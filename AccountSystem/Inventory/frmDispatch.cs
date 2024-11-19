using AccountSystem.Inventory;
using Newtonsoft.Json;
using System;
using System.Windows.Forms;
namespace AccountSystem
{
    public partial class frmDispatch : Form
    {
        private MyModule Fn = new MyModule();
        string[] cData;
        public frmDispatch()
        {
            InitializeComponent();
            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }
        #region Default Instance
        private static frmDispatch defaultInstance;
        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static frmDispatch Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new frmDispatch();
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
            // TODO: This line of code loads data into the 'dataSet1.SODetails1' table. You can move, or remove it, as needed.
            this.sODetails1TableAdapter.Fill(this.dataSet1.SODetails1);

            Fn.fillCombo(cbLocation, "sp_OfficeLocations");
            cbLocation.SelectedValue = MyModule.BranchID;
            Fn.fillCombo(cboStores, "sp_Warehouses");
            lblModify.Text = "" + MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo;
            txtTrxNo.Text = Fn.GetRecords("SELECT isnull(MAX(convert(int,Sale_bill_no)),0) +1 FROM tblSaleOrder WHERE (BranchID = " + cbLocation.SelectedValue + ")")[0];
            Fn.fillCombo(cboVendor, "sp_VendorsList");
            Fn.fillCombo(cboPayTerms, "SELECT PaymentTermsID, PaymentTermsTxt FROM tblPaymentTerms");
            Fn.fillCombo(cboSalesman, "SELECT EntryAccID, EntryAccName FROM TblAccEntry WHERE (AccType = 9)");
            Fn.fillGrdCombo(gdv_prod_name, "SELECT tbl_Product.Prod_id, tbl_Product.Prod_name FROM tbl_Product INNER JOIN tbl_Brand ON tbl_Product.Brand_id = tbl_Brand.Brand_id INNER JOIN tbl_Prod_category ON tbl_Product.Prod_Catg_id = tbl_Prod_category.Prod_ctg_id WHERE (tbl_Product.Disle <> 1) OR (tbl_Product.Disle IS NULL)");

            // TODO: This line of code loads data into the 'dataSet1.SOHead1' table. You can move, or remove it, as needed.
            this.sOHead1TableAdapter.Fill(this.dataSet1.SOHead1,Convert.ToInt32(cbLocation.SelectedValue));
        }
        private void cbo_vendor_SelectedIndexChanged(object sender, EventArgs e)
        {
            cData = Fn.GetRecords("SELECT TblAccEntry.BAddress + '<br><b>Contact No. ' + TblAccEntry.BContactNo AS Addressline, TblAccEntry.BTransport, TblAccEntry.CrLimit, (SELECT ISNULL(SUM(AmountDeb-AmountCre), 0) AS Expr1 FROM VW_VoucherDTL WHERE (AccEntryID = " + cboVendor.SelectedValue + ")) AS Balance, tblLocations.CityNmae + ', ' + 'Region, ' + tblLocations.Province AS Loc, TblAccEntry.PaymentTermsID FROM TblAccEntry INNER JOIN tblLocations ON TblAccEntry.BCity = tblLocations.CityID WHERE (TblAccEntry.EntryAccID = " + cboVendor.SelectedValue + ") ");
            txtAddress.Text = cData[0];
            //txtTransport.Text = cData[1];
            //cboCity.Text = cData[4];
            txtBF.Text=float.Parse(cData[3]).ToString("#,#.00;(#,#.00)");
        }
        private void grdBill_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                if (grdBill.Rows[e.RowIndex].Cells["prchse_prod_rate"].Value == null || grdBill.Rows[e.RowIndex].Cells["prchse_prod_rate"].Value.ToString()=="0" || grdBill.Rows[e.RowIndex].Cells["prchse_prod_rate"].Value.ToString() == "")
                {
                    string[] rates = Fn.GetRecords("sp_GetPurchaseRate '" + grdBill.Rows[e.RowIndex].Cells["gdv_prod_name"].Value + "','" + dtTrxDate.Text + "','" + cboStores.SelectedValue + "'");
                    grdBill.Rows[e.RowIndex].Cells["prchse_prod_rate"].Value = rates[0];
                    grdBill.Rows[e.RowIndex].Cells["gtxtPRate"].Value  = rates[1];

                }
                if (grdBill.Rows[e.RowIndex].Cells["txtInvoiced"].Value == null || grdBill.Rows[e.RowIndex].Cells["txtInvoiced"].Value == DBNull.Value)
                {
                    grdBill.Rows[e.RowIndex].Cells["txtInvoiced"].Value = 1;

                }
                //if (grdBill.Rows[e.RowIndex].Cells["Discount"].Value == null)
                //{
                //    grdBill.Rows[e.RowIndex].Cells["Discount"].Value = 0;
                //}
                //if (grdBill.Rows[e.RowIndex].Cells["GST"].Value == null || grdBill.Rows[e.RowIndex].Cells["GST"].Value == DBNull.Value)
                //{
                //    grdBill.Rows[e.RowIndex].Cells["GST"].Value = 0;
                //}

