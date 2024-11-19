namespace AccountSystem
{
    partial class frmPacketing
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
            System.Windows.Forms.Label label20;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPacketing));
            this.lblname = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.grpbx_product = new System.Windows.Forms.GroupBox();
            this.cboPackDamage = new System.Windows.Forms.ComboBox();
            this.cboStores = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtRmks = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbltQTY = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPallets = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cboProducts = new SergeUtils.EasyCompletionComboBox();
            this.txtPallets = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            label20 = new System.Windows.Forms.Label();
            this.grpbx_product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new System.Drawing.Point(14, 131);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(85, 13);
            label20.TabIndex = 66;
            label20.Text = "Stock Location :";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(14, 45);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(87, 13);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Product Name";
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Image = global::AccountSystem.Properties.Resources.save_all;
            this.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsave.Location = new System.Drawing.Point(290, 263);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(87, 26);
            this.btnsave.TabIndex = 3;
            this.btnsave.Text = "&Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // grpbx_product
            // 
            this.grpbx_product.Controls.Add(this.cboPackDamage);
            this.grpbx_product.Controls.Add(this.cboStores);
            this.grpbx_product.Controls.Add(label20);
            this.grpbx_product.Controls.Add(this.label22);
            this.grpbx_product.Controls.Add(this.txtRmks);
            this.grpbx_product.Controls.Add(this.btnsave);
            this.grpbx_product.Controls.Add(this.button1);
            this.grpbx_product.Controls.Add(this.lbltQTY);
            this.grpbx_product.Controls.Add(this.label5);
            this.grpbx_product.Controls.Add(this.lblPallets);
            this.grpbx_product.Controls.Add(this.label8);
            this.grpbx_product.Controls.Add(this.lblCost);
            this.grpbx_product.Controls.Add(this.label4);
            this.grpbx_product.Controls.Add(this.label1);
            this.grpbx_product.Controls.Add(this.dateTimePicker1);
            this.grpbx_product.Controls.Add(this.cboProducts);
            this.grpbx_product.Controls.Add(this.txtPallets);
            this.grpbx_product.Controls.Add(this.lblQty);
            this.grpbx_product.Controls.Add(this.lblname);
            this.grpbx_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbx_product.Location = new System.Drawing.Point(82, 58);
            this.grpbx_product.Name = "grpbx_product";
            this.grpbx_product.Size = new System.Drawing.Size(482, 299);
            this.grpbx_product.TabIndex = 1;
            this.grpbx_product.TabStop = false;
            // 
            // cboPackDamage
            // 
            this.cboPackDamage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPackDamage.FormattingEnabled = true;
            this.cboPackDamage.Location = new System.Drawing.Point(271, 19);
            this.cboPackDamage.Name = "cboPackDamage";
            this.cboPackDamage.Size = new System.Drawing.Size(106, 21);
            this.cboPackDamage.TabIndex = 68;
            // 
            // cboStores
            // 
            this.cboStores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStores.FormattingEnabled = true;
            this.cboStores.Location = new System.Drawing.Point(115, 128);
            this.cboStores.Name = "cboStores";
            this.cboStores.Size = new System.Drawing.Size(259, 21);
            this.cboStores.TabIndex = 67;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(14, 155);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 16);
            this.label22.TabIndex = 32;
            this.label22.Text = "Remarks";
            // 
            // txtRmks
            // 
            this.txtRmks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRmks.Location = new System.Drawing.Point(17, 176);
            this.txtRmks.MaxLength = 550;
            this.txtRmks.Multiline = true;
            this.txtRmks.Name = "txtRmks";
            this.txtRmks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRmks.Size = new System.Drawing.Size(440, 68);
            this.txtRmks.TabIndex = 31;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::AccountSystem.Properties.Resources.exit;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(382, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 4;
            this.button1.Text = "&Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbltQTY
            // 
            this.lbltQTY.AutoSize = true;
            this.lbltQTY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltQTY.Location = new System.Drawing.Point(229, 105);
            this.lbltQTY.Name = "lbltQTY";
            this.lbltQTY.Size = new System.Drawing.Size(14, 13);
            this.lbltQTY.TabIndex = 27;
            this.lbltQTY.Text = "0";
            this.lbltQTY.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(135, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "QTY";
            // 
            // lblPallets
            // 
            this.lblPallets.AutoSize = true;
            this.lblPallets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPallets.Location = new System.Drawing.Point(84, 105);
            this.lblPallets.Name = "lblPallets";
            this.lblPallets.Size = new System.Drawing.Size(14, 13);
            this.lblPallets.TabIndex = 23;
            this.lblPallets.Text = "0";
            this.lblPallets.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Pallet Size";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(325, 75);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(14, 13);
            this.lblCost.TabIndex = 14;
            this.lblCost.Text = "0";
            this.lblCost.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(235, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Per Item cost";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd MMMM yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(115, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(150, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // cboProducts
            // 
            this.cboProducts.FormattingEnabled = true;
            this.cboProducts.Location = new System.Drawing.Point(115, 45);
            this.cboProducts.MatchingMethod = SergeUtils.StringMatchingMethod.UseWildcards;
            this.cboProducts.Name = "cboProducts";
            this.cboProducts.Size = new System.Drawing.Size(262, 21);
            this.cboProducts.TabIndex = 5;
            this.cboProducts.SelectedIndexChanged += new System.EventHandler(this.cboProducts_SelectedIndexChanged);
            // 
            // txtPallets
            // 
            this.txtPallets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPallets.Location = new System.Drawing.Point(115, 71);
            this.txtPallets.Name = "txtPallets";
            this.txtPallets.Size = new System.Drawing.Size(77, 20);
            this.txtPallets.TabIndex = 11;
            this.txtPallets.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            this.txtPallets.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(14, 75);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(45, 13);
            this.lblQty.TabIndex = 10;
            this.lblQty.Text = "Pallets";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Product Packeting";
            // 
            // frmPacketing
            // 
            this.AcceptButton = this.btnsave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(811, 495);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpbx_product);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPacketing";
            this.Text = "Product Packeting";
            this.Load += new System.EventHandler(this.frmproduct_Load);
            this.grpbx_product.ResumeLayout(false);
            this.grpbx_product.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.GroupBox grpbx_product;
        public System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPallets;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label label3;
        private SergeUtils.EasyCompletionComboBox cboProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPallets;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbltQTY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtRmks;
        private System.Windows.Forms.ComboBox cboStores;
        private System.Windows.Forms.ComboBox cboPackDamage;
    }
}

