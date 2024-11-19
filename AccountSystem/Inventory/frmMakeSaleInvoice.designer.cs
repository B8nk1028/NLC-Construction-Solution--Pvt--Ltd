namespace AccountSystem
{
    partial class frmMakeSaleInvoice
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
            System.Windows.Forms.Label label9;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMakeSaleInvoice));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.cboVendor = new System.Windows.Forms.ComboBox();
            this.sOHeadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new AccountSystem.DataSet1();
            this.label4 = new System.Windows.Forms.Label();
            this.dtTrxDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_prchse_date = new System.Windows.Forms.Label();
            this.lbl_prchse_bill_no = new System.Windows.Forms.Label();
            this.txtTrxNo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtInvoicNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.InvoiceTag = new DevExpress.XtraEditors.CalcEdit();
            this.txtBF = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtGatePass = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtDeliveryChNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cboPayTerms = new System.Windows.Forms.ComboBox();
            this.cboStores = new System.Windows.Forms.ComboBox();
            this.cbLocation = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress = new DevExpress.XtraEditors.LabelControl();
            this.cboSalesman = new System.Windows.Forms.ComboBox();
            this.grdBill = new System.Windows.Forms.DataGridView();
            this.gdv_prod_name = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Prchse_prod_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtxtremaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtInvoiced = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prchse_prod_rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prchse_Prod_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchDet_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiced = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x = new System.Windows.Forms.DataGridViewImageColumn();
            this.gtxtPRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodrateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disctDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodqtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleDetidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packingDetailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remaings = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOHeadSODetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sODetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtLodingUnLoad = new DevExpress.XtraEditors.CalcEdit();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.textNetTotal = new System.Windows.Forms.TextBox();
            this.txtCarriage = new System.Windows.Forms.TextBox();
            this.btnGen = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnDiscard = new DevExpress.XtraEditors.SimpleButton();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.txtBilti = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTransport = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtShip = new System.Windows.Forms.DateTimePicker();
            this.cboCity = new SergeUtils.EasyCompletionComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblSCreated = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.lblModify = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.sOHeadTableAdapter = new AccountSystem.DataSet1TableAdapters.SOHeadTableAdapter();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sODetailsTableAdapter = new AccountSystem.DataSet1TableAdapters.SODetailsTableAdapter();
            this.tableAdapterManager = new AccountSystem.DataSet1TableAdapters.TableAdapterManager();
            label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sOHeadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceTag.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOHeadSODetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sODetailsBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLodingUnLoad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(641, 41);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(85, 13);
            label9.TabIndex = 5;
            label9.Text = "Stock Location :";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(578, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(411, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Generate Sale Invoice";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cboVendor
            // 
            this.cboVendor.BackColor = System.Drawing.SystemColors.Window;
            this.cboVendor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sOHeadBindingSource, "Contact_id", true));
            this.cboVendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVendor.Enabled = false;
            this.cboVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVendor.FormattingEnabled = true;
            this.cboVendor.Location = new System.Drawing.Point(8, 25);
            this.cboVendor.Name = "cboVendor";
            this.cboVendor.Size = new System.Drawing.Size(342, 21);
            this.cboVendor.TabIndex = 2;
            this.cboVendor.SelectedIndexChanged += new System.EventHandler(this.cbo_vendor_SelectedIndexChanged);
            // 
            // sOHeadBindingSource
            // 
            this.sOHeadBindingSource.DataMember = "SOHead";
            this.sOHeadBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(5, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Customer";
            // 
            // dtTrxDate
            // 
            this.dtTrxDate.CustomFormat = "ddMMMMyyyy";
            this.dtTrxDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.sOHeadBindingSource, "Sale_date", true));
            this.dtTrxDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTrxDate.Location = new System.Drawing.Point(852, 147);
            this.dtTrxDate.Name = "dtTrxDate";
            this.dtTrxDate.Size = new System.Drawing.Size(137, 20);
            this.dtTrxDate.TabIndex = 15;
            // 
            // lbl_prchse_date
            // 
            this.lbl_prchse_date.AutoSize = true;
            this.lbl_prchse_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbl_prchse_date.Location = new System.Drawing.Point(812, 151);
            this.lbl_prchse_date.Name = "lbl_prchse_date";
            this.lbl_prchse_date.Size = new System.Drawing.Size(34, 13);
            this.lbl_prchse_date.TabIndex = 14;
            this.lbl_prchse_date.Text = "Date";
            // 
            // lbl_prchse_bill_no
            // 
            this.lbl_prchse_bill_no.AutoSize = true;
            this.lbl_prchse_bill_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbl_prchse_bill_no.Location = new System.Drawing.Point(800, 126);
            this.lbl_prchse_bill_no.Name = "lbl_prchse_bill_no";
            this.lbl_prchse_bill_no.Size = new System.Drawing.Size(79, 13);
            this.lbl_prchse_bill_no.TabIndex = 12;
            this.lbl_prchse_bill_no.Text = "Sale Order #";
            // 
            // txtTrxNo
            // 
            this.txtTrxNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sOHeadBindingSource, "Sale_bill_no", true));
            this.txtTrxNo.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.sOHeadBindingSource, "Sale_id", true));
            this.txtTrxNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrxNo.Location = new System.Drawing.Point(888, 122);
            this.txtTrxNo.Name = "txtTrxNo";
            this.txtTrxNo.ReadOnly = true;
            this.txtTrxNo.Size = new System.Drawing.Size(101, 20);
            this.txtTrxNo.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.txtInvoicNo);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label29);
            this.panel1.Controls.Add(this.InvoiceTag);
            this.panel1.Controls.Add(this.txtBF);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txtGatePass);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.txtDeliveryChNo);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.cboPayTerms);
            this.panel1.Controls.Add(this.cboStores);
            this.panel1.Controls.Add(label9);
            this.panel1.Controls.Add(this.cbLocation);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTrxNo);
            this.panel1.Controls.Add(this.dtTrxDate);
            this.panel1.Controls.Add(this.lbl_prchse_date);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.cboSalesman);
            this.panel1.Controls.Add(this.lbl_prchse_bill_no);
            this.panel1.Controls.Add(this.cboVendor);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 174);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtInvoicNo
            // 
            this.txtInvoicNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoicNo.Location = new System.Drawing.Point(77, 119);
            this.txtInvoicNo.Name = "txtInvoicNo";
            this.txtInvoicNo.ReadOnly = true;
            this.txtInvoicNo.Size = new System.Drawing.Size(101, 20);
            this.txtInvoicNo.TabIndex = 86;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(8, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 85;
            this.label8.Text = "Invoice #";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label29.Location = new System.Drawing.Point(867, 78);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(62, 13);
            this.label29.TabIndex = 84;
            this.label29.Text = "Invoice %";
            // 
            // InvoiceTag
            // 
            this.InvoiceTag.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sOHeadBindingSource, "InvoiceTag", true));
            this.InvoiceTag.EditValue = new decimal(new int[] {
            65,
            0,
            0,
            0});
            this.InvoiceTag.Location = new System.Drawing.Point(931, 75);
            this.InvoiceTag.Name = "InvoiceTag";
            this.InvoiceTag.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.InvoiceTag.Properties.Appearance.Options.UseFont = true;
            this.InvoiceTag.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.InvoiceTag.Size = new System.Drawing.Size(58, 19);
            this.InvoiceTag.TabIndex = 83;
            // 
            // txtBF
            // 
            this.txtBF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBF.Location = new System.Drawing.Point(359, 25);
            this.txtBF.Name = "txtBF";
            this.txtBF.ReadOnly = true;
            this.txtBF.Size = new System.Drawing.Size(113, 20);
            this.txtBF.TabIndex = 82;
            this.txtBF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(356, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 13);
            this.label14.TabIndex = 81;
            this.label14.Text = "Brought Forward";
            // 
            // txtGatePass
            // 
            this.txtGatePass.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sOHeadBindingSource, "BilltyNo", true));
            this.txtGatePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGatePass.Location = new System.Drawing.Point(888, 98);
            this.txtGatePass.Name = "txtGatePass";
            this.txtGatePass.Size = new System.Drawing.Size(101, 20);
            this.txtGatePass.TabIndex = 66;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label28.Location = new System.Drawing.Point(799, 102);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(83, 13);
            this.label28.TabIndex = 65;
            this.label28.Text = "Gate Outward #";
            // 
            // txtDeliveryChNo
            // 
            this.txtDeliveryChNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeliveryChNo.Location = new System.Drawing.Point(715, 11);
            this.txtDeliveryChNo.Name = "txtDeliveryChNo";
            this.txtDeliveryChNo.Size = new System.Drawing.Size(101, 20);
            this.txtDeliveryChNo.TabIndex = 64;
            this.txtDeliveryChNo.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(608, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 63;
            this.label7.Text = "Delivery Order #";
            this.label7.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(324, 151);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 13);
            this.label13.TabIndex = 45;
            this.label13.Text = "Terms of Payment";
            // 
            // cboPayTerms
            // 
            this.cboPayTerms.BackColor = System.Drawing.SystemColors.Window;
            this.cboPayTerms.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sOHeadBindingSource, "PaymentTermsID", true));
            this.cboPayTerms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPayTerms.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPayTerms.FormattingEnabled = true;
            this.cboPayTerms.Location = new System.Drawing.Point(436, 147);
            this.cboPayTerms.Name = "cboPayTerms";
            this.cboPayTerms.Size = new System.Drawing.Size(191, 21);
            this.cboPayTerms.TabIndex = 46;
            // 
            // cboStores
            // 
            this.cboStores.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sOHeadBindingSource, "StoreID", true));
            this.cboStores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStores.Enabled = false;
            this.cboStores.FormattingEnabled = true;
            this.cboStores.Location = new System.Drawing.Point(730, 37);
            this.cboStores.Name = "cboStores";
            this.cboStores.Size = new System.Drawing.Size(259, 21);
            this.cboStores.TabIndex = 6;
            // 
            // cbLocation
            // 
            this.cbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.Location = new System.Drawing.Point(822, 9);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(52, 21);
            this.cbLocation.TabIndex = 7;
            this.cbLocation.Visible = false;
            this.cbLocation.SelectedIndexChanged += new System.EventHandler(this.cbLocation_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(7, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Salesman";
            // 
            // txtAddress
            // 
            this.txtAddress.AllowHtmlString = true;
            this.txtAddress.Location = new System.Drawing.Point(13, 53);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(8, 14);
            this.txtAddress.TabIndex = 4;
            this.txtAddress.Text = "..";
            // 
            // cboSalesman
            // 
            this.cboSalesman.BackColor = System.Drawing.SystemColors.Window;
            this.cboSalesman.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sOHeadBindingSource, "Salesman", true));
            this.cboSalesman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSalesman.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSalesman.FormattingEnabled = true;
            this.cboSalesman.Location = new System.Drawing.Point(77, 147);
            this.cboSalesman.Name = "cboSalesman";
            this.cboSalesman.Size = new System.Drawing.Size(233, 21);
            this.cboSalesman.TabIndex = 0;
            // 
            // grdBill
            // 
            this.grdBill.AllowUserToAddRows = false;
            this.grdBill.AllowUserToDeleteRows = false;
            this.grdBill.AllowUserToResizeColumns = false;
            this.grdBill.AllowUserToResizeRows = false;
            this.grdBill.AutoGenerateColumns = false;
            this.grdBill.BackgroundColor = System.Drawing.Color.White;
            this.grdBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdBill.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.grdBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gdv_prod_name,
            this.Prchse_prod_qty,
            this.gtxtremaining,
            this.txtInvoiced,
            this.prchse_prod_rate,
            this.GAmount,
            this.GST,
            this.Discount,
            this.Prchse_Prod_Amount,
            this.PurchDet_id,
            this.colInvoiced,
            this.x,
            this.gtxtPRate,
            this.prodrateDataGridViewTextBoxColumn,
            this.disctDataGridViewTextBoxColumn,
            this.prodidDataGridViewTextBoxColumn,
            this.prodqtyDataGridViewTextBoxColumn,
            this.saleDetidDataGridViewTextBoxColumn,
            this.saleidDataGridViewTextBoxColumn,
            this.packingDetailDataGridViewTextBoxColumn,
            this.pRateDataGridViewTextBoxColumn,
            this.Remaings});
            this.grdBill.DataSource = this.sOHeadSODetailsBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdBill.DefaultCellStyle = dataGridViewCellStyle8;
            this.grdBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdBill.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grdBill.EnableHeadersVisualStyles = false;
            this.grdBill.GridColor = System.Drawing.SystemColors.Control;
            this.grdBill.Location = new System.Drawing.Point(0, 174);
            this.grdBill.Name = "grdBill";
            this.grdBill.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdBill.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.grdBill.RowHeadersVisible = false;
            this.grdBill.Size = new System.Drawing.Size(1040, 260);
            this.grdBill.TabIndex = 1;
            this.grdBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBill_CellClick);
            this.grdBill.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdBill_CellFormatting);
            this.grdBill.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdBill_CellMouseMove);
            this.grdBill.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBill_CellValueChanged);
            // 
            // gdv_prod_name
            // 
            this.gdv_prod_name.DataPropertyName = "prod_id";
            this.gdv_prod_name.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.gdv_prod_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gdv_prod_name.HeaderText = "Product Name";
            this.gdv_prod_name.Name = "gdv_prod_name";
            this.gdv_prod_name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gdv_prod_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.gdv_prod_name.Width = 250;
            // 
            // Prchse_prod_qty
            // 
            this.Prchse_prod_qty.DataPropertyName = "prod_qty";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.Prchse_prod_qty.DefaultCellStyle = dataGridViewCellStyle2;
            this.Prchse_prod_qty.HeaderText = "Order QTY";
            this.Prchse_prod_qty.Name = "Prchse_prod_qty";
            this.Prchse_prod_qty.ReadOnly = true;
            this.Prchse_prod_qty.Width = 70;
            // 
            // gtxtremaining
            // 
            this.gtxtremaining.DataPropertyName = "remainingInv";
            this.gtxtremaining.HeaderText = "Dispatched QTY";
            this.gtxtremaining.Name = "gtxtremaining";
            this.gtxtremaining.ReadOnly = true;
            // 
            // txtInvoiced
            // 
            this.txtInvoiced.HeaderText = "Invoice QTY";
            this.txtInvoiced.Name = "txtInvoiced";
            this.txtInvoiced.Width = 70;
            // 
            // prchse_prod_rate
            // 
            this.prchse_prod_rate.DataPropertyName = "Prod_rate";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.prchse_prod_rate.DefaultCellStyle = dataGridViewCellStyle3;
            this.prchse_prod_rate.HeaderText = "Rate";
            this.prchse_prod_rate.Name = "prchse_prod_rate";
            // 
            // GAmount
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.GAmount.DefaultCellStyle = dataGridViewCellStyle4;
            this.GAmount.HeaderText = "Gross Amount";
            this.GAmount.Name = "GAmount";
            this.GAmount.ReadOnly = true;
            // 
            // GST
            // 
            this.GST.DataPropertyName = "GST";
            this.GST.HeaderText = "GST %";
            this.GST.Name = "GST";
            // 
            // Discount
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.Discount.DefaultCellStyle = dataGridViewCellStyle5;
            this.Discount.HeaderText = "Tax Amount";
            this.Discount.Name = "Discount";
            // 
            // Prchse_Prod_Amount
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.Prchse_Prod_Amount.DefaultCellStyle = dataGridViewCellStyle6;
            this.Prchse_Prod_Amount.HeaderText = "Net Amount";
            this.Prchse_Prod_Amount.Name = "Prchse_Prod_Amount";
            this.Prchse_Prod_Amount.ReadOnly = true;
            // 
            // PurchDet_id
            // 
            this.PurchDet_id.DataPropertyName = "SaleDet_id";
            this.PurchDet_id.HeaderText = "ID";
            this.PurchDet_id.Name = "PurchDet_id";
            this.PurchDet_id.ReadOnly = true;
            this.PurchDet_id.Visible = false;
            this.PurchDet_id.Width = 5;
            // 
            // colInvoiced
            // 
            this.colInvoiced.DataPropertyName = "Invoiced";
            this.colInvoiced.HeaderText = "Invoice Act";
            this.colInvoiced.Name = "colInvoiced";
            this.colInvoiced.ReadOnly = true;
            this.colInvoiced.Visible = false;
            // 
            // x
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.NullValue = "My.Resources.Resources.close";
            this.x.DefaultCellStyle = dataGridViewCellStyle7;
            this.x.HeaderText = "";
            this.x.Image = global::AccountSystem.Properties.Resources.close;
            this.x.Name = "x";
            this.x.ReadOnly = true;
            this.x.Visible = false;
            this.x.Width = 30;
            // 
            // gtxtPRate
            // 
            this.gtxtPRate.DataPropertyName = "PRate";
            this.gtxtPRate.HeaderText = "gtxtPRate";
            this.gtxtPRate.Name = "gtxtPRate";
            this.gtxtPRate.ReadOnly = true;
            this.gtxtPRate.Visible = false;
            // 
            // prodrateDataGridViewTextBoxColumn
            // 
            this.prodrateDataGridViewTextBoxColumn.DataPropertyName = "Prod_rate";
            this.prodrateDataGridViewTextBoxColumn.HeaderText = "Prod_rate";
            this.prodrateDataGridViewTextBoxColumn.Name = "prodrateDataGridViewTextBoxColumn";
            this.prodrateDataGridViewTextBoxColumn.Visible = false;
            // 
            // disctDataGridViewTextBoxColumn
            // 
            this.disctDataGridViewTextBoxColumn.DataPropertyName = "Disct";
            this.disctDataGridViewTextBoxColumn.HeaderText = "Disct";
            this.disctDataGridViewTextBoxColumn.Name = "disctDataGridViewTextBoxColumn";
            this.disctDataGridViewTextBoxColumn.Visible = false;
            // 
            // prodidDataGridViewTextBoxColumn
            // 
            this.prodidDataGridViewTextBoxColumn.DataPropertyName = "prod_id";
            this.prodidDataGridViewTextBoxColumn.HeaderText = "prod_id";
            this.prodidDataGridViewTextBoxColumn.Name = "prodidDataGridViewTextBoxColumn";
            this.prodidDataGridViewTextBoxColumn.Visible = false;
            // 
            // prodqtyDataGridViewTextBoxColumn
            // 
            this.prodqtyDataGridViewTextBoxColumn.DataPropertyName = "prod_qty";
            this.prodqtyDataGridViewTextBoxColumn.HeaderText = "prod_qty";
            this.prodqtyDataGridViewTextBoxColumn.Name = "prodqtyDataGridViewTextBoxColumn";
            this.prodqtyDataGridViewTextBoxColumn.Visible = false;
            // 
            // saleDetidDataGridViewTextBoxColumn
            // 
            this.saleDetidDataGridViewTextBoxColumn.DataPropertyName = "SaleDet_id";
            this.saleDetidDataGridViewTextBoxColumn.HeaderText = "SaleDet_id";
            this.saleDetidDataGridViewTextBoxColumn.Name = "saleDetidDataGridViewTextBoxColumn";
            this.saleDetidDataGridViewTextBoxColumn.ReadOnly = true;
            this.saleDetidDataGridViewTextBoxColumn.Visible = false;
            // 
            // saleidDataGridViewTextBoxColumn
            // 
            this.saleidDataGridViewTextBoxColumn.DataPropertyName = "Sale_id";
            this.saleidDataGridViewTextBoxColumn.HeaderText = "Sale_id";
            this.saleidDataGridViewTextBoxColumn.Name = "saleidDataGridViewTextBoxColumn";
            this.saleidDataGridViewTextBoxColumn.Visible = false;
            // 
            // packingDetailDataGridViewTextBoxColumn
            // 
            this.packingDetailDataGridViewTextBoxColumn.DataPropertyName = "PackingDetail";
            this.packingDetailDataGridViewTextBoxColumn.HeaderText = "PackingDetail";
            this.packingDetailDataGridViewTextBoxColumn.Name = "packingDetailDataGridViewTextBoxColumn";
            this.packingDetailDataGridViewTextBoxColumn.Visible = false;
            // 
            // pRateDataGridViewTextBoxColumn
            // 
            this.pRateDataGridViewTextBoxColumn.DataPropertyName = "PRate";
            this.pRateDataGridViewTextBoxColumn.HeaderText = "PRate";
            this.pRateDataGridViewTextBoxColumn.Name = "pRateDataGridViewTextBoxColumn";
            this.pRateDataGridViewTextBoxColumn.Visible = false;
            // 
            // Remaings
            // 
            this.Remaings.DataPropertyName = "remaining";
            this.Remaings.HeaderText = "Remaings";
            this.Remaings.Name = "Remaings";
            this.Remaings.ReadOnly = true;
            this.Remaings.Visible = false;
            // 
            // sOHeadSODetailsBindingSource
            // 
            this.sOHeadSODetailsBindingSource.DataMember = "SOHead_SODetails";
            this.sOHeadSODetailsBindingSource.DataSource = this.sOHeadBindingSource;
            // 
            // sODetailsBindingSource
            // 
            this.sODetailsBindingSource.DataMember = "SODetails";
            this.sODetailsBindingSource.DataSource = this.dataSet1;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(862, 7);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(127, 20);
            this.txtTotal.TabIndex = 5;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtCarriage_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.label27);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.txtLodingUnLoad);
            this.panel2.Controls.Add(this.txtBalance);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Controls.Add(this.textNetTotal);
            this.panel2.Controls.Add(this.txtCarriage);
            this.panel2.Controls.Add(this.btnGen);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnAddNew);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnDiscard);
            this.panel2.Controls.Add(this.cboStatus);
            this.panel2.Controls.Add(this.txtTotal);
            this.panel2.Controls.Add(this.txtBilti);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtTransport);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dtShip);
            this.panel2.Controls.Add(this.cboCity);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.lblSCreated);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtRemarks);
            this.panel2.Controls.Add(this.lblModify);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 434);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1040, 165);
            this.panel2.TabIndex = 2;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label27.Location = new System.Drawing.Point(556, 60);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(298, 13);
            this.label27.TabIndex = 87;
            this.label27.Text = "Loading/ungloading/Packeting of dispatch material";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(726, 84);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(128, 13);
            this.label19.TabIndex = 86;
            this.label19.Text = "Total Invoice Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(746, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 85;
            this.label1.Text = "Carriage && Freight";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(750, 11);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(104, 13);
            this.label16.TabIndex = 84;
            this.label16.Text = "Sales Incl. S.Tax";
            // 
            // txtLodingUnLoad
            // 
            this.txtLodingUnLoad.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sOHeadBindingSource, "Loading", true));
            this.txtLodingUnLoad.Location = new System.Drawing.Point(862, 57);
            this.txtLodingUnLoad.Name = "txtLodingUnLoad";
            this.txtLodingUnLoad.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtLodingUnLoad.Properties.Appearance.Options.UseFont = true;
            this.txtLodingUnLoad.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtLodingUnLoad.Size = new System.Drawing.Size(127, 19);
            this.txtLodingUnLoad.TabIndex = 83;
            this.txtLodingUnLoad.EditValueChanged += new System.EventHandler(this.txtCarriage_TextChanged);
            // 
            // txtBalance
            // 
            this.txtBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.Location = new System.Drawing.Point(862, 103);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(127, 20);
            this.txtBalance.TabIndex = 82;
            this.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(801, 107);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 13);
            this.label15.TabIndex = 81;
            this.label15.Text = "Balance";
            // 
            // btnPrint
            // 
            this.btnPrint.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.Appearance.Options.UseForeColor = true;
            this.btnPrint.Enabled = false;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(724, 130);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(119, 23);
            this.btnPrint.TabIndex = 80;
            this.btnPrint.Text = "&Print Sale Invoice";
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // textNetTotal
            // 
            this.textNetTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNetTotal.Location = new System.Drawing.Point(862, 80);
            this.textNetTotal.Name = "textNetTotal";
            this.textNetTotal.ReadOnly = true;
            this.textNetTotal.Size = new System.Drawing.Size(127, 20);
            this.textNetTotal.TabIndex = 77;
            this.textNetTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCarriage
            // 
            this.txtCarriage.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sOHeadBindingSource, "CarriageFreight", true));
            this.txtCarriage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarriage.Location = new System.Drawing.Point(862, 31);
            this.txtCarriage.Name = "txtCarriage";
            this.txtCarriage.Size = new System.Drawing.Size(127, 20);
            this.txtCarriage.TabIndex = 75;
            this.txtCarriage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCarriage.TextChanged += new System.EventHandler(this.txtCarriage_TextChanged);
            // 
            // btnGen
            // 
            this.btnGen.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGen.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnGen.Appearance.Options.UseFont = true;
            this.btnGen.Appearance.Options.UseForeColor = true;
            this.btnGen.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.sOHeadBindingSource, "Sale_id", true));
            this.btnGen.Image = ((System.Drawing.Image)(resources.GetObject("btnGen.Image")));
            this.btnGen.Location = new System.Drawing.Point(848, 130);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(142, 23);
            this.btnGen.TabIndex = 16;
            this.btnGen.Text = "&Generate Sale Invoice";
            this.btnGen.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClose
            // 
            this.btnClose.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.Appearance.Options.UseForeColor = true;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(953, 18);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(84, 23);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "&Close";
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Appearance.ForeColor = System.Drawing.Color.Green;
            this.btnAddNew.Appearance.Options.UseFont = true;
            this.btnAddNew.Appearance.Options.UseForeColor = true;
            this.btnAddNew.Image = global::AccountSystem.Properties.Resources.add;
            this.btnAddNew.Location = new System.Drawing.Point(634, 130);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(84, 23);
            this.btnAddNew.TabIndex = 14;
            this.btnAddNew.Text = "&Add New";
            this.btnAddNew.Visible = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Appearance.Options.UseForeColor = true;
            this.btnSave.Image = global::AccountSystem.Properties.Resources.save_all;
            this.btnSave.Location = new System.Drawing.Point(1008, 64);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 23);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "&Save";
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.pOHeadBindingNavigatorSaveItem_Click);
            // 
            // btnDiscard
            // 
            this.btnDiscard.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscard.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnDiscard.Appearance.Options.UseFont = true;
            this.btnDiscard.Appearance.Options.UseForeColor = true;
            this.btnDiscard.Image = global::AccountSystem.Properties.Resources.close;
            this.btnDiscard.Location = new System.Drawing.Point(1008, 91);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDiscard.Size = new System.Drawing.Size(84, 23);
            this.btnDiscard.TabIndex = 15;
            this.btnDiscard.Text = "&Discard";
            this.btnDiscard.Visible = false;
            this.btnDiscard.Click += new System.EventHandler(this.btnDiscard_Click);
            // 
            // cboStatus
            // 
            this.cboStatus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sOHeadBindingSource, "OrderStatus", true));
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.Enabled = false;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Ordered",
            "On Ship",
            "Removed",
            "Invoiced"});
            this.cboStatus.Location = new System.Drawing.Point(945, 91);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(57, 21);
            this.cboStatus.TabIndex = 58;
            this.cboStatus.Visible = false;
            // 
            // txtBilti
            // 
            this.txtBilti.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sOHeadBindingSource, "BilltyNo", true));
            this.txtBilti.Location = new System.Drawing.Point(527, 41);
            this.txtBilti.Name = "txtBilti";
            this.txtBilti.Size = new System.Drawing.Size(100, 20);
            this.txtBilti.TabIndex = 9;
            this.txtBilti.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label12.Location = new System.Drawing.Point(449, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Shipping Date";
            this.label12.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label10.Location = new System.Drawing.Point(490, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Bilti #";
            this.label10.Visible = false;
            // 
            // txtTransport
            // 
            this.txtTransport.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sOHeadBindingSource, "Transport", true));
            this.txtTransport.Location = new System.Drawing.Point(86, 8);
            this.txtTransport.Name = "txtTransport";
            this.txtTransport.Size = new System.Drawing.Size(143, 20);
            this.txtTransport.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(8, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Vehicle #";
            // 
            // dtShip
            // 
            this.dtShip.CustomFormat = "ddMMMMyyyy";
            this.dtShip.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.sOHeadBindingSource, "BilltyDT", true));
            this.dtShip.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtShip.Location = new System.Drawing.Point(527, 67);
            this.dtShip.Name = "dtShip";
            this.dtShip.Size = new System.Drawing.Size(136, 20);
            this.dtShip.TabIndex = 12;
            this.dtShip.Visible = false;
            // 
            // cboCity
            // 
            this.cboCity.BackColor = System.Drawing.SystemColors.Window;
            this.cboCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sOHeadBindingSource, "ToShip", true));
            this.cboCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCity.FormattingEnabled = true;
            this.cboCity.Location = new System.Drawing.Point(86, 32);
            this.cboCity.Name = "cboCity";
            this.cboCity.Size = new System.Drawing.Size(215, 21);
            this.cboCity.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label11.Location = new System.Drawing.Point(8, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "To Loction";
            // 
            // lblSCreated
            // 
            this.lblSCreated.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sOHeadBindingSource, "Created", true));
            this.lblSCreated.Location = new System.Drawing.Point(7, 103);
            this.lblSCreated.Name = "lblSCreated";
            this.lblSCreated.Size = new System.Drawing.Size(423, 20);
            this.lblSCreated.TabIndex = 10;
            this.lblSCreated.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(8, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Remarks";
            // 
            // txtRemarks
            // 
            this.txtRemarks.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sOHeadBindingSource, "Remarks", true));
            this.txtRemarks.Location = new System.Drawing.Point(86, 61);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(425, 36);
            this.txtRemarks.TabIndex = 4;
            // 
            // lblModify
            // 
            this.lblModify.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sOHeadBindingSource, "Modifed", true));
            this.lblModify.Location = new System.Drawing.Point(7, 123);
            this.lblModify.Name = "lblModify";
            this.lblModify.Size = new System.Drawing.Size(496, 20);
            this.lblModify.TabIndex = 13;
            this.lblModify.Text = "...";
            this.lblModify.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.NullValue = "My.Resources.Resources.close";
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::AccountSystem.Properties.Resources.close;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 30;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle11.Format = "N2";
            dataGridViewCellStyle11.NullValue = null;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTextBoxColumn1.HeaderText = "Rate";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 70;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Gross Amount";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Discount Amount";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewCellStyle12.Format = "N2";
            dataGridViewCellStyle12.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewTextBoxColumn5.HeaderText = "Net Amount";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            this.dataGridViewTextBoxColumn6.Width = 5;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Window;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.DataSource = this.sOHeadBindingSource;
            this.listBox1.DisplayMember = "SaleOrder";
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(194, 571);
            this.listBox1.TabIndex = 0;
            this.listBox1.ValueMember = "Sale_id";
            // 
            // sOHeadTableAdapter
            // 
            this.sOHeadTableAdapter.ClearBeforeFill = true;
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // dockPanel1
            // 
            this.dockPanel1.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.dockPanel1.Appearance.BackColor2 = System.Drawing.SystemColors.Window;
            this.dockPanel1.Appearance.Options.UseBackColor = true;
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel1.ID = new System.Guid("14c9ba6c-1704-4f2a-a31c-934ed8101efb");
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.Options.ShowCloseButton = false;
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel1.Size = new System.Drawing.Size(200, 599);
            this.dockPanel1.TabText = "Sale Order";
            this.dockPanel1.Text = "Sale Order";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.listBox1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 25);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(194, 571);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grdBill);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1040, 599);
            this.panel3.TabIndex = 44;
            // 
            // sODetailsTableAdapter
            // 
            this.sODetailsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PODetails1TableAdapter = null;
            this.tableAdapterManager.PODetails2TableAdapter = null;
            this.tableAdapterManager.PODetailsTableAdapter = null;
            this.tableAdapterManager.POHead1TableAdapter = null;
            this.tableAdapterManager.POHead2TableAdapter = null;
            this.tableAdapterManager.POHeadTableAdapter = null;
            this.tableAdapterManager.PurchaseRTNDetailTableAdapter = null;
            this.tableAdapterManager.PurchaseRTNHeadTableAdapter = null;
            this.tableAdapterManager.SaleRetrunDetailsTableAdapter = null;
            this.tableAdapterManager.SaleRetrunHeadTableAdapter = null;
            this.tableAdapterManager.SODetails1TableAdapter = null;
            this.tableAdapterManager.SODetailsTableAdapter = this.sODetailsTableAdapter;
            this.tableAdapterManager.SOHead1TableAdapter = null;
            this.tableAdapterManager.SOHeadTableAdapter = this.sOHeadTableAdapter;
            this.tableAdapterManager.UpdateOrder = AccountSystem.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmMakeSaleInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1240, 599);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dockPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMakeSaleInvoice";
            this.Text = "Generate Sale Invoice";
            this.Load += new System.EventHandler(this.frmPurchaseOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sOHeadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceTag.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOHeadSODetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sODetailsBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLodingUnLoad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboVendor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtTrxDate;
        private System.Windows.Forms.Label lbl_prchse_date;
        private System.Windows.Forms.Label lbl_prchse_bill_no;
        public System.Windows.Forms.TextBox txtTrxNo;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView grdBill;
        public System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DevExpress.XtraEditors.LabelControl txtAddress;
        internal DevExpress.XtraEditors.SimpleButton btnGen;
        internal DevExpress.XtraEditors.SimpleButton btnClose;
        internal DevExpress.XtraEditors.SimpleButton btnSave;
        internal DevExpress.XtraEditors.SimpleButton btnAddNew;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.ListBox listBox1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboSalesman;
        private System.Windows.Forms.BindingSource sOHeadBindingSource;
        private DataSet1TableAdapters.SOHeadTableAdapter sOHeadTableAdapter;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label lblModify;
        private System.Windows.Forms.Label lblSCreated;
        private System.Windows.Forms.ComboBox cbLocation;
        private System.Windows.Forms.TextBox txtBilti;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTransport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtShip;
        private SergeUtils.EasyCompletionComboBox cboCity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource sODetailsBindingSource;
        private DataSet1TableAdapters.SODetailsTableAdapter sODetailsTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource sOHeadSODetailsBindingSource;
        private System.Windows.Forms.ComboBox cboStores;
        internal DevExpress.XtraEditors.SimpleButton btnDiscard;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboPayTerms;
        public System.Windows.Forms.TextBox txtGatePass;
        private System.Windows.Forms.Label label28;
        public System.Windows.Forms.TextBox txtDeliveryChNo;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox textNetTotal;
        public System.Windows.Forms.TextBox txtCarriage;
        internal DevExpress.XtraEditors.SimpleButton btnPrint;
        public System.Windows.Forms.TextBox txtBF;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label15;
        private DevExpress.XtraEditors.CalcEdit txtLodingUnLoad;
        private System.Windows.Forms.DataGridViewComboBoxColumn gdv_prod_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prchse_prod_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtxtremaining;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtInvoiced;
        private System.Windows.Forms.DataGridViewTextBoxColumn prchse_prod_rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn GAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn GST;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prchse_Prod_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchDet_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiced;
        private System.Windows.Forms.DataGridViewImageColumn x;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtxtPRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodrateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn disctDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodqtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleDetidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packingDetailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remaings;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label29;
        private DevExpress.XtraEditors.CalcEdit InvoiceTag;
        public System.Windows.Forms.TextBox txtInvoicNo;
        private System.Windows.Forms.Label label8;
    }
}

