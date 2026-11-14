namespace ToyMartB2C
{
    partial class UserDashboardForm
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
            btnShop = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(78, 54);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(38, 15);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "label1";
            // 
            // btnShop
            // 
            btnShop.Location = new Point(78, 117);
            btnShop.Name = "btnShop";
            btnShop.Size = new Size(75, 23);
            btnShop.TabIndex = 1;
            btnShop.Text = "Shop";
            btnShop.UseVisualStyleBackColor = true;
            btnShop.Click += btnShop_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(177, 117);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // UserDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogout);
            Controls.Add(btnShop);
            Controls.Add(lblWelcome);
            Name = "UserDashboardForm";
            Text = "UserDashboardForm";
            Load += UserDashboardForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Button btnShop;
        private Button btnLogout;
    }
}