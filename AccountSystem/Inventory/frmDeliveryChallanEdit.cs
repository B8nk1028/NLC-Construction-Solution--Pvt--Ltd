using AccountSystem.Inventory;
using System;
using System.Windows.Forms;
namespace AccountSystem
{
    public partial class frmDeliveryChallanEdit : Form
    {
        private MyModule Fn = new MyModule();
        string[] cData;
        public frmDeliveryChallanEdit()
        {
            InitializeComponent();
            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }
        #region Default Instance
        private static frmDeliveryChallanEdit defaultInstance;
        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static frmDeliveryChallanEdit Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new frmDeliveryChallanEdit();
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
            lblModify.Text = "" + MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo;
            //txtTrxNo.Text = Fn.GetRecords("SELECT isnull(MAX(convert(int,Sale_bill_no)),0) +1 FROM tblDelivery WHERE (BranchID = " + cbLocation.SelectedValue + ")")[0];
            Fn.fillCombo(cboVendor, "sp_VendorsList");
            Fn.fillCombo(cboPayTerms, "SELECT PaymentTermsID, PaymentTermsTxt FROM tblPaymentTerms");
            Fn.fillCombo(cboSalesman, "SELECT EntryAccID, EntryAccName FROM TblAccEntry WHERE (AccType = 9)");
            Fn.fillGrdCombo(gdv_prod_name, "SELECT tbl_Product.Prod_id, tbl_Product.Prod_name FROM tbl_Product INNER JOIN tbl_Brand ON tbl_Product.Brand_id = tbl_Brand.Brand_id INNER JOIN tbl_Prod_category ON tbl_Product.Prod_Catg_id = tbl_Prod_category.Prod_ctg_id WHERE (tbl_Product.Disle <> 1) OR (tbl_Product.Disle IS NULL)");
            // TODO: This line of code loads data into the 'dataSet1.SODetails' table. You can move, or remove it, as needed.
            this.sODetailsTableAdapter.Fill(this.dataSet1.SODetails,-1);
            // TODO: This line of code loads data into the 'dataSet1.SOHead' table. You can move, or remove it, as needed.
            this.sOHeadTableAdapter.Fill(this.dataSet1.SOHead,Convert.ToInt32(cbLocation.SelectedValue),-1);
        }
        private void cbo_vendor_SelectedIndexChanged(object sender, EventArgs e)
        {
            cData = Fn.GetRecords("SELECT TblAccEntry.BAddress + '<br><b>Contact No. ' + TblAccEntry.BContactNo AS Addressline, TblAccEntry.BTransport, TblAccEntry.CrLimit, (SELECT ISNULL(SUM(AmountDeb-AmountCre), 0) AS Expr1 FROM VW_VoucherDTL WHERE (AccEntryID = " + cboVendor.SelectedValue + ")) AS Balance, tblLocations.CityNmae + ', ' + 'Region, ' + tblLocations.Province AS Loc, TblAccEntry.PaymentTermsID FROM TblAccEntry INNER JOIN tblLocations ON TblAccEntry.BCity = tblLocations.CityID WHERE (TblAccEntry.EntryAccID = " + cboVendor.SelectedValue + ") ");
            txtAddress.Text = cData[0];
            //txtTransport.Text = cData[1];
            //cboCity.Text = cData[4];
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

            double qty = 0, price = 0, amount = 0, tax = 0, gAmount = 0, GST = 17;
            double total = 0; double totalG = 0; double WTax = 0;
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
                        //if (grdBill.Rows[e.RowIndex].Cells["Discount"].Value == null || grdBill.Rows[e.RowIndex].Cells["Discount"].Value == DBNull.Value)
                        //{
                        //    grdBill.Rows[e.RowIndex].Cells["Discount"].Value = 0;
                        //}
                        //else
                        //{
                        //    GST = Double.Parse(grdBill.Rows[e.RowIndex].Cells["Discount"].Value.ToString());
                        //}
                        gAmount = qty * price;
                        WTax = (gAmount * Double.Parse(InvoiceTag.Text) / 100) / (1 + (GST / 100));
                        tax = (gAmount * Double.Parse(InvoiceTag.Text) / 100) - WTax;
                        //tax = GST / 100 * (gAmount * 0.65);
                        //grdBill.Rows[e.RowIndex].Cells["Discount"].Value = tax;
                        amount = (gAmount * Double.Parse(InvoiceTag.Text) / 100);
grdBill.Rows[e.RowIndex].Cells["Prchse_Prod_Amount"].Value = amount;
     grdBill.Rows[e.RowIndex].Cells["GAmount"].Value = gAmount;



                        //gAmount = qty * price;
                        ////tax = GST / 100 * (gAmount * 0.65);
                        //grdBill.Rows[e.RowIndex].Cells["gtxtTax"].Value = Discount;
                        //amount = (gAmount * 0.65);
                    }
                    catch (Exception)
                    {
                        //grdBill.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                        //MessageBox.Show("please enter numeric values in Quantity and price fields");
                    }
                    
