namespace AccountSystem
{
    partial class frmInventorySettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventorySettings));
            this.dgv_category = new System.Windows.Forms.DataGridView();
            this.txt_category = new System.Windows.Forms.TextBox();
            this.dgv_unit = new System.Windows.Forms.DataGridView();
            this.txt_unit = new System.Windows.Forms.TextBox();
            this.dgv_brand = new System.Windows.Forms.DataGridView();
            this.txt_brand = new System.Windows.Forms.TextBox();
            this.txt_pakg_no = new System.Windows.Forms.TextBox();
            this.lbl_pkg_no = new System.Windows.Forms.Label();
            this.dgv_pakg = new System.Windows.Forms.DataGridView();
            this.txt_paking = new System.Windows.Forms.TextBox();
            this.gbx_str = new System.Windows.Forms.GroupBox();
            this.txt_str_name = new System.Windows.Forms.TextBox();
            this.lbl_str_name = new System.Windows.Forms.Label();
            this.cbo_str_type = new System.Windows.Forms.ComboBox();
            this.lbl_str_adrs = new System.Windows.Forms.Label();
            this.txt_str_contact = new System.Windows.Forms.TextBox();
            this.lbl_str_type = new System.Windows.Forms.Label();
            this.txt_str_adrs = new System.Windows.Forms.TextBox();
            this.lbl_str_contact = new System.Windows.Forms.Label();
            this.dgv_str = new System.Windows.Forms.DataGridView();
            this.tabcontrol_parameters = new DevExpress.XtraTab.XtraTabControl();
            this.page_prod_ctg = new DevExpress.XtraTab.XtraTabPage();
            this.ckSubCat = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.p_CatCheckBox = new System.Windows.Forms.CheckBox();
            this.tbl_Inv_SetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inv_Set_DS = new AccountSystem.Inv_Set_DS();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_category_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_addnew = new DevExpress.XtraEditors.SimpleButton();
            this.page_prod_unit = new DevExpress.XtraTab.XtraTabPage();
            this.ckCat = new System.Windows.Forms.CheckBox();
            this.btn_unit_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_unit_adnw = new DevExpress.XtraEditors.SimpleButton();
            this.page_prod_brand = new DevExpress.XtraTab.XtraTabPage();
            this.grpBrand = new System.Windows.Forms.GroupBox();
            this.ckBrand = new System.Windows.Forms.CheckBox();
            this.p_BrandCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_brand_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_brand_addnew = new DevExpress.XtraEditors.SimpleButton();
            this.page_prod_paking = new DevExpress.XtraTab.XtraTabPage();
            this.grpPaking = new System.Windows.Forms.GroupBox();
            this.p_PackCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btn_pakg_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_pakg_addnew = new DevExpress.XtraEditors.SimpleButton();
            this.lbl_paking = new System.Windows.Forms.Label();
            this.page_prod_addstore = new DevExpress.XtraTab.XtraTabPage();
            this.grpStore = new System.Windows.Forms.GroupBox();
            this.exp_DateCheckBox = new System.Windows.Forms.CheckBox();
            this.storeCheckBox = new System.Windows.Forms.CheckBox();
            this.btn_str_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_str_adnw = new DevExpress.XtraEditors.SimpleButton();
            this.tabSetup = new DevExpress.XtraTab.XtraTabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.grpCat = new System.Windows.Forms.GroupBox();
            this.btn_frmparameter_close = new DevExpress.XtraEditors.SimpleButton();
            this.tbl_Inv_SetTableAdapter = new AccountSystem.Inv_Set_DSTableAdapters.tbl_Inv_SetTableAdapter();
            this.tableAdapterManager = new AccountSystem.Inv_Set_DSTableAdapters.TableAdapterManager();
            this.tbl_Inv_SetBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbl_Inv_SetBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.comIDTextBox = new System.Windows.Forms.TextBox();
            this.repliCheckBox = new System.Windows.Forms.CheckBox();
            this.grpUnit = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_category)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_unit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_brand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pakg)).BeginInit();
            this.gbx_str.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_str)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabcontrol_parameters)).BeginInit();
            this.tabcontrol_parameters.SuspendLayout();
            this.page_prod_ctg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Inv_SetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv_Set_DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.page_prod_unit.SuspendLayout();
            this.page_prod_brand.SuspendLayout();
            this.grpBrand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.page_prod_paking.SuspendLayout();
            this.grpPaking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.page_prod_addstore.SuspendLayout();
            this.grpStore.SuspendLayout();
            this.tabSetup.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpCat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Inv_SetBindingNavigator)).BeginInit();
            this.tbl_Inv_SetBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_category
            // 
            this.dgv_category.AllowUserToAddRows = false;
            this.dgv_category.AllowUserToDeleteRows = false;
            this.dgv_category.AllowUserToResizeColumns = false;
            this.dgv_category.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_category.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_category.BackgroundColor = System.Drawing.Color.White;
            this.dgv_category.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_category.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_category.Location = new System.Drawing.Point(19, 49);
            this.dgv_category.Name = "dgv_category";
            this.dgv_category.ReadOnly = true;
            this.dgv_category.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_category.Size = new System.Drawing.Size(339, 296);
            this.dgv_category.TabIndex = 0;
            this.dgv_category.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_category_CellClick);
            this.dgv_category.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_category_CellContentClick);
            this.dgv_category.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_category_DataBindingComplete);
            // 
            // txt_category
            // 
            this.txt_category.Enabled = false;
            this.txt_category.Location = new System.Drawing.Point(19, 351);
            this.txt_category.Name = "txt_category";
            this.txt_category.Size = new System.Drawing.Size(234, 20);
            this.txt_category.TabIndex = 1;
            // 
            // dgv_unit
            // 
            this.dgv_unit.AllowUserToAddRows = false;
            this.dgv_unit.AllowUserToDeleteRows = false;
            this.dgv_unit.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_unit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_unit.BackgroundColor = System.Drawing.Color.White;
            this.dgv_unit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_unit.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_unit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_unit.Location = new System.Drawing.Point(17, 30);
            this.dgv_unit.Name = "dgv_unit";
            this.dgv_unit.ReadOnly = true;
            this.dgv_unit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_unit.Size = new System.Drawing.Size(339, 315);
            this.dgv_unit.TabIndex = 0;
            this.dgv_unit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_unit_CellClick);
            this.dgv_unit.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_unit_DataBindingComplete);
            // 
            // txt_unit
            // 
            this.txt_unit.Enabled = false;
            this.txt_unit.Location = new System.Drawing.Point(17, 352);
            this.txt_unit.Name = "txt_unit";
            this.txt_unit.Size = new System.Drawing.Size(234, 20);
            this.txt_unit.TabIndex = 1;
            // 
            // dgv_brand
            // 
            this.dgv_brand.AllowUserToAddRows = false;
            this.dgv_brand.AllowUserToDeleteRows = false;
            this.dgv_brand.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_brand.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_brand.BackgroundColor = System.Drawing.Color.White;
            this.dgv_brand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_brand.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_brand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_brand.Location = new System.Drawing.Point(10, 57);
            this.dgv_brand.Name = "dgv_brand";
            this.dgv_brand.ReadOnly = true;
            this.dgv_brand.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_brand.Size = new System.Drawing.Size(339, 287);
            this.dgv_brand.TabIndex = 0;
            this.dgv_brand.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_brand_CellClick);
            this.dgv_brand.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_brand_DataBindingComplete);
            // 
            // txt_brand
            // 
            this.txt_brand.Enabled = false;
            this.txt_brand.Location = new System.Drawing.Point(10, 350);
            this.txt_brand.Name = "txt_brand";
            this.txt_brand.Size = new System.Drawing.Size(234, 20);
            this.txt_brand.TabIndex = 1;
            // 
            // txt_pakg_no
            // 
            this.txt_pakg_no.Enabled = false;
            this.txt_pakg_no.Location = new System.Drawing.Point(280, 317);
            this.txt_pakg_no.Name = "txt_pakg_no";
            this.txt_pakg_no.Size = new System.Drawing.Size(75, 20);
            this.txt_pakg_no.TabIndex = 4;
            this.txt_pakg_no.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pakg_no_KeyPress);
            // 
            // lbl_pkg_no
            // 
            this.lbl_pkg_no.AutoSize = true;
            this.lbl_pkg_no.Location = new System.Drawing.Point(181, 320);
            this.lbl_pkg_no.Name = "lbl_pkg_no";
            this.lbl_pkg_no.Size = new System.Drawing.Size(93, 13);
            this.lbl_pkg_no.TabIndex = 3;
            this.lbl_pkg_no.Text = "Measurement Uint";
            // 
            // dgv_pakg
            // 
            this.dgv_pakg.AllowUserToAddRows = false;
            this.dgv_pakg.AllowUserToDeleteRows = false;
            this.dgv_pakg.AllowUserToResizeRows = false;
            this.dgv_pakg.BackgroundColor = System.Drawing.Color.White;
            this.dgv_pakg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_pakg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pakg.Location = new System.Drawing.Point(6, 40);
            this.dgv_pakg.Name = "dgv_pakg";
            this.dgv_pakg.ReadOnly = true;
            this.dgv_pakg.Size = new System.Drawing.Size(339, 271);
            this.dgv_pakg.TabIndex = 0;
            this.dgv_pakg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pakg_CellClick);
            this.dgv_pakg.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_pakg_DataBindingComplete);
            // 
            // txt_paking
            // 
            this.txt_paking.Enabled = false;
            this.txt_paking.Location = new System.Drawing.Point(54, 317);
            this.txt_paking.Name = "txt_paking";
            this.txt_paking.Size = new System.Drawing.Size(121, 20);
            this.txt_paking.TabIndex = 2;
            // 
            // gbx_str
            // 
            this.gbx_str.Controls.Add(this.txt_str_name);
            this.gbx_str.Controls.Add(this.lbl_str_name);
            this.gbx_str.Controls.Add(this.cbo_str_type);
            this.gbx_str.Controls.Add(this.lbl_str_adrs);
            this.gbx_str.Controls.Add(this.txt_str_contact);
            this.gbx_str.Controls.Add(this.lbl_str_type);
            this.gbx_str.Controls.Add(this.txt_str_adrs);
            this.gbx_str.Controls.Add(this.lbl_str_contact);
            this.gbx_str.Location = new System.Drawing.Point(178, 71);
            this.gbx_str.Name = "gbx_str";
            this.gbx_str.Size = new System.Drawing.Size(459, 159);
            this.gbx_str.TabIndex = 1;
            this.gbx_str.TabStop = false;
            // 
            // txt_str_name
            // 
            this.txt_str_name.Enabled = false;
            this.txt_str_name.Location = new System.Drawing.Point(75, 19);
            this.txt_str_name.Name = "txt_str_name";
            this.txt_str_name.Size = new System.Drawing.Size(179, 20);
            this.txt_str_name.TabIndex = 1;
            // 
            // lbl_str_name
            // 
            this.lbl_str_name.AutoSize = true;
            this.lbl_str_name.Location = new System.Drawing.Point(10, 26);
            this.lbl_str_name.Name = "lbl_str_name";
            this.lbl_str_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_str_name.TabIndex = 0;
            this.lbl_str_name.Text = "Name";
            // 
            // cbo_str_type
            // 
            this.cbo_str_type.Enabled = false;
            this.cbo_str_type.FormattingEnabled = true;
            this.cbo_str_type.Items.AddRange(new object[] {
            "Furniture",
            "Food",
            ""});
            this.cbo_str_type.Location = new System.Drawing.Point(75, 93);
            this.cbo_str_type.Name = "cbo_str_type";
            this.cbo_str_type.Size = new System.Drawing.Size(121, 21);
            this.cbo_str_type.TabIndex = 5;
            // 
            // lbl_str_adrs
            // 
            this.lbl_str_adrs.AutoSize = true;
            this.lbl_str_adrs.Location = new System.Drawing.Point(10, 48);
            this.lbl_str_adrs.Name = "lbl_str_adrs";
            this.lbl_str_adrs.Size = new System.Drawing.Size(48, 13);
            this.lbl_str_adrs.TabIndex = 2;
            this.lbl_str_adrs.Text = "Location";
            // 
            // txt_str_contact
            // 
            this.txt_str_contact.Enabled = false;
            this.txt_str_contact.Location = new System.Drawing.Point(75, 120);
            this.txt_str_contact.Name = "txt_str_contact";
            this.txt_str_contact.Size = new System.Drawing.Size(179, 20);
            this.txt_str_contact.TabIndex = 7;
            // 
            // lbl_str_type
            // 
            this.lbl_str_type.AutoSize = true;
            this.lbl_str_type.Location = new System.Drawing.Point(10, 96);
            this.lbl_str_type.Name = "lbl_str_type";
            this.lbl_str_type.Size = new System.Drawing.Size(31, 13);
            this.lbl_str_type.TabIndex = 4;
            this.lbl_str_type.Text = "Type";
            // 
            // txt_str_adrs
            // 
            this.txt_str_adrs.Enabled = false;
            this.txt_str_adrs.Location = new System.Drawing.Point(75, 45);
            this.txt_str_adrs.Name = "txt_str_adrs";
            this.txt_str_adrs.Size = new System.Drawing.Size(352, 20);
            this.txt_str_adrs.TabIndex = 3;
            // 
            // lbl_str_contact
            // 
            this.lbl_str_contact.AutoSize = true;
            this.lbl_str_contact.Location = new System.Drawing.Point(10, 123);
            this.lbl_str_contact.Name = "lbl_str_contact";
            this.lbl_str_contact.Size = new System.Drawing.Size(61, 13);
            this.lbl_str_contact.TabIndex = 6;
            this.lbl_str_contact.Text = "Contact No";
            // 
            // dgv_str
            // 
            this.dgv_str.AllowUserToAddRows = false;
            this.dgv_str.AllowUserToDeleteRows = false;
            this.dgv_str.AllowUserToResizeRows = false;
            this.dgv_str.BackgroundColor = System.Drawing.Color.White;
            this.dgv_str.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_str.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_str.Location = new System.Drawing.Point(21, 62);
            this.dgv_str.Name = "dgv_str";
            this.dgv_str.ReadOnly = true;
            this.dgv_str.Size = new System.Drawing.Size(130, 319);
            this.dgv_str.TabIndex = 0;
            this.dgv_str.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_str_CellClick);
            this.dgv_str.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_str_DataBindingComplete);
            // 
            // tabcontrol_parameters
            // 
            this.tabcontrol_parameters.AppearancePage.Header.Font = new System.Drawing.Font("Tahoma", 9F);
            this.tabcontrol_parameters.AppearancePage.Header.Options.UseFont = true;
            this.tabcontrol_parameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcontrol_parameters.Location = new System.Drawing.Point(0, 0);
            this.tabcontrol_parameters.Name = "tabcontrol_parameters";
            this.tabcontrol_parameters.SelectedTabPage = this.page_prod_ctg;
            this.tabcontrol_parameters.Size = new System.Drawing.Size(1174, 438);
            this.tabcontrol_parameters.TabIndex = 2;
            this.tabcontrol_parameters.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.page_prod_unit,
            this.page_prod_ctg,
            this.page_prod_brand,
            this.page_prod_paking,
            this.page_prod_addstore,
            this.tabSetup});
            // 
            // page_prod_ctg
            // 
            this.page_prod_ctg.Controls.Add(this.ckSubCat);
            this.page_prod_ctg.Controls.Add(this.label1);
            this.page_prod_ctg.Controls.Add(this.p_CatCheckBox);
            this.page_prod_ctg.Controls.Add(this.pictureBox1);
            this.page_prod_ctg.Controls.Add(this.btn_category_cancel);
            this.page_prod_ctg.Controls.Add(this.dgv_category);
            this.page_prod_ctg.Controls.Add(this.btn_addnew);
            this.page_prod_ctg.Controls.Add(this.txt_category);
            this.page_prod_ctg.Name = "page_prod_ctg";
            this.page_prod_ctg.Size = new System.Drawing.Size(1167, 408);
            this.page_prod_ctg.Text = "Category";
            // 
            // ckSubCat
            // 
            this.ckSubCat.AutoSize = true;
            this.ckSubCat.Location = new System.Drawing.Point(259, 353);
            this.ckSubCat.Name = "ckSubCat";
            this.ckSubCat.Size = new System.Drawing.Size(99, 17);
            this.ckSubCat.TabIndex = 34;
            this.ckSubCat.Text = "Active/Inactive";
            this.ckSubCat.UseVisualStyleBackColor = true;
            this.ckSubCat.CheckedChanged += new System.EventHandler(this.ckSubCat_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label1.Location = new System.Drawing.Point(376, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 96);
            this.label1.TabIndex = 32;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // p_CatCheckBox
            // 
            this.p_CatCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tbl_Inv_SetBindingSource, "P_Cat", true));
            this.p_CatCheckBox.Enabled = false;
            this.p_CatCheckBox.Location = new System.Drawing.Point(19, 19);
            this.p_CatCheckBox.Name = "p_CatCheckBox";
            this.p_CatCheckBox.Size = new System.Drawing.Size(202, 24);
            this.p_CatCheckBox.TabIndex = 33;
            this.p_CatCheckBox.Text = "Enable/Disable Categories.";
            this.p_CatCheckBox.UseVisualStyleBackColor = true;
            this.p_CatCheckBox.Visible = false;
            this.p_CatCheckBox.CheckedChanged += new System.EventHandler(this.p_CatCheckBox_CheckedChanged);
            // 
            // tbl_Inv_SetBindingSource
            // 
            this.tbl_Inv_SetBindingSource.DataMember = "tbl_Inv_Set";
            this.tbl_Inv_SetBindingSource.DataSource = this.inv_Set_DS;
            // 
            // inv_Set_DS
            // 
            this.inv_Set_DS.DataSetName = "Inv_Set_DS";
            this.inv_Set_DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(376, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 35);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // btn_category_cancel
            // 
            this.btn_category_cancel.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_category_cancel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_category_cancel.Appearance.Options.UseFont = true;
            this.btn_category_cancel.Appearance.Options.UseForeColor = true;
            this.btn_category_cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_category_cancel.Image")));
            this.btn_category_cancel.Location = new System.Drawing.Point(274, 380);
            this.btn_category_cancel.Name = "btn_category_cancel";
            this.btn_category_cancel.Size = new System.Drawing.Size(84, 23);
            this.btn_category_cancel.TabIndex = 29;
            this.btn_category_cancel.Text = "&Cancel";
            this.btn_category_cancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_addnew
            // 
            this.btn_addnew.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addnew.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btn_addnew.Appearance.Options.UseFont = true;
            this.btn_addnew.Appearance.Options.UseForeColor = true;
            this.btn_addnew.Image = global::AccountSystem.Properties.Resources.add;
            this.btn_addnew.Location = new System.Drawing.Point(184, 380);
            this.btn_addnew.Name = "btn_addnew";
            this.btn_addnew.Size = new System.Drawing.Size(84, 23);
            this.btn_addnew.TabIndex = 30;
            this.btn_addnew.Text = "&Add New";
            this.btn_addnew.Click += new System.EventHandler(this.btn_addnew_Click);
            // 
            // page_prod_unit
            // 
            this.page_prod_unit.Controls.Add(this.ckCat);
            this.page_prod_unit.Controls.Add(this.dgv_unit);
            this.page_prod_unit.Controls.Add(this.btn_unit_cancel);
            this.page_prod_unit.Controls.Add(this.txt_unit);
            this.page_prod_unit.Controls.Add(this.btn_unit_adnw);
            this.page_prod_unit.Name = "page_prod_unit";
            this.page_prod_unit.Size = new System.Drawing.Size(1167, 408);
            this.page_prod_unit.Text = "Measurement Units";
            // 
            // ckCat
            // 
            this.ckCat.AutoSize = true;
            this.ckCat.Location = new System.Drawing.Point(257, 354);
            this.ckCat.Name = "ckCat";
            this.ckCat.Size = new System.Drawing.Size(99, 17);
            this.ckCat.TabIndex = 37;
            this.ckCat.Text = "Active/Inactive";
            this.ckCat.UseVisualStyleBackColor = true;
            // 
            // btn_unit_cancel
            // 
            this.btn_unit_cancel.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_unit_cancel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_unit_cancel.Appearance.Options.UseFont = true;
            this.btn_unit_cancel.Appearance.Options.UseForeColor = true;
            this.btn_unit_cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_unit_cancel.Image")));
            this.btn_unit_cancel.Location = new System.Drawing.Point(272, 380);
            this.btn_unit_cancel.Name = "btn_unit_cancel";
            this.btn_unit_cancel.Size = new System.Drawing.Size(84, 23);
            this.btn_unit_cancel.TabIndex = 32;
            this.btn_unit_cancel.Text = "&Cancel";
            this.btn_unit_cancel.Click += new System.EventHandler(this.btn_unit_cancel_Click);
            // 
            // btn_unit_adnw
            // 
            this.btn_unit_adnw.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_unit_adnw.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btn_unit_adnw.Appearance.Options.UseFont = true;
            this.btn_unit_adnw.Appearance.Options.UseForeColor = true;
            this.btn_unit_adnw.Image = global::AccountSystem.Properties.Resources.add;
            this.btn_unit_adnw.Location = new System.Drawing.Point(182, 380);
            this.btn_unit_adnw.Name = "btn_unit_adnw";
            this.btn_unit_adnw.Size = new System.Drawing.Size(84, 23);
            this.btn_unit_adnw.TabIndex = 33;
            this.btn_unit_adnw.Text = "&Add New";
            this.btn_unit_adnw.Click += new System.EventHandler(this.btn_unit_adnw_Click);
            // 
            // page_prod_brand
            // 
            this.page_prod_brand.Controls.Add(this.grpBrand);
            this.page_prod_brand.Name = "page_prod_brand";
            this.page_prod_brand.Size = new System.Drawing.Size(1167, 408);
            this.page_prod_brand.Text = "Item Type";
            // 
            // grpBrand
            // 
            this.grpBrand.Controls.Add(this.ckBrand);
            this.grpBrand.Controls.Add(this.p_BrandCheckBox);
            this.grpBrand.Controls.Add(this.label3);
            this.grpBrand.Controls.Add(this.pictureBox3);
            this.grpBrand.Controls.Add(this.btn_brand_cancel);
            this.grpBrand.Controls.Add(this.btn_brand_addnew);
            this.grpBrand.Controls.Add(this.dgv_brand);
            this.grpBrand.Controls.Add(this.txt_brand);
            this.grpBrand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBrand.Location = new System.Drawing.Point(0, 0);
            this.grpBrand.Name = "grpBrand";
            this.grpBrand.Size = new System.Drawing.Size(1167, 408);
            this.grpBrand.TabIndex = 3;
            this.grpBrand.TabStop = false;
            // 
            // ckBrand
            // 
            this.ckBrand.AutoSize = true;
            this.ckBrand.Location = new System.Drawing.Point(250, 352);
            this.ckBrand.Name = "ckBrand";
            this.ckBrand.Size = new System.Drawing.Size(99, 17);
            this.ckBrand.TabIndex = 39;
            this.ckBrand.Text = "Active/Inactive";
            this.ckBrand.UseVisualStyleBackColor = true;
            // 
            // p_BrandCheckBox
            // 
            this.p_BrandCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tbl_Inv_SetBindingSource, "P_Brand", true));
            this.p_BrandCheckBox.Enabled = false;
            this.p_BrandCheckBox.Location = new System.Drawing.Point(10, 19);
            this.p_BrandCheckBox.Name = "p_BrandCheckBox";
            this.p_BrandCheckBox.Size = new System.Drawing.Size(170, 24);
            this.p_BrandCheckBox.TabIndex = 38;
            this.p_BrandCheckBox.Text = "Enable/Disable Branding.";
            this.p_BrandCheckBox.UseVisualStyleBackColor = true;
            this.p_BrandCheckBox.Visible = false;
            this.p_BrandCheckBox.CheckedChanged += new System.EventHandler(this.p_BrandCheckBox_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label3.Location = new System.Drawing.Point(364, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 32);
            this.label3.TabIndex = 37;
            this.label3.Text = "Brand is the personality that identifies \r\na product, service or company.";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(364, 57);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 35);
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            // 
            // btn_brand_cancel
            // 
            this.btn_brand_cancel.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_brand_cancel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_brand_cancel.Appearance.Options.UseFont = true;
            this.btn_brand_cancel.Appearance.Options.UseForeColor = true;
            this.btn_brand_cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_brand_cancel.Image")));
            this.btn_brand_cancel.Location = new System.Drawing.Point(266, 378);
            this.btn_brand_cancel.Name = "btn_brand_cancel";
            this.btn_brand_cancel.Size = new System.Drawing.Size(84, 23);
            this.btn_brand_cancel.TabIndex = 34;
            this.btn_brand_cancel.Text = "&Cancel";
            this.btn_brand_cancel.Click += new System.EventHandler(this.btn_brand_cancel_Click);
            // 
            // btn_brand_addnew
            // 
            this.btn_brand_addnew.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_brand_addnew.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btn_brand_addnew.Appearance.Options.UseFont = true;
            this.btn_brand_addnew.Appearance.Options.UseForeColor = true;
            this.btn_brand_addnew.Image = global::AccountSystem.Properties.Resources.add;
            this.btn_brand_addnew.Location = new System.Drawing.Point(176, 378);
            this.btn_brand_addnew.Name = "btn_brand_addnew";
            this.btn_brand_addnew.Size = new System.Drawing.Size(84, 23);
            this.btn_brand_addnew.TabIndex = 35;
            this.btn_brand_addnew.Text = "&Add New";
            this.btn_brand_addnew.Click += new System.EventHandler(this.btn_brand_addnew_Click);
            // 
            // page_prod_paking
            // 
            this.page_prod_paking.Controls.Add(this.grpPaking);
            this.page_prod_paking.Name = "page_prod_paking";
            this.page_prod_paking.PageVisible = false;
            this.page_prod_paking.Size = new System.Drawing.Size(1167, 408);
            this.page_prod_paking.Text = "Product Packaging";
            // 
            // grpPaking
            // 
            this.grpPaking.Controls.Add(this.p_PackCheckBox);
            this.grpPaking.Controls.Add(this.label4);
            this.grpPaking.Controls.Add(this.pictureBox4);
            this.grpPaking.Controls.Add(this.btn_pakg_cancel);
            this.grpPaking.Controls.Add(this.btn_pakg_addnew);
            this.grpPaking.Controls.Add(this.txt_pakg_no);
            this.grpPaking.Controls.Add(this.dgv_pakg);
            this.grpPaking.Controls.Add(this.lbl_pkg_no);
            this.grpPaking.Controls.Add(this.lbl_paking);
            this.grpPaking.Controls.Add(this.txt_paking);
            this.grpPaking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPaking.Location = new System.Drawing.Point(0, 0);
            this.grpPaking.Name = "grpPaking";
            this.grpPaking.Size = new System.Drawing.Size(1167, 408);
            this.grpPaking.TabIndex = 3;
            this.grpPaking.TabStop = false;
            // 
            // p_PackCheckBox
            // 
            this.p_PackCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tbl_Inv_SetBindingSource, "P_Pack", true));
            this.p_PackCheckBox.Location = new System.Drawing.Point(6, 10);
            this.p_PackCheckBox.Name = "p_PackCheckBox";
            this.p_PackCheckBox.Size = new System.Drawing.Size(188, 24);
            this.p_PackCheckBox.TabIndex = 40;
            this.p_PackCheckBox.Text = "Enable/Disable Packaging.";
            this.p_PackCheckBox.UseVisualStyleBackColor = true;
            this.p_PackCheckBox.CheckedChanged += new System.EventHandler(this.p_PackCheckBox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label4.Location = new System.Drawing.Point(363, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 48);
            this.label4.TabIndex = 39;
            this.label4.Text = "Set packaging with measurement unit \r\nto calculate quantity of product quickly. \r" +
    "\ne.g Dozen (x12)";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(363, 51);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(34, 35);
            this.pictureBox4.TabIndex = 38;
            this.pictureBox4.TabStop = false;
            // 
            // btn_pakg_cancel
            // 
            this.btn_pakg_cancel.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pakg_cancel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_pakg_cancel.Appearance.Options.UseFont = true;
            this.btn_pakg_cancel.Appearance.Options.UseForeColor = true;
            this.btn_pakg_cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_pakg_cancel.Image")));
            this.btn_pakg_cancel.Location = new System.Drawing.Point(261, 357);
            this.btn_pakg_cancel.Name = "btn_pakg_cancel";
            this.btn_pakg_cancel.Size = new System.Drawing.Size(84, 23);
            this.btn_pakg_cancel.TabIndex = 36;
            this.btn_pakg_cancel.Text = "&Cancel";
            this.btn_pakg_cancel.Click += new System.EventHandler(this.btn_pakg_cancel_Click);
            // 
            // btn_pakg_addnew
            // 
            this.btn_pakg_addnew.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pakg_addnew.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btn_pakg_addnew.Appearance.Options.UseFont = true;
            this.btn_pakg_addnew.Appearance.Options.UseForeColor = true;
            this.btn_pakg_addnew.Image = global::AccountSystem.Properties.Resources.add;
            this.btn_pakg_addnew.Location = new System.Drawing.Point(171, 357);
            this.btn_pakg_addnew.Name = "btn_pakg_addnew";
            this.btn_pakg_addnew.Size = new System.Drawing.Size(84, 23);
            this.btn_pakg_addnew.TabIndex = 37;
            this.btn_pakg_addnew.Text = "&Add New";
            this.btn_pakg_addnew.Click += new System.EventHandler(this.btn_pakg_addnew_Click);
            // 
            // lbl_paking
            // 
            this.lbl_paking.AutoSize = true;
            this.lbl_paking.Location = new System.Drawing.Point(6, 320);
            this.lbl_paking.Name = "lbl_paking";
            this.lbl_paking.Size = new System.Drawing.Size(46, 13);
            this.lbl_paking.TabIndex = 1;
            this.lbl_paking.Text = "Packing";
            // 
            // page_prod_addstore
            // 
            this.page_prod_addstore.AutoScroll = true;
            this.page_prod_addstore.Controls.Add(this.grpStore);
            this.page_prod_addstore.Name = "page_prod_addstore";
            this.page_prod_addstore.PageVisible = false;
            this.page_prod_addstore.Size = new System.Drawing.Size(1167, 408);
            this.page_prod_addstore.Text = "Add Store";
            // 
            // grpStore
            // 
            this.grpStore.Controls.Add(this.exp_DateCheckBox);
            this.grpStore.Controls.Add(this.storeCheckBox);
            this.grpStore.Controls.Add(this.btn_str_cancel);
            this.grpStore.Controls.Add(this.btn_str_adnw);
            this.grpStore.Controls.Add(this.gbx_str);
            this.grpStore.Controls.Add(this.dgv_str);
            this.grpStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpStore.Location = new System.Drawing.Point(0, 0);
            this.grpStore.Name = "grpStore";
            this.grpStore.Size = new System.Drawing.Size(1167, 408);
            this.grpStore.TabIndex = 3;
            this.grpStore.TabStop = false;
            // 
            // exp_DateCheckBox
            // 
            this.exp_DateCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tbl_Inv_SetBindingSource, "Exp_Date", true));
            this.exp_DateCheckBox.Location = new System.Drawing.Point(21, 13);
            this.exp_DateCheckBox.Name = "exp_DateCheckBox";
            this.exp_DateCheckBox.Size = new System.Drawing.Size(220, 21);
            this.exp_DateCheckBox.TabIndex = 10;
            this.exp_DateCheckBox.Text = "Use Expiry/Best before Date for product.";
            this.exp_DateCheckBox.UseVisualStyleBackColor = true;
            this.exp_DateCheckBox.CheckedChanged += new System.EventHandler(this.exp_DateCheckBox_CheckedChanged);
            // 
            // storeCheckBox
            // 
            this.storeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tbl_Inv_SetBindingSource, "Store", true));
            this.storeCheckBox.Location = new System.Drawing.Point(21, 30);
            this.storeCheckBox.Name = "storeCheckBox";
            this.storeCheckBox.Size = new System.Drawing.Size(167, 24);
            this.storeCheckBox.TabIndex = 9;
            this.storeCheckBox.Text = "Use Stores for stock.";
            this.storeCheckBox.UseVisualStyleBackColor = true;
            this.storeCheckBox.CheckedChanged += new System.EventHandler(this.storeCheckBox_CheckedChanged);
            // 
            // btn_str_cancel
            // 
            this.btn_str_cancel.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_str_cancel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_str_cancel.Appearance.Options.UseFont = true;
            this.btn_str_cancel.Appearance.Options.UseForeColor = true;
            this.btn_str_cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_str_cancel.Image")));
            this.btn_str_cancel.Location = new System.Drawing.Point(555, 261);
            this.btn_str_cancel.Name = "btn_str_cancel";
            this.btn_str_cancel.Size = new System.Drawing.Size(84, 23);
            this.btn_str_cancel.TabIndex = 38;
            this.btn_str_cancel.Text = "&Cancel";
            this.btn_str_cancel.Click += new System.EventHandler(this.btn_str_cancel_Click);
            // 
            // btn_str_adnw
            // 
            this.btn_str_adnw.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_str_adnw.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btn_str_adnw.Appearance.Options.UseFont = true;
            this.btn_str_adnw.Appearance.Options.UseForeColor = true;
            this.btn_str_adnw.Image = global::AccountSystem.Properties.Resources.add;
            this.btn_str_adnw.Location = new System.Drawing.Point(465, 261);
            this.btn_str_adnw.Name = "btn_str_adnw";
            this.btn_str_adnw.Size = new System.Drawing.Size(84, 23);
            this.btn_str_adnw.TabIndex = 39;
            this.btn_str_adnw.Text = "&Add New";
            this.btn_str_adnw.Click += new System.EventHandler(this.btn_str_adnw_Click);
            // 
            // tabSetup
            // 
            this.tabSetup.Controls.Add(this.groupBox2);
            this.tabSetup.Controls.Add(this.groupBox1);
            this.tabSetup.Name = "tabSetup";
            this.tabSetup.PageVisible = false;
            this.tabSetup.Size = new System.Drawing.Size(1167, 408);
            this.tabSetup.Text = "Entery Forms Setup";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox7);
            this.groupBox2.Controls.Add(this.checkBox5);
            this.groupBox2.Controls.Add(this.checkBox6);
            this.groupBox2.Location = new System.Drawing.Point(21, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(591, 181);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sale Invoice";
            // 
            // checkBox4
            // 
            this.checkBox4.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tbl_Inv_SetBindingSource, "S_Bns_Schm", true));
            this.checkBox4.Location = new System.Drawing.Point(15, 24);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(399, 27);
            this.checkBox4.TabIndex = 13;
            this.checkBox4.Text = "Remove Bones/Scheme column from sale form";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tbl_Inv_SetBindingSource, "S_Dist", true));
            this.checkBox3.Location = new System.Drawing.Point(15, 51);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(399, 27);
            this.checkBox3.TabIndex = 14;
            this.checkBox3.Text = "Remove Discount column from sale form";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tbl_Inv_SetBindingSource, "S_Salesman", true));
            this.checkBox7.Location = new System.Drawing.Point(15, 132);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(399, 27);
            this.checkBox7.TabIndex = 17;
            this.checkBox7.Text = "Remove Salesman from sale form";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tbl_Inv_SetBindingSource, "S_SPDist", true));
            this.checkBox5.Location = new System.Drawing.Point(15, 78);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(399, 27);
            this.checkBox5.TabIndex = 15;
            this.checkBox5.Text = "Remove Special Discount column from sale form";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tbl_Inv_SetBindingSource, "S_Remarks", true));
            this.checkBox6.Location = new System.Drawing.Point(15, 105);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(399, 27);
            this.checkBox6.TabIndex = 16;
            this.checkBox6.Text = "Remove Product Description column from sale form";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Location = new System.Drawing.Point(21, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 100);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Goods Receipt Note (GRN)";
            // 
            // checkBox1
            // 
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tbl_Inv_SetBindingSource, "P_Bns_Schm", true));
            this.checkBox1.Location = new System.Drawing.Point(15, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(399, 27);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Remove Bones/Scheme column from purchase form";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tbl_Inv_SetBindingSource, "P_Dist", true));
            this.checkBox2.Location = new System.Drawing.Point(15, 48);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(399, 27);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.Text = "Remove Discount column from purchase form";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // grpCat
            // 
            this.grpCat.Controls.Add(this.btn_frmparameter_close);
            this.grpCat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpCat.Location = new System.Drawing.Point(0, 438);
            this.grpCat.Name = "grpCat";
            this.grpCat.Size = new System.Drawing.Size(1174, 37);
            this.grpCat.TabIndex = 3;
            this.grpCat.TabStop = false;
            // 
            // btn_frmparameter_close
            // 
            this.btn_frmparameter_close.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_frmparameter_close.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_frmparameter_close.Appearance.Options.UseFont = true;
            this.btn_frmparameter_close.Appearance.Options.UseForeColor = true;
            this.btn_frmparameter_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_frmparameter_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_frmparameter_close.Image")));
            this.btn_frmparameter_close.Location = new System.Drawing.Point(523, 9);
            this.btn_frmparameter_close.Name = "btn_frmparameter_close";
            this.btn_frmparameter_close.Size = new System.Drawing.Size(71, 23);
            this.btn_frmparameter_close.TabIndex = 31;
            this.btn_frmparameter_close.Text = "&Close";
            this.btn_frmparameter_close.Click += new System.EventHandler(this.btn_frmparameter_close_Click);
            // 
            // tbl_Inv_SetTableAdapter
            // 
            this.tbl_Inv_SetTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_Inv_SetTableAdapter = this.tbl_Inv_SetTableAdapter;
            this.tableAdapterManager.UpdateOrder = AccountSystem.Inv_Set_DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_Inv_SetBindingNavigator
            // 
            this.tbl_Inv_SetBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbl_Inv_SetBindingNavigator.BindingSource = this.tbl_Inv_SetBindingSource;
            this.tbl_Inv_SetBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbl_Inv_SetBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbl_Inv_SetBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.tbl_Inv_SetBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tbl_Inv_SetBindingNavigatorSaveItem});
            this.tbl_Inv_SetBindingNavigator.Location = new System.Drawing.Point(172, 306);
            this.tbl_Inv_SetBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbl_Inv_SetBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbl_Inv_SetBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbl_Inv_SetBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbl_Inv_SetBindingNavigator.Name = "tbl_Inv_SetBindingNavigator";
            this.tbl_Inv_SetBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbl_Inv_SetBindingNavigator.Size = new System.Drawing.Size(278, 25);
            this.tbl_Inv_SetBindingNavigator.TabIndex = 32;
            this.tbl_Inv_SetBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tbl_Inv_SetBindingNavigatorSaveItem
            // 
            this.tbl_Inv_SetBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbl_Inv_SetBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbl_Inv_SetBindingNavigatorSaveItem.Image")));
            this.tbl_Inv_SetBindingNavigatorSaveItem.Name = "tbl_Inv_SetBindingNavigatorSaveItem";
            this.tbl_Inv_SetBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tbl_Inv_SetBindingNavigatorSaveItem.Text = "Save Data";
            this.tbl_Inv_SetBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbl_Inv_SetBindingNavigatorSaveItem_Click);
            // 
            // comIDTextBox
            // 
            this.comIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_Inv_SetBindingSource, "ComID", true));
            this.comIDTextBox.Location = new System.Drawing.Point(23, 315);
            this.comIDTextBox.Name = "comIDTextBox";
            this.comIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.comIDTextBox.TabIndex = 33;
            // 
            // repliCheckBox
            // 
            this.repliCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tbl_Inv_SetBindingSource, "Repli", true));
            this.repliCheckBox.Location = new System.Drawing.Point(422, 285);
            this.repliCheckBox.Name = "repliCheckBox";
            this.repliCheckBox.Size = new System.Drawing.Size(104, 24);
            this.repliCheckBox.TabIndex = 34;
            this.repliCheckBox.Text = "checkBox1";
            this.repliCheckBox.UseVisualStyleBackColor = true;
            // 
            // grpUnit
            // 
            this.grpUnit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpUnit.Location = new System.Drawing.Point(0, 475);
            this.grpUnit.Name = "grpUnit";
            this.grpUnit.Size = new System.Drawing.Size(1174, 14);
            this.grpUnit.TabIndex = 3;
            this.grpUnit.TabStop = false;
            // 
            // frmInventorySettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_frmparameter_close;
            this.ClientSize = new System.Drawing.Size(1174, 489);
            this.Controls.Add(this.tabcontrol_parameters);
            this.Controls.Add(this.tbl_Inv_SetBindingNavigator);
            this.Controls.Add(this.grpCat);
            this.Controls.Add(this.comIDTextBox);
            this.Controls.Add(this.repliCheckBox);
            this.Controls.Add(this.grpUnit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInventorySettings";
            this.Text = "Product Prerequisite";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_parameters_FormClosing);
            this.Load += new System.EventHandler(this.Frm_parameters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_category)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_unit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_brand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pakg)).EndInit();
            this.gbx_str.ResumeLayout(false);
            this.gbx_str.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_str)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabcontrol_parameters)).EndInit();
            this.tabcontrol_parameters.ResumeLayout(false);
            this.page_prod_ctg.ResumeLayout(false);
            this.page_prod_ctg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Inv_SetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv_Set_DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.page_prod_unit.ResumeLayout(false);
            this.page_prod_unit.PerformLayout();
            this.page_prod_brand.ResumeLayout(false);
            this.grpBrand.ResumeLayout(false);
            this.grpBrand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.page_prod_paking.ResumeLayout(false);
            this.grpPaking.ResumeLayout(false);
            this.grpPaking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.page_prod_addstore.ResumeLayout(false);
            this.grpStore.ResumeLayout(false);
            this.tabSetup.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.grpCat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Inv_SetBindingNavigator)).EndInit();
            this.tbl_Inv_SetBindingNavigator.ResumeLayout(false);
            this.tbl_Inv_SetBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_category;
        private System.Windows.Forms.DataGridView dgv_category;
        private System.Windows.Forms.DataGridView dgv_unit;
        private System.Windows.Forms.TextBox txt_unit;
        private System.Windows.Forms.DataGridView dgv_brand;
        private System.Windows.Forms.TextBox txt_brand;
        private System.Windows.Forms.DataGridView dgv_pakg;
        private System.Windows.Forms.TextBox txt_paking;
        private System.Windows.Forms.TextBox txt_pakg_no;
        private System.Windows.Forms.Label lbl_pkg_no;
        private System.Windows.Forms.DataGridView dgv_str;
        private System.Windows.Forms.Label lbl_str_contact;
        private System.Windows.Forms.Label lbl_str_type;
        private System.Windows.Forms.Label lbl_str_adrs;
        private System.Windows.Forms.Label lbl_str_name;
        private System.Windows.Forms.ComboBox cbo_str_type;
        private System.Windows.Forms.TextBox txt_str_contact;
        private System.Windows.Forms.TextBox txt_str_adrs;
        private System.Windows.Forms.TextBox txt_str_name;
        private System.Windows.Forms.GroupBox gbx_str;
        private DevExpress.XtraTab.XtraTabControl tabcontrol_parameters;
        private DevExpress.XtraTab.XtraTabPage page_prod_ctg;
        private DevExpress.XtraTab.XtraTabPage page_prod_unit;
        private DevExpress.XtraTab.XtraTabPage page_prod_brand;
        private DevExpress.XtraTab.XtraTabPage page_prod_paking;
        private DevExpress.XtraTab.XtraTabPage page_prod_addstore;
        private System.Windows.Forms.GroupBox grpCat;
        internal DevExpress.XtraEditors.SimpleButton btn_category_cancel;
        internal DevExpress.XtraEditors.SimpleButton btn_addnew;
        internal DevExpress.XtraEditors.SimpleButton btn_unit_cancel;
        internal DevExpress.XtraEditors.SimpleButton btn_unit_adnw;
        internal DevExpress.XtraEditors.SimpleButton btn_brand_cancel;
        internal DevExpress.XtraEditors.SimpleButton btn_brand_addnew;
        internal DevExpress.XtraEditors.SimpleButton btn_frmparameter_close;
        internal DevExpress.XtraEditors.SimpleButton btn_pakg_cancel;
        internal DevExpress.XtraEditors.SimpleButton btn_pakg_addnew;
        internal DevExpress.XtraEditors.SimpleButton btn_str_cancel;
        internal DevExpress.XtraEditors.SimpleButton btn_str_adnw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Inv_Set_DS inv_Set_DS;
        private System.Windows.Forms.BindingSource tbl_Inv_SetBindingSource;
        private Inv_Set_DSTableAdapters.tbl_Inv_SetTableAdapter tbl_Inv_SetTableAdapter;
        private Inv_Set_DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbl_Inv_SetBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tbl_Inv_SetBindingNavigatorSaveItem;
        private System.Windows.Forms.CheckBox p_CatCheckBox;
        private System.Windows.Forms.TextBox comIDTextBox;
        private System.Windows.Forms.CheckBox p_BrandCheckBox;
        private System.Windows.Forms.CheckBox p_PackCheckBox;
        private System.Windows.Forms.CheckBox storeCheckBox;
        private System.Windows.Forms.CheckBox exp_DateCheckBox;
        private System.Windows.Forms.CheckBox repliCheckBox;
        private DevExpress.XtraTab.XtraTabPage tabSetup;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpUnit;
        private System.Windows.Forms.GroupBox grpBrand;
        private System.Windows.Forms.GroupBox grpPaking;
        private System.Windows.Forms.Label lbl_paking;
        private System.Windows.Forms.GroupBox grpStore;
        private System.Windows.Forms.CheckBox ckSubCat;
        private System.Windows.Forms.CheckBox ckCat;
        private System.Windows.Forms.CheckBox ckBrand;
    }
}

