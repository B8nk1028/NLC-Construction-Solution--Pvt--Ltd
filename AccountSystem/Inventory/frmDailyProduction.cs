using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Value;

namespace AccountSystem
{
    public partial class frmDailyProduction : Form
    {

        private MyModule Fn = new MyModule();
        public object[] ProductInfo;

        public frmDailyProduction()
        {
            InitializeComponent();
            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }

        #region Default Instance

        private static frmDailyProduction defaultInstance;

        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static frmDailyProduction Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new frmDailyProduction();
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



        private void btnsave_Click(object sender, EventArgs e)
        {
            
            if (txtQty.Text == "")
            {
                MessageBox.Show("Please enter Qty");
                return;

            }
            Fn.Exec("sp_InsertDailyProduction '" + dateTimePicker1.Value.ToString("dd MMM yyyy") + "', '" + cboProducts.SelectedValue.ToString().Split('|')[0] + "', '" +  txtQty.Text.Replace(",", "") + "', '" + lbltPallets.Text.Replace(",", "") + "','" + cboProducts.SelectedValue.ToString().Split('|')[2] + "','" + cboProducts.SelectedValue.ToString().Split('|')[3] + "','" + cboProducts.SelectedValue.ToString().Split('|')[4] + "','" + cboProducts.SelectedValue.ToString().Split('|')[5] + "','" + cboProducts.SelectedValue.ToString().Split('|')[6] + "','" + txtSand.Value + "','" + txtPan.Value + "','" + txtPigment.Value + "','" + txtCement.Value + "','" + cboProducts.SelectedValue.ToString().Split('|')[8] + "','" + txtStonDust.Value + "','" + txtSand2.Value + "','" + txtCement2.Value + "','" + txtPigment2.Value
                + "','" + lblPanCost.Text.Replace(",", "") + "','" + lblSandCost.Text.Replace(",", "") + "','" + lblCementCost.Text.Replace(",", "") + "','" + lblPigmentCost.Text.Replace(",", "") + "','" + lblStonCost.Text.Replace(",","") + "','" + lblScreenSand.Text.Replace(",", "") + "','"+ txtRmks.Text+ "','" + cboProducts.SelectedValue.ToString().Split('|')[10] + "','"+ddShift.Text+"','"+ddShiftStaff.SelectedValue+"','"+dtWHours.Text+"'");

            //Fn.Exec("INSERT INTO tblDailyProduction (pDate, ProdID, pallets, Qty,sand,pan,pigment,Cement,pPcCost,sand1,pan1,pigment1,Cement1) VALUES (CONVERT(DATETIME, '" + dateTimePicker1.Value.ToString("dd MMM yyyy")+"', 102), '"+cboProducts.SelectedValue.ToString().Split('|')[0]+"', '"+ lbltPallets.Text.Replace(",","") + "', '"+txtQty.Text.Replace(",", "") + "','" + cboProducts.SelectedValue.ToString().Split('|')[2] + "','" + cboProducts.SelectedValue.ToString().Split('|')[3] + "','" + cboProducts.SelectedValue.ToString().Split('|')[4] + "','" + cboProducts.SelectedValue.ToString().Split('|')[5] + "','"+ cboProducts.SelectedValue.ToString().Split('|')[6] + "','"+txtSand.Text+"','"+txtPan.Text+"','"+txtPigment.Text+"','"+txtCement.Text+"')");
            MessageBox.Show("Save successfully!");
   txtQty.Text = "";
        }
        private string[] ActiveRates = { "a", "b", "c", "d", "e", "f", "g", "h" };
        private void frmproduct_Load(object sender, EventArgs e)
        {
            Fn.fillCombo(ddShiftStaff, "SELECT EntryAccID,EntryAccName FROM TblAccEntry WHERE (AccType = 20) AND (EntryAccName LIKE N'%Plt%(E)')");
            Fn.fillCombo(cboProducts, "SELECT convert(varchar,tbl_Product.Prod_id)+'|'+convert(varchar,isnull(PalletsSize,0))+'|'+(SELECT convert(varchar,isnull(SUM(qty),0)) AS sand FROM tbl_ProductRecipe WHERE (rProd_id = 27) AND (Prod_id = tbl_Product.Prod_id))+'|'+(SELECT convert(varchar,isnull(SUM(qty),0)) AS pan FROM tbl_ProductRecipe WHERE (rProd_id = 29) AND (Prod_id = tbl_Product.Prod_id))+'|'+(SELECT convert(varchar,isnull(SUM(qty),0)) AS pan FROM tbl_ProductRecipe WHERE (rProd_id = 44) AND (Prod_id = tbl_Product.Prod_id))+'|'+(SELECT convert(varchar,isnull(SUM(qty),0)) AS cemt FROM tbl_ProductRecipe WHERE (rProd_id = 28) AND (Prod_id = tbl_Product.Prod_id))+'|'+(SELECT convert(varchar,isnull(SUM(amt),0))+'|'+tbl_Unit.Unit_title AS amt FROM tbl_ProductRecipe WHERE (Prod_id = tbl_Product.Prod_id))+'|'+(SELECT convert(varchar,isnull(SUM(qty),0)) AS cemt FROM tbl_ProductRecipe WHERE (rProd_id = 47) AND (Prod_id = tbl_Product.Prod_id))+'|'+convert(varchar,tbl_Product.Sft)+'|'+(SELECT convert(varchar,isnull(SUM(qty),0)) FROM tbl_ProductRecipe WHERE (rProd_id = 3899) AND (Prod_id = tbl_Product.Prod_id)) perCost, tbl_Product.Prod_name pname FROM tbl_Product INNER JOIN tbl_Unit ON tbl_Product.Unit_id = tbl_Unit.Unit_id WHERE (tbl_Product.Brand_id IN (1,2,18,19,2018)) order by Prod_name");
            ActiveRates = Fn.GetRecords("sp_ActiveRates");
        }

  

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            Fn.DecimalValue(sender, e, txtQty.Text);
        }

