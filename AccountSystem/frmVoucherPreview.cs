using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;
using Newtonsoft.Json;
using SergeUtils;
namespace AccountSystem
{
    public partial class frmVoucherPreview : Form
    {
        private Boolean chkSave = default(Boolean);
        private MyModule Fn = new MyModule();
        private Words Wrd = new Words();
        public frmVoucherPreview()
        {
            InitializeComponent();
            if (defaultInstance == null)
                defaultInstance = this;
        }
        #region Default Instance
        private static frmVoucherPreview defaultInstance;
        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static frmVoucherPreview Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new frmVoucherPreview();
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

            Fn.fillCombo(cbLocation, "sp_OfficeLocations");
            cbLocation.SelectedValue = MyModule.BranchID;
            cboVouType.Text = "JV-   Journal Voucher";


        }
        private bool grdChk()
        {
            bool chk = true;
            for (int i = 0; i <= tblVoucherDTLDataGridView.Rows.Count - 2; i++)
            {
                if (tblVoucherDTLDataGridView.Rows[i].Cells[0].Value == null)
                {
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
               
                Fn.GetNum(txtOpenCash, "SELECT ISNULL(CONVERT(Varchar, SUM(VW_VoucherDTL.AmountDeb - VW_VoucherDTL.AmountCre)), '0') AS OpenBalance, TblAccSubHead.AccSubName + N' / ' + TblAccEntry.EntryAccName AS Expr1 FROM VW_VoucherHDR INNER JOIN VW_VoucherDTL ON VW_VoucherHDR.VoucherID = VW_VoucherDTL.VoucherID RIGHT OUTER JOIN TblAccSubHead INNER JOIN TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID ON VW_VoucherDTL.AccEntryID = TblAccEntry.EntryAccID WHERE (TblAccEntry.EntryAccID = " + tblVoucherDTLDataGridView.Rows[e.RowIndex].Cells[0].Tag + ") AND (VW_VoucherHDR.BranchID = " + cbLocation.SelectedValue + ") GROUP BY TblAccSubHead.AccSubName + N' / ' + TblAccEntry.EntryAccName, TblAccSubHead.AccSubName, TblAccEntry.EntryAccName");
                txtOpenCash.Text = txtOpenCash.Tag + " = " + String.Format("{0:#,0;(#,0)}", Convert.ToInt32(txtOpenCash.Text));
                //------------------------
            }
            catch
            {
                txtOpenCash.Text = "";
            }

            if (e.ColumnIndex == 5)
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
            }
        }
        private void tblVoucherDTLDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

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
        {
            MyModule.ParmB = cboVouType.Text.Split('-')[1];
            frmJVReport.Default.MdiParent = FrmMain.Default;
            MyModule.ParmD = voucherN.Tag.ToString();
            frmJVReport.Default.Show(); frmJVReport.Default.Activate();
        }
        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.Focus();
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
            //lblinWords.Text = Wrd.changeCurrencyToWords(Convert.ToString(sumdr));
        }

        private void entryDateDateTimePicker_Enter(object sender, EventArgs e)
        {
            string[] actDate = Fn.GetRecords("sp_ActiveDates");
            entryDateDateTimePicker.MaxDate = Convert.ToDateTime(actDate[1]);
            entryDateDateTimePicker.MinDate = Convert.ToDateTime(actDate[0]);
        }

        private Int32 searchVoucher()
        {
            DataTable vDT = Fn.FillDSet("sp_VoucherData '"+cboVouType.Text.Split('-')[0]+"/"+ voucherN.Text+"',"+cbLocation.SelectedValue).Tables[0];
            tblVoucherDTLDataGridView.Height = 0;
            tblVoucherDTLDataGridView.Rows.Clear();

            for (int i = 0; i < vDT.Rows.Count; i++)
            {
                tblVoucherDTLDataGridView.Rows.Add();
                tblVoucherDTLDataGridView.Rows[tblVoucherDTLDataGridView.RowCount - 1].Cells[0].Value = vDT.Rows[i]["EntryAccName"];
                tblVoucherDTLDataGridView.Rows[tblVoucherDTLDataGridView.RowCount - 1].Cells[0].Tag = vDT.Rows[i]["EntryAccID"];
                tblVoucherDTLDataGridView.Rows[tblVoucherDTLDataGridView.RowCount - 1].Cells[1].Value = vDT.Rows[i]["Ref"].ToString() == "0" ? "" : vDT.Rows[i]["Ref"].ToString().Replace("S", "SL/").Replace("P", "PR/");
                tblVoucherDTLDataGridView.Rows[tblVoucherDTLDataGridView.RowCount - 1].Cells[1].Tag = vDT.Rows[i]["Ref"] == null ? "0" : vDT.Rows[i]["Ref"];
                tblVoucherDTLDataGridView.Rows[tblVoucherDTLDataGridView.RowCount - 1].Cells[2].Value = vDT.Rows[i]["Description"];
                tblVoucherDTLDataGridView.Rows[tblVoucherDTLDataGridView.RowCount - 1].Cells[3].Value = vDT.Rows[i]["AmountDeb"];
                tblVoucherDTLDataGridView.Rows[tblVoucherDTLDataGridView.RowCount - 1].Cells[4].Value = vDT.Rows[i]["AmountCre"];
                //tblVoucherDTLDataGridView.Height = tblVoucherDTLDataGridView.Height + 50;
            }
            if (vDT.Rows.Count>0)
            {
                voucherN.Tag = vDT.Rows[0]["VoucherID"];
                bankIDTextBox.Text=vDT.Rows[0]["Memo"].ToString();
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
            caclc();
            }

            return vDT.Rows.Count;
                }
        private void btnDiscard_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to discard this voucher entry?";
            string title = "Voucher Discard";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                

            }
            else
            {
                return;
            }
        }

        private void voucherN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                searchVoucher();
            }
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnFF_Click(object sender, EventArgs e)
        {
            try
            {
                voucherN.Text = (Convert.ToInt32(voucherN.Text) + 1).ToString();
                if (searchVoucher()==0)
                {
                    voucherN.Text = (Convert.ToInt32(voucherN.Text) - 1).ToString();
                    searchVoucher();
                }


            }
            catch(Exception ex)
            {

            }
            
        }

        private void btnBak_Click(object sender, EventArgs e)
        {
            try
            {
                voucherN.Text = (Convert.ToInt32(voucherN.Text) - 1).ToString();
                if (searchVoucher() == 0)
                {
                    voucherN.Text = (Convert.ToInt32(voucherN.Text) + 1).ToString();
                    searchVoucher();
                }
            }
            catch
            {

            }
        }

        private void cboVouType_SelectedIndexChanged(object sender, EventArgs e)
        {
            voucherN.Text = "1";
            searchVoucher();
        }

        private void cbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            voucherN.Text = "1";
            searchVoucher();
        }
    }
}