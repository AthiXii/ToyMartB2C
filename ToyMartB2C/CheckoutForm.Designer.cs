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
            button2 = new Button();
            button3 = new Button();
            lblPayment = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            SuspendLayout();
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToAddRows = false;
            dgvItems.AllowUserToOrderColumns = true;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Location = new Point(363, 77);
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.RowHeadersVisible = false;
            dgvItems.Size = new Size(222, 325);
            dgvItems.TabIndex = 0;
            // 
            // lblRecipient
            // 
            lblRecipient.AutoSize = true;
            lblRecipient.Location = new Point(182, 134);
            lblRecipient.Name = "lblRecipient";
            lblRecipient.Size = new Size(91, 15);
            lblRecipient.TabIndex = 1;
            lblRecipient.Text = "Recipient Name";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Location = new Point(181, 161);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(69, 15);
            lblContact.TabIndex = 2;
            lblContact.Text = "63+0090009";
            // 
            // lblAddress
            // 
            lblAddress.Location = new Point(182, 188);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(158, 23);
            lblAddress.TabIndex = 3;
            lblAddress.Text = "full adress";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(185, 218);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(32, 15);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "P123";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(35, 304);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(125, 23);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit Delivery Info";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(35, 344);
            button2.Name = "button2";
            button2.Size = new Size(125, 23);
            button2.TabIndex = 6;
            button2.Text = "Place Order";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(180, 344);
            button3.Name = "button3";
            button3.Size = new Size(125, 23);
            button3.TabIndex = 7;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = true;
            // 
            // lblPayment
            // 
            lblPayment.AutoSize = true;
            lblPayment.Location = new Point(180, 250);
            lblPayment.Name = "lblPayment";
            lblPayment.Size = new Size(105, 15);
            lblPayment.TabIndex = 8;
            lblPayment.Text = "Payement Method";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 134);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 9;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 161);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 10;
            label2.Text = "Contact No.:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 188);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 11;
            label3.Text = "Address:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 218);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 13;
            label4.Text = "Order Total:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 250);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 14;
            label5.Text = "Payment Method:";
            // 
            // CheckoutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblPayment);
            Controls.Add(button3);
            Controls.Add(button2);
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
        private Button button2;
        private Button button3;
        private Label lblPayment;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}