                    //grdBill.Rows[e.RowIndex].Cells["Discount"].Value = Discount;
               
                }
            }
            for (int i = 0; i < grdBill.Rows.Count - 1; i++)
            {
                if (grdBill.Rows[i].Cells["Prchse_Prod_Amount"].Value != null)
                {
                   
                    totalG = totalG + Convert.ToDouble(grdBill.Rows[i].Cells["GAmount"].Value);
                    total = total + Convert.ToDouble(grdBill.Rows[i].Cells["Prchse_Prod_Amount"].Value);
                    txtTotal.Text = Convert.ToDouble(total).ToString("#,#.00");
                    txtLodingUnLoad.Text = Convert.ToDouble(totalG * (100 - Convert.ToDouble(InvoiceTag.Value)) / 100).ToString();
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
                btnPrint.Visible = true;
                grdBill.ReadOnly = true;
                string items = "";
                for (int i = 0; i < grdBill.Rows.Count - 1; i++)
                {
                    items = items + "," + "{\"productid\":\"" + grdBill.Rows[i].Cells["gdv_prod_name"].Value.ToString() + "\",\"rate\":\"" + grdBill.Rows[i].Cells["prchse_prod_rate"].Value.ToString() + "\",\"qty\":\"" + grdBill.Rows[i].Cells["Prchse_prod_qty"].Value.ToString() + "\",\"disc\":\"" + grdBill.Rows[i].Cells["Discount"].Value.ToString() + "\"}";

                }
                string Data2Post = "{\"Salesman\":" + cboSalesman.SelectedValue + ",\"VendorID\":" + cboVendor.SelectedValue + ",\"TrxDate\":\"" + dtTrxDate.Value + "\",\"Created\":\"" + MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo + "\",\"CompID\":" + MyModule.CompID + ",\"items\":[" + items.Substring(1) + "]}";

                string ID = Fn.GetRecords("sp_DeliveryChallan '" + Data2Post + "',"+ cbLocation.SelectedValue)[0];
                btnPrint.Tag = ID;
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
            btnSave.Enabled = true;
            btnAddNew.Visible = false;
            btnPrint.Visible = false;
            grdBill.Rows.Clear();
            grdBill.ReadOnly = false;
            cboVendor.Enabled = true;
            dtTrxDate.Enabled = true;
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
                //cData = Fn.GetRecords("SELECT TblAccEntry.BAddress + '<br><b>Contact No. ' + TblAccEntry.BContactNo AS Addressline, TblAccEntry.BTransport, ISNULL(TblAccEntry.CrLimit, 0) AS CrLimit, (SELECT ISNULL(SUM(AmountDeb - AmountCre), 0) AS Expr1 FROM VW_VoucherDTL WHERE (AccEntryID = " + cboVendor.SelectedValue + ")) AS Balance, tblLocations.CityNmae + ', ' + tblLocations.Region + ', ' + tblLocations.Province AS Loc, TblAccEntry.PaymentTermsID FROM TblAccEntry LEFT OUTER JOIN tblLocations ON TblAccEntry.BCity = tblLocations.CityID WHERE (TblAccEntry.EntryAccID = " + cboVendor.SelectedValue + ")");
                //txtAddress.Text = cData[0];
                //txtTransport.Text = cData[1];
                //cboCity.Text = cData[4];
                //cboPayTerms.SelectedValue = cData[5];
                //if (Convert.ToInt32(cData[2]) <= Convert.ToInt32(cData[3])+Convert.ToDouble(txtTotal.Text.Replace(",","")))
                //{
                //    MessageBox.Show("Credit Limit is increasing" + Environment.NewLine + "Credit Limit: " + cData[2] + Environment.NewLine + "Current Balance: " + cData[3], "Credit Limit is increasing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    return;
                //}
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
            this.sOHeadTableAdapter.Fill(this.dataSet1.SOHead, Convert.ToInt32(cbLocation.SelectedValue),-1);
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
            this.sOHeadTableAdapter.Fill(this.dataSet1.SOHead, Convert.ToInt32(cbLocation.SelectedValue),-1);
        }

        private void btnPrintSOrder_Click(object sender, EventArgs e)
        {
            rptSaleOrder PO = new rptSaleOrder();
            PO.Tag = btnPrint.Tag;
            PO.ShowDialog();
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textNetTotal.Text = (Convert.ToDouble((txtTotal.Text == "" ? "0" : txtTotal.Text)) + Convert.ToDouble((txtCarriage.Text == "" ? "0" : txtCarriage.Text)) + Convert.ToDouble((txtLodingUnLoad.Text == "" ? "0" : txtLodingUnLoad.Text))).ToString("#,#.00");
                //txtBalance.Text = (Convert.ToDouble((textNetTotal.Text == "" ? "0" : textNetTotal.Text)) - Convert.ToDouble((txtPaid.Text == "" ? "0" : txtPaid.Text))).ToString("#,#.00");
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
    }
}