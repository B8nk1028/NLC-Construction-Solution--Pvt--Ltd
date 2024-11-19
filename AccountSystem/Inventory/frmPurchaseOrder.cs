using AccountSystem.Inventory;
using Newtonsoft.Json;
using System;
using System.Windows.Forms;
namespace AccountSystem
{
    public partial class frmPurchaseOrder : Form
    {
        private MyModule Fn = new MyModule();
        public frmPurchaseOrder()
        {
            InitializeComponent();
            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }
        #region Default Instance
        private static frmPurchaseOrder defaultInstance;
        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static frmPurchaseOrder Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new frmPurchaseOrder();
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
            txtTrxNo.Text = Fn.GetRecords("SELECT isnull(MAX(convert(int,Purch_bill_no)),0)+1 FROM tblPurchaseOrder WHERE (BranchID = " + cbLocation.SelectedValue + ") AND (OrderStatus <> 'Removed')")[0];
            Fn.fillCombo(cboVendor, "SELECT EntryAccID, EntryAccName FROM TblAccEntry WHERE (AccType IN (8, 10)) AND (Stat = 1) AND (EntryAccID <> 6612 AND EntryAccID <> 6749)");
            //tbl_Brand.Brand_name+' '+tbl_Product.Prod_name+' '+tbl_Prod_category.Prod_ctg_name
            Fn.fillCombo(cboProducts, "SELECT tbl_Product.Prod_id,tbl_Product.Prod_name FROM tbl_Product INNER JOIN tbl_Brand ON tbl_Product.Brand_id = tbl_Brand.Brand_id INNER JOIN tbl_Prod_category ON tbl_Product.Prod_Catg_id = tbl_Prod_category.Prod_ctg_id WHERE (tbl_Product.Disle <> 1 OR tbl_Product.Disle IS NULL) AND (tbl_Product.pType = 1) and (Prod_Catg_id <> 2)");
            cboProducts.Text = ""; cboProducts.SelectedIndex = -1; txtRate.Text = ""; txtQty.Text = ""; txtGAmount.Text = ""; txtDAmt.Text = ""; txtNetAmt.Text = "";
            cboProducts.Focus();
        }
        private void cbo_vendor_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAddress.Text = Fn.GetRecords("SELECT BAddress+'<br><b>Contact No. '+BContactNo FROM TblAccEntry WHERE (EntryAccID = " + cboVendor.SelectedValue + ")")[0].ToString();
        }
        private void grdBill_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                if (grdBill.Rows[e.RowIndex].Cells["prchse_prod_rate"].Value == null || grdBill.Rows[e.RowIndex].Cells["prchse_prod_rate"].Value.ToString() == "0" || grdBill.Rows[e.RowIndex].Cells["prchse_prod_rate"].Value.ToString() == "")
                {
                    grdBill.Rows[e.RowIndex].Cells["prchse_prod_rate"].Value = Fn.GetRecords("SELECT P_Price FROM tbl_Product WHERE (Prod_id = '" + grdBill.Rows[e.RowIndex].Cells["gdv_prod_name"].Value + "')")[0];
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
                        //Disc = Double.Parse(grdBill.Rows[e.RowIndex].Cells["Discount"].Value == null ? "0" : grdBill.Rows[e.RowIndex].Cells["Discount"].Value.ToString());
                        gAmount = qty * price;
                        if (grdBill.Rows[e.RowIndex].Cells["Discount"].Value == null)
                        {
                            grdBill.Rows[e.RowIndex].Cells["Discount"].Value = 0;
                        }
                        else
                        {
                            string[] values = Fn.GetRecords("SELECT P_Price,SalesTax FROM tbl_Product WHERE (Prod_id = '" + grdBill.Rows[e.RowIndex].Cells["gdv_prod_name"].Tag + "')");
                            Discount = Double.Parse(values[1]) * gAmount / 100;
                            //grdBill.Rows[e.RowIndex].Cells["Discount"].Value = Discount;
                        }

                        //Discount = gAmount * Disc / 100;
                        amount = gAmount + Discount;
                    }
                    catch (Exception)
                    {
                        //grdBill.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                        //MessageBox.Show("please enter numeric values in Quantity and price fields");
                    }
                    grdBill.Rows[e.RowIndex].Cells["Discount"].Value = Discount;
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
            if (txtSaleContract.Text == "")
            {
                MessageBox.Show("Please enter demand book number", "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (grdBill.Rows.Count > 0 && cboVendor.SelectedValue != null)
            {
                btnSave.Enabled = false;
                string items = "";
                for (int i = 0; i < grdBill.Rows.Count; i++)
                {
                    items = items + "," + "{\"Descr\":" + JsonConvert.ToString(grdBill.Rows[i].Cells["colDescription"].Value.ToString().Replace("'", "''")) + ",\"productid\":\"" + grdBill.Rows[i].Cells["gdv_prod_name"].Tag.ToString() + "\",\"rate\":\"" + grdBill.Rows[i].Cells["prchse_prod_rate"].Value.ToString() + "\",\"qty\":\"" + grdBill.Rows[i].Cells["Prchse_prod_qty"].Value.ToString() + "\",\"disc\":\"" + grdBill.Rows[i].Cells["Discount"].Value.ToString() + "\"}";
                }
                string Data2Post = "{\"SaleContract\":\"" + txtSaleContract.Text + "\",\"VendorID\":" + cboVendor.SelectedValue + ",\"TrxDate\":\"" + dtTrxDate.Text + "\",\"Created\":\"" + MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo + "\",\"CompID\":" + MyModule.CompID + ",\"items\":[" + items.Substring(1) + "]}";
                string ID = Fn.GetRecords("sp_PurchaseOrder '" + Data2Post.Replace("'", "''") + "'," + cbLocation.SelectedValue)[0];
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
            btnSave.Enabled = true;
            btnAddNew.Visible = false;
            btnPrint.Visible = false;
            grdBill.Rows.Clear();
            grdBill.ReadOnly = false;
            cboVendor.Enabled = true;
            dtTrxDate.Enabled = true;
            panel4.Visible = true;
            grdBill.Height = 0;
            txtTrxNo.Text = Fn.GetRecords("SELECT isnull(MAX(convert(int,Purch_bill_no)),0)+1 FROM tblPurchaseOrder WHERE (BranchID = " + cbLocation.SelectedValue + ")")[0];
            cboProducts.Text = ""; cboProducts.SelectedIndex = -1; txtRate.Text = ""; txtQty.Text = ""; txtGAmount.Text = ""; txtDAmt.Text = ""; txtNetAmt.Text = "";
            cboProducts.Focus();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            rptPurchaseOrder PO = new rptPurchaseOrder();
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
            if (e.ColumnIndex == 7 && grdBill.ReadOnly == false)
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
                        }
                        catch { }
                    }
                }
            }
        }
        private void grdBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void cboProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (txtRate.Text == null || txtRate.Text == "0" || txtRate.Text == "")
            //{
            string[] values = Fn.GetRecords("SELECT P_Price,SalesTax FROM tbl_Product WHERE (Prod_id = '" + cboProducts.SelectedValue + "')");
            txtRate.Text = values[0];


            if (values[1] != "b")
            {

                txtDAmt.Value = (Convert.ToDecimal(txtRate.Text) * Convert.ToDecimal(values[1]) / 100);
            }
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
            double qty = 0, price = 0, amount = 0, Disc = 0, gAmount = 0;
            decimal Discount = 0;
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
                    string[] values = Fn.GetRecords("SELECT P_Price,SalesTax FROM tbl_Product WHERE (Prod_id = '" + cboProducts.SelectedValue + "')");
                    //txtRate.Text = values[0];


                    if (values[1] != "b")
                    {

                        txtDAmt.Value = (Convert.ToDecimal(gAmount) * Convert.ToDecimal(values[1]) / 100);
                    }
                    //if (txtDAmt.Text == null)
                    //{
                    //    txtDAmt.Value = 0;
                    //}
                    //else
                    //{
                    //    Discount = (Convert.ToDecimal(txtRate.Value) * Convert.ToDecimal(txtDAmt.Value) / 100);
                    //}

                    //Discount = gAmount * Disc / 100;
                    amount = gAmount + Convert.ToDouble(txtDAmt.Value);
                    //amount = gAmount;
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
                    txtTotal.Text = Convert.ToDouble(total).ToString("#,#.00");
                }
            }
        }
        private void btnAddRow_Click(object sender, EventArgs e)
        {
            if (cboProducts.SelectedValue == null || (txtQty.Value + txtRate.Text) == "00")
            {
                MessageBox.Show("Please select product name" + Environment.NewLine + "Please check the entries Qty and rate " + Environment.NewLine + "Can’t save blank values!", "Invaild Values", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //Calc();
            grdBill.Rows.Add();
            grdBill.Rows[grdBill.RowCount - 1].Cells[0].Value = cboProducts.Text;
            grdBill.Rows[grdBill.RowCount - 1].Cells[0].Tag = cboProducts.SelectedValue;
            grdBill.Rows[grdBill.RowCount - 1].Cells[1].Value = txtDescr.Text;
            grdBill.Rows[grdBill.RowCount - 1].Cells[2].Value = txtRate.Text;
            grdBill.Rows[grdBill.RowCount - 1].Cells[3].Value = txtQty.Text;
            grdBill.Rows[grdBill.RowCount - 1].Cells[4].Value = txtGAmount.Text;
            grdBill.Rows[grdBill.RowCount - 1].Cells[5].Value = txtDAmt.Value;
            grdBill.Rows[grdBill.RowCount - 1].Cells[6].Value = txtNetAmt.Text;
            grdBill.Height = grdBill.Height + 22;
            cboProducts.Text = ""; cboProducts.SelectedIndex = -1; txtRate.Text = ""; txtQty.Text = ""; txtGAmount.Text = ""; txtDAmt.Text = ""; txtNetAmt.Text = "";
            cboProducts.Focus();
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
        private void cbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTrxNo.Text = Fn.GetRecords("SELECT isnull(MAX(convert(int,Purch_bill_no)),0)+1 FROM tblPurchaseOrder WHERE (BranchID = " + cbLocation.SelectedValue + ")")[0];
        }

        private void dtTrxDate_Enter(object sender, EventArgs e)
        {
            string[] actDate = Fn.GetRecords("sp_ActiveDates");
            dtTrxDate.MaxDate = Convert.ToDateTime(actDate[1]);
            dtTrxDate.MinDate = Convert.ToDateTime(actDate[0]);
        }
    }
}