        private void cboProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calc();
        }

        private void Costing()
        {
            try
            {
            lblSandCost.Text = (Convert.ToDecimal(ActiveRates[0] == "" ? "0" : ActiveRates[0]) * (Convert.ToDecimal(txtSand.Value))).ToString("#,#.##");
            lblScreenSand.Text= (Convert.ToDecimal(ActiveRates[5] == "" ? "0" : ActiveRates[5]) * Convert.ToDecimal(txtSand2.Value)).ToString("#,#.##");
            lblPanCost.Text = (Convert.ToDecimal(ActiveRates[1] == "" ? "0" : ActiveRates[1]) * (Convert.ToDecimal(txtPan.Value))).ToString("#,#.##");
            lblPigmentCost.Text = (Convert.ToDecimal(ActiveRates[2] == "" ? "0" : ActiveRates[2]) * (Convert.ToDecimal(txtPigment.Value) + txtPigment2.Value)).ToString("#,#.##");
            lblCementCost.Text = (Convert.ToDecimal(ActiveRates[3] == "" ? "0" : ActiveRates[3]) * (Convert.ToDecimal(txtCement.Value) + txtCement2.Value)).ToString("#,#.##");
            lblStonCost.Text = (Convert.ToDecimal(ActiveRates[4] == "" ? "0" : ActiveRates[4]) * (Convert.ToDecimal(txtStonDust.Value))).ToString("#,#.##");
            lblTotalCost.Text = (Convert.ToDecimal(lblSandCost.Text == "" ? "0" : lblSandCost.Text) + Convert.ToDecimal(lblPanCost.Text == "" ? "0" : lblPanCost.Text) + Convert.ToDecimal(lblPigmentCost.Text == "" ? "0" : lblPigmentCost.Text) + Convert.ToDecimal(lblCementCost.Text == "" ? "0" : lblCementCost.Text) + Convert.ToDecimal(lblStonCost.Text == "" ? "0" : lblStonCost.Text)).ToString("#,#.##");

            lblJMFCost.Text = (Convert.ToDecimal(txtQty.Text == "" ? "0" : txtQty.Text) * (Convert.ToDecimal(lblCost.Text)*Convert.ToDecimal(lblPallets.Text)) / Convert.ToDecimal(cboProducts.SelectedValue.ToString().Split('|')[9])).ToString("#,#.##");
            }
            catch (Exception ex)
            {


            }

        }
        private void Calc()
        {
            try
            {
            lblPallets.Text = cboProducts.SelectedValue.ToString().Split('|')[1];
            lblCost.Text = cboProducts.SelectedValue.ToString().Split('|')[6];
            double qty = txtQty.Text == "" ? 0 : Convert.ToDouble(txtQty.Text);
                double tqty = (Convert.ToDouble(txtQty.Text == "" ? "0" : txtQty.Text) * Convert.ToDouble(lblPallets.Text))/Convert.ToDouble(cboProducts.SelectedValue.ToString().Split('|')[9]);

                lblScreenSand.Text= (tqty * (cboProducts.SelectedValue.ToString().Split('|')[10] == "" ? 0 : Convert.ToDouble(cboProducts.SelectedValue.ToString().Split('|')[10])) * 40).ToString();

                lblSand.Text=(tqty * (cboProducts.SelectedValue.ToString().Split('|')[2] == "" ? 0 : Convert.ToDouble(cboProducts.SelectedValue.ToString().Split('|')[2]))*40).ToString();
            lblPan.Text = (tqty * (cboProducts.SelectedValue.ToString().Split('|')[3] == "" ? 0 : Convert.ToDouble(cboProducts.SelectedValue.ToString().Split('|')[3]))*39).ToString();
            lblCement.Text = (tqty * (cboProducts.SelectedValue.ToString().Split('|')[5] == "" ? 0 : Convert.ToDouble(cboProducts.SelectedValue.ToString().Split('|')[5]))*1000).ToString();
            lblPigment.Text = (tqty * (cboProducts.SelectedValue.ToString().Split('|')[4] == "" ? 0 : Convert.ToDouble(cboProducts.SelectedValue.ToString().Split('|')[4]))).ToString();
            lblStonDust.Text = (tqty * (cboProducts.SelectedValue.ToString().Split('|')[8] == "" ? 0 : Convert.ToDouble(cboProducts.SelectedValue.ToString().Split('|')[8]))).ToString();
            lblQty.Text = "Quantity (" + cboProducts.SelectedValue.ToString().Split('|')[7] + ")";
            lbltPallets.Text = (Convert.ToDecimal(txtQty.Text==""?"0":txtQty.Text) * Convert.ToDecimal(lblPallets.Text)/ Convert.ToDecimal(cboProducts.SelectedValue.ToString().Split('|')[9])).ToString("#,#.##");
            }
            catch (Exception ex)
            {

            }




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
    }
}