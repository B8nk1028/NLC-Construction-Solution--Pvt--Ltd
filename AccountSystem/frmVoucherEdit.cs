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
    public partial class frmVoucherEdit : Form
    {
        private Boolean chkSave = default(Boolean);
        private MyModule Fn = new MyModule();
        private Words Wrd = new Words(); private DateTimePicker cellDateTimePicker;
        public frmVoucherEdit()
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
        private static frmVoucherEdit defaultInstance;
        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static frmVoucherEdit Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new frmVoucherEdit();
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
        private void cellDateTimePickerValueChanged(object sender, EventArgs e)
        {
            int rw = tblVoucherDTLDataGridView.CurrentRow.Index;
            if (cellDateTimePicker.Checked)
            {
                tblVoucherDTLDataGridView.Rows[rw].Cells["cExpDT"].Value = cellDateTimePicker.Value.ToString("MMMM yyyy");
                tblVoucherDTLDataGridView.Rows[rw].Cells["Expr1"].Value = cellDateTimePicker.Value.ToString("dd MMMM yyyy");
            }
            else
            {
                tblVoucherDTLDataGridView.Rows[rw].Cells["cExpDT"].Value = "";
                tblVoucherDTLDataGridView.Rows[rw].Cells["Expr1"].Value = "";
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
        private void frmVoucher_Load(object sender, EventArgs e)
        {
            Fn.fillGrdCombo(cboEntryAcc, "SELECT EntryAccID, EntryAccName FROM TblAccEntry WHERE (Stat = 1) ORDER BY EntryAccName");
            btnPrint.Enabled = true;
            Fn.fillCombo(cbLocation, "sp_OfficeLocations");
            cbLocation.SelectedValue = MyModule.BranchID;
            //Fn.fillGrdCombo(refDataGridViewTextBoxColumn, "sp_PenddingInvoices " + accEntryIDDataGridViewTextBoxColumn);
            cboVouType.Text = "JV-   Journal Voucher";
            Fn.GetNum(voucherN, "SELECT COUNT(tbl.VoucherID) AS Voch FROM (SELECT VoucherID FROM TblVoucherDTL GROUP BY VoucherID) AS tbl INNER JOIN TblVoucherHDR ON tbl.VoucherID = TblVoucherHDR.VoucherID WHERE (convert(date,EntryDate) between '" + MyModule.ActiveYear + "' and (DATEADD(MONTH,12, convert(datetime,'" + MyModule.ActiveYear + "'))-1)) AND (VoucherNo LIKE N'JV/%') AND (CompanyID =" + MyModule.CompID + ") AND (BranchID =" + cbLocation.SelectedValue + ")");
            voucherN.Text = "JV/" + voucherN.Text;
            //string[] actDate = Fn.GetRecords("sp_ActiveDates");
            //entryDateDateTimePicker.MaxDate = Convert.ToDateTime(actDate[1]);
            //entryDateDateTimePicker.MinDate = Convert.ToDateTime(actDate[0]);
        }
        private void frmVoucher_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (chkSave == true)
            //{
            //    DialogResult response = default(DialogResult);
            //    response = MessageBox.Show("Do you want to save the changes", "Confirm to Save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            //    if (response == DialogResult.Yes)
            //    {
            //if (lblTCr.Text != lblTDr.Text)
            //{
            //    MessageBox.Show("Please check the entries Debit an Credit are not equel ...", "Debit != Credit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    e.Cancel = true;
            //}
            //        btnSave.PerformClick();
            //    }
            //    else if (response == DialogResult.No)
            //    {
            //        //Fn.Exec("DELETE FROM TblVoucherHDR WHERE (VoucherID in (SELECT TblVoucherHDR.VoucherID FROM TblVoucherDTL RIGHT OUTER JOIN TblVoucherHDR ON TblVoucherDTL.VoucherID = TblVoucherHDR.VoucherID GROUP BY TblVoucherHDR.VoucherID HAVING (SUM(TblVoucherDTL.AmountDeb - TblVoucherDTL.AmountCre) <> 0) OR (SUM(TblVoucherDTL.AmountDeb - TblVoucherDTL.AmountCre) IS NULL))) AND (Created LIKE N'" + MyModule.UserName + "|%')");
            //    }
            //    else
            //    {
            //        e.Cancel = true;
            //    }
            //}
            //Fn.Exec("DELETE FROM TblVoucherHDR WHERE (VoucherID in (SELECT TblVoucherHDR.VoucherID FROM TblVoucherDTL RIGHT OUTER JOIN TblVoucherHDR ON TblVoucherDTL.VoucherID = TblVoucherHDR.VoucherID GROUP BY TblVoucherHDR.VoucherID HAVING (SUM(TblVoucherDTL.AmountDeb - TblVoucherDTL.AmountCre) <> 0) OR (SUM(TblVoucherDTL.AmountDeb - TblVoucherDTL.AmountCre) IS NULL))) AND (Created LIKE N'" + MyModule.UserName + "|%')");
        }
        private void cboVouType_SelectedIndexChanged(object sender, EventArgs e)
        {
            rfrsh();
        }
        private void rfrsh()
        {
            tblVoucherDTLDataGridView.Height = 0;
            //tblVoucherDTLDataGridView.Rows.Clear();
            txtCheqNo.Clear(); lblTCr.Text = ""; lblTDr.Text = "";
            //btnSave.Enabled = false;
            Fn.fillList(listVoucher, "SELECT TblVoucherHDR.VoucherID, TblVoucherHDR.VoucherNo FROM TblVoucherHDR INNER JOIN TblVoucherDTL ON TblVoucherHDR.VoucherID = TblVoucherDTL.VoucherID WHERE (TblVoucherHDR.VoucherNo LIKE N'" + cboVouType.Text.Split('-')[0] + "%') AND (TblVoucherHDR.BranchID = " + cbLocation.SelectedValue + ") AND (TblVoucherHDR.EntryDate between (SELECT AccYear FROM tblMonthCloseing) and (SELECT DATEADD(DAY,-1,(DATEADD(year,1,AccYear))) FROM tblMonthCloseing)) GROUP BY TblVoucherHDR.VoucherNo, TblVoucherHDR.VoucherID  order by convert(int,substring(VoucherNo, PatIndex('%[0-9]%', VoucherNo), len(VoucherNo)))");
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
            if (lblTCr.Text != lblTDr.Text)
            {
                MessageBox.Show("Please check the entries Debit an Credit are not equel ...", "Debit != Credit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            this.Validate();
            this.tblVoucherDTLBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.voucherEd);
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
                        tblVoucherDTLDataGridView.Height = tblVoucherDTLDataGridView.Height - 22;
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
                            try
                            {
                                tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells["Dr"].Value = 0;
                                tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells["Dr"].ReadOnly = true;
                            }
                            catch (Exception ex)
                            {
                            }
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
            if (e.RowIndex > 0)
            {
                if (tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells["cboEntryAcc"].Value == null)
                {
                    //MessageBox.Show("Please select an account");
                    SendKeys.Send("{LEFT}");
                    //tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells["cboEntryAcc"].Selected = true;
                    //cb.Focus();
                }
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
                if (cellDateTimePicker.Checked && e.ColumnIndex == 1)
                {
                    tblVoucherDTLDataGridView.Rows[rw].Cells["cExpDT"].Value = cellDateTimePicker.Value.ToString("MMMM yyyy");
                    tblVoucherDTLDataGridView.Rows[rw].Cells["Expr1"].Value = cellDateTimePicker.Value.ToString("dd MMMM yyyy");
                }
                else if (cellDateTimePicker.Checked = false && e.ColumnIndex == 1)
                {
                    tblVoucherDTLDataGridView.Rows[rw].Cells["cExpDT"].Value = "";
                    tblVoucherDTLDataGridView.Rows[rw].Cells["Expr1"].Value = "";
                }
                cellDateTimePicker.Visible = false;
            }
        }
        private System.Windows.Forms.ComboBox AccTitle;
        private System.Windows.Forms.TextBox Ref;
        private void tblVoucherDTLDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //if (tblVoucherDTLDataGridView.CurrentCell.ColumnIndex == 0)
            //{
            //    AccTitle = (ComboBox)e.Control;
            //    AccTitle.TextChanged += new EventHandler(AccTitle_TextChanged);
            //}
            //if (tblVoucherDTLDataGridView.CurrentCell.ColumnIndex == 1)
            //{
            //    Ref = (TextBox)e.Control;
            //    string[] dd = Fn.GetRecords("sp_PenddingInvoices " + AccTitle.SelectedValue);
            //    Ref.Text = dd[1];
            //}
            //if (e.Control is ComboBox)
            //{
            //    cb = (ComboBox)e.Control;
            //    cb.DropDownStyle = ComboBoxStyle.DropDown;
            //    cb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //    cb.AutoCompleteSource = AutoCompleteSource.ListItems;
            //    cb.Text = null;
            //}
        }
        void AccTitle_TextChanged(object sender, EventArgs e)
        {
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
            //if (tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells["Dr"].Value.ToString()=="0")
            //{
            //    tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells["Dr"].ReadOnly = true;
            //    tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells["CR"].ReadOnly = false;
            //}
            //if (tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells["CR"].Value.ToString() == "0")
            //{
            //    tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells["CR"].ReadOnly = true;
            //    tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells["Dr"].ReadOnly = false;
            //}

            //if (e.ColumnIndex == 6)
            //{
            //    if (e.Value.ToString() == "System.Drawing.Bitmap")
            //    {
            //        e.Value = global::AccountSystem.Properties.Resources.close;
            //    }
            //}
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
            MyModule.ParmA = Wrd.changeCurrencyToWords(Convert.ToString(lblTDr.Text));
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
            //lblinWords.Text = Wrd.changeCurrencyToWords(Convert.ToString(sumdr));
        }
        private void cboAcc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtOpenCash.Clear();
                txtOpenCash.Text = txtOpenCash.Tag + " = " + String.Format("{0:#,0;(#,0)}", Convert.ToInt32(txtOpenCash.Text));
                //------------------------
            }
            catch
            {
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
                    Fn.GetNum(voucherN, "SELECT COUNT(tbl.VoucherID) AS Voch FROM (SELECT VoucherID FROM TblVoucherDTL GROUP BY VoucherID) AS tbl INNER JOIN TblVoucherHDR ON tbl.VoucherID = TblVoucherHDR.VoucherID WHERE (convert(date,EntryDate) between '" + MyModule.ActiveYear + "' and (DATEADD(MONTH,12, convert(datetime,'" + MyModule.ActiveYear + "'))-1)) AND (VoucherNo LIKE N'JV/%') AND (CompanyID =" + MyModule.CompID + ") AND (BranchID =" + cbLocation.SelectedValue + ")");
                    voucherN.Text = "JV/" + voucherN.Text;
                }
                txtOpenCash.Text = txtOpenCash.Tag + " = " + String.Format("{0:#,0;(#,0)}", Convert.ToInt32(txtOpenCash.Text));
                //------------------------
            }
            catch
            {
                txtOpenCash.Text = "";
            }
        }
        private void txtDr_Enter(object sender, EventArgs e)
        {
        }
        private void txtCr_Enter(object sender, EventArgs e)
        {
        }
        private void txtDr_Leave(object sender, EventArgs e)
        {
        }
        private void txtCr_Leave(object sender, EventArgs e)
        {
        }
        private void entryDateDateTimePicker_Enter(object sender, EventArgs e)
        {
            string[] actDate = Fn.GetRecords("sp_ActiveDates");
            entryDateDateTimePicker.MaxDate = Convert.ToDateTime(actDate[1]);
            entryDateDateTimePicker.MinDate = Convert.ToDateTime(actDate[0]);
        }
        private void listVoucher_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadVoucher();
            //try
            //{
            //    this.tblVoucherHDRTableAdapter.Fill(this.voucherEd.TblVoucherHDR, ((int)(System.Convert.ChangeType(listVoucher.SelectedValue, typeof(int)))));
            //    this.tblVoucherDTLTableAdapter.Fill(this.voucherEd.TblVoucherDTL, ((int)(System.Convert.ChangeType(listVoucher.SelectedValue, typeof(int)))));
            //    voucherN.Tag = listVoucher.SelectedValue;
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}
            //DataTable vDT = Fn.FillDSet("SELECT TblAccEntry.EntryAccName, TblVoucherDTL.Description, TblVoucherDTL.AmountDeb, TblVoucherDTL.AmountCre, TblVoucherDTL.Ref, TblVoucherHDR.EntryDate, TblVoucherHDR.Memo, TblVoucherHDR.VoucherNo, TblVoucherHDR.VoucherID, TblAccEntry.EntryAccID, TblVoucherHDR.CheqNo FROM TblVoucherHDR INNER JOIN TblVoucherDTL ON TblVoucherHDR.VoucherID = TblVoucherDTL.VoucherID INNER JOIN TblAccEntry ON TblVoucherDTL.AccEntryID = TblAccEntry.EntryAccID WHERE (TblVoucherHDR.VoucherID = " + listVoucher.SelectedValue + ") ORDER BY TblVoucherDTL.AmountCre").Tables[0];
            //tblVoucherDTLDataGridView.Height = 0;

            //entryDateDateTimePicker.Text = vDT.Rows[0]["EntryDate"].ToString();
            //if (vDT.Rows[0]["CheqNo"].ToString() == "")
            //{
            //    txtCheqNo.Visible = false;
            //    label4.Visible = false;
            //}
            //else
            //{
            //    txtCheqNo.Visible = true;
            //    label4.Visible = true;
            //    txtCheqNo.Text = vDT.Rows[0]["CheqNo"].ToString();
            //}

            //caclc();
        }
        private void btnDiscard_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to discard this voucher entry?";
            string title = "Voucher Discard";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Fn.Exec("UPDATE TblVoucherHDR SET VStatus = 1 WHERE (VoucherID = " + listVoucher.SelectedValue + ")");
                rfrsh();
            }
            else
            {
                return;
            }
        }
        private void tblVoucherDTLBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblVoucherDTLBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.voucherEd);
        }
        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
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

        private void btnNewRow_Click(object sender, EventArgs e)
        {
            Fn.Exec("INSERT INTO TblVoucherDTL (AccEntryID, Description, AmountDeb, AmountCre, VoucherID) VALUES ("+ tblVoucherDTLDataGridView.Rows[0].Cells[0].Value + ", N'"+ tblVoucherDTLDataGridView.Rows[0].Cells[3].Value + "', 0, 0, "+ listVoucher.SelectedValue + ")");
            loadVoucher();
        }
        private void loadVoucher()
        {
            try
            {
                this.tblVoucherHDRTableAdapter.Fill(this.voucherEd.TblVoucherHDR, ((int)(System.Convert.ChangeType(listVoucher.SelectedValue, typeof(int)))));
                this.tblVoucherDTLTableAdapter.Fill(this.voucherEd.TblVoucherDTL, ((int)(System.Convert.ChangeType(listVoucher.SelectedValue, typeof(int)))));
                voucherN.Tag = listVoucher.SelectedValue;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            DataTable vDT = Fn.FillDSet("SELECT TblAccEntry.EntryAccName, TblVoucherDTL.Description, TblVoucherDTL.AmountDeb, TblVoucherDTL.AmountCre, TblVoucherDTL.Ref, TblVoucherHDR.EntryDate, TblVoucherHDR.Memo, TblVoucherHDR.VoucherNo, TblVoucherHDR.VoucherID, TblAccEntry.EntryAccID, TblVoucherHDR.CheqNo FROM TblVoucherHDR INNER JOIN TblVoucherDTL ON TblVoucherHDR.VoucherID = TblVoucherDTL.VoucherID INNER JOIN TblAccEntry ON TblVoucherDTL.AccEntryID = TblAccEntry.EntryAccID WHERE (TblVoucherHDR.VoucherID = " + listVoucher.SelectedValue + ") ORDER BY TblVoucherDTL.AmountCre").Tables[0];
            tblVoucherDTLDataGridView.Height = 0;
            //tblVoucherDTLDataGridView.Rows.Clear();
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
            //tblVoucherDTLDataGridView.Height = vDT.Rows.Count * 18;
            //for (int i = 0; i < vDT.Rows.Count; i++)
            //{
            //tblVoucherDTLDataGridView.Rows.Add();
            //tblVoucherDTLDataGridView.Rows[i].Cells["cboEntryAcc"].Value = vDT.Rows[i]["EntryAccName"];
            //tblVoucherDTLDataGridView.Rows[i].Cells["cboEntryAcc"].Tag = vDT.Rows[i]["EntryAccID"];
            ////tblVoucherDTLDataGridView.Rows[i]Cells["cboRef"].Value = vDT.Rows[i]["Ref"].ToString() == "0" ? "" : vDT.Rows[i]["Ref"].ToString();
            //tblVoucherDTLDataGridView.Rows[i]Cells["cboRef"].Tag = vDT.Rows[i]["Ref"] == null ? "0" : vDT.Rows[i]["Ref"];
            //tblVoucherDTLDataGridView.Rows[i].Cells["Description"].Value = vDT.Rows[i]["Description"];
            //tblVoucherDTLDataGridView.Rows[i].Cells["Dr"].Value = vDT.Rows[i]["AmountDeb"];
            //tblVoucherDTLDataGridView.Rows[i].Cells["CR"].Value = vDT.Rows[i]["AmountCre"];
            //tblVoucherDTLDataGridView.Height = 2 22;
            //}
            caclc();
        }
    }
}