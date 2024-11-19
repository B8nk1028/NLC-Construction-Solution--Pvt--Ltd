using Newtonsoft.Json;
using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
namespace AccountSystem
{
    public partial class FundTransfer : Form
    {
        private MyModule Fn = new MyModule();
        public string Legders;
        public FundTransfer()
        {
            InitializeComponent();
            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }
        #region Default Instance
        private static FundTransfer defaultInstance;
        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static FundTransfer Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new FundTransfer();
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
            
        }
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            Fn.fillCombo(toLocation, "SELECT convert(varchar,EntryAccID), EntryAccName FROM TblAccEntry WHERE (AccType IN (23, 22)) AND EntryAccID<>" + cbLocation.SelectedValue);
            Fn.fillCombo(cboAcc, "SELECT EntryAccID, EntryAccName FROM TblAccEntry WHERE (Stat = 1) AND (BranchID IS NULL OR BranchID = " + cbLocation.SelectedValue + ") ORDER BY EntryAccName");
            cboAcc.SelectedIndex = -1;
        }
        private void datePicker1_Enter(object sender, EventArgs e)
        {
            string[] actDate = Fn.GetRecords("sp_ActiveDates");
            datePicker1.MaxDate = Convert.ToDateTime(actDate[1]);
            datePicker1.MinDate = Convert.ToDateTime(actDate[0]);
        }
        private void toLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            Fn.fillCombo(toAcc, "SELECT EntryAccID, EntryAccName FROM TblAccEntry WHERE (Stat = 1) AND (BranchID IS NULL OR BranchID = " + toLocation.SelectedValue + ") ORDER BY EntryAccName");
            toAcc.SelectedIndex = -1;
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            if (btnShow.Text == "Add New")
            {
                Fn.fillCombo(cbLocation, "sp_OfficeLocations");
                txtAmount.Text = "";
                bankIDTextBox.Text = "";
                btnShow.Text = "Post";
            }
            else
            {
                DateTime sdate = DateTime.ParseExact(MyModule.AMonth, "MMyyyy", CultureInfo.InvariantCulture);
                DateTime edate = sdate.AddMonths(-1);
                sdate = (sdate.AddMonths(1)).AddDays(-1);
                if (!Fn.Between(datePicker1.Value.ToString("yyyyMM"), edate.ToString("yyyyMM"), sdate.ToString("yyyyMM")))
                {
                    MessageBox.Show("Please enter a valid date ...", "Active Mouths are " + edate.ToString("MMMM yyyy") + " and " + sdate.ToString("MMMM yyyy"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (toAcc.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select account ...", "Invalid Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (cboAcc.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select account ...", "Invalid Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtAmount.Text == "")
                {
                    MessageBox.Show("Please enter amount ...", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string Data2Post = "{\"EntryDate\":" + JsonConvert.ToString(datePicker1.Text) + ",\"Memo\":" + JsonConvert.ToString(bankIDTextBox.Text) + ",\"Created\":" + JsonConvert.ToString(MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo) + ",\"CompanyID\":" + JsonConvert.ToString(MyModule.CompID) + ",\"items\":[{\"AccEntryID\":" + JsonConvert.ToString(toLocation.SelectedValue) + ",\"Description\":" + JsonConvert.ToString(bankIDTextBox.Text) + ",\"AmountDeb\":" + JsonConvert.ToString(txtAmount.Text) + ",\"AmountCre\":0,\"Ref\":0},{\"AccEntryID\":" + JsonConvert.ToString(cboAcc.SelectedValue) + ",\"Description\":" + JsonConvert.ToString(bankIDTextBox.Text) + ",\"AmountCre\":" + JsonConvert.ToString(txtAmount.Text) + ",\"AmountDeb\":0,\"Ref\":0}]}";
                string ID = Fn.GetRecords("sp_CreateJV '" + Data2Post + "'," + cbLocation.SelectedValue)[0];
                string Data2Post2 = "{\"EntryDate\":" + JsonConvert.ToString(datePicker1.Text) + ",\"Memo\":" + JsonConvert.ToString(bankIDTextBox.Text) + ",\"Created\":" + JsonConvert.ToString(MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo) + ",\"CompanyID\":" + JsonConvert.ToString(MyModule.CompID) + ",\"items\":[{\"AccEntryID\":" + JsonConvert.ToString(toAcc.SelectedValue) + ",\"Description\":" + JsonConvert.ToString(bankIDTextBox.Text) + ",\"AmountDeb\":" + JsonConvert.ToString(txtAmount.Text) + ",\"AmountCre\":0,\"Ref\":0},{\"AccEntryID\":" + JsonConvert.ToString(cbLocation.SelectedValue) + ",\"Description\":" + JsonConvert.ToString(bankIDTextBox.Text) + ",\"AmountCre\":" + JsonConvert.ToString(txtAmount.Text) + ",\"AmountDeb\":0,\"Ref\":0}]}";
                string ID2 = Fn.GetRecords("sp_CreateJV '" + Data2Post2 + "'," + toLocation.SelectedValue)[0];
                if (ID == "a")
                {
                    MessageBox.Show("There is some issue in data please check and try again", "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                btnShow.Text = "Add New";
                MessageBox.Show("Fund transfered successfully ...", "Saved Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        private void FundTransfer_Activated(object sender, EventArgs e)
        {
            Fn.fillCombo(cbLocation, "sp_OfficeLocations");
            txtAmount.Text = "";
            bankIDTextBox.Text = "";
        }
    }
}