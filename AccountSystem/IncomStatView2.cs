using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace AccountSystem
{
    public partial class IncomStatView2 : Form
    {
        private MyModule Fn = new MyModule();

        public IncomStatView2()
        {
            InitializeComponent();
            if (defaultInstance == null)
                defaultInstance = this;
        }

        #region Default Instance

        private static IncomStatView2 defaultInstance;

        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static IncomStatView2 Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new IncomStatView2();
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
            // TODO: This line of code loads data into the 'CompanyLogo.TblCompany' table. You can move, or remove it, as needed.
            this.TblCompanyTableAdapter.Fill(this.CompanyLogo.TblCompany, MyModule.CompID);
            // TODO: This line of code loads data into the 'IncomStat.TblAccHead' table. You can move, or remove it, as needed.
            TextBox txtyear = new TextBox();
            Fn.GetNum(txtyear, "SELECT convert(varchar,AccYear) FROM tblMonthCloseing WHERE CompID =" + MyModule.CompID);
            string sYear = Convert.ToDateTime(txtyear.Text).ToString("MMMM yyyy");
            string eYear = Convert.ToDateTime(sYear).AddMonths(11).ToString("MMMM yyyy");
            this.TblAccHead1TableAdapter.Fill(this.IncomStat.TblAccHead1, MyModule.CompID, Fn.FirstDayOfMonthFromDateTime(Convert.ToDateTime(sYear)), Fn.LastDayOfMonthFromDateTime(Convert.ToDateTime(eYear)));

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
            string sYear = Convert.ToDateTime(dateTimePicker2.Text).ToString("MMMM yyyy");
            string eYear = Convert.ToDateTime(dateTimePicker1.Text).ToString("MMMM yyyy");
            this.TblAccHead1TableAdapter.Fill(this.IncomStat.TblAccHead1, MyModule.CompID, Fn.FirstDayOfMonthFromDateTime(Convert.ToDateTime(sYear)), Fn.LastDayOfMonthFromDateTime(Convert.ToDateTime(eYear)));

            TextBox txtbox = new TextBox();
            Fn.GetNum(txtbox, "SELECT Address+Char(13)+char(10)+Phone AS Expr1 FROM TblCompany Where CompanyID=" + MyModule.CompID);
            ReportParameter param1 = new ReportParameter();
            ReportParameter param = new ReportParameter();
            ReportParameter para = new ReportParameter();

            param1 = new ReportParameter("ReportParameter1", "From " + sYear + " to " + eYear, false);

            param = new ReportParameter("ReportParameter2", MyModule.CompName, false);
            para = new ReportParameter("ReportParameter3", txtbox.Text, false);
            try
            {
                this.reportViewer1.LocalReport.SetParameters(param1);
                this.reportViewer1.LocalReport.SetParameters(param);
                this.reportViewer1.LocalReport.SetParameters(para);

                this.reportViewer1.ShowExportButton = true; this.reportViewer1.RefreshReport();
            }
            catch
            { }
        }

        private void reportViewer1_Drillthrough(object sender, DrillthroughEventArgs e)
        {
            LocalReport localreport = (LocalReport)e.Report;
            ReportParameter param1 = new ReportParameter();

            string sYear = Convert.ToDateTime(dateTimePicker2.Text).ToString("MMMM yyyy");
            string eYear = Convert.ToDateTime(dateTimePicker1.Text).ToString("MMMM yyyy");
            param1 = new ReportParameter("ReportParameter1", "From " + sYear + " to " + eYear, false);
            e.Report.SetParameters(param1);
            this.DataTable1TableAdapter.Fill(this.CostGoods.DataTable1, Fn.FirstDayOfMonthFromDateTime(Convert.ToDateTime(sYear)), Fn.LastDayOfMonthFromDateTime(Convert.ToDateTime(eYear)), MyModule.CompID);

            ReportDataSource datasource = new ReportDataSource("DataSet1", CostGoods.Tables[0]);
            ReportDataSource datasource2 = new ReportDataSource("DataSet2", CompanyLogo.Tables[0]);
            localreport.DataSources.Add(datasource2);
            localreport.DataSources.Add(datasource);
        }
    }
}