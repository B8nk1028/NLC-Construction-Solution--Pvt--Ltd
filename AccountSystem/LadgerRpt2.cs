using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;

namespace AccountSystem
{
    public partial class LadgerRpt2 : Form
    {
        private Words Wrd = new Words();
        private MyModule Fn = new MyModule();

        public LadgerRpt2()
        {
            InitializeComponent();
            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }

        #region Default Instance

        private static LadgerRpt2 defaultInstance;

        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static LadgerRpt2 Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new LadgerRpt2();
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
            FrmMain.Default.grpExportInv.Visible = true;

        }

        private void LadgerRpt_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMain.Default.grpExport.Visible = false;
            FrmMain.Default.grpExportInv.Visible = false;
        }

        private void reportViewer1_Drillthrough(object sender, DrillthroughEventArgs e)
        {
            //string VId=null;
            LocalReport localreport = (LocalReport)e.Report;
            ReportParameterInfoCollection DrillThroughValues = e.Report.GetParameters();
            if (DrillThroughValues.Count == 6)
            {
                //ReportParameter param2 = new ReportParameter();
                //if (DrillThroughValues[0].Values[0].ToString().IndexOf("Sale") != -1)
                //{
                //    param2 = new ReportParameter("ReportParameter2", "Sale", false);
                //}
                //else
                //{
                //    param2 = new ReportParameter("ReportParameter2", "Purchase", false);
                //}
                //e.Report.SetParameters(param2);
                //string[] words = DrillThroughValues[0].Values[0].ToString().Split(' ');
                //string bill = words[0] + " " + words[1];
                this.duplicateGRNTableAdapter.Fill(this.Pur_SalDS.DuplicateGRN, DrillThroughValues[2].Values[0].ToString());

                ReportDataSource datasource = new ReportDataSource("DataSet1", Pur_SalDS.Tables[1]);
                ReportDataSource datasource2 = new ReportDataSource("DataSet2", CompanyLogo.Tables[0]);
                localreport.DataSources.Add(datasource2);
                localreport.DataSources.Add(datasource);
            }
            else
            {
                ReportParameter param1 = new ReportParameter();
                param1 = new ReportParameter("ReportParameter1", Wrd.changeCurrencyToWords(Fn.GetRecords("SELECT SUM(AmountDeb) AS Expr1 FROM VW_VoucherDTL WHERE (VoucherID = '" + DrillThroughValues[2].Values[0].ToString() + "')")[0]), false);
                e.Report.SetParameters(param1);
                this.dataTable1TableAdapter1.Fill(this.JVDataSet.DataTable1, DrillThroughValues[2].Values[0].ToString());

                ReportDataSource datasource = new ReportDataSource("DataSet2", JVDataSet.Tables[0]);
                ReportDataSource datasource2 = new ReportDataSource("DataSet1", CompanyLogo.Tables[0]);
                localreport.DataSources.Add(datasource);
                localreport.DataSources.Add(datasource2);
            }
            localreport.Refresh();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                Fn.Exec("DELETE FROM LadgerView; INSERT INTO LadgerView  (edate, VNo, Des, Dr, Cr, Totals,VID,AccID,Product,Qty,Rate,Disct,Typ) SELECT VW_VoucherHDR.EntryDate, VW_VoucherHDR.VoucherNo, VW_VoucherDTL.Descripation AS Expr1, VW_VoucherDTL.AmountDeb, VW_VoucherDTL.AmountCre, VW_VoucherDTL.AmountDeb - VW_VoucherDTL.AmountCre AS totals, VW_VoucherHDR.VoucherID, VW_VoucherDTL.AccEntryID, VWGoodsSalesPurchase.Prod_name, VWGoodsSalesPurchase.prod_qty, VWGoodsSalesPurchase.Prod_rate, VWGoodsSalesPurchase.Disct, TblAccHead.AccType FROM VWGoodsSalesPurchase RIGHT OUTER JOIN VW_VoucherDTL INNER JOIN VW_VoucherHDR ON VW_VoucherDTL.VoucherID = VW_VoucherHDR.VoucherID INNER JOIN TblAccSubHead INNER JOIN TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID INNER JOIN TblAccHead ON TblAccSubHead.AccHeadID = TblAccHead.AccHeadID ON VW_VoucherDTL.AccEntryID = TblAccEntry.EntryAccID ON VWGoodsSalesPurchase.BranchID = VW_VoucherHDR.BranchID AND VWGoodsSalesPurchase.sr = VW_VoucherDTL.Descripation AND VWGoodsSalesPurchase.Contact_id = VW_VoucherDTL.AccEntryID WHERE (CONVERT(DATE, VW_VoucherHDR.EntryDate) BETWEEN CONVERT(DATE, '" + LedgerReport.Default.datePicker1.Text + "', 102) AND CONVERT(DATE, '" + LedgerReport.Default.datePicker2.Text + "', 102)) AND (VW_VoucherDTL.AccEntryID IN (" + LedgerReport.Default.Legders.Substring(1) + ")) AND (CONVERT(varchar, VW_VoucherHDR.BranchID) LIKE '" + LedgerReport.Default.cbLocation.SelectedValue + "') UNION SELECT '1-1-1900' AS edate, '' AS vochNo, 'Openning Balance' AS Des, 0 AS Dr, 0 AS Cr, SUM(VW_VoucherDTL.AmountDeb - VW_VoucherDTL.AmountCre) AS totals, '0' AS VoucherI, VW_VoucherDTL.AccEntryID, NULL AS Expr1, NULL AS Expr2, NULL AS Expr3, NULL AS Expr4, TblAccHead.AccType FROM TblAccSubHead INNER JOIN TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID INNER JOIN TblAccHead ON TblAccSubHead.AccHeadID = TblAccHead.AccHeadID INNER JOIN VW_VoucherDTL INNER JOIN VW_VoucherHDR ON VW_VoucherDTL.VoucherID = VW_VoucherHDR.VoucherID ON TblAccEntry.EntryAccID = VW_VoucherDTL.AccEntryID WHERE (VW_VoucherDTL.AccEntryID IN (" + LedgerReport.Default.Legders.Substring(1) + ")) AND (CONVERT(DATE, VW_VoucherHDR.EntryDate) < CONVERT(DATE, '" + LedgerReport.Default.datePicker1.Text + "', 102)) AND (CONVERT(varchar, VW_VoucherHDR.BranchID) LIKE '" + LedgerReport.Default.cbLocation.SelectedValue + "') GROUP BY VW_VoucherDTL.AccEntryID, TblAccHead.AccType");
                this.DataTable1TableAdapter.Fill(this.LadgerDataSet.DataTable1);
                this.reportViewer1.ShowExportButton = true; this.reportViewer1.RefreshReport();
            }
            catch
            {

            }

        }

        private void LadgerRpt_Activated(object sender, EventArgs e)
        {

        }
    }
}