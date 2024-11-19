
using System;
using System.Data;
using System.Windows.Forms;

namespace AccountSystem
{
    
    public partial class frmVendors
    {
        MyModule Fn = new MyModule();
        public frmVendors()
        {
            InitializeComponent();
            if (defaultInstance == null)
                defaultInstance = this;
        }

        #region Default Instance

        private static frmVendors defaultInstance;
        public static frmVendors Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new frmVendors();
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

        private void sp_RegisterVendorsSelectBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            createdTextBox.Text = MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo;
            modifiedTextBox.Text = MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo;
            this.Validate();
            this.sp_RegisterVendorsSelectBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cVESDAccounts);

        }

        private void frmVendors_Load(object sender, EventArgs e)
        {
            Fn.fillCombo(statComboBox, "SELECT 1 as vl,'Active' as txt UNION SELECT 0 as vl,'Inactive' as txt");
            this.sp_RegisterVendorsSelectTableAdapter.Fill(this.cVESDAccounts.sp_RegisterVendorsSelect);
            //if (MyModule.UserName.ToUpper() != "admin".ToUpper())
            //{
            //    statComboBox.Enabled = false;
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
            this.sp_RegisterVendorsSelectBindingSource.CancelEdit();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}