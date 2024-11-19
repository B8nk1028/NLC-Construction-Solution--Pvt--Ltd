using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace AccountSystem
{
    public partial class WithSManV : Form
    {
        public WithSManV()
        {
            InitializeComponent();
            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }

        #region Default Instance

        private static WithSManV defaultInstance;

        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static WithSManV Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new WithSManV();
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

        private void WithSManV_Load(object sender, EventArgs e)
        {
            ReportParameter param1 = new ReportParameter();
            // TODO: This line of code loads data into the 'CompanyLogo.TblCompany' table. You can move, or remove it, as needed.
            this.TblCompanyTableAdapter.Fill(this.CompanyLogo.TblCompany, MyModule.CompID);
            // TODO: This line of code loads data into the 'WithSalesmanDS.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.WithSalesmanDS.DataTable1, Convert.ToDateTime(MyModule.Parm1), Convert.ToDateTime(MyModule.Parm2), MyModule.ParmB, MyModule.CompID);
            param1 = new ReportParameter("ReportParameter1", MyModule.ParmA, false);
            this.reportViewer1.LocalReport.SetParameters(param1);
            this.reportViewer1.ShowExportButton = true; this.reportViewer1.RefreshReport();
            MyModule.rpt = reportViewer1;
            FrmMain.Default.grpExportInv.Visible = true;
        }

        private void WithSManV_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMain.Default.grpExportInv.Visible = false;
        }
    }
}