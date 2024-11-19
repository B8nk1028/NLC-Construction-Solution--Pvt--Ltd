using System;
using System.Windows.Forms;

namespace AccountSystem
{
    public partial class frmPrintBill
    {
        public frmPrintBill()
        {
            InitializeComponent();

            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }

        #region Default Instance

        private static frmPrintBill defaultInstance;

        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static frmPrintBill Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new frmPrintBill();
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Sale_Invioce.DataTable11' table. You can move, or remove it, as needed.
            this.DataTable11TableAdapter.Fill(this.Sale_Invioce.DataTable11, MyModule.CompID, Convert.ToInt32(txtto.Text), Convert.ToInt32(txtfrm.Text));
            // TODO: This line of code loads data into the 'CompanyLogo.TblCompany' table. You can move, or remove it, as needed.
            this.TblCompanyTableAdapter.Fill(this.CompanyLogo.TblCompany, MyModule.CompID);

            this.reportViewer1.ShowExportButton = true; this.reportViewer1.RefreshReport();
        }

        private void frmPrintBill_Load(object sender, EventArgs e)
        {
        }

        private void txtfrm_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}