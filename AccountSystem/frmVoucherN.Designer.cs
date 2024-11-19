namespace AccountSystem
{
    partial class frmVoucherN
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
            System.Windows.Forms.Label voucherno;
            System.Windows.Forms.Label entryDateLabel;
            System.Windows.Forms.Label bankIDLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVoucherN));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.voucherN = new System.Windows.Forms.TextBox();
            this.entryDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bankIDTextBox = new System.Windows.Forms.TextBox();
            this.lblTCr = new System.Windows.Forms.Label();
            this.lblTDr = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtOpenCash = new System.Windows.Forms.TextBox();
            this.lblinWords = new System.Windows.Forms.Label();
            this.cboVouType = new System.Windows.Forms.ComboBox();
            this.tblVoucherDTLDataGridView = new System.Windows.Forms.DataGridView();
            this.cboEntryAcc = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            voucherno = new System.Windows.Forms.Label();
            entryDateLabel = new System.Windows.Forms.Label();
            bankIDLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVoucherDTLDataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // voucherno
            // 
            voucherno.AutoSize = true;
            voucherno.Location = new System.Drawing.Point(52, 53);
            voucherno.Name = "voucherno";
            voucherno.Size = new System.Drawing.Size(70, 13);
            voucherno.TabIndex = 0;
            voucherno.Text = "Voucher No :";
            // 
            // entryDateLabel
            // 
            entryDateLabel.AutoSize = true;
            entryDateLabel.Location = new System.Drawing.Point(506, 53);
            entryDateLabel.Name = "entryDateLabel";
            entryDateLabel.Size = new System.Drawing.Size(60, 13);
            entryDateLabel.TabIndex = 5;
            entryDateLabel.Text = "Entry Date:";
            // 
            // bankIDLabel
            // 
            bankIDLabel.AutoSize = true;
            bankIDLabel.Location = new System.Drawing.Point(52, 81);
            bankIDLabel.Name = "bankIDLabel";
            bankIDLabel.Size = new System.Drawing.Size(103, 13);
            bankIDLabel.TabIndex = 3;
            bankIDLabel.Text = "Voucher Description";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(55, 139);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(103, 15);
            label1.TabIndex = 7;
            label1.Text = "Opening Balance";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(49, 12);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(80, 13);
            label2.TabIndex = 30;
            label2.Text = "Voucher Type :";
            // 
            // voucherN
            // 
            this.voucherN.Location = new System.Drawing.Point(131, 49);
            this.voucherN.Name = "voucherN";
            this.voucherN.ReadOnly = true;
            this.voucherN.Size = new System.Drawing.Size(142, 20);
            this.voucherN.TabIndex = 2;
            // 
            // entryDateDateTimePicker
            // 
            this.entryDateDateTimePicker.CustomFormat = "ddMMMMyyyy";
            this.entryDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.entryDateDateTimePicker.Location = new System.Drawing.Point(572, 49);
            this.entryDateDateTimePicker.Name = "entryDateDateTimePicker";
            this.entryDateDateTimePicker.Size = new System.Drawing.Size(146, 20);
            this.entryDateDateTimePicker.TabIndex = 6;
            // 
            // bankIDTextBox
            // 
            this.bankIDTextBox.Location = new System.Drawing.Point(52, 99);
            this.bankIDTextBox.MaxLength = 250;
            this.bankIDTextBox.Multiline = true;
            this.bankIDTextBox.Name = "bankIDTextBox";
            this.bankIDTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.bankIDTextBox.Size = new System.Drawing.Size(566, 33);
            this.bankIDTextBox.TabIndex = 4;
            // 
            // lblTCr
            // 
            this.lblTCr.BackColor = System.Drawing.Color.White;
            this.lblTCr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTCr.Location = new System.Drawing.Point(555, 462);
            this.lblTCr.Name = "lblTCr";
            this.lblTCr.Size = new System.Drawing.Size(75, 13);
            this.lblTCr.TabIndex = 10;
            this.lblTCr.Text = "00";
            // 
            // lblTDr
            // 
            this.lblTDr.BackColor = System.Drawing.Color.White;
            this.lblTDr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTDr.Location = new System.Drawing.Point(640, 462);
            this.lblTDr.Name = "lblTDr";
            this.lblTDr.Size = new System.Drawing.Size(75, 13);
            this.lblTDr.TabIndex = 11;
            this.lblTDr.Text = "00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(69, 452);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(655, 34);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // txtOpenCash
            // 
            this.txtOpenCash.BackColor = System.Drawing.Color.White;
            this.txtOpenCash.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOpenCash.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpenCash.Location = new System.Drawing.Point(164, 139);
            this.txtOpenCash.Name = "txtOpenCash";
            this.txtOpenCash.ReadOnly = true;
            this.txtOpenCash.Size = new System.Drawing.Size(590, 15);
            this.txtOpenCash.TabIndex = 8;
            // 
            // lblinWords
            // 
            this.lblinWords.AutoSize = true;
            this.lblinWords.BackColor = System.Drawing.Color.Transparent;
            this.lblinWords.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinWords.Location = new System.Drawing.Point(12, 9);
            this.lblinWords.Name = "lblinWords";
            this.lblinWords.Size = new System.Drawing.Size(16, 16);
            this.lblinWords.TabIndex = 1;
            this.lblinWords.Text = "..";
            // 
            // cboVouType
            // 
            this.cboVouType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVouType.FormattingEnabled = true;
            this.cboVouType.Items.AddRange(new object[] {
            "Journal Voucher",
            "Grant Payment Voucher",
            "Grant Receipt Voucher",
            "Security Payment Voucher",
            "Security Receipt Voucher"});
            this.cboVouType.Location = new System.Drawing.Point(131, 9);
            this.cboVouType.Name = "cboVouType";
            this.cboVouType.Size = new System.Drawing.Size(178, 21);
            this.cboVouType.TabIndex = 29;
            this.cboVouType.SelectedIndexChanged += new System.EventHandler(this.cboVouType_SelectedIndexChanged);
            // 
            // tblVoucherDTLDataGridView
            // 
            this.tblVoucherDTLDataGridView.AllowUserToResizeColumns = false;
            this.tblVoucherDTLDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblVoucherDTLDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tblVoucherDTLDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tblVoucherDTLDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tblVoucherDTLDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.tblVoucherDTLDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblVoucherDTLDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tblVoucherDTLDataGridView.ColumnHeadersHeight = 25;
            this.tblVoucherDTLDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tblVoucherDTLDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cboEntryAcc,
            this.Description,
            this.DR,
            this.Cr,
            this.X});
            this.tblVoucherDTLDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.tblVoucherDTLDataGridView.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.tblVoucherDTLDataGridView.Location = new System.Drawing.Point(52, 169);
            this.tblVoucherDTLDataGridView.Name = "tblVoucherDTLDataGridView";
            this.tblVoucherDTLDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tblVoucherDTLDataGridView.RowHeadersVisible = false;
            this.tblVoucherDTLDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tblVoucherDTLDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tblVoucherDTLDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.tblVoucherDTLDataGridView.Size = new System.Drawing.Size(741, 276);
            this.tblVoucherDTLDataGridView.TabIndex = 31;
            this.tblVoucherDTLDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblVoucherDTLDataGridView_CellClick);
            this.tblVoucherDTLDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblVoucherDTLDataGridView_CellEndEdit);
            this.tblVoucherDTLDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.tblVoucherDTLDataGridView_CellFormatting);
            this.tblVoucherDTLDataGridView.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tblVoucherDTLDataGridView_CellMouseMove);
            this.tblVoucherDTLDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblVoucherDTLDataGridView_CellValueChanged);
            this.tblVoucherDTLDataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.tblVoucherDTLDataGridView_EditingControlShowing);
            this.tblVoucherDTLDataGridView.Enter += new System.EventHandler(this.tblVoucherDTLDataGridView_Enter);
            // 
            // cboEntryAcc
            // 
            this.cboEntryAcc.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.cboEntryAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboEntryAcc.HeaderText = "Account Code";
            this.cboEntryAcc.Name = "cboEntryAcc";
            this.cboEntryAcc.Width = 250;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.Width = 250;
            // 
            // DR
            // 
            this.DR.HeaderText = "Dr.";
            this.DR.Name = "DR";
            // 
            // Cr
            // 
            this.Cr.HeaderText = "Cr.";
            this.Cr.Name = "Cr";
            this.Cr.Width = 80;
            // 
            // X
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "Null";
            this.X.DefaultCellStyle = dataGridViewCellStyle3;
            this.X.HeaderText = "";
            this.X.Image = global::AccountSystem.Properties.Resources.close;
            this.X.Name = "X";
            this.X.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.X.Width = 20;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPrint);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.btnClose);
            this.groupBox3.Location = new System.Drawing.Point(69, 501);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(655, 38);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.Appearance.Options.UseForeColor = true;
            this.btnPrint.Enabled = false;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(377, 11);
            this.btnPrint.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(95, 22);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "&Print Voucher";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Appearance.Options.UseForeColor = true;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(478, 11);
            this.btnSave.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 22);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.Appearance.Options.UseForeColor = true;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(566, 11);
            this.btnClose.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 22);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "&Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmVoucherN
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(793, 546);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tblVoucherDTLDataGridView);
            this.Controls.Add(label2);
            this.Controls.Add(this.cboVouType);
            this.Controls.Add(label1);
            this.Controls.Add(this.txtOpenCash);
            this.Controls.Add(this.lblTDr);
            this.Controls.Add(this.lblTCr);
            this.Controls.Add(this.voucherN);
            this.Controls.Add(entryDateLabel);
            this.Controls.Add(this.entryDateDateTimePicker);
            this.Controls.Add(bankIDLabel);
            this.Controls.Add(this.bankIDTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblinWords);
            this.Controls.Add(voucherno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVoucherN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Journal Voucher";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVoucher_FormClosing);
            this.Load += new System.EventHandler(this.frmVoucher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVoucherDTLDataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox voucherN;
        private System.Windows.Forms.DateTimePicker entryDateDateTimePicker;
        private System.Windows.Forms.TextBox bankIDTextBox;
        private System.Windows.Forms.Label lblTCr;
        private System.Windows.Forms.Label lblTDr;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtOpenCash;
        private System.Windows.Forms.Label lblinWords;
        private System.Windows.Forms.ComboBox cboVouType;
        private System.Windows.Forms.DataGridView tblVoucherDTLDataGridView;
        private System.Windows.Forms.DataGridViewComboBoxColumn cboEntryAcc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn DR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cr;
        private System.Windows.Forms.DataGridViewImageColumn X;
        private System.Windows.Forms.GroupBox groupBox3;
        internal DevExpress.XtraEditors.SimpleButton btnPrint;
        internal DevExpress.XtraEditors.SimpleButton btnSave;
        internal DevExpress.XtraEditors.SimpleButton btnClose;
    }
}