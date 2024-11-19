using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
namespace AccountSystem
{
    public partial class DayClosing : Form
    {
        private MyModule Fn = new MyModule();
        private ReportParameter param1 = new ReportParameter();
        private ReportParameter param2 = new ReportParameter();
        public DayClosing()
        {
            InitializeComponent();
            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }
        #region Default Instance
        private static DayClosing defaultInstance;
        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static DayClosing Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new DayClosing();
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
        private void StockRptParm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMain.Default.grpExport.Visible = false;
            FrmMain.Default.grpExportInv.Visible = false;
        }
        private void StockRptParm2_Load(object sender, EventArgs e)
        {
            string[] actDate = Fn.GetRecords("sp_ActiveDates");
            
            datePicker1.MaxDate = Convert.ToDateTime(actDate[1]);
            datePicker1.MinDate = Convert.ToDateTime(actDate[0]);
            datePicker1.Value=Convert.ToDateTime(actDate[1]);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (datePicker1.Value== datePicker1.MaxDate)
            {
                Fn.Exec("UPDATE tblMonthCloseing SET ActiveDay = DATEADD(DAY, 1,'"+ datePicker1.Value + "')");
                
                MessageBox.Show("Day successfully closed"+Environment.NewLine+ "Please take backup before exit", "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.reportViewer1.PrintDialog();
                this.Close();
            }else
	{
             MessageBox.Show("Day already closed"+Environment.NewLine+ "or date is not valid", "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
	}
        }

        private void datePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.DataSources.Clear();
            string[] DSet = { "DataSet1", "DataSet2" };
            string[] SQL = { "sp_DayClosing '" + datePicker1.Text + "'", "SELECT CompanyID, Logo FROM TblCompany WHERE (CompanyID = 1)" };
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
                new ReportParameter("ReportParameter1", "Closing Day : " + datePicker1.Text ,false),
                new ReportParameter("ReportParameter2", MyModule.CompName, false),
                new ReportParameter("ReportParameter3", companyaddress, false)
            };
            // Pass Parameters for Local Report
            this.reportViewer1.LocalReport.SetParameters(paraList.ToArray());

            this.reportViewer1.ShowExportButton = true; this.reportViewer1.RefreshReport();
            MyModule.rpt = reportViewer1;
            FrmMain.Default.grpExport.Visible = true;
        }
    }
}