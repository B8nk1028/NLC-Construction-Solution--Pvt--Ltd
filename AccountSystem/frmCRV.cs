using Newtonsoft.Json;
using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;
namespace AccountSystem
{
    public partial class frmCRV : Form
    {
        private Double bdeb, bcre, entDr, entCr;
        private MyModule Fn = new MyModule();
        private Words Wrd = new Words();
        private bool bexist;
        public frmCRV()
        {
            InitializeComponent();
            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }
        #region Default Instance
        private static frmCRV defaultInstance;
        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static frmCRV Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new frmCRV();
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
        private void Amount()
        {
            if (RadioBankWidrw.Checked == true)
            {
                bdeb = 0;
                //bcre = Convert.ToDouble(txtAmount.Text);
                entCr = 0;
                bcre = Convert.ToDouble(entryAmount.Text);
                entDr = Convert.ToDouble(entryAmount.Text);
            }
            else
            {
                //bdeb = Convert.ToDouble(txtAmount.Text);
                bcre = 0;
                bdeb = Convert.ToDouble(entryAmount.Text);
                entCr = Convert.ToDouble(entryAmount.Text);
                entDr = 0;
            }
        }
        private void ValidateNum(TextBox txtBox)
        {
            try
            {
                if (txtBox.Text != "")
                {
                    Double a;
                    a = Convert.ToDouble(txtBox.Text) / 2;
                    bexist = true;
                }
            }
            catch
            {
                MessageBox.Show("Invalid Input Please Re-Enter");
            }
        }
        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            ValidateNum(txtAmount);
        }
        private void entryAmount_TextChanged(object sender, EventArgs e)
        {
            ValidateNum(entryAmount);
            lblinWords.Text = Wrd.changeCurrencyToWords(Convert.ToString(entryAmount.Text));
        }
        private bool ValidateControls()
        {
            //bool functionReturnValue = false;
            bool validate = true;
            DateTime sdate = DateTime.ParseExact(MyModule.AMonth, "MMyyyy", CultureInfo.InvariantCulture);
            DateTime edate = sdate.AddMonths(-1);
            sdate = (sdate.AddMonths(1)).AddDays(-1);
            if (cmboBank.SelectedValue == null)
            {
                MessageBox.Show("Please select a valid cash account name . . . ", "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return validate == false;
                //return functionReturnValue;
            }
            //else if (string.IsNullOrEmpty(txtAmount.Text))
            //{
            //    MessageBox.Show("Please Enter valid Amount ","GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return validate == false;
            //}
            else if (entryAmount.Text == "0")
            {
                MessageBox.Show("Please Enter valid Amount ", "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return validate == false;
            }
            else if (string.IsNullOrEmpty(entryAmount.Text))
            {
                MessageBox.Show("Please Enter valid Amount ", "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return validate == false;
            }
            else if (!Fn.Between(entryDatePicker.Value.ToString("yyyyMM"), edate.ToString("yyyyMM"), sdate.ToString("yyyyMM")))
            {
                MessageBox.Show("Can not save due to invalid date", "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return validate == false;
            }
            else if (GridChk() == false)
            {
                MessageBox.Show("Can not save due to invalid amount", "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return validate == false;
            }
            return (validate);
            //return functionReturnValue;
        }
        private Boolean GridChk()
        {
            Boolean chk = true;
            try
            {
                for (int i = 0; i <= tblVoucherDTLDataGridView.Rows.Count - 1; i++)
                {
                    Double a;
                    a = Convert.ToDouble(tblVoucherDTLDataGridView.Rows[i].Cells[3].Value) / 2;
                    txtBankDesc.Text = tblVoucherDTLDataGridView.Rows[i].Cells[2].Value + ", " + txtBankDesc.Text;
                }
            }
            catch
            {
                chk = false;
            }
            return chk;
        }
        private void clear()
        {
            cmboBank.Text = null;
            txtAmount.Clear();
            entryAmount.Clear();
            txtBankDesc.Clear();
            tblVoucherDTLDataGridView.Rows.Clear();
        }
        private void tblVoucherDTLDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 0)
                {
                    try
                    {
                        if (tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells[2].Value == null && tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells[0].Value != null)
                        {
                            //if ((e.RowIndex+1) % 2 == 0)
                            //{
                            tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells[2].Value = txtBankDesc.Text;
                            //}
                        }
                    }
                    catch
                    { }
                }
                int counter = 0;
                Double sumcr = 0;
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
                    tblVoucherDTLDataGridView.Rows[counter].Cells[3].Value = 0;
                }
                //txtAmount.Text = sumcr.ToString();
                entryAmount.Text = sumcr.ToString();
            }
        }
        private void RadioBankWidrw_CheckedChanged(object sender, EventArgs e)
        {
            Fn.GetNum(txtVoucherNo, "SELECT COUNT(*) AS V FROM TblVoucherHDR0 WHERE (convert(date,EntryDate) between '" + MyModule.ActiveYear + "' and (DATEADD(MONTH,12, convert(datetime,'" + MyModule.ActiveYear + "'))-1)) AND (VoucherNo LIKE N'CPV/%') AND (CompanyID =" + MyModule.CompID + ")AND (BranchID =" + cbLocation.SelectedValue + ")");
            txtVoucherNo.Text = "CPV/" + txtVoucherNo.Text;
            fillHeads_R();
        }
        private void RadioBankDeposit_CheckedChanged(object sender, EventArgs e)
        {
            Fn.GetNum(txtVoucherNo, "SELECT COUNT(*) AS V FROM TblVoucherHDR0 WHERE (convert(date,EntryDate) between '" + MyModule.ActiveYear + "' and (DATEADD(MONTH,12, convert(datetime,'" + MyModule.ActiveYear + "'))-1)) AND (VoucherNo LIKE N'CRV/%') AND (CompanyID =" + MyModule.CompID + ") AND (BranchID =" + cbLocation.SelectedValue + ")");
            txtVoucherNo.Text = "CRV/" + txtVoucherNo.Text;
            fillHeads_E();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "&Add New")
            {
                RadioBankDeposit.Checked = true;
                btnSave.Text = "&Save";
                btnPrint.Enabled = false;
                groupBox4.Enabled = true;
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                tblVoucherDTLDataGridView.Enabled = true;
                tblVoucherDTLDataGridView.Height = 0;
                clear();
                cbRef2.Text = null;
                //Fn.GetNum(txtVoucherNo, "SELECT COUNT(*) AS V FROM TblVoucherHDR0 WHERE (convert(date,EntryDate) between '" + MyModule.ActiveYear + "' and (DATEADD(MONTH,12, convert(datetime,'" + MyModule.ActiveYear + "'))-1)) AND (VoucherNo LIKE N'CRV/%') AND (CompanyID =" + MyModule.CompID + ")AND (BranchID =" + cbLocation.SelectedValue + ")");
                Fn.GetNum(txtVoucherNo, "SELECT COUNT(tbl.VoucherID) AS Voch FROM (SELECT VoucherID FROM TblVoucherDTL GROUP BY VoucherID) AS tbl INNER JOIN TblVoucherHDR ON tbl.VoucherID = TblVoucherHDR.VoucherID WHERE (convert(date,EntryDate) between '" + MyModule.ActiveYear + "' and (DATEADD(MONTH,12, convert(datetime,'" + MyModule.ActiveYear + "'))-1)) AND (VoucherNo LIKE N'CRV/%') AND (CompanyID =" + MyModule.CompID + ") AND (BranchID =" + cbLocation.SelectedValue + ")");
                txtVoucherNo.Text = "CRV/" + txtVoucherNo.Text;
                bexist = false;
            }
            else
            {
                if (ValidateControls())
                {
                    Amount();
                    if (bdeb != entCr || bcre != entDr)
                    {
                        MessageBox.Show("Please check Debit and Credit are not equal ", "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        double DrAmt = 0; double CrAmt = 0; string desc = ""; double totAmtDr = 0; double totAmtCr = 0;
                        string items = ""; string vCh = "";
                        for (int i = 0; i < tblVoucherDTLDataGridView.Rows.Count; i++)
                        {
                            if (RadioBankDeposit.Checked)
                            {
                                vCh = "CRV";
                                CrAmt = Convert.ToDouble(tblVoucherDTLDataGridView.Rows[i].Cells["Amt"].Value);
                                if (tblVoucherDTLDataGridView.Rows[i].Cells["Amt"].Value != null || Convert.ToDouble(tblVoucherDTLDataGridView.Rows[i].Cells["Amt"].Value) != 0)
                                {
                                    totAmtDr = totAmtDr + Convert.ToDouble(tblVoucherDTLDataGridView.Rows[i].Cells["Amt"].Value);
                                }
                            }
                            else
                            {
                                vCh = "CPV";
                                DrAmt = Convert.ToDouble(tblVoucherDTLDataGridView.Rows[i].Cells["Amt"].Value);
                                if (tblVoucherDTLDataGridView.Rows[i].Cells["Amt"].Value != null || Convert.ToDouble(tblVoucherDTLDataGridView.Rows[i].Cells["Amt"].Value) != 0)
                                {
                                    totAmtCr = totAmtCr + Convert.ToDouble(tblVoucherDTLDataGridView.Rows[i].Cells["Amt"].Value);
                                }
                            }
                            items = items + "," + "{\"AccEntryID\":" + JsonConvert.ToString(tblVoucherDTLDataGridView.Rows[i].Cells["AccountCode"].Tag) + ",\"Description\":" + JsonConvert.ToString(tblVoucherDTLDataGridView.Rows[i].Cells["Description"].Value) + ",\"AmountDeb\":" + JsonConvert.ToString(DrAmt) + ",\"AmountCre\":" + JsonConvert.ToString(CrAmt) + ",\"Ref\":" + JsonConvert.ToString(tblVoucherDTLDataGridView.Rows[i].Cells["cboRef"].Tag) + "}";
                            if (tblVoucherDTLDataGridView.Rows[i].Cells["Description"].Value.ToString() != "")
                            {
                                desc = desc + "," + tblVoucherDTLDataGridView.Rows[i].Cells["Description"].Value.ToString();
                            }
                            else
                            {
                                desc = ".";
                            }
                        }
                        items = items + "," + "{\"AccEntryID\":" + JsonConvert.ToString(cmboBank.SelectedValue) + ",\"Description\":" + JsonConvert.ToString((desc.Substring(1))) + ",\"AmountDeb\":" + JsonConvert.ToString(totAmtDr) + ",\"AmountCre\":" + JsonConvert.ToString(totAmtCr) + ",\"Ref\":" + JsonConvert.ToString(cbRef2.SelectedValue) + "}";
                        string Data2Post = "{\"EntryDate\":" + JsonConvert.ToString(entryDatePicker.Text) + ",\"Created\":" + JsonConvert.ToString(MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo) + ",\"CompanyID\":" + JsonConvert.ToString(MyModule.CompID) + ",\"items\":[" + items.Substring(1) + "]}";
                        string ID = Fn.GetRecords("sp_CreateCashVouchers0 '" + Data2Post.Replace("'", "''") + "'," + cbLocation.SelectedValue + ",'" + vCh + "'")[0];
                        txtVid.Text = ID;
                        //////////////////////////////// to GL ///////////////////////////////////////////
                        Fn.Exec("UPDATE TblVoucherHDR0 SET VStatus = 2 WHERE (VoucherID = " + ID + ")");
                        ID = Fn.GetRecords("sp_CreateCashVouchers '" + Data2Post.Replace("'", "''") + "'," + cbLocation.SelectedValue + ",'" + vCh + "'")[0];
                        txtVid.Text = ID;
                        btnPrint.Enabled = true;

                        //////////////////////////// end GL //////////////////////////////////////////////
                        if (ID == "a")
                        {
                            MessageBox.Show("There is some issue in data please check and try again", "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        //if (RadioBankDeposit.Checked)
                        //{
                        //    txtVoucherNo.Clear();
                        //    Fn.GetNum(txtVoucherNo, "SELECT COUNT(*) AS V FROM TblVoucherHDR0 WHERE (convert(date,EntryDate) between '" + MyModule.ActiveYear + "' and (DATEADD(MONTH,12, convert(datetime,'" + MyModule.ActiveYear + "'))-1)) AND (VoucherNo LIKE N'CRV/%') AND (CompanyID =" + MyModule.CompID + ") AND (BranchID =" + cbLocation.SelectedValue + ")");
                        //    txtVoucherNo.Text = "CRV/" + txtVoucherNo.Text;
                        //    txtVid.Text = Fn.ExenID("insert into TblVoucherHDR0 (VoucherNo,EntryDate,Created,Modified,Repli,CompanyID,BranchID) values('" + txtVoucherNo.Text + "','" + entryDatePicker.Text + "','" + MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo + "','" + MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo + "',0," + MyModule.CompID + "," + cbLocation.SelectedValue + ") SELECT @@IDENTITY").ToString();
                        //    Fn.Exec("insert into TblVoucherDTL (VoucherID,AccEntryID,Description,AmountDeb,AmountCre,Repli) values(" + txtVid.Text + ",'" + cmboBank.SelectedValue + "','" + txtBankDesc.Text + " '," + bdeb + "," + bcre + ",0)");
                        //    //Fn.Exec("insert into TblVoucherDTL (VoucherID,AccEntryID,Description,AmountDeb,AmountCre,Repli) values('" + txtVid.Text + "','" + cmboEntry.SelectedValue + "','" + txtEntryDesc.Text + "'," + entDr + "," + entCr + ",0)");
                        //    //------------------------------
                        //    for (int i = 0; i <= tblVoucherDTLDataGridView.Rows.Count - 1; i++)
                        //    {
                        //        SqlCommand cmd = new SqlCommand();
                        //        cmd.CommandText = "insert into TblVoucherDTL (VoucherID,AccEntryID,Description,AmountDeb,AmountCre,Repli,Ref) values(" + txtVid.Text + ",@AccEntryID,@Description,@AmountDeb,@AmountCre,0,@Ref)";
                        //        cmd.Parameters.AddWithValue("@AccEntryID", tblVoucherDTLDataGridView.Rows[i].Cells[0].Tag);
                        //        cmd.Parameters.AddWithValue("@Description", tblVoucherDTLDataGridView.Rows[i].Cells[2].Value.Equals(null) ? "-" : tblVoucherDTLDataGridView.Rows[i].Cells[2].Value);
                        //        cmd.Parameters.AddWithValue("@AmountDeb", 0);
                        //        cmd.Parameters.AddWithValue("@AmountCre", tblVoucherDTLDataGridView.Rows[i].Cells[3].Value);
                        //        cmd.Parameters.AddWithValue("@Ref", tblVoucherDTLDataGridView.Rows[i].Cells["cboRef"].Value == null ? "0" : tblVoucherDTLDataGridView.Rows[i].Cells["cboRef"].Tag);
                        //        Fn.CmdExe(cmd);
                        //    }
                        //    //----------------------------
                        //}
                        //else
                        //{
                        //    txtVoucherNo.Clear();
                        //    Fn.GetNum(txtVoucherNo, "SELECT COUNT(*) AS V FROM TblVoucherHDR0 WHERE (CONVERT(varchar, MONTH(EntryDate)) + CONVERT(varchar, YEAR(EntryDate)) = '" + MyModule.AMonth + "') AND (VoucherNo LIKE N'CPV/%') AND (CompanyID =" + MyModule.CompID + ") AND (BranchID =" + cbLocation.SelectedValue + ")");
                        //    txtVoucherNo.Text = "CPV/" + txtVoucherNo.Text;
                        //    txtVid.Text = Fn.ExenID("insert into TblVoucherHDR0 (VoucherNo,EntryDate,Created,Modified,Repli,CompanyID,BranchID) values('" + txtVoucherNo.Text + "','" + entryDatePicker.Text + "','" + MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo + "','" + MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo + "',0," + MyModule.CompID + "," + cbLocation.SelectedValue + ") SELECT @@IDENTITY").ToString();
                        //    //Fn.Exec("insert into TblVoucherDTL (VoucherID,AccEntryID,Description,AmountDeb,AmountCre,Repli) values('" + txtVid.Text + "','" + cmboEntry.SelectedValue + "','" + txtEntryDesc.Text + "'," + entDr + "," + entCr + ",0)");
                        //    //------------------------------
                        //    for (int i = 0; i <= tblVoucherDTLDataGridView.Rows.Count - 1; i++)
                        //    {
                        //        SqlCommand cmd = new SqlCommand();
                        //        cmd.CommandText = "insert into TblVoucherDTL (VoucherID,AccEntryID,Description,AmountDeb,AmountCre,Repli,Ref) values(" + txtVid.Text + ",@AccEntryID,@Description,@AmountDeb,@AmountCre,0,@Ref)";
                        //        cmd.Parameters.AddWithValue("@AccEntryID", tblVoucherDTLDataGridView.Rows[i].Cells[0].Tag);
                        //        cmd.Parameters.AddWithValue("@Description", tblVoucherDTLDataGridView.Rows[i].Cells[2].Value.Equals(null) ? "-" : tblVoucherDTLDataGridView.Rows[i].Cells[2].Value);
                        //        cmd.Parameters.AddWithValue("@AmountDeb", tblVoucherDTLDataGridView.Rows[i].Cells[3].Value);
                        //        cmd.Parameters.AddWithValue("@AmountCre", 0);
                        //        cmd.Parameters.AddWithValue("@Ref", tblVoucherDTLDataGridView.Rows[i].Cells["cboRef"].Value == null ? "0" : tblVoucherDTLDataGridView.Rows[i].Cells["cboRef"].Tag);
                        //        Fn.CmdExe(cmd);
                        //    }
                        //    Fn.Exec("insert into TblVoucherDTL (VoucherID,AccEntryID,Description,AmountDeb,AmountCre,Repli) values(" + txtVid.Text + ",'" + cmboBank.SelectedValue + "','" + txtBankDesc.Text + " '," + bdeb + "," + bcre + ",0)");
                        //    //----------------------------
                        //}
                        btnSave.Text = "&Add New";
                        btnPrint.Enabled = true;
                        bexist = false;
                        groupBox4.Enabled = false;
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;
                        tblVoucherDTLDataGridView.Enabled = false;
                    }
                }
            }
        }
        private void tblVoucherDTLDataGridView_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 4)
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
            if (e.ColumnIndex == 4)
            {
                if (e.Value.ToString() == "System.Drawing.Bitmap")
                {
                    e.Value = global::AccountSystem.Properties.Resources.close;
                }
            }
        }
        private void tblVoucherDTLDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    txtOpenCash.Clear();
                    Fn.GetNum(txtOpenCash, "SELECT ISNULL(CONVERT(Varchar, SUM(VW_VoucherDTL.AmountDeb - VW_VoucherDTL.AmountCre)), '0') AS OpenBalance, TblAccSubHead.AccSubName + N' / ' + TblAccEntry.EntryAccName AS Expr1 FROM VW_VoucherHDR INNER JOIN VW_VoucherDTL ON VW_VoucherHDR.VoucherID = VW_VoucherDTL.VoucherID RIGHT OUTER JOIN TblAccSubHead INNER JOIN TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID ON VW_VoucherDTL.AccEntryID = TblAccEntry.EntryAccID WHERE (TblAccEntry.EntryAccID = " + tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells[0].Tag + ") AND (VW_VoucherHDR.BranchID = " + cbLocation.SelectedValue + ") GROUP BY TblAccSubHead.AccSubName + N' / ' + TblAccEntry.EntryAccName, TblAccSubHead.AccSubName, TblAccEntry.EntryAccName");
                    txtOpenCash.Text = txtOpenCash.Tag + " = " + String.Format("{0:#,0;(#,0)}", Convert.ToInt32(txtOpenCash.Text));
                    if (e.ColumnIndex == 4)
                    {
                        foreach (DataGridViewRow row in tblVoucherDTLDataGridView.SelectedRows)
                        {
                            try
                            {
                                tblVoucherDTLDataGridView.Rows.Remove(row);
                                tblVoucherDTLDataGridView.Height = tblVoucherDTLDataGridView.Height - 22;
                            }
                            catch { }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void tblVoucherDTLDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

        }
        private void fillHeads_R()
        {

            Fn.fillCombo(cboAcc, "SELECT TblAccEntry.EntryAccID,TblAccEntry.EntryAccName+' '+right(REPLICATE('0',2) + cast(TblAccHead.AccHeadCode as varchar(2)),2)+ '-' + right(REPLICATE('0',3) + cast(TblAccSubHead.AccSubCode as varchar(3)),3)+ '-' + right(REPLICATE('0',4) + cast(TblAccEntry.EntryAccCode as varchar(4)),4) FROM TblAccHead INNER JOIN TblAccSubHead ON TblAccHead.AccHeadID = TblAccSubHead.AccHeadID INNER JOIN TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID WHERE (TblAccHead.AccType <> N'Revenue') AND (TblAccEntry.AccType NOT IN (21, 22, 23)) AND (TblAccHead.CompanyID =" + MyModule.CompID + ") AND (TblAccEntry.Stat = 1) order by EntryAccName");
            cboAcc.Text = null; cbRef.Text = null;
        }
        private void fillHeads_E()
        {

            Fn.fillCombo(cboAcc, "SELECT TblAccEntry.EntryAccID, TblAccEntry.EntryAccName AS Expr1 FROM TblAccHead INNER JOIN TblAccSubHead ON TblAccHead.AccHeadID = TblAccSubHead.AccHeadID INNER JOIN TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID WHERE (TblAccHead.AccType <> N'Expenditure') AND (TblAccHead.CompanyID = 1) AND (TblAccEntry.Stat = 1) AND (TblAccEntry.AccType NOT IN (21, 22, 23)) AND (TblAccEntry.BranchID IS NULL OR TblAccEntry.BranchID = " + cbLocation.SelectedValue+ ") order by EntryAccName");
            cboAcc.Text = null; cbRef.Text = null;
        }
        private void frmCVoucher_Load(object sender, EventArgs e)
        {
           
            txtDr.Height = cboAcc.Height;
            txtNarr.Height = cboAcc.Height;
            Fn.fillCombo(cbLocation, "sp_OfficeLocations");
            cbLocation.SelectedValue = MyModule.BranchID;
            Fn.fillCombo(cbRef2, "select 0,null union SELECT EntryAccID, EntryAccName FROM TblAccEntry WHERE(AccType = 9)");
            //Fn.GetNum(txtVoucherNo, "SELECT COUNT(*) AS V FROM TblVoucherHDR0 WHERE (convert(date,EntryDate) between '" + MyModule.ActiveYear + "' and (DATEADD(MONTH,12, convert(datetime,'" + MyModule.ActiveYear + "'))-1)) AND (VoucherNo LIKE N'CRV/%') AND (CompanyID =" + MyModule.CompID + ") AND (BranchID =" + cbLocation.SelectedValue + ")");
            Fn.GetNum(txtVoucherNo, "SELECT COUNT(tbl.VoucherID) AS Voch FROM (SELECT VoucherID FROM TblVoucherDTL GROUP BY VoucherID) AS tbl INNER JOIN TblVoucherHDR ON tbl.VoucherID = TblVoucherHDR.VoucherID WHERE (convert(date,EntryDate) between '" + MyModule.ActiveYear + "' and (DATEADD(MONTH,12, convert(datetime,'" + MyModule.ActiveYear + "'))-1)) AND (VoucherNo LIKE N'CRV/%') AND (CompanyID =" + MyModule.CompID + ") AND (BranchID =" + cbLocation.SelectedValue + ")");
            txtVoucherNo.Text = "CRV/" + txtVoucherNo.Text;
            fillHeads_E();
            Fn.fillCombo(cmboBank, "SELECT EntryAccID, EntryAccName FROM TblAccEntry WHERE (AccType = 2) AND (Stat = 1)");
            string[] actDate = Fn.GetRecords("sp_ActiveDates");
            entryDatePicker.MaxDate = Convert.ToDateTime(actDate[1]);
            entryDatePicker.MinDate = Convert.ToDateTime(actDate[0]);
        }
        private void frmCVoucher_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bexist)
            {
                DialogResult result = new DialogResult();
                result = MessageBox.Show("Do you want to save changes you made to bank voucher?", "GM Soft", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    btnSave.PerformClick();
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {//////////////////////////////// to GL ///////////////////////////////////////////
            MyModule.ParmB = label10.Text;
            frmJVReport.Default.MdiParent = FrmMain.Default;
            MyModule.ParmD = txtVid.Text.ToString();
            MyModule.ParmA = Wrd.changeCurrencyToWords(entryAmount.Text.Replace(",", ""));
            frmJVReport.Default.Show(); frmJVReport.Default.Activate();
            //////////////////////////////// to GL end ///////////////////////////////////////////
            //MyModule.ParmA = lblinWords.Text;
            //if (txtVoucherNo.Text.Contains("CPV/"))
            //{
            //    frmGPVReport.Default.MdiParent = FrmMain.Default;
            //    MyModule.ParmD = txtVid.Text;
            //    frmGPVReport.Default.Show();
            //}
            //else
            //{
            //    frmGRVReport.Default.MdiParent = FrmMain.Default;
            //    MyModule.ParmD = txtVid.Text;
            //    frmGRVReport.Default.Show();
            //}
        }
        private void btnAddRow_Click(object sender, EventArgs e)
        {
            if (cboAcc.SelectedValue == null || txtDr.Value.ToString() == "0")
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
            tblVoucherDTLDataGridView.Rows[tblVoucherDTLDataGridView.RowCount - 1].Cells[3].Value = txtDr.Value;
            tblVoucherDTLDataGridView.Height = tblVoucherDTLDataGridView.Height + 22;
            cboAcc.Text = null; cboAcc.SelectedIndex = -1; cbRef.Text = null; txtNarr.Text = ""; txtDr.Value = 0; cbRef.Text = "";
            cboAcc.Focus();
            int counter = 0;
            Double sumcr = 0;
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
                tblVoucherDTLDataGridView.Rows[counter].Cells[3].Value = 0;
            }
            //txtAmount.Text = sumcr.ToString();
            entryAmount.Text = sumcr.ToString();
        }
        private void cboAcc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Fn.fillCombo(cbRef, "sp_PenddingInvoices " + cboAcc.SelectedValue);
                txtOpenCash.Clear();
                Fn.GetNum(txtOpenCash, "SELECT ISNULL(CONVERT(Varchar, format(SUM(VW_VoucherDTL.AmountDeb - VW_VoucherDTL.AmountCre),'#,#;(#,#)')), '0') AS OpenBalance, TblAccSubHead.AccSubName + N' / ' + TblAccEntry.EntryAccName AS Expr1 FROM VW_VoucherHDR INNER JOIN VW_VoucherDTL ON VW_VoucherHDR.VoucherID = VW_VoucherDTL.VoucherID RIGHT OUTER JOIN TblAccSubHead INNER JOIN TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID ON VW_VoucherDTL.AccEntryID = TblAccEntry.EntryAccID WHERE (TblAccEntry.EntryAccID = " + cboAcc.SelectedValue + ") AND (VW_VoucherHDR.BranchID = " + cbLocation.SelectedValue + ") GROUP BY TblAccSubHead.AccSubName + N' / ' + TblAccEntry.EntryAccName, TblAccSubHead.AccSubName, TblAccEntry.EntryAccName");
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
                if (RadioBankDeposit.Checked)
                {
                    Fn.GetNum(txtVoucherNo, "SELECT COUNT(*) AS V FROM TblVoucherHDR0 WHERE (convert(date,EntryDate) between '" + MyModule.ActiveYear + "' and (DATEADD(MONTH,12, convert(datetime,'" + MyModule.ActiveYear + "'))-1)) AND (VoucherNo LIKE N'CRV/%') AND (CompanyID =" + MyModule.CompID + ") AND (BranchID =" + cbLocation.SelectedValue + ")");
                    txtVoucherNo.Text = "CRV/" + txtVoucherNo.Text;
                }
                else
                {
                    Fn.GetNum(txtVoucherNo, "SELECT COUNT(*) AS V FROM TblVoucherHDR0 WHERE (convert(date,EntryDate) between '" + MyModule.ActiveYear + "' and (DATEADD(MONTH,12, convert(datetime,'" + MyModule.ActiveYear + "'))-1)) AND (VoucherNo LIKE N'CPV/%') AND (CompanyID =" + MyModule.CompID + ") AND (BranchID =" + cbLocation.SelectedValue + ")");
                    txtVoucherNo.Text = "CPV/" + txtVoucherNo.Text;
                }
                Fn.GetNum(txtOpenCash, "SELECT ISNULL(CONVERT(Varchar, format(SUM(VW_VoucherDTL.AmountDeb - VW_VoucherDTL.AmountCre),'#,#;(#,#)'))), '0') AS OpenBalance, TblAccSubHead.AccSubName + N' / ' + TblAccEntry.EntryAccName AS Expr1 FROM VW_VoucherHDR INNER JOIN VW_VoucherDTL ON VW_VoucherHDR.VoucherID = VW_VoucherDTL.VoucherID RIGHT OUTER JOIN TblAccSubHead INNER JOIN TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID ON VW_VoucherDTL.AccEntryID = TblAccEntry.EntryAccID WHERE (TblAccEntry.EntryAccID = " + cboAcc.SelectedValue + ") AND (VW_VoucherHDR.BranchID = " + cbLocation.SelectedValue + ") GROUP BY TblAccSubHead.AccSubName + N' / ' + TblAccEntry.EntryAccName, TblAccSubHead.AccSubName, TblAccEntry.EntryAccName");
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

        private void entryDatePicker_Enter(object sender, EventArgs e)
        {
            string[] actDate = Fn.GetRecords("sp_ActiveDates");
            entryDatePicker.MaxDate = Convert.ToDateTime(actDate[1]);
            entryDatePicker.MinDate = Convert.ToDateTime(actDate[0]);
        }

        private void cmboBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //-----------------------------SELECT CONVERT(Varchar, SUM(TblVoucherDTL.AmountCre - TblVoucherDTL.AmountDeb)) AS OpenBalance,   TblAccHead.AccHeadName + N' ->' + TblAccSubHead.AccSubName + N' ->' + TblAccEntry.EntryAccName AS Expr1 FROM TblAccSubHead INNER JOIN  TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID INNER JOIN  TblAccHead ON TblAccSubHead.AccHeadID = TblAccHead.AccHeadID LEFT OUTER JOIN  TblVoucherDTL ON TblAccEntry.EntryAccID = TblVoucherDTL.AccEntryID WHERE (TblAccEntry.EntryAccID = " + tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells[1].Value + ") GROUP BY TblAccHead.AccHeadName + N' ->' + TblAccSubHead.AccSubName + N' ->' + TblAccEntry.EntryAccName, TblAccSubHead.AccSubName, TblAccEntry.EntryAccName
                txtBOpening.Clear();
                Fn.GetNum(txtBOpening, "SELECT ISNULL(CONVERT(Varchar, format(SUM(VW_VoucherDTL.AmountDeb - VW_VoucherDTL.AmountCre),'#,#;(#,#)')), '0') AS OpenBalance, TblAccSubHead.AccSubName + N' / ' + TblAccEntry.EntryAccName AS Expr1 FROM TblAccSubHead INNER JOIN TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID LEFT OUTER JOIN VW_VoucherDTL ON TblAccEntry.EntryAccID = VW_VoucherDTL.AccEntryID WHERE (TblAccEntry.EntryAccID = " + cmboBank.SelectedValue + ") GROUP BY TblAccSubHead.AccSubName + N' / ' + TblAccEntry.EntryAccName, TblAccSubHead.AccSubName, TblAccEntry.EntryAccName");
                //Fn.GetNum(txtBOpening, "SELECT ISNULL(CONVERT(Varchar, SUM(convert(bigint,TblVoucherDTL.AmountDeb)-convert(bigint,TblVoucherDTL.AmountCre))), 'Nil') AS OpenBalance,   TblAccHead.AccHeadName + N' ->' + TblAccSubHead.AccSubName + N' ->' + TblAccEntry.EntryAccName AS Expr1 FROM TblAccSubHead INNER JOIN  TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID INNER JOIN  TblAccHead ON TblAccSubHead.AccHeadID = TblAccHead.AccHeadID LEFT OUTER JOIN  TblVoucherDTL ON TblAccEntry.EntryAccID = TblVoucherDTL.AccEntryID WHERE (TblAccEntry.EntryAccID = " + cmboBank.SelectedValue + ") GROUP BY TblAccHead.AccHeadName + N' ->' + TblAccSubHead.AccSubName + N' ->' + TblAccEntry.EntryAccName, TblAccSubHead.AccSubName, TblAccEntry.EntryAccName");
                txtBOpening.Text = txtBOpening.Text;
                //------------------------
            }
            catch
            {
                txtBOpening.Text = "";
            }
        }
        private void tblVoucherDTLDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                try
                {
                    //-----------------------------SELECT CONVERT(Varchar, SUM(TblVoucherDTL.AmountCre - TblVoucherDTL.AmountDeb)) AS OpenBalance,   TblAccHead.AccHeadName + N' ->' + TblAccSubHead.AccSubName + N' ->' + TblAccEntry.EntryAccName AS Expr1 FROM TblAccSubHead INNER JOIN  TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID INNER JOIN  TblAccHead ON TblAccSubHead.AccHeadID = TblAccHead.AccHeadID LEFT OUTER JOIN  TblVoucherDTL ON TblAccEntry.EntryAccID = TblVoucherDTL.AccEntryID WHERE (TblAccEntry.EntryAccID = " + tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells[1].Value + ") GROUP BY TblAccHead.AccHeadName + N' ->' + TblAccSubHead.AccSubName + N' ->' + TblAccEntry.EntryAccName, TblAccSubHead.AccSubName, TblAccEntry.EntryAccName
                    txtOpenCash.Clear();
                    Fn.GetNum(txtOpenCash, "SELECT ISNULL(CONVERT(Varchar, format(SUM(VW_VoucherDTL.AmountDeb - VW_VoucherDTL.AmountCre),'#,#;(#,#)'))), '0') AS OpenBalance, TblAccSubHead.AccSubName + N' / ' + TblAccEntry.EntryAccName AS Expr1 FROM VW_VoucherHDR INNER JOIN VW_VoucherDTL ON VW_VoucherHDR.VoucherID = VW_VoucherDTL.VoucherID RIGHT OUTER JOIN TblAccSubHead INNER JOIN TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID ON VW_VoucherDTL.AccEntryID = TblAccEntry.EntryAccID WHERE (TblAccEntry.EntryAccID = " + tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells[0].Tag + ") AND (VW_VoucherHDR.BranchID = " + cbLocation.SelectedValue + ") GROUP BY TblAccSubHead.AccSubName + N' / ' + TblAccEntry.EntryAccName, TblAccSubHead.AccSubName, TblAccEntry.EntryAccName");
                    txtOpenCash.Text = txtOpenCash.Tag + " = " + String.Format("{0:#,0;(#,0)}", Convert.ToInt32(txtOpenCash.Text));
                    //------------------------
                }
                catch
                {
                    txtOpenCash.Text = "";
                }
            }
        }
        private void tblVoucherDTLDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (RadioBankWidrw.Checked)
            {
                RadioBankDeposit.Checked = true;
            }
            else
            {
                RadioBankWidrw.Checked = true;
            }
        }
    }
}