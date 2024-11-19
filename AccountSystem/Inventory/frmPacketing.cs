using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Value;

namespace AccountSystem
{
    public partial class frmPacketing : Form
    {

        private MyModule Fn = new MyModule();
        public object[] ProductInfo;

        public frmPacketing()
        {
            InitializeComponent();
            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }

        #region Default Instance

        private static frmPacketing defaultInstance;

        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static frmPacketing Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new frmPacketing();
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
            
            if (txtPallets.Text == "")
            {
                MessageBox.Show("Please enter Qty");
                return;

            }
            Fn.Exec("INSERT INTO tblPacketing (pDate, ProdID, pallets, Qty,Damage,remarks,StoreID) VALUES (CONVERT(DATETIME, '" + dateTimePicker1.Text+"', 102), '"+cboProducts.SelectedValue.ToString().Split('|')[0]+ "', convert(float," + txtPallets.Text + ")*"+ cboPackDamage.SelectedValue+ ", convert(float," + lbltQTY.Text.Replace(",","")+ ")*"+ cboPackDamage.SelectedValue+ "," + cboPackDamage.SelectedValue+ ",'"+ txtRmks.Text+ "',"+ cboStores.SelectedValue+ ")");
            MessageBox.Show("Save successfully!");
   txtPallets.Text = "";
        }

        private void frmproduct_Load(object sender, EventArgs e)
        {
            Fn.fillCombo(cboStores, "SELECT CONVERT(varchar, EntryAccID) AS Expr1, EntryAccName FROM TblAccEntry WHERE (AccType IN (21)) AND (Stat = 1) AND (NOT (EntryAccID IN (6763, 15992)))");Fn.fillCombo(cboPackDamage, "select 1,'Packeting' union select -1, 'Damages'");
            Fn.fillCombo(cboProducts, "SELECT convert(varchar,tbl_Product.Prod_id)+'|'+convert(varchar,isnull(PalletsSize,0))+'|'+(SELECT convert(varchar,isnull(SUM(qty),0)) AS sand FROM tbl_ProductRecipe WHERE (rProd_id = 27) AND (Prod_id = tbl_Product.Prod_id))+'|'+(SELECT convert(varchar,isnull(SUM(qty),0)) AS pan FROM tbl_ProductRecipe WHERE (rProd_id = 29) AND (Prod_id = tbl_Product.Prod_id))+'|'+(SELECT convert(varchar,isnull(SUM(qty),0)) AS pan FROM tbl_ProductRecipe WHERE (rProd_id = 44) AND (Prod_id = tbl_Product.Prod_id))+'|'+(SELECT convert(varchar,isnull(SUM(qty),0)) AS cemt FROM tbl_ProductRecipe WHERE (rProd_id = 28) AND (Prod_id = tbl_Product.Prod_id))+'|'+(SELECT convert(varchar,isnull(SUM(amt),0))+'|'+tbl_Unit.Unit_title+'|'+convert(varchar,tbl_Product.Sft) AS amt FROM tbl_ProductRecipe WHERE (Prod_id = tbl_Product.Prod_id)) perCost, tbl_Product.Prod_name pname FROM tbl_Product INNER JOIN tbl_Unit ON tbl_Product.Unit_id = tbl_Unit.Unit_id WHERE (tbl_Product.Brand_id IN (1,2,18,19,2018)) order by Prod_name");
           
        }

  

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            Fn.DecimalValue(sender, e, txtPallets.Text);
        }

        private void cboProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calc();
        }
        private void Calc()
        {
            try
            {
            lblPallets.Text = cboProducts.SelectedValue.ToString().Split('|')[1];
            lblCost.Text = cboProducts.SelectedValue.ToString().Split('|')[6];
            double qty = txtPallets.Text == "" ? 0 : Convert.ToDouble(txtPallets.Text);
          
            label5.Text = "Quantity (" + cboProducts.SelectedValue.ToString().Split('|')[7] + ")";
            lbltQTY.Text = (Convert.ToDecimal(txtPallets.Text==""?"0":txtPallets.Text) * Convert.ToDecimal(lblPallets.Text) / Convert.ToDecimal(cboProducts.SelectedValue.ToString().Split('|')[8])).ToString("#,#.##");
            }
            catch (Exception ex)
            {

            }

        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            Calc();
        }
    }
}