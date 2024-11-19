using AccountSystem.Inventory;
using Newtonsoft.Json;
using System;
using System.Windows.Forms;
namespace AccountSystem
{
    public partial class frmOutwardGatePass : Form
    {
        private MyModule Fn = new MyModule();
        string[] cData;
        public frmOutwardGatePass()
        {
            InitializeComponent();
            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }
        #region Default Instance
        private static frmOutwardGatePass defaultInstance;
        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static frmOutwardGatePass Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new frmOutwardGatePass();
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
            txtTrxNo.Text = Fn.GetRecords("SELECT COUNT(gID) +1 FROM tblGateOutward")[0];

        }


        private void grdBill_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
               
                if (grdBill.Rows[e.RowIndex].Cells["qty"].Value == null)
                {
                    grdBill.Rows[e.RowIndex].Cells["qty"].Value = 1;
                }

                grdBill.Rows[e.RowIndex].Cells["x"].Value = global::AccountSystem.Properties.Resources.close;
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMs.Text=="")
                {
                    MessageBox.Show("Please enter M/S.", "Invaild Values", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (grdBill.Rows.Count > 0)
                {
                    
                    btnSave.Enabled = false;
                    string items = "";
                    for (int i = 0; i < grdBill.Rows.Count; i++)
                    {
                        items = items + "," + "{\"Descrip\":" + JsonConvert.ToString(grdBill.Rows[i].Cells["Descr"].Value) + ",\"AU\":" + JsonConvert.ToString(grdBill.Rows[i].Cells["AU"].Value) + ",\"Qty\":\"" + grdBill.Rows[i].Cells["qty"].Value + "\",\"remarks\":\"" + grdBill.Rows[i].Cells["Remarks"].Value.ToString() + "\"}";
                    }
                    string Data2Post = "{\"gDate\":" + JsonConvert.ToString(dtTrxDate.Text) + ",\"balance\":" + (chkBalance.Checked ? 1 : 0) + ",\"Nretrunable\":" + (chkNonRetrunable.Checked ? 1 : 0) + ",\"rDate\":" + JsonConvert.ToString(dateTimePicker1.Text) + ",\"MS\":" + JsonConvert.ToString(txtMs.Text) + ",\"vehicleNo\":" + JsonConvert.ToString(txtVehicleNo.Text) + ",\"driver\":" + JsonConvert.ToString(txtNameofDriver.Text) + ",\"deliverby\":" + JsonConvert.ToString(txtDeliveredBy.Text) + ",\"gatekeeper\":" + JsonConvert.ToString(txtGateKeeper.Text) + ",\"created\":\"" + MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo + "\",\"items\":[" + items.Substring(1) + "]}";
                    string ID = Fn.GetRecords("sp_GateOutward '" + Data2Post + "'")[0];
                    btnPrint.Tag = ID;
                    if (ID == "a")
                    {

                        MessageBox.Show("There is some issue in data please check and try again", "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    btnSave.Enabled = false;
                    dtTrxDate.Enabled = false;
     
                    btnAddNew.Visible = true;
                    //btnPrint.Visible = true;
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
            chkBalance.Checked = false;
            chkNonRetrunable.Checked = false;
            txtMs.Text = "";
            txtVehicleNo.Text = "";
            txtNameofDriver.Text = "";
            txtDeliveredBy.Text = "";
            txtGateKeeper.Text = "";

            btnSave.Enabled = true;
            btnAddNew.Visible = false;
            btnPrint.Visible = false;
            txtTrxNo.Text = Fn.GetRecords("SELECT COUNT(gID) +1 FROM tblGateOutward")[0];
            grdBill.Rows.Clear();

            grdBill.ReadOnly = false;

            dtTrxDate.Enabled = true;
            grdBill.Height = 0;
            panel4.Visible = true;


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
            grdBill.Rows.Insert(0, txtDescription.Text, cboAU.Text, txtQty.Value, txtRemarks.Text);
            grdBill.Height = grdBill.Height + 22;
            txtDescription.Text = ""; cboAU.Text = ""; txtQty.Value = 0; txtRemarks.Text = "";
            //if (cboProducts.SelectedValue == null || (txtQty.Value + txtRate.Text) == "00")
            //{
            //    MessageBox.Show("Please select product name" + Environment.NewLine + "Please check the entries Qty and rate " + Environment.NewLine + "Can’t save blank values!", "Invaild Values", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}
            //Calc();

        }
        private void cbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtTrxNo.Text = Fn.GetRecords("SELECT isnull(MAX(convert(int,Sale_bill_no)),0) +1 FROM tblDelivery WHERE (BranchID = " + cbLocation.SelectedValue + ")")[0];
            //Fn.fillCombo(cboProducts, "sp_ProductList '" + cboStores.SelectedValue + "'");
        }
        private void cboProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (txtRate.Text == null || txtRate.Text == "0" || txtRate.Text == "")
            //{
           
            //string[] rates = Fn.GetRecords("sp_GetPurchaseRate '" + cboProducts.SelectedValue + "','"+ dtTrxDate.Text+ "','" + cboStores.SelectedValue + "'");
            //txtRate.Text = rates[0];
            //txtPRate.Text = rates[1];
            ////}
            //if (txtQty.Text == null || txtQty.Text == "0" || txtQty.Text == "")
            //{
            //    txtQty.Text = "1";
            //}
            //if (txtDAmt.Text == null || txtDAmt.Text == "")
            //{
            //    txtDAmt.Text = "0";
            //}
         
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
            //txtPurchOrderDT.MaxDate = Convert.ToDateTime(actDate[1]);
            //txtPurchOrderDT.MinDate = Convert.ToDateTime(actDate[0]);
        }

        private void cboStores_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Fn.fillCombo(cboProducts, "sp_ProductList '" + cboStores.SelectedValue + "'");
        }
    }
}