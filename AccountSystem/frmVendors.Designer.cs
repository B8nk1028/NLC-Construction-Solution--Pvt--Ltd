using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;

using System.Linq;
using System;
using System.Collections;
using System.Xml.Linq;
using System.Windows.Forms;

namespace AccountSystem
{
	partial class frmVendors : DevExpress.XtraEditors.XtraForm
		{
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
			{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

        //Required by the Windows Form Designer
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
			{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label entryAccNameLabel;
            System.Windows.Forms.Label createdLabel;
            System.Windows.Forms.Label modifiedLabel;
            System.Windows.Forms.Label statLabel;
            System.Windows.Forms.Label bAddressLabel;
            System.Windows.Forms.Label bContactNoLabel;
            System.Windows.Forms.Label bContactPersonLabel;
            System.Windows.Forms.Label bCDetailsLabel;
            System.Windows.Forms.Label bBankAccLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendors));
            System.Windows.Forms.Label nTNLabel;
            System.Windows.Forms.Label sTNLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sp_RegisterVendorsSelectBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.sp_RegisterVendorsSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cVESDAccounts = new AccountSystem.CVESDAccounts();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sp_RegisterVendorsSelectBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statComboBox = new System.Windows.Forms.ComboBox();
            this.entryAccNameTextBox = new System.Windows.Forms.TextBox();
            this.createdTextBox = new System.Windows.Forms.TextBox();
            this.modifiedTextBox = new System.Windows.Forms.TextBox();
            this.bAddressTextBox = new System.Windows.Forms.TextBox();
            this.bContactNoTextBox = new System.Windows.Forms.TextBox();
            this.bContactPersonTextBox = new System.Windows.Forms.TextBox();
            this.bCDetailsTextBox = new System.Windows.Forms.TextBox();
            this.bBankAccTextBox = new System.Windows.Forms.TextBox();
            this.sp_RegisterVendorsSelectTableAdapter = new AccountSystem.CVESDAccountsTableAdapters.sp_RegisterVendorsSelectTableAdapter();
            this.tableAdapterManager = new AccountSystem.CVESDAccountsTableAdapters.TableAdapterManager();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.nTNTextBox = new System.Windows.Forms.TextBox();
            this.sTNTextBox = new System.Windows.Forms.TextBox();
            entryAccNameLabel = new System.Windows.Forms.Label();
            createdLabel = new System.Windows.Forms.Label();
            modifiedLabel = new System.Windows.Forms.Label();
            statLabel = new System.Windows.Forms.Label();
            bAddressLabel = new System.Windows.Forms.Label();
            bContactNoLabel = new System.Windows.Forms.Label();
            bContactPersonLabel = new System.Windows.Forms.Label();
            bCDetailsLabel = new System.Windows.Forms.Label();
            bBankAccLabel = new System.Windows.Forms.Label();
            nTNLabel = new System.Windows.Forms.Label();
            sTNLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_RegisterVendorsSelectBindingNavigator)).BeginInit();
            this.sp_RegisterVendorsSelectBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_RegisterVendorsSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cVESDAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // entryAccNameLabel
            // 
            entryAccNameLabel.AutoSize = true;
            entryAccNameLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            entryAccNameLabel.Location = new System.Drawing.Point(21, 67);
            entryAccNameLabel.Name = "entryAccNameLabel";
            entryAccNameLabel.Size = new System.Drawing.Size(85, 13);
            entryAccNameLabel.TabIndex = 2;
            entryAccNameLabel.Text = "Vendor Name:";
            // 
            // createdLabel
            // 
            createdLabel.AutoSize = true;
            createdLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            createdLabel.Location = new System.Drawing.Point(20, 465);
            createdLabel.Name = "createdLabel";
            createdLabel.Size = new System.Drawing.Size(55, 13);
            createdLabel.TabIndex = 17;
            createdLabel.Text = "Created:";
            // 
            // modifiedLabel
            // 
            modifiedLabel.AutoSize = true;
            modifiedLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            modifiedLabel.Location = new System.Drawing.Point(435, 464);
            modifiedLabel.Name = "modifiedLabel";
            modifiedLabel.Size = new System.Drawing.Size(58, 13);
            modifiedLabel.TabIndex = 19;
            modifiedLabel.Text = "Modified:";
            // 
            // statLabel
            // 
            statLabel.AutoSize = true;
            statLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            statLabel.Location = new System.Drawing.Point(21, 340);
            statLabel.Name = "statLabel";
            statLabel.Size = new System.Drawing.Size(47, 13);
            statLabel.TabIndex = 14;
            statLabel.Text = "Status:";
            // 
            // bAddressLabel
            // 
            bAddressLabel.AutoSize = true;
            bAddressLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            bAddressLabel.Location = new System.Drawing.Point(21, 94);
            bAddressLabel.Name = "bAddressLabel";
            bAddressLabel.Size = new System.Drawing.Size(56, 13);
            bAddressLabel.TabIndex = 4;
            bAddressLabel.Text = "Address:";
            // 
            // bContactNoLabel
            // 
            bContactNoLabel.AutoSize = true;
            bContactNoLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            bContactNoLabel.Location = new System.Drawing.Point(21, 159);
            bContactNoLabel.Name = "bContactNoLabel";
            bContactNoLabel.Size = new System.Drawing.Size(107, 13);
            bContactNoLabel.TabIndex = 6;
            bContactNoLabel.Text = "Contact Numbers:";
            // 
            // bContactPersonLabel
            // 
            bContactPersonLabel.AutoSize = true;
            bContactPersonLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            bContactPersonLabel.Location = new System.Drawing.Point(21, 186);
            bContactPersonLabel.Name = "bContactPersonLabel";
            bContactPersonLabel.Size = new System.Drawing.Size(96, 13);
            bContactPersonLabel.TabIndex = 8;
            bContactPersonLabel.Text = "Contact Person:";
            // 
            // bCDetailsLabel
            // 
            bCDetailsLabel.AutoSize = true;
            bCDetailsLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            bCDetailsLabel.Location = new System.Drawing.Point(21, 213);
            bCDetailsLabel.Name = "bCDetailsLabel";
            bCDetailsLabel.Size = new System.Drawing.Size(49, 13);
            bCDetailsLabel.TabIndex = 10;
            bCDetailsLabel.Text = "Details:";
            // 
            // bBankAccLabel
            // 
            bBankAccLabel.AutoSize = true;
            bBankAccLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            bBankAccLabel.Location = new System.Drawing.Point(21, 273);
            bBankAccLabel.Name = "bBankAccLabel";
            bBankAccLabel.Size = new System.Drawing.Size(87, 13);
            bBankAccLabel.TabIndex = 12;
            bBankAccLabel.Text = "Bank Account:";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(sTNLabel);
            this.panel1.Controls.Add(this.sTNTextBox);
            this.panel1.Controls.Add(nTNLabel);
            this.panel1.Controls.Add(this.nTNTextBox);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.statComboBox);
            this.panel1.Controls.Add(entryAccNameLabel);
            this.panel1.Controls.Add(this.entryAccNameTextBox);
            this.panel1.Controls.Add(createdLabel);
            this.panel1.Controls.Add(this.createdTextBox);
            this.panel1.Controls.Add(modifiedLabel);
            this.panel1.Controls.Add(this.modifiedTextBox);
            this.panel1.Controls.Add(statLabel);
            this.panel1.Controls.Add(bAddressLabel);
            this.panel1.Controls.Add(this.bAddressTextBox);
            this.panel1.Controls.Add(bContactNoLabel);
            this.panel1.Controls.Add(this.bContactNoTextBox);
            this.panel1.Controls.Add(bContactPersonLabel);
            this.panel1.Controls.Add(this.bContactPersonTextBox);
            this.panel1.Controls.Add(bCDetailsLabel);
            this.panel1.Controls.Add(this.bCDetailsTextBox);
            this.panel1.Controls.Add(bBankAccLabel);
            this.panel1.Controls.Add(this.bBankAccTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(268, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 463);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(688, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 0);
            this.button1.TabIndex = 27;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.sp_RegisterVendorsSelectBindingNavigator);
            this.panel2.Location = new System.Drawing.Point(372, 389);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(382, 36);
            this.panel2.TabIndex = 26;
            // 
            // sp_RegisterVendorsSelectBindingNavigator
            // 
            this.sp_RegisterVendorsSelectBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sp_RegisterVendorsSelectBindingNavigator.AutoSize = false;
            this.sp_RegisterVendorsSelectBindingNavigator.BackColor = System.Drawing.SystemColors.Window;
            this.sp_RegisterVendorsSelectBindingNavigator.BindingSource = this.sp_RegisterVendorsSelectBindingSource;
            this.sp_RegisterVendorsSelectBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sp_RegisterVendorsSelectBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sp_RegisterVendorsSelectBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.sp_RegisterVendorsSelectBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sp_RegisterVendorsSelectBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.sp_RegisterVendorsSelectBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorAddNewItem,
            this.toolStripSeparator2,
            this.bindingNavigatorDeleteItem,
            this.sp_RegisterVendorsSelectBindingNavigatorSaveItem,
            this.bindingNavigatorSeparator2,
            this.btnClose});
            this.sp_RegisterVendorsSelectBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sp_RegisterVendorsSelectBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sp_RegisterVendorsSelectBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sp_RegisterVendorsSelectBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sp_RegisterVendorsSelectBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sp_RegisterVendorsSelectBindingNavigator.Name = "sp_RegisterVendorsSelectBindingNavigator";
            this.sp_RegisterVendorsSelectBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sp_RegisterVendorsSelectBindingNavigator.Size = new System.Drawing.Size(378, 33);
            this.sp_RegisterVendorsSelectBindingNavigator.TabIndex = 16;
            this.sp_RegisterVendorsSelectBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(128, 30);
            this.bindingNavigatorAddNewItem.Text = "Add New Vendor";
            this.bindingNavigatorAddNewItem.ToolTipText = "Add New Vendor";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // sp_RegisterVendorsSelectBindingSource
            // 
            this.sp_RegisterVendorsSelectBindingSource.DataMember = "sp_RegisterVendorsSelect";
            this.sp_RegisterVendorsSelectBindingSource.DataSource = this.cVESDAccounts;
            // 
            // cVESDAccounts
            // 
            this.cVESDAccounts.DataSetName = "CVESDAccounts";
            this.cVESDAccounts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(39, 30);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 30);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Visible = false;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 30);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            this.bindingNavigatorMoveFirstItem.Visible = false;
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 30);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            this.bindingNavigatorMovePreviousItem.Visible = false;
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
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 30);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            this.bindingNavigatorMoveNextItem.Visible = false;
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 30);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            this.bindingNavigatorMoveLastItem.Visible = false;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.ForeColor = System.Drawing.SystemColors.Window;
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Padding = new System.Windows.Forms.Padding(5);
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // sp_RegisterVendorsSelectBindingNavigatorSaveItem
            // 
            this.sp_RegisterVendorsSelectBindingNavigatorSaveItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sp_RegisterVendorsSelectBindingNavigatorSaveItem.Image = global::AccountSystem.Properties.Resources.save_all;
            this.sp_RegisterVendorsSelectBindingNavigatorSaveItem.Name = "sp_RegisterVendorsSelectBindingNavigatorSaveItem";
            this.sp_RegisterVendorsSelectBindingNavigatorSaveItem.Size = new System.Drawing.Size(101, 30);
            this.sp_RegisterVendorsSelectBindingNavigatorSaveItem.Text = "Save Vendor";
            this.sp_RegisterVendorsSelectBindingNavigatorSaveItem.Click += new System.EventHandler(this.sp_RegisterVendorsSelectBindingNavigatorSaveItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.ForeColor = System.Drawing.SystemColors.Window;
            this.bindingNavigatorSeparator2.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Padding = new System.Windows.Forms.Padding(5);
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 30);
            this.btnClose.Text = "Close Form";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vendor Management";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(2, 478);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // statComboBox
            // 
            this.statComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sp_RegisterVendorsSelectBindingSource, "Stat", true));
            this.statComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statComboBox.FormattingEnabled = true;
            this.statComboBox.Location = new System.Drawing.Point(134, 336);
            this.statComboBox.Name = "statComboBox";
            this.statComboBox.Size = new System.Drawing.Size(121, 21);
            this.statComboBox.TabIndex = 15;
            // 
            // entryAccNameTextBox
            // 
            this.entryAccNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sp_RegisterVendorsSelectBindingSource, "EntryAccName", true));
            this.entryAccNameTextBox.Location = new System.Drawing.Point(134, 64);
            this.entryAccNameTextBox.Name = "entryAccNameTextBox";
            this.entryAccNameTextBox.Size = new System.Drawing.Size(376, 21);
            this.entryAccNameTextBox.TabIndex = 3;
            // 
            // createdTextBox
            // 
            this.createdTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.createdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.createdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sp_RegisterVendorsSelectBindingSource, "Created", true));
            this.createdTextBox.Location = new System.Drawing.Point(75, 463);
            this.createdTextBox.Name = "createdTextBox";
            this.createdTextBox.ReadOnly = true;
            this.createdTextBox.Size = new System.Drawing.Size(332, 14);
            this.createdTextBox.TabIndex = 18;
            // 
            // modifiedTextBox
            // 
            this.modifiedTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.modifiedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modifiedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sp_RegisterVendorsSelectBindingSource, "Modified", true));
            this.modifiedTextBox.Location = new System.Drawing.Point(493, 463);
            this.modifiedTextBox.Name = "modifiedTextBox";
            this.modifiedTextBox.ReadOnly = true;
            this.modifiedTextBox.Size = new System.Drawing.Size(309, 14);
            this.modifiedTextBox.TabIndex = 20;
            // 
            // bAddressTextBox
            // 
            this.bAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sp_RegisterVendorsSelectBindingSource, "BAddress", true));
            this.bAddressTextBox.Location = new System.Drawing.Point(134, 91);
            this.bAddressTextBox.Multiline = true;
            this.bAddressTextBox.Name = "bAddressTextBox";
            this.bAddressTextBox.Size = new System.Drawing.Size(376, 38);
            this.bAddressTextBox.TabIndex = 5;
            // 
            // bContactNoTextBox
            // 
            this.bContactNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sp_RegisterVendorsSelectBindingSource, "BContactNo", true));
            this.bContactNoTextBox.Location = new System.Drawing.Point(134, 156);
            this.bContactNoTextBox.Name = "bContactNoTextBox";
            this.bContactNoTextBox.Size = new System.Drawing.Size(376, 21);
            this.bContactNoTextBox.TabIndex = 7;
            // 
            // bContactPersonTextBox
            // 
            this.bContactPersonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sp_RegisterVendorsSelectBindingSource, "BContactPerson", true));
            this.bContactPersonTextBox.Location = new System.Drawing.Point(134, 183);
            this.bContactPersonTextBox.Name = "bContactPersonTextBox";
            this.bContactPersonTextBox.Size = new System.Drawing.Size(376, 21);
            this.bContactPersonTextBox.TabIndex = 9;
            // 
            // bCDetailsTextBox
            // 
            this.bCDetailsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sp_RegisterVendorsSelectBindingSource, "BCDetails", true));
            this.bCDetailsTextBox.Location = new System.Drawing.Point(134, 210);
            this.bCDetailsTextBox.Multiline = true;
            this.bCDetailsTextBox.Name = "bCDetailsTextBox";
            this.bCDetailsTextBox.Size = new System.Drawing.Size(376, 54);
            this.bCDetailsTextBox.TabIndex = 11;
            // 
            // bBankAccTextBox
            // 
            this.bBankAccTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sp_RegisterVendorsSelectBindingSource, "BBankAcc", true));
            this.bBankAccTextBox.Location = new System.Drawing.Point(134, 270);
            this.bBankAccTextBox.Multiline = true;
            this.bBankAccTextBox.Name = "bBankAccTextBox";
            this.bBankAccTextBox.Size = new System.Drawing.Size(376, 60);
            this.bBankAccTextBox.TabIndex = 13;
            // 
            // sp_RegisterVendorsSelectTableAdapter
            // 
            this.sp_RegisterVendorsSelectTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.sp_RegisterCustomerSelectTableAdapter = null;
            this.tableAdapterManager.sp_RegisterStaffSelectTableAdapter = null;
            this.tableAdapterManager.sp_RegisterStoreSelectTableAdapter = null;
            this.tableAdapterManager.sp_RegisterVendorsSelectTableAdapter = this.sp_RegisterVendorsSelectTableAdapter;
            this.tableAdapterManager.UpdateOrder = AccountSystem.CVESDAccountsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.DataSource = this.sp_RegisterVendorsSelectBindingSource;
            this.listBox1.DisplayMember = "EntryAccName";
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(33, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(229, 463);
            this.listBox1.TabIndex = 1;
            this.listBox1.ValueMember = "EntryAccID";
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.35371F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.64629F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 923F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBox1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 35);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 97.06275F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1189, 469);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1189, 35);
            this.panel3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(29, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Create && Manage Vendors";
            // 
            // nTNLabel
            // 
            nTNLabel.AutoSize = true;
            nTNLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            nTNLabel.Location = new System.Drawing.Point(21, 136);
            nTNLabel.Name = "nTNLabel";
            nTNLabel.Size = new System.Drawing.Size(31, 13);
            nTNLabel.TabIndex = 27;
            nTNLabel.Text = "NTN:";
            // 
            // nTNTextBox
            // 
            this.nTNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sp_RegisterVendorsSelectBindingSource, "NTN", true));
            this.nTNTextBox.Location = new System.Drawing.Point(134, 132);
            this.nTNTextBox.Name = "nTNTextBox";
            this.nTNTextBox.Size = new System.Drawing.Size(160, 21);
            this.nTNTextBox.TabIndex = 28;
            // 
            // sTNLabel
            // 
            sTNLabel.AutoSize = true;
            sTNLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            sTNLabel.Location = new System.Drawing.Point(300, 136);
            sTNLabel.Name = "sTNLabel";
            sTNLabel.Size = new System.Drawing.Size(31, 13);
            sTNLabel.TabIndex = 28;
            sTNLabel.Text = "STN:";
            // 
            // sTNTextBox
            // 
            this.sTNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sp_RegisterVendorsSelectBindingSource, "STN", true));
            this.sTNTextBox.Location = new System.Drawing.Point(336, 132);
            this.sTNTextBox.Name = "sTNTextBox";
            this.sTNTextBox.Size = new System.Drawing.Size(174, 21);
            this.sTNTextBox.TabIndex = 29;
            // 
            // frmVendors
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(1189, 504);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmVendors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendor Management";
            this.Load += new System.EventHandler(this.frmVendors_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sp_RegisterVendorsSelectBindingNavigator)).EndInit();
            this.sp_RegisterVendorsSelectBindingNavigator.ResumeLayout(false);
            this.sp_RegisterVendorsSelectBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_RegisterVendorsSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cVESDAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

		}
        private System.ComponentModel.IContainer components;
        private Panel panel1;
        private CVESDAccounts cVESDAccounts;
        private BindingSource sp_RegisterVendorsSelectBindingSource;
        private CVESDAccountsTableAdapters.sp_RegisterVendorsSelectTableAdapter sp_RegisterVendorsSelectTableAdapter;
        private CVESDAccountsTableAdapters.TableAdapterManager tableAdapterManager;
        private BindingNavigator sp_RegisterVendorsSelectBindingNavigator;
        private ToolStripButton bindingNavigatorAddNewItem;
        private ToolStripLabel bindingNavigatorCountItem;
        private ToolStripButton bindingNavigatorDeleteItem;
        private ToolStripButton bindingNavigatorMoveFirstItem;
        private ToolStripButton bindingNavigatorMovePreviousItem;
        private ToolStripTextBox bindingNavigatorPositionItem;
        private ToolStripButton bindingNavigatorMoveNextItem;
        private ToolStripButton bindingNavigatorMoveLastItem;
        private ToolStripSeparator bindingNavigatorSeparator2;
        private ToolStripButton sp_RegisterVendorsSelectBindingNavigatorSaveItem;
        private TextBox entryAccNameTextBox;
        private TextBox createdTextBox;
        private TextBox modifiedTextBox;
        private TextBox bAddressTextBox;
        private TextBox bContactNoTextBox;
        private TextBox bContactPersonTextBox;
        private TextBox bCDetailsTextBox;
        private TextBox bBankAccTextBox;
        private ListBox listBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox statComboBox;
        private GroupBox groupBox1;
        private Label label2;
        private PictureBox pictureBox1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnClose;
        private Panel panel2;
        private Button button1;
        private Panel panel3;
        private Label label4;
        private TextBox sTNTextBox;
        private TextBox nTNTextBox;
    }
	
}
