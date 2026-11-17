namespace ToyMartB2C
{
    partial class AdminDashboardForm
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
            lblWelcome = new Label();
            btnLogout = new Button();
            btnOrders = new Button();
            btnInventory = new Button();
            lblStats = new Label();
            btnUsers = new Button();
            btnReports = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(258, 57);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(38, 15);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "label1";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(1357, 38);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(142, 51);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnOrders
            // 
            btnOrders.Location = new Point(53, 458);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(245, 100);
            btnOrders.TabIndex = 3;
            btnOrders.Text = "Manage Orders";
            btnOrders.UseVisualStyleBackColor = true;
            btnOrders.Click += btnOrders_Click;
            // 
            // btnInventory
            // 
            btnInventory.Location = new Point(53, 246);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(245, 100);
            btnInventory.TabIndex = 12;
            btnInventory.Text = "Manage Inventory";
            btnInventory.UseVisualStyleBackColor = true;
            btnInventory.Click += btnInventory_Click_1;
            // 
            // lblStats
            // 
            lblStats.AutoSize = true;
            lblStats.Location = new Point(53, 152);
            lblStats.Name = "lblStats";
            lblStats.Size = new Size(38, 15);
            lblStats.TabIndex = 13;
            lblStats.Text = "label1";
            // 
            // btnUsers
            // 
            btnUsers.Location = new Point(53, 352);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(245, 100);
            btnUsers.TabIndex = 14;
            btnUsers.Text = "Manage Users";
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnReports
            // 
            btnReports.Location = new Point(55, 564);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(243, 100);
            btnReports.TabIndex = 15;
            btnReports.Text = "Manage Reports";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Modern No. 20", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(30, 29);
            label6.Name = "label6";
            label6.Size = new Size(199, 50);
            label6.TabIndex = 16;
            label6.Text = "ToyMart";
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1552, 744);
            Controls.Add(label6);
            Controls.Add(btnReports);
            Controls.Add(btnUsers);
            Controls.Add(lblStats);
            Controls.Add(btnInventory);
            Controls.Add(btnOrders);
            Controls.Add(btnLogout);
            Controls.Add(lblWelcome);
            Name = "AdminDashboardForm";
            Text = "AdminDashboardForm";
            Load += AdminDashboardForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Button btnLogout;
        private Button btnOrders;
        private Button btnInventory;
        private Label lblStats;
        private Button btnUsers;
        private Button btnReports;
        private Label label6;
    }
}