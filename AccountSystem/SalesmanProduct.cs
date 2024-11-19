﻿using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace AccountSystem
{
    public partial class SalesmanProduct : Form
    {
        private MyModule Fn = new MyModule();
        private ReportParameter param1 = new ReportParameter();

        public SalesmanProduct()
        {
            InitializeComponent();

            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }

        #region Default Instance

        private static SalesmanProduct defaultInstance;

        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static SalesmanProduct Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new SalesmanProduct();
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

            this.DataTable2TableAdapter.Fill(this.StockRpt.DataTable2, (int)ddSaleman.SelectedValue, datePicker1.Text, datePicker2.Text);

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
            Fn.fillCombo(ddSaleman, "SELECT Contact_id, ContactName FROM tbl_Account where (ContactType = 'Salesmen' or ContactType = 'Employees') and CompanyID = " + MyModule.CompID);
        }
    }
}