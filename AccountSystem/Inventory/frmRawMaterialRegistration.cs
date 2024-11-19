using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Value;

namespace AccountSystem
{
    public partial class frmRawMaterialRegistration : Form
    {
        private MyDB fn = new MyDB();
        private MyModule Fn = new MyModule();
        public object[] ProductInfo;

        public frmRawMaterialRegistration()
        {
            InitializeComponent();
            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }

        #region Default Instance

        private static frmRawMaterialRegistration defaultInstance;

        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static frmRawMaterialRegistration Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new frmRawMaterialRegistration();
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

        public Boolean nameValidator()
        {
            bool chk = true;
            if (txtname.Text == "")
            {
                MessageBox.Show("Please Enter Name !!!");
                txtname.Focus();
                chk = false;
               
            }
            else if (txtprice.Text == "")
            {
                MessageBox.Show("Please Enter Price !!!");
                txtprice.Focus();
                chk = false;
            }
            else if (cobunit.Text == "")
            {
                MessageBox.Show("Please Enter Valid Unit !!!");
                cobunit.Focus();
                chk = false;
            }
            //else if (txtbarcode.Text == "")
            //{
            //    MessageBox.Show("Please Enter Valid code !!!");
            //    txtbarcode.Focus();
            //    chk = false;
            //}
            else if (btnsave.Text == "&Save")
            {
                //if (fn.RecordChk("SELECT Barcode FROM tbl_Product WHERE(Barcode = '" + txtbarcode.Text + "') AND (CompID = " + MyModule.CompID + ")") == false)
                //{
                //    MessageBox.Show("Barcode (" + txtbarcode.Text + ") allready entered ... Please enter new one.");
                //    txtbarcode.Focus();
                //    chk = false;
                //}
            }
            try
            {
                //e.Handled = !char.IsNumber(e.KeyChar);
                Convert.ToDecimal(txtprice.Text);
                Convert.ToDecimal(txtP_Price.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a valid price ...");
                txtprice.Focus();
                chk = false;
            }
            return chk;
        }

        //private void txtbarcode_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        //}

        private void btnclose_Click(object sender, EventArgs e)
        {
            fn.ClearGroup(grpbx_product);
            fn.ClearAll(this);
            //fn.fillCombo(cobcategory, "SELECT Prod_ctg_id, Prod_ctg_name FROM tbl_Prod_category");
            //fn.fillCombo(cobunit, "SELECT Unit_id, Unit_title FROM tbl_Unit");
            //fn.fillCombo(cobbrand, "SELECT Brand_id, Brand_name FROM tbl_Brand");
            btnsave.Text = "&Save";
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (nameValidator())
            {
                SqlCommand cmd = new SqlCommand();
                if (btnsave.Text == "&Save")
                {
                    try
                    {
                        cmd.CommandText = "INSERT INTO tbl_Product(Prod_name, Prod_Price, Prod_Catg_id, Unit_id, Brand_id, Barcode, Created, Modified, Repli,DngrLevel,CompID,P_Price,pType,SalesTax,PalletsSize)VALUES(@name,@price,@catg,@unit,@brand,@barcode,@created,@modified,@repli,@DngrLevel," + MyModule.CompID + ",@P_Price,1,'"+ txtSalesTax.Text+ "',@PalletsSize)";
                        cmd.Parameters.AddWithValue("@name", txtname.Text);
                        cmd.Parameters.AddWithValue("@price", txtprice.Text);
                        cmd.Parameters.AddWithValue("@catg", cobcategory.SelectedValue == null ? DBNull.Value : cobcategory.SelectedValue);
                        cmd.Parameters.AddWithValue("@unit", cobunit.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@brand", cobbrand.SelectedValue == null ? DBNull.Value : cobbrand.SelectedValue);
                        cmd.Parameters.AddWithValue("@barcode", txtbarcode.Text);
                        cmd.Parameters.AddWithValue("@created", DateTime.Now);
                        cmd.Parameters.AddWithValue("@modified", DateTime.Now);
                        cmd.Parameters.AddWithValue("@repli", 0);
                        cmd.Parameters.AddWithValue("@DngrLevel", txtDngrLevel.Text);
                        cmd.Parameters.AddWithValue("@P_Price", txtP_Price.Text);
                        cmd.Parameters.AddWithValue("@PalletsSize", txtPallets.Text);
                        Fn.CmdExe(cmd);
                        txtname.Tag = Fn.GetRecords("SELECT MAX(Prod_id) FROM tbl_Product")[0];
                        //fn.ClearGroup(grpbx_product);
                        //fn.ClearAll(this);
                        btnsave.Text = "&Update";
                        MessageBox.Show("Successfully Saved");

                        txtname.Focus();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Not Successfully saved");
                    }
                }
                else if (btnsave.Text == "&Update")
                {
                    try
                    {
                        cmd.CommandText = "UPDATE tbl_Product set Prod_name=@Prod_name ,Prod_Price=@Prod_Price, Prod_Catg_id=@Prod_Catg_id,Unit_id=@Unit_id,Brand_id=@Brand_id,Barcode=@Barcode, Created=@Created, Modified=@Modified, Repli=@Repli,DngrLevel=@DngrLevel,P_Price=@P_Price,SalesTax=@SalesTax,PalletsSize=@PalletsSize WHERE(Prod_id=" + txtname.Tag + ")";
                        cmd.Parameters.AddWithValue("@Prod_name", txtname.Text);
                        cmd.Parameters.AddWithValue("@Prod_Price", txtprice.Text);
                        cmd.Parameters.AddWithValue("@Prod_Catg_id", cobcategory.SelectedValue == null ? DBNull.Value : cobcategory.SelectedValue);
                        cmd.Parameters.AddWithValue("@Unit_id", cobunit.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@Brand_id", cobbrand.SelectedValue == null ? DBNull.Value : cobbrand.SelectedValue);
                        cmd.Parameters.AddWithValue("@barcode", txtbarcode.Text);
                        cmd.Parameters.AddWithValue("@created", DateTime.Now);
                        cmd.Parameters.AddWithValue("@modified", DateTime.Now);
                        cmd.Parameters.AddWithValue("@repli", 0);
                        cmd.Parameters.AddWithValue("@DngrLevel", txtDngrLevel.Text);
                        cmd.Parameters.AddWithValue("@P_Price", txtP_Price.Text);
                        cmd.Parameters.AddWithValue("@SalesTax", txtSalesTax.Text);
                        cmd.Parameters.AddWithValue("@PalletsSize", txtPallets.Text);
                        //fn.ClearGroup(grpbx_product);
                        //fn.ClearAll(this);
                        Fn.CmdExe(cmd);
                        //btnsave.Text = "&Save";
                        MessageBox.Show("Successfully Saved");
                        txtname.Focus();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Not Successfully saved");
                    }
                }
            }
        }

        private void btnfind_Click_1(object sender, EventArgs e)
        {
            if (btnProductfind.Text == "&Cancel")
            {
                //fn.fillCombo(cobcategory, "SELECT Prod_ctg_id, Prod_ctg_name FROM tbl_Prod_category");
                //fn.fillCombo(cobunit, "SELECT Unit_id, Unit_title FROM tbl_Unit");
                //fn.fillCombo(cobbrand, "SELECT Brand_id, Brand_name FROM tbl_Brand");
                btnsave.Text = "&Save";
                fn.ClearGroup(grpbx_product);
                fn.ClearAll(this);
                grdBill.Height = 0;
                DataTable dt = Fn.FillDSet("SELECT tbl_Product.Prod_name+' ('+tbl_Unit.Unit_title+')' Prod_name, tbl_ProductRecipe.qty, tbl_Product.p_Price * tbl_ProductRecipe.qty AS amt, tbl_ProductRecipe.id FROM tbl_ProductRecipe INNER JOIN tbl_Product ON tbl_ProductRecipe.rProd_id = tbl_Product.Prod_id INNER JOIN tbl_Unit ON tbl_Product.Unit_id = tbl_Unit.Unit_id WHERE (tbl_ProductRecipe.Prod_id = 0)").Tables[0];
                BindingSource bs = new BindingSource();
                bs.DataSource = dt;
                grdBill.DataSource = bs;
                //groupBox1.Enabled = false;
                btnProductfind.Text = "&Find";
            }
            else
            {
                //frmfind find = new frmfind();
                frmfindRW.Default.ShowDialog();
                //this.Close();
            }
        }

        private void frmproduct_Load(object sender, EventArgs e)
        {
            
            Fn.fillCombo(cboProducts, "SELECT convert(varchar,tbl_Product.Prod_id)+'|'+convert(varchar,tbl_Product.p_Price), tbl_Product.Prod_name+' ('+tbl_Unit.Unit_title+')' FROM tbl_Product INNER JOIN tbl_Unit ON tbl_Product.Unit_id = tbl_Unit.Unit_id");
            //Fn.CenterScreen(this);
            cboProducts.Text = ""; cboProducts.SelectedIndex = -1;
            object[] Inv_Set = fn.GetRecords("SELECT P_Cat, P_Brand FROM tbl_Inv_Set WHERE (ComID = " + MyModule.CompID + ") order by P_Brand");
            if ((bool)Inv_Set[0])
            {
                cobcategory.Enabled = false;
            }
            else
            {
                fn.fillCombo(cobcategory, "SELECT Prod_ctg_id, Prod_ctg_name FROM tbl_Prod_category where Repli=1 order by Prod_ctg_name");
            }
            if ((bool)Inv_Set[1])
            {
                cobbrand.Enabled = false;
            }
            else
            {
                fn.fillCombo(cobbrand, "SELECT Brand_id, Brand_name FROM tbl_Brand where Repli=1 order by Brand_name");
            }
            fn.fillCombo(cobunit, "SELECT Unit_id, Unit_title FROM tbl_Unit where Repli=1 order by Unit_title");
            if (txtname.Text == "")
            {
                fn.ClearAll(this);
                fn.ClearGroup(grpbx_product);
            }
        }

        public void FillRecord()
        {
            txtname.Tag = ProductInfo[0].ToString();
            txtname.Text = ProductInfo[1].ToString();
            txtprice.Text = ProductInfo[2].ToString();
            cobcategory.SelectedValue = ProductInfo[3].ToString();
            cobunit.SelectedValue = ProductInfo[4].ToString();
            cobbrand.SelectedValue = ProductInfo[5].ToString();
            txtbarcode.Text = ProductInfo[6].ToString();
            txtDngrLevel.Text = ProductInfo[7].ToString();
            txtP_Price.Text = ProductInfo[8].ToString();
            txtSalesTax.Text = ProductInfo[9].ToString();
            txtPallets.Text= ProductInfo[10].ToString();
            groupBox1.Enabled = true;
  DataTable dt=Fn.FillDSet("SELECT tbl_Product.Prod_name+' ('+tbl_Unit.Unit_title+')' Prod_name, tbl_ProductRecipe.qty, tbl_Product.p_Price * tbl_ProductRecipe.qty AS amt, tbl_ProductRecipe.id FROM tbl_ProductRecipe INNER JOIN tbl_Product ON tbl_ProductRecipe.rProd_id = tbl_Product.Prod_id INNER JOIN tbl_Unit ON tbl_Product.Unit_id = tbl_Unit.Unit_id WHERE (tbl_ProductRecipe.Prod_id = " + txtname.Tag + ")").Tables[0];
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            grdBill.DataSource = bs;
            if (dt.Rows.Count>0)
            {
                grdBill.Height = dt.Rows.Count* 24;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtGAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtRQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            Fn.DecimalValue(sender, e, txtRQty.Text);
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            if (nameValidator())
            {
                btnsave_Click(sender, e);

                //grdBill.Rows.Add();
                Fn.Exec("INSERT INTO tbl_ProductRecipe (Prod_id, rProd_id, qty, amt,rate) VALUES (" + txtname.Tag + ", "+ (cboProducts.SelectedValue).ToString().Split('|')[0] + ","+ txtRQty.Text + ", '"+ txtGAmount.Text + "','"+ (cboProducts.SelectedValue).ToString().Split('|')[1] + "')");
                //grdBill.Rows[grdBill.RowCount - 1].Cells["gtxtItem"].Value = cboProducts.Text.Split('|')[0];
                //grdBill.Rows[grdBill.RowCount - 1].Cells["gtxtItem"].Tag = (cboProducts.SelectedValue).ToString().Split('|')[0];
                ////grdBill.Rows[grdBill.RowCount - 1].Cells["gtxtMU"].Value = txtRate.Text;
                //grdBill.Rows[grdBill.RowCount - 1].Cells["gtxtQty"].Value = txtRQty.Text;
                //grdBill.Rows[grdBill.RowCount - 1].Cells["gtxtAmount"].Value = Convert.ToDecimal((cboProducts.SelectedValue).ToString().Split('|')[1]) * Convert.ToDecimal(txtRQty.Text);
                //grdBill.Rows[grdBill.RowCount - 1].Cells["txtID"].Value = txtGAmount.Text;

                cboProducts.Text = ""; cboProducts.SelectedIndex = -1; txtRQty.Text = ""; txtGAmount.Text = "";
                cboProducts.Focus();
                DataTable dt = Fn.FillDSet("SELECT tbl_Product.Prod_name+' ('+tbl_Unit.Unit_title+')' Prod_name, tbl_ProductRecipe.qty, tbl_Product.p_Price * tbl_ProductRecipe.qty AS amt, tbl_ProductRecipe.id FROM tbl_ProductRecipe INNER JOIN tbl_Product ON tbl_ProductRecipe.rProd_id = tbl_Product.Prod_id INNER JOIN tbl_Unit ON tbl_Product.Unit_id = tbl_Unit.Unit_id WHERE (tbl_ProductRecipe.Prod_id = " + txtname.Tag + ")").Tables[0];
                BindingSource bs = new BindingSource();
                bs.DataSource = dt;
                grdBill.DataSource = bs;
                if (dt.Rows.Count > 0)
                {
                    grdBill.Height = dt.Rows.Count * 24;
                }

            }

        }

        private void grdBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==1)
            {
            Fn.Exec("DELETE FROM tbl_ProductRecipe WHERE (id = "+ grdBill [5,e.RowIndex].Value+ ")");
            DataTable dt = Fn.FillDSet("SELECT tbl_Product.Prod_name+' ('+tbl_Unit.Unit_title+')' Prod_name, tbl_ProductRecipe.qty, tbl_Product.p_Price * tbl_ProductRecipe.qty AS amt, tbl_ProductRecipe.id FROM tbl_ProductRecipe INNER JOIN tbl_Product ON tbl_ProductRecipe.rProd_id = tbl_Product.Prod_id INNER JOIN tbl_Unit ON tbl_Product.Unit_id = tbl_Unit.Unit_id WHERE (tbl_ProductRecipe.Prod_id = " + txtname.Tag + ")").Tables[0];
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            grdBill.DataSource = bs;
            if (dt.Rows.Count > 0)
            {
                grdBill.Height = dt.Rows.Count * 24;
            }
            }

        }

        private void txtPallets_KeyPress(object sender, KeyPressEventArgs e)
        {
            Fn.DecimalValue(sender, e, txtPallets.Text);
        }

        private void txtprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            Fn.DecimalValue(sender, e, txtprice.Text);
        }

        private void txtSalesTax_KeyPress(object sender, KeyPressEventArgs e)
        {
            Fn.DecimalValue(sender, e, txtSalesTax.Text);
        }

        private void txtP_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            Fn.DecimalValue(sender, e, txtP_Price.Text);
        }

        private void txtDngrLevel_KeyPress(object sender, KeyPressEventArgs e)
        {
            Fn.DecimalValue(sender, e, txtDngrLevel.Text);
        }

        private void cboProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtGAmount.Text = (float.Parse((cboProducts.SelectedValue).ToString().Split('|')[1]) * float.Parse(txtRQty.Text)).ToString();
            }
            catch (Exception ex)
            {

            }



        }

        private void txtRQty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtGAmount.Text = (float.Parse((cboProducts.SelectedValue).ToString().Split('|')[1]) * float.Parse(txtRQty.Text)).ToString();
            }
            catch (Exception ex)
            {

            }
        }
        
        private void grdBill_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {double total = 0;
            for (int i = 0; i < grdBill.Rows.Count; i++)
            {
               
                if (grdBill.Rows[i].Cells["gtxtAmount"].Value != null)
                {

                    total = total + Convert.ToDouble(grdBill.Rows[i].Cells["gtxtAmount"].Value);
     
                    txtJMF.Text = Convert.ToDouble(total).ToString("#,#.00");

                }
            }
        }
    }
}