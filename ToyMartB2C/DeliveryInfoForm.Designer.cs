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
            SuspendLayout();
            // 
            // txtRecipient
            // 
            txtRecipient.Location = new Point(202, 108);
            txtRecipient.Name = "txtRecipient";
            txtRecipient.Size = new Size(193, 23);
            txtRecipient.TabIndex = 0;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(202, 137);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(193, 23);
            txtContact.TabIndex = 1;
            // 
            // cboProvince
            // 
            cboProvince.FormattingEnabled = true;
            cboProvince.Items.AddRange(new object[] { "Metro Manila", "Cavite", "Laguna ", "Batangas ", "Rizal", "Quezon", "Bulacan", "Pampanga", "Cebu", "Davao del Sur" });
            cboProvince.Location = new Point(202, 166);
            cboProvince.Name = "cboProvince";
            cboProvince.Size = new Size(214, 23);
            cboProvince.TabIndex = 2;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(202, 195);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(193, 23);
            txtCity.TabIndex = 3;
            // 
            // txtBarangay
            // 
            txtBarangay.Location = new Point(202, 224);
            txtBarangay.Name = "txtBarangay";
            txtBarangay.Size = new Size(193, 23);
            txtBarangay.TabIndex = 4;
            // 
            // txtStreet
            // 
            txtStreet.Location = new Point(202, 253);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(193, 23);
            txtStreet.TabIndex = 5;
            // 
            // txtPostal
            // 
            txtPostal.Location = new Point(202, 282);
            txtPostal.Name = "txtPostal";
            txtPostal.Size = new Size(193, 23);
            txtPostal.TabIndex = 6;
            // 
            // cboPayment
            // 
            cboPayment.FormattingEnabled = true;
            cboPayment.Items.AddRange(new object[] { " Cash on Delivery", "GCash", "Maya", "Credit/Debit Card" });
            cboPayment.Location = new Point(202, 311);
            cboPayment.Name = "cboPayment";
            cboPayment.Size = new Size(214, 23);
            cboPayment.TabIndex = 7;
            // 
            // btnContinue
            // 
            btnContinue.Location = new Point(212, 365);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(137, 23);
            btnContinue.TabIndex = 8;
            btnContinue.Text = "Review Order";
            btnContinue.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(52, 365);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(137, 23);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back to Cart";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 116);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 10;
            label1.Text = "Recipient Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 145);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 11;
            label2.Text = "ContactNumber:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 174);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 12;
            label3.Text = "Province:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 203);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 13;
            label4.Text = "City/Municipality:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 232);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 14;
            label5.Text = "Barangay:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 261);
            label6.Name = "label6";
            label6.Size = new Size(160, 15);
            label6.TabIndex = 15;
            label6.Text = "House No.Street.Subdivision:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 290);
            label7.Name = "label7";
            label7.Size = new Size(73, 15);
            label7.TabIndex = 16;
            label7.Text = "postal Code:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(29, 319);
            label8.Name = "label8";
            label8.Size = new Size(105, 15);
            label8.TabIndex = 17;
            label8.Text = "Mode of Payment:";
            // 
            // DeliveryInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 450);
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
    }
}