namespace AccountSystem
{
    partial class PO_Invioce
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PO_Invioce));
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Purch_Invioce = new AccountSystem.Purch_Invioce();
            this.TblCompanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CompanyLogo = new AccountSystem.CompanyLogo();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTable1TableAdapter = new AccountSystem.Purch_InvioceTableAdapters.DataTable1TableAdapter();
            this.TblCompanyTableAdapter = new AccountSystem.CompanyLogoTableAdapters.TblCompanyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Purch_Invioce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblCompanyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.Purch_Invioce;
            // 
            // Purch_Invioce
            // 
            this.Purch_Invioce.DataSetName = "Purch_Invioce";
            this.Purch_Invioce.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable1BindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.TblCompanyBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AccountSystem.PO_Invioce.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowExportButton = false;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowRefreshButton = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.Size = new System.Drawing.Size(731, 422);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // TblCompanyTableAdapter
            // 
            this.TblCompanyTableAdapter.ClearBeforeFill = true;
            // 
            // PO_Invioce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 422);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PO_Invioce";
            this.Text = "PO Invioce";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PO_Invioce_FormClosing);
            this.Load += new System.EventHandler(this.PO_Invioce_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Purch_Invioce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblCompanyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private Purch_Invioce Purch_Invioce;
        private System.Windows.Forms.BindingSource TblCompanyBindingSource;
        private CompanyLogo CompanyLogo;
        private Purch_InvioceTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private CompanyLogoTableAdapters.TblCompanyTableAdapter TblCompanyTableAdapter;
    }
}