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
    public partial class UserDashboardForm : Form
    {
        public UserDashboardForm()
        {

            InitializeComponent();
            LoadOrderChoices();
            LoadInquiries();
            LoadOrders();
            Theme.Apply(this);
        }
        private void LoadOrderChoices()
        {
            var dt = Db.Query(
                "SELECT order_id, 'Order #' + CAST(order_id AS NVARCHAR(10)) AS label " +
                "FROM orders WHERE user_id = @u ORDER BY order_id DESC",
                new SqlParameter("@u", Session.UserId));

            var none = dt.NewRow();
            none["order_id"] = 0;
            none["label"] = "(No specific order)";
            dt.Rows.InsertAt(none, 0);

            cboOrder.DataSource = dt;
            cboOrder.DisplayMember = "label";
            cboOrder.ValueMember = "order_id";
        }

        private void LoadInquiries()
        {
            dgvInquiries.DataSource = Db.Query(
                "SELECT inquiry_id AS No, created_at AS Date, subject AS Subject, " +
                "status AS Status, response AS Reply " +
                "FROM inquiries WHERE user_id = @u ORDER BY created_at DESC",
                new SqlParameter("@u", Session.UserId));
            dgvInquiries.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void UserDashboardForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome, " + Session.UserName + " (" + Session.Role + ")";
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            this.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtSubject.Text.Trim() == "" || txtMessage.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a subject and a message.", "Missing information");
                return;
            }

            int orderId = Convert.ToInt32(cboOrder.SelectedValue);
            Db.Execute(
                "INSERT INTO inquiries (user_id, order_id, subject, message) VALUES (@u, @o, @s, @m)",
                new SqlParameter("@u", Session.UserId),
                new SqlParameter("@o", orderId == 0 ? DBNull.Value : orderId),
                new SqlParameter("@s", txtSubject.Text.Trim()),
                new SqlParameter("@m", txtMessage.Text.Trim()));

            txtSubject.Clear();
            txtMessage.Clear();
            cboOrder.SelectedIndex = 0;
            LoadInquiries();
            MessageBox.Show("Your inquiry was sent. We'll reply here soon.", "Sent");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using var f = new DeliveryInfoForm { ProfileMode = true };
            if (f.ShowDialog() == DialogResult.OK)
                MessageBox.Show("Your delivery details have been saved.", "Saved");
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            using var cart = new CartForm();
            cart.ShowDialog();
        }
        private void LoadOrders()
        {
            dgvOrders.DataSource = Db.Query(
                "SELECT order_id AS OrderNo, order_date AS Date, total AS Total, " +
                "payment_method AS Payment, status AS Status " +
                "FROM orders WHERE user_id = @u ORDER BY order_date DESC",
                new SqlParameter("@u", Session.UserId));

            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (dgvOrders.Columns.Contains("Total"))
                dgvOrders.Columns["Total"].DefaultCellStyle.Format = "N2";
            if (dgvOrders.Columns.Contains("Date"))
                dgvOrders.Columns["Date"].DefaultCellStyle.Format = "MMM dd, yyyy h:mm tt";
        }

        private void dgvOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow == null) return;
            int id = (int)dgvOrders.CurrentRow.Cells["OrderNo"].Value;

            dgvOrderItems.DataSource = Db.Query(
                "SELECT p.name AS Product, od.quantity AS Qty, od.unit_price AS Price, " +
                "od.quantity * od.unit_price AS Subtotal " +
                "FROM order_details od JOIN products p ON od.product_id = p.product_id " +
                "WHERE od.order_id = @o",
                new SqlParameter("@o", id));

            dgvOrderItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderItems.Columns["Price"].DefaultCellStyle.Format = "N2";
            dgvOrderItems.Columns["Subtotal"].DefaultCellStyle.Format = "N2";
        }
    }
}
