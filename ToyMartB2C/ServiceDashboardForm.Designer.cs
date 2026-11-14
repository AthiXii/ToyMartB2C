namespace ToyMartB2C
{
    partial class ServiceDashboardForm
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
            btnInventory = new Button();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(63, 62);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(70, 15);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "lblWelcome";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(63, 138);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnInventory
            // 
            btnInventory.Location = new Point(185, 138);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(75, 23);
            btnInventory.TabIndex = 2;
            btnInventory.Text = "Inventory";
            btnInventory.UseVisualStyleBackColor = true;
            btnInventory.Click += btnInventory_Click;
            // 
            // ServiceDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnInventory);
            Controls.Add(btnLogout);
            Controls.Add(lblWelcome);
            Name = "ServiceDashboardForm";
            Text = "ServiceDashboardForm";
            Load += ServiceDashboardForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Button btnLogout;
        private Button btnInventory;
    }
}