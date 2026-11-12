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
    public partial class ServiceDashboardForm : Form
    {
        public ServiceDashboardForm()
        {
            InitializeComponent();
        }

        private void ServiceDashboardForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome, " + Session.UserName + " (" + Session.Role + ")";

        }
    }
}
