using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
namespace AccountSystem
{
    public partial class rptSearchJVs : Form
    {
        private MyModule Fn = new MyModule(); private Words Wrd = new Words();
        private ReportParameter param1 = new ReportParameter();
        private ReportParameter param2 = new ReportParameter();
        public rptSearchJVs()
        {
            InitializeComponent();
            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }
        #region Default Instance
        private static rptSearchJVs defaultInstance;
        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static rptSearchJVs Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new rptSearchJVs();
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
            string vnumber=txtVoucher.Text==""?"%":cboVouType.Text.Split('-')[0]+"/"+ txtVoucher.Text;
            string vamount = txtAmount.Text == "" ? "%" : txtAmount.Text;
            string vcheque= textCheque.Text==""?"%":textCheque.Text;

            string[] DSet = { "DataSet1"};
            string[] SQL = { "sp_SearchVouchers '"+cbLocation.SelectedValue + "','" + vnumber + "','%" + vcheque + "%','" + vamount+"','"+datePicker1.Text+"','"+datePicker2.Text+"'" };
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
                
                new ReportParameter("ReportParameter2", MyModule.CompName, false),
                new ReportParameter("ReportParameter3", companyaddress, false)
            };
            // Pass Parameters for Local Report
            //this.reportViewer1.LocalReport.SetParameters(paraList.ToArray());

            this.reportViewer1.ShowExportButton = true; this.reportViewer1.RefreshReport();
            MyModule.rpt = reportViewer1;
            FrmMain.Default.grpExport.Visible = true;
            
        }
        private void StockRptParm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMain.Default.grpExport.Visible = false;
            FrmMain.Default.grpExportInv.Visible = false;
        }
        private void StockRptParm2_Load(object sender, EventArgs e)
        {

            cboVouType.Text = "JV-   Journal Voucher";
            Fn.fillCombo(cbLocation, "select '%','ANY' union SELECT convert(varchar,EntryAccID), EntryAccName FROM TblAccEntry WHERE (AccType IN (23, 22))");
            string[] opnset = Fn.GetRecords("SELECT CodeSt,AccYear FROM tblMonthCloseing WHERE (CompID =" + MyModule.CompID + ")");
            datePicker1.Value = Convert.ToDateTime(opnset[1]);
            this.TblCompanyTableAdapter.Fill(this.CompanyLogo.TblCompany, MyModule.CompID);
            txtAmount.Text = "";
        }
        private void reportViewer1_Drillthrough(object sender, DrillthroughEventArgs e)
        {
            //string VId=null;
            LocalReport localreport = (LocalReport)e.Report;
            ReportParameterInfoCollection DrillThroughValues = e.Report.GetParameters();
            if (DrillThroughValues.Count == 6)
            {
                this.duplicateGRNTableAdapter.Fill(this.Pur_SalDS.DuplicateGRN, DrillThroughValues[2].Values[0].ToString());

                ReportDataSource datasource = new ReportDataSource("DataSet1", Pur_SalDS.Tables[1]);
                ReportDataSource datasource2 = new ReportDataSource("DataSet2", CompanyLogo.Tables[0]);
                localreport.DataSources.Add(datasource2);
                localreport.DataSources.Add(datasource);
            }
            else
            {
                ReportParameter param1 = new ReportParameter();
                param1 = new ReportParameter("ReportParameter1", Wrd.changeCurrencyToWords(Fn.GetRecords("SELECT SUM(AmountDeb) AS Expr1 FROM VW_VoucherDTL WHERE (VoucherID = '" + DrillThroughValues[2].Values[0].ToString() + "')")[0]), false);
                e.Report.SetParameters(param1);
                this.dataTable1TableAdapter1.Fill(this.JVDataSet.DataTable1, DrillThroughValues[2].Values[0].ToString());

                ReportDataSource datasource = new ReportDataSource("DataSet2", JVDataSet.Tables[0]);
                ReportDataSource datasource2 = new ReportDataSource("DataSet1", CompanyLogo.Tables[0]);
                localreport.DataSources.Add(datasource);
                localreport.DataSources.Add(datasource2);
            }
            localreport.Refresh();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            const int BACKSPACE = 8;
            const int DECIMAL_POINT = 46;
            const int ZERO = 48;
            const int NINE = 57;
            const int NOT_FOUND = -1;

            int keyvalue = (int)e.KeyChar; // not really necessary to cast to int

            if ((keyvalue == BACKSPACE) ||
            ((keyvalue >= ZERO) && (keyvalue <= NINE))) return;
            // Allow the first (but only the first) decimal point
            if ((keyvalue == DECIMAL_POINT) &&
            (txtAmount.Text.IndexOf(".") == NOT_FOUND)) return;
            // Allow nothing else
            e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.DataSources.Clear();

            string[] DSet = { "DataSet1" };
            string[] SQL = { "sp_SearchVouchers2 '" + cbLocation.SelectedValue + "','" + txtFrom.Text + "','" + txtTo.Text + "','" + datePicker1.Text + "','" + datePicker2.Text + "','"+cboVouType.Text.Split('-')[0]+"'" };
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

                new ReportParameter("ReportParameter2", MyModule.CompName, false),
                new ReportParameter("ReportParameter3", companyaddress, false)
            };
            // Pass Parameters for Local Report
            //this.reportViewer1.LocalReport.SetParameters(paraList.ToArray());

            this.reportViewer1.ShowExportButton = true; this.reportViewer1.RefreshReport();
            MyModule.rpt = reportViewer1;
            FrmMain.Default.grpExport.Visible = true;
        }

        private void txtVoucher_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}