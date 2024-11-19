using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AccountSystem
{
    public partial class frmVoucherN : Form
    {
        private Boolean chkSave = default(Boolean);
        private MyModule Fn = new MyModule();
        private Words Wrd = new Words();

        public frmVoucherN()
        {
            InitializeComponent();
            if (defaultInstance == null)
                defaultInstance = this;
        }

        #region Default Instance

        private static frmVoucherN defaultInstance;

        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static frmVoucherN Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new frmVoucherN();
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

        private void frmVoucher_Load(object sender, EventArgs e)
        {
            cboVouType.Text = "Journal Voucher";
            Fn.GetNum(voucherN, "SELECT COUNT(tbl.VoucherID) AS Voch FROM (SELECT VoucherID FROM TblVoucherDTL GROUP BY VoucherID) AS tbl INNER JOIN TblVoucherHDR ON tbl.VoucherID = TblVoucherHDR.VoucherID WHERE (CONVERT(varchar, MONTH(EntryDate)) + CONVERT(varchar, YEAR(EntryDate)) = '" + MyModule.AMonth + "') AND (VoucherNo LIKE N'JV/%') AND (CompanyID =" + MyModule.CompID + ")");
            voucherN.Text = "JV/" + voucherN.Text;
            this.lblinWords.Parent = this.pictureBox1;
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
                    Fn.Exec("DELETE FROM TblVoucherHDR WHERE (VoucherID in (SELECT TblVoucherHDR.VoucherID FROM TblVoucherDTL RIGHT OUTER JOIN TblVoucherHDR ON TblVoucherDTL.VoucherID = TblVoucherHDR.VoucherID GROUP BY TblVoucherHDR.VoucherID HAVING (SUM(TblVoucherDTL.AmountDeb - TblVoucherDTL.AmountCre) <> 0) OR (SUM(TblVoucherDTL.AmountDeb - TblVoucherDTL.AmountCre) IS NULL))) AND (Created LIKE N'" + MyModule.UserName + "|%')");
                }
                else
                {
                    e.Cancel = true;
                }
            }
            Fn.Exec("DELETE FROM TblVoucherHDR WHERE (VoucherID in (SELECT TblVoucherHDR.VoucherID FROM TblVoucherDTL RIGHT OUTER JOIN TblVoucherHDR ON TblVoucherDTL.VoucherID = TblVoucherHDR.VoucherID GROUP BY TblVoucherHDR.VoucherID HAVING (SUM(TblVoucherDTL.AmountDeb - TblVoucherDTL.AmountCre) <> 0) OR (SUM(TblVoucherDTL.AmountDeb - TblVoucherDTL.AmountCre) IS NULL))) AND (Created LIKE N'" + MyModule.UserName + "|%')");
        }

        private ComboBox cb = new ComboBox();

        private void cboVouType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboVouType.Text == "Journal Voucher")
            {
                Fn.GetNum(voucherN, "SELECT COUNT(tbl.VoucherID) AS Voch FROM (SELECT VoucherID FROM TblVoucherDTL GROUP BY VoucherID) AS tbl INNER JOIN TblVoucherHDR ON tbl.VoucherID = TblVoucherHDR.VoucherID WHERE (CONVERT(varchar, MONTH(EntryDate)) + CONVERT(varchar, YEAR(EntryDate)) = '" + MyModule.AMonth + "') AND (VoucherNo LIKE N'JV/%') AND (CompanyID =" + MyModule.CompID + ")");
                voucherN.Text = "JV/" + voucherN.Text;
            }
            else if (cboVouType.Text == "Grant Payment Voucher")
            {
                Fn.GetNum(voucherN, "SELECT COUNT(tbl.VoucherID) AS Voch FROM (SELECT VoucherID FROM TblVoucherDTL GROUP BY VoucherID) AS tbl INNER JOIN TblVoucherHDR ON tbl.VoucherID = TblVoucherHDR.VoucherID WHERE (CONVERT(varchar, MONTH(EntryDate)) + CONVERT(varchar, YEAR(EntryDate)) = '" + MyModule.AMonth + "') AND (VoucherNo LIKE N'GPV/%') AND (CompanyID =" + MyModule.CompID + ")");
                voucherN.Text = "GPV/" + voucherN.Text;
            }
            else if (cboVouType.Text == "Grant Receipt Voucher")
            {
                Fn.GetNum(voucherN, "SELECT COUNT(tbl.VoucherID) AS Voch FROM (SELECT VoucherID FROM TblVoucherDTL GROUP BY VoucherID) AS tbl INNER JOIN TblVoucherHDR ON tbl.VoucherID = TblVoucherHDR.VoucherID WHERE (CONVERT(varchar, MONTH(EntryDate)) + CONVERT(varchar, YEAR(EntryDate)) = '" + MyModule.AMonth + "') AND (VoucherNo LIKE N'GRV/%') AND (CompanyID =" + MyModule.CompID + ")");
                voucherN.Text = "GRV/" + voucherN.Text;
            }
            else if (cboVouType.Text == "Security Payment Voucher")
            {
                Fn.GetNum(voucherN, "SELECT COUNT(tbl.VoucherID) AS Voch FROM (SELECT VoucherID FROM TblVoucherDTL GROUP BY VoucherID) AS tbl INNER JOIN TblVoucherHDR ON tbl.VoucherID = TblVoucherHDR.VoucherID WHERE (CONVERT(varchar, MONTH(EntryDate)) + CONVERT(varchar, YEAR(EntryDate)) = '" + MyModule.AMonth + "') AND (VoucherNo LIKE N'SPV/%') AND (CompanyID =" + MyModule.CompID + ")");
                voucherN.Text = "SPV/" + voucherN.Text;
            }
            else if (cboVouType.Text == "Security Receipt Voucher")
            {
                Fn.GetNum(voucherN, "SELECT COUNT(tbl.VoucherID) AS Voch FROM (SELECT VoucherID FROM TblVoucherDTL GROUP BY VoucherID) AS tbl INNER JOIN TblVoucherHDR ON tbl.VoucherID = TblVoucherHDR.VoucherID WHERE (CONVERT(varchar, MONTH(EntryDate)) + CONVERT(varchar, YEAR(EntryDate)) = '" + MyModule.AMonth + "') AND (VoucherNo LIKE N'SRV/%') AND (CompanyID =" + MyModule.CompID + ")");
                voucherN.Text = "SRV/" + voucherN.Text;
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
                cboVouType.Enabled = true;
                clear();
                Fn.GetNum(voucherN, "SELECT COUNT(tbl.VoucherID) AS Voch FROM (SELECT VoucherID FROM TblVoucherDTL GROUP BY VoucherID) AS tbl INNER JOIN TblVoucherHDR ON tbl.VoucherID = TblVoucherHDR.VoucherID WHERE (CONVERT(varchar, MONTH(EntryDate)) + CONVERT(varchar, YEAR(EntryDate)) = '" + MyModule.AMonth + "') AND (VoucherNo LIKE N'JV/%') AND (CompanyID =" + MyModule.CompID + ")");
                voucherN.Text = "JV/" + voucherN.Text;
                cboVouType.Text = "Journal Voucher";
            }
            else
            {
                if (MyModule.AMonth == Convert.ToDateTime(entryDateDateTimePicker.Text).ToString("Myyyy"))
                {
                    if (lblTCr.Text != lblTDr.Text | lblTDr.Text == "00")
                    {
                        MessageBox.Show("Please check the entries debit and credit are not equel" + Environment.NewLine + "Can’t save blank voucher!", "Debit != Credit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        voucherN.Tag = Fn.ExenID("insert into TblVoucherHDR (VoucherNo,EntryDate,Created,Modified,Repli,CompanyID,Memo) values('" + voucherN.Text + "','" + entryDateDateTimePicker.Text + "','" + MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo + "','" + MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo + "',0," + MyModule.CompID + ",'" + bankIDTextBox.Text + "') SELECT @@IDENTITY").ToString();

                        for (int i = 0; i <= tblVoucherDTLDataGridView.Rows.Count - 2; i++)
                        {
                            SqlCommand cmd = new SqlCommand();
                            cmd.CommandText = "insert into TblVoucherDTL (VoucherID,AccEntryID,Description,AmountDeb,AmountCre,Repli) values(" + voucherN.Tag + ",@AccEntryID,@Description,@AmountDeb,@AmountCre,0)";

                            cmd.Parameters.AddWithValue("@AccEntryID", tblVoucherDTLDataGridView.Rows[i].Cells[0].Value);
                            cmd.Parameters.AddWithValue("@Description", tblVoucherDTLDataGridView.Rows[i].Cells[1].Value == null ? "-" : tblVoucherDTLDataGridView.Rows[i].Cells[1].Value);
                            cmd.Parameters.AddWithValue("@AmountDeb", tblVoucherDTLDataGridView.Rows[i].Cells[2].Value);
                            cmd.Parameters.AddWithValue("@AmountCre", tblVoucherDTLDataGridView.Rows[i].Cells[3].Value);
                            Fn.CmdExe(cmd);
                        }
                        //----------------------------
                    }
                    btnSave.Text = "&Add New";
                    btnPrint.Enabled = true;
                    chkSave = false;
                    entryDateDateTimePicker.Enabled = false;
                    bankIDTextBox.Enabled = false;
                    tblVoucherDTLDataGridView.Enabled = false;
                    cboVouType.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Please enter a valid date ...", "Running Mouth is " + MyModule.AMonth, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void tblVoucherDTLDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //-----------------------------SELECT CONVERT(Varchar, SUM(TblVoucherDTL.AmountCre - TblVoucherDTL.AmountDeb)) AS OpenBalance,   TblAccHead.AccHeadName + N' ->' + TblAccSubHead.AccSubName + N' ->' + TblAccEntry.EntryAccName AS Expr1 FROM TblAccSubHead INNER JOIN  TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID INNER JOIN  TblAccHead ON TblAccSubHead.AccHeadID = TblAccHead.AccHeadID LEFT OUTER JOIN  TblVoucherDTL ON TblAccEntry.EntryAccID = TblVoucherDTL.AccEntryID WHERE (TblAccEntry.EntryAccID = " + tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells[1].Value + ") GROUP BY TblAccHead.AccHeadName + N' ->' + TblAccSubHead.AccSubName + N' ->' + TblAccEntry.EntryAccName, TblAccSubHead.AccSubName, TblAccEntry.EntryAccName
                txtOpenCash.Clear();
                Fn.GetNum(txtOpenCash, "SELECT ISNULL(CONVERT(Varchar, SUM(TblVoucherDTL.AmountDeb-TblVoucherDTL.AmountCre)), 'Nil') AS OpenBalance,   TblAccHead.AccHeadName + N' ->' + TblAccSubHead.AccSubName + N' ->' + TblAccEntry.EntryAccName AS Expr1 FROM TblAccSubHead INNER JOIN  TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID INNER JOIN  TblAccHead ON TblAccSubHead.AccHeadID = TblAccHead.AccHeadID LEFT OUTER JOIN  TblVoucherDTL ON TblAccEntry.EntryAccID = TblVoucherDTL.AccEntryID WHERE (TblAccEntry.EntryAccID = " + tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells[0].Value + ") GROUP BY TblAccHead.AccHeadName + N' ->' + TblAccSubHead.AccSubName + N' ->' + TblAccEntry.EntryAccName, TblAccSubHead.AccSubName, TblAccEntry.EntryAccName");
                txtOpenCash.Text = txtOpenCash.Tag + " = " + String.Format("{0:#,#.00}", txtOpenCash.Text);
                //------------------------
            }
            catch
            {
                txtOpenCash.Text = "";
            }
            if (e.ColumnIndex == 0)
            {
                if (Fn.GetRecords("SELECT CodeSt FROM tblMonthCloseing WHERE (CompID =" + MyModule.CompID + ")")[0] == "True")
                {
                    Fn.fillGridCbo(cboEntryAcc, "SELECT TblAccEntry.EntryAccID,right(REPLICATE('0',2) + cast(TblAccHead.AccHeadCode as varchar(2)),2)+ '-' + right(REPLICATE('0',3) + cast(TblAccSubHead.AccSubCode as varchar(3)),3)+ '-' + right(REPLICATE('0',4) + cast(TblAccEntry.EntryAccCode as varchar(4)),4)+' '+TblAccEntry.EntryAccName FROM TblAccHead INNER JOIN TblAccSubHead ON TblAccHead.AccHeadID = TblAccSubHead.AccHeadID INNER JOIN TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID WHERE (TblAccHead.CompanyID =" + MyModule.CompID + ")");
                }
                else
                {
                    Fn.fillGridCbo(cboEntryAcc, "SELECT TblAccEntry.EntryAccID,TblAccEntry.EntryAccName+' '+right(REPLICATE('0',2) + cast(TblAccHead.AccHeadCode as varchar(2)),2)+ '-' + right(REPLICATE('0',3) + cast(TblAccSubHead.AccSubCode as varchar(3)),3)+ '-' + right(REPLICATE('0',4) + cast(TblAccEntry.EntryAccCode as varchar(4)),4) FROM TblAccHead INNER JOIN TblAccSubHead ON TblAccHead.AccHeadID = TblAccSubHead.AccHeadID INNER JOIN TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID WHERE (TblAccHead.CompanyID =" + MyModule.CompID + ")");
                }                //Fn.fillGridCbo(cboEntryAcc, "SELECT TblAccEntry.EntryAccID, TblAccEntry.EntryAccName+'('+AccSubName+')' AS Expr1  FROM TblAccHead INNER JOIN TblAccSubHead ON TblAccHead.AccHeadID = TblAccSubHead.AccHeadID INNER JOIN TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID WHERE (TblAccHead.CompanyID =" + MyModule.CompID + ") ORDER BY Expr1");
            }
            if (e.ColumnIndex == 4)
            {
                foreach (DataGridViewRow row in tblVoucherDTLDataGridView.SelectedRows)
                {
                    try
                    {
                        tblVoucherDTLDataGridView.Rows.Remove(row);
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
                        //-----------------------------SELECT CONVERT(Varchar, SUM(TblVoucherDTL.AmountCre - TblVoucherDTL.AmountDeb)) AS OpenBalance,   TblAccHead.AccHeadName + N' ->' + TblAccSubHead.AccSubName + N' ->' + TblAccEntry.EntryAccName AS Expr1 FROM TblAccSubHead INNER JOIN  TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID INNER JOIN  TblAccHead ON TblAccSubHead.AccHeadID = TblAccHead.AccHeadID LEFT OUTER JOIN  TblVoucherDTL ON TblAccEntry.EntryAccID = TblVoucherDTL.AccEntryID WHERE (TblAccEntry.EntryAccID = " + tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells[1].Value + ") GROUP BY TblAccHead.AccHeadName + N' ->' + TblAccSubHead.AccSubName + N' ->' + TblAccEntry.EntryAccName, TblAccSubHead.AccSubName, TblAccEntry.EntryAccName
                        txtOpenCash.Clear();
                        Fn.GetNum(txtOpenCash, "SELECT ISNULL(CONVERT(Varchar, SUM(TblVoucherDTL.AmountDeb-TblVoucherDTL.AmountCre)), 'Nil') AS OpenBalance,   TblAccHead.AccHeadName + N' ->' + TblAccSubHead.AccSubName + N' ->' + TblAccEntry.EntryAccName AS Expr1 FROM TblAccSubHead INNER JOIN  TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID INNER JOIN  TblAccHead ON TblAccSubHead.AccHeadID = TblAccHead.AccHeadID LEFT OUTER JOIN  TblVoucherDTL ON TblAccEntry.EntryAccID = TblVoucherDTL.AccEntryID WHERE (TblAccEntry.EntryAccID = " + tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells[0].Value + ") GROUP BY TblAccHead.AccHeadName + N' ->' + TblAccSubHead.AccSubName + N' ->' + TblAccEntry.EntryAccName, TblAccSubHead.AccSubName, TblAccEntry.EntryAccName");
                        txtOpenCash.Text = txtOpenCash.Tag + " = " + String.Format("{0:#,#.00}", txtOpenCash.Text);
                        //------------------------
                    }
                    catch
                    {
                        txtOpenCash.Text = "";
                    }
                }
                if (e.ColumnIndex == 2)
                {
                    try
                    {
                        if (Convert.ToDouble(tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells[2].Value.Equals(null) ? 0 : tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells[2].Value) > 0)
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
                        tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells[2].Value = 0;
                    }
                }
                if (e.ColumnIndex == 3)
                {
                    try
                    {
                        if (Convert.ToDouble(tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells[3].Value.Equals(System.DBNull.Value) ? 0 : tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells[3].Value) > 0)
                        {
                            tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells[2].Value = 0;
                            tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells[2].ReadOnly = true;
                        }
                        else
                        {
                            tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells[2].ReadOnly = false;
                        }
                    }
                    catch
                    {
                        tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells[3].Value = 0;
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
                    MessageBox.Show("Please select an account");
                }
                if (e.ColumnIndex == 0)
                {
                    if (tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells[1].Value == null)
                    {
                        tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells[1].Value = tblVoucherDTLDataGridView.Rows[e.RowIndex - 1].Cells[1].Value;
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
                        sumcr = sumcr + Convert.ToDouble(tblVoucherDTLDataGridView.Rows[counter].Cells[2].Value.Equals(System.DBNull.Value) ? 0 : tblVoucherDTLDataGridView.Rows[counter].Cells[2].Value);

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
                        sumdr = sumdr + Convert.ToDouble(tblVoucherDTLDataGridView.Rows[counte].Cells[3].Value.Equals(System.DBNull.Value) ? 0 : tblVoucherDTLDataGridView.Rows[counte].Cells[3].Value);

                        counte = counte + 1;
                    }
                }
                catch
                {
                }

                lblTDr.Text = String.Format("{0:#,#.00}", sumdr);
                lblinWords.Text = Wrd.changeCurrencyToWords(Convert.ToString(sumdr));
            }
        }

        private void tblVoucherDTLDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is ComboBox)
            {
                cb = (ComboBox)e.Control;
                cb.DropDownStyle = ComboBoxStyle.DropDown;
                cb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cb.AutoCompleteSource = AutoCompleteSource.ListItems;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MyModule.ParmB = cboVouType.Text;
            MyModule.ParmA = lblinWords.Text;
            frmJVReport.Default.MdiParent = FrmMain.Default;
            MyModule.ParmC = Convert.ToInt32(voucherN.Tag);
            frmJVReport.Default.Show();
        }
    }
}