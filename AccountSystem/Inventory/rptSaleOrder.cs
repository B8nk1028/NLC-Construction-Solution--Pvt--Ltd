using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AccountSystem.Inventory
{
    public partial class rptSaleOrder : Form
    {
        private MyModule Fn = new MyModule();
        public rptSaleOrder()
        {
            InitializeComponent();
        }

        private void rptPurchaseOrder_Load(object sender, EventArgs e)
        {

            this.Location = new Point(-5, 0);
            this.reportViewer1.LocalReport.DataSources.Clear();
            string[] DSet = { "DataSet1", "DataSet2" };
            string[] SQL = { "SELECT TblAccEntry.EntryAccName, TblAccEntry.BAddress, TblAccEntry.BContactNo, tbl_Product.Prod_name, SUM(tblDeliveryDetail.prod_qty) AS Prod_qty, tblDeliveryDetail.Prod_rate, tblDeliveryDetail.Disct, tbl_Prod_category.Prod_ctg_name, tbl_Brand.Brand_name, tblDelivery.Sale_bill_no, tblDelivery.Sale_date, tblDelivery.Transport, TblAccEntry_1.EntryAccName AS Saleman, tblDelivery.Remarks, tblDeliveryDetail.PackingDetail, tblDelivery.BilltyNo, tblDelivery.BilltyDT, tblDelivery.ToShip, TblAccEntry_2.EntryAccName AS Branch, TblAccEntry_3.EntryAccName AS Store, tblDelivery.Loading, tblDelivery.CarriageFreight, SUM(tblDeliveryDetail.Tax) AS GST, tbl_Unit.Unit_title, tblPaymentTerms.PaymentTermsTxt FROM tbl_Product INNER JOIN tbl_Brand ON tbl_Product.Brand_id = tbl_Brand.Brand_id INNER JOIN tbl_Prod_category ON tbl_Product.Prod_Catg_id = tbl_Prod_category.Prod_ctg_id INNER JOIN tblDeliveryDetail ON tbl_Product.Prod_id = tblDeliveryDetail.prod_id INNER JOIN tblDelivery ON tblDeliveryDetail.Sale_id = tblDelivery.Sale_id INNER JOIN TblAccEntry ON tblDelivery.Contact_id = TblAccEntry.EntryAccID INNER JOIN TblAccEntry AS TblAccEntry_1 ON tblDelivery.Salesman = TblAccEntry_1.EntryAccID INNER JOIN TblAccEntry AS TblAccEntry_2 ON tblDelivery.BranchID = TblAccEntry_2.EntryAccID INNER JOIN TblAccEntry AS TblAccEntry_3 ON tblDelivery.StoreID = TblAccEntry_3.EntryAccID INNER JOIN tbl_Unit ON tbl_Product.Unit_id = tbl_Unit.Unit_id INNER JOIN tblPaymentTerms ON tblDelivery.PaymentTermsID = tblPaymentTerms.PaymentTermsID WHERE (tblDelivery.Sale_id = "+this.Tag+") GROUP BY TblAccEntry.EntryAccName, TblAccEntry.BAddress, TblAccEntry.BContactNo, tbl_Product.Prod_name, tblDeliveryDetail.Prod_rate, tblDeliveryDetail.Disct, tbl_Prod_category.Prod_ctg_name, tbl_Brand.Brand_name, tblDelivery.Sale_bill_no, tblDelivery.Sale_date, tblDelivery.Transport, TblAccEntry_1.EntryAccName, tblDelivery.Remarks, tblDeliveryDetail.PackingDetail, tblDelivery.BilltyNo, tblDelivery.BilltyDT, tblDelivery.ToShip, TblAccEntry_2.EntryAccName, TblAccEntry_3.EntryAccName, tblDelivery.Loading, tblDelivery.CarriageFreight, tbl_Unit.Unit_title, tblPaymentTerms.PaymentTermsTxt", "SELECT CompanyID, Logo FROM TblCompany WHERE (CompanyID = 1)" };
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
                new ReportParameter("ReportParameter2",MyModule.CompName,false),
                new ReportParameter("ReportParameter3", companyaddress, false),
                new ReportParameter("ReportParameter1", MyModule.TermsCond, false)
            };
            // Pass Parameters for Local Report
            this.reportViewer1.LocalReport.SetParameters(paraList.ToArray());


            //this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = ZoomMode.PageWidth;
            this.reportViewer1.ShowExportButton = true; this.reportViewer1.RefreshReport();
            MyModule.rpt = reportViewer1;
            FrmMain.Default.grpExport.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            reportViewer1.PrintDialog();
        }
    }
}
