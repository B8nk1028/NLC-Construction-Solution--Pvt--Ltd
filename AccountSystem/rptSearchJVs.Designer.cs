using System.Windows.Forms;

namespace AccountSystem
{
    partial class rptSearchJVs
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
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptSearchJVs));
            this.btnShow = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cbLocation = new System.Windows.Forms.ComboBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lblbrand = new System.Windows.Forms.Label();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtVoucher = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.textCheque = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.cboVouType = new System.Windows.Forms.ComboBox();
            this.datePicker2 = new System.Windows.Forms.DateTimePicker();
            this.datePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Pur_SalDS = new AccountSystem.Pur_SalDS();
            this.duplicateGRNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.duplicateGRNTableAdapter = new AccountSystem.Pur_SalDSTableAdapters.DuplicateGRNTableAdapter();
            this.tableAdapterManager = new AccountSystem.Pur_SalDSTableAdapters.TableAdapterManager();
            this.dataTable1TableAdapter1 = new AccountSystem.JVDataSetTableAdapters.DataTable1TableAdapter();
            this.JVDataSet = new AccountSystem.JVDataSet();
            this.CompanyLogo = new AccountSystem.CompanyLogo();
            this.TblCompanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TblCompanyTableAdapter = new AccountSystem.CompanyLogoTableAdapters.TblCompanyTableAdapter();
            label6 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pur_SalDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duplicateGRNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblCompanyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(25, 44);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(54, 13);
            label6.TabIndex = 32;
            label6.Text = "Location :";
            label6.Visible = false;
            label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(3, 3);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(60, 13);
            label1.TabIndex = 33;
            label1.Text = "Voucher #:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 46);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(96, 13);
            label2.TabIndex = 39;
            label2.Text = "Cheque #/ Desc. :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(166, 3);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(46, 13);
            label3.TabIndex = 42;
            label3.Text = "Amount:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(6, 98);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(36, 13);
            label4.TabIndex = 46;
            label4.Text = "From :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(16, 122);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(26, 13);
            label5.TabIndex = 45;
            label5.Text = "To :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(6, 141);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(80, 13);
            label7.TabIndex = 47;
            label7.Text = "Voucher Type :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(13, 18);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(30, 13);
            label8.TabIndex = 45;
            label8.Text = "From";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(119, 18);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(20, 13);
            label9.TabIndex = 48;
            label9.Text = "To";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(6, 88);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(78, 23);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "&Search";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnclose
            // 
            this.btnclose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnclose.Location = new System.Drawing.Point(222, 344);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(78, 23);
            this.btnclose.TabIndex = 4;
            this.btnclose.Text = "&Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = null;
            reportDataSource4.Name = "DataSet2";
            reportDataSource4.Value = null;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AccountSystem.rptSearchVouchers.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(313, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.reportViewer1.ShowExportButton = false;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowRefreshButton = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.Size = new System.Drawing.Size(906, 422);
            this.reportViewer1.TabIndex = 6;
            this.reportViewer1.Drillthrough += new Microsoft.Reporting.WinForms.DrillthroughEventHandler(this.reportViewer1_Drillthrough);
            // 
            // cbLocation
            // 
            this.cbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.Location = new System.Drawing.Point(8, 67);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(292, 21);
            this.cbLocation.TabIndex = 33;
            this.cbLocation.Visible = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(8, 41);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(23, 20);
            this.pictureBox6.TabIndex = 34;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Visible = false;
            // 
            // lblbrand
            // 
            this.lblbrand.AutoSize = true;
            this.lblbrand.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbrand.Location = new System.Drawing.Point(1, 0);
            this.lblbrand.Name = "lblbrand";
            this.lblbrand.Size = new System.Drawing.Size(165, 23);
            this.lblbrand.TabIndex = 37;
            this.lblbrand.Text = "Search Vouchers";
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
            this.dockPanel1.ID = new System.Guid("f9ebfc41-3732-4b59-8ae6-4a3c7ef011d6");
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.Options.ShowCloseButton = false;
            this.dockPanel1.OriginalSize = new System.Drawing.Size(313, 200);
            this.dockPanel1.Size = new System.Drawing.Size(313, 422);
            this.dockPanel1.Text = "Search Vouchers";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.tabControl1);
            this.dockPanel1_Container.Controls.Add(this.btnclose);
            this.dockPanel1_Container.Controls.Add(this.cboVouType);
            this.dockPanel1_Container.Controls.Add(label7);
            this.dockPanel1_Container.Controls.Add(label4);
            this.dockPanel1_Container.Controls.Add(label5);
            this.dockPanel1_Container.Controls.Add(this.datePicker2);
            this.dockPanel1_Container.Controls.Add(this.datePicker1);
            this.dockPanel1_Container.Controls.Add(label6);
            this.dockPanel1_Container.Controls.Add(this.lblbrand);
            this.dockPanel1_Container.Controls.Add(this.cbLocation);
            this.dockPanel1_Container.Controls.Add(this.pictureBox6);
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 25);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(307, 394);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(8, 184);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(292, 154);
            this.tabControl1.TabIndex = 49;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(label1);
            this.tabPage1.Controls.Add(this.btnShow);
            this.tabPage1.Controls.Add(this.txtVoucher);
            this.tabPage1.Controls.Add(this.txtAmount);
            this.tabPage1.Controls.Add(this.textCheque);
            this.tabPage1.Controls.Add(label2);
            this.tabPage1.Controls.Add(label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(284, 128);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Open Search";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtVoucher
            // 
            this.txtVoucher.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVoucher.Location = new System.Drawing.Point(6, 19);
            this.txtVoucher.Name = "txtVoucher";
            this.txtVoucher.Size = new System.Drawing.Size(100, 20);
            this.txtVoucher.TabIndex = 38;
            this.txtVoucher.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVoucher_KeyPress);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(169, 19);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 38;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // textCheque
            // 
            this.textCheque.Location = new System.Drawing.Point(6, 62);
            this.textCheque.Name = "textCheque";
            this.textCheque.Size = new System.Drawing.Size(263, 20);
            this.textCheque.TabIndex = 40;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(label8);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.txtFrom);
            this.tabPage2.Controls.Add(this.txtTo);
            this.tabPage2.Controls.Add(label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(284, 128);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Serial Search";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 23);
            this.button2.TabIndex = 43;
            this.button2.Text = "&Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtFrom
            // 
            this.txtFrom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFrom.Location = new System.Drawing.Point(16, 34);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(100, 20);
            this.txtFrom.TabIndex = 46;
            this.txtFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFrom_KeyPress);
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(122, 34);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(100, 20);
            this.txtTo.TabIndex = 47;
            this.txtTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTo_KeyPress);
            // 
            // cboVouType
            // 
            this.cboVouType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVouType.FormattingEnabled = true;
            this.cboVouType.Items.AddRange(new object[] {
            "JV-   Journal Voucher",
            "BPV-Bank Payment Voucher",
            "BRV-Bank Receipt Voucher",
            "CPV-Cash Payment Voucher",
            "CRV-Cash Receipt Voucher",
            "PUR-Purchase Voucher",
            "PR-Purchase Retrun",
            "SL-Sale Voucher",
            "SR-Sale Retrun",
            "COC-Stock Consumed"});
            this.cboVouType.Location = new System.Drawing.Point(8, 157);
            this.cboVouType.Name = "cboVouType";
            this.cboVouType.Size = new System.Drawing.Size(292, 21);
            this.cboVouType.TabIndex = 48;
            // 
            // datePicker2
            // 
            this.datePicker2.CustomFormat = "dd MMMM yyyy";
            this.datePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker2.Location = new System.Drawing.Point(45, 118);
            this.datePicker2.Name = "datePicker2";
            this.datePicker2.Size = new System.Drawing.Size(136, 20);
            this.datePicker2.TabIndex = 43;
            // 
            // datePicker1
            // 
            this.datePicker1.CustomFormat = "dd MMMM yyyy";
            this.datePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker1.Location = new System.Drawing.Point(45, 94);
            this.datePicker1.Name = "datePicker1";
            this.datePicker1.Size = new System.Drawing.Size(136, 20);
            this.datePicker1.TabIndex = 44;
            // 
            // Pur_SalDS
            // 
            this.Pur_SalDS.DataSetName = "Pur_SalDS";
            this.Pur_SalDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // duplicateGRNBindingSource
            // 
            this.duplicateGRNBindingSource.DataMember = "DuplicateGRN";
            this.duplicateGRNBindingSource.DataSource = this.Pur_SalDS;
            // 
            // duplicateGRNTableAdapter
            // 
            this.duplicateGRNTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = AccountSystem.Pur_SalDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataTable1TableAdapter1
            // 
            this.dataTable1TableAdapter1.ClearBeforeFill = true;
            // 
            // JVDataSet
            // 
            this.JVDataSet.DataSetName = "JVDataSet";
            this.JVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CompanyLogo
            // 
            this.CompanyLogo.DataSetName = "CompanyLogo";
            this.CompanyLogo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TblCompanyBindingSource
            // 
            this.TblCompanyBindingSource.DataMember = "TblCompany";
            this.TblCompanyBindingSource.DataSource = this.CompanyLogo;
            // 
            // TblCompanyTableAdapter
            // 
            this.TblCompanyTableAdapter.ClearBeforeFill = true;
            // 
            // rptSearchJVs
            // 
            this.AcceptButton = this.btnShow;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.btnclose;
            this.ClientSize = new System.Drawing.Size(1219, 422);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.dockPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "rptSearchJVs";
            this.Text = "Search Vouchers";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StockRptParm_FormClosing);
            this.Load += new System.EventHandler(this.StockRptParm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.dockPanel1_Container.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pur_SalDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duplicateGRNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblCompanyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnclose;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox cbLocation;
        internal System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lblbrand;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private System.Windows.Forms.TextBox textCheque;
        private System.Windows.Forms.TextBox txtVoucher;
        private Pur_SalDS Pur_SalDS;
        private System.Windows.Forms.BindingSource duplicateGRNBindingSource;
        private Pur_SalDSTableAdapters.DuplicateGRNTableAdapter duplicateGRNTableAdapter;
        private Pur_SalDSTableAdapters.TableAdapterManager tableAdapterManager;
        private JVDataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter1;
        private JVDataSet JVDataSet;
        private CompanyLogo CompanyLogo;
        private System.Windows.Forms.BindingSource TblCompanyBindingSource;
        private CompanyLogoTableAdapters.TblCompanyTableAdapter TblCompanyTableAdapter;
        private System.Windows.Forms.TextBox txtAmount;
        private DateTimePicker datePicker2;
        private DateTimePicker datePicker1;
        private ComboBox cboVouType;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button2;
        private TextBox txtFrom;
        private TextBox txtTo;
    }
}