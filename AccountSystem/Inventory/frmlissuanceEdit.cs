using AccountSystem.Inventory;
using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace AccountSystem
{
    public partial class frmlissuanceEdit : Form
    {
        private MyModule Fn = new MyModule();
        string[] cData;
        string ItemDiscount = "0", NetTotal = "0";
        public frmlissuanceEdit()
        {
            InitializeComponent();
            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }
        #region Default Instance
        private static frmlissuanceEdit defaultInstance;
        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static frmlissuanceEdit Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new frmlissuanceEdit();
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
            // TODO: This line of code loads data into the 'dataSet6.tblissuanceDetail' table. You can move, or remove it, as needed.
            this.tblissuanceDetailTableAdapter.Fill(this.dataSet6.tblissuanceDetail);
            // TODO: This line of code loads data into the 'dataSet6.tblissuance' table. You can move, or remove it, as needed.
            this.tblissuanceTableAdapter.Fill(this.dataSet6.tblissuance);



            Fn.fillCombo(cbLocation, "sp_OfficeLocations");
            cbLocation.SelectedValue = MyModule.BranchID;
            Fn.fillCombo(cboStores, "sp_Stores");

            cboStores.SelectedIndex = -1;
            Fn.fillGrdCombo(gtxtUsedfor, "sp_ConsumableUsedfor");
            Fn.fillGrdCombo(gtxtItem, "SELECT Prod_id, Prod_name FROM tbl_Product WHERE (NOT (Prod_Catg_id IN (1, 2)))");
            lblModify.Text = "" + MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo;
            txtIssueNo.Text = Fn.GetRecords("SELECT isnull(MAX(convert(int,Issue_id)),0) +1 FROM tblissuance WHERE (BranchID = " + cbLocation.SelectedValue + ")")[0];
            Fn.fillCombo(cboVendor, "SELECT EntryAccID, EntryAccName FROM TblAccEntry WHERE (AccType = 22) AND (Stat = 1)");
           

        }
        private void cbo_vendor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cData = Fn.GetRecords("SELECT TblAccEntry.BAddress + '<br><b>Contact No. ' + TblAccEntry.BContactNo AS Addressline, TblAccEntry.BTransport, TblAccEntry.CrLimit, (SELECT ISNULL(SUM(AmountDeb - AmountCre), 0) AS Expr1 FROM VW_VoucherDTL WHERE (AccEntryID = 5601)) AS Balance, tblLocations.CityNmae + ', ' + tblLocations.Region + ', ' + tblLocations.Province AS Loc, TblAccEntry.PaymentTermsID FROM TblAccEntry LEFT OUTER JOIN tblLocations ON TblAccEntry.BCity = tblLocations.CityID WHERE (TblAccEntry.EntryAccID =" + cboVendor.SelectedValue + ") ");
                txtAddress.Text = cData[0];


            }
            catch 
            {

            }

        }
        private void grdBill_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                
                if (grdBill.Rows[e.RowIndex].Cells["gtxtqty"].Value == null || grdBill.Rows[e.RowIndex].Cells["gtxtqty"].Value == DBNull.Value)
                {
                    grdBill.Rows[e.RowIndex].Cells["gtxtqty"].Value = 1;
                }
               
                grdBill.Rows[e.RowIndex].Cells["x"].Value = global::AccountSystem.Properties.Resources.close;
            }
        }
        private void grdBill_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            double qty = 0;
            if (e.RowIndex >= 0 || e.RowIndex < grdBill.Rows.Count)
            {
                if (grdBill.Rows[e.RowIndex].Cells["gtxtqty"].Value != null && (grdBill.Rows[e.RowIndex].Cells["gtxtqty"].Value != null || grdBill.Rows[e.RowIndex].Cells["gtxtqty"].Value == DBNull.Value))
                {
                    try
                    {
                        if (grdBill.Rows[e.RowIndex].Cells["gtxtqty"].Value == null || grdBill.Rows[e.RowIndex].Cells["gtxtqty"].Value == DBNull.Value)
                        {
                            grdBill.Rows[e.RowIndex].Cells["gtxtqty"].Value = 1;
                        }
                        else
                        {
                            qty = Double.Parse(grdBill.Rows[e.RowIndex].Cells["gtxtqty"].Value.ToString());
                        }
                       

                    }
                    catch (Exception)
                    {

                    }

                }
            }

        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (cboVendor.SelectedValue == null)
            {
                MessageBox.Show("Please select vaild customer, salesman and bank details.", "Invaild Values", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
           
            if (grdBill.Rows.Count > 0)
            {
               
                btnSave.Enabled = false;
                string items = "";
               
         

                    for (int i = 0; i < grdBill.Rows.Count; i++)
                {
                    
                    items = items + "," + "{\"prod_id\":\"" + grdBill.Rows[i].Cells["gtxtItem"].Tag.ToString() + "\",\"prod_qty\":\"" + grdBill.Rows[i].Cells["gtxtQty"].Value.ToString() + "\",\"P_Remarks\":\"" + grdBill.Rows[i].Cells["gtxtUsedfor"].Tag.ToString() + "\",\"PackingDetail\":\"" + grdBill.Rows[i].Cells["gtxtRemarks"].Value.ToString() + "\"}";
                }
                string Data2Post = "{\"DeptID\":\"" + cboVendor.SelectedValue + "\",\"DemandNo\":\"" + txtDemandNo.Text + "\",\"StoreID\":\"" + cboStores.SelectedValue + "\",\"IssueDT\":" + JsonConvert.ToString(dtIssuDate.Text) + ",\"Created\":\"" + MyModule.UserName + "|" + DateTime.Now.ToString("dd-MMM-yyyy HH:mm") + "|" + MyModule.PCInfo + "\",\"CompID\":" + MyModule.CompID + ",\"items\":[" + items.Substring(1) + "]}";
                string ID = Fn.GetRecords("sp_CreateIssuance '" + Data2Post + "'," + cbLocation.SelectedValue)[0];
                btnPrint.Tag = ID;
                if (ID == "a")
                {
                    btnSave.Enabled = true;
                    MessageBox.Show("There is some issue in data please check and try again", "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
             
                cboVendor.Enabled = false;
            
                btnPrint.Enabled = true;
                btnAddNew.Enabled = true;
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
            txtIssueNo.Text = Fn.GetRecords("SELECT isnull(MAX(convert(int,Issue_id)),0) +1 FROM tblissuance WHERE (BranchID = " + cbLocation.SelectedValue + ")")[0];
            btnSave.Enabled = true;
            btnAddNew.Enabled = false;
            btnPrint.Enabled = false;
            int rw = grdBill.Rows.Count;
            for (int i = 0; i < rw; i++)
            {
                grdBill.Rows.RemoveAt(0);
            }
           
            if (btnSave.Tag.ToString() != "0")
            {
                btnAddNew.Tag = btnSave.Tag;
            }
            btnSave.Tag = "0";
          
            grdBill.ReadOnly = false;
            cboVendor.Enabled = true;
          
            grdBill.Height = 0;

            cboVendor.SelectedIndex = -1;
          

        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            rptSaleInvoice PO = new rptSaleInvoice();
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
            if (e.ColumnIndex == 5)
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
                                //grdBill.Height = grdBill.Height - 23;
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
           
        }
        private void txtCarriage_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void txtPaid_TextChanged(object sender, EventArgs e)
        {
           
           
        }
        private void cbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIssueNo.Text = Fn.GetRecords("SELECT isnull(MAX(convert(int,Issue_id)),0) +1 FROM tblissuance WHERE (BranchID = " + cbLocation.SelectedValue + ")")[0];

        }
        private void btnAddRow_Click(object sender, EventArgs e)
        {
            if (cboStores.SelectedIndex == -1)
            {
                MessageBox.Show("Please select store location for stock", "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
           
            grdBill.Height = grdBill.Height + 22;
            Calc();
          
        }
        private void cboProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
 
            Calc();
        }
        private void Calc()
        {
            double qty = 0;
            double total = 0;
   

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

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void txtPurchOrderDT_Enter(object sender, EventArgs e)
        {

        }

        private void dtDeliveryChDate_Enter(object sender, EventArgs e)
        {

        }

        private void dtSaleDate_Enter(object sender, EventArgs e)
        {

        }

        private void dtShip_Enter(object sender, EventArgs e)
        {

        }

        private void cboStores_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tblissuanceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblissuanceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet6);

        }

        private void txtDAmt_ValueChanged(object sender, EventArgs e)
        {
            Calc();
        }
    }
}