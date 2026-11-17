using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ToyMartB2C
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            Theme.Apply(this);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text;

            if (user == "" || pass == "")
            {
                MessageBox.Show("Please enter your username and password.", "Missing information");
                return;
            }

            var dt = Db.Query(
                "SELECT user_id, username, password_hash, role FROM users WHERE username = @u",
                new SqlParameter("@u", user));

            if (dt.Rows.Count == 0 ||
                !BCrypt.Net.BCrypt.Verify(pass, dt.Rows[0]["password_hash"].ToString()))
            {
                MessageBox.Show("Incorrect username or password.", "Login failed");
                return;
            }

            Session.UserId = (int)dt.Rows[0]["user_id"];
            Session.UserName = dt.Rows[0]["username"].ToString()!;
            Session.Role = dt.Rows[0]["role"].ToString()!;

            this.DialogResult = DialogResult.OK;
        }
        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            new RegisterForm().ShowDialog();
        }
    }
}
