namespace ToyMartB2C
{
    partial class RegisterForm
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
            txtFullName = new TextBox();
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtPassConfirm = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnRegister = new Button();
            btnBack = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(212, 93);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(100, 23);
            txtFullName.TabIndex = 0;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(212, 139);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(100, 23);
            txtUsername.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(212, 179);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(212, 221);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtPassConfirm
            // 
            txtPassConfirm.Location = new Point(212, 268);
            txtPassConfirm.Name = "txtPassConfirm";
            txtPassConfirm.Size = new Size(100, 23);
            txtPassConfirm.TabIndex = 6;
            txtPassConfirm.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 95);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 7;
            label1.Text = "Full Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 182);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 8;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 139);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 9;
            label3.Text = "User Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 229);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 10;
            label4.Text = "Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 276);
            label5.Name = "label5";
            label5.Size = new Size(107, 15);
            label5.TabIndex = 11;
            label5.Text = "Confirm Password:";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(83, 339);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 12;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(198, 340);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 13;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Modern No. 20", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(83, 24);
            label6.Name = "label6";
            label6.Size = new Size(199, 50);
            label6.TabIndex = 14;
            label6.Text = "ToyMart";
            // 
            // RegisterForm
            // 
            AcceptButton = btnRegister;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 450);
            Controls.Add(label6);
            Controls.Add(btnBack);
            Controls.Add(btnRegister);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassConfirm);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtUsername);
            Controls.Add(txtFullName);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFullName;
        private TextBox txtUsername;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtPassConfirm;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnRegister;
        private Button btnBack;
        private Label label6;
    }
}