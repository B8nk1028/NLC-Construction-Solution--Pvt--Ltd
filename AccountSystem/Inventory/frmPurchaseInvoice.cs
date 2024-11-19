using AccountSystem.Inventory;
using System;
using System.Windows.Forms;
namespace AccountSystem
{
    public partial class frmPurchaseInvoice : Form
    {
        private MyModule Fn = new MyModule();
        string ItemDiscount = "0", NetTotal = "0";
        public frmPurchaseInvoice()
        {
            InitializeComponent();
            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }
        #region Default Instance
        private static frmPurchaseInvoice defaultInstance;
        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static frmPurchaseInvoice Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new frmPurchaseInvoice();
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
        private void frmPurchaseOrder_Load(object sender, EventArgs e)
        {
            Fn.fillCombo(cbLocation, "sp_OfficeLocations");
            cbLocation.SelectedValue = MyModule.BranchID;
            Fn.fillCombo(cboStores, "sp_Warehouses");
            cboStores.SelectedIndex = -1;
            txtPNo.Text = Fn.GetRecords("SELECT isnull(MAX(convert(int,Purch_bill_no)),0)+1 FROM tbl_Purchase WHERE (BranchID = " + cbLocation.SelectedValue + ") AND (InvoiceType = 1)")[0];
            Fn.fillCombo(cboVendor, "sp_VendorsList");
            Fn.fillCombo(cboBank, "SELECT EntryAccID, EntryAccName FROM TblAccEntry WHERE (AccType = 3)");
            Fn.fillCombo(cboProducts, "SELECT tbl_Product.Prod_id,tbl_Product.Prod_name FROM tbl_Product INNER JOIN tbl_Brand ON tbl_Product.Brand_id = tbl_Brand.Brand_id INNER JOIN tbl_Prod_category ON tbl_Product.Prod_Catg_id = tbl_Prod_category.Prod_ctg_id WHERE (tbl_Product.Disle <> 1 OR tbl_Product.Disle IS NULL) AND (tbl_Product.pType = 1) and (Prod_Catg_id <> 2)");
            cboProducts.Text = ""; cboProducts.SelectedIndex = -1; txtRate.Text = ""; txtQty.Text = ""; txtGAmount.Text = ""; txtDescr.Text = ""; txtNetAmt.Text = "";
            cboProducts.Focus();
        }
        private void grdBill_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                if (grdBill.Rows[e.RowIndex].Cells["prchse_prod_rate"].Value == null || grdBill.Rows[e.RowIndex].Cells["prchse_prod_rate"].Value.ToString() == "0" || grdBill.Rows[e.RowIndex].Cells["prchse_prod_rate"].Value.ToString() == "")
                {
                    grdBill.Rows[e.RowIndex].Cells["prchse_prod_rate"].Value = Fn.GetRecords("SELECT P_Price FROM tbl_Product WHERE (Prod_id = '" + grdBill.Rows[e.RowIndex].Cells["gdv_prod_name"].Value + "')")[0];
                }
                if (grdBill.Rows[e.RowIndex].Cells["Prchse_prod_qty"].Value == null || grdBill.Rows[e.RowIndex].Cells["Prchse_prod_qty"].Value == DBNull.Value)
                {
                    grdBill.Rows[e.RowIndex].Cells["Prchse_prod_qty"].Value = 1;
                }
                if (grdBill.Rows[e.RowIndex].Cells["gtxtGST"].Value == null)
                {
                    grdBill.Rows[e.RowIndex].Cells["gtxtGST"].Value = 0;
                }
                grdBill.Rows[e.RowIndex].Cells["x"].Value = global::AccountSystem.Properties.Resources.close;
            }
        }
        private void grdBill_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            double qty = 0, price = 0, amount = 0, tax = 0, gAmount = 0, GST = 0;
            double total = 0;
            if (e.RowIndex >= 0 || e.RowIndex + 1 < grdBill.Rows.Count)
            {
                if (grdBill.Rows[e.RowIndex].Cells["prchse_prod_rate"].Value != null && (grdBill.Rows[e.RowIndex].Cells["Prchse_prod_qty"].Value != null || grdBill.Rows[e.RowIndex].Cells["Prchse_prod_qty"].Value == DBNull.Value))
                {
                    try
                    {
                        if (grdBill.Rows[e.RowIndex].Cells["Prchse_prod_qty"].Value == null || grdBill.Rows[e.RowIndex].Cells["Prchse_prod_qty"].Value == DBNull.Value)
                        {
                            grdBill.Rows[e.RowIndex].Cells["Prchse_prod_qty"].Value = 1;
                        }
                        else
                        {
                            qty = Double.Parse(grdBill.Rows[e.RowIndex].Cells["Prchse_prod_qty"].Value.ToString());
                        }
                        if (grdBill.Rows[e.RowIndex].Cells["prchse_prod_rate"].Value == null)
                        {
                            grdBill.Rows[e.RowIndex].Cells["prchse_prod_rate"].Value = 0;
                        }
                        else
                        {
                            price = Double.Parse(grdBill.Rows[e.RowIndex].Cells["prchse_prod_rate"].Value.ToString());
                        }
                        //Disc = Double.Parse(grdBill.Rows[e.RowIndex].Cells["Disc"].Value == null ? "0" : grdBill.Rows[e.RowIndex].Cells["Disc"].Value.ToString());
                        if (grdBill.Rows[e.RowIndex].Cells["gtxtGST"].Value == null || grdBill.Rows[e.RowIndex].Cells["gtxtGST"].Value == DBNull.Value)
                        {
                            grdBill.Rows[e.RowIndex].Cells["gtxtGST"].Value = 0;
                        }
                        else
                        {
                            GST = Double.Parse(grdBill.Rows[e.RowIndex].Cells["gtxtGST"].Value.ToString());
                        }
                        gAmount = qty * price;
                        tax= GST/100*gAmount;
                        grdBill.Rows[e.RowIndex].Cells["gtxtTax"].Value = tax;
                        amount = gAmount + tax;
                    }
                    catch (Exception)
                    {
                        //grdBill.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                        //MessageBox.Show("please enter numeric values in Quantity and price fields");
                    }
                    grdBill.Rows[e.RowIndex].Cells["Prchse_Prod_Amount"].Value = amount;
                    //grdBill.Rows[e.RowIndex].Cells["Discount"].Value = Discount;
                    grdBill.Rows[e.RowIndex].Cells["GAmount"].Value = gAmount;
                }
            }
            for (int i = 0; i < grdBill.Rows.Count; i++)
            {
                if (grdBill.Rows[i].Cells["Prchse_Prod_Amount"].Value != null)
                {
                    total = total + Convert.ToDouble(grdBill.Rows[i].Cells["Prchse_Prod_Amount"].Value);
                    //Disc = Disc + Convert.ToDouble(grdBill.Rows[i].Cells["Discount"].Value == DBNull.Value ? "0" : grdBill.Rows[i].Cells["Discount"].Value);
                    //ItemDiscount = Disc.ToString("#,#.00");
                    txtTotal.Text = Convert.ToDouble(total).ToString("#,#.00");
                    //NetTotal = (total + Disc).ToString("#,#.00");
                }
            }
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (cboStores.SelectedIndex == -1)
            {
                MessageBox.Show("Please select store location for stock", "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (grdBill.Rows.Count > 0)
            {
                btnSave.Enabled = false;

                string items = "";
                for (int i = 0; i < grdBill.Rows.Count; i++)
                {
                    items = items + "," + "{\"productid\":\"" + grdBill.Rows[i].Cells["gdv_prod_name"].Tag.ToString() + "\",\"rate\":\"" + grdBill.Rows[i].Cells["prchse_prod_rate"].Value.ToString() + "\",\"qty\":\"" + grdBill.Rows[i].Cells["Prchse_prod_qty"].Value.ToString() + "\",\"GST\":\"" + grdBill.Rows[i].Cells["gtxtGST"].Value.ToString() + "\",\"Tax\":\"" + grdBill.Rows[i].Cells["gtxtTax"].Value.ToString() + "\",\"Descr\":\"" + grdBill.Rows[i].Cells["gtxtDescr"].Value.ToString() + "\"}";
                }
                string Data2Post = "{\"FED\":\"" + txtFED.Text.Replace(",", "") + "\",\"StoreID\":\"" + cboStores.SelectedValue + "\",\"TotalAmount\":\"" + textNetTotal.Text.Replace(",", "") + "\",\"ItemDiscount\":\"" + ItemDiscount.Replace(",", "") + "\",\"AccEntryID\":" + cboBank.SelectedValue + ",\"Remarks\":\"" + txtCheque.Text + "\",\"VendorInvoiceDate\":\"" + dtVinvDT.Text + "\",\"VendorInvoice\":\"" + txtVInvoice.Text + "\",\"AmountPaid\":\"" + txtPaid.Text.Replace(",", "") + "\",\"CarriageFreight\":\"" + txtCarriage.Text.Replace(",", "") + "\",\"AdditionalDiscount\":0,\"PurchaseOrderDate\":\"" + dtTrxDate.Text + "\",\"Purch_OrderNo\":\"" + txtTrxNo.Text + "\",\"VendorID\":" + cboVendor.SelectedValue + ",\"TrxDate\":\"" + dtPurchDT.Text + "\",\"Created\":\"" + MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo + "\",\"CompID\":" + MyModule.CompID + ",\"items\":[" + items.Substring(1) + "]}";
                string ID = Fn.GetRecords("sp_CreateGRN '" + Data2Post + "'," + cbLocation.SelectedValue + "," + btnSave.Tag)[0];
                btnPrint.Tag = ID;
                if (ID == "a")
                {
                    btnSave.Enabled = true;
                    MessageBox.Show("There is some issue in data please check and try again", "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                dtTrxDate.Enabled = false;
                panel5.Enabled = false;
                panel1.Hide();
                panel3.Enabled = false;
                panel4.Enabled = false;
                panel6.Enabled = false;
                dtTrxDate.Enabled = false;
                cboVendor.Enabled = false;
                btnAddNew.Visible = true;
                btnAddNew.Enabled = true;
                btnPrint.Enabled = true;
                grdBill.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("Please enter product detail ...");
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            txtFED.Text = "0";
            txtCarriage.Text = "0";
            btnSave.Enabled = true;
            btnAddNew.Enabled = false;
            btnPrint.Enabled = false;
            grdBill.Rows.Clear();
            grdBill.ReadOnly = false;
            cboVendor.Enabled = true;
            dtTrxDate.Enabled = true;
            panel4.Enabled = true;
            grdBill.Height = 0;
            cboProducts.Text = ""; cboProducts.SelectedIndex = -1; txtRate.Text = ""; txtQty.Text = ""; txtGAmount.Text = ""; txtDescr.Text = ""; txtNetAmt.Text = "";
            cboProducts.Focus();
            panel1.Show();
            txtPNo.Text = Fn.GetRecords("SELECT isnull(MAX(convert(int,Purch_bill_no)),0)+1 FROM tbl_Purchase WHERE (BranchID = " + cbLocation.SelectedValue + ") AND (InvoiceType = 1)")[0];
            panel5.Enabled = true;
            panel3.Enabled = true;
            panel6.Enabled = true;
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            rptGRN GRN = new rptGRN();
            GRN.Tag = btnPrint.Tag;
            GRN.ShowDialog();
        }
        private void grdBill_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                grdBill.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            else
            {
                grdBill.SelectionMode = DataGridViewSelectionMode.CellSelect;
            }
        }
        private void grdBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8 && grdBill.ReadOnly == false)
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Are You Want to Delete ?", "Deleting Record", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in grdBill.SelectedRows)
                    {
                        try
                        {
                            grdBill.Rows.Remove(row);
                            grdBill.Height = grdBill.Height - 22;
                        }
                        catch { }
                    }
                }
            }
        }
        private void txtAddDisc_TextChanged(object sender, EventArgs e)
        {
            txtFED.Text = Fn.ValidateNumber(txtFED);
            txtGTotal.Text = (Convert.ToDouble((txtTotal.Text == "" ? "0" : txtTotal.Text)) + Convert.ToDouble((txtFED.Text == "" ? "0" : txtFED.Text))).ToString("#,#.00");
            textNetTotal.Text = (Convert.ToDouble((txtGTotal.Text == "" ? "0" : txtGTotal.Text)) + Convert.ToDouble((txtCarriage.Text == "" ? "0" : txtCarriage.Text))).ToString("#,#.00");
            txtBalance.Text = (Convert.ToDouble((textNetTotal.Text == "" ? "0" : textNetTotal.Text)) - Convert.ToDouble((txtPaid.Text == "" ? "0" : txtPaid.Text))).ToString("#,#.00");
        }
        private void txtCarriage_TextChanged(object sender, EventArgs e)
        {
            txtCarriage.Text = Fn.ValidateNumber(txtCarriage);
            txtGTotal.Text = (Convert.ToDouble((txtTotal.Text == "" ? "0" : txtTotal.Text)) + Convert.ToDouble((txtFED.Text == "" ? "0" : txtFED.Text))).ToString("#,#.00");
            textNetTotal.Text = (Convert.ToDouble((txtGTotal.Text == "" ? "0" : txtGTotal.Text)) + Convert.ToDouble((txtCarriage.Text == "" ? "0" : txtCarriage.Text))).ToString("#,#.00");
            txtBalance.Text = (Convert.ToDouble((textNetTotal.Text == "" ? "0" : textNetTotal.Text)) - Convert.ToDouble((txtPaid.Text == "" ? "0" : txtPaid.Text))).ToString("#,#.00");
        }
        private void txtPaid_TextChanged(object sender, EventArgs e)
        {
            txtPaid.Text = Fn.ValidateNumber(txtPaid);
            txtGTotal.Text = (Convert.ToDouble((txtTotal.Text == "" ? "0" : txtTotal.Text)) + Convert.ToDouble((txtFED.Text == "" ? "0" : txtFED.Text))).ToString("#,#.00");
            textNetTotal.Text = (Convert.ToDouble((txtGTotal.Text == "" ? "0" : txtGTotal.Text)) + Convert.ToDouble((txtCarriage.Text == "" ? "0" : txtCarriage.Text))).ToString("#,#.00");
            txtBalance.Text = (Convert.ToDouble((textNetTotal.Text == "" ? "0" : textNetTotal.Text)) - Convert.ToDouble((txtPaid.Text == "" ? "0" : txtPaid.Text))).ToString("#,#.00");
            if (Convert.ToDouble((txtPaid.Text == "" ? "0" : txtPaid.Text)) > 0)
            {
                panel6.Show(); cboBank.SelectedIndex = -1;
            }
            else
            {
                panel6.Hide(); cboBank.SelectedIndex = 0;
            }
        }
        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            txtGTotal.Text = (Convert.ToDouble((txtTotal.Text == "" ? "0" : txtTotal.Text)) + Convert.ToDouble((txtFED.Text == "" ? "0" : txtFED.Text))).ToString("#,#.00");
            textNetTotal.Text = (Convert.ToDouble((txtGTotal.Text == "" ? "0" : txtGTotal.Text)) + Convert.ToDouble((txtCarriage.Text == "" ? "0" : txtCarriage.Text))).ToString("#,#.00");
            txtBalance.Text = (Convert.ToDouble((textNetTotal.Text == "" ? "0" : textNetTotal.Text)) - Convert.ToDouble((txtPaid.Text == "" ? "0" : txtPaid.Text))).ToString("#,#.00");
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage1"])
            {
                Fn.fillCombo(cboBank, "SELECT EntryAccID, EntryAccName FROM TblAccEntry WHERE (AccType = 3)");
            }
            else
            {
                Fn.fillCombo(cboBank, "SELECT EntryAccID, EntryAccName FROM TblAccEntry WHERE (AccType = 2)");
            }
        }
        private void cbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPNo.Text = Fn.GetRecords("SELECT isnull(MAX(convert(int,Purch_bill_no)),0)+1 FROM tbl_Purchase WHERE (BranchID = " + cbLocation.SelectedValue + ") AND (InvoiceType = 1)")[0];
        }
        private void btnAddRow_Click(object sender, EventArgs e)
        {
            if (cboProducts.SelectedValue == null || (txtQty.Value + txtRate.Text) == "00")
            {
                MessageBox.Show("Please select product name" + Environment.NewLine + "Please check the entries Qty and rate " + Environment.NewLine + "Can’t save blank values!", "Invaild Values", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            grdBill.Rows.Add();
            grdBill.Rows[grdBill.RowCount - 1].Cells[0].Value = cboProducts.Text;
            grdBill.Rows[grdBill.RowCount - 1].Cells[0].Tag = cboProducts.SelectedValue;
            grdBill.Rows[grdBill.RowCount - 1].Cells[1].Value = txtDescr.Text;
            grdBill.Rows[grdBill.RowCount - 1].Cells[2].Value = txtRate.Text;
            grdBill.Rows[grdBill.RowCount - 1].Cells[3].Value = txtQty.Text;
            grdBill.Rows[grdBill.RowCount - 1].Cells[4].Value = txtGAmount.Text;
            grdBill.Rows[grdBill.RowCount - 1].Cells[5].Value = nGST.Value;
            grdBill.Rows[grdBill.RowCount - 1].Cells[6].Value = txtTax.Text;
            grdBill.Rows[grdBill.RowCount - 1].Cells[7].Value = txtNetAmt.Text;
            grdBill.Height = grdBill.Height + 22;
            cboProducts.Text = ""; cboProducts.SelectedIndex = -1; txtRate.Text = ""; txtQty.Text = ""; txtGAmount.Text = ""; txtDescr.Text = ""; txtNetAmt.Text = "";
            cboProducts.Focus();
        }
        private void cboVendor_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAddress.Text = Fn.GetRecords("SELECT BAddress+'<br><b>Contact No. '+BContactNo FROM TblAccEntry WHERE (EntryAccID = " + cboVendor.SelectedValue + ")")[0].ToString();
        }
        private void txtRate_ValueChanged(object sender, EventArgs e)
        {
            Calc();
        }
        private void txtQty_ValueChanged(object sender, EventArgs e)
        {
            Calc();
        }
        private void txtDAmt_ValueChanged(object sender, EventArgs e)
        {
            Calc();
        }
        private void cboProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (txtRate.Text == null || txtRate.Text == "0" || txtRate.Text == "")
            //{
            txtRate.Text = Fn.GetRecords("SELECT P_Price FROM tbl_Product WHERE (Prod_id = '" + cboProducts.SelectedValue + "')")[0];
            //}
            if (txtQty.Text == null || txtQty.Text == "0" || txtQty.Text == "")
            {
                txtQty.Text = "1";
            }
            //if (txtDAmt.Text == null || txtDAmt.Text == "")
            //{
            //    txtDAmt.Text = "0";
            //}
            Calc();
        }

        private void grdBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtVinvDT_Enter(object sender, EventArgs e)
        {
            string[] actDate = Fn.GetRecords("sp_ActiveDates");
            dtVinvDT.MaxDate = Convert.ToDateTime(actDate[1]);
            dtVinvDT.MinDate = Convert.ToDateTime(actDate[0]);
        }

        private void dtPurchDT_Enter(object sender, EventArgs e)
        {
            string[] actDate = Fn.GetRecords("sp_ActiveDates");
            dtPurchDT.MaxDate = Convert.ToDateTime(actDate[1]);
            dtPurchDT.MinDate = Convert.ToDateTime(actDate[0]);
        }

        private void Calc()
        {
            double qty = 0, price = 0, amount = 0, tax = 0, gAmount = 0, GST = 0;
            double total = 0;
            if (txtRate.Text != null && txtQty.Text != null)
            {
                try
                {
                    if (txtQty.Text == null)
                    {
                        txtQty.Value = 0;
                    }
                    else
                    {
                        qty = Double.Parse(txtQty.Value.ToString());
                    }
                    if (txtRate.Text == null)
                    {
                        txtRate.Value = 0;
                    }
                    else
                    {
                        price = Double.Parse(txtRate.Value.ToString());
                    }
                    //Disc = Double.Parse(grdBill.Rows[e.RowIndex].Cells["Disc"].Value == null ? "0" : grdBill.Rows[e.RowIndex].Cells["Disc"].Value.ToString());
                    //if (txtDAmt.Text == null)
                    //{
                    //    txtDAmt.Value = 0;
                    //}
                    //else
                    //{
                    //    Discount = Double.Parse(txtDAmt.Value.ToString());
                    //}
                    gAmount = qty * price;
                    tax =Convert.ToDouble(nGST.Value) / 100 * gAmount;
                    txtTax.Text = tax.ToString();
                    amount = gAmount + tax;
                }
                catch (Exception)
                {
                    //grdBill.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                    //MessageBox.Show("please enter numeric values in Quantity and price fields");
                }
                txtNetAmt.Text = amount.ToString();
                //grdBill.Rows[e.RowIndex].Cells["Discount"].Value = Discount;
                txtGAmount.Text = gAmount.ToString();
            }
            for (int i = 0; i < grdBill.Rows.Count; i++)
            {
                if (grdBill.Rows[i].Cells["Prchse_Prod_Amount"].Value != null)
                {
                    total = total + Convert.ToDouble(grdBill.Rows[i].Cells["Prchse_Prod_Amount"].Value);
                    txtTotal.Text = Convert.ToDouble(total).ToString();
                }
            }
        }
    }
}