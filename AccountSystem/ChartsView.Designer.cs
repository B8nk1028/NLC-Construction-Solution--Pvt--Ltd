namespace AccountSystem
{
    partial class ChartsView
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.TblAccHeadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ChartView = new AccountSystem.ChartView();
            this.ExSalViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TblCompanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TblAccHeadTableAdapter = new AccountSystem.ChartViewTableAdapters.TblAccHeadTableAdapter();
            this.ExSalViewTableAdapter = new AccountSystem.ChartViewTableAdapters.ExSalViewTableAdapter();
            this.TblCompanyTableAdapter = new AccountSystem.ChartViewTableAdapters.TblCompanyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TblAccHeadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExSalViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblCompanyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TblAccHeadBindingSource
            // 
            this.TblAccHeadBindingSource.DataMember = "TblAccHead";
            this.TblAccHeadBindingSource.DataSource = this.ChartView;
            // 
            // ChartView
            // 
            this.ChartView.DataSetName = "ChartView";
            this.ChartView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ExSalViewBindingSource
            // 
            this.ExSalViewBindingSource.DataMember = "ExSalView";
            this.ExSalViewBindingSource.DataSource = this.ChartView;
            // 
            // TblCompanyBindingSource
            // 
            this.TblCompanyBindingSource.DataMember = "TblCompany";
            this.TblCompanyBindingSource.DataSource = this.ChartView;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TblAccHeadBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.ExSalViewBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.TblCompanyBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AccountSystem.chart1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowExportButton = false;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowRefreshButton = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.Size = new System.Drawing.Size(802, 538);
            this.reportViewer1.TabIndex = 0;
            // 
            // TblAccHeadTableAdapter
            // 
            this.TblAccHeadTableAdapter.ClearBeforeFill = true;
            // 
            // ExSalViewTableAdapter
            // 
            this.ExSalViewTableAdapter.ClearBeforeFill = true;
            // 
            // TblCompanyTableAdapter
            // 
            this.TblCompanyTableAdapter.ClearBeforeFill = true;
            // 
            // ChartsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 538);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ChartsView";
            this.Text = "Financial Comparisons";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IncomStatView_FormClosing);
            this.Load += new System.EventHandler(this.IncomStatView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TblAccHeadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExSalViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblCompanyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TblAccHeadBindingSource;
        private ChartView ChartView;
        private ChartViewTableAdapters.TblAccHeadTableAdapter TblAccHeadTableAdapter;
        private System.Windows.Forms.BindingSource ExSalViewBindingSource;
        private ChartViewTableAdapters.ExSalViewTableAdapter ExSalViewTableAdapter;
        private System.Windows.Forms.BindingSource TblCompanyBindingSource;
        private ChartViewTableAdapters.TblCompanyTableAdapter TblCompanyTableAdapter;




    }
}