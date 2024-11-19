using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace AccountSystem
{
    public partial class GeneralEntries : Form
    {
        private MyModule Fn = new MyModule();
        public string Legders;
        public GeneralEntries()
        {
            InitializeComponent();
            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }
        #region Default Instance
        private static GeneralEntries defaultInstance;
        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static GeneralEntries Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new GeneralEntries();
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
        private void LedgerReport_Load(object sender, EventArgs e)
        {
            Fn.fillCombo(cbLocation, "select '%','ALL' union SELECT convert(varchar,EntryAccID), EntryAccName FROM TblAccEntry WHERE (AccType IN (22, 23))");
            //Fn.CenterScreen(this);
            string[] opnset = Fn.GetRecords("SELECT CodeSt,AccYear FROM tblMonthCloseing WHERE (CompID =" + MyModule.CompID + ")");
            datePicker1.Value = Convert.ToDateTime(opnset[1]);
        }
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Fn.Exec("DELETE FROM LadgerView; INSERT INTO LadgerView  (edate, VNo, Des, Dr, Cr, Totals,VID,AccID) SELECT VW_VoucherHDR.EntryDate, VW_VoucherHDR.VoucherNo, VW_VoucherDTL.Descripation + Case When IsNull(VW_VoucherHDR.CheqNo,'') = '' Then '' Else '  Cheque No: ' + VW_VoucherHDR.CheqNo End AS Expr1, VW_VoucherDTL.AmountDeb, VW_VoucherDTL.AmountCre, VW_VoucherDTL.AmountDeb - VW_VoucherDTL.AmountCre AS totals,VW_VoucherHDR.VoucherID,VW_VoucherDTL.AccEntryID FROM VW_VoucherDTL INNER JOIN VW_VoucherHDR ON VW_VoucherDTL.VoucherID = VW_VoucherHDR.VoucherID WHERE (VW_VoucherHDR.EntryDate BETWEEN CONVERT(DATETIME, '" + datePicker1.Text + "' , 102) AND CONVERT(DATETIME, '" + datePicker2.Text + "', 102)) AND (VW_VoucherHDR.CompID = 1) AND (CONVERT(varchar, VW_VoucherHDR.BranchID) LIKE '" + cbLocation.SelectedValue + "')");
            MyModule.ParmA = "From " + datePicker1.Text + " to " + datePicker2.Text;
            MyModule.ParmB = "";
            GLadgerRpt.Default.MdiParent = FrmMain.Default;
            GLadgerRpt.Default.Show();
            //this.Close();
        }
    }
}