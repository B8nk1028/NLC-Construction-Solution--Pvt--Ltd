namespace AccountSystem
{
    partial class frmProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducts));
            this.lblname = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.lblprice = new System.Windows.Forms.Label();
            this.lblcategory = new System.Windows.Forms.Label();
            this.lblunit = new System.Windows.Forms.Label();
            this.lblbrand = new System.Windows.Forms.Label();
            this.lblbarcode = new System.Windows.Forms.Label();
            this.cobcategory = new System.Windows.Forms.ComboBox();
            this.cobunit = new System.Windows.Forms.ComboBox();
            this.cobbrand = new System.Windows.Forms.ComboBox();
            this.txtbarcode = new System.Windows.Forms.TextBox();
            this.btnProductfind = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.grpbx_product = new System.Windows.Forms.GroupBox();
            this.txtP_Price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDngrLevel = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpbx_product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(11, 22);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(87, 13);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Product Name";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(112, 19);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(353, 20);
            this.txtname.TabIndex = 1;
            // 
            // txtprice
            // 
            this.txtprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(112, 158);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(77, 20);
            this.txtprice.TabIndex = 9;
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.Location = new System.Drawing.Point(11, 161);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(73, 13);
            this.lblprice.TabIndex = 8;
            this.lblprice.Text = "Retail Price";
            // 
            // lblcategory
            // 
            this.lblcategory.AutoSize = true;
            this.lblcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcategory.Location = new System.Drawing.Point(11, 120);
            this.lblcategory.Name = "lblcategory";
            this.lblcategory.Size = new System.Drawing.Size(83, 13);
            this.lblcategory.TabIndex = 6;
            this.lblcategory.Text = "Sub-Category";
            // 
            // lblunit
            // 
            this.lblunit.AutoSize = true;
            this.lblunit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblunit.Location = new System.Drawing.Point(11, 92);
            this.lblunit.Name = "lblunit";
            this.lblunit.Size = new System.Drawing.Size(30, 13);
            this.lblunit.TabIndex = 4;
            this.lblunit.Text = "Unit";
            // 
            // lblbrand
            // 
            this.lblbrand.AutoSize = true;
            this.lblbrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbrand.Location = new System.Drawing.Point(11, 48);
            this.lblbrand.Name = "lblbrand";
            this.lblbrand.Size = new System.Drawing.Size(40, 13);
            this.lblbrand.TabIndex = 2;
            this.lblbrand.Text = "Brand";
            // 
            // lblbarcode
            // 
            this.lblbarcode.AutoSize = true;
            this.lblbarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbarcode.Location = new System.Drawing.Point(264, 224);
            this.lblbarcode.Name = "lblbarcode";
            this.lblbarcode.Size = new System.Drawing.Size(84, 13);
            this.lblbarcode.TabIndex = 14;
            this.lblbarcode.Text = "Product Code";
            this.lblbarcode.Visible = false;
            // 
            // cobcategory
            // 
            this.cobcategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cobcategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cobcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobcategory.FormattingEnabled = true;
            this.cobcategory.Location = new System.Drawing.Point(112, 116);
            this.cobcategory.Name = "cobcategory";
            this.cobcategory.Size = new System.Drawing.Size(163, 21);
            this.cobcategory.TabIndex = 7;
            // 
            // cobunit
            // 
            this.cobunit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cobunit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cobunit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobunit.FormattingEnabled = true;
            this.cobunit.Location = new System.Drawing.Point(112, 89);
            this.cobunit.Name = "cobunit";
            this.cobunit.Size = new System.Drawing.Size(129, 21);
            this.cobunit.TabIndex = 5;
            // 
            // cobbrand
            // 
            this.cobbrand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cobbrand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cobbrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobbrand.FormattingEnabled = true;
            this.cobbrand.Location = new System.Drawing.Point(112, 45);
            this.cobbrand.Name = "cobbrand";
            this.cobbrand.Size = new System.Drawing.Size(353, 21);
            this.cobbrand.TabIndex = 3;
            // 
            // txtbarcode
            // 
            this.txtbarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbarcode.Location = new System.Drawing.Point(365, 221);
            this.txtbarcode.Name = "txtbarcode";
            this.txtbarcode.Size = new System.Drawing.Size(163, 20);
            this.txtbarcode.TabIndex = 15;
            this.txtbarcode.Visible = false;
            // 
            // btnProductfind
            // 
            this.btnProductfind.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductfind.Image = ((System.Drawing.Image)(resources.GetObject("btnProductfind.Image")));
            this.btnProductfind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductfind.Location = new System.Drawing.Point(367, 322);
            this.btnProductfind.Name = "btnProductfind";
            this.btnProductfind.Size = new System.Drawing.Size(87, 26);
            this.btnProductfind.TabIndex = 2;
            this.btnProductfind.Text = "&Find";
            this.btnProductfind.UseVisualStyleBackColor = true;
            this.btnProductfind.Click += new System.EventHandler(this.btnfind_Click_1);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Image = global::AccountSystem.Properties.Resources.save_all;
            this.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsave.Location = new System.Drawing.Point(460, 322);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(87, 26);
            this.btnsave.TabIndex = 3;
            this.btnsave.Text = "&Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // grpbx_product
            // 
            this.grpbx_product.Controls.Add(this.txtP_Price);
            this.grpbx_product.Controls.Add(this.label2);
            this.grpbx_product.Controls.Add(this.label1);
            this.grpbx_product.Controls.Add(this.txtDngrLevel);
            this.grpbx_product.Controls.Add(this.cobcategory);
            this.grpbx_product.Controls.Add(this.lblname);
            this.grpbx_product.Controls.Add(this.txtname);
            this.grpbx_product.Controls.Add(this.txtprice);
            this.grpbx_product.Controls.Add(this.lblprice);
            this.grpbx_product.Controls.Add(this.txtbarcode);
            this.grpbx_product.Controls.Add(this.lblcategory);
            this.grpbx_product.Controls.Add(this.cobbrand);
            this.grpbx_product.Controls.Add(this.lblunit);
            this.grpbx_product.Controls.Add(this.cobunit);
            this.grpbx_product.Controls.Add(this.lblbrand);
            this.grpbx_product.Controls.Add(this.lblbarcode);
            this.grpbx_product.Location = new System.Drawing.Point(82, 58);
            this.grpbx_product.Name = "grpbx_product";
            this.grpbx_product.Size = new System.Drawing.Size(546, 258);
            this.grpbx_product.TabIndex = 1;
            this.grpbx_product.TabStop = false;
            // 
            // txtP_Price
            // 
            this.txtP_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtP_Price.Location = new System.Drawing.Point(112, 184);
            this.txtP_Price.Name = "txtP_Price";
            this.txtP_Price.Size = new System.Drawing.Size(77, 20);
            this.txtP_Price.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Purchase Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Minimum level";
            // 
            // txtDngrLevel
            // 
            this.txtDngrLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDngrLevel.Location = new System.Drawing.Point(112, 221);
            this.txtDngrLevel.Name = "txtDngrLevel";
            this.txtDngrLevel.Size = new System.Drawing.Size(77, 20);
            this.txtDngrLevel.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::AccountSystem.Properties.Resources.exit;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(553, 322);
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
            this.label3.Text = "Product Management";
            // 
            // frmProducts
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
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.grpbx_product);
            this.Controls.Add(this.btnProductfind);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProducts";
            this.Text = "Product Management";
            this.Load += new System.EventHandler(this.frmproduct_Load);
            this.grpbx_product.ResumeLayout(false);
            this.grpbx_product.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label lblcategory;
        private System.Windows.Forms.Label lblunit;
        private System.Windows.Forms.Label lblbrand;
        private System.Windows.Forms.Label lblbarcode;
        private System.Windows.Forms.ComboBox cobcategory;
        private System.Windows.Forms.ComboBox cobunit;
        private System.Windows.Forms.ComboBox cobbrand;
        private System.Windows.Forms.TextBox txtbarcode;
        private System.Windows.Forms.GroupBox grpbx_product;
        public System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btnProductfind;
        private System.Windows.Forms.TextBox txtDngrLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtP_Price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

