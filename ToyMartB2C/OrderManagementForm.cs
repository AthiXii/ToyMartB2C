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
    public partial class OrderManagementForm : Form
    {
        public OrderManagementForm()
        {
            InitializeComponent();
            Theme.Apply(this);
        }

        private bool ready = false;
        private readonly string[] statuses =
            { "Pending", "Processing", "Shipped", "Delivered", "Cancelled" };

        private void OrderManagementForm_Load(object sender, EventArgs e)
        {
            cboFilter.Items.Add("All");
            cboFilter.Items.AddRange(statuses);
            cboFilter.SelectedIndex = 0;

            cboStatus.Items.AddRange(statuses);

            ready = true;
            LoadOrders();
        }

        private void LoadOrders()
        {
            if (!ready) return;

            int keepId = SelectedOrderId();

            var dt = Db.Query(
                "SELECT o.order_id AS OrderNo, o.order_date AS Date, u.username AS Customer, " +
                "o.total AS Total, o.payment_method AS Payment, o.status AS Status " +
                "FROM orders o JOIN users u ON o.user_id = u.user_id " +
                "WHERE (@f = 'All' OR o.status = @f) ORDER BY o.order_date DESC",
                new SqlParameter("@f", cboFilter.Text));

            dgvOrders.DataSource = dt;
            dgvOrders.Columns["Total"].DefaultCellStyle.Format = "N2";
            dgvOrders.Columns["Date"].DefaultCellStyle.Format = "MMM dd, yyyy h:mm tt";

            // Keep the same order selected after refreshing
            foreach (DataGridViewRow row in dgvOrders.Rows)
            {
                if ((int)row.Cells["OrderNo"].Value == keepId)
                {
                    row.Selected = true;
                    dgvOrders.CurrentCell = row.Cells["OrderNo"];
                    break;
                }
            }
            ShowDetails();
        }

        private int SelectedOrderId()
        {
            if (dgvOrders.CurrentRow == null) return 0;
            return (int)dgvOrders.CurrentRow.Cells["OrderNo"].Value;
        }

        private void ShowDetails()
        {
            int id = SelectedOrderId();
            if (id == 0)
            {
                dgvItems.DataSource = null;
                lblRecipient.Text = lblContact.Text = lblAddress.Text = lblPayment.Text = "";
                cboStatus.SelectedIndex = -1;
                return;
            }

            var o = Db.Query(
                "SELECT recipient_name, contact_no, province, city, barangay, street, " +
                "postal_code, payment_method, status FROM orders WHERE order_id = @o",
                new SqlParameter("@o", id));
            if (o.Rows.Count == 0) return;
            var r = o.Rows[0];

            lblRecipient.Text = "Recipient: " + r["recipient_name"];
            lblContact.Text = "Contact: " + r["contact_no"];
            lblAddress.Text = "Deliver to: " + r["street"] + ", Brgy. " + r["barangay"] + ", " +
                              r["city"] + ", " + r["province"] + " " + r["postal_code"];
            lblPayment.Text = "Payment: " + r["payment_method"];
            cboStatus.SelectedItem = r["status"].ToString();

            dgvItems.DataSource = Db.Query(
                "SELECT p.name AS Product, od.quantity AS Qty, od.unit_price AS Price, " +
                "od.quantity * od.unit_price AS Subtotal " +
                "FROM order_details od JOIN products p ON od.product_id = p.product_id " +
                "WHERE od.order_id = @o",
                new SqlParameter("@o", id));
            dgvItems.Columns["Price"].DefaultCellStyle.Format = "N2";
            dgvItems.Columns["Subtotal"].DefaultCellStyle.Format = "N2";
        }

        private void dgvOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (!ready) return;
            ShowDetails();
        }

        private void cboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            int id = SelectedOrderId();
            if (id == 0)
            {
                MessageBox.Show("Click an order in the list first.", "No order selected");
                return;
            }
            if (cboStatus.SelectedItem == null)
            {
                MessageBox.Show("Choose a new status.", "No status selected");
                return;
            }

            string newStatus = cboStatus.SelectedItem.ToString()!;
            string oldStatus = dgvOrders.CurrentRow!.Cells["Status"].Value.ToString()!;

            if (newStatus == oldStatus)
            {
                MessageBox.Show("The order already has that status.", "No change");
                return;
            }
            if (oldStatus == "Cancelled")
            {
                MessageBox.Show("A cancelled order can't be changed.", "Not allowed");
                return;
            }
            if (oldStatus == "Delivered" && newStatus == "Cancelled")
            {
                MessageBox.Show("A delivered order can't be cancelled.", "Not allowed");
                return;
            }
            if (newStatus == "Cancelled" &&
                MessageBox.Show("Cancel this order and return its items to stock?", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;

            using var conn = new SqlConnection(Db.connStr);
            conn.Open();
            using var tx = conn.BeginTransaction();
            try
            {
                if (newStatus == "Cancelled")
                {
                    // Put the stock back
                    var restock = new SqlCommand(
                        "UPDATE p SET p.stock = p.stock + od.quantity " +
                        "FROM products p JOIN order_details od ON p.product_id = od.product_id " +
                        "WHERE od.order_id = @o", conn, tx);
                    restock.Parameters.AddWithValue("@o", id);
                    restock.ExecuteNonQuery();
                }

                var upd = new SqlCommand("UPDATE orders SET status = @s WHERE order_id = @o", conn, tx);
                upd.Parameters.AddWithValue("@s", newStatus);
                upd.Parameters.AddWithValue("@o", id);
                upd.ExecuteNonQuery();

                tx.Commit();
                MessageBox.Show("Order #" + id + " is now " + newStatus + ".", "Updated");
                LoadOrders();
            }
            catch (Exception ex)
            {
                tx.Rollback();
                MessageBox.Show("Could not update the order: " + ex.Message, "Error");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
