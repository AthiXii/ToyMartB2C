namespace ToyMartB2C
{
    partial class ProductCatalogForm
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
            label1 = new Label();
            txtSearch = new TextBox();
            cboCategory = new ComboBox();
            btnBack = new Button();
            flpProducts = new FlowLayoutPanel();
            label6 = new Label();
            btnAccount = new Button();
            btnLogout = new Button();
            btnLogin = new Button();
            lblUser = new Label();
            btnCart = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 77);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(134, 77);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(267, 23);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(407, 77);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(121, 23);
            cboCategory.TabIndex = 3;
            cboCategory.SelectedIndexChanged += cboCategory_SelectedIndexChanged;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(1431, 105);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click_1;
            // 
            // flpProducts
            // 
            flpProducts.AutoScroll = true;
            flpProducts.Location = new Point(30, 146);
            flpProducts.Name = "flpProducts";
            flpProducts.Size = new Size(1501, 570);
            flpProducts.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Modern No. 20", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(199, 50);
            label6.TabIndex = 15;
            label6.Text = "ToyMart";
            // 
            // btnAccount
            // 
            btnAccount.Location = new Point(1340, 76);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(75, 23);
            btnAccount.TabIndex = 16;
            btnAccount.Text = "Account";
            btnAccount.UseVisualStyleBackColor = true;
            btnAccount.Click += btnAccount_Click_1;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(1431, 73);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 17;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click_1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(1259, 105);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 18;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click_1;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(217, 33);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(105, 15);
            lblUser.TabIndex = 19;
            lblUser.Text = "Browsing As Guest";
            // 
            // btnCart
            // 
            btnCart.Location = new Point(1340, 105);
            btnCart.Name = "btnCart";
            btnCart.Size = new Size(75, 23);
            btnCart.TabIndex = 20;
            btnCart.Text = "Cart";
            btnCart.UseVisualStyleBackColor = true;
            btnCart.Click += btnCart_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(40, 77);
            label2.Name = "label2";
            label2.Size = new Size(60, 21);
            label2.TabIndex = 21;
            label2.Text = "Search:";
            // 
            // ProductCatalogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1552, 744);
            Controls.Add(label2);
            Controls.Add(btnCart);
            Controls.Add(lblUser);
            Controls.Add(btnLogin);
            Controls.Add(btnLogout);
            Controls.Add(btnAccount);
            Controls.Add(label6);
            Controls.Add(flpProducts);
            Controls.Add(btnBack);
            Controls.Add(cboCategory);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Name = "ProductCatalogForm";
            Text = "ProductCatalogForm";
            Load += ProductCatalogForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSearch;
        private ComboBox cboCategory;
        private Button btnBack;
        private FlowLayoutPanel flpProducts;
        private Label label6;
        private Button btnAccount;
        private Button btnLogout;
        private Button btnLogin;
        private Label lblUser;
        private Button btnCart;
        private Label label2;
    }
}