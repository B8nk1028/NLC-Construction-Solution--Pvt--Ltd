namespace AccountSystem
{
    partial class AccountChart
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ChartHeads = new AccountSystem.ChartHeads();
            this.TblAccEntryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TblAccEntryTableAdapter = new AccountSystem.ChartHeadsTableAdapters.TblAccEntryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ChartHeads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblAccEntryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.TblAccEntryBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AccountSystem.AccountHeads.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(903, 443);
            this.reportViewer1.TabIndex = 0;
            // 
            // ChartHeads
            // 
            this.ChartHeads.DataSetName = "ChartHeads";
            this.ChartHeads.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TblAccEntryBindingSource
            // 
            this.TblAccEntryBindingSource.DataMember = "TblAccEntry";
            this.TblAccEntryBindingSource.DataSource = this.ChartHeads;
            // 
            // TblAccEntryTableAdapter
            // 
            this.TblAccEntryTableAdapter.ClearBeforeFill = true;
            // 
            // AccountChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 443);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AccountChart";
            this.ShowIcon = false;
            this.Text = "Chart of Accounts";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AccountChart_FormClosing);
            this.Load += new System.EventHandler(this.AccountChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChartHeads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblAccEntryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TblAccEntryBindingSource;
        private ChartHeads ChartHeads;
        private ChartHeadsTableAdapters.TblAccEntryTableAdapter TblAccEntryTableAdapter;
    }
}