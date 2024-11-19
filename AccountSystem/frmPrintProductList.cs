using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
namespace AccountSystem
{
    public partial class frmPrintProductList : Form
    {
        private MyModule Fn = new MyModule();
        private ReportParameter param1 = new ReportParameter();
        private ReportParameter param2 = new ReportParameter();
        public frmPrintProductList()
        {
            InitializeComponent();
            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }
        #region Default Instance
        private static frmPrintProductList defaultInstance;
        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static frmPrintProductList Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new frmPrintProductList();
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
            
        }
        private void StockRptParm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMain.Default.grpExport.Visible = false;
            FrmMain.Default.grpExportInv.Visible = false;
        }

        private void frmPrintProductList_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.DataSources.Clear();
            string[] DSet = { "DataSet1", "DataSet2" };
            string[] SQL = { "SELECT tbl_Product.Prod_name, tbl_Product_1.Prod_name AS item, tbl_ProductRecipe.qty, tbl_ProductRecipe.amt, tbl_ProductRecipe.rate, tbl_Unit.Unit_title AS itemU, tbl_Unit_1.Unit_title AS Unit FROM tbl_Product INNER JOIN tbl_ProductRecipe ON tbl_Product.Prod_id = tbl_ProductRecipe.Prod_id INNER JOIN tbl_Product AS tbl_Product_1 ON tbl_ProductRecipe.rProd_id = tbl_Product_1.Prod_id INNER JOIN tbl_Unit ON tbl_Product_1.Unit_id = tbl_Unit.Unit_id INNER JOIN tbl_Unit AS tbl_Unit_1 ON tbl_Product.Unit_id = tbl_Unit_1.Unit_id ORDER BY tbl_Product.Prod_name", "SELECT CompanyID, Logo FROM TblCompany WHERE (CompanyID = 1)" };
            DataTable dt = new DataTable();
            for (int i = 0; i < DSet.Length; i++)
            {
                dt = Fn.FillDSet(SQL[i]).Tables[0];
                ReportDataSource datasource = new ReportDataSource(DSet[i], dt);
                this.reportViewer1.LocalReport.DataSources.Add(datasource);
            }
            //string companyaddress = Fn.GetRecords("SELECT Address+Char(13)+char(10)+Phone AS Expr1 FROM TblCompany Where CompanyID=" + MyModule.CompID)[0];
            List<ReportParameter> paraList = new List<ReportParameter>
            {

                new ReportParameter("ReportParameter1", MyModule.CompName, false)
                //new ReportParameter("ReportParameter3", companyaddress, false)
            };
            // Pass Parameters for Local Report
            this.reportViewer1.LocalReport.SetParameters(paraList.ToArray());

            this.reportViewer1.ShowExportButton = true; this.reportViewer1.RefreshReport();
            MyModule.rpt = reportViewer1;
            FrmMain.Default.grpExport.Visible = true;
        }
    }
}