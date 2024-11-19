using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;

using System.Linq;
using System;
using System.Collections;
using System.Xml.Linq;
using System.Windows.Forms;

namespace AccountSystem
{
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")]public partial class LoginForm : System.Windows.Forms.Form
		{
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
			{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}
		
		//Required by the Windows Form Designer
		private System.ComponentModel.Container components = null;
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
			{
            System.Windows.Forms.Label label18;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.BtnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.BtnOK = new DevExpress.XtraEditors.SimpleButton();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.cboUsername = new System.Windows.Forms.ComboBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbLocation = new System.Windows.Forms.ComboBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.cboCompany = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new System.Drawing.Point(13, 108);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(54, 13);
            label18.TabIndex = 55;
            label18.Text = "Location :";
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.LogoPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.BackgroundImage")));
            this.LogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LogoPictureBox.Location = new System.Drawing.Point(12, 20);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(79, 85);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPictureBox.TabIndex = 12;
            this.LogoPictureBox.TabStop = false;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Appearance.ForeColor = System.Drawing.Color.Red;
            this.BtnCancel.Appearance.Options.UseFont = true;
            this.BtnCancel.Appearance.Options.UseForeColor = true;
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancel.Image")));
            this.BtnCancel.Location = new System.Drawing.Point(265, 117);
            this.BtnCancel.LookAndFeel.SkinName = "DevExpress Style";
            this.BtnCancel.LookAndFeel.UseDefaultLookAndFeel = false;
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 4;
            this.BtnCancel.Text = "&Cancel";
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click_1);
            // 
            // BtnOK
            // 
            this.BtnOK.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOK.Appearance.ForeColor = System.Drawing.Color.Green;
            this.BtnOK.Appearance.Options.UseFont = true;
            this.BtnOK.Appearance.Options.UseForeColor = true;
            this.BtnOK.Image = ((System.Drawing.Image)(resources.GetObject("BtnOK.Image")));
            this.BtnOK.Location = new System.Drawing.Point(182, 117);
            this.BtnOK.LookAndFeel.SkinName = "DevExpress Style";
            this.BtnOK.LookAndFeel.UseDefaultLookAndFeel = false;
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 3;
            this.BtnOK.Text = "&OK";
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click_1);
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.cboUsername);
            this.GroupBox1.Controls.Add(this.pictureBox6);
            this.GroupBox1.Controls.Add(label18);
            this.GroupBox1.Controls.Add(this.PictureBox2);
            this.GroupBox1.Controls.Add(this.PictureBox1);
            this.GroupBox1.Controls.Add(this.cbLocation);
            this.GroupBox1.Controls.Add(this.PasswordTextBox);
            this.GroupBox1.Controls.Add(this.PasswordLabel);
            this.GroupBox1.Controls.Add(this.UsernameLabel);
            this.GroupBox1.Location = new System.Drawing.Point(101, 9);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(239, 97);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            // 
            // cboUsername
            // 
            this.cboUsername.FormattingEnabled = true;
            this.cboUsername.Location = new System.Drawing.Point(36, 23);
            this.cboUsername.Name = "cboUsername";
            this.cboUsername.Size = new System.Drawing.Size(190, 21);
            this.cboUsername.TabIndex = 13;
            this.cboUsername.SelectedIndexChanged += new System.EventHandler(this.cboUsername_SelectedIndexChanged);
            this.cboUsername.TextChanged += new System.EventHandler(this.UsernameTextBox_TextChanged);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(13, 124);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(23, 20);
            this.pictureBox6.TabIndex = 56;
            this.pictureBox6.TabStop = false;
            // 
            // PictureBox2
            // 
            this.PictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBox2.BackgroundImage")));
            this.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PictureBox2.Location = new System.Drawing.Point(13, 65);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(23, 20);
            this.PictureBox2.TabIndex = 7;
            this.PictureBox2.TabStop = false;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBox1.BackgroundImage")));
            this.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PictureBox1.Location = new System.Drawing.Point(13, 24);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(23, 20);
            this.PictureBox1.TabIndex = 6;
            this.PictureBox1.TabStop = false;
            // 
            // cbLocation
            // 
            this.cbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.Location = new System.Drawing.Point(36, 124);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(190, 21);
            this.cbLocation.TabIndex = 54;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(36, 65);
            this.PasswordTextBox.MaxLength = 10;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(190, 22);
            this.PasswordTextBox.TabIndex = 3;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(13, 44);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(173, 20);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "&Password";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(13, 9);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(163, 13);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "&User Name";
            this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboCompany
            // 
            this.cboCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCompany.FormattingEnabled = true;
            this.cboCompany.Location = new System.Drawing.Point(106, 226);
            this.cboCompany.Name = "cboCompany";
            this.cboCompany.Size = new System.Drawing.Size(230, 20);
            this.cboCompany.TabIndex = 2;
            this.cboCompany.Visible = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "&Select a Company";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Visible = false;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.BtnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(356, 152);
            this.ControlBox = false;
            this.Controls.Add(this.cboCompany);
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application Security";
            this.Activated += new System.EventHandler(this.LoginForm_Activated);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.Disposed += new System.EventHandler(this.LoginForm_Disposed);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

		}
		internal System.Windows.Forms.PictureBox LogoPictureBox;
		internal DevExpress.XtraEditors.SimpleButton BtnCancel;
		internal DevExpress.XtraEditors.SimpleButton BtnOK;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.PictureBox PictureBox2;
		internal System.Windows.Forms.PictureBox PictureBox1;
		internal System.Windows.Forms.TextBox PasswordTextBox;
		internal System.Windows.Forms.Label PasswordLabel;
		internal System.Windows.Forms.Label UsernameLabel;
        private ComboBox cboCompany;
        internal Label label1;
        internal PictureBox pictureBox6;
        public ComboBox cbLocation;
        private ComboBox cboUsername;
    }
	
}
