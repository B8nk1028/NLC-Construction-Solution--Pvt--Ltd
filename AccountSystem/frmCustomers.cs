
using System;
using System.Data;
using System.Windows.Forms;

namespace AccountSystem
{
    
    public partial class frmCustomers
    {
        MyModule Fn = new MyModule();
        public frmCustomers()
        {
            InitializeComponent();
            if (defaultInstance == null)
                defaultInstance = this;
        }

        #region Default Instance

        private static frmCustomers defaultInstance;
        public static frmCustomers Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new frmCustomers();
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

        private void sp_RegisterCustomerSelectBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            createdTextBox.Text = MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo;
            modifiedTextBox.Text = MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo;
            this.Validate();
            this.sp_RegisterCustomerSelectBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cVESDAccounts);

        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            Fn.fillCombo(cbLocation, "sp_OfficeLocations");
            Fn.fillCombo(statComboBox, "SELECT 1 as vl,'Active' as txt UNION SELECT 0 as vl,'Inactive' as txt");
            Fn.fillCombo(bCityComboBox, "SELECT CityID, CityNmae FROM tblLocations order by CityNmae");
            Fn.fillCombo(cboPayTerms, "SELECT PaymentTermsID, PaymentTermsTxt FROM tblPaymentTerms");
            this.sp_RegisterCustomerSelectTableAdapter.Fill(this.cVESDAccounts.sp_RegisterCustomerSelect,"%");
            //if (MyModule.UserName.ToUpper()!="admin".ToUpper())
            //{
            //    statComboBox.Enabled = false;
            //    crLimitTextBox.ReadOnly = true;
            //}

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            createdTextBox.Text = MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo;
            modifiedTextBox.Text = MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo;
            statComboBox.SelectedValue = 0;
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            this.sp_RegisterCustomerSelectBindingSource.CancelEdit();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.sp_RegisterCustomerSelectTableAdapter.Fill(this.cVESDAccounts.sp_RegisterCustomerSelect, txtSearch.Text);
        }

        private void statLabel_Click(object sender, EventArgs e)
        {

        }
    }
}