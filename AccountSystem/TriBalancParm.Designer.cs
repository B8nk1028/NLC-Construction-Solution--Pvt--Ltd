namespace AccountSystem
{
    partial class TriBalancParm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TriBalancParm));
            System.Windows.Forms.Label label6;
            this.datePicker1 = new System.Windows.Forms.DateTimePicker();
            this.datePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnShow = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnclose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.optSix = new System.Windows.Forms.RadioButton();
            this.optTwo = new System.Windows.Forms.RadioButton();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.cbLocation = new System.Windows.Forms.ComboBox();
            label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // datePicker1
            // 
            this.datePicker1.CustomFormat = "dd MMMM yyyy";
            this.datePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker1.Location = new System.Drawing.Point(6, 32);
            this.datePicker1.Name = "datePicker1";
            this.datePicker1.Size = new System.Drawing.Size(136, 20);
            this.datePicker1.TabIndex = 0;
            // 
            // datePicker2
            // 
            this.datePicker2.CustomFormat = "dd MMMM yyyy";
            this.datePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker2.Location = new System.Drawing.Point(159, 32);
            this.datePicker2.Name = "datePicker2";
            this.datePicker2.Size = new System.Drawing.Size(136, 20);
            this.datePicker2.TabIndex = 1;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(229, 171);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(78, 23);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Run &Report";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datePicker1);
            this.groupBox1.Controls.Add(this.datePicker2);
            this.groupBox1.Location = new System.Drawing.Point(82, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 63);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Period between Dates";
            // 
            // btnclose
            // 
            this.btnclose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnclose.Location = new System.Drawing.Point(313, 171);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(78, 23);
            this.btnclose.TabIndex = 4;
            this.btnclose.Text = "&Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.optSix);
            this.groupBox2.Controls.Add(this.optTwo);
            this.groupBox2.Location = new System.Drawing.Point(82, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 35);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // optSix
            // 
            this.optSix.AutoSize = true;
            this.optSix.Checked = true;
            this.optSix.Location = new System.Drawing.Point(163, 12);
            this.optSix.Name = "optSix";
            this.optSix.Size = new System.Drawing.Size(82, 17);
            this.optSix.TabIndex = 1;
            this.optSix.TabStop = true;
            this.optSix.Text = "Six Columns";
            this.optSix.UseVisualStyleBackColor = true;
            // 
            // optTwo
            // 
            this.optTwo.AutoSize = true;
            this.optTwo.Location = new System.Drawing.Point(17, 12);
            this.optTwo.Name = "optTwo";
            this.optTwo.Size = new System.Drawing.Size(89, 17);
            this.optTwo.TabIndex = 0;
            this.optTwo.Text = "Two Columns";
            this.optTwo.UseVisualStyleBackColor = true;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(82, 14);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(23, 20);
            this.pictureBox6.TabIndex = 28;
            this.pictureBox6.TabStop = false;
            // 
            // cbLocation
            // 
            this.cbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.Location = new System.Drawing.Point(82, 34);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(309, 21);
            this.cbLocation.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(97, 17);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(54, 13);
            label6.TabIndex = 26;
            label6.Text = "Location :";
            // 
            // TriBalancParm
            // 
            this.AcceptButton = this.btnShow;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.btnclose;
            this.ClientSize = new System.Drawing.Size(406, 202);
            this.Controls.Add(this.cbLocation);
            this.Controls.Add(label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.pictureBox6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TriBalancParm";
            this.Text = "Trial Balance";
            this.Load += new System.EventHandler(this.TriBalancParm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datePicker1;
        private System.Windows.Forms.DateTimePicker datePicker2;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton optSix;
        private System.Windows.Forms.RadioButton optTwo;
        internal System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.ComboBox cbLocation;
    }
}