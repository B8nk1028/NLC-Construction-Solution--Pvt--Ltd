using AccountSystem.Inventory;
using Newtonsoft.Json;
using System;
using System.Windows.Forms;
namespace AccountSystem
{
    public partial class frmDeliveryChallan0 : Form
    {
        private MyModule Fn = new MyModule();
        string[] cData;
        public frmDeliveryChallan0()
        {
            InitializeComponent();
            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }
        #region Default Instance
        private static frmDeliveryChallan0 defaultInstance;
        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static frmDeliveryChallan0 Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new frmDeliveryChallan0();
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
            lblSCreated.Text = "" + MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo;
            txtTrxNo.Text = Fn.GetRecords("SELECT isnull(MAX(convert(int,Sale_bill_no)),0) +1 FROM tblDelivery WHERE (BranchID = " + cbLocation.SelectedValue + ")")[0];
            Fn.fillCombo(cboVendor, "sp_VendorsList");
            Fn.fillCombo(cboSalesman, "SELECT EntryAccID, EntryAccName FROM TblAccEntry WHERE (AccType = 9)");
            cboSalesman.SelectedIndex = -1;
            Fn.fillCombo(cboPayTerms, "SELECT PaymentTermsID, PaymentTermsTxt FROM tblPaymentTerms");
            Fn.fillCombo(cboProducts, "sp_ProductList '" + cboStores.SelectedValue + "'");
            cboProducts.Text = ""; cboProducts.SelectedIndex = -1; txtRate.Text = ""; txtPRate.Text = ""; txtQty.Text = ""; txtGAmount.Text = ""; txtDAmt.Text = ""; txtNetAmt.Text = "";
            cboProducts.Focus();
        }
        bool chk = false;
        private void cbo_vendor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cData = Fn.GetRecords("SELECT TblAccEntry.BAddress + '<br><b>Contact No. ' + TblAccEntry.BContactNo AS Addressline, TblAccEntry.BTransport, ISNULL(TblAccEntry.CrLimit, 0) AS CrLimit, (SELECT ISNULL(SUM(AmountDeb - AmountCre), 0) AS Expr1 FROM VW_VoucherDTL WHERE (AccEntryID = " + cboVendor.SelectedValue + ")) AS Balance, tblLocations.CityNmae + ', ' + tblLocations.Region + ', ' + tblLocations.Province AS Loc, TblAccEntry.PaymentTermsID FROM TblAccEntry LEFT OUTER JOIN tblLocations ON TblAccEntry.BCity = tblLocations.CityID WHERE (TblAccEntry.EntryAccID = " + cboVendor.SelectedValue + ")");
                txtAddress.Text = cData[0];
                txtTransport.Text = cData[1];
                cboCity.Text = cData[4];
                cboPayTerms.SelectedValue= cData[5];
                if (Convert.ToInt32(cData[2]) <= Convert.ToInt32(cData[3]) && chk)
                {
                    MessageBox.Show("Credit Limit is increasing" + Environment.NewLine + "Credit Limit: " + cData[2] + Environment.NewLine + "Current Balance: " + cData[3], "Credit Limit is increasing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {

            }
            chk = true;

        }
        private void grdBill_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                if (grdBill.Rows[e.RowIndex].Cells["prchse_prod_rate"].Value == null || grdBill.Rows[e.RowIndex].Cells["prchse_prod_rate"].Value.ToString() == "0" || grdBill.Rows[e.RowIndex].Cells["prchse_prod_rate"].Value.ToString() == "")
                {
                    grdBill.Rows[e.RowIndex].Cells["prchse_prod_rate"].Value = Fn.GetRecords("SELECT Prod_Price FROM tbl_Product WHERE (Prod_id = '" + grdBill.Rows[e.RowIndex].Cells["gdv_prod_name"].Value + "')")[0];
                }
                if (grdBill.Rows[e.RowIndex].Cells["Prchse_prod_qty"].Value == null)
                {
                    grdBill.Rows[e.RowIndex].Cells["Prchse_prod_qty"].Value = 1;
                }
                if (grdBill.Rows[e.RowIndex].Cells["Discount"].Value == null)
                {
                    grdBill.Rows[e.RowIndex].Cells["Discount"].Value = 0;
                }
                grdBill.Rows[e.RowIndex].Cells["x"].Value = global::AccountSystem.Properties.Resources.close;
            }
        }
        private void grdBill_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            double qty = 0, price = 0, amount = 0, Disc = 0, gAmount = 0, Discount = 0;
            double total = 0;
            if (e.RowIndex >= 0 || e.RowIndex + 1 < grdBill.Rows.Count)
            {
                if (grdBill.Rows[e.RowIndex].Cells["prchse_prod_rate"].Value != null && grdBill.Rows[e.RowIndex].Cells["Prchse_prod_qty"].Value != null)
                {
                    try
                    {
                        if (grdBill.Rows[e.RowIndex].Cells["Prchse_prod_qty"].Value == null)
                        {
                            grdBill.Rows[e.RowIndex].Cells["Prchse_prod_qty"].Value = 0;
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
                        if (grdBill.Rows[e.RowIndex].Cells["Discount"].Value == null)
                        {
                            grdBill.Rows[e.RowIndex].Cells["Discount"].Value = 0;
                        }
                        else
                        {
                            Discount = Double.Parse(grdBill.Rows[e.RowIndex].Cells["Discount"].Value.ToString());
                        }
                        gAmount = qty * price;
                        //Discount = gAmount * Disc / 100;
                        amount = gAmount - Discount;
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
                    txtTotal.Text = Convert.ToDouble(total).ToString("#,#.00");
                }
            }
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboVendor.SelectedValue == null || cboSalesman.SelectedValue == null)
                {
                    MessageBox.Show("Please select vaild customer and salesman.", "Invaild Values", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (grdBill.Rows.Count > 0)
                {
                    if (Convert.ToInt32(cData[2]) <= (Convert.ToDouble(cData[3]) + Convert.ToDouble(txtTotal.Text)))
                    {
                        string message = "Credit Limit is increasing for " + cboVendor.Text + Environment.NewLine + "Credit Limit: " + cData[2] + Environment.NewLine + "Current Balance: " + cData[3] + Environment.NewLine + "Do you want to save delivery challan?";
                        string title = "Credit Limit is increasing";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            //this.Close();
                        }
                        else
                        {
                            return;
                        }
                    }
                    btnSave.Enabled = false;
                    string items = "";
                    for (int i = 0; i < grdBill.Rows.Count; i++)
                    {
                        items = items + "," + "{\"PRate\":" + JsonConvert.ToString(grdBill.Rows[i].Cells["gtxtPRate"].Value) + ",\"PackingDetail\":" + JsonConvert.ToString(grdBill.Rows[i].Cells["txtPackingDetail"].Value) + ",\"productid\":\"" + grdBill.Rows[i].Cells["gdv_prod_name"].Tag.ToString() + "\",\"rate\":\"" + grdBill.Rows[i].Cells["prchse_prod_rate"].Value.ToString() + "\",\"qty\":\"" + grdBill.Rows[i].Cells["Prchse_prod_qty"].Value.ToString() + "\",\"disc\":\"" + grdBill.Rows[i].Cells["Discount"].Value.ToString() + "\"}";
                    }
                    string Data2Post = "{\"PayTerm\":\"" + (cboPayTerms.SelectedValue==null?0: cboPayTerms.SelectedValue) + "\",\"StoreID\":\"" + cboStores.SelectedValue + "\",\"BilltyDT\":" + JsonConvert.ToString(dtShip.Text) + ",\"BilltyNo\":" + JsonConvert.ToString(txtBilti.Text) + ",\"ToShip\":" + JsonConvert.ToString(cboCity.Text) + ",\"PurchaseOrder\":" + JsonConvert.ToString(txtPurchaseOrder.Text) + ",\"PurchOrderDT\":" + JsonConvert.ToString(txtPurchOrderDT.Text) + ",\"Remarks\":" + JsonConvert.ToString(txtRemarks.Text) + ",\"Transport\":" + JsonConvert.ToString(txtTransport.Text) + ",\"Salesman\":" + cboSalesman.SelectedValue + ",\"VendorID\":" + cboVendor.SelectedValue + ",\"TrxDate\":\"" + dtTrxDate.Value + "\",\"Created\":\"" + MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo + "\",\"CompID\":" + MyModule.CompID + ",\"items\":[" + items.Substring(1) + "]}";
                    string ID = Fn.GetRecords("sp_DeliveryChallan '" + Data2Post + "'," + cbLocation.SelectedValue)[0];
                    btnPrint.Tag = ID;
                    if (ID == "a")
                    {
                        
                        MessageBox.Show("There is some issue in data please check and try again", "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    btnSave.Enabled = false;
                    dtTrxDate.Enabled = false;
                    cboVendor.Enabled = false;
                    btnAddNew.Visible = true;
                    btnPrint.Visible = true;
                    grdBill.ReadOnly = true;
                    panel4.Visible = false;
                }
                else
                {
                    MessageBox.Show("Please enter product detail ...");
                }
            }
            catch (Exception ex)
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
            btnSave.Enabled = true;
            btnAddNew.Visible = false;
            btnPrint.Visible = false;
            cboStores.Enabled = true;
            cboStores.SelectedIndex = -1;
            grdBill.Rows.Clear();
            txtTrxNo.Text = Fn.GetRecords("SELECT isnull(MAX(convert(int,Sale_bill_no)),0) +1 FROM tblDelivery WHERE (BranchID = " + cbLocation.SelectedValue + ")")[0];
            grdBill.ReadOnly = false;
            cboVendor.Enabled = true;
            dtTrxDate.Enabled = true;
            grdBill.Height = 0;
            panel4.Visible = true; cboVendor.SelectedIndex = -1;
            cboSalesman.SelectedIndex = -1;
            cboProducts.Text = ""; cboProducts.SelectedIndex = -1; txtRate.Text = ""; txtPRate.Text = ""; txtQty.Text = ""; txtGAmount.Text = ""; txtDAmt.Text = ""; txtNetAmt.Text = "";
            cboProducts.Focus();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            rptDeliveryChallan PO = new rptDeliveryChallan();
            PO.Tag = btnPrint.Tag;
            PO.ShowDialog();
        }
        private void grdBill_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 7)
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
            if (btnSave.Enabled)
            {
                if (e.ColumnIndex == 7)
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
                                if (grdBill.Rows.Count==0)
                                {
                                    cboStores.Enabled = true;
                                }
                            }
                            catch { }
                        }
                    }
                }
            }
        }
        private void btnAddRow_Click(object sender, EventArgs e)
        {
            if (cboStores.SelectedIndex == -1)
            {
                MessageBox.Show("Please select store location for stock", "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            cboStores.Enabled = false;
            if (cboProducts.SelectedValue == null || (txtQty.Value + txtRate.Text) == "00")
            {
                MessageBox.Show("Please select product name" + Environment.NewLine + "Please check the entries Qty and rate " + Environment.NewLine + "Can’t save blank values!", "Invaild Values", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //Calc();
            if (cboProducts.Text.Split('|')[1] == "0" || cboProducts.Text.Split('|')[1] == "" || txtQty.Value > Int32.Parse(
    cboProducts.Text.Split('|')[1].Split(' ')[0] == "" ? "0" : cboProducts.Text.Split('|')[1].Split(' ')[0].Replace(",","")))
            {
                MessageBox.Show("Stock is not available for select product " + Environment.NewLine + "or stock is less for selected quantity", "Out Of Stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            grdBill.Rows.Add();
            grdBill.Rows[grdBill.RowCount - 1].Cells[0].Value = cboProducts.Text.Split('|')[0];
            grdBill.Rows[grdBill.RowCount - 1].Cells[0].Tag = cboProducts.SelectedValue;
            grdBill.Rows[grdBill.RowCount - 1].Cells["prchse_prod_rate"].Value = txtRate.Text;
            grdBill.Rows[grdBill.RowCount - 1].Cells["gtxtPRate"].Value = txtPRate.Text;
            grdBill.Rows[grdBill.RowCount - 1].Cells["Prchse_prod_qty"].Value = txtQty.Text;
            grdBill.Rows[grdBill.RowCount - 1].Cells["GAmount"].Value = txtGAmount.Text;
            grdBill.Rows[grdBill.RowCount - 1].Cells["Discount"].Value = txtDAmt.Value;
            grdBill.Rows[grdBill.RowCount - 1].Cells["Prchse_Prod_Amount"].Value = txtNetAmt.Text;
            grdBill.Height = grdBill.Height + 22;
            cboProducts.Text = ""; cboProducts.SelectedIndex = -1; txtRate.Text = ""; txtPRate.Text = ""; txtQty.Text = ""; txtGAmount.Text = ""; txtDAmt.Text = ""; txtNetAmt.Text = "";
            cboProducts.Focus();
        }
        private void cbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTrxNo.Text = Fn.GetRecords("SELECT isnull(MAX(convert(int,Sale_bill_no)),0) +1 FROM tblDelivery WHERE (BranchID = " + cbLocation.SelectedValue + ")")[0];
            Fn.fillCombo(cboProducts, "sp_ProductList '" + cboStores.SelectedValue + "'");
        }
        private void cboProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (txtRate.Text == null || txtRate.Text == "0" || txtRate.Text == "")
            //{
           
            string[] rates = Fn.GetRecords("sp_GetPurchaseRate '" + cboProducts.SelectedValue + "','"+ dtTrxDate.Text+ "','" + cbLocation.SelectedValue + "'");
            txtRate.Text = rates[0];
            txtPRate.Text = rates[1];
            //}
            if (txtQty.Text == null || txtQty.Text == "0" || txtQty.Text == "")
            {
                txtQty.Text = "1";
            }
            if (txtDAmt.Text == null || txtDAmt.Text == "")
            {
                txtDAmt.Text = "0";
            }
            Calc();
        }
        private void Calc()
        {
            double qty = 0, price = 0, amount = 0, Disc = 0, gAmount = 0, Discount = 0;
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
                    if (txtDAmt.Text == null)
                    {
                        txtDAmt.Value = 0;
                    }
                    else
                    {
                        Discount = Double.Parse(txtDAmt.Value.ToString());
                    }
                    gAmount = qty * price;
                    //Discount = gAmount * Disc / 100;
                    amount = gAmount - Discount;
                }
                catch (Exception)
                {
                    //grdBill.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                    //MessageBox.Show("please enter numeric values in Quantity and price fields");
                }
                txtNetAmt.Text = amount.ToString("#,#.00");
                //grdBill.Rows[e.RowIndex].Cells["Discount"].Value = Discount;
                txtGAmount.Text = gAmount.ToString("#,#.00");
            }
            for (int i = 0; i < grdBill.Rows.Count; i++)
            {
                if (grdBill.Rows[i].Cells["Prchse_Prod_Amount"].Value != null)
                {
                    total = total + Convert.ToDouble(grdBill.Rows[i].Cells["Prchse_Prod_Amount"].Value);
                    txtTotal.Text = Convert.ToDouble(total).ToString("#,#.00");
                }
            }
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

        private void dtTrxDate_Enter(object sender, EventArgs e)
        {
            string[] actDate = Fn.GetRecords("sp_ActiveDates");
            dtTrxDate.MaxDate = Convert.ToDateTime(actDate[1]);
            dtTrxDate.MinDate = Convert.ToDateTime(actDate[0]);
        }

        private void txtPurchOrderDT_Enter(object sender, EventArgs e)
        {
            string[] actDate = Fn.GetRecords("sp_ActiveDates");
            txtPurchOrderDT.MaxDate = Convert.ToDateTime(actDate[1]);
            txtPurchOrderDT.MinDate = Convert.ToDateTime(actDate[0]);
        }

        private void cboStores_SelectedIndexChanged(object sender, EventArgs e)
        {
            Fn.fillCombo(cboProducts, "sp_ProductList '" + cboStores.SelectedValue + "'");
        }
    }
}