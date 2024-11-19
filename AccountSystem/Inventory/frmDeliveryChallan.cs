using AccountSystem.Inventory;
using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace AccountSystem
{
    public partial class frmDeliveryChallan : Form
    {
        private MyModule Fn = new MyModule();
        string[] cData;
        string ItemDiscount = "0", NetTotal = "0";
        public frmDeliveryChallan()
        {
            InitializeComponent();
            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }
        #region Default Instance
        private static frmDeliveryChallan defaultInstance;
        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static frmDeliveryChallan Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new frmDeliveryChallan();
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
            panel5.BackColor = panel2.BackColor;
            panel5.Location = new Point(3, 3);

            Fn.fillCombo(cbLocation, "sp_OfficeLocations");
            cbLocation.SelectedValue = MyModule.BranchID;
            Fn.fillCombo(cboStores, "sp_Warehouses");
            cboStores.SelectedIndex = -1;

            lblModify.Text = "" + MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo;
            textBox1.Text = Fn.GetRecords("SELECT isnull(MAX(convert(int,Sale_bill_no)),0) +1 FROM tblDelivery")[0];
            Fn.fillCombo(cboVendor, "sp_VendorsList");
            Fn.fillCombo(cboSalesman, "SELECT EntryAccID, EntryAccName FROM TblAccEntry WHERE (AccType = 9)");
            Fn.fillCombo(cboBank, "SELECT EntryAccID, EntryAccName FROM TblAccEntry WHERE (AccType = 3)");
            Fn.fillCombo(cboPayTerms, "SELECT PaymentTermsID, PaymentTermsTxt FROM tblPaymentTerms");
            Fn.fillCombo(cboProducts, "sp_ProductList '" + cboStores.SelectedValue + "'");
            cboProducts.Text = ""; cboProducts.SelectedIndex = -1; txtRate.Text = ""; txtPRate.Text = ""; txtQty.Text = ""; txtGAmount.Text = "";
            //txtGST.Text = "17";
            txtNetAmt.Text = "";
            cboProducts.Focus();
        }
        private void cbo_vendor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboVendor.SelectedValue.ToString() == "6612")
                {
                    pnlWalkin.Show(); panel5.Hide();
                    //label5.Visible = false;
                    panel5.Location = new Point(24, 30);
                    panel5.BackColor = Color.White;
                    //pnlPaidBalance.Hide();
                    panel6.Visible = true;
                    //tabControl1.SelectedTab = tabControl1.TabPages["tabPage1"];
                }
                else
                {
                    pnlWalkin.Hide(); label5.Visible = true;
                    //tabControl1.SelectedTab = tabControl1.TabPages["tabPage3"];
                    panel5.Show();
                    //pnlPaidBalance.Show();
                 
                }
                cData = Fn.GetRecords("SELECT TblAccEntry.BAddress + '<br><b>Contact No. ' + TblAccEntry.BContactNo AS Addressline, TblAccEntry.BTransport, TblAccEntry.CrLimit, (SELECT ISNULL(SUM(AmountDeb - AmountCre), 0) AS Expr1 FROM VW_VoucherDTL WHERE (AccEntryID = 5601)) AS Balance, tblLocations.CityNmae + ', ' + tblLocations.Region + ', ' + tblLocations.Province AS Loc, TblAccEntry.PaymentTermsID FROM TblAccEntry LEFT OUTER JOIN tblLocations ON TblAccEntry.BCity = tblLocations.CityID WHERE (TblAccEntry.EntryAccID =" + cboVendor.SelectedValue + ") ");
                txtAddress.Text = cData[0];
                txtTransport.Text = cData[1];
                cboCity.Text = cData[4];
                cboPayTerms.SelectedValue = cData[5];
            }
            catch 
            {

            }

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
            double total = 0;double totalG = 0; double WTax = 0;
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
                        if (grdBill.Rows[e.RowIndex].Cells["gtxtGST"].Value == null || grdBill.Rows[e.RowIndex].Cells["gtxtGST"].Value == DBNull.Value)
                        {
                            grdBill.Rows[e.RowIndex].Cells["gtxtGST"].Value = 0;
                        }
                        else
                        {
                            GST = Double.Parse(grdBill.Rows[e.RowIndex].Cells["gtxtGST"].Value.ToString());
                        }

                        gAmount = qty * price;
                        WTax =  (gAmount * Double.Parse(InvoiceTag.Text)/100) / (1 + (GST / 100));
                        tax =  (gAmount * Double.Parse(InvoiceTag.Text) / 100) - WTax;
                        //tax = GST / 100 * (gAmount * 0.65);
                        grdBill.Rows[e.RowIndex].Cells["gtxtTax"].Value = tax;
                        amount = (gAmount * Double.Parse(InvoiceTag.Text) / 100);

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
                    tax = tax + Convert.ToDouble(grdBill.Rows[i].Cells["gtxtTax"].Value);
                }
                if (grdBill.Rows[i].Cells["Prchse_Prod_Amount"].Value != null)
                {
                    totalG = totalG + Convert.ToDouble(grdBill.Rows[i].Cells["GAmount"].Value);
                    total = total + Convert.ToDouble(grdBill.Rows[i].Cells["Prchse_Prod_Amount"].Value);
                    //ItemDiscount = Disc.ToString();
                    txtTotal.Text = Convert.ToDouble(total).ToString("#,#.00");
                    NetTotal = (total + tax).ToString();
                    txtLodingUnLoad.Text = Convert.ToDouble(totalG * (100- Convert.ToDouble(InvoiceTag.Value))/100).ToString();
                }
            }
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (cboVendor.SelectedValue == null || cboSalesman.SelectedValue == null || cboBank.SelectedValue == null)
            {
                MessageBox.Show("Please select vaild customer, salesman and bank details.", "Invaild Values", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cboVendor.SelectedValue.ToString() == "6612" && (txtWCName.Text == "" || txtWCPhone.Text == "" || txtWCAddress.Text == ""))
            {
                MessageBox.Show("Please enter Walk-in customer details." + Environment.NewLine + "must enter Name, Contact number, Address etc. ", "Invaild Values", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (grdBill.Rows.Count > 0)
            {
                //if (cboVendor.SelectedValue.ToString() != "6612")
                //{
                //    if (Convert.ToInt32(cData[2]) <= (Convert.ToDouble(cData[3]) + Convert.ToDouble(txtBalance.Text.Replace(",",""))))
                //    {
                //        string message = "Credit Limit is increasing for " + cboVendor.Text + Environment.NewLine + "Credit Limit: " + cData[2] + Environment.NewLine + "Current Balance: " + cData[3] + Environment.NewLine + "Do you want to save delivery challan?";
                //        string title = "Credit Limit is increasing";
                //        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                //        DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
                //        if (result == DialogResult.Yes)
                //        {
                //            //return;
                //        }
                //        else
                //        {
                //            return;
                //        }
                //    }
                //}
                btnSave.Enabled = false;
                string items = "";
                string PaidAmount=txtPaid.Text;
                double tax = 0;
                if (cboVendor.SelectedValue.ToString() == "6612")
                { PaidAmount = textNetTotal.Text; }
                    for (int i = 0; i < grdBill.Rows.Count; i++)
                {
                    tax = tax + Convert.ToDouble(grdBill.Rows[i].Cells["gtxtTax"].Value);
                    items = items + "," + "{\"PRate\":" + JsonConvert.ToString(grdBill.Rows[i].Cells["gtxtPRate"].Value) + ",\"productid\":\"" + grdBill.Rows[i].Cells["gdv_prod_name"].Tag.ToString() + "\",\"rate\":\"" + grdBill.Rows[i].Cells["prchse_prod_rate"].Value.ToString() + "\",\"qty\":\"" + grdBill.Rows[i].Cells["Prchse_prod_qty"].Value.ToString() + "\",\"GST\":\"" + grdBill.Rows[i].Cells["gtxtGST"].Value.ToString() + "\",\"Tax\":\"" + grdBill.Rows[i].Cells["gtxtTax"].Value.ToString() + "\"}";
                }
                string Data2Post = "{\"InvoiceTag\":\"" + InvoiceTag.Text + "\",\"GatePass\":\"" + txtGatePass.Text + "\",\"Loading\":\"" + txtLodingUnLoad.Text + "\",\"StoreID\":\"" + cboStores.SelectedValue + "\",\"Transport\":" + JsonConvert.ToString(txtTransport.Text) + ",\"BilltyDT\":" + JsonConvert.ToString(dtShip.Text) + ",\"BilltyNo\":" + JsonConvert.ToString(txtBilti.Text) + ",\"ToShip\":" + JsonConvert.ToString(cboCity.Text) + ",\"WlkinName\":" + JsonConvert.ToString(txtWCName.Text) + ",\"WlkinContact\":" + JsonConvert.ToString(txtWCPhone.Text) + ",\"WlkinAddress\":" + JsonConvert.ToString(txtWCAddress.Text) + ",\"TotalAmount\":\"" + textNetTotal.Text.Replace(",","") + "\",\"ItemDiscount\":\"" + ItemDiscount + "\",\"TransactionNo\":" + JsonConvert.ToString(txtCheque.Text) + ",\"Salesman\":" + cboSalesman.SelectedValue + ",\"AccEntryID\":" + cboBank.SelectedValue + ",\"Remarks\":" + JsonConvert.ToString(txtRemarks.Text) + ",\"DeliveryChDate\":\"" + dtDeliveryChDate.Text + "\",\"DeliveryChNo\":\"" + txtDeliveryChNo.Text + "\",\"AmountPaid\":\"" + PaidAmount.Replace(",", "") + "\",\"CarriageFreight\":\"" + txtCarriage.Text.Replace(",", "") + "\",\"PaymentTermsID\":\"" + cboPayTerms.SelectedValue + "\",\"PurchaseOrderDate\":\"" + dtDeliveryChDate.Text + "\",\"Purch_OrderNo\":\"" + txtPurchaseOrder.Text + "\",\"Contact_id\":" + cboVendor.SelectedValue + ",\"Sale_date\":\"" + dtSaleDate.Text + "\",\"Created\":\"" + MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo + "\",\"CompID\":" + MyModule.CompID + ",\"items\":[" + items.Substring(1) + "]}";
                string ID = Fn.GetRecords("sp_DeliveryChallan '" + Data2Post.Replace("'", "''") + "'," + cbLocation.SelectedValue + "," + btnSave.Tag+",'"+tax+"'")[0];
                btnPrint.Tag = ID;
                if (ID == "a")
                {
                    btnSave.Enabled = true;
                    MessageBox.Show("There is some issue in data please check and try again", "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                dtDeliveryChDate.Enabled = false;
                cboVendor.Enabled = false;
                txtLodingUnLoad.Enabled = false;
                txtCarriage.Enabled = false;
                panel5.Enabled = false;
                btnPrint.Enabled = true;
                btnAddNew.Enabled = true;
                grdBill.ReadOnly = true;
                panel4.Visible = true;
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
            textBox1.Text = Fn.GetRecords("SELECT isnull(MAX(convert(int,Sale_bill_no)),0) +1 FROM tbl_Sale WHERE (BranchID = " + cbLocation.SelectedValue + ") AND (InvoiceType = 1)")[0];
            btnSave.Enabled = true;
            btnAddNew.Enabled = false;
            btnPrint.Enabled = false;
            int rw = grdBill.Rows.Count;
            for (int i = 0; i < rw; i++)
            {
                grdBill.Rows.RemoveAt(0);
            }
            txtDeliveryChNo.ReadOnly = false;
            if (txtDeliveryChNo.Text != "")
            {
                txtDeliveryChNo.Tag = txtDeliveryChNo.Text;
            }
            if (btnSave.Tag.ToString() != "0")
            {
                btnAddNew.Tag = btnSave.Tag;
            }
            btnSave.Tag = "0";
            txtDeliveryChNo.Text = "";
            grdBill.ReadOnly = false;
            cboVendor.Enabled = true;
            txtLodingUnLoad.Enabled = true;
            txtCarriage.Enabled = true;
            panel5.Enabled = true;
            dtDeliveryChDate.Enabled = true;
            grdBill.Height = 0;
            panel4.Visible = true;
            cboVendor.SelectedIndex = -1;
            cboSalesman.SelectedIndex = -1;
            txtLodingUnLoad.Text = "";
            txtTotal.Clear();
            txtCarriage.Clear(); txtPaid.Clear();
            txtWCName.Clear(); txtWCPhone.Clear();txtWCAddress.Clear();
            cboProducts.Text = ""; cboProducts.SelectedIndex = -1; txtRate.Text = ""; txtPRate.Text = ""; txtQty.Text = ""; txtGAmount.Text = "";
            //txtGST.Text = "";
            txtNetAmt.Text = "";
            cboProducts.Focus();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            //rptSaleInvoice2 PO = new rptSaleInvoice2();
            rptSaleOrder PO = new rptSaleOrder();
            PO.Tag = btnPrint.Tag;
            PO.ShowDialog();
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
                                grdBill.Height = grdBill.Height - 23;
                                if (grdBill.Rows.Count == 0)
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
        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textNetTotal.Text = (Convert.ToDouble((txtTotal.Text == "" ? "0" : txtTotal.Text)) + Convert.ToDouble((txtCarriage.Text == "" ? "0" : txtCarriage.Text)) + Convert.ToDouble((txtLodingUnLoad.Text == "" ? "0" : txtLodingUnLoad.Text))).ToString("#,#.00");
                txtBalance.Text = (Convert.ToDouble((textNetTotal.Text == "" ? "0" : textNetTotal.Text)) - Convert.ToDouble((txtPaid.Text == "" ? "0" : txtPaid.Text))).ToString("#,#.00");
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
                textNetTotal.Text = (Convert.ToDouble((txtTotal.Text == "" ? "0" : txtTotal.Text)) + Convert.ToDouble((txtCarriage.Text == "" ? "0" : txtCarriage.Text))+Convert.ToDouble((txtLodingUnLoad.Text == "" ? "0" : txtLodingUnLoad.Text))).ToString("#,#.00");
                txtBalance.Text = (Convert.ToDouble((textNetTotal.Text == "" ? "0" : textNetTotal.Text)) - Convert.ToDouble((txtPaid.Text == "" ? "0" : txtPaid.Text))).ToString("#,#.00");
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
                if (Convert.ToDouble((txtPaid.Text == "" ? "0" : txtPaid.Text)) > 0)
                {
                    panel6.Visible = true;
                    panel5.Location = new Point(24, 30);
                    panel5.BackColor = Color.White;
                    Fn.fillCombo(cboBank, "SELECT EntryAccID, EntryAccName FROM TblAccEntry WHERE (AccType = 3)");
                    cboBank.SelectedIndex = -1;
                    panel5.Visible = false;
                   
                    //tabControl1.SelectedTab = tabControl1.TabPages["tabPage1"];
                    txtPaid.Focus();
                }
                else
                {
                    cboBank.SelectedIndex = 0;
                    panel5.BackColor = panel2.BackColor;
                    panel5.Location = new Point(3, 3);
                    panel6.Hide();
                    panel5.Show();
                    
                }
                textNetTotal.Text = (Convert.ToDouble((txtTotal.Text == "" ? "0" : txtTotal.Text)) + Convert.ToDouble((txtCarriage.Text == "" ? "0" : txtCarriage.Text))).ToString("#,#.00");
                txtBalance.Text = (Convert.ToDouble((textNetTotal.Text == "" ? "0" : textNetTotal.Text)) - Convert.ToDouble((txtPaid.Text == "" ? "0" : txtPaid.Text))).ToString("#,#.00");
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
            textBox1.Text = Fn.GetRecords("SELECT isnull(MAX(convert(int,Sale_bill_no)),0) +1 FROM tbl_Sale WHERE (BranchID = " + cbLocation.SelectedValue + ") AND (InvoiceType = 1)")[0];
            Fn.fillCombo(cboProducts, "sp_ProductList '" + cboStores.SelectedValue + "'");
        }
        private void btnAddRow_Click(object sender, EventArgs e)
        {
            if (cboStores.SelectedIndex == -1)
            {
                MessageBox.Show("Please select store location for stock", "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            if (cboProducts.SelectedValue == null || (txtQty.Value + txtRate.Text) == "00")
            {
                MessageBox.Show("Please select product name" + Environment.NewLine + "Please check the entries Qty and rate " + Environment.NewLine + "Can’t save blank values!", "Invaild Values", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //if (cboProducts.Text.Split('|')[1]=="0" || cboProducts.Text.Split('|')[1]=="" || txtQty.Value>Int32.Parse(
            //    cboProducts.Text.Split('|')[1]==""?"0":cboProducts.Text.Split('|')[1].Replace("(","").Replace(")","").Replace(",", "")))
            //{
            //    MessageBox.Show("Stock is not available for select product " + Environment.NewLine + "or stock is less for selected quantity", "Out Of Stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}
            cboStores.Enabled = false;
            grdBill.Rows.Add();
            grdBill.Rows[grdBill.RowCount - 1].Cells[0].Value = cboProducts.Text.Split('|')[0];
            grdBill.Rows[grdBill.RowCount - 1].Cells[0].Tag = cboProducts.SelectedValue;
            grdBill.Rows[grdBill.RowCount - 1].Cells[2].Value = txtRate.Text;
            grdBill.Rows[grdBill.RowCount - 1].Cells["gtxtPRate"].Value = txtPRate.Text;
            grdBill.Rows[grdBill.RowCount - 1].Cells[1].Value = txtQty.Text;
            grdBill.Rows[grdBill.RowCount - 1].Cells[3].Value = txtGAmount.Text;
            grdBill.Rows[grdBill.RowCount - 1].Cells[4].Value = txtGST.Text;
            grdBill.Rows[grdBill.RowCount - 1].Cells[5].Value = txtNetAmt.Text;
            grdBill.Height = grdBill.Height + 22;
            Calc();
            cboProducts.Text = ""; cboProducts.SelectedIndex = -1; txtRate.Text = ""; txtPRate.Text = ""; txtQty.Text = ""; txtGAmount.Text = "";
            //txtGST.Text = "";
            txtNetAmt.Text = "";
            cboProducts.Focus();txtTax.Clear();
        }
        private void cboProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] rates = Fn.GetRecords("sp_GetPurchaseRate '" + cboProducts.SelectedValue + "','" + dtSaleDate.Text + "','" + cboStores.SelectedValue + "'");
            txtRate.Text = rates[0];
            txtPRate.Text = rates[1];
            if (txtQty.Text == null || txtQty.Text == "0" || txtQty.Text == "")
            {
                txtQty.Text = "1";
            }
            if (txtGST.Text == null || txtGST.Text == "")
            {
                txtGST.Text = "0";
            }
            Calc();
        }
        private void Calc()
        {
            double qty = 0, price = 0, amount = 0, tax = 0, gAmount = 0, GST = 0;
            double total = 0; double totalG = 0; double WTax = 0;
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
                    if (txtGST.Text == null)
                    {
                        txtGST.Value = 0;
                    }
                    else
                    {
                        GST = Double.Parse(txtGST.Value.ToString());
                    }

                    gAmount = qty * price;
                    WTax = (gAmount * Double.Parse(InvoiceTag.Value.ToString()) / 100) / (1 + (GST / 100));
                    tax = (gAmount * Double.Parse(InvoiceTag.Value.ToString()) / 100) - WTax;
                    //tax = (Convert.ToDouble(txtGST.Value) / 100) * (gAmount*0.65);
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
                    totalG = totalG + Convert.ToDouble(grdBill.Rows[i].Cells["GAmount"].Value);
                    total = total + Convert.ToDouble(grdBill.Rows[i].Cells["Prchse_Prod_Amount"].Value);
                    txtTotal.Text = Convert.ToDouble(total).ToString();
                    txtLodingUnLoad.Text= Convert.ToDouble(totalG* (100 - Convert.ToDouble(InvoiceTag.Value)) / 100).ToString();
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
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage1"])
            {
                Fn.fillCombo(cboBank, "SELECT EntryAccID, EntryAccName FROM TblAccEntry WHERE (AccType = 3)");
                cboBank.SelectedIndex = -1;
                panel5.Hide();
            }
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage2"])
            {
                Fn.fillCombo(cboBank, "SELECT EntryAccID, EntryAccName FROM TblAccEntry WHERE (AccType = 2)");
                cboBank.SelectedIndex = -1;
                panel5.Hide();
            }
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage3"])
            {
                panel5.Show();
            }
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
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

        private void dtShip_Enter(object sender, EventArgs e)
        {
            string[] actDate = Fn.GetRecords("sp_ActiveDates");
            dtShip.MaxDate = Convert.ToDateTime(actDate[1]);
            dtShip.MinDate = Convert.ToDateTime(actDate[0]);
        }

        private void cboStores_SelectedIndexChanged(object sender, EventArgs e)
        {
            Fn.fillCombo(cboProducts, "sp_ProductList '" + cboStores.SelectedValue + "'");
        }

        private void txtDAmt_ValueChanged(object sender, EventArgs e)
        {
            Calc();
        }
    }
}