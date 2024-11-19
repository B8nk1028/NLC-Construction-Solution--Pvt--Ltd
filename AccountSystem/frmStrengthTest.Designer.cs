using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
//
using System.Linq;
using System;
using System.Collections;
using System.Xml.Linq;
using System.Windows.Forms;

namespace AccountSystem
{
	partial class frmStrengthTest : DevExpress.XtraEditors.XtraForm
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
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
			{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStrengthTest));
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress = new DevExpress.XtraEditors.LabelControl();
            this.cboVendor = new System.Windows.Forms.ComboBox();
            this.cboProducts = new SergeUtils.EasyCompletionComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dttestDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtProdDT = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtavg = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRmks = new System.Windows.Forms.TextBox();
            this.voucherEd = new AccountSystem.VoucherEd();
            this.tblStrengthTestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblStrengthTestTableAdapter = new AccountSystem.VoucherEdTableAdapters.tblStrengthTestTableAdapter();
            this.tableAdapterManager = new AccountSystem.VoucherEdTableAdapters.TableAdapterManager();
            this.tblStrengthTestBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tblStrengthTestBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.txtT1 = new System.Windows.Forms.TextBox();
            this.txtT2 = new System.Windows.Forms.TextBox();
            this.txtT3 = new System.Windows.Forms.TextBox();
            this.txtS3 = new System.Windows.Forms.TextBox();
            this.txtS2 = new System.Windows.Forms.TextBox();
            this.txtS1 = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.voucherEd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStrengthTestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStrengthTestBindingNavigator)).BeginInit();
            this.tblStrengthTestBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Client Name";
            // 
            // txtAddress
            // 
            this.txtAddress.AllowHtmlString = true;
            this.txtAddress.Location = new System.Drawing.Point(20, 55);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(8, 14);
            this.txtAddress.TabIndex = 9;
            this.txtAddress.Text = "..";
            // 
            // cboVendor
            // 
            this.cboVendor.BackColor = System.Drawing.SystemColors.Window;
            this.cboVendor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblStrengthTestBindingSource, "ClientID", true));
            this.cboVendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVendor.FormattingEnabled = true;
            this.cboVendor.Location = new System.Drawing.Point(15, 28);
            this.cboVendor.Name = "cboVendor";
            this.cboVendor.Size = new System.Drawing.Size(342, 21);
            this.cboVendor.TabIndex = 8;
            this.cboVendor.SelectedIndexChanged += new System.EventHandler(this.cboVendor_SelectedIndexChanged);
            // 
            // cboProducts
            // 
            this.cboProducts.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblStrengthTestBindingSource, "ProductID", true));
            this.cboProducts.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProducts.FormattingEnabled = true;
            this.cboProducts.Location = new System.Drawing.Point(15, 118);
            this.cboProducts.MatchingMethod = SergeUtils.StringMatchingMethod.UseWildcards;
            this.cboProducts.Name = "cboProducts";
            this.cboProducts.Size = new System.Drawing.Size(342, 22);
            this.cboProducts.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(12, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Product Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(427, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Test Date";
            // 
            // dttestDate
            // 
            this.dttestDate.CustomFormat = "ddMMMMyyyy";
            this.dttestDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblStrengthTestBindingSource, "TestDate", true));
            this.dttestDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dttestDate.Location = new System.Drawing.Point(500, 28);
            this.dttestDate.Name = "dttestDate";
            this.dttestDate.Size = new System.Drawing.Size(137, 21);
            this.dttestDate.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(391, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Production Date";
            // 
            // dtProdDT
            // 
            this.dtProdDT.CustomFormat = "ddMMMMyyyy";
            this.dtProdDT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblStrengthTestBindingSource, "ProductionDt", true));
            this.dtProdDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtProdDT.Location = new System.Drawing.Point(500, 118);
            this.dtProdDT.Name = "dtProdDT";
            this.dtProdDT.Size = new System.Drawing.Size(137, 21);
            this.dtProdDT.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(12, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Area (Sq inch)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Italic);
            this.label5.Location = new System.Drawing.Point(12, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 18);
            this.label5.TabIndex = 22;
            this.label5.Text = "Machine Reading (lbs)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Italic);
            this.label6.Location = new System.Drawing.Point(202, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 18);
            this.label6.TabIndex = 26;
            this.label6.Text = "Crushing Strenght (psi)";
            // 
            // txtavg
            // 
            this.txtavg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtavg.Location = new System.Drawing.Point(193, 297);
            this.txtavg.Name = "txtavg";
            this.txtavg.ReadOnly = true;
            this.txtavg.Size = new System.Drawing.Size(125, 20);
            this.txtavg.TabIndex = 63;
            this.txtavg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Italic);
            this.label7.Location = new System.Drawing.Point(90, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 18);
            this.label7.TabIndex = 64;
            this.label7.Text = "Average (psi)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Italic);
            this.label8.Location = new System.Drawing.Point(18, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 18);
            this.label8.TabIndex = 66;
            this.label8.Text = "Remarks";
            // 
            // txtRmks
            // 
            this.txtRmks.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblStrengthTestBindingSource, "Rearks", true));
            this.txtRmks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRmks.Location = new System.Drawing.Point(93, 333);
            this.txtRmks.Multiline = true;
            this.txtRmks.Name = "txtRmks";
            this.txtRmks.Size = new System.Drawing.Size(544, 39);
            this.txtRmks.TabIndex = 65;
            // 
            // voucherEd
            // 
            this.voucherEd.DataSetName = "VoucherEd";
            this.voucherEd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblStrengthTestBindingSource
            // 
            this.tblStrengthTestBindingSource.DataMember = "tblStrengthTest";
            this.tblStrengthTestBindingSource.DataSource = this.voucherEd;
            // 
            // tblStrengthTestTableAdapter
            // 
            this.tblStrengthTestTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblStrengthTestTableAdapter = this.tblStrengthTestTableAdapter;
            this.tableAdapterManager.TblVoucherDTLTableAdapter = null;
            this.tableAdapterManager.TblVoucherHDRTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AccountSystem.VoucherEdTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblStrengthTestBindingNavigator
            // 
            this.tblStrengthTestBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblStrengthTestBindingNavigator.AutoSize = false;
            this.tblStrengthTestBindingNavigator.BackColor = System.Drawing.SystemColors.Control;
            this.tblStrengthTestBindingNavigator.BindingSource = this.tblStrengthTestBindingSource;
            this.tblStrengthTestBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblStrengthTestBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblStrengthTestBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tblStrengthTestBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tblStrengthTestBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.toolStripSeparator1,
            this.bindingNavigatorDeleteItem,
            this.toolStripSeparator2,
            this.tblStrengthTestBindingNavigatorSaveItem,
            this.toolStripSeparator3,
            this.btnClose});
            this.tblStrengthTestBindingNavigator.Location = new System.Drawing.Point(0, 427);
            this.tblStrengthTestBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblStrengthTestBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblStrengthTestBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblStrengthTestBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblStrengthTestBindingNavigator.Name = "tblStrengthTestBindingNavigator";
            this.tblStrengthTestBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblStrengthTestBindingNavigator.Size = new System.Drawing.Size(873, 40);
            this.tblStrengthTestBindingNavigator.TabIndex = 68;
            this.tblStrengthTestBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 37);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 37);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 40);
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 37);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 37);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 37);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Margin = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(74, 37);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(60, 37);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // tblStrengthTestBindingNavigatorSaveItem
            // 
            this.tblStrengthTestBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblStrengthTestBindingNavigatorSaveItem.Image")));
            this.tblStrengthTestBindingNavigatorSaveItem.Name = "tblStrengthTestBindingNavigatorSaveItem";
            this.tblStrengthTestBindingNavigatorSaveItem.Size = new System.Drawing.Size(78, 37);
            this.tblStrengthTestBindingNavigatorSaveItem.Text = "Save Data";
            this.tblStrengthTestBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblStrengthTestBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::AccountSystem.Properties.Resources.exit;
            this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 37);
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 40);
            // 
            // txtT1
            // 
            this.txtT1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblStrengthTestBindingSource, "Test1", true));
            this.txtT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtT1.Location = new System.Drawing.Point(15, 206);
            this.txtT1.Name = "txtT1";
            this.txtT1.Size = new System.Drawing.Size(113, 20);
            this.txtT1.TabIndex = 69;
            this.txtT1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtT1.TextChanged += new System.EventHandler(this.txtT1_ValueChanged);
            // 
            // txtT2
            // 
            this.txtT2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblStrengthTestBindingSource, "Test2", true));
            this.txtT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtT2.Location = new System.Drawing.Point(15, 234);
            this.txtT2.Name = "txtT2";
            this.txtT2.Size = new System.Drawing.Size(113, 20);
            this.txtT2.TabIndex = 70;
            this.txtT2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtT2.TextChanged += new System.EventHandler(this.txtT1_ValueChanged);
            // 
            // txtT3
            // 
            this.txtT3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblStrengthTestBindingSource, "Test3", true));
            this.txtT3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtT3.Location = new System.Drawing.Point(15, 260);
            this.txtT3.Name = "txtT3";
            this.txtT3.Size = new System.Drawing.Size(113, 20);
            this.txtT3.TabIndex = 71;
            this.txtT3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtT3.TextChanged += new System.EventHandler(this.txtT1_ValueChanged);
            // 
            // txtS3
            // 
            this.txtS3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtS3.Location = new System.Drawing.Point(205, 256);
            this.txtS3.Name = "txtS3";
            this.txtS3.ReadOnly = true;
            this.txtS3.Size = new System.Drawing.Size(113, 20);
            this.txtS3.TabIndex = 74;
            this.txtS3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtS2
            // 
            this.txtS2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtS2.Location = new System.Drawing.Point(205, 230);
            this.txtS2.Name = "txtS2";
            this.txtS2.ReadOnly = true;
            this.txtS2.Size = new System.Drawing.Size(113, 20);
            this.txtS2.TabIndex = 73;
            this.txtS2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtS1
            // 
            this.txtS1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtS1.Location = new System.Drawing.Point(205, 202);
            this.txtS1.Name = "txtS1";
            this.txtS1.ReadOnly = true;
            this.txtS1.Size = new System.Drawing.Size(113, 20);
            this.txtS1.TabIndex = 72;
            this.txtS1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtArea
            // 
            this.txtArea.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblStrengthTestBindingSource, "Area", true));
            this.txtArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArea.Location = new System.Drawing.Point(120, 146);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(113, 20);
            this.txtArea.TabIndex = 75;
            this.txtArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmStrengthTest
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 467);
            this.ControlBox = false;
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtS3);
            this.Controls.Add(this.txtS2);
            this.Controls.Add(this.txtS1);
            this.Controls.Add(this.txtT3);
            this.Controls.Add(this.txtT2);
            this.Controls.Add(this.txtT1);
            this.Controls.Add(this.tblStrengthTestBindingNavigator);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtRmks);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtavg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtProdDT);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dttestDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboProducts);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.cboVendor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.SkinName = "Black";
            this.Name = "frmStrengthTest";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Strength Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.About_FormClosing);
            this.Load += new System.EventHandler(this.About_Load);
            ((System.ComponentModel.ISupportInitialize)(this.voucherEd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStrengthTestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStrengthTestBindingNavigator)).EndInit();
            this.tblStrengthTestBindingNavigator.ResumeLayout(false);
            this.tblStrengthTestBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
        private System.ComponentModel.IContainer components;
        private Label label4;
        private DevExpress.XtraEditors.LabelControl txtAddress;
        private ComboBox cboVendor;
        private SergeUtils.EasyCompletionComboBox cboProducts;
        private Label label1;
        private Label label10;
        private DateTimePicker dttestDate;
        private Label label2;
        private DateTimePicker dtProdDT;
        private Label label3;
        private Label label5;
        private Label label6;
        public TextBox txtavg;
        private Label label7;
        private Label label8;
        public TextBox txtRmks;
        private VoucherEd voucherEd;
        private BindingSource tblStrengthTestBindingSource;
        private VoucherEdTableAdapters.tblStrengthTestTableAdapter tblStrengthTestTableAdapter;
        private VoucherEdTableAdapters.TableAdapterManager tableAdapterManager;
        private BindingNavigator tblStrengthTestBindingNavigator;
        private ToolStripButton bindingNavigatorAddNewItem;
        private ToolStripLabel bindingNavigatorCountItem;
        private ToolStripButton bindingNavigatorDeleteItem;
        private ToolStripButton bindingNavigatorMoveFirstItem;
        private ToolStripButton bindingNavigatorMovePreviousItem;
        private ToolStripSeparator bindingNavigatorSeparator;
        private ToolStripTextBox bindingNavigatorPositionItem;
        private ToolStripSeparator bindingNavigatorSeparator1;
        private ToolStripButton bindingNavigatorMoveNextItem;
        private ToolStripButton bindingNavigatorMoveLastItem;
        private ToolStripSeparator bindingNavigatorSeparator2;
        private ToolStripButton tblStrengthTestBindingNavigatorSaveItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton btnClose;
        public TextBox txtT1;
        public TextBox txtT2;
        public TextBox txtT3;
        public TextBox txtS3;
        public TextBox txtS2;
        public TextBox txtS1;
        public TextBox txtArea;
    }
	
}
