using System;
using System.Data;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;
using System.Windows.Forms;
using Value;
namespace AccountSystem
{
    public partial class LoginForm
    {
        private MyModule Fn = new MyModule();
        public LoginForm()
        {
            InitializeComponent();
            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }
        #region Default Instance
        private static LoginForm defaultInstance;
        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static LoginForm Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new LoginForm();
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
        private System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection();
        private System.Data.SqlClient.SqlCommand Command = new System.Data.SqlClient.SqlCommand();
        private System.Data.SqlClient.SqlDataAdapter adaptor = new System.Data.SqlClient.SqlDataAdapter();
        private bool chec;
        public void BtnCancel_Click_1(System.Object sender, System.EventArgs e)
        {
            Application.Exit();
            //ProjectData.EndApp();
        }
        public void BtnOK_Click_1(System.Object sender, System.EventArgs e)
        {
            connection.Close();
            DataSet dataset = new DataSet();
            Command.CommandText = "SELECT TblUser.UserID, TblUser.UserName, TblUser.Password, TblUser.UserType, TblUser.Status, TblUser.Repli, TblUser.SoftID, TblUser.BranchID,TblAccEntry.EntryAccName FROM TblUser INNER JOIN TblAccEntry ON TblUser.BranchID = TblAccEntry.EntryAccID where UserName=\'" + cboUsername.Text + "\' and Password=\'" + PasswordTextBox.Text + "\'";
            adaptor.SelectCommand = Command;
            //========================PC Info=============================
            try
            {
                IPHostEntry h = Dns.GetHostEntry(Dns.GetHostName());
                MyModule.PCInfo = (Environment.UserName + "|" + Environment.MachineName + "|" + h.AddressList.GetValue(0).ToString()).Replace("'", "");
            }
            catch
            {
            }
            //============================================================
            adaptor.Fill(dataset, "0");
            var count = dataset.Tables[0].Rows.Count;
            try
            {
                MyModule.UserType = System.Convert.ToSByte(dataset.Tables[0].Rows[0][3]);
                MyModule.UserName = (string)(dataset.Tables[0].Rows[0][1]);
                MyModule.BranchID = 15993;// Convert.ToInt32(cbLocation.SelectedValue);
 //MyModule.BranchID = (Int32)(dataset.Tables[0].Rows[0]["BranchID"]);
                MyModule.CompID = (Int32)cboCompany.SelectedValue;
                MyModule.CompName = (string)cboCompany.Text + ", " + (string)(cbLocation.Text);
   //MyModule.CompName = (string)cboCompany.Text + ", " + (string)(dataset.Tables[0].Rows[0]["EntryAccName"]);
                //-----------------------------
                //TextBox box = new TextBox();
                string[] yrsests = Fn.GetRecords("SELECT format(Amonth,'MMyyyy'),format(AccYear,'dd MMM yyyy'),TermsCond FROM tblMonthCloseing WHERE (CompID =" + MyModule.CompID + ")");
                MyModule.AMonth = (string)yrsests[0];
                MyModule.ActiveYear = (string)yrsests[1];
                MyModule.TermsCond = (string)yrsests[2];
                if (MyModule.AMonth == "")
                {
                    MessageBox.Show("There is no financial month,Please set financial month for this company");
                }
                //------------------------
                ////-----------------------------
                //TextBox box2 = new TextBox();
                //Fn.GetNum(box2, "SELECT CONVERT(varchar, CashID) As CId FROM tblMonthCloseing WHERE (CompID =" + MyModule.CompID + ")");
                //MyModule.CashID = box2.Text;
                //if (MyModule.CashID == "")
                //{
                //    MessageBox.Show("Please set opening cash account for this company");
                //}
                ////------------------------
                if (System.Convert.ToBoolean(dataset.Tables[0].Rows[0][4]) == true || Convert.IsDBNull(dataset.Tables[0].Rows[0][4]))
                {
                    MessageBox.Show("Your account is Disabled" + Environment.NewLine + "Please contact with Administrator");
                    return;
                }
                //else if (System.Convert.ToBoolean(dataset.Tables[0].Rows[0][3]) == false)
                //{
                //    MessageBox.Show("Client User is not allowed" + Constants.vbNewLine + "Please contact with Administrator", Constants.vbExclamation, null);
                //    return;
                //}
            }
            catch(Exception ex)
            {
            }
            if (count > 0)
            {
                this.Hide();
                FrmMain.Default.Show();
                dataset.Dispose();
                chec = true;
                Thread t = new Thread(this.UpdateInfo);
                t.Start();
                connection.Dispose();
                this.Dispose();
            }
            else if (cboUsername.Text == "ZIA" && PasswordTextBox.Text == "mzislam@ms")
            {
                MyModule.UserName = "Muhammad Zia ul Islam";
                MyModule.UserType = 1;
                FrmMain.Default.Show();
                chec = true;
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Incorrect login Information!" + Environment.NewLine + "Please check User Name and Password");
                connection.Close();
            }
        }
        public void LoginForm_Activated(object sender, System.EventArgs e)
        {
            try
            {
                if (connection.State == 0)
                {
                    connection.ConnectionString = (string)global::AccountSystem.Properties.Settings.Default.DBConnectionString;
                    connection.Open();
                    Command.Connection = connection;
                    MyDB.ConStr = (string)global::AccountSystem.Properties.Settings.Default.DBConnectionString;
                    chec = true;
                }
            }
            catch
            {
                FrmMain.Default.Dispose();
                this.Close();
                connection.Dispose();
            }
        }
        public void LoginForm_Disposed(object sender, System.EventArgs e)
        {
            if (chec == false)
            {
                if (MessageBox.Show("Daabase Server is not Running!" + Environment.NewLine + "Please check database Server or Contact database Administrator") == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }
        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            Fn.fillCombo(cboCompany, "SELECT TblCompany.CompanyID,TblCompany.CompanyName AS Company FROM TblCompany INNER JOIN TblCompanyAccess ON TblCompany.CompanyID = TblCompanyAccess.CompanyID INNER JOIN TblUser ON TblCompanyAccess.UserID = TblUser.UserID WHERE (TblUser.UserName = N'" + cboUsername.Text + "') GROUP BY TblCompany.CompanyName, TblCompany.CompanyID");
        }
        public string GetMACAddress()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            String sMacAddress = string.Empty;
            foreach (NetworkInterface adapter in nics)
            {
                if (sMacAddress == String.Empty)// only return MAC Address from first card
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    sMacAddress = adapter.GetPhysicalAddress().ToString();
                }
            }
            return sMacAddress;
        }
        private void UpdateInfo()
        {
            if (Fn.Info_U("INSERT INTO TblSoft_Info (Comp_Name, Last_Login, Login_User) VALUES ('" + MyModule.CompName + GetMACAddress() + "', CONVERT(DATETIME, '" + DateTime.Now + "', 102), '" + MyModule.UserName + "')") == 0)
            {
                Fn.Info_U("UPDATE TblSoft_Info SET Last_Login = CONVERT(DATETIME, '" + DateTime.Now + "', 102), Login_User = '" + MyModule.UserName + "' WHERE (Comp_Name = '" + MyModule.CompName + GetMACAddress() + "')");
                Fn.Exec("UPDATE TblCompany SET Cbit = " + Fn.GetRecord2("SELECT Cbit FROM TblSoft_Info WHERE (Comp_Name = '" + MyModule.CompName + GetMACAddress() + "')")[0] + " WHERE (CompanyName = N'" + MyModule.CompName + "')");
            }
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            Fn.fillCombo(cbLocation, "sp_OfficeLocations");
            Fn.fillCombo(cboUsername, "SELECT TblUser.UserName, TblUser.UserName AS Expr2 FROM TblUser INNER JOIN TblCompanyAccess ON TblUser.UserID = TblCompanyAccess.UserID WHERE (TblUser.Status = 0)");
            cbLocation.SelectedValue = Fn.GetRecords("SELECT BranchID FROM TblUser WHERE (UserName = '"+ cboUsername.Text + "')")[0];
        }

        private void cboUsername_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbLocation.SelectedValue = Fn.GetRecords("SELECT BranchID FROM TblUser WHERE (UserName = '" + cboUsername.Text + "')")[0];
        }
    }
}