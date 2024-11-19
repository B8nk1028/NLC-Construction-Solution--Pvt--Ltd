namespace AccountSystem
{
    partial class LadgerRpt
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LadgerRpt));
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LadgerDataSet = new AccountSystem.LadgerDataSet();
            this.TblCompanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CompanyLogo = new AccountSystem.CompanyLogo();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTable1TableAdapter = new AccountSystem.LadgerDataSetTableAdapters.DataTable1TableAdapter();
            this.TblCompanyTableAdapter = new AccountSystem.CompanyLogoTableAdapters.TblCompanyTableAdapter();
            this.JVDataSet = new AccountSystem.JVDataSet();
            this.dataTable1TableAdapter1 = new AccountSystem.JVDataSetTableAdapters.DataTable1TableAdapter();
            this.Pur_SalDS = new AccountSystem.Pur_SalDS();
            this.Sal_PurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Sal_PurTableAdapter = new AccountSystem.Pur_SalDSTableAdapters.Sal_PurTableAdapter();
            this.duplicateGRNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.duplicateGRNTableAdapter = new AccountSystem.Pur_SalDSTableAdapters.DuplicateGRNTableAdapter();
            this.tableAdapterManager = new AccountSystem.Pur_SalDSTableAdapters.TableAdapterManager();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.DescWdth = new System.Windows.Forms.NumericUpDown();
            this.ckCol1 = new System.Windows.Forms.CheckBox();
            this.ckCol3 = new System.Windows.Forms.CheckBox();
            this.ckCol2 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LadgerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblCompanyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pur_SalDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sal_PurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duplicateGRNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescWdth)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.LadgerDataSet;
            // 
            // LadgerDataSet
            // 
            this.LadgerDataSet.DataSetName = "LadgerDataSet";
            this.LadgerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.DataTable1BindingSource;
            reportDataSource4.Name = "DataSet2";
            reportDataSource4.Value = this.TblCompanyBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AccountSystem.LadgerReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowExportButton = false;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowRefreshButton = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.Size = new System.Drawing.Size(889, 562);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Drillthrough += new Microsoft.Reporting.WinForms.DrillthroughEventHandler(this.reportViewer1_Drillthrough);
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // TblCompanyTableAdapter
            // 
            this.TblCompanyTableAdapter.ClearBeforeFill = true;
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
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(406, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(19, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Visible = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // DescWdth
            // 
            this.DescWdth.Location = new System.Drawing.Point(523, 3);
            this.DescWdth.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.DescWdth.Name = "DescWdth";
            this.DescWdth.Size = new System.Drawing.Size(77, 20);
            this.DescWdth.TabIndex = 2;
            this.DescWdth.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.DescWdth.ValueChanged += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ckCol1
            // 
            this.ckCol1.AutoSize = true;
            this.ckCol1.Checked = true;
            this.ckCol1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckCol1.Location = new System.Drawing.Point(607, 5);
            this.ckCol1.Name = "ckCol1";
            this.ckCol1.Size = new System.Drawing.Size(67, 17);
            this.ckCol1.TabIndex = 3;
            this.ckCol1.Text = "Column I";
            this.ckCol1.UseVisualStyleBackColor = true;
            this.ckCol1.CheckedChanged += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ckCol3
            // 
            this.ckCol3.AutoSize = true;
            this.ckCol3.Checked = true;
            this.ckCol3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckCol3.Location = new System.Drawing.Point(779, 5);
            this.ckCol3.Name = "ckCol3";
            this.ckCol3.Size = new System.Drawing.Size(73, 17);
            this.ckCol3.TabIndex = 4;
            this.ckCol3.Text = "Column III";
            this.ckCol3.UseVisualStyleBackColor = true;
            this.ckCol3.CheckedChanged += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ckCol2
            // 
            this.ckCol2.AutoSize = true;
            this.ckCol2.Checked = true;
            this.ckCol2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckCol2.Location = new System.Drawing.Point(693, 5);
            this.ckCol2.Name = "ckCol2";
            this.ckCol2.Size = new System.Drawing.Size(70, 17);
            this.ckCol2.TabIndex = 5;
            this.ckCol2.Text = "Column II";
            this.ckCol2.UseVisualStyleBackColor = true;
            this.ckCol2.CheckedChanged += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(427, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Description Width";
            // 
            // LadgerRpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 562);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ckCol2);
            this.Controls.Add(this.ckCol3);
            this.Controls.Add(this.ckCol1);
            this.Controls.Add(this.DescWdth);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LadgerRpt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ladger Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.LadgerRpt_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LadgerRpt_FormClosing);
            this.Load += new System.EventHandler(this.LadgerRpt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LadgerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblCompanyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pur_SalDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sal_PurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duplicateGRNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescWdth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private LadgerDataSet LadgerDataSet;
        private LadgerDataSetTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private System.Windows.Forms.BindingSource TblCompanyBindingSource;
        private CompanyLogo CompanyLogo;
        private CompanyLogoTableAdapters.TblCompanyTableAdapter TblCompanyTableAdapter;
        private JVDataSet JVDataSet;
        private JVDataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter1;
        private System.Windows.Forms.BindingSource Sal_PurBindingSource;
        private Pur_SalDS Pur_SalDS;
        private Pur_SalDSTableAdapters.Sal_PurTableAdapter Sal_PurTableAdapter;
        private System.Windows.Forms.BindingSource duplicateGRNBindingSource;
        private Pur_SalDSTableAdapters.DuplicateGRNTableAdapter duplicateGRNTableAdapter;
        private Pur_SalDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.NumericUpDown DescWdth;
        private System.Windows.Forms.CheckBox ckCol1;
        private System.Windows.Forms.CheckBox ckCol3;
        private System.Windows.Forms.CheckBox ckCol2;
        private System.Windows.Forms.Label label1;
    }
}