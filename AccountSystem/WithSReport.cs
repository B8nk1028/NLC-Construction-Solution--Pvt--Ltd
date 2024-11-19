using System;
using System.Windows.Forms;

namespace AccountSystem
{
    public partial class WithSReport : Form
    {
        private MyModule Fn = new MyModule();

        public WithSReport()
        {
            InitializeComponent();

            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }

        #region Default Instance

        private static WithSReport defaultInstance;

        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static WithSReport Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new WithSReport();
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

        private void LedgerReport_Load(object sender, EventArgs e)
        {
            Fn.CenterScreen(this);

            Fn.fillCombo(cboSalesMan, "SELECT Contact_id, ContactName FROM tbl_Account WHERE (CompanyID =" + MyModule.CompID + ") ORDER BY ContactName");
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MyModule.ParmA = "From " + datePicker1.Text + " to " + datePicker2.Text;
            MyModule.ParmB = cboSalesMan.Text;
            MyModule.Parm1 = datePicker1.Text;
            MyModule.Parm2 = datePicker2.Text;
            WithSManV.Default.MdiParent = FrmMain.Default;
            WithSManV.Default.Show();
            //this.Close();
        }
    }
}