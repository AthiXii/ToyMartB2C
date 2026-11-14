namespace ToyMartB2C
{
    partial class InventoryForm
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
            dgvProducts = new DataGridView();
            txtDescription = new TextBox();
            txtStock = new TextBox();
            txtSearch = new TextBox();
            txtPrice = new TextBox();
            cboCategory = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnBack = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtName = new TextBox();
            picProduct = new PictureBox();
            label7 = new Label();
            btnBrowse = new Button();
            btnRemoveImage = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picProduct).BeginInit();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(45, 166);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(468, 391);
            dgvProducts.TabIndex = 0;
            dgvProducts.CellClick += dgvProducts_CellClick;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(613, 191);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(286, 122);
            txtDescription.TabIndex = 1;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(613, 361);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(53, 23);
            txtStock.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(126, 137);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(387, 23);
            txtSearch.TabIndex = 3;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(613, 330);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(52, 23);
            txtPrice.TabIndex = 5;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(613, 163);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(286, 23);
            cboCategory.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(728, 331);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(728, 360);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 22);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(826, 330);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(826, 359);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 10;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(43, 108);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(165, 23);
            btnBack.TabIndex = 11;
            btnBack.Text = "BACK TO DASHBOARD";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(520, 139);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 12;
            label1.Text = "Product Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(537, 191);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 13;
            label2.Text = "Description:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(568, 369);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 15;
            label3.Text = "Stock:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(571, 335);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 14;
            label4.Text = "Price:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 140);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 16;
            label5.Text = "Search:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(549, 166);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 17;
            label6.Text = "Category:";
            // 
            // txtName
            // 
            txtName.Location = new Point(613, 136);
            txtName.Name = "txtName";
            txtName.Size = new Size(286, 23);
            txtName.TabIndex = 4;
            // 
            // picProduct
            // 
            picProduct.BackColor = SystemColors.ButtonFace;
            picProduct.BorderStyle = BorderStyle.FixedSingle;
            picProduct.Location = new Point(613, 407);
            picProduct.Name = "picProduct";
            picProduct.Size = new Size(150, 150);
            picProduct.SizeMode = PictureBoxSizeMode.Zoom;
            picProduct.TabIndex = 18;
            picProduct.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(519, 401);
            label7.Name = "label7";
            label7.Size = new Size(88, 15);
            label7.TabIndex = 19;
            label7.Text = "Product Image:";
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(773, 434);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(128, 23);
            btnBrowse.TabIndex = 21;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnRemoveImage
            // 
            btnRemoveImage.Location = new Point(775, 471);
            btnRemoveImage.Name = "btnRemoveImage";
            btnRemoveImage.Size = new Size(126, 23);
            btnRemoveImage.TabIndex = 22;
            btnRemoveImage.Text = "Remove Image";
            btnRemoveImage.UseVisualStyleBackColor = true;
            btnRemoveImage.Click += btnRemoveImage_Click;
            // 
            // InventoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 579);
            Controls.Add(btnRemoveImage);
            Controls.Add(btnBrowse);
            Controls.Add(label7);
            Controls.Add(picProduct);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(cboCategory);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(txtSearch);
            Controls.Add(txtStock);
            Controls.Add(txtDescription);
            Controls.Add(dgvProducts);
            Name = "InventoryForm";
            Text = "InventoryForm";
            Load += InventoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)picProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProducts;
        private TextBox txtDescription;
        private TextBox txtStock;
        private TextBox txtSearch;
        private TextBox txtPrice;
        private ComboBox cboCategory;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private Button btnBack;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtName;
        private PictureBox picProduct;
        private Label label7;
        private Button btnBrowse;
        private Button btnRemoveImage;
    }
}