using AccountSystem.Inventory;
using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
namespace AccountSystem
{
    public partial class frmSaleReturn : Form
    {
        private MyModule Fn = new MyModule();
        string ItemDiscount = "0", NetTotal = "0";
        public frmSaleReturn()
        {
            InitializeComponent();
            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }
        #region Default Instance
        private static frmSaleReturn defaultInstance;
        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static frmSaleReturn Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new frmSaleReturn();
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
            if (MyModule.UserName == "Admin")
            {
                btnDel.Visible = true;
            }
            Fn.fillCombo(cbLocation, "sp_OfficeLocations");
            cbLocation.SelectedValue = MyModule.BranchID;
            Fn.fillCombo(cboStores, "sp_Warehouses");
            // TODO: This line of code loads data into the 'dataSet1.SaleRetrunDetails' table. You can move, or remove it, as needed.
            this.saleRetrunDetailsTableAdapter.Fill(this.dataSet1.SaleRetrunDetails);
            lblModify.Text = "" + MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo;
            textBox1.Text = Fn.GetRecords("SELECT isnull(MAX(convert(int,Sale_bill_no)),0) +1 FROM tbl_Sale WHERE (BranchID = " + MyModule.BranchID + ") AND (InvoiceType = -1)")[0];
            Fn.fillCombo(cboVendor, "sp_VendorsList");
            Fn.fillCombo(cboSalesman, "SELECT EntryAccID, EntryAccName FROM TblAccEntry WHERE (AccType = 9)");
            Fn.fillCombo(cboBank, "SELECT EntryAccID, EntryAccName FROM TblAccEntry WHERE (AccType = 3)");
            Fn.fillCombo(cboPayTerms, "SELECT PaymentTermsID, PaymentTermsTxt FROM tblPaymentTerms");
            Fn.fillCombo(cboProducts, "sp_ProductList '" + cbLocation.SelectedValue + "'");
            Fn.fillGrdCombo(gdv_prod_name, "SELECT tbl_Product.Prod_id, tbl_Product.Prod_name FROM tbl_Product INNER JOIN tbl_Brand ON tbl_Product.Brand_id = tbl_Brand.Brand_id INNER JOIN tbl_Prod_category ON tbl_Product.Prod_Catg_id = tbl_Prod_category.Prod_ctg_id WHERE (tbl_Product.Disle <> 1) OR (tbl_Product.Disle IS NULL)");
        }
        private void cbo_vendor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] cData = Fn.GetRecords("SELECT BAddress + '<br><b>Contact No. ' + BContactNo, BTransport, CrLimit FROM TblAccEntry WHERE (EntryAccID = " + cboVendor.SelectedValue + ")");
            txtAddress.Text = cData[0];
            txtTransport.Text = cData[1];
        }
        private void grdBill_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                if (grdBill.Rows[e.RowIndex].Cells["prchse_prod_rate"].Value == null || grdBill.Rows[e.RowIndex].Cells["prchse_prod_rate"].Value.ToString() == "0" || grdBill.Rows[e.RowIndex].Cells["prchse_prod_rate"].Value.ToString() == "")
                {
                    string[] rates = Fn.GetRecords("SELECT Prod_Price,P_Price FROM tbl_Product WHERE (Prod_id = '" + grdBill.Rows[e.RowIndex].Cells["gdv_prod_name"].Value + "')");
                    grdBill.Rows[e.RowIndex].Cells["prchse_prod_rate"].Value = rates[0];
                    grdBill.Rows[e.RowIndex].Cells["gtxtPRate"].Value = rates[1];
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
                refreshData(e.RowIndex);
            }
            
        }
        private void refreshData(int r)
        {




            double qty = 0, price = 0, amount = 0, tax = 0, gAmount = 0, Discount = 0, GST = 0; double WTax = 0;
            double total = 0; double GAmt = 0;
            if ((r >= 0 || r < grdBill.Rows.Count)&& r!=-1)
            {
                if (grdBill.Rows[r].Cells["prchse_prod_rate"].Value != null && (grdBill.Rows[r].Cells["Prchse_prod_qty"].Value != null || grdBill.Rows[r].Cells["Prchse_prod_qty"].Value == DBNull.Value))
                {
                    try
                    {
                        if (grdBill.Rows[r].Cells["Prchse_prod_qty"].Value == null || grdBill.Rows[r].Cells["Prchse_prod_qty"].Value == DBNull.Value)
                        {
                            grdBill.Rows[r].Cells["Prchse_prod_qty"].Value = 1;
                    }
                        else
                        {
                        qty = Double.Parse(grdBill.Rows[r].Cells["Prchse_prod_qty"].Value.ToString());
                    }
                        if (grdBill.Rows[r].Cells["prchse_prod_rate"].Value == null)
                        {
                            grdBill.Rows[r].Cells["prchse_prod_rate"].Value = 0;
                        }
                        else
                        {
                            price = Double.Parse(grdBill.Rows[r].Cells["prchse_prod_rate"].Value.ToString());
                        }
                        //Disc = Double.Parse(grdBill.Rows[r].Cells["Disc"].Value == null ? "0" : grdBill.Rows[r].Cells["Disc"].Value.ToString());
                        if (grdBill.Rows[r].Cells["Discount"].Value == null || grdBill.Rows[r].Cells["Discount"].Value == DBNull.Value)
                        {
                            grdBill.Rows[r].Cells["Discount"].Value = 0;
                        }
                        else
                        {
                            Discount = Double.Parse(grdBill.Rows[r].Cells["Discount"].Value.ToString());
                        }
                        gAmount = qty * price;
                        //Discount = gAmount * Disc / 100;


                        WTax = (gAmount * 0.65) / (1.17);
                        tax = (gAmount * 0.65) - WTax;

                        grdBill.Rows[r].Cells["Discount"].Value = tax;

                        amount = gAmount + tax;
                    }
                    catch (Exception ex)
                    {
                        //grdBill.Rows[r].Cells[e.ColumnIndex].Value = 0;
                        //MessageBox.Show("please enter numeric values in Quantity and price fields");
                    }
                    grdBill.Rows[r].Cells["Prchse_Prod_Amount"].Value = amount;
                    //grdBill.Rows[r].Cells["Discount"].Value = Discount;
                    grdBill.Rows[r].Cells["GAmount"].Value = gAmount;
                }
            }
            for (int i = 0; i < grdBill.Rows.Count; i++)
            {
                if (grdBill.Rows[i].Cells["Prchse_Prod_Amount"].Value != null)
                {
                    try
                    {
                        total = total + Convert.ToDouble(grdBill.Rows[i].Cells["Prchse_Prod_Amount"].Value);
                        GAmt = GAmt + Convert.ToDouble(grdBill.Rows[i].Cells["GAmount"].Value);
                        GST = GST + Convert.ToDouble(grdBill.Rows[i].Cells["Discount"].Value);
                        ItemDiscount = GST.ToString();
                        txtTotal.Text = Convert.ToDouble(total).ToString();
                        //txtGTotal.Text = (Convert.ToDouble(GAmt) - Convert.ToDouble(txtLodingUnLoad.Text)).ToString();
                        NetTotal = (total + GST).ToString();
                    }
                    catch (Exception ex)
                    {

                    }

                }
            }
            txtTotal.Text = Convert.ToDouble(GAmt).ToString("#,#.00");

            txtLodingUnLoad.Text = Convert.ToDouble(GAmt * (100 - Convert.ToDouble(cboPayTerms.Tag)) / 100).ToString();
            double lod = 0;
            if (double.TryParse(txtLodingUnLoad.Text, out lod))
            {
                lod = double.Parse(txtLodingUnLoad.Text);
            }
            txtGTotal.Text = (Convert.ToDouble(GAmt) - lod - GST).ToString();
            textNetTotal.Text = (Convert.ToDouble((txtTotal.Text == "" ? "0" : txtTotal.Text)) - GST + Convert.ToDouble((txtCarriage.Text == "" ? "0" : txtCarriage.Text))).ToString("#,#.00");
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (grdBill.Rows.Count > 0)
            {
                btnSave.Enabled = false;
                string items = "";
                for (int i = 0; i < grdBill.Rows.Count; i++)
                {
                    items = items + "," + "{\"PRate\":" + JsonConvert.ToString(grdBill.Rows[i].Cells["gtxtPRate"].Value) + ",\"PackingDetail\":" + JsonConvert.ToString(grdBill.Rows[i].Cells["packingDetailDataGridViewTextBoxColumn"].Value.ToString()) + ",\"productid\":\"" + grdBill.Rows[i].Cells["gdv_prod_name"].Value.ToString() + "\",\"rate\":\"" + grdBill.Rows[i].Cells["prchse_prod_rate"].Value.ToString() + "\",\"qty\":\"" + grdBill.Rows[i].Cells["Prchse_prod_qty"].Value.ToString() + "\",\"disc\":\"" + grdBill.Rows[i].Cells["Discount"].Value.ToString() + "\"}";
                }
                string Data2Post = "{\"InvoiceTag\":\"" + cboPayTerms.Tag + "\",\"Loading\":\"" + txtLodingUnLoad.Text + "\",\"StoreID\":\"" + cboStores.SelectedValue + "\",\"WlkinName\":" + JsonConvert.ToString(wlkinNameTextBox.Text) + ",\"WlkinContact\":" + JsonConvert.ToString(wlkinContactTextBox.Text) + ",\"WlkinAddress\":" + JsonConvert.ToString(wlkinAddressTextBox.Text) + ",\"TotalAmount\":\"" + textNetTotal.Text.Replace(",", "") + "\",\"ItemDiscount\":\"0\",\"Transport\":" + JsonConvert.ToString(txtTransport.Text) + ",\"TransactionNo\":" + JsonConvert.ToString(txtCheque.Text) + ",\"Salesman\":" + cboSalesman.SelectedValue + ",\"AccEntryID\":" + cboBank.SelectedValue + ",\"Remarks\":" + JsonConvert.ToString(txtRemarks.Text) + ",\"DeliveryChDate\":\"" + dtDeliveryChDate.Text + "\",\"DeliveryChNo\":\"" + txtDeliveryChNo.Text + "\",\"AmountPaid\":\"" + txtPaid.Text + "\",\"CarriageFreight\":\"" + txtCarriage.Text + "\",\"PaymentTermsID\":\"" + cboPayTerms.SelectedValue + "\",\"PurchaseOrderDate\":\"" + dtDeliveryChDate.Text + "\",\"Purch_OrderNo\":\"" + txtDeliveryChNo.Text + "\",\"Contact_id\":" + cboVendor.SelectedValue + ",\"Sale_date\":\"" + dtSaleDate.Text + "\",\"Created\":\"" + MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo + "\",\"CompID\":" + MyModule.CompID + ",\"items\":[" + items.Substring(1) + "]}";
                string ID = Fn.GetRecords("sp_CreateSaleRetrun '" + Data2Post + "'," + cbLocation.SelectedValue + "," + (btnSave.Tag.ToString() == "" ? "0" : btnSave.Tag.ToString()))[0];
                btnPrint.Tag = ID;
                if (ID == "a")
                {
                    btnSave.Enabled = true;
                    MessageBox.Show("There is some issue in data please check and try again", "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                dtDeliveryChDate.Enabled = false;
                cboVendor.Enabled = false;
                btnPrint.Enabled = true;
                grdBill.ReadOnly = true;
                panel5.Hide(); btnAddNew.Enabled = true;
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
            btnAddNew.Enabled = false;
            listBox1.ClearSelected();
            cbLocation.Enabled = true;
            panel5.Show();
            textBox1.Text = Fn.GetRecords("SELECT isnull(MAX(convert(int,Sale_bill_no)),0) +1 FROM tbl_Sale WHERE (BranchID = " + cbLocation.SelectedValue + ") AND (InvoiceType = -1)")[0];
            btnSave.Enabled = true;
            btnPrint.Enabled = false;
            int rw = grdBill.Rows.Count;
            for (int i = 0; i < rw; i++)
            {
                grdBill.Rows.RemoveAt(0);
            }
            if (rw < 0)
            {
                grdBill.DataSource = null;
            }
            txtDeliveryChNo.ReadOnly = false;
            grdBill.Height = (grdBill.Rows.Count * 22) + 28;
            if (txtDeliveryChNo.Text != "")
            {
                txtDeliveryChNo.Tag = txtDeliveryChNo.Text;
            }
            btnSave.Tag = "0";
            if (btnSave.Tag.ToString() != "0")
            {
                btnAddNew.Tag = btnSave.Tag;
            }
            txtDeliveryChNo.Text = "";
            grdBill.ReadOnly = false;
            cboVendor.Enabled = true;
            if (!listBox1.Enabled)
            {
                listBox1.Enabled = true;
                try
                {
                    saleRetrunHeadBindingSource.RemoveAt(listBox1.SelectedIndex);
                }
                catch
                {
                }
            }
            dtDeliveryChDate.Enabled = true;
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            rptSaleRetrun PO = new rptSaleRetrun();
            PO.Tag = btnPrint.Tag;
            PO.ShowDialog();
        }
        private void grdBill_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.ColumnIndex == 8)
            {
                grdBill.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            //else
            //{
            //    grdBill.SelectionMode = DataGridViewSelectionMode.CellSelect;
            //}
        }
        private void grdBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
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
        private void pOHeadBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            lblModify.Text = "" + MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo;
            this.Validate();
            this.saleRetrunHeadBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage1"])
            {
                Fn.fillCombo(cboBank, "SELECT EntryAccID, EntryAccName FROM TblAccEntry WHERE (AccType = 3)");
            }
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage2"])
            {
                Fn.fillCombo(cboBank, "SELECT EntryAccID, EntryAccName FROM TblAccEntry WHERE (AccType = 2)");
            }
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage3"])
            {
            }
        }
        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            //double total = 0; double totalG = 0; double gst = 0;
            //try
            //{
            //    for (int i = 0; i < grdBill.Rows.Count; i++)
            //    {

            //        if (grdBill.Rows[i].Cells["Prchse_Prod_Amount"].Value != null)
            //        {
            //            totalG = totalG + Convert.ToDouble(grdBill.Rows[i].Cells["GAmount"].Value);
            //            total = total + Convert.ToDouble(grdBill.Rows[i].Cells["Prchse_Prod_Amount"].Value);
            //            gst = gst + Convert.ToDouble(grdBill.Rows[i].Cells["Discount"].Value);
            //            //ItemDiscount = Disc.ToString();
            //            //txtTotal.Text = Convert.ToDouble(totalG).ToString("#,#.00");

            //            txtLodingUnLoad.Text = Convert.ToDouble(totalG * 0.35).ToString();

            //        }
            //    }
            //    double lod = 0;
            //    if (double.TryParse(txtLodingUnLoad.Text, out lod))
            //    {
            //        lod = double.Parse(txtLodingUnLoad.Text);
            //    }
            //    txtGTotal.Text = (Convert.ToDouble(totalG) - lod - gst).ToString();
            //    textNetTotal.Text = (Convert.ToDouble((txtTotal.Text == "" ? "0" : txtTotal.Text)) + Convert.ToDouble((txtCarriage.Text == "" ? "0" : txtCarriage.Text))).ToString("#,#.00");

            //}
            //catch
            //{
            //    MessageBox.Show("Invalid Values", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    TextBox thisbox = sender as TextBox;
            //    thisbox.Focus();
            //    thisbox.Undo();
            //    thisbox.ClearUndo();
            //}
        }
        private void txtCarriage_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtPaid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32((txtPaid.Text == "" ? "0" : txtPaid.Text)) > 0)
                {
                    panel6.Show();
                    Fn.fillCombo(cboBank, "SELECT EntryAccID, EntryAccName FROM TblAccEntry WHERE (AccType = 3)");
                    tabControl1.SelectedTab = tabControl1.TabPages["tabPage1"];
                    txtPaid.Focus(); cboBank.SelectedIndex = -1;
                    //label5.Show();
                    cboBank.Show();
                    //txtRemarks.Show();
                }
                else
                {
                    panel6.Hide(); cboBank.SelectedIndex = 0;
                    //label5.Hide();
                    cboBank.Hide();
                    //txtRemarks.Hide();
                }
                textNetTotal.Text = (Convert.ToInt32((txtTotal.Text == "" ? "0" : txtTotal.Text)) + Convert.ToInt32((txtCarriage.Text == "" ? "0" : txtCarriage.Text))).ToString();
                txtBalance.Text = (Convert.ToInt32((textNetTotal.Text == "" ? "0" : textNetTotal.Text)) - Convert.ToInt32((txtPaid.Text == "" ? "0" : txtPaid.Text))).ToString();
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
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //grdBill.DataSource = null;
                //int i = this.dataSet1.SaleRetrunDetails.Rows.Count - 1;
                //for (i = 0; i <= i; i++)
                //{
                //    grdBill.Rows[grdBill.RowCount - 1].Cells[0].Value = this.dataSet1.SaleRetrunDetails.Rows[i]["prod_id"];
                //    grdBill.Rows[grdBill.RowCount - 1].Cells[2].Value = this.dataSet1.SaleRetrunDetails.Rows[i]["prod_qty"];
                //    grdBill.Rows[grdBill.RowCount - 1].Cells["gtxtPRate"].Value = this.dataSet1.SaleRetrunDetails.Rows[i]["PRate"];
                //    grdBill.Rows[grdBill.RowCount - 1].Cells[1].Value = this.dataSet1.SaleRetrunDetails.Rows[i]["Prod_rate"];
                //    grdBill.Rows[grdBill.RowCount - 1].Cells[4].Value = this.dataSet1.SaleRetrunDetails.Rows[i]["Disct"];
                //    grdBill.Height = grdBill.Height + 22;
                //}
                if (grdBill.Rows.Count <= 1)
                {
                    //foreach (DataRow rw in this.dataSet1.SaleRetrunDetails)
                    //{
                    //    grdBill.Rows[grdBill.RowCount - 1].Cells[0].Value = rw["prod_id"];
                    //    grdBill.Rows[grdBill.RowCount - 1].Cells[2].Value = rw["prod_qty"];
                    //    grdBill.Rows[grdBill.RowCount - 1].Cells["gtxtPRate"].Value = rw["PRate"];
                    //    grdBill.Rows[grdBill.RowCount - 1].Cells[1].Value = rw["Prod_rate"];
                    //    grdBill.Rows[grdBill.RowCount - 1].Cells[4].Value = rw["Disct"];
                    //    grdBill.Height = grdBill.Height + 22;
                    //}
                    this.saleRetrunDetailsTableAdapter.Fill(this.dataSet1.SaleRetrunDetails);
                }
                grdBill.Height = (grdBill.Rows.Count * 22) + 28;
                txtDeliveryChNo.ReadOnly = true;
                grdBill.ReadOnly = false;
                //txtDeliveryChNo.Text = txtDeliveryChNo.Tag == null ? "" : txtDeliveryChNo.Tag.ToString();
                btnSave.Tag = btnAddNew.Tag;
                cboVendor.Enabled = false;
                dtDeliveryChDate.Enabled = false;
                cbLocation.Enabled = false;
            }
            catch
            {
            }
        }
        private void btnAddRow_Click(object sender, EventArgs e)
        {
            if (cboProducts.SelectedValue == null || (txtQty.Value + txtRate.Text) == "00")
            {
                MessageBox.Show("Please select product name" + Environment.NewLine + "Please check the entries Qty and rate " + Environment.NewLine + "Can’t save blank values!", "Invaild Values", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataRow newRow = this.dataSet1.SaleRetrunDetails.NewRow();
            newRow["prod_id"] = cboProducts.SelectedValue;
            newRow["Prod_rate"] = txtRate.Text;
            newRow["PRate"] = txtPRate.Text;
            newRow["prod_qty"] = txtQty.Text;
            newRow["Disct"] = txtDAmt.Text;
            try
            {
                newRow["Sale_id"] = grdBill.Rows[0].Cells["Sale_id"].Value;
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Please select sale invoice first" + Environment.NewLine + " ", "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            this.dataSet1.SaleRetrunDetails.Rows.Add(newRow);
            //grdBill.Rows[grdBill.RowCount - 1].Cells[0].Value = cboProducts.Text.Split('|')[0];
            //grdBill.Rows[grdBill.RowCount - 1].Cells[0].Tag = cboProducts.SelectedValue;
            //grdBill.Rows[grdBill.RowCount - 1].Cells[0].Value = cboProducts.SelectedValue;
            //grdBill.Rows[grdBill.RowCount - 1].Cells["prchse_prod_rate"].Value = txtRate.Text;
            //grdBill.Rows[grdBill.RowCount - 1].Cells["gtxtPRate"].Value = txtPRate.Text;
            //grdBill.Rows[grdBill.RowCount - 1].Cells["Prchse_prod_qty"].Value = txtQty.Text;
            //grdBill.Rows[grdBill.RowCount - 1].Cells["GAmount"].Value = txtGAmount.Text;
            //grdBill.Rows[grdBill.RowCount - 1].Cells["Discount"].Value = txtDAmt.Text;
            //grdBill.Rows[grdBill.RowCount - 1].Cells["Prchse_Prod_Amount"].Value = txtNetAmt.Text;
            grdBill.Height = grdBill.Height + 22;
            Calc();
            cboProducts.Text = ""; cboProducts.SelectedIndex = -1; txtRate.Text = ""; txtPRate.Text = ""; txtQty.Text = ""; txtGAmount.Text = ""; txtDAmt.Text = ""; txtNetAmt.Text = "";
            cboProducts.Focus();
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
                    //Disc = Double.Parse(grdBill.Rows[r].Cells["Disc"].Value == null ? "0" : grdBill.Rows[r].Cells["Disc"].Value.ToString());
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
                    //grdBill.Rows[r].Cells[e.ColumnIndex].Value = 0;
                    //MessageBox.Show("please enter numeric values in Quantity and price fields");
                }
                txtNetAmt.Text = amount.ToString();
                //grdBill.Rows[r].Cells["Discount"].Value = Discount;
                txtGAmount.Text = gAmount.ToString();
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
        private void txtDAmt_ValueChanged(object sender, EventArgs e)
        {
            Calc();
        }
        private void cboProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] rates = Fn.GetRecords("sp_GetPurchaseRate '" + cboProducts.SelectedValue + "','" + dtSaleDate.Text + "','" + cbLocation.SelectedValue + "'");
            txtRate.Text = rates[0];
            txtPRate.Text = rates[1];
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
        private void cbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = Fn.GetRecords("SELECT isnull(MAX(convert(int,Sale_bill_no)),0) +1 FROM tbl_Sale WHERE (BranchID = " + cbLocation.SelectedValue + ") AND (InvoiceType = -1)")[0];
            Fn.fillCombo(cboProducts, "sp_ProductList '" + cbLocation.SelectedValue + "'");
        }

        private void txtPurchOrderDT_Enter(object sender, EventArgs e)
        {
            string[] actDate = Fn.GetRecords("sp_ActiveDates");
            txtPurchOrderDT.MaxDate = Convert.ToDateTime(actDate[1]);
            txtPurchOrderDT.MinDate = Convert.ToDateTime(actDate[0]);
        }

        private void dtDeliveryChDate_Enter(object sender, EventArgs e)
        {
            string[] actDate = Fn.GetRecords("sp_ActiveDates");
            dtDeliveryChDate.MaxDate = Convert.ToDateTime(actDate[1]);
            dtDeliveryChDate.MinDate = Convert.ToDateTime(actDate[0]);
        }

        private void dtSaleDate_Enter(object sender, EventArgs e)
        {
            string[] actDate = Fn.GetRecords("sp_ActiveDates");
            dtSaleDate.MaxDate = Convert.ToDateTime(actDate[1]);
            dtSaleDate.MinDate = Convert.ToDateTime(actDate[0]);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Fn.Exec("UPDATE tbl_Sale SET CarriageFreight = 0, AmountPaid = 0, TotalAmount = 0, ItemDiscount = 0, AdditionalDiscount = 0 WHERE (Sale_id = "+ btnPrint.Tag + ");UPDATE tbl_SaleDetail SET prod_qty = 0, Disct = 0 WHERE (Sale_id = " + btnPrint.Tag + ")");
                fillToolStripButton_Click(sender, e);


            }
            else
            {
                return;
            }
        }

        private void grdBill_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
         //refreshData(e.RowIndex);   
        }

        private void grdBill_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            refreshData(e.RowIndex);
        }


        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.saleRetrunHeadTableAdapter.Fill(this.dataSet1.SaleRetrunHead, "%" + searchToolStripTextBox.Text + "%");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}