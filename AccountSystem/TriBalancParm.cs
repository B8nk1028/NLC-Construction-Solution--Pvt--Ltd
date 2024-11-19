using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace AccountSystem
{
    public partial class TriBalancParm : Form
    {
        private MyModule Fn = new MyModule();

        public TriBalancParm()
        {
            InitializeComponent();

            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }

        #region Default Instance

        private static TriBalancParm defaultInstance;

        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static TriBalancParm Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new TriBalancParm();
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

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (optTwo.Checked)
            {
                //TextBox txtyear = new TextBox();
                //Fn.GetNum(txtyear, "SELECT convert(varchar,AccYear) FROM tblMonthCloseing WHERE CompID =" + MyModule.CompID);
                //string dt = Convert.ToDateTime(datePicker1.Text).ToString("yyyy") + "-" + Convert.ToDateTime(txtyear.Text).ToString("MMMM") + "-1";
                //// Changes made for SME F ... Exp. opening blance removed ...
                ////org one >>>//Fn.Exec("DELETE FROM TriBalance; INSERT INTO TriBalance  (EntryAccID, OpenBalnCr,OpenBalnDr, CampID) SELECT TblAccEntry.EntryAccID, SUM(TblVoucherDTL.AmountCre),sum(TblVoucherDTL.AmountDeb), TblAccHead.CompanyID FROM TblAccSubHead INNER JOIN  TblAccHead ON TblAccSubHead.AccHeadID = TblAccHead.AccHeadID INNER JOIN  TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID LEFT OUTER JOIN  TblVoucherDTL INNER JOIN  TblVoucherHDR ON TblVoucherDTL.VoucherID = TblVoucherHDR.VoucherID ON TblAccEntry.EntryAccID = TblVoucherDTL.AccEntryID WHERE (TblAccHead.CompanyID =" + MyModule.CompID + ") AND (TblVoucherHDR.EntryDate < CONVERT(DATETIME, '" + datePicker1.Text + "', 102)) GROUP BY TblAccEntry.EntryAccID, TblAccHead.CompanyID");
                //Fn.Exec("DELETE FROM TriBalance; INSERT INTO TriBalance  (EntryAccID, OpenBalnCr,OpenBalnDr, CampID) SELECT TblAccEntry.EntryAccID, SUM(TblVoucherDTL.AmountCre) AS Expr1, SUM(TblVoucherDTL.AmountDeb) AS Expr2, TblAccHead.CompanyID FROM TblAccSubHead INNER JOIN TblAccHead ON TblAccSubHead.AccHeadID = TblAccHead.AccHeadID INNER JOIN TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID LEFT OUTER JOIN TblVoucherDTL INNER JOIN TblVoucherHDR ON TblVoucherDTL.VoucherID = TblVoucherHDR.VoucherID ON TblAccEntry.EntryAccID = TblVoucherDTL.AccEntryID WHERE (TblAccHead.CompanyID = " + MyModule.CompID + ") AND (TblVoucherHDR.EntryDate < CONVERT(DATETIME, '" + datePicker1.Text + "', 102)) AND (TblVoucherHDR.EntryDate >= CONVERT(DATETIME, '" + dt + "', 102)) GROUP BY TblAccEntry.EntryAccID, TblAccHead.CompanyID, TblAccHead.AccType HAVING ((TblAccHead.AccType = N'Expenditure') or (TblAccHead.AccType = N'Revenue'))");
                //Fn.Exec("INSERT INTO TriBalance  (EntryAccID, OpenBalnCr,OpenBalnDr, CampID) SELECT " + Fn.GetRecords("SELECT RetOpen, CompID FROM tblMonthCloseing WHERE (CompID = " + MyModule.CompID + ")")[0] + " AS Expr3, CASE WHEN isnull(SUM(TblVoucherDTL.Amountcre), 0) - isnull(SUM(TblVoucherDTL.Amountdeb), 0) < 0 THEN 0 ELSE isnull(SUM(TblVoucherDTL.Amountcre), 0) - isnull(SUM(TblVoucherDTL.Amountdeb), 0) END AS Expr2, CASE WHEN isnull(SUM(TblVoucherDTL.AmountDeb), 0) - isnull(SUM(TblVoucherDTL.AmountCre), 0) < 0 THEN 0 ELSE isnull(SUM(TblVoucherDTL.AmountDeb), 0) - isnull(SUM(TblVoucherDTL.AmountCre), 0) END AS Expr1, TblAccHead.CompanyID FROM TblAccSubHead INNER JOIN TblAccHead ON TblAccSubHead.AccHeadID = TblAccHead.AccHeadID INNER JOIN TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID LEFT OUTER JOIN TblVoucherDTL INNER JOIN TblVoucherHDR ON TblVoucherDTL.VoucherID = TblVoucherHDR.VoucherID ON TblAccEntry.EntryAccID = TblVoucherDTL.AccEntryID WHERE (TblAccHead.CompanyID = " + MyModule.CompID + ") AND (TblVoucherHDR.EntryDate < CONVERT(DATETIME, '" + dt + "', 102)) AND (TblAccHead.AccType = N'Expenditure' OR TblAccHead.AccType = N'Revenue') GROUP BY TblAccHead.CompanyID");
                //Fn.Exec("INSERT INTO TriBalance  (EntryAccID, OpenBalnCr,OpenBalnDr, CampID) SELECT TblAccEntry.EntryAccID, SUM(TblVoucherDTL.AmountCre) AS Expr1, SUM(TblVoucherDTL.AmountDeb) AS Expr2, TblAccHead.CompanyID FROM TblAccSubHead INNER JOIN TblAccHead ON TblAccSubHead.AccHeadID = TblAccHead.AccHeadID INNER JOIN TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID LEFT OUTER JOIN TblVoucherDTL INNER JOIN TblVoucherHDR ON TblVoucherDTL.VoucherID = TblVoucherHDR.VoucherID ON TblAccEntry.EntryAccID = TblVoucherDTL.AccEntryID WHERE (TblAccHead.CompanyID =" + MyModule.CompID + ") AND (TblVoucherHDR.EntryDate < CONVERT(DATETIME, '" + datePicker1.Text + "', 102)) AND ((TblAccHead.AccType <> N'Expenditure') and (TblAccHead.AccType <> N'Revenue')) GROUP BY TblAccEntry.EntryAccID, TblAccHead.CompanyID");
                Fn.Exec("DELETE FROM TriBalance;");
                insert_update();

                MyModule.ParmA = "From " + datePicker1.Text + " to " + datePicker2.Text;
                MyModule.Parm1 = datePicker1.Text;
                MyModule.Parm2 = datePicker2.Text;
                MyModule.ParmB = cbLocation.SelectedValue.ToString();
                if (Application.OpenForms.OfType<TrBlanRptView2>().Count() == 1)
                {
                    TrBlanRptView2.Default.Activate();
                }
                TrBlanRptView2.Default.MdiParent = FrmMain.Default;
                TrBlanRptView2.Default.Show();
                //this.Close();
            }
            else
            {
                TextBox txtyear = new TextBox();
                Fn.GetNum(txtyear, "SELECT convert(varchar,AccYear) FROM tblMonthCloseing WHERE CompID =" + MyModule.CompID);
                string dt = Convert.ToDateTime(datePicker1.Text).ToString("yyyy") + "-" + Convert.ToDateTime(txtyear.Text).ToString("MMMM") + "-1";
                // Changes made for SME F ... Exp. opening blance removed ...
                //org one >>>//Fn.Exec("DELETE FROM TriBalance; INSERT INTO TriBalance  (EntryAccID, OpenBalnCr,OpenBalnDr, CampID) SELECT TblAccEntry.EntryAccID, SUM(TblVoucherDTL.AmountCre),sum(TblVoucherDTL.AmountDeb), TblAccHead.CompanyID FROM TblAccSubHead INNER JOIN  TblAccHead ON TblAccSubHead.AccHeadID = TblAccHead.AccHeadID INNER JOIN  TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID LEFT OUTER JOIN  TblVoucherDTL INNER JOIN  TblVoucherHDR ON TblVoucherDTL.VoucherID = TblVoucherHDR.VoucherID ON TblAccEntry.EntryAccID = TblVoucherDTL.AccEntryID WHERE (TblAccHead.CompanyID =" + MyModule.CompID + ") AND (TblVoucherHDR.EntryDate < CONVERT(DATETIME, '" + datePicker1.Text + "', 102)) GROUP BY TblAccEntry.EntryAccID, TblAccHead.CompanyID");

                //Fn.Exec("DELETE FROM TriBalance; INSERT INTO TriBalance  (EntryAccID, OpenBalnCr,OpenBalnDr, CampID) SELECT TblAccEntry.EntryAccID, SUM(TblVoucherDTL.AmountCre) AS Expr1, SUM(TblVoucherDTL.AmountDeb) AS Expr2, TblAccHead.CompanyID FROM TblAccSubHead INNER JOIN TblAccHead ON TblAccSubHead.AccHeadID = TblAccHead.AccHeadID INNER JOIN TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID LEFT OUTER JOIN TblVoucherDTL INNER JOIN TblVoucherHDR ON TblVoucherDTL.VoucherID = TblVoucherHDR.VoucherID ON TblAccEntry.EntryAccID = TblVoucherDTL.AccEntryID WHERE (TblAccHead.CompanyID = " + MyModule.CompID + ") AND (TblVoucherHDR.EntryDate < CONVERT(DATETIME, '" + datePicker1.Text + "', 102)) AND (TblVoucherHDR.EntryDate >= CONVERT(DATETIME, '" + dt + "', 102)) GROUP BY TblAccEntry.EntryAccID, TblAccHead.CompanyID, TblAccHead.AccType HAVING ((TblAccHead.AccType = N'Expenditure') or (TblAccHead.AccType = N'Revenue'))");
                //Fn.Exec("INSERT INTO TriBalance  (EntryAccID, OpenBalnCr,OpenBalnDr, CampID) SELECT " + Fn.GetRecords("SELECT RetOpen, CompID FROM tblMonthCloseing WHERE (CompID = " + MyModule.CompID + ")")[0] + " AS Expr3, CASE WHEN isnull(SUM(TblVoucherDTL.Amountcre), 0) - isnull(SUM(TblVoucherDTL.Amountdeb), 0) < 0 THEN 0 ELSE isnull(SUM(TblVoucherDTL.Amountcre), 0) - isnull(SUM(TblVoucherDTL.Amountdeb), 0) END AS Expr2, CASE WHEN isnull(SUM(TblVoucherDTL.AmountDeb), 0) - isnull(SUM(TblVoucherDTL.AmountCre), 0) < 0 THEN 0 ELSE isnull(SUM(TblVoucherDTL.AmountDeb), 0) - isnull(SUM(TblVoucherDTL.AmountCre), 0) END AS Expr1, TblAccHead.CompanyID FROM TblAccSubHead INNER JOIN TblAccHead ON TblAccSubHead.AccHeadID = TblAccHead.AccHeadID INNER JOIN TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID LEFT OUTER JOIN TblVoucherDTL INNER JOIN TblVoucherHDR ON TblVoucherDTL.VoucherID = TblVoucherHDR.VoucherID ON TblAccEntry.EntryAccID = TblVoucherDTL.AccEntryID WHERE (TblAccHead.CompanyID = " + MyModule.CompID + ") AND (TblVoucherHDR.EntryDate < CONVERT(DATETIME, '" + dt + "', 102)) AND (TblAccHead.AccType = N'Expenditure' OR TblAccHead.AccType = N'Revenue') GROUP BY TblAccHead.CompanyID");
                //Fn.Exec("INSERT INTO TriBalance  (EntryAccID, OpenBalnCr,OpenBalnDr, CampID) SELECT TblAccEntry.EntryAccID, SUM(TblVoucherDTL.AmountCre) AS Expr1, SUM(TblVoucherDTL.AmountDeb) AS Expr2, TblAccHead.CompanyID FROM TblAccSubHead INNER JOIN TblAccHead ON TblAccSubHead.AccHeadID = TblAccHead.AccHeadID INNER JOIN TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID LEFT OUTER JOIN TblVoucherDTL INNER JOIN TblVoucherHDR ON TblVoucherDTL.VoucherID = TblVoucherHDR.VoucherID ON TblAccEntry.EntryAccID = TblVoucherDTL.AccEntryID WHERE (TblAccHead.CompanyID =" + MyModule.CompID + ") AND (TblVoucherHDR.EntryDate < CONVERT(DATETIME, '" + datePicker1.Text + "', 102)) AND ((TblAccHead.AccType <> N'Expenditure') and (TblAccHead.AccType <> N'Revenue')) GROUP BY TblAccEntry.EntryAccID, TblAccHead.CompanyID");

                Fn.Exec("sp_TriBalance2 '" + datePicker1.Text + "','" + dt + "','" + cbLocation.SelectedValue + "'," + MyModule.CompID);
                MyModule.ParmB = cbLocation.SelectedValue.ToString();
                insert_update();


                MyModule.ParmA = "From " + datePicker1.Text + " to " + datePicker2.Text;
                MyModule.Parm1 = datePicker1.Text;
                MyModule.Parm2 = datePicker2.Text;
                if (Application.OpenForms.OfType<TrBlanRptView>().Count() == 1)
                {
                    TrBlanRptView.Default.Activate();
                }
                TrBlanRptView.Default.MdiParent = FrmMain.Default;
                TrBlanRptView.Default.Show();
                //this.Close();
            }
        }

        private void insert_update()
        {
            DataSet MyDataSet = new DataSet();
            MyDataSet.Clear();
            SqlDataAdapter MyDataAdapter = new SqlDataAdapter("SELECT TblAccEntry.EntryAccID, SUM(VW_VoucherDTL.AmountCre) AS CR, SUM(VW_VoucherDTL.AmountDeb) AS DR, 1 FROM TblAccSubHead INNER JOIN TblAccHead ON TblAccSubHead.AccHeadID = TblAccHead.AccHeadID INNER JOIN TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID LEFT OUTER JOIN VW_VoucherDTL INNER JOIN VW_VoucherHDR ON VW_VoucherDTL.VoucherID = VW_VoucherHDR.VoucherID ON TblAccEntry.EntryAccID = VW_VoucherDTL.AccEntryID WHERE (VW_VoucherHDR.EntryDate BETWEEN CONVERT(DATETIME, '" + datePicker1.Text + "', 102) AND CONVERT(DATETIME, '" + datePicker2.Text + "', 102)) AND (convert(varchar,VW_VoucherHDR.BranchID) like '" + cbLocation.SelectedValue + "') GROUP BY TblAccEntry.EntryAccID", (string)global::AccountSystem.Properties.Settings.Default.DBConnectionString);

            //System.Data.SqlClient.SqlDataAdapter MyDataAdapter = new System.Data.SqlClient.SqlDataAdapter("SELECT TblAccEntry.EntryAccID, SUM(TblVoucherDTL.AmountCre),sum(TblVoucherDTL.AmountDeb), TblAccHead.CompanyID FROM TblAccSubHead INNER JOIN  TblAccHead ON TblAccSubHead.AccHeadID = TblAccHead.AccHeadID INNER JOIN  TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID LEFT OUTER JOIN  TblVoucherDTL INNER JOIN  TblVoucherHDR ON TblVoucherDTL.VoucherID = TblVoucherHDR.VoucherID ON TblAccEntry.EntryAccID = TblVoucherDTL.AccEntryID WHERE (TblAccHead.CompanyID = " + MyModule.CompID + ") AND (TblVoucherHDR.EntryDate BETWEEN CONVERT(DATETIME, '" + datePicker1.Text + "', 102) AND   CONVERT(DATETIME, '" + datePicker2.Text + "', 102)) GROUP BY TblAccEntry.EntryAccID, TblAccHead.CompanyID",(string)global::AccountSystem.Properties.Settings.Default.DBConnectionString);
            MyDataAdapter.Fill(MyDataSet);
            for (int i = 0; i <= MyDataSet.Tables[0].Rows.Count - 1; i++)
            {
                Fn.Exec("INSERT INTO TriBalance(EntryAccID, CurrtBalnCr,CurrtBalnDr, CampID)VALUES (" + MyDataSet.Tables[0].Rows[i][0] + "," + MyDataSet.Tables[0].Rows[i][1] + "," + MyDataSet.Tables[0].Rows[i][2] + "," + MyDataSet.Tables[0].Rows[i][3] + ")");
            }
            for (int i = 0; i <= MyDataSet.Tables[0].Rows.Count - 1; i++)
            {
                Fn.Exec("UPDATE TriBalance SET CurrtBalnCr = " + MyDataSet.Tables[0].Rows[i][1] + ",CurrtBalnDr = " + MyDataSet.Tables[0].Rows[i][2] + ", CampID = " + MyDataSet.Tables[0].Rows[i][3] + " WHERE (EntryAccID =" + MyDataSet.Tables[0].Rows[i][0] + ")");
            }
            MyDataSet.Dispose();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TriBalancParm_Load(object sender, EventArgs e)
        {
            Fn.fillCombo(cbLocation, "select '%','ALL' union SELECT convert(varchar,EntryAccID), EntryAccName FROM TblAccEntry WHERE (AccType IN (22, 23))");
            string[] opnset = Fn.GetRecords("SELECT CodeSt,AccYear FROM tblMonthCloseing WHERE (CompID =" + MyModule.CompID + ")");
            datePicker1.Value = Convert.ToDateTime(opnset[1]);
           
        }
    }
}