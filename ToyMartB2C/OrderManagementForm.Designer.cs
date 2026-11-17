namespace ToyMartB2C
{
    partial class OrderManagementForm
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
            dgvOrders = new DataGridView();
            cboFilter = new ComboBox();
            cboStatus = new ComboBox();
            lblRecipient = new Label();
            lblContact = new Label();
            lblAddress = new Label();
            lblPayment = new Label();
            btnUpdateStatus = new Button();
            btnRefresh = new Button();
            btnBack = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            SuspendLayout();
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToAddRows = false;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Location = new Point(361, 194);
            dgvItems.MultiSelect = false;
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.RowHeadersVisible = false;
            dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItems.Size = new Size(470, 495);
            dgvItems.TabIndex = 0;
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(864, 194);
            dgvOrders.MultiSelect = false;
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersVisible = false;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new Size(647, 495);
            dgvOrders.TabIndex = 1;
            dgvOrders.SelectionChanged += dgvOrders_SelectionChanged;
            // 
            // cboFilter
            // 
            cboFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFilter.FormattingEnabled = true;
            cboFilter.Location = new Point(361, 142);
            cboFilter.Name = "cboFilter";
            cboFilter.Size = new Size(313, 23);
            cboFilter.TabIndex = 2;
            cboFilter.SelectedIndexChanged += cboFilter_SelectedIndexChanged;
            // 
            // cboStatus
            // 
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(966, 142);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(337, 23);
            cboStatus.TabIndex = 3;
            // 
            // lblRecipient
            // 
            lblRecipient.AutoSize = true;
            lblRecipient.Location = new Point(45, 200);
            lblRecipient.Name = "lblRecipient";
            lblRecipient.Size = new Size(38, 15);
            lblRecipient.TabIndex = 4;
            lblRecipient.Text = "label1";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Location = new Point(45, 231);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(38, 15);
            lblContact.TabIndex = 5;
            lblContact.Text = "label2";
            // 
            // lblAddress
            // 
            lblAddress.Location = new Point(45, 263);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(272, 81);
            lblAddress.TabIndex = 6;
            lblAddress.Text = "label3";
            // 
            // lblPayment
            // 
            lblPayment.AutoSize = true;
            lblPayment.Location = new Point(45, 356);
            lblPayment.Name = "lblPayment";
            lblPayment.Size = new Size(38, 15);
            lblPayment.TabIndex = 7;
            lblPayment.Text = "label4";
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.Location = new Point(45, 607);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(239, 23);
            btnUpdateStatus.TabIndex = 8;
            btnUpdateStatus.Text = "Update Status";
            btnUpdateStatus.UseVisualStyleBackColor = true;
            btnUpdateStatus.Click += btnUpdateStatus_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(45, 639);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(239, 23);
            btnRefresh.TabIndex = 9;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(1263, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(239, 64);
            btnBack.TabIndex = 10;
            btnBack.Text = "Back to Dashboard";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Modern No. 20", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(33, 38);
            label6.Name = "label6";
            label6.Size = new Size(199, 50);
            label6.TabIndex = 17;
            label6.Text = "ToyMart";
            // 
            // OrderManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1552, 744);
            Controls.Add(label6);
            Controls.Add(btnBack);
            Controls.Add(btnRefresh);
            Controls.Add(btnUpdateStatus);
            Controls.Add(lblPayment);
            Controls.Add(lblAddress);
            Controls.Add(lblContact);
            Controls.Add(lblRecipient);
            Controls.Add(cboStatus);
            Controls.Add(cboFilter);
            Controls.Add(dgvOrders);
            Controls.Add(dgvItems);
            Name = "OrderManagementForm";
            Text = "OrderManagementForm";
            Load += OrderManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvItems;
        private DataGridView dgvOrders;
        private ComboBox cboFilter;
        private ComboBox cboStatus;
        private Label lblRecipient;
        private Label lblContact;
        private Label lblAddress;
        private Label lblPayment;
        private Button btnUpdateStatus;
        private Button btnRefresh;
        private Button btnBack;
        private Label label6;
    }
}