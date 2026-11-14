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
    public partial class UserDashboardForm : Form
    {
        public UserDashboardForm()
        {
            InitializeComponent();
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
    }
}
