using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace ToyMartB2C
{
    public partial class InventoryForm : Form
    {
        private int selectedId = 0;
        private string currentImage = "";
        private string pendingSource = "";
        public InventoryForm()
        {
            InitializeComponent();
            Theme.Apply(this);
        }
        private void InventoryForm_Load(object sender, EventArgs e)
        {
            var source = Db.Query("SELECT category_id, name FROM categories ORDER BY name");
            cboCategory.DataSource = source;
            cboCategory.DisplayMember = "name";
            cboCategory.ValueMember = "category_id";
            LoadProducts();
        }
        private void ClearInputs()
        {
            selectedId = 0;
            pendingSource = "";
            currentImage = "";
            txtName.Clear(); txtDescription.Clear(); txtPrice.Clear(); txtStock.Clear();
            if (cboCategory.Items.Count > 0) cboCategory.SelectedIndex = 0;
            ShowImage();
        }

        private void LoadProducts()
        {
            var dt = Db.Query(
        "SELECT p.product_id, p.name, p.description, p.price, p.stock, " +
        "c.name AS category, p.category_id, p.image_path " +
        "FROM products p LEFT JOIN categories c ON p.category_id = c.category_id " +
        "WHERE p.name LIKE @s ORDER BY p.name",
        new SqlParameter("@s", "%" + txtSearch.Text.Trim() + "%"));
            dgvProducts.DataSource = dt;
            dgvProducts.Columns["category_id"].Visible = false;
            dgvProducts.Columns["image_path"].Visible = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvProducts.Rows[e.RowIndex];
            selectedId = (int)row.Cells["product_id"].Value;
            txtName.Text = row.Cells["name"].Value.ToString();
            txtDescription.Text = row.Cells["description"].Value.ToString();
            txtPrice.Text = row.Cells["price"].Value.ToString();
            txtStock.Text = row.Cells["stock"].Value.ToString();
            if (row.Cells["category_id"].Value != DBNull.Value)
                cboCategory.SelectedValue = row.Cells["category_id"].Value;

            pendingSource = "";
            currentImage = row.Cells["image_path"].Value == DBNull.Value
                ? "" : row.Cells["image_path"].Value.ToString()!;
            ShowImage();
        }

        private bool ValidateProduct(out decimal price, out int stock)
        {
            price = 0; stock = 0;
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Product name is required.", "Missing information");
                return false;
            }
            if (!decimal.TryParse(txtPrice.Text, out price) || price <= 0)
            {
                MessageBox.Show("Price must be a number greater than zero.", "Invalid price");
                return false;
            }
            if (!int.TryParse(txtStock.Text, out stock) || stock < 0)
            {
                MessageBox.Show("Stock must be a whole number, zero or more.", "Invalid stock");
                return false;
            }
            if (cboCategory.SelectedValue == null)
            {
                MessageBox.Show("Please choose a category.", "Missing information");
                return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateProduct(out decimal price, out int stock)) return;
            Db.Execute(
                "INSERT INTO products (name, description, price, stock, category_id, image_path) " +
                "VALUES (@n, @d, @p, @s, @c, @i)",
                new SqlParameter("@n", txtName.Text.Trim()),
                new SqlParameter("@d", txtDescription.Text.Trim()),
                new SqlParameter("@p", price),
                new SqlParameter("@s", stock),
                new SqlParameter("@c", cboCategory.SelectedValue),
                new SqlParameter("@i", ImageToSave()));
            MessageBox.Show("Product added.", "Success");
            ClearInputs();
            LoadProducts();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Click a product in the list first.", "No product selected");
                return;
            }
            if (!ValidateProduct(out decimal price, out int stock)) return;
            Db.Execute(
                "UPDATE products SET name=@n, description=@d, price=@p, stock=@s, " +
                "category_id=@c, image_path=@i WHERE product_id=@id",
                new SqlParameter("@n", txtName.Text.Trim()),
                new SqlParameter("@d", txtDescription.Text.Trim()),
                new SqlParameter("@p", price),
                new SqlParameter("@s", stock),
                new SqlParameter("@c", cboCategory.SelectedValue),
                new SqlParameter("@i", ImageToSave()),
                new SqlParameter("@id", selectedId));
            MessageBox.Show("Product updated.", "Success");
            ClearInputs();
            LoadProducts();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Click a product in the list first.", "No product selected");
                return;
            }
            if (MessageBox.Show("Delete this product?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;

            try
            {
                Db.Execute("DELETE FROM cart WHERE product_id = @id", new SqlParameter("@id", selectedId));
                Db.Execute("DELETE FROM products WHERE product_id = @id", new SqlParameter("@id", selectedId));
                ClearInputs();
                LoadProducts();
            }
            catch
            {
                MessageBox.Show("This product is part of past orders and can't be deleted. " +
                                "Set its stock to 0 instead.", "Cannot delete");
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowImage()
        {
            picProduct.Image?.Dispose();
            if (pendingSource != "")
            {
                using var fs = new FileStream(pendingSource, FileMode.Open, FileAccess.Read);
                using var img = Image.FromStream(fs);
                picProduct.Image = new Bitmap(img);
            }
            else
            {
                picProduct.Image = imagePrep.Load(currentImage);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using var dlg = new OpenFileDialog();
            dlg.Title = "Choose a product image";
            dlg.Filter = "Images|*.jpg;*.jpeg;*.png;*.bmp";
            if (dlg.ShowDialog() != DialogResult.OK) return;

            if (new FileInfo(dlg.FileName).Length > 5 * 1024 * 1024)
            {
                MessageBox.Show("Please choose an image smaller than 5 MB.", "Image too large");
                return;
            }
            pendingSource = dlg.FileName;
            ShowImage();
        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            pendingSource = "";
            currentImage = "";
            ShowImage();
        }
        private string ImageToSave()
        {
            if (pendingSource != "") return imagePrep.Save(pendingSource);
            return currentImage;
        }
    }
}
