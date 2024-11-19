namespace AccountSystem
{
    partial class StockRptParm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptIncomeStatement));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.Windows.Forms.Label label6;
            this.TblCompanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CompanyLogo = new AccountSystem.CompanyLogo();
            this.datePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnShow = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnclose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TblCompanyTableAdapter = new AccountSystem.CompanyLogoTableAdapters.TblCompanyTableAdapter();
            this.Pur_SalDS = new AccountSystem.Pur_SalDS();
            this.Sal_PurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Sal_PurTableAdapter = new AccountSystem.Pur_SalDSTableAdapters.Sal_PurTableAdapter();
            this.cbLocation = new System.Windows.Forms.ComboBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.tbl_UnitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StockRpt2 = new AccountSystem.StockRpt2();
            this.tbl_UnitTableAdapter = new AccountSystem.StockRpt2TableAdapters.tbl_UnitTableAdapter();
            this.ProductLadger = new AccountSystem.ProductLadger();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable1TableAdapter = new AccountSystem.ProductLadgerTableAdapters.DataTable1TableAdapter();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TblCompanyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyLogo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pur_SalDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sal_PurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_UnitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockRpt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductLadger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TblCompanyBindingSource
            // 
            this.TblCompanyBindingSource.DataMember = "TblCompany";
            this.TblCompanyBindingSource.DataSource = this.CompanyLogo;
            // 
            // CompanyLogo
            // 
            this.CompanyLogo.DataSetName = "CompanyLogo";
            this.CompanyLogo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datePicker2
            // 
            this.datePicker2.CustomFormat = "dd MMMM yyyy";
            this.datePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker2.Location = new System.Drawing.Point(159, 21);
            this.datePicker2.Name = "datePicker2";
            this.datePicker2.Size = new System.Drawing.Size(136, 20);
            this.datePicker2.TabIndex = 1;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(258, 86);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(78, 23);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Run &Report";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datePicker1);
            this.groupBox1.Controls.Add(this.datePicker2);
            this.groupBox1.Location = new System.Drawing.Point(110, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 49);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Period between Dates";
            // 
            // datePicker1
            // 
            this.datePicker1.CustomFormat = "dd MMMM yyyy";
            this.datePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker1.Location = new System.Drawing.Point(17, 21);
            this.datePicker1.Name = "datePicker1";
            this.datePicker1.Size = new System.Drawing.Size(136, 20);
            this.datePicker1.TabIndex = 6;
            // 
            // btnclose
            // 
            this.btnclose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnclose.Location = new System.Drawing.Point(342, 86);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(78, 23);
            this.btnclose.TabIndex = 4;
            this.btnclose.Text = "&Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.tbl_UnitBindingSource;
            reportDataSource4.Name = "DataSet2";
            reportDataSource4.Value = this.TblCompanyBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AccountSystem.StockRpt2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 114);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowExportButton = false;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowRefreshButton = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.Size = new System.Drawing.Size(781, 308);
            this.reportViewer1.TabIndex = 6;
            this.reportViewer1.Drillthrough += new Microsoft.Reporting.WinForms.DrillthroughEventHandler(this.reportViewer1_Drillthrough);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbLocation);
            this.panel1.Controls.Add(label6);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnShow);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 114);
            this.panel1.TabIndex = 7;
            // 
            // TblCompanyTableAdapter
            // 
            this.TblCompanyTableAdapter.ClearBeforeFill = true;
            // 
            // Pur_SalDS
            // 
            this.Pur_SalDS.DataSetName = "Pur_SalDS";
            this.Pur_SalDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Sal_PurBindingSource
            // 
            this.Sal_PurBindingSource.DataMember = "Sal_Pur";
            this.Sal_PurBindingSource.DataSource = this.Pur_SalDS;
            // 
            // Sal_PurTableAdapter
            // 
            this.Sal_PurTableAdapter.ClearBeforeFill = true;
            // 
            // cbLocation
            // 
            this.cbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.Location = new System.Drawing.Point(181, 6);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(239, 21);
            this.cbLocation.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(121, 9);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(54, 13);
            label6.TabIndex = 32;
            label6.Text = "Location :";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(106, 6);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(23, 20);
            this.pictureBox6.TabIndex = 34;
            this.pictureBox6.TabStop = false;
            // 
            // tbl_UnitBindingSource
            // 
            this.tbl_UnitBindingSource.DataMember = "tbl_Unit";
            this.tbl_UnitBindingSource.DataSource = this.StockRpt2;
            // 
            // StockRpt2
            // 
            this.StockRpt2.DataSetName = "StockRpt2";
            this.StockRpt2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_UnitTableAdapter
            // 
            this.tbl_UnitTableAdapter.ClearBeforeFill = true;
            // 
            // ProductLadger
            // 
            this.ProductLadger.DataSetName = "ProductLadger";
            this.ProductLadger.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.ProductLadger;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // StockRptParm2
            // 
            this.AcceptButton = this.btnShow;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.btnclose;
            this.ClientSize = new System.Drawing.Size(781, 422);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "StockRptParm2";
            this.Text = "Stock Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StockRptParm_FormClosing);
            this.Load += new System.EventHandler(this.StockRptParm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TblCompanyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyLogo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pur_SalDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sal_PurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_UnitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockRpt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductLadger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datePicker2;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource TblCompanyBindingSource;
        private CompanyLogo CompanyLogo;
        private CompanyLogoTableAdapters.TblCompanyTableAdapter TblCompanyTableAdapter;
        private System.Windows.Forms.BindingSource Sal_PurBindingSource;
        private Pur_SalDS Pur_SalDS;
        private Pur_SalDSTableAdapters.Sal_PurTableAdapter Sal_PurTableAdapter;
        private System.Windows.Forms.BindingSource tbl_UnitBindingSource;
        private StockRpt2 StockRpt2;
        private StockRpt2TableAdapters.tbl_UnitTableAdapter tbl_UnitTableAdapter;
        private System.Windows.Forms.DateTimePicker datePicker1;
        private System.Windows.Forms.ComboBox cbLocation;
        internal System.Windows.Forms.PictureBox pictureBox6;
        private ProductLadger ProductLadger;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private ProductLadgerTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
    }
}