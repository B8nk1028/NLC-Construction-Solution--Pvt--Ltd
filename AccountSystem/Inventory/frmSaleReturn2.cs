using AccountSystem.Inventory;
using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Windows.Forms;
namespace AccountSystem
{
    public partial class frmSaleReturn2 : Form
    {
        private MyModule Fn = new MyModule();
        string ItemDiscount = "0", NetTotal = "0";
        public frmSaleReturn2()
        {
            InitializeComponent();
            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }
        #region Default Instance
        private static frmSaleReturn2 defaultInstance;
        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static frmSaleReturn2 Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new frmSaleReturn2();
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
            textBox1.Text = Fn.GetRecords("SELECT COUNT(Sale_id) +1 FROM tbl_Sale WHERE (BranchID = " + MyModule.BranchID + ") AND (InvoiceType = -1)")[0];
            Fn.fillCombo(cboVendor, "sp_VendorsList");
            Fn.fillCombo(cboSalesman, "SELECT EntryAccID, EntryAccName FROM TblAccEntry WHERE (AccType = 9)");
            Fn.fillCombo(cboBank, "SELECT EntryAccID, EntryAccName FROM TblAccEntry WHERE (AccType = 3)");
            Fn.fillCombo(cboPayTerms, "SELECT PaymentTermsID, PaymentTermsTxt FROM tblPaymentTerms");
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
                    txtTotal.Text = Convert.ToInt32(total).ToString();
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
                    items = items + "," + "{\"PRate\":" + JsonConvert.ToString(grdBill.Rows[i].Cells["gtxtPRate"].Value) + ",\"PackingDetail\":" + JsonConvert.ToString(grdBill.Rows[i].Cells["packingDetailDataGridViewTextBoxColumn"].Value.ToString()) + ",\"productid\":\"" + grdBill.Rows[i].Cells["gdv_prod_name"].Value.ToString() + "\",\"rate\":\"" + grdBill.Rows[i].Cells["prchse_prod_rate"].Value.ToString() + "\",\"qty\":\"" + grdBill.Rows[i].Cells["Prchse_prod_qty"].Value.ToString() + "\",\"disc\":\"" + grdBill.Rows[i].Cells["Discount"].Value.ToString() + "\"}";
                }
                string Data2Post = "{\"TotalAmount\":\"" + NetTotal + "\",\"ItemDiscount\":\"" + ItemDiscount + "\",\"Transport\":" + JsonConvert.ToString(txtTransport.Text) + ",\"TransactionNo\":" + JsonConvert.ToString(txtCheque.Text) + ",\"Salesman\":" + cboSalesman.SelectedValue + ",\"AccEntryID\":" + cboBank.SelectedValue + ",\"Remarks\":" + JsonConvert.ToString(txtRemarks.Text) + ",\"DeliveryChDate\":\"" + dtDeliveryChDate.Text + "\",\"DeliveryChNo\":\"" + txtDeliveryChNo.Text + "\",\"AmountPaid\":\"" + txtPaid.Text + "\",\"CarriageFreight\":\"" + txtCarriage.Text + "\",\"PaymentTermsID\":\"" + cboPayTerms.SelectedValue + "\",\"PurchaseOrderDate\":\"" + dtDeliveryChDate.Text + "\",\"Purch_OrderNo\":\"" + txtDeliveryChNo.Text + "\",\"Contact_id\":" + cboVendor.SelectedValue + ",\"Sale_date\":\"" + dtSaleDate.Text + "\",\"Created\":\"" + MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo + "\",\"CompID\":" + MyModule.CompID + ",\"items\":[" + items.Substring(1) + "]}";
                string ID = Fn.GetRecords("sp_CreateSaleRetrun '" + Data2Post + "'," + cbLocation.SelectedValue + "," + btnSave.Tag)[0];
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
            textBox1.Text = Fn.GetRecords("SELECT COUNT(Sale_id) +1 FROM tbl_Sale WHERE (BranchID = " + cbLocation.SelectedValue + ") AND (InvoiceType = -1)")[0];
            btnSave.Enabled = true;
            btnPrint.Enabled = false;
            int rw = grdBill.Rows.Count - 1;
            for (int i = 0; i < rw; i++)
            {
                grdBill.Rows.RemoveAt(0);
            }
            if (rw < 0)
            {
                grdBill.DataSource = null;
            }
            txtDeliveryChNo.ReadOnly = false;
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
            try
            {
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
        private void txtCarriage_TextChanged(object sender, EventArgs e)
        {
            try
            {
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
        private void txtPaid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32((txtPaid.Text == "" ? "0" : txtPaid.Text)) > 0)
                {
                    panel6.Show();
                    Fn.fillCombo(cboBank, "SELECT EntryAccID, EntryAccName FROM TblAccEntry WHERE (AccType = 3)");

                    tabControl1.SelectedTab = tabControl1.TabPages["tabPage1"];
                    txtPaid.Focus();
                }
                else
                {
                    panel6.Hide();

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
                if (grdBill.Rows.Count <= 1)
                {
                    this.saleRetrunDetailsTableAdapter.Fill(this.dataSet1.SaleRetrunDetails);


                }
                txtDeliveryChNo.ReadOnly = true;
                grdBill.ReadOnly = false;
                txtDeliveryChNo.Text = txtDeliveryChNo.Tag.ToString();
                btnSave.Tag = btnAddNew.Tag;
                cboVendor.Enabled = false;
                dtDeliveryChDate.Enabled = false;
            }
            catch
            {
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