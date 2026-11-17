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
            txtSubject = new TextBox();
            txtMessage = new TextBox();
            cboOrder = new ComboBox();
            btnSend = new Button();
            dgvInquiries = new DataGridView();
            btnEdit = new Button();
            btnCart = new Button();
            dgvOrders = new DataGridView();
            dgvOrderItems = new DataGridView();
            ContactSupport = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvInquiries).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderItems).BeginInit();
            ContactSupport.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(251, 55);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(38, 15);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "label1";
            // 
            // btnShop
            // 
            btnShop.Location = new Point(1018, 55);
            btnShop.Name = "btnShop";
            btnShop.Size = new Size(145, 88);
            btnShop.TabIndex = 1;
            btnShop.Text = "Shop";
            btnShop.UseVisualStyleBackColor = true;
            btnShop.Click += btnShop_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(1367, 55);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(145, 88);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(30, 25);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(182, 23);
            txtSubject.TabIndex = 3;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(30, 104);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(1426, 182);
            txtMessage.TabIndex = 4;
            // 
            // cboOrder
            // 
            cboOrder.DropDownStyle = ComboBoxStyle.DropDownList;
            cboOrder.FormattingEnabled = true;
            cboOrder.Location = new Point(30, 60);
            cboOrder.Name = "cboOrder";
            cboOrder.Size = new Size(182, 23);
            cboOrder.TabIndex = 5;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(282, 25);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(142, 59);
            btnSend.TabIndex = 6;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // dgvInquiries
            // 
            dgvInquiries.AllowUserToAddRows = false;
            dgvInquiries.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInquiries.Location = new Point(30, 312);
            dgvInquiries.Name = "dgvInquiries";
            dgvInquiries.ReadOnly = true;
            dgvInquiries.RowHeadersVisible = false;
            dgvInquiries.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInquiries.Size = new Size(1426, 215);
            dgvInquiries.TabIndex = 7;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(704, 55);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(284, 88);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Edit Delivery Details";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnCart
            // 
            btnCart.Location = new Point(1193, 55);
            btnCart.Name = "btnCart";
            btnCart.Size = new Size(145, 88);
            btnCart.TabIndex = 9;
            btnCart.Text = "Cart";
            btnCart.UseVisualStyleBackColor = true;
            btnCart.Click += btnCart_Click;
            // 
            // dgvOrders
            // 
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(38, 25);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.Size = new Size(1413, 218);
            dgvOrders.TabIndex = 10;
            dgvOrders.SelectionChanged += dgvOrders_SelectionChanged;
            // 
            // dgvOrderItems
            // 
            dgvOrderItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderItems.Location = new Point(38, 259);
            dgvOrderItems.Name = "dgvOrderItems";
            dgvOrderItems.Size = new Size(1413, 269);
            dgvOrderItems.TabIndex = 11;
            // 
            // ContactSupport
            // 
            ContactSupport.Controls.Add(tabPage1);
            ContactSupport.Controls.Add(tabPage2);
            ContactSupport.Location = new Point(24, 139);
            ContactSupport.Name = "ContactSupport";
            ContactSupport.SelectedIndex = 0;
            ContactSupport.Size = new Size(1495, 579);
            ContactSupport.TabIndex = 12;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtMessage);
            tabPage1.Controls.Add(txtSubject);
            tabPage1.Controls.Add(cboOrder);
            tabPage1.Controls.Add(btnSend);
            tabPage1.Controls.Add(dgvInquiries);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1487, 551);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvOrders);
            tabPage2.Controls.Add(dgvOrderItems);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1487, 551);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Modern No. 20", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(33, 27);
            label6.Name = "label6";
            label6.Size = new Size(199, 50);
            label6.TabIndex = 17;
            label6.Text = "ToyMart";
            // 
            // UserDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1552, 744);
            Controls.Add(label6);
            Controls.Add(ContactSupport);
            Controls.Add(btnCart);
            Controls.Add(btnEdit);
            Controls.Add(btnLogout);
            Controls.Add(btnShop);
            Controls.Add(lblWelcome);
            Name = "UserDashboardForm";
            Text = "UserDashboardForm";
            Load += UserDashboardForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInquiries).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderItems).EndInit();
            ContactSupport.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Button btnShop;
        private Button btnLogout;
        private TextBox txtSubject;
        private TextBox txtMessage;
        private ComboBox cboOrder;
        private Button btnSend;
        private DataGridView dgvInquiries;
        private Button btnEdit;
        private Button btnCart;
        private DataGridView dgvOrders;
        private DataGridView dgvOrderItems;
        private TabControl ContactSupport;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label6;
    }
}