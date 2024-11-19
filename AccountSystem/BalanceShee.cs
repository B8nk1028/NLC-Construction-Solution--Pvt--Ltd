using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace AccountSystem
{
    public partial class BalanceShee : Form
    {
        private MyModule Fn = new MyModule();

        public BalanceShee()
        {
            InitializeComponent();
            if (defaultInstance == null)
                defaultInstance = this;
        }

        #region Default Instance

        private static BalanceShee defaultInstance;

        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static BalanceShee Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new BalanceShee();
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

        private void IncomStatView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BalanceSheet.TblCompany' table. You can move, or remove it, as needed.
            this.TblCompanyTableAdapter.Fill(this.BalanceSheet.TblCompany, MyModule.CompID);
            // TODO: This line of code loads data into the 'IncomStat.TblAccHead' table. You can move, or remove it, as needed.
            TextBox txtyear = new TextBox();
            Fn.GetNum(txtyear, "SELECT convert(varchar,AccYear) FROM tblMonthCloseing WHERE CompID =" + MyModule.CompID);
            string sYear = Convert.ToDateTime(txtyear.Text).ToString("MMMM yyyy");
            string eYear = Convert.ToDateTime(sYear).AddMonths(11).ToString("MMMM yyyy");
            this.TblAccHeadTableAdapter.Fill(this.BalanceSheet.TblAccHead, MyModule.CompID, Fn.LastDayOfMonthFromDateTime(Convert.ToDateTime(eYear)));
            // TODO: This line of code loads data into the 'BalanceSheet.OpeningB' table. You can move, or remove it, as needed.
            TextBox txtbox = new TextBox();
            Fn.GetNum(txtbox, "SELECT Address+Char(13)+char(10)+Phone AS Expr1 FROM TblCompany Where CompanyID=" + MyModule.CompID);
            ReportParameter param1 = new ReportParameter();
            ReportParameter param = new ReportParameter();
            ReportParameter para = new ReportParameter();

            param1 = new ReportParameter("ReportParameter1", "Accounting Year from " + sYear + " to " + eYear, false);

            param = new ReportParameter("ReportParameter2", MyModule.CompName, false);
            para = new ReportParameter("ReportParameter3", txtbox.Text, false);
            this.reportViewer1.LocalReport.SetParameters(param1);
            this.reportViewer1.LocalReport.SetParameters(param);
            this.reportViewer1.LocalReport.SetParameters(para);

            this.reportViewer1.ShowExportButton = true; this.reportViewer1.RefreshReport();
            MyModule.rpt = reportViewer1;
            FrmMain.Default.grpExport.Visible = true;
        }

        private void IncomStatView_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMain.Default.grpExport.Visible = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            TextBox txtyear = new TextBox();
            Fn.GetNum(txtyear, "SELECT convert(varchar,AccYear) FROM tblMonthCloseing WHERE CompID =" + MyModule.CompID);
            //string sYear = Convert.ToDateTime(dateTimePicker2.Text).ToString("MMMM yyyy");
            //string sYear = Convert.ToDateTime(dateTimePicker2.Text).ToString("MMMM yyyy");
            string eYear = Convert.ToDateTime(dateTimePicker1.Text).ToString("MMMM yyyy");
            this.TblAccHeadTableAdapter.Fill(this.BalanceSheet.TblAccHead, MyModule.CompID, Fn.LastDayOfMonthFromDateTime(Convert.ToDateTime(eYear)));
            // TODO: This line of code loads data into the 'BalanceSheet.OpeningB' table. You can move, or remove it, as needed.

            TextBox txtbox = new TextBox();
            Fn.GetNum(txtbox, "SELECT Address+Char(13)+char(10)+Phone AS Expr1 FROM TblCompany Where CompanyID=" + MyModule.CompID);
            ReportParameter param1 = new ReportParameter();
            ReportParameter param = new ReportParameter();
            ReportParameter para = new ReportParameter();
            param1 = new ReportParameter("ReportParameter1", "Till Date : " + eYear, false);
            //param1 = new ReportParameter("ReportParameter1", "From " + sYear + " to " + eYear, false);

            param = new ReportParameter("ReportParameter2", MyModule.CompName, false);
            para = new ReportParameter("ReportParameter3", txtbox.Text, false);
            this.reportViewer1.LocalReport.SetParameters(param1);
            this.reportViewer1.LocalReport.SetParameters(param);
            this.reportViewer1.LocalReport.SetParameters(para);

            this.reportViewer1.ShowExportButton = true; this.reportViewer1.RefreshReport();
        }
    }
}