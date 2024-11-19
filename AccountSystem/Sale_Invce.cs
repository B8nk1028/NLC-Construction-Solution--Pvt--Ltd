using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace AccountSystem
{
    public partial class Sale_Invce : Form
    {
        public Sale_Invce()
        {
            InitializeComponent();
            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }

        #region Default Instance

        private static Sale_Invce defaultInstance;

        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static Sale_Invce Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new Sale_Invce();
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

        private void Sale_Invce_Load(object sender, EventArgs e)
        {
            ReportParameter param1 = new ReportParameter();
            FrmMain.Default.grpExport.Visible = true;
            FrmMain.Default.grpExportInv.Visible = true;
            param1 = new ReportParameter("ReportParameter1", MyModule.Parm2, false);
            this.reportViewer1.LocalReport.SetParameters(param1);
            // TODO: This line of code loads data into the 'Sale_Invioce.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.Sale_Invioce.DataTable1, MyModule.CompID, MyModule.Parm1);
            // TODO: This line of code loads data into the 'CompanyLogo.TblCompany' table. You can move, or remove it, as needed.
            this.TblCompanyTableAdapter.Fill(this.CompanyLogo.TblCompany, MyModule.CompID);

            this.reportViewer1.ShowExportButton = true; this.reportViewer1.RefreshReport();
            MyModule.rpt = reportViewer1;
        }

        private void Sale_Invce_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMain.Default.grpExport.Visible = false;
            FrmMain.Default.grpExportInv.Visible = false;
        }
    }
}