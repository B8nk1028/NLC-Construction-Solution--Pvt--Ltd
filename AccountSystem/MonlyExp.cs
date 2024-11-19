using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace AccountSystem
{
    public partial class MonlyExp : Form
    {
        private MyModule Fn = new MyModule();

        public MonlyExp()
        {
            InitializeComponent();
            if (defaultInstance == null)
                defaultInstance = this;
        }

        #region Default Instance

        private static MonlyExp defaultInstance;

        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static MonlyExp Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new MonlyExp();
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

        private void Form1_Load(object sender, EventArgs e)
        {
            Fn.fillCombo(cbLocation, "select '%','ALL' union SELECT convert(varchar,EntryAccID), EntryAccName FROM TblAccEntry WHERE (AccType IN (22, 23))");
            reloadrpt();
        }
        private void reloadrpt()
        {
            TextBox txtyear = new TextBox();
            Fn.GetNum(txtyear, "SELECT convert(varchar,AccYear) FROM tblMonthCloseing WHERE CompID =" + MyModule.CompID);
            string sYear = Convert.ToDateTime(txtyear.Text).ToString("MMMM yyyy");
            string eYear = Convert.ToDateTime(sYear).AddMonths(11).ToString("MMMM yyyy");
            this.TblAccEntryTableAdapter.Fill(this.MonthViseDS.TblAccEntry, Fn.FirstDayOfMonthFromDateTime(Convert.ToDateTime(sYear)), Fn.LastDayOfMonthFromDateTime(Convert.ToDateTime(eYear)), cbLocation.SelectedValue.ToString());
            TextBox txtbox = new TextBox();
            Fn.GetNum(txtbox, "SELECT Address+Char(13)+char(10)+Phone AS Expr1 FROM TblCompany Where CompanyID=" + MyModule.CompID);
            ReportParameter param1 = new ReportParameter();
            ReportParameter param = new ReportParameter();
            ReportParameter para = new ReportParameter();

            param1 = new ReportParameter("ReportParameter1", "Accounting Year from " + sYear + " to " + eYear, false);

            param = new ReportParameter("ReportParameter2", MyModule.CompName, false);
            para = new ReportParameter("ReportParameter3", txtbox.Text, false);
            this.reportViewer1.LocalReport.SetParameters(param1);
            this.reportViewer1.LocalReport.SetParameters(param);
            this.reportViewer1.LocalReport.SetParameters(para);

            this.reportViewer1.ShowExportButton = true; this.reportViewer1.RefreshReport();
            MyModule.rpt = reportViewer1;
            FrmMain.Default.grpExport.Visible = true;
        }
        private void MonlyExp_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMain.Default.grpExport.Visible = false;
        }

        private void cbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            reloadrpt();
        }
    }
}