namespace AccountSystem
{
    partial class frmVoucher
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
            System.Windows.Forms.Label voucherIDLabel;
            System.Windows.Forms.Label voucherno;
            System.Windows.Forms.Label entryDateLabel;
            System.Windows.Forms.Label bankIDLabel;
            System.Windows.Forms.Label cheqNoLabel;
            System.Windows.Forms.Label drawingDateLabel;
            System.Windows.Forms.Label createdLabel;
            System.Windows.Forms.Label modifiedLabel;
            System.Windows.Forms.Label repliLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label companyIDLabel;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVoucher));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.voucherDS = new AccountSystem.VoucherDS();
            this.tblVoucherHDRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblVoucherHDRTableAdapter = new AccountSystem.VoucherDSTableAdapters.TblVoucherHDRTableAdapter();
            this.tableAdapterManager = new AccountSystem.VoucherDSTableAdapters.TableAdapterManager();
            this.tblVoucherDTLTableAdapter = new AccountSystem.VoucherDSTableAdapters.TblVoucherDTLTableAdapter();
            this.tblVoucherHDRBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tblVoucherHDRBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.PrintVoucher = new System.Windows.Forms.ToolStripButton();
            this.voucherIDTextBox = new System.Windows.Forms.TextBox();
            this.voucherN = new System.Windows.Forms.TextBox();
            this.entryDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bankIDTextBox = new System.Windows.Forms.TextBox();
            this.cheqNoTextBox = new System.Windows.Forms.TextBox();
            this.drawingDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.createdTextBox = new System.Windows.Forms.TextBox();
            this.modifiedTextBox = new System.Windows.Forms.TextBox();
            this.repliCheckBox = new System.Windows.Forms.CheckBox();
            this.tblVoucherDTLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblVoucherDTLDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboEntryAcc = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblTCr = new System.Windows.Forms.Label();
            this.lblTDr = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtOpenCash = new System.Windows.Forms.TextBox();
            this.lblinWords = new System.Windows.Forms.Label();
            this.companyIDTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboVouType = new System.Windows.Forms.ComboBox();
            voucherIDLabel = new System.Windows.Forms.Label();
            voucherno = new System.Windows.Forms.Label();
            entryDateLabel = new System.Windows.Forms.Label();
            bankIDLabel = new System.Windows.Forms.Label();
            cheqNoLabel = new System.Windows.Forms.Label();
            drawingDateLabel = new System.Windows.Forms.Label();
            createdLabel = new System.Windows.Forms.Label();
            modifiedLabel = new System.Windows.Forms.Label();
            repliLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            companyIDLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.voucherDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVoucherHDRBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVoucherHDRBindingNavigator)).BeginInit();
            this.tblVoucherHDRBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblVoucherDTLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVoucherDTLDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // voucherIDLabel
            // 
            voucherIDLabel.AutoSize = true;
            voucherIDLabel.Location = new System.Drawing.Point(50, 125);
            voucherIDLabel.Name = "voucherIDLabel";
            voucherIDLabel.Size = new System.Drawing.Size(64, 13);
            voucherIDLabel.TabIndex = 1;
            voucherIDLabel.Text = "Voucher ID:";
            voucherIDLabel.Visible = false;
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
            // cheqNoLabel
            // 
            cheqNoLabel.AutoSize = true;
            cheqNoLabel.Location = new System.Drawing.Point(50, 91);
            cheqNoLabel.Name = "cheqNoLabel";
            cheqNoLabel.Size = new System.Drawing.Size(52, 13);
            cheqNoLabel.TabIndex = 9;
            cheqNoLabel.Text = "Cheq No:";
            cheqNoLabel.Visible = false;
            // 
            // drawingDateLabel
            // 
            drawingDateLabel.AutoSize = true;
            drawingDateLabel.Location = new System.Drawing.Point(50, 66);
            drawingDateLabel.Name = "drawingDateLabel";
            drawingDateLabel.Size = new System.Drawing.Size(75, 13);
            drawingDateLabel.TabIndex = 11;
            drawingDateLabel.Text = "Drawing Date:";
            drawingDateLabel.Visible = false;
            // 
            // createdLabel
            // 
            createdLabel.AutoSize = true;
            createdLabel.Location = new System.Drawing.Point(41, 554);
            createdLabel.Name = "createdLabel";
            createdLabel.Size = new System.Drawing.Size(47, 13);
            createdLabel.TabIndex = 14;
            createdLabel.Text = "Created:";
            // 
            // modifiedLabel
            // 
            modifiedLabel.AutoSize = true;
            modifiedLabel.Location = new System.Drawing.Point(538, 554);
            modifiedLabel.Name = "modifiedLabel";
            modifiedLabel.Size = new System.Drawing.Size(50, 13);
            modifiedLabel.TabIndex = 16;
            modifiedLabel.Text = "Modified:";
            // 
            // repliLabel
            // 
            repliLabel.AutoSize = true;
            repliLabel.Location = new System.Drawing.Point(495, 322);
            repliLabel.Name = "repliLabel";
            repliLabel.Size = new System.Drawing.Size(34, 13);
            repliLabel.TabIndex = 12;
            repliLabel.Text = "Repli:";
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
            // companyIDLabel
            // 
            companyIDLabel.AutoSize = true;
            companyIDLabel.Location = new System.Drawing.Point(59, 151);
            companyIDLabel.Name = "companyIDLabel";
            companyIDLabel.Size = new System.Drawing.Size(68, 13);
            companyIDLabel.TabIndex = 26;
            companyIDLabel.Text = "Company ID:";
            companyIDLabel.Visible = false;
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
            // voucherDS
            // 
            this.voucherDS.DataSetName = "VoucherDS";
            this.voucherDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblVoucherHDRBindingSource
            // 
            this.tblVoucherHDRBindingSource.DataMember = "TblVoucherHDR";
            this.tblVoucherHDRBindingSource.DataSource = this.voucherDS;
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
            this.tableAdapterManager.UpdateOrder = AccountSystem.VoucherDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblVoucherDTLTableAdapter
            // 
            this.tblVoucherDTLTableAdapter.ClearBeforeFill = true;
            // 
            // tblVoucherHDRBindingNavigator
            // 
            this.tblVoucherHDRBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblVoucherHDRBindingNavigator.AutoSize = false;
            this.tblVoucherHDRBindingNavigator.BackColor = System.Drawing.Color.White;
            this.tblVoucherHDRBindingNavigator.BindingSource = this.tblVoucherHDRBindingSource;
            this.tblVoucherHDRBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblVoucherHDRBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblVoucherHDRBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tblVoucherHDRBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tblVoucherHDRBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.toolStripButton1,
            this.toolStripLabel1,
            this.tblVoucherHDRBindingNavigatorSaveItem,
            this.toolStripLabel2,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorAddNewItem,
            this.toolStripLabel4,
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.PrintVoucher});
            this.tblVoucherHDRBindingNavigator.Location = new System.Drawing.Point(0, 574);
            this.tblVoucherHDRBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblVoucherHDRBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblVoucherHDRBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblVoucherHDRBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblVoucherHDRBindingNavigator.Name = "tblVoucherHDRBindingNavigator";
            this.tblVoucherHDRBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblVoucherHDRBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tblVoucherHDRBindingNavigator.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tblVoucherHDRBindingNavigator.Size = new System.Drawing.Size(793, 28);
            this.tblVoucherHDRBindingNavigator.TabIndex = 18;
            this.tblVoucherHDRBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(74, 25);
            this.bindingNavigatorAddNewItem.Text = "&Add new";
            this.bindingNavigatorAddNewItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 25);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            this.bindingNavigatorCountItem.Visible = false;
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 25);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Visible = false;
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(139, 25);
            this.toolStripLabel3.Text = "                                            ";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(56, 25);
            this.toolStripButton1.Text = "&Close";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(13, 25);
            this.toolStripLabel1.Text = "  ";
            // 
            // tblVoucherHDRBindingNavigatorSaveItem
            // 
            this.tblVoucherHDRBindingNavigatorSaveItem.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.tblVoucherHDRBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblVoucherHDRBindingNavigatorSaveItem.Image")));
            this.tblVoucherHDRBindingNavigatorSaveItem.Name = "tblVoucherHDRBindingNavigatorSaveItem";
            this.tblVoucherHDRBindingNavigatorSaveItem.Size = new System.Drawing.Size(78, 25);
            this.tblVoucherHDRBindingNavigatorSaveItem.Text = "&Save Data";
            this.tblVoucherHDRBindingNavigatorSaveItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tblVoucherHDRBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblVoucherHDRBindingNavigatorSaveItem_Click);
            this.tblVoucherHDRBindingNavigatorSaveItem.MouseHover += new System.EventHandler(this.tblVoucherHDRBindingNavigatorSaveItem_MouseHover);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(13, 25);
            this.toolStripLabel2.Text = "  ";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(13, 25);
            this.toolStripLabel4.Text = "  ";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 25);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            this.bindingNavigatorMoveFirstItem.Visible = false;
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 25);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            this.bindingNavigatorMovePreviousItem.Visible = false;
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 28);
            this.bindingNavigatorSeparator.Visible = false;
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            this.bindingNavigatorPositionItem.Visible = false;
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 28);
            this.bindingNavigatorSeparator1.Visible = false;
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 25);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            this.bindingNavigatorMoveNextItem.Visible = false;
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 25);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            this.bindingNavigatorMoveLastItem.Visible = false;
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 28);
            this.bindingNavigatorSeparator2.Visible = false;
            // 
            // PrintVoucher
            // 
            this.PrintVoucher.Image = ((System.Drawing.Image)(resources.GetObject("PrintVoucher.Image")));
            this.PrintVoucher.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PrintVoucher.Name = "PrintVoucher";
            this.PrintVoucher.Size = new System.Drawing.Size(98, 25);
            this.PrintVoucher.Text = "&Print Voucher";
            this.PrintVoucher.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.PrintVoucher.Click += new System.EventHandler(this.PrintVoucher_Click);
            // 
            // voucherIDTextBox
            // 
            this.voucherIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblVoucherHDRBindingSource, "VoucherID", true));
            this.voucherIDTextBox.Location = new System.Drawing.Point(97, 30);
            this.voucherIDTextBox.Name = "voucherIDTextBox";
            this.voucherIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.voucherIDTextBox.TabIndex = 2;
            // 
            // voucherN
            // 
            this.voucherN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblVoucherHDRBindingSource, "VoucherNo", true));
            this.voucherN.Location = new System.Drawing.Point(131, 49);
            this.voucherN.Name = "voucherN";
            this.voucherN.ReadOnly = true;
            this.voucherN.Size = new System.Drawing.Size(142, 20);
            this.voucherN.TabIndex = 2;
            // 
            // entryDateDateTimePicker
            // 
            this.entryDateDateTimePicker.CustomFormat = "ddMMMMyyyy";
            this.entryDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblVoucherHDRBindingSource, "EntryDate", true));
            this.entryDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.entryDateDateTimePicker.Location = new System.Drawing.Point(572, 49);
            this.entryDateDateTimePicker.Name = "entryDateDateTimePicker";
            this.entryDateDateTimePicker.Size = new System.Drawing.Size(146, 20);
            this.entryDateDateTimePicker.TabIndex = 6;
            // 
            // bankIDTextBox
            // 
            this.bankIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblVoucherHDRBindingSource, "Memo", true));
            this.bankIDTextBox.Location = new System.Drawing.Point(52, 99);
            this.bankIDTextBox.MaxLength = 250;
            this.bankIDTextBox.Multiline = true;
            this.bankIDTextBox.Name = "bankIDTextBox";
            this.bankIDTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.bankIDTextBox.Size = new System.Drawing.Size(566, 33);
            this.bankIDTextBox.TabIndex = 4;
            // 
            // cheqNoTextBox
            // 
            this.cheqNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblVoucherHDRBindingSource, "CheqNo", true));
            this.cheqNoTextBox.Location = new System.Drawing.Point(133, 88);
            this.cheqNoTextBox.Name = "cheqNoTextBox";
            this.cheqNoTextBox.Size = new System.Drawing.Size(200, 20);
            this.cheqNoTextBox.TabIndex = 10;
            this.cheqNoTextBox.Visible = false;
            // 
            // drawingDateDateTimePicker
            // 
            this.drawingDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblVoucherHDRBindingSource, "DrawingDate", true));
            this.drawingDateDateTimePicker.Location = new System.Drawing.Point(133, 62);
            this.drawingDateDateTimePicker.Name = "drawingDateDateTimePicker";
            this.drawingDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.drawingDateDateTimePicker.TabIndex = 12;
            this.drawingDateDateTimePicker.Visible = false;
            // 
            // createdTextBox
            // 
            this.createdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.createdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblVoucherHDRBindingSource, "Created", true));
            this.createdTextBox.Location = new System.Drawing.Point(94, 554);
            this.createdTextBox.Name = "createdTextBox";
            this.createdTextBox.ReadOnly = true;
            this.createdTextBox.Size = new System.Drawing.Size(173, 13);
            this.createdTextBox.TabIndex = 15;
            // 
            // modifiedTextBox
            // 
            this.modifiedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modifiedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblVoucherHDRBindingSource, "Modified", true));
            this.modifiedTextBox.Location = new System.Drawing.Point(588, 554);
            this.modifiedTextBox.Name = "modifiedTextBox";
            this.modifiedTextBox.ReadOnly = true;
            this.modifiedTextBox.Size = new System.Drawing.Size(155, 13);
            this.modifiedTextBox.TabIndex = 17;
            // 
            // repliCheckBox
            // 
            this.repliCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tblVoucherHDRBindingSource, "Repli", true));
            this.repliCheckBox.Location = new System.Drawing.Point(578, 317);
            this.repliCheckBox.Name = "repliCheckBox";
            this.repliCheckBox.Size = new System.Drawing.Size(200, 24);
            this.repliCheckBox.TabIndex = 13;
            this.repliCheckBox.Text = "checkBox1";
            this.repliCheckBox.UseVisualStyleBackColor = true;
            // 
            // tblVoucherDTLBindingSource
            // 
            this.tblVoucherDTLBindingSource.DataMember = "TblVoucherHDR_TblVoucherDTL";
            this.tblVoucherDTLBindingSource.DataSource = this.tblVoucherHDRBindingSource;
            // 
            // tblVoucherDTLDataGridView
            // 
            this.tblVoucherDTLDataGridView.AllowUserToResizeColumns = false;
            this.tblVoucherDTLDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblVoucherDTLDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tblVoucherDTLDataGridView.AutoGenerateColumns = false;
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
            this.dataGridViewTextBoxColumn1,
            this.cboEntryAcc,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.X,
            this.dataGridViewCheckBoxColumn1});
            this.tblVoucherDTLDataGridView.DataSource = this.tblVoucherDTLBindingSource;
            this.tblVoucherDTLDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.tblVoucherDTLDataGridView.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.tblVoucherDTLDataGridView.Location = new System.Drawing.Point(56, 160);
            this.tblVoucherDTLDataGridView.Name = "tblVoucherDTLDataGridView";
            this.tblVoucherDTLDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tblVoucherDTLDataGridView.RowHeadersVisible = false;
            this.tblVoucherDTLDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tblVoucherDTLDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tblVoucherDTLDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.tblVoucherDTLDataGridView.Size = new System.Drawing.Size(737, 328);
            this.tblVoucherDTLDataGridView.TabIndex = 9;
            this.tblVoucherDTLDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblVoucherDTLDataGridView_CellClick);
            this.tblVoucherDTLDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblVoucherDTLDataGridView_CellEndEdit);
            this.tblVoucherDTLDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.tblVoucherDTLDataGridView_CellFormatting);
            this.tblVoucherDTLDataGridView.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tblVoucherDTLDataGridView_CellMouseMove);
            this.tblVoucherDTLDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblVoucherDTLDataGridView_CellValueChanged);
            this.tblVoucherDTLDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.tblVoucherDTLDataGridView_DataError);
            this.tblVoucherDTLDataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.tblVoucherDTLDataGridView_EditingControlShowing);
            this.tblVoucherDTLDataGridView.Enter += new System.EventHandler(this.tblVoucherDTLDataGridView_Enter);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "VoucherID";
            this.dataGridViewTextBoxColumn1.HeaderText = "VoucherID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // cboEntryAcc
            // 
            this.cboEntryAcc.DataPropertyName = "AccEntryID";
            this.cboEntryAcc.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.cboEntryAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboEntryAcc.HeaderText = "Account Code";
            this.cboEntryAcc.Name = "cboEntryAcc";
            this.cboEntryAcc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cboEntryAcc.Width = 220;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Description";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn3.HeaderText = "Description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 300;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "AmountDeb";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn4.HeaderText = "Dr.";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "AmountCre";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn5.HeaderText = "Cr.";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // X
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.X.DefaultCellStyle = dataGridViewCellStyle6;
            this.X.HeaderText = "";
            this.X.Image = global::AccountSystem.Properties.Resources.close;
            this.X.Name = "X";
            this.X.Width = 20;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Repli";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Repli";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Visible = false;
            // 
            // lblTCr
            // 
            this.lblTCr.BackColor = System.Drawing.Color.White;
            this.lblTCr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTCr.Location = new System.Drawing.Point(555, 503);
            this.lblTCr.Name = "lblTCr";
            this.lblTCr.Size = new System.Drawing.Size(75, 13);
            this.lblTCr.TabIndex = 10;
            this.lblTCr.Text = "00";
            // 
            // lblTDr
            // 
            this.lblTDr.BackColor = System.Drawing.Color.White;
            this.lblTDr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTDr.Location = new System.Drawing.Point(640, 503);
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
            this.pictureBox1.Location = new System.Drawing.Point(69, 493);
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
            // companyIDTextBox
            // 
            this.companyIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblVoucherHDRBindingSource, "CompanyID", true));
            this.companyIDTextBox.Location = new System.Drawing.Point(445, 284);
            this.companyIDTextBox.Name = "companyIDTextBox";
            this.companyIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.companyIDTextBox.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.voucherIDTextBox);
            this.groupBox1.Controls.Add(this.drawingDateDateTimePicker);
            this.groupBox1.Controls.Add(companyIDLabel);
            this.groupBox1.Controls.Add(drawingDateLabel);
            this.groupBox1.Controls.Add(this.cheqNoTextBox);
            this.groupBox1.Controls.Add(cheqNoLabel);
            this.groupBox1.Controls.Add(voucherIDLabel);
            this.groupBox1.Location = new System.Drawing.Point(164, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 216);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
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
            // frmVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 602);
            this.Controls.Add(label2);
            this.Controls.Add(this.cboVouType);
            this.Controls.Add(label1);
            this.Controls.Add(this.txtOpenCash);
            this.Controls.Add(this.lblTDr);
            this.Controls.Add(this.lblTCr);
            this.Controls.Add(this.tblVoucherDTLDataGridView);
            this.Controls.Add(this.voucherN);
            this.Controls.Add(entryDateLabel);
            this.Controls.Add(this.entryDateDateTimePicker);
            this.Controls.Add(bankIDLabel);
            this.Controls.Add(this.bankIDTextBox);
            this.Controls.Add(createdLabel);
            this.Controls.Add(this.createdTextBox);
            this.Controls.Add(modifiedLabel);
            this.Controls.Add(this.modifiedTextBox);
            this.Controls.Add(repliLabel);
            this.Controls.Add(this.repliCheckBox);
            this.Controls.Add(this.tblVoucherHDRBindingNavigator);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblinWords);
            this.Controls.Add(voucherno);
            this.Controls.Add(this.companyIDTextBox);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVoucher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Journal Voucher";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVoucher_FormClosing);
            this.Load += new System.EventHandler(this.frmVoucher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.voucherDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVoucherHDRBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVoucherHDRBindingNavigator)).EndInit();
            this.tblVoucherHDRBindingNavigator.ResumeLayout(false);
            this.tblVoucherHDRBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblVoucherDTLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVoucherDTLDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VoucherDS voucherDS;
        private System.Windows.Forms.BindingSource tblVoucherHDRBindingSource;
        private VoucherDSTableAdapters.TblVoucherHDRTableAdapter tblVoucherHDRTableAdapter;
        private VoucherDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblVoucherHDRBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
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
        private VoucherDSTableAdapters.TblVoucherDTLTableAdapter tblVoucherDTLTableAdapter;
        private System.Windows.Forms.TextBox voucherIDTextBox;
        private System.Windows.Forms.TextBox voucherN;
        private System.Windows.Forms.DateTimePicker entryDateDateTimePicker;
        private System.Windows.Forms.TextBox bankIDTextBox;
        private System.Windows.Forms.TextBox cheqNoTextBox;
        private System.Windows.Forms.DateTimePicker drawingDateDateTimePicker;
        private System.Windows.Forms.TextBox createdTextBox;
        private System.Windows.Forms.TextBox modifiedTextBox;
        private System.Windows.Forms.CheckBox repliCheckBox;
        private System.Windows.Forms.BindingSource tblVoucherDTLBindingSource;
        private System.Windows.Forms.DataGridView tblVoucherDTLDataGridView;
        private System.Windows.Forms.Label lblTCr;
        private System.Windows.Forms.Label lblTDr;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.TextBox txtOpenCash;
        private System.Windows.Forms.Label lblinWords;
        private System.Windows.Forms.TextBox companyIDTextBox;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton PrintVoucher;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboVouType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn cboEntryAcc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewImageColumn X;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}