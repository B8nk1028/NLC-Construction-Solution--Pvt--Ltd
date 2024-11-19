using AccountSystem.Inventory;
using Newtonsoft.Json;
using System;
using System.Windows.Forms;
namespace AccountSystem
{
    public partial class frmPurchaseReturn : Form
    {
        private MyModule Fn = new MyModule();
        string ItemDiscount = "0", NetTotal = "0";
        public frmPurchaseReturn()
        {
            InitializeComponent();
            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }
        #region Default Instance
        private static frmPurchaseReturn defaultInstance;
        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static frmPurchaseReturn Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new frmPurchaseReturn();
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
            this.purchaseRTNDetailTableAdapter.Fill(this.dataSet1.PurchaseRTNDetail);
            txtPNo.Text = Fn.GetRecords("SELECT isnull(MAX(convert(int,Purch_bill_no)),0)+1 FROM tbl_Purchase WHERE (BranchID = " + cbLocation.SelectedValue + ") AND (InvoiceType = -1)")[0];
            Fn.fillCombo(cboVendor, "sp_VendorsList");
            Fn.fillCombo(cboBank, "SELECT EntryAccID, EntryAccName FROM TblAccEntry WHERE (AccType = 3)");
            Fn.fillGrdCombo(gdv_prod_name, "SELECT tbl_Product.Prod_id, tbl_Product.Prod_name FROM tbl_Product INNER JOIN tbl_Brand ON tbl_Product.Brand_id = tbl_Brand.Brand_id INNER JOIN tbl_Prod_category ON tbl_Product.Prod_Catg_id = tbl_Prod_category.Prod_ctg_id WHERE (tbl_Product.Disle <> 1 OR tbl_Product.Disle IS NULL) AND (tbl_Product.pType = 1) and (Prod_Catg_id <> 2)");

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
            double qty = 0, price = 0, amount = 0, Disc = 0, gAmount = 0, Discount = 0;
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
            for (int i = 0; i < grdBill.Rows.Count - 1; i++)
            {
                if (grdBill.Rows[i].Cells["Prchse_Prod_Amount"].Value != null)
                {
                    total = total + Convert.ToDouble(grdBill.Rows[i].Cells["Prchse_Prod_Amount"].Value);
                    Disc = Disc + Convert.ToDouble(grdBill.Rows[i].Cells["Discount"].Value);
                    ItemDiscount = Disc.ToString();
                    txtTotal.Text = Convert.ToDouble(total).ToString("#,#.00");
                    NetTotal = (total + Disc).ToString();
                }
            }
        }
        private void btnsave_Click(object sender, EventArgs e)
        {

            if (grdBill.Rows.Count > 1)
            {
                btnSave.Enabled = false;
        
                string items = "";
                for (int i = 0; i < grdBill.Rows.Count - 1; i++)
                {
                    items = items + "," + "{\"productid\":\"" + grdBill.Rows[i].Cells["gdv_prod_name"].Value.ToString() + "\",\"rate\":\"" + grdBill.Rows[i].Cells["prchse_prod_rate"].Value.ToString() + "\",\"qty\":\"" + grdBill.Rows[i].Cells["Prchse_prod_qty"].Value.ToString() + "\",\"disc\":\"" + grdBill.Rows[i].Cells["Discount"].Value.ToString() + "\"}";
                }
                string Data2Post = "{\"StoreID\":\"" + cboStores.SelectedValue + "\",\"TotalAmount\":\"" + NetTotal + "\",\"ItemDiscount\":\"" + ItemDiscount + "\",\"Transport\":" + JsonConvert.ToString(txtTransport.Text) + ",\"AccEntryID\":" + cboBank.SelectedValue + ",\"Remarks\":\"" + txtCheque.Text + "\",\"VendorInvoiceDate\":\"" + dtVinvDT.Text + "\",\"VendorInvoice\":\"" + txtVInvoice.Text + "\",\"AmountPaid\":\"" + txtPaid.Text + "\",\"CarriageFreight\":\"" + txtCarriage.Text + "\",\"AdditionalDiscount\":\"" + txtAddDisc.Text + "\",\"PurchaseOrderDate\":\"" + dtTrxDate.Text + "\",\"Purch_OrderNo\":\"" + txtTrxNo.Text + "\",\"VendorID\":" + cboVendor.SelectedValue + ",\"TrxDate\":\"" + dtPurchDT.Text + "\",\"Created\":\"" + MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo + "\",\"CompID\":" + MyModule.CompID + ",\"items\":[" + items.Substring(1) + "]}";
                string ID = Fn.GetRecords("sp_CreateGRNRetrun '" + Data2Post + "'," + cbLocation.SelectedValue + "," + btnSave.Tag)[0];
                btnPrint.Tag = ID;
                if (ID == "a")
                {
                    btnSave.Enabled = true;
                    MessageBox.Show("There is some issue in data please check and try again", "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                dtTrxDate.Enabled = false;
                panel5.Enabled = false;
                panel3.Enabled = false;
                panel4.Enabled = false;
                panel6.Enabled = false;

                dtTrxDate.Enabled = false;
                cboVendor.Enabled = false;
                btnAddNew.Visible = true;
                btnAddNew.Enabled = true;
                btnPrint.Enabled = true;
                grdBill.ReadOnly = true;
                listBox1.Enabled = false;

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
            listBox1.ClearSelected();
            btnAddNew.Enabled = false;
            txtPNo.Text = Fn.GetRecords("SELECT isnull(MAX(convert(int,Purch_bill_no)),0)+1 FROM tbl_Purchase WHERE (BranchID = " + cbLocation.SelectedValue + ") AND (InvoiceType = -1)")[0];
            btnSave.Enabled = true;
            //btnAddNew.Visible = false;
            btnPrint.Enabled = false;
            int rw = grdBill.Rows.Count - 1;
            for (int i = 0; i < rw; i++)
            {
                grdBill.Rows.RemoveAt(0);
            }
            cboVendor.Enabled = true;
            if (rw < 0)
            {
                grdBill.DataSource = null;
                //grdBill.Rows.Add(1);
            }
            txtTrxNo.ReadOnly = false;
            if (txtTrxNo.Text != "")
            {
                txtTrxNo.Tag = txtTrxNo.Text;
            }
            btnSave.Tag = "0";
            if (btnSave.Tag.ToString() != "0")
            {
                btnAddNew.Tag = btnSave.Tag;
            }

            txtTrxNo.Text = "";
            grdBill.ReadOnly = false;
            cboVendor.Enabled = true;

            if (!listBox1.Enabled)
            {
                listBox1.Enabled = true;
                try
                {
                    purchaseRTNHeadBindingSource.RemoveAt(listBox1.SelectedIndex);
                }
                catch
                {

                }


            }

            //panel1.Enabled = true;
            panel5.Enabled = true;
            panel3.Enabled = true;
            panel4.Enabled = true;
            panel6.Enabled = true;
            dtTrxDate.Enabled = true;
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            rptGRNReturn GRN = new rptGRNReturn();
            GRN.Tag = btnPrint.Tag;
            GRN.ShowDialog();
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
                            }
                            catch { }
                        }
                    }
                }
            }
        }
        private void pOHeadBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.purchaseRTNHeadBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);
        }
        private void txtAddDisc_TextChanged(object sender, EventArgs e)
        {
            txtAddDisc.Text = Fn.ValidateNumber(txtAddDisc);
            txtGTotal.Text = (Convert.ToDouble((txtTotal.Text == "" ? "0" : txtTotal.Text)) + Convert.ToDouble((txtAddDisc.Text == "" ? "0" : txtAddDisc.Text))).ToString("#,#.00");
            textNetTotal.Text = (Convert.ToDouble((txtGTotal.Text == "" ? "0" : txtGTotal.Text)) + Convert.ToDouble((txtCarriage.Text == "" ? "0" : txtCarriage.Text))).ToString("#,#.00");
            txtBalance.Text = (Convert.ToDouble((textNetTotal.Text == "" ? "0" : textNetTotal.Text)) - Convert.ToDouble((txtPaid.Text == "" ? "0" : txtPaid.Text))).ToString("#,#.00");
        }
        private void txtCarriage_TextChanged(object sender, EventArgs e)
        {
            txtCarriage.Text = Fn.ValidateNumber(txtCarriage);
            txtGTotal.Text = (Convert.ToDouble((txtTotal.Text == "" ? "0" : txtTotal.Text)) + Convert.ToDouble((txtAddDisc.Text == "" ? "0" : txtAddDisc.Text))).ToString("#,#.00");
            textNetTotal.Text = (Convert.ToDouble((txtGTotal.Text == "" ? "0" : txtGTotal.Text)) + Convert.ToDouble((txtCarriage.Text == "" ? "0" : txtCarriage.Text))).ToString("#,#.00");
            txtBalance.Text = (Convert.ToDouble((textNetTotal.Text == "" ? "0" : textNetTotal.Text)) - Convert.ToDouble((txtPaid.Text == "" ? "0" : txtPaid.Text))).ToString("#,#.00");
        }
        private void txtPaid_TextChanged(object sender, EventArgs e)
        {
            txtPaid.Text = Fn.ValidateNumber(txtPaid);
            if (Convert.ToDouble((txtPaid.Text == "" ? "0" : txtPaid.Text)) > 0)
            {
                panel6.Show();
                Fn.fillCombo(cboBank, "SELECT EntryAccID, EntryAccName FROM TblAccEntry WHERE (AccType = 3)");
                cboBank.SelectedIndex = -1;
                tabControl1.SelectedTab = tabControl1.TabPages["tabPage1"];
                txtPaid.Focus();
            }
            else
            {
                panel6.Hide(); cboBank.SelectedIndex = 0;

            }
            txtGTotal.Text = (Convert.ToDouble((txtTotal.Text == "" ? "0" : txtTotal.Text)) + Convert.ToDouble((txtAddDisc.Text == "" ? "0" : txtAddDisc.Text))).ToString("#,#.00");
            textNetTotal.Text = (Convert.ToDouble((txtGTotal.Text == "" ? "0" : txtGTotal.Text)) + Convert.ToDouble((txtCarriage.Text == "" ? "0" : txtCarriage.Text))).ToString("#,#.00");
            txtBalance.Text = (Convert.ToDouble((textNetTotal.Text == "" ? "0" : textNetTotal.Text)) - Convert.ToDouble((txtPaid.Text == "" ? "0" : txtPaid.Text))).ToString("#,#.00");
        }
        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            txtGTotal.Text = (Convert.ToDouble((txtTotal.Text == "" ? "0" : txtTotal.Text)) +Convert.ToDouble((txtAddDisc.Text == "" ? "0" : txtAddDisc.Text))).ToString("#,#.00");
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
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (grdBill.Rows.Count <= 1)
                {

                    this.purchaseRTNDetailTableAdapter.Fill(this.dataSet1.PurchaseRTNDetail);


                }
                txtTrxNo.ReadOnly = true;
                grdBill.ReadOnly = false;
                txtTrxNo.Text = txtTrxNo.Tag.ToString();
                //btnSave.Tag = btnAddNew.Tag;
                cboVendor.Enabled = false;
                dtTrxDate.Enabled = false;
            }
            catch
            {
            }
        }

        private void cbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPNo.Text = Fn.GetRecords("SELECT isnull(MAX(convert(int,Purch_bill_no)),0)+1 FROM tbl_Purchase WHERE (BranchID = " + cbLocation.SelectedValue + ") AND (InvoiceType = -1)")[0];
        }

        private void dtVinvDT_Enter(object sender, EventArgs e)
        {
            string[] actDate = Fn.GetRecords("sp_ActiveDates");
            dtVinvDT.MaxDate = Convert.ToDateTime(actDate[1]);
            dtVinvDT.MinDate = Convert.ToDateTime(actDate[0]);
        }

        private void dtTrxDate_Enter(object sender, EventArgs e)
        {
            string[] actDate = Fn.GetRecords("sp_ActiveDates");
            dtTrxDate.MaxDate = Convert.ToDateTime(actDate[1]);
            dtTrxDate.MinDate = Convert.ToDateTime(actDate[0]);
        }

        private void dtPurchDT_Enter(object sender, EventArgs e)
        {
            string[] actDate = Fn.GetRecords("sp_ActiveDates");
            dtPurchDT.MaxDate = Convert.ToDateTime(actDate[1]);
            dtPurchDT.MinDate = Convert.ToDateTime(actDate[0]);
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.purchaseRTNHeadTableAdapter.Fill(this.dataSet1.PurchaseRTNHead, "%" + searchToolStripTextBox.Text + "%");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}