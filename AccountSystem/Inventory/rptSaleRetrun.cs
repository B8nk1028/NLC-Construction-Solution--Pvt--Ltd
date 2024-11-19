﻿using Microsoft.Reporting.WinForms;
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
    public partial class rptSaleRetrun : Form
    {
        private MyModule Fn = new MyModule();
        public rptSaleRetrun()
        {
            InitializeComponent();
        }

        private void rptPurchaseOrder_Load(object sender, EventArgs e)
        {

            this.Location = new Point(-5, 0);

            string[] DSet = { "DataSet1", "DataSet2" };
            string[] SQL = { "SELECT TblAccEntry.EntryAccName, TblAccEntry.BAddress, TblAccEntry.BContactNo, tbl_Product.Prod_name, SUM(tbl_SaleDetail.prod_qty) AS Prod_qty, tbl_SaleDetail.Prod_rate, tbl_SaleDetail.Disct, tbl_Prod_category.Prod_ctg_name, tbl_Brand.Brand_name, tbl_Sale.Sale_bill_no, tbl_Sale.Sale_date, TblAccEntry_1.EntryAccName AS Saleman, tbl_Sale.Remarks, tbl_Sale.Sale_OrderNo, tbl_Sale.Sale_OrderDT, tbl_Sale.DeliveryChDate, tbl_Sale.DeliveryChNo, tbl_Sale.CarriageFreight, tbl_Sale.AmountPaid, tblPaymentTerms.PaymentTermsTxt, tbl_Sale.Transport, tbl_SaleDetail.PackingDetail, tbl_Sale.WlkinName, tbl_Sale.WlkinContact, tbl_Sale.WlkinAddress, tbl_Sale.Contact_id FROM tbl_Sale INNER JOIN TblAccEntry AS TblAccEntry_1 ON tbl_Sale.Salesman = TblAccEntry_1.EntryAccID INNER JOIN tbl_SaleDetail INNER JOIN tbl_Product INNER JOIN tbl_Brand ON tbl_Product.Brand_id = tbl_Brand.Brand_id INNER JOIN tbl_Prod_category ON tbl_Product.Prod_Catg_id = tbl_Prod_category.Prod_ctg_id ON tbl_SaleDetail.prod_id = tbl_Product.Prod_id ON tbl_Sale.Sale_id = tbl_SaleDetail.Sale_id INNER JOIN TblAccEntry ON tbl_Sale.Contact_id = TblAccEntry.EntryAccID LEFT OUTER JOIN tblPaymentTerms ON tbl_Sale.PaymentTermsID = tblPaymentTerms.PaymentTermsID WHERE (tbl_Sale.Sale_id = "+this.Tag+") GROUP BY TblAccEntry.EntryAccName, TblAccEntry.BAddress, TblAccEntry.BContactNo, tbl_Product.Prod_name, tbl_SaleDetail.Prod_rate, tbl_SaleDetail.Disct, tbl_Prod_category.Prod_ctg_name, tbl_Brand.Brand_name, tbl_Sale.Sale_bill_no, tbl_Sale.Sale_date, TblAccEntry_1.EntryAccName, tbl_Sale.Remarks, tbl_Sale.Sale_OrderNo, tbl_Sale.Sale_OrderDT, tbl_Sale.DeliveryChDate, tbl_Sale.DeliveryChNo, tbl_Sale.CarriageFreight, tbl_Sale.AmountPaid, tblPaymentTerms.PaymentTermsTxt, tbl_Sale.Transport, tbl_SaleDetail.PackingDetail, tbl_Sale.WlkinName, tbl_Sale.WlkinContact, tbl_Sale.WlkinAddress, tbl_Sale.Contact_id", "SELECT CompanyID, Logo FROM TblCompany WHERE (CompanyID = 1)" };
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