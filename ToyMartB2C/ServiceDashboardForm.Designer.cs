namespace ToyMartB2C
{
    partial class ServiceDashboardForm
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
            btnLogout = new Button();
            btnInventory = new Button();
            dgvInquiries = new DataGridView();
            lblCustomer = new Label();
            txtMessage = new TextBox();
            txtReply = new TextBox();
            btnSaveReply = new Button();
            btnResolve = new Button();
            btnRefresh = new Button();
            cboFilter = new ComboBox();
            label6 = new Label();
            btnOrders = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInquiries).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(256, 48);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(70, 15);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "lblWelcome";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(1433, 40);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnInventory
            // 
            btnInventory.Location = new Point(56, 107);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(163, 83);
            btnInventory.TabIndex = 2;
            btnInventory.Text = "Inventory";
            btnInventory.UseVisualStyleBackColor = true;
            btnInventory.Click += btnInventory_Click;
            // 
            // dgvInquiries
            // 
            dgvInquiries.AllowUserToAddRows = false;
            dgvInquiries.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInquiries.Location = new Point(783, 126);
            dgvInquiries.MultiSelect = false;
            dgvInquiries.Name = "dgvInquiries";
            dgvInquiries.ReadOnly = true;
            dgvInquiries.RowHeadersVisible = false;
            dgvInquiries.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInquiries.Size = new Size(590, 518);
            dgvInquiries.TabIndex = 3;
            dgvInquiries.CellContentClick += dgvInquiries_CellContentClick;
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new Point(335, 117);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(38, 15);
            lblCustomer.TabIndex = 4;
            lblCustomer.Text = "label1";
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(335, 209);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.ReadOnly = true;
            txtMessage.Size = new Size(414, 214);
            txtMessage.TabIndex = 5;
            // 
            // txtReply
            // 
            txtReply.Location = new Point(335, 456);
            txtReply.Multiline = true;
            txtReply.Name = "txtReply";
            txtReply.Size = new Size(414, 188);
            txtReply.TabIndex = 6;
            // 
            // btnSaveReply
            // 
            btnSaveReply.Location = new Point(56, 355);
            btnSaveReply.Name = "btnSaveReply";
            btnSaveReply.Size = new Size(170, 68);
            btnSaveReply.TabIndex = 7;
            btnSaveReply.Text = "Save Reply";
            btnSaveReply.UseVisualStyleBackColor = true;
            btnSaveReply.Click += btnSaveReply_Click;
            // 
            // btnResolve
            // 
            btnResolve.Location = new Point(56, 452);
            btnResolve.Name = "btnResolve";
            btnResolve.Size = new Size(170, 68);
            btnResolve.TabIndex = 8;
            btnResolve.Text = "Resolve";
            btnResolve.UseVisualStyleBackColor = true;
            btnResolve.Click += btnResolve_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(56, 541);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(170, 68);
            btnRefresh.TabIndex = 9;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // cboFilter
            // 
            cboFilter.FormattingEnabled = true;
            cboFilter.Location = new Point(335, 148);
            cboFilter.Name = "cboFilter";
            cboFilter.Size = new Size(121, 23);
            cboFilter.TabIndex = 10;
            cboFilter.SelectedIndexChanged += cboFilter_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Modern No. 20", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(35, 20);
            label6.Name = "label6";
            label6.Size = new Size(199, 50);
            label6.TabIndex = 17;
            label6.Text = "ToyMart";
            // 
            // btnOrders
            // 
            btnOrders.Location = new Point(56, 209);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(163, 83);
            btnOrders.TabIndex = 18;
            btnOrders.Text = "Orders";
            btnOrders.UseVisualStyleBackColor = true;
            btnOrders.Click += btnOrders_Click;
            // 
            // ServiceDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1552, 744);
            Controls.Add(btnOrders);
            Controls.Add(label6);
            Controls.Add(cboFilter);
            Controls.Add(btnRefresh);
            Controls.Add(btnResolve);
            Controls.Add(btnSaveReply);
            Controls.Add(txtReply);
            Controls.Add(txtMessage);
            Controls.Add(lblCustomer);
            Controls.Add(dgvInquiries);
            Controls.Add(btnInventory);
            Controls.Add(btnLogout);
            Controls.Add(lblWelcome);
            Name = "ServiceDashboardForm";
            Text = "ServiceDashboardForm";
            Load += ServiceDashboardForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInquiries).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Button btnLogout;
        private Button btnInventory;
        private DataGridView dgvInquiries;
        private Label lblCustomer;
        private TextBox txtMessage;
        private TextBox txtReply;
        private Button btnSaveReply;
        private Button btnResolve;
        private Button btnRefresh;
        private ComboBox cboFilter;
        private Label label6;
        private Button btnOrders;
    }
}