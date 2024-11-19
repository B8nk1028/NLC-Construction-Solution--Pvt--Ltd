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
	partial class SplashScreen : System.Windows.Forms.Form
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
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
			{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.ApplicationTitle = new System.Windows.Forms.Label();
            this.LoadingLbl = new System.Windows.Forms.Label();
            this.LoadTimer = new System.Windows.Forms.Timer(this.components);
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // ApplicationTitle
            // 
            this.ApplicationTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ApplicationTitle.BackColor = System.Drawing.Color.Transparent;
            this.ApplicationTitle.Font = new System.Drawing.Font("Bookman Old Style", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicationTitle.ForeColor = System.Drawing.Color.Black;
            this.ApplicationTitle.Location = new System.Drawing.Point(14, 113);
            this.ApplicationTitle.Name = "ApplicationTitle";
            this.ApplicationTitle.Size = new System.Drawing.Size(439, 29);
            this.ApplicationTitle.TabIndex = 7;
            this.ApplicationTitle.Text = "NLC Construction Solution (Pvt) Ltd";
            // 
            // LoadingLbl
            // 
            this.LoadingLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoadingLbl.BackColor = System.Drawing.Color.Transparent;
            this.LoadingLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadingLbl.ForeColor = System.Drawing.Color.Red;
            this.LoadingLbl.Location = new System.Drawing.Point(41, 184);
            this.LoadingLbl.Name = "LoadingLbl";
            this.LoadingLbl.Size = new System.Drawing.Size(174, 20);
            this.LoadingLbl.TabIndex = 11;
            this.LoadingLbl.Text = "Loading . . .";
            // 
            // LoadTimer
            // 
            this.LoadTimer.Enabled = true;
            this.LoadTimer.Tick += new System.EventHandler(this.LoadTimer_Tick);
            // 
            // PictureBox2
            // 
            this.PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
            this.PictureBox2.Location = new System.Drawing.Point(19, 184);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(16, 16);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox2.TabIndex = 12;
            this.PictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 23);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(185, 78);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Powered by:";
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(483, 214);
            this.ControlBox = false;
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.LoadingLbl);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ApplicationTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.Label ApplicationTitle;
		internal System.Windows.Forms.Label LoadingLbl;
		internal System.Windows.Forms.Timer LoadTimer;
        internal System.Windows.Forms.PictureBox PictureBox2;
        private System.ComponentModel.IContainer components;
        internal PictureBox pictureBox3;
        private Label label1;
    }
	
}
