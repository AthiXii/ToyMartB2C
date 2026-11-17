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
    public partial class ServiceDashboardForm : Form
    {
        public bool FromAdmin { get; set; } = false;
        private bool ready = false;
        private bool busy = false;
        public ServiceDashboardForm()
        {
            InitializeComponent();
            Theme.Apply(this);

        }

        private void ServiceDashboardForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome, " + Session.UserName + " (" + Session.Role + ")";
            cboFilter.Items.AddRange(new object[] { "Open", "Resolved", "All" });
            cboFilter.SelectedIndex = 0;

            ready = true;
            LoadInquiries();
        }
        private void LoadInquiries()
        {
            if (!ready) return;
            busy = true;

            int keepId = SelectedInquiryId();

            var dt = Db.Query(
                "SELECT i.inquiry_id AS No, i.created_at AS Date, u.username AS Customer, " +
                "i.subject AS Subject, i.status AS Status " +
                "FROM inquiries i JOIN users u ON i.user_id = u.user_id " +
                "WHERE (@f = 'All' OR i.status = @f) ORDER BY i.created_at DESC",
             new SqlParameter("@f", cboFilter.SelectedItem?.ToString() ?? "All"));

            dgvInquiries.DataSource = dt;
            dgvInquiries.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            foreach (DataGridViewRow row in dgvInquiries.Rows)
            {
                if ((int)row.Cells["No"].Value == keepId)
                {
                    dgvInquiries.CurrentCell = row.Cells["No"];
                    break;
                }
            }

            busy = false;
            ShowDetails();
        }
        private int SelectedInquiryId()
        {
            if (dgvInquiries.CurrentRow == null) return 0;
            return (int)dgvInquiries.CurrentRow.Cells["No"].Value;
        }
        private void ShowDetails()
        {
            if (busy) return;
            int id = SelectedInquiryId();
            if (id == 0)
            {
                lblCustomer.Text = "";
                txtMessage.Text = "";
                txtReply.Text = "";
                return;
            }

            var dt = Db.Query(
                "SELECT u.full_name, u.username, i.order_id, i.message, i.response " +
                "FROM inquiries i JOIN users u ON i.user_id = u.user_id " +
                "WHERE i.inquiry_id = @i",
                new SqlParameter("@i", id));
            if (dt.Rows.Count == 0) return;
            var r = dt.Rows[0];

            string who = r["full_name"] == DBNull.Value || r["full_name"].ToString() == ""
                ? r["username"].ToString()! : r["full_name"].ToString()!;
            string order = r["order_id"] == DBNull.Value ? "" : "   |   Order #" + r["order_id"];
            lblCustomer.Text = "From: " + who + order;
            txtMessage.Text = r["message"].ToString();
            txtReply.Text = r["response"] == DBNull.Value ? "" : r["response"].ToString();
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            this.Close();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            new InventoryForm().ShowDialog();
        }

        private void dgvInquiries_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!ready || busy) return;
            ShowDetails();
        }

        private void cboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!ready) return;
            LoadInquiries();
        }

        private void SaveReply(bool resolve)
        {
            int id = SelectedInquiryId();
            if (id == 0)
            {
                MessageBox.Show("Click an inquiry in the list first.", "No inquiry selected");
                return;
            }
            if (txtReply.Text.Trim() == "")
            {
                MessageBox.Show("Please type a reply first.", "Empty reply");
                return;
            }
            Db.Execute(
                "UPDATE inquiries SET response = @r, status = @s, handled_by = @h, handled_at = GETDATE() " +
                "WHERE inquiry_id = @i",
                new SqlParameter("@r", txtReply.Text.Trim()),
                new SqlParameter("@s", resolve ? "Resolved" : "Open"),
                new SqlParameter("@h", Session.UserId),
                new SqlParameter("@i", id));
            MessageBox.Show(resolve ? "Reply sent and inquiry resolved." : "Reply saved.", "Done");
            LoadInquiries();
        }

        private void btnSaveReply_Click(object sender, EventArgs e)
        {
            SaveReply(false);
        }

        private void btnResolve_Click(object sender, EventArgs e)
        {
            SaveReply(true);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadInquiries();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            new OrderManagementForm().ShowDialog();
        }
    }
}
