using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToyMartB2C
{
    public partial class ProductCatalogForm : Form
    {
        private bool ready = false;
        public ProductCatalogForm()
        {
            InitializeComponent();
            Theme.Apply(this);
        }


        private void ProductCatalogForm_Load(object sender, EventArgs e)
        {
            var cats = Db.Query("SELECT category_id, name FROM categories ORDER BY name");
            var all = cats.NewRow();
            all["category_id"] = 0;
            all["name"] = "All Categories";
            cats.Rows.InsertAt(all, 0);

            cboCategory.DataSource = cats;
            cboCategory.DisplayMember = "name";
            cboCategory.ValueMember = "category_id";
            cboCategory.SelectedIndex = 0;

            ready = true;
            LoadProducts();
            UpdateHeader();
        }
        private void ClearCards()
        {
            foreach (Control card in flpProducts.Controls)
                foreach (Control c in card.Controls)
                    if (c is PictureBox pb) pb.Image?.Dispose();
            flpProducts.Controls.Clear();
        }

        private void LoadProducts()
        {
            if (!ready) return;

            int catId = Convert.ToInt32(cboCategory.SelectedValue);
            var dt = Db.Query(
                "SELECT product_id, name, price, stock, image_path FROM products " +
                "WHERE name LIKE @s AND (@c = 0 OR category_id = @c) ORDER BY name",
                new SqlParameter("@s", "%" + txtSearch.Text.Trim() + "%"),
                new SqlParameter("@c", catId));

            flpProducts.SuspendLayout();
            ClearCards();

            foreach (DataRow r in dt.Rows)
            {
                int id = (int)r["product_id"];
                int stock = (int)r["stock"];
                string img = r["image_path"] == DBNull.Value ? "" : r["image_path"].ToString()!;

                var card = new Panel
                {
                    Width = 210,
                    Height = 300,
                    Margin = new Padding(10),
                    BorderStyle = BorderStyle.None,
                    BackColor = Color.White
                };
                Theme.RoundPanel(card);

                var pic = new PictureBox
                {
                    Left = 15,
                    Top = 10,
                    Width = 178,
                    Height = 150,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    BackColor = Color.WhiteSmoke,
                    Image = imagePrep.Load(img)
                };

                var lblName = new Label
                {
                    Left = 10,
                    Top = 168,
                    Width = 188,
                    Height = 40,
                    Text = r["name"].ToString(),
                    Font = new Font("Segoe UI", 10, FontStyle.Bold)
                };

                var lblPrice = new Label
                {
                    Left = 10,
                    Top = 210,
                    Width = 188,
                    Height = 22,
                    Text = "₱" + ((decimal)r["price"]).ToString("N2"),
                    Font = new Font("Segoe UI", 11, FontStyle.Bold),
                    ForeColor = ColorTranslator.FromHtml("#D81B60")
                };

                var lblStock = new Label
                {
                    Left = 10,
                    Top = 234,
                    Width = 188,
                    Height = 20,
                    Text = stock > 0 ? "In stock: " + stock : "Out of stock",
                    ForeColor = stock > 0 ? Color.Gray : Color.Firebrick
                };

                var btn = new Button
                {
                    Left = 10,
                    Top = 260,
                    Width = 188,
                    Height = 30,
                    Text = stock > 0 ? "Add to Cart" : "Unavailable",
                    Enabled = stock > 0,
                    FlatStyle = FlatStyle.Flat
                };
                Theme.StyleButton(btn);
                btn.Click += (s, args) => AddToCart(id);

                card.Controls.AddRange(new Control[] { pic, lblName, lblPrice, lblStock, btn });
                flpProducts.Controls.Add(card);
            }

            flpProducts.ResumeLayout();
        }

        private void AddToCart(int productId)
        {
            if (!RequireLogin()) return;
            var p = Db.Query("SELECT name, stock FROM products WHERE product_id = @p",
                new SqlParameter("@p", productId));
            if (p.Rows.Count == 0) return;
            int stock = (int)p.Rows[0]["stock"];
            string name = p.Rows[0]["name"].ToString()!;

            var c = Db.Query("SELECT cart_id, quantity FROM cart WHERE user_id = @u AND product_id = @p",
                new SqlParameter("@u", Session.UserId),
                new SqlParameter("@p", productId));

            if (c.Rows.Count > 0)
            {
                int qty = (int)c.Rows[0]["quantity"];
                if (qty + 1 > stock)
                {
                    MessageBox.Show("Only " + stock + " of \"" + name + "\" available, and you already have " + qty + " in your cart.", "Not enough stock");
                    return;
                }
                Db.Execute("UPDATE cart SET quantity = quantity + 1 WHERE cart_id = @id",
                    new SqlParameter("@id", (int)c.Rows[0]["cart_id"]));
            }
            else
            {
                Db.Execute("INSERT INTO cart (user_id, product_id, quantity) VALUES (@u, @p, 1)",
                    new SqlParameter("@u", Session.UserId),
                    new SqlParameter("@p", productId));
            }
            MessageBox.Show("\"" + name + "\" added to your cart.", "Added");
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }
        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void UpdateHeader()
        {
            lblUser.Text = Session.IsLoggedIn ? "Hi, " + Session.UserName : "Browsing as guest";
            btnLogin.Visible = !Session.IsLoggedIn;
            btnAccount.Visible = Session.IsLoggedIn;
            btnLogout.Visible = Session.IsLoggedIn;
        }

        private bool OpenLogin()
        {
            using var login = new LoginForm();
            if (login.ShowDialog() != DialogResult.OK) return false;

            if (Session.Role == "admin" || Session.Role == "service")
            {
                OpenStaffDashboard();
                return false;
            }
            UpdateHeader();
            return true;
        }
        private void OpenStaffDashboard()
        {
            this.Hide();
            using Form dash = Session.Role == "admin"
                ? new AdminDashboardForm()
                : new ServiceDashboardForm();
            dash.ShowDialog();

            Session.Clear();
            UpdateHeader();
            this.Show();
        }

        private bool RequireLogin()
        {
            if (Session.IsLoggedIn) return true;
            MessageBox.Show("Please log in to continue.", "Login required");
            return OpenLogin();
        }

        private void btnAccount_Click_1(object sender, EventArgs e)
        {
            new UserDashboardForm().ShowDialog();
            UpdateHeader();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            OpenLogin();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            Session.Clear();
            UpdateHeader();
            MessageBox.Show("You have been logged out.", "Goodbye");
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            if (!RequireLogin()) return;
            new CartForm().ShowDialog();
        }
    }

}
