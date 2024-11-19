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
    public partial class rptPurchaseOrder : Form
    {
        private MyModule Fn = new MyModule();
        public rptPurchaseOrder()
        {
            InitializeComponent();
        }

        private void rptPurchaseOrder_Load(object sender, EventArgs e)
        {

            this.Location = new Point(-5, 0);

            string[] DSet = { "DataSet1", "DataSet2" };
            string[] SQL = { "SELECT TblAccEntry.EntryAccName, TblAccEntry.BAddress, TblAccEntry.BContactNo, tbl_Product.Prod_name, SUM(tblPurchaseO_Detail.Prod_qty) AS Prod_qty, tblPurchaseO_Detail.Prod_rate, tblPurchaseO_Detail.Disct, tbl_Prod_category.Prod_ctg_name, tbl_Brand.Brand_name, tblPurchaseOrder.Purch_bill_no, tblPurchaseOrder.Purch_date FROM tblPurchaseOrder INNER JOIN TblAccEntry ON tblPurchaseOrder.Contact_id = TblAccEntry.EntryAccID INNER JOIN tblPurchaseO_Detail ON tblPurchaseOrder.Purch_id = tblPurchaseO_Detail.Purch_id INNER JOIN tbl_Product ON tblPurchaseO_Detail.Prod_id = tbl_Product.Prod_id INNER JOIN tbl_Brand ON tbl_Product.Brand_id = tbl_Brand.Brand_id INNER JOIN tbl_Prod_category ON tbl_Product.Prod_Catg_id = tbl_Prod_category.Prod_ctg_id WHERE (tblPurchaseOrder.Purch_id = "+this.Tag+") GROUP BY TblAccEntry.EntryAccName, TblAccEntry.BAddress, TblAccEntry.BContactNo, tbl_Product.Prod_name, tblPurchaseO_Detail.Prod_rate, tblPurchaseO_Detail.Disct, tbl_Prod_category.Prod_ctg_name, tbl_Brand.Brand_name, tblPurchaseOrder.Purch_bill_no, tblPurchaseOrder.Purch_date", "SELECT CompanyID, Logo FROM TblCompany WHERE (CompanyID = 1)" };
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
