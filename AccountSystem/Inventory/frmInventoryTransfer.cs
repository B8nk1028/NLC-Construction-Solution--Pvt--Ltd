using AccountSystem.Inventory;
using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Windows.Forms;
namespace AccountSystem
{
    public partial class InventoryTransfer : Form
    {
        private MyModule Fn = new MyModule();
        string ItemDiscount = "0", NetTotal = "0";
        public InventoryTransfer()
        {
            InitializeComponent();
            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }
        #region Default Instance
        private static InventoryTransfer defaultInstance;
        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static InventoryTransfer Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new InventoryTransfer();
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
            cbLocation.SelectedValue = MyModule.BranchID;
            lblModify.Text = "" + MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo;
            textBox1.Text = Fn.GetRecords("SELECT COUNT(Sale_id) +1 FROM tbl_Sale WHERE (BranchID = " + cbLocation.SelectedValue + ") AND (InvoiceType = 1)")[0];

            Fn.fillCombo(cboVendor, "sp_Warehouses");
            Fn.fillCombo(cboProducts, "SELECT tbl_Product.Prod_id, tbl_Product.Prod_name FROM tbl_Product INNER JOIN tbl_Brand ON tbl_Product.Brand_id = tbl_Brand.Brand_id INNER JOIN tbl_Prod_category ON tbl_Product.Prod_Catg_id = tbl_Prod_category.Prod_ctg_id WHERE (tbl_Product.Disle <> 1) OR (tbl_Product.Disle IS NULL)");
            cboProducts.Text = ""; cboProducts.SelectedIndex = -1; txtRate.Text = ""; txtPRate.Text = ""; txtQty.Text = ""; txtNetAmt.Text = "";
            cboProducts.Focus();
        }
        private void cbo_vendor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Fn.fillCombo(cbLocation, "SELECT convert(varchar,EntryAccID), EntryAccName FROM TblAccEntry WHERE (AccType IN (21, 22)) AND (Stat = 1) AND EntryAccID<>" + cboVendor.SelectedValue);
            string[] cData = Fn.GetRecords("SELECT BAddress + '<br><b>Contact No. ' + BContactNo, BTransport, CrLimit FROM TblAccEntry WHERE (EntryAccID = " + cboVendor.SelectedValue + ")");
            txtAddress.Text = cData[0];
        }
        private void grdBill_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                if (grdBill.Rows[e.RowIndex].Cells["prchse_prod_rate"].Value == null || grdBill.Rows[e.RowIndex].Cells["prchse_prod_rate"].Value.ToString() == "0" || grdBill.Rows[e.RowIndex].Cells["prchse_prod_rate"].Value.ToString() == "")
                {
                    grdBill.Rows[e.RowIndex].Cells["prchse_prod_rate"].Value = Fn.GetRecords("SELECT Prod_Price FROM tbl_Product WHERE (Prod_id = '" + grdBill.Rows[e.RowIndex].Cells["gdv_prod_name"].Value + "')")[0];
                }
                if (grdBill.Rows[e.RowIndex].Cells["Prchse_prod_qty"].Value == null || grdBill.Rows[e.RowIndex].Cells["Prchse_prod_qty"].Value == DBNull.Value)
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
            if (e.RowIndex >= 0 || e.RowIndex < grdBill.Rows.Count)
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
                        if (grdBill.Rows[e.RowIndex].Cells["Discount"].Value == null || grdBill.Rows[e.RowIndex].Cells["Discount"].Value == DBNull.Value)
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
                    Disc = Disc + Convert.ToDouble(grdBill.Rows[i].Cells["Discount"].Value);
                }
                if (grdBill.Rows[i].Cells["Prchse_Prod_Amount"].Value != null)
                {
                    total = total + Convert.ToDouble(grdBill.Rows[i].Cells["Prchse_Prod_Amount"].Value);
                    ItemDiscount = Disc.ToString();
                    txtTotal.Text = Convert.ToInt32(total).ToString();
                    NetTotal = (total + Disc).ToString();
                }
            }
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (grdBill.Rows.Count > 0)
            {
                btnSave.Enabled = false;
                
                string items = "";
                for (int i = 0; i < grdBill.Rows.Count; i++)
                {
                    items = items + "," + "{\"PRate\":" + JsonConvert.ToString(grdBill.Rows[i].Cells["gtxtPRate"].Value) + ",\"productid\":\"" + grdBill.Rows[i].Cells["gdv_prod_name"].Tag.ToString() + "\",\"rate\":\"" + grdBill.Rows[i].Cells["prchse_prod_rate"].Value.ToString() + "\",\"qty\":\"" + grdBill.Rows[i].Cells["Prchse_prod_qty"].Value.ToString() + "\",\"disc\":\"" + grdBill.Rows[i].Cells["Discount"].Value.ToString() + "\"}";
                }
                string Data2Post = "{\"TotalAmount\":\"" + NetTotal + "\",\"Remarks\":" + JsonConvert.ToString(txtRemarks.Text) + ",\"CarriageFreight\":\"" + txtCarriage.Text + "\",\"Contact_id\":" + cboVendor.SelectedValue + ",\"Sale_date\":\"" + dtSaleDate.Value + "\",\"Created\":\"" + MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo + "\",\"CompID\":" + MyModule.CompID + ",\"items\":[" + items.Substring(1) + "]}";
                string ID = Fn.GetRecords("sp_InventoryTransfer '" + Data2Post + "'," + cbLocation.SelectedValue + "," + btnSave.Tag)[0];
                btnPrint.Tag = ID;
                if (ID == "a")
                {
                    btnSave.Enabled = true;
                    MessageBox.Show("There is some issue in data please check and try again", "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                cboVendor.Enabled = false;
                btnPrint.Enabled = true;
                grdBill.ReadOnly = true;
                btnAddNew.Enabled = true;
                panel4.Visible = false;
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
            textBox1.Text = Fn.GetRecords("SELECT COUNT(Sale_id) +1 FROM tblInventoryTransfer WHERE (BranchID = " + cbLocation.SelectedValue + ")")[0];
            btnSave.Enabled = true;
            btnPrint.Enabled = false;
            btnAddNew.Enabled = false;
            int rw = grdBill.Rows.Count;
            for (int i = 0; i < rw; i++)
            {
                grdBill.Rows.RemoveAt(0);
            }
            if (btnSave.Tag.ToString() != "0")
            {
                btnAddNew.Tag = btnSave.Tag;
            }
            btnSave.Tag = "0";
            grdBill.ReadOnly = false;
            cboVendor.Enabled = true;
            grdBill.Height = 0;
            panel4.Visible = true;
            cboProducts.Text = ""; cboProducts.SelectedIndex = -1; txtRate.Text = ""; txtPRate.Text = ""; txtQty.Text = ""; txtNetAmt.Text = "";
            cboProducts.Focus(); txtTotal.Clear();txtCarriage.Clear(); cboVendor.SelectedIndex = -1;
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            rptTransferNote PO = new rptTransferNote();
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
            if (e.ColumnIndex == 7)
            {
                if (btnSave.Enabled)
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
        }
        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textNetTotal.Text = (Convert.ToInt32((txtTotal.Text == "" ? "0" : txtTotal.Text)) + Convert.ToInt32((txtCarriage.Text == "" ? "0" : txtCarriage.Text))).ToString();
            }
            catch
            {
                MessageBox.Show("Invalid Values", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TextBox thisbox = sender as TextBox;
                thisbox.Focus();
                thisbox.Undo();
                thisbox.ClearUndo();
            }
        }
        private void txtCarriage_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textNetTotal.Text = (Convert.ToInt32((txtTotal.Text == "" ? "0" : txtTotal.Text)) + Convert.ToInt32((txtCarriage.Text == "" ? "0" : txtCarriage.Text))).ToString();
            }
            catch
            {
                MessageBox.Show("Invalid Values", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TextBox thisbox = sender as TextBox;
                thisbox.Focus();
                thisbox.Undo();
                thisbox.ClearUndo();
            }
        }
        private void txtPaid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textNetTotal.Text = (Convert.ToInt32((txtTotal.Text == "" ? "0" : txtTotal.Text)) + Convert.ToInt32((txtCarriage.Text == "" ? "0" : txtCarriage.Text))).ToString();
            }
            catch
            {
                MessageBox.Show("Invalid Values", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TextBox thisbox = sender as TextBox;
                thisbox.Focus();
                thisbox.Undo();
                thisbox.ClearUndo();
            }
        }
        private void cbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] cData = Fn.GetRecords("SELECT BAddress + '<br><b>Contact No. ' + BContactNo, BTransport, CrLimit FROM TblAccEntry WHERE (EntryAccID = " + cbLocation.SelectedValue + ")");
            txtAddressTo.Text = cData[0];
            textBox1.Text = Fn.GetRecords("SELECT COUNT(Sale_id) +1 FROM tblInventoryTransfer WHERE (BranchID = " + cbLocation.SelectedValue + ")")[0];
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
            grdBill.Rows[grdBill.RowCount - 1].Cells[2].Value = txtRate.Text;
            grdBill.Rows[grdBill.RowCount - 1].Cells["gtxtPRate"].Value = txtPRate.Text;
            grdBill.Rows[grdBill.RowCount - 1].Cells[1].Value = txtQty.Text;
            grdBill.Rows[grdBill.RowCount - 1].Cells[6].Value = txtNetAmt.Text;
            grdBill.Height = grdBill.Height + 22;
            Calc();
            cboProducts.Text = ""; cboProducts.SelectedIndex = -1; txtRate.Text = ""; txtPRate.Text = ""; txtQty.Text = ""; txtNetAmt.Text = "";
            cboProducts.Focus();
        }
        private void cboProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] rates = Fn.GetRecords("sp_GetPurchaseRate '" + cboProducts.SelectedValue + "','" + dtSaleDate.Text + "','" + cbLocation.SelectedValue + "'");
            //txtRate.Text = rates[0];//changed on haroon request 30 aug 2018
            txtRate.Text = rates[1];
            txtPRate.Text = rates[1];
            if (txtQty.Text == null || txtQty.Text == "0" || txtQty.Text == "")
            {
                txtQty.Text = "1";
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
                    gAmount = qty * price;
                    //Discount = gAmount * Disc / 100;
                    amount = gAmount - Discount;
                }
                catch (Exception)
                {
                    //grdBill.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                    //MessageBox.Show("please enter numeric values in Quantity and price fields");
                }
                txtNetAmt.Text = amount.ToString();
            }
            for (int i = 0; i < grdBill.Rows.Count; i++)
            {
                if (grdBill.Rows[i].Cells["Prchse_Prod_Amount"].Value != null)
                {
                    total = total + Convert.ToDouble(grdBill.Rows[i].Cells["Prchse_Prod_Amount"].Value);
                    txtTotal.Text = Convert.ToInt32(total).ToString();
                }
            }
        }
        private void txtQty_ValueChanged(object sender, EventArgs e)
        {
            Calc();
        }
        private void txtRate_ValueChanged(object sender, EventArgs e)
        {
            Calc();
        }

        private void dtSaleDate_Enter(object sender, EventArgs e)
        {
            string[] actDate = Fn.GetRecords("sp_ActiveDates");
            dtSaleDate.MaxDate = Convert.ToDateTime(actDate[1]);
            dtSaleDate.MinDate = Convert.ToDateTime(actDate[0]);
        }

        private void txtDAmt_ValueChanged(object sender, EventArgs e)
        {
            Calc();
        }
    }
}