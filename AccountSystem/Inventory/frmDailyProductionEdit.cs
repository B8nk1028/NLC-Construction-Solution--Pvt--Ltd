using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Value;
namespace AccountSystem
{
    public partial class frmDailyProductionEdit : Form
    {
        private MyModule Fn = new MyModule();
        public object[] ProductInfo;
        public frmDailyProductionEdit()
        {
            InitializeComponent();
            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }
        #region Default Instance
        private static frmDailyProductionEdit defaultInstance;
        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static frmDailyProductionEdit Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new frmDailyProductionEdit();
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
        private string[] ActiveRates = { "a", "b", "c", "d", "e", "f", "g", "h" };
        private void frmproduct_Load(object sender, EventArgs e)
        {
            Fn.fillCombo(ddShiftStaff, "SELECT EntryAccID,EntryAccName FROM TblAccEntry WHERE (AccType = 20) AND (EntryAccName LIKE N'%Plt%(E)')");
            Fn.fillCombo(cboProducts, "SELECT tbl_Product.Prod_id, tbl_Product.Prod_name pname FROM tbl_Product INNER JOIN tbl_Unit ON tbl_Product.Unit_id = tbl_Unit.Unit_id WHERE (tbl_Product.Brand_id IN (1,2,18,19,2018)) order by Prod_name");
            ActiveRates = Fn.GetRecords("sp_ActiveRates");
            SearchRecord();
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        string pdata;
        private void cboProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProducts.SelectedValue!=null)
            {
                pdata = Fn.GetRecords("SELECT convert(varchar,tbl_Product.Prod_id)+'|'+convert(varchar,isnull(PalletsSize,0))+'|'+(SELECT convert(varchar,isnull(SUM(qty),0)) AS sand FROM tbl_ProductRecipe WHERE (rProd_id = 27) AND (Prod_id = tbl_Product.Prod_id))+'|'+(SELECT convert(varchar,isnull(SUM(qty),0)) AS pan FROM tbl_ProductRecipe WHERE (rProd_id = 29) AND (Prod_id = tbl_Product.Prod_id))+'|'+(SELECT convert(varchar,isnull(SUM(qty),0)) AS pan FROM tbl_ProductRecipe WHERE (rProd_id = 44) AND (Prod_id = tbl_Product.Prod_id))+'|'+(SELECT convert(varchar,isnull(SUM(qty),0)) AS cemt FROM tbl_ProductRecipe WHERE (rProd_id = 28) AND (Prod_id = tbl_Product.Prod_id))+'|'+(SELECT convert(varchar,isnull(SUM(amt),0))+'|'+tbl_Unit.Unit_title AS amt FROM tbl_ProductRecipe WHERE (Prod_id = tbl_Product.Prod_id))+'|'+(SELECT convert(varchar,isnull(SUM(qty),0)) AS cemt FROM tbl_ProductRecipe WHERE (rProd_id = 47) AND (Prod_id = tbl_Product.Prod_id))+'|'+convert(varchar,tbl_Product.Sft)+'|'+(SELECT convert(varchar,isnull(SUM(qty),0)) FROM tbl_ProductRecipe WHERE (rProd_id = 3899) AND (Prod_id = tbl_Product.Prod_id)) perCost FROM tbl_Product INNER JOIN tbl_Unit ON tbl_Product.Unit_id = tbl_Unit.Unit_id WHERE (tbl_Product.Brand_id IN (1,2,18,19,2018)) AND (tbl_Product.Prod_id = " + cboProducts.SelectedValue + ")")[0];
                Calc();
            }

        }
        private void Costing()
        {
            lblSandCost.Text = (Convert.ToDecimal(ActiveRates[0] == "" ? "0" : ActiveRates[0]) * (Convert.ToDecimal(txtSand.Value*40) + txtSand2.Value*40)).ToString("#.0");
            lblScreenSand.Text = (Convert.ToDecimal(ActiveRates[5] == "" ? "0" : ActiveRates[5]) * Convert.ToDecimal(txtSand2.Value)).ToString("#.0");
            lblPanCost.Text = (Convert.ToDecimal(ActiveRates[1] == "" ? "0" : ActiveRates[1]) * (Convert.ToDecimal(txtPan.Value*39))).ToString("#.0");
            lblPigmentCost.Text = (Convert.ToDecimal(ActiveRates[2] == "" ? "0" : ActiveRates[2]) * (Convert.ToDecimal(txtPigment.Value) + txtPigment2.Value)).ToString("#.0");
            lblCementCost.Text = (Convert.ToDecimal(ActiveRates[3] == "" ? "0" : ActiveRates[3]) * (Convert.ToDecimal(txtCement.Value) + txtCement2.Value)*1000).ToString("#.0");
            lblStonCost.Text = (Convert.ToDecimal(ActiveRates[4] == "" ? "0" : ActiveRates[4]) * (Convert.ToDecimal(txtStonDust.Value))).ToString("#.0");
            lblTotalCost.Text = (Convert.ToDecimal(lblSandCost.Text == "" ? "0" : lblSandCost.Text) + Convert.ToDecimal(lblPanCost.Text == "" ? "0" : lblPanCost.Text) + Convert.ToDecimal(lblPigmentCost.Text == "" ? "0" : lblPigmentCost.Text) + Convert.ToDecimal(lblCementCost.Text == "" ? "0" : lblCementCost.Text) + Convert.ToDecimal(lblStonCost.Text == "" ? "0" : lblStonCost.Text)).ToString("#.0");
            lblJMFCost.Text = (Convert.ToDecimal(txtQty.Value.ToString() == "" ? 0 : txtQty.Value) * (Convert.ToDecimal(lblCost.Text) * Convert.ToDecimal(lblPallets.Text)) / Convert.ToDecimal(pdata.Split('|')[9])).ToString("#.0");
        }
        private void Calc()
        {
            lblPallets.Text = pdata.Split('|')[1];
            lblCost.Text = pdata.Split('|')[6];
            double qty = txtQty.Value.ToString() == "" ? 0 : Convert.ToDouble(txtQty.Value);
            double tqty = (Convert.ToDouble(txtQty.Text == "" ? "0" : txtQty.Text) * Convert.ToDouble(lblPallets.Text))/ Convert.ToDouble(pdata.Split('|')[9]);

            lblScreenSand.Text = (tqty * (pdata.Split('|')[10] == "" ? 0 : Convert.ToDouble(pdata.Split('|')[10]))).ToString();

            lblSand.Text = (tqty * (pdata.Split('|')[2] == "" ? 0 : Convert.ToDouble(pdata.Split('|')[2]))).ToString();
            lblPan.Text = (tqty * (pdata.Split('|')[3] == "" ? 0 : Convert.ToDouble(pdata.Split('|')[3]))).ToString();
            lblCement.Text = (tqty * (pdata.Split('|')[5] == "" ? 0 : Convert.ToDouble(pdata.Split('|')[5]))).ToString();
            lblPigment.Text = (tqty * (pdata.Split('|')[4] == "" ? 0 : Convert.ToDouble(pdata.Split('|')[4]))).ToString();
            lblStonDust.Text = (tqty * (pdata.Split('|')[8] == "" ? 0 : Convert.ToDouble(pdata.Split('|')[8]))).ToString();
            lblQty.Text = "Quantity (" + pdata.Split('|')[7] + ")";
            lbltPallets.Text = (Convert.ToDecimal(txtQty.Text == "" ? "0" : txtQty.Text) * Convert.ToDecimal(lblPallets.Text) / Convert.ToDecimal(pdata.Split('|')[9])).ToString("#.0");
            //lblPallets.Text = (Convert.ToDecimal(lbltPallets.Text) / Convert.ToDecimal(txtQty.Value.ToString() == "" ? 0 : txtQty.Value)).ToString("#.0");
        }
        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            Calc();
            Costing();
        }
        private void txtSand_ValueChanged(object sender, EventArgs e)
        {
            Costing();
        }

        private void SearchRecord()
        {
            try
            {
                this.tblDailyProductionTableAdapter.Fill(this.dataSet6.tblDailyProduction, pDateDateTimePicker.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        private void pDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            SearchRecord();
        }

        private void tblDailyProductionBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tblDailyProductionBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tblDailyProductionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet6);

        }
    }
}