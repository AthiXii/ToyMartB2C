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
    public partial class CartForm : Form
    {
        public CartForm()
        {
            InitializeComponent();
        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            LoadCart();
        }
        private void LoadCart()
        {
            var dt = Db.Query(
                "SELECT c.cart_id, c.product_id, p.name AS Product, p.price AS Price, " +
                "c.quantity AS Qty, p.stock AS Stock, p.price * c.quantity AS Subtotal " +
                "FROM cart c JOIN products p ON c.product_id = p.product_id " +
                "WHERE c.user_id = @u ORDER BY p.name",
                new SqlParameter("@u", Session.UserId));

            dgvCart.DataSource = dt;
            dgvCart.Columns["cart_id"].Visible = false;
            dgvCart.Columns["product_id"].Visible = false;
            dgvCart.Columns["Stock"].Visible = false;
            dgvCart.Columns["Price"].DefaultCellStyle.Format = "N2";
            dgvCart.Columns["Subtotal"].DefaultCellStyle.Format = "N2";

            decimal total = 0;
            foreach (DataRow r in dt.Rows) total += (decimal)r["Subtotal"];
            lblTotal.Text = "Total: ₱" + total.ToString("N2");
        }
        private DataGridViewRow? SelectedRow()
        {
            if (dgvCart.CurrentRow == null)
            {
                MessageBox.Show("Click an item in the cart first.", "No item selected");
                return null;
            }
            return dgvCart.CurrentRow;
        }


        private void btnPlus_Click_1(object sender, EventArgs e)
        {
            var row = SelectedRow();
            if (row == null) return;

            int qty = (int)row.Cells["Qty"].Value;
            int stock = (int)row.Cells["Stock"].Value;
            if (qty + 1 > stock)
            {
                MessageBox.Show("Only " + stock + " in stock.", "Not enough stock");
                return;
            }
            Db.Execute("UPDATE cart SET quantity = quantity + 1 WHERE cart_id = @id",
                new SqlParameter("@id", (int)row.Cells["cart_id"].Value));
            LoadCart();
        }

        private void btnMinus_Click_1(object sender, EventArgs e)
        {
            var row = SelectedRow();
            if (row == null) return;

            int qty = (int)row.Cells["Qty"].Value;
            int id = (int)row.Cells["cart_id"].Value;
            if (qty <= 1)
            {
                Db.Execute("DELETE FROM cart WHERE cart_id = @id", new SqlParameter("@id", id));
            }
            else
            {
                Db.Execute("UPDATE cart SET quantity = quantity - 1 WHERE cart_id = @id",
                    new SqlParameter("@id", id));
            }
            LoadCart();
        }

        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            var row = SelectedRow();
            if (row == null) return;

            if (MessageBox.Show("Remove this item from your cart?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            Db.Execute("DELETE FROM cart WHERE cart_id = @id",
                new SqlParameter("@id", (int)row.Cells["cart_id"].Value));
            LoadCart();
        }

        private void btnCheckout_Click_1(object sender, EventArgs e)
        {
            if (dgvCart.Rows.Count == 0)
            {
                MessageBox.Show("Your cart is empty.", "Nothing to check out");
                return;
            }
            foreach (DataGridViewRow r in dgvCart.Rows)
            {
                if ((int)r.Cells["Qty"].Value > (int)r.Cells["Stock"].Value)
                {
                    MessageBox.Show("Not enough stock for \"" + r.Cells["Product"].Value +
                        "\". Please lower the quantity.", "Stock changed");
                    return;
                }
            }

            var info = new DeliveryInfoForm();
            this.Hide();
            info.ShowDialog();
            this.Close();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
