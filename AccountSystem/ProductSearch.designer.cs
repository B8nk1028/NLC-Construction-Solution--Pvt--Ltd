namespace AccountSystem
{
    partial class frmfind
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
            this.grdproductsearch = new System.Windows.Forms.DataGridView();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnclose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdproductsearch)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdproductsearch
            // 
            this.grdproductsearch.AllowUserToAddRows = false;
            this.grdproductsearch.AllowUserToDeleteRows = false;
            this.grdproductsearch.AllowUserToResizeColumns = false;
            this.grdproductsearch.AllowUserToResizeRows = false;
            this.grdproductsearch.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdproductsearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdproductsearch.GridColor = System.Drawing.Color.White;
            this.grdproductsearch.Location = new System.Drawing.Point(15, 47);
            this.grdproductsearch.MultiSelect = false;
            this.grdproductsearch.Name = "grdproductsearch";
            this.grdproductsearch.ReadOnly = true;
            this.grdproductsearch.RowHeadersVisible = false;
            this.grdproductsearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdproductsearch.Size = new System.Drawing.Size(381, 233);
            this.grdproductsearch.TabIndex = 0;
            this.grdproductsearch.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grdproductsearch_DataBindingComplete);
            this.grdproductsearch.DoubleClick += new System.EventHandler(this.grdproductsearch_DoubleClick);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(59, 21);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(322, 20);
            this.txtsearch.TabIndex = 1;
            this.txtsearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsearch_KeyPress);
            // 
            // btnclose
            // 
            this.btnclose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Image = global::AccountSystem.Properties.Resources.exit;
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.Location = new System.Drawing.Point(317, 286);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(79, 23);
            this.btnclose.TabIndex = 3;
            this.btnclose.Text = "&Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtsearch);
            this.groupBox1.Controls.Add(this.btnclose);
            this.groupBox1.Controls.Add(this.grdproductsearch);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 315);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // frmfind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnclose;
            this.ClientSize = new System.Drawing.Size(435, 339);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmfind";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find Product";
            this.Load += new System.EventHandler(this.frmfind_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdproductsearch)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdproductsearch;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}