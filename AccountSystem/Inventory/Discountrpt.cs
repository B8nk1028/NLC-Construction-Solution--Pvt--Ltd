using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace AccountSystem
{
    public partial class Discountrpt : Form
    {
        private MyModule Fn = new MyModule();
        private ReportParameter param1 = new ReportParameter();

        public Discountrpt()
        {
            InitializeComponent();

            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }

        #region Default Instance

        private static Discountrpt defaultInstance;

        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static Discountrpt Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new Discountrpt();
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

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            param1 = new ReportParameter("ReportParameter1", "From " + datePicker1.Text + " to " + datePicker2.Text, false);
            this.reportViewer1.LocalReport.SetParameters(param1);
            this.Salesman_DSTableAdapter.Fill(this.WithSalesmanDS.Salesman_DS, ddSaleman.SelectedValue.ToString(), datePicker1.Text, datePicker2.Text);
            // TODO: This line of code loads data into the 'CompanyLogo.TblCompany' table. You can move, or remove it, as needed.
            this.TblCompanyTableAdapter.Fill(this.CompanyLogo.TblCompany, MyModule.CompID);
            this.reportViewer1.ShowExportButton = true; this.reportViewer1.RefreshReport();
            MyModule.rpt = reportViewer1;
            FrmMain.Default.grpExport.Visible = true;
            FrmMain.Default.grpExportInv.Visible = true;
            MyModule.rpt = reportViewer1;
        }

        private void StockRptParm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMain.Default.grpExport.Visible = false;
            FrmMain.Default.grpExportInv.Visible = false;
        }

        private void Discountrpt_Load(object sender, EventArgs e)
        {
            datePicker1.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            Fn.fillCombo(ddSaleman, "select '%','ALL' union SELECT convert(varchar,EntryAccID), EntryAccName FROM TblAccEntry WHERE (AccType IN (22, 23))");
            // TODO: This line of code loads data into the 'WithSalesmanDS.Salesman_DS' table. You can move, or remove it, as needed.
        }
    }
}