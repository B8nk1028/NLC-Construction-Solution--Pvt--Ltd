using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
namespace AccountSystem
{
    public partial class ProdLadgar : Form
    {
        private Words Wrd = new Words();
        private MyModule Fn = new MyModule();
        public ProdLadgar()
        {
            InitializeComponent();
            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }
        #region Default Instance
        private static ProdLadgar defaultInstance;
        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static ProdLadgar Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new ProdLadgar();
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
        private void ProdLadgar_Load(object sender, EventArgs e)
        {

        }
        private void ProdLadgar_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMain.Default.grpExport.Visible = false;
            FrmMain.Default.grpExportInv.Visible = false;
        }
        private void reportViewer1_Drillthrough(object sender, DrillthroughEventArgs e)
        {
            LocalReport localreport = (LocalReport)e.Report;
            ReportParameterInfoCollection DrillThroughValues = e.Report.GetParameters();
            if (DrillThroughValues.Count == 6)
            {
   DataTable dt1=Fn.FillDSet("SELECT BType, BillNo, EntryAccName, BAddress, BContactNo, Prod_name, Prod_qty, Prod_rate, Disct, Prod_ctg_name, Brand_name, Sale_bill_no, Sale_date, Saleman, Remarks, DeliveryChNo, DeliveryChDate, Sale_OrderNo, Sale_OrderDT, AdditionalDiscount, CarriageFreight, AmountPaid, PaymentTermsTxt, Transport, BilltyNo, BilltyDT, WlkinName, WlkinContact, WlkinAddress, ToShip, ShipFrom, Contact_id, Tax, Loading, descPurch FROM VW_DuplicateBill WHERE (BillNo = '" + DrillThroughValues[2].Values[0].ToString() + "')").Tables[0];
   DataTable dt2=Fn.FillDSet("SELECT Logo, CompanyName, Address, Phone FROM TblCompany WHERE (CompanyID = 1)").Tables[0];
                ReportDataSource datasource = new ReportDataSource("DataSet1", dt1);
                ReportDataSource datasource2 = new ReportDataSource("DataSet2", dt2);
                localreport.DataSources.Add(datasource2);
                localreport.DataSources.Add(datasource);
            }
            else
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
            localreport.Refresh();
        }

        private void ProdLadgar_Activated(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.DataSources.Clear();
            string[] DSet = { "DataSet1", "DataSet2" };
            string[] SQL = { "sp_ProductLadger '" + MyModule.Parm1 + "','" + MyModule.Parm2 + "','" + MyModule.ParmB + "','" + MyModule.ParmA + "','" + MyModule.Parm3 + "'", "SELECT CompanyID, Logo FROM TblCompany WHERE (CompanyID = 1)" };
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
                new ReportParameter("ReportParameter1", " " + MyModule.Parm1 + " to " + MyModule.Parm1,false),
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
    }
}