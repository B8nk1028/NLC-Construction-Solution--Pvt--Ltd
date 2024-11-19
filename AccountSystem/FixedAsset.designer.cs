namespace AccountSystem
{
    partial class FixedAsset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FixedAsset));
            this.lbl_asset_code = new System.Windows.Forms.Label();
            this.rbtn_Attached_Asset = new System.Windows.Forms.RadioButton();
            this.rbtn_new_asset = new System.Windows.Forms.RadioButton();
            this.lbl_account_head = new System.Windows.Forms.Label();
            this.lbl_asset = new System.Windows.Forms.Label();
            this.cbx_account_head = new System.Windows.Forms.ComboBox();
            this.txt_asset_code = new System.Windows.Forms.TextBox();
            this.cbx_asset_code = new System.Windows.Forms.ComboBox();
            this.pnl_fixed_aset = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_submit_fixedAsset = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_item_name = new System.Windows.Forms.TextBox();
            this.txt_cost_of_asset = new System.Windows.Forms.TextBox();
            this.txt_asset_life = new System.Windows.Forms.TextBox();
            this.txt_serial_no = new System.Windows.Forms.TextBox();
            this.txt_vendor = new System.Windows.Forms.TextBox();
            this.txt_asset_value = new System.Windows.Forms.TextBox();
            this.txt_serving_info = new System.Windows.Forms.TextBox();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.txt_location = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtp_serving_date = new System.Windows.Forms.DateTimePicker();
            this.txt_model_No = new System.Windows.Forms.TextBox();
            this.txt_warranty = new System.Windows.Forms.TextBox();
            this.cbx_asset_life = new System.Windows.Forms.ComboBox();
            this.rbtn_cash = new System.Windows.Forms.RadioButton();
            this.rbtn_bank = new System.Windows.Forms.RadioButton();
            this.cbox_bank = new System.Windows.Forms.ComboBox();
            this.cbox_cash = new System.Windows.Forms.ComboBox();
            this.txt_cheque = new System.Windows.Forms.TextBox();
            this.pnl_bank = new System.Windows.Forms.Panel();
            this.lbl_cheque_no = new System.Windows.Forms.Label();
            this.lbl_bank_name = new System.Windows.Forms.Label();
            this.pnl_cash = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtVoucherNo = new System.Windows.Forms.TextBox();
            this.txtVid = new System.Windows.Forms.TextBox();
            this.pnl_fixed_aset.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_bank.SuspendLayout();
            this.pnl_cash.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_asset_code
            // 
            this.lbl_asset_code.AutoSize = true;
            this.lbl_asset_code.Location = new System.Drawing.Point(137, 10);
            this.lbl_asset_code.Name = "lbl_asset_code";
            this.lbl_asset_code.Size = new System.Drawing.Size(61, 13);
            this.lbl_asset_code.TabIndex = 3;
            this.lbl_asset_code.Text = "Asset Code";
            // 
            // rbtn_Attached_Asset
            // 
            this.rbtn_Attached_Asset.AutoSize = true;
            this.rbtn_Attached_Asset.Location = new System.Drawing.Point(103, 12);
            this.rbtn_Attached_Asset.Name = "rbtn_Attached_Asset";
            this.rbtn_Attached_Asset.Size = new System.Drawing.Size(182, 17);
            this.rbtn_Attached_Asset.TabIndex = 64;
            this.rbtn_Attached_Asset.Text = "Attach Asset info to existing code";
            this.rbtn_Attached_Asset.UseVisualStyleBackColor = true;
            this.rbtn_Attached_Asset.CheckedChanged += new System.EventHandler(this.rbtn_Attached_Asset_CheckedChanged);
            // 
            // rbtn_new_asset
            // 
            this.rbtn_new_asset.AutoSize = true;
            this.rbtn_new_asset.Checked = true;
            this.rbtn_new_asset.Location = new System.Drawing.Point(24, 12);
            this.rbtn_new_asset.Name = "rbtn_new_asset";
            this.rbtn_new_asset.Size = new System.Drawing.Size(76, 17);
            this.rbtn_new_asset.TabIndex = 63;
            this.rbtn_new_asset.TabStop = true;
            this.rbtn_new_asset.Text = "New Asset";
            this.rbtn_new_asset.UseVisualStyleBackColor = true;
            this.rbtn_new_asset.CheckedChanged += new System.EventHandler(this.rbtn_new_asset_CheckedChanged);
            // 
            // lbl_account_head
            // 
            this.lbl_account_head.AutoSize = true;
            this.lbl_account_head.Location = new System.Drawing.Point(10, 5);
            this.lbl_account_head.Name = "lbl_account_head";
            this.lbl_account_head.Size = new System.Drawing.Size(76, 13);
            this.lbl_account_head.TabIndex = 2;
            this.lbl_account_head.Text = "Account Head";
            // 
            // lbl_asset
            // 
            this.lbl_asset.AutoSize = true;
            this.lbl_asset.Location = new System.Drawing.Point(13, 14);
            this.lbl_asset.Name = "lbl_asset";
            this.lbl_asset.Size = new System.Drawing.Size(61, 13);
            this.lbl_asset.TabIndex = 49;
            this.lbl_asset.Text = "Asset Code";
            // 
            // cbx_account_head
            // 
            this.cbx_account_head.FormattingEnabled = true;
            this.cbx_account_head.Location = new System.Drawing.Point(3, 25);
            this.cbx_account_head.Name = "cbx_account_head";
            this.cbx_account_head.Size = new System.Drawing.Size(121, 21);
            this.cbx_account_head.TabIndex = 0;
            this.cbx_account_head.SelectedIndexChanged += new System.EventHandler(this.cbx_account_head_SelectedIndexChanged);
            // 
            // txt_asset_code
            // 
            this.txt_asset_code.Location = new System.Drawing.Point(130, 26);
            this.txt_asset_code.Name = "txt_asset_code";
            this.txt_asset_code.Size = new System.Drawing.Size(100, 20);
            this.txt_asset_code.TabIndex = 1;
            // 
            // cbx_asset_code
            // 
            this.cbx_asset_code.FormattingEnabled = true;
            this.cbx_asset_code.Location = new System.Drawing.Point(5, 30);
            this.cbx_asset_code.Name = "cbx_asset_code";
            this.cbx_asset_code.Size = new System.Drawing.Size(154, 21);
            this.cbx_asset_code.TabIndex = 48;
            // 
            // pnl_fixed_aset
            // 
            this.pnl_fixed_aset.Controls.Add(this.lbl_asset_code);
            this.pnl_fixed_aset.Controls.Add(this.lbl_account_head);
            this.pnl_fixed_aset.Controls.Add(this.txt_asset_code);
            this.pnl_fixed_aset.Controls.Add(this.cbx_account_head);
            this.pnl_fixed_aset.Location = new System.Drawing.Point(12, 35);
            this.pnl_fixed_aset.Name = "pnl_fixed_aset";
            this.pnl_fixed_aset.Size = new System.Drawing.Size(244, 60);
            this.pnl_fixed_aset.TabIndex = 81;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_asset);
            this.panel1.Controls.Add(this.cbx_asset_code);
            this.panel1.Location = new System.Drawing.Point(12, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 60);
            this.panel1.TabIndex = 82;
            this.panel1.Visible = false;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.simpleButton2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Appearance.Options.UseForeColor = true;
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(549, 418);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 66;
            this.simpleButton2.Text = "Cancel";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btn_submit_fixedAsset
            // 
            this.btn_submit_fixedAsset.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_submit_fixedAsset.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_submit_fixedAsset.Appearance.Options.UseFont = true;
            this.btn_submit_fixedAsset.Appearance.Options.UseForeColor = true;
            this.btn_submit_fixedAsset.Image = ((System.Drawing.Image)(resources.GetObject("btn_submit_fixedAsset.Image")));
            this.btn_submit_fixedAsset.Location = new System.Drawing.Point(468, 416);
            this.btn_submit_fixedAsset.Name = "btn_submit_fixedAsset";
            this.btn_submit_fixedAsset.Size = new System.Drawing.Size(75, 23);
            this.btn_submit_fixedAsset.TabIndex = 65;
            this.btn_submit_fixedAsset.Text = "Submit";
            this.btn_submit_fixedAsset.Click += new System.EventHandler(this.btn_submit_fixedAsset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 83;
            this.label1.Text = "Item Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 84;
            this.label2.Text = "Cost of Asset";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 85;
            this.label3.Text = "Asset Life";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 86;
            this.label4.Text = "Serial No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 87;
            this.label5.Text = "Vendor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 89;
            this.label7.Text = "Asset value";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 90;
            this.label8.Text = "Service information";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 301);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 91;
            this.label9.Text = "Description";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 336);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 92;
            this.label10.Text = "Location";
            // 
            // txt_item_name
            // 
            this.txt_item_name.Location = new System.Drawing.Point(126, 130);
            this.txt_item_name.Name = "txt_item_name";
            this.txt_item_name.Size = new System.Drawing.Size(100, 20);
            this.txt_item_name.TabIndex = 2;
            // 
            // txt_cost_of_asset
            // 
            this.txt_cost_of_asset.Location = new System.Drawing.Point(353, 127);
            this.txt_cost_of_asset.Name = "txt_cost_of_asset";
            this.txt_cost_of_asset.Size = new System.Drawing.Size(100, 20);
            this.txt_cost_of_asset.TabIndex = 3;
            this.txt_cost_of_asset.TextChanged += new System.EventHandler(this.txt_cost_of_asset_TextChanged);
            // 
            // txt_asset_life
            // 
            this.txt_asset_life.Location = new System.Drawing.Point(128, 156);
            this.txt_asset_life.Name = "txt_asset_life";
            this.txt_asset_life.Size = new System.Drawing.Size(100, 20);
            this.txt_asset_life.TabIndex = 4;
            this.txt_asset_life.TextChanged += new System.EventHandler(this.txt_asset_life_TextChanged);
            // 
            // txt_serial_no
            // 
            this.txt_serial_no.Location = new System.Drawing.Point(130, 184);
            this.txt_serial_no.Name = "txt_serial_no";
            this.txt_serial_no.Size = new System.Drawing.Size(100, 20);
            this.txt_serial_no.TabIndex = 6;
            this.txt_serial_no.TextChanged += new System.EventHandler(this.txt_serial_no_TextChanged);
            // 
            // txt_vendor
            // 
            this.txt_vendor.Location = new System.Drawing.Point(130, 210);
            this.txt_vendor.Name = "txt_vendor";
            this.txt_vendor.Size = new System.Drawing.Size(100, 20);
            this.txt_vendor.TabIndex = 8;
            // 
            // txt_asset_value
            // 
            this.txt_asset_value.Location = new System.Drawing.Point(130, 239);
            this.txt_asset_value.Name = "txt_asset_value";
            this.txt_asset_value.Size = new System.Drawing.Size(100, 20);
            this.txt_asset_value.TabIndex = 10;
            // 
            // txt_serving_info
            // 
            this.txt_serving_info.Location = new System.Drawing.Point(130, 265);
            this.txt_serving_info.Name = "txt_serving_info";
            this.txt_serving_info.Size = new System.Drawing.Size(100, 20);
            this.txt_serving_info.TabIndex = 11;
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(130, 288);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(310, 42);
            this.txt_description.TabIndex = 12;
            // 
            // txt_location
            // 
            this.txt_location.Location = new System.Drawing.Point(133, 336);
            this.txt_location.Name = "txt_location";
            this.txt_location.Size = new System.Drawing.Size(168, 20);
            this.txt_location.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 103;
            this.label11.Text = "Serving Date ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(251, 190);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 104;
            this.label12.Text = "Model No";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(251, 217);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 105;
            this.label13.Text = "Warranty";
            // 
            // dtp_serving_date
            // 
            this.dtp_serving_date.CustomFormat = "dd-MMM-yyyy";
            this.dtp_serving_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_serving_date.Location = new System.Drawing.Point(126, 104);
            this.dtp_serving_date.Name = "dtp_serving_date";
            this.dtp_serving_date.Size = new System.Drawing.Size(130, 20);
            this.dtp_serving_date.TabIndex = 1;
            // 
            // txt_model_No
            // 
            this.txt_model_No.Location = new System.Drawing.Point(325, 186);
            this.txt_model_No.Name = "txt_model_No";
            this.txt_model_No.Size = new System.Drawing.Size(100, 20);
            this.txt_model_No.TabIndex = 7;
            // 
            // txt_warranty
            // 
            this.txt_warranty.Location = new System.Drawing.Point(325, 212);
            this.txt_warranty.Name = "txt_warranty";
            this.txt_warranty.Size = new System.Drawing.Size(100, 20);
            this.txt_warranty.TabIndex = 9;
            // 
            // cbx_asset_life
            // 
            this.cbx_asset_life.FormattingEnabled = true;
            this.cbx_asset_life.Items.AddRange(new object[] {
            "Years",
            "Months",
            "Days"});
            this.cbx_asset_life.Location = new System.Drawing.Point(230, 156);
            this.cbx_asset_life.Name = "cbx_asset_life";
            this.cbx_asset_life.Size = new System.Drawing.Size(47, 21);
            this.cbx_asset_life.TabIndex = 5;
            this.cbx_asset_life.SelectedIndexChanged += new System.EventHandler(this.cbx_asset_life_SelectedIndexChanged);
            // 
            // rbtn_cash
            // 
            this.rbtn_cash.AutoSize = true;
            this.rbtn_cash.Location = new System.Drawing.Point(85, 10);
            this.rbtn_cash.Name = "rbtn_cash";
            this.rbtn_cash.Size = new System.Drawing.Size(49, 17);
            this.rbtn_cash.TabIndex = 112;
            this.rbtn_cash.TabStop = true;
            this.rbtn_cash.Text = "Cash";
            this.rbtn_cash.UseVisualStyleBackColor = true;
            this.rbtn_cash.CheckedChanged += new System.EventHandler(this.rbtn_cash_CheckedChanged);
            // 
            // rbtn_bank
            // 
            this.rbtn_bank.AutoSize = true;
            this.rbtn_bank.Location = new System.Drawing.Point(10, 10);
            this.rbtn_bank.Name = "rbtn_bank";
            this.rbtn_bank.Size = new System.Drawing.Size(50, 17);
            this.rbtn_bank.TabIndex = 113;
            this.rbtn_bank.TabStop = true;
            this.rbtn_bank.Text = "Bank";
            this.rbtn_bank.UseVisualStyleBackColor = true;
            this.rbtn_bank.CheckedChanged += new System.EventHandler(this.rbtn_bank_CheckedChanged);
            // 
            // cbox_bank
            // 
            this.cbox_bank.FormattingEnabled = true;
            this.cbox_bank.Location = new System.Drawing.Point(15, 20);
            this.cbox_bank.Name = "cbox_bank";
            this.cbox_bank.Size = new System.Drawing.Size(248, 21);
            this.cbox_bank.TabIndex = 114;
            // 
            // cbox_cash
            // 
            this.cbox_cash.FormattingEnabled = true;
            this.cbox_cash.Location = new System.Drawing.Point(16, 18);
            this.cbox_cash.Name = "cbox_cash";
            this.cbox_cash.Size = new System.Drawing.Size(242, 21);
            this.cbox_cash.TabIndex = 116;
            // 
            // txt_cheque
            // 
            this.txt_cheque.Location = new System.Drawing.Point(267, 20);
            this.txt_cheque.Name = "txt_cheque";
            this.txt_cheque.Size = new System.Drawing.Size(148, 20);
            this.txt_cheque.TabIndex = 118;
            this.txt_cheque.TextChanged += new System.EventHandler(this.txt_cheque_TextChanged);
            // 
            // pnl_bank
            // 
            this.pnl_bank.Controls.Add(this.lbl_cheque_no);
            this.pnl_bank.Controls.Add(this.lbl_bank_name);
            this.pnl_bank.Controls.Add(this.txt_cheque);
            this.pnl_bank.Controls.Add(this.cbox_bank);
            this.pnl_bank.Location = new System.Drawing.Point(10, 28);
            this.pnl_bank.Name = "pnl_bank";
            this.pnl_bank.Size = new System.Drawing.Size(418, 49);
            this.pnl_bank.TabIndex = 119;
            // 
            // lbl_cheque_no
            // 
            this.lbl_cheque_no.AutoSize = true;
            this.lbl_cheque_no.Location = new System.Drawing.Point(267, 4);
            this.lbl_cheque_no.Name = "lbl_cheque_no";
            this.lbl_cheque_no.Size = new System.Drawing.Size(60, 13);
            this.lbl_cheque_no.TabIndex = 120;
            this.lbl_cheque_no.Text = "cheque No";
            // 
            // lbl_bank_name
            // 
            this.lbl_bank_name.AutoSize = true;
            this.lbl_bank_name.Location = new System.Drawing.Point(15, 4);
            this.lbl_bank_name.Name = "lbl_bank_name";
            this.lbl_bank_name.Size = new System.Drawing.Size(63, 13);
            this.lbl_bank_name.TabIndex = 119;
            this.lbl_bank_name.Text = "Bank Name";
            // 
            // pnl_cash
            // 
            this.pnl_cash.Controls.Add(this.label17);
            this.pnl_cash.Controls.Add(this.cbox_cash);
            this.pnl_cash.Location = new System.Drawing.Point(10, 29);
            this.pnl_cash.Name = "pnl_cash";
            this.pnl_cash.Size = new System.Drawing.Size(413, 48);
            this.pnl_cash.TabIndex = 120;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 4);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 13);
            this.label17.TabIndex = 120;
            this.label17.Text = "Account Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn_bank);
            this.groupBox1.Controls.Add(this.pnl_cash);
            this.groupBox1.Controls.Add(this.rbtn_cash);
            this.groupBox1.Controls.Add(this.pnl_bank);
            this.groupBox1.Location = new System.Drawing.Point(28, 362);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 79);
            this.groupBox1.TabIndex = 121;
            this.groupBox1.TabStop = false;
            // 
            // txtVoucherNo
            // 
            this.txtVoucherNo.Location = new System.Drawing.Point(453, 189);
            this.txtVoucherNo.Name = "txtVoucherNo";
            this.txtVoucherNo.Size = new System.Drawing.Size(100, 20);
            this.txtVoucherNo.TabIndex = 13;
            this.txtVoucherNo.Visible = false;
            // 
            // txtVid
            // 
            this.txtVid.Location = new System.Drawing.Point(453, 212);
            this.txtVid.Name = "txtVid";
            this.txtVid.Size = new System.Drawing.Size(100, 20);
            this.txtVid.TabIndex = 15;
            this.txtVid.Visible = false;
            // 
            // FixedAsset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 444);
            this.Controls.Add(this.txtVid);
            this.Controls.Add(this.txtVoucherNo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnl_fixed_aset);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbx_asset_life);
            this.Controls.Add(this.txt_warranty);
            this.Controls.Add(this.txt_model_No);
            this.Controls.Add(this.dtp_serving_date);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_location);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.txt_serving_info);
            this.Controls.Add(this.txt_asset_value);
            this.Controls.Add(this.txt_vendor);
            this.Controls.Add(this.txt_serial_no);
            this.Controls.Add(this.txt_asset_life);
            this.Controls.Add(this.txt_cost_of_asset);
            this.Controls.Add(this.txt_item_name);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtn_Attached_Asset);
            this.Controls.Add(this.rbtn_new_asset);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btn_submit_fixedAsset);
            this.Name = "FixedAsset";
            this.Text = "FixedAsset";
            this.Load += new System.EventHandler(this.FixedAsset_Load);
            this.pnl_fixed_aset.ResumeLayout(false);
            this.pnl_fixed_aset.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_bank.ResumeLayout(false);
            this.pnl_bank.PerformLayout();
            this.pnl_cash.ResumeLayout(false);
            this.pnl_cash.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_asset_code;
        private System.Windows.Forms.RadioButton rbtn_Attached_Asset;
        private System.Windows.Forms.RadioButton rbtn_new_asset;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.Label lbl_account_head;
        private System.Windows.Forms.Label lbl_asset;
        private System.Windows.Forms.ComboBox cbx_account_head;
        private System.Windows.Forms.TextBox txt_asset_code;
        private System.Windows.Forms.ComboBox cbx_asset_code;
        private System.Windows.Forms.Panel pnl_fixed_aset;
        private DevExpress.XtraEditors.SimpleButton btn_submit_fixedAsset;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_item_name;
        private System.Windows.Forms.TextBox txt_cost_of_asset;
        private System.Windows.Forms.TextBox txt_asset_life;
        private System.Windows.Forms.TextBox txt_serial_no;
        private System.Windows.Forms.TextBox txt_vendor;
        private System.Windows.Forms.TextBox txt_asset_value;
        private System.Windows.Forms.TextBox txt_serving_info;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.TextBox txt_location;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtp_serving_date;
        private System.Windows.Forms.TextBox txt_model_No;
        private System.Windows.Forms.TextBox txt_warranty;
        private System.Windows.Forms.ComboBox cbx_asset_life;
        private System.Windows.Forms.RadioButton rbtn_cash;
        private System.Windows.Forms.RadioButton rbtn_bank;
        private System.Windows.Forms.ComboBox cbox_bank;
        private System.Windows.Forms.ComboBox cbox_cash;
        private System.Windows.Forms.TextBox txt_cheque;
        private System.Windows.Forms.Panel pnl_bank;
        private System.Windows.Forms.Panel pnl_cash;
        private System.Windows.Forms.Label lbl_cheque_no;
        private System.Windows.Forms.Label lbl_bank_name;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtVoucherNo;
        private System.Windows.Forms.TextBox txtVid;
    }
}