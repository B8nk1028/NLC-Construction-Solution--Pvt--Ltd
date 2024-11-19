namespace AccountSystem
{
    partial class frmYearCls
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
            System.Windows.Forms.Label compIDLabel;
            System.Windows.Forms.Label createdLabel;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYearCls));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textDate = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tblMonthCloseingBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tblMonthCloseingBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.compIDTextBox = new System.Windows.Forms.TextBox();
            this.createdTextBox = new System.Windows.Forms.TextBox();
            this.wHTaxTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.codeStRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cboOpeningRet = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cboCrDr = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboSales = new System.Windows.Forms.ComboBox();
            this.cboPurchases = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTC = new System.Windows.Forms.RichTextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tblMonthCloseingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.settingDS = new AccountSystem.SettingDS();
            this.tblMonthCloseingTableAdapter = new AccountSystem.SettingDSTableAdapters.tblMonthCloseingTableAdapter();
            this.tableAdapterManager = new AccountSystem.SettingDSTableAdapters.TableAdapterManager();
            compIDLabel = new System.Windows.Forms.Label();
            createdLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblMonthCloseingBindingNavigator)).BeginInit();
            this.tblMonthCloseingBindingNavigator.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblMonthCloseingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingDS)).BeginInit();
            this.SuspendLayout();
            // 
            // compIDLabel
            // 
            compIDLabel.AutoSize = true;
            compIDLabel.Location = new System.Drawing.Point(101, 58);
            compIDLabel.Name = "compIDLabel";
            compIDLabel.Size = new System.Drawing.Size(51, 13);
            compIDLabel.TabIndex = 10;
            compIDLabel.Text = "Comp ID:";
            // 
            // createdLabel
            // 
            createdLabel.AutoSize = true;
            createdLabel.Location = new System.Drawing.Point(719, 430);
            createdLabel.Name = "createdLabel";
            createdLabel.Size = new System.Drawing.Size(72, 13);
            createdLabel.TabIndex = 11;
            createdLabel.Text = "Last Changes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(8, 25);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(36, 13);
            label3.TabIndex = 14;
            label3.Text = "%age:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimePicker1.CustomFormat = "MMMMyyyy";
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblMonthCloseingBindingSource, "AccYear", true));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 39);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(117, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Value = new System.DateTime(2011, 7, 1, 17, 58, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Active Accounting Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Active Month";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "MMMMyyyy";
            this.dateTimePicker3.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblMonthCloseingBindingSource, "AMonth", true));
            this.dateTimePicker3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblMonthCloseingBindingSource, "AMonth", true));
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(81, 19);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.ShowUpDown = true;
            this.dateTimePicker3.Size = new System.Drawing.Size(119, 20);
            this.dateTimePicker3.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textDate);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 71);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set Accounting Year";
            // 
            // textDate
            // 
            this.textDate.Location = new System.Drawing.Point(130, 39);
            this.textDate.Name = "textDate";
            this.textDate.ReadOnly = true;
            this.textDate.Size = new System.Drawing.Size(111, 20);
            this.textDate.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(34, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 48);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Set Active Month";
            // 
            // tblMonthCloseingBindingNavigator
            // 
            this.tblMonthCloseingBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblMonthCloseingBindingNavigator.BindingSource = this.tblMonthCloseingBindingSource;
            this.tblMonthCloseingBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblMonthCloseingBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblMonthCloseingBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tblMonthCloseingBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tblMonthCloseingBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.toolStripLabel2,
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
            this.btnClose,
            this.toolStripLabel1,
            this.tblMonthCloseingBindingNavigatorSaveItem});
            this.tblMonthCloseingBindingNavigator.Location = new System.Drawing.Point(0, 451);
            this.tblMonthCloseingBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblMonthCloseingBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblMonthCloseingBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblMonthCloseingBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblMonthCloseingBindingNavigator.Name = "tblMonthCloseingBindingNavigator";
            this.tblMonthCloseingBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblMonthCloseingBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tblMonthCloseingBindingNavigator.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tblMonthCloseingBindingNavigator.Size = new System.Drawing.Size(1065, 25);
            this.tblMonthCloseingBindingNavigator.TabIndex = 10;
            this.tblMonthCloseingBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Visible = false;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Visible = false;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            this.bindingNavigatorMoveFirstItem.Visible = false;
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(40, 22);
            this.toolStripLabel2.Text = "           ";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            this.bindingNavigatorMovePreviousItem.Visible = false;
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            this.bindingNavigatorSeparator1.Visible = false;
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            this.bindingNavigatorMoveNextItem.Visible = false;
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            this.bindingNavigatorMoveLastItem.Visible = false;
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            this.bindingNavigatorSeparator2.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.ForeColor = System.Drawing.Color.Brown;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 22);
            this.btnClose.Text = "&Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(16, 22);
            this.toolStripLabel1.Text = "   ";
            // 
            // tblMonthCloseingBindingNavigatorSaveItem
            // 
            this.tblMonthCloseingBindingNavigatorSaveItem.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tblMonthCloseingBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblMonthCloseingBindingNavigatorSaveItem.Image")));
            this.tblMonthCloseingBindingNavigatorSaveItem.Name = "tblMonthCloseingBindingNavigatorSaveItem";
            this.tblMonthCloseingBindingNavigatorSaveItem.Size = new System.Drawing.Size(78, 22);
            this.tblMonthCloseingBindingNavigatorSaveItem.Text = "Save Data";
            this.tblMonthCloseingBindingNavigatorSaveItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tblMonthCloseingBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblMonthCloseingBindingNavigatorSaveItem_Click);
            // 
            // compIDTextBox
            // 
            this.compIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblMonthCloseingBindingSource, "CompID", true));
            this.compIDTextBox.Location = new System.Drawing.Point(158, 55);
            this.compIDTextBox.Name = "compIDTextBox";
            this.compIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.compIDTextBox.TabIndex = 11;
            // 
            // createdTextBox
            // 
            this.createdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.createdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblMonthCloseingBindingSource, "Created", true));
            this.createdTextBox.Location = new System.Drawing.Point(797, 430);
            this.createdTextBox.Name = "createdTextBox";
            this.createdTextBox.ReadOnly = true;
            this.createdTextBox.Size = new System.Drawing.Size(256, 13);
            this.createdTextBox.TabIndex = 12;
            // 
            // wHTaxTextBox
            // 
            this.wHTaxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblMonthCloseingBindingSource, "WHTax", true));
            this.wHTaxTextBox.Location = new System.Drawing.Point(49, 21);
            this.wHTaxTextBox.Name = "wHTaxTextBox";
            this.wHTaxTextBox.Size = new System.Drawing.Size(100, 20);
            this.wHTaxTextBox.TabIndex = 13;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(label3);
            this.groupBox3.Controls.Add(this.wHTaxTextBox);
            this.groupBox3.Location = new System.Drawing.Point(416, 149);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(180, 53);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "WithHolding Tax";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.radioButton1);
            this.groupBox4.Controls.Add(this.codeStRadioButton);
            this.groupBox4.Location = new System.Drawing.Point(416, 41);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(249, 100);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Account Display";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "e.g. Cash in Hand 01-002-0001";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "e.g. 01-002-0001 Cash in Hand";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(14, 59);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(136, 17);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "[Account Name] [Code]";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // codeStRadioButton
            // 
            this.codeStRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.tblMonthCloseingBindingSource, "CodeSt", true));
            this.codeStRadioButton.Location = new System.Drawing.Point(14, 22);
            this.codeStRadioButton.Name = "codeStRadioButton";
            this.codeStRadioButton.Size = new System.Drawing.Size(148, 24);
            this.codeStRadioButton.TabIndex = 3;
            this.codeStRadioButton.TabStop = true;
            this.codeStRadioButton.Text = "[Code] [Account Name]";
            this.codeStRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cboOpeningRet);
            this.groupBox5.Location = new System.Drawing.Point(34, 238);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(273, 49);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Opening Retained Earnings/Exp.";
            // 
            // cboOpeningRet
            // 
            this.cboOpeningRet.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblMonthCloseingBindingSource, "RetOpen", true));
            this.cboOpeningRet.FormattingEnabled = true;
            this.cboOpeningRet.Location = new System.Drawing.Point(9, 18);
            this.cboOpeningRet.Name = "cboOpeningRet";
            this.cboOpeningRet.Size = new System.Drawing.Size(250, 21);
            this.cboOpeningRet.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cboCrDr);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.cboSales);
            this.groupBox6.Controls.Add(this.cboPurchases);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Location = new System.Drawing.Point(34, 306);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(273, 142);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            // 
            // cboCrDr
            // 
            this.cboCrDr.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblMonthCloseingBindingSource, "DrCr", true));
            this.cboCrDr.FormattingEnabled = true;
            this.cboCrDr.Location = new System.Drawing.Point(11, 116);
            this.cboCrDr.Name = "cboCrDr";
            this.cboCrDr.Size = new System.Drawing.Size(230, 21);
            this.cboCrDr.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Debitors && Creditors";
            // 
            // cboSales
            // 
            this.cboSales.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblMonthCloseingBindingSource, "Sales", true));
            this.cboSales.FormattingEnabled = true;
            this.cboSales.Location = new System.Drawing.Point(11, 76);
            this.cboSales.Name = "cboSales";
            this.cboSales.Size = new System.Drawing.Size(230, 21);
            this.cboSales.TabIndex = 0;
            // 
            // cboPurchases
            // 
            this.cboPurchases.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblMonthCloseingBindingSource, "Purchases", true));
            this.cboPurchases.FormattingEnabled = true;
            this.cboPurchases.Location = new System.Drawing.Point(11, 34);
            this.cboPurchases.Name = "cboPurchases";
            this.cboPurchases.Size = new System.Drawing.Size(230, 21);
            this.cboPurchases.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Inventory Purchases";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Inventory Sales";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(880, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 0);
            this.button1.TabIndex = 18;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtTC
            // 
            this.txtTC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblMonthCloseingBindingSource, "TermsCond", true));
            this.txtTC.Location = new System.Drawing.Point(6, 18);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(523, 171);
            this.txtTC.TabIndex = 19;
            this.txtTC.Text = "";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtTC);
            this.groupBox7.Location = new System.Drawing.Point(416, 208);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(535, 195);
            this.groupBox7.TabIndex = 20;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Invoice Terms && Condition";
            // 
            // tblMonthCloseingBindingSource
            // 
            this.tblMonthCloseingBindingSource.DataMember = "tblMonthCloseing";
            this.tblMonthCloseingBindingSource.DataSource = this.settingDS;
            // 
            // settingDS
            // 
            this.settingDS.DataSetName = "SettingDS";
            this.settingDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblMonthCloseingTableAdapter
            // 
            this.tblMonthCloseingTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblMonthCloseingTableAdapter = this.tblMonthCloseingTableAdapter;
            this.tableAdapterManager.UpdateOrder = AccountSystem.SettingDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmYearCls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(1065, 476);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(createdLabel);
            this.Controls.Add(this.createdTextBox);
            this.Controls.Add(this.tblMonthCloseingBindingNavigator);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(compIDLabel);
            this.Controls.Add(this.compIDTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmYearCls";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application Settings";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmYearCls_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblMonthCloseingBindingNavigator)).EndInit();
            this.tblMonthCloseingBindingNavigator.ResumeLayout(false);
            this.tblMonthCloseingBindingNavigator.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblMonthCloseingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private SettingDS settingDS;
        private System.Windows.Forms.BindingSource tblMonthCloseingBindingSource;
        private SettingDSTableAdapters.tblMonthCloseingTableAdapter tblMonthCloseingTableAdapter;
        private SettingDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblMonthCloseingBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tblMonthCloseingBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox compIDTextBox;
        private System.Windows.Forms.TextBox createdTextBox;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.TextBox textDate;
        private System.Windows.Forms.TextBox wHTaxTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton codeStRadioButton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cboOpeningRet;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cboPurchases;
        private System.Windows.Forms.ComboBox cboSales;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboCrDr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox txtTC;
        private System.Windows.Forms.GroupBox groupBox7;
    }
}