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
    public partial class CheckoutForm : Form
    {
        private readonly DeliveryInfoForm infoForm;
        private bool goingBack = false;
        private decimal total = 0;

        public CheckoutForm(DeliveryInfoForm info)
        {
            InitializeComponent();
            infoForm = info;
        }

        private void CheckoutForm_Load(object sender, EventArgs e)
        {
            lblRecipient.Text = "Recipient: " + CheckoutInfo.Recipient;
            lblContact.Text = "Contact: " + CheckoutInfo.Contact;
            lblAddress.Text = "Deliver to: " + CheckoutInfo.FullAddress;
            lblPayment.Text = "Payment: " + CheckoutInfo.Payment;

            var dt = Db.Query(
       "SELECT p.product_id, p.name AS Product, p.price AS Price, c.quantity AS Qty, " +
       "p.price * c.quantity AS Subtotal " +
       "FROM cart c JOIN products p ON c.product_id = p.product_id " +
       "WHERE c.user_id = @u",
       new SqlParameter("@u", Session.UserId));
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Your cart is empty.", "Nothing to check out");
                this.Close();
                return;
            }

            dgvItems.DataSource = dt;
            dgvItems.Columns["product_id"].Visible = false;

            total = 0;
            foreach (DataRow r in dt.Rows) total += (decimal)r["Subtotal"];
            lblTotal.Text = "Total: ₱" + total.ToString("N2");
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            goingBack = true;
            infoForm.Show();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            using var conn = new SqlConnection(Db.connStr);
            conn.Open();
            using var tx = conn.BeginTransaction();

            try
            {
                var cmd = new SqlCommand(
                    "INSERT INTO orders (user_id, total, payment_method, recipient_name, contact_no, " +
                    "province, city, barangay, street, postal_code) " +
                    "VALUES (@u, @t, @pm, @rn, @cn, @pr, @ci, @ba, @st, @po); " +
                    "SELECT CAST(SCOPE_IDENTITY() AS INT);", conn, tx);
                cmd.Parameters.AddWithValue("@u", Session.UserId);
                cmd.Parameters.AddWithValue("@t", total);
                cmd.Parameters.AddWithValue("@pm", CheckoutInfo.Payment);
                cmd.Parameters.AddWithValue("@rn", CheckoutInfo.Recipient);
                cmd.Parameters.AddWithValue("@cn", CheckoutInfo.Contact);
                cmd.Parameters.AddWithValue("@pr", CheckoutInfo.Province);
                cmd.Parameters.AddWithValue("@ci", CheckoutInfo.City);
                cmd.Parameters.AddWithValue("@ba", CheckoutInfo.Barangay);
                cmd.Parameters.AddWithValue("@st", CheckoutInfo.Street);
                cmd.Parameters.AddWithValue("@po", CheckoutInfo.Postal);
                int orderId = (int)cmd.ExecuteScalar();

                foreach (DataGridViewRow row in dgvItems.Rows)
                {
                    int productId = (int)row.Cells["product_id"].Value;
                    int qty = (int)row.Cells["Qty"].Value;
                    decimal price = (decimal)row.Cells["Price"].Value;

                    var d = new SqlCommand(
                        "INSERT INTO order_details (order_id, product_id, quantity, unit_price) " +
                        "VALUES (@o, @p, @q, @pr)", conn, tx);
                    d.Parameters.AddWithValue("@o", orderId);
                    d.Parameters.AddWithValue("@p", productId);
                    d.Parameters.AddWithValue("@q", qty);
                    d.Parameters.AddWithValue("@pr", price);
                    d.ExecuteNonQuery();

                    var s = new SqlCommand(
                        "UPDATE products SET stock = stock - @q WHERE product_id = @p AND stock >= @q",
                        conn, tx);
                    s.Parameters.AddWithValue("@q", qty);
                    s.Parameters.AddWithValue("@p", productId);
                    if (s.ExecuteNonQuery() == 0)
                        throw new Exception("Not enough stock for: " + row.Cells["Product"].Value);
                }

                var c = new SqlCommand("DELETE FROM cart WHERE user_id = @u", conn, tx);
                c.Parameters.AddWithValue("@u", Session.UserId);
                c.ExecuteNonQuery();

                tx.Commit();

                CheckoutInfo.LastOrderId = orderId;
                MessageBox.Show("Order placed! Order #" + orderId, "Success");

                goingBack = false;
                this.Close();                 
               // new RewardsForm().Show();  
            }
            catch (Exception ex)
            {
                tx.Rollback();
                MessageBox.Show("Order failed: " + ex.Message, "Error");
            }
        }
        private void CheckoutForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!goingBack) infoForm.Close();
        }
    }
    }
