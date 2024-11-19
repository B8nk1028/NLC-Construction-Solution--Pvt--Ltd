
using System;
using System.Data;
using System.Windows.Forms;

namespace AccountSystem
{
    
    public partial class frmEmployees
    {
        MyModule Fn = new MyModule();
        public frmEmployees()
        {
            InitializeComponent();
            if (defaultInstance == null)
                defaultInstance = this;
        }

        #region Default Instance

        private static frmEmployees defaultInstance;
        public static frmEmployees Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new frmEmployees();
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

        private void sp_RegisterStaffSelectBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            createdTextBox.Text = MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo;
            modifiedTextBox.Text = MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo;
            this.Validate();
            this.sp_RegisterStaffSelectBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cVESDAccounts);

        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            Fn.fillCombo(statComboBox, "SELECT 1 as vl,'Active' as txt UNION SELECT 0 as vl,'Inactive' as txt");
            Fn.fillCombo(accTypeComboBox, "SELECT 9 as vl,'Salesmen' as txt UNION SELECT 20 as vl,'General Staff' as txt");
            this.sp_RegisterStaffSelectTableAdapter.Fill(this.cVESDAccounts.sp_RegisterStaffSelect);
            //if (MyModule.UserName.ToLower() != "admin".ToLower())
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
            this.sp_RegisterStaffSelectBindingSource.CancelEdit();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}