using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Value;

namespace AccountSystem
{
    public partial class frmProducts : Form
    {
        private MyDB fn = new MyDB();
        private MyModule Fn = new MyModule();
        public object[] ProductInfo;

        public frmProducts()
        {
            InitializeComponent();
            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }

        #region Default Instance

        private static frmProducts defaultInstance;

        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static frmProducts Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new frmProducts();
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
                        cmd.CommandText = "INSERT INTO tbl_Product(Prod_name, Prod_Price, Prod_Catg_id, Unit_id, Brand_id, Barcode, Created, Modified, Repli,DngrLevel,CompID,P_Price)VALUES(@name,@price,@catg,@unit,@brand,@barcode,@created,@modified,@repli,@DngrLevel," + MyModule.CompID + ",@P_Price)";
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
                        fn.CmdExe(cmd);
                        fn.ClearGroup(grpbx_product);
                        fn.ClearAll(this);
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
                        cmd.CommandText = "UPDATE tbl_Product set Prod_name=@Prod_name ,Prod_Price=@Prod_Price, Prod_Catg_id=@Prod_Catg_id,Unit_id=@Unit_id,Brand_id=@Brand_id,Barcode=@Barcode, Created=@Created, Modified=@Modified, Repli=@Repli,DngrLevel=@DngrLevel,P_Price=@P_Price WHERE(Prod_id=" + txtname.Tag + ")";
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
                        Fn.CmdExe(cmd);
                        fn.ClearGroup(grpbx_product);
                        fn.ClearAll(this);
                        btnsave.Text = "&Save";
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
                btnProductfind.Text = "&Find";
            }
            else
            {
                //frmfind find = new frmfind();
                frmfind.Default.ShowDialog();
                //this.Close();
            }
        }

        private void frmproduct_Load(object sender, EventArgs e)
        {
            //Fn.CenterScreen(this);
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}