using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;

using System.Linq;
using System;
using System.Collections;
using System.Xml.Linq;
using System.Windows.Forms;

namespace AccountSystem
{
    
    public partial class frmPrintBill : DevExpress.XtraEditors.XtraForm
		{
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
			{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

        //Required by the Windows Form Designer
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
			{
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DataTable11BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Sale_Invioce = new AccountSystem.Sale_Invioce();
            this.TblCompanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CompanyLogo = new AccountSystem.CompanyLogo();
            this.SimpleButton8 = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfrm = new System.Windows.Forms.TextBox();
            this.txtto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTable11TableAdapter = new AccountSystem.Sale_InvioceTableAdapters.DataTable11TableAdapter();
            this.TblCompanyTableAdapter = new AccountSystem.CompanyLogoTableAdapters.TblCompanyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable11BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sale_Invioce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblCompanyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataTable11BindingSource
            // 
            this.DataTable11BindingSource.DataMember = "DataTable11";
            this.DataTable11BindingSource.DataSource = this.Sale_Invioce;
            // 
            // Sale_Invioce
            // 
            this.Sale_Invioce.DataSetName = "Sale_Invioce";
            this.Sale_Invioce.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // SimpleButton8
            // 
            this.SimpleButton8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpleButton8.Appearance.ForeColor = System.Drawing.Color.Green;
            this.SimpleButton8.Appearance.Options.UseFont = true;
            this.SimpleButton8.Appearance.Options.UseForeColor = true;
            this.SimpleButton8.Location = new System.Drawing.Point(208, 44);
            this.SimpleButton8.LookAndFeel.UseDefaultLookAndFeel = false;
            this.SimpleButton8.Name = "SimpleButton8";
            this.SimpleButton8.Size = new System.Drawing.Size(84, 24);
            this.SimpleButton8.TabIndex = 6;
            this.SimpleButton8.Text = "&Close";
            this.SimpleButton8.Click += new System.EventHandler(this.SimpleButton8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Print Bills from ";
            // 
            // txtfrm
            // 
            this.txtfrm.Location = new System.Drawing.Point(97, 7);
            this.txtfrm.Name = "txtfrm";
            this.txtfrm.Size = new System.Drawing.Size(82, 21);
            this.txtfrm.TabIndex = 8;
            this.txtfrm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfrm_KeyPress);
            // 
            // txtto
            // 
            this.txtto.Location = new System.Drawing.Point(208, 7);
            this.txtto.Name = "txtto";
            this.txtto.Size = new System.Drawing.Size(82, 21);
            this.txtto.TabIndex = 9;
            this.txtto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfrm_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "to";
            // 
            // btnPrint
            // 
            this.btnPrint.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Appearance.ForeColor = System.Drawing.Color.Green;
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.Appearance.Options.UseForeColor = true;
            this.btnPrint.Location = new System.Drawing.Point(118, 44);
            this.btnPrint.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(84, 24);
            this.btnPrint.TabIndex = 11;
            this.btnPrint.Text = "&Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.SimpleButton8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtfrm);
            this.panel1.Controls.Add(this.txtto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 76);
            this.panel1.TabIndex = 12;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.DataTable11BindingSource;
            reportDataSource4.Name = "DataSet2";
            reportDataSource4.Value = this.TblCompanyBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AccountSystem.PrintBills.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 76);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1022, 433);
            this.reportViewer1.TabIndex = 13;
            // 
            // DataTable11TableAdapter
            // 
            this.DataTable11TableAdapter.ClearBeforeFill = true;
            // 
            // TblCompanyTableAdapter
            // 
            this.TblCompanyTableAdapter.ClearBeforeFill = true;
            // 
            // frmPrintBill
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 509);
            this.ControlBox = false;
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.SkinName = "Black";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmPrintBill";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Bills";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.About_FormClosing);
            this.Load += new System.EventHandler(this.frmPrintBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable11BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sale_Invioce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblCompanyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

            }

        internal DevExpress.XtraEditors.SimpleButton SimpleButton8;
        private Label label1;
        private TextBox txtfrm;
        private TextBox txtto;
        private Label label2;
        internal DevExpress.XtraEditors.SimpleButton btnPrint;
        private Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.ComponentModel.IContainer components;
        private BindingSource DataTable11BindingSource;
        private Sale_Invioce Sale_Invioce;
        private BindingSource TblCompanyBindingSource;
        private CompanyLogo CompanyLogo;
        private Sale_InvioceTableAdapters.DataTable11TableAdapter DataTable11TableAdapter;
        private CompanyLogoTableAdapters.TblCompanyTableAdapter TblCompanyTableAdapter;
	}
	
}
