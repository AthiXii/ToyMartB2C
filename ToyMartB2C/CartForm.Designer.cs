namespace ToyMartB2C
{
    partial class CartForm
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
            dgvCart = new DataGridView();
            lblTotal = new Label();
            label1 = new Label();
            btnBack = new Button();
            btnMinus = new Button();
            btnPlus = new Button();
            btnRemove = new Button();
            btnCheckout = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            SuspendLayout();
            // 
            // dgvCart
            // 
            dgvCart.AllowUserToAddRows = false;
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Location = new Point(414, 126);
            dgvCart.MultiSelect = false;
            dgvCart.Name = "dgvCart";
            dgvCart.ReadOnly = true;
            dgvCart.RowHeadersVisible = false;
            dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCart.Size = new Size(484, 533);
            dgvCart.TabIndex = 0;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(1033, 198);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(35, 15);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "₱0.00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(952, 198);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 2;
            label1.Text = "Total:";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(949, 269);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(221, 79);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click_1;
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(1067, 370);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(103, 79);
            btnMinus.TabIndex = 4;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click_1;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(949, 370);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(103, 79);
            btnPlus.TabIndex = 5;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click_1;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(949, 475);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(221, 79);
            btnRemove.TabIndex = 6;
            btnRemove.Text = "Remove Item";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click_1;
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(949, 580);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(221, 79);
            btnCheckout.TabIndex = 7;
            btnCheckout.Text = "Proceed to Checkout";
            btnCheckout.UseVisualStyleBackColor = true;
            btnCheckout.Click += btnCheckout_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Modern No. 20", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(39, 26);
            label6.Name = "label6";
            label6.Size = new Size(199, 50);
            label6.TabIndex = 17;
            label6.Text = "ToyMart";
            // 
            // CartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1552, 744);
            Controls.Add(label6);
            Controls.Add(btnCheckout);
            Controls.Add(btnRemove);
            Controls.Add(btnPlus);
            Controls.Add(btnMinus);
            Controls.Add(btnBack);
            Controls.Add(label1);
            Controls.Add(lblTotal);
            Controls.Add(dgvCart);
            Name = "CartForm";
            Text = "CartForm";
            Load += CartForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCart;
        private Label lblTotal;
        private Label label1;
        private Button btnBack;
        private Button btnMinus;
        private Button btnPlus;
        private Button btnRemove;
        private Button btnCheckout;
        private Label label6;
    }
}