namespace ToyMartB2C
{
    partial class ReportsForm
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
            dtpFrom = new DateTimePicker();
            dtpTo = new DateTimePicker();
            cboStaff = new ComboBox();
            btnGenerate = new Button();
            lblSummary = new Label();
            dgvStaff = new DataGridView();
            dgvDetails = new DataGridView();
            btnBack = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStaff).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetails).BeginInit();
            SuspendLayout();
            // 
            // dtpFrom
            // 
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(43, 349);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(96, 23);
            dtpFrom.TabIndex = 0;
            // 
            // dtpTo
            // 
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(223, 349);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(98, 23);
            dtpTo.TabIndex = 1;
            // 
            // cboStaff
            // 
            cboStaff.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStaff.FormattingEnabled = true;
            cboStaff.Location = new Point(43, 420);
            cboStaff.Name = "cboStaff";
            cboStaff.Size = new Size(121, 23);
            cboStaff.TabIndex = 2;
            cboStaff.SelectedIndexChanged += cboStaff_SelectedIndexChanged;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(45, 620);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(125, 89);
            btnGenerate.TabIndex = 8;
            btnGenerate.Text = "Generate";
            btnGenerate.Click += btnGenerate_Click_1;
            // 
            // lblSummary
            // 
            lblSummary.AutoSize = true;
            lblSummary.Location = new Point(43, 180);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(38, 15);
            lblSummary.TabIndex = 4;
            lblSummary.Text = "label1";
            // 
            // dgvStaff
            // 
            dgvStaff.AllowUserToAddRows = false;
            dgvStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStaff.Location = new Point(455, 110);
            dgvStaff.Name = "dgvStaff";
            dgvStaff.ReadOnly = true;
            dgvStaff.RowHeadersVisible = false;
            dgvStaff.Size = new Size(1049, 304);
            dgvStaff.TabIndex = 5;
            // 
            // dgvDetails
            // 
            dgvDetails.AllowUserToAddRows = false;
            dgvDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetails.Location = new Point(455, 420);
            dgvDetails.Name = "dgvDetails";
            dgvDetails.ReadOnly = true;
            dgvDetails.RowHeadersVisible = false;
            dgvDetails.Size = new Size(1049, 289);
            dgvDetails.TabIndex = 6;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(1295, 72);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(209, 23);
            btnBack.TabIndex = 7;
            btnBack.Text = "Back to Dashboard";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 321);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 9;
            label1.Text = "From:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(226, 322);
            label2.Name = "label2";
            label2.Size = new Size(23, 15);
            label2.TabIndex = 10;
            label2.Text = "To:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 399);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 11;
            label3.Text = "Staff:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 124);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 12;
            label4.Text = "Summary:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Modern No. 20", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(27, 23);
            label6.Name = "label6";
            label6.Size = new Size(199, 50);
            label6.TabIndex = 17;
            label6.Text = "ToyMart";
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1552, 744);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(dgvDetails);
            Controls.Add(dgvStaff);
            Controls.Add(lblSummary);
            Controls.Add(btnGenerate);
            Controls.Add(cboStaff);
            Controls.Add(dtpTo);
            Controls.Add(dtpFrom);
            Name = "ReportsForm";
            Text = "ReportsForm";
            Load += ReportsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStaff).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpFrom;
        private DateTimePicker dtpTo;
        private ComboBox cboStaff;
        private Button btnGenerate;
        private Label lblSummary;
        private DataGridView dgvStaff;
        private DataGridView dgvDetails;
        private Button btnBack;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
    }
}