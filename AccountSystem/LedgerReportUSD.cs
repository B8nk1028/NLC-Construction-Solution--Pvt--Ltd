using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AccountSystem
{
    public partial class LedgerReportUSD : Form
    {
        private MyModule Fn = new MyModule();
        public string Legders;
        public LedgerReportUSD()
        {
            InitializeComponent();

            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }

        #region Default Instance

        private static LedgerReportUSD defaultInstance;

        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static LedgerReportUSD Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new LedgerReportUSD();
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

        private void LedgerReport_Load(object sender, EventArgs e)
        {
            Fn.fillCombo(cbLocation, "select '%','ALL' union SELECT convert(varchar,EntryAccID), EntryAccName FROM TblAccEntry WHERE (AccType IN (22, 23))");

            //Fn.CenterScreen(this);
            string[] opnset = Fn.GetRecords("SELECT CodeSt,AccYear FROM tblMonthCloseing WHERE (CompID =" + MyModule.CompID + ")");
            datePicker1.Value = Convert.ToDateTime(opnset[1]);

            Fn.fillList(listAccHeads, "SELECT TblAccEntry.EntryAccID,TblAccEntry.EntryAccName as Expr1 FROM TblAccHead INNER JOIN TblAccSubHead ON TblAccHead.AccHeadID = TblAccSubHead.AccHeadID INNER JOIN TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID WHERE (TblAccHead.CompanyID =" + MyModule.CompID + ") AND (TblAccEntry.Stat = 1) AND (TblAccEntry.AccType = 10) AND (TblAccEntry.BranchID IS NULL OR convert(varchar,TblAccEntry.BranchID) like '" + cbLocation.SelectedValue + "') ORDER BY Expr1");

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Legders = "";
            if (listAccHeads.SelectedValue != null)
            {
                foreach (DataRowView objDataRowView in listAccHeads.SelectedItems)
                {
                    Legders = Legders + "," + objDataRowView[0].ToString();
                }
                //Fn.Exec("DELETE FROM LadgerView; INSERT INTO LadgerView  (edate, VNo, Des, Dr, Cr, Totals,VID,AccID) SELECT VW_VoucherHDR.EntryDate, VW_VoucherHDR.VoucherNo, VW_VoucherDTL.Descripation AS Expr1, VW_VoucherDTL.AmountDeb, VW_VoucherDTL.AmountCre, VW_VoucherDTL.AmountDeb - VW_VoucherDTL.AmountCre AS totals, VW_VoucherHDR.VoucherID, VW_VoucherDTL.AccEntryID FROM VW_VoucherDTL INNER JOIN VW_VoucherHDR ON VW_VoucherDTL.VoucherID = VW_VoucherHDR.VoucherID WHERE (CONVERT(DATE,VW_VoucherHDR.EntryDate) BETWEEN CONVERT(DATETIME, '" + datePicker1.Text + "', 102) AND CONVERT(DATETIME, '" + datePicker2.Text + "', 102)) AND (VW_VoucherDTL.AccEntryID IN (" + Legders.Substring(1) + ")); INSERT INTO LadgerView  (edate, VNo, Des, Dr, Cr, Totals,VID,AccID) SELECT '1-1-1900' AS edate, '' AS vochNo, 'Openning Balance' AS Des, SUM(VW_VoucherDTL.AmountDeb) AS Dr, SUM(VW_VoucherDTL.AmountCre) AS Cr, SUM(VW_VoucherDTL.AmountDeb - VW_VoucherDTL.AmountCre) AS totals, '0' AS VoucherI, VW_VoucherDTL.AccEntryID FROM VW_VoucherDTL INNER JOIN VW_VoucherHDR ON VW_VoucherDTL.VoucherID = VW_VoucherHDR.VoucherID WHERE (VW_VoucherDTL.AccEntryID in (" + Legders.Substring(1) + ")) AND (CONVERT(DATETIME,VW_VoucherHDR.EntryDate) < CONVERT(DATETIME, '" + datePicker1.Text + "', 102)) GROUP BY VW_VoucherDTL.AccEntryID");

                Fn.Exec("DELETE FROM LadgerView; INSERT INTO LadgerView  (edate, VNo, Des, Dr, Cr, Totals,VID,AccID,Typ) SELECT VW_VoucherHDR.EntryDate, VW_VoucherHDR.VoucherNo, VW_VoucherDTLUSD.Descripation AS Expr1, SUM(VW_VoucherDTLUSD.AmountDeb), SUM(VW_VoucherDTLUSD.AmountCre),SUM(VW_VoucherDTLUSD.AmountDeb - VW_VoucherDTLUSD.AmountCre) AS totals, VW_VoucherHDR.VoucherID, VW_VoucherDTLUSD.AccEntryID, TblAccHead.AccType FROM TblAccHead INNER JOIN TblAccSubHead ON TblAccHead.AccHeadID = TblAccSubHead.AccHeadID INNER JOIN TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID INNER JOIN VW_VoucherDTLUSD INNER JOIN VW_VoucherHDR ON VW_VoucherDTLUSD.VoucherID = VW_VoucherHDR.VoucherID ON TblAccEntry.EntryAccID = VW_VoucherDTLUSD.AccEntryID WHERE (CONVERT(DATE, VW_VoucherHDR.EntryDate) BETWEEN CONVERT(DATE, '" + datePicker1.Text + "', 102) AND CONVERT(DATE, '" + datePicker2.Text + "', 102)) AND (VW_VoucherDTLUSD.AccEntryID IN (" + Legders.Substring(1) + ")) AND (CONVERT(varchar, VW_VoucherHDR.BranchID) LIKE '" + cbLocation.SelectedValue + "') GROUP BY VW_VoucherHDR.EntryDate, VW_VoucherHDR.VoucherNo, VW_VoucherDTLUSD.Descripation, VW_VoucherHDR.VoucherID, VW_VoucherDTLUSD.AccEntryID, TblAccHead.AccType; INSERT INTO LadgerView  (edate, VNo, Des, Dr, Cr, Totals,VID,AccID,Typ) SELECT '1-1-1900' AS edate, '' AS vochNo, 'Openning Balance' AS Des, 0 AS Dr, 0 AS Cr, SUM(VW_VoucherDTLUSD.AmountDeb - VW_VoucherDTLUSD.AmountCre) AS totals, '0' AS VoucherI, VW_VoucherDTLUSD.AccEntryID, TblAccHead.AccType FROM TblAccSubHead INNER JOIN TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID INNER JOIN VW_VoucherDTLUSD INNER JOIN VW_VoucherHDR ON VW_VoucherDTLUSD.VoucherID = VW_VoucherHDR.VoucherID ON TblAccEntry.EntryAccID = VW_VoucherDTLUSD.AccEntryID INNER JOIN TblAccHead ON TblAccSubHead.AccHeadID = TblAccHead.AccHeadID WHERE (VW_VoucherDTLUSD.AccEntryID IN (" + Legders.Substring(1) + ")) AND (CONVERT(DATE, VW_VoucherHDR.EntryDate) < CONVERT(DATE, '" + datePicker1.Text + "', 102)) AND (CONVERT(varchar, VW_VoucherHDR.BranchID) LIKE '" + cbLocation.SelectedValue + "') GROUP BY VW_VoucherDTLUSD.AccEntryID, TblAccHead.AccType");

                MyModule.ParmA = "From " + datePicker1.Text + " to " + datePicker2.Text;
                MyModule.ParmB = listAccHeads.Text;
                MyModule.ParmD = "usd";
                if (Application.OpenForms.OfType<LadgerRpt>().Count() == 1)
                {
                    LadgerRpt.Default.Close();
                }
                LadgerRpt.Default.MdiParent = FrmMain.Default;
                LadgerRpt.Default.Show();
                //this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fn.Exec("DELETE FROM LadgerView; INSERT INTO LadgerView  (edate, VNo, Des, Dr, Cr, Totals,VID,AccID) SELECT TblVoucherHDR.EntryDate, TblVoucherHDR.VoucherNo, TblVoucherDTL.Description + Case When IsNull(TblVoucherHDR.CheqNo,'') = '' Then '' Else '  Cheque No: ' + TblVoucherHDR.CheqNo End+Case When IsNull(TblVoucherHDR.DrawingDate,'') = '' Then '' Else '  Drawing Date: ' + convert(varchar,TblVoucherHDR.DrawingDate,9)End AS Expr1, TblVoucherDTL.AmountDeb, TblVoucherDTL.AmountCre, TblVoucherDTL.AmountDeb - TblVoucherDTL.AmountCre AS totals,TblVoucherHDR.VoucherID,TblVoucherDTL.AccEntryID FROM TblVoucherDTL INNER JOIN TblVoucherHDR ON TblVoucherDTL.VoucherID = TblVoucherHDR.VoucherID WHERE (TblVoucherHDR.EntryDate BETWEEN CONVERT(DATETIME, '" + datePicker1.Text + "' , 102) AND CONVERT(DATETIME, '" + datePicker2.Text + "', 102)) AND (TblVoucherHDR.CompanyID = " + MyModule.CompID + ") AND (CONVERT(varchar, TblVoucherHDR.BranchID) LIKE '" + cbLocation.SelectedValue + "')");
            MyModule.ParmA = "From " + datePicker1.Text + " to " + datePicker2.Text;
            MyModule.ParmB = listAccHeads.Text;
            GLadgerRpt.Default.MdiParent = FrmMain.Default;
            GLadgerRpt.Default.Show();
            //this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Fn.fillList(listAccHeads, "SELECT TblAccEntry.EntryAccID,TblAccEntry.EntryAccName as Expr1 FROM TblAccHead INNER JOIN TblAccSubHead ON TblAccHead.AccHeadID = TblAccSubHead.AccHeadID INNER JOIN TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID WHERE (TblAccHead.CompanyID =" + MyModule.CompID + ") AND (TblAccEntry.EntryAccName LIKE '%" + txtSearch.Text + "%') AND (TblAccEntry.Stat = 1) AND (TblAccEntry.BranchID IS NULL OR convert(varchar,TblAccEntry.BranchID) like '" + cbLocation.SelectedValue + "') ORDER BY Expr1");
        }

        private void cbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            Fn.fillList(listAccHeads, "SELECT TblAccEntry.EntryAccID,TblAccEntry.EntryAccName as Expr1 FROM TblAccHead INNER JOIN TblAccSubHead ON TblAccHead.AccHeadID = TblAccSubHead.AccHeadID INNER JOIN TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID WHERE (TblAccHead.CompanyID =" + MyModule.CompID + ") AND (TblAccEntry.Stat = 1) AND (TblAccEntry.BranchID IS NULL OR convert(varchar,TblAccEntry.BranchID) like '" + cbLocation.SelectedValue + "') ORDER BY Expr1");
        }

        private void btnLgrItems_Click(object sender, EventArgs e)
        {
            Legders = "";
            if (listAccHeads.SelectedValue != null)
            {
                foreach (DataRowView objDataRowView in listAccHeads.SelectedItems)
                {
                    Legders = Legders + "," + objDataRowView[0].ToString();
                }

                Fn.Exec("DELETE FROM LadgerView; INSERT INTO LadgerView  (edate, VNo, Des, Dr, Cr, Totals,VID,AccID,Product,Qty,Rate,Disct,Typ) SELECT VW_VoucherHDR.EntryDate, VW_VoucherHDR.VoucherNo, VW_VoucherDTL.Descripation AS Expr1, VW_VoucherDTL.AmountDeb, VW_VoucherDTL.AmountCre, VW_VoucherDTL.AmountDeb - VW_VoucherDTL.AmountCre AS totals, VW_VoucherHDR.VoucherID, VW_VoucherDTL.AccEntryID, VWGoodsSalesPurchase.Prod_name, VWGoodsSalesPurchase.prod_qty, VWGoodsSalesPurchase.Prod_rate, VWGoodsSalesPurchase.Disct, TblAccHead.AccType FROM VWGoodsSalesPurchase RIGHT OUTER JOIN VW_VoucherDTL INNER JOIN VW_VoucherHDR ON VW_VoucherDTL.VoucherID = VW_VoucherHDR.VoucherID INNER JOIN TblAccSubHead INNER JOIN TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID INNER JOIN TblAccHead ON TblAccSubHead.AccHeadID = TblAccHead.AccHeadID ON VW_VoucherDTL.AccEntryID = TblAccEntry.EntryAccID ON VWGoodsSalesPurchase.BranchID = VW_VoucherHDR.BranchID AND VWGoodsSalesPurchase.sr = VW_VoucherDTL.Descripation AND VWGoodsSalesPurchase.Contact_id = VW_VoucherDTL.AccEntryID WHERE (CONVERT(DATE, VW_VoucherHDR.EntryDate) BETWEEN CONVERT(DATE, '" + datePicker1.Text + "', 102) AND CONVERT(DATE, '" + datePicker2.Text + "', 102)) AND (VW_VoucherDTL.AccEntryID IN (" + Legders.Substring(1) + ")) AND (CONVERT(varchar, VW_VoucherHDR.BranchID) LIKE '" + cbLocation.SelectedValue + "') UNION SELECT '1-1-1900' AS edate, '' AS vochNo, 'Openning Balance' AS Des, 0 AS Dr, 0 AS Cr, SUM(VW_VoucherDTL.AmountDeb - VW_VoucherDTL.AmountCre) AS totals, '0' AS VoucherI, VW_VoucherDTL.AccEntryID, NULL AS Expr1, NULL AS Expr2, NULL AS Expr3, NULL AS Expr4, TblAccHead.AccType FROM TblAccSubHead INNER JOIN TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID INNER JOIN TblAccHead ON TblAccSubHead.AccHeadID = TblAccHead.AccHeadID INNER JOIN VW_VoucherDTL INNER JOIN VW_VoucherHDR ON VW_VoucherDTL.VoucherID = VW_VoucherHDR.VoucherID ON TblAccEntry.EntryAccID = VW_VoucherDTL.AccEntryID WHERE (VW_VoucherDTL.AccEntryID IN (" + Legders.Substring(1) + ")) AND (CONVERT(DATE, VW_VoucherHDR.EntryDate) < CONVERT(DATE, '" + datePicker1.Text + "', 102)) AND (CONVERT(varchar, VW_VoucherHDR.BranchID) LIKE '" + cbLocation.SelectedValue + "') GROUP BY VW_VoucherDTL.AccEntryID, TblAccHead.AccType");

                MyModule.ParmA = "From " + datePicker1.Text + " to " + datePicker2.Text;
                MyModule.ParmB = listAccHeads.Text;
                if (Application.OpenForms.OfType<LadgerRpt2>().Count() == 1)
                {
                    LadgerRpt2.Default.Close();
                }
                LadgerRpt2.Default.MdiParent = FrmMain.Default;
                LadgerRpt2.Default.Show();
            }

        }

        private void LedgerReportUSD_FormClosing(object sender, FormClosingEventArgs e)
        {
            MyModule.ParmD = "";
        }
    }
}