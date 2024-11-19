using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace AccountSystem
{
    public partial class frmJVReport : Form
    {
        public frmJVReport()
        {
            InitializeComponent();
            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }

        #region Default Instance

        private static frmJVReport defaultInstance;

        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static frmJVReport Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new frmJVReport();
                    defaultInstance.FormClosed += new FormClosedEventHandler(defaultInstance_FormClosed);
                }

                return defaultInstance;
            }
        }

        private static void defaultInstance_FormClosed(object sender, FormClosedEventArgs e)
        {
            defaultInstance = null;
        }

        #endregion Default Instance

        private void Form1_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'CompanyLogo.TblCompany' table. You can move, or remove it, as needed.
            //this.TblCompanyTableAdapter.Fill(this.CompanyLogo.TblCompany, MyModule.CompID);
            //// TODO: This line of code loads data into the 'JVDataSet.DataTable1' table. You can move, or remove it, as needed.
            //this.DataTable1TableAdapter.Fill(this.JVDataSet.DataTable1, MyModule.ParmD);
            //ReportParameter param2 = new ReportParameter();
            //param2 = new ReportParameter("ReportParameter2", MyModule.ParmB, false);
            //this.reportViewer1.LocalReport.SetParameters(param2);
            //ReportParameter param1 = new ReportParameter();
            //param1 = new ReportParameter("ReportParameter1", MyModule.ParmA, false);
            //this.reportViewer1.LocalReport.SetParameters(param1);
            //ReportParameter param3 = new ReportParameter();
            //param3 = new ReportParameter("ReportParameter3", MyModule.UserName, false);
            //this.reportViewer1.LocalReport.SetParameters(param3);
            //this.reportViewer1.ShowExportButton = true; this.reportViewer1.RefreshReport();
            //MyModule.rpt = reportViewer1;
            //FrmMain.Default.grpExport.Visible = true;
        }

        private void frmJVReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMain.Default.grpExport.Visible = false;
        }

        private void frmJVReport_Activated(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'CompanyLogo.TblCompany' table. You can move, or remove it, as needed.
            this.TblCompanyTableAdapter.Fill(this.CompanyLogo.TblCompany, MyModule.CompID);
            // TODO: This line of code loads data into the 'JVDataSet.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.JVDataSet.DataTable1, MyModule.ParmD);
            ReportParameter param2 = new ReportParameter();
            param2 = new ReportParameter("ReportParameter2", MyModule.ParmB, false);
            this.reportViewer1.LocalReport.SetParameters(param2);
            ReportParameter param1 = new ReportParameter();
            param1 = new ReportParameter("ReportParameter1", MyModule.ParmA, false);
            this.reportViewer1.LocalReport.SetParameters(param1);
            ReportParameter param3 = new ReportParameter();
            param3 = new ReportParameter("ReportParameter3", MyModule.UserName, false);
            this.reportViewer1.LocalReport.SetParameters(param3);
            this.reportViewer1.ShowExportButton = true; this.reportViewer1.RefreshReport();
            MyModule.rpt = reportViewer1;
            FrmMain.Default.grpExport.Visible = true;
        }
    }
}