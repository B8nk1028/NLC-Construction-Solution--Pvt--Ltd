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
	partial class About : DevExpress.XtraEditors.XtraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.SimpleButton8 = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(12, 18);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(187, 81);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Bookman Old Style", 18F);
            this.Label1.Location = new System.Drawing.Point(216, 35);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(431, 27);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "NLC Construction Solution (Pvt) Ltd";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(557, 64);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(87, 13);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Version 10.1.0.0";
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(9, 180);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(436, 48);
            this.Label3.TabIndex = 3;
            this.Label3.Text = resources.GetString("Label3.Text");
            // 
            // SimpleButton8
            // 
            this.SimpleButton8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpleButton8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SimpleButton8.Appearance.Options.UseFont = true;
            this.SimpleButton8.Appearance.Options.UseForeColor = true;
            this.SimpleButton8.Image = global::AccountSystem.Properties.Resources.exit;
            this.SimpleButton8.Location = new System.Drawing.Point(589, 204);
            this.SimpleButton8.Name = "SimpleButton8";
            this.SimpleButton8.Size = new System.Drawing.Size(84, 24);
            this.SimpleButton8.TabIndex = 6;
            this.SimpleButton8.Text = "&Close";
            this.SimpleButton8.Click += new System.EventHandler(this.SimpleButton8_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(556, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 39);
            this.label4.TabIndex = 7;
            this.label4.Text = "Developed by: \r\nMuhammad Zia ul Islam\r\n+92 300 9040900";
            // 
            // About
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 250);
            this.ControlBox = false;
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.SimpleButton8);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.SkinName = "Black";
            this.Name = "About";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About Us";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.About_FormClosing);
            this.Load += new System.EventHandler(this.About_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.PictureBox PictureBox1;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label3;
        internal DevExpress.XtraEditors.SimpleButton SimpleButton8;
        internal Label label4;
        private System.ComponentModel.IContainer components;
    }
	
}
