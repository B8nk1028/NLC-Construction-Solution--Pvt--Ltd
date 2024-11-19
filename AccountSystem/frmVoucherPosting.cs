using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Newtonsoft.Json;
using SergeUtils;
namespace AccountSystem
{
    public partial class frmVoucherPosting : Form
    {
        private Boolean chkSave = default(Boolean);
        private MyModule Fn = new MyModule();
        private Words Wrd = new Words();
        private DateTimePicker cellDateTimePicker;
        public frmVoucherPosting()
        {
            InitializeComponent();
            if (defaultInstance == null)
                defaultInstance = this;
            this.cellDateTimePicker = new DateTimePicker();
            this.cellDateTimePicker.ValueChanged += new EventHandler(cellDateTimePickerValueChanged);
            this.cellDateTimePicker.Leave += new System.EventHandler(this.cellDateTimePicker_Leave);
            this.cellDateTimePicker.Visible = false;
            this.cellDateTimePicker.CustomFormat = "MMMM yyyy";
            this.cellDateTimePicker.Format = DateTimePickerFormat.Custom;
            this.cellDateTimePicker.ShowUpDown = true;
            this.cellDateTimePicker.ShowCheckBox = true;
            this.tblVoucherDTLDataGridView.Controls.Add(cellDateTimePicker);
        }
        #region Default Instance
        private static frmVoucherPosting defaultInstance;
        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static frmVoucherPosting Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new frmVoucherPosting();
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
            Fn.fillGrdCombo(cboEntryAcc, "SELECT EntryAccID, EntryAccName FROM TblAccEntry WHERE (Stat = 1) AND (AccType NOT IN (21, 22, 23)) ORDER BY EntryAccName");
            Fn.fillCombo(cbLocation, "sp_OfficeLocations");
            cbLocation.SelectedValue = MyModule.BranchID;
            Fn.fillCombo(cboAcc, "SELECT EntryAccID, EntryAccName FROM TblAccEntry WHERE (Stat = 1)");
            cboAcc.Text = null; cbRef.Text = null;
            cboVouType.Text = "JV-   Journal Voucher";
            Fn.GetNum(voucherN, "SELECT COUNT(tbl.VoucherID) AS Voch FROM (SELECT VoucherID FROM TblVoucherDTL GROUP BY VoucherID) AS tbl INNER JOIN TblVoucherHDR ON tbl.VoucherID = TblVoucherHDR.VoucherID WHERE (convert(date,EntryDate) between '" + MyModule.ActiveYear + "' and (DATEADD(MONTH,12, convert(datetime,'" + MyModule.ActiveYear + "'))-1)) AND (VoucherNo LIKE N'JV/%') AND (CompanyID =" + MyModule.CompID + ") AND (BranchID =" + cbLocation.SelectedValue + ")");
            voucherN.Text = "JV/" + voucherN.Text;
            string[] actDate = Fn.GetRecords("sp_ActiveDates");
            entryDateDateTimePicker.MaxDate = Convert.ToDateTime(actDate[1]);
            entryDateDateTimePicker.MinDate = Convert.ToDateTime(actDate[0]);
        }
        private void frmVoucher_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (chkSave == true)
            //{
            //    DialogResult response = default(DialogResult);
            //    response = MessageBox.Show("Do you want to save the changes", "Confirm to Save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            //    if (response == DialogResult.Yes)
            //    {
            //        if (lblTCr.Text != lblTDr.Text)
            //        {
            //            MessageBox.Show("Please check the entries Debit an Credit are not equel ...", "Debit != Credit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            e.Cancel = true;
            //        }
            //        btnSave.PerformClick();
            //    }
            //    else if (response == DialogResult.No)
            //    {
            //        //Fn.Exec("DELETE FROM TblVoucherHDR0 WHERE (VoucherID in (SELECT TblVoucherHDR0.VoucherID FROM TblVoucherDTL0 RIGHT OUTER JOIN TblVoucherHDR0 ON TblVoucherDTL0.VoucherID = TblVoucherHDR0.VoucherID GROUP BY TblVoucherHDR0.VoucherID HAVING (SUM(TblVoucherDTL0.AmountDeb - TblVoucherDTL0.AmountCre) <> 0) OR (SUM(TblVoucherDTL0.AmountDeb - TblVoucherDTL0.AmountCre) IS NULL))) AND (Created LIKE N'" + MyModule.UserName + "|%')");
            //    }
            //    else
            //    {
            //        e.Cancel = true;
            //    }
            //}
            //Fn.Exec("DELETE FROM TblVoucherHDR0 WHERE (VoucherID in (SELECT TblVoucherHDR0.VoucherID FROM TblVoucherDTL0 RIGHT OUTER JOIN TblVoucherHDR0 ON TblVoucherDTL0.VoucherID = TblVoucherHDR0.VoucherID GROUP BY TblVoucherHDR0.VoucherID HAVING (SUM(TblVoucherDTL0.AmountDeb - TblVoucherDTL0.AmountCre) <> 0) OR (SUM(TblVoucherDTL0.AmountDeb - TblVoucherDTL0.AmountCre) IS NULL))) AND (Created LIKE N'" + MyModule.UserName + "|%')");
        }
        private void cboVouType_SelectedIndexChanged(object sender, EventArgs e)
        {
            rfrsh();
        }
        private void rfrsh()
        {
            tblVoucherDTLDataGridView.Height = 0;
            tblVoucherDTLDataGridView.Rows.Clear();
            txtCheqNo.Clear(); lblTCr.Text = ""; lblTDr.Text = "";
            btnDiscard.Enabled = false;
            btnSave.Enabled = false;
            Fn.fillList(listVoucher, "SELECT TblVoucherHDR0.VoucherID, TblVoucherHDR0.VoucherNo FROM TblVoucherHDR0 INNER JOIN TblVoucherDTL0 ON TblVoucherHDR0.VoucherID = TblVoucherDTL0.VoucherID WHERE (TblVoucherHDR0.VoucherNo LIKE N'" + cboVouType.Text.Split('-')[0] + "%') AND (TblVoucherHDR0.VStatus = 0) AND (TblVoucherHDR0.BranchID = " + cbLocation.SelectedValue + ") GROUP BY TblVoucherHDR0.VoucherNo, TblVoucherHDR0.VoucherID order by convert(int,SUBSTRING( VoucherNo ,LEN(VoucherNo) -  CHARINDEX('/',REVERSE(VoucherNo)) + 2  , LEN(VoucherNo)))");
            Fn.GetNum(voucherN, "SELECT COUNT(tbl.VoucherID) AS Voch FROM (SELECT VoucherID FROM TblVoucherDTL GROUP BY VoucherID) AS tbl INNER JOIN TblVoucherHDR ON tbl.VoucherID = TblVoucherHDR.VoucherID WHERE (convert(date,EntryDate) between '" + MyModule.ActiveYear + "' and (DATEADD(MONTH,12, convert(datetime,'" + MyModule.ActiveYear + "'))-1)) AND (VoucherNo LIKE N'" + cboVouType.Text.Split('-')[0] + "/%') AND (CompanyID =" + MyModule.CompID + ") AND (BranchID =" + cbLocation.SelectedValue + ")");
            voucherN.Text = "" + cboVouType.Text.Split('-')[0] + "/" + voucherN.Text;
        }
        private void clear()
        {
            lblTCr.Text = "";
            lblTDr.Text = "";
            txtOpenCash.Clear();
            bankIDTextBox.Clear();
            tblVoucherDTLDataGridView.Rows.Clear();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "&Add New")
            {
                btnSave.Text = "Post to &GL";
                btnPrint.Enabled = false;
                entryDateDateTimePicker.Enabled = true;
                bankIDTextBox.Enabled = true;
                tblVoucherDTLDataGridView.Enabled = true;
                panel3.Visible = true;
                cboVouType.Enabled = true;
                tblVoucherDTLDataGridView.Height = 0;
                pnlBank.Enabled = true;
                rfrsh();
            }
            else
            {
                if (Fn.GetRecords("SELECT AccYear FROM tblMonthCloseing WHERE (AccYear <= CONVERT(DATETIME, '" + entryDateDateTimePicker.Text + "', 102))")[0] == "a")
                {
                    MessageBox.Show("Please enter a valid date ...", "Invaild Accounting Year ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
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
                                items = items + "," + "{\"AccEntryID\":" + JsonConvert.ToString(tblVoucherDTLDataGridView.Rows[i].Cells["cboEntryAcc"].Value) + ",\"Description\":" + JsonConvert.ToString(tblVoucherDTLDataGridView.Rows[i].Cells["Description"].Value) + ",\"AmountDeb\":" + JsonConvert.ToString(tblVoucherDTLDataGridView.Rows[i].Cells["DR"].Value.ToString().Replace(",", "")) + ",\"AmountCre\":" + JsonConvert.ToString(tblVoucherDTLDataGridView.Rows[i].Cells["Cr"].Value.ToString().Replace(",", "")) + ",\"Ref\":" + JsonConvert.ToString(tblVoucherDTLDataGridView.Rows[i].Cells["cboRef"].Tag) + ",\"ExpDT\":" + JsonConvert.ToString(tblVoucherDTLDataGridView.Rows[i].Cells["cExpDT"].Value) + "}";
                                if (tblVoucherDTLDataGridView.Rows[i].Cells["DR"].Value != null || Convert.ToDouble(tblVoucherDTLDataGridView.Rows[i].Cells["DR"].Value) != 0)
                                {
                                    DrAmt = DrAmt + Convert.ToDouble(tblVoucherDTLDataGridView.Rows[i].Cells["DR"].Value);
                                }
                                if (tblVoucherDTLDataGridView.Rows[i].Cells["Cr"].Value != null || Convert.ToDouble(tblVoucherDTLDataGridView.Rows[i].Cells["Cr"].Value) != 0)
                                {
                                    CrAmt = CrAmt + Convert.ToDouble(tblVoucherDTLDataGridView.Rows[i].Cells["DR"].Value);
                                }
                            }
                            if (CrAmt != DrAmt)
                            {
                                MessageBox.Show("Please check Dr. and Cr. not equivalent ...", "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            string Data2Post = "{\"EntryDate\":" + JsonConvert.ToString(entryDateDateTimePicker.Text) + ",\"Memo\":" + JsonConvert.ToString(bankIDTextBox.Text) + ",\"Created\":" + JsonConvert.ToString(MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo) + ",\"CompanyID\":" + JsonConvert.ToString(MyModule.CompID) + ",\"items\":[" + items.Substring(1) + "]}";
                            string ID = "a";
                            if (cboVouType.Text.Split('-')[0] == "JV")
                            {
                                ID = Fn.GetRecords("sp_CreateJV '" + Data2Post + "'," + cbLocation.SelectedValue)[0];
                            }
                            if (cboVouType.Text.Split('-')[0] == "CPV")
                            {
                                ID = Fn.GetRecords("sp_CreateCashVouchers '" + Data2Post + "'," + cbLocation.SelectedValue + ",'CPV'")[0];
                            }
                            if (cboVouType.Text.Split('-')[0] == "CRV")
                            {
                                ID = Fn.GetRecords("sp_CreateCashVouchers '" + Data2Post + "'," + cbLocation.SelectedValue + ",'CRV'")[0];
                            }
                            if (cboVouType.Text.Split('-')[0] == "BPV")
                            {
                                ID = Fn.GetRecords("sp_CreateBankVouchers '" + Data2Post + "'," + cbLocation.SelectedValue + ",'BPV','" + txtCheqNo.Text + "'")[0];
                            }
                            if (cboVouType.Text.Split('-')[0] == "BRV")
                            {
                                ID = Fn.GetRecords("sp_CreateBankVouchers '" + Data2Post + "'," + cbLocation.SelectedValue + ",'BRV','" + txtCheqNo.Text + "'")[0];
                            }
                            voucherN.Tag = ID;
                            if (ID == "a")
                            {
                                MessageBox.Show("There is some issue in data please check and try again", "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            Fn.Exec("UPDATE TblVoucherHDR0 SET VStatus = 2 WHERE (VoucherID = " + listVoucher.SelectedValue + ")");
                        }
                        btnDiscard.Enabled = false;
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
                if (tblVoucherDTLDataGridView.Rows[i].Cells["cboEntryAcc"].Value == null)
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
                txtOpenCash.Clear();
                Fn.GetNum(txtOpenCash, "SELECT ISNULL(CONVERT(Varchar, SUM(VW_VoucherDTL.AmountDeb - VW_VoucherDTL.AmountCre)), '0') AS OpenBalance, TblAccSubHead.AccSubName + N' / ' + TblAccEntry.EntryAccName AS Expr1 FROM VW_VoucherHDR INNER JOIN VW_VoucherDTL ON VW_VoucherHDR.VoucherID = VW_VoucherDTL.VoucherID RIGHT OUTER JOIN TblAccSubHead INNER JOIN TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID ON VW_VoucherDTL.AccEntryID = TblAccEntry.EntryAccID WHERE (TblAccEntry.EntryAccID = " + tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells["cboEntryAcc"].Tag + ") AND (VW_VoucherHDR.BranchID = " + cbLocation.SelectedValue + ") GROUP BY TblAccSubHead.AccSubName + N' / ' + TblAccEntry.EntryAccName, TblAccSubHead.AccSubName, TblAccEntry.EntryAccName");
                txtOpenCash.Text = txtOpenCash.Tag + " = " + String.Format("{0:#,0;(#,0)}", Convert.ToInt32(txtOpenCash.Text));
                //------------------------
            }
            catch
            {
                txtOpenCash.Text = "";
            }
            if (e.ColumnIndex == 6)
            {
                foreach (DataGridViewRow row in tblVoucherDTLDataGridView.SelectedRows)
                {
                    try
                    {
                        tblVoucherDTLDataGridView.Rows.Remove(row);
                        tblVoucherDTLDataGridView.Height = tblVoucherDTLDataGridView.Height - 21;
                        Fn.Exec("DELETE FROM TblVoucherDTL0 WHERE (ID = " + tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells["X"].Tag + ")");
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
                        Fn.GetNum(txtOpenCash, "SELECT ISNULL(CONVERT(Varchar, SUM(VW_VoucherDTL.AmountDeb - VW_VoucherDTL.AmountCre)), '0') AS OpenBalance, TblAccSubHead.AccSubName + N' / ' + TblAccEntry.EntryAccName AS Expr1 FROM VW_VoucherHDR INNER JOIN VW_VoucherDTL ON VW_VoucherHDR.VoucherID = VW_VoucherDTL.VoucherID RIGHT OUTER JOIN TblAccSubHead INNER JOIN TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID ON VW_VoucherDTL.AccEntryID = TblAccEntry.EntryAccID WHERE (TblAccEntry.EntryAccID = " + tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells["cboEntryAcc"].Tag + ") AND (VW_VoucherHDR.BranchID = " + cbLocation.SelectedValue + ") GROUP BY TblAccSubHead.AccSubName + N' / ' + TblAccEntry.EntryAccName, TblAccSubHead.AccSubName, TblAccEntry.EntryAccName");
                        txtOpenCash.Text = txtOpenCash.Tag + " = " + String.Format("{0:#,0;(#,0)}", Convert.ToInt32(txtOpenCash.Text));
                        //------------------------
                    }
                    catch
                    {
                        txtOpenCash.Text = "";
                    }
                }
                if (e.ColumnIndex == 4)
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
                if (e.ColumnIndex == 5)
                {
                    try
                    {
                        if (Convert.ToDouble(tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells["CR"].Value.Equals(System.DBNull.Value) ? 0 : tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells["CR"].Value) > 0)
                        {
                            tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells["Dr"].Value = 0;
                            tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells["Dr"].ReadOnly = true;
                        }
                        else
                        {
                            tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells["Dr"].ReadOnly = false;
                        }
                    }
                    catch
                    {
                        tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells["CR"].Value = 0;
                    }
                }
            }
        }
        private void tblVoucherDTLDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells["cboEntryAcc"].Value == null)
                {
                    //MessageBox.Show("Please select an account");
                    SendKeys.Send("{LEFT}");
                    //tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells["cboEntryAcc"].Selected = true;
                    //cb.Focus();
                }
                Fn.Exec("UPDATE TblVoucherDTL0 SET AccEntryID = " + tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells["cboEntryAcc"].Value.ToString().Replace(",", "") + ", Description = N'" + tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells["Description"].Value.ToString() + "', AmountDeb = " + tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells["Dr"].Value.ToString().Replace(",", "") + ", AmountCre = " + tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells["CR"].Value.ToString().Replace(",", "") + " WHERE (ID = " + tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells["X"].Tag + ")");
                if (e.ColumnIndex == 0)
                {
                    if (tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells["Description"].Value == null)
                    {
                        tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells["Description"].Value = tblVoucherDTLDataGridView.Rows[e.RowIndex - 1].Cells["cboRef"].Value;
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
                        sumcr = sumcr + Convert.ToDouble(tblVoucherDTLDataGridView.Rows[counter].Cells["Dr"].Value.Equals(System.DBNull.Value) ? 0 : tblVoucherDTLDataGridView.Rows[counter].Cells["Dr"].Value);
                        counter = counter + 1;
                    }
                }
                catch
                {
                }
                lblTCr.Text = String.Format("{0:#,#.00}", sumcr);
                lblWrdFig.Text = Wrd.changeNumericToWords(sumcr);
                try
                {
                    while ((counte < tblVoucherDTLDataGridView.Rows.Count))
                    {
                        sumdr = sumdr + Convert.ToDouble(tblVoucherDTLDataGridView.Rows[counte].Cells["CR"].Value.Equals(System.DBNull.Value) ? 0 : tblVoucherDTLDataGridView.Rows[counte].Cells["CR"].Value);
                        counte = counte + 1;
                    }
                }
                catch
                {
                }
                lblTDr.Text = String.Format("{0:#,#.00}", sumdr);



                int rw = tblVoucherDTLDataGridView.CurrentRow.Index;
                if (cellDateTimePicker.Checked && e.ColumnIndex==1)
                {
                    tblVoucherDTLDataGridView.Rows[rw].Cells["cExpDT"].Value = cellDateTimePicker.Value.ToString("MMMM yyyy");
                }
                else if (cellDateTimePicker.Checked=false && e.ColumnIndex == 1)
                {
   tblVoucherDTLDataGridView.Rows[rw].Cells["cExpDT"].Value = "";
                }

                cellDateTimePicker.Visible = false;
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
            if (e.ColumnIndex == 6)
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
            if (e.ColumnIndex == 6)
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
        {
            MyModule.ParmB = cboVouType.Text.Split('-')[1];
            frmJVReport.Default.MdiParent = FrmMain.Default;
            MyModule.ParmD = voucherN.Tag.ToString();
            MyModule.ParmA = Wrd.changeCurrencyToWords(lblTDr.Text.Replace(",", ""));
            frmJVReport.Default.Show(); frmJVReport.Default.Activate();
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
            tblVoucherDTLDataGridView.Rows[tblVoucherDTLDataGridView.RowCount - 1].Cells["cboEntryAcc"].Value = cboAcc.SelectedValue;
            tblVoucherDTLDataGridView.Rows[tblVoucherDTLDataGridView.RowCount - 1].Cells["cboEntryAcc"].Tag = cboAcc.SelectedValue;
            tblVoucherDTLDataGridView.Rows[tblVoucherDTLDataGridView.RowCount - 1].Cells["cboRef"].Value = cbRef.Text;
            tblVoucherDTLDataGridView.Rows[tblVoucherDTLDataGridView.RowCount - 1].Cells["cboRef"].Tag = cbRef.SelectedValue == null ? "0" : cbRef.SelectedValue;
            tblVoucherDTLDataGridView.Rows[tblVoucherDTLDataGridView.RowCount - 1].Cells["Description"].Value = txtNarr.Text;
            tblVoucherDTLDataGridView.Rows[tblVoucherDTLDataGridView.RowCount - 1].Cells["Dr"].Value = txtDr.Text;
            tblVoucherDTLDataGridView.Rows[tblVoucherDTLDataGridView.RowCount - 1].Cells["CR"].Value = txtCr.Text;
            if (txtExpDT.Checked)
            {
                tblVoucherDTLDataGridView.Rows[tblVoucherDTLDataGridView.RowCount - 1].Cells["cExpDT"].Value = txtExpDT.Text;
            }
            caclc();
            Fn.Exec("INSERT INTO TblVoucherDTL0 (VoucherID, AccEntryID, Description, AmountDeb, AmountCre) VALUES (" + listVoucher.SelectedValue + ", " + cboAcc.SelectedValue + ", N'" + txtNarr.Text + "', " + txtDr.Text + ", " + txtCr.Text + ")");
            tblVoucherDTLDataGridView.Height = tblVoucherDTLDataGridView.Height + 21;
            cboAcc.Text = ""; cboAcc.SelectedIndex = -1; cbRef.Text = ""; txtNarr.Text = ""; txtDr.Text = ""; txtCr.Text = ""; cbRef.Text = "";
            cboAcc.Focus(); txtDr.ReadOnly = false; txtCr.ReadOnly = false; txtExpDT.Checked = false;
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
                    sumcr = sumcr + Convert.ToDouble(tblVoucherDTLDataGridView.Rows[counter].Cells["Dr"].Value.Equals(System.DBNull.Value) ? 0 : tblVoucherDTLDataGridView.Rows[counter].Cells["Dr"].Value);
                    counter = counter + 1;
                }
            }
            catch
            {
            }
            lblTCr.Text = String.Format("{0:#,#.00}", sumcr);
            txtDiff.Text = String.Format("{0:#,#.00}", sumdr - sumcr);
            lblWrdFig.Text = Wrd.changeNumericToWords(sumcr);
            try
            {
                while ((counte < tblVoucherDTLDataGridView.Rows.Count))
                {
                    sumdr = sumdr + Convert.ToDouble(tblVoucherDTLDataGridView.Rows[counte].Cells["CR"].Value.Equals(System.DBNull.Value) ? 0 : tblVoucherDTLDataGridView.Rows[counte].Cells["CR"].Value);
                    counte = counte + 1;
                }
            }
            catch
            {
            }
            lblTDr.Text = String.Format("{0:#,#.00}", sumdr);
            txtDiff.Text = String.Format("{0:#,#.00}", sumdr - sumcr);
            //lblinWords.Text = Wrd.changeCurrencyToWords(Convert.ToString(sumdr));
        }
        void cellDateTimePickerValueChanged(object sender, EventArgs e)
        {
            int rw = tblVoucherDTLDataGridView.CurrentRow.Index;
            if (cellDateTimePicker.Checked)
            {
                tblVoucherDTLDataGridView.Rows[rw].Cells["cExpDT"].Value = cellDateTimePicker.Value.ToString("MMMM yyyy");
            }
            else
            {
                tblVoucherDTLDataGridView.Rows[rw].Cells["cExpDT"].Value = "";
            }
        }
        private void cellDateTimePicker_Leave(object sender, EventArgs e)
        {
            int rw = tblVoucherDTLDataGridView.CurrentRow.Index;
            if (cellDateTimePicker.Checked)
            {
                tblVoucherDTLDataGridView.Rows[rw].Cells["cExpDT"].Value = cellDateTimePicker.Value.ToString("MMMM yyyy");
            }
            else
            {
                tblVoucherDTLDataGridView.Rows[rw].Cells["cExpDT"].Value = "";
            }
            cellDateTimePicker.Visible = false;
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
        private void listVoucher_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable vDT = Fn.FillDSet("SELECT TblVoucherDTL0.ID,TblAccEntry.EntryAccName, TblVoucherDTL0.Description, TblVoucherDTL0.AmountDeb, TblVoucherDTL0.AmountCre, TblVoucherDTL0.Ref, TblVoucherHDR0.EntryDate, TblVoucherHDR0.Memo, TblVoucherHDR0.VoucherNo, TblVoucherHDR0.VoucherID, TblAccEntry.EntryAccID, TblVoucherHDR0.CheqNo,case when expDT>'1 JAN 2015' then format(expDT,'MMMM yyyy') else '' end ExpDT FROM TblVoucherHDR0 INNER JOIN TblVoucherDTL0 ON TblVoucherHDR0.VoucherID = TblVoucherDTL0.VoucherID INNER JOIN TblAccEntry ON TblVoucherDTL0.AccEntryID = TblAccEntry.EntryAccID WHERE (TblVoucherHDR0.VoucherID = " + listVoucher.SelectedValue + ") ORDER BY TblAccEntry.EntryAccName").Tables[0];
            tblVoucherDTLDataGridView.Height = 0;
            tblVoucherDTLDataGridView.Rows.Clear();
            btnDiscard.Enabled = true; btnSave.Enabled = true;
            entryDateDateTimePicker.Text = vDT.Rows[0]["EntryDate"].ToString();
            if (vDT.Rows[0]["CheqNo"].ToString() == "")
            {
                txtCheqNo.Visible = false;
                label4.Visible = false;
            }
            else
            {
                txtCheqNo.Visible = true;
                label4.Visible = true;
                txtCheqNo.Text = vDT.Rows[0]["CheqNo"].ToString();
            }
            for (int i = 0; i < vDT.Rows.Count; i++)
            {
                tblVoucherDTLDataGridView.Rows.Add();
                tblVoucherDTLDataGridView.Rows[tblVoucherDTLDataGridView.RowCount - 1].Cells["cboEntryAcc"].Value = vDT.Rows[i]["EntryAccID"];
                tblVoucherDTLDataGridView.Rows[tblVoucherDTLDataGridView.RowCount - 1].Cells["cboEntryAcc"].Tag = vDT.Rows[i]["EntryAccID"];
                tblVoucherDTLDataGridView.Rows[tblVoucherDTLDataGridView.RowCount - 1].Cells["cboRef"].Value = vDT.Rows[i]["Ref"].ToString() == "0" ? "" : vDT.Rows[i]["Ref"].ToString().Replace("S", "SL/").Replace("P", "PR/");
                tblVoucherDTLDataGridView.Rows[tblVoucherDTLDataGridView.RowCount - 1].Cells["cboRef"].Tag = vDT.Rows[i]["Ref"] == null ? "0" : vDT.Rows[i]["Ref"];
                tblVoucherDTLDataGridView.Rows[tblVoucherDTLDataGridView.RowCount - 1].Cells["Description"].Value = vDT.Rows[i]["Description"];
                tblVoucherDTLDataGridView.Rows[tblVoucherDTLDataGridView.RowCount - 1].Cells["cExpDT"].Value = vDT.Rows[i]["ExpDT"];
                tblVoucherDTLDataGridView.Rows[tblVoucherDTLDataGridView.RowCount - 1].Cells["Dr"].Value = vDT.Rows[i]["AmountDeb"];
                tblVoucherDTLDataGridView.Rows[tblVoucherDTLDataGridView.RowCount - 1].Cells["CR"].Value = vDT.Rows[i]["AmountCre"];
                tblVoucherDTLDataGridView.Rows[tblVoucherDTLDataGridView.RowCount - 1].Cells["X"].Tag = vDT.Rows[i]["ID"];
                tblVoucherDTLDataGridView.Height = tblVoucherDTLDataGridView.Height + 21;
            }
            caclc();
            cboAcc.Text = ""; cboAcc.SelectedIndex = -1; cbRef.Text = ""; txtNarr.Text = ""; txtDr.Text = ""; txtCr.Text = ""; cbRef.Text = "";
            cboAcc.Focus(); txtDr.ReadOnly = false; txtCr.ReadOnly = false;
        }
        private void btnDiscard_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to discard this voucher entry?";
            string title = "Voucher Discard";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Fn.Exec("UPDATE TblVoucherHDR0 SET VStatus = 1 WHERE (VoucherID = " + listVoucher.SelectedValue + ")");
                rfrsh();
            }
            else
            {
                return;
            }
        }

        private void tblVoucherDTLDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            var index = tblVoucherDTLDataGridView.CurrentCell.ColumnIndex;
            if (index == 1)
            {
                Rectangle tempRect = this.tblVoucherDTLDataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                cellDateTimePicker.Location = tempRect.Location;
                cellDateTimePicker.Width = tempRect.Width;
                try
                {
                    cellDateTimePicker.Value = DateTime.Parse(tblVoucherDTLDataGridView.CurrentCell.Value.ToString());
                }
                catch
                {
                    cellDateTimePicker.Value = DateTime.Now;
                    cellDateTimePicker.Checked = false;
                }
                cellDateTimePicker.Visible = true;
            }
            else
            {
                cellDateTimePicker.Visible = false;
            }
        }
    }
}