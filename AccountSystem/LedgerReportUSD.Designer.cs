namespace AccountSystem
{
    partial class LedgerReportUSD
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
            System.Windows.Forms.Label label6;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LedgerReportUSD));
            this.btnclose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listAccHeads = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.datePicker1 = new System.Windows.Forms.DateTimePicker();
            this.datePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnShow = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.Panel();
            this.btnLgrItems = new System.Windows.Forms.Button();
            this.cbLocation = new System.Windows.Forms.ComboBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(32, 137);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(54, 13);
            label6.TabIndex = 29;
            label6.Text = "Location :";
            // 
            // btnclose
            // 
            this.btnclose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnclose.Location = new System.Drawing.Point(253, 234);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(78, 23);
            this.btnclose.TabIndex = 2;
            this.btnclose.Text = "&Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(22, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 502);
            this.groupBox1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listAccHeads);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(381, 460);
            this.panel2.TabIndex = 14;
            // 
            // listAccHeads
            // 
            this.listAccHeads.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listAccHeads.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listAccHeads.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listAccHeads.FormattingEnabled = true;
            this.listAccHeads.ItemHeight = 16;
            this.listAccHeads.Location = new System.Drawing.Point(0, 0);
            this.listAccHeads.Name = "listAccHeads";
            this.listAccHeads.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listAccHeads.Size = new System.Drawing.Size(381, 460);
            this.listAccHeads.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.DarkOrchid;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 42);
            this.panel1.TabIndex = 13;
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearch.Location = new System.Drawing.Point(0, 18);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(381, 20);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Account Heads";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vendor\r\nLedger Report (USD)";
            // 
            // datePicker1
            // 
            this.datePicker1.CustomFormat = "dd MMMM yyyy";
            this.datePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker1.Location = new System.Drawing.Point(17, 208);
            this.datePicker1.Name = "datePicker1";
            this.datePicker1.Size = new System.Drawing.Size(136, 20);
            this.datePicker1.TabIndex = 0;
            // 
            // datePicker2
            // 
            this.datePicker2.CustomFormat = "dd MMMM yyyy";
            this.datePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker2.Location = new System.Drawing.Point(170, 208);
            this.datePicker2.Name = "datePicker2";
            this.datePicker2.Size = new System.Drawing.Size(136, 20);
            this.datePicker2.TabIndex = 1;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(170, 234);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(78, 23);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "&Ledger(s)";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "General &Enteries";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLgrItems);
            this.groupBox2.Controls.Add(this.cbLocation);
            this.groupBox2.Controls.Add(label6);
            this.groupBox2.Controls.Add(this.pictureBox6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.btnShow);
            this.groupBox2.Controls.Add(this.btnclose);
            this.groupBox2.Controls.Add(this.datePicker1);
            this.groupBox2.Controls.Add(this.datePicker2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(403, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(424, 502);
            this.groupBox2.TabIndex = 10;
            // 
            // btnLgrItems
            // 
            this.btnLgrItems.Location = new System.Drawing.Point(17, 265);
            this.btnLgrItems.Name = "btnLgrItems";
            this.btnLgrItems.Size = new System.Drawing.Size(118, 23);
            this.btnLgrItems.TabIndex = 32;
            this.btnLgrItems.Text = "&Ledger(s) with Items";
            this.btnLgrItems.UseVisualStyleBackColor = true;
            this.btnLgrItems.Visible = false;
            this.btnLgrItems.Click += new System.EventHandler(this.btnLgrItems_Click);
            // 
            // cbLocation
            // 
            this.cbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.Location = new System.Drawing.Point(17, 154);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(309, 21);
            this.cbLocation.TabIndex = 30;
            this.cbLocation.SelectedIndexChanged += new System.EventHandler(this.cbLocation_SelectedIndexChanged);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(17, 134);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(23, 20);
            this.pictureBox6.TabIndex = 31;
            this.pictureBox6.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Period between Dates";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(22, 502);
            this.panel3.TabIndex = 11;
            // 
            // LedgerReportUSD
            // 
            this.AcceptButton = this.btnShow;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnclose;
            this.ClientSize = new System.Drawing.Size(827, 502);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "LedgerReportUSD";
            this.Text = "Ledger Report";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LedgerReportUSD_FormClosing);
            this.Load += new System.EventHandler(this.LedgerReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Panel groupBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker datePicker1;
        public System.Windows.Forms.DateTimePicker datePicker2;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listAccHeads;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.ComboBox cbLocation;
        internal System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnLgrItems;
    }
}