namespace ToyMartB2C
{
    partial class UserManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBack = new Button();
            btnDelete = new Button();
            btnChangeRole = new Button();
            cboRole = new ComboBox();
            lblSelected = new Label();
            dgvUsers = new DataGridView();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(443, 53);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(146, 23);
            btnBack.TabIndex = 18;
            btnBack.Text = "Back ";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(36, 310);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(146, 23);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnChangeRole
            // 
            btnChangeRole.Location = new Point(36, 281);
            btnChangeRole.Name = "btnChangeRole";
            btnChangeRole.Size = new Size(146, 23);
            btnChangeRole.TabIndex = 16;
            btnChangeRole.Text = "Change Role";
            btnChangeRole.UseVisualStyleBackColor = true;
            btnChangeRole.Click += btnChangeRole_Click;
            // 
            // cboRole
            // 
            cboRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRole.FormattingEnabled = true;
            cboRole.Location = new Point(36, 172);
            cboRole.Name = "cboRole";
            cboRole.Size = new Size(121, 23);
            cboRole.TabIndex = 15;
            // 
            // lblSelected
            // 
            lblSelected.AutoSize = true;
            lblSelected.Location = new Point(36, 154);
            lblSelected.Name = "lblSelected";
            lblSelected.Size = new Size(38, 15);
            lblSelected.TabIndex = 14;
            lblSelected.Text = "label1";
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(307, 89);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(303, 313);
            dgvUsers.TabIndex = 13;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(43, 119);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 23);
            txtSearch.TabIndex = 12;
            // 
            // UserManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1552, 744);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(btnChangeRole);
            Controls.Add(cboRole);
            Controls.Add(lblSelected);
            Controls.Add(dgvUsers);
            Controls.Add(txtSearch);
            Name = "UserManagementForm";
            Text = "UserManagementForm";
            Load += UserManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button btnDelete;
        private Button btnChangeRole;
        private ComboBox cboRole;
        private Label lblSelected;
        private DataGridView dgvUsers;
        private TextBox txtSearch;
    }
}