namespace AccountSystem
{
    partial class frmDamage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDamage));
            this.lblname = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.grpbx_product = new System.Windows.Forms.GroupBox();
            this.lbltPallets = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPigment = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblPallets = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCement = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblPan = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSand = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cboProducts = new SergeUtils.EasyCompletionComboBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtRmks = new System.Windows.Forms.TextBox();
            this.grpbx_product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.btnsave.Location = new System.Drawing.Point(290, 234);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(87, 26);
            this.btnsave.TabIndex = 3;
            this.btnsave.Text = "&Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // grpbx_product
            // 
            this.grpbx_product.Controls.Add(this.label22);
            this.grpbx_product.Controls.Add(this.txtRmks);
            this.grpbx_product.Controls.Add(this.btnsave);
            this.grpbx_product.Controls.Add(this.button1);
            this.grpbx_product.Controls.Add(this.lbltPallets);
            this.grpbx_product.Controls.Add(this.label5);
            this.grpbx_product.Controls.Add(this.lblPigment);
            this.grpbx_product.Controls.Add(this.label10);
            this.grpbx_product.Controls.Add(this.lblPallets);
            this.grpbx_product.Controls.Add(this.label8);
            this.grpbx_product.Controls.Add(this.lblCement);
            this.grpbx_product.Controls.Add(this.label11);
            this.grpbx_product.Controls.Add(this.lblPan);
            this.grpbx_product.Controls.Add(this.label9);
            this.grpbx_product.Controls.Add(this.lblSand);
            this.grpbx_product.Controls.Add(this.label7);
            this.grpbx_product.Controls.Add(this.label6);
            this.grpbx_product.Controls.Add(this.lblCost);
            this.grpbx_product.Controls.Add(this.label4);
            this.grpbx_product.Controls.Add(this.label1);
            this.grpbx_product.Controls.Add(this.dateTimePicker1);
            this.grpbx_product.Controls.Add(this.cboProducts);
            this.grpbx_product.Controls.Add(this.txtQty);
            this.grpbx_product.Controls.Add(this.lblQty);
            this.grpbx_product.Controls.Add(this.lblname);
            this.grpbx_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbx_product.Location = new System.Drawing.Point(82, 58);
            this.grpbx_product.Name = "grpbx_product";
            this.grpbx_product.Size = new System.Drawing.Size(482, 266);
            this.grpbx_product.TabIndex = 1;
            this.grpbx_product.TabStop = false;
            // 
            // lbltPallets
            // 
            this.lbltPallets.AutoSize = true;
            this.lbltPallets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltPallets.Location = new System.Drawing.Point(182, 105);
            this.lbltPallets.Name = "lbltPallets";
            this.lbltPallets.Size = new System.Drawing.Size(14, 13);
            this.lbltPallets.TabIndex = 27;
            this.lbltPallets.Text = "0";
            this.lbltPallets.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(135, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Pallets";
            // 
            // lblPigment
            // 
            this.lblPigment.AutoSize = true;
            this.lblPigment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPigment.Location = new System.Drawing.Point(325, 312);
            this.lblPigment.Name = "lblPigment";
            this.lblPigment.Size = new System.Drawing.Size(14, 13);
            this.lblPigment.TabIndex = 25;
            this.lblPigment.Text = "0";
            this.lblPigment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPigment.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(325, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Pigment";
            this.label10.Visible = false;
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
            // lblCement
            // 
            this.lblCement.AutoSize = true;
            this.lblCement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCement.Location = new System.Drawing.Point(230, 312);
            this.lblCement.Name = "lblCement";
            this.lblCement.Size = new System.Drawing.Size(14, 13);
            this.lblCement.TabIndex = 21;
            this.lblCement.Text = "0";
            this.lblCement.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblCement.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(230, 289);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Cement";
            this.label11.Visible = false;
            // 
            // lblPan
            // 
            this.lblPan.AutoSize = true;
            this.lblPan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPan.Location = new System.Drawing.Point(131, 312);
            this.lblPan.Name = "lblPan";
            this.lblPan.Size = new System.Drawing.Size(14, 13);
            this.lblPan.TabIndex = 19;
            this.lblPan.Text = "0";
            this.lblPan.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblPan.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(131, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Pan";
            this.label9.Visible = false;
            // 
            // lblSand
            // 
            this.lblSand.AutoSize = true;
            this.lblSand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSand.Location = new System.Drawing.Point(20, 312);
            this.lblSand.Name = "lblSand";
            this.lblSand.Size = new System.Drawing.Size(14, 13);
            this.lblSand.TabIndex = 17;
            this.lblSand.Text = "0";
            this.lblSand.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblSand.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Sand";
            this.label7.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "RAW MATERIAL CONSUMED";
            this.label6.Visible = false;
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
            this.cboProducts.Size = new System.Drawing.Size(236, 21);
            this.cboProducts.TabIndex = 5;
            this.cboProducts.SelectedIndexChanged += new System.EventHandler(this.cboProducts_SelectedIndexChanged);
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(115, 71);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(77, 20);
            this.txtQty.TabIndex = 11;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(14, 75);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(26, 13);
            this.lblQty.TabIndex = 10;
            this.lblQty.Text = "Qty";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::AccountSystem.Properties.Resources.exit;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(382, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 4;
            this.button1.Text = "&Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.label3.Text = "Product Damages";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(17, 130);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(98, 16);
            this.label22.TabIndex = 32;
            this.label22.Text = "Damage Remarks";
            // 
            // txtRmks
            // 
            this.txtRmks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRmks.Location = new System.Drawing.Point(17, 149);
            this.txtRmks.MaxLength = 550;
            this.txtRmks.Multiline = true;
            this.txtRmks.Name = "txtRmks";
            this.txtRmks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRmks.Size = new System.Drawing.Size(440, 68);
            this.txtRmks.TabIndex = 31;
            // 
            // frmDamage
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
            this.Name = "frmDamage";
            this.Text = "Product Damages";
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
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label label3;
        private SergeUtils.EasyCompletionComboBox cboProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblPan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSand;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCement;
        private System.Windows.Forms.Label lblPallets;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPigment;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbltPallets;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtRmks;
    }
}

