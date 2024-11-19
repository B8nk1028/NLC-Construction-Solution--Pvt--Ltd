using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
namespace AccountSystem
{
    public partial class rptDispatchRegister : Form
    {
        private MyModule Fn = new MyModule();
        private ReportParameter param1 = new ReportParameter();
        private ReportParameter param2 = new ReportParameter();
        public rptDispatchRegister()
        {
            InitializeComponent();
            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }
        #region Default Instance
        private static rptDispatchRegister defaultInstance;
        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static rptDispatchRegister Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new rptDispatchRegister();
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
            string[] DSet = { "DataSet1", "DataSet2" };
            string[] SQL = { "sp_DispatchRegister '" + datePicker1.Text + "','" + datePicker2.Text + "','"+ cboVendor.SelectedValue+"'", "SELECT CompanyID, Logo FROM TblCompany WHERE (CompanyID = 1)" };
            DataTable dt = new DataTable();
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
        private void StockRptParm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMain.Default.grpExport.Visible = false;
            FrmMain.Default.grpExportInv.Visible = false;
        }
        private void StockRptParm2_Load(object sender, EventArgs e)
        {
            Fn.fillCombo(cbLocation, "select '%','ALL' union SELECT convert(varchar,EntryAccID), EntryAccName FROM TblAccEntry WHERE (AccType IN (22, 23))");

            string[] opnset = Fn.GetRecords("SELECT CodeSt,AccYear FROM tblMonthCloseing WHERE (CompID =" + MyModule.CompID + ")");
            datePicker1.Value = Convert.ToDateTime(opnset[1]);
            Fn.fillCombo(cboVendor, "select '%','ALL' union SELECT convert(varchar,EntryAccID), EntryAccName FROM TblAccEntry WHERE (AccType = 8)");
        }
    }
}