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
	partial class frmUsers : DevExpress.XtraEditors.XtraForm
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
            System.Windows.Forms.Label Label4;
            System.Windows.Forms.Label Label5;
            System.Windows.Forms.Label PasswordLabel;
            System.Windows.Forms.Label Label2;
            System.Windows.Forms.Label User_NameLabel;
            System.Windows.Forms.Label Label3;
            System.Windows.Forms.Label Label1;
            System.Windows.Forms.Label StatusLabel;
            System.Windows.Forms.Label label6;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TblUserDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.repliDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.softIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVoucherDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnBVoucherDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnCahsVDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnLedgerDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnTBDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnISDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnBSDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnFCDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.expenseSheetDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnPurchaseDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnPurchaseOrderDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnPOEditDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnSaleDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnDeliveryChallanDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnEditSaleOrderDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnIssuanceDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnSaleRDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnPurchRDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnDisSchDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnPurVenDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnCustSDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnSalesmenDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnSalemanProductDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnProdLadgerDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnStockDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnBTCDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnUsersDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnCompanyDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnBackupDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnAppSettingDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnProductDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnProPrerDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnProdListDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnStoreDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnVendorsDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnEmployeesDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnCustomersDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnChartAccDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.branchIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TblUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UsersDataSet = new AccountSystem.UsersDataSet();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnBSCheckBox = new System.Windows.Forms.CheckBox();
            this.btnOverdueBalancesCheckBox = new System.Windows.Forms.CheckBox();
            this.btnISCheckBox = new System.Windows.Forms.CheckBox();
            this.btnLedgerinUSDCheckBox = new System.Windows.Forms.CheckBox();
            this.btnGeneralEntriesCheckBox = new System.Windows.Forms.CheckBox();
            this.btnTBCheckBox = new System.Windows.Forms.CheckBox();
            this.btnDisSchCheckBox = new System.Windows.Forms.CheckBox();
            this.btnLedgerCheckBox = new System.Windows.Forms.CheckBox();
            this.btnCahsVCheckBox = new System.Windows.Forms.CheckBox();
            this.btnBVoucherCheckBox = new System.Windows.Forms.CheckBox();
            this.btnVoucherCheckBox = new System.Windows.Forms.CheckBox();
            this.btnSearchVouchersCheckBox = new System.Windows.Forms.CheckBox();
            this.btnFundTransferCheckBox = new System.Windows.Forms.CheckBox();
            this.btnVoucherPostingCheckBox = new System.Windows.Forms.CheckBox();
            this.btnPaymenttoVendorCheckBox = new System.Windows.Forms.CheckBox();
            this.btnReceiptsReportCheckBox = new System.Windows.Forms.CheckBox();
            this.btnVoucherPreviewCheckBox = new System.Windows.Forms.CheckBox();
            this.btnEditVouchersCheckBox = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnWalkinCustCheckBox = new System.Windows.Forms.CheckBox();
            this.btnPurchaseOrderCheckBox = new System.Windows.Forms.CheckBox();
            this.btnPOEditCheckBox = new System.Windows.Forms.CheckBox();
            this.btnOrderStatusCheckBox = new System.Windows.Forms.CheckBox();
            this.btnPurchRCheckBox = new System.Windows.Forms.CheckBox();
            this.btnPurVenCheckBox = new System.Windows.Forms.CheckBox();
            this.btnSaleRCheckBox = new System.Windows.Forms.CheckBox();
            this.btnIssuanceCheckBox = new System.Windows.Forms.CheckBox();
            this.btnEditSaleOrderCheckBox = new System.Windows.Forms.CheckBox();
            this.btnDeliveryChallanCheckBox = new System.Windows.Forms.CheckBox();
            this.btnStockCheckBox = new System.Windows.Forms.CheckBox();
            this.btnProdLadgerCheckBox = new System.Windows.Forms.CheckBox();
            this.btnSaleCheckBox = new System.Windows.Forms.CheckBox();
            this.btnPurchaseCheckBox = new System.Windows.Forms.CheckBox();
            this.btnOverdueInvoicesCheckBox = new System.Windows.Forms.CheckBox();
            this.btnSaleRegCheckBox = new System.Windows.Forms.CheckBox();
            this.btnPurchaseRegCheckBox = new System.Windows.Forms.CheckBox();
            this.btnChangeOrderStatusCheckBox = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnSalesmenCheckBox = new System.Windows.Forms.CheckBox();
            this.btnSalemanProductCheckBox = new System.Windows.Forms.CheckBox();
            this.vendorBalancesCheckBox = new System.Windows.Forms.CheckBox();
            this.btnCustBalanceCheckBox = new System.Windows.Forms.CheckBox();
            this.btnCashBankBalancesCheckBox = new System.Windows.Forms.CheckBox();
            this.btnProfitabilityCheckBox = new System.Windows.Forms.CheckBox();
            this.btnEmpProCheckBox = new System.Windows.Forms.CheckBox();
            this.btnCustSCheckBox = new System.Windows.Forms.CheckBox();
            this.btnMonthWiseSaleCheckBox = new System.Windows.Forms.CheckBox();
            this.expenseSheetCheckBox = new System.Windows.Forms.CheckBox();
            this.btnFCCheckBox = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnBTCCheckBox = new System.Windows.Forms.CheckBox();
            this.btnClaimFormEditCheckBox = new System.Windows.Forms.CheckBox();
            this.btnRPTTIRECLAIMSCheckBox = new System.Windows.Forms.CheckBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnDayClosingCheckBox = new System.Windows.Forms.CheckBox();
            this.btnCityRegCheckBox = new System.Windows.Forms.CheckBox();
            this.btnPaymenttermsCheckBox = new System.Windows.Forms.CheckBox();
            this.btnUsersCheckBox = new System.Windows.Forms.CheckBox();
            this.btnCompanyCheckBox = new System.Windows.Forms.CheckBox();
            this.btnChartAccCheckBox = new System.Windows.Forms.CheckBox();
            this.btnCustomersCheckBox = new System.Windows.Forms.CheckBox();
            this.btnEmployeesCheckBox = new System.Windows.Forms.CheckBox();
            this.btnVendorsCheckBox = new System.Windows.Forms.CheckBox();
            this.btnStoreCheckBox = new System.Windows.Forms.CheckBox();
            this.btnProdListCheckBox = new System.Windows.Forms.CheckBox();
            this.btnProPrerCheckBox = new System.Windows.Forms.CheckBox();
            this.btnProductCheckBox = new System.Windows.Forms.CheckBox();
            this.btnAppSettingCheckBox = new System.Windows.Forms.CheckBox();
            this.btnBackupCheckBox = new System.Windows.Forms.CheckBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tblAccEntryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PictureBox4 = new System.Windows.Forms.PictureBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.User_NameTextBox = new System.Windows.Forms.TextBox();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.TblUserBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.BindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.BindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.BindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.BindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TblUserBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.ToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.StatusCheckBox = new System.Windows.Forms.CheckBox();
            this.GroupType = new System.Windows.Forms.GroupBox();
            this.RadioBClient = new System.Windows.Forms.RadioButton();
            this.RadioBComm = new System.Windows.Forms.RadioButton();
            this.RadioBAdmin = new System.Windows.Forms.RadioButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.PictureBox5 = new System.Windows.Forms.PictureBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TblUserTableAdapter = new AccountSystem.UsersDataSetTableAdapters.TblUserTableAdapter();
            this.TableAdapterManager = new AccountSystem.UsersDataSetTableAdapters.TableAdapterManager();
            this.tblAccEntryTableAdapter = new AccountSystem.UsersDataSetTableAdapters.TblAccEntryTableAdapter();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.showhidedashCheckBox = new System.Windows.Forms.CheckBox();
            Label4 = new System.Windows.Forms.Label();
            Label5 = new System.Windows.Forms.Label();
            PasswordLabel = new System.Windows.Forms.Label();
            Label2 = new System.Windows.Forms.Label();
            User_NameLabel = new System.Windows.Forms.Label();
            Label3 = new System.Windows.Forms.Label();
            Label1 = new System.Windows.Forms.Label();
            StatusLabel = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TblUserDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataSet)).BeginInit();
            this.Panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAccEntryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblUserBindingNavigator)).BeginInit();
            this.TblUserBindingNavigator.SuspendLayout();
            this.GroupType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Location = new System.Drawing.Point(80, 41);
            Label4.Name = "Label4";
            Label4.Size = new System.Drawing.Size(106, 13);
            Label4.TabIndex = 26;
            Label4.Text = "Create New Account";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            Label5.Location = new System.Drawing.Point(78, 21);
            Label5.Name = "Label5";
            Label5.Size = new System.Drawing.Size(153, 19);
            Label5.TabIndex = 24;
            Label5.Text = "Add/Change User";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new System.Drawing.Point(7, 49);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new System.Drawing.Size(57, 13);
            PasswordLabel.TabIndex = 3;
            PasswordLabel.Text = "Password:";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new System.Drawing.Point(7, 80);
            Label2.Name = "Label2";
            Label2.Size = new System.Drawing.Size(52, 13);
            Label2.TabIndex = 5;
            Label2.Text = "Re-Type:";
            // 
            // User_NameLabel
            // 
            User_NameLabel.AutoSize = true;
            User_NameLabel.Location = new System.Drawing.Point(7, 22);
            User_NameLabel.Name = "User_NameLabel";
            User_NameLabel.Size = new System.Drawing.Size(63, 13);
            User_NameLabel.TabIndex = 1;
            User_NameLabel.Text = "User Name:";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new System.Drawing.Point(49, 56);
            Label3.Name = "Label3";
            Label3.Size = new System.Drawing.Size(106, 13);
            Label3.TabIndex = 23;
            Label3.Text = "Create New Account";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            Label1.Location = new System.Drawing.Point(47, 37);
            Label1.Name = "Label1";
            Label1.Size = new System.Drawing.Size(153, 19);
            Label1.TabIndex = 0;
            Label1.Text = "Add/Change User";
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new System.Drawing.Point(381, 3);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new System.Drawing.Size(80, 13);
            StatusLabel.TabIndex = 10;
            StatusLabel.Text = "Account Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(7, 104);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(54, 13);
            label6.TabIndex = 23;
            label6.Text = "Location :";
            // 
            // TblUserDataGridView
            // 
            this.TblUserDataGridView.AllowUserToAddRows = false;
            this.TblUserDataGridView.AllowUserToDeleteRows = false;
            this.TblUserDataGridView.AllowUserToResizeColumns = false;
            this.TblUserDataGridView.AllowUserToResizeRows = false;
            this.TblUserDataGridView.AutoGenerateColumns = false;
            this.TblUserDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.TblUserDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TblUserDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.TblUserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TblUserDataGridView.ColumnHeadersVisible = false;
            this.TblUserDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.UserName,
            this.userIDDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.userTypeDataGridViewTextBoxColumn,
            this.statusDataGridViewCheckBoxColumn,
            this.repliDataGridViewCheckBoxColumn,
            this.softIDDataGridViewTextBoxColumn,
            this.btnVoucherDataGridViewCheckBoxColumn,
            this.btnBVoucherDataGridViewCheckBoxColumn,
            this.btnCahsVDataGridViewCheckBoxColumn,
            this.btnLedgerDataGridViewCheckBoxColumn,
            this.btnTBDataGridViewCheckBoxColumn,
            this.btnISDataGridViewCheckBoxColumn,
            this.btnBSDataGridViewCheckBoxColumn,
            this.btnFCDataGridViewCheckBoxColumn,
            this.expenseSheetDataGridViewCheckBoxColumn,
            this.btnPurchaseDataGridViewCheckBoxColumn,
            this.btnPurchaseOrderDataGridViewCheckBoxColumn,
            this.btnPOEditDataGridViewCheckBoxColumn,
            this.btnSaleDataGridViewCheckBoxColumn,
            this.btnDeliveryChallanDataGridViewCheckBoxColumn,
            this.btnEditSaleOrderDataGridViewCheckBoxColumn,
            this.btnIssuanceDataGridViewCheckBoxColumn,
            this.btnSaleRDataGridViewCheckBoxColumn,
            this.btnPurchRDataGridViewCheckBoxColumn,
            this.btnDisSchDataGridViewCheckBoxColumn,
            this.btnPurVenDataGridViewCheckBoxColumn,
            this.btnCustSDataGridViewCheckBoxColumn,
            this.btnSalesmenDataGridViewCheckBoxColumn,
            this.btnSalemanProductDataGridViewCheckBoxColumn,
            this.btnProdLadgerDataGridViewCheckBoxColumn,
            this.btnStockDataGridViewCheckBoxColumn,
            this.btnBTCDataGridViewCheckBoxColumn,
            this.btnUsersDataGridViewCheckBoxColumn,
            this.btnCompanyDataGridViewCheckBoxColumn,
            this.btnBackupDataGridViewCheckBoxColumn,
            this.btnAppSettingDataGridViewCheckBoxColumn,
            this.btnProductDataGridViewCheckBoxColumn,
            this.btnProPrerDataGridViewCheckBoxColumn,
            this.btnProdListDataGridViewCheckBoxColumn,
            this.btnStoreDataGridViewCheckBoxColumn,
            this.btnVendorsDataGridViewCheckBoxColumn,
            this.btnEmployeesDataGridViewCheckBoxColumn,
            this.btnCustomersDataGridViewCheckBoxColumn,
            this.btnChartAccDataGridViewCheckBoxColumn,
            this.branchIDDataGridViewTextBoxColumn});
            this.TblUserDataGridView.DataSource = this.TblUserBindingSource;
            this.TblUserDataGridView.GridColor = System.Drawing.Color.White;
            this.TblUserDataGridView.Location = new System.Drawing.Point(134, 56);
            this.TblUserDataGridView.Name = "TblUserDataGridView";
            this.TblUserDataGridView.ReadOnly = true;
            this.TblUserDataGridView.RowHeadersVisible = false;
            this.TblUserDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TblUserDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.TblUserDataGridView.RowTemplate.Height = 35;
            this.TblUserDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TblUserDataGridView.Size = new System.Drawing.Size(361, 242);
            this.TblUserDataGridView.TabIndex = 1;
            this.TblUserDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TblUserDataGridView_CellDoubleClick);
            this.TblUserDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.TblUserDataGridView_CellFormatting);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Image = ((System.Drawing.Image)(resources.GetObject("Column1.Image")));
            this.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 40;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.UserName.DefaultCellStyle = dataGridViewCellStyle1;
            this.UserName.HeaderText = "User Name";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 250;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.userNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordDataGridViewTextBoxColumn.Visible = false;
            // 
            // userTypeDataGridViewTextBoxColumn
            // 
            this.userTypeDataGridViewTextBoxColumn.DataPropertyName = "UserType";
            this.userTypeDataGridViewTextBoxColumn.HeaderText = "UserType";
            this.userTypeDataGridViewTextBoxColumn.Name = "userTypeDataGridViewTextBoxColumn";
            this.userTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.userTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewCheckBoxColumn.HeaderText = "Status";
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            this.statusDataGridViewCheckBoxColumn.ReadOnly = true;
            this.statusDataGridViewCheckBoxColumn.Visible = false;
            // 
            // repliDataGridViewCheckBoxColumn
            // 
            this.repliDataGridViewCheckBoxColumn.DataPropertyName = "Repli";
            this.repliDataGridViewCheckBoxColumn.HeaderText = "Repli";
            this.repliDataGridViewCheckBoxColumn.Name = "repliDataGridViewCheckBoxColumn";
            this.repliDataGridViewCheckBoxColumn.ReadOnly = true;
            this.repliDataGridViewCheckBoxColumn.Visible = false;
            // 
            // softIDDataGridViewTextBoxColumn
            // 
            this.softIDDataGridViewTextBoxColumn.DataPropertyName = "SoftID";
            this.softIDDataGridViewTextBoxColumn.HeaderText = "SoftID";
            this.softIDDataGridViewTextBoxColumn.Name = "softIDDataGridViewTextBoxColumn";
            this.softIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.softIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // btnVoucherDataGridViewCheckBoxColumn
            // 
            this.btnVoucherDataGridViewCheckBoxColumn.DataPropertyName = "btnVoucher";
            this.btnVoucherDataGridViewCheckBoxColumn.HeaderText = "btnVoucher";
            this.btnVoucherDataGridViewCheckBoxColumn.Name = "btnVoucherDataGridViewCheckBoxColumn";
            this.btnVoucherDataGridViewCheckBoxColumn.ReadOnly = true;
            this.btnVoucherDataGridViewCheckBoxColumn.Visible = false;
            // 
            // btnBVoucherDataGridViewCheckBoxColumn
            // 
            this.btnBVoucherDataGridViewCheckBoxColumn.DataPropertyName = "btnBVoucher";
            this.btnBVoucherDataGridViewCheckBoxColumn.HeaderText = "btnBVoucher";
            this.btnBVoucherDataGridViewCheckBoxColumn.Name = "btnBVoucherDataGridViewCheckBoxColumn";
            this.btnBVoucherDataGridViewCheckBoxColumn.ReadOnly = true;
            this.btnBVoucherDataGridViewCheckBoxColumn.Visible = false;
            // 
            // btnCahsVDataGridViewCheckBoxColumn
            // 
            this.btnCahsVDataGridViewCheckBoxColumn.DataPropertyName = "btnCahsV";
            this.btnCahsVDataGridViewCheckBoxColumn.HeaderText = "btnCahsV";
            this.btnCahsVDataGridViewCheckBoxColumn.Name = "btnCahsVDataGridViewCheckBoxColumn";
            this.btnCahsVDataGridViewCheckBoxColumn.ReadOnly = true;
            this.btnCahsVDataGridViewCheckBoxColumn.Visible = false;
            // 
            // btnLedgerDataGridViewCheckBoxColumn
            // 
            this.btnLedgerDataGridViewCheckBoxColumn.DataPropertyName = "btnLedger";
            this.btnLedgerDataGridViewCheckBoxColumn.HeaderText = "btnLedger";
            this.btnLedgerDataGridViewCheckBoxColumn.Name = "btnLedgerDataGridViewCheckBoxColumn";
            this.btnLedgerDataGridViewCheckBoxColumn.ReadOnly = true;
            this.btnLedgerDataGridViewCheckBoxColumn.Visible = false;
            // 
            // btnTBDataGridViewCheckBoxColumn
            // 
            this.btnTBDataGridViewCheckBoxColumn.DataPropertyName = "btnTB";
            this.btnTBDataGridViewCheckBoxColumn.HeaderText = "btnTB";
            this.btnTBDataGridViewCheckBoxColumn.Name = "btnTBDataGridViewCheckBoxColumn";
            this.btnTBDataGridViewCheckBoxColumn.ReadOnly = true;
            this.btnTBDataGridViewCheckBoxColumn.Visible = false;
            // 
            // btnISDataGridViewCheckBoxColumn
            // 
            this.btnISDataGridViewCheckBoxColumn.DataPropertyName = "btnIS";
            this.btnISDataGridViewCheckBoxColumn.HeaderText = "btnIS";
            this.btnISDataGridViewCheckBoxColumn.Name = "btnISDataGridViewCheckBoxColumn";
            this.btnISDataGridViewCheckBoxColumn.ReadOnly = true;
            this.btnISDataGridViewCheckBoxColumn.Visible = false;
            // 
            // btnBSDataGridViewCheckBoxColumn
            // 
            this.btnBSDataGridViewCheckBoxColumn.DataPropertyName = "btnBS";
            this.btnBSDataGridViewCheckBoxColumn.HeaderText = "btnBS";
            this.btnBSDataGridViewCheckBoxColumn.Name = "btnBSDataGridViewCheckBoxColumn";
            this.btnBSDataGridViewCheckBoxColumn.ReadOnly = true;
            this.btnBSDataGridViewCheckBoxColumn.Visible = false;
            // 
            // btnFCDataGridViewCheckBoxColumn
            // 
            this.btnFCDataGridViewCheckBoxColumn.DataPropertyName = "btnFC";
            this.btnFCDataGridViewCheckBoxColumn.HeaderText = "btnFC";
            this.btnFCDataGridViewCheckBoxColumn.Name = "btnFCDataGridViewCheckBoxColumn";
            this.btnFCDataGridViewCheckBoxColumn.ReadOnly = true;
            this.btnFCDataGridViewCheckBoxColumn.Visible = false;
            // 
            // expenseSheetDataGridViewCheckBoxColumn
            // 
            this.expenseSheetDataGridViewCheckBoxColumn.DataPropertyName = "ExpenseSheet";
            this.expenseSheetDataGridViewCheckBoxColumn.HeaderText = "ExpenseSheet";
            this.expenseSheetDataGridViewCheckBoxColumn.Name = "expenseSheetDataGridViewCheckBoxColumn";
            this.expenseSheetDataGridViewCheckBoxColumn.ReadOnly = true;
            this.expenseSheetDataGridViewCheckBoxColumn.Visible = false;
            // 
            // btnPurchaseDataGridViewCheckBoxColumn
            // 
            this.btnPurchaseDataGridViewCheckBoxColumn.DataPropertyName = "btnPurchase";
            this.btnPurchaseDataGridViewCheckBoxColumn.HeaderText = "btnPurchase";
            this.btnPurchaseDataGridViewCheckBoxColumn.Name = "btnPurchaseDataGridViewCheckBoxColumn";
            this.btnPurchaseDataGridViewCheckBoxColumn.ReadOnly = true;
            this.btnPurchaseDataGridViewCheckBoxColumn.Visible = false;
            // 
            // btnPurchaseOrderDataGridViewCheckBoxColumn
            // 
            this.btnPurchaseOrderDataGridViewCheckBoxColumn.DataPropertyName = "btnPurchaseOrder";
            this.btnPurchaseOrderDataGridViewCheckBoxColumn.HeaderText = "btnPurchaseOrder";
            this.btnPurchaseOrderDataGridViewCheckBoxColumn.Name = "btnPurchaseOrderDataGridViewCheckBoxColumn";
            this.btnPurchaseOrderDataGridViewCheckBoxColumn.ReadOnly = true;
            this.btnPurchaseOrderDataGridViewCheckBoxColumn.Visible = false;
            // 
            // btnPOEditDataGridViewCheckBoxColumn
            // 
            this.btnPOEditDataGridViewCheckBoxColumn.DataPropertyName = "btnPOEdit";
            this.btnPOEditDataGridViewCheckBoxColumn.HeaderText = "btnPOEdit";
            this.btnPOEditDataGridViewCheckBoxColumn.Name = "btnPOEditDataGridViewCheckBoxColumn";
            this.btnPOEditDataGridViewCheckBoxColumn.ReadOnly = true;
            this.btnPOEditDataGridViewCheckBoxColumn.Visible = false;
            // 
            // btnSaleDataGridViewCheckBoxColumn
            // 
            this.btnSaleDataGridViewCheckBoxColumn.DataPropertyName = "btnSale";
            this.btnSaleDataGridViewCheckBoxColumn.HeaderText = "btnSale";
            this.btnSaleDataGridViewCheckBoxColumn.Name = "btnSaleDataGridViewCheckBoxColumn";
            this.btnSaleDataGridViewCheckBoxColumn.ReadOnly = true;
            this.btnSaleDataGridViewCheckBoxColumn.Visible = false;
            // 
            // btnDeliveryChallanDataGridViewCheckBoxColumn
            // 
            this.btnDeliveryChallanDataGridViewCheckBoxColumn.DataPropertyName = "btnDeliveryChallan";
            this.btnDeliveryChallanDataGridViewCheckBoxColumn.HeaderText = "btnDeliveryChallan";
            this.btnDeliveryChallanDataGridViewCheckBoxColumn.Name = "btnDeliveryChallanDataGridViewCheckBoxColumn";
            this.btnDeliveryChallanDataGridViewCheckBoxColumn.ReadOnly = true;
            this.btnDeliveryChallanDataGridViewCheckBoxColumn.Visible = false;
            // 
            // btnEditSaleOrderDataGridViewCheckBoxColumn
            // 
            this.btnEditSaleOrderDataGridViewCheckBoxColumn.DataPropertyName = "btnEditSaleOrder";
            this.btnEditSaleOrderDataGridViewCheckBoxColumn.HeaderText = "btnEditSaleOrder";
            this.btnEditSaleOrderDataGridViewCheckBoxColumn.Name = "btnEditSaleOrderDataGridViewCheckBoxColumn";
            this.btnEditSaleOrderDataGridViewCheckBoxColumn.ReadOnly = true;
            this.btnEditSaleOrderDataGridViewCheckBoxColumn.Visible = false;
            // 
            // btnIssuanceDataGridViewCheckBoxColumn
            // 
            this.btnIssuanceDataGridViewCheckBoxColumn.DataPropertyName = "btnIssuance";
            this.btnIssuanceDataGridViewCheckBoxColumn.HeaderText = "btnIssuance";
            this.btnIssuanceDataGridViewCheckBoxColumn.Name = "btnIssuanceDataGridViewCheckBoxColumn";
            this.btnIssuanceDataGridViewCheckBoxColumn.ReadOnly = true;
            this.btnIssuanceDataGridViewCheckBoxColumn.Visible = false;
            // 
            // btnSaleRDataGridViewCheckBoxColumn
            // 
            this.btnSaleRDataGridViewCheckBoxColumn.DataPropertyName = "btnSaleR";
            this.btnSaleRDataGridViewCheckBoxColumn.HeaderText = "btnSaleR";
            this.btnSaleRDataGridViewCheckBoxColumn.Name = "btnSaleRDataGridViewCheckBoxColumn";
            this.btnSaleRDataGridViewCheckBoxColumn.ReadOnly = true;
            this.btnSaleRDataGridViewCheckBoxColumn.Visible = false;
            // 
            // btnPurchRDataGridViewCheckBoxColumn
            // 
            this.btnPurchRDataGridViewCheckBoxColumn.DataPropertyName = "btnPurchR";
            this.btnPurchRDataGridViewCheckBoxColumn.HeaderText = "btnPurchR";
            this.btnPurchRDataGridViewCheckBoxColumn.Name = "btnPurchRDataGridViewCheckBoxColumn";
            this.btnPurchRDataGridViewCheckBoxColumn.ReadOnly = true;
            this.btnPurchRDataGridViewCheckBoxColumn.Visible = false;
            // 
            // btnDisSchDataGridViewCheckBoxColumn
            // 
            this.btnDisSchDataGridViewCheckBoxColumn.DataPropertyName = "btnDisSch";
            this.btnDisSchDataGridViewCheckBoxColumn.HeaderText = "btnDisSch";
            this.btnDisSchDataGridViewCheckBoxColumn.Name = "btnDisSchDataGridViewCheckBoxColumn";
            this.btnDisSchDataGridViewCheckBoxColumn.ReadOnly = true;
            this.btnDisSchDataGridViewCheckBoxColumn.Visible = false;
            // 
            // btnPurVenDataGridViewCheckBoxColumn
            // 
            this.btnPurVenDataGridViewCheckBoxColumn.DataPropertyName = "btnPurVen";
            this.btnPurVenDataGridViewCheckBoxColumn.HeaderText = "btnPurVen";
            this.btnPurVenDataGridViewCheckBoxColumn.Name = "btnPurVenDataGridViewCheckBoxColumn";
            this.btnPurVenDataGridViewCheckBoxColumn.ReadOnly = true;
            this.btnPurVenDataGridViewCheckBoxColumn.Visible = false;
            // 
            // btnCustSDataGridViewCheckBoxColumn
            // 
            this.btnCustSDataGridViewCheckBoxColumn.DataPropertyName = "btnCustS";
            this.btnCustSDataGridViewCheckBoxColumn.HeaderText = "btnCustS";
            this.btnCustSDataGridViewCheckBoxColumn.Name = "btnCustSDataGridViewCheckBoxColumn";
            this.btnCustSDataGridViewCheckBoxColumn.ReadOnly = true;
            this.btnCustSDataGridViewCheckBoxColumn.Visible = false;
            // 
            // btnSalesmenDataGridViewCheckBoxColumn
            // 
            this.btnSalesmenDataGridViewCheckBoxColumn.DataPropertyName = "btnSalesmen";
            this.btnSalesmenDataGridViewCheckBoxColumn.HeaderText = "btnSalesmen";
            this.btnSalesmenDataGridViewCheckBoxColumn.Name = "btnSalesmenDataGridViewCheckBoxColumn";
            this.btnSalesmenDataGridViewCheckBoxColumn.ReadOnly = true;
            this.btnSalesmenDataGridViewCheckBoxColumn.Visible = false;
            // 
            // btnSalemanProductDataGridViewCheckBoxColumn
            // 
            this.btnSalemanProductDataGridViewCheckBoxColumn.DataPropertyName = "btnSalemanProduct";
            this.btnSalemanProductDataGridViewCheckBoxColumn.HeaderText = "btnSalemanProduct";
            this.btnSalemanProductDataGridViewCheckBoxColumn.Name = "btnSalemanProductDataGridViewCheckBoxColumn";
            this.btnSalemanProductDataGridViewCheckBoxColumn.ReadOnly = true;
            this.btnSalemanProductDataGridViewCheckBoxColumn.Visible = false;
            // 
            // btnProdLadgerDataGridViewCheckBoxColumn
            // 
            this.btnProdLadgerDataGridViewCheckBoxColumn.DataPropertyName = "btnProdLadger";
            this.btnProdLadgerDataGridViewCheckBoxColumn.HeaderText = "btnProdLadger";
            this.btnProdLadgerDataGridViewCheckBoxColumn.Name = "btnProdLadgerDataGridViewCheckBoxColumn";
            this.btnProdLadgerDataGridViewCheckBoxColumn.ReadOnly = true;
            this.btnProdLadgerDataGridViewCheckBoxColumn.Visible = false;
            // 
            // btnStockDataGridViewCheckBoxColumn
            // 
            this.btnStockDataGridViewCheckBoxColumn.DataPropertyName = "btnStock";
            this.btnStockDataGridViewCheckBoxColumn.HeaderText = "btnStock";
            this.btnStockDataGridViewCheckBoxColumn.Name = "btnStockDataGridViewCheckBoxColumn";
            this.btnStockDataGridViewCheckBoxColumn.ReadOnly = true;
            this.btnStockDataGridViewCheckBoxColumn.Visible = false;
            // 
            // btnBTCDataGridViewCheckBoxColumn
            // 
            this.btnBTCDataGridViewCheckBoxColumn.DataPropertyName = "btnBTC";
            this.btnBTCDataGridViewCheckBoxColumn.HeaderText = "btnBTC";
            this.btnBTCDataGridViewCheckBoxColumn.Name = "btnBTCDataGridViewCheckBoxColumn";
            this.btnBTCDataGridViewCheckBoxColumn.ReadOnly = true;
            this.btnBTCDataGridViewCheckBoxColumn.Visible = false;
            // 
            // btnUsersDataGridViewCheckBoxColumn
            // 
            this.btnUsersDataGridViewCheckBoxColumn.DataPropertyName = "btnUsers";
            this.btnUsersDataGridViewCheckBoxColumn.HeaderText = "btnUsers";
            this.btnUsersDataGridViewCheckBoxColumn.Name = "btnUsersDataGridViewCheckBoxColumn";
            this.btnUsersDataGridViewCheckBoxColumn.ReadOnly = true;
            this.btnUsersDataGridViewCheckBoxColumn.Visible = false;
            // 
            // btnCompanyDataGridViewCheckBoxColumn
            // 
            this.btnCompanyDataGridViewCheckBoxColumn.DataPropertyName = "btnCompany";
            this.btnCompanyDataGridViewCheckBoxColumn.HeaderText = "btnCompany";
            this.btnCompanyDataGridViewCheckBoxColumn.Name = "btnCompanyDataGridViewCheckBoxColumn";
            this.btnCompanyDataGridViewCheckBoxColumn.ReadOnly = true;
            this.btnCompanyDataGridViewCheckBoxColumn.Visible = false;
            // 
            // btnBackupDataGridViewCheckBoxColumn
            // 
            this.btnBackupDataGridViewCheckBoxColumn.DataPropertyName = "btnBackup";
            this.btnBackupDataGridViewCheckBoxColumn.HeaderText = "btnBackup";
            this.btnBackupDataGridViewCheckBoxColumn.Name = "btnBackupDataGridViewCheckBoxColumn";
            this.btnBackupDataGridViewCheckBoxColumn.ReadOnly = true;
            this.btnBackupDataGridViewCheckBoxColumn.Visible = false;
            // 
            // btnAppSettingDataGridViewCheckBoxColumn
            // 
            this.btnAppSettingDataGridViewCheckBoxColumn.DataPropertyName = "btnAppSetting";
            this.btnAppSettingDataGridViewCheckBoxColumn.HeaderText = "btnAppSetting";
            this.btnAppSettingDataGridViewCheckBoxColumn.Name = "btnAppSettingDataGridViewCheckBoxColumn";
            this.btnAppSettingDataGridViewCheckBoxColumn.ReadOnly = true;
            this.btnAppSettingDataGridViewCheckBoxColumn.Visible = false;
            // 
            // btnProductDataGridViewCheckBoxColumn
            // 
            this.btnProductDataGridViewCheckBoxColumn.DataPropertyName = "btnProduct";
            this.btnProductDataGridViewCheckBoxColumn.HeaderText = "btnProduct";
            this.btnProductDataGridViewCheckBoxColumn.Name = "btnProductDataGridViewCheckBoxColumn";
            this.btnProductDataGridViewCheckBoxColumn.ReadOnly = true;
            this.btnProductDataGridViewCheckBoxColumn.Visible = false;
            // 
            // btnProPrerDataGridViewCheckBoxColumn
            // 
            this.btnProPrerDataGridViewCheckBoxColumn.DataPropertyName = "btnProPrer";
            this.btnProPrerDataGridViewCheckBoxColumn.HeaderText = "btnProPrer";
            this.btnProPrerDataGridViewCheckBoxColumn.Name = "btnProPrerDataGridViewCheckBoxColumn";
            this.btnProPrerDataGridViewCheckBoxColumn.ReadOnly = true;
            this.btnProPrerDataGridViewCheckBoxColumn.Visible = false;
            // 
            // btnProdListDataGridViewCheckBoxColumn
            // 
            this.btnProdListDataGridViewCheckBoxColumn.DataPropertyName = "btnProdList";
            this.btnProdListDataGridViewCheckBoxColumn.HeaderText = "btnProdList";
            this.btnProdListDataGridViewCheckBoxColumn.Name = "btnProdListDataGridViewCheckBoxColumn";
            this.btnProdListDataGridViewCheckBoxColumn.ReadOnly = true;
            this.btnProdListDataGridViewCheckBoxColumn.Visible = false;
            // 
            // btnStoreDataGridViewCheckBoxColumn
            // 
            this.btnStoreDataGridViewCheckBoxColumn.DataPropertyName = "btnStore";
            this.btnStoreDataGridViewCheckBoxColumn.HeaderText = "btnStore";
            this.btnStoreDataGridViewCheckBoxColumn.Name = "btnStoreDataGridViewCheckBoxColumn";
            this.btnStoreDataGridViewCheckBoxColumn.ReadOnly = true;
            this.btnStoreDataGridViewCheckBoxColumn.Visible = false;
            // 
            // btnVendorsDataGridViewCheckBoxColumn
            // 
            this.btnVendorsDataGridViewCheckBoxColumn.DataPropertyName = "btnVendors";
            this.btnVendorsDataGridViewCheckBoxColumn.HeaderText = "btnVendors";
            this.btnVendorsDataGridViewCheckBoxColumn.Name = "btnVendorsDataGridViewCheckBoxColumn";
            this.btnVendorsDataGridViewCheckBoxColumn.ReadOnly = true;
            this.btnVendorsDataGridViewCheckBoxColumn.Visible = false;
            // 
            // btnEmployeesDataGridViewCheckBoxColumn
            // 
            this.btnEmployeesDataGridViewCheckBoxColumn.DataPropertyName = "btnEmployees";
            this.btnEmployeesDataGridViewCheckBoxColumn.HeaderText = "btnEmployees";
            this.btnEmployeesDataGridViewCheckBoxColumn.Name = "btnEmployeesDataGridViewCheckBoxColumn";
            this.btnEmployeesDataGridViewCheckBoxColumn.ReadOnly = true;
            this.btnEmployeesDataGridViewCheckBoxColumn.Visible = false;
            // 
            // btnCustomersDataGridViewCheckBoxColumn
            // 
            this.btnCustomersDataGridViewCheckBoxColumn.DataPropertyName = "btnCustomers";
            this.btnCustomersDataGridViewCheckBoxColumn.HeaderText = "btnCustomers";
            this.btnCustomersDataGridViewCheckBoxColumn.Name = "btnCustomersDataGridViewCheckBoxColumn";
            this.btnCustomersDataGridViewCheckBoxColumn.ReadOnly = true;
            this.btnCustomersDataGridViewCheckBoxColumn.Visible = false;
            // 
            // btnChartAccDataGridViewCheckBoxColumn
            // 
            this.btnChartAccDataGridViewCheckBoxColumn.DataPropertyName = "btnChartAcc";
            this.btnChartAccDataGridViewCheckBoxColumn.HeaderText = "btnChartAcc";
            this.btnChartAccDataGridViewCheckBoxColumn.Name = "btnChartAccDataGridViewCheckBoxColumn";
            this.btnChartAccDataGridViewCheckBoxColumn.ReadOnly = true;
            this.btnChartAccDataGridViewCheckBoxColumn.Visible = false;
            // 
            // branchIDDataGridViewTextBoxColumn
            // 
            this.branchIDDataGridViewTextBoxColumn.DataPropertyName = "BranchID";
            this.branchIDDataGridViewTextBoxColumn.HeaderText = "BranchID";
            this.branchIDDataGridViewTextBoxColumn.Name = "branchIDDataGridViewTextBoxColumn";
            this.branchIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.branchIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // TblUserBindingSource
            // 
            this.TblUserBindingSource.DataMember = "TblUser";
            this.TblUserBindingSource.DataSource = this.UsersDataSet;
            // 
            // UsersDataSet
            // 
            this.UsersDataSet.DataSetName = "UsersDataSet";
            this.UsersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 40;
            // 
            // Panel1
            // 
            this.Panel1.AutoScroll = true;
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Panel1.Controls.Add(this.showhidedashCheckBox);
            this.Panel1.Controls.Add(this.tabControl1);
            this.Panel1.Controls.Add(this.Panel2);
            this.Panel1.Controls.Add(Label3);
            this.Panel1.Controls.Add(Label1);
            this.Panel1.Controls.Add(this.PictureBox1);
            this.Panel1.Controls.Add(this.TblUserBindingNavigator);
            this.Panel1.Controls.Add(this.StatusCheckBox);
            this.Panel1.Controls.Add(StatusLabel);
            this.Panel1.Controls.Add(this.GroupType);
            this.Panel1.Location = new System.Drawing.Point(82, 43);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1009, 377);
            this.Panel1.TabIndex = 0;
            this.Panel1.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(0, 212);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(989, 117);
            this.tabControl1.TabIndex = 29;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage1.Controls.Add(this.btnBSCheckBox);
            this.tabPage1.Controls.Add(this.btnOverdueBalancesCheckBox);
            this.tabPage1.Controls.Add(this.btnISCheckBox);
            this.tabPage1.Controls.Add(this.btnLedgerinUSDCheckBox);
            this.tabPage1.Controls.Add(this.btnGeneralEntriesCheckBox);
            this.tabPage1.Controls.Add(this.btnTBCheckBox);
            this.tabPage1.Controls.Add(this.btnDisSchCheckBox);
            this.tabPage1.Controls.Add(this.btnLedgerCheckBox);
            this.tabPage1.Controls.Add(this.btnCahsVCheckBox);
            this.tabPage1.Controls.Add(this.btnBVoucherCheckBox);
            this.tabPage1.Controls.Add(this.btnVoucherCheckBox);
            this.tabPage1.Controls.Add(this.btnSearchVouchersCheckBox);
            this.tabPage1.Controls.Add(this.btnFundTransferCheckBox);
            this.tabPage1.Controls.Add(this.btnVoucherPostingCheckBox);
            this.tabPage1.Controls.Add(this.btnPaymenttoVendorCheckBox);
            this.tabPage1.Controls.Add(this.btnReceiptsReportCheckBox);
            this.tabPage1.Controls.Add(this.btnVoucherPreviewCheckBox);
            this.tabPage1.Controls.Add(this.btnEditVouchersCheckBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(981, 91);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Accounts";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnBSCheckBox
            // 
            this.btnBSCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnBS", true));
            this.btnBSCheckBox.Location = new System.Drawing.Point(685, 26);
            this.btnBSCheckBox.Name = "btnBSCheckBox";
            this.btnBSCheckBox.Size = new System.Drawing.Size(19, 24);
            this.btnBSCheckBox.TabIndex = 21;
            this.btnBSCheckBox.Text = "Balance Sheet";
            this.btnBSCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnOverdueBalancesCheckBox
            // 
            this.btnOverdueBalancesCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnOverdueBalances", true));
            this.btnOverdueBalancesCheckBox.Location = new System.Drawing.Point(63, 26);
            this.btnOverdueBalancesCheckBox.Name = "btnOverdueBalancesCheckBox";
            this.btnOverdueBalancesCheckBox.Size = new System.Drawing.Size(16, 18);
            this.btnOverdueBalancesCheckBox.TabIndex = 52;
            this.btnOverdueBalancesCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnISCheckBox
            // 
            this.btnISCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnIS", true));
            this.btnISCheckBox.Location = new System.Drawing.Point(685, 3);
            this.btnISCheckBox.Name = "btnISCheckBox";
            this.btnISCheckBox.Size = new System.Drawing.Size(19, 24);
            this.btnISCheckBox.TabIndex = 19;
            this.btnISCheckBox.Text = "Income Statement";
            this.btnISCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnLedgerinUSDCheckBox
            // 
            this.btnLedgerinUSDCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnLedgerinUSD", true));
            this.btnLedgerinUSDCheckBox.Location = new System.Drawing.Point(431, 46);
            this.btnLedgerinUSDCheckBox.Name = "btnLedgerinUSDCheckBox";
            this.btnLedgerinUSDCheckBox.Size = new System.Drawing.Size(18, 24);
            this.btnLedgerinUSDCheckBox.TabIndex = 50;
            this.btnLedgerinUSDCheckBox.Text = "btn Ledgerin USD:";
            this.btnLedgerinUSDCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnGeneralEntriesCheckBox
            // 
            this.btnGeneralEntriesCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnGeneralEntries", true));
            this.btnGeneralEntriesCheckBox.Location = new System.Drawing.Point(431, 5);
            this.btnGeneralEntriesCheckBox.Name = "btnGeneralEntriesCheckBox";
            this.btnGeneralEntriesCheckBox.Size = new System.Drawing.Size(17, 24);
            this.btnGeneralEntriesCheckBox.TabIndex = 51;
            this.btnGeneralEntriesCheckBox.Text = "btn General Entries:";
            this.btnGeneralEntriesCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnTBCheckBox
            // 
            this.btnTBCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnTB", true));
            this.btnTBCheckBox.Location = new System.Drawing.Point(640, 17);
            this.btnTBCheckBox.Name = "btnTBCheckBox";
            this.btnTBCheckBox.Size = new System.Drawing.Size(17, 24);
            this.btnTBCheckBox.TabIndex = 17;
            this.btnTBCheckBox.Text = "Trial Balance";
            this.btnTBCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnDisSchCheckBox
            // 
            this.btnDisSchCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnDisSch", true));
            this.btnDisSchCheckBox.Location = new System.Drawing.Point(63, 45);
            this.btnDisSchCheckBox.Name = "btnDisSchCheckBox";
            this.btnDisSchCheckBox.Size = new System.Drawing.Size(16, 21);
            this.btnDisSchCheckBox.TabIndex = 45;
            this.btnDisSchCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnLedgerCheckBox
            // 
            this.btnLedgerCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnLedger", true));
            this.btnLedgerCheckBox.Location = new System.Drawing.Point(583, 17);
            this.btnLedgerCheckBox.Name = "btnLedgerCheckBox";
            this.btnLedgerCheckBox.Size = new System.Drawing.Size(17, 24);
            this.btnLedgerCheckBox.TabIndex = 15;
            this.btnLedgerCheckBox.Text = "General Ledger";
            this.btnLedgerCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnCahsVCheckBox
            // 
            this.btnCahsVCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnCahsV", true));
            this.btnCahsVCheckBox.Location = new System.Drawing.Point(63, 3);
            this.btnCahsVCheckBox.Name = "btnCahsVCheckBox";
            this.btnCahsVCheckBox.Size = new System.Drawing.Size(17, 24);
            this.btnCahsVCheckBox.TabIndex = 13;
            this.btnCahsVCheckBox.Text = "Cash Voucher";
            this.btnCahsVCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnBVoucherCheckBox
            // 
            this.btnBVoucherCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnBVoucher", true));
            this.btnBVoucherCheckBox.Location = new System.Drawing.Point(226, 17);
            this.btnBVoucherCheckBox.Name = "btnBVoucherCheckBox";
            this.btnBVoucherCheckBox.Size = new System.Drawing.Size(20, 24);
            this.btnBVoucherCheckBox.TabIndex = 11;
            this.btnBVoucherCheckBox.Text = "Bank Voucher";
            this.btnBVoucherCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnVoucherCheckBox
            // 
            this.btnVoucherCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnVoucher", true));
            this.btnVoucherCheckBox.Location = new System.Drawing.Point(15, 17);
            this.btnVoucherCheckBox.Name = "btnVoucherCheckBox";
            this.btnVoucherCheckBox.Size = new System.Drawing.Size(15, 24);
            this.btnVoucherCheckBox.TabIndex = 9;
            this.btnVoucherCheckBox.Text = "Journal Voucher";
            this.btnVoucherCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnSearchVouchersCheckBox
            // 
            this.btnSearchVouchersCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnSearchVouchers", true));
            this.btnSearchVouchersCheckBox.Location = new System.Drawing.Point(685, 45);
            this.btnSearchVouchersCheckBox.Name = "btnSearchVouchersCheckBox";
            this.btnSearchVouchersCheckBox.Size = new System.Drawing.Size(19, 24);
            this.btnSearchVouchersCheckBox.TabIndex = 32;
            this.btnSearchVouchersCheckBox.Text = "btn Search Vouchers:";
            this.btnSearchVouchersCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnFundTransferCheckBox
            // 
            this.btnFundTransferCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnFundTransfer", true));
            this.btnFundTransferCheckBox.Location = new System.Drawing.Point(822, 6);
            this.btnFundTransferCheckBox.Name = "btnFundTransferCheckBox";
            this.btnFundTransferCheckBox.Size = new System.Drawing.Size(21, 24);
            this.btnFundTransferCheckBox.TabIndex = 31;
            this.btnFundTransferCheckBox.Text = "btn Fund Transfer:";
            this.btnFundTransferCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnVoucherPostingCheckBox
            // 
            this.btnVoucherPostingCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnVoucherPosting", true));
            this.btnVoucherPostingCheckBox.Location = new System.Drawing.Point(299, 47);
            this.btnVoucherPostingCheckBox.Name = "btnVoucherPostingCheckBox";
            this.btnVoucherPostingCheckBox.Size = new System.Drawing.Size(17, 24);
            this.btnVoucherPostingCheckBox.TabIndex = 29;
            this.btnVoucherPostingCheckBox.Text = "btn Voucher Posting:";
            this.btnVoucherPostingCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnPaymenttoVendorCheckBox
            // 
            this.btnPaymenttoVendorCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnPaymenttoVendor", true));
            this.btnPaymenttoVendorCheckBox.Location = new System.Drawing.Point(299, 26);
            this.btnPaymenttoVendorCheckBox.Name = "btnPaymenttoVendorCheckBox";
            this.btnPaymenttoVendorCheckBox.Size = new System.Drawing.Size(17, 24);
            this.btnPaymenttoVendorCheckBox.TabIndex = 54;
            this.btnPaymenttoVendorCheckBox.Text = "btn Paymentto Vendor:";
            this.btnPaymenttoVendorCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnReceiptsReportCheckBox
            // 
            this.btnReceiptsReportCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnReceiptsReport", true));
            this.btnReceiptsReportCheckBox.Location = new System.Drawing.Point(299, 5);
            this.btnReceiptsReportCheckBox.Name = "btnReceiptsReportCheckBox";
            this.btnReceiptsReportCheckBox.Size = new System.Drawing.Size(17, 24);
            this.btnReceiptsReportCheckBox.TabIndex = 30;
            this.btnReceiptsReportCheckBox.Text = "btn Receipts Report:";
            this.btnReceiptsReportCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnVoucherPreviewCheckBox
            // 
            this.btnVoucherPreviewCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnVoucherPreview", true));
            this.btnVoucherPreviewCheckBox.Location = new System.Drawing.Point(431, 26);
            this.btnVoucherPreviewCheckBox.Name = "btnVoucherPreviewCheckBox";
            this.btnVoucherPreviewCheckBox.Size = new System.Drawing.Size(17, 24);
            this.btnVoucherPreviewCheckBox.TabIndex = 33;
            this.btnVoucherPreviewCheckBox.Text = "btn Voucher Preview:";
            this.btnVoucherPreviewCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnEditVouchersCheckBox
            // 
            this.btnEditVouchersCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnEditVouchers", true));
            this.btnEditVouchersCheckBox.Location = new System.Drawing.Point(822, 26);
            this.btnEditVouchersCheckBox.Name = "btnEditVouchersCheckBox";
            this.btnEditVouchersCheckBox.Size = new System.Drawing.Size(21, 24);
            this.btnEditVouchersCheckBox.TabIndex = 34;
            this.btnEditVouchersCheckBox.Text = "btn Edit Vouchers:";
            this.btnEditVouchersCheckBox.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage2.Controls.Add(this.btnWalkinCustCheckBox);
            this.tabPage2.Controls.Add(this.btnPurchaseOrderCheckBox);
            this.tabPage2.Controls.Add(this.btnPOEditCheckBox);
            this.tabPage2.Controls.Add(this.btnOrderStatusCheckBox);
            this.tabPage2.Controls.Add(this.btnPurchRCheckBox);
            this.tabPage2.Controls.Add(this.btnPurVenCheckBox);
            this.tabPage2.Controls.Add(this.btnSaleRCheckBox);
            this.tabPage2.Controls.Add(this.btnIssuanceCheckBox);
            this.tabPage2.Controls.Add(this.btnEditSaleOrderCheckBox);
            this.tabPage2.Controls.Add(this.btnDeliveryChallanCheckBox);
            this.tabPage2.Controls.Add(this.btnStockCheckBox);
            this.tabPage2.Controls.Add(this.btnProdLadgerCheckBox);
            this.tabPage2.Controls.Add(this.btnSaleCheckBox);
            this.tabPage2.Controls.Add(this.btnPurchaseCheckBox);
            this.tabPage2.Controls.Add(this.btnOverdueInvoicesCheckBox);
            this.tabPage2.Controls.Add(this.btnSaleRegCheckBox);
            this.tabPage2.Controls.Add(this.btnPurchaseRegCheckBox);
            this.tabPage2.Controls.Add(this.btnChangeOrderStatusCheckBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(981, 91);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Inventory";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnWalkinCustCheckBox
            // 
            this.btnWalkinCustCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnWalkinCust", true));
            this.btnWalkinCustCheckBox.Location = new System.Drawing.Point(372, 45);
            this.btnWalkinCustCheckBox.Name = "btnWalkinCustCheckBox";
            this.btnWalkinCustCheckBox.Size = new System.Drawing.Size(21, 24);
            this.btnWalkinCustCheckBox.TabIndex = 55;
            this.btnWalkinCustCheckBox.Text = "btn Walkin Cust:";
            this.btnWalkinCustCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnPurchaseOrderCheckBox
            // 
            this.btnPurchaseOrderCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnPurchaseOrder", true));
            this.btnPurchaseOrderCheckBox.Location = new System.Drawing.Point(3, 3);
            this.btnPurchaseOrderCheckBox.Name = "btnPurchaseOrderCheckBox";
            this.btnPurchaseOrderCheckBox.Size = new System.Drawing.Size(18, 24);
            this.btnPurchaseOrderCheckBox.TabIndex = 29;
            this.btnPurchaseOrderCheckBox.Text = "Purchase Order";
            this.btnPurchaseOrderCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnPOEditCheckBox
            // 
            this.btnPOEditCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnPOEdit", true));
            this.btnPOEditCheckBox.Location = new System.Drawing.Point(3, 26);
            this.btnPOEditCheckBox.Name = "btnPOEditCheckBox";
            this.btnPOEditCheckBox.Size = new System.Drawing.Size(18, 24);
            this.btnPOEditCheckBox.TabIndex = 31;
            this.btnPOEditCheckBox.Text = "Edit Purchase Order";
            this.btnPOEditCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnOrderStatusCheckBox
            // 
            this.btnOrderStatusCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnOrderStatus", true));
            this.btnOrderStatusCheckBox.Location = new System.Drawing.Point(133, 45);
            this.btnOrderStatusCheckBox.Name = "btnOrderStatusCheckBox";
            this.btnOrderStatusCheckBox.Size = new System.Drawing.Size(23, 24);
            this.btnOrderStatusCheckBox.TabIndex = 44;
            this.btnOrderStatusCheckBox.Text = "btn Order Status:";
            this.btnOrderStatusCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnPurchRCheckBox
            // 
            this.btnPurchRCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnPurchR", true));
            this.btnPurchRCheckBox.Location = new System.Drawing.Point(597, 9);
            this.btnPurchRCheckBox.Name = "btnPurchRCheckBox";
            this.btnPurchRCheckBox.Size = new System.Drawing.Size(17, 24);
            this.btnPurchRCheckBox.TabIndex = 43;
            this.btnPurchRCheckBox.Text = "Purchase Retrun";
            this.btnPurchRCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnPurVenCheckBox
            // 
            this.btnPurVenCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnPurVen", true));
            this.btnPurVenCheckBox.Location = new System.Drawing.Point(3, 45);
            this.btnPurVenCheckBox.Name = "btnPurVenCheckBox";
            this.btnPurVenCheckBox.Size = new System.Drawing.Size(18, 24);
            this.btnPurVenCheckBox.TabIndex = 47;
            this.btnPurVenCheckBox.Text = "Purchase Vedors Wise";
            this.btnPurVenCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnSaleRCheckBox
            // 
            this.btnSaleRCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnSaleR", true));
            this.btnSaleRCheckBox.Location = new System.Drawing.Point(597, 39);
            this.btnSaleRCheckBox.Name = "btnSaleRCheckBox";
            this.btnSaleRCheckBox.Size = new System.Drawing.Size(18, 24);
            this.btnSaleRCheckBox.TabIndex = 41;
            this.btnSaleRCheckBox.Text = "Sale Retrun";
            this.btnSaleRCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnIssuanceCheckBox
            // 
            this.btnIssuanceCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnIssuance", true));
            this.btnIssuanceCheckBox.Location = new System.Drawing.Point(540, 15);
            this.btnIssuanceCheckBox.Name = "btnIssuanceCheckBox";
            this.btnIssuanceCheckBox.Size = new System.Drawing.Size(18, 24);
            this.btnIssuanceCheckBox.TabIndex = 39;
            this.btnIssuanceCheckBox.Text = "Inventory Transfer";
            this.btnIssuanceCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnEditSaleOrderCheckBox
            // 
            this.btnEditSaleOrderCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnEditSaleOrder", true));
            this.btnEditSaleOrderCheckBox.Location = new System.Drawing.Point(372, 26);
            this.btnEditSaleOrderCheckBox.Name = "btnEditSaleOrderCheckBox";
            this.btnEditSaleOrderCheckBox.Size = new System.Drawing.Size(21, 24);
            this.btnEditSaleOrderCheckBox.TabIndex = 37;
            this.btnEditSaleOrderCheckBox.Text = "Delivery Challan Edit";
            this.btnEditSaleOrderCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnDeliveryChallanCheckBox
            // 
            this.btnDeliveryChallanCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnDeliveryChallan", true));
            this.btnDeliveryChallanCheckBox.Location = new System.Drawing.Point(372, 3);
            this.btnDeliveryChallanCheckBox.Name = "btnDeliveryChallanCheckBox";
            this.btnDeliveryChallanCheckBox.Size = new System.Drawing.Size(21, 24);
            this.btnDeliveryChallanCheckBox.TabIndex = 35;
            this.btnDeliveryChallanCheckBox.Text = "Delivery Challan";
            this.btnDeliveryChallanCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnStockCheckBox
            // 
            this.btnStockCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnStock", true));
            this.btnStockCheckBox.Location = new System.Drawing.Point(903, 15);
            this.btnStockCheckBox.Name = "btnStockCheckBox";
            this.btnStockCheckBox.Size = new System.Drawing.Size(19, 24);
            this.btnStockCheckBox.TabIndex = 57;
            this.btnStockCheckBox.Text = "Stock Report";
            this.btnStockCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnProdLadgerCheckBox
            // 
            this.btnProdLadgerCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnProdLadger", true));
            this.btnProdLadgerCheckBox.Location = new System.Drawing.Point(722, 15);
            this.btnProdLadgerCheckBox.Name = "btnProdLadgerCheckBox";
            this.btnProdLadgerCheckBox.Size = new System.Drawing.Size(18, 24);
            this.btnProdLadgerCheckBox.TabIndex = 55;
            this.btnProdLadgerCheckBox.Text = "Product Ladgar";
            this.btnProdLadgerCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnSaleCheckBox
            // 
            this.btnSaleCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnSale", true));
            this.btnSaleCheckBox.Location = new System.Drawing.Point(314, 15);
            this.btnSaleCheckBox.Name = "btnSaleCheckBox";
            this.btnSaleCheckBox.Size = new System.Drawing.Size(18, 24);
            this.btnSaleCheckBox.TabIndex = 33;
            this.btnSaleCheckBox.Text = "Sale Invoice";
            this.btnSaleCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnPurchaseCheckBox
            // 
            this.btnPurchaseCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnPurchase", true));
            this.btnPurchaseCheckBox.Location = new System.Drawing.Point(133, 26);
            this.btnPurchaseCheckBox.Name = "btnPurchaseCheckBox";
            this.btnPurchaseCheckBox.Size = new System.Drawing.Size(23, 24);
            this.btnPurchaseCheckBox.TabIndex = 27;
            this.btnPurchaseCheckBox.Text = "Goods Receipt Note (GRN)";
            this.btnPurchaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnOverdueInvoicesCheckBox
            // 
            this.btnOverdueInvoicesCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnOverdueInvoices", true));
            this.btnOverdueInvoicesCheckBox.Location = new System.Drawing.Point(772, 45);
            this.btnOverdueInvoicesCheckBox.Name = "btnOverdueInvoicesCheckBox";
            this.btnOverdueInvoicesCheckBox.Size = new System.Drawing.Size(14, 24);
            this.btnOverdueInvoicesCheckBox.TabIndex = 37;
            this.btnOverdueInvoicesCheckBox.Text = "btn Overdue Invoices:";
            this.btnOverdueInvoicesCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnSaleRegCheckBox
            // 
            this.btnSaleRegCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnSaleReg", true));
            this.btnSaleRegCheckBox.Location = new System.Drawing.Point(772, 3);
            this.btnSaleRegCheckBox.Name = "btnSaleRegCheckBox";
            this.btnSaleRegCheckBox.Size = new System.Drawing.Size(14, 24);
            this.btnSaleRegCheckBox.TabIndex = 35;
            this.btnSaleRegCheckBox.Text = "btn Sale Reg:";
            this.btnSaleRegCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnPurchaseRegCheckBox
            // 
            this.btnPurchaseRegCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnPurchaseReg", true));
            this.btnPurchaseRegCheckBox.Location = new System.Drawing.Point(772, 26);
            this.btnPurchaseRegCheckBox.Name = "btnPurchaseRegCheckBox";
            this.btnPurchaseRegCheckBox.Size = new System.Drawing.Size(14, 24);
            this.btnPurchaseRegCheckBox.TabIndex = 36;
            this.btnPurchaseRegCheckBox.Text = "btn Purchase Reg:";
            this.btnPurchaseRegCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnChangeOrderStatusCheckBox
            // 
            this.btnChangeOrderStatusCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnChangeOrderStatus", true));
            this.btnChangeOrderStatusCheckBox.Location = new System.Drawing.Point(133, 0);
            this.btnChangeOrderStatusCheckBox.Name = "btnChangeOrderStatusCheckBox";
            this.btnChangeOrderStatusCheckBox.Size = new System.Drawing.Size(23, 24);
            this.btnChangeOrderStatusCheckBox.TabIndex = 53;
            this.btnChangeOrderStatusCheckBox.Text = "btn Change Order Status:";
            this.btnChangeOrderStatusCheckBox.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage3.BackgroundImage")));
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage3.Controls.Add(this.btnSalesmenCheckBox);
            this.tabPage3.Controls.Add(this.btnSalemanProductCheckBox);
            this.tabPage3.Controls.Add(this.vendorBalancesCheckBox);
            this.tabPage3.Controls.Add(this.btnCustBalanceCheckBox);
            this.tabPage3.Controls.Add(this.btnCashBankBalancesCheckBox);
            this.tabPage3.Controls.Add(this.btnProfitabilityCheckBox);
            this.tabPage3.Controls.Add(this.btnEmpProCheckBox);
            this.tabPage3.Controls.Add(this.btnCustSCheckBox);
            this.tabPage3.Controls.Add(this.btnMonthWiseSaleCheckBox);
            this.tabPage3.Controls.Add(this.expenseSheetCheckBox);
            this.tabPage3.Controls.Add(this.btnFCCheckBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(981, 91);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Executive Reports";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnSalesmenCheckBox
            // 
            this.btnSalesmenCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnSalesmen", true));
            this.btnSalesmenCheckBox.Location = new System.Drawing.Point(141, 30);
            this.btnSalesmenCheckBox.Name = "btnSalesmenCheckBox";
            this.btnSalesmenCheckBox.Size = new System.Drawing.Size(17, 24);
            this.btnSalesmenCheckBox.TabIndex = 51;
            this.btnSalesmenCheckBox.Text = "Customer Wise Profitability";
            this.btnSalesmenCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnSalemanProductCheckBox
            // 
            this.btnSalemanProductCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnSalemanProduct", true));
            this.btnSalemanProductCheckBox.Location = new System.Drawing.Point(141, 50);
            this.btnSalemanProductCheckBox.Name = "btnSalemanProductCheckBox";
            this.btnSalemanProductCheckBox.Size = new System.Drawing.Size(17, 24);
            this.btnSalemanProductCheckBox.TabIndex = 53;
            this.btnSalemanProductCheckBox.Text = "City Wise Profitability";
            this.btnSalemanProductCheckBox.UseVisualStyleBackColor = true;
            // 
            // vendorBalancesCheckBox
            // 
            this.vendorBalancesCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "VendorBalances", true));
            this.vendorBalancesCheckBox.Location = new System.Drawing.Point(343, 9);
            this.vendorBalancesCheckBox.Name = "vendorBalancesCheckBox";
            this.vendorBalancesCheckBox.Size = new System.Drawing.Size(17, 24);
            this.vendorBalancesCheckBox.TabIndex = 38;
            this.vendorBalancesCheckBox.Text = "Vendor Balances:";
            this.vendorBalancesCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnCustBalanceCheckBox
            // 
            this.btnCustBalanceCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnCustBalance", true));
            this.btnCustBalanceCheckBox.Location = new System.Drawing.Point(343, 28);
            this.btnCustBalanceCheckBox.Name = "btnCustBalanceCheckBox";
            this.btnCustBalanceCheckBox.Size = new System.Drawing.Size(17, 24);
            this.btnCustBalanceCheckBox.TabIndex = 39;
            this.btnCustBalanceCheckBox.Text = "btn Cust Balance:";
            this.btnCustBalanceCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnCashBankBalancesCheckBox
            // 
            this.btnCashBankBalancesCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnCashBankBalances", true));
            this.btnCashBankBalancesCheckBox.Location = new System.Drawing.Point(343, 50);
            this.btnCashBankBalancesCheckBox.Name = "btnCashBankBalancesCheckBox";
            this.btnCashBankBalancesCheckBox.Size = new System.Drawing.Size(17, 24);
            this.btnCashBankBalancesCheckBox.TabIndex = 40;
            this.btnCashBankBalancesCheckBox.Text = "btn Cash Bank Balances:";
            this.btnCashBankBalancesCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnProfitabilityCheckBox
            // 
            this.btnProfitabilityCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnProfitability", true));
            this.btnProfitabilityCheckBox.Location = new System.Drawing.Point(502, 20);
            this.btnProfitabilityCheckBox.Name = "btnProfitabilityCheckBox";
            this.btnProfitabilityCheckBox.Size = new System.Drawing.Size(17, 24);
            this.btnProfitabilityCheckBox.TabIndex = 41;
            this.btnProfitabilityCheckBox.Text = "btn Profitability:";
            this.btnProfitabilityCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnEmpProCheckBox
            // 
            this.btnEmpProCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnEmpPro", true));
            this.btnEmpProCheckBox.Location = new System.Drawing.Point(558, 48);
            this.btnEmpProCheckBox.Name = "btnEmpProCheckBox";
            this.btnEmpProCheckBox.Size = new System.Drawing.Size(15, 24);
            this.btnEmpProCheckBox.TabIndex = 43;
            this.btnEmpProCheckBox.Text = "btn Emp Pro:";
            this.btnEmpProCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnCustSCheckBox
            // 
            this.btnCustSCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnCustS", true));
            this.btnCustSCheckBox.Location = new System.Drawing.Point(141, 9);
            this.btnCustSCheckBox.Name = "btnCustSCheckBox";
            this.btnCustSCheckBox.Size = new System.Drawing.Size(17, 24);
            this.btnCustSCheckBox.TabIndex = 49;
            this.btnCustSCheckBox.Text = "Product wise Profitability Report";
            this.btnCustSCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnMonthWiseSaleCheckBox
            // 
            this.btnMonthWiseSaleCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnMonthWiseSale", true));
            this.btnMonthWiseSaleCheckBox.Location = new System.Drawing.Point(558, 14);
            this.btnMonthWiseSaleCheckBox.Name = "btnMonthWiseSaleCheckBox";
            this.btnMonthWiseSaleCheckBox.Size = new System.Drawing.Size(15, 24);
            this.btnMonthWiseSaleCheckBox.TabIndex = 42;
            this.btnMonthWiseSaleCheckBox.Text = "btn Month Wise Sale:";
            this.btnMonthWiseSaleCheckBox.UseVisualStyleBackColor = true;
            // 
            // expenseSheetCheckBox
            // 
            this.expenseSheetCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "ExpenseSheet", true));
            this.expenseSheetCheckBox.Location = new System.Drawing.Point(81, 20);
            this.expenseSheetCheckBox.Name = "expenseSheetCheckBox";
            this.expenseSheetCheckBox.Size = new System.Drawing.Size(18, 24);
            this.expenseSheetCheckBox.TabIndex = 25;
            this.expenseSheetCheckBox.Text = "Expense Sheet";
            this.expenseSheetCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnFCCheckBox
            // 
            this.btnFCCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnFC", true));
            this.btnFCCheckBox.Location = new System.Drawing.Point(14, 20);
            this.btnFCCheckBox.Name = "btnFCCheckBox";
            this.btnFCCheckBox.Size = new System.Drawing.Size(16, 24);
            this.btnFCCheckBox.TabIndex = 23;
            this.btnFCCheckBox.Text = "Financial Comparisons";
            this.btnFCCheckBox.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage4.BackgroundImage")));
            this.tabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage4.Controls.Add(this.btnBTCCheckBox);
            this.tabPage4.Controls.Add(this.btnClaimFormEditCheckBox);
            this.tabPage4.Controls.Add(this.btnRPTTIRECLAIMSCheckBox);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(981, 91);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "BTC Tire Claim";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnBTCCheckBox
            // 
            this.btnBTCCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnBTC", true));
            this.btnBTCCheckBox.Location = new System.Drawing.Point(9, 21);
            this.btnBTCCheckBox.Name = "btnBTCCheckBox";
            this.btnBTCCheckBox.Size = new System.Drawing.Size(16, 24);
            this.btnBTCCheckBox.TabIndex = 59;
            this.btnBTCCheckBox.Text = "BTC Tire Claim";
            this.btnBTCCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnClaimFormEditCheckBox
            // 
            this.btnClaimFormEditCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnClaimFormEdit", true));
            this.btnClaimFormEditCheckBox.Location = new System.Drawing.Point(61, 47);
            this.btnClaimFormEditCheckBox.Name = "btnClaimFormEditCheckBox";
            this.btnClaimFormEditCheckBox.Size = new System.Drawing.Size(16, 24);
            this.btnClaimFormEditCheckBox.TabIndex = 46;
            this.btnClaimFormEditCheckBox.Text = "btn Claim Form Edit:";
            this.btnClaimFormEditCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnRPTTIRECLAIMSCheckBox
            // 
            this.btnRPTTIRECLAIMSCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnRPTTIRECLAIMS", true));
            this.btnRPTTIRECLAIMSCheckBox.Location = new System.Drawing.Point(61, 17);
            this.btnRPTTIRECLAIMSCheckBox.Name = "btnRPTTIRECLAIMSCheckBox";
            this.btnRPTTIRECLAIMSCheckBox.Size = new System.Drawing.Size(16, 24);
            this.btnRPTTIRECLAIMSCheckBox.TabIndex = 45;
            this.btnRPTTIRECLAIMSCheckBox.Text = "btn RPTTIRECLAIMS:";
            this.btnRPTTIRECLAIMSCheckBox.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage5.BackgroundImage")));
            this.tabPage5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage5.Controls.Add(this.btnDayClosingCheckBox);
            this.tabPage5.Controls.Add(this.btnCityRegCheckBox);
            this.tabPage5.Controls.Add(this.btnPaymenttermsCheckBox);
            this.tabPage5.Controls.Add(this.btnUsersCheckBox);
            this.tabPage5.Controls.Add(this.btnCompanyCheckBox);
            this.tabPage5.Controls.Add(this.btnChartAccCheckBox);
            this.tabPage5.Controls.Add(this.btnCustomersCheckBox);
            this.tabPage5.Controls.Add(this.btnEmployeesCheckBox);
            this.tabPage5.Controls.Add(this.btnVendorsCheckBox);
            this.tabPage5.Controls.Add(this.btnStoreCheckBox);
            this.tabPage5.Controls.Add(this.btnProdListCheckBox);
            this.tabPage5.Controls.Add(this.btnProPrerCheckBox);
            this.tabPage5.Controls.Add(this.btnProductCheckBox);
            this.tabPage5.Controls.Add(this.btnAppSettingCheckBox);
            this.tabPage5.Controls.Add(this.btnBackupCheckBox);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(981, 91);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Advance Settings";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnDayClosingCheckBox
            // 
            this.btnDayClosingCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnDayClosing", true));
            this.btnDayClosingCheckBox.Location = new System.Drawing.Point(215, 45);
            this.btnDayClosingCheckBox.Name = "btnDayClosingCheckBox";
            this.btnDayClosingCheckBox.Size = new System.Drawing.Size(18, 24);
            this.btnDayClosingCheckBox.TabIndex = 47;
            this.btnDayClosingCheckBox.Text = "btn Day Closing:";
            this.btnDayClosingCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnCityRegCheckBox
            // 
            this.btnCityRegCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnCityReg", true));
            this.btnCityRegCheckBox.Location = new System.Drawing.Point(864, 21);
            this.btnCityRegCheckBox.Name = "btnCityRegCheckBox";
            this.btnCityRegCheckBox.Size = new System.Drawing.Size(17, 24);
            this.btnCityRegCheckBox.TabIndex = 48;
            this.btnCityRegCheckBox.Text = "btn City Reg:";
            this.btnCityRegCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnPaymenttermsCheckBox
            // 
            this.btnPaymenttermsCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnPaymentterms", true));
            this.btnPaymenttermsCheckBox.Location = new System.Drawing.Point(864, 46);
            this.btnPaymenttermsCheckBox.Name = "btnPaymenttermsCheckBox";
            this.btnPaymenttermsCheckBox.Size = new System.Drawing.Size(17, 24);
            this.btnPaymenttermsCheckBox.TabIndex = 49;
            this.btnPaymenttermsCheckBox.Text = "btn Paymentterms:";
            this.btnPaymenttermsCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnUsersCheckBox
            // 
            this.btnUsersCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnUsers", true));
            this.btnUsersCheckBox.Location = new System.Drawing.Point(20, 23);
            this.btnUsersCheckBox.Name = "btnUsersCheckBox";
            this.btnUsersCheckBox.Size = new System.Drawing.Size(17, 24);
            this.btnUsersCheckBox.TabIndex = 61;
            this.btnUsersCheckBox.Text = "Add / Change User";
            this.btnUsersCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnCompanyCheckBox
            // 
            this.btnCompanyCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnCompany", true));
            this.btnCompanyCheckBox.Location = new System.Drawing.Point(84, 7);
            this.btnCompanyCheckBox.Name = "btnCompanyCheckBox";
            this.btnCompanyCheckBox.Size = new System.Drawing.Size(19, 24);
            this.btnCompanyCheckBox.TabIndex = 63;
            this.btnCompanyCheckBox.Text = "Business Profile";
            this.btnCompanyCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnChartAccCheckBox
            // 
            this.btnChartAccCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnChartAcc", true));
            this.btnChartAccCheckBox.Location = new System.Drawing.Point(810, 23);
            this.btnChartAccCheckBox.Name = "btnChartAccCheckBox";
            this.btnChartAccCheckBox.Size = new System.Drawing.Size(15, 24);
            this.btnChartAccCheckBox.TabIndex = 83;
            this.btnChartAccCheckBox.Text = "Chart Of Account";
            this.btnChartAccCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnCustomersCheckBox
            // 
            this.btnCustomersCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnCustomers", true));
            this.btnCustomersCheckBox.Location = new System.Drawing.Point(630, 49);
            this.btnCustomersCheckBox.Name = "btnCustomersCheckBox";
            this.btnCustomersCheckBox.Size = new System.Drawing.Size(20, 24);
            this.btnCustomersCheckBox.TabIndex = 81;
            this.btnCustomersCheckBox.Text = "Customers (Clients etc.)";
            this.btnCustomersCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnEmployeesCheckBox
            // 
            this.btnEmployeesCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnEmployees", true));
            this.btnEmployeesCheckBox.Location = new System.Drawing.Point(630, 27);
            this.btnEmployeesCheckBox.Name = "btnEmployeesCheckBox";
            this.btnEmployeesCheckBox.Size = new System.Drawing.Size(20, 24);
            this.btnEmployeesCheckBox.TabIndex = 79;
            this.btnEmployeesCheckBox.Text = "Employees (Salesmen etc.)";
            this.btnEmployeesCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnVendorsCheckBox
            // 
            this.btnVendorsCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnVendors", true));
            this.btnVendorsCheckBox.Location = new System.Drawing.Point(630, 7);
            this.btnVendorsCheckBox.Name = "btnVendorsCheckBox";
            this.btnVendorsCheckBox.Size = new System.Drawing.Size(20, 24);
            this.btnVendorsCheckBox.TabIndex = 77;
            this.btnVendorsCheckBox.Text = "Vendors (Dealers etc.)";
            this.btnVendorsCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnStoreCheckBox
            // 
            this.btnStoreCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnStore", true));
            this.btnStoreCheckBox.Location = new System.Drawing.Point(572, 23);
            this.btnStoreCheckBox.Name = "btnStoreCheckBox";
            this.btnStoreCheckBox.Size = new System.Drawing.Size(18, 24);
            this.btnStoreCheckBox.TabIndex = 75;
            this.btnStoreCheckBox.Text = "Store/Display Center";
            this.btnStoreCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnProdListCheckBox
            // 
            this.btnProdListCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnProdList", true));
            this.btnProdListCheckBox.Location = new System.Drawing.Point(417, 46);
            this.btnProdListCheckBox.Name = "btnProdListCheckBox";
            this.btnProdListCheckBox.Size = new System.Drawing.Size(17, 24);
            this.btnProdListCheckBox.TabIndex = 73;
            this.btnProdListCheckBox.Text = "Product List";
            this.btnProdListCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnProPrerCheckBox
            // 
            this.btnProPrerCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnProPrer", true));
            this.btnProPrerCheckBox.Location = new System.Drawing.Point(417, 14);
            this.btnProPrerCheckBox.Name = "btnProPrerCheckBox";
            this.btnProPrerCheckBox.Size = new System.Drawing.Size(17, 24);
            this.btnProPrerCheckBox.TabIndex = 71;
            this.btnProPrerCheckBox.Text = "Product Prerequisite";
            this.btnProPrerCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnProductCheckBox
            // 
            this.btnProductCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnProduct", true));
            this.btnProductCheckBox.Location = new System.Drawing.Point(361, 23);
            this.btnProductCheckBox.Name = "btnProductCheckBox";
            this.btnProductCheckBox.Size = new System.Drawing.Size(15, 24);
            this.btnProductCheckBox.TabIndex = 69;
            this.btnProductCheckBox.Text = "Product Registration";
            this.btnProductCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnAppSettingCheckBox
            // 
            this.btnAppSettingCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnAppSetting", true));
            this.btnAppSettingCheckBox.Location = new System.Drawing.Point(84, 49);
            this.btnAppSettingCheckBox.Name = "btnAppSettingCheckBox";
            this.btnAppSettingCheckBox.Size = new System.Drawing.Size(19, 24);
            this.btnAppSettingCheckBox.TabIndex = 67;
            this.btnAppSettingCheckBox.Text = "Application Settings";
            this.btnAppSettingCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnBackupCheckBox
            // 
            this.btnBackupCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "btnBackup", true));
            this.btnBackupCheckBox.Location = new System.Drawing.Point(84, 27);
            this.btnBackupCheckBox.Name = "btnBackupCheckBox";
            this.btnBackupCheckBox.Size = new System.Drawing.Size(19, 24);
            this.btnBackupCheckBox.TabIndex = 65;
            this.btnBackupCheckBox.Text = "Database Backup";
            this.btnBackupCheckBox.UseVisualStyleBackColor = true;
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.pictureBox6);
            this.Panel2.Controls.Add(this.comboBox1);
            this.Panel2.Controls.Add(label6);
            this.Panel2.Controls.Add(PasswordLabel);
            this.Panel2.Controls.Add(this.PictureBox4);
            this.Panel2.Controls.Add(this.PasswordTextBox);
            this.Panel2.Controls.Add(this.PictureBox2);
            this.Panel2.Controls.Add(this.User_NameTextBox);
            this.Panel2.Controls.Add(this.PictureBox3);
            this.Panel2.Controls.Add(this.TextBox1);
            this.Panel2.Controls.Add(Label2);
            this.Panel2.Controls.Add(User_NameLabel);
            this.Panel2.Location = new System.Drawing.Point(7, 77);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(460, 131);
            this.Panel2.TabIndex = 27;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(70, 101);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(23, 20);
            this.pictureBox6.TabIndex = 25;
            this.pictureBox6.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.TblUserBindingSource, "BranchID", true));
            this.comboBox1.DataSource = this.tblAccEntryBindingSource;
            this.comboBox1.DisplayMember = "EntryAccName";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(97, 100);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(357, 21);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.ValueMember = "EntryAccID";
            // 
            // tblAccEntryBindingSource
            // 
            this.tblAccEntryBindingSource.DataMember = "TblAccEntry";
            this.tblAccEntryBindingSource.DataSource = this.UsersDataSet;
            // 
            // PictureBox4
            // 
            this.PictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBox4.BackgroundImage")));
            this.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PictureBox4.Location = new System.Drawing.Point(70, 74);
            this.PictureBox4.Name = "PictureBox4";
            this.PictureBox4.Size = new System.Drawing.Size(23, 20);
            this.PictureBox4.TabIndex = 22;
            this.PictureBox4.TabStop = false;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.PasswordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.TblUserBindingSource, "Password", true));
            this.PasswordTextBox.Location = new System.Drawing.Point(97, 46);
            this.PasswordTextBox.MaxLength = 50;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(122, 21);
            this.PasswordTextBox.TabIndex = 4;
            // 
            // PictureBox2
            // 
            this.PictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBox2.BackgroundImage")));
            this.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PictureBox2.Location = new System.Drawing.Point(70, 46);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(23, 20);
            this.PictureBox2.TabIndex = 20;
            this.PictureBox2.TabStop = false;
            // 
            // User_NameTextBox
            // 
            this.User_NameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.User_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.TblUserBindingSource, "UserName", true));
            this.User_NameTextBox.Location = new System.Drawing.Point(97, 19);
            this.User_NameTextBox.MaxLength = 50;
            this.User_NameTextBox.Name = "User_NameTextBox";
            this.User_NameTextBox.Size = new System.Drawing.Size(122, 21);
            this.User_NameTextBox.TabIndex = 2;
            // 
            // PictureBox3
            // 
            this.PictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBox3.BackgroundImage")));
            this.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PictureBox3.Location = new System.Drawing.Point(70, 19);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(23, 20);
            this.PictureBox3.TabIndex = 19;
            this.PictureBox3.TabStop = false;
            // 
            // TextBox1
            // 
            this.TextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.TextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.TblUserBindingSource, "Password", true));
            this.TextBox1.Location = new System.Drawing.Point(97, 73);
            this.TextBox1.MaxLength = 50;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.PasswordChar = '*';
            this.TextBox1.Size = new System.Drawing.Size(122, 21);
            this.TextBox1.TabIndex = 6;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(7, 24);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(42, 51);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 16;
            this.PictureBox1.TabStop = false;
            // 
            // TblUserBindingNavigator
            // 
            this.TblUserBindingNavigator.AddNewItem = this.BindingNavigatorAddNewItem;
            this.TblUserBindingNavigator.AutoSize = false;
            this.TblUserBindingNavigator.BackColor = System.Drawing.Color.White;
            this.TblUserBindingNavigator.BindingSource = this.TblUserBindingSource;
            this.TblUserBindingNavigator.CountItem = this.BindingNavigatorCountItem;
            this.TblUserBindingNavigator.DeleteItem = this.BindingNavigatorDeleteItem;
            this.TblUserBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TblUserBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TblUserBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BindingNavigatorMoveFirstItem,
            this.BindingNavigatorMovePreviousItem,
            this.BindingNavigatorSeparator,
            this.BindingNavigatorPositionItem,
            this.BindingNavigatorCountItem,
            this.BindingNavigatorSeparator1,
            this.BindingNavigatorMoveNextItem,
            this.BindingNavigatorMoveLastItem,
            this.BindingNavigatorSeparator2,
            this.BindingNavigatorAddNewItem,
            this.BindingNavigatorDeleteItem,
            this.TblUserBindingNavigatorSaveItem,
            this.ToolStripLabel1,
            this.ToolStripButton1});
            this.TblUserBindingNavigator.Location = new System.Drawing.Point(0, 349);
            this.TblUserBindingNavigator.MoveFirstItem = this.BindingNavigatorMoveFirstItem;
            this.TblUserBindingNavigator.MoveLastItem = this.BindingNavigatorMoveLastItem;
            this.TblUserBindingNavigator.MoveNextItem = this.BindingNavigatorMoveNextItem;
            this.TblUserBindingNavigator.MovePreviousItem = this.BindingNavigatorMovePreviousItem;
            this.TblUserBindingNavigator.Name = "TblUserBindingNavigator";
            this.TblUserBindingNavigator.PositionItem = this.BindingNavigatorPositionItem;
            this.TblUserBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.TblUserBindingNavigator.Size = new System.Drawing.Size(1009, 28);
            this.TblUserBindingNavigator.TabIndex = 12;
            this.TblUserBindingNavigator.Text = "BindingNavigator1";
            // 
            // BindingNavigatorAddNewItem
            // 
            this.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorAddNewItem.Image")));
            this.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem";
            this.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 25);
            this.BindingNavigatorAddNewItem.Text = "Add new";
            this.BindingNavigatorAddNewItem.Visible = false;
            // 
            // BindingNavigatorCountItem
            // 
            this.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem";
            this.BindingNavigatorCountItem.Size = new System.Drawing.Size(35, 25);
            this.BindingNavigatorCountItem.Text = "of {0}";
            this.BindingNavigatorCountItem.ToolTipText = "Total number of items";
            this.BindingNavigatorCountItem.Visible = false;
            // 
            // BindingNavigatorDeleteItem
            // 
            this.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorDeleteItem.Image")));
            this.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem";
            this.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 25);
            this.BindingNavigatorDeleteItem.Text = "Delete";
            this.BindingNavigatorDeleteItem.Visible = false;
            // 
            // BindingNavigatorMoveFirstItem
            // 
            this.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMoveFirstItem.Image")));
            this.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem";
            this.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 25);
            this.BindingNavigatorMoveFirstItem.Text = "Move first";
            this.BindingNavigatorMoveFirstItem.Visible = false;
            // 
            // BindingNavigatorMovePreviousItem
            // 
            this.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMovePreviousItem.Image")));
            this.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem";
            this.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 25);
            this.BindingNavigatorMovePreviousItem.Text = "Move previous";
            this.BindingNavigatorMovePreviousItem.Visible = false;
            // 
            // BindingNavigatorSeparator
            // 
            this.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator";
            this.BindingNavigatorSeparator.Size = new System.Drawing.Size(6, 28);
            this.BindingNavigatorSeparator.Visible = false;
            // 
            // BindingNavigatorPositionItem
            // 
            this.BindingNavigatorPositionItem.AccessibleName = "Position";
            this.BindingNavigatorPositionItem.AutoSize = false;
            this.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem";
            this.BindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.BindingNavigatorPositionItem.Text = "0";
            this.BindingNavigatorPositionItem.ToolTipText = "Current position";
            this.BindingNavigatorPositionItem.Visible = false;
            // 
            // BindingNavigatorSeparator1
            // 
            this.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1";
            this.BindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 28);
            this.BindingNavigatorSeparator1.Visible = false;
            // 
            // BindingNavigatorMoveNextItem
            // 
            this.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMoveNextItem.Image")));
            this.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem";
            this.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 25);
            this.BindingNavigatorMoveNextItem.Text = "Move next";
            this.BindingNavigatorMoveNextItem.Visible = false;
            // 
            // BindingNavigatorMoveLastItem
            // 
            this.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorMoveLastItem.Image")));
            this.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem";
            this.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 25);
            this.BindingNavigatorMoveLastItem.Text = "Move last";
            this.BindingNavigatorMoveLastItem.Visible = false;
            // 
            // BindingNavigatorSeparator2
            // 
            this.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2";
            this.BindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 28);
            this.BindingNavigatorSeparator2.Visible = false;
            // 
            // TblUserBindingNavigatorSaveItem
            // 
            this.TblUserBindingNavigatorSaveItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TblUserBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("TblUserBindingNavigatorSaveItem.Image")));
            this.TblUserBindingNavigatorSaveItem.Name = "TblUserBindingNavigatorSaveItem";
            this.TblUserBindingNavigatorSaveItem.Size = new System.Drawing.Size(77, 25);
            this.TblUserBindingNavigatorSaveItem.Text = "Save User";
            this.TblUserBindingNavigatorSaveItem.Click += new System.EventHandler(this.TblUserBindingNavigatorSaveItem_Click);
            // 
            // ToolStripLabel1
            // 
            this.ToolStripLabel1.Name = "ToolStripLabel1";
            this.ToolStripLabel1.Size = new System.Drawing.Size(13, 25);
            this.ToolStripLabel1.Text = "  ";
            // 
            // ToolStripButton1
            // 
            this.ToolStripButton1.ForeColor = System.Drawing.Color.Red;
            this.ToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton1.Image")));
            this.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton1.Name = "ToolStripButton1";
            this.ToolStripButton1.Size = new System.Drawing.Size(56, 25);
            this.ToolStripButton1.Text = "&Close";
            this.ToolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // StatusCheckBox
            // 
            this.StatusCheckBox.Checked = true;
            this.StatusCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.StatusCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "Status", true));
            this.StatusCheckBox.Location = new System.Drawing.Point(384, 18);
            this.StatusCheckBox.Name = "StatusCheckBox";
            this.StatusCheckBox.Size = new System.Drawing.Size(81, 24);
            this.StatusCheckBox.TabIndex = 11;
            this.StatusCheckBox.Text = "Disable";
            this.StatusCheckBox.UseVisualStyleBackColor = true;
            this.StatusCheckBox.CheckedChanged += new System.EventHandler(this.StatusCheckBox_CheckedChanged);
            // 
            // GroupType
            // 
            this.GroupType.Controls.Add(this.RadioBClient);
            this.GroupType.Controls.Add(this.RadioBComm);
            this.GroupType.Controls.Add(this.RadioBAdmin);
            this.GroupType.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.TblUserBindingSource, "UserType", true));
            this.GroupType.Location = new System.Drawing.Point(291, 107);
            this.GroupType.Name = "GroupType";
            this.GroupType.Size = new System.Drawing.Size(160, 40);
            this.GroupType.TabIndex = 7;
            this.GroupType.TabStop = false;
            this.GroupType.Text = "User Type ";
            // 
            // RadioBClient
            // 
            this.RadioBClient.Location = new System.Drawing.Point(15, 62);
            this.RadioBClient.Name = "RadioBClient";
            this.RadioBClient.Size = new System.Drawing.Size(117, 18);
            this.RadioBClient.TabIndex = 2;
            this.RadioBClient.TabStop = true;
            this.RadioBClient.Text = "KPO";
            this.RadioBClient.UseVisualStyleBackColor = true;
            this.RadioBClient.CheckedChanged += new System.EventHandler(this.RadioBClient_CheckedChanged);
            // 
            // RadioBComm
            // 
            this.RadioBComm.AutoSize = true;
            this.RadioBComm.Location = new System.Drawing.Point(15, 44);
            this.RadioBComm.Name = "RadioBComm";
            this.RadioBComm.Size = new System.Drawing.Size(72, 17);
            this.RadioBComm.TabIndex = 1;
            this.RadioBComm.TabStop = true;
            this.RadioBComm.Text = "Executive";
            this.RadioBComm.UseVisualStyleBackColor = true;
            this.RadioBComm.CheckedChanged += new System.EventHandler(this.RadioBComm_CheckedChanged);
            // 
            // RadioBAdmin
            // 
            this.RadioBAdmin.Checked = true;
            this.RadioBAdmin.Location = new System.Drawing.Point(15, 28);
            this.RadioBAdmin.Name = "RadioBAdmin";
            this.RadioBAdmin.Size = new System.Drawing.Size(100, 18);
            this.RadioBAdmin.TabIndex = 0;
            this.RadioBAdmin.TabStop = true;
            this.RadioBAdmin.Text = "Administrator";
            this.RadioBAdmin.UseVisualStyleBackColor = true;
            this.RadioBAdmin.CheckedChanged += new System.EventHandler(this.RadioBAdmin_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(514, 357);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(63, 23);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "&Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(433, 357);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add New";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // PictureBox5
            // 
            this.PictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox5.Image")));
            this.PictureBox5.Location = new System.Drawing.Point(38, 8);
            this.PictureBox5.Name = "PictureBox5";
            this.PictureBox5.Size = new System.Drawing.Size(42, 51);
            this.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox5.TabIndex = 25;
            this.PictureBox5.TabStop = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "UserName";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn1.HeaderText = "User Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 250;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "UserType";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Format = "*";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn2.HeaderText = "UserType";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 10;
            // 
            // TblUserTableAdapter
            // 
            this.TblUserTableAdapter.ClearBeforeFill = true;
            // 
            // TableAdapterManager
            // 
            this.TableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.TableAdapterManager.TblUserTableAdapter = this.TblUserTableAdapter;
            this.TableAdapterManager.UpdateOrder = AccountSystem.UsersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblAccEntryTableAdapter
            // 
            this.tblAccEntryTableAdapter.ClearBeforeFill = true;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Bank Payment Voucher";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 98;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // showhidedashCheckBox
            // 
            this.showhidedashCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.TblUserBindingSource, "showhidedash", true));
            this.showhidedashCheckBox.Location = new System.Drawing.Point(826, 195);
            this.showhidedashCheckBox.Name = "showhidedashCheckBox";
            this.showhidedashCheckBox.Size = new System.Drawing.Size(147, 24);
            this.showhidedashCheckBox.TabIndex = 30;
            this.showhidedashCheckBox.Text = "Show/Hide Dashboard";
            this.showhidedashCheckBox.UseVisualStyleBackColor = true;
            // 
            // frmUsers
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1091, 436);
            this.Controls.Add(Label5);
            this.Controls.Add(this.PictureBox5);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.TblUserDataGridView);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(Label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add / Remove Users";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUsers_FormClosing);
            this.Load += new System.EventHandler(this.frmUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TblUserDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataSet)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAccEntryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblUserBindingNavigator)).EndInit();
            this.TblUserBindingNavigator.ResumeLayout(false);
            this.TblUserBindingNavigator.PerformLayout();
            this.GroupType.ResumeLayout(false);
            this.GroupType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal AccountSystem.UsersDataSet UsersDataSet;
		internal System.Windows.Forms.BindingSource TblUserBindingSource;
		internal AccountSystem.UsersDataSetTableAdapters.TblUserTableAdapter TblUserTableAdapter;
		internal AccountSystem.UsersDataSetTableAdapters.TableAdapterManager TableAdapterManager;
		internal System.Windows.Forms.BindingNavigator TblUserBindingNavigator;
		internal System.Windows.Forms.ToolStripButton BindingNavigatorAddNewItem;
		internal System.Windows.Forms.ToolStripLabel BindingNavigatorCountItem;
		internal System.Windows.Forms.ToolStripButton BindingNavigatorDeleteItem;
		internal System.Windows.Forms.ToolStripButton BindingNavigatorMoveFirstItem;
		internal System.Windows.Forms.ToolStripButton BindingNavigatorMovePreviousItem;
		internal System.Windows.Forms.ToolStripSeparator BindingNavigatorSeparator;
		internal System.Windows.Forms.ToolStripTextBox BindingNavigatorPositionItem;
		internal System.Windows.Forms.ToolStripSeparator BindingNavigatorSeparator1;
		internal System.Windows.Forms.ToolStripButton BindingNavigatorMoveNextItem;
		internal System.Windows.Forms.ToolStripButton BindingNavigatorMoveLastItem;
		internal System.Windows.Forms.ToolStripSeparator BindingNavigatorSeparator2;
		internal System.Windows.Forms.ToolStripButton TblUserBindingNavigatorSaveItem;
		internal System.Windows.Forms.TextBox User_NameTextBox;
		internal System.Windows.Forms.TextBox PasswordTextBox;
        internal System.Windows.Forms.CheckBox StatusCheckBox;
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.GroupBox GroupType;
		internal System.Windows.Forms.RadioButton RadioBClient;
		internal System.Windows.Forms.RadioButton RadioBComm;
		internal System.Windows.Forms.RadioButton RadioBAdmin;
        internal System.Windows.Forms.DataGridView TblUserDataGridView;
        //internal System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        //internal System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
        //internal System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn4;
        //internal System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn5;
		internal System.Windows.Forms.ToolStripButton ToolStripButton1;
		internal System.Windows.Forms.Panel Panel1;
		internal System.Windows.Forms.PictureBox PictureBox1;
		internal DevExpress.XtraEditors.SimpleButton btnAdd;
		internal DevExpress.XtraEditors.SimpleButton btnClose;
		internal System.Windows.Forms.PictureBox PictureBox4;
		internal System.Windows.Forms.PictureBox PictureBox2;
		internal System.Windows.Forms.PictureBox PictureBox3;
        internal System.Windows.Forms.ToolStripLabel ToolStripLabel1;
		internal System.Windows.Forms.PictureBox PictureBox5;
		internal System.Windows.Forms.Panel Panel2;
        private System.ComponentModel.IContainer components;
        private DataGridViewImageColumn dataGridViewImageColumn1;
        internal PictureBox pictureBox6;
        private ComboBox comboBox1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private CheckBox btnVoucherCheckBox;
        private CheckBox btnBVoucherCheckBox;
        private CheckBox btnCahsVCheckBox;
        private CheckBox btnLedgerCheckBox;
        private CheckBox btnTBCheckBox;
        private CheckBox btnISCheckBox;
        private CheckBox btnBSCheckBox;
        private CheckBox btnFCCheckBox;
        private CheckBox expenseSheetCheckBox;
        private CheckBox btnPurchaseCheckBox;
        private CheckBox btnPurchaseOrderCheckBox;
        private CheckBox btnPOEditCheckBox;
        private CheckBox btnSaleCheckBox;
        private CheckBox btnDeliveryChallanCheckBox;
        private CheckBox btnEditSaleOrderCheckBox;
        private CheckBox btnIssuanceCheckBox;
        private CheckBox btnSaleRCheckBox;
        private CheckBox btnPurchRCheckBox;
        private CheckBox btnDisSchCheckBox;
        private CheckBox btnPurVenCheckBox;
        private CheckBox btnCustSCheckBox;
        private CheckBox btnSalesmenCheckBox;
        private CheckBox btnSalemanProductCheckBox;
        private CheckBox btnProdLadgerCheckBox;
        private CheckBox btnStockCheckBox;
        private CheckBox btnBTCCheckBox;
        private CheckBox btnUsersCheckBox;
        private CheckBox btnCompanyCheckBox;
        private CheckBox btnBackupCheckBox;
        private CheckBox btnAppSettingCheckBox;
        private CheckBox btnProductCheckBox;
        private CheckBox btnProPrerCheckBox;
        private CheckBox btnProdListCheckBox;
        private CheckBox btnStoreCheckBox;
        private CheckBox btnVendorsCheckBox;
        private CheckBox btnEmployeesCheckBox;
        private CheckBox btnCustomersCheckBox;
        private CheckBox btnChartAccCheckBox;
        private BindingSource tblAccEntryBindingSource;
        private UsersDataSetTableAdapters.TblAccEntryTableAdapter tblAccEntryTableAdapter;
        private DataGridViewImageColumn Column1;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userTypeDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn repliDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn softIDDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn btnVoucherDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn btnBVoucherDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn btnCahsVDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn btnLedgerDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn btnTBDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn btnISDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn btnBSDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn btnFCDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn expenseSheetDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn btnPurchaseDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn btnPurchaseOrderDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn btnPOEditDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn btnSaleDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn btnDeliveryChallanDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn btnEditSaleOrderDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn btnIssuanceDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn btnSaleRDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn btnPurchRDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn btnDisSchDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn btnPurVenDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn btnCustSDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn btnSalesmenDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn btnSalemanProductDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn btnProdLadgerDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn btnStockDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn btnBTCDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn btnUsersDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn btnCompanyDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn btnBackupDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn btnAppSettingDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn btnProductDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn btnProPrerDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn btnProdListDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn btnStoreDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn btnVendorsDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn btnEmployeesDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn btnCustomersDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn btnChartAccDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn branchIDDataGridViewTextBoxColumn;
        private CheckBox btnOverdueBalancesCheckBox;
        private CheckBox btnGeneralEntriesCheckBox;
        private CheckBox btnLedgerinUSDCheckBox;
        private CheckBox btnPaymenttermsCheckBox;
        private CheckBox btnCityRegCheckBox;
        private CheckBox btnDayClosingCheckBox;
        private CheckBox btnOrderStatusCheckBox;
        private CheckBox btnEmpProCheckBox;
        private CheckBox btnMonthWiseSaleCheckBox;
        private CheckBox btnProfitabilityCheckBox;
        private CheckBox btnCashBankBalancesCheckBox;
        private CheckBox btnCustBalanceCheckBox;
        private CheckBox vendorBalancesCheckBox;
        private CheckBox btnOverdueInvoicesCheckBox;
        private CheckBox btnPurchaseRegCheckBox;
        private CheckBox btnSaleRegCheckBox;
        private CheckBox btnEditVouchersCheckBox;
        private CheckBox btnVoucherPreviewCheckBox;
        private CheckBox btnSearchVouchersCheckBox;
        private CheckBox btnFundTransferCheckBox;
        private CheckBox btnReceiptsReportCheckBox;
        private CheckBox btnVoucherPostingCheckBox;
        private CheckBox btnRPTTIRECLAIMSCheckBox;
        private CheckBox btnClaimFormEditCheckBox;
        private CheckBox btnChangeOrderStatusCheckBox;
        private CheckBox btnPaymenttoVendorCheckBox;
        private CheckBox btnWalkinCustCheckBox;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private CheckBox showhidedashCheckBox;
    }
	
}
