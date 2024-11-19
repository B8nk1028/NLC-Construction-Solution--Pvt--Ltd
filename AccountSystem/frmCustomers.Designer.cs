using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using Microsoft.VisualBasic;
using System.Linq;
using System;
using System.Collections;
using System.Xml.Linq;
using System.Windows.Forms;

namespace AccountSystem
{
	partial class frmCustomers : DevExpress.XtraEditors.XtraForm
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
            System.Windows.Forms.Label bCityLabel;
            System.Windows.Forms.Label bTransportLabel;
            System.Windows.Forms.Label crLimitLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label nTNLabel;
            System.Windows.Forms.Label sTNLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomers));
            this.panel1 = new System.Windows.Forms.Panel();
            this.sTNTextBox = new System.Windows.Forms.TextBox();
            this.sp_RegisterCustomerSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cVESDAccounts = new AccountSystem.CVESDAccounts();
            this.nTNTextBox = new System.Windows.Forms.TextBox();
            this.cbLocation = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cboPayTerms = new System.Windows.Forms.ComboBox();
            this.crLimitTextBox = new System.Windows.Forms.TextBox();
            this.bTransportTextBox = new System.Windows.Forms.TextBox();
            this.bCityComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sp_RegisterCustomerSelectBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sp_RegisterCustomerSelectBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
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
            this.sp_RegisterCustomerSelectTableAdapter = new AccountSystem.CVESDAccountsTableAdapters.sp_RegisterCustomerSelectTableAdapter();
            this.tableAdapterManager = new AccountSystem.CVESDAccountsTableAdapters.TableAdapterManager();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            entryAccNameLabel = new System.Windows.Forms.Label();
            createdLabel = new System.Windows.Forms.Label();
            modifiedLabel = new System.Windows.Forms.Label();
            statLabel = new System.Windows.Forms.Label();
            bAddressLabel = new System.Windows.Forms.Label();
            bContactNoLabel = new System.Windows.Forms.Label();
            bContactPersonLabel = new System.Windows.Forms.Label();
            bCDetailsLabel = new System.Windows.Forms.Label();
            bBankAccLabel = new System.Windows.Forms.Label();
            bCityLabel = new System.Windows.Forms.Label();
            bTransportLabel = new System.Windows.Forms.Label();
            crLimitLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            nTNLabel = new System.Windows.Forms.Label();
            sTNLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_RegisterCustomerSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cVESDAccounts)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_RegisterCustomerSelectBindingNavigator)).BeginInit();
            this.sp_RegisterCustomerSelectBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // entryAccNameLabel
            // 
            entryAccNameLabel.AutoSize = true;
            entryAccNameLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            entryAccNameLabel.Location = new System.Drawing.Point(85, 80);
            entryAccNameLabel.Name = "entryAccNameLabel";
            entryAccNameLabel.Size = new System.Drawing.Size(100, 13);
            entryAccNameLabel.TabIndex = 2;
            entryAccNameLabel.Text = "Customer Name:";
            // 
            // createdLabel
            // 
            createdLabel.AutoSize = true;
            createdLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            createdLabel.Location = new System.Drawing.Point(11, 477);
            createdLabel.Name = "createdLabel";
            createdLabel.Size = new System.Drawing.Size(55, 13);
            createdLabel.TabIndex = 22;
            createdLabel.Text = "Created:";
            // 
            // modifiedLabel
            // 
            modifiedLabel.AutoSize = true;
            modifiedLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            modifiedLabel.Location = new System.Drawing.Point(369, 477);
            modifiedLabel.Name = "modifiedLabel";
            modifiedLabel.Size = new System.Drawing.Size(58, 13);
            modifiedLabel.TabIndex = 24;
            modifiedLabel.Text = "Modified:";
            // 
            // statLabel
            // 
            statLabel.AutoSize = true;
            statLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            statLabel.Location = new System.Drawing.Point(407, 107);
            statLabel.Name = "statLabel";
            statLabel.Size = new System.Drawing.Size(47, 13);
            statLabel.TabIndex = 6;
            statLabel.Text = "Status:";
            statLabel.Click += new System.EventHandler(this.statLabel_Click);
            // 
            // bAddressLabel
            // 
            bAddressLabel.AutoSize = true;
            bAddressLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            bAddressLabel.Location = new System.Drawing.Point(129, 134);
            bAddressLabel.Name = "bAddressLabel";
            bAddressLabel.Size = new System.Drawing.Size(56, 13);
            bAddressLabel.TabIndex = 8;
            bAddressLabel.Text = "Address:";
            // 
            // bContactNoLabel
            // 
            bContactNoLabel.AutoSize = true;
            bContactNoLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            bContactNoLabel.Location = new System.Drawing.Point(78, 199);
            bContactNoLabel.Name = "bContactNoLabel";
            bContactNoLabel.Size = new System.Drawing.Size(107, 13);
            bContactNoLabel.TabIndex = 10;
            bContactNoLabel.Text = "Contact Numbers:";
            // 
            // bContactPersonLabel
            // 
            bContactPersonLabel.AutoSize = true;
            bContactPersonLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            bContactPersonLabel.Location = new System.Drawing.Point(89, 225);
            bContactPersonLabel.Name = "bContactPersonLabel";
            bContactPersonLabel.Size = new System.Drawing.Size(96, 13);
            bContactPersonLabel.TabIndex = 12;
            bContactPersonLabel.Text = "Contact Person:";
            // 
            // bCDetailsLabel
            // 
            bCDetailsLabel.AutoSize = true;
            bCDetailsLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            bCDetailsLabel.Location = new System.Drawing.Point(136, 252);
            bCDetailsLabel.Name = "bCDetailsLabel";
            bCDetailsLabel.Size = new System.Drawing.Size(49, 13);
            bCDetailsLabel.TabIndex = 14;
            bCDetailsLabel.Text = "Details:";
            // 
            // bBankAccLabel
            // 
            bBankAccLabel.AutoSize = true;
            bBankAccLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            bBankAccLabel.Location = new System.Drawing.Point(694, 61);
            bBankAccLabel.Name = "bBankAccLabel";
            bBankAccLabel.Size = new System.Drawing.Size(87, 13);
            bBankAccLabel.TabIndex = 14;
            bBankAccLabel.Text = "Bank Account:";
            bBankAccLabel.Visible = false;
            // 
            // bCityLabel
            // 
            bCityLabel.AutoSize = true;
            bCityLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            bCityLabel.Location = new System.Drawing.Point(118, 107);
            bCityLabel.Name = "bCityLabel";
            bCityLabel.Size = new System.Drawing.Size(67, 13);
            bCityLabel.TabIndex = 4;
            bCityLabel.Text = "City Name:";
            // 
            // bTransportLabel
            // 
            bTransportLabel.AutoSize = true;
            bTransportLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            bTransportLabel.Location = new System.Drawing.Point(63, 322);
            bTransportLabel.Name = "bTransportLabel";
            bTransportLabel.Size = new System.Drawing.Size(122, 13);
            bTransportLabel.TabIndex = 20;
            bTransportLabel.Text = "Transport Company:";
            // 
            // crLimitLabel
            // 
            crLimitLabel.AutoSize = true;
            crLimitLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            crLimitLabel.Location = new System.Drawing.Point(402, 295);
            crLimitLabel.Name = "crLimitLabel";
            crLimitLabel.Size = new System.Drawing.Size(75, 13);
            crLimitLabel.TabIndex = 18;
            crLimitLabel.Text = "Credit Limit:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            label3.Location = new System.Drawing.Point(124, 61);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(61, 13);
            label3.TabIndex = 67;
            label3.Text = "Location :";
            label3.Visible = false;
            // 
            // nTNLabel
            // 
            nTNLabel.AutoSize = true;
            nTNLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            nTNLabel.Location = new System.Drawing.Point(154, 174);
            nTNLabel.Name = "nTNLabel";
            nTNLabel.Size = new System.Drawing.Size(31, 13);
            nTNLabel.TabIndex = 68;
            nTNLabel.Text = "NTN:";
            // 
            // sTNLabel
            // 
            sTNLabel.AutoSize = true;
            sTNLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            sTNLabel.Location = new System.Drawing.Point(396, 174);
            sTNLabel.Name = "sTNLabel";
            sTNLabel.Size = new System.Drawing.Size(31, 13);
            sTNLabel.TabIndex = 69;
            sTNLabel.Text = "STN:";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(sTNLabel);
            this.panel1.Controls.Add(this.sTNTextBox);
            this.panel1.Controls.Add(nTNLabel);
            this.panel1.Controls.Add(this.nTNTextBox);
            this.panel1.Controls.Add(this.cbLocation);
            this.panel1.Controls.Add(label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.cboPayTerms);
            this.panel1.Controls.Add(crLimitLabel);
            this.panel1.Controls.Add(this.crLimitTextBox);
            this.panel1.Controls.Add(bTransportLabel);
            this.panel1.Controls.Add(this.bTransportTextBox);
            this.panel1.Controls.Add(bCityLabel);
            this.panel1.Controls.Add(this.bCityComboBox);
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
            this.panel1.Location = new System.Drawing.Point(346, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 721);
            this.panel1.TabIndex = 2;
            // 
            // sTNTextBox
            // 
            this.sTNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sp_RegisterCustomerSelectBindingSource, "STN", true));
            this.sTNTextBox.Location = new System.Drawing.Point(432, 170);
            this.sTNTextBox.Name = "sTNTextBox";
            this.sTNTextBox.Size = new System.Drawing.Size(151, 21);
            this.sTNTextBox.TabIndex = 70;
            // 
            // sp_RegisterCustomerSelectBindingSource
            // 
            this.sp_RegisterCustomerSelectBindingSource.DataMember = "sp_RegisterCustomerSelect";
            this.sp_RegisterCustomerSelectBindingSource.DataSource = this.cVESDAccounts;
            // 
            // cVESDAccounts
            // 
            this.cVESDAccounts.DataSetName = "CVESDAccounts";
            this.cVESDAccounts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nTNTextBox
            // 
            this.nTNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sp_RegisterCustomerSelectBindingSource, "NTN", true));
            this.nTNTextBox.Location = new System.Drawing.Point(207, 170);
            this.nTNTextBox.Name = "nTNTextBox";
            this.nTNTextBox.Size = new System.Drawing.Size(168, 21);
            this.nTNTextBox.TabIndex = 69;
            // 
            // cbLocation
            // 
            this.cbLocation.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sp_RegisterCustomerSelectBindingSource, "BranchID", true));
            this.cbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.Location = new System.Drawing.Point(207, 53);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(376, 21);
            this.cbLocation.TabIndex = 68;
            this.cbLocation.Visible = false;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(636, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 0);
            this.button1.TabIndex = 26;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(77, 295);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Terms of Payment";
            // 
            // cboPayTerms
            // 
            this.cboPayTerms.BackColor = System.Drawing.SystemColors.Window;
            this.cboPayTerms.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sp_RegisterCustomerSelectBindingSource, "PaymentTermsID", true));
            this.cboPayTerms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPayTerms.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPayTerms.FormattingEnabled = true;
            this.cboPayTerms.Location = new System.Drawing.Point(207, 291);
            this.cboPayTerms.Name = "cboPayTerms";
            this.cboPayTerms.Size = new System.Drawing.Size(191, 21);
            this.cboPayTerms.TabIndex = 17;
            // 
            // crLimitTextBox
            // 
            this.crLimitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sp_RegisterCustomerSelectBindingSource, "CrLimit", true));
            this.crLimitTextBox.Location = new System.Drawing.Point(483, 291);
            this.crLimitTextBox.Name = "crLimitTextBox";
            this.crLimitTextBox.Size = new System.Drawing.Size(100, 21);
            this.crLimitTextBox.TabIndex = 19;
            // 
            // bTransportTextBox
            // 
            this.bTransportTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sp_RegisterCustomerSelectBindingSource, "BTransport", true));
            this.bTransportTextBox.Location = new System.Drawing.Point(207, 318);
            this.bTransportTextBox.Multiline = true;
            this.bTransportTextBox.Name = "bTransportTextBox";
            this.bTransportTextBox.Size = new System.Drawing.Size(376, 58);
            this.bTransportTextBox.TabIndex = 21;
            // 
            // bCityComboBox
            // 
            this.bCityComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sp_RegisterCustomerSelectBindingSource, "BCity", true));
            this.bCityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bCityComboBox.FormattingEnabled = true;
            this.bCityComboBox.Location = new System.Drawing.Point(207, 103);
            this.bCityComboBox.Name = "bCityComboBox";
            this.bCityComboBox.Size = new System.Drawing.Size(121, 21);
            this.bCityComboBox.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.sp_RegisterCustomerSelectBindingNavigator);
            this.panel2.Location = new System.Drawing.Point(182, 382);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(418, 51);
            this.panel2.TabIndex = 22;
            // 
            // sp_RegisterCustomerSelectBindingNavigator
            // 
            this.sp_RegisterCustomerSelectBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sp_RegisterCustomerSelectBindingNavigator.AutoSize = false;
            this.sp_RegisterCustomerSelectBindingNavigator.BackColor = System.Drawing.SystemColors.Window;
            this.sp_RegisterCustomerSelectBindingNavigator.BindingSource = this.sp_RegisterCustomerSelectBindingSource;
            this.sp_RegisterCustomerSelectBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sp_RegisterCustomerSelectBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sp_RegisterCustomerSelectBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.sp_RegisterCustomerSelectBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sp_RegisterCustomerSelectBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.sp_RegisterCustomerSelectBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorAddNewItem,
            this.toolStripSeparator2,
            this.bindingNavigatorDeleteItem,
            this.sp_RegisterCustomerSelectBindingNavigatorSaveItem,
            this.bindingNavigatorSeparator2,
            this.btnClose});
            this.sp_RegisterCustomerSelectBindingNavigator.Location = new System.Drawing.Point(0, 8);
            this.sp_RegisterCustomerSelectBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sp_RegisterCustomerSelectBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sp_RegisterCustomerSelectBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sp_RegisterCustomerSelectBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sp_RegisterCustomerSelectBindingNavigator.Name = "sp_RegisterCustomerSelectBindingNavigator";
            this.sp_RegisterCustomerSelectBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sp_RegisterCustomerSelectBindingNavigator.Size = new System.Drawing.Size(406, 33);
            this.sp_RegisterCustomerSelectBindingNavigator.TabIndex = 0;
            this.sp_RegisterCustomerSelectBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(142, 30);
            this.bindingNavigatorAddNewItem.Text = "Add New Customer";
            this.bindingNavigatorAddNewItem.ToolTipText = "Add New Vendor";
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.ForeColor = System.Drawing.SystemColors.Window;
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Padding = new System.Windows.Forms.Padding(5);
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // sp_RegisterCustomerSelectBindingNavigatorSaveItem
            // 
            this.sp_RegisterCustomerSelectBindingNavigatorSaveItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sp_RegisterCustomerSelectBindingNavigatorSaveItem.Image = global::AccountSystem.Properties.Resources.save_all;
            this.sp_RegisterCustomerSelectBindingNavigatorSaveItem.Name = "sp_RegisterCustomerSelectBindingNavigatorSaveItem";
            this.sp_RegisterCustomerSelectBindingNavigatorSaveItem.Size = new System.Drawing.Size(115, 30);
            this.sp_RegisterCustomerSelectBindingNavigatorSaveItem.Text = "Save Customer";
            this.sp_RegisterCustomerSelectBindingNavigatorSaveItem.Click += new System.EventHandler(this.sp_RegisterCustomerSelectBindingNavigatorSaveItem_Click);
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
            this.label2.Size = new System.Drawing.Size(339, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Management";
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
            this.groupBox1.Size = new System.Drawing.Size(2, 721);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // statComboBox
            // 
            this.statComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sp_RegisterCustomerSelectBindingSource, "Stat", true));
            this.statComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statComboBox.FormattingEnabled = true;
            this.statComboBox.Location = new System.Drawing.Point(462, 103);
            this.statComboBox.Name = "statComboBox";
            this.statComboBox.Size = new System.Drawing.Size(121, 21);
            this.statComboBox.TabIndex = 7;
            // 
            // entryAccNameTextBox
            // 
            this.entryAccNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sp_RegisterCustomerSelectBindingSource, "EntryAccName", true));
            this.entryAccNameTextBox.Location = new System.Drawing.Point(207, 77);
            this.entryAccNameTextBox.Name = "entryAccNameTextBox";
            this.entryAccNameTextBox.Size = new System.Drawing.Size(376, 21);
            this.entryAccNameTextBox.TabIndex = 3;
            // 
            // createdTextBox
            // 
            this.createdTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.createdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.createdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sp_RegisterCustomerSelectBindingSource, "Created", true));
            this.createdTextBox.Location = new System.Drawing.Point(66, 476);
            this.createdTextBox.Name = "createdTextBox";
            this.createdTextBox.ReadOnly = true;
            this.createdTextBox.Size = new System.Drawing.Size(268, 14);
            this.createdTextBox.TabIndex = 23;
            // 
            // modifiedTextBox
            // 
            this.modifiedTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.modifiedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modifiedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sp_RegisterCustomerSelectBindingSource, "Modified", true));
            this.modifiedTextBox.Location = new System.Drawing.Point(427, 476);
            this.modifiedTextBox.Name = "modifiedTextBox";
            this.modifiedTextBox.ReadOnly = true;
            this.modifiedTextBox.Size = new System.Drawing.Size(290, 14);
            this.modifiedTextBox.TabIndex = 25;
            // 
            // bAddressTextBox
            // 
            this.bAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sp_RegisterCustomerSelectBindingSource, "BAddress", true));
            this.bAddressTextBox.Location = new System.Drawing.Point(207, 131);
            this.bAddressTextBox.Multiline = true;
            this.bAddressTextBox.Name = "bAddressTextBox";
            this.bAddressTextBox.Size = new System.Drawing.Size(376, 35);
            this.bAddressTextBox.TabIndex = 9;
            // 
            // bContactNoTextBox
            // 
            this.bContactNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sp_RegisterCustomerSelectBindingSource, "BContactNo", true));
            this.bContactNoTextBox.Location = new System.Drawing.Point(207, 196);
            this.bContactNoTextBox.Name = "bContactNoTextBox";
            this.bContactNoTextBox.Size = new System.Drawing.Size(376, 21);
            this.bContactNoTextBox.TabIndex = 11;
            // 
            // bContactPersonTextBox
            // 
            this.bContactPersonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sp_RegisterCustomerSelectBindingSource, "BContactPerson", true));
            this.bContactPersonTextBox.Location = new System.Drawing.Point(207, 222);
            this.bContactPersonTextBox.Name = "bContactPersonTextBox";
            this.bContactPersonTextBox.Size = new System.Drawing.Size(376, 21);
            this.bContactPersonTextBox.TabIndex = 13;
            // 
            // bCDetailsTextBox
            // 
            this.bCDetailsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sp_RegisterCustomerSelectBindingSource, "BCDetails", true));
            this.bCDetailsTextBox.Location = new System.Drawing.Point(207, 249);
            this.bCDetailsTextBox.Multiline = true;
            this.bCDetailsTextBox.Name = "bCDetailsTextBox";
            this.bCDetailsTextBox.Size = new System.Drawing.Size(376, 36);
            this.bCDetailsTextBox.TabIndex = 15;
            // 
            // bBankAccTextBox
            // 
            this.bBankAccTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sp_RegisterCustomerSelectBindingSource, "BBankAcc", true));
            this.bBankAccTextBox.Location = new System.Drawing.Point(697, 80);
            this.bBankAccTextBox.Multiline = true;
            this.bBankAccTextBox.Name = "bBankAccTextBox";
            this.bBankAccTextBox.Size = new System.Drawing.Size(82, 60);
            this.bBankAccTextBox.TabIndex = 15;
            this.bBankAccTextBox.Visible = false;
            // 
            // sp_RegisterCustomerSelectTableAdapter
            // 
            this.sp_RegisterCustomerSelectTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.sp_RegisterCustomerSelectTableAdapter = this.sp_RegisterCustomerSelectTableAdapter;
            this.tableAdapterManager.sp_RegisterStaffSelectTableAdapter = null;
            this.tableAdapterManager.sp_RegisterStoreSelectTableAdapter = null;
            this.tableAdapterManager.sp_RegisterVendorsSelectTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AccountSystem.CVESDAccountsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.DataSource = this.sp_RegisterCustomerSelectBindingSource;
            this.listBox1.DisplayMember = "EntryAccName";
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(0, 36);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(298, 685);
            this.listBox1.TabIndex = 2;
            this.listBox1.ValueMember = "EntryAccID";
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.35371F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.64629F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 796F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.93725F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 97.06275F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1140, 749);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label1.Location = new System.Drawing.Point(42, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer List";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listBox1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(42, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(298, 721);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 21);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(298, 15);
            this.panel4.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearch.Location = new System.Drawing.Point(0, 0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(298, 21);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // frmCustomers
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(1140, 749);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Management";
            this.Load += new System.EventHandler(this.frmCustomers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_RegisterCustomerSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cVESDAccounts)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sp_RegisterCustomerSelectBindingNavigator)).EndInit();
            this.sp_RegisterCustomerSelectBindingNavigator.ResumeLayout(false);
            this.sp_RegisterCustomerSelectBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

		}
        private System.ComponentModel.IContainer components;
        private Panel panel1;
        private CVESDAccounts cVESDAccounts;
        private BindingSource sp_RegisterCustomerSelectBindingSource;
        private CVESDAccountsTableAdapters.sp_RegisterCustomerSelectTableAdapter sp_RegisterCustomerSelectTableAdapter;
        private CVESDAccountsTableAdapters.TableAdapterManager tableAdapterManager;
        private BindingNavigator sp_RegisterCustomerSelectBindingNavigator;
        private ToolStripButton bindingNavigatorAddNewItem;
        private ToolStripLabel bindingNavigatorCountItem;
        private ToolStripButton bindingNavigatorDeleteItem;
        private ToolStripButton bindingNavigatorMoveFirstItem;
        private ToolStripButton bindingNavigatorMovePreviousItem;
        private ToolStripTextBox bindingNavigatorPositionItem;
        private ToolStripButton bindingNavigatorMoveNextItem;
        private ToolStripButton bindingNavigatorMoveLastItem;
        private ToolStripSeparator bindingNavigatorSeparator2;
        private ToolStripButton sp_RegisterCustomerSelectBindingNavigatorSaveItem;
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
        private Label label1;
        private ComboBox statComboBox;
        private GroupBox groupBox1;
        private Label label2;
        private PictureBox pictureBox1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnClose;
        private Panel panel2;
        private TextBox crLimitTextBox;
        private TextBox bTransportTextBox;
        private ComboBox bCityComboBox;
        private Panel panel3;
        private TextBox txtSearch;
        private Panel panel4;
        private Label label11;
        private ComboBox cboPayTerms;
        private Button button1;
        private ComboBox cbLocation;
        private TextBox sTNTextBox;
        private TextBox nTNTextBox;
    }
	
}
