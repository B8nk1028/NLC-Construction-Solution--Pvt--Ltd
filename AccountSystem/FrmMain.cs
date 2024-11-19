using DevExpress.LookAndFeel;
using DevExpress.XtraBars;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using Tulpep.NotificationWindow;
using Value;
namespace AccountSystem
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private MyDB fn = new MyDB();
        private MyModule Fn = new MyModule();
        bool backupchk;
        #region Default Instance
        private static FrmMain defaultInstance;
        public static FrmMain Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new FrmMain();
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
        public FrmMain()
        {
            InitializeComponent();
            if (defaultInstance == null)
                defaultInstance = this;
            //DevExpress.UserSkins.OfficeSkins.Register();
            DevExpress.UserSkins.BonusSkins.Register();
            //Springtime,Stardust,Valentine,McSkin,Dark Side,Coffee,DevExpress Style,Black
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
        }
        private void btnEntrAcc_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<frmEntryAcc>().Count() == 1)
            {
                frmEntryAcc.Default.Activate();
            }
            frmEntryAcc.Default.MdiParent = this;
            frmEntryAcc.Default.Show();
        }
        private void btnChartAcc_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<frmChartAccounts>().Count() == 1)
            {
                frmChartAccounts.Default.Activate();
            }
            frmChartAccounts.Default.MdiParent = this;
            frmChartAccounts.Default.Show();
            //frmAcHead.Default.MdiParent = this;
            //frmAcHead.Default.Show();
        }
        private void btnSubAcc_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<frmAcSubHead>().Count() == 1)
            {
                frmAcSubHead.Default.Activate();
            }
            frmAcSubHead.Default.MdiParent = this;
            frmAcSubHead.Default.Show();
            //Form1 comp = new Form1();
            //comp.MdiParent = this;
            //comp.Show();
        }
        private void btnCompany_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<frmCompany>().Count() == 1)
            {
                frmCompany.Default.Activate();
            }
            frmCompany.Default.MdiParent = this;
            frmCompany.Default.Show();
        }
        private void btnUsers_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<frmUsers>().Count() == 1)
            {
                frmUsers.Default.Activate();
            }
            frmUsers.Default.MdiParent = this;
            frmUsers.Default.Show();
        }
        private void btnBackup_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                SqlConnection con;
                SqlCommand cmd;
                SqlConnectionStringBuilder SSB = new SqlConnectionStringBuilder(global::AccountSystem.Properties.Settings.Default.DBConnectionString);
                String Server = SSB.DataSource;
                String Catalog = SSB.InitialCatalog;
                con = new SqlConnection(global::AccountSystem.Properties.Settings.Default.DBConnectionString);
                SaveFileDialog opendg = new SaveFileDialog();
                opendg.Filter = "Backup Files(*.bak)|*.bak";
                opendg.FileName = DateTime.Now.ToString("MMMM dd yyyy HH mm");
                opendg.Title = "Save Backup File";
                if (opendg.ShowDialog() == DialogResult.OK)
                {
                    cmd = new SqlCommand("backup database " + Catalog + " to disk='" + opendg.FileName + "'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Backup Done Successfully ...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Backup terminated due to some error …" + Environment.NewLine + "Use other location to take backup");
            }
        }
        private void btnWord_ItemClick(object sender, ItemClickEventArgs e)
        {
            MyModule.rpt.ExportDialog(MyModule.rpt.LocalReport.ListRenderingExtensions()[3]);
        }
        private void btnExcel_ItemClick(object sender, ItemClickEventArgs e)
        {
            MyModule.rpt.ExportDialog(MyModule.rpt.LocalReport.ListRenderingExtensions()[0]);
        }
        private void btnPDF_ItemClick(object sender, ItemClickEventArgs e)
        {
            MyModule.rpt.ExportDialog(MyModule.rpt.LocalReport.ListRenderingExtensions()[2]);
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            frmDashboard dash = new frmDashboard();
            dash.MdiParent = this;
            dash.Show(); dash.Hide();
 

            frmDashB1 dash2 = new frmDashB1();
            dash2.MdiParent = this;
            dash2.Show(); dash2.Hide();

            //if (Convert.ToInt32(Fn.GetRecords("SELECT COUNT(*) AS Expr1 FROM TblVoucherHDR")[0]) > 150)
            //{
            //if (Fn.GetRecords("SELECT SoftID FROM TblUser")[0] != fn.GetMyId())
            //{
            //    Regist frm = new Regist();
            //    frm.ShowDialog();
            //}
            //}
            LoginForm.Default.ShowDialog();
            if (Fn.GetRecords("SELECT Cbit FROM TblCompany WHERE (CompanyID = " + MyModule.CompID + ")")[0] == "1")
            {
                Regist frm = new Regist();
                frm.ShowDialog();
            }
            //ribbon.Minimized = true;
            if (MyModule.UserName == "Muhammad Zia ul Islam")
            {
                btnCompany.Visibility = BarItemVisibility.Always;
            }
            else
            {
                try
                {
                    DataTable Users = Fn.FillDSet("SELECT BranchID, btnVoucher, btnBVoucher, btnCahsV, btnLedger, btnTB, btnIS, btnBS, btnFC, ExpenseSheet, btnPurchase, btnPurchaseOrder, btnPOEdit, btnSale, btnDeliveryChallan, btnEditSaleOrder, btnIssuance, btnSaleR, btnPurchR, btnDisSch, btnPurVen, btnCustS, btnSalesmen, btnSalemanProduct, btnProdLadger, btnStock, btnBTC, btnUsers, btnCompany, btnBackup, btnAppSetting, btnProduct, btnProPrer, btnProdList, btnStore, btnVendors, btnEmployees, btnCustomers, btnChartAcc, btnVoucherPosting, btnReceiptsReport, btnFundTransfer, btnSearchVouchers, btnVoucherPreview, btnEditVouchers, btnSaleReg, btnPurchaseReg, btnOverdueInvoices, VendorBalances, btnCustBalance, btnCashBankBalances, btnProfitability, btnMonthWiseSale, btnEmpPro, btnOrderStatus, btnRPTTIRECLAIMS, btnClaimFormEdit, btnDayClosing, btnCityReg, btnPaymentterms, btnLedgerinUSD, btnGeneralEntries, btnOverdueBalances, btnChangeOrderStatus, btnPaymenttoVendor,btnWalkinCust,showhidedash FROM TblUser WHERE (UserName = '" + MyModule.UserName + "')").Tables[0];
                    //MyModule.BranchID = (Int32)Users.Rows[0]["BranchID"];
                    btnVoucher.Enabled = (bool)Users.Rows[0]["btnVoucher"];
                    dash.btnJournalVoucher.Enabled = (bool)Users.Rows[0]["btnVoucher"];

                    btnBRV.Enabled = (bool)Users.Rows[0]["btnDisSch"]; btnBPV.Enabled = (bool)Users.Rows[0]["btnBVoucher"];
                    btnCRV.Enabled = (bool)Users.Rows[0]["btnCahsV"];
                    btnCPV.Enabled = (bool)Users.Rows[0]["btnOverdueBalances"];
                    dash.btnBankPaymentVoucher.Enabled = (bool)Users.Rows[0]["btnBVoucher"];
                    dash.btnBankReceiptVoucher.Enabled = (bool)Users.Rows[0]["btnDisSch"];
                    dash.btnCashReceiptVoucher.Enabled = (bool)Users.Rows[0]["btnCahsV"];
                    dash.btnCashPaymentVoucher.Enabled = (bool)Users.Rows[0]["btnOverdueBalances"];

                    btnLedger.Enabled = (bool)Users.Rows[0]["btnLedger"];
                    dash.btnAccountsLedgers.Enabled = (bool)Users.Rows[0]["btnLedger"];

                    btnTB.Enabled = (bool)Users.Rows[0]["btnTB"];
                    dash.btnTrialBalance.Enabled = (bool)Users.Rows[0]["btnTB"];

                    btnIS.Enabled = (bool)Users.Rows[0]["btnIS"];
                    btnBS.Enabled = (bool)Users.Rows[0]["btnBS"];
                    btnFC.Enabled = (bool)Users.Rows[0]["btnFC"];
                    ExpenseSheet.Enabled = (bool)Users.Rows[0]["ExpenseSheet"];
                    btnPurchase.Enabled = (bool)Users.Rows[0]["btnPurchase"];
                    

                    btnPurchaseOrder.Enabled = (bool)Users.Rows[0]["btnPurchaseOrder"];
                    dash.btnPurchaseOrder.Enabled= (bool)Users.Rows[0]["btnPurchaseOrder"];

                    btnPOEdit.Enabled = (bool)Users.Rows[0]["btnPOEdit"];
                    btnSale.Enabled = (bool)Users.Rows[0]["btnSale"];
                    btnDeliveryChallan.Enabled = (bool)Users.Rows[0]["btnDeliveryChallan"];
                    dash.btnDeliveryChallan.Enabled = (bool)Users.Rows[0]["btnDeliveryChallan"];

                    btnEditSaleOrder.Enabled = (bool)Users.Rows[0]["btnEditSaleOrder"];
                    btnIssuance.Enabled = (bool)Users.Rows[0]["btnIssuance"];
                    btnSaleR.Enabled = (bool)Users.Rows[0]["btnSaleR"];
                    btnPurchR.Enabled = (bool)Users.Rows[0]["btnPurchR"];
                    btnrptPatternWiseProfitability.Enabled = (bool)Users.Rows[0]["btnCustS"];
                    btnCustomerWiseProfitability.Enabled = (bool)Users.Rows[0]["btnSalesmen"];
                    btnCityWiseProfitability.Enabled = (bool)Users.Rows[0]["btnSalemanProduct"];
                    btnProdLadger.Enabled = (bool)Users.Rows[0]["btnProdLadger"];
                    dash.btnInventoryLedgers.Enabled = (bool)Users.Rows[0]["btnProdLadger"];

                    btnStock.Enabled = (bool)Users.Rows[0]["btnStock"];
                    dash.btnStockReport.Enabled = (bool)Users.Rows[0]["btnStock"];

                    btnBTC.Enabled = (bool)Users.Rows[0]["btnBTC"];
                    btnUsers.Enabled = (bool)Users.Rows[0]["btnUsers"];
                    btnCompany.Enabled = (bool)Users.Rows[0]["btnCompany"];
                    btnBackup.Enabled = (bool)Users.Rows[0]["btnBackup"];
                    btnAppSetting.Enabled = (bool)Users.Rows[0]["btnAppSetting"];
                    btnProduct.Enabled = (bool)Users.Rows[0]["btnProduct"];
                    btnProPrer.Enabled = (bool)Users.Rows[0]["btnProPrer"];
                    btnProdList.Enabled = (bool)Users.Rows[0]["btnProdList"];
                    btnStore.Enabled = (bool)Users.Rows[0]["btnStore"];
                    btnVendors.Enabled = (bool)Users.Rows[0]["btnVendors"];
                    btnEmployees.Enabled = (bool)Users.Rows[0]["btnEmployees"];
                    btnCustomers.Enabled = (bool)Users.Rows[0]["btnCustomers"];
                    btnChartAcc.Enabled = (bool)Users.Rows[0]["btnChartAcc"];

                    btnVoucherPosting.Enabled = (bool)Users.Rows[0]["btnVoucherPosting"];
                    btnReceiptsReport.Enabled = (bool)Users.Rows[0]["btnReceiptsReport"];
                    btnFundTransfer.Enabled = (bool)Users.Rows[0]["btnFundTransfer"];
                    btnSearchVouchers.Enabled = (bool)Users.Rows[0]["btnSearchVouchers"];
                    btnVoucherPreview.Enabled = (bool)Users.Rows[0]["btnVoucherPreview"];
                    btnEditVouchers.Enabled = (bool)Users.Rows[0]["btnEditVouchers"];
                    btnSaleReg.Enabled = (bool)Users.Rows[0]["btnSaleReg"];
                    btnPurchaseReg.Enabled = (bool)Users.Rows[0]["btnPurchaseReg"];
                    btnOverdueInvoices.Enabled = (bool)Users.Rows[0]["btnOverdueInvoices"];
                    dash.btnOverdueInvoices.Enabled = (bool)Users.Rows[0]["btnOverdueInvoices"];

                    VendorBalances.Enabled = (bool)Users.Rows[0]["VendorBalances"];
                    dash.btnVendorBalances.Enabled = (bool)Users.Rows[0]["VendorBalances"];

                    btnCustBalance.Enabled = (bool)Users.Rows[0]["btnCustBalance"];
                    dash.btnCustomerBalances.Enabled = (bool)Users.Rows[0]["btnCustBalance"];

                    btnCashBankBalances.Enabled = (bool)Users.Rows[0]["btnCashBankBalances"];
                    btnProfitability.Enabled = (bool)Users.Rows[0]["btnProfitability"];
                    btnMonthWiseSale.Enabled = (bool)Users.Rows[0]["btnMonthWiseSale"];
                    btnEmpPro.Enabled = (bool)Users.Rows[0]["btnEmpPro"];
                    btnOrderStatus.Enabled = (bool)Users.Rows[0]["btnOrderStatus"];
                    btnRPTTIRECLAIMS.Enabled = (bool)Users.Rows[0]["btnRPTTIRECLAIMS"];
                    btnClaimFormEdit.Enabled = (bool)Users.Rows[0]["btnClaimFormEdit"];
                    btnDayClosing.Enabled = (bool)Users.Rows[0]["btnDayClosing"];
                    btnCityReg.Enabled = (bool)Users.Rows[0]["btnCityReg"];
                    btnPaymentterms.Enabled = (bool)Users.Rows[0]["btnPaymentterms"];
                    btnLedgerinUSD.Enabled = (bool)Users.Rows[0]["btnLedgerinUSD"];
                    btnGeneralEntries.Enabled = (bool)Users.Rows[0]["btnGeneralEntries"];
                    btnOverdueBalances.Enabled = (bool)Users.Rows[0]["btnOverdueBalances"];
                    btnChangeOrderStatus.Enabled = (bool)Users.Rows[0]["btnChangeOrderStatus"];
                    btnPaymenttoVendor.Enabled = (bool)Users.Rows[0]["btnPaymenttoVendor"];
                    btnWalkinCust.Enabled = (bool)Users.Rows[0]["btnWalkinCust"];
                    dash.btnSaleInvoice.Enabled = (bool)Users.Rows[0]["btnWalkinCust"];

                    btnPurchaseInvoice.Enabled = (bool)Users.Rows[0]["btnPurVen"];
                    dash.btnPurchaseInvoice.Enabled = (bool)Users.Rows[0]["btnPurVen"];

                    dash.Visible = (bool)Users.Rows[0]["showhidedash"];
                    backupchk= (bool)Users.Rows[0]["showhidedash"];
                    dash2.Show();
                }
                catch(Exception ex)
                {
                }
            }
            StatusTxt.Caption = (string)(" Login User : " + MyModule.UserName);
            lblCompany.Caption = MyModule.CompName;
            try
            {
                MyModule.CompName = MyModule.CompName.Split(',')[0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please assign branch to selected user" + Environment.NewLine + "User not added in company profile");

            }
            
            StatusTime.Caption = DateTime.Now.ToString("dddd, MMMM dd, yyyy - hh:mm");
            //if (MyModule.UserType == 1)
            //{
            StatusTxt.Glyph = global::AccountSystem.Properties.Resources.admin2;
            //}
            //else if (MyModule.UserType == 0)
            //{
            //    StatusTxt.Glyph = global::AccountSystem.Properties.Resources.user2;
            //}
            //else
            //{
            //    StatusTxt.Glyph = global::AccountSystem.Properties.Resources.Extv2;
            //}
            //dash.Show();
        }
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
        private void ribbon_ApplicationButtonClick(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<About>().Count() == 1)
            {
                About.Default.Activate();
            }
            About.Default.MdiParent = this;
            About.Default.Show();
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            StatusTime.Caption = DateTime.Now.ToString("dddd, MMMM dd, yyyy - hh:mm");
            StatusTime.Glyph = global::AccountSystem.Properties.Resources.yahoo_idle;

            ////PopupNotifier popup = new PopupNotifier();
            //popupNotifier1.TitleText = "BE HAPPY";
            //popupNotifier1.ContentText = "Thank you";
            //popupNotifier1.ContentPadding= new Padding(4, 0, 0, 0);
            //popupNotifier1.TitlePadding= new Padding(4,13,0,0);
            //popupNotifier1.Image= global::AccountSystem.Properties.Resources.info_img;
            //popupNotifier1.Popup();// show 
        }
        private void btnVoucher_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<frmVouchers>().Count() == 1)
            {
                frmVouchers.Default.Activate();
            }
            frmVouchers.Default.MdiParent = this;
            frmVouchers.Default.Show();
        }
        private void EntryAccED_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<frmEntryAccED>().Count() == 1)
            {
                frmEntryAccED.Default.Activate();
            }
            frmEntryAccED.Default.MdiParent = this;
            frmEntryAccED.Default.Show();
        }
        private void SubAccEd_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<frmAcSubHeadED>().Count() == 1)
            {
                frmAcSubHeadED.Default.Activate();
            }
            frmAcSubHeadED.Default.MdiParent = this;
            frmAcSubHeadED.Default.Show();
        }
        private void JVoucherEd_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<frmVoucherED>().Count() == 1)
            {
                frmVoucherED.Default.Activate();
            }
            frmVoucherED.Default.MdiParent = this;
            frmVoucherED.Default.Show();
        }
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<frmYearCls>().Count() == 1)
            {
                frmYearCls.Default.Activate();
            }
            frmYearCls.Default.MdiParent = this;
            frmYearCls.Default.Show();
        }
        private void btnBVoucher_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<frmBVoucher>().Count() == 1)
            {
                frmBVoucher.Default.Activate();
            }
            frmBVoucher.Default.MdiParent = this;
            frmBVoucher.Default.Show();
        }
        private void btnBS_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<rptBLSheet>().Count() == 1)
            {
                rptBLSheet.Default.Activate();
            }
            //BalanceShee.Default.MdiParent = this;
            //BalanceShee.Default.Show();
            rptBLSheet.Default.MdiParent = this;
            rptBLSheet.Default.Show();
        }
        private void btnTB_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<TriBalancParm>().Count() == 1)
            {
                TriBalancParm.Default.Activate();
            }
            TriBalancParm.Default.MdiParent = this;
            TriBalancParm.Default.Show();
        }
        private void btnLedger_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<LedgerReport>().Count() == 1)
            {
                LedgerReport.Default.Activate();
            }
            LedgerReport.Default.MdiParent = this;
            LedgerReport.Default.Show();
        }
        private void btnIS_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<rptIncomeStatement>().Count() == 1)
            {
                rptIncomeStatement.Default.Activate();
            }
            //IncomStatView.Default.MdiParent = this;
            //IncomStatView.Default.Show(); 
            rptIncomeStatement.Default.MdiParent = this;
            rptIncomeStatement.Default.Show();
        }
        private void btnFC_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<ChartsView>().Count() == 1)
            {
                ChartsView.Default.Activate();
            }
            ChartsView.Default.MdiParent = this;
            ChartsView.Default.Show();
        }
        private void btnCahsV_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<frmCVoucher>().Count() == 1)
            {
                frmCVoucher.Default.Activate();
            }
            frmCVoucher.Default.MdiParent = this;
            frmCVoucher.Default.Show();
        }
        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<frmChartAccounts>().Count() == 1)
            {
                frmChartAccounts.Default.Activate();
            }
            frmChartAccounts.Default.MdiParent = this;
            frmChartAccounts.Default.Show();
        }
        private void barButtonItem2_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<MonlyExp>().Count() == 1)
            {
                MonlyExp.Default.Activate();
            }
            MonlyExp.Default.MdiParent = this;
            MonlyExp.Default.Show();
        }
        private void btnVendors_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<frmVendors>().Count() == 1)
            {
                frmVendors.Default.Activate();
            }
            frmVendors.Default.MdiParent = this;
            frmVendors.Default.Show();
        }
        private void btnProPrer_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<frmInventorySettings>().Count() == 1)
            {
                frmInventorySettings.Default.Activate();
            }
            frmInventorySettings.Default.MdiParent = this;
            frmInventorySettings.Default.Show();
        }
        private void btnProduct_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<frmRawMaterialRegistration>().Count() == 1)
            {
                //frmProducts.Default.Activate();
                frmRawMaterialRegistration.Default.Activate();
            }
            frmRawMaterialRegistration.Default.MdiParent = this;
            frmRawMaterialRegistration.Default.Show();
        }
        private void btnSale_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<frmMakeSaleInvoice>().Count() == 1)
            {
                frmMakeSaleInvoice.Default.Activate();
            }
            //frmSaleInvoice
         
            frmMakeSaleInvoice.Default.MdiParent = this;
            frmMakeSaleInvoice.Default.Show();
        }
        private void btnSaleR_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<frmSaleReturn>().Count() == 1)
            {
                frmSaleReturn.Default.Activate();
            }
            frmSaleReturn.Default.MdiParent = this;
            frmSaleReturn.Default.Show();
        }
        private void btnPurchase_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<frmGRN>().Count() == 1)
            {
                frmGRN.Default.Activate();
            }
            frmGRN.Default.MdiParent = this;
            frmGRN.Default.Show();
            //frm_Purchase.Default.MdiParent = this;
            //frm_Purchase.Default.Show();
        }
        private void btnPurchR_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<frmPurchaseReturn>().Count() == 1)
            {
                frmPurchaseReturn.Default.Activate();
            }
            frmPurchaseReturn.Default.MdiParent = this;
            frmPurchaseReturn.Default.Show();
        }
        private void barButtonItem2_ItemClick_2(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<rptStockReport>().Count() == 1)
            {
                rptStockReport.Default.Activate();
            }
            //StockRptParm2.Default.MdiParent = this;
            //StockRptParm2.Default.Show();
            rptStockReport.Default.MdiParent = this;
            rptStockReport.Default.Show();
        }
        private void btnFixedAsset_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<FixedAsset>().Count() == 1)
            {
                FixedAsset.Default.Activate();
            }
            FixedAsset.Default.MdiParent = this;
            FixedAsset.Default.Show();
        }
        private void btnProdLadger_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<ProdLedgerReport>().Count() == 1)
            {
                ProdLedgerReport.Default.Activate();
            }
            ProdLedgerReport.Default.MdiParent = this;
            ProdLedgerReport.Default.Show();
        }
        private void btnIssuance_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<InventoryTransfer>().Count() == 1)
            {
                InventoryTransfer.Default.Activate();
            }
            InventoryTransfer.Default.MdiParent = this;
            InventoryTransfer.Default.Show();
        }
        private void btnStockWith_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<WithSReport>().Count() == 1)
            {
                WithSReport.Default.Activate();
            }
            WithSReport.Default.MdiParent = this;
            WithSReport.Default.Show();
        }
        private void barButtonItem3_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<StockRptDetails>().Count() == 1)
            {
                StockRptDetails.Default.Activate();
            }
            StockRptDetails.Default.MdiParent = this;
            StockRptDetails.Default.Show();
        }
        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }
        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<ProductSheetList>().Count() == 1)
            {
                ProductSheetList.Default.Activate();
            }
            ProductSheetList.Default.MdiParent = this;
            ProductSheetList.Default.Show();
        }
        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<IncomStatView2>().Count() == 1)
            {
                IncomStatView2.Default.Activate();
            }
            IncomStatView2.Default.MdiParent = this;
            IncomStatView2.Default.Show();
        }
        private void btnSalesmen_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<Discountrpt>().Count() == 1)
            {
                Discountrpt.Default.Activate();
            }
            Discountrpt.Default.MdiParent = this;
            Discountrpt.Default.Show();
        }
        private void btnCustS_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<SaleWiseRpt>().Count() == 1)
            {
                SaleWiseRpt.Default.Activate();
            }
            SaleWiseRpt.Default.MdiParent = this;
            SaleWiseRpt.Default.Show();
        }
        private void btnPurVen_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<PurchWiseRpt>().Count() == 1)
            {
                PurchWiseRpt.Default.Activate();
            }
            PurchWiseRpt.Default.MdiParent = this;
            PurchWiseRpt.Default.Show();
        }
        private void btnDisSch_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<SchemeRpt>().Count() == 1)
            {
                SchemeRpt.Default.Activate();
            }
            SchemeRpt.Default.MdiParent = this;
            SchemeRpt.Default.Show();
        }
        private void btnPrintBill_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<frmPrintBill>().Count() == 1)
            {
                frmPrintBill.Default.Activate();
            }
            frmPrintBill.Default.MdiParent = this;
            frmPrintBill.Default.Show();
        }
        private void btnSalemanProduct_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<SalesmanProduct>().Count() == 1)
            {
                SalesmanProduct.Default.Activate();
            }
            SalesmanProduct.Default.MdiParent = this;
            SalesmanProduct.Default.Show();
        }
        private void btnEmployees_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<frmEmployees>().Count() == 1)
            {
                frmEmployees.Default.Activate();
            }
            frmEmployees.Default.MdiParent = this;
            frmEmployees.Default.Show();
        }
        private void btnCustomers_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<frmCustomers>().Count() == 1)
            {
                frmCustomers.Default.Activate();
            }
            frmCustomers.Default.MdiParent = this;
            frmCustomers.Default.Show();
        }
        private void btnStore_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<frmStores>().Count() == 1)
            {
                frmStores.Default.Activate();
            }
            frmStores.Default.MdiParent = this;
            frmStores.Default.Show();
        }
        private void btnPurchaseOrder_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<frmPurchaseOrder>().Count() == 1)
            {
                frmPurchaseOrder.Default.Activate();
            }
            frmPurchaseOrder.Default.MdiParent = this;
            frmPurchaseOrder.Default.Show();
        }
        private void btnPOEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<frmPurchaseOrderEdit>().Count() == 1)
            {
                frmPurchaseOrderEdit.Default.Activate();
            }
            frmPurchaseOrderEdit.Default.MdiParent = this;
            frmPurchaseOrderEdit.Default.Show();
        }
        private void btnSaleOrder_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<frmDeliveryChallan>().Count() == 1)
            {
                frmDeliveryChallan.Default.Activate();
            }
            frmDeliveryChallan.Default.MdiParent = this;
            frmDeliveryChallan.Default.Show();
        }
        private void btnEditSaleOrder_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<frmDeliveryChallanEdit>().Count() == 1)
            {
                frmDeliveryChallanEdit.Default.Activate();
            }
            frmDeliveryChallanEdit.Default.MdiParent = this;
            frmDeliveryChallanEdit.Default.Show();
        }
        private void btnWalkinCust_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<frmSaleInvoiceWlkin>().Count() == 1)
            {
                frmSaleInvoiceWlkin.Default.Activate();
            }
            frmSaleInvoiceWlkin.Default.MdiParent = this;
            frmSaleInvoiceWlkin.Default.Show();
        }
        private void btnCityReg_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<frmCityReg>().Count() == 1)
            {
                frmCityReg.Default.Activate();
            }
            frmCityReg.Default.MdiParent = this;
            frmCityReg.Default.Show();
        }
        private void btnBTC_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<Inventory.frmClaimForm>().Count() == 1)
            {
                Application.OpenForms.OfType<Inventory.frmClaimForm>().First().Activate();
            }
            else
            {
            Inventory.frmClaimForm frm = new Inventory.frmClaimForm();
            frm.MdiParent = this;
            frm.Show();
            }

        }
        private void btnPurchaseInvoice_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<frmPurchaseInvoice>().Count() == 1)
            {
                frmPurchaseInvoice.Default.Activate();
            }
            frmPurchaseInvoice.Default.MdiParent = this;
            frmPurchaseInvoice.Default.Show();
        }
        private void btnPaymentterms_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<frmPayTerms>().Count() == 1)
            {
                frmPayTerms.Default.Activate();
            }
            frmPayTerms.Default.MdiParent = this;
            frmPayTerms.Default.Show();
        }
        private void btnrptPatternWiseProfitability_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<rptPatternWiseProfitability>().Count() == 1)
            {
                rptPatternWiseProfitability.Default.Activate();
            }
            rptPatternWiseProfitability.Default.MdiParent = this;
            rptPatternWiseProfitability.Default.Show();
        }
        private void btnCustomerWiseProfitability_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<rpCustomerWiseProfitability>().Count() == 1)
            {
                rpCustomerWiseProfitability.Default.Activate();
            }
            rpCustomerWiseProfitability.Default.MdiParent = this;
            rpCustomerWiseProfitability.Default.Show();
        }
        private void btnCityWiseProfitability_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<rptRegionWiseProfitability>().Count() == 1)
            {
                rptRegionWiseProfitability.Default.Activate();
            }
            rptRegionWiseProfitability.Default.MdiParent = this;
            rptRegionWiseProfitability.Default.Show();
        }
        private void btnProfitability_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<Profitability>().Count() == 1)
            {
                Profitability.Default.Activate();
            }
            Profitability.Default.MdiParent = this;
            Profitability.Default.Show();
        }
        private void btnCRV_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<frmCRV>().Count() == 1)
            {
                frmCRV.Default.Activate();
            }
            frmCRV.Default.MdiParent = this;
            frmCRV.Default.Show();
        }
        private void btnBRV_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<frmBRV>().Count() == 1)
            {
                frmBRV.Default.Activate();
            }
            frmBRV.Default.MdiParent = this;
            frmBRV.Default.Show();
        }
        private void btnCPV_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<frmCPV>().Count() == 1)
            {
                frmCPV.Default.Activate();
            }
            frmCPV.Default.MdiParent = this;
            frmCPV.Default.Show();
        }
        private void btnBPV_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<frmBPV>().Count() == 1)
            {
                frmBPV.Default.Activate();
            }
            frmBPV.Default.MdiParent = this;
            frmBPV.Default.Show();
        }
        private void btnSearchVouchers_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<rptSearchJVs>().Count() == 1)
            {
                rptSearchJVs.Default.Activate();
            }
            rptSearchJVs.Default.MdiParent = this;
            rptSearchJVs.Default.Show();
        }
        private void btnVoucherPosting_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<frmVoucherPosting>().Count() == 1)
            {
                frmVoucherPosting.Default.Activate();
            }
            frmVoucherPosting.Default.MdiParent = this;
            frmVoucherPosting.Default.Show();
        }
        private void btnVoucherPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<frmVoucherPreview>().Count() == 1)
            {
                frmVoucherPreview.Default.Activate();
            }
            frmVoucherPreview.Default.MdiParent = this;
            frmVoucherPreview.Default.Show();
        }
        private void VendorBalances_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<rptVendorBalances>().Count() == 1)
            {
                rptVendorBalances.Default.Activate();
            }
            rptVendorBalances.Default.MdiParent = this;
            rptVendorBalances.Default.Show();
        }
        private void btnCustBalance_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<rptCustomerBalances>().Count() == 1)
            {
                rptCustomerBalances.Default.Activate();
            }
            rptCustomerBalances.Default.MdiParent = this;
            rptCustomerBalances.Default.Show();
        }
        private void btnCashBankBalances_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<rptCashBankBalances>().Count() == 1)
            {
                rptCashBankBalances.Default.Activate();
            }
            rptCashBankBalances.Default.MdiParent = this;
            rptCashBankBalances.Default.Show();
        }
        private void btnSaleReg_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<rptSaleRegister>().Count() == 1)
            {
                rptSaleRegister.Default.Activate();
            }
            rptSaleRegister.Default.MdiParent = this;
            rptSaleRegister.Default.Show();
        }
        private void btnPurchaseReg_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<rptPurchaseRegister>().Count() == 1)
            {
                rptPurchaseRegister.Default.Activate();
            }
            rptPurchaseRegister.Default.MdiParent = this;
            rptPurchaseRegister.Default.Show();
        }
        private void btnReceiptsReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<rptReceiptsReport>().Count() == 1)
            {
                rptReceiptsReport.Default.Activate();
            }
            rptReceiptsReport.Default.MdiParent = this;
            rptReceiptsReport.Default.Show();
        }
        private void btnFundTransfer_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<FundTransfer>().Count() == 1)
            {
                FundTransfer.Default.Activate();
            }
            FundTransfer.Default.MdiParent = this;
            FundTransfer.Default.Show();
        }
        private void btnChangePassword_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChangePassword.Default.ShowDialog();
        }
        private void btnDayClosing_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<DayClosing>().Count() == 1)
            {
                DayClosing.Default.Activate();
            }
            DayClosing.Default.MdiParent = this;
            DayClosing.Default.Show();
        }
        private void btnOverdueInvoices_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<rptOverdueInvoices>().Count() == 1)
            {
                rptOverdueInvoices.Default.Activate();
            }
            rptOverdueInvoices.Default.MdiParent = this;
            rptOverdueInvoices.Default.Show();
        }
        private void btnMonthWiseSale_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<rptMonthWiseSale>().Count() == 1)
            {
                rptMonthWiseSale.Default.Activate();
            }
            rptMonthWiseSale.Default.MdiParent = this;
            rptMonthWiseSale.Default.Show();
        }
        private void btnEmpPro_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<rptEmployeeProfitability>().Count() == 1)
            {
                rptEmployeeProfitability.Default.Activate();
            }
            rptEmployeeProfitability.Default.MdiParent = this;
            rptEmployeeProfitability.Default.Show();
        }
        private void btnOrderStatus_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<rptOrderStatus>().Count() == 1)
            {
                rptOrderStatus.Default.Activate();
            }
            rptOrderStatus.Default.MdiParent = this;
            rptOrderStatus.Default.Show();
        }
        private void btnRPTTIRECLAIMS_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<RPTTIRECLAIMS>().Count() == 1)
            {
                RPTTIRECLAIMS.Default.Activate();
            }
            RPTTIRECLAIMS.Default.MdiParent = this;
            RPTTIRECLAIMS.Default.Show();
        }
        private void btnClaimFormEdit_ItemClick(object sender, ItemClickEventArgs e)
        {

            if (Application.OpenForms.OfType<Inventory.frmClaimFormEdit>().Count() == 1)
            {
                Application.OpenForms.OfType<Inventory.frmClaimFormEdit>().First().Activate();
            }
            else
            {
            Inventory.frmClaimFormEdit frm = new Inventory.frmClaimFormEdit();
            frm.MdiParent = this;
            frm.Show();
            }

        }
        private void barButtonItem1_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<frmVoucherEdit>().Count() == 1)
            {
                frmVoucherEdit.Default.Activate();
            }
            frmVoucherEdit.Default.MdiParent = this;
            frmVoucherEdit.Default.Show();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!backupchk)
            {
                Application.Exit();
                return;
            }
            DialogResult result = new DialogResult();
            result = MessageBox.Show("Do you want to create a backup of database?", "GM Soft", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                try
                {
                    SqlConnection con;
                    SqlCommand cmd;
                    SqlConnectionStringBuilder SSB = new SqlConnectionStringBuilder(global::AccountSystem.Properties.Settings.Default.DBConnectionString);
                    String Server = SSB.DataSource;
                    String Catalog = SSB.InitialCatalog;
                    con = new SqlConnection(global::AccountSystem.Properties.Settings.Default.DBConnectionString);
                    SaveFileDialog opendg = new SaveFileDialog();
                    opendg.Filter = "Backup Files(*.bak)|*.bak";
                    opendg.FileName = DateTime.Now.ToString("MMMM dd yyyy HH mm");
                    opendg.Title = "Save Backup File";
                    if (opendg.ShowDialog() == DialogResult.OK)
                    {
                        cmd = new SqlCommand("backup database " + Catalog + " to disk='" + opendg.FileName + "'", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Backup Done Successfully ..."); Application.Exit();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Backup terminated due to some error …" + Environment.NewLine + "Use other location to take backup");
                }
            }
            else if (result == DialogResult.No)
            {
                Application.Exit();
            }
        }

        private void btnChangeOrderStatus_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<frmPurchaseOrderStatusEdit>().Count() == 1)
            {
                frmPurchaseOrderStatusEdit.Default.Activate();
            }
            frmPurchaseOrderStatusEdit.Default.MdiParent = this;
            frmPurchaseOrderStatusEdit.Default.Show();
        }

        private void btnGeneralEntries_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<GeneralEntries>().Count() == 1)
            {
                GeneralEntries.Default.Activate();
            }
            GeneralEntries.Default.MdiParent = this;
            GeneralEntries.Default.Show();
        }

        private void btnPaymenttoVendor_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<frmPaymenttoVendor>().Count() == 1)
            {
                frmPaymenttoVendor.Default.Activate();
            }
            frmPaymenttoVendor.Default.MdiParent = this;
            frmPaymenttoVendor.Default.Show();

        }

        private void btnLedgerinUSD_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<LedgerReportUSD>().Count() == 1)
            {
                LedgerReportUSD.Default.Activate();
            }
            LedgerReportUSD.Default.MdiParent = this;
            LedgerReportUSD.Default.Show();
        }

        private void btnOverdueBalances_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnStaffRecoverySheet_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<rptStaffRecoverySheet>().Count() == 1)
            {
                rptStaffRecoverySheet.Default.Activate();
            }
            rptStaffRecoverySheet.Default.MdiParent = this;
            rptStaffRecoverySheet.Default.Show();
        }

        private void btnRawMaterialRegistration_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<frmRawMaterialRegistration>().Count() == 1)
            {
                frmRawMaterialRegistration.Default.Activate();
            }
            frmRawMaterialRegistration.Default.MdiParent = this;
            frmRawMaterialRegistration.Default.Show();
        }

        private void btnQuotations_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<frmQuotations>().Count() == 1)
            {
                frmQuotations.Default.Activate();
            }
            frmQuotations.Default.MdiParent = this;
            frmQuotations.Default.Show();
        }

        private void btnDailyProduction_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<frmDailyProduction>().Count() == 1)
            {
                frmDailyProduction.Default.Activate();
            }
            frmDailyProduction.Default.MdiParent = this;
            frmDailyProduction.Default.Show();
        }

        private void btnDailyUpdateReport_ItemClick(object sender, ItemClickEventArgs e)
        {
if (Application.OpenForms.OfType<rptDailyUpdate>().Count() == 1)
            {
                rptDailyUpdate.Default.Activate();
            }
            rptDailyUpdate.Default.MdiParent = this;
            rptDailyUpdate.Default.Show();
        }

        private void btnDemandBook_ItemClick(object sender, ItemClickEventArgs e)
        {
if (Application.OpenForms.OfType<frmDemandBook>().Count() == 1)
            {
                frmDemandBook.Default.Activate();
            }
            frmDemandBook.Default.MdiParent = this;
            frmDemandBook.Default.Show();
        }

        private void btnrptStockReportRaw_ItemClick(object sender, ItemClickEventArgs e)
        {
if (Application.OpenForms.OfType<rptStockReportRaw>().Count() == 1)
            {
                rptStockReportRaw.Default.Activate();
            }
            rptStockReportRaw.Default.MdiParent = this;
            rptStockReportRaw.Default.Show();
        }

        private void btnProductDamages_ItemClick(object sender, ItemClickEventArgs e)
        {
if (Application.OpenForms.OfType<frmDamage>().Count() == 1)
            {
                frmDamage.Default.Activate();
            }
            frmDamage.Default.MdiParent = this;
            frmDamage.Default.Show();
        }

        private void btnOutwardGatePass_ItemClick(object sender, ItemClickEventArgs e)
        {
if (Application.OpenForms.OfType<frmOutwardGatePass>().Count() == 1)
            {
                frmOutwardGatePass.Default.Activate();
            }
            frmOutwardGatePass.Default.MdiParent = this;
            frmOutwardGatePass.Default.Show();
        }

        private void btnInwardGatePass_ItemClick(object sender, ItemClickEventArgs e)
        {
if (Application.OpenForms.OfType<frmInwardGatePass>().Count() == 1)
            {
                frmInwardGatePass.Default.Activate();
            }
            frmInwardGatePass.Default.MdiParent = this;
            frmInwardGatePass.Default.Show();
        }

        private void btnSalenprod_ItemClick(object sender, ItemClickEventArgs e)
        {
if (Application.OpenForms.OfType<rptSalenProduction>().Count() == 1)
            {
                rptSalenProduction.Default.Activate();
            }
            rptSalenProduction.Default.MdiParent = this;
            rptSalenProduction.Default.Show();
        }

        private void btnDispatchOGP_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<frmDispathGatePass>().Count() == 1)
            {
                frmDispathGatePass.Default.Activate();
            }
            frmDispathGatePass.Default.MdiParent = this;
            frmDispathGatePass.Default.Show();
        }

        private void btnDispatchRegister_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<rptDispatchRegister>().Count() == 1)
            {
                rptDispatchRegister.Default.Activate();
            }
            rptDispatchRegister.Default.MdiParent = this;
            rptDispatchRegister.Default.Show();
        }

        private void btnInwardRegister_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<rptInwardGatePassRegis>().Count() == 1)
            {
                rptInwardGatePassRegis.Default.Activate();
            }
            rptInwardGatePassRegis.Default.MdiParent = this;
            rptInwardGatePassRegis.Default.Show();
        }

        private void btnProductCostVariation_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<rptProductCostVariation>().Count() == 1)
            {
                rptProductCostVariation.Default.Activate();
            }
            rptProductCostVariation.Default.MdiParent = this;
            rptProductCostVariation.Default.Show();
        }

        private void btnDailyProductReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<rptDailyProductReport>().Count() == 1)
            {
                rptDailyProductReport.Default.Activate();
            }
            rptDailyProductReport.Default.MdiParent = this;
            rptDailyProductReport.Default.Show();
        }

        private void btnPaymentTransection_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<rptPaymentsDtl>().Count() == 1)
            {
                rptPaymentsDtl.Default.Activate();
            }
            rptPaymentsDtl.Default.MdiParent = this;
            rptPaymentsDtl.Default.Show();
        }

        private void btnSaleReport_ItemClick(object sender, ItemClickEventArgs e)
        {
 if (Application.OpenForms.OfType<rptSaleReport>().Count() == 1)
            {
                rptSaleReport.Default.Activate();
            }
            rptSaleReport.Default.MdiParent = this;
            rptSaleReport.Default.Show();
        }

        private void btnSaleTaxReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<rptSaleTaxReport>().Count() == 1)
            {
                rptSaleTaxReport.Default.Activate();
            }
            rptSaleTaxReport.Default.MdiParent = this;
            rptSaleTaxReport.Default.Show();
        }

        private void btnConsumableItems_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<lissuance>().Count() == 1)
            {
                lissuance.Default.Activate();
            }
            lissuance.Default.MdiParent = this;
            lissuance.Default.Show();
        }

        private void btnPurchaseReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<rptPurchaseSum>().Count() == 1)
            {
                rptPurchaseSum.Default.Activate();
            }
            rptPurchaseSum.Default.MdiParent = this;
            rptPurchaseSum.Default.Show();
        }

        private void btnComparativeStatment_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnNonConsumableItems_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<frmNonCons>().Count() == 1)
            {
                frmNonCons.Default.Activate();
            }
            frmNonCons.Default.MdiParent = this;
            frmNonCons.Default.Show();
        }

        private void popupNotifier1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ggggggggggg");
        }

        private void btnBankReconciliation_ItemClick(object sender, ItemClickEventArgs e)
        {
 if (Application.OpenForms.OfType<rptBankReconciliation>().Count() == 1)
            {
                rptBankReconciliation.Default.Activate();
            }
            rptBankReconciliation.Default.MdiParent = this;
            rptBankReconciliation.Default.Show();
        }

        private void btnEditSaleInvoice_ItemClick(object sender, ItemClickEventArgs e)
        {
 if (Application.OpenForms.OfType<frmEditSaleInvoice>().Count() == 1)
            {
                frmEditSaleInvoice.Default.Activate();
            }
            frmEditSaleInvoice.Default.MdiParent = this;
            frmEditSaleInvoice.Default.Show();
        }

        private void btnEditPurchases_ItemClick(object sender, ItemClickEventArgs e)
        {
 if (Application.OpenForms.OfType<frmEditPurchases>().Count() == 1)
            {
                frmEditPurchases.Default.Activate();
            }
            frmEditPurchases.Default.MdiParent = this;
            frmEditPurchases.Default.Show();
        }

        private void btnDailyProductionEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
 if (Application.OpenForms.OfType<frmDailyProductionEdit>().Count() == 1)
            {
                frmDailyProductionEdit.Default.Activate();
            }
            frmDailyProductionEdit.Default.MdiParent = this;
            frmDailyProductionEdit.Default.Show();
        }

        private void btnGenPurch_ItemClick(object sender, ItemClickEventArgs e)
        {
 if (Application.OpenForms.OfType<frmCreateGRN>().Count() == 1)
            {
                frmCreateGRN.Default.Activate();
            }
            frmCreateGRN.Default.MdiParent = this;
            frmCreateGRN.Default.Show();
        }

        private void btnDailyBankCashReport_ItemClick(object sender, ItemClickEventArgs e)
        {
 if (Application.OpenForms.OfType<rptDailyBankCashReport>().Count() == 1)
            {
                rptDailyBankCashReport.Default.Activate();
            }
            rptDailyBankCashReport.Default.MdiParent = this;
            rptDailyBankCashReport.Default.Show();
        }

        private void btnDispatch_ItemClick(object sender, ItemClickEventArgs e)
        {
 if (Application.OpenForms.OfType<frmDispatch>().Count() == 1)
            {
                frmDispatch.Default.Activate();
            }
            frmDispatch.Default.MdiParent = this;
            frmDispatch.Default.Show();
        }

        private void btnPacketing_ItemClick(object sender, ItemClickEventArgs e)
        {
 if (Application.OpenForms.OfType<frmPacketing>().Count() == 1)
            {
                frmPacketing.Default.Activate();
            }
            frmPacketing.Default.MdiParent = this;
            frmPacketing.Default.Show();
        }

        private void btnIncomeStatement2_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<rptIncomeStatement2>().Count() == 1)
            {
                rptIncomeStatement2.Default.Activate();
            }
            rptIncomeStatement2.Default.MdiParent = this;
            rptIncomeStatement2.Default.Show();
        }

        private void btnSaleReportDetials_ItemClick(object sender, ItemClickEventArgs e)
        {
if (Application.OpenForms.OfType<rptSaleReportDetials>().Count() == 1)
            {
                rptSaleReportDetials.Default.Activate();
            }
            rptSaleReportDetials.Default.MdiParent = this;
            rptSaleReportDetials.Default.Show();
        }

        private void btnStrengthTest_ItemClick(object sender, ItemClickEventArgs e)
        {
if (Application.OpenForms.OfType<frmStrengthTest>().Count() == 1)
            {
                frmStrengthTest.Default.Activate();
            }
            frmStrengthTest.Default.MdiParent = this;
            frmStrengthTest.Default.Show();
        }

        private void btnfrmlissuanceEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
if (Application.OpenForms.OfType<frmlissuanceEdit>().Count() == 1)
            {
                frmlissuanceEdit.Default.Activate();
            }
            frmlissuanceEdit.Default.MdiParent = this;
            frmlissuanceEdit.Default.Show();
        }

        private void TaxReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<rptSaleTax>().Count() == 1)
            {
                rptSaleTax.Default.Activate();
            }
            rptSaleTax.Default.MdiParent = this;
            rptSaleTax.Default.Show();
        }

        private void WHTTaxonSupplies_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Application.OpenForms.OfType<rptWHT_On_Sup>().Count() == 1)
            {
                rptWHT_On_Sup.Default.Activate();
            }
            rptWHT_On_Sup.Default.MdiParent = this;
            rptWHT_On_Sup.Default.Show();
        }
    }
}