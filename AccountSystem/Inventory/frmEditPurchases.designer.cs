namespace AccountSystem
{
    partial class frmEditPurchases
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
            System.Windows.Forms.Label label20;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditPurchases));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.cboVendor = new System.Windows.Forms.ComboBox();
            this.purchaseRTNHeadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new AccountSystem.DataSet1();
            this.label4 = new System.Windows.Forms.Label();
            this.dtTrxDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_prchse_date = new System.Windows.Forms.Label();
            this.lbl_prchse_bill_no = new System.Windows.Forms.Label();
            this.txtTrxNo = new System.Windows.Forms.TextBox();
            this.grdBill = new System.Windows.Forms.DataGridView();
            this.gdv_prod_name = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Descr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prchse_prod_rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prchse_prod_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prchse_Prod_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchDet_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x = new System.Windows.Forms.DataGridViewImageColumn();
            this.prodidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodqtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodrateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disctDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchDetidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseRTNDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddress = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.txtCheque = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAddDisc = new System.Windows.Forms.TextBox();
            this.textNetTotal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.label10 = new System.Windows.Forms.Label();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.txtGTotal = new System.Windows.Forms.TextBox();
            this.txtTransport = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCarriage = new System.Windows.Forms.TextBox();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tableAdapterManager = new AccountSystem.DataSet1TableAdapters.TableAdapterManager();
            this.purchaseRTNDetailTableAdapter = new AccountSystem.DataSet1TableAdapters.PurchaseRTNDetailTableAdapter();
            this.purchaseRTNHeadTableAdapter = new AccountSystem.DataSet1TableAdapters.PurchaseRTNHeadTableAdapter();
            this.txtVInvoice = new System.Windows.Forms.TextBox();
            this.dtVinvDT = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtComInv = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cboStores = new System.Windows.Forms.ComboBox();
            this.cbLocation = new System.Windows.Forms.ComboBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.searchToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            label20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseRTNHeadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseRTNDetailBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            this.fillToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new System.Drawing.Point(403, 80);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(85, 13);
            label20.TabIndex = 64;
            label20.Text = "Stock Location :";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(527, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Edit Purchases";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cboVendor
            // 
            this.cboVendor.BackColor = System.Drawing.Color.White;
            this.cboVendor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.purchaseRTNHeadBindingSource, "Contact_id", true));
            this.cboVendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVendor.FormattingEnabled = true;
            this.cboVendor.Location = new System.Drawing.Point(3, 19);
            this.cboVendor.Name = "cboVendor";
            this.cboVendor.Size = new System.Drawing.Size(363, 21);
            this.cboVendor.TabIndex = 9;
            this.cboVendor.SelectedIndexChanged += new System.EventHandler(this.cbo_vendor_SelectedIndexChanged);
            // 
            // purchaseRTNHeadBindingSource
            // 
            this.purchaseRTNHeadBindingSource.DataMember = "PurchaseRTNHead";
            this.purchaseRTNHeadBindingSource.DataSource = this.dataSet1;
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
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Vendor Name";
            // 
            // dtTrxDate
            // 
            this.dtTrxDate.CustomFormat = "ddMMMMyyyy";
            this.dtTrxDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.purchaseRTNHeadBindingSource, "Purch_date", true));
            this.dtTrxDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTrxDate.Location = new System.Drawing.Point(614, 53);
            this.dtTrxDate.Name = "dtTrxDate";
            this.dtTrxDate.Size = new System.Drawing.Size(137, 20);
            this.dtTrxDate.TabIndex = 20;
            this.dtTrxDate.Enter += new System.EventHandler(this.dtTrxDate_Enter);
            // 
            // lbl_prchse_date
            // 
            this.lbl_prchse_date.AutoSize = true;
            this.lbl_prchse_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbl_prchse_date.Location = new System.Drawing.Point(493, 57);
            this.lbl_prchse_date.Name = "lbl_prchse_date";
            this.lbl_prchse_date.Size = new System.Drawing.Size(116, 13);
            this.lbl_prchse_date.TabIndex = 18;
            this.lbl_prchse_date.Text = "Purchase Invoice Date";
            // 
            // lbl_prchse_bill_no
            // 
            this.lbl_prchse_bill_no.AutoSize = true;
            this.lbl_prchse_bill_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbl_prchse_bill_no.Location = new System.Drawing.Point(546, 36);
            this.lbl_prchse_bill_no.Name = "lbl_prchse_bill_no";
            this.lbl_prchse_bill_no.Size = new System.Drawing.Size(100, 13);
            this.lbl_prchse_bill_no.TabIndex = 19;
            this.lbl_prchse_bill_no.Text = "Purchase Invoice #";
            // 
            // txtTrxNo
            // 
            this.txtTrxNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseRTNHeadBindingSource, "Purch_bill_no", true));
            this.txtTrxNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrxNo.Location = new System.Drawing.Point(650, 32);
            this.txtTrxNo.Name = "txtTrxNo";
            this.txtTrxNo.ReadOnly = true;
            this.txtTrxNo.Size = new System.Drawing.Size(101, 20);
            this.txtTrxNo.TabIndex = 21;
            this.txtTrxNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grdBill
            // 
            this.grdBill.AllowUserToResizeColumns = false;
            this.grdBill.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grdBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdBill.AutoGenerateColumns = false;
            this.grdBill.BackgroundColor = System.Drawing.Color.White;
            this.grdBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdBill.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.grdBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gdv_prod_name,
            this.Descr,
            this.prchse_prod_rate,
            this.Prchse_prod_qty,
            this.GAmount,
            this.Prchse_Prod_Amount,
            this.PurchDet_id,
            this.x,
            this.prodidDataGridViewTextBoxColumn,
            this.prodqtyDataGridViewTextBoxColumn,
            this.prodrateDataGridViewTextBoxColumn,
            this.disctDataGridViewTextBoxColumn,
            this.purchDetidDataGridViewTextBoxColumn,
            this.purchidDataGridViewTextBoxColumn,
            this.Discount});
            this.grdBill.DataSource = this.purchaseRTNDetailBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdBill.DefaultCellStyle = dataGridViewCellStyle9;
            this.grdBill.Dock = System.Windows.Forms.DockStyle.Left;
            this.grdBill.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grdBill.EnableHeadersVisualStyles = false;
            this.grdBill.GridColor = System.Drawing.SystemColors.Control;
            this.grdBill.Location = new System.Drawing.Point(0, 0);
            this.grdBill.Name = "grdBill";
            this.grdBill.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdBill.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.grdBill.RowHeadersVisible = false;
            this.grdBill.Size = new System.Drawing.Size(774, 159);
            this.grdBill.TabIndex = 17;
            this.grdBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBill_CellClick);
            this.grdBill.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdBill_CellFormatting);
            this.grdBill.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdBill_CellMouseMove);
            this.grdBill.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBill_CellValueChanged);
            // 
            // gdv_prod_name
            // 
            this.gdv_prod_name.DataPropertyName = "Prod_id";
            this.gdv_prod_name.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.gdv_prod_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gdv_prod_name.HeaderText = "Particulars";
            this.gdv_prod_name.Name = "gdv_prod_name";
            this.gdv_prod_name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gdv_prod_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.gdv_prod_name.Width = 250;
            // 
            // Descr
            // 
            this.Descr.DataPropertyName = "Descr";
            this.Descr.HeaderText = "Description";
            this.Descr.Name = "Descr";
            this.Descr.Width = 200;
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
            // Prchse_prod_qty
            // 
            this.Prchse_prod_qty.DataPropertyName = "Prod_qty";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Prchse_prod_qty.DefaultCellStyle = dataGridViewCellStyle4;
            this.Prchse_prod_qty.HeaderText = "Quantity";
            this.Prchse_prod_qty.Name = "Prchse_prod_qty";
            this.Prchse_prod_qty.Width = 70;
            // 
            // GAmount
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.GAmount.DefaultCellStyle = dataGridViewCellStyle5;
            this.GAmount.HeaderText = "Gross Amount";
            this.GAmount.Name = "GAmount";
            this.GAmount.Visible = false;
            // 
            // Prchse_Prod_Amount
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.Prchse_Prod_Amount.DefaultCellStyle = dataGridViewCellStyle6;
            this.Prchse_Prod_Amount.HeaderText = "Net Amount";
            this.Prchse_Prod_Amount.Name = "Prchse_Prod_Amount";
            // 
            // PurchDet_id
            // 
            this.PurchDet_id.DataPropertyName = "PurchDet_id";
            this.PurchDet_id.HeaderText = "ID";
            this.PurchDet_id.Name = "PurchDet_id";
            this.PurchDet_id.ReadOnly = true;
            this.PurchDet_id.Visible = false;
            this.PurchDet_id.Width = 5;
            // 
            // x
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.NullValue = "My.Resources.Resources.close";
            this.x.DefaultCellStyle = dataGridViewCellStyle7;
            this.x.HeaderText = "";
            this.x.Image = global::AccountSystem.Properties.Resources.close;
            this.x.Name = "x";
            this.x.Width = 30;
            // 
            // prodidDataGridViewTextBoxColumn
            // 
            this.prodidDataGridViewTextBoxColumn.DataPropertyName = "Prod_id";
            this.prodidDataGridViewTextBoxColumn.HeaderText = "Prod_id";
            this.prodidDataGridViewTextBoxColumn.Name = "prodidDataGridViewTextBoxColumn";
            this.prodidDataGridViewTextBoxColumn.Visible = false;
            // 
            // prodqtyDataGridViewTextBoxColumn
            // 
            this.prodqtyDataGridViewTextBoxColumn.DataPropertyName = "Prod_qty";
            this.prodqtyDataGridViewTextBoxColumn.HeaderText = "Prod_qty";
            this.prodqtyDataGridViewTextBoxColumn.Name = "prodqtyDataGridViewTextBoxColumn";
            this.prodqtyDataGridViewTextBoxColumn.Visible = false;
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
            // purchDetidDataGridViewTextBoxColumn
            // 
            this.purchDetidDataGridViewTextBoxColumn.DataPropertyName = "PurchDet_id";
            this.purchDetidDataGridViewTextBoxColumn.HeaderText = "PurchDet_id";
            this.purchDetidDataGridViewTextBoxColumn.Name = "purchDetidDataGridViewTextBoxColumn";
            this.purchDetidDataGridViewTextBoxColumn.ReadOnly = true;
            this.purchDetidDataGridViewTextBoxColumn.Visible = false;
            // 
            // purchidDataGridViewTextBoxColumn
            // 
            this.purchidDataGridViewTextBoxColumn.DataPropertyName = "Purch_id";
            this.purchidDataGridViewTextBoxColumn.HeaderText = "Purch_id";
            this.purchidDataGridViewTextBoxColumn.Name = "purchidDataGridViewTextBoxColumn";
            this.purchidDataGridViewTextBoxColumn.Visible = false;
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "Disct";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Discount.DefaultCellStyle = dataGridViewCellStyle8;
            this.Discount.HeaderText = "Tax";
            this.Discount.Name = "Discount";
            this.Discount.Visible = false;
            // 
            // purchaseRTNDetailBindingSource
            // 
            this.purchaseRTNDetailBindingSource.DataMember = "PurchaseRTNHead_PurchaseRTNDetail";
            this.purchaseRTNDetailBindingSource.DataSource = this.purchaseRTNHeadBindingSource;
            // 
            // txtTotal
            // 
            this.txtTotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseRTNHeadBindingSource, "TotalAmount", true));
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(127, 3);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(104, 20);
            this.txtTotal.TabIndex = 24;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(40, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Total Amount";
            // 
            // txtAddress
            // 
            this.txtAddress.AllowHtmlString = true;
            this.txtAddress.Location = new System.Drawing.Point(9, 46);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(8, 14);
            this.txtAddress.TabIndex = 26;
            this.txtAddress.Text = "..";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.txtCheque);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.txtGTotal);
            this.panel2.Controls.Add(this.txtTransport);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtCarriage);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 337);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1021, 148);
            this.panel2.TabIndex = 38;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label18.Location = new System.Drawing.Point(6, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 13);
            this.label18.TabIndex = 57;
            this.label18.Text = "Description";
            // 
            // txtCheque
            // 
            this.txtCheque.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseRTNHeadBindingSource, "Remarks", true));
            this.txtCheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheque.Location = new System.Drawing.Point(9, 32);
            this.txtCheque.Multiline = true;
            this.txtCheque.Name = "txtCheque";
            this.txtCheque.Size = new System.Drawing.Size(490, 32);
            this.txtCheque.TabIndex = 56;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtTotal);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.txtAddDisc);
            this.panel5.Controls.Add(this.textNetTotal);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Location = new System.Drawing.Point(519, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(271, 96);
            this.panel5.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(90, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "GST";
            // 
            // txtAddDisc
            // 
            this.txtAddDisc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseRTNHeadBindingSource, "FED", true));
            this.txtAddDisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddDisc.Location = new System.Drawing.Point(127, 29);
            this.txtAddDisc.Name = "txtAddDisc";
            this.txtAddDisc.Size = new System.Drawing.Size(104, 20);
            this.txtAddDisc.TabIndex = 42;
            this.txtAddDisc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAddDisc.TextChanged += new System.EventHandler(this.txtAddDisc_TextChanged);
            // 
            // textNetTotal
            // 
            this.textNetTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNetTotal.Location = new System.Drawing.Point(127, 53);
            this.textNetTotal.Name = "textNetTotal";
            this.textNetTotal.ReadOnly = true;
            this.textNetTotal.Size = new System.Drawing.Size(104, 20);
            this.textNetTotal.TabIndex = 48;
            this.textNetTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(62, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 47;
            this.label12.Text = "Net Total";
            // 
            // btnPrint
            // 
            this.btnPrint.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.Appearance.Options.UseForeColor = true;
            this.btnPrint.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.purchaseRTNHeadBindingSource, "Purch_id", true));
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(170, 115);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(106, 23);
            this.btnPrint.TabIndex = 37;
            this.btnPrint.Text = "&Print Invoice";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(798, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Gross Total";
            this.label10.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.Appearance.Options.UseForeColor = true;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(372, 115);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(84, 23);
            this.btnClose.TabIndex = 34;
            this.btnClose.Text = "&Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtGTotal
            // 
            this.txtGTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGTotal.Location = new System.Drawing.Point(875, 56);
            this.txtGTotal.Name = "txtGTotal";
            this.txtGTotal.ReadOnly = true;
            this.txtGTotal.Size = new System.Drawing.Size(104, 20);
            this.txtGTotal.TabIndex = 44;
            this.txtGTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGTotal.Visible = false;
            // 
            // txtTransport
            // 
            this.txtTransport.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseRTNHeadBindingSource, "Transport", true));
            this.txtTransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransport.Location = new System.Drawing.Point(60, 70);
            this.txtTransport.Multiline = true;
            this.txtTransport.Name = "txtTransport";
            this.txtTransport.Size = new System.Drawing.Size(439, 32);
            this.txtTransport.TabIndex = 54;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(762, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 13);
            this.label11.TabIndex = 45;
            this.label11.Text = "Carriage && Freight";
            this.label11.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.Location = new System.Drawing.Point(8, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 26);
            this.label8.TabIndex = 55;
            this.label8.Text = "Shipping\r\nDetails";
            // 
            // txtCarriage
            // 
            this.txtCarriage.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseRTNHeadBindingSource, "CarriageFreight", true));
            this.txtCarriage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarriage.Location = new System.Drawing.Point(875, 82);
            this.txtCarriage.Name = "txtCarriage";
            this.txtCarriage.Size = new System.Drawing.Size(104, 20);
            this.txtCarriage.TabIndex = 46;
            this.txtCarriage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCarriage.Visible = false;
            this.txtCarriage.TextChanged += new System.EventHandler(this.txtCarriage_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Appearance.Options.UseForeColor = true;
            this.btnSave.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.purchaseRTNHeadBindingSource, "Purch_id", true));
            this.btnSave.Image = global::AccountSystem.Properties.Resources.save_all;
            this.btnSave.Location = new System.Drawing.Point(282, 115);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 23);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.NullValue = "My.Resources.Resources.close";
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::AccountSystem.Properties.Resources.close;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 30;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle12.Format = "N2";
            dataGridViewCellStyle12.NullValue = null;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle12;
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
            dataGridViewCellStyle13.Format = "N2";
            dataGridViewCellStyle13.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle13;
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
            this.listBox1.DataSource = this.purchaseRTNHeadBindingSource;
            this.listBox1.DisplayMember = "PurchaseOrder";
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(0, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(194, 432);
            this.listBox1.TabIndex = 39;
            this.listBox1.ValueMember = "Purch_id";
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
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
            this.tableAdapterManager.PurchaseRTNDetailTableAdapter = this.purchaseRTNDetailTableAdapter;
            this.tableAdapterManager.PurchaseRTNHeadTableAdapter = this.purchaseRTNHeadTableAdapter;
            this.tableAdapterManager.SaleRetrunDetailsTableAdapter = null;
            this.tableAdapterManager.SaleRetrunHeadTableAdapter = null;
            this.tableAdapterManager.SODetails1TableAdapter = null;
            this.tableAdapterManager.SODetailsTableAdapter = null;
            this.tableAdapterManager.SOHead1TableAdapter = null;
            this.tableAdapterManager.SOHeadTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AccountSystem.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // purchaseRTNDetailTableAdapter
            // 
            this.purchaseRTNDetailTableAdapter.ClearBeforeFill = true;
            // 
            // purchaseRTNHeadTableAdapter
            // 
            this.purchaseRTNHeadTableAdapter.ClearBeforeFill = true;
            // 
            // txtVInvoice
            // 
            this.txtVInvoice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseRTNHeadBindingSource, "VendorInvoice", true));
            this.txtVInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVInvoice.Location = new System.Drawing.Point(128, 100);
            this.txtVInvoice.Name = "txtVInvoice";
            this.txtVInvoice.Size = new System.Drawing.Size(101, 20);
            this.txtVInvoice.TabIndex = 43;
            this.txtVInvoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtVinvDT
            // 
            this.dtVinvDT.CustomFormat = "ddMMMMyyyy";
            this.dtVinvDT.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.purchaseRTNHeadBindingSource, "VendorInvoiceDate", true));
            this.dtVinvDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtVinvDT.Location = new System.Drawing.Point(128, 122);
            this.dtVinvDT.Name = "dtVinvDT";
            this.dtVinvDT.Size = new System.Drawing.Size(137, 20);
            this.dtVinvDT.TabIndex = 42;
            this.dtVinvDT.Enter += new System.EventHandler(this.dtVinvDT_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(3, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Vendor Invoice Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(3, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Vendor Invoice #";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.grdBill);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 178);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1021, 159);
            this.panel3.TabIndex = 49;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.txtComInv);
            this.panel4.Controls.Add(this.label21);
            this.panel4.Controls.Add(this.cboStores);
            this.panel4.Controls.Add(label20);
            this.panel4.Controls.Add(this.cbLocation);
            this.panel4.Controls.Add(this.cboVendor);
            this.panel4.Controls.Add(this.txtAddress);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtTrxNo);
            this.panel4.Controls.Add(this.lbl_prchse_bill_no);
            this.panel4.Controls.Add(this.dtVinvDT);
            this.panel4.Controls.Add(this.dtTrxDate);
            this.panel4.Controls.Add(this.lbl_prchse_date);
            this.panel4.Controls.Add(this.txtVInvoice);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1021, 178);
            this.panel4.TabIndex = 48;
            // 
            // txtComInv
            // 
            this.txtComInv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseRTNHeadBindingSource, "CommercialInvoice", true));
            this.txtComInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComInv.Location = new System.Drawing.Point(128, 152);
            this.txtComInv.Name = "txtComInv";
            this.txtComInv.Size = new System.Drawing.Size(101, 20);
            this.txtComInv.TabIndex = 67;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(3, 156);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(119, 13);
            this.label21.TabIndex = 66;
            this.label21.Text = "Inword Gate Pass #";
            // 
            // cboStores
            // 
            this.cboStores.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.purchaseRTNHeadBindingSource, "StoreID", true));
            this.cboStores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStores.FormattingEnabled = true;
            this.cboStores.Location = new System.Drawing.Point(492, 76);
            this.cboStores.Name = "cboStores";
            this.cboStores.Size = new System.Drawing.Size(259, 21);
            this.cboStores.TabIndex = 65;
            // 
            // cbLocation
            // 
            this.cbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.Location = new System.Drawing.Point(797, 76);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(54, 21);
            this.cbLocation.TabIndex = 57;
            this.cbLocation.Visible = false;
            this.cbLocation.SelectedIndexChanged += new System.EventHandler(this.cbLocation_SelectedIndexChanged);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel3);
            this.panel7.Controls.Add(this.panel4);
            this.panel7.Controls.Add(this.panel2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(200, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1021, 485);
            this.panel7.TabIndex = 50;
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
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel1.ID = new System.Guid("0a014233-b054-4cde-9a42-0d3dc7287cfb");
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.Options.ShowCloseButton = false;
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel1.Size = new System.Drawing.Size(200, 485);
            this.dockPanel1.TabText = "Show/Hide Purchase Invoice List";
            this.dockPanel1.Text = "Purchase Invoice List";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.listBox1);
            this.dockPanel1_Container.Controls.Add(this.fillToolStrip);
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 25);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(194, 457);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(194, 25);
            this.fillToolStrip.TabIndex = 52;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // searchToolStripTextBox
            // 
            this.searchToolStripTextBox.Name = "searchToolStripTextBox";
            this.searchToolStripTextBox.Size = new System.Drawing.Size(125, 25);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("fillToolStripButton.Image")));
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(62, 22);
            this.fillToolStripButton.Text = "Search";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // frmEditPurchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1221, 485);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.dockPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEditPurchases";
            this.Text = "Edit Purchases";
            this.Load += new System.EventHandler(this.frmPurchaseOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.purchaseRTNHeadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseRTNDetailBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.dockPanel1_Container.PerformLayout();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
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
        public System.Windows.Forms.DataGridView grdBill;
        public System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DevExpress.XtraEditors.LabelControl txtAddress;
        internal DevExpress.XtraEditors.SimpleButton btnPrint;
        internal DevExpress.XtraEditors.SimpleButton btnClose;
        internal DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.ListBox listBox1;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.TextBox txtVInvoice;
        private System.Windows.Forms.DateTimePicker dtVinvDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textNetTotal;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txtCarriage;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtGTotal;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtAddDisc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.TextBox txtCheque;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripTextBox searchToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.BindingSource purchaseRTNHeadBindingSource;
        private DataSet1TableAdapters.PurchaseRTNHeadTableAdapter purchaseRTNHeadTableAdapter;
        private System.Windows.Forms.BindingSource purchaseRTNDetailBindingSource;
        private DataSet1TableAdapters.PurchaseRTNDetailTableAdapter purchaseRTNDetailTableAdapter;
        public System.Windows.Forms.TextBox txtTransport;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbLocation;
        private System.Windows.Forms.ComboBox cboStores;
        public System.Windows.Forms.TextBox txtComInv;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridViewComboBoxColumn gdv_prod_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descr;
        private System.Windows.Forms.DataGridViewTextBoxColumn prchse_prod_rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prchse_prod_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn GAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prchse_Prod_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchDet_id;
        private System.Windows.Forms.DataGridViewImageColumn x;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodqtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodrateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn disctDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchDetidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
    }
}

