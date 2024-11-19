using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace AccountSystem
{
    public partial class StockRptParm2 : Form
    {
        private MyModule Fn = new MyModule();
        private ReportParameter param1 = new ReportParameter();
        private ReportParameter param2 = new ReportParameter();

        public StockRptParm2()
        {
            InitializeComponent();

            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }

        #region Default Instance

        private static StockRptParm2 defaultInstance;

        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static StockRptParm2 Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new StockRptParm2();
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
            MyModule.ParmA = "From " + datePicker1.Text + " to " + datePicker2.Text;
            MyModule.Parm1 = datePicker1.Text;
            MyModule.Parm2 = datePicker2.Text;

            param1 = new ReportParameter("ReportParameter1", MyModule.ParmA, false);
            this.reportViewer1.LocalReport.SetParameters(param1);

            this.TblCompanyTableAdapter.Fill(this.CompanyLogo.TblCompany, MyModule.CompID);
            this.tbl_UnitTableAdapter.Fill(this.StockRpt2.tbl_Unit, MyModule.CompID, datePicker2.Value, datePicker1.Value, cbLocation.SelectedValue.ToString());
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

        private void reportViewer1_Drillthrough(object sender, DrillthroughEventArgs e)
        {
            ReportParameterInfoCollection DrillThroughValues = e.Report.GetParameters();
            LocalReport localreport = (LocalReport)e.Report;
            if (DrillThroughValues.Count == 1)
            {
                e.Report.SetParameters(param1);

                // TODO: This line of code loads data into the 'LadgerDataSet.DataTable1' table. You can move, or remove it, as needed.

                //MyModule.ParmB = Fn.GetRecords("SELECT Prod_id, Prod_name FROM tbl_Product WHERE (Prod_name = '" + DrillThroughValues[0].Values[0].ToString() + "')")[0];
                MyModule.ParmA = "From " + datePicker1.Text + " to " + datePicker2.Text;
                MyModule.ParmB = DrillThroughValues[0].Values[0].ToString();
                //MyModule.Parm1 = datePicker1.Text;
                //MyModule.Parm2 = datePicker2.Text;
                Fn.Exec("delete tmpProductLedger;INSERT INTO tmpProductLedger SELECT tbl_Purchase.Purch_date, tbl_Purchase.Purch_bill_no, TblAccEntry.EntryAccName AS ContactName, tbl_Purchase.Purch_On, tbl_Purchase_Detail.Prod_qty * ISNULL(tbl_Purchase_Detail.Pakg_id, 1) * tbl_Purchase.InvoiceType AS QtyT, (tbl_Purchase_Detail.Prod_rate * tbl_Purchase_Detail.Prod_qty * ISNULL(tbl_Purchase_Detail.Pakg_id, 1) - tbl_Purchase_Detail.Disct) * tbl_Purchase.InvoiceType AS Amount, tbl_Product.Barcode + ' ' + tbl_Product.Prod_name + ' ' + tbl_Brand.Brand_name + ' ' + tbl_Prod_category.Prod_ctg_name AS Prod_name, tbl_Unit.Unit_title, 'Purchase' AS P_S, tbl_Purchase_Detail.Bns FROM tbl_Purchase INNER JOIN tbl_Purchase_Detail ON tbl_Purchase.Purch_id = tbl_Purchase_Detail.Purch_id INNER JOIN tbl_Product ON tbl_Purchase_Detail.Prod_id = tbl_Product.Prod_id INNER JOIN tbl_Unit ON tbl_Product.Unit_id = tbl_Unit.Unit_id INNER JOIN TblAccEntry ON tbl_Purchase.Contact_id = TblAccEntry.EntryAccID INNER JOIN tbl_Brand ON tbl_Product.Brand_id = tbl_Brand.Brand_id INNER JOIN tbl_Prod_category ON tbl_Product.Prod_Catg_id = tbl_Prod_category.Prod_ctg_id WHERE (tbl_Purchase.Purch_date BETWEEN CONVERT(DATETIME, '" + datePicker1.Text + "', 102) AND CONVERT(DATETIME, '" + datePicker2.Text + "', 102)) AND (tbl_Product.Prod_id IN (" + MyModule.ParmB + ")) AND ('Purchase' LIKE '%') AND (convert(varchar,tbl_Purchase.BranchID) like '" + cbLocation.SelectedValue + "') UNION SELECT tbl_Sale.Sale_date, tbl_Sale.Sale_bill_no, TblAccEntry_1.EntryAccName AS ContactName, tbl_Sale.Sale_On, tbl_SaleDetail.prod_qty * - (1 * tbl_Sale.InvoiceType) AS Expr1, (tbl_SaleDetail.Prod_rate * tbl_SaleDetail.prod_qty - tbl_SaleDetail.Disct * tbl_SaleDetail.Prod_rate * tbl_SaleDetail.prod_qty / 100) * - (1 * tbl_Sale.InvoiceType) AS Amount, tbl_Product_1.Barcode + ' ' + tbl_Product_1.Prod_name + ' ' + tbl_Brand_1.Brand_name + ' ' + tbl_Prod_category_1.Prod_ctg_name AS Prod_name, tbl_Unit_1.Unit_title, 'Sale' AS P_S, tbl_SaleDetail.Bns * - 1 AS Expr2 FROM tbl_Sale INNER JOIN tbl_SaleDetail ON tbl_Sale.Sale_id = tbl_SaleDetail.Sale_id INNER JOIN tbl_Product AS tbl_Product_1 ON tbl_SaleDetail.prod_id = tbl_Product_1.Prod_id INNER JOIN tbl_Unit AS tbl_Unit_1 ON tbl_Product_1.Unit_id = tbl_Unit_1.Unit_id INNER JOIN TblAccEntry AS TblAccEntry_1 ON tbl_Sale.Contact_id = TblAccEntry_1.EntryAccID INNER JOIN tbl_Prod_category AS tbl_Prod_category_1 ON tbl_Product_1.Prod_Catg_id = tbl_Prod_category_1.Prod_ctg_id INNER JOIN tbl_Brand AS tbl_Brand_1 ON tbl_Product_1.Brand_id = tbl_Brand_1.Brand_id WHERE (tbl_Product_1.Prod_id IN (" + MyModule.ParmB + ")) AND (tbl_Sale.Sale_date BETWEEN CONVERT(DATETIME, '" + datePicker1.Text + "', 102) AND CONVERT(DATETIME, '" + datePicker2.Text + "', 102)) AND ('Sale' LIKE '%') AND (convert(varchar,tbl_Sale.BranchID) like '" + cbLocation.SelectedValue + "') UNION SELECT MAX(dt) AS Expr8, MAX(Expr1) AS Expr1, Expr3, MAX(Expr2) AS Expr2, SUM(QtyT) AS Expr6, SUM(Amount) AS Expr7, Prod_name, MAX(Expr5) AS Expr5, MAX(P_S) AS Expr9, SUM(Expr6) AS Expr10 FROM (SELECT 0 AS dt, '. ' AS Expr1, 0 AS Expr2, 'Opening (B/F)' AS Expr3, SUM(tbl_Purchase_Detail_1.Prod_qty * ISNULL(tbl_Purchase_Detail_1.Pakg_id, 1) * tbl_Purchase_1.InvoiceType) AS QtyT, SUM(tbl_Purchase_Detail_1.Prod_rate * tbl_Purchase_Detail_1.Prod_qty * ISNULL(tbl_Purchase_Detail_1.Pakg_id, 1) * tbl_Purchase_1.InvoiceType) AS Amount, tbl_Product_2.Barcode + ' ' + tbl_Product_2.Prod_name + ' ' + tbl_Brand_3.Brand_name + ' ' + tbl_Prod_category_3.Prod_ctg_name AS Prod_name, ' .' AS Expr5, '. ' AS P_S, SUM(tbl_Purchase_Detail_1.Bns) AS Expr6 FROM tbl_Purchase AS tbl_Purchase_1 INNER JOIN tbl_Purchase_Detail AS tbl_Purchase_Detail_1 ON tbl_Purchase_1.Purch_id = tbl_Purchase_Detail_1.Purch_id INNER JOIN tbl_Product AS tbl_Product_2 ON tbl_Purchase_Detail_1.Prod_id = tbl_Product_2.Prod_id INNER JOIN tbl_Unit AS tbl_Unit_2 ON tbl_Product_2.Unit_id = tbl_Unit_2.Unit_id INNER JOIN tbl_Brand AS tbl_Brand_3 ON tbl_Product_2.Brand_id = tbl_Brand_3.Brand_id INNER JOIN tbl_Prod_category AS tbl_Prod_category_3 ON tbl_Product_2.Prod_Catg_id = tbl_Prod_category_3.Prod_ctg_id WHERE (tbl_Product_2.Prod_id IN (" + MyModule.ParmB + ")) AND (tbl_Purchase_1.Purch_date < CONVERT(DATETIME, '" + datePicker1.Text + "', 102)) AND ('Purchase' LIKE '%') AND (convert(varchar,tbl_Purchase_1.BranchID) like '" + cbLocation.SelectedValue + "') GROUP BY tbl_Product_2.Barcode + ' ' + tbl_Product_2.Prod_name + ' ' + tbl_Brand_3.Brand_name + ' ' + tbl_Prod_category_3.Prod_ctg_name UNION SELECT 0 AS Expr2, ' .' AS Expr3, 0 AS Expr4, 'Opening (B/F)' AS Expr5, SUM(tbl_SaleDetail_1.prod_qty * - (1 * tbl_Sale_1.InvoiceType)) AS Expr1, SUM(tbl_SaleDetail_1.Prod_rate * tbl_SaleDetail_1.prod_qty * - (1 * tbl_Sale_1.InvoiceType)) AS Amount, tbl_Product_1.Barcode + ' ' + tbl_Product_1.Prod_name + ' ' + tbl_Brand_2.Brand_name + ' ' + tbl_Prod_category_2.Prod_ctg_name AS Expr6, ' .' AS Expr7, '. ' AS P_S, SUM(tbl_SaleDetail_1.Bns * - 1) AS Expr8 FROM tbl_Sale AS tbl_Sale_1 INNER JOIN tbl_SaleDetail AS tbl_SaleDetail_1 ON tbl_Sale_1.Sale_id = tbl_SaleDetail_1.Sale_id INNER JOIN tbl_Product AS tbl_Product_1 ON tbl_SaleDetail_1.prod_id = tbl_Product_1.Prod_id INNER JOIN tbl_Brand AS tbl_Brand_2 ON tbl_Product_1.Brand_id = tbl_Brand_2.Brand_id INNER JOIN tbl_Prod_category AS tbl_Prod_category_2 ON tbl_Product_1.Prod_Catg_id = tbl_Prod_category_2.Prod_ctg_id INNER JOIN tbl_Unit AS tbl_Unit_1 ON tbl_Product_1.Unit_id = tbl_Unit_1.Unit_id WHERE (tbl_Product_1.Prod_id IN (" + MyModule.ParmB + ")) AND (tbl_Sale_1.Sale_date < CONVERT(DATETIME, '" + datePicker1.Text + "', 102)) AND ('Sale' LIKE '%') AND (convert(varchar,tbl_Sale_1.BranchID) like '" + cbLocation.SelectedValue + "') GROUP BY tbl_Product_1.Barcode + ' ' + tbl_Product_1.Prod_name + ' ' + tbl_Brand_2.Brand_name + ' ' + tbl_Prod_category_2.Prod_ctg_name) AS tmp GROUP BY Expr3, Prod_name HAVING (SUM(QtyT) <> 0) ORDER BY tbl_Purchase.Purch_date, P_S");

                //this.dataTable1TableAdapter1.Fill(this.ProdLadger2.DataTable1, MyModule.CompID, Convert.ToDateTime(datePicker1.Value), Convert.ToDateTime(datePicker2.Value), Convert.ToInt32(MyModule.ParmB));
                this.DataTable1TableAdapter.Fill(this.ProductLadger.DataTable1);
                ReportDataSource datasource = new ReportDataSource("DataSet1", ProductLadger.Tables[0]);
                localreport.DataSources.Add(datasource);
                ReportDataSource datasource2 = new ReportDataSource("DataSet2", CompanyLogo.Tables[0]);
                localreport.DataSources.Add(datasource2);
            }
            else
            {
                param2 = new ReportParameter("ReportParameter2", DrillThroughValues[0].Values[0].ToString(), false);
                e.Report.SetParameters(param2);
                //string bill = DrillThroughValues[0].Values[0].ToString() + " Bill:" + DrillThroughValues[1].Values[0].ToString();
                this.Sal_PurTableAdapter.Fill(this.Pur_SalDS.Sal_Pur, DrillThroughValues[1].Values[0].ToString(), MyModule.CompID);

                ReportDataSource datasource = new ReportDataSource("DataSet1", Pur_SalDS.Tables[0]);
                ReportDataSource datasource2 = new ReportDataSource("DataSet2", CompanyLogo.Tables[0]);
                localreport.DataSources.Add(datasource2);
                localreport.DataSources.Add(datasource);
            }

            localreport.Refresh();
        }

        private void StockRptParm2_Load(object sender, EventArgs e)
        {
            Fn.fillCombo(cbLocation, "select '%','ALL' union SELECT convert(varchar,EntryAccID), EntryAccName FROM TblAccEntry WHERE (AccType IN (22, 21))");
            datePicker1.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        }
    }
}