using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace ToyMartB2C
{
    public partial class ReportsForm : Form
    {
        private bool ready = false;

        public ReportsForm()
        {
            InitializeComponent();
            Theme.Apply(this);
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Today.AddDays(-30);
            dtpTo.Value = DateTime.Today;

            var staff = Db.Query(
                "SELECT user_id, username FROM users WHERE role IN ('service','admin') ORDER BY username");
            var all = staff.NewRow();
            all["user_id"] = 0;
            all["username"] = "All staff";
            staff.Rows.InsertAt(all, 0);
            cboStaff.DataSource = staff;
            cboStaff.DisplayMember = "username";
            cboStaff.ValueMember = "user_id";

            ready = true;
            GenerateReport();
        }

        private void GenerateReport()
        {
            if (!ready) return;

            DateTime from = dtpFrom.Value.Date;
            DateTime to = dtpTo.Value.Date.AddDays(1);
            int staffId = Convert.ToInt32(cboStaff.SelectedValue);

            if (from >= to)
            {
                MessageBox.Show("The start date must be before the end date.", "Invalid dates");
                return;
            }

            // Summary
            var s = Db.Query(
                "SELECT " +
                "(SELECT COUNT(*) FROM inquiries WHERE created_at >= @f AND created_at < @t) AS Received, " +
                "(SELECT COUNT(*) FROM inquiries WHERE handled_at >= @f AND handled_at < @t " +
                "   AND (@s = 0 OR handled_by = @s)) AS Handled, " +
                "(SELECT COUNT(*) FROM inquiries WHERE handled_at >= @f AND handled_at < @t " +
                "   AND status = 'Resolved' AND (@s = 0 OR handled_by = @s)) AS Resolved, " +
                "(SELECT COUNT(*) FROM inquiries WHERE status = 'Open') AS StillOpen, " +
                "(SELECT AVG(DATEDIFF(MINUTE, created_at, handled_at)) FROM inquiries " +
                "   WHERE handled_at >= @f AND handled_at < @t AND (@s = 0 OR handled_by = @s)) AS AvgMin",
                new SqlParameter("@f", from), new SqlParameter("@t", to),
                new SqlParameter("@s", staffId));
            var r = s.Rows[0];

            string avg = r["AvgMin"] == DBNull.Value
                ? "n/a"
                : (Convert.ToInt32(r["AvgMin"]) >= 60
                    ? (Convert.ToInt32(r["AvgMin"]) / 60.0).ToString("0.0") + " hours"
                    : Convert.ToInt32(r["AvgMin"]) + " minutes");

            lblSummary.Text =
                "Report: " + from.ToString("MMM dd, yyyy") + " to " + dtpTo.Value.ToString("MMM dd, yyyy") +
                "   |   Staff: " + cboStaff.Text + "\n" +
                "Inquiries received: " + r["Received"] + "     Handled: " + r["Handled"] +
                "     Resolved: " + r["Resolved"] + "\n" +
                "Currently open (all dates): " + r["StillOpen"] + "     Average response time: " + avg;

            // Per-staff summary
            dgvStaff.DataSource = Db.Query(
                "SELECT u.username AS Staff, u.role AS Role, COUNT(*) AS Handled, " +
                "SUM(CASE WHEN i.status = 'Resolved' THEN 1 ELSE 0 END) AS Resolved, " +
                "AVG(DATEDIFF(MINUTE, i.created_at, i.handled_at)) AS [Avg Minutes] " +
                "FROM inquiries i JOIN users u ON i.handled_by = u.user_id " +
                "WHERE i.handled_at >= @f AND i.handled_at < @t AND (@s = 0 OR i.handled_by = @s) " +
                "GROUP BY u.username, u.role ORDER BY Handled DESC",
                new SqlParameter("@f", from), new SqlParameter("@t", to),
                new SqlParameter("@s", staffId));
            dgvStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Each handled inquiry
            dgvDetails.DataSource = Db.Query(
                "SELECT i.inquiry_id AS No, c.username AS Customer, i.subject AS Subject, " +
                "i.status AS Status, h.username AS [Handled By], i.handled_at AS [Handled On] " +
                "FROM inquiries i " +
                "JOIN users c ON i.user_id = c.user_id " +
                "JOIN users h ON i.handled_by = h.user_id " +
                "WHERE i.handled_at >= @f AND i.handled_at < @t AND (@s = 0 OR i.handled_by = @s) " +
                "ORDER BY i.handled_at DESC",
                new SqlParameter("@f", from), new SqlParameter("@t", to),
                new SqlParameter("@s", staffId));
            dgvDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (dgvDetails.Columns.Contains("Handled On"))
                dgvDetails.Columns["Handled On"].DefaultCellStyle.Format = "MMM dd, yyyy h:mm tt";
        }

        private void cboStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateReport();
        }


        private void btnGenerate_Click_1(object sender, EventArgs e)
        {
            GenerateReport();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}