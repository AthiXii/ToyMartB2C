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
    public partial class UserManagementForm : Form
    {
        public UserManagementForm()
        {
            InitializeComponent();
            Theme.Apply(this);
        }

        private void UserManagementForm_Load(object sender, EventArgs e)
        {
            cboRole.Items.AddRange(new object[] { "customer", "service", "admin" });
            cboRole.SelectedIndex = 0;
            LoadUsers();
        }
        private void LoadUsers()
        {
            dgvUsers.DataSource = Db.Query(
                "SELECT user_id AS ID, username AS Username, full_name AS Name, " +
                "email AS Email, role AS Role FROM users " +
                "WHERE username LIKE @s OR full_name LIKE @s ORDER BY role, username",
                new SqlParameter("@s", "%" + txtSearch.Text.Trim() + "%"));
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private int SelectedUserId()
        {
            if (dgvUsers.CurrentRow == null) return 0;
            return (int)dgvUsers.CurrentRow.Cells["ID"].Value;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null) return;
            lblSelected.Text = "Selected: " + dgvUsers.CurrentRow.Cells["Username"].Value;
            cboRole.SelectedItem = dgvUsers.CurrentRow.Cells["Role"].Value.ToString();
        }

        private void btnChangeRole_Click(object sender, EventArgs e)
        {
            int id = SelectedUserId();
            if (id == 0)
            {
                MessageBox.Show("Click a user first.", "No user selected");
                return;
            }
            if (id == Session.UserId)
            {
                MessageBox.Show("You can't change your own role.", "Not allowed");
                return;
            }
            Db.Execute("UPDATE users SET role = @r WHERE user_id = @id",
                new SqlParameter("@r", cboRole.SelectedItem!.ToString()),
                new SqlParameter("@id", id));
            MessageBox.Show("Role updated.", "Success");
            LoadUsers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = SelectedUserId();
            if (id == 0)
            {
                MessageBox.Show("Click a user first.", "No user selected");
                return;
            }
            if (id == Session.UserId)
            {
                MessageBox.Show("You can't delete your own account.", "Not allowed");
                return;
            }
            if (MessageBox.Show("Delete this account?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;

            try
            {
                Db.Execute("DELETE FROM cart WHERE user_id = @id", new SqlParameter("@id", id));
                Db.Execute("DELETE FROM inquiries WHERE user_id = @id", new SqlParameter("@id", id));
                Db.Execute("DELETE FROM users WHERE user_id = @id", new SqlParameter("@id", id));
                LoadUsers();
            }
            catch
            {
                MessageBox.Show("This account has past orders and can't be deleted.", "Cannot delete");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
