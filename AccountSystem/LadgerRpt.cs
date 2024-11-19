using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
namespace AccountSystem
{
    public partial class LadgerRpt : Form
    {
        private Words Wrd = new Words();
        private MyModule Fn = new MyModule();
        public LadgerRpt()
        {
            InitializeComponent();
            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }
        #region Default Instance
        private static LadgerRpt defaultInstance;
        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static LadgerRpt Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new LadgerRpt();
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

            List<ReportParameter> paraList = new List<ReportParameter>
            {
                new ReportParameter("ReportParameter1", MyModule.ParmA,false),
                new ReportParameter("ReportParameter4", MyModule.ParmB, false),
                new ReportParameter("ReportParameter2", MyModule.CompName, false),
                new ReportParameter("ReportParameter3", txtbox.Text, false)
            };
            // Pass Parameters for Local Report
            this.reportViewer1.LocalReport.SetParameters(paraList.ToArray());

            this.reportViewer1.ShowExportButton = true; this.reportViewer1.RefreshReport();
            MyModule.rpt = reportViewer1;
            FrmMain.Default.grpExport.Visible = true;
            FrmMain.Default.grpExportInv.Visible = true;
        }
        private void LadgerRpt_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMain.Default.grpExport.Visible = false;
            FrmMain.Default.grpExportInv.Visible = false;
            MyModule.ParmD = "";
        }
        private void reportViewer1_Drillthrough(object sender, DrillthroughEventArgs e)
        {
            LocalReport localreport = (LocalReport)e.Report;
            ReportParameterInfoCollection DrillThroughValues = e.Report.GetParameters();
            if (Int32.TryParse(DrillThroughValues[2].Values[0].ToString(), out int v))
            {

                localreport.ReportEmbeddedResource = "AccountSystem.SubLedger.rdlc";
                ReportParameter param1 = new ReportParameter();
                param1 = new ReportParameter("ReportParameter1", Wrd.changeCurrencyToWords(Fn.GetRecords("SELECT SUM(AmountDeb) AS Expr1 FROM VW_VoucherDTL WHERE (VoucherID = '" + DrillThroughValues[2].Values[0].ToString() + "')")[0]), false);
                e.Report.SetParameters(param1);
                this.dataTable1TableAdapter1.Fill(this.JVDataSet.DataTable1, DrillThroughValues[2].Values[0].ToString());
                ReportDataSource datasource = new ReportDataSource("DataSet2", JVDataSet.Tables[0]);
                ReportDataSource datasource2 = new ReportDataSource("DataSet1", CompanyLogo.Tables[0]);
                localreport.DataSources.Add(datasource);
                localreport.DataSources.Add(datasource2);
            }
            else
            {
                if (MyModule.ParmD == "usd")
                {
                    localreport.ReportEmbeddedResource = "AccountSystem.LadgerSubBillUSD.rdlc";
                }
                else
                {
                    localreport.ReportEmbeddedResource = "AccountSystem.LadgerSubBill.rdlc";
                }
                if (DrillThroughValues.Count == 6)
                {
                    
                    ReportParameter param1 = new ReportParameter();
                    param1 = new ReportParameter("ReportParameter4", DrillThroughValues[2].Values[1].ToString(), false);
                    param1 = new ReportParameter("ReportParameter6", MyModule.TermsCond, false);
                    e.Report.SetParameters(param1);
                    this.duplicateGRNTableAdapter.Fill(this.Pur_SalDS.DuplicateGRN, DrillThroughValues[2].Values[0].ToString());
                    ReportDataSource datasource = new ReportDataSource("DataSet1", Pur_SalDS.Tables[1]);
                    ReportDataSource datasource2 = new ReportDataSource("DataSet2", CompanyLogo.Tables[0]);
                    localreport.DataSources.Add(datasource2);
                    localreport.DataSources.Add(datasource);
                }
                else
                {
                    localreport.ReportEmbeddedResource = "AccountSystem.SubLedger.rdlc";
                    ReportParameter param1 = new ReportParameter();
                    param1 = new ReportParameter("ReportParameter1", Wrd.changeCurrencyToWords(Fn.GetRecords("SELECT SUM(AmountDeb) AS Expr1 FROM VW_VoucherDTL WHERE (VoucherID = '" + DrillThroughValues[2].Values[0].ToString() + "')")[0]), false);
                    e.Report.SetParameters(param1);
                    this.dataTable1TableAdapter1.Fill(this.JVDataSet.DataTable1, DrillThroughValues[2].Values[0].ToString());
                    ReportDataSource datasource = new ReportDataSource("DataSet2", JVDataSet.Tables[0]);
                    ReportDataSource datasource2 = new ReportDataSource("DataSet1", CompanyLogo.Tables[0]);
                    localreport.DataSources.Add(datasource);
                    localreport.DataSources.Add(datasource2);
                }
            }
            localreport.Refresh();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                //Fn.Exec("DELETE FROM LadgerView; INSERT INTO LadgerView  (edate, VNo, Des, Dr, Cr, Totals,VID,AccID,Typ) SELECT VW_VoucherHDR.EntryDate, VW_VoucherHDR.VoucherNo, VW_VoucherDTL.Descripation AS Expr1, VW_VoucherDTL.AmountDeb, VW_VoucherDTL.AmountCre, VW_VoucherDTL.AmountDeb - VW_VoucherDTL.AmountCre AS totals, VW_VoucherHDR.VoucherID, VW_VoucherDTL.AccEntryID, TblAccHead.AccType FROM TblAccHead INNER JOIN TblAccSubHead ON TblAccHead.AccHeadID = TblAccSubHead.AccHeadID INNER JOIN TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID INNER JOIN VW_VoucherDTL INNER JOIN VW_VoucherHDR ON VW_VoucherDTL.VoucherID = VW_VoucherHDR.VoucherID ON TblAccEntry.EntryAccID = VW_VoucherDTL.AccEntryID WHERE (CONVERT(DATE, VW_VoucherHDR.EntryDate) BETWEEN CONVERT(DATE, '" + LedgerReport.Default.datePicker1.Text + "', 102) AND CONVERT(DATE, '" + LedgerReport.Default.datePicker2.Text + "', 102)) AND (VW_VoucherDTL.AccEntryID IN (" + LedgerReport.Default.Legders.Substring(1) + ")) AND (CONVERT(varchar, VW_VoucherHDR.BranchID) LIKE '" + LedgerReport.Default.cbLocation.SelectedValue + "'); INSERT INTO LadgerView  (edate, VNo, Des, Dr, Cr, Totals,VID,AccID,Typ) SELECT '1-1-1900' AS edate, '' AS vochNo, 'Openning Balance' AS Des, 0 AS Dr, 0 AS Cr, SUM(VW_VoucherDTL.AmountDeb - VW_VoucherDTL.AmountCre) AS totals, '0' AS VoucherI, VW_VoucherDTL.AccEntryID, TblAccHead.AccType FROM TblAccSubHead INNER JOIN TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID INNER JOIN VW_VoucherDTL INNER JOIN VW_VoucherHDR ON VW_VoucherDTL.VoucherID = VW_VoucherHDR.VoucherID ON TblAccEntry.EntryAccID = VW_VoucherDTL.AccEntryID INNER JOIN TblAccHead ON TblAccSubHead.AccHeadID = TblAccHead.AccHeadID WHERE (VW_VoucherDTL.AccEntryID IN (" + LedgerReport.Default.Legders.Substring(1) + ")) AND (CONVERT(DATE, VW_VoucherHDR.EntryDate) < CONVERT(DATE, '" + LedgerReport.Default.datePicker1.Text + "', 102)) AND (CONVERT(varchar, VW_VoucherHDR.BranchID) LIKE '" + LedgerReport.Default.cbLocation.SelectedValue + "') GROUP BY VW_VoucherDTL.AccEntryID, TblAccHead.AccType");
                // TODO: This line of code loads data into the 'CompanyLogo.TblCompany' table. You can move, or remove it, as needed.
                //this.TblCompanyTableAdapter.Fill(this.CompanyLogo.TblCompany, MyModule.CompID);
                // TODO: This line of code loads data into the 'LadgerDataSet.DataTable1' table. You can move, or remove it, as needed.
                //this.DataTable1TableAdapter.Fill(this.LadgerDataSet.DataTable1);
                TextBox txtbox = new TextBox();
                Fn.GetNum(txtbox, "SELECT Address+Char(13)+char(10)+Phone AS Expr1 FROM TblCompany Where CompanyID=" + MyModule.CompID);

                List<ReportParameter> paraList = new List<ReportParameter>
            {
                new ReportParameter("ReportParameter1", MyModule.ParmA,false),
                new ReportParameter("ReportParameter4", MyModule.ParmB, false),
                new ReportParameter("ReportParameter2", MyModule.CompName, false),
                new ReportParameter("DecsWdth", DescWdth.Value.ToString()+"pt", false),
                new ReportParameter("Col1", ckCol1.Checked.ToString(), false),
                new ReportParameter("Col2", ckCol2.Checked.ToString(), false),
                new ReportParameter("Col3", ckCol3.Checked.ToString(), false),
                new ReportParameter("ReportParameter3", txtbox.Text, false)
            };
                // Pass Parameters for Local Report
                this.reportViewer1.LocalReport.SetParameters(paraList.ToArray());



                //LadgerDataSet.Clear();

                //this.DataTable1TableAdapter.Fill(this.LadgerDataSet.DataTable1);
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