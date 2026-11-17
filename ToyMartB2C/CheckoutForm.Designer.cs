namespace ToyMartB2C
{
    partial class CheckoutForm
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
            dgvItems = new DataGridView();
            lblRecipient = new Label();
            lblContact = new Label();
            lblAddress = new Label();
            lblTotal = new Label();
            btnEdit = new Button();
            btnConfirm = new Button();
            btnCancel = new Button();
            lblPayment = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            SuspendLayout();
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToAddRows = false;
            dgvItems.AllowUserToOrderColumns = true;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Location = new Point(885, 85);
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.RowHeadersVisible = false;
            dgvItems.Size = new Size(413, 580);
            dgvItems.TabIndex = 0;
            // 
            // lblRecipient
            // 
            lblRecipient.AutoSize = true;
            lblRecipient.Location = new Point(604, 211);
            lblRecipient.Name = "lblRecipient";
            lblRecipient.Size = new Size(91, 15);
            lblRecipient.TabIndex = 1;
            lblRecipient.Text = "Recipient Name";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Location = new Point(603, 238);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(69, 15);
            lblContact.TabIndex = 2;
            lblContact.Text = "63+0090009";
            // 
            // lblAddress
            // 
            lblAddress.Location = new Point(603, 262);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(183, 80);
            lblAddress.TabIndex = 3;
            lblAddress.Text = "full adress";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(604, 363);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(32, 15);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "P123";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(470, 439);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(239, 45);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit Delivery Info";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click_1;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(335, 564);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(239, 101);
            btnConfirm.TabIndex = 6;
            btnConfirm.Text = "Place Order";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(603, 564);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(239, 101);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblPayment
            // 
            lblPayment.AutoSize = true;
            lblPayment.Location = new Point(604, 395);
            lblPayment.Name = "lblPayment";
            lblPayment.Size = new Size(105, 15);
            lblPayment.TabIndex = 8;
            lblPayment.Text = "Payement Method";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(457, 211);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 9;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(457, 238);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 10;
            label2.Text = "Contact No.:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(457, 265);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 11;
            label3.Text = "Address:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(448, 363);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 13;
            label4.Text = "Order Total:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(448, 395);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 14;
            label5.Text = "Payment Method:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Modern No. 20", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(35, 36);
            label6.Name = "label6";
            label6.Size = new Size(199, 50);
            label6.TabIndex = 17;
            label6.Text = "ToyMart";
            // 
            // CheckoutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1552, 744);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblPayment);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(btnEdit);
            Controls.Add(lblTotal);
            Controls.Add(lblAddress);
            Controls.Add(lblContact);
            Controls.Add(lblRecipient);
            Controls.Add(dgvItems);
            Name = "CheckoutForm";
            Text = "CheckoutForm";
            Load += CheckoutForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvItems;
        private Label lblRecipient;
        private Label lblContact;
        private Label lblAddress;
        private Label lblTotal;
        private Button btnEdit;
        private Button btnConfirm;
        private Button btnCancel;
        private Label lblPayment;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}