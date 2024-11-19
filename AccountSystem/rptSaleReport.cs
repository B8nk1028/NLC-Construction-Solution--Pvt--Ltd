using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
namespace AccountSystem
{
    public partial class rptSaleReport : Form
    {
        private MyModule Fn = new MyModule();
        private ReportParameter param1 = new ReportParameter();
        private ReportParameter param2 = new ReportParameter();
        public rptSaleReport()
        {
            InitializeComponent();
            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }
        #region Default Instance
        private static rptSaleReport defaultInstance;
        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static rptSaleReport Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new rptSaleReport();
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
            
            this.reportViewer1.LocalReport.DataSources.Clear();
            string[] DSet = { "DataSet1", "DataSet2", "DataSet3" };
            string[] SQL = { "sp_SalesReport2 '" + datePicker1.Text + "','" + datePicker2.Text + "','" + cboVendorCustomer.SelectedValue + "','" + cboSalesman.SelectedValue + "'", "SELECT CompanyID, Logo FROM TblCompany WHERE (CompanyID = 1)" , "sp_RetrunReport '" + datePicker1.Text + "','" + datePicker2.Text + "','" + cboVendorCustomer.SelectedValue + "','" + cboSalesman.SelectedValue + "'" };
            DataTable dt = new DataTable();
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AccountSystem.Sale_Report.rdlc";
            for (int i = 0; i < DSet.Length; i++)
            {
                dt = Fn.FillDSet(SQL[i]).Tables[0];
                ReportDataSource datasource = new ReportDataSource(DSet[i], dt);
                this.reportViewer1.LocalReport.DataSources.Add(datasource);
            }
            string companyaddress = Fn.GetRecords("SELECT Address+Char(13)+char(10)+Phone AS Expr1 FROM TblCompany Where CompanyID=" + MyModule.CompID)[0];
            List<ReportParameter> paraList = new List<ReportParameter>
            {
                new ReportParameter("ReportParameter1", " " + datePicker1.Text + " to " + datePicker2.Text,false),
                new ReportParameter("ReportParameter2", MyModule.CompName, false),
                new ReportParameter("ReportParameter3", companyaddress, false),
                new ReportParameter("GPass", chkGatePass.Checked.ToString(), false),
                new ReportParameter("SOrder", chkSaleOrderNo.Checked.ToString(), false),
                new ReportParameter("Rep", chkRep.Checked.ToString(), false),
                new ReportParameter("PTerms", chkPayment.Checked.ToString(), false)
            };
            // Pass Parameters for Local Report
            this.reportViewer1.LocalReport.SetParameters(paraList.ToArray());

