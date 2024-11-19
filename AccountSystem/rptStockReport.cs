using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
namespace AccountSystem
{
    public partial class rptStockReport : Form
    {
        private MyModule Fn = new MyModule();
        private ReportParameter param1 = new ReportParameter();
        private ReportParameter param2 = new ReportParameter();
        public rptStockReport()
        {
            InitializeComponent();
            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }
        #region Default Instance
        private static rptStockReport defaultInstance;
        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static rptStockReport Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new rptStockReport();
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
            string[] SQL = { "sp_StockReport2 '"+ datePicker1.Text + "','"+ datePicker2.Text + "','"+ cbLocation.SelectedValue+ "'", "SELECT CompanyID, Logo FROM TblCompany WHERE (CompanyID = 1)" };
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
            FrmMain.Default.grpExportInv.Visible = true;

        }
        private void StockRptParm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMain.Default.grpExport.Visible = false;
            FrmMain.Default.grpExportInv.Visible = false;
        }
        private void StockRptParm2_Load(object sender, EventArgs e)
        {
            Fn.fillCombo(cbLocation, "select '%','ALL' union SELECT convert(varchar,EntryAccID), EntryAccName FROM TblAccEntry WHERE (AccType IN (22, 21))");
            string[] opnset = Fn.GetRecords("SELECT CodeSt,AccYear FROM tblMonthCloseing WHERE (CompID =" + MyModule.CompID + ")");
            datePicker1.Value = Convert.ToDateTime(opnset[1]);
        }

        private void reportViewer1_Drillthrough(object sender, DrillthroughEventArgs e)
        {
            LocalReport localreport = (LocalReport)e.Report;
            ReportParameterInfoCollection DrillThroughValues = e.Report.GetParameters();

            if (DrillThroughValues.Count == 3 & localreport.ReportEmbeddedResource== "AccountSystem.LadgerSubBill.rdlc")
            {
                DataTable dt1 = Fn.FillDSet("SELECT BType, BillNo, EntryAccName, BAddress, BContactNo, Prod_name, Prod_qty, Prod_rate, Disct, Prod_ctg_name, Brand_name, Sale_bill_no, Sale_date, Saleman, Remarks, DeliveryChNo, DeliveryChDate, Sale_OrderNo,Sale_OrderDT, AdditionalDiscount, CarriageFreight, AmountPaid, PaymentTermsTxt, Transport, BilltyNo, BilltyDT, WlkinName, WlkinContact, WlkinAddress, ToShip, ShipFrom, Contact_id FROM VW_DuplicateBill WHERE(BillNo = '" + DrillThroughValues[2].Values[0].ToString() + "')").Tables[0];
                DataTable dt2 = Fn.FillDSet("SELECT Logo, CompanyName, Address, Phone FROM TblCompany WHERE (CompanyID = 1)").Tables[0];
                ReportDataSource datasource = new ReportDataSource("DataSet1", dt1);
                ReportDataSource datasource2 = new ReportDataSource("DataSet2", dt2);
                localreport.DataSources.Add(datasource2);
                localreport.DataSources.Add(datasource);
            }
         else if (localreport.ReportEmbeddedResource == "AccountSystem.TranferNote.rdlc")
            {


                string[] DSet = { "DataSet1", "DataSet2" };
                string[] SQL = { "sp_TransferNote " + DrillThroughValues[2].Values[0].ToString(), "SELECT CompanyID, Logo FROM TblCompany WHERE (CompanyID = 1)" };
                DataTable dt = new DataTable();
                for (int i = 0; i < DSet.Length; i++)
                {

                    dt = Fn.FillDSet(SQL[i]).Tables[0];
                    ReportDataSource datasource = new ReportDataSource(DSet[i], dt);
                    localreport.DataSources.Add(datasource);
                }
                string companyaddress = Fn.GetRecords("SELECT Address+Char(13)+char(10)+Phone AS Expr1 FROM TblCompany Where CompanyID=" + MyModule.CompID)[0];

                ReportParameter param = new ReportParameter();
                ReportParameter para = new ReportParameter();


                param = new ReportParameter("ReportParameter2", MyModule.CompName, false);
                para = new ReportParameter("ReportParameter3", companyaddress, false);

                localreport.SetParameters(param);
                localreport.SetParameters(para);

            }
            else
            {
                localreport.DataSources.Clear();
                string[] DSet = { "DataSet1", "DataSet2" };
                string[] SQL = { "sp_ProductLadger '" + datePicker1.Text + "','" + datePicker2.Text + "','" + DrillThroughValues[0].Values[0].ToString() + "','" + cbLocation.SelectedValue + "','%'", "SELECT CompanyID, Logo FROM TblCompany WHERE (CompanyID = 1)" };
                DataTable dt = new DataTable();
                for (int i = 0; i < DSet.Length; i++)
                {
                    dt = Fn.FillDSet(SQL[i]).Tables[0];
                    ReportDataSource datasource = new ReportDataSource(DSet[i], dt);
                    localreport.DataSources.Add(datasource);
                }
                string companyaddress = Fn.GetRecords("SELECT Address+Char(13)+char(10)+Phone AS Expr1 FROM TblCompany Where CompanyID=" + MyModule.CompID)[0];
                List<ReportParameter> paraList = new List<ReportParameter>
            {
                new ReportParameter("ReportParameter1", " " + datePicker1.Text + " to " + datePicker2.Text,false),
                new ReportParameter("ReportParameter2", MyModule.CompName, false),
                new ReportParameter("ReportParameter3", companyaddress, false)
            };
                // Pass Parameters for Local Report
                localreport.SetParameters(paraList.ToArray());
            }










            localreport.Refresh();

            }
    }
}