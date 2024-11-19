namespace AccountSystem
{
    partial class SalesmanProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesmanProduct));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.datePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnShow = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.ddSaleman = new System.Windows.Forms.ComboBox();
            this.btnclose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StockRpt = new AccountSystem.StockRpt();
            this.DataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable2TableAdapter = new AccountSystem.StockRptTableAdapters.DataTable2TableAdapter();
            this.CompanyLogo = new AccountSystem.CompanyLogo();
            this.TblCompanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TblCompanyTableAdapter = new AccountSystem.CompanyLogoTableAdapters.TblCompanyTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StockRpt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblCompanyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // datePicker2
            // 
            this.datePicker2.CustomFormat = "dd MMMM yyyy";
            this.datePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker2.Location = new System.Drawing.Point(175, 19);
            this.datePicker2.Name = "datePicker2";
            this.datePicker2.Size = new System.Drawing.Size(136, 20);
            this.datePicker2.TabIndex = 1;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(354, 84);
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
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.ddSaleman);
            this.groupBox1.Controls.Add(this.datePicker2);
            this.groupBox1.Location = new System.Drawing.Point(87, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 73);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Period between Dates";
            // 
            // datePicker1
            // 
            this.datePicker1.CustomFormat = "dd MMMM yyyy";
            this.datePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker1.Location = new System.Drawing.Point(23, 19);
            this.datePicker1.Name = "datePicker1";
            this.datePicker1.Size = new System.Drawing.Size(136, 20);
            this.datePicker1.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Salesman";
            // 
            // ddSaleman
            // 
            this.ddSaleman.FormattingEnabled = true;
            this.ddSaleman.Location = new System.Drawing.Point(84, 45);
            this.ddSaleman.Name = "ddSaleman";
            this.ddSaleman.Size = new System.Drawing.Size(328, 21);
            this.ddSaleman.TabIndex = 12;
            // 
            // btnclose
            // 
            this.btnclose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnclose.Location = new System.Drawing.Point(438, 84);
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
            this.pictureBox1.Location = new System.Drawing.Point(9, 7);
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
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AccountSystem.SalesmanProduct.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 112);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowExportButton = false;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowRefreshButton = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.Size = new System.Drawing.Size(781, 310);
            this.reportViewer1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnShow);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 112);
            this.panel1.TabIndex = 7;
            // 
            // StockRpt
            // 
            this.StockRpt.DataSetName = "StockRpt";
            this.StockRpt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable2BindingSource
            // 
            this.DataTable2BindingSource.DataMember = "DataTable2";
            this.DataTable2BindingSource.DataSource = this.StockRpt;
            // 
            // DataTable2TableAdapter
            // 
            this.DataTable2TableAdapter.ClearBeforeFill = true;
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
            // SalesmanProduct
            // 
            this.AcceptButton = this.btnShow;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.btnclose;
            this.ClientSize = new System.Drawing.Size(781, 422);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SalesmanProduct";
            this.Text = "Salesman Product Sale";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StockRptParm_FormClosing);
            this.Load += new System.EventHandler(this.Discountrpt_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StockRpt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblCompanyBindingSource)).EndInit();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ddSaleman;
        private System.Windows.Forms.DateTimePicker datePicker1;
        private System.Windows.Forms.BindingSource DataTable2BindingSource;
        private StockRpt StockRpt;
        private System.Windows.Forms.BindingSource TblCompanyBindingSource;
        private CompanyLogo CompanyLogo;
        private StockRptTableAdapters.DataTable2TableAdapter DataTable2TableAdapter;
        private CompanyLogoTableAdapters.TblCompanyTableAdapter TblCompanyTableAdapter;
    }
}