using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountSystem
{
    public partial class frmDashboard : Form
    { MyModule Fn = new MyModule();
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDT_ValueChanged(object sender, EventArgs e)
        {
            
        }
        private void FillDash1()
        {
            try
            {
                DataTable dash2 = Fn.FillDSet("sp_StockValue '" + frmDT.Value.ToShortDateString() + "','" + toDT.Value.ToShortDateString() + "','" + cbLocation.SelectedValue + "'").Tables[0];
                lblOpValue.Text = String.Format("Rs. {0:#,#.00}", dash2.Rows[0]["BF"]);
                lblPurch.Text = String.Format("Rs. {0:#,#.00}", dash2.Rows[0]["P"]);
                lblSale.Text = String.Format("Rs. {0:#,#.00;#,#.00}", dash2.Rows[0]["S"]);
                lblTrin.Text = String.Format("Rs. {0:#,#.00}", dash2.Rows[0]["STIN"]);
                lblTrout.Text = String.Format("Rs. {0:#,#.00;#,#.00}", dash2.Rows[0]["STOUT"]);
                Double crntValue = Convert.ToDouble(dash2.Rows[0]["BF"]) + Convert.ToDouble(dash2.Rows[0]["P"]) + Convert.ToDouble(dash2.Rows[0]["S"])+ Convert.ToDouble(dash2.Rows[0]["STIN"])+ Convert.ToDouble(dash2.Rows[0]["STOUT"]);
                lblClose.Text = String.Format("Rs. {0:#,#.00}", crntValue);

                DataTable dash1 = Fn.FillDSet("sp_Daashboard1 '" + frmDT.Value.ToShortDateString() + "','" + toDT.Value.ToShortDateString() + "','" + cbLocation.SelectedValue + "'").Tables[0];
                lblBCOpenning.Text = String.Format("Rs. {0:#,#.00}", dash1.Rows[0][1]);
                lblBCReceipts.Text = String.Format("Rs. {0:#,#.0}", dash1.Rows[2][1]);
                lblBCPayments.Text = String.Format("Rs. {0:#,#.0}", dash1.Rows[1][1]);
                Double crntBC = Convert.ToDouble(dash1.Rows[2][1]) - Convert.ToDouble(dash1.Rows[1][1]) + Convert.ToDouble(dash1.Rows[0][1]);
                lblBCCurrent.Text = String.Format("Rs. {0:#,#.0}", crntBC);

                lblPVOpening.Text = String.Format("Rs. {0:#,#.0}", dash1.Rows[3][1]);
                lblPVPayments.Text = String.Format("Rs. {0:#,#.0}", dash1.Rows[4][1]);
                lblPVReceipts.Text = String.Format("Rs. {0:#,#.0}", dash1.Rows[5][1]);
                Double crntPV = Convert.ToDouble(dash1.Rows[3][1])+ Convert.ToDouble(dash1.Rows[4][1]) - Convert.ToDouble(dash1.Rows[5][1]);
                lblPVCurrent.Text = String.Format("Rs. {0:#,#.0}", crntPV);

                lblRCOpening.Text = String.Format("Rs. {0:#,#.0}", dash1.Rows[6][1]);
                lblRCReceipts.Text = String.Format("Rs. {0:#,#.0}", dash1.Rows[7][1]);
                lblRCPayments.Text = String.Format("Rs. {0:#,#.0}", dash1.Rows[8][1]);
                Double crntRC = Convert.ToDouble(dash1.Rows[6][1]) + Convert.ToDouble(dash1.Rows[8][1]) - Convert.ToDouble(dash1.Rows[7][1]);
                lblRCCurrent.Text = String.Format("Rs. {0:#,#.0}", crntRC);
                try
                {
                    this.advancesPrepaymentsTableAdapter.Fill(this.dataSet3.AdvancesPrepayments, cbLocation.SelectedValue.ToString());
                }
                catch (System.Exception ex)
                {

                }

            }
            catch
            {

            }

        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet3.sp_OverdueInvoices' table. You can move, or remove it, as needed.
            //this.sp_OverdueInvoicesTableAdapter.Fill(this.dataSet3.sp_OverdueInvoices);

            Fn.fillCombo(cbLocation, "select '%','ALL' union SELECT convert(varchar,EntryAccID), EntryAccName FROM TblAccEntry WHERE (AccType IN (22, 23))"); FillDash1();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FillDash1();
        }

        private void btnPurchaseOrder_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmPurchaseOrder>().Count() == 1)
            {
                frmPurchaseOrder.Default.Activate();
            }
            frmPurchaseOrder.Default.MdiParent = FrmMain.Default;
            frmPurchaseOrder.Default.Show();
        }

        private void btnPurchaseInvoice_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmPurchaseInvoice>().Count() == 1)
            {
                frmPurchaseInvoice.Default.Activate();
            }
            frmPurchaseInvoice.Default.MdiParent = FrmMain.Default;
            frmPurchaseInvoice.Default.Show();
        }

        private void btnSaleInvoice_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmSaleInvoiceWlkin>().Count() == 1)
            {
                frmSaleInvoiceWlkin.Default.Activate();
            }
            frmSaleInvoiceWlkin.Default.MdiParent = FrmMain.Default;
            frmSaleInvoiceWlkin.Default.Show();
        }

        private void btnJournalVoucher_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmVouchers>().Count() == 1)
            {
                frmVouchers.Default.Activate();
            }
            frmVouchers.Default.MdiParent = FrmMain.Default;
            frmVouchers.Default.Show();
        }

        private void btnCashPaymentVoucher_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCPV>().Count() == 1)
            {
                frmCPV.Default.Activate();
            }
            frmCPV.Default.MdiParent = FrmMain.Default;
            frmCPV.Default.Show();
        }

        private void btnBankPaymentVoucher_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmBPV>().Count() == 1)
            {
                frmBPV.Default.Activate();
            }
            frmBPV.Default.MdiParent = FrmMain.Default;
            frmBPV.Default.Show();
        }

        private void btnCashReceiptVoucher_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCRV>().Count() == 1)
            {
                frmCRV.Default.Activate();
            }
            frmCRV.Default.MdiParent = FrmMain.Default;
            frmCRV.Default.Show();
        }

        private void btnBankReceiptVoucher_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmBRV>().Count() == 1)
            {
                frmBRV.Default.Activate();
            }
            frmBRV.Default.MdiParent = FrmMain.Default;
            frmBRV.Default.Show();
        }

        private void btnAccountsLedgers_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<LedgerReport>().Count() == 1)
            {
                LedgerReport.Default.Activate();
            }
            LedgerReport.Default.MdiParent = FrmMain.Default;
            LedgerReport.Default.Show();
        }

        private void btnTrialBalance_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<TriBalancParm>().Count() == 1)
            {
                TriBalancParm.Default.Activate();
            }
            TriBalancParm.Default.MdiParent = FrmMain.Default;
            TriBalancParm.Default.Show();
        }

        private void btnInventoryLedgers_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ProdLedgerReport>().Count() == 1)
            {
                ProdLedgerReport.Default.Activate();
            }
            ProdLedgerReport.Default.MdiParent = FrmMain.Default;
            ProdLedgerReport.Default.Show();
        }

        private void btnStockReport_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<rptStockReport>().Count() == 1)
            {
                rptStockReport.Default.Activate();
            }
            //StockRptParm2.Default.MdiParent = this;
            //StockRptParm2.Default.Show();
            rptStockReport.Default.MdiParent = FrmMain.Default;
            rptStockReport.Default.Show();
        }

        private void btnVendorBalances_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<rptVendorBalances>().Count() == 1)
            {
                rptVendorBalances.Default.Activate();
            }
            rptVendorBalances.Default.MdiParent = FrmMain.Default;
            rptVendorBalances.Default.Show();
        }

        private void btnCustomerBalances_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<rptCustomerBalances>().Count() == 1)
            {
                rptCustomerBalances.Default.Activate();
            }
            rptCustomerBalances.Default.MdiParent = FrmMain.Default;
            rptCustomerBalances.Default.Show();
        }

        private void btnDeliveryChallan_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmDeliveryChallan>().Count() == 1)
            {
                frmDeliveryChallan.Default.Activate();
            }
            frmDeliveryChallan.Default.MdiParent = FrmMain.Default;
            frmDeliveryChallan.Default.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<rptOverdueInvoices>().Count() == 1)
            {
                rptOverdueInvoices.Default.Activate();
            }
            rptOverdueInvoices.Default.MdiParent = FrmMain.Default;
            rptOverdueInvoices.Default.Show();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            double total = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells["Expr1"].Value != null)
                {
                   
                       total = total + Convert.ToDouble(dataGridView1.Rows[i].Cells["Expr1"].Value);
                    txtTotal.Text = Convert.ToDouble(total).ToString("#,#.00");
                }
            }
        }
    }
}
