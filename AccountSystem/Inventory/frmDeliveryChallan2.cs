using AccountSystem.Inventory;
using Newtonsoft.Json;
using System;
using System.Windows.Forms;
namespace AccountSystem
{
    public partial class frmDeliveryChallan2 : Form
    {
        private MyModule Fn = new MyModule();
        string[] cData;
        public frmDeliveryChallan2()
        {
            InitializeComponent();
            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }
        #region Default Instance
        private static frmDeliveryChallan2 defaultInstance;
        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static frmDeliveryChallan2 Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new frmDeliveryChallan2();
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
            cboStores.SelectedIndex = -1;
            lblSCreated.Text = "" + MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo;
            txtTrxNo.Text = Fn.GetRecords("SELECT isnull(MAX(convert(int,Sale_bill_no)),0) +1 FROM tblDelivery WHERE (BranchID = " + cbLocation.SelectedValue + ")")[0];
            Fn.fillCombo(cboVendor, "sp_VendorsList");
            Fn.fillCombo(cboSalesman, "SELECT EntryAccID, EntryAccName FROM TblAccEntry WHERE (AccType = 9)");
            cboSalesman.SelectedIndex = -1;
            Fn.fillCombo(cboPayTerms, "SELECT PaymentTermsID, PaymentTermsTxt FROM tblPaymentTerms");
            Fn.fillCombo(cboProducts, "sp_ProductList '" + cboStores.SelectedValue + "'");
            cboProducts.Text = ""; cboProducts.SelectedIndex = -1; txtUM.Text = ""; txtPRate.Text = ""; txtQty.Text = ""; txtDescrip.Text = "";
            cboProducts.Focus();
        }
        bool chk = false;
        private void cbo_vendor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cData = Fn.GetRecords("SELECT TblAccEntry.BAddress + '<br><b>Contact No. ' + TblAccEntry.BContactNo AS Addressline, TblAccEntry.BTransport, ISNULL(TblAccEntry.CrLimit, 0) AS CrLimit, (SELECT ISNULL(SUM(AmountDeb - AmountCre), 0) AS Expr1 FROM VW_VoucherDTL WHERE (AccEntryID = " + cboVendor.SelectedValue + ")) AS Balance, tblLocations.CityNmae + ', ' + tblLocations.Region + ', ' + tblLocations.Province AS Loc, TblAccEntry.PaymentTermsID FROM TblAccEntry LEFT OUTER JOIN tblLocations ON TblAccEntry.BCity = tblLocations.CityID WHERE (TblAccEntry.EntryAccID = " + cboVendor.SelectedValue + ")");
                txtAddress.Text = cData[0];
                txtTransport.Text = cData[1];
                cboCity.Text = cData[4];
                cboPayTerms.SelectedValue= cData[5];
                if (Convert.ToInt32(cData[2]) <= Convert.ToInt32(cData[3]) && chk)
                {
                    MessageBox.Show("Credit Limit is increasing" + Environment.NewLine + "Credit Limit: " + cData[2] + Environment.NewLine + "Current Balance: " + cData[3], "Credit Limit is increasing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            catch
            {

            }
            chk = true;

        }
        private void grdBill_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                
                if (grdBill.Rows[e.RowIndex].Cells["gtxtQty"].Value == null)
                {
                    grdBill.Rows[e.RowIndex].Cells["gtxtQty"].Value = 1;
                }
                grdBill.Rows[e.RowIndex].Cells["x"].Value = global::AccountSystem.Properties.Resources.close;
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboVendor.SelectedValue == null || cboSalesman.SelectedValue == null)
                {
                    MessageBox.Show("Please select vaild customer and salesman.", "Invaild Values", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (grdBill.Rows.Count > 0)
                {
                    string items = "";
                    for (int i = 0; i < grdBill.Rows.Count; i++)
                    {
                        items = items + "," + "{\"PRate\":" + JsonConvert.ToString(grdBill.Rows[i].Cells["gtxtPRate"].Value) + ",\"PackingDetail\":" + JsonConvert.ToString(grdBill.Rows[i].Cells["txtPackingDetail"].Value) + ",\"productid\":\"" + grdBill.Rows[i].Cells["gtxtItemName"].Tag.ToString() + "\",\"um\":\"" + grdBill.Rows[i].Cells["gtxtUM"].Value.ToString() + "\",\"qty\":\"" + grdBill.Rows[i].Cells["gtxtQty"].Value.ToString() + "\"}";
                    }
                    string Data2Post = "{\"PayTerm\":\"" + (cboPayTerms.SelectedValue==null?0: cboPayTerms.SelectedValue) + "\",\"StoreID\":\"" + cboStores.SelectedValue + "\",\"BilltyDT\":" + JsonConvert.ToString(dtShip.Text) + ",\"BilltyNo\":" + JsonConvert.ToString(txtBilti.Text) + ",\"ToShip\":" + JsonConvert.ToString(cboCity.Text) + ",\"PurchaseOrder\":" + JsonConvert.ToString(txtPurchaseOrder.Text) + ",\"PurchOrderDT\":" + JsonConvert.ToString(txtPurchOrderDT.Text) + ",\"Remarks\":" + JsonConvert.ToString(txtRemarks.Text) + ",\"Transport\":" + JsonConvert.ToString(txtTransport.Text) + ",\"Salesman\":" + cboSalesman.SelectedValue + ",\"VendorID\":" + cboVendor.SelectedValue + ",\"TrxDate\":\"" + dtTrxDate.Text + "\",\"Created\":\"" + MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo + "\",\"CompID\":" + MyModule.CompID + ",\"items\":[" + items.Substring(1) + "]}";
                    string ID = Fn.GetRecords("sp_DeliveryChallan '" + Data2Post + "'," + cbLocation.SelectedValue)[0];
                    btnPrint.Tag = ID;
                    if (ID == "a")
                    {
                        
                        MessageBox.Show("There is some issue in data please check and try again", "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    btnSave.Enabled = false;
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
            catch (Exception ex)
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
            cboStores.Enabled = true;
            cboStores.SelectedIndex = -1;
            grdBill.Rows.Clear();
            txtTrxNo.Text = Fn.GetRecords("SELECT isnull(MAX(convert(int,Sale_bill_no)),0) +1 FROM tblDelivery WHERE (BranchID = " + cbLocation.SelectedValue + ")")[0];
            grdBill.ReadOnly = false;
            cboVendor.Enabled = true;
            dtTrxDate.Enabled = true;
            grdBill.Height = 0;
            panel4.Visible = true; cboVendor.SelectedIndex = -1;
            cboSalesman.SelectedIndex = -1;
            cboProducts.Text = ""; cboProducts.SelectedIndex = -1; txtUM.Text = ""; txtPRate.Text = ""; txtQty.Text = ""; txtDescrip.Text = "";
            cboProducts.Focus();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            rptDeliveryChallan PO = new rptDeliveryChallan();
            PO.Tag = btnPrint.Tag;
            PO.ShowDialog();
        }
        private void grdBill_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 5)
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
            if (btnSave.Enabled)
            {
                if (e.ColumnIndex == 5)
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
                                if (grdBill.Rows.Count==0)
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
        private void btnAddRow_Click(object sender, EventArgs e)
        {
            if (cboStores.SelectedIndex == -1)
            {
                MessageBox.Show("Please select store location for stock", "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            cboStores.Enabled = false;
            if (cboProducts.SelectedValue == null || txtQty.Value == 0)
            {
                MessageBox.Show("Please select product name" + Environment.NewLine + "Please check the entries Qty and rate " + Environment.NewLine + "Can’t save blank values!", "Invaild Values", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //Calc();
            if (cboProducts.Text.Split('|')[1] == "0" || cboProducts.Text.Split('|')[1] == "")
            {
                MessageBox.Show("Stock is not available for select product " + Environment.NewLine + "or stock is less for selected quantity", "Out Of Stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            grdBill.Rows.Add();
            grdBill.Rows[grdBill.RowCount - 1].Cells[0].Value = cboProducts.Text.Split('|')[0];
            grdBill.Rows[grdBill.RowCount - 1].Cells[0].Tag = cboProducts.SelectedValue;
            grdBill.Rows[grdBill.RowCount - 1].Cells["gtxtUM"].Value = cboProducts.Text.Split(' ')[1];
            grdBill.Rows[grdBill.RowCount - 1].Cells["gtxtPRate"].Value = txtPRate.Text;
            grdBill.Rows[grdBill.RowCount - 1].Cells["gtxtQty"].Value = txtQty.Text;
            grdBill.Rows[grdBill.RowCount - 1].Cells["txtPackingDetail"].Value = txtDescrip.Text;
            grdBill.Height = grdBill.Height + 22;
            cboProducts.Text = ""; cboProducts.SelectedIndex = -1; txtUM.Text = ""; txtPRate.Text = ""; txtQty.Text = ""; txtDescrip.Text = "";
            cboProducts.Focus();
        }
        private void cbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTrxNo.Text = Fn.GetRecords("SELECT isnull(MAX(convert(int,Sale_bill_no)),0) +1 FROM tblDelivery WHERE (BranchID = " + cbLocation.SelectedValue + ")")[0];
            Fn.fillCombo(cboProducts, "sp_ProductList '" + cboStores.SelectedValue + "'");
        }
        private void cboProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProducts.Text!="")
            {
            txtUM.Text = cboProducts.Text.Split(' ')[1];
            }


            string[] rates = Fn.GetRecords("sp_GetPurchaseRate '" + cboProducts.SelectedValue + "','"+ dtTrxDate.Text+ "','" + cboStores.SelectedValue + "'");
            txtPRate.Text = rates[1];
            if (txtQty.Text == null || txtQty.Text == "0" || txtQty.Text == "")
            {
                txtQty.Text = "1";
            }
        }
  
        

        private void dtTrxDate_Enter(object sender, EventArgs e)
        {
            string[] actDate = Fn.GetRecords("sp_ActiveDates");
            dtTrxDate.MaxDate = Convert.ToDateTime(actDate[1]);
            dtTrxDate.MinDate = Convert.ToDateTime(actDate[0]);
        }

        private void txtPurchOrderDT_Enter(object sender, EventArgs e)
        {
            string[] actDate = Fn.GetRecords("sp_ActiveDates");
            txtPurchOrderDT.MaxDate = Convert.ToDateTime(actDate[1]);
            txtPurchOrderDT.MinDate = Convert.ToDateTime(actDate[0]);
        }

        private void cboStores_SelectedIndexChanged(object sender, EventArgs e)
        {
            Fn.fillCombo(cboProducts, "sp_ProductList '" + cboStores.SelectedValue + "'");
        }
    }
}