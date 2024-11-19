namespace AccountSystem
{
    partial class frmVoucherED
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label voucherIDLabel;
            System.Windows.Forms.Label voucherNoLabel;
            System.Windows.Forms.Label entryDateLabel;
            System.Windows.Forms.Label memoLabel;
            System.Windows.Forms.Label createdLabel;
            System.Windows.Forms.Label modifiedLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVoucherED));
            this.listVoucher = new System.Windows.Forms.ListBox();
            this.cboVouType = new System.Windows.Forms.ComboBox();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.cbLocation = new System.Windows.Forms.ComboBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.voucherEd = new AccountSystem.VoucherEd();
            this.tblVoucherHDRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblVoucherHDRTableAdapter = new AccountSystem.VoucherEdTableAdapters.TblVoucherHDRTableAdapter();
            this.tableAdapterManager = new AccountSystem.VoucherEdTableAdapters.TableAdapterManager();
            this.tblVoucherDTLTableAdapter = new AccountSystem.VoucherEdTableAdapters.TblVoucherDTLTableAdapter();
            this.tblVoucherHDRBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tblVoucherHDRBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.voucherIDTextBox = new System.Windows.Forms.TextBox();
            this.voucherNoTextBox = new System.Windows.Forms.TextBox();
            this.entryDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.memoTextBox = new System.Windows.Forms.TextBox();
            this.createdLabel1 = new System.Windows.Forms.Label();
            this.modifiedLabel1 = new System.Windows.Forms.Label();
            this.tblVoucherDTLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblVoucherDTLDataGridView = new System.Windows.Forms.DataGridView();
            this.grdCboAccHeads = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label2 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            voucherIDLabel = new System.Windows.Forms.Label();
            voucherNoLabel = new System.Windows.Forms.Label();
            entryDateLabel = new System.Windows.Forms.Label();
            memoLabel = new System.Windows.Forms.Label();
            createdLabel = new System.Windows.Forms.Label();
            modifiedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voucherEd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVoucherHDRBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVoucherHDRBindingNavigator)).BeginInit();
            this.tblVoucherHDRBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblVoucherDTLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVoucherDTLDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            label2.ForeColor = System.Drawing.Color.BlueViolet;
            label2.Location = new System.Drawing.Point(193, 43);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(80, 13);
            label2.TabIndex = 32;
            label2.Text = "Voucher Type :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(208, 16);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(54, 13);
            label7.TabIndex = 40;
            label7.Text = "Location :";
            // 
            // voucherIDLabel
            // 
            voucherIDLabel.AutoSize = true;
            voucherIDLabel.Location = new System.Drawing.Point(201, 385);
            voucherIDLabel.Name = "voucherIDLabel";
            voucherIDLabel.Size = new System.Drawing.Size(64, 13);
            voucherIDLabel.TabIndex = 46;
            voucherIDLabel.Text = "Voucher ID:";
            // 
            // voucherNoLabel
            // 
            voucherNoLabel.AutoSize = true;
            voucherNoLabel.Location = new System.Drawing.Point(781, 46);
            voucherNoLabel.Name = "voucherNoLabel";
            voucherNoLabel.Size = new System.Drawing.Size(67, 13);
            voucherNoLabel.TabIndex = 48;
            voucherNoLabel.Text = "Voucher No:";
            // 
            // entryDateLabel
            // 
            entryDateLabel.AutoSize = true;
            entryDateLabel.Location = new System.Drawing.Point(756, 75);
            entryDateLabel.Name = "entryDateLabel";
            entryDateLabel.Size = new System.Drawing.Size(60, 13);
            entryDateLabel.TabIndex = 50;
            entryDateLabel.Text = "Entry Date:";
            // 
            // memoLabel
            // 
            memoLabel.AutoSize = true;
            memoLabel.Location = new System.Drawing.Point(190, 362);
            memoLabel.Name = "memoLabel";
            memoLabel.Size = new System.Drawing.Size(39, 13);
            memoLabel.TabIndex = 52;
            memoLabel.Text = "Memo:";
            // 
            // createdLabel
            // 
            createdLabel.AutoSize = true;
            createdLabel.Location = new System.Drawing.Point(187, 410);
            createdLabel.Name = "createdLabel";
            createdLabel.Size = new System.Drawing.Size(47, 13);
            createdLabel.TabIndex = 58;
            createdLabel.Text = "Created:";
            // 
            // modifiedLabel
            // 
            modifiedLabel.AutoSize = true;
            modifiedLabel.Location = new System.Drawing.Point(634, 412);
            modifiedLabel.Name = "modifiedLabel";
            modifiedLabel.Size = new System.Drawing.Size(50, 13);
            modifiedLabel.TabIndex = 60;
            modifiedLabel.Text = "Modified:";
            // 
            // listVoucher
            // 
            this.listVoucher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listVoucher.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listVoucher.FormattingEnabled = true;
            this.listVoucher.ItemHeight = 15;
            this.listVoucher.Location = new System.Drawing.Point(0, 0);
            this.listVoucher.Name = "listVoucher";
            this.listVoucher.Size = new System.Drawing.Size(164, 450);
            this.listVoucher.TabIndex = 0;
            this.listVoucher.SelectedIndexChanged += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // cboVouType
            // 
            this.cboVouType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVouType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVouType.FormattingEnabled = true;
            this.cboVouType.Items.AddRange(new object[] {
            "JV-Journal Voucher",
            "GPV-Grant Payment Voucher",
            "GRV-Grant Receipt Voucher",
            "SPV-Security Payment Voucher",
            "SRV-Security Receipt Voucher",
            "BPV-Bank Payment Voucher",
            "BRV-Bank Receipt Voucher",
            "CPV-Cash Payment Voucher",
            "CRV-Cash Receipt Voucher"});
            this.cboVouType.Location = new System.Drawing.Point(271, 39);
            this.cboVouType.Name = "cboVouType";
            this.cboVouType.Size = new System.Drawing.Size(266, 21);
            this.cboVouType.TabIndex = 31;
            this.cboVouType.SelectedIndexChanged += new System.EventHandler(this.cboVouType_SelectedIndexChanged);
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
            this.dockPanel1.ID = new System.Guid("e2e66d5c-c5d5-42af-af54-7519f0d22efc");
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(170, 200);
            this.dockPanel1.Size = new System.Drawing.Size(170, 478);
            this.dockPanel1.Text = "Unposted Vouchers";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.listVoucher);
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 25);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(164, 450);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // cbLocation
            // 
            this.cbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.Location = new System.Drawing.Point(271, 12);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(266, 21);
            this.cbLocation.TabIndex = 41;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(193, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(23, 20);
            this.pictureBox6.TabIndex = 42;
            this.pictureBox6.TabStop = false;
            // 
            // voucherEd
            // 
            this.voucherEd.DataSetName = "VoucherEd";
            this.voucherEd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblVoucherHDRBindingSource
            // 
            this.tblVoucherHDRBindingSource.DataMember = "TblVoucherHDR";
            this.tblVoucherHDRBindingSource.DataSource = this.voucherEd;
            // 
            // tblVoucherHDRTableAdapter
            // 
            this.tblVoucherHDRTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TblVoucherDTLTableAdapter = this.tblVoucherDTLTableAdapter;
            this.tableAdapterManager.TblVoucherHDRTableAdapter = this.tblVoucherHDRTableAdapter;
            this.tableAdapterManager.UpdateOrder = AccountSystem.VoucherEdTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblVoucherDTLTableAdapter
            // 
            this.tblVoucherDTLTableAdapter.ClearBeforeFill = true;
            // 
            // tblVoucherHDRBindingNavigator
            // 
            this.tblVoucherHDRBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblVoucherHDRBindingNavigator.BindingSource = this.tblVoucherHDRBindingSource;
            this.tblVoucherHDRBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblVoucherHDRBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblVoucherHDRBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.tblVoucherHDRBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tblVoucherHDRBindingNavigatorSaveItem});
            this.tblVoucherHDRBindingNavigator.Location = new System.Drawing.Point(507, 437);
            this.tblVoucherHDRBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblVoucherHDRBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblVoucherHDRBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblVoucherHDRBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblVoucherHDRBindingNavigator.Name = "tblVoucherHDRBindingNavigator";
            this.tblVoucherHDRBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblVoucherHDRBindingNavigator.Size = new System.Drawing.Size(278, 25);
            this.tblVoucherHDRBindingNavigator.TabIndex = 45;
            this.tblVoucherHDRBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tblVoucherHDRBindingNavigatorSaveItem
            // 
            this.tblVoucherHDRBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblVoucherHDRBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblVoucherHDRBindingNavigatorSaveItem.Image")));
            this.tblVoucherHDRBindingNavigatorSaveItem.Name = "tblVoucherHDRBindingNavigatorSaveItem";
            this.tblVoucherHDRBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tblVoucherHDRBindingNavigatorSaveItem.Text = "Save Data";
            this.tblVoucherHDRBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblVoucherHDRBindingNavigatorSaveItem_Click_1);
            // 
            // voucherIDTextBox
            // 
            this.voucherIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblVoucherHDRBindingSource, "VoucherID", true));
            this.voucherIDTextBox.Enabled = false;
            this.voucherIDTextBox.Location = new System.Drawing.Point(271, 382);
            this.voucherIDTextBox.Name = "voucherIDTextBox";
            this.voucherIDTextBox.ReadOnly = true;
            this.voucherIDTextBox.Size = new System.Drawing.Size(101, 20);
            this.voucherIDTextBox.TabIndex = 47;
            // 
            // voucherNoTextBox
            // 
            this.voucherNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblVoucherHDRBindingSource, "VoucherNo", true));
            this.voucherNoTextBox.Location = new System.Drawing.Point(862, 43);
            this.voucherNoTextBox.Name = "voucherNoTextBox";
            this.voucherNoTextBox.ReadOnly = true;
            this.voucherNoTextBox.Size = new System.Drawing.Size(91, 20);
            this.voucherNoTextBox.TabIndex = 49;
            // 
            // entryDateDateTimePicker
            // 
            this.entryDateDateTimePicker.CustomFormat = "ddMMMMyyyy";
            this.entryDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblVoucherHDRBindingSource, "EntryDate", true));
            this.entryDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.entryDateDateTimePicker.Location = new System.Drawing.Point(822, 71);
            this.entryDateDateTimePicker.Name = "entryDateDateTimePicker";
            this.entryDateDateTimePicker.Size = new System.Drawing.Size(131, 20);
            this.entryDateDateTimePicker.TabIndex = 51;
            // 
            // memoTextBox
            // 
            this.memoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblVoucherHDRBindingSource, "Memo", true));
            this.memoTextBox.Location = new System.Drawing.Point(271, 359);
            this.memoTextBox.Name = "memoTextBox";
            this.memoTextBox.Size = new System.Drawing.Size(200, 20);
            this.memoTextBox.TabIndex = 53;
            // 
            // createdLabel1
            // 
            this.createdLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblVoucherHDRBindingSource, "Created", true));
            this.createdLabel1.Location = new System.Drawing.Point(268, 410);
            this.createdLabel1.Name = "createdLabel1";
            this.createdLabel1.Size = new System.Drawing.Size(200, 12);
            this.createdLabel1.TabIndex = 59;
            this.createdLabel1.Text = "label1";
            // 
            // modifiedLabel1
            // 
            this.modifiedLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblVoucherHDRBindingSource, "Modified", true));
            this.modifiedLabel1.Location = new System.Drawing.Point(715, 410);
            this.modifiedLabel1.Name = "modifiedLabel1";
            this.modifiedLabel1.Size = new System.Drawing.Size(200, 17);
            this.modifiedLabel1.TabIndex = 61;
            this.modifiedLabel1.Text = "label1";
            // 
            // tblVoucherDTLBindingSource
            // 
            this.tblVoucherDTLBindingSource.DataMember = "FK_TblVoucherID";
            this.tblVoucherDTLBindingSource.DataSource = this.tblVoucherHDRBindingSource;
            // 
            // tblVoucherDTLDataGridView
            // 
            this.tblVoucherDTLDataGridView.AutoGenerateColumns = false;
            this.tblVoucherDTLDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tblVoucherDTLDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tblVoucherDTLDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblVoucherDTLDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdCboAccHeads,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn1});
            this.tblVoucherDTLDataGridView.DataSource = this.tblVoucherDTLBindingSource;
            this.tblVoucherDTLDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.tblVoucherDTLDataGridView.Location = new System.Drawing.Point(193, 102);
            this.tblVoucherDTLDataGridView.Name = "tblVoucherDTLDataGridView";
            this.tblVoucherDTLDataGridView.RowHeadersVisible = false;
            this.tblVoucherDTLDataGridView.Size = new System.Drawing.Size(781, 251);
            this.tblVoucherDTLDataGridView.TabIndex = 65;
            // 
            // grdCboAccHeads
            // 
            this.grdCboAccHeads.DataPropertyName = "AccEntryID";
            this.grdCboAccHeads.HeaderText = "AccEntryID";
            this.grdCboAccHeads.Name = "grdCboAccHeads";
            this.grdCboAccHeads.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grdCboAccHeads.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.grdCboAccHeads.Width = 250;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Ref";
            this.dataGridViewTextBoxColumn7.HeaderText = "Ref";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn3.HeaderText = "Description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 250;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "AmountDeb";
            this.dataGridViewTextBoxColumn4.HeaderText = "AmountDeb";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "AmountCre";
            this.dataGridViewTextBoxColumn5.HeaderText = "AmountCre";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Repli";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Repli";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn6.HeaderText = "ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "VoucherID";
            this.dataGridViewTextBoxColumn1.HeaderText = "VoucherID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // frmVoucherED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 478);
            this.Controls.Add(this.tblVoucherDTLDataGridView);
            this.Controls.Add(voucherIDLabel);
            this.Controls.Add(this.voucherIDTextBox);
            this.Controls.Add(voucherNoLabel);
            this.Controls.Add(this.voucherNoTextBox);
            this.Controls.Add(entryDateLabel);
            this.Controls.Add(this.entryDateDateTimePicker);
            this.Controls.Add(memoLabel);
            this.Controls.Add(this.memoTextBox);
            this.Controls.Add(createdLabel);
            this.Controls.Add(this.createdLabel1);
            this.Controls.Add(modifiedLabel);
            this.Controls.Add(this.modifiedLabel1);
            this.Controls.Add(this.tblVoucherHDRBindingNavigator);
            this.Controls.Add(this.cbLocation);
            this.Controls.Add(label7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.cboVouType);
            this.Controls.Add(label2);
            this.Controls.Add(this.dockPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVoucherED";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voucher Posting";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVoucher_FormClosing);
            this.Load += new System.EventHandler(this.frmVoucher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voucherEd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVoucherHDRBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVoucherHDRBindingNavigator)).EndInit();
            this.tblVoucherHDRBindingNavigator.ResumeLayout(false);
            this.tblVoucherHDRBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblVoucherDTLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVoucherDTLDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listVoucher;
        private System.Windows.Forms.ComboBox cboVouType;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private System.Windows.Forms.ComboBox cbLocation;
        internal System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.BindingNavigator tblVoucherHDRBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.BindingSource tblVoucherHDRBindingSource;
        private VoucherEd voucherEd;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tblVoucherHDRBindingNavigatorSaveItem;
        private VoucherEdTableAdapters.TblVoucherHDRTableAdapter tblVoucherHDRTableAdapter;
        private VoucherEdTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox voucherIDTextBox;
        private System.Windows.Forms.TextBox voucherNoTextBox;
        private System.Windows.Forms.DateTimePicker entryDateDateTimePicker;
        private System.Windows.Forms.TextBox memoTextBox;
        private System.Windows.Forms.Label createdLabel1;
        private System.Windows.Forms.Label modifiedLabel1;
        private VoucherEdTableAdapters.TblVoucherDTLTableAdapter tblVoucherDTLTableAdapter;
        private System.Windows.Forms.BindingSource tblVoucherDTLBindingSource;
        private System.Windows.Forms.DataGridView tblVoucherDTLDataGridView;
        private System.Windows.Forms.DataGridViewComboBoxColumn grdCboAccHeads;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}