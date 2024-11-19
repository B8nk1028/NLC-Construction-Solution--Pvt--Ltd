using AccountSystem.Inventory;
using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Windows.Forms;
namespace AccountSystem
{
    public partial class frmEditSaleInvoice : Form
    {
        private MyModule Fn = new MyModule();
        string ItemDiscount = "0", NetTotal = "0";
        public frmEditSaleInvoice()
        {
            InitializeComponent();
            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }
        #region Default Instance
        private static frmEditSaleInvoice defaultInstance;
        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static frmEditSaleInvoice Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new frmEditSaleInvoice();
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
            // TODO: This line of code loads data into the 'dataSet1.SaleRetrunDetails' table. You can move, or remove it, as needed.
            this.saleRetrunDetailsTableAdapter.Fill(this.dataSet1.SaleRetrunDetails);
            lblModify.Text = "" + MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo;

            Fn.fillCombo(cboVendor, "sp_VendorsList");
            Fn.fillCombo(cboSalesman, "SELECT EntryAccID, EntryAccName FROM TblAccEntry WHERE (AccType = 9)");

            Fn.fillCombo(cboPayTerms, "SELECT PaymentTermsID, PaymentTermsTxt FROM tblPaymentTerms");
            Fn.fillGrdCombo(gdv_prod_name, "SELECT tbl_Product.Prod_id, tbl_Product.Prod_name FROM tbl_Product INNER JOIN tbl_Brand ON tbl_Product.Brand_id = tbl_Brand.Brand_id INNER JOIN tbl_Prod_category ON tbl_Product.Prod_Catg_id = tbl_Prod_category.Prod_ctg_id WHERE (tbl_Product.Disle <> 1) OR (tbl_Product.Disle IS NULL)");
        }
        private void cbo_vendor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] cData = Fn.GetRecords("SELECT BAddress + '<br><b>Contact No. ' + BContactNo, BTransport, CrLimit FROM TblAccEntry WHERE (EntryAccID = " + cboVendor.SelectedValue + ")");
            txtAddress.Text = cData[0];

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
                }
  
        }
        private void grdBill_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
            if (grdBill.SelectionMode == DataGridViewSelectionMode.FullRowSelect)
            {
return;
            }
            

            double qty = 0, price = 0, amount = 0, tax = 0, gAmount = 0, Discount = 0, GST = 0; double WTax = 0;
            double total = 0; double GAmt = 0;
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


                        WTax = (gAmount * Double.Parse(InvoiceTag.Text) / 100) / (1.17);
                        tax = (gAmount * Double.Parse(InvoiceTag.Text) / 100) - WTax;

                        grdBill.Rows[e.RowIndex].Cells["Discount"].Value = tax;

                        amount = gAmount + tax;












                    }
                    catch (Exception ex)
                    {
                        //grdBill.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                        //MessageBox.Show("please enter numeric values in Quantity and price fields");
                    }
                    grdBill.Rows[e.RowIndex].Cells["Prchse_Prod_Amount"].Value = amount;
                    //grdBill.Rows[e.RowIndex].Cells["Discount"].Value = Discount;
                    grdBill.Rows[e.RowIndex].Cells["GAmount"].Value = gAmount;
                }
            }
            for (int i = 0; i < grdBill.Rows.Count - 1; i++)
            {
              
                if (grdBill.Rows[i].Cells["Prchse_Prod_Amount"].Value != null)
                {
                    try
                    {
                        total = total + Convert.ToDouble(grdBill.Rows[i].Cells["Prchse_Prod_Amount"].Value);
                        GAmt = GAmt + Convert.ToDouble(grdBill.Rows[i].Cells["GAmount"].Value);
                        GST = GST + Convert.ToDouble(grdBill.Rows[i].Cells["Discount"].Value);
                        ItemDiscount = GST.ToString();
                        txtTotal.Text = Convert.ToDouble(total).ToString("#,#.00");
                        //txtGTotal.Text = (Convert.ToDouble(GAmt) - Convert.ToDouble(txtLodingUnLoad.Text)).ToString();
                        NetTotal = (total + GST).ToString();
                    }
                    catch (Exception ex)
                    {

                    }

                }
            }
            double lod = 0;
            if (double.TryParse(txtLodingUnLoad.Text, out lod))
            {
                lod = double.Parse(txtLodingUnLoad.Text);
            }
            txtLodingUnLoad.Text = Convert.ToDouble(GAmt * (100 - Convert.ToDouble(InvoiceTag.Value)) / 100).ToString();
            txtGTotal.Text = (Convert.ToDouble(GAmt) - lod - GST).ToString("#,#.00");
            //textNetTotal.Text = (Convert.ToDouble((txtTotal.Text == "" ? "0" : txtTotal.Text)) + Convert.ToDouble((txtCarriage.Text == "" ? "0" : txtCarriage.Text))).ToString("#,#.00");
            textNetTotal.Text = (Convert.ToDouble((txtTotal.Text == "" ? "0" : txtTotal.Text)) - GST+ Convert.ToDouble((txtCarriage.Text == "" ? "0" : txtCarriage.Text))).ToString("#,#.00");
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < grdBill.Rows.Count - 1; i++)
            {
                if (grdBill.Rows[i].Cells["Prchse_prod_qty"].Value == null || grdBill.Rows[i].Cells["gdv_prod_name"].Value == DBNull.Value)
                {

                    grdBill.Rows.RemoveAt(i);
                }
            }
            lblModify.Text = lblModify.Text+"," + MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo;
            this.Validate();
            this.saleRetrunHeadBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            rptSaleInvoice2 PO = new rptSaleInvoice2();
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

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            double total = 0; double totalG = 0; double gst = 0;
            try
            {
                //for (int i = 0; i < grdBill.Rows.Count; i++)
                //{

                //    if (grdBill.Rows[i].Cells["Prchse_Prod_Amount"].Value != null)
                //    {
                //        totalG = totalG + Convert.ToDouble(grdBill.Rows[i].Cells["GAmount"].Value);
                //        total = total + Convert.ToDouble(grdBill.Rows[i].Cells["Prchse_Prod_Amount"].Value);
                //        gst = gst + Convert.ToDouble(grdBill.Rows[i].Cells["Discount"].Value);
                //        //ItemDiscount = Disc.ToString();
                //        //txtTotal.Text = Convert.ToDouble(totalG).ToString("#,#.00");
                //        //txtLodingUnLoad.Text = Convert.ToDouble(totalG * 0.35).ToString();

                //    }
                //}
                //double lod = 0;
                //if (double.TryParse(txtLodingUnLoad.Text,out lod))
                //{
                //    lod = double.Parse(txtLodingUnLoad.Text);
                //}
                //txtLodingUnLoad.Text = Convert.ToDouble(totalG * 0.35).ToString();
                //txtGTotal.Text = (Convert.ToDouble(totalG) - lod - gst).ToString("#,#.00");
                //textNetTotal.Text = (Convert.ToDouble((txtTotal.Text == "" ? "0" : txtTotal.Text)) + Convert.ToDouble((txtCarriage.Text == "" ? "0" : txtCarriage.Text))).ToString("#,#.00");

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

        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (grdBill.Rows.Count <= 1)
                {
                    this.saleRetrunDetailsTableAdapter.Fill(this.dataSet1.SaleRetrunDetails);


                }
                txtDeliveryChNo.ReadOnly = true;
                grdBill.ReadOnly = false;
                txtDeliveryChNo.Text = txtDeliveryChNo.Tag.ToString();

                cboVendor.Enabled = false;
                dtDeliveryChDate.Enabled = false;
            }
            catch
            {
            }
        }

        private void searchToolStripTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                fillToolStripButton_Click(sender, e);
            }
            
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.saleRetrunHeadTableAdapter.Fill(this.dataSet1.SaleRetrunHead, "%"+searchToolStripTextBox.Text+"%");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}