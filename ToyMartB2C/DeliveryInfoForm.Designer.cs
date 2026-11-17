namespace ToyMartB2C
{
    partial class DeliveryInfoForm
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
            txtRecipient = new TextBox();
            txtContact = new TextBox();
            cboProvince = new ComboBox();
            txtCity = new TextBox();
            txtBarangay = new TextBox();
            txtStreet = new TextBox();
            txtPostal = new TextBox();
            cboPayment = new ComboBox();
            btnContinue = new Button();
            btnBack = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // txtRecipient
            // 
            txtRecipient.Font = new Font("Segoe UI", 14.25F);
            txtRecipient.Location = new Point(494, 140);
            txtRecipient.Name = "txtRecipient";
            txtRecipient.Size = new Size(346, 33);
            txtRecipient.TabIndex = 0;
            // 
            // txtContact
            // 
            txtContact.Font = new Font("Segoe UI", 14.25F);
            txtContact.Location = new Point(494, 187);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(346, 33);
            txtContact.TabIndex = 1;
            // 
            // cboProvince
            // 
            cboProvince.Font = new Font("Segoe UI", 14.25F);
            cboProvince.FormattingEnabled = true;
            cboProvince.Items.AddRange(new object[] { "Metro Manila", "Cavite", "Laguna ", "Batangas ", "Rizal", "Quezon", "Bulacan", "Pampanga", "Cebu", "Davao del Sur" });
            cboProvince.Location = new Point(494, 231);
            cboProvince.Name = "cboProvince";
            cboProvince.Size = new Size(367, 33);
            cboProvince.TabIndex = 2;
            // 
            // txtCity
            // 
            txtCity.Font = new Font("Segoe UI", 14.25F);
            txtCity.Location = new Point(494, 282);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(346, 33);
            txtCity.TabIndex = 3;
            // 
            // txtBarangay
            // 
            txtBarangay.Font = new Font("Segoe UI", 14.25F);
            txtBarangay.Location = new Point(494, 332);
            txtBarangay.Name = "txtBarangay";
            txtBarangay.Size = new Size(346, 33);
            txtBarangay.TabIndex = 4;
            // 
            // txtStreet
            // 
            txtStreet.Font = new Font("Segoe UI", 14.25F);
            txtStreet.Location = new Point(494, 380);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(346, 33);
            txtStreet.TabIndex = 5;
            // 
            // txtPostal
            // 
            txtPostal.Font = new Font("Segoe UI", 14.25F);
            txtPostal.Location = new Point(494, 431);
            txtPostal.Name = "txtPostal";
            txtPostal.Size = new Size(346, 33);
            txtPostal.TabIndex = 6;
            // 
            // cboPayment
            // 
            cboPayment.Font = new Font("Segoe UI", 14.25F);
            cboPayment.FormattingEnabled = true;
            cboPayment.Items.AddRange(new object[] { " Cash on Delivery", "GCash", "Maya", "Credit/Debit Card" });
            cboPayment.Location = new Point(494, 484);
            cboPayment.Name = "cboPayment";
            cboPayment.Size = new Size(367, 33);
            cboPayment.TabIndex = 7;
            // 
            // btnContinue
            // 
            btnContinue.Location = new Point(621, 571);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(240, 50);
            btnContinue.TabIndex = 19;
            btnContinue.Text = "Continue";
            btnContinue.Click += btnContinue_Click_1;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(621, 59);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(219, 47);
            btnBack.TabIndex = 18;
            btnBack.Text = "Back to Dashboard";
            btnBack.Click += btnBack_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.Location = new Point(69, 140);
            label1.Name = "label1";
            label1.Size = new Size(148, 25);
            label1.TabIndex = 10;
            label1.Text = "Recipient Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(67, 190);
            label2.Name = "label2";
            label2.Size = new Size(150, 25);
            label2.TabIndex = 11;
            label2.Text = "ContactNumber:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.Location = new Point(67, 239);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 12;
            label3.Text = "Province:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F);
            label4.Location = new Point(67, 285);
            label4.Name = "label4";
            label4.Size = new Size(159, 25);
            label4.TabIndex = 13;
            label4.Text = "City/Municipality:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F);
            label5.Location = new Point(69, 335);
            label5.Name = "label5";
            label5.Size = new Size(95, 25);
            label5.TabIndex = 14;
            label5.Text = "Barangay:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F);
            label6.Location = new Point(69, 383);
            label6.Name = "label6";
            label6.Size = new Size(252, 25);
            label6.TabIndex = 15;
            label6.Text = "House No.Street.Subdivision:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F);
            label7.Location = new Point(69, 434);
            label7.Name = "label7";
            label7.Size = new Size(116, 25);
            label7.TabIndex = 16;
            label7.Text = "postal Code:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F);
            label8.Location = new Point(69, 487);
            label8.Name = "label8";
            label8.Size = new Size(164, 25);
            label8.TabIndex = 17;
            label8.Text = "Mode of Payment:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Modern No. 20", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(39, 35);
            label9.Name = "label9";
            label9.Size = new Size(199, 50);
            label9.TabIndex = 20;
            label9.Text = "ToyMart";
            // 
            // DeliveryInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 744);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(btnContinue);
            Controls.Add(cboPayment);
            Controls.Add(txtPostal);
            Controls.Add(txtStreet);
            Controls.Add(txtBarangay);
            Controls.Add(txtCity);
            Controls.Add(cboProvince);
            Controls.Add(txtContact);
            Controls.Add(txtRecipient);
            Name = "DeliveryInfoForm";
            Text = "DeliveryInfoForm";
            Load += DeliveryInfoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRecipient;
        private TextBox txtContact;
        private ComboBox cboProvince;
        private TextBox txtCity;
        private TextBox txtBarangay;
        private TextBox txtStreet;
        private TextBox txtPostal;
        private ComboBox cboPayment;
        private Button btnContinue;
        private Button btnBack;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}