            this.reportViewer1.ShowExportButton = true; this.reportViewer1.RefreshReport();
            MyModule.rpt = reportViewer1;
            FrmMain.Default.grpExport.Visible = true;
            
        }
        private void StockRptParm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMain.Default.grpExport.Visible = false;
            FrmMain.Default.grpExportInv.Visible = false;
        }
        private void StockRptParm2_Load(object sender, EventArgs e)
        {
            Fn.fillCombo(cbLocation, "select '%','ALL' union SELECT convert(varchar,EntryAccID), EntryAccName FROM TblAccEntry WHERE (AccType IN (22, 23))");
            Fn.fillCombo(cboSalesman, "select '%','ALL' union SELECT convert(varchar,EntryAccID), EntryAccName FROM TblAccEntry WHERE (AccType = 9)");
            Fn.fillCombo(cboVendorCustomer, "select '%','ALL' union SELECT convert(varchar,EntryAccID), EntryAccName FROM TblAccEntry WHERE (AccType IN (8, 10))");
            Fn.fillCombo(regionComboBox, "select '%','ALL' union SELECT Region, Region AS reg FROM tblLocations GROUP BY Region");
            Fn.fillCombo(cbCity, "select '%','ALL' union SELECT CityNmae,CityNmae cty FROM tblLocations WHERE (Region LIKE '" + regionComboBox.SelectedValue + "')");
            string[] opnset = Fn.GetRecords("SELECT CodeSt,AccYear FROM tblMonthCloseing WHERE (CompID =" + MyModule.CompID + ")");
            datePicker1.Value = Convert.ToDateTime(opnset[1]);

        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.DataSources.Clear();
            string[] DSet = { "DataSet1", "DataSet2" };
            string[] SQL = { "sp_SaleRegister '" + datePicker1.Text + "','" + datePicker2.Text + "','" + cbLocation.SelectedValue + "','" + cboSalesman.SelectedValue + "','" + cbCity.SelectedValue + "','" + regionComboBox.SelectedValue + "','" + cboVendorCustomer.SelectedValue + "'", "SELECT CompanyID, Logo FROM TblCompany WHERE (CompanyID = 1)" };
            DataTable dt = new DataTable();
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AccountSystem.rptSaleRegister2.rdlc";
            for (int i = 0; i < DSet.Length; i++)
            {
                dt = Fn.FillDSet(SQL[i]).Tables[0];
                ReportDataSource datasource = new ReportDataSource(DSet[i], dt);
                this.reportViewer1.LocalReport.DataSources.Add(datasource);
            }
            string companyaddress = Fn.GetRecords("SELECT Address+Char(13)+char(10)+Phone AS Expr1 FROM TblCompany Where CompanyID=" + MyModule.CompID)[0];
            List<ReportParameter> paraList = new List<ReportParameter>
            {
                new ReportParameter("ReportParameter1", " " + datePicker1.Text + " to " + datePicker2.Text,false),
                new ReportParameter("ReportParameter2", MyModule.CompName, false),
                new ReportParameter("ReportParameter3", companyaddress, false)
            };
            // Pass Parameters for Local Report
            this.reportViewer1.LocalReport.SetParameters(paraList.ToArray());

            this.reportViewer1.ShowExportButton = true; this.reportViewer1.RefreshReport();
            MyModule.rpt = reportViewer1;
            FrmMain.Default.grpExport.Visible = true;
        }

        private void btnSaleItems_Click(object sender, EventArgs e)
        {

            this.reportViewer1.LocalReport.DataSources.Clear();
            string[] DSet = { "DataSet1", "DataSet2" };
            string[] SQL = { "sp_SalesReport3 '" + datePicker1.Text + "','" + datePicker2.Text + "','" + cboVendorCustomer.SelectedValue + "','" + cboSalesman.SelectedValue + "'", "SELECT CompanyID, Logo FROM TblCompany WHERE (CompanyID = 1)" };
            DataTable dt = new DataTable();
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AccountSystem.Sale_Report2.rdlc";
            for (int i = 0; i < DSet.Length; i++)
            {
                dt = Fn.FillDSet(SQL[i]).Tables[0];
                ReportDataSource datasource = new ReportDataSource(DSet[i], dt);
                this.reportViewer1.LocalReport.DataSources.Add(datasource);
            }
            string companyaddress = Fn.GetRecords("SELECT Address+Char(13)+char(10)+Phone AS Expr1 FROM TblCompany Where CompanyID=" + MyModule.CompID)[0];
            List<ReportParameter> paraList = new List<ReportParameter>
            {
                new ReportParameter("ReportParameter1", " " + datePicker1.Text + " to " + datePicker2.Text,false),
                new ReportParameter("ReportParameter2", MyModule.CompName, false),
                new ReportParameter("ReportParameter3", companyaddress, false),
                new ReportParameter("ReportParameter4", cboVendorCustomer.Text, false)
            };
            // Pass Parameters for Local Report
            this.reportViewer1.LocalReport.SetParameters(paraList.ToArray());

            this.reportViewer1.ShowExportButton = true; this.reportViewer1.RefreshReport();
            MyModule.rpt = reportViewer1;
            FrmMain.Default.grpExport.Visible = true;
        }
    }
}