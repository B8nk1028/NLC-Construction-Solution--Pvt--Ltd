namespace AccountSystem
{
    partial class frmVoucherPosting
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label voucherno;
            System.Windows.Forms.Label entryDateLabel;
            System.Windows.Forms.Label bankIDLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label6;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVoucherPosting));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.voucherN = new System.Windows.Forms.TextBox();
            this.entryDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bankIDTextBox = new System.Windows.Forms.TextBox();
            this.lblTCr = new System.Windows.Forms.Label();
            this.lblTDr = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtOpenCash = new System.Windows.Forms.TextBox();
            this.cboVouType = new System.Windows.Forms.ComboBox();
            this.tblVoucherDTLDataGridView = new System.Windows.Forms.DataGridView();
            this.cboEntryAcc = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cExpDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.pnlBank = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.drawingDatePicker = new System.Windows.Forms.DateTimePicker();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCheqNo = new System.Windows.Forms.TextBox();
            this.cbLocation = new System.Windows.Forms.ComboBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnDiscard = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtExpDT = new System.Windows.Forms.DateTimePicker();
            this.cbRef = new System.Windows.Forms.ComboBox();
            this.txtCr = new System.Windows.Forms.NumericUpDown();
            this.txtDr = new System.Windows.Forms.NumericUpDown();
            this.txtNarr = new System.Windows.Forms.TextBox();
            this.cboAcc = new SergeUtils.EasyCompletionComboBox();
            this.btnAddRow = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDiff = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblWrdFig = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.listVoucher = new System.Windows.Forms.ListBox();
            voucherno = new System.Windows.Forms.Label();
            entryDateLabel = new System.Windows.Forms.Label();
            bankIDLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVoucherDTLDataGridView)).BeginInit();
            this.pnlBank.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDr)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // voucherno
            // 
            voucherno.AutoSize = true;
            voucherno.Location = new System.Drawing.Point(5, 55);
            voucherno.Name = "voucherno";
            voucherno.Size = new System.Drawing.Size(70, 13);
            voucherno.TabIndex = 4;
            voucherno.Text = "Voucher No :";
            // 
            // entryDateLabel
            // 
            entryDateLabel.AutoSize = true;
            entryDateLabel.BackColor = System.Drawing.Color.Transparent;
            entryDateLabel.Location = new System.Drawing.Point(695, 56);
            entryDateLabel.Name = "entryDateLabel";
            entryDateLabel.Size = new System.Drawing.Size(60, 13);
            entryDateLabel.TabIndex = 2;
            entryDateLabel.Text = "Entry Date:";
            // 
            // bankIDLabel
            // 
            bankIDLabel.AutoSize = true;
            bankIDLabel.Location = new System.Drawing.Point(6, 6);
            bankIDLabel.Name = "bankIDLabel";
            bankIDLabel.Size = new System.Drawing.Size(52, 13);
            bankIDLabel.TabIndex = 0;
            bankIDLabel.Text = "Remarks:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(5, 81);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(103, 15);
            label1.TabIndex = 6;
            label1.Text = "Opening Balance";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(5, 29);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(80, 13);
            label2.TabIndex = 0;
            label2.Text = "Voucher Type :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(452, 30);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(54, 13);
            label6.TabIndex = 34;
            label6.Text = "Location :";
            label6.Visible = false;
            // 
            // voucherN
            // 
            this.voucherN.BackColor = System.Drawing.Color.White;
            this.voucherN.Location = new System.Drawing.Point(120, 51);
            this.voucherN.Name = "voucherN";
            this.voucherN.ReadOnly = true;
            this.voucherN.Size = new System.Drawing.Size(142, 20);
            this.voucherN.TabIndex = 5;
            // 
            // entryDateDateTimePicker
            // 
            this.entryDateDateTimePicker.CustomFormat = "ddMMMMyyyy";
            this.entryDateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.entryDateDateTimePicker.Location = new System.Drawing.Point(761, 53);
            this.entryDateDateTimePicker.Name = "entryDateDateTimePicker";
            this.entryDateDateTimePicker.Size = new System.Drawing.Size(138, 19);
            this.entryDateDateTimePicker.TabIndex = 3;
            this.entryDateDateTimePicker.Enter += new System.EventHandler(this.entryDateDateTimePicker_Enter);
            // 
            // bankIDTextBox
            // 
            this.bankIDTextBox.Location = new System.Drawing.Point(64, 6);
            this.bankIDTextBox.MaxLength = 250;
            this.bankIDTextBox.Multiline = true;
            this.bankIDTextBox.Name = "bankIDTextBox";
            this.bankIDTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.bankIDTextBox.Size = new System.Drawing.Size(739, 28);
            this.bankIDTextBox.TabIndex = 1;
            // 
            // lblTCr
            // 
            this.lblTCr.BackColor = System.Drawing.Color.White;
            this.lblTCr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTCr.Location = new System.Drawing.Point(692, 50);
            this.lblTCr.Name = "lblTCr";
            this.lblTCr.Size = new System.Drawing.Size(91, 13);
            this.lblTCr.TabIndex = 2;
            this.lblTCr.Text = "00";
            this.lblTCr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTDr
            // 
            this.lblTDr.BackColor = System.Drawing.Color.White;
            this.lblTDr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTDr.Location = new System.Drawing.Point(803, 50);
            this.lblTDr.Name = "lblTDr";
            this.lblTDr.Size = new System.Drawing.Size(91, 13);
            this.lblTDr.TabIndex = 3;
            this.lblTDr.Text = "00";
            this.lblTDr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(9, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(898, 34);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // txtOpenCash
            // 
            this.txtOpenCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.txtOpenCash.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOpenCash.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpenCash.Location = new System.Drawing.Point(120, 81);
            this.txtOpenCash.Name = "txtOpenCash";
            this.txtOpenCash.ReadOnly = true;
            this.txtOpenCash.Size = new System.Drawing.Size(479, 15);
            this.txtOpenCash.TabIndex = 7;
            // 
            // cboVouType
            // 
            this.cboVouType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVouType.FormattingEnabled = true;
            this.cboVouType.Items.AddRange(new object[] {
            "JV-   Journal Voucher",
            "BPV-Bank Payment Voucher",
            "BRV-Bank Receipt Voucher",
            "CPV-Cash Payment Voucher",
            "CRV-Cash Receipt Voucher"});
            this.cboVouType.Location = new System.Drawing.Point(120, 25);
            this.cboVouType.Name = "cboVouType";
            this.cboVouType.Size = new System.Drawing.Size(178, 21);
            this.cboVouType.TabIndex = 1;
            this.cboVouType.SelectedIndexChanged += new System.EventHandler(this.cboVouType_SelectedIndexChanged);
            // 
            // tblVoucherDTLDataGridView
            // 
            this.tblVoucherDTLDataGridView.AllowUserToAddRows = false;
            this.tblVoucherDTLDataGridView.AllowUserToResizeColumns = false;
            this.tblVoucherDTLDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblVoucherDTLDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tblVoucherDTLDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tblVoucherDTLDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.tblVoucherDTLDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tblVoucherDTLDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblVoucherDTLDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tblVoucherDTLDataGridView.ColumnHeadersHeight = 25;
            this.tblVoucherDTLDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tblVoucherDTLDataGridView.ColumnHeadersVisible = false;
            this.tblVoucherDTLDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cboEntryAcc,
            this.cExpDT,
            this.cboRef,
            this.Description,
            this.DR,
            this.Cr,
            this.X});
            this.tblVoucherDTLDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblVoucherDTLDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.tblVoucherDTLDataGridView.EnableHeadersVisualStyles = false;
            this.tblVoucherDTLDataGridView.GridColor = System.Drawing.SystemColors.Window;
            this.tblVoucherDTLDataGridView.Location = new System.Drawing.Point(0, 0);
            this.tblVoucherDTLDataGridView.MultiSelect = false;
            this.tblVoucherDTLDataGridView.Name = "tblVoucherDTLDataGridView";
            this.tblVoucherDTLDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblVoucherDTLDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.tblVoucherDTLDataGridView.RowHeadersVisible = false;
            this.tblVoucherDTLDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tblVoucherDTLDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.tblVoucherDTLDataGridView.Size = new System.Drawing.Size(967, 0);
            this.tblVoucherDTLDataGridView.TabIndex = 2;
            this.tblVoucherDTLDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.tblVoucherDTLDataGridView_CellBeginEdit);
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
            this.cboEntryAcc.HeaderText = "Account Code";
            this.cboEntryAcc.Name = "cboEntryAcc";
            this.cboEntryAcc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cboEntryAcc.Width = 250;
            // 
            // cExpDT
            // 
            this.cExpDT.HeaderText = "ExpDT";
            this.cExpDT.Name = "cExpDT";
            this.cExpDT.Width = 127;
            // 
            // cboRef
            // 
            this.cboRef.HeaderText = "Ref. #";
            this.cboRef.Name = "cboRef";
            this.cboRef.ReadOnly = true;
            this.cboRef.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cboRef.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Description
            // 
            this.Description.HeaderText = "Narration";
            this.Description.Name = "Description";
            this.Description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Description.Width = 250;
            // 
            // DR
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.DR.DefaultCellStyle = dataGridViewCellStyle3;
            this.DR.HeaderText = "Dr.";
            this.DR.Name = "DR";
            this.DR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Cr
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.Cr.DefaultCellStyle = dataGridViewCellStyle4;
            this.Cr.HeaderText = "Cr.";
            this.Cr.Name = "Cr";
            this.Cr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Cr.Width = 80;
            // 
            // X
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.NullValue = "Null";
            this.X.DefaultCellStyle = dataGridViewCellStyle5;
            this.X.HeaderText = "";
            this.X.Image = global::AccountSystem.Properties.Resources.close;
            this.X.Name = "X";
            this.X.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.X.Width = 22;
            // 
            // btnPrint
            // 
            this.btnPrint.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.Appearance.Options.UseForeColor = true;
            this.btnPrint.Enabled = false;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(635, 25);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(95, 23);
            this.btnPrint.TabIndex = 0;
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
            this.btnSave.Location = new System.Drawing.Point(736, 25);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Post to &GL";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseHover += new System.EventHandler(this.btnSave_MouseHover);
            // 
            // btnClose
            // 
            this.btnClose.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.Appearance.Options.UseForeColor = true;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(824, 25);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "&Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // pnlBank
            // 
            this.pnlBank.BackColor = System.Drawing.SystemColors.Info;
            this.pnlBank.Controls.Add(this.label3);
            this.pnlBank.Controls.Add(this.label12);
            this.pnlBank.Controls.Add(this.drawingDatePicker);
            this.pnlBank.Location = new System.Drawing.Point(951, 27);
            this.pnlBank.Name = "pnlBank";
            this.pnlBank.Size = new System.Drawing.Size(273, 52);
            this.pnlBank.TabIndex = 33;
            this.pnlBank.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cheque No";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(183, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Cheque Date";
            // 
            // drawingDatePicker
            // 
            this.drawingDatePicker.CustomFormat = "ddMMMMyyyy";
            this.drawingDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.drawingDatePicker.Location = new System.Drawing.Point(186, 22);
            this.drawingDatePicker.Name = "drawingDatePicker";
            this.drawingDatePicker.Size = new System.Drawing.Size(130, 20);
            this.drawingDatePicker.TabIndex = 9;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.txtCheqNo);
            this.groupControl1.Controls.Add(this.cbLocation);
            this.groupControl1.Controls.Add(label6);
            this.groupControl1.Controls.Add(this.pictureBox6);
            this.groupControl1.Controls.Add(this.cboVouType);
            this.groupControl1.Controls.Add(this.pnlBank);
            this.groupControl1.Controls.Add(voucherno);
            this.groupControl1.Controls.Add(label2);
            this.groupControl1.Controls.Add(this.entryDateDateTimePicker);
            this.groupControl1.Controls.Add(entryDateLabel);
            this.groupControl1.Controls.Add(label1);
            this.groupControl1.Controls.Add(this.voucherN);
            this.groupControl1.Controls.Add(this.txtOpenCash);
            this.groupControl1.Location = new System.Drawing.Point(2, 4);
            this.groupControl1.LookAndFeel.SkinName = "The Asphalt World";
            this.groupControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(928, 105);
            this.groupControl1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(704, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Cheque(s)";
            // 
            // txtCheqNo
            // 
            this.txtCheqNo.Location = new System.Drawing.Point(761, 78);
            this.txtCheqNo.MaxLength = 50;
            this.txtCheqNo.Name = "txtCheqNo";
            this.txtCheqNo.Size = new System.Drawing.Size(138, 20);
            this.txtCheqNo.TabIndex = 8;
            // 
            // cbLocation
            // 
            this.cbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.Location = new System.Drawing.Point(503, 26);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(291, 21);
            this.cbLocation.TabIndex = 35;
            this.cbLocation.Visible = false;
            this.cbLocation.SelectedIndexChanged += new System.EventHandler(this.cboVouType_SelectedIndexChanged);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(437, 26);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(23, 20);
            this.pictureBox6.TabIndex = 36;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Visible = false;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnDiscard);
            this.groupControl2.Controls.Add(this.btnPrint);
            this.groupControl2.Controls.Add(this.btnClose);
            this.groupControl2.Controls.Add(this.btnSave);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(210, 477);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(981, 59);
            this.groupControl2.TabIndex = 2;
            // 
            // btnDiscard
            // 
            this.btnDiscard.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscard.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDiscard.Appearance.Options.UseFont = true;
            this.btnDiscard.Appearance.Options.UseForeColor = true;
            this.btnDiscard.Image = global::AccountSystem.Properties.Resources.close;
            this.btnDiscard.Location = new System.Drawing.Point(545, 25);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Size = new System.Drawing.Size(85, 23);
            this.btnDiscard.TabIndex = 3;
            this.btnDiscard.Text = "&Discard";
            this.btnDiscard.Click += new System.EventHandler(this.btnDiscard_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(210, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 472);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.tblVoucherDTLDataGridView);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 142);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(967, 249);
            this.panel5.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtExpDT);
            this.panel3.Controls.Add(this.cbRef);
            this.panel3.Controls.Add(this.txtCr);
            this.panel3.Controls.Add(this.txtDr);
            this.panel3.Controls.Add(this.txtNarr);
            this.panel3.Controls.Add(this.cboAcc);
            this.panel3.Controls.Add(this.btnAddRow);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(967, 24);
            this.panel3.TabIndex = 0;
            // 
            // txtExpDT
            // 
            this.txtExpDT.Checked = false;
            this.txtExpDT.CustomFormat = "MMMM yyyy";
            this.txtExpDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtExpDT.Location = new System.Drawing.Point(251, 2);
            this.txtExpDT.Name = "txtExpDT";
            this.txtExpDT.ShowCheckBox = true;
            this.txtExpDT.ShowUpDown = true;
            this.txtExpDT.Size = new System.Drawing.Size(127, 20);
            this.txtExpDT.TabIndex = 6;
            // 
            // cbRef
            // 
            this.cbRef.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRef.FormattingEnabled = true;
            this.cbRef.Location = new System.Drawing.Point(377, 1);
            this.cbRef.Name = "cbRef";
            this.cbRef.Size = new System.Drawing.Size(100, 21);
            this.cbRef.TabIndex = 1;
            // 
            // txtCr
            // 
            this.txtCr.DecimalPlaces = 2;
            this.txtCr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCr.Location = new System.Drawing.Point(827, 1);
            this.txtCr.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txtCr.Name = "txtCr";
            this.txtCr.Size = new System.Drawing.Size(80, 21);
            this.txtCr.TabIndex = 4;
            this.txtCr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCr.Enter += new System.EventHandler(this.txtCr_Enter);
            this.txtCr.Leave += new System.EventHandler(this.txtCr_Leave);
            // 
            // txtDr
            // 
            this.txtDr.DecimalPlaces = 2;
            this.txtDr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDr.Location = new System.Drawing.Point(727, 1);
            this.txtDr.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txtDr.Name = "txtDr";
            this.txtDr.Size = new System.Drawing.Size(100, 21);
            this.txtDr.TabIndex = 3;
            this.txtDr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDr.Enter += new System.EventHandler(this.txtDr_Enter);
            this.txtDr.Leave += new System.EventHandler(this.txtDr_Leave);
            // 
            // txtNarr
            // 
            this.txtNarr.BackColor = System.Drawing.Color.White;
            this.txtNarr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNarr.Location = new System.Drawing.Point(477, 1);
            this.txtNarr.Name = "txtNarr";
            this.txtNarr.Size = new System.Drawing.Size(250, 21);
            this.txtNarr.TabIndex = 2;
            // 
            // cboAcc
            // 
            this.cboAcc.FormattingEnabled = true;
            this.cboAcc.Location = new System.Drawing.Point(1, 1);
            this.cboAcc.MatchingMethod = SergeUtils.StringMatchingMethod.UseWildcards;
            this.cboAcc.Name = "cboAcc";
            this.cboAcc.Size = new System.Drawing.Size(250, 21);
            this.cboAcc.TabIndex = 0;
            this.cboAcc.SelectedIndexChanged += new System.EventHandler(this.cboAcc_SelectedIndexChanged);
            // 
            // btnAddRow
            // 
            this.btnAddRow.Image = global::AccountSystem.Properties.Resources.add;
            this.btnAddRow.Location = new System.Drawing.Point(907, 0);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(23, 23);
            this.btnAddRow.TabIndex = 5;
            this.btnAddRow.UseVisualStyleBackColor = true;
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupControl1);
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(981, 142);
            this.panel4.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.ColumnHeadersHeight = 25;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.Column1,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewImageColumn1});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.Location = new System.Drawing.Point(0, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(967, 25);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblVoucherDTLDataGridView_CellClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblVoucherDTLDataGridView_CellEndEdit);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.tblVoucherDTLDataGridView_CellFormatting);
            this.dataGridView1.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tblVoucherDTLDataGridView_CellMouseMove);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblVoucherDTLDataGridView_CellValueChanged);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.tblVoucherDTLDataGridView_EditingControlShowing);
            this.dataGridView1.Enter += new System.EventHandler(this.tblVoucherDTLDataGridView_Enter);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Account Code";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn6.Width = 250;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Exp. Date";
            this.Column1.Name = "Column1";
            this.Column1.Width = 127;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Ref. #";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Narration";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn8.Width = 250;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Dr.";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Cr.";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn10.Width = 80;
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.NullValue = "Null";
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::AccountSystem.Properties.Resources.close;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 22;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtDiff);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lblWrdFig);
            this.panel2.Controls.Add(this.lblTDr);
            this.panel2.Controls.Add(this.bankIDTextBox);
            this.panel2.Controls.Add(bankIDLabel);
            this.panel2.Controls.Add(this.lblTCr);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 391);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(981, 81);
            this.panel2.TabIndex = 1;
            // 
            // txtDiff
            // 
            this.txtDiff.AutoSize = true;
            this.txtDiff.Location = new System.Drawing.Point(824, 18);
            this.txtDiff.Name = "txtDiff";
            this.txtDiff.Size = new System.Drawing.Size(73, 13);
            this.txtDiff.TabIndex = 26;
            this.txtDiff.Text = "                      ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(824, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Difference";
            // 
            // lblWrdFig
            // 
            this.lblWrdFig.AutoSize = true;
            this.lblWrdFig.BackColor = System.Drawing.Color.Thistle;
            this.lblWrdFig.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrdFig.Location = new System.Drawing.Point(23, 50);
            this.lblWrdFig.Name = "lblWrdFig";
            this.lblWrdFig.Size = new System.Drawing.Size(0, 13);
            this.lblWrdFig.TabIndex = 23;
            this.lblWrdFig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Description";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 250;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Dr.";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Cr.";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTextBoxColumn4.HeaderText = "Cr.";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewTextBoxColumn5.HeaderText = "Cr.";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel1.ID = new System.Guid("2d085fa7-fa18-4385-8f67-9973b6be64e7");
            this.dockPanel1.Location = new System.Drawing.Point(10, 5);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel1.Size = new System.Drawing.Size(200, 531);
            this.dockPanel1.Text = "Unposted Vouchers";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.listVoucher);
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 25);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(194, 508);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // listVoucher
            // 
            this.listVoucher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listVoucher.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listVoucher.FormattingEnabled = true;
            this.listVoucher.ItemHeight = 15;
            this.listVoucher.Location = new System.Drawing.Point(0, 0);
            this.listVoucher.Name = "listVoucher";
            this.listVoucher.Size = new System.Drawing.Size(194, 508);
            this.listVoucher.TabIndex = 1;
            this.listVoucher.SelectedIndexChanged += new System.EventHandler(this.listVoucher_SelectedIndexChanged);
            // 
            // frmVoucherPosting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1196, 536);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.dockPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVoucherPosting";
            this.Padding = new System.Windows.Forms.Padding(10, 5, 5, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voucher Posting";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVoucher_FormClosing);
            this.Load += new System.EventHandler(this.frmVoucher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVoucherDTLDataGridView)).EndInit();
            this.pnlBank.ResumeLayout(false);
            this.pnlBank.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDr)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox voucherN;
        private System.Windows.Forms.DateTimePicker entryDateDateTimePicker;
        private System.Windows.Forms.TextBox bankIDTextBox;
        private System.Windows.Forms.Label lblTCr;
        private System.Windows.Forms.Label lblTDr;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtOpenCash;
        private System.Windows.Forms.ComboBox cboVouType;
        private System.Windows.Forms.DataGridView tblVoucherDTLDataGridView;
        internal DevExpress.XtraEditors.SimpleButton btnPrint;
        internal DevExpress.XtraEditors.SimpleButton btnSave;
        internal DevExpress.XtraEditors.SimpleButton btnClose;
        private System.Windows.Forms.Panel pnlBank;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker drawingDatePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtNarr;
        private SergeUtils.EasyCompletionComboBox cboAcc;
        private System.Windows.Forms.Button btnAddRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.NumericUpDown txtCr;
        private System.Windows.Forms.NumericUpDown txtDr;
        private System.Windows.Forms.ComboBox cbRef;
        private System.Windows.Forms.ComboBox cbLocation;
        internal System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private System.Windows.Forms.ListBox listVoucher;
        internal DevExpress.XtraEditors.SimpleButton btnDiscard;
        private System.Windows.Forms.TextBox txtCheqNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblWrdFig;
        private System.Windows.Forms.Label txtDiff;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DateTimePicker txtExpDT;
        private System.Windows.Forms.DataGridViewComboBoxColumn cboEntryAcc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cExpDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn cboRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn DR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cr;
        private System.Windows.Forms.DataGridViewImageColumn X;
    }
}