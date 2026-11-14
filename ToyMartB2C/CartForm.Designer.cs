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
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            SuspendLayout();
            // 
            // dgvCart
            // 
            dgvCart.AllowUserToAddRows = false;
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Location = new Point(50, 52);
            dgvCart.MultiSelect = false;
            dgvCart.Name = "dgvCart";
            dgvCart.ReadOnly = true;
            dgvCart.RowHeadersVisible = false;
            dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCart.Size = new Size(236, 310);
            dgvCart.TabIndex = 0;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(115, 377);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(35, 15);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "₱0.00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 377);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 2;
            label1.Text = "Total:";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(325, 230);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(193, 23);
            btnBack.TabIndex = 3;
            btnBack.Text = "Continue Shopping";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click_1;
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(443, 270);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(75, 23);
            btnMinus.TabIndex = 4;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click_1;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(325, 270);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(75, 23);
            btnPlus.TabIndex = 5;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click_1;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(325, 299);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(193, 23);
            btnRemove.TabIndex = 6;
            btnRemove.Text = "Remove Item";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click_1;
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(325, 342);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(193, 23);
            btnCheckout.TabIndex = 7;
            btnCheckout.Text = "Proceed to Checkout";
            btnCheckout.UseVisualStyleBackColor = true;
            btnCheckout.Click += btnCheckout_Click_1;
            // 
            // CartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}