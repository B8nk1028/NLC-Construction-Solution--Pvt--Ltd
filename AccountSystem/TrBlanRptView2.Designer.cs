namespace AccountSystem
{
    partial class TrBlanRptView2
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.TriBalanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TriBalanceDS = new AccountSystem.TriBalanceDS();
            this.TblCompanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CompanyLogo = new AccountSystem.CompanyLogo();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TblCompanyTableAdapter = new AccountSystem.CompanyLogoTableAdapters.TblCompanyTableAdapter();
            this.TriBalanceTableAdapter = new AccountSystem.TriBalanceDSTableAdapters.TriBalanceTableAdapter();
            this.LadgerDataSet = new AccountSystem.LadgerDataSet();
            this.DataTable1TableAdapter = new AccountSystem.LadgerDataSetTableAdapters.DataTable1TableAdapter();
            this.JVDataSet = new AccountSystem.JVDataSet();
            this.dataTable1TableAdapter1 = new AccountSystem.JVDataSetTableAdapters.DataTable1TableAdapter();
            this.btnTogl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TriBalanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TriBalanceDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblCompanyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LadgerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JVDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // TriBalanceBindingSource
            // 
            this.TriBalanceBindingSource.DataMember = "TriBalance";
            this.TriBalanceBindingSource.DataSource = this.TriBalanceDS;
            // 
            // TriBalanceDS
            // 
            this.TriBalanceDS.DataSetName = "TriBalanceDS";
            this.TriBalanceDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // reportViewer1
            // 
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TriBalanceBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.TblCompanyBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AccountSystem.TBlanceRpt2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowExportButton = false;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowRefreshButton = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.Size = new System.Drawing.Size(880, 583);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Drillthrough += new Microsoft.Reporting.WinForms.DrillthroughEventHandler(this.reportViewer1_Drillthrough);
            // 
            // TblCompanyTableAdapter
            // 
            this.TblCompanyTableAdapter.ClearBeforeFill = true;
            // 
            // TriBalanceTableAdapter
            // 
            this.TriBalanceTableAdapter.ClearBeforeFill = true;
            // 
            // LadgerDataSet
            // 
            this.LadgerDataSet.DataSetName = "LadgerDataSet";
            this.LadgerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // JVDataSet
            // 
            this.JVDataSet.DataSetName = "JVDataSet";
            this.JVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1TableAdapter1
            // 
            this.dataTable1TableAdapter1.ClearBeforeFill = true;
            // 
            // btnTogl
            // 
            this.btnTogl.BackColor = System.Drawing.Color.Transparent;
            this.btnTogl.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnTogl.FlatAppearance.BorderSize = 0;
            this.btnTogl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTogl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnTogl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTogl.Image = global::AccountSystem.Properties.Resources.iw_plus;
            this.btnTogl.Location = new System.Drawing.Point(388, 2);
            this.btnTogl.Name = "btnTogl";
            this.btnTogl.Size = new System.Drawing.Size(22, 21);
            this.btnTogl.TabIndex = 1;
            this.btnTogl.Tag = "false";
            this.btnTogl.UseVisualStyleBackColor = false;
            this.btnTogl.Click += new System.EventHandler(this.btnTogl_Click);
            // 
            // TrBlanRptView2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 583);
            this.Controls.Add(this.btnTogl);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TrBlanRptView2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trial Balance Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.TrBlanRptView2_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TrBlanRptView_FormClosing);
            this.Load += new System.EventHandler(this.TrBlanRptView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TriBalanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TriBalanceDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblCompanyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LadgerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JVDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

       
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TriBalanceBindingSource;
        private TriBalanceDS TriBalanceDS;
        private TriBalanceDSTableAdapters.TriBalanceTableAdapter TriBalanceTableAdapter;
        private System.Windows.Forms.BindingSource TblCompanyBindingSource;
        private CompanyLogo CompanyLogo;
        private CompanyLogoTableAdapters.TblCompanyTableAdapter TblCompanyTableAdapter;
        private LadgerDataSet LadgerDataSet;
        private LadgerDataSetTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private JVDataSet JVDataSet;
        private JVDataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter1;
        private System.Windows.Forms.Button btnTogl;

    }
}