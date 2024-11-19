namespace AccountSystem
{
    partial class StockRptDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockRptDetails));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.datePicker1 = new System.Windows.Forms.DateTimePicker();
            this.datePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnShow = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnclose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CompanyLogo = new AccountSystem.CompanyLogo();
            this.TblCompanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TblCompanyTableAdapter = new AccountSystem.CompanyLogoTableAdapters.TblCompanyTableAdapter();
            this.DataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.WithSalesmanDS = new AccountSystem.WithSalesmanDS();
            this.DataTable2TableAdapter = new AccountSystem.WithSalesmanDSTableAdapters.DataTable2TableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblCompanyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WithSalesmanDS)).BeginInit();
            this.SuspendLayout();
            // 
            // datePicker1
            // 
            this.datePicker1.CustomFormat = "dd MMMM yyyy";
            this.datePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker1.Location = new System.Drawing.Point(236, 60);
            this.datePicker1.Name = "datePicker1";
            this.datePicker1.Size = new System.Drawing.Size(136, 20);
            this.datePicker1.TabIndex = 0;
            this.datePicker1.Value = new System.DateTime(2011, 9, 4, 0, 0, 0, 0);
            this.datePicker1.Visible = false;
            // 
            // datePicker2
            // 
            this.datePicker2.CustomFormat = "dd MMMM yyyy";
            this.datePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker2.Location = new System.Drawing.Point(95, 35);
            this.datePicker2.Name = "datePicker2";
            this.datePicker2.Size = new System.Drawing.Size(136, 20);
            this.datePicker2.TabIndex = 1;
            // 
            // btnShow
            // 
            this.btnShow.Image = ((System.Drawing.Image)(resources.GetObject("btnShow.Image")));
            this.btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShow.Location = new System.Drawing.Point(134, 61);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(104, 23);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Refresh";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datePicker2);
            this.groupBox1.Controls.Add(this.btnShow);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnclose);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(757, 90);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnclose
            // 
            this.btnclose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnclose.Image = global::AccountSystem.Properties.Resources.exit;
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.Location = new System.Drawing.Point(244, 61);
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
            this.pictureBox1.Location = new System.Drawing.Point(17, 12);
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
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable2BindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.TblCompanyBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AccountSystem.Stock_Details.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 100);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowExportButton = false;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowRefreshButton = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.Size = new System.Drawing.Size(781, 322);
            this.reportViewer1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.datePicker1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 100);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Till Date:";
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
            // DataTable2BindingSource
            // 
            this.DataTable2BindingSource.DataMember = "DataTable2";
            this.DataTable2BindingSource.DataSource = this.WithSalesmanDS;
            // 
            // WithSalesmanDS
            // 
            this.WithSalesmanDS.DataSetName = "WithSalesmanDS";
            this.WithSalesmanDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable2TableAdapter
            // 
            this.DataTable2TableAdapter.ClearBeforeFill = true;
            // 
            // StockRptDetails
            // 
            this.AcceptButton = this.btnShow;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.btnclose;
            this.ClientSize = new System.Drawing.Size(781, 422);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "StockRptDetails";
            this.Text = "Stock Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StockRptParm_FormClosing);
            this.Load += new System.EventHandler(this.StockRptParm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CompanyLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblCompanyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WithSalesmanDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datePicker1;
        private System.Windows.Forms.DateTimePicker datePicker2;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource DataTable2BindingSource;
        private WithSalesmanDS WithSalesmanDS;
        private WithSalesmanDSTableAdapters.DataTable2TableAdapter DataTable2TableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource TblCompanyBindingSource;
        private CompanyLogo CompanyLogo;
        private CompanyLogoTableAdapters.TblCompanyTableAdapter TblCompanyTableAdapter;
    }
}