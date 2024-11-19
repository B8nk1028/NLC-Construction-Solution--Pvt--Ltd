using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace AccountSystem
{

    public partial class ChangePassword : XtraForm
    {
        MyModule Fn = new MyModule();
        public ChangePassword()
        {
            InitializeComponent();
            if (defaultInstance == null)
                defaultInstance = this;
        }

        #region Default Instance

        private static ChangePassword defaultInstance;

        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static ChangePassword Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new ChangePassword();
                    defaultInstance.FormClosed += new FormClosedEventHandler(defaultInstance_FormClosed);
                }

                return defaultInstance;
            }
        }

        private static void defaultInstance_FormClosed(object sender, FormClosedEventArgs e)
        {
            defaultInstance = null;
        }

        #endregion Default Instance

        public void About_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            this.Hide();
            this.MdiParent = null;
            Dispose();
        }

        private void SimpleButton8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void About_Load(object sender, EventArgs e)
        {
            UsernameTextBox.Text = MyModule.UserName;

        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (Fn.GetRecords("SELECT UserID FROM TblUser WHERE (UserName = '"+ UsernameTextBox.Text + "') AND (Password = '"+ PasswordTextBox.Text + "')")[0] == "a")
            {
                MessageBox.Show("Incorrect login Information!" + Environment.NewLine + "Please check User Name and Password");
                return;
            }
            if (txtNewPass.Text==txtNewRePass.Text)
            {
                Fn.Exec("UPDATE TblUser SET Password = '"+ txtNewPass.Text + "' WHERE (UserName = '" + UsernameTextBox.Text + "') AND (Password = '" + PasswordTextBox.Text + "')");
                MessageBox.Show("Password updated successfully!" + Environment.NewLine + "Please restart application with new password");
                this.Close();
            }
            else
            {
                MessageBox.Show("Password mismatch!" + Environment.NewLine + "Please check your password");
            }
            
        }
    }
}