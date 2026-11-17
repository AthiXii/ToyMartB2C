using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToyMartB2C
{
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
        {
            InitializeComponent();
            Theme.Apply(this);
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome, " + Session.UserName + " (" + Session.Role + ")";
            LoadStats();
        }
        private void LoadStats()
        {
            var dt = Db.Query(
                "SELECT " +
                "(SELECT COUNT(*) FROM orders WHERE status = 'Pending') AS Pending, " +
                "(SELECT COUNT(*) FROM orders) AS Orders, " +
                "(SELECT COUNT(*) FROM products WHERE stock <= 5) AS LowStock, " +
                "(SELECT COUNT(*) FROM users WHERE role = 'customer') AS Customers, " +
                "(SELECT ISNULL(SUM(total), 0) FROM orders WHERE status <> 'Cancelled') AS Sales");
            var r = dt.Rows[0];
            lblStats.Text =
                "Pending orders: " + r["Pending"] + "     Total orders: " + r["Orders"] + "\n" +
                "Low-stock products (5 or less): " + r["LowStock"] + "     Customers: " + r["Customers"] + "\n" +
                "Total sales: ₱" + ((decimal)r["Sales"]).ToString("N2");
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            this.Close();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            new OrderManagementForm().ShowDialog();
            LoadStats();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            new UserManagementForm().ShowDialog();
            LoadStats();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            new ReportsForm().ShowDialog();
        }

        private void btnInventory_Click_1(object sender, EventArgs e)
        {
            new InventoryForm().ShowDialog();
            LoadStats();
        }
    }
}
