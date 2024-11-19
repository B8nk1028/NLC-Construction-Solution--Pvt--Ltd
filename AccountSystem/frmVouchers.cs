using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;
using Newtonsoft.Json;
using SergeUtils;
namespace AccountSystem
{
    public partial class frmVouchers : Form
    {
        private Boolean chkSave = default(Boolean);
        private MyModule Fn = new MyModule();
        private Words Wrd = new Words();
        public frmVouchers()
        {
            InitializeComponent();
            if (defaultInstance == null)
                defaultInstance = this;
        }
        #region Default Instance
        private static frmVouchers defaultInstance;
        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static frmVouchers Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new frmVouchers();
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
        //private ComboBox cb = new ComboBox();
        private void frmVoucher_Load(object sender, EventArgs e)
        {
            //txtCr.Height = cboAcc.Height;
            //txtDr.Height = cboAcc.Height;
            //txtNarr.Height = cboAcc.Height;
            Fn.fillCombo(cbLocation, "sp_OfficeLocations");
            cbLocation.SelectedValue = MyModule.BranchID;
            //if (Fn.GetRecords("SELECT CodeSt FROM tblMonthCloseing WHERE (CompID =" + MyModule.CompID + ")")[0] == "True")
            //{
            //    Fn.fillCombo(cb, "SELECT TblAccEntry.EntryAccID,right(REPLICATE('0',2) + cast(TblAccHead.AccHeadCode as varchar(2)),2)+ '-' + right(REPLICATE('0',3) + cast(TblAccSubHead.AccSubCode as varchar(3)),3)+ '-' + right(REPLICATE('0',4) + cast(TblAccEntry.EntryAccCode as varchar(4)),4)+' '+TblAccEntry.EntryAccName as Expr1 FROM TblAccHead INNER JOIN TblAccSubHead ON TblAccHead.AccHeadID = TblAccSubHead.AccHeadID INNER JOIN TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID WHERE (TblAccHead.CompanyID =" + MyModule.CompID + ") AND (TblAccEntry.Stat = 1) ORDER BY Expr1");
            //}
            //else
            //{
            //    Fn.fillCombo(cb, "SELECT TblAccEntry.EntryAccID,TblAccEntry.EntryAccName+' '+right(REPLICATE('0',2) + cast(TblAccHead.AccHeadCode as varchar(2)),2)+ '-' + right(REPLICATE('0',3) + cast(TblAccSubHead.AccSubCode as varchar(3)),3)+ '-' + right(REPLICATE('0',4) + cast(TblAccEntry.EntryAccCode as varchar(4)),4) as Expr1 FROM TblAccHead INNER JOIN TblAccSubHead ON TblAccHead.AccHeadID = TblAccSubHead.AccHeadID INNER JOIN TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID WHERE (TblAccHead.CompanyID =" + MyModule.CompID + ") AND (TblAccEntry.Stat = 1) ORDER BY Expr1");
            //}
            Fn.fillCombo(cboAcc, "SELECT EntryAccID, EntryAccName FROM TblAccEntry WHERE (Stat = 1) AND (AccType NOT IN (21, 22, 23)) ORDER BY EntryAccName");
            cboAcc.Text = null; cbRef.Text = null;
            cboVouType.Text = "Journal Voucher";
            Fn.GetNum(voucherN, "SELECT COUNT(tbl.VoucherID) AS Voch FROM (SELECT VoucherID FROM TblVoucherDTL GROUP BY VoucherID) AS tbl INNER JOIN TblVoucherHDR ON tbl.VoucherID = TblVoucherHDR.VoucherID WHERE (convert(date,EntryDate) between '" + MyModule.ActiveYear + "' and (DATEADD(MONTH,12, convert(datetime,'" + MyModule.ActiveYear + "'))-1)) AND (VoucherNo LIKE N'JV/%') AND (CompanyID =" + MyModule.CompID + ") AND (BranchID =" + cbLocation.SelectedValue + ")");
            voucherN.Text = "JV/" + voucherN.Text;
            this.lblinWords.Parent = this.pictureBox1;
            string[] actDate = Fn.GetRecords("sp_ActiveDates");
            entryDateDateTimePicker.MaxDate = Convert.ToDateTime(actDate[1]);
            entryDateDateTimePicker.MinDate = Convert.ToDateTime(actDate[0]);
        }
        private void frmVoucher_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (chkSave == true)
            {
                DialogResult response = default(DialogResult);
                response = MessageBox.Show("Do you want to save the changes", "Confirm to Save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                if (response == DialogResult.Yes)
                {
                    if (lblTCr.Text != lblTDr.Text)
                    {
                        MessageBox.Show("Please check the entries Debit an Credit are not equel ...", "Debit != Credit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        e.Cancel = true;
                    }
                    btnSave.PerformClick();
                }
                else if (response == DialogResult.No)
                {
                    //Fn.Exec("DELETE FROM TblVoucherHDR0 WHERE (VoucherID in (SELECT TblVoucherHDR0.VoucherID FROM TblVoucherDTL0 RIGHT OUTER JOIN TblVoucherHDR0 ON TblVoucherDTL0.VoucherID = TblVoucherHDR0.VoucherID GROUP BY TblVoucherHDR0.VoucherID HAVING (SUM(TblVoucherDTL0.AmountDeb - TblVoucherDTL0.AmountCre) <> 0) OR (SUM(TblVoucherDTL0.AmountDeb - TblVoucherDTL0.AmountCre) IS NULL))) AND (Created LIKE N'" + MyModule.UserName + "|%')");
                }
                else
                {
                    e.Cancel = true;
                }
            }
            //Fn.Exec("DELETE FROM TblVoucherHDR0 WHERE (VoucherID in (SELECT TblVoucherHDR0.VoucherID FROM TblVoucherDTL0 RIGHT OUTER JOIN TblVoucherHDR0 ON TblVoucherDTL0.VoucherID = TblVoucherHDR0.VoucherID GROUP BY TblVoucherHDR0.VoucherID HAVING (SUM(TblVoucherDTL0.AmountDeb - TblVoucherDTL0.AmountCre) <> 0) OR (SUM(TblVoucherDTL0.AmountDeb - TblVoucherDTL0.AmountCre) IS NULL))) AND (Created LIKE N'" + MyModule.UserName + "|%')");
        }
        private void cboVouType_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlBank.Visible = false;
            if (cboVouType.Text == "Journal Voucher")
            {
                Fn.GetNum(voucherN, "SELECT COUNT(tbl.VoucherID) AS Voch FROM (SELECT VoucherID FROM TblVoucherDTL0 GROUP BY VoucherID) AS tbl INNER JOIN TblVoucherHDR0 ON tbl.VoucherID = TblVoucherHDR0.VoucherID WHERE (convert(date,EntryDate) between '" + MyModule.ActiveYear + "' and (DATEADD(MONTH,12, convert(datetime,'" + MyModule.ActiveYear + "'))-1)) AND (VoucherNo LIKE N'JV/%') AND (CompanyID =" + MyModule.CompID + ") AND (BranchID =" + cbLocation.SelectedValue + ")");
                voucherN.Text = "JV/" + voucherN.Text;
            }
            else if (cboVouType.Text == "Grant Payment Voucher")
            {
                Fn.GetNum(voucherN, "SELECT COUNT(tbl.VoucherID) AS Voch FROM (SELECT VoucherID FROM TblVoucherDTL0 GROUP BY VoucherID) AS tbl INNER JOIN TblVoucherHDR0 ON tbl.VoucherID = TblVoucherHDR0.VoucherID WHERE (CONVERT(varchar, MONTH(EntryDate)) + CONVERT(varchar, YEAR(EntryDate)) = '" + MyModule.AMonth + "') AND (VoucherNo LIKE N'GPV/%') AND (CompanyID =" + MyModule.CompID + ")");
                voucherN.Text = "GPV/" + voucherN.Text;
            }
            else if (cboVouType.Text == "Grant Receipt Voucher")
            {
                Fn.GetNum(voucherN, "SELECT COUNT(tbl.VoucherID) AS Voch FROM (SELECT VoucherID FROM TblVoucherDTL0 GROUP BY VoucherID) AS tbl INNER JOIN TblVoucherHDR0 ON tbl.VoucherID = TblVoucherHDR0.VoucherID WHERE (CONVERT(varchar, MONTH(EntryDate)) + CONVERT(varchar, YEAR(EntryDate)) = '" + MyModule.AMonth + "') AND (VoucherNo LIKE N'GRV/%') AND (CompanyID =" + MyModule.CompID + ")");
                voucherN.Text = "GRV/" + voucherN.Text;
            }
            else if (cboVouType.Text == "Security Payment Voucher")
            {
                Fn.GetNum(voucherN, "SELECT COUNT(tbl.VoucherID) AS Voch FROM (SELECT VoucherID FROM TblVoucherDTL0 GROUP BY VoucherID) AS tbl INNER JOIN TblVoucherHDR0 ON tbl.VoucherID = TblVoucherHDR0.VoucherID WHERE (CONVERT(varchar, MONTH(EntryDate)) + CONVERT(varchar, YEAR(EntryDate)) = '" + MyModule.AMonth + "') AND (VoucherNo LIKE N'SPV/%') AND (CompanyID =" + MyModule.CompID + ")");
                voucherN.Text = "SPV/" + voucherN.Text;
            }
            else if (cboVouType.Text == "Security Receipt Voucher")
            {
                Fn.GetNum(voucherN, "SELECT COUNT(tbl.VoucherID) AS Voch FROM (SELECT VoucherID FROM TblVoucherDTL0 GROUP BY VoucherID) AS tbl INNER JOIN TblVoucherHDR0 ON tbl.VoucherID = TblVoucherHDR0.VoucherID WHERE (CONVERT(varchar, MONTH(EntryDate)) + CONVERT(varchar, YEAR(EntryDate)) = '" + MyModule.AMonth + "') AND (VoucherNo LIKE N'SRV/%') AND (CompanyID =" + MyModule.CompID + ")");
                voucherN.Text = "SRV/" + voucherN.Text;
            }
            else if (cboVouType.Text == "Bank Receipt Voucher")
            {
                Fn.GetNum(voucherN, "SELECT COUNT(tbl.VoucherID) AS Voch FROM (SELECT VoucherID FROM TblVoucherDTL0 GROUP BY VoucherID) AS tbl INNER JOIN TblVoucherHDR0 ON tbl.VoucherID = TblVoucherHDR0.VoucherID WHERE (CONVERT(varchar, MONTH(EntryDate)) + CONVERT(varchar, YEAR(EntryDate)) = '" + MyModule.AMonth + "') AND (VoucherNo LIKE N'BRV/%') AND (CompanyID =" + MyModule.CompID + ")");
                voucherN.Text = "BRV/" + voucherN.Text;
                pnlBank.Visible = true;
            }
            else if (cboVouType.Text == "Cash Receipt Voucher")
            {
                Fn.GetNum(voucherN, "SELECT COUNT(tbl.VoucherID) AS Voch FROM (SELECT VoucherID FROM TblVoucherDTL0 GROUP BY VoucherID) AS tbl INNER JOIN TblVoucherHDR0 ON tbl.VoucherID = TblVoucherHDR0.VoucherID WHERE (CONVERT(varchar, MONTH(EntryDate)) + CONVERT(varchar, YEAR(EntryDate)) = '" + MyModule.AMonth + "') AND (VoucherNo LIKE N'CRV/%') AND (CompanyID =" + MyModule.CompID + ")");
                voucherN.Text = "CRV/" + voucherN.Text;
            }
            else if (cboVouType.Text == "Bank Payment Voucher")
            {
                Fn.GetNum(voucherN, "SELECT COUNT(tbl.VoucherID) AS Voch FROM (SELECT VoucherID FROM TblVoucherDTL0 GROUP BY VoucherID) AS tbl INNER JOIN TblVoucherHDR0 ON tbl.VoucherID = TblVoucherHDR0.VoucherID WHERE (CONVERT(varchar, MONTH(EntryDate)) + CONVERT(varchar, YEAR(EntryDate)) = '" + MyModule.AMonth + "') AND (VoucherNo LIKE N'BPV/%') AND (CompanyID =" + MyModule.CompID + ")");
                voucherN.Text = "BPV/" + voucherN.Text;
                pnlBank.Visible = true;
            }
            else if (cboVouType.Text == "Cash Payment Voucher")
            {
                Fn.GetNum(voucherN, "SELECT COUNT(tbl.VoucherID) AS Voch FROM (SELECT VoucherID FROM TblVoucherDTL0 GROUP BY VoucherID) AS tbl INNER JOIN TblVoucherHDR0 ON tbl.VoucherID = TblVoucherHDR0.VoucherID WHERE (CONVERT(varchar, MONTH(EntryDate)) + CONVERT(varchar, YEAR(EntryDate)) = '" + MyModule.AMonth + "') AND (VoucherNo LIKE N'CPV/%') AND (CompanyID =" + MyModule.CompID + ")");
                voucherN.Text = "CPV/" + voucherN.Text;
            }
        }
        private void clear()
        {
            lblTCr.Text = "";
            lblTDr.Text = "";
            txtOpenCash.Clear();
            lblinWords.Text = "";
            bankIDTextBox.Clear();
            tblVoucherDTLDataGridView.Rows.Clear();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "&Add New")
            {
                btnSave.Text = "&Save";
                btnPrint.Enabled = false;
                entryDateDateTimePicker.Enabled = true;
                bankIDTextBox.Enabled = true;
                tblVoucherDTLDataGridView.Enabled = true;
                panel3.Visible = true;
                cboVouType.Enabled = true;
                tblVoucherDTLDataGridView.Height = 0;
                pnlBank.Enabled = true;
                clear();
                Fn.GetNum(voucherN, "SELECT COUNT(tbl.VoucherID) AS Voch FROM (SELECT VoucherID FROM TblVoucherDTL GROUP BY VoucherID) AS tbl INNER JOIN TblVoucherHDR ON tbl.VoucherID = TblVoucherHDR.VoucherID WHERE (convert(date,EntryDate) between '" + MyModule.ActiveYear + "' and (DATEADD(MONTH,12, convert(datetime,'" + MyModule.ActiveYear + "'))-1)) AND (VoucherNo LIKE N'JV/%') AND (CompanyID =" + MyModule.CompID + ") AND (BranchID =" + cbLocation.SelectedValue + ")");
                voucherN.Text = "JV/" + voucherN.Text;
                cboVouType.Text = "Journal Voucher";
            }
            else
            {
                caclc();
                DateTime sdate = DateTime.ParseExact(MyModule.AMonth, "MMyyyy", CultureInfo.InvariantCulture);
                DateTime edate = sdate.AddMonths(-1);
                sdate = (sdate.AddMonths(1)).AddDays(-1);
                if (Fn.Between(entryDateDateTimePicker.Value.ToString("yyyyMM"), edate.ToString("yyyyMM"), sdate.ToString("yyyyMM")))
                {
                    if (grdChk())
                    {
                        if (lblTCr.Text != lblTDr.Text | lblTDr.Text == "00" | lblTDr.Text == "" | lblTDr.Text == ".00")
                        {
                            MessageBox.Show("Please check the entries debit and credit are not equel" + Environment.NewLine + "Can’t save blank voucher!", "Debit != Credit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        else
                        {
                            double DrAmt = 0; double CrAmt = 0;
                            string items = "";
                            for (int i = 0; i < tblVoucherDTLDataGridView.Rows.Count; i++)
                            {
                                items = items + "," + "{\"AccEntryID\":" + JsonConvert.ToString(tblVoucherDTLDataGridView.Rows[i].Cells["cboEntryAcc"].Tag) + ",\"Description\":" + JsonConvert.ToString(tblVoucherDTLDataGridView.Rows[i].Cells["Description"].Value) + ",\"AmountDeb\":" + JsonConvert.ToString(tblVoucherDTLDataGridView.Rows[i].Cells["DR"].Value.ToString().Replace(",", "")) + ",\"AmountCre\":" + JsonConvert.ToString(tblVoucherDTLDataGridView.Rows[i].Cells["Cr"].Value.ToString().Replace(",", "")) + ",\"Ref\":" + JsonConvert.ToString(tblVoucherDTLDataGridView.Rows[i].Cells["cboRef"].Tag) + "}";
                                if (tblVoucherDTLDataGridView.Rows[i].Cells["DR"].Value != null || Convert.ToDouble(tblVoucherDTLDataGridView.Rows[i].Cells["DR"].Value.ToString()) != 0)
                                {
                                    DrAmt = DrAmt + Convert.ToDouble(tblVoucherDTLDataGridView.Rows[i].Cells["DR"].Value.ToString().Replace(",", ""));
                                }
                                if (tblVoucherDTLDataGridView.Rows[i].Cells["Cr"].Value != null || Convert.ToDouble(tblVoucherDTLDataGridView.Rows[i].Cells["Cr"].Value) != 0)
                                {
                                    CrAmt = CrAmt + Convert.ToDouble(tblVoucherDTLDataGridView.Rows[i].Cells["DR"].Value.ToString().Replace(",", ""));
                                }
                            }
                            if (CrAmt != DrAmt)
                            {
                                MessageBox.Show("Please check Dr. and Cr. not equivalent ...", "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            string Data2Post = "{\"EntryDate\":" + JsonConvert.ToString(entryDateDateTimePicker.Text) + ",\"Memo\":" + JsonConvert.ToString(bankIDTextBox.Text) + ",\"Created\":" + JsonConvert.ToString(MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo) + ",\"CompanyID\":" + JsonConvert.ToString(MyModule.CompID) + ",\"items\":[" + items.Substring(1) + "]}";
                            string ID = Fn.GetRecords("sp_CreateJV0 '" + Data2Post + "'," + cbLocation.SelectedValue)[0];
                            voucherN.Tag = ID;
                            //////////////////////////////// to GL ///////////////////////////////////////////
                            Fn.Exec("UPDATE TblVoucherHDR0 SET VStatus = 2 WHERE (VoucherID = " + ID + ")");
                            ID = Fn.GetRecords("sp_CreateJV '" + Data2Post + "'," + cbLocation.SelectedValue)[0];
                            voucherN.Tag = ID;
                            btnPrint.Enabled = true;

                            //////////////////////////// end GL //////////////////////////////////////////////
                            if (ID == "a")
                            {
                                MessageBox.Show("There is some issue in data please check and try again", "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            //if (cboVouType.Text == "Bank Payment Voucher" | cboVouType.Text == "Bank Receipt Voucher")
                            //{
                            //    voucherN.Tag = Fn.ExenID("insert into TblVoucherHDR0 (VoucherNo,EntryDate,CheqNo,Created,Modified,Repli,DrawingDate,CompanyID,BranchID) values('" + voucherN.Text + "','" + entryDateDateTimePicker.Text + "','" + (txtCheqNo.Text.Equals(null) ? "" : txtCheqNo.Text) + "','" + MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo + "','" + MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo + "',0,'" + drawingDatePicker.Text + "'," + MyModule.CompID + "," + cbLocation.SelectedValue + ") SELECT @@IDENTITY").ToString();
                            //}
                            //else
                            //{
                            //    voucherN.Tag = Fn.ExenID("insert into TblVoucherHDR0 (VoucherNo,EntryDate,Created,Modified,Repli,CompanyID,Memo,BranchID) values('" + voucherN.Text + "','" + entryDateDateTimePicker.Text + "','" + MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo + "','" + MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo + "',0," + MyModule.CompID + ",'" + bankIDTextBox.Text + "'," + cbLocation.SelectedValue + ") SELECT @@IDENTITY").ToString();
                            //}
                            //for (int i = 0; i <= tblVoucherDTLDataGridView.Rows.Count - 1; i++)
                            //{
                            //    SqlCommand cmd = new SqlCommand();
                            //    cmd.CommandText = "insert into TblVoucherDTL0 (VoucherID,AccEntryID,Description,AmountDeb,AmountCre,Ref) values(" + voucherN.Tag + ",@AccEntryID,@Description,@AmountDeb,@AmountCre,@Ref)";
                            //    cmd.Parameters.AddWithValue("@AccEntryID", tblVoucherDTLDataGridView.Rows[i].Cells[0].Tag);
                            //    cmd.Parameters.AddWithValue("@Description", tblVoucherDTLDataGridView.Rows[i].Cells["Description"].Value == null ? "-" : tblVoucherDTLDataGridView.Rows[i].Cells[2].Value);
                            //    cmd.Parameters.AddWithValue("@AmountDeb", tblVoucherDTLDataGridView.Rows[i].Cells["DR"].Value);
                            //    cmd.Parameters.AddWithValue("@AmountCre", tblVoucherDTLDataGridView.Rows[i].Cells["Cr"].Value);
                            //    cmd.Parameters.AddWithValue("@Ref", tblVoucherDTLDataGridView.Rows[i].Cells["cboRef"].Value == null ? "0" : tblVoucherDTLDataGridView.Rows[i].Cells["cboRef"].Tag);
                            //    Fn.CmdExe(cmd);
                            //}
                            //----------------------------
                        }
                        btnSave.Text = "&Add New";
                        btnPrint.Enabled = true;
                        chkSave = false;
                        entryDateDateTimePicker.Enabled = false;
                        bankIDTextBox.Enabled = false;
                        tblVoucherDTLDataGridView.Enabled = false;
                        panel3.Visible = false;
                        cboVouType.Enabled = false;
                        pnlBank.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid date ...", "Active Mouths are " + edate.ToString("MMMM yyyy") + " and " + sdate.ToString("MMMM yyyy"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private bool grdChk()
        {
            bool chk = true;
            for (int i = 0; i <= tblVoucherDTLDataGridView.Rows.Count - 2; i++)
            {
                if (tblVoucherDTLDataGridView.Rows[i].Cells[0].Value == null)
                {
                    //MessageBox.Show("Please select a account");
                    tblVoucherDTLDataGridView.Rows.RemoveAt(i);
                    i--;
                }
            }
            return chk;
        }
        private void tblVoucherDTLDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //-----------------------------SELECT CONVERT(Varchar, SUM(TblVoucherDTL0.AmountCre - TblVoucherDTL0.AmountDeb)) AS OpenBalance,   TblAccHead.AccHeadName + N' ->' + TblAccSubHead.AccSubName + N' ->' + TblAccEntry.EntryAccName AS Expr1 FROM TblAccSubHead INNER JOIN  TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID INNER JOIN  TblAccHead ON TblAccSubHead.AccHeadID = TblAccHead.AccHeadID LEFT OUTER JOIN  TblVoucherDTL0 ON TblAccEntry.EntryAccID = TblVoucherDTL0.AccEntryID WHERE (TblAccEntry.EntryAccID = " + tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells[1].Value + ") GROUP BY TblAccHead.AccHeadName + N' ->' + TblAccSubHead.AccSubName + N' ->' + TblAccEntry.EntryAccName, TblAccSubHead.AccSubName, TblAccEntry.EntryAccName
                txtOpenCash.Clear();
                //Fn.GetNum(txtOpenCash, "SELECT ISNULL(CONVERT(Varchar, SUM(TblVoucherDTL0.AmountDeb-TblVoucherDTL0.AmountCre)), 'Nil') AS OpenBalance,   TblAccHead.AccHeadName + N' ->' + TblAccSubHead.AccSubName + N' ->' + TblAccEntry.EntryAccName AS Expr1 FROM TblAccSubHead INNER JOIN  TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID INNER JOIN  TblAccHead ON TblAccSubHead.AccHeadID = TblAccHead.AccHeadID LEFT OUTER JOIN  TblVoucherDTL0 ON TblAccEntry.EntryAccID = TblVoucherDTL0.AccEntryID WHERE (TblAccEntry.EntryAccID = " + tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells[0].Value + ") GROUP BY TblAccHead.AccHeadName + N' ->' + TblAccSubHead.AccSubName + N' ->' + TblAccEntry.EntryAccName, TblAccSubHead.AccSubName, TblAccEntry.EntryAccName");
                Fn.GetNum(txtOpenCash, "SELECT ISNULL(CONVERT(Varchar, SUM(VW_VoucherDTL.AmountDeb - VW_VoucherDTL.AmountCre)), '0') AS OpenBalance, TblAccSubHead.AccSubName + N' / ' + TblAccEntry.EntryAccName AS Expr1 FROM VW_VoucherHDR INNER JOIN VW_VoucherDTL ON VW_VoucherHDR.VoucherID = VW_VoucherDTL.VoucherID RIGHT OUTER JOIN TblAccSubHead INNER JOIN TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID ON VW_VoucherDTL.AccEntryID = TblAccEntry.EntryAccID WHERE (TblAccEntry.EntryAccID = " + tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells[0].Tag + ") AND (VW_VoucherHDR.BranchID = " + cbLocation.SelectedValue + ") GROUP BY TblAccSubHead.AccSubName + N' / ' + TblAccEntry.EntryAccName, TblAccSubHead.AccSubName, TblAccEntry.EntryAccName");
                txtOpenCash.Text = txtOpenCash.Tag + " = " + String.Format("{0:#,0;(#,0)}", Convert.ToInt32(txtOpenCash.Text));
                //------------------------
            }
            catch
            {
                txtOpenCash.Text = "";
            }
            //if (e.ColumnIndex == 0 && e.RowIndex == 0)
            //{
            //    if (Fn.GetRecords("SELECT CodeSt FROM tblMonthCloseing WHERE (CompID =" + MyModule.CompID + ")")[0] == "True")
            //    {
            //        //Fn.fillGridCbo(cboEntryAcc, "SELECT TblAccEntry.EntryAccID,right(REPLICATE('0',2) + cast(TblAccHead.AccHeadCode as varchar(2)),2)+ '-' + right(REPLICATE('0',3) + cast(TblAccSubHead.AccSubCode as varchar(3)),3)+ '-' + right(REPLICATE('0',4) + cast(TblAccEntry.EntryAccCode as varchar(4)),4)+' '+TblAccEntry.EntryAccName as Expr1 FROM TblAccHead INNER JOIN TblAccSubHead ON TblAccHead.AccHeadID = TblAccSubHead.AccHeadID INNER JOIN TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID WHERE (TblAccHead.CompanyID =" + MyModule.CompID + ") ORDER BY Expr1");
            //    }
            //    else
            //    {
            //        //Fn.fillGridCbo(cboEntryAcc, "SELECT TblAccEntry.EntryAccID,TblAccEntry.EntryAccName+' '+right(REPLICATE('0',2) + cast(TblAccHead.AccHeadCode as varchar(2)),2)+ '-' + right(REPLICATE('0',3) + cast(TblAccSubHead.AccSubCode as varchar(3)),3)+ '-' + right(REPLICATE('0',4) + cast(TblAccEntry.EntryAccCode as varchar(4)),4) as Expr1 FROM TblAccHead INNER JOIN TblAccSubHead ON TblAccHead.AccHeadID = TblAccSubHead.AccHeadID INNER JOIN TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID WHERE (TblAccHead.CompanyID =" + MyModule.CompID + ") ORDER BY Expr1");
            //    }
            //}
            if (e.ColumnIndex == 5)
            {
                foreach (DataGridViewRow row in tblVoucherDTLDataGridView.SelectedRows)
                {
                    try
                    {
                        tblVoucherDTLDataGridView.Rows.Remove(row);
                        tblVoucherDTLDataGridView.Height = tblVoucherDTLDataGridView.Height - 21;
                    }
                    catch { }
                }
            }
        }
        private void tblVoucherDTLDataGridView_Enter(object sender, EventArgs e)
        {
            if (!chkSave == true)
            {
                chkSave = true;
            }
        }
        private void tblVoucherDTLDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 0)
                {
                    try
                    {
                        txtOpenCash.Clear();
                        // Fn.GetNum(txtOpenCash, "SELECT ISNULL(CONVERT(Varchar, SUM(convert(bigint,TblVoucherDTL0.AmountDeb)-convert(bigint,TblVoucherDTL0.AmountCre))), 'Nil') AS OpenBalance,   TblAccHead.AccHeadName + N' ->' + TblAccSubHead.AccSubName + N' ->' + TblAccEntry.EntryAccName AS Expr1 FROM TblAccSubHead INNER JOIN  TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID INNER JOIN  TblAccHead ON TblAccSubHead.AccHeadID = TblAccHead.AccHeadID LEFT OUTER JOIN  TblVoucherDTL0 ON TblAccEntry.EntryAccID = TblVoucherDTL0.AccEntryID WHERE (TblAccEntry.EntryAccID = " + tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells[0].Value + ") GROUP BY TblAccHead.AccHeadName + N' ->' + TblAccSubHead.AccSubName + N' ->' + TblAccEntry.EntryAccName, TblAccSubHead.AccSubName, TblAccEntry.EntryAccName");
                        Fn.GetNum(txtOpenCash, "SELECT ISNULL(CONVERT(Varchar, SUM(VW_VoucherDTL.AmountDeb - VW_VoucherDTL.AmountCre)), '0') AS OpenBalance, TblAccSubHead.AccSubName + N' / ' + TblAccEntry.EntryAccName AS Expr1 FROM VW_VoucherHDR INNER JOIN VW_VoucherDTL ON VW_VoucherHDR.VoucherID = VW_VoucherDTL.VoucherID RIGHT OUTER JOIN TblAccSubHead INNER JOIN TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID ON VW_VoucherDTL.AccEntryID = TblAccEntry.EntryAccID WHERE (TblAccEntry.EntryAccID = " + tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells[0].Tag + ") AND (VW_VoucherHDR.BranchID = " + cbLocation.SelectedValue + ") GROUP BY TblAccSubHead.AccSubName + N' / ' + TblAccEntry.EntryAccName, TblAccSubHead.AccSubName, TblAccEntry.EntryAccName");
                        txtOpenCash.Text = txtOpenCash.Tag + " = " + String.Format("{0:#,0;(#,0)}", Convert.ToInt32(txtOpenCash.Text));
                        //------------------------
                    }
                    catch
                    {
                        txtOpenCash.Text = "";
                    }
                }
                if (e.ColumnIndex == 3)
                {
                    try
                    {
                        if (Convert.ToDouble(tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells["DR"].Value.Equals(null) ? 0 : tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells["DR"].Value) > 0)
                        {
                            tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells["Cr"].Value = 0;
                            tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells["Cr"].ReadOnly = true;
                        }
                        else
                        {
                            tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells["Cr"].ReadOnly = false;
                        }
                    }
                    catch
                    {
                        tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells["DR"].Value = 0;
                    }
                }
                if (e.ColumnIndex == 4)
                {
                    try
                    {
                        if (Convert.ToDouble(tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells[4].Value.Equals(System.DBNull.Value) ? 0 : tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells[4].Value) > 0)
                        {
                            tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells[3].Value = 0;
                            tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells[3].ReadOnly = true;
                        }
                        else
                        {
                            tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells[3].ReadOnly = false;
                        }
                    }
                    catch
                    {
                        tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells[4].Value = 0;
                    }
                }
            }
        }
        private void tblVoucherDTLDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                if (tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells[0].Value == null)
                {
                    //MessageBox.Show("Please select an account");
                    SendKeys.Send("{LEFT}");
                    //tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells[0].Selected = true;
                    //cb.Focus();
                }
                if (e.ColumnIndex == 0)
                {
                    if (tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells[2].Value == null)
                    {
                        tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells[2].Value = tblVoucherDTLDataGridView.Rows[e.RowIndex - 1].Cells[1].Value;
                    }
                }
                int counte = 0;
                int counter = 0;
                Double sumcr = 0;
                Double sumdr = 0;
                try
                {
                    while ((counter < tblVoucherDTLDataGridView.Rows.Count))
                    {
                        sumcr = sumcr + Convert.ToDouble(tblVoucherDTLDataGridView.Rows[counter].Cells[3].Value.Equals(System.DBNull.Value) ? 0 : tblVoucherDTLDataGridView.Rows[counter].Cells[3].Value);
                        counter = counter + 1;
                    }
                }
                catch
                {
                }
                lblTCr.Text = String.Format("{0:#,#.00}", sumcr);
                try
                {
                    while ((counte < tblVoucherDTLDataGridView.Rows.Count))
                    {
                        sumdr = sumdr + Convert.ToDouble(tblVoucherDTLDataGridView.Rows[counte].Cells[4].Value.Equals(System.DBNull.Value) ? 0 : tblVoucherDTLDataGridView.Rows[counte].Cells[4].Value);
                        counte = counte + 1;
                    }
                }
                catch
                {
                }
                lblTDr.Text = String.Format("{0:#,#.00}", sumdr);
                txtDiff.Text= String.Format("{0:#,#.00}", sumdr- sumcr);
                lblinWords.Text = Wrd.changeCurrencyToWords(Convert.ToString(sumdr));
            }
        }
        private void tblVoucherDTLDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //if (e.Control is ComboBox)
            //{
            //    cb = (ComboBox)e.Control;
            //    cb.DropDownStyle = ComboBoxStyle.DropDown;
            //    cb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //    cb.AutoCompleteSource = AutoCompleteSource.ListItems;
            //    cb.Text = null;
            //}
        }
        private void tblVoucherDTLDataGridView_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                tblVoucherDTLDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            else
            {
                tblVoucherDTLDataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            }
        }
        private void tblVoucherDTLDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                if (e.Value.ToString() == "System.Drawing.Bitmap")
                {
                    e.Value = global::AccountSystem.Properties.Resources.close;
                }
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {//////////////////////////////// to GL ///////////////////////////////////////////
            MyModule.ParmB = cboVouType.Text;
            frmJVReport.Default.MdiParent = FrmMain.Default;
            MyModule.ParmD = voucherN.Tag.ToString();
            MyModule.ParmA = lblinWords.Text;
            frmJVReport.Default.Show(); frmJVReport.Default.Activate();
            //////////////////////////////// to GL end ///////////////////////////////////////////
            //MyModule.ParmB = cboVouType.Text;
            //MyModule.ParmA = lblinWords.Text;
            //frmJVReport.Default.MdiParent = FrmMain.Default;
            //MyModule.ParmD = voucherN.Tag.ToString();
            //frmJVReport.Default.Show();
        }
        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.Focus();
        }
        private void btnSave_MouseHover(object sender, EventArgs e)
        {
            btnSave.Focus();
        }
        private void btnAddRow_Click(object sender, EventArgs e)
        {
            if (cboAcc.SelectedValue == null || (txtDr.Text + txtCr.Text) == "00")
            {
                MessageBox.Show("Please select account name" + Environment.NewLine + "Please check the entries debit and credit are not equel" + Environment.NewLine + "Can’t save blank voucher!", "Debit != Credit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            tblVoucherDTLDataGridView.Rows.Add();
            tblVoucherDTLDataGridView.Rows[tblVoucherDTLDataGridView.RowCount - 1].Cells[0].Value = cboAcc.Text;
            tblVoucherDTLDataGridView.Rows[tblVoucherDTLDataGridView.RowCount - 1].Cells[0].Tag = cboAcc.SelectedValue;
            tblVoucherDTLDataGridView.Rows[tblVoucherDTLDataGridView.RowCount - 1].Cells[1].Value = cbRef.Text;
            tblVoucherDTLDataGridView.Rows[tblVoucherDTLDataGridView.RowCount - 1].Cells[1].Tag = cbRef.SelectedValue == null ? "0" : cbRef.SelectedValue;
            tblVoucherDTLDataGridView.Rows[tblVoucherDTLDataGridView.RowCount - 1].Cells[2].Value = txtNarr.Text;
            tblVoucherDTLDataGridView.Rows[tblVoucherDTLDataGridView.RowCount - 1].Cells[3].Value = txtDr.Text;
            tblVoucherDTLDataGridView.Rows[tblVoucherDTLDataGridView.RowCount - 1].Cells[4].Value = txtCr.Text;
            caclc();
            tblVoucherDTLDataGridView.Height = tblVoucherDTLDataGridView.Height + 21;
            cboAcc.Text = ""; cboAcc.SelectedIndex = -1; cbRef.Text = ""; txtNarr.Text = ""; txtDr.Text = ""; txtCr.Text = ""; cbRef.Text = "";
            cboAcc.Focus(); txtDr.ReadOnly = false; txtCr.ReadOnly = false;
        }
        private void caclc()
        {
            int counte = 0;
            int counter = 0;
            Double sumcr = 0;
            Double sumdr = 0;
            try
            {
                while ((counter < tblVoucherDTLDataGridView.Rows.Count))
                {
                    sumcr = sumcr + Convert.ToDouble(tblVoucherDTLDataGridView.Rows[counter].Cells[3].Value.Equals(System.DBNull.Value) ? 0 : tblVoucherDTLDataGridView.Rows[counter].Cells[3].Value);
                    counter = counter + 1;
                }
            }
            catch
            {
            }
            lblTCr.Text = String.Format("{0:#,#.00}", sumcr);
            try
            {
                while ((counte < tblVoucherDTLDataGridView.Rows.Count))
                {
                    sumdr = sumdr + Convert.ToDouble(tblVoucherDTLDataGridView.Rows[counte].Cells[4].Value.Equals(System.DBNull.Value) ? 0 : tblVoucherDTLDataGridView.Rows[counte].Cells[4].Value);
                    counte = counte + 1;
                }
            }
            catch
            {
            }
            lblTDr.Text = String.Format("{0:#,#.00}", sumdr);
            txtDiff.Text = String.Format("{0:#,#.00}", sumdr - sumcr);
            lblinWords.Text = Wrd.changeCurrencyToWords(Convert.ToString(sumdr));
        }
        private void cboAcc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtOpenCash.Clear();
                Fn.fillCombo(cbRef, "sp_PenddingInvoices " + cboAcc.SelectedValue);
                Fn.GetNum(txtOpenCash, "SELECT ISNULL(CONVERT(Varchar, SUM(VW_VoucherDTL.AmountDeb - VW_VoucherDTL.AmountCre)), '0') AS OpenBalance, TblAccSubHead.AccSubName + N' / ' + TblAccEntry.EntryAccName AS Expr1 FROM VW_VoucherHDR INNER JOIN VW_VoucherDTL ON VW_VoucherHDR.VoucherID = VW_VoucherDTL.VoucherID RIGHT OUTER JOIN TblAccSubHead INNER JOIN TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID ON VW_VoucherDTL.AccEntryID = TblAccEntry.EntryAccID WHERE (TblAccEntry.EntryAccID = " + cboAcc.SelectedValue + ") AND (VW_VoucherHDR.BranchID = " + cbLocation.SelectedValue + ") GROUP BY TblAccSubHead.AccSubName + N' / ' + TblAccEntry.EntryAccName, TblAccSubHead.AccSubName, TblAccEntry.EntryAccName");
                txtOpenCash.Text = txtOpenCash.Tag + " = " + String.Format("{0:#,0;(#,0)}", Convert.ToInt32(txtOpenCash.Text));
                //------------------------
                cbRef.Text = null;
            }
            catch
            {
                cbRef.Text = null;
                txtOpenCash.Text = "";
            }
        }
        private void cbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtOpenCash.Clear();
                if (cboVouType.Text == "Journal Voucher")
                {
                    Fn.GetNum(voucherN, "SELECT COUNT(tbl.VoucherID) AS Voch FROM (SELECT VoucherID FROM TblVoucherDTL0 GROUP BY VoucherID) AS tbl INNER JOIN TblVoucherHDR0 ON tbl.VoucherID = TblVoucherHDR0.VoucherID WHERE (convert(date,EntryDate) between '" + MyModule.ActiveYear + "' and (DATEADD(MONTH,12, convert(datetime,'" + MyModule.ActiveYear + "'))-1)) AND (VoucherNo LIKE N'JV/%') AND (CompanyID =" + MyModule.CompID + ") AND (BranchID =" + cbLocation.SelectedValue + ")");
                    voucherN.Text = "JV/" + voucherN.Text;
                }
                Fn.GetNum(txtOpenCash, "SELECT ISNULL(CONVERT(Varchar, SUM(VW_VoucherDTL.AmountDeb - VW_VoucherDTL.AmountCre)), '0') AS OpenBalance, TblAccSubHead.AccSubName + N' / ' + TblAccEntry.EntryAccName AS Expr1 FROM VW_VoucherHDR INNER JOIN VW_VoucherDTL ON VW_VoucherHDR.VoucherID = VW_VoucherDTL.VoucherID RIGHT OUTER JOIN TblAccSubHead INNER JOIN TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID ON VW_VoucherDTL.AccEntryID = TblAccEntry.EntryAccID WHERE (TblAccEntry.EntryAccID = " + cboAcc.SelectedValue + ") AND (VW_VoucherHDR.BranchID = " + cbLocation.SelectedValue + ") GROUP BY TblAccSubHead.AccSubName + N' / ' + TblAccEntry.EntryAccName, TblAccSubHead.AccSubName, TblAccEntry.EntryAccName");
                txtOpenCash.Text = txtOpenCash.Tag + " = " + String.Format("{0:#,0;(#,0)}", Convert.ToInt32(txtOpenCash.Text));
                //------------------------
                cbRef.Text = null;
                Fn.fillCombo(cbRef, "sp_PenddingInvoices " + cboAcc.SelectedValue);
            }
            catch
            {
                cbRef.Text = null;
                txtOpenCash.Text = "";
            }
        }
        private void txtDr_Enter(object sender, EventArgs e)
        {
            txtDr.Select(0, txtDr.Text.Length);
        }
        private void txtCr_Enter(object sender, EventArgs e)
        {
            txtCr.Select(0, txtCr.Text.Length);
        }
        private void txtDr_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txtDr.Text == "" ? 0 : txtDr.Value) > 0)
                {
                    txtCr.Text = "0";
                    txtCr.ReadOnly = true;
                }
                else
                {
                    txtCr.ReadOnly = false;
                }
            }
            catch
            {
                txtDr.Text = "0";
            }
        }
        private void txtCr_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txtCr.Text == "" ? 0 : txtCr.Value) > 0)
                {
                    txtDr.Text = "0";
                    txtDr.ReadOnly = true;
                }
                else
                {
                    txtDr.ReadOnly = false;
                }
            }
            catch
            {
                txtCr.Text = "0";
            }
        }

        private void entryDateDateTimePicker_Enter(object sender, EventArgs e)
        {
            string[] actDate = Fn.GetRecords("sp_ActiveDates");
            entryDateDateTimePicker.MaxDate = Convert.ToDateTime(actDate[1]);
            entryDateDateTimePicker.MinDate = Convert.ToDateTime(actDate[0]);
        }
    }
}