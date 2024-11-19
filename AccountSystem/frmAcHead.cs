using System;
using System.Windows.Forms;

namespace AccountSystem
{
    public partial class frmAcHead : Form
    {
        private MyModule c = new MyModule();

        public frmAcHead()
        {
            InitializeComponent();
            defaultInstance = this;
        }

        #region Default Instance

        private static frmAcHead defaultInstance;

        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static frmAcHead Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new frmAcHead();
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

        private void frmAcHead_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accHeadDS.TblAccHead' table. You can move, or remove it, as needed.
            this.tblAccHeadTableAdapter.Fill(this.accHeadDS.TblAccHead, MyModule.CompID);
        }

        private void tblAccHeadBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (ValidateControls())
            {
                modifiedTextBox.Text = MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo;
                repliCheckBox.Checked = false;
                this.Validate();
                this.tblAccHeadBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.accHeadDS);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            c.GetNum(accHeadCodeTextBox, "SELECT COUNT(*) AS Id FROM TblAccHead WHERE (CompanyID =" + MyModule.CompID + ")");

            if (string.IsNullOrEmpty(createdTextBox.Text))
            {
                createdTextBox.Text = MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo;
            }

            modifiedTextBox.Text = MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo;
            repliCheckBox.Checked = false;
            companyIDTextBox.Text = Convert.ToString(MyModule.CompID);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidateControls()
        {
            //bool functionReturnValue = false;
            bool validate = true;

            if (string.IsNullOrEmpty(accHeadNameTextBox.Text))
            {
                MessageBox.Show("Please enter a Account Head Name . . . ", "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return validate == false;
                //return functionReturnValue;
            }
            else if (string.IsNullOrEmpty(accTypeComboBox.Text))
            {
                MessageBox.Show("Please Select a Account Type . . . ", "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return validate == false;
            }
            return (validate);
            //return functionReturnValue;
        }
    }
}