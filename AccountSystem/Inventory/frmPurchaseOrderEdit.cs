using AccountSystem.Inventory;
using System;
using System.Windows.Forms;
namespace AccountSystem
{
    public partial class frmPurchaseOrderEdit : Form
    {
        private MyModule Fn = new MyModule();
        public frmPurchaseOrderEdit()
        {
            InitializeComponent();
            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }
        #region Default Instance
        private static frmPurchaseOrderEdit defaultInstance;
        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static frmPurchaseOrderEdit Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new frmPurchaseOrderEdit();
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
            lblModify.Text = "" + MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo;
            txtTrxNo.Text = Fn.GetRecords("SELECT isnull(MAX(convert(int,Purch_bill_no)),0)+1 FROM tblPurchaseOrder WHERE (BranchID = " + cbLocation.SelectedValue + ") AND (OrderStatus <> 'Removed')")[0];
            Fn.fillCombo(cboVendor, "SELECT EntryAccID, EntryAccName FROM TblAccEntry WHERE (AccType IN (8, 10)) AND (Stat = 1) AND (EntryAccID <> 6612 AND EntryAccID <> 6749)");
            Fn.fillGrdCombo(gdv_prod_name, "SELECT tbl_Product.Prod_id, tbl_Product.Prod_name FROM tbl_Product INNER JOIN tbl_Brand ON tbl_Product.Brand_id = tbl_Brand.Brand_id INNER JOIN tbl_Prod_category ON tbl_Product.Prod_Catg_id = tbl_Prod_category.Prod_ctg_id WHERE (tbl_Product.Disle <> 1 OR tbl_Product.Disle IS NULL) AND (tbl_Product.pType = 1)");
            // TODO: This line of code loads data into the 'dataSet1.PODetails1' table. You can move, or remove it, as needed.
            this.pODetails1TableAdapter.Fill(this.dataSet1.PODetails1);
            // TODO: This line of code loads data into the 'dataSet1.POHead' table. You can move, or remove it, as needed.
            this.pOHead1TableAdapter.Fill(this.dataSet1.POHead1,Convert.ToInt32(cbLocation.SelectedValue));
        }
        private void cbo_vendor_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAddress.Text = Fn.GetRecords("SELECT BAddress+'<br><b>Contact No. '+BContactNo FROM TblAccEntry WHERE (EntryAccID = " + cboVendor.SelectedValue + ")")[0].ToString();
        }
        private void grdBill_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                if (grdBill.Rows[e.RowIndex].Cells["prchse_prod_rate"].Value == null || grdBill.Rows[e.RowIndex].Cells["prchse_prod_rate"].Value.ToString()=="0" || grdBill.Rows[e.RowIndex].Cells["prchse_prod_rate"].Value.ToString() == "")
                {
                    grdBill.Rows[e.RowIndex].Cells["prchse_prod_rate"].Value = Fn.GetRecords("SELECT P_Price FROM tbl_Product WHERE (Prod_id = '" + grdBill.Rows[e.RowIndex].Cells["gdv_prod_name"].Value + "')")[0];
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
            double qty=0, price=0, amount = 0, Disc = 0, gAmount = 0, Discount = 0;
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
                        //amount = gAmount - Discount;
                        amount = gAmount;
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
            for (int i = 0; i < grdBill.Rows.Count - 1; i++)
            {
                if (grdBill.Rows[i].Cells["Prchse_Prod_Amount"].Value != null)
                {
                    total = total + Convert.ToDouble(grdBill.Rows[i].Cells["Prchse_Prod_Amount"].Value);
                    txtTotal.Text = Convert.ToInt32(total).ToString("#,#.00");
                }
            }
            if (e.ColumnIndex == 7)
            {
                if (e.Value.ToString() == "System.Drawing.Bitmap")
                {
                    e.Value = global::AccountSystem.Properties.Resources.close;
                }
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtComInv.Text == "")
            {
                MessageBox.Show("Please enter Commercial Invoice number", "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtPackList.Text == "")
            {
                MessageBox.Show("Please enter Packing list number", "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtBLNum.Text == "")
            {
                MessageBox.Show("Please enter BL number", "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (grdBill.Rows.Count > 0 && cboVendor.SelectedValue != null)
            {
                btnSave.Enabled = false;
                string items = "";
                for (int i = 0; i < grdBill.Rows.Count-1; i++)
                {
                    items = items + "," + "{\"productid\":\"" + grdBill.Rows[i].Cells["gdv_prod_name"].Value.ToString() + "\",\"rate\":\"" + grdBill.Rows[i].Cells["prchse_prod_rate"].Value.ToString() + "\",\"qty\":\"" + grdBill.Rows[i].Cells["Prchse_prod_qty"].Value.ToString() + "\",\"disc\":\"" + grdBill.Rows[i].Cells["Discount"].Value.ToString() + "\",\"itemID\":\"" + grdBill.Rows[i].Cells["PurchDet_id"].Value.ToString() + "\",\"BLNum\":\"" + txtBLNum.Text + "\"}";
                }
                string Data2Post = "{\"OrderID\":\"" + btnPrint.Tag.ToString() + "\",\"BLNum\":\"" + txtBLNum.Text + "\",\"CommercialInvoice\":\"" + txtComInv.Text + "\",\"PackListNum\":\"" + txtPackList.Text + "\",\"SaleContract\":\"" + txtSaleContract.Text + "\",\"VendorID\":" + cboVendor.SelectedValue + ",\"TrxDate\":\"" + dtTrxDate.Text + "\",\"Created\":\"" + MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo + "\",\"CompID\":" + MyModule.CompID + ",\"items\":[" + items.Substring(1) + "]}";
                string ID = Fn.GetRecords("sp_PurchaseOrderShipped '" + Data2Post + "'," + cbLocation.SelectedValue)[0];
                btnPrint.Tag = ID;
                if (ID == "a")
                {
                    btnSave.Enabled = true;
                    MessageBox.Show("There is some issue in data please check and try again", "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                dtTrxDate.Enabled = false;
                cboVendor.Enabled = false;
                btnAddNew.Visible = true;
                btnPrint.Visible = true;
                grdBill.ReadOnly = true;
                //panel4.Visible = false;
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
            //grdBill.Rows.Clear();
            grdBill.ReadOnly = false;
            cboVendor.Enabled = true;
            dtTrxDate.Enabled = true;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            rptPurchaseOrder PO = new rptPurchaseOrder();
            PO.Tag = btnPrint.Tag;
            PO.ShowDialog();


        }

        private void grdBill_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
            if (e.ColumnIndex == grdBill.Rows[0].Cells["x"].ColumnIndex)
            {
                grdBill.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            else
            {
                grdBill.SelectionMode = DataGridViewSelectionMode.CellSelect;
            }
            }
            catch
            {

            }

        }

        private void grdBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == grdBill.Rows[e.RowIndex].Cells["x"].ColumnIndex)
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
            lblModify.Text = "" + MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo;
            this.Validate();
            this.pOHeadBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void cbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.pOHead1TableAdapter.Fill(this.dataSet1.POHead1, Convert.ToInt32(cbLocation.SelectedValue));
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            cboStatus.Text = "Removed";
            lblModify.Text = "" + MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo;
            this.Validate();
            this.pOHeadBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);
            // TODO: This line of code loads data into the 'dataSet1.PODetails' table. You can move, or remove it, as needed.
            this.pODetails1TableAdapter.Fill(this.dataSet1.PODetails1);
            // TODO: This line of code loads data into the 'dataSet1.POHead' table. You can move, or remove it, as needed.
            this.pOHead1TableAdapter.Fill(this.dataSet1.POHead1, Convert.ToInt32(cbLocation.SelectedValue));
        }
    }
}