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
	partial class frmStores : DevExpress.XtraEditors.XtraForm
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
            System.Windows.Forms.Label accTypeLabel;
            System.Windows.Forms.Label bCityLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStores));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.bCityComboBox = new System.Windows.Forms.ComboBox();
            this.sp_RegisterStoreSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cVESDAccounts = new AccountSystem.CVESDAccounts();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sp_RegisterStoreSelectBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sp_RegisterStoreSelectBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.accTypeComboBox = new System.Windows.Forms.ComboBox();
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
            this.sp_RegisterStoreSelectTableAdapter = new AccountSystem.CVESDAccountsTableAdapters.sp_RegisterStoreSelectTableAdapter();
            this.tableAdapterManager = new AccountSystem.CVESDAccountsTableAdapters.TableAdapterManager();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            entryAccNameLabel = new System.Windows.Forms.Label();
            createdLabel = new System.Windows.Forms.Label();
            modifiedLabel = new System.Windows.Forms.Label();
            statLabel = new System.Windows.Forms.Label();
            bAddressLabel = new System.Windows.Forms.Label();
            bContactNoLabel = new System.Windows.Forms.Label();
            bContactPersonLabel = new System.Windows.Forms.Label();
            bCDetailsLabel = new System.Windows.Forms.Label();
            accTypeLabel = new System.Windows.Forms.Label();
            bCityLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_RegisterStoreSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cVESDAccounts)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_RegisterStoreSelectBindingNavigator)).BeginInit();
            this.sp_RegisterStoreSelectBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // entryAccNameLabel
            // 
            entryAccNameLabel.AutoSize = true;
            entryAccNameLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            entryAccNameLabel.Location = new System.Drawing.Point(20, 67);
            entryAccNameLabel.Name = "entryAccNameLabel";
            entryAccNameLabel.Size = new System.Drawing.Size(135, 13);
            entryAccNameLabel.TabIndex = 2;
            entryAccNameLabel.Text = "Stores/Display Center:";
            // 
            // createdLabel
            // 
            createdLabel.AutoSize = true;
            createdLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            createdLabel.Location = new System.Drawing.Point(20, 421);
            createdLabel.Name = "createdLabel";
            createdLabel.Size = new System.Drawing.Size(55, 13);
            createdLabel.TabIndex = 19;
            createdLabel.Text = "Created:";
            // 
            // modifiedLabel
            // 
            modifiedLabel.AutoSize = true;
            modifiedLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            modifiedLabel.Location = new System.Drawing.Point(435, 420);
            modifiedLabel.Name = "modifiedLabel";
            modifiedLabel.Size = new System.Drawing.Size(58, 13);
            modifiedLabel.TabIndex = 21;
            modifiedLabel.Text = "Modified:";
            // 
            // statLabel
            // 
            statLabel.AutoSize = true;
            statLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            statLabel.Location = new System.Drawing.Point(20, 301);
            statLabel.Name = "statLabel";
            statLabel.Size = new System.Drawing.Size(47, 13);
            statLabel.TabIndex = 16;
            statLabel.Text = "Status:";
            // 
            // bAddressLabel
            // 
            bAddressLabel.AutoSize = true;
            bAddressLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            bAddressLabel.Location = new System.Drawing.Point(20, 121);
            bAddressLabel.Name = "bAddressLabel";
            bAddressLabel.Size = new System.Drawing.Size(56, 13);
            bAddressLabel.TabIndex = 8;
            bAddressLabel.Text = "Address:";
            // 
            // bContactNoLabel
            // 
            bContactNoLabel.AutoSize = true;
            bContactNoLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            bContactNoLabel.Location = new System.Drawing.Point(20, 186);
            bContactNoLabel.Name = "bContactNoLabel";
            bContactNoLabel.Size = new System.Drawing.Size(107, 13);
            bContactNoLabel.TabIndex = 10;
            bContactNoLabel.Text = "Contact Numbers:";
            // 
            // bContactPersonLabel
            // 
            bContactPersonLabel.AutoSize = true;
            bContactPersonLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            bContactPersonLabel.Location = new System.Drawing.Point(20, 213);
            bContactPersonLabel.Name = "bContactPersonLabel";
            bContactPersonLabel.Size = new System.Drawing.Size(96, 13);
            bContactPersonLabel.TabIndex = 12;
            bContactPersonLabel.Text = "Contact Person:";
            // 
            // bCDetailsLabel
            // 
            bCDetailsLabel.AutoSize = true;
            bCDetailsLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            bCDetailsLabel.Location = new System.Drawing.Point(20, 240);
            bCDetailsLabel.Name = "bCDetailsLabel";
            bCDetailsLabel.Size = new System.Drawing.Size(49, 13);
            bCDetailsLabel.TabIndex = 14;
            bCDetailsLabel.Text = "Details:";
            // 
            // accTypeLabel
            // 
            accTypeLabel.AutoSize = true;
            accTypeLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            accTypeLabel.Location = new System.Drawing.Point(20, 94);
            accTypeLabel.Name = "accTypeLabel";
            accTypeLabel.Size = new System.Drawing.Size(63, 13);
            accTypeLabel.TabIndex = 4;
            accTypeLabel.Text = "Site Type:";
            // 
            // bCityLabel
            // 
            bCityLabel.AutoSize = true;
            bCityLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            bCityLabel.Location = new System.Drawing.Point(325, 94);
            bCityLabel.Name = "bCityLabel";
            bCityLabel.Size = new System.Drawing.Size(67, 13);
            bCityLabel.TabIndex = 6;
            bCityLabel.Text = "City Name:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(bCityLabel);
            this.panel1.Controls.Add(this.bCityComboBox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(accTypeLabel);
            this.panel1.Controls.Add(this.accTypeComboBox);
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
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(295, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(927, 472);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(664, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 0);
            this.button1.TabIndex = 26;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bCityComboBox
            // 
            this.bCityComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sp_RegisterStoreSelectBindingSource, "BCity", true));
            this.bCityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bCityComboBox.FormattingEnabled = true;
            this.bCityComboBox.Location = new System.Drawing.Point(396, 91);
            this.bCityComboBox.Name = "bCityComboBox";
            this.bCityComboBox.Size = new System.Drawing.Size(145, 21);
            this.bCityComboBox.TabIndex = 7;
            // 
            // sp_RegisterStoreSelectBindingSource
            // 
            this.sp_RegisterStoreSelectBindingSource.DataMember = "sp_RegisterStoreSelect";
            this.sp_RegisterStoreSelectBindingSource.DataSource = this.cVESDAccounts;
            // 
            // cVESDAccounts
            // 
            this.cVESDAccounts.DataSetName = "CVESDAccounts";
            this.cVESDAccounts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.sp_RegisterStoreSelectBindingNavigator);
            this.panel2.Location = new System.Drawing.Point(266, 342);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 53);
            this.panel2.TabIndex = 18;
            // 
            // sp_RegisterStoreSelectBindingNavigator
            // 
            this.sp_RegisterStoreSelectBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sp_RegisterStoreSelectBindingNavigator.AutoSize = false;
            this.sp_RegisterStoreSelectBindingNavigator.BackColor = System.Drawing.SystemColors.Window;
            this.sp_RegisterStoreSelectBindingNavigator.BindingSource = this.sp_RegisterStoreSelectBindingSource;
            this.sp_RegisterStoreSelectBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sp_RegisterStoreSelectBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sp_RegisterStoreSelectBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.sp_RegisterStoreSelectBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sp_RegisterStoreSelectBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.sp_RegisterStoreSelectBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorSeparator2,
            this.sp_RegisterStoreSelectBindingNavigatorSaveItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripSeparator1,
            this.btnClose});
            this.sp_RegisterStoreSelectBindingNavigator.Location = new System.Drawing.Point(0, 10);
            this.sp_RegisterStoreSelectBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sp_RegisterStoreSelectBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sp_RegisterStoreSelectBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sp_RegisterStoreSelectBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sp_RegisterStoreSelectBindingNavigator.Name = "sp_RegisterStoreSelectBindingNavigator";
            this.sp_RegisterStoreSelectBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sp_RegisterStoreSelectBindingNavigator.Size = new System.Drawing.Size(336, 33);
            this.sp_RegisterStoreSelectBindingNavigator.TabIndex = 0;
            this.sp_RegisterStoreSelectBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(107, 30);
            this.bindingNavigatorAddNewItem.Text = "Add New Site";
            this.bindingNavigatorAddNewItem.ToolTipText = "Add New Staff";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.ForeColor = System.Drawing.SystemColors.Window;
            this.bindingNavigatorSeparator2.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Padding = new System.Windows.Forms.Padding(5);
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // sp_RegisterStoreSelectBindingNavigatorSaveItem
            // 
            this.sp_RegisterStoreSelectBindingNavigatorSaveItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sp_RegisterStoreSelectBindingNavigatorSaveItem.Image = global::AccountSystem.Properties.Resources.save_all;
            this.sp_RegisterStoreSelectBindingNavigatorSaveItem.Name = "sp_RegisterStoreSelectBindingNavigatorSaveItem";
            this.sp_RegisterStoreSelectBindingNavigatorSaveItem.Size = new System.Drawing.Size(80, 30);
            this.sp_RegisterStoreSelectBindingNavigatorSaveItem.Text = "Save Site";
            this.sp_RegisterStoreSelectBindingNavigatorSaveItem.Click += new System.EventHandler(this.sp_RegisterStoreSelectBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.Window;
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Padding = new System.Windows.Forms.Padding(5);
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
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
            // accTypeComboBox
            // 
            this.accTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sp_RegisterStoreSelectBindingSource, "AccType", true));
            this.accTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accTypeComboBox.FormattingEnabled = true;
            this.accTypeComboBox.Location = new System.Drawing.Point(155, 90);
            this.accTypeComboBox.Name = "accTypeComboBox";
            this.accTypeComboBox.Size = new System.Drawing.Size(161, 21);
            this.accTypeComboBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(446, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stores/Departments";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(2, 472);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // statComboBox
            // 
            this.statComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sp_RegisterStoreSelectBindingSource, "Stat", true));
            this.statComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statComboBox.FormattingEnabled = true;
            this.statComboBox.Location = new System.Drawing.Point(155, 297);
            this.statComboBox.Name = "statComboBox";
            this.statComboBox.Size = new System.Drawing.Size(121, 21);
            this.statComboBox.TabIndex = 17;
            // 
            // entryAccNameTextBox
            // 
            this.entryAccNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sp_RegisterStoreSelectBindingSource, "EntryAccName", true));
            this.entryAccNameTextBox.Location = new System.Drawing.Point(155, 64);
            this.entryAccNameTextBox.Name = "entryAccNameTextBox";
            this.entryAccNameTextBox.Size = new System.Drawing.Size(386, 21);
            this.entryAccNameTextBox.TabIndex = 3;
            // 
            // createdTextBox
            // 
            this.createdTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.createdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.createdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sp_RegisterStoreSelectBindingSource, "Created", true));
            this.createdTextBox.Location = new System.Drawing.Point(75, 419);
            this.createdTextBox.Name = "createdTextBox";
            this.createdTextBox.ReadOnly = true;
            this.createdTextBox.Size = new System.Drawing.Size(332, 14);
            this.createdTextBox.TabIndex = 20;
            // 
            // modifiedTextBox
            // 
            this.modifiedTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.modifiedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modifiedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sp_RegisterStoreSelectBindingSource, "Modified", true));
            this.modifiedTextBox.Location = new System.Drawing.Point(493, 419);
            this.modifiedTextBox.Name = "modifiedTextBox";
            this.modifiedTextBox.ReadOnly = true;
            this.modifiedTextBox.Size = new System.Drawing.Size(309, 14);
            this.modifiedTextBox.TabIndex = 22;
            // 
            // bAddressTextBox
            // 
            this.bAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sp_RegisterStoreSelectBindingSource, "BAddress", true));
            this.bAddressTextBox.Location = new System.Drawing.Point(155, 118);
            this.bAddressTextBox.Multiline = true;
            this.bAddressTextBox.Name = "bAddressTextBox";
            this.bAddressTextBox.Size = new System.Drawing.Size(386, 59);
            this.bAddressTextBox.TabIndex = 9;
            // 
            // bContactNoTextBox
            // 
            this.bContactNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sp_RegisterStoreSelectBindingSource, "BContactNo", true));
            this.bContactNoTextBox.Location = new System.Drawing.Point(155, 183);
            this.bContactNoTextBox.Name = "bContactNoTextBox";
            this.bContactNoTextBox.Size = new System.Drawing.Size(386, 21);
            this.bContactNoTextBox.TabIndex = 11;
            // 
            // bContactPersonTextBox
            // 
            this.bContactPersonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sp_RegisterStoreSelectBindingSource, "BContactPerson", true));
            this.bContactPersonTextBox.Location = new System.Drawing.Point(155, 210);
            this.bContactPersonTextBox.Name = "bContactPersonTextBox";
            this.bContactPersonTextBox.Size = new System.Drawing.Size(386, 21);
            this.bContactPersonTextBox.TabIndex = 13;
            // 
            // bCDetailsTextBox
            // 
            this.bCDetailsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sp_RegisterStoreSelectBindingSource, "BCDetails", true));
            this.bCDetailsTextBox.Location = new System.Drawing.Point(155, 237);
            this.bCDetailsTextBox.Multiline = true;
            this.bCDetailsTextBox.Name = "bCDetailsTextBox";
            this.bCDetailsTextBox.Size = new System.Drawing.Size(386, 54);
            this.bCDetailsTextBox.TabIndex = 15;
            // 
            // sp_RegisterStoreSelectTableAdapter
            // 
            this.sp_RegisterStoreSelectTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.sp_RegisterCustomerSelectTableAdapter = null;
            this.tableAdapterManager.sp_RegisterStaffSelectTableAdapter = null;
            this.tableAdapterManager.sp_RegisterStoreSelectTableAdapter = this.sp_RegisterStoreSelectTableAdapter;
            this.tableAdapterManager.sp_RegisterVendorsSelectTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AccountSystem.CVESDAccountsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.DataSource = this.sp_RegisterStoreSelectBindingSource;
            this.listBox1.DisplayMember = "EntryAccName";
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(21, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(268, 472);
            this.listBox1.TabIndex = 1;
            this.listBox1.ValueMember = "EntryAccID";
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.349206F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.65079F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 932F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.629032F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 96.37096F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1225, 496);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label1.Location = new System.Drawing.Point(21, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stores/Departmenta List";
            // 
            // frmStores
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(1225, 496);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmStores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stores/Departments";
            this.Load += new System.EventHandler(this.frmStaff_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_RegisterStoreSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cVESDAccounts)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sp_RegisterStoreSelectBindingNavigator)).EndInit();
            this.sp_RegisterStoreSelectBindingNavigator.ResumeLayout(false);
            this.sp_RegisterStoreSelectBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

		}
        private System.ComponentModel.IContainer components;
        private Panel panel1;
        private CVESDAccounts cVESDAccounts;
        private BindingSource sp_RegisterStoreSelectBindingSource;
        private CVESDAccountsTableAdapters.sp_RegisterStoreSelectTableAdapter sp_RegisterStoreSelectTableAdapter;
        private CVESDAccountsTableAdapters.TableAdapterManager tableAdapterManager;
        private BindingNavigator sp_RegisterStoreSelectBindingNavigator;
        private ToolStripButton bindingNavigatorAddNewItem;
        private ToolStripLabel bindingNavigatorCountItem;
        private ToolStripButton bindingNavigatorDeleteItem;
        private ToolStripButton bindingNavigatorMoveFirstItem;
        private ToolStripButton bindingNavigatorMovePreviousItem;
        private ToolStripTextBox bindingNavigatorPositionItem;
        private ToolStripButton bindingNavigatorMoveNextItem;
        private ToolStripButton bindingNavigatorMoveLastItem;
        private ToolStripSeparator bindingNavigatorSeparator2;
        private ToolStripButton sp_RegisterStoreSelectBindingNavigatorSaveItem;
        private TextBox entryAccNameTextBox;
        private TextBox createdTextBox;
        private TextBox modifiedTextBox;
        private TextBox bAddressTextBox;
        private TextBox bContactNoTextBox;
        private TextBox bContactPersonTextBox;
        private TextBox bCDetailsTextBox;
        private ListBox listBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private ComboBox statComboBox;
        private GroupBox groupBox1;
        private Label label2;
        private PictureBox pictureBox1;
        private ComboBox accTypeComboBox;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnClose;
        private Panel panel2;
        private ComboBox bCityComboBox;
        private Button button1;
    }
	
}
