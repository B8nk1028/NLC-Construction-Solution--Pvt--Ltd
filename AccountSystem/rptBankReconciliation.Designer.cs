namespace AccountSystem
{
    partial class rptBankReconciliation
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label7;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptBankReconciliation));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.lblCAmount = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblbrand = new System.Windows.Forms.Label();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.btnUpBankBlance = new System.Windows.Forms.Button();
            this.btnPayDiff = new System.Windows.Forms.Button();
            this.btnRecDiff = new System.Windows.Forms.Button();
            this.btnPayBank = new System.Windows.Forms.Button();
            this.btnRecBank = new System.Windows.Forms.Button();
            this.txtBankBlance = new System.Windows.Forms.NumericUpDown();
            this.datePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cboBank = new SergeUtils.EasyCompletionComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBAmount = new System.Windows.Forms.Label();
            this.bkAmt = new System.Windows.Forms.NumericUpDown();
            this.btnsavepnl = new System.Windows.Forms.Button();
            this.btnpnlcls = new System.Windows.Forms.Button();
            this.tamount = new System.Windows.Forms.NumericUpDown();
            this.txtBref = new System.Windows.Forms.TextBox();
            this.dtDiffDate = new System.Windows.Forms.DateTimePicker();
            this.pnlRecBank = new System.Windows.Forms.Panel();
            this.txtObservation = new SergeUtils.EasyCompletionComboBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankBlance)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bkAmt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamount)).BeginInit();
            this.pnlRecBank.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(36, 99);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(37, 13);
            label2.TabIndex = 54;
            label2.Text = "Month";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(9, 180);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(141, 13);
            label1.TabIndex = 55;
            label1.Text = "Bank Balance per statement";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(11, 55);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(30, 13);
            label3.TabIndex = 56;
            label3.Text = "Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(11, 81);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(55, 13);
            label4.TabIndex = 58;
            label4.Text = "Bank Ref.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(11, 164);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(64, 13);
            label7.TabIndex = 62;
            label7.Text = "Observation";
            // 
            // lblCAmount
            // 
            this.lblCAmount.AutoSize = true;
            this.lblCAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCAmount.Location = new System.Drawing.Point(11, 109);
            this.lblCAmount.Name = "lblCAmount";
            this.lblCAmount.Size = new System.Drawing.Size(49, 13);
            this.lblCAmount.TabIndex = 60;
            this.lblCAmount.Text = "Amount";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(77, 122);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(78, 23);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Run &Report";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnclose
            // 
            this.btnclose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnclose.Location = new System.Drawing.Point(161, 122);
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
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = null;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = null;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AccountSystem.rptBankReconciliation.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(328, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowExportButton = false;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowRefreshButton = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.Size = new System.Drawing.Size(891, 493);
            this.reportViewer1.TabIndex = 6;
            this.reportViewer1.Print += new Microsoft.Reporting.WinForms.ReportPrintEventHandler(this.reportViewer1_Print);
            this.reportViewer1.Drillthrough += new Microsoft.Reporting.WinForms.DrillthroughEventHandler(this.reportViewer1_Drillthrough);
            this.reportViewer1.StatusChanged += new System.EventHandler<System.EventArgs>(this.reportViewer1_StatusChanged);
            // 
            // lblbrand
            // 
            this.lblbrand.AutoSize = true;
            this.lblbrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbrand.Location = new System.Drawing.Point(60, 17);
            this.lblbrand.Name = "lblbrand";
            this.lblbrand.Size = new System.Drawing.Size(194, 24);
            this.lblbrand.TabIndex = 37;
            this.lblbrand.Text = "Bank Reconciliation";
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
            this.dockPanel1.OriginalSize = new System.Drawing.Size(328, 200);
            this.dockPanel1.Size = new System.Drawing.Size(328, 493);
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.btnUpBankBlance);
            this.dockPanel1_Container.Controls.Add(this.btnPayDiff);
            this.dockPanel1_Container.Controls.Add(this.btnRecDiff);
            this.dockPanel1_Container.Controls.Add(this.btnPayBank);
            this.dockPanel1_Container.Controls.Add(this.btnRecBank);
            this.dockPanel1_Container.Controls.Add(label1);
            this.dockPanel1_Container.Controls.Add(this.txtBankBlance);
            this.dockPanel1_Container.Controls.Add(label2);
            this.dockPanel1_Container.Controls.Add(this.datePicker1);
            this.dockPanel1_Container.Controls.Add(this.cboBank);
            this.dockPanel1_Container.Controls.Add(this.label5);
            this.dockPanel1_Container.Controls.Add(this.lblbrand);
            this.dockPanel1_Container.Controls.Add(this.pictureBox1);
            this.dockPanel1_Container.Controls.Add(this.btnShow);
            this.dockPanel1_Container.Controls.Add(this.btnclose);
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 25);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(322, 465);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // btnUpBankBlance
            // 
            this.btnUpBankBlance.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnUpBankBlance.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnUpBankBlance.Location = new System.Drawing.Point(284, 175);
            this.btnUpBankBlance.Name = "btnUpBankBlance";
            this.btnUpBankBlance.Size = new System.Drawing.Size(26, 23);
            this.btnUpBankBlance.TabIndex = 60;
            this.btnUpBankBlance.Text = "";
            this.btnUpBankBlance.UseVisualStyleBackColor = true;
            this.btnUpBankBlance.Click += new System.EventHandler(this.btnUpBankBlance_Click);
            // 
            // btnPayDiff
            // 
            this.btnPayDiff.Location = new System.Drawing.Point(9, 310);
            this.btnPayDiff.Name = "btnPayDiff";
            this.btnPayDiff.Size = new System.Drawing.Size(301, 45);
            this.btnPayDiff.TabIndex = 59;
            this.btnPayDiff.Text = "Payments both in the accounts and on the bank statement but registering different" +
    " amounts";
            this.btnPayDiff.UseVisualStyleBackColor = true;
            this.btnPayDiff.Click += new System.EventHandler(this.btnPayDiff_Click);
            // 
            // btnRecDiff
            // 
            this.btnRecDiff.Location = new System.Drawing.Point(9, 266);
            this.btnRecDiff.Name = "btnRecDiff";
            this.btnRecDiff.Size = new System.Drawing.Size(301, 36);
            this.btnRecDiff.TabIndex = 58;
            this.btnRecDiff.Text = "Receipts both in the accounts and on the bank statement but registering different" +
    " amounts";
            this.btnRecDiff.UseVisualStyleBackColor = true;
            this.btnRecDiff.Click += new System.EventHandler(this.btnRecDiff_Click);
            // 
            // btnPayBank
            // 
            this.btnPayBank.Location = new System.Drawing.Point(9, 235);
            this.btnPayBank.Name = "btnPayBank";
            this.btnPayBank.Size = new System.Drawing.Size(301, 23);
            this.btnPayBank.TabIndex = 57;
            this.btnPayBank.Text = "Payments on the bank statement, not in the accounts";
            this.btnPayBank.UseVisualStyleBackColor = true;
            this.btnPayBank.Click += new System.EventHandler(this.btnPayBank_Click);
            // 
            // btnRecBank
            // 
            this.btnRecBank.Location = new System.Drawing.Point(9, 204);
            this.btnRecBank.Name = "btnRecBank";
            this.btnRecBank.Size = new System.Drawing.Size(301, 23);
            this.btnRecBank.TabIndex = 56;
            this.btnRecBank.Text = "Receipts on the bank statement, not in the accounts";
            this.btnRecBank.UseVisualStyleBackColor = true;
            this.btnRecBank.Click += new System.EventHandler(this.btnRecBank_Click);
            // 
            // txtBankBlance
            // 
            this.txtBankBlance.DecimalPlaces = 2;
            this.txtBankBlance.Location = new System.Drawing.Point(153, 176);
            this.txtBankBlance.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtBankBlance.Name = "txtBankBlance";
            this.txtBankBlance.Size = new System.Drawing.Size(132, 20);
            this.txtBankBlance.TabIndex = 55;
            // 
            // datePicker1
            // 
            this.datePicker1.CustomFormat = "MMMM yyyy";
            this.datePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker1.Location = new System.Drawing.Point(77, 95);
            this.datePicker1.Name = "datePicker1";
            this.datePicker1.ShowUpDown = true;
            this.datePicker1.Size = new System.Drawing.Size(119, 20);
            this.datePicker1.TabIndex = 52;
            // 
            // cboBank
            // 
            this.cboBank.BackColor = System.Drawing.SystemColors.Window;
            this.cboBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBank.FormattingEnabled = true;
            this.cboBank.Location = new System.Drawing.Point(77, 68);
            this.cboBank.Name = "cboBank";
            this.cboBank.Size = new System.Drawing.Size(233, 21);
            this.cboBank.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(2, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Bank Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtObservation);
            this.groupBox1.Controls.Add(this.lblBAmount);
            this.groupBox1.Controls.Add(this.bkAmt);
            this.groupBox1.Controls.Add(this.btnsavepnl);
            this.groupBox1.Controls.Add(this.btnpnlcls);
            this.groupBox1.Controls.Add(label7);
            this.groupBox1.Controls.Add(this.lblCAmount);
            this.groupBox1.Controls.Add(this.tamount);
            this.groupBox1.Controls.Add(label4);
            this.groupBox1.Controls.Add(this.txtBref);
            this.groupBox1.Controls.Add(label3);
            this.groupBox1.Controls.Add(this.dtDiffDate);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 276);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Receipts on the bank statement, not in the accounts";
            // 
            // lblBAmount
            // 
            this.lblBAmount.AutoSize = true;
            this.lblBAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBAmount.Location = new System.Drawing.Point(148, 109);
            this.lblBAmount.Name = "lblBAmount";
            this.lblBAmount.Size = new System.Drawing.Size(82, 13);
            this.lblBAmount.TabIndex = 66;
            this.lblBAmount.Text = "Bank Amount";
            this.lblBAmount.Visible = false;
            // 
            // bkAmt
            // 
            this.bkAmt.DecimalPlaces = 2;
            this.bkAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bkAmt.Location = new System.Drawing.Point(148, 129);
            this.bkAmt.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.bkAmt.Name = "bkAmt";
            this.bkAmt.Size = new System.Drawing.Size(136, 20);
            this.bkAmt.TabIndex = 65;
            // 
            // btnsavepnl
            // 
            this.btnsavepnl.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnsavepnl.Location = new System.Drawing.Point(180, 219);
            this.btnsavepnl.Name = "btnsavepnl";
            this.btnsavepnl.Size = new System.Drawing.Size(46, 23);
            this.btnsavepnl.TabIndex = 63;
            this.btnsavepnl.Text = "";
            this.btnsavepnl.UseVisualStyleBackColor = true;
            this.btnsavepnl.Click += new System.EventHandler(this.btnsavepnl_Click);
            // 
            // btnpnlcls
            // 
            this.btnpnlcls.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnpnlcls.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnpnlcls.Location = new System.Drawing.Point(235, 219);
            this.btnpnlcls.Name = "btnpnlcls";
            this.btnpnlcls.Size = new System.Drawing.Size(49, 23);
            this.btnpnlcls.TabIndex = 64;
            this.btnpnlcls.Text = "";
            this.btnpnlcls.UseVisualStyleBackColor = true;
            this.btnpnlcls.Click += new System.EventHandler(this.btnpnlcls_Click);
            // 
            // tamount
            // 
            this.tamount.DecimalPlaces = 2;
            this.tamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tamount.Location = new System.Drawing.Point(11, 129);
            this.tamount.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.tamount.Name = "tamount";
            this.tamount.Size = new System.Drawing.Size(133, 20);
            this.tamount.TabIndex = 59;
            // 
            // txtBref
            // 
            this.txtBref.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBref.Location = new System.Drawing.Point(77, 77);
            this.txtBref.Name = "txtBref";
            this.txtBref.Size = new System.Drawing.Size(142, 20);
            this.txtBref.TabIndex = 57;
            // 
            // dtDiffDate
            // 
            this.dtDiffDate.CustomFormat = "dd MMMM yyyy";
            this.dtDiffDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDiffDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDiffDate.Location = new System.Drawing.Point(77, 51);
            this.dtDiffDate.Name = "dtDiffDate";
            this.dtDiffDate.Size = new System.Drawing.Size(142, 20);
            this.dtDiffDate.TabIndex = 55;
            // 
            // pnlRecBank
            // 
            this.pnlRecBank.Controls.Add(this.groupBox1);
            this.pnlRecBank.Location = new System.Drawing.Point(5, 85);
            this.pnlRecBank.Name = "pnlRecBank";
            this.pnlRecBank.Size = new System.Drawing.Size(320, 305);
            this.pnlRecBank.TabIndex = 9;
            this.pnlRecBank.Visible = false;
            // 
            // txtObservation
            // 
            this.txtObservation.BackColor = System.Drawing.SystemColors.Window;
            this.txtObservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservation.FormattingEnabled = true;
            this.txtObservation.Location = new System.Drawing.Point(10, 180);
            this.txtObservation.Name = "txtObservation";
            this.txtObservation.Size = new System.Drawing.Size(274, 21);
            this.txtObservation.TabIndex = 67;
            // 
            // rptBankReconciliation
            // 
            this.AcceptButton = this.btnShow;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.btnclose;
            this.ClientSize = new System.Drawing.Size(1219, 493);
            this.Controls.Add(this.pnlRecBank);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.dockPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "rptBankReconciliation";
            this.Text = "Bank Reconciliation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StockRptParm_FormClosing);
            this.Load += new System.EventHandler(this.StockRptParm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.dockPanel1_Container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankBlance)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bkAmt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamount)).EndInit();
            this.pnlRecBank.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label lblbrand;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private SergeUtils.EasyCompletionComboBox cboBank;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker datePicker1;
        private System.Windows.Forms.NumericUpDown txtBankBlance;
        private System.Windows.Forms.Button btnPayDiff;
        private System.Windows.Forms.Button btnRecDiff;
        private System.Windows.Forms.Button btnPayBank;
        private System.Windows.Forms.Button btnRecBank;
        private System.Windows.Forms.Button btnUpBankBlance;
        private System.Windows.Forms.Panel pnlRecBank;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnsavepnl;
        private System.Windows.Forms.Button btnpnlcls;
        private System.Windows.Forms.NumericUpDown tamount;
        private System.Windows.Forms.TextBox txtBref;
        private System.Windows.Forms.DateTimePicker dtDiffDate;
        private System.Windows.Forms.NumericUpDown bkAmt;
        private System.Windows.Forms.Label lblBAmount;
        private System.Windows.Forms.Label lblCAmount;
        private SergeUtils.EasyCompletionComboBox txtObservation;
    }
}