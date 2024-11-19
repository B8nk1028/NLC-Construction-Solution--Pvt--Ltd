using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
//
using System.Linq;
using System;
using System.Collections;
using System.Xml.Linq;
using System.Windows.Forms;

namespace AccountSystem
{
	partial class ChangePassword : DevExpress.XtraEditors.XtraForm
		{
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
			{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
			{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.Label1 = new System.Windows.Forms.Label();
            this.SimpleButton8 = new DevExpress.XtraEditors.SimpleButton();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.BtnOK = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtNewRePass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Bookman Old Style", 18F);
            this.Label1.Location = new System.Drawing.Point(12, 21);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(221, 27);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Change Password";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SimpleButton8
            // 
            this.SimpleButton8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpleButton8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SimpleButton8.Appearance.Options.UseFont = true;
            this.SimpleButton8.Appearance.Options.UseForeColor = true;
            this.SimpleButton8.Image = global::AccountSystem.Properties.Resources.exit;
            this.SimpleButton8.Location = new System.Drawing.Point(119, 264);
            this.SimpleButton8.Name = "SimpleButton8";
            this.SimpleButton8.Size = new System.Drawing.Size(84, 24);
            this.SimpleButton8.TabIndex = 6;
            this.SimpleButton8.Text = "&Close";
            this.SimpleButton8.Click += new System.EventHandler(this.SimpleButton8_Click);
            // 
            // PictureBox2
            // 
            this.PictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBox2.BackgroundImage")));
            this.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PictureBox2.Location = new System.Drawing.Point(38, 117);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(23, 20);
            this.PictureBox2.TabIndex = 13;
            this.PictureBox2.TabStop = false;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBox1.BackgroundImage")));
            this.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PictureBox1.Location = new System.Drawing.Point(38, 76);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(23, 20);
            this.PictureBox1.TabIndex = 12;
            this.PictureBox1.TabStop = false;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(61, 117);
            this.PasswordTextBox.MaxLength = 10;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(190, 22);
            this.PasswordTextBox.TabIndex = 11;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.UsernameTextBox.Location = new System.Drawing.Point(61, 76);
            this.UsernameTextBox.MaxLength = 10;
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.ReadOnly = true;
            this.UsernameTextBox.Size = new System.Drawing.Size(190, 21);
            this.UsernameTextBox.TabIndex = 9;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(38, 96);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(173, 20);
            this.PasswordLabel.TabIndex = 10;
            this.PasswordLabel.Text = "Old Password";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(38, 61);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(163, 13);
            this.UsernameLabel.TabIndex = 8;
            this.UsernameLabel.Text = "&User Name";
            this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnOK
            // 
            this.BtnOK.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOK.Appearance.ForeColor = System.Drawing.Color.Green;
            this.BtnOK.Appearance.Options.UseFont = true;
            this.BtnOK.Appearance.Options.UseForeColor = true;
            this.BtnOK.Image = ((System.Drawing.Image)(resources.GetObject("BtnOK.Image")));
            this.BtnOK.Location = new System.Drawing.Point(38, 264);
            this.BtnOK.LookAndFeel.SkinName = "DevExpress Style";
            this.BtnOK.LookAndFeel.UseDefaultLookAndFeel = false;
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 14;
            this.BtnOK.Text = "&Update";
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Location = new System.Drawing.Point(38, 175);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 20);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.Location = new System.Drawing.Point(61, 175);
            this.txtNewPass.MaxLength = 10;
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(190, 22);
            this.txtNewPass.TabIndex = 16;
            this.txtNewPass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "New Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox4.Location = new System.Drawing.Point(38, 217);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(23, 20);
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // txtNewRePass
            // 
            this.txtNewRePass.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewRePass.Location = new System.Drawing.Point(61, 217);
            this.txtNewRePass.MaxLength = 10;
            this.txtNewRePass.Name = "txtNewRePass";
            this.txtNewRePass.Size = new System.Drawing.Size(190, 22);
            this.txtNewRePass.TabIndex = 19;
            this.txtNewRePass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Re-type Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ChangePassword
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 303);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.SimpleButton8);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.txtNewRePass);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.SkinName = "Black";
            this.Name = "ChangePassword";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.About_FormClosing);
            this.Load += new System.EventHandler(this.About_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.Label Label1;
        internal DevExpress.XtraEditors.SimpleButton SimpleButton8;
        private System.ComponentModel.IContainer components;
        internal PictureBox PictureBox2;
        internal PictureBox PictureBox1;
        internal TextBox PasswordTextBox;
        internal TextBox UsernameTextBox;
        internal Label PasswordLabel;
        internal Label UsernameLabel;
        internal DevExpress.XtraEditors.SimpleButton BtnOK;
        internal PictureBox pictureBox3;
        internal TextBox txtNewPass;
        internal Label label2;
        internal PictureBox pictureBox4;
        internal TextBox txtNewRePass;
        internal Label label3;
    }
	
}
