using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
namespace AccountSystem
{
    public partial class rptIncomeStatement : Form
    {
        private MyModule Fn = new MyModule(); private Words Wrd = new Words();
        //private ReportParameter param1 = new ReportParameter();
        //private ReportParameter param2 = new ReportParameter();
        string companyaddress;
        public rptIncomeStatement()
        {
            InitializeComponent();
            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }
        #region Default Instance
        private static rptIncomeStatement defaultInstance;
        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static rptIncomeStatement Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new rptIncomeStatement();
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
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.DataSources.Clear();
            string[] DSet = { "DataSet1", "DataSet2" };
            string[] SQL = { "sp_IncomStatment '" + cbLocation.SelectedValue + "','" + datePicker1.Text + "','" + datePicker2.Text + "'", "SELECT CompanyID, Logo FROM TblCompany WHERE (CompanyID = 1)" };
            DataTable dt = new DataTable();
            for (int i = 0; i < DSet.Length; i++)
            {
                dt = Fn.FillDSet(SQL[i]).Tables[0];
                ReportDataSource datasource = new ReportDataSource(DSet[i], dt);
                this.reportViewer1.LocalReport.DataSources.Add(datasource);
            }
            companyaddress = Fn.GetRecords("SELECT Address+Char(13)+char(10)+Phone AS Expr1 FROM TblCompany Where CompanyID=" + MyModule.CompID)[0];
            List<ReportParameter> paraList = new List<ReportParameter>
            {
                new ReportParameter("ReportParameter1", " " + datePicker1.Text + " to " + datePicker2.Text,false),
                new ReportParameter("ReportParameter2", MyModule.CompName, false),
                new ReportParameter("ReportParameter3", companyaddress, false)
            };
            // Pass Parameters for Local Report
            this.reportViewer1.LocalReport.SetParameters(paraList.ToArray());

