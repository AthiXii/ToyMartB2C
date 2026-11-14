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
            btnInventory = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(61, 64);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(38, 15);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "label1";
            // 
            // btnInventory
            // 
            btnInventory.Location = new Point(61, 145);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(149, 23);
            btnInventory.TabIndex = 1;
            btnInventory.Text = "Manage Inventory";
            btnInventory.UseVisualStyleBackColor = true;
            btnInventory.Click += btnInventory_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(68, 198);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogout);
            Controls.Add(btnInventory);
            Controls.Add(lblWelcome);
            Name = "AdminDashboardForm";
            Text = "AdminDashboardForm";
            Load += AdminDashboardForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Button btnInventory;
        private Button btnLogout;
    }
}