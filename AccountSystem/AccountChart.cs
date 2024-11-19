using System;
using System.Windows.Forms;

namespace AccountSystem
{
    public partial class AccountChart : Form
    {
        public AccountChart()
        {
            InitializeComponent();
            if (defaultInstance == null)
                defaultInstance = this;
        }

        #region Default Instance

        private static AccountChart defaultInstance;

        public static AccountChart Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new AccountChart();
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

        private void AccountChart_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ChartHeads.TblAccEntry' table. You can move, or remove it, as needed.
            this.TblAccEntryTableAdapter.Fill(this.ChartHeads.TblAccEntry, MyModule.CompID);

            this.reportViewer1.ShowExportButton = true; this.reportViewer1.RefreshReport();
            MyModule.rpt = reportViewer1;
            FrmMain.Default.grpExport.Visible = true;
        }

        private void AccountChart_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMain.Default.grpExport.Visible = false;
        }
    }
}