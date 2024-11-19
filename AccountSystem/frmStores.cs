
using System;
using System.Data;
using System.Windows.Forms;

namespace AccountSystem
{
    
    public partial class frmStores
    {
        MyModule Fn = new MyModule();
        public frmStores()
        {
            InitializeComponent();
            if (defaultInstance == null)
                defaultInstance = this;
        }

        #region Default Instance

        private static frmStores defaultInstance;
        public static frmStores Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new frmStores();
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

        private void sp_RegisterStoreSelectBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            createdTextBox.Text = MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo;
            modifiedTextBox.Text = MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo;
            this.Validate();
            this.sp_RegisterStoreSelectBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cVESDAccounts);

        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            Fn.fillCombo(statComboBox, "SELECT 1 as vl,'Active' as txt UNION SELECT 0 as vl,'Inactive' as txt");
            Fn.fillCombo(accTypeComboBox, "SELECT 21 as vl,'Stores' as txt UNION SELECT 22 as vl,'Departments' as txt");
            Fn.fillCombo(bCityComboBox, "SELECT CityID, CityNmae FROM tblLocations order by CityNmae");
            this.sp_RegisterStoreSelectTableAdapter.Fill(this.cVESDAccounts.sp_RegisterStoreSelect);
            //if (MyModule.UserName.ToLower() != "admin")
            //{
            //    statComboBox.Enabled = false;
            //}
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            createdTextBox.Text = MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo;
            modifiedTextBox.Text = MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo;
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            this.sp_RegisterStoreSelectBindingSource.CancelEdit();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}