                grdBill.Rows[e.RowIndex].Cells["x"].Value = global::AccountSystem.Properties.Resources.close;
            }
        }
        private void grdBill_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            double qty = 0, price = 0, amount = 0, tax = 0, gAmount = 0, GST = 0;
            double total = 0; double totalG = 0; double WTax = 0;
            if (e.RowIndex >= 0 || e.RowIndex + 1 < grdBill.Rows.Count)
            {
                if (grdBill.Rows[e.RowIndex].Cells["prchse_prod_rate"].Value != null && (grdBill.Rows[e.RowIndex].Cells["txtInvoiced"].Value != null || grdBill.Rows[e.RowIndex].Cells["txtInvoiced"].Value == DBNull.Value))
                {
                    try
                    {
                        
                        if (grdBill.Rows[e.RowIndex].Cells["txtInvoiced"].Value == null || grdBill.Rows[e.RowIndex].Cells["txtInvoiced"].Value == DBNull.Value)
                        {
                            grdBill.Rows[e.RowIndex].Cells["txtInvoiced"].Value = 1;
                        }

                        else
                        {
                            qty = Double.Parse(grdBill.Rows[e.RowIndex].Cells["txtInvoiced"].Value.ToString());
                        }
                      

                        if (grdBill.Rows[e.RowIndex].Cells["prchse_prod_rate"].Value == null)
                        {
                            grdBill.Rows[e.RowIndex].Cells["prchse_prod_rate"].Value = 0;
                        }
                        else
                        {
                            price = Double.Parse(grdBill.Rows[e.RowIndex].Cells["prchse_prod_rate"].Value.ToString());
                        }
                        //grdBill.Rows[e.RowIndex].Cells["Remaings"].Value =Int32.Parse(grdBill.Rows[e.RowIndex].Cells["Prchse_prod_qty"].Value.ToString()) - Int32.Parse(grdBill.Rows[e.RowIndex].Cells["txtInvoiced"].Value.ToString());
                        //Disc = Double.Parse(grdBill.Rows[e.RowIndex].Cells["Disc"].Value == null ? "0" : grdBill.Rows[e.RowIndex].Cells["Disc"].Value.ToString());
                        //if (grdBill.Rows[e.RowIndex].Cells["Discount"].Value == null || grdBill.Rows[e.RowIndex].Cells["Discount"].Value == DBNull.Value)
                        //{
                        //    grdBill.Rows[e.RowIndex].Cells["Discount"].Value = 0;
                        //}

                        if (grdBill.Rows[e.RowIndex].Cells["GST"].Value == null || grdBill.Rows[e.RowIndex].Cells["GST"].Value == DBNull.Value)
                        {
                            grdBill.Rows[e.RowIndex].Cells["GST"].Value = 0;
                        }
                        else
                        {
                            GST = Double.Parse(grdBill.Rows[e.RowIndex].Cells["GST"].Value.ToString());
                        }
                        gAmount = qty * price;
                        WTax = (gAmount * 0.65) / (1 + (GST / 100));
                        tax = (gAmount * 0.65) - WTax;
                        //tax = GST / 100 * (gAmount*0.65);

                    

                        amount = (gAmount * 0.65);

                    }
                    catch (Exception)
                    {
                        //grdBill.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                        //MessageBox.Show("please enter numeric values in Quantity and price fields");
                    }
                    grdBill.Rows[e.RowIndex].Cells["Prchse_Prod_Amount"].Value = amount;
                    grdBill.Rows[e.RowIndex].Cells["Discount"].Value = tax;
                    grdBill.Rows[e.RowIndex].Cells["GAmount"].Value = gAmount;
                }
            }
            for (int i = 0; i < grdBill.Rows.Count; i++)
            {
                
                if (grdBill.Rows[i].Cells["Prchse_Prod_Amount"].Value != null)
                {
                    totalG = totalG + Convert.ToDouble(grdBill.Rows[i].Cells["GAmount"].Value);
                    total = total + Convert.ToDouble(grdBill.Rows[i].Cells["Prchse_Prod_Amount"].Value);
                    //ItemDiscount = Disc.ToString();
                    txtTotal.Text = Convert.ToDouble(total).ToString("#,#.00");
                    txtLodingUnLoad.Text = Convert.ToDouble(totalG * 0.35).ToString();

                }
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (grdBill.Rows.Count>1)
            {
                btnSave.Enabled = false;
                dtTrxDate.Enabled = false;
                cboVendor.Enabled = false;
                btnAddNew.Visible = true;
                btnGen.Visible = true;
                grdBill.ReadOnly = true;
                string items = "";
                for (int i = 0; i < grdBill.Rows.Count - 1; i++)
                {
                    items = items + "," + "{\"productid\":\"" + grdBill.Rows[i].Cells["gdv_prod_name"].Value.ToString() + "\",\"rate\":\"" + grdBill.Rows[i].Cells["prchse_prod_rate"].Value.ToString() + "\",\"qty\":\"" + grdBill.Rows[i].Cells["txtInvoiced"].Value.ToString() + "\",\"disc\":\"" + grdBill.Rows[i].Cells["Discount"].Value.ToString() + "\"}";

                }
                string Data2Post = "{\"Salesman\":" + cboSalesman.SelectedValue + ",\"VendorID\":" + cboVendor.SelectedValue + ",\"TrxDate\":\"" + dtTrxDate.Value + "\",\"Created\":\"" + MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo + "\",\"CompID\":" + MyModule.CompID + ",\"items\":[" + items.Substring(1) + "]}";

                string ID = Fn.GetRecords("sp_DeliveryChallan '" + Data2Post + "',"+ cbLocation.SelectedValue)[0];
                btnGen.Tag = ID;
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
            this.sOHead1TableAdapter.Fill(this.dataSet1.SOHead1, Convert.ToInt32(cbLocation.SelectedValue));
            //btnSave.Enabled = true;
            btnAddNew.Visible = false;
            btnGen.Visible = true;
            //grdBill.Rows.Clear();
            grdBill.ReadOnly = false;
            cboVendor.Enabled = true;
            dtTrxDate.Enabled = true;


            btnGen.Enabled = true;
            txtLodingUnLoad.Enabled = true;
            txtCarriage.Enabled = true;
            btnPrint.Visible = false;

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            btnGen.Enabled = false;
            //if (cboVendor.SelectedValue == null || cboSalesman.SelectedValue == null || cboBank.SelectedValue == null)
            //{
            //    MessageBox.Show("Please select vaild customer, salesman and bank details.", "Invaild Values", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}
            //if (cboVendor.SelectedValue.ToString() == "6612" && (txtWCName.Text == "" || txtWCPhone.Text == "" || txtWCAddress.Text == ""))
            //{
            //    MessageBox.Show("Please enter Walk-in customer details." + Environment.NewLine + "must enter Name, Contact number, Address etc. ", "Invaild Values", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}
            dispatchDTTextBox.Text = dispatchDTTextBox.Text + "," + dtTrxDate.Text;
            if (grdBill.Rows.Count > 0)
            {
                btnSave.Enabled = false;
                string items = "";
                string PaidAmount = "0";
                double tax = 0;
                //PaidAmount = txtBF.Text;
                for (int i = 0; i < grdBill.Rows.Count; i++)
                {
                    grdBill.Rows[i].Cells["gtxtremaining"].Value = Int32.Parse(grdBill.Rows[i].Cells["gtxtremaining"].Value.ToString()) - Int32.Parse(grdBill.Rows[i].Cells["txtInvoiced"].Value==null?"0": grdBill.Rows[i].Cells["txtInvoiced"].Value.ToString());
grdBill.Rows[i].Cells["RemaingsInv"].Value = Int32.Parse(grdBill.Rows[i].Cells["RemaingsInv"].Value.ToString()) + Int32.Parse(grdBill.Rows[i].Cells["txtInvoiced"].Value == null ? "0" : grdBill.Rows[i].Cells["txtInvoiced"].Value.ToString());
                    tax = tax + Convert.ToDouble(grdBill.Rows[i].Cells["Discount"].Value);
                    items = items + "," + "{\"PRate\":" + JsonConvert.ToString(grdBill.Rows[i].Cells["gtxtPRate"].Value) + ",\"productid\":\"" + grdBill.Rows[i].Cells["gdv_prod_name"].Value.ToString() + "\",\"rate\":\"" + grdBill.Rows[i].Cells["prchse_prod_rate"].Value.ToString() + "\",\"qty\":\"" + (grdBill.Rows[i].Cells["txtInvoiced"].Value == null ? "0" : grdBill.Rows[i].Cells["txtInvoiced"].Value.ToString()) + "\",\"GST\":\"" + grdBill.Rows[i].Cells["GST"].Value.ToString() + "\",\"Tax\":\"" + (grdBill.Rows[i].Cells["Discount"].Value == null ? "0" : grdBill.Rows[i].Cells["Discount"].Value.ToString()) + "\"}";
                }
                string Data2Post = "{\"GatePass\":\"" + txtGatePass.Text + "\",\"Loading\":\"" + txtLodingUnLoad.Text + "\",\"StoreID\":\"" + cboStores.SelectedValue + "\",\"Transport\":" + JsonConvert.ToString(txtTransport.Text) + ",\"BilltyDT\":" + JsonConvert.ToString(dtShip.Text) + ",\"BilltyNo\":" + JsonConvert.ToString(txtBilti.Text) + ",\"ToShip\":" + JsonConvert.ToString(cboCity.Text) + ",\"WlkinName\":\"\",\"WlkinContact\":\"\",\"WlkinAddress\":\"\",\"TotalAmount\":\"" + textNetTotal.Text.Replace(",", "") + "\",\"ItemDiscount\":\"0\",\"TransactionNo\":\"\",\"Salesman\":" + cboSalesman.SelectedValue + ",\"AccEntryID\":\"\",\"Remarks\":" + JsonConvert.ToString(txtRemarks.Text) + ",\"DeliveryChDate\":\"\",\"DeliveryChNo\":\"" + txtDeliveryChNo.Text + "\",\"AmountPaid\":\"" + PaidAmount.Replace(",", "") + "\",\"CarriageFreight\":\"" + txtCarriage.Text.Replace(",", "") + "\",\"PaymentTermsID\":\"" + cboPayTerms.SelectedValue + "\",\"PurchaseOrderDate\":\"\",\"Purch_OrderNo\":" + JsonConvert.ToString(txtTrxNo.Text) + ",\"Contact_id\":" + cboVendor.SelectedValue + ",\"Sale_date\":\""+ dtTrxDate.Text+ "\",\"Created\":\"" + MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo + "\",\"CompID\":" + MyModule.CompID + ",\"items\":[" + items.Substring(1) + "]}";
                //string ID = Fn.GetRecords("sp_CreateSaleInvoice '" + Data2Post + "'," + cbLocation.SelectedValue + "," + txtTrxNo.Tag + ",'" + tax + "'")[0];
                //btnPrint.Tag = ID;
                //if (ID == "a")
                //{
                //    btnGen.Enabled = true;
                //    btnSave.Enabled = true;
                //    MessageBox.Show("There is some issue in data please check and try again", "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    return;
                //}
                btnGen.Enabled = false;
                //cboVendor.Enabled = false;
                txtLodingUnLoad.Enabled = false;
                txtCarriage.Enabled = false;
                btnPrint.Visible = true;
                btnAddNew.Visible = true;
                btnPrint.Enabled = true;
                btnAddNew.Enabled = true;
                grdBill.ReadOnly = true;
                this.Validate();
                this.sOHeadBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSet1);
            }
            else
            {
                MessageBox.Show("Please enter product detail ...");
            }


































            //rptDeliveryChallan PO = new rptDeliveryChallan();
            //PO.Tag = btnPrint.Tag;
            //PO.ShowDialog();


        }

        private void grdBill_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 10)
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
            if (e.ColumnIndex == 10)
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
                        }
                        catch { }
                    }
                }
            }
        }

        private void pOHeadBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                cData = Fn.GetRecords("SELECT TblAccEntry.BAddress + '<br><b>Contact No. ' + TblAccEntry.BContactNo AS Addressline, TblAccEntry.BTransport, ISNULL(TblAccEntry.CrLimit, 0) AS CrLimit, (SELECT ISNULL(SUM(AmountDeb - AmountCre), 0) AS Expr1 FROM VW_VoucherDTL WHERE (AccEntryID = " + cboVendor.SelectedValue + ")) AS Balance, tblLocations.CityNmae + ', ' + tblLocations.Region + ', ' + tblLocations.Province AS Loc, TblAccEntry.PaymentTermsID FROM TblAccEntry LEFT OUTER JOIN tblLocations ON TblAccEntry.BCity = tblLocations.CityID WHERE (TblAccEntry.EntryAccID = " + cboVendor.SelectedValue + ")");
                txtAddress.Text = cData[0];
                //txtTransport.Text = cData[1];
                //cboCity.Text = cData[4];
                cboPayTerms.SelectedValue = cData[5];
                if (Convert.ToInt32(cData[2]) <= Convert.ToInt32(cData[3])+Convert.ToDouble(txtTotal.Text.Replace(",","")))
                {
                    MessageBox.Show("Credit Limit is increasing" + Environment.NewLine + "Credit Limit: " + cData[2] + Environment.NewLine + "Current Balance: " + cData[3], "Credit Limit is increasing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            catch
            {

            }
            lblModify.Text = "" + MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo;
            this.Validate();
            this.sOHeadBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void cbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtTrxNo.Text = Fn.GetRecords("SELECT COUNT(Sale_id) +1 FROM tblDelivery WHERE (BranchID = " + cbLocation.SelectedValue + ")")[0];
            this.sOHead1TableAdapter.Fill(this.dataSet1.SOHead1, Convert.ToInt32(cbLocation.SelectedValue));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            cboStatus.Text = "Removed";
            lblModify.Text = "" + MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo;
            this.Validate();
            this.sOHeadBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);
            this.sOHead1TableAdapter.Fill(this.dataSet1.SOHead1, Convert.ToInt32(cbLocation.SelectedValue));
        }

        private void txtCarriage_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textNetTotal.Text = (Convert.ToDouble((txtTotal.Text == "" ? "0" : txtTotal.Text)) + Convert.ToDouble((txtCarriage.Text == "" ? "0" : txtCarriage.Text)) + Convert.ToDouble((txtLodingUnLoad.Text == "" ? "0" : txtLodingUnLoad.Text))).ToString("#,#.00");
                txtBalance.Text = (Convert.ToDouble((txtBF.Text == ""|| txtBF.Text == "d" ? "0" : txtBF.Text.Replace("(","-").Replace(")",""))) + Convert.ToDouble((textNetTotal.Text == "" ? "0" : textNetTotal.Text))).ToString("#,#.00");

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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            rptSaleInvoice2 PO = new rptSaleInvoice2();
            //rptSaleInvoice PO = new rptSaleInvoice();
            PO.Tag = btnPrint.Tag;
            PO.ShowDialog();
        }

    
    }
}