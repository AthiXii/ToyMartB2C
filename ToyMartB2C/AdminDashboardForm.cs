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
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome, " + Session.UserName + " (" + Session.Role + ")";
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            new InventoryForm().ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            this.Close();
        }
    }
}
