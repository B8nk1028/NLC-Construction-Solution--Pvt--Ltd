using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace AccountSystem
{
    public partial class GLadgerRpt : Form
    {
        private Words Wrd = new Words();
        private MyModule Fn = new MyModule();

        public GLadgerRpt()
        {
            InitializeComponent();
            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }

        #region Default Instance

        private static GLadgerRpt defaultInstance;

        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static GLadgerRpt Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new GLadgerRpt();
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

        private void LadgerRpt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'CompanyLogo.TblCompany' table. You can move, or remove it, as needed.
            this.TblCompanyTableAdapter.Fill(this.CompanyLogo.TblCompany, MyModule.CompID);
            // TODO: This line of code loads data into the 'LadgerDataSet.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.LadgerDataSet.DataTable1);
            TextBox txtbox = new TextBox();
            Fn.GetNum(txtbox, "SELECT Address+Char(13)+char(10)+Phone AS Expr1 FROM TblCompany Where CompanyID=" + MyModule.CompID);
            ReportParameter param1 = new ReportParameter();
            ReportParameter param = new ReportParameter();
            ReportParameter para = new ReportParameter();
            ReportParameter par = new ReportParameter();
            param1 = new ReportParameter("ReportParameter1", MyModule.ParmA, false);
            par = new ReportParameter("ReportParameter4", MyModule.ParmB, false);
            param = new ReportParameter("ReportParameter2", MyModule.CompName, false);
            para = new ReportParameter("ReportParameter3", txtbox.Text, false);
            this.reportViewer1.LocalReport.SetParameters(param1);
            this.reportViewer1.LocalReport.SetParameters(param);
            this.reportViewer1.LocalReport.SetParameters(para);
            this.reportViewer1.LocalReport.SetParameters(par);
            this.reportViewer1.ShowExportButton = true; this.reportViewer1.RefreshReport();
            MyModule.rpt = reportViewer1;
            FrmMain.Default.grpExport.Visible = true;
        }

        private void LadgerRpt_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMain.Default.grpExport.Visible = false;
        }

        private void reportViewer1_Drillthrough(object sender, DrillthroughEventArgs e)
        {
            //string VId=null;
            ReportParameterInfoCollection DrillThroughValues = e.Report.GetParameters();
            //foreach (ReportParameterInfo d in DrillThroughValues)
            //{
            //    VId=(d.Values[0].ToString().Trim());
            //}

            ReportParameter param1 = new ReportParameter();
            param1 = new ReportParameter("ReportParameter1", Wrd.changeCurrencyToWords(Fn.GetRecords("SELECT SUM(AmountDeb) AS Expr1 FROM VW_VoucherDTL WHERE (VoucherID = '" + DrillThroughValues[2].Values[0].ToString() + "')")[0]), false);
            e.Report.SetParameters(param1);
            this.dataTable1TableAdapter1.Fill(this.JVDataSet.DataTable1, DrillThroughValues[2].Values[0].ToString());
            LocalReport localreport = (LocalReport)e.Report;
            ReportDataSource datasource = new ReportDataSource("DataSet2", JVDataSet.Tables[0]);
            ReportDataSource datasource2 = new ReportDataSource("DataSet1", CompanyLogo.Tables[0]);
            localreport.DataSources.Add(datasource);
            localreport.DataSources.Add(datasource2);
            localreport.Refresh();
        }
    }
}