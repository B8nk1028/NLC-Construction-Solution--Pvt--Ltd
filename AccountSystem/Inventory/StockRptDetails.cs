using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace AccountSystem
{
    public partial class StockRptDetails : Form
    {
        private MyModule Fn = new MyModule();
        private ReportParameter param1 = new ReportParameter();

        public StockRptDetails()
        {
            InitializeComponent();

            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }

        #region Default Instance

        private static StockRptDetails defaultInstance;

        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static StockRptDetails Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new StockRptDetails();
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
            //    MyModule.ParmA = "From " + datePicker1.Text + " to " + datePicker2.Text;
            //    MyModule.Parm1 = datePicker1.Text;
            //    MyModule.Parm2 = datePicker2.Text;

            //    param1 = new ReportParameter("ReportParameter1", MyModule.ParmA, false);
            //    this.reportViewer1.LocalReport.SetParameters(param1);

            //    this.TblCompanyTableAdapter.Fill(this.CompanyLogo.TblCompany, MyModule.CompID);
            //    this.DataTable1TableAdapter.Fill(this.StockRpt.DataTable1,MyModule.CompID, datePicker2.Value, datePicker1.Value);
            //    this.reportViewer1.ShowExportButton = true; this.reportViewer1.RefreshReport();
            //    MyModule.rpt = reportViewer1;
            //    FrmMain.Default.grpExport.Visible = true;
            //    FrmMain.Default.grpExportInv.Visible = true;
        }

        private void StockRptParm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMain.Default.grpExport.Visible = false;
            FrmMain.Default.grpExportInv.Visible = false;
        }

        //private void reportViewer1_Drillthrough(object sender, DrillthroughEventArgs e)
        //{
        //    ReportParameterInfoCollection DrillThroughValues = e.Report.GetParameters();
        //    LocalReport localreport = (LocalReport)e.Report;
        //    if (DrillThroughValues.Count == 1)
        //    {
        //        e.Report.SetParameters(param1);

        //        // TODO: This line of code loads data into the 'LadgerDataSet.DataTable1' table. You can move, or remove it, as needed.

        //        MyModule.ParmB = Fn.GetRecords("SELECT Prod_id, Prod_name FROM tbl_Product WHERE (Prod_name = '" + DrillThroughValues[0].Values[0].ToString() + "')")[0];

        //        this.dataTable1TableAdapter1.Fill(this.ProdLadger2.DataTable1, MyModule.CompID, Convert.ToDateTime(datePicker1.Value), Convert.ToDateTime(datePicker2.Value), Convert.ToInt32(MyModule.ParmB));

        //        ReportDataSource datasource = new ReportDataSource("DataSet1", ProdLadger2.Tables[0]);
        //        localreport.DataSources.Add(datasource);
        //        ReportDataSource datasource2 = new ReportDataSource("DataSet2", CompanyLogo.Tables[0]);
        //        localreport.DataSources.Add(datasource2);
        //    }
        //    else
        //    {
        //        string bill=DrillThroughValues[0].Values[0].ToString() + " Bill:"+ DrillThroughValues[1].Values[0].ToString();
        //        this.Sal_PurTableAdapter.Fill(this.Pur_SalDS.Sal_Pur, MyModule.CompID, bill);

        //        ReportDataSource datasource = new ReportDataSource("DataSet1", Pur_SalDS.Tables[0]);
        //        ReportDataSource datasource2 = new ReportDataSource("DataSet2", CompanyLogo.Tables[0]);
        //        localreport.DataSources.Add(datasource2);
        //        localreport.DataSources.Add(datasource);

        //    }

        //    localreport.Refresh();
        //}

        private void StockRptParm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'CompanyLogo.TblCompany' table. You can move, or remove it, as needed.
            this.TblCompanyTableAdapter.Fill(this.CompanyLogo.TblCompany, MyModule.CompID);
            MyModule.ParmA = "Till Date: " + datePicker2.Text;
            param1 = new ReportParameter("ReportParameter1", MyModule.ParmA, false);
            this.reportViewer1.LocalReport.SetParameters(param1);
            // TODO: This line of code loads data into the 'WithSalesmanDS.DataTable2' table. You can move, or remove it, as needed.
            this.DataTable2TableAdapter.Fill(this.WithSalesmanDS.DataTable2, datePicker2.Value.Date, MyModule.CompID);
            this.reportViewer1.ShowExportButton = true; this.reportViewer1.RefreshReport();
            MyModule.rpt = reportViewer1;
            FrmMain.Default.grpExport.Visible = true;
            FrmMain.Default.grpExportInv.Visible = true;
        }

        private void btnShow_Click_1(object sender, EventArgs e)
        {
            MyModule.ParmA = "Till Date: " + datePicker2.Text;
            param1 = new ReportParameter("ReportParameter1", MyModule.ParmA, false);
            this.reportViewer1.LocalReport.SetParameters(param1);
            // TODO: This line of code loads data into the 'WithSalesmanDS.DataTable2' table. You can move, or remove it, as needed.
            this.DataTable2TableAdapter.Fill(this.WithSalesmanDS.DataTable2, datePicker2.Value.Date, MyModule.CompID);
            this.reportViewer1.ShowExportButton = true; this.reportViewer1.RefreshReport();
            MyModule.rpt = reportViewer1;
            FrmMain.Default.grpExport.Visible = true;
            FrmMain.Default.grpExportInv.Visible = true;
        }
    }
}