using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;

namespace AccountSystem
{
    public partial class TrBlanRptView : Form
    {
        private Words Wrd = new Words();
        private MyModule Fn = new MyModule();
        private ReportParameter param1 = new ReportParameter();
        private ReportParameter param = new ReportParameter();
        private ReportParameter para = new ReportParameter();
        private ReportParameter TogBtn = new ReportParameter();

        public TrBlanRptView()
        {
            InitializeComponent();

            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }

        #region Default Instance

        private static TrBlanRptView defaultInstance;

        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static TrBlanRptView Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new TrBlanRptView();
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
            if (DrillThroughValues.Count == 5 & localreport.ReportEmbeddedResource == "AccountSystem.LadgerReport.rdlc")
            {


                //DataTable lgDS = Fn.FillDSet("SELECT EntryDate edate, VoucherNo VNo, Descripation Des, AmountDeb Dr, AmountCre Cr, totals Totals, '" + DrillThroughValues[3].Values[0] + "' AS AccName, VoucherID VID from( SELECT VW_VoucherHDR.EntryDate, VW_VoucherHDR.VoucherNo, VW_VoucherDTL.Descripation, VW_VoucherDTL.AmountDeb, VW_VoucherDTL.AmountCre, VW_VoucherDTL.AmountDeb - VW_VoucherDTL.AmountCre AS totals,VW_VoucherHDR.VoucherID,VW_VoucherDTL.AccEntryID FROM VW_VoucherDTL INNER JOIN VW_VoucherHDR ON VW_VoucherDTL.VoucherID = VW_VoucherHDR.VoucherID WHERE (VW_VoucherHDR.EntryDate BETWEEN CONVERT(DATETIME, '" + MyModule.Parm1 + "' , 102) AND CONVERT(DATETIME, '" + MyModule.Parm2 + "', 102)) AND (VW_VoucherDTL.AccEntryID =" + DrillThroughValues[4].Values[0] + ") AND (CONVERT(varchar, VW_VoucherHDR.BranchID) LIKE '" + MyModule.ParmB + "') union SELECT '1-1-1900' AS edate, '' AS vochNo, 'Openning Balance' AS Des, 0 AS Dr, 0 AS Cr, SUM(VW_VoucherDTL.AmountDeb - VW_VoucherDTL.AmountCre) AS totals,'0' as VoucherI,VW_VoucherDTL.AccEntryID FROM VW_VoucherDTL INNER JOIN VW_VoucherHDR ON VW_VoucherDTL.VoucherID = VW_VoucherHDR.VoucherID WHERE(VW_VoucherDTL.AccEntryID = " + DrillThroughValues[4].Values[0] + ") AND(VW_VoucherHDR.EntryDate < CONVERT(DATETIME, '" + MyModule.Parm1 + "', 102)) AND (CONVERT(varchar, VW_VoucherHDR.BranchID) LIKE '" + MyModule.ParmB + "') GROUP BY VW_VoucherDTL.AccEntryID)tb").Tables[0];
                DataTable lgDS = Fn.FillDSet("SELECT EntryDate edate, VoucherNo VNo, Descripation Des, AmountDeb Dr, AmountCre Cr, totals Totals, '" + DrillThroughValues[3].Values[0] + "' AS AccName, VoucherID VID,AccType Typ from(SELECT VW_VoucherHDR.EntryDate, VW_VoucherHDR.VoucherNo, VW_VoucherDTL.Descripation, VW_VoucherDTL.AmountDeb, VW_VoucherDTL.AmountCre, VW_VoucherDTL.AmountDeb - VW_VoucherDTL.AmountCre AS totals, VW_VoucherHDR.VoucherID, VW_VoucherDTL.AccEntryID, TblAccHead.AccType FROM TblAccHead INNER JOIN TblAccSubHead ON TblAccHead.AccHeadID = TblAccSubHead.AccHeadID INNER JOIN TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID INNER JOIN VW_VoucherDTL INNER JOIN VW_VoucherHDR ON VW_VoucherDTL.VoucherID = VW_VoucherHDR.VoucherID ON TblAccEntry.EntryAccID = VW_VoucherDTL.AccEntryID WHERE (CONVERT(DATE, VW_VoucherHDR.EntryDate) BETWEEN CONVERT(DATE, '" + MyModule.Parm1 + "', 102) AND CONVERT(DATE, '" + MyModule.Parm2 + "', 102)) AND (VW_VoucherDTL.AccEntryID IN (" + DrillThroughValues[4].Values[0] + ")) AND (CONVERT(varchar, VW_VoucherHDR.BranchID) LIKE '" + MyModule.ParmB + "') union SELECT '1-1-1900' AS edate, '' AS vochNo, 'Openning Balance' AS Des, 0 AS Dr, 0 AS Cr, SUM(VW_VoucherDTL.AmountDeb - VW_VoucherDTL.AmountCre) AS totals, '0' AS VoucherI, VW_VoucherDTL.AccEntryID, TblAccHead.AccType FROM TblAccSubHead INNER JOIN TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID INNER JOIN VW_VoucherDTL INNER JOIN VW_VoucherHDR ON VW_VoucherDTL.VoucherID = VW_VoucherHDR.VoucherID ON TblAccEntry.EntryAccID = VW_VoucherDTL.AccEntryID INNER JOIN TblAccHead ON TblAccSubHead.AccHeadID = TblAccHead.AccHeadID WHERE (VW_VoucherDTL.AccEntryID IN (" + DrillThroughValues[4].Values[0] + ")) AND (CONVERT(DATE, VW_VoucherHDR.EntryDate) < CONVERT(DATE, '" + MyModule.Parm1 + "', 102)) AND (CONVERT(varchar, VW_VoucherHDR.BranchID) LIKE '" + MyModule.ParmB + "') GROUP BY VW_VoucherDTL.AccEntryID, TblAccHead.AccType)tb").Tables[0];

                e.Report.SetParameters(param1);
                e.Report.SetParameters(param);
                e.Report.SetParameters(para);
                // TODO: This line of code loads data into the 'LadgerDataSet.DataTable1' table. You can move, or remove it, as needed.
                ReportParameter par = new ReportParameter();
                par = new ReportParameter("ReportParameter4", DrillThroughValues[3].Values[0].ToString(), false);
                e.Report.SetParameters(par);
                this.DataTable1TableAdapter.Fill(this.LadgerDataSet.DataTable1);

                ReportDataSource datasource = new ReportDataSource("DataSet1", lgDS);
                localreport.DataSources.Add(datasource);
                ReportDataSource datasource2 = new ReportDataSource("DataSet2", CompanyLogo.Tables[0]);
                localreport.DataSources.Add(datasource2);
            }
           else if (DrillThroughValues.Count == 6 & localreport.ReportEmbeddedResource == "AccountSystem.LadgerSubBill.rdlc")
            {
              
                this.duplicateGRNTableAdapter.Fill(this.pur_SalDS.DuplicateGRN, DrillThroughValues[2].Values[0].ToString());

                ReportDataSource datasource = new ReportDataSource("DataSet1", pur_SalDS.Tables[1]);
                ReportDataSource datasource2 = new ReportDataSource("DataSet2", CompanyLogo.Tables[0]);
                localreport.DataSources.Add(datasource2);
                localreport.DataSources.Add(datasource);
            }
            else if(DrillThroughValues.Count == 4)
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

        private void TrBlanRptView_Activated(object sender, EventArgs e)
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