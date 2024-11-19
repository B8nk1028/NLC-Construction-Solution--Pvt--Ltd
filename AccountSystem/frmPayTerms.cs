using System;
using System.Data;
using System.Windows.Forms;
namespace AccountSystem
{
    public partial class frmPayTerms
    {
        MyModule Fn = new MyModule();
        public frmPayTerms()
        {
            InitializeComponent();
            if (defaultInstance == null)
                defaultInstance = this;
        }
        #region Default Instance
        private static frmPayTerms defaultInstance;
        public static frmPayTerms Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new frmPayTerms();
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
        private void frmVendors_Load(object sender, EventArgs e)
        {
            this.tblPaymentTermsTableAdapter.Fill(this.dataSet2.tblPaymentTerms);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tblPaymentTermsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblPaymentTermsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet2);
        }
    }
}