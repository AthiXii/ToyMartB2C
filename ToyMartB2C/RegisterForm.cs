using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToyMartB2C
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string pass = txtPassword.Text;
            string confirm = txtPassConfirm.Text;

            if (fullName == "" || username == "" || email == "" || pass == "")
            {
                MessageBox.Show("Please fill in all fields.", "Missing information");
                return;
            }
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid email");
                return;
            }
            if (pass.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters.", "Weak password");
                return;
            }
            if (pass != confirm)
            {
                MessageBox.Show("Passwords do not match.", "Password mismatch");
                return;
            }

            var exists = Db.Query("SELECT 1 FROM users WHERE username = @u",
                new SqlParameter("@u", username));
            if (exists.Rows.Count > 0)
            {
                MessageBox.Show("That username is already taken.", "Username taken");
                return;
            }

            string hash = BCrypt.Net.BCrypt.HashPassword(pass);

            Db.Execute(
                "INSERT INTO users (username, password_hash, full_name, email, role) " +
                "VALUES (@u, @p, @f, @e, 'customer')",
                new SqlParameter("@u", username),
                new SqlParameter("@p", hash),
                new SqlParameter("@f", fullName),
                new SqlParameter("@e", email));

            MessageBox.Show("Account created! You can now log in.", "Success");
            this.Close();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
