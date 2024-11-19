using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Value;

namespace AccountSystem
{
    public partial class frmDamage : Form
    {

        private MyModule Fn = new MyModule();
        public object[] ProductInfo;

        public frmDamage()
        {
            InitializeComponent();
            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }

        #region Default Instance

        private static frmDamage defaultInstance;

        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static frmDamage Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new frmDamage();
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
            Fn.Exec("INSERT INTO tblDailyProduction (pDate, ProdID, pallets, Qty,sand,pan,pigment,Cement,pPcCost,Damage) VALUES (CONVERT(DATETIME, '" + dateTimePicker1.Text+"', 102), '"+cboProducts.SelectedValue.ToString().Split('|')[0]+ "', convert(float," + lbltPallets.Text + ")*-1, convert(float," + txtQty.Text+ ")*-1*" + cboProducts.SelectedValue.ToString().Split('|')[8] + ",0,0,0,0,'" + cboProducts.SelectedValue.ToString().Split('|')[6] + "',1,'"+ txtRmks.Text+ "')");
            MessageBox.Show("Save successfully!");
   txtQty.Text = "";
        }

        private void frmproduct_Load(object sender, EventArgs e)
        {
            Fn.fillCombo(cboProducts, "SELECT convert(varchar,tbl_Product.Prod_id)+'|'+convert(varchar,isnull(PalletsSize,0))+'|'+(SELECT convert(varchar,isnull(SUM(qty),0)) AS sand FROM tbl_ProductRecipe WHERE (rProd_id = 27) AND (Prod_id = tbl_Product.Prod_id))+'|'+(SELECT convert(varchar,isnull(SUM(qty),0)) AS pan FROM tbl_ProductRecipe WHERE (rProd_id = 29) AND (Prod_id = tbl_Product.Prod_id))+'|'+(SELECT convert(varchar,isnull(SUM(qty),0)) AS pan FROM tbl_ProductRecipe WHERE (rProd_id = 44) AND (Prod_id = tbl_Product.Prod_id))+'|'+(SELECT convert(varchar,isnull(SUM(qty),0)) AS cemt FROM tbl_ProductRecipe WHERE (rProd_id = 28) AND (Prod_id = tbl_Product.Prod_id))+'|'+(SELECT convert(varchar,isnull(SUM(amt),0))+'|'+tbl_Unit.Unit_title+'|'+convert(varchar,tbl_Product.Sft) AS amt FROM tbl_ProductRecipe WHERE (Prod_id = tbl_Product.Prod_id)) perCost, tbl_Product.Prod_name pname FROM tbl_Product INNER JOIN tbl_Unit ON tbl_Product.Unit_id = tbl_Unit.Unit_id WHERE (tbl_Product.Brand_id IN (1,2,18,19,2018)) order by Prod_name");
           
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
        private void Calc()
        {
            lblPallets.Text = cboProducts.SelectedValue.ToString().Split('|')[1];
            lblCost.Text = cboProducts.SelectedValue.ToString().Split('|')[6];
            double qty = txtQty.Text == "" ? 0 : Convert.ToDouble(txtQty.Text);
            lblSand.Text=(qty*(cboProducts.SelectedValue.ToString().Split('|')[2] == "" ? 0 : Convert.ToDouble(cboProducts.SelectedValue.ToString().Split('|')[2]))).ToString();
            lblPan.Text = (qty * (cboProducts.SelectedValue.ToString().Split('|')[3] == "" ? 0 : Convert.ToDouble(cboProducts.SelectedValue.ToString().Split('|')[3]))).ToString();
            lblCement.Text = (qty * (cboProducts.SelectedValue.ToString().Split('|')[5] == "" ? 0 : Convert.ToDouble(cboProducts.SelectedValue.ToString().Split('|')[5]))).ToString();
            lblPigment.Text = (qty * (cboProducts.SelectedValue.ToString().Split('|')[4] == "" ? 0 : Convert.ToDouble(cboProducts.SelectedValue.ToString().Split('|')[4]))).ToString();
            lblQty.Text = "Quantity (" + cboProducts.SelectedValue.ToString().Split('|')[7] + ")";
            lbltPallets.Text = (Convert.ToDecimal(txtQty.Text==""?"0":txtQty.Text) / Convert.ToDecimal(lblPallets.Text)).ToString("#,#.##");
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            Calc();
        }
    }
}