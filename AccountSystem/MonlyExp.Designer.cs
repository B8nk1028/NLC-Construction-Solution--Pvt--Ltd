namespace AccountSystem
{
    partial class MonlyExp
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
            System.Windows.Forms.Label label6;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonlyExp));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.cbLocation = new System.Windows.Forms.ComboBox();
            this.TblAccEntryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MonthViseDS = new AccountSystem.MonthViseDS();
            this.TblAccEntryTableAdapter = new AccountSystem.MonthViseDSTableAdapters.TblAccEntryTableAdapter();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblAccEntryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthViseDS)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TblAccEntryBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AccountSystem.MonlyExp.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowExportButton = false;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowRefreshButton = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.Size = new System.Drawing.Size(1005, 518);
            this.reportViewer1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Location = new System.Drawing.Point(435, 7);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(54, 13);
            label6.TabIndex = 35;
            label6.Text = "Location :";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(416, 4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(23, 20);
            this.pictureBox6.TabIndex = 37;
            this.pictureBox6.TabStop = false;
            // 
            // cbLocation
            // 
            this.cbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.Location = new System.Drawing.Point(492, 3);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(248, 21);
            this.cbLocation.TabIndex = 36;
            this.cbLocation.SelectedIndexChanged += new System.EventHandler(this.cbLocation_SelectedIndexChanged);
            // 
            // TblAccEntryBindingSource
            // 
            this.TblAccEntryBindingSource.DataMember = "TblAccEntry";
            this.TblAccEntryBindingSource.DataSource = this.MonthViseDS;
            // 
            // MonthViseDS
            // 
            this.MonthViseDS.DataSetName = "MonthViseDS";
            this.MonthViseDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TblAccEntryTableAdapter
            // 
            this.TblAccEntryTableAdapter.ClearBeforeFill = true;
            // 
            // MonlyExp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 518);
            this.Controls.Add(label6);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.cbLocation);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MonlyExp";
            this.Text = "Expense Sheet";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MonlyExp_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblAccEntryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthViseDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TblAccEntryBindingSource;
        private MonthViseDS MonthViseDS;
        private MonthViseDSTableAdapters.TblAccEntryTableAdapter TblAccEntryTableAdapter;
        internal System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.ComboBox cbLocation;
    }
}