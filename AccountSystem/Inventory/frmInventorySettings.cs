using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Value;
namespace AccountSystem
{
    public partial class frmInventorySettings : Form
    {
        private MyModule Fn = new MyModule();
        private MyDB fn = new MyDB();
        public int update_id;
        public void Refreshallgrdvw()
        {
            fn.fillGrid(dgv_category, "SELECT Prod_ctg_id, Prod_ctg_name,Repli  FROM tbl_Prod_category");
            fn.fillGrid(dgv_unit, "SELECT Unit_id, Unit_title,Repli  FROM tbl_Unit");
            fn.fillGrid(dgv_brand, "SELECT Brand_id, Brand_name,Repli  FROM tbl_Brand");
            fn.fillGrid(dgv_pakg, "SELECT Pakg_id, Pakg_name, Pakg_no  FROM tbl_Paking");
            fn.fillGrid(dgv_str, "SELECT Str_name, Str_id, Str_address, Str_type, Str_contact_no FROM tbl_Store");
        }
        public Boolean validation()
        {
            bool chk = true;
            if (txt_category.Text == "")
            {
                MessageBox.Show("Please enter the Category name ");
                txt_category.Focus();
                chk = false;
            }
            return chk;
        }
        public Boolean validationpaking()
        {
            bool chk = true;
            if (txt_paking.Text == "")
            {
                MessageBox.Show("Please enter the paking name ");
                txt_paking.Focus();
                chk = false;
            }
            else if (txt_pakg_no.Text == "")
            {
                MessageBox.Show("Please enter the paking number ");
                txt_pakg_no.Focus();
                chk = false;
            }
            return chk;
        }
        public Boolean validationbrandpage()
        {
            bool chk = true;
            if (txt_brand.Text == "")
            {
                MessageBox.Show("Please enter the brand name ");
                txt_brand.Focus();
                chk = false;
            }
            return chk;
        }
        public Boolean validationAddStorepage()
        {
            bool chk = true;
            if (txt_str_name.Text == "")
            {
                MessageBox.Show("Please enter the Name ");
                txt_str_name.Focus();
                chk = false;
            }
            return chk;
        }
        public Boolean validationunitpage()
        {
            bool chk = true;
            if (txt_unit.Text == "")
            {
                MessageBox.Show("Please enter the Unit ");
                txt_unit.Focus();
                chk = false;
            }
            return chk;
        }
        public frmInventorySettings()
        {
            InitializeComponent();
            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }
        #region Default Instance
        private static frmInventorySettings defaultInstance;
        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static frmInventorySettings Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new frmInventorySettings();
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
        private void btn_addnew_Click(object sender, EventArgs e)
        {
            if (btn_addnew.Text == "&Add New")
            {
                btn_addnew.Text = "&Save";
                btn_addnew.Image = global::AccountSystem.Properties.Resources.save_all;
                txt_category.Enabled = true;
                txt_category.Focus();
            }
            else if (btn_addnew.Text == "&Save")
            {
                if (validation())
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "INSERT INTO tbl_Prod_category(Prod_ctg_name, Repli)VALUES (@Prod_ctg_name,@Repli)";
                    cmd.Parameters.AddWithValue("@Prod_ctg_name", txt_category.Text);
                    cmd.Parameters.AddWithValue("@Repli", ckBrand.Checked);
                    fn.CmdExe(cmd);
                    txt_category.Text = "";
                    Refreshallgrdvw();
                    fn.ClearGroup(grpCat);
                    btn_addnew.Text = "&Add New";
                    btn_addnew.Image = global::AccountSystem.Properties.Resources.add;
                    txt_category.Enabled = false;
                }
            }
            else if (btn_addnew.Text == "&Update")
            {
                if (validation())
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "UPDATE tbl_Prod_category SET Prod_ctg_name = @name,Repli=@Repli WHERE (Prod_ctg_id = @id)";
                    cmd.Parameters.AddWithValue("@name", txt_category.Text);
                    cmd.Parameters.AddWithValue("@id", txt_category.Tag);
                    cmd.Parameters.AddWithValue("@Repli", ckSubCat.Checked);
                    fn.CmdExe(cmd);
                    Refreshallgrdvw();
                    fn.ClearGroup(grpCat);
                    btn_addnew.Text = "&Add New";
                    btn_addnew.Image = global::AccountSystem.Properties.Resources.add;
                    txt_category.Enabled = false;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            txt_category.Enabled = false;
            btn_addnew.Text = "&Add New";
            btn_addnew.Image = global::AccountSystem.Properties.Resources.add;
            txt_category.Text = "";
        }
        private void btn_unit_adnw_Click(object sender, EventArgs e)
        {
            if (btn_unit_adnw.Text == "&Add New")
            {
                btn_unit_adnw.Text = "&Save";
                btn_unit_adnw.Image = global::AccountSystem.Properties.Resources.save_all;
                txt_unit.Enabled = true;
                txt_unit.Focus();
            }
            else if (btn_unit_adnw.Text == "&Save")
            {
                if (validationunitpage())
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "INSERT INTO tbl_Unit(Repli, Unit_title)VALUES(@repli,@title)";
                    cmd.Parameters.AddWithValue("@repli", ckCat.Checked);
                    cmd.Parameters.AddWithValue("@title", txt_unit.Text);
                    fn.CmdExe(cmd);
                    txt_unit.Text = "";
                    Refreshallgrdvw();
                    fn.ClearGroup(grpUnit);
                    btn_unit_adnw.Text = "&Add New";
                    btn_unit_adnw.Image = global::AccountSystem.Properties.Resources.add;
                    txt_unit.Enabled = false;
                }
            }
            else if (btn_unit_adnw.Text == "&Update")
            {
                if (validationunitpage())
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "UPDATE    tbl_Unit SET Unit_title = @name, Repli=@Repli WHERE     (Unit_id = @id)";
                    cmd.Parameters.AddWithValue("@name", txt_unit.Text);
                    cmd.Parameters.AddWithValue("@id", txt_unit.Tag);
                    cmd.Parameters.AddWithValue("@Repli", ckCat.Checked);
                    fn.CmdExe(cmd);
                    Refreshallgrdvw();
                    fn.ClearGroup(grpUnit);
                    btn_unit_adnw.Text = "&Add New";
                    btn_unit_adnw.Image = global::AccountSystem.Properties.Resources.add;
                    txt_unit.Enabled = false;
                }
            }
        }
        private void btn_unit_cancel_Click(object sender, EventArgs e)
        {
            txt_unit.Enabled = false;
            btn_unit_adnw.Text = "&Add New";
            btn_unit_adnw.Image = global::AccountSystem.Properties.Resources.add;
            txt_unit.Text = "";
        }
        private void Frm_parameters_Load(object sender, EventArgs e)
        {
            Fn.CenterScreen(this);
            // TODO: This line of code loads data into the 'inv_Set_DS.tbl_Inv_Set' table. You can move, or remove it, as needed.
            this.tbl_Inv_SetTableAdapter.Fill(this.inv_Set_DS.tbl_Inv_Set, MyModule.CompID);
            if (inv_Set_DS.tbl_Inv_Set.Rows.Count == 0)
            {
                bindingNavigatorAddNewItem.Visible = true;
                bindingNavigatorAddNewItem.PerformClick();
                bindingNavigatorAddNewItem.Visible = false;
            }
            //MyDB.ConStr = "Data Source=valuetech;Initial Catalog=ValuePOS;User ID=sa;Password=mzislam";
            fn.fillGrid(dgv_category, "SELECT Prod_ctg_id, Prod_ctg_name,Repli FROM tbl_Prod_category");
            fn.fillGrid(dgv_unit, "SELECT Unit_id, Unit_title,Repli  FROM tbl_Unit");
            fn.fillGrid(dgv_brand, "SELECT Brand_id, Brand_name,Repli  FROM tbl_Brand");
            fn.fillGrid(dgv_pakg, "SELECT Pakg_id, Pakg_name, Pakg_no  FROM tbl_Paking");
            fn.fillGrid(dgv_str, "SELECT Str_name, Str_id, Str_address, Str_type, Str_contact_no FROM tbl_Store");
        }
        private void btn_brand_addnew_Click(object sender, EventArgs e)
        {
            if (btn_brand_addnew.Text == "&Add New")
            {
                btn_brand_addnew.Text = "&Save";
                btn_brand_addnew.Image = global::AccountSystem.Properties.Resources.save_all;
                txt_brand.Enabled = true;
                txt_brand.Focus();
            }
            else if (btn_brand_addnew.Text == "&Save")
            {
                if (validationbrandpage())
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "INSERT INTO tbl_Brand(Brand_name, Repli)VALUES(@name,@repli)";
                    cmd.Parameters.AddWithValue("@name", txt_brand.Text);
                    cmd.Parameters.AddWithValue("@repli", ckBrand.Checked);
                    fn.CmdExe(cmd);
                    txt_brand.Text = "";
                    Refreshallgrdvw();
                    fn.ClearGroup(grpBrand);
                    btn_brand_addnew.Text = "&Add New";
                    btn_brand_addnew.Image = global::AccountSystem.Properties.Resources.add;
                    txt_brand.Enabled = false;
                }
            }
            else if (btn_brand_addnew.Text == "&Update")
            {
                if (validationbrandpage())
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "UPDATE    tbl_Brand SET Brand_name = @name,Repli=@Repli WHERE (Brand_id = @id)";
                    cmd.Parameters.AddWithValue("@name", txt_brand.Text);
                    cmd.Parameters.AddWithValue("@id", txt_brand.Tag);
                    cmd.Parameters.AddWithValue("@Repli", ckBrand.Checked);
                    fn.CmdExe(cmd);
                    Refreshallgrdvw();
                    fn.ClearGroup(grpBrand);
                    btn_brand_addnew.Text = "&Add New";
                    btn_brand_addnew.Image = global::AccountSystem.Properties.Resources.add;
                    txt_brand.Enabled = false;
                }
            }
        }
        private void btn_brand_cancel_Click(object sender, EventArgs e)
        {
            txt_brand.Enabled = false;
            btn_brand_addnew.Text = "&Add New";
            btn_brand_addnew.Image = global::AccountSystem.Properties.Resources.add;
            txt_brand.Text = "";
        }
        private void btn_pakg_addnew_Click(object sender, EventArgs e)
        {
            if (btn_pakg_addnew.Text == "&Add New")
            {
                btn_pakg_addnew.Text = "&Save";
                btn_pakg_addnew.Image = global::AccountSystem.Properties.Resources.save_all;
                txt_paking.Enabled = true;
                txt_pakg_no.Enabled = true;
                txt_paking.Focus();
            }
            else if (btn_pakg_addnew.Text == "&Save")
            {
                if (validationpaking())
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "INSERT INTO tbl_Paking(Pakg_name, Pakg_no, Repli)VALUES(@name,@no,@repli)";
                    cmd.Parameters.AddWithValue("@name", txt_paking.Text);
                    cmd.Parameters.AddWithValue("@no", txt_pakg_no.Text);
                    cmd.Parameters.AddWithValue("@repli", 0);
                    fn.CmdExe(cmd);
                    txt_paking.Text = "";
                    Refreshallgrdvw();
                    fn.ClearGroup(grpPaking);
                    btn_pakg_addnew.Text = "&Add New";
                    btn_pakg_addnew.Image = global::AccountSystem.Properties.Resources.add;
                    txt_paking.Enabled = false;
                    txt_pakg_no.Enabled = false;
                }
            }
            else if (btn_pakg_addnew.Text == "&Update")
            {
                if (validationpaking())
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "UPDATE    tbl_Paking SET Pakg_name = @name, Pakg_no = @no,Repli=0 WHERE     (Pakg_id = @id)";
                    cmd.Parameters.AddWithValue("@name", txt_paking.Text);
                    cmd.Parameters.AddWithValue("@no", txt_pakg_no.Text);
                    cmd.Parameters.AddWithValue("@id", txt_paking.Tag);
                    fn.CmdExe(cmd);
                    Refreshallgrdvw();
                    btn_pakg_addnew.Text = "&Add New";
                    btn_pakg_addnew.Image = global::AccountSystem.Properties.Resources.add;
                    txt_paking.Enabled = false;
                    txt_pakg_no.Enabled = false;
                }
            }
        }
        private void btn_pakg_cancel_Click(object sender, EventArgs e)
        {
            txt_paking.Enabled = false;
            txt_pakg_no.Enabled = false;
            btn_pakg_addnew.Text = "&Add New";
            btn_pakg_addnew.Image = global::AccountSystem.Properties.Resources.add;
            txt_paking.Text = "";
            txt_pakg_no.Text = "";
        }
        private void txt_pakg_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void dgv_category_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_addnew.Text = "&Update";
            btn_addnew.Image = global::AccountSystem.Properties.Resources.save_all;
            txt_category.Enabled = true;
            //if (e.ColumnIndex == 1)
            //{
            txt_category.Text = dgv_category.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_category.Tag = Convert.ToInt32(dgv_category.Rows[e.RowIndex].Cells[0].Value);
            ckSubCat.Checked = (bool)dgv_category.Rows[e.RowIndex].Cells[2].Value;
            //}
        }
        private void frm_parameters_frsh_btn_Click(object sender, EventArgs e)
        {
            fn.fillGrid(dgv_category, "SELECT Prod_ctg_id, Prod_ctg_name,Repli  FROM tbl_Prod_category");
            fn.fillGrid(dgv_unit, "SELECT Unit_id, Unit_title,Repli   FROM tbl_Unit");
            fn.fillGrid(dgv_brand, "SELECT Brand_id, Brand_name,Repli   FROM tbl_Brand");
            fn.fillGrid(dgv_pakg, "SELECT Pakg_id, Pakg_name, Pakg_no  FROM tbl_Paking");
        }
        private void dgv_category_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void page_prod_unit_Click(object sender, EventArgs e)
        {
        }
        private void dgv_unit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_unit_adnw.Text = "&Update";
            btn_unit_adnw.Image = global::AccountSystem.Properties.Resources.save_all;
            txt_unit.Enabled = true;
            //if (e.ColumnIndex == 1)
            //{
            txt_unit.Text = dgv_unit.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_unit.Tag = Convert.ToInt32(dgv_unit.Rows[e.RowIndex].Cells[0].Value);
            ckCat.Checked = (bool)dgv_unit.Rows[e.RowIndex].Cells[2].Value;
            //}
        }
        private void dgv_brand_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_brand_addnew.Text = "&Update";
            btn_brand_addnew.Image = global::AccountSystem.Properties.Resources.save_all;
            txt_brand.Enabled = true;
            //if (e.ColumnIndex == 1)
            //{
            txt_brand.Text = dgv_brand.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_brand.Tag = Convert.ToInt32(dgv_brand.Rows[e.RowIndex].Cells[0].Value);
            ckBrand.Checked = (bool)dgv_brand.Rows[e.RowIndex].Cells[2].Value;
            //}
        }
        private void dgv_pakg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_pakg_addnew.Text = "&Update";
            btn_pakg_addnew.Image = global::AccountSystem.Properties.Resources.save_all;
            txt_paking.Enabled = true;
            txt_pakg_no.Enabled = true;
            if (e.ColumnIndex == 1)
            {
                txt_paking.Text = dgv_pakg.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                txt_pakg_no.Text = dgv_pakg.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_paking.Tag = Convert.ToInt32(dgv_pakg.Rows[e.RowIndex].Cells[0].Value);
            }
        }
        private void btn_frmparameter_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgv_category_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgv_category.RowHeadersVisible = false;
            dgv_category.Columns[0].Visible = false;
            dgv_category.Columns[0].HeaderText = "ID";
            dgv_category.Columns[1].Width = 234;
            dgv_category.Columns[1].HeaderText = "Category Name";
            dgv_category.Columns[2].Width = 80;
            dgv_category.Columns[2].HeaderText = "Status";
        }
        private void dgv_unit_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgv_unit.RowHeadersVisible = false;
            dgv_unit.Columns[0].Visible = false;
            dgv_unit.Columns[1].Width = 234;
            dgv_unit.Columns[1].HeaderText = "Sub-Category";
            dgv_unit.Columns[2].Width = 80;
            dgv_unit.Columns[2].HeaderText = "Status";
        }
        private void dgv_brand_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgv_brand.RowHeadersVisible = false;
            dgv_brand.Columns[0].Visible = false;
            dgv_brand.Columns[1].Width = 234;
            dgv_brand.Columns[1].HeaderText = "Brand";
            dgv_brand.Columns[2].Width = 80;
            dgv_brand.Columns[2].HeaderText = "Status";
        }
        private void dgv_pakg_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgv_pakg.RowHeadersVisible = false;
            dgv_pakg.Columns[0].Visible = false;
            dgv_pakg.Columns[1].HeaderText = "Paking Name";
            dgv_pakg.Columns[2].HeaderText = "Number";
            dgv_pakg.Columns[1].Width = 160;
            dgv_pakg.Columns[2].Width = 160;
        }
        private void btn_str_adnw_Click(object sender, EventArgs e)
        {
            if (btn_str_adnw.Text == "&Add New")
            {
                btn_str_adnw.Text = "&Save";
                btn_str_adnw.Image = global::AccountSystem.Properties.Resources.save_all;
                txt_str_adrs.Enabled = true;
                txt_str_contact.Enabled = true;
                txt_str_name.Enabled = true;
                cbo_str_type.Enabled = true;
                txt_str_name.Focus();
            }
            else if (btn_str_adnw.Text == "&Save")
            {
                if (validationAddStorepage())
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "INSERT INTO tbl_Store (Str_name, Str_address, Str_type, Str_contact_no, Repli, Created, Modified)VALUES (@name,@address,@type,@contactno,@repli,@created,@modified)";
                    cmd.Parameters.AddWithValue("@name", txt_str_name.Text);
                    cmd.Parameters.AddWithValue("@address", txt_str_adrs.Text);
                    cmd.Parameters.AddWithValue("@type", cbo_str_type.Text);
                    cmd.Parameters.AddWithValue("@contactno", txt_str_contact.Text);
                    cmd.Parameters.AddWithValue("@repli", 0);
                    cmd.Parameters.AddWithValue("@created", DateTime.Now);
                    cmd.Parameters.AddWithValue("@modified", DateTime.Now);
                    fn.CmdExe(cmd);
                    Refreshallgrdvw();
                    btn_str_adnw.Text = "&Add New";
                    btn_str_adnw.Image = global::AccountSystem.Properties.Resources.add;
                    fn.ClearGroup(gbx_str);
                    txt_str_adrs.Enabled = false;
                    txt_str_contact.Enabled = false;
                    txt_str_name.Enabled = false;
                    cbo_str_type.Enabled = false;
                }
            }
            else if (btn_str_adnw.Text == "&Update")
            {
                if (validationAddStorepage())
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "UPDATE tbl_Store SET Str_name = @name, Str_address = @address, Str_contact_no = @contact, Str_type = @type,Repli=0 WHERE (Str_id = @id)";
                    cmd.Parameters.AddWithValue("@name", txt_str_name.Text);
                    cmd.Parameters.AddWithValue("@address", txt_str_adrs.Text);
                    cmd.Parameters.AddWithValue("@type", cbo_str_type.Text);
                    cmd.Parameters.AddWithValue("@contact", txt_str_contact.Text);
                    cmd.Parameters.AddWithValue("@id", txt_str_name.Tag);
                    fn.CmdExe(cmd);
                    Refreshallgrdvw();
                    btn_str_adnw.Text = "&Add New";
                    btn_str_adnw.Image = global::AccountSystem.Properties.Resources.add;
                    fn.ClearGroup(gbx_str);
                    fn.ClearGroup(grpStore);
                    txt_str_adrs.Enabled = false;
                    txt_str_contact.Enabled = false;
                    txt_str_name.Enabled = false;
                    cbo_str_type.Enabled = false;
                }
            }
        }
        private void btn_str_cancel_Click(object sender, EventArgs e)
        {
            fn.ClearGroup(grpStore);
            txt_str_adrs.Text = "";
            txt_str_contact.Text = "";
            txt_str_name.Text = "";
            cbo_str_type.Text = "";
            txt_str_adrs.Enabled = false;
            txt_str_contact.Enabled = false;
            txt_str_name.Enabled = false;
            cbo_str_type.Enabled = false;
            btn_str_adnw.Text = "&Add New";
            btn_str_adnw.Image = global::AccountSystem.Properties.Resources.add;
            fn.ClearAll(this);
        }
        private void dgv_str_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgv_str.RowHeadersVisible = false;
            dgv_str.Columns[1].Visible = false;
            dgv_str.Columns[0].HeaderText = "Store Name";
            dgv_str.Columns[2].Visible = false;
            dgv_str.Columns[3].Visible = false;
            dgv_str.Columns[4].Visible = false;
            dgv_str.Columns[0].Width = 110;
        }
        private void dgv_str_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_str_adnw.Text = "&Update";
            btn_str_adnw.Image = global::AccountSystem.Properties.Resources.save_all;
            txt_str_adrs.Enabled = true;
            txt_str_contact.Enabled = true;
            txt_str_name.Enabled = true;
            cbo_str_type.Enabled = true;
            if (e.ColumnIndex == 0)
            {
                txt_str_name.Tag = Convert.ToInt32(dgv_str.Rows[e.RowIndex].Cells[1].Value);
                txt_str_name.Text = dgv_str.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_str_adrs.Text = dgv_str.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbo_str_type.Text = dgv_str.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_str_contact.Text = dgv_str.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }
        private void tbl_Inv_SetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            comIDTextBox.Text = MyModule.CompID.ToString();
            repliCheckBox.Checked = false;
            this.Validate();
            this.tbl_Inv_SetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inv_Set_DS);
        }
        private void p_CatCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //tbl_Inv_SetBindingNavigatorSaveItem.PerformClick();
            if (p_CatCheckBox.Checked)
            {
                grpCat.Enabled = false;
            }
            else
            {
                grpCat.Enabled = true;
            }
        }
        private void p_BrandCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //tbl_Inv_SetBindingNavigatorSaveItem.PerformClick();
            if (p_BrandCheckBox.Checked)
            {
                grpBrand.Enabled = false;
            }
            else
            {
                grpBrand.Enabled = true;
            }
        }
        private void p_PackCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //tbl_Inv_SetBindingNavigatorSaveItem.PerformClick();
            if (p_PackCheckBox.Checked)
            {
                grpPaking.Enabled = false;
            }
            else
            {
                grpPaking.Enabled = true;
            }
        }
        private void storeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //tbl_Inv_SetBindingNavigatorSaveItem.PerformClick();
            if (storeCheckBox.Checked)
            {
                grpStore.Enabled = false;
            }
            else
            {
                grpStore.Enabled = true;
            }
        }
        private void exp_DateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //tbl_Inv_SetBindingNavigatorSaveItem.PerformClick();
        }
        private void Frm_parameters_FormClosing(object sender, FormClosingEventArgs e)
        {
            tbl_Inv_SetBindingNavigatorSaveItem.PerformClick();
        }
        private void ckSubCat_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}