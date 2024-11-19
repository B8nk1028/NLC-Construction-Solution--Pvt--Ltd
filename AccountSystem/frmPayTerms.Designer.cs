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
	partial class frmPayTerms : DevExpress.XtraEditors.XtraForm
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
            System.Windows.Forms.Label paymentTermsTxtLabel;
            System.Windows.Forms.Label maxValLabel;
            System.Windows.Forms.Label minValLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayTerms));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tblPaymentTermsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tblPaymentTermsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new AccountSystem.DataSet2();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tblPaymentTermsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.paymentTermsTxtTextBox = new System.Windows.Forms.TextBox();
            this.maxValNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.minValNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tblPaymentTermsTableAdapter = new AccountSystem.DataSet2TableAdapters.tblPaymentTermsTableAdapter();
            this.tableAdapterManager = new AccountSystem.DataSet2TableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            paymentTermsTxtLabel = new System.Windows.Forms.Label();
            maxValLabel = new System.Windows.Forms.Label();
            minValLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPaymentTermsBindingNavigator)).BeginInit();
            this.tblPaymentTermsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPaymentTermsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxValNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minValNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // paymentTermsTxtLabel
            // 
            paymentTermsTxtLabel.AutoSize = true;
            paymentTermsTxtLabel.Location = new System.Drawing.Point(108, 83);
            paymentTermsTxtLabel.Name = "paymentTermsTxtLabel";
            paymentTermsTxtLabel.Size = new System.Drawing.Size(88, 13);
            paymentTermsTxtLabel.TabIndex = 27;
            paymentTermsTxtLabel.Text = "Payment Terms :";
            // 
            // maxValLabel
            // 
            maxValLabel.AutoSize = true;
            maxValLabel.Location = new System.Drawing.Point(108, 107);
            maxValLabel.Name = "maxValLabel";
            maxValLabel.Size = new System.Drawing.Size(60, 13);
            maxValLabel.TabIndex = 29;
            maxValLabel.Text = "Max Value:";
            // 
            // minValLabel
            // 
            minValLabel.AutoSize = true;
            minValLabel.Location = new System.Drawing.Point(108, 134);
            minValLabel.Name = "minValLabel";
            minValLabel.Size = new System.Drawing.Size(56, 13);
            minValLabel.TabIndex = 31;
            minValLabel.Text = "Min Value:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tblPaymentTermsBindingNavigator);
            this.panel1.Controls.Add(paymentTermsTxtLabel);
            this.panel1.Controls.Add(this.paymentTermsTxtTextBox);
            this.panel1.Controls.Add(maxValLabel);
            this.panel1.Controls.Add(this.maxValNumericUpDown);
            this.panel1.Controls.Add(minValLabel);
            this.panel1.Controls.Add(this.minValNumericUpDown);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(185, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1035, 703);
            this.panel1.TabIndex = 2;
            // 
            // tblPaymentTermsBindingNavigator
            // 
            this.tblPaymentTermsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblPaymentTermsBindingNavigator.AutoSize = false;
            this.tblPaymentTermsBindingNavigator.BackColor = System.Drawing.Color.White;
            this.tblPaymentTermsBindingNavigator.BindingSource = this.tblPaymentTermsBindingSource;
            this.tblPaymentTermsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblPaymentTermsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblPaymentTermsBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.tblPaymentTermsBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tblPaymentTermsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorSeparator1,
            this.tblPaymentTermsBindingNavigatorSaveItem,
            this.bindingNavigatorSeparator2,
            this.btnClose});
            this.tblPaymentTermsBindingNavigator.Location = new System.Drawing.Point(111, 180);
            this.tblPaymentTermsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblPaymentTermsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblPaymentTermsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblPaymentTermsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblPaymentTermsBindingNavigator.Name = "tblPaymentTermsBindingNavigator";
            this.tblPaymentTermsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblPaymentTermsBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tblPaymentTermsBindingNavigator.Size = new System.Drawing.Size(377, 29);
            this.tblPaymentTermsBindingNavigator.TabIndex = 1;
            this.tblPaymentTermsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Margin = new System.Windows.Forms.Padding(100, 1, 0, 2);
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(74, 26);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // tblPaymentTermsBindingSource
            // 
            this.tblPaymentTermsBindingSource.DataMember = "tblPaymentTerms";
            this.tblPaymentTermsBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 26);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 26);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Visible = false;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 26);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            this.bindingNavigatorMoveFirstItem.Visible = false;
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 26);
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
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 26);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            this.bindingNavigatorMoveNextItem.Visible = false;
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 26);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            this.bindingNavigatorMoveLastItem.Visible = false;
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 29);
            // 
            // tblPaymentTermsBindingNavigatorSaveItem
            // 
            this.tblPaymentTermsBindingNavigatorSaveItem.Image = global::AccountSystem.Properties.Resources.save_all;
            this.tblPaymentTermsBindingNavigatorSaveItem.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.tblPaymentTermsBindingNavigatorSaveItem.Name = "tblPaymentTermsBindingNavigatorSaveItem";
            this.tblPaymentTermsBindingNavigatorSaveItem.Size = new System.Drawing.Size(78, 26);
            this.tblPaymentTermsBindingNavigatorSaveItem.Text = "Save Data";
            this.tblPaymentTermsBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblPaymentTermsBindingNavigatorSaveItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 29);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::AccountSystem.Properties.Resources.exit;
            this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClose.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 26);
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // paymentTermsTxtTextBox
            // 
            this.paymentTermsTxtTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPaymentTermsBindingSource, "PaymentTermsTxt", true));
            this.paymentTermsTxtTextBox.Location = new System.Drawing.Point(197, 80);
            this.paymentTermsTxtTextBox.Name = "paymentTermsTxtTextBox";
            this.paymentTermsTxtTextBox.Size = new System.Drawing.Size(291, 21);
            this.paymentTermsTxtTextBox.TabIndex = 28;
            // 
            // maxValNumericUpDown
            // 
            this.maxValNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblPaymentTermsBindingSource, "MaxVal", true));
            this.maxValNumericUpDown.Location = new System.Drawing.Point(197, 107);
            this.maxValNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.maxValNumericUpDown.Name = "maxValNumericUpDown";
            this.maxValNumericUpDown.Size = new System.Drawing.Size(120, 21);
            this.maxValNumericUpDown.TabIndex = 30;
            // 
            // minValNumericUpDown
            // 
            this.minValNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblPaymentTermsBindingSource, "MinVal", true));
            this.minValNumericUpDown.Location = new System.Drawing.Point(197, 134);
            this.minValNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.minValNumericUpDown.Name = "minValNumericUpDown";
            this.minValNumericUpDown.Size = new System.Drawing.Size(120, 21);
            this.minValNumericUpDown.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Payment Terms Settings";
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
            this.listBox1.DataSource = this.tblPaymentTermsBindingSource;
            this.listBox1.DisplayMember = "PaymentTermsTxt";
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(23, 43);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(156, 703);
            this.listBox1.TabIndex = 1;
            this.listBox1.ValueMember = "PaymentTermsID";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.35371F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.64629F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1040F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.357143F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.64286F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1223, 749);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment Term List";
            // 
            // tblPaymentTermsTableAdapter
            // 
            this.tblPaymentTermsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblLocationsTableAdapter = null;
            this.tableAdapterManager.tblPaymentTermsTableAdapter = this.tblPaymentTermsTableAdapter;
            this.tableAdapterManager.tblTireClaimsDTLTableAdapter = null;
            this.tableAdapterManager.tblTireClaimsHDRTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AccountSystem.DataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(383, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 0);
            this.button1.TabIndex = 33;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmPayTerms
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(1223, 749);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmPayTerms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment Terms";
            this.Load += new System.EventHandler(this.frmVendors_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPaymentTermsBindingNavigator)).EndInit();
            this.tblPaymentTermsBindingNavigator.ResumeLayout(false);
            this.tblPaymentTermsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPaymentTermsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxValNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minValNumericUpDown)).EndInit();
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
        private BindingSource tblPaymentTermsBindingSource;
        private DataSet2TableAdapters.tblPaymentTermsTableAdapter tblPaymentTermsTableAdapter;
        private DataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private BindingNavigator tblPaymentTermsBindingNavigator;
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
        private ToolStripButton tblPaymentTermsBindingNavigatorSaveItem;
        private ToolStripButton btnClose;
        private TextBox paymentTermsTxtTextBox;
        private NumericUpDown maxValNumericUpDown;
        private NumericUpDown minValNumericUpDown;
        private Button button1;
    }
	
}