            this.reportViewer1.ShowExportButton = true; this.reportViewer1.RefreshReport();
            MyModule.rpt = reportViewer1;
            FrmMain.Default.grpExport.Visible = true;
        }
        private void StockRptParm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMain.Default.grpExport.Visible = false;
            FrmMain.Default.grpExportInv.Visible = false;
        }
        private void StockRptParm2_Load(object sender, EventArgs e)
        {
            Fn.fillCombo(cbLocation, "select '%','ALL' union SELECT convert(varchar,EntryAccID), EntryAccName FROM TblAccEntry WHERE (AccType IN (22, 23))");
            string[] opnset = Fn.GetRecords("SELECT CodeSt,AccYear FROM tblMonthCloseing WHERE (CompID =" + MyModule.CompID + ")");
            datePicker1.Value = Convert.ToDateTime(opnset[1]);

            this.TblCompanyTableAdapter.Fill(this.CompanyLogo.TblCompany, 1);
        }
        private void reportViewer1_Drillthrough(object sender, DrillthroughEventArgs e)
        {
            ReportParameterInfoCollection DrillThroughValues = e.Report.GetParameters();
            LocalReport localreport = (LocalReport)e.Report;
            if (DrillThroughValues.Count == 5)
            {
                string AccID = (DrillThroughValues[4].Values[0] == "5574" ? "in(5574,11936)" : "=" + DrillThroughValues[4].Values[0]);
 DataTable lgDS = Fn.FillDSet("SELECT EntryDate AS edate, VoucherNo AS VNo, Descripation AS Des, AmountDeb AS Dr, AmountCre AS Cr, totals AS Totals, '" + DrillThroughValues[3].Values[0] + "' AS AccName, VoucherID AS VID,'c' Typ, 0 AS AccID, SDr, SCr,0 vnum FROM (SELECT VW_VoucherHDR.EntryDate, VW_VoucherHDR.VoucherNo, VW_VoucherDTL_2.Descripation, VW_VoucherDTL_2.AmountDeb, VW_VoucherDTL_2.AmountCre, VW_VoucherDTL_2.AmountDeb - VW_VoucherDTL_2.AmountCre AS totals, VW_VoucherHDR.VoucherID, VW_VoucherDTL_2.AccEntryID, 0 AS SDr, 0 AS SCr FROM VW_VoucherDTL AS VW_VoucherDTL_2 INNER JOIN VW_VoucherHDR ON VW_VoucherDTL_2.VoucherID = VW_VoucherHDR.VoucherID WHERE (VW_VoucherHDR.EntryDate BETWEEN CONVERT(DATETIME, '" + datePicker1.Text + "', 102) AND CONVERT(DATETIME, '" + datePicker2.Text + "', 102)) AND (VW_VoucherDTL_2.AccEntryID " + AccID + ") AND (CONVERT(varchar, VW_VoucherHDR.BranchID) LIKE '" + cbLocation.SelectedValue + "') UNION SELECT '1-1-1900' AS edate, '' AS vochNo, 'Openning Balance' AS Des, 0 AS Dr, 0 AS Cr, SUM(VW_VoucherDTL_1.AmountDeb - VW_VoucherDTL_1.AmountCre) AS totals, '0' AS VoucherI, 0 AccEntryID, 0 AS Expr1, 0 AS Expr2 FROM VW_VoucherDTL AS VW_VoucherDTL_1 INNER JOIN VW_VoucherHDR AS VW_VoucherHDR_2 ON VW_VoucherDTL_1.VoucherID = VW_VoucherHDR_2.VoucherID WHERE (VW_VoucherDTL_1.AccEntryID " + AccID + ") AND (VW_VoucherHDR_2.EntryDate < CONVERT(DATETIME, '" + datePicker1.Text + "', 102)) AND (CONVERT(varchar, VW_VoucherHDR_2.BranchID) LIKE '" + cbLocation.SelectedValue + "') UNION SELECT VW_VoucherHDR_1.EntryDate, VW_VoucherHDR_1.VoucherNo, VW_VoucherDTL.Descripation, VW_VoucherDTL.AmountDeb, VW_VoucherDTL.AmountCre, VW_VoucherDTL.AmountDeb - VW_VoucherDTL.AmountCre AS totals, VW_VoucherHDR_1.VoucherID, VW_VoucherDTL.AccEntryID, VW_VoucherDTL.Expr1, VW_VoucherDTL.Expr2 FROM (SELECT 'S' + CONVERT(varchar, tbl_Sale.Sale_id) AS VoucherID, 1 AS AccEntryID, CASE WHEN InvoiceType = 1 THEN 'Sale Invoice : ' ELSE 'Sale Retrun : ' END + tbl_Sale.Sale_bill_no AS Descripation, SUM(CASE WHEN InvoiceType = 1 THEN tbl_SaleDetail.prod_qty * tbl_SaleDetail.PRate ELSE 0 END) AS AmountDeb, SUM(CASE WHEN InvoiceType = 1 THEN 0 ELSE tbl_SaleDetail.prod_qty * tbl_SaleDetail.PRate END) AS AmountCre, SUM(CASE WHEN InvoiceType = 1 THEN (tbl_SaleDetail.prod_qty * tbl_SaleDetail.Prod_rate)-tax ELSE 0 END) AS Expr1, SUM(CASE WHEN InvoiceType = 1 THEN 0 ELSE (tbl_SaleDetail.prod_qty * tbl_SaleDetail.Prod_rate) - tax END) AS Expr2 FROM tbl_Sale INNER JOIN tbl_SaleDetail ON tbl_Sale.Sale_id = tbl_SaleDetail.Sale_id GROUP BY 'S' + CONVERT(varchar, tbl_Sale.Sale_id), CASE WHEN InvoiceType = 1 THEN 'Sale Invoice : ' ELSE 'Sale Retrun : ' END + tbl_Sale.Sale_bill_no) AS VW_VoucherDTL INNER JOIN VW_VoucherHDR AS VW_VoucherHDR_1 ON VW_VoucherDTL.VoucherID = VW_VoucherHDR_1.VoucherID WHERE (VW_VoucherHDR_1.EntryDate BETWEEN CONVERT(DATETIME, '" + datePicker1.Text + "', 102) AND CONVERT(DATETIME, '" + datePicker2.Text + "', 102)) AND (CONVERT(varchar, VW_VoucherHDR_1.BranchID) LIKE '" + cbLocation.SelectedValue + "') AND (VW_VoucherDTL.AccEntryID " + AccID + ")) AStb").Tables[0];

                //DataTable lgDS = Fn.FillDSet("SELECT EntryDate edate, VoucherNo VNo, Descripation Des, AmountDeb Dr, AmountCre Cr, totals Totals, '"+ DrillThroughValues[3].Values[0] + "' AS AccName, VoucherID VID,'c' Typ from( SELECT VW_VoucherHDR.EntryDate, VW_VoucherHDR.VoucherNo, VW_VoucherDTL.Descripation, VW_VoucherDTL.AmountDeb, VW_VoucherDTL.AmountCre, VW_VoucherDTL.AmountDeb - VW_VoucherDTL.AmountCre AS totals,VW_VoucherHDR.VoucherID,VW_VoucherDTL.AccEntryID FROM VW_VoucherDTL INNER JOIN VW_VoucherHDR ON VW_VoucherDTL.VoucherID = VW_VoucherHDR.VoucherID WHERE (VW_VoucherHDR.EntryDate BETWEEN CONVERT(DATETIME, '" + datePicker1.Text + "' , 102) AND CONVERT(DATETIME, '" + datePicker2.Text + "', 102)) AND (VW_VoucherDTL.AccEntryID =" + DrillThroughValues[4].Values[0]+ ") AND (CONVERT(varchar, VW_VoucherHDR.BranchID) LIKE '"+ cbLocation.SelectedValue + "') union SELECT '1-1-1900' AS edate, '' AS vochNo, 'Openning Balance' AS Des, 0 AS Dr, 0 AS Cr, SUM(VW_VoucherDTL.AmountDeb - VW_VoucherDTL.AmountCre) AS totals,'0' as VoucherI,VW_VoucherDTL.AccEntryID FROM VW_VoucherDTL INNER JOIN VW_VoucherHDR ON VW_VoucherDTL.VoucherID = VW_VoucherHDR.VoucherID WHERE(VW_VoucherDTL.AccEntryID = " + DrillThroughValues[4].Values[0] + ") AND(VW_VoucherHDR.EntryDate < CONVERT(DATETIME, '" + datePicker1.Text + "', 102)) AND (CONVERT(varchar, VW_VoucherHDR.BranchID) LIKE '"+ cbLocation.SelectedValue + "') GROUP BY VW_VoucherDTL.AccEntryID UNION SELECT VW_VoucherHDR.EntryDate, VW_VoucherHDR.VoucherNo, VW_VoucherDTL.Descripation, VW_VoucherDTL.AmountDeb, VW_VoucherDTL.AmountCre, VW_VoucherDTL.AmountDeb - VW_VoucherDTL.AmountCre AS totals, VW_VoucherHDR.VoucherID, VW_VoucherDTL.AccEntryID FROM (SELECT 'S' + CONVERT(varchar, tbl_Sale.Sale_id) AS VoucherID, 1 AS AccEntryID, CASE WHEN InvoiceType = 1 THEN 'Sale Invoice : ' ELSE 'Sale Retrun : ' END + tbl_Sale.Sale_bill_no AS Descripation, SUM(CASE WHEN InvoiceType = 1 THEN tbl_SaleDetail.prod_qty * tbl_SaleDetail.PRate ELSE 0 END) AS AmountDeb, SUM(CASE WHEN InvoiceType = 1 THEN 0 ELSE tbl_SaleDetail.prod_qty * tbl_SaleDetail.PRate END) AS AmountCre FROM tbl_Sale INNER JOIN tbl_SaleDetail ON tbl_Sale.Sale_id = tbl_SaleDetail.Sale_id GROUP BY 'S' + CONVERT(varchar, tbl_Sale.Sale_id), CASE WHEN InvoiceType = 1 THEN 'Sale Invoice : ' ELSE 'Sale Retrun : ' END + tbl_Sale.Sale_bill_no) VW_VoucherDTL INNER JOIN VW_VoucherHDR ON VW_VoucherDTL.VoucherID = VW_VoucherHDR.VoucherID WHERE (VW_VoucherHDR.EntryDate BETWEEN CONVERT(DATETIME, '" + datePicker1.Text + "', 102) AND CONVERT(DATETIME, '" + datePicker2.Text + "', 102)) AND (CONVERT(varchar, VW_VoucherHDR.BranchID) LIKE '" + cbLocation.SelectedValue + "') and (VW_VoucherDTL.AccEntryID = " + DrillThroughValues[4].Values[0] + "))tb").Tables[0];


                List<ReportParameter> paraList = new List<ReportParameter>
            {
                new ReportParameter("ReportParameter1", " " + datePicker1.Text + " to " + datePicker2.Text,false),
                new ReportParameter("ReportParameter2", MyModule.CompName, false),
                new ReportParameter("ReportParameter3", companyaddress, false)
            };
                // Pass Parameters for Local Report
                e.Report.SetParameters(paraList.ToArray());
                // TODO: This line of code loads data into the 'LadgerDataSet.DataTable1' table. You can move, or remove it, as needed.
                ReportParameter par = new ReportParameter();
                par = new ReportParameter("ReportParameter4", DrillThroughValues[3].Values[0].ToString(), false);
                e.Report.SetParameters(par);


                ReportDataSource datasource = new ReportDataSource("DataSet1", lgDS);
                localreport.DataSources.Add(datasource);
                ReportDataSource datasource2 = new ReportDataSource("DataSet2", CompanyLogo.Tables[0]);
                localreport.DataSources.Add(datasource2);
            }
            if (DrillThroughValues.Count == 6)
            {

                this.duplicateGRNTableAdapter.Fill(this.Pur_SalDS.DuplicateGRN, DrillThroughValues[2].Values[0].ToString());

                ReportDataSource datasource = new ReportDataSource("DataSet1", Pur_SalDS.Tables[1]);
                ReportDataSource datasource2 = new ReportDataSource("DataSet2", CompanyLogo.Tables[0]);
                localreport.DataSources.Add(datasource2);
                localreport.DataSources.Add(datasource);
            }
            if (DrillThroughValues.Count == 4)
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
    }
}