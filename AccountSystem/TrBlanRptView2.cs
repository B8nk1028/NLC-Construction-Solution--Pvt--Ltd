using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace AccountSystem
{
    public partial class TrBlanRptView2 : Form
    {
        private Words Wrd = new Words();
        private MyModule Fn = new MyModule();
        private ReportParameter param1 = new ReportParameter();
        private ReportParameter param = new ReportParameter();
        private ReportParameter para = new ReportParameter();
        private ReportParameter TogBtn = new ReportParameter();

        public TrBlanRptView2()
        {
            InitializeComponent();

            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }

        #region Default Instance

        private static TrBlanRptView2 defaultInstance;

        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static TrBlanRptView2 Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new TrBlanRptView2();
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

        private void TrBlanRptView_Load(object sender, EventArgs e)
        {

        }

        private void TrBlanRptView_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MyModule.ParmA = "";
            FrmMain.Default.grpExport.Visible = false;
        }

        private void reportViewer1_Drillthrough(object sender, DrillthroughEventArgs e)
        {
            ReportParameterInfoCollection DrillThroughValues = e.Report.GetParameters();
            LocalReport localreport = (LocalReport)e.Report;
            if (DrillThroughValues.Count == 5)
            {
                Fn.Exec("DELETE FROM LadgerView; INSERT INTO LadgerView  (edate, VNo, Des, Dr, Cr, Totals,VID,AccID) SELECT  " +
                    " TblVoucherHDR.EntryDate, TblVoucherHDR.VoucherNo, TblVoucherDTL.Description + Case When IsNull(TblVoucherHDR.CheqNo,'') " +
                    "= '' Then '' Else '  Cheque No: ' + TblVoucherHDR.CheqNo End+Case When IsNull(TblVoucherHDR.DrawingDate,'') = '' Then '' Else '  " +
                    "Drawing Date: ' + convert(varchar,TblVoucherHDR.DrawingDate,9)End AS Expr1, TblVoucherDTL.AmountDeb, TblVoucherDTL.AmountCre, " +
                    "TblVoucherDTL.AmountDeb - TblVoucherDTL.AmountCre AS totals,TblVoucherHDR.VoucherID,TblVoucherDTL.AccEntryID FROM TblVoucherDTL INNER JOIN TblVoucherHDR " +
                    "ON TblVoucherDTL.VoucherID = TblVoucherHDR.VoucherID WHERE (TblVoucherHDR.EntryDate BETWEEN CONVERT(DATETIME, '" + MyModule.Parm1 + "' , 102) " +
                    "AND CONVERT(DATETIME, '" + MyModule.Parm2 + "', 102)) AND   (TblVoucherDTL.AccEntryID =" + Convert.ToInt32(DrillThroughValues[4].Values[0].ToString()) + "); " +
                    "INSERT INTO LadgerView  (edate, VNo, Des, Dr, Cr, Totals,VID,AccID) SELECT '1-1-1900' AS edate, '' AS vochNo, 'Openning Balance' AS Des, " +
                    "SUM(TblVoucherDTL.AmountDeb) AS Dr, SUM(TblVoucherDTL.AmountCre) AS Cr,   SUM(TblVoucherDTL.AmountDeb - TblVoucherDTL.AmountCre) AS " +
                    "totals,'0' as VoucherI,TblVoucherDTL.AccEntryID FROM TblVoucherDTL INNER JOIN  TblVoucherHDR ON TblVoucherDTL.VoucherID = TblVoucherHDR.VoucherID WHERE " +
                    "(TblVoucherDTL.AccEntryID =" + Convert.ToInt32(DrillThroughValues[4].Values[0].ToString()) + ") AND (TblVoucherHDR.EntryDate < " +
                    "CONVERT(DATETIME, '" + MyModule.Parm1 + "', 102)) GROUP BY TblVoucherDTL.AccEntryID");
                e.Report.SetParameters(param1);
                e.Report.SetParameters(param);
                e.Report.SetParameters(para);
                // TODO: This line of code loads data into the 'LadgerDataSet.DataTable1' table. You can move, or remove it, as needed.
                ReportParameter par = new ReportParameter();
                par = new ReportParameter("ReportParameter4", DrillThroughValues[3].Values[0].ToString(), false);
                e.Report.SetParameters(par);
                this.DataTable1TableAdapter.Fill(this.LadgerDataSet.DataTable1);

                ReportDataSource datasource = new ReportDataSource("DataSet1", LadgerDataSet.Tables[0]);
                localreport.DataSources.Add(datasource);
                ReportDataSource datasource2 = new ReportDataSource("DataSet2", CompanyLogo.Tables[0]);
                localreport.DataSources.Add(datasource2);
            }
            else
            {
                ReportParameter prm = new ReportParameter();
                prm = new ReportParameter("ReportParameter1", Wrd.changeCurrencyToWords(Fn.GetRecords("SELECT SUM(AmountDeb) AS Expr1 FROM VW_VoucherDTL WHERE (VoucherID = '" + DrillThroughValues[2].Values[0].ToString() + "')")[0]), false);
                e.Report.SetParameters(prm);
                this.dataTable1TableAdapter1.Fill(this.JVDataSet.DataTable1,DrillThroughValues[2].Values[0].ToString());

                ReportDataSource datasource = new ReportDataSource("DataSet2", JVDataSet.Tables[0]);
                ReportDataSource datasource2 = new ReportDataSource("DataSet1", CompanyLogo.Tables[0]);
                localreport.DataSources.Add(datasource2);
                localreport.DataSources.Add(datasource);
            }

            localreport.Refresh();
        }

        private void btnTogl_Click(object sender, EventArgs e)
        {
            if ((string)btnTogl.Tag == "false")
            {
                TogBtn = new ReportParameter("ReportParameter4", "True", false);
                btnTogl.Tag = "True";
                btnTogl.Image = global::AccountSystem.Properties.Resources.iw_minus;
            }
            else
            {
                TogBtn = new ReportParameter("ReportParameter4", "false", false);
                btnTogl.Tag = "false";
                btnTogl.Image = global::AccountSystem.Properties.Resources.iw_plus;
            }
            this.reportViewer1.LocalReport.SetParameters(TogBtn);
            reportViewer1.RefreshReport();
        }

        private void TrBlanRptView2_Activated(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'CompanyLogo.TblCompany' table. You can move, or remove it, as needed.
            this.TblCompanyTableAdapter.Fill(this.CompanyLogo.TblCompany, MyModule.CompID);
            // TODO: This line of code loads data into the 'TriBalanceDS.TriBalance' table. You can move, or remove it, as needed.
            this.TriBalanceTableAdapter.Fill(this.TriBalanceDS.TriBalance);

            TextBox txtbox = new TextBox();
            Fn.GetNum(txtbox, "SELECT Address+Char(13)+char(10)+Phone AS Expr1 FROM TblCompany Where CompanyID=" + MyModule.CompID);
            TogBtn = new ReportParameter("ReportParameter4", "false", false);
            param1 = new ReportParameter("ReportParameter1", MyModule.ParmA, false);
            param = new ReportParameter("ReportParameter2", MyModule.CompName, false);
            para = new ReportParameter("ReportParameter3", txtbox.Text, false);
            this.reportViewer1.LocalReport.SetParameters(param1);
            this.reportViewer1.LocalReport.SetParameters(param);
            this.reportViewer1.LocalReport.SetParameters(para);
            this.reportViewer1.LocalReport.SetParameters(TogBtn);

            this.reportViewer1.ShowExportButton = true; this.reportViewer1.RefreshReport();
            MyModule.rpt = reportViewer1;
            FrmMain.Default.grpExport.Visible = true;
        }
    }
}