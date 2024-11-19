using System;
using System.Data.SqlClient;
using System.Net;
using System.Windows.Forms;
using Value;

namespace AccountSystem
{
    public partial class Regist : Form
    {
        private Barcodes md = new Barcodes();
        private MyDB Fn = new MyDB();
        private MyModule ss = new MyModule();
        private bool chk;

        public Regist()
        {
            InitializeComponent();
        }

        private void Regist_Load(object sender, EventArgs e)
        {
            IPHostEntry h = Dns.GetHostEntry(Dns.GetHostName());
            txtCode.Text = md.Code128(Fn.GetMyId()) + "-" + Environment.UserName + "|" + Environment.MachineName + "|" + h.AddressList.GetValue(0).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtRegis.Text != Fn.GetMyId())
            {
                MessageBox.Show("Registration key not valid ...");
            }
            else
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "UPDATE TblUser SET SoftID = @SoftID";
                cmd.Parameters.AddWithValue("@SoftID", txtRegis.Text);
                ss.CmdExe(cmd);
                chk = true;
                this.Close();
            }
        }

        private void Regist_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (chk == false)
            {
                Application.Exit();
            }
        }
    }
}