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
    }
}
