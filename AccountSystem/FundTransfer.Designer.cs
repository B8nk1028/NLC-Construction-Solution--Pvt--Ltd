namespace AccountSystem
{
    partial class FundTransfer
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label bankIDLabel;
            System.Windows.Forms.Label label7;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FundTransfer));
            this.btnclose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.datePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnShow = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.Panel();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.bankIDTextBox = new System.Windows.Forms.TextBox();
            this.toAcc = new SergeUtils.EasyCompletionComboBox();
            this.cboAcc = new SergeUtils.EasyCompletionComboBox();
            this.toLocation = new System.Windows.Forms.ComboBox();
            this.cbLocation = new System.Windows.Forms.ComboBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            label6 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            bankIDLabel = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(25, 62);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(54, 13);
            label6.TabIndex = 29;
            label6.Text = "Location :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(337, 64);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(70, 13);
            label3.TabIndex = 33;
            label3.Text = "To Location :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(7, 105);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(79, 13);
            label4.TabIndex = 35;
            label4.Text = "From Account :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(337, 105);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(69, 13);
            label5.TabIndex = 37;
            label5.Text = "To Account :";
            // 
            // bankIDLabel
            // 
            bankIDLabel.AutoSize = true;
            bankIDLabel.Location = new System.Drawing.Point(7, 183);
            bankIDLabel.Name = "bankIDLabel";
            bankIDLabel.Size = new System.Drawing.Size(52, 13);
            bankIDLabel.TabIndex = 38;
            bankIDLabel.Text = "Remarks:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(7, 144);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(46, 13);
            label7.TabIndex = 44;
            label7.Text = "Amount:";
            // 
            // btnclose
            // 
            this.btnclose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnclose.Location = new System.Drawing.Point(94, 232);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(78, 23);
            this.btnclose.TabIndex = 2;
            this.btnclose.Text = "&Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fund Transfer";
            // 
            // datePicker1
            // 
            this.datePicker1.CustomFormat = "dd MMMM yyyy";
            this.datePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker1.Location = new System.Drawing.Point(513, 45);
            this.datePicker1.Name = "datePicker1";
            this.datePicker1.Size = new System.Drawing.Size(136, 20);
            this.datePicker1.TabIndex = 0;
            this.datePicker1.Enter += new System.EventHandler(this.datePicker1_Enter);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(10, 232);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(78, 23);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "&Post";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAmount);
            this.groupBox2.Controls.Add(label7);
            this.groupBox2.Controls.Add(this.bankIDTextBox);
            this.groupBox2.Controls.Add(bankIDLabel);
            this.groupBox2.Controls.Add(label5);
            this.groupBox2.Controls.Add(this.toAcc);
            this.groupBox2.Controls.Add(label4);
            this.groupBox2.Controls.Add(this.cboAcc);
            this.groupBox2.Controls.Add(label3);
            this.groupBox2.Controls.Add(this.toLocation);
            this.groupBox2.Controls.Add(this.cbLocation);
            this.groupBox2.Controls.Add(label6);
            this.groupBox2.Controls.Add(this.pictureBox6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnShow);
            this.groupBox2.Controls.Add(this.btnclose);
            this.groupBox2.Controls.Add(this.datePicker1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(22, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(675, 502);
            this.groupBox2.TabIndex = 10;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(10, 160);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 43;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // bankIDTextBox
            // 
            this.bankIDTextBox.Location = new System.Drawing.Point(10, 198);
            this.bankIDTextBox.MaxLength = 250;
            this.bankIDTextBox.Multiline = true;
            this.bankIDTextBox.Name = "bankIDTextBox";
            this.bankIDTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.bankIDTextBox.Size = new System.Drawing.Size(639, 28);
            this.bankIDTextBox.TabIndex = 39;
            // 
            // toAcc
            // 
            this.toAcc.FormattingEnabled = true;
            this.toAcc.Location = new System.Drawing.Point(340, 120);
            this.toAcc.MatchingMethod = SergeUtils.StringMatchingMethod.UseWildcards;
            this.toAcc.Name = "toAcc";
            this.toAcc.Size = new System.Drawing.Size(309, 21);
            this.toAcc.TabIndex = 36;
            // 
            // cboAcc
            // 
            this.cboAcc.FormattingEnabled = true;
            this.cboAcc.Location = new System.Drawing.Point(10, 120);
            this.cboAcc.MatchingMethod = SergeUtils.StringMatchingMethod.UseWildcards;
            this.cboAcc.Name = "cboAcc";
            this.cboAcc.Size = new System.Drawing.Size(309, 21);
            this.cboAcc.TabIndex = 34;
            // 
            // toLocation
            // 
            this.toLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toLocation.FormattingEnabled = true;
            this.toLocation.Location = new System.Drawing.Point(340, 81);
            this.toLocation.Name = "toLocation";
            this.toLocation.Size = new System.Drawing.Size(309, 21);
            this.toLocation.TabIndex = 32;
            this.toLocation.SelectedIndexChanged += new System.EventHandler(this.toLocation_SelectedIndexChanged);
            // 
            // cbLocation
            // 
            this.cbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.Location = new System.Drawing.Point(10, 81);
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
            this.pictureBox6.Location = new System.Drawing.Point(10, 59);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(23, 20);
            this.pictureBox6.TabIndex = 31;
            this.pictureBox6.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(477, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Date";
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
            // FundTransfer
            // 
            this.AcceptButton = this.btnShow;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnclose;
            this.ClientSize = new System.Drawing.Size(697, 502);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FundTransfer";
            this.Text = "Fund Transfer";
            this.Activated += new System.EventHandler(this.FundTransfer_Activated);
            this.Load += new System.EventHandler(this.LedgerReport_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker datePicker1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Panel groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.ComboBox cbLocation;
        internal System.Windows.Forms.PictureBox pictureBox6;
        public System.Windows.Forms.ComboBox toLocation;
        private SergeUtils.EasyCompletionComboBox toAcc;
        private SergeUtils.EasyCompletionComboBox cboAcc;
        private System.Windows.Forms.TextBox bankIDTextBox;
        private System.Windows.Forms.TextBox txtAmount;
    }
}