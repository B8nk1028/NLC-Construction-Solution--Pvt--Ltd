using System;
using System.Windows.Forms;

namespace AccountSystem
{
    public partial class PO_Invioce : Form
    {
        public PO_Invioce()
        {
            InitializeComponent();
            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }

        #region Default Instance

        private static PO_Invioce defaultInstance;

        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static PO_Invioce Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new PO_Invioce();
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

        private void PO_Invioce_Load(object sender, EventArgs e)
        {
            FrmMain.Default.grpExport.Visible = true;
            FrmMain.Default.grpExportInv.Visible = true;
            // TODO: This line of code loads data into the 'Purch_Invioce.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.Purch_Invioce.DataTable1, MyModule.CompID, MyModule.Parm1);
            // TODO: This line of code loads data into the 'CompanyLogo.TblCompany' table. You can move, or remove it, as needed.
            this.TblCompanyTableAdapter.Fill(this.CompanyLogo.TblCompany, MyModule.CompID);

            this.reportViewer1.ShowExportButton = true; this.reportViewer1.RefreshReport();
            MyModule.rpt = reportViewer1;
        }

        private void PO_Invioce_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMain.Default.grpExport.Visible = false;
            FrmMain.Default.grpExportInv.Visible = false;
        }
    }
}