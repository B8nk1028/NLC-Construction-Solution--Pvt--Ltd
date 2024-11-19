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
    public partial class rptGRNReturn : Form
    {
        private MyModule Fn = new MyModule();
        public rptGRNReturn()
        {
            InitializeComponent();
        }

        private void rptPurchaseOrder_Load(object sender, EventArgs e)
        {

            this.Location = new Point(-5, 0);

            string[] DSet = { "DataSet1", "DataSet2" };
            string[] SQL = { "SELECT TblAccEntry.EntryAccName, TblAccEntry.BAddress, TblAccEntry.BContactNo, tbl_Product.Prod_name, SUM(tbl_Purchase_Detail.Prod_qty) AS Prod_qty, tbl_Purchase_Detail.Prod_rate, tbl_Purchase_Detail.Disct,   tbl_Prod_category.Prod_ctg_name, tbl_Brand.Brand_name, tbl_Purchase.Purch_bill_no, tbl_Purchase.Purch_date, tbl_Purchase.Purch_OrderNo, tbl_Purchase.PurchaseOrderDate, tbl_Purchase.VendorInvoice,   tbl_Purchase.VendorInvoiceDate, tbl_Purchase.AdditionalDiscount, tbl_Purchase.CarriageFreight, tbl_Purchase.AmountPaid, TblAccEntry_1.EntryAccName AS bank, tbl_Purchase.Remarks FROM tbl_Purchase INNER JOIN  TblAccEntry ON tbl_Purchase.Contact_id = TblAccEntry.EntryAccID INNER JOIN  tbl_Purchase_Detail ON tbl_Purchase.Purch_id = tbl_Purchase_Detail.Purch_id INNER JOIN  tbl_Product ON tbl_Purchase_Detail.Prod_id = tbl_Product.Prod_id INNER JOIN  tbl_Brand ON tbl_Product.Brand_id = tbl_Brand.Brand_id INNER JOIN  tbl_Prod_category ON tbl_Product.Prod_Catg_id = tbl_Prod_category.Prod_ctg_id INNER JOIN  TblAccEntry AS TblAccEntry_1 ON tbl_Purchase.AccEntryID = TblAccEntry_1.EntryAccID WHERE (tbl_Purchase.Purch_id = "+this.Tag+") GROUP BY TblAccEntry.EntryAccName, TblAccEntry.BAddress, TblAccEntry.BContactNo, tbl_Product.Prod_name, tbl_Purchase_Detail.Prod_rate, tbl_Purchase_Detail.Disct, tbl_Prod_category.Prod_ctg_name, tbl_Brand.Brand_name,   tbl_Purchase.Purch_bill_no, tbl_Purchase.Purch_date, tbl_Purchase.Purch_OrderNo, tbl_Purchase.PurchaseOrderDate, tbl_Purchase.VendorInvoice, tbl_Purchase.VendorInvoiceDate, tbl_Purchase.AdditionalDiscount,   tbl_Purchase.CarriageFreight, tbl_Purchase.AmountPaid, TblAccEntry_1.EntryAccName, tbl_Purchase.Remarks", "SELECT CompanyID, Logo FROM TblCompany WHERE (CompanyID = 1)" };
            DataTable dt = new DataTable();
            for (int i = 0; i < DSet.Length; i++)
            {

                dt = Fn.FillDSet(SQL[i]).Tables[0];
                ReportDataSource datasource = new ReportDataSource(DSet[i], dt);
                this.reportViewer1.LocalReport.DataSources.Add(datasource);
            }
            string companyaddress = Fn.GetRecords("SELECT Address+Char(13)+char(10)+Phone AS Expr1 FROM TblCompany Where CompanyID=" + MyModule.CompID)[0];

            ReportParameter param = new ReportParameter();
            ReportParameter para = new ReportParameter();


            param = new ReportParameter("ReportParameter2", MyModule.CompName, false);
            para = new ReportParameter("ReportParameter3", companyaddress, false);

            this.reportViewer1.LocalReport.SetParameters(param);
            this.reportViewer1.LocalReport.SetParameters(para);

            //this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = ZoomMode.PageWidth;
            this.reportViewer1.ShowExportButton = true; this.reportViewer1.RefreshReport();
     
            //this.reportViewer1.PrintDialog();
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
