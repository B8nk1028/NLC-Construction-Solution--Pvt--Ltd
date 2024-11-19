using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
namespace AccountSystem
{
    public partial class rptBankReconciliation : Form
    {
        private MyModule Fn = new MyModule();
        private ReportParameter param1 = new ReportParameter();
        private ReportParameter param2 = new ReportParameter();
        public rptBankReconciliation()
        {
            InitializeComponent();
            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }
        #region Default Instance
        private static rptBankReconciliation defaultInstance;
        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static rptBankReconciliation Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new rptBankReconciliation();
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
        private void reloadRpt()
        {
            this.reportViewer1.LocalReport.DataSources.Clear();
            string[] DSet = { "DataSet1", "DataSet2" };
            string[] SQL = { "sp_BankReconiliation '" + cboBank.SelectedValue + "','" +Fn.LastDayOfMonthFromDateTime(datePicker1.Value).ToString("dd MMMM yyyy") + "'", "SELECT CompanyID, Logo FROM TblCompany WHERE (CompanyID = 1)" };
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
                new ReportParameter("ReportParameter1",datePicker1.Text,false),
                new ReportParameter("ReportParameter2", MyModule.CompName, false),
                new ReportParameter("ReportParameter3", companyaddress, false)
            };
            // Pass Parameters for Local Report
            this.reportViewer1.LocalReport.SetParameters(paraList.ToArray());
            this.reportViewer1.ShowExportButton = true; this.reportViewer1.RefreshReport();
            MyModule.rpt = reportViewer1;
            FrmMain.Default.grpExport.Visible = true;
            string[] outs = Fn.GetRecords("SELECT isnull(BankBalance,0),BankRecID FROM tblBankReconHDR WHERE (BankID = " + cboBank.SelectedValue + ") AND (format(RMonth,'MMMM yyyy') = '" + datePicker1.Text + "')");
            txtBankBlance.Value = decimal.Parse(outs[0]);
            btnsavepnl.Tag = outs[1];
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            //var cc = this.reportViewer1.sc
            SHide = new ReportParameter("SHide", "false");
            this.reportViewer1.LocalReport.SetParameters(SHide);
            reloadRpt();
            //this.reportViewer1.AutoScrollPosition = new Point(0, 100);
        }
        private void StockRptParm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMain.Default.grpExport.Visible = false;
            FrmMain.Default.grpExportInv.Visible = false;
        }
        private void StockRptParm2_Load(object sender, EventArgs e)
        {
            datePicker1.Value = Fn.FirstDayOfMonthFromDateTime(DateTime.Now);
            Fn.fillCombo(cboBank, "SELECT convert(varchar,EntryAccID), EntryAccName FROM TblAccEntry WHERE (AccType = 3)");
        }
        private void reportViewer1_Drillthrough(object sender, DrillthroughEventArgs e)
        {
            //this.reportViewer1.AutoScroll = true;
            //var cc = this.reportViewer1.CurrentStatus.CanExport;
            int v = e.Report.GetParameters().Count;
            ReportParameterInfoCollection DrillThroughValues = e.Report.GetParameters();
            if (DrillThroughValues[1].Values[0] == "0")
            {
                Fn.Exec("UPDATE tblBankReconDTL SET RStatus = 1 WHERE (VoucherID = " + DrillThroughValues[0].Values[0] + ") AND (RStatus = 0)");
            }
            else if (DrillThroughValues[1].Values[0] == "1" || DrillThroughValues[1].Values[0] == "2")
            {
                Fn.Exec("UPDATE tblBankReconDTL SET RStatus = 0 WHERE (VoucherID = " + DrillThroughValues[0].Values[0] + ") AND (RStatus = 1)");
            }
            else
            {
                Fn.Exec("DELETE FROM tblBankReconDiffs WHERE (DiffID = " + DrillThroughValues[0].Values[0] + ")");
            }
            reloadRpt();
            e.Cancel = true;
        }
        private void btnUpBankBlance_Click(object sender, EventArgs e)
        {
            Fn.Exec("UPDATE tblBankReconHDR SET BankBalance = '" + txtBankBlance.Value + "' WHERE (BankID = " + cboBank.SelectedValue + ") AND (format(RMonth,'MMMM yyyy') = '" + datePicker1.Text + "')");
            reloadRpt();
        }
        private void btnRecBank_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "Receipts on the bank statement, not in the accounts";
            groupBox1.Tag = "3";
            dtDiffDate.Value = DateTime.Now;
            txtBref.Clear();
            tamount.Value = 0; bkAmt.Value = 0;
            txtObservation.Items.Clear();
            string[] items = { "Bank interest", "Accounting error", "Bank error", "-"};
            txtObservation.Items.AddRange(items);
         
            lblBAmount.Visible = false;
            bkAmt.Visible = false;
            lblCAmount.Text = "Amount";
            pnlRecBank.Visible = true;
        }
        private void btnPayBank_Click(object sender, EventArgs e)
        {
            groupBox1.Text = btnPayBank.Text;
            groupBox1.Tag = "4";
            dtDiffDate.Value = DateTime.Now;
            txtBref.Clear();
            tamount.Value = 0; bkAmt.Value = 0;
            txtObservation.Items.Clear();
            string[] items = { "Bank charges & interest", "Accounting error", "Bank error", "-" };
            txtObservation.Items.AddRange(items);
            lblBAmount.Visible = false;
            bkAmt.Visible = false; lblCAmount.Text = "Amount";
            pnlRecBank.Visible = true;
        }
        private void btnRecDiff_Click(object sender, EventArgs e)
        {
            groupBox1.Text = btnRecDiff.Text;
            groupBox1.Tag = "5";
            dtDiffDate.Value = DateTime.Now;
            txtBref.Clear();
            tamount.Value = 0; bkAmt.Value = 0;
            txtObservation.Items.Clear();
            string[] items = { "Accounting error", "Bank error", "-" };
            txtObservation.Items.AddRange(items);
            lblBAmount.Visible = true;
            bkAmt.Visible = true; lblCAmount.Text = "Accounts Amount";
            pnlRecBank.Visible = true;
        }
        private void btnPayDiff_Click(object sender, EventArgs e)
        {
            groupBox1.Text = btnPayDiff.Text;
            groupBox1.Tag = "6";
            dtDiffDate.Value = DateTime.Now;
            txtBref.Clear();
            tamount.Value = 0;
            bkAmt.Value = 0;
            txtObservation.Items.Clear();
            string[] items = { "Accounting error", "Bank error", "-" };
            txtObservation.Items.AddRange(items);
            lblBAmount.Visible = true;
            bkAmt.Visible = true; lblCAmount.Text = "Accounts Amount";
            pnlRecBank.Visible = true;
        }
        private void btnsavepnl_Click(object sender, EventArgs e)
        {
            pnlRecBank.Hide();
            Fn.Exec("INSERT INTO tblBankReconDiffs (BankRecID, DiffDate, DiffRef, AccAmount, Observation, BankAmount, DiffType) VALUES (" + btnsavepnl.Tag + ", '" + dtDiffDate.Text + "', '" + txtBref.Text + "','" + (groupBox1.Tag.ToString() == "3" ? tamount.Value * -1 : tamount.Value) + "', '" + txtObservation.Text + "', '" + bkAmt.Value + "', " + groupBox1.Tag + ")");
            reloadRpt();
        }
        private void btnpnlcls_Click(object sender, EventArgs e)
        {
            pnlRecBank.Hide();
        }
        ReportParameter SHide = new ReportParameter();
        private void reportViewer1_Print(object sender, ReportPrintEventArgs e)
        {
            SHide = new ReportParameter("SHide", "true");
            this.reportViewer1.LocalReport.SetParameters(SHide);
            this.reportViewer1.Refresh();
        }

        private void reportViewer1_StatusChanged(object sender, EventArgs e)
        {
            //if (reportViewer1.DisplayMode.Equals(DisplayMode.PrintLayout))
            //{
            //    SHide = new ReportParameter("SHide", "true");
            //    this.reportViewer1.LocalReport.SetParameters(SHide);
            //}
            //else
            //{
            //    SHide = new ReportParameter("SHide", "false");
            //    this.reportViewer1.LocalReport.SetParameters(SHide);
            //}
        }
    }
}