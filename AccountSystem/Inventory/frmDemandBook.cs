using AccountSystem.Inventory;
using Newtonsoft.Json;
using System;
using System.Windows.Forms;
namespace AccountSystem
{
    public partial class frmDemandBook : Form
    {
        private MyModule Fn = new MyModule();
        string[] cData;
        public frmDemandBook()
        {
            InitializeComponent();
            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }
        #region Default Instance
        private static frmDemandBook defaultInstance;
        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static frmDemandBook Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new frmDemandBook();
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
            txtTrxNo.Text = Fn.GetRecords("SELECT COUNT(DemandID) + 1 FROM tblDemands WHERE (format(dDate, 'MMMyyyy') = '"+ dtTrxDate.Value.ToString("MMMyyy")+ "')")[0];
            Fn.fillCombo(cbofrmDept, "SELECT EntryAccID, EntryAccName FROM TblAccEntry WHERE (Stat = 1) AND (AccType=22)");
        }
        bool chk = false;

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
                //if (cboVendor.SelectedValue == null || cboSalesman.SelectedValue == null)
                //{
                //    MessageBox.Show("Please select vaild customer and salesman.", "Invaild Values", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    return;
                //}
                if (grdBill.Rows.Count > 0)
                {

                  
                    string items = "";
                    for (int i = 0; i < grdBill.Rows.Count; i++)
                    {
                        items = items + "," + "{\"PordID\":" + JsonConvert.ToString(grdBill.Rows[i].Cells["gdv_prod_name"].Value) + ",\"PordID\":" + JsonConvert.ToString(grdBill.Rows[i].Cells["gdv_prod_name"].Value) + ",\"Descr\":" + JsonConvert.ToString(grdBill.Rows[i].Cells["Descr"].Value) + ",\"UnitID\":\"" + grdBill.Rows[i].Cells["AU"].Value.ToString() + "\",\"Qty\":\"" + grdBill.Rows[i].Cells["qty"].Value.ToString() + "\",\"Remarks\":\"" + grdBill.Rows[i].Cells["rmks"].Value.ToString() + "\"}";
                    }
                    string Data2Post = "{\"EstAmt\":" + JsonConvert.ToString(txtEstAmt.Value) + ",\"FrmDepotID\":" + JsonConvert.ToString(cbofrmDept.SelectedValue) + ",\"ToDepotID\":" + JsonConvert.ToString(cbToDept.SelectedValue) + ",\"dDate\":" + JsonConvert.ToString(dtTrxDate.Text) + ",\"DepartID\":" + JsonConvert.ToString(txtToDeport.Text) + ",\"frmDepot\":" + JsonConvert.ToString(txtfrmDepot.Text) + ",\"Created\":\"" + MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo + "\",\"CompID\":" + MyModule.CompID + ",\"items\":[" + items.Substring(1) + "]}";
                    string ID = Fn.GetRecords("sp_CreateDemandBook '" + Data2Post + "','" + dtTrxDate.Value.ToString("MMMyyy") + "'")[0];
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
            btnSave.Enabled = true;
            btnAddNew.Visible = false;
            btnPrint.Visible = false;
            txtToDeport.Clear();
            txtfrmDepot.Clear();
            grdBill.Rows.Clear();
            txtEstAmt.Value = 0;
            txtTrxNo.Text = Fn.GetRecords("SELECT isnull(MAX(convert(int,DemandNo)),0) +1 FROM tblDemands")[0];
            grdBill.ReadOnly = false;
   
            dtTrxDate.Enabled = true;
            grdBill.Height = 0;
            panel4.Visible = true;

            cboProducts.Focus();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            //rptDeliveryChallan PO = new rptDeliveryChallan();
            //PO.Tag = btnPrint.Tag;
            //PO.ShowDialog();
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


            //if (cboProducts.SelectedValue == null || (txtQty.Value + txtRate.Text) == "00")
            //{
            //    MessageBox.Show("Please select product name" + Environment.NewLine + "Please check the entries Qty and rate " + Environment.NewLine + "Can’t save blank values!", "Invaild Values", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}

            grdBill.Rows.Add();
            grdBill.Rows[grdBill.RowCount - 1].Cells["gdv_prod_name"].Value = cboProducts.Text;


            grdBill.Rows[grdBill.RowCount - 1].Cells["Descr"].Value = txtDescr.Text;
            grdBill.Rows[grdBill.RowCount - 1].Cells["qty"].Value = txtQty.Text;
            grdBill.Rows[grdBill.RowCount - 1].Cells["AU"].Value = txtAU.Text;
            grdBill.Rows[grdBill.RowCount - 1].Cells["rmks"].Value = txtRmks.Text;

            grdBill.Height = grdBill.Height + 22;
          txtDescr.Text="";
           txtQty.Text = "";
            txtAU.Text = "";
           txtRmks.Text = ""; cboProducts.Text = "";
        }

        private void cbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cboVendor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Fn.fillCombo(cbToDept, "SELECT convert(varchar,EntryAccID), EntryAccName FROM TblAccEntry WHERE (AccType IN (21, 22,23)) AND (Stat = 1) AND EntryAccID<>" + cbofrmDept.SelectedValue);
        }
    }
}