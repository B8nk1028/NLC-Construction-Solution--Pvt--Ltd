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
	partial class frmCityReg : DevExpress.XtraEditors.XtraForm
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
            System.Windows.Forms.Label cityNmaeLabel;
            System.Windows.Forms.Label regionLabel;
            System.Windows.Forms.Label provinceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCityReg));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tblLocationsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tblLocationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new AccountSystem.DataSet2();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tblLocationsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.cityNmaeTextBox = new System.Windows.Forms.TextBox();
            this.regionComboBox = new System.Windows.Forms.ComboBox();
            this.provinceComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tblLocationsTableAdapter = new AccountSystem.DataSet2TableAdapters.tblLocationsTableAdapter();
            this.tableAdapterManager = new AccountSystem.DataSet2TableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            cityNmaeLabel = new System.Windows.Forms.Label();
            regionLabel = new System.Windows.Forms.Label();
            provinceLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblLocationsBindingNavigator)).BeginInit();
            this.tblLocationsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblLocationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cityNmaeLabel
            // 
            cityNmaeLabel.AutoSize = true;
            cityNmaeLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            cityNmaeLabel.Location = new System.Drawing.Point(127, 105);
            cityNmaeLabel.Name = "cityNmaeLabel";
            cityNmaeLabel.Size = new System.Drawing.Size(67, 13);
            cityNmaeLabel.TabIndex = 27;
            cityNmaeLabel.Text = "City Name:";
            // 
            // regionLabel
            // 
            regionLabel.AutoSize = true;
            regionLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            regionLabel.Location = new System.Drawing.Point(127, 132);
            regionLabel.Name = "regionLabel";
            regionLabel.Size = new System.Drawing.Size(49, 13);
            regionLabel.TabIndex = 29;
            regionLabel.Text = "Region:";
            // 
            // provinceLabel
            // 
            provinceLabel.AutoSize = true;
            provinceLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            provinceLabel.Location = new System.Drawing.Point(127, 159);
            provinceLabel.Name = "provinceLabel";
            provinceLabel.Size = new System.Drawing.Size(59, 13);
            provinceLabel.TabIndex = 31;
            provinceLabel.Text = "Province:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tblLocationsBindingNavigator);
            this.panel1.Controls.Add(cityNmaeLabel);
            this.panel1.Controls.Add(this.cityNmaeTextBox);
            this.panel1.Controls.Add(regionLabel);
            this.panel1.Controls.Add(this.regionComboBox);
            this.panel1.Controls.Add(provinceLabel);
            this.panel1.Controls.Add(this.provinceComboBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(171, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 703);
            this.panel1.TabIndex = 2;
            // 
            // tblLocationsBindingNavigator
            // 
            this.tblLocationsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblLocationsBindingNavigator.AutoSize = false;
            this.tblLocationsBindingNavigator.BackColor = System.Drawing.SystemColors.Window;
            this.tblLocationsBindingNavigator.BindingSource = this.tblLocationsBindingSource;
            this.tblLocationsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblLocationsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblLocationsBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.tblLocationsBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tblLocationsBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tblLocationsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorSeparator1,
            this.tblLocationsBindingNavigatorSaveItem,
            this.bindingNavigatorSeparator2,
            this.btnClose});
            this.tblLocationsBindingNavigator.Location = new System.Drawing.Point(113, 208);
            this.tblLocationsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblLocationsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblLocationsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblLocationsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblLocationsBindingNavigator.Name = "tblLocationsBindingNavigator";
            this.tblLocationsBindingNavigator.Padding = new System.Windows.Forms.Padding(0);
            this.tblLocationsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblLocationsBindingNavigator.Size = new System.Drawing.Size(370, 33);
            this.tblLocationsBindingNavigator.TabIndex = 1;
            this.tblLocationsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(107, 30);
            this.bindingNavigatorAddNewItem.Text = "Add New City";
            // 
            // tblLocationsBindingSource
            // 
            this.tblLocationsBindingSource.DataMember = "tblLocations";
            this.tblLocationsBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // tblLocationsBindingNavigatorSaveItem
            // 
            this.tblLocationsBindingNavigatorSaveItem.Image = global::AccountSystem.Properties.Resources.save_all;
            this.tblLocationsBindingNavigatorSaveItem.Name = "tblLocationsBindingNavigatorSaveItem";
            this.tblLocationsBindingNavigatorSaveItem.Size = new System.Drawing.Size(101, 30);
            this.tblLocationsBindingNavigatorSaveItem.Text = "Save Record";
            this.tblLocationsBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblLocationsBindingNavigatorSaveItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::AccountSystem.Properties.Resources.exit;
            this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 30);
            this.btnClose.Text = "Close Form";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cityNmaeTextBox
            // 
            this.cityNmaeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblLocationsBindingSource, "CityNmae", true));
            this.cityNmaeTextBox.Location = new System.Drawing.Point(198, 102);
            this.cityNmaeTextBox.Name = "cityNmaeTextBox";
            this.cityNmaeTextBox.Size = new System.Drawing.Size(121, 21);
            this.cityNmaeTextBox.TabIndex = 28;
            // 
            // regionComboBox
            // 
            this.regionComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblLocationsBindingSource, "Region", true));
            this.regionComboBox.FormattingEnabled = true;
            this.regionComboBox.Location = new System.Drawing.Point(198, 129);
            this.regionComboBox.Name = "regionComboBox";
            this.regionComboBox.Size = new System.Drawing.Size(121, 21);
            this.regionComboBox.TabIndex = 30;
            this.regionComboBox.SelectedIndexChanged += new System.EventHandler(this.regionComboBox_SelectedIndexChanged);
            // 
            // provinceComboBox
            // 
            this.provinceComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblLocationsBindingSource, "Province", true));
            this.provinceComboBox.FormattingEnabled = true;
            this.provinceComboBox.Location = new System.Drawing.Point(198, 156);
            this.provinceComboBox.Name = "provinceComboBox";
            this.provinceComboBox.Size = new System.Drawing.Size(121, 21);
            this.provinceComboBox.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "City Management";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 29);
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
            this.groupBox1.Size = new System.Drawing.Size(2, 703);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.DataSource = this.tblLocationsBindingSource;
            this.listBox1.DisplayMember = "CityNmae";
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(22, 43);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(143, 703);
            this.listBox1.TabIndex = 1;
            this.listBox1.ValueMember = "CityID";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.35371F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.64629F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1037F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.357143F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.64286F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1206, 749);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "City List";
            // 
            // tblLocationsTableAdapter
            // 
            this.tblLocationsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblLocationsTableAdapter = this.tblLocationsTableAdapter;
            this.tableAdapterManager.tblPaymentTermsTableAdapter = null;
            this.tableAdapterManager.tblTireClaimsDTLTableAdapter = null;
            this.tableAdapterManager.tblTireClaimsHDRTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AccountSystem.DataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(428, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 0);
            this.button1.TabIndex = 33;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmCityReg
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(1206, 749);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmCityReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "City Registration";
            this.Load += new System.EventHandler(this.frmVendors_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblLocationsBindingNavigator)).EndInit();
            this.tblLocationsBindingNavigator.ResumeLayout(false);
            this.tblLocationsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblLocationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

		}
        private System.ComponentModel.IContainer components;
        private Panel panel1;
        private ListBox listBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private PictureBox pictureBox1;
        private DataSet2 dataSet2;
        private BindingSource tblLocationsBindingSource;
        private DataSet2TableAdapters.tblLocationsTableAdapter tblLocationsTableAdapter;
        private DataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private BindingNavigator tblLocationsBindingNavigator;
        private ToolStripButton bindingNavigatorAddNewItem;
        private ToolStripLabel bindingNavigatorCountItem;
        private ToolStripButton bindingNavigatorDeleteItem;
        private ToolStripButton bindingNavigatorMoveFirstItem;
        private ToolStripButton bindingNavigatorMovePreviousItem;
        private ToolStripTextBox bindingNavigatorPositionItem;
        private ToolStripSeparator bindingNavigatorSeparator1;
        private ToolStripButton bindingNavigatorMoveNextItem;
        private ToolStripButton bindingNavigatorMoveLastItem;
        private ToolStripSeparator bindingNavigatorSeparator2;
        private ToolStripButton tblLocationsBindingNavigatorSaveItem;
        private TextBox cityNmaeTextBox;
        private ComboBox regionComboBox;
        private ComboBox provinceComboBox;
        private ToolStripButton btnClose;
        private Button button1;
    }
	
}
