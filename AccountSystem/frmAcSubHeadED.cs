using System;
using System.Data;
using System.Windows.Forms;

namespace AccountSystem
{
    public partial class frmAcSubHeadED : Form
    {
        private MyModule Fn = new MyModule();

        public frmAcSubHeadED()
        {
            InitializeComponent();
            defaultInstance = this;
        }

        #region Default Instance

        private static frmAcSubHeadED defaultInstance;

        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static frmAcSubHeadED Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new frmAcSubHeadED();
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
            // TODO: This line of code loads data into the 'accSubHDS.TblAccSubHead' table. You can move, or remove it, as needed.

            this.tblAccHeadTableAdapter.Fill(this.accHeadDS.TblAccHead, MyModule.CompID);
            bindingNavigatorAddNewItem.Visible = true;
            bindingNavigatorAddNewItem.Visible = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tblAccSubHeadBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (ValidateControls())
            {
                this.Validate();
                Fn.Exec("UPDATE TblAccSubHead SET AccSubName = N'" + accSubNameTextBox.Text + "', Modified = N'" + MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo + "', Repli = 0 where AccSubID='" + accSubCodeTextBox.Text + "'");
            }
        }

        private void cboHead_SelectedIndexChanged(object sender, EventArgs e)
        {
            accSubNameTextBox.Text = "";
            accSubCodeTextBox.Text = "";
            if (!string.IsNullOrEmpty(cboHead.Text))
            {
                FilterCode();
            }
        }

        private void FilterCode()
        {
            try
            {
                DataSet MyDataSet = new DataSet();
                MyDataSet.Clear();
                string MySQLStr = "SELECT right(REPLICATE('0',2) + cast(TblAccHead.AccHeadCode as varchar(2)),2)+ '-' + right(REPLICATE('0',3) + cast(TblAccSubHead.AccSubCode as varchar(3)),3) AS 'Account Code',TblAccSubHead.AccSubName as 'Account Name', TblAccSubHead.AccSubID FROM TblAccHead INNER JOIN TblAccSubHead ON TblAccHead.AccHeadID = TblAccSubHead.AccHeadID  WHERE (TblAccHead.AccHeadID =" + cboHead.SelectedValue + ")";
                System.Data.SqlClient.SqlDataAdapter MyDataAdapter = new System.Data.SqlClient.SqlDataAdapter(MySQLStr,(string)global::AccountSystem.Properties.Settings.Default.DBConnectionString);
                MyDataAdapter.Fill(MyDataSet);

                tblAccHeadDataGridView.DataSource = MyDataSet.Tables[0];
                tblAccHeadDataGridView.Columns[0].Width = 80;
                tblAccHeadDataGridView.Columns[1].Width = 200;
                tblAccHeadDataGridView.Columns[2].Width = 0;
                tblAccHeadDataGridView.Columns[2].Visible = false;
                MyDataSet.Dispose();
            }
            catch (System.Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void CountCode()
        {
            try
            {
                DataSet MyDataSet = new DataSet();
                MyDataSet.Clear();

                string MySQLStr = "SELECT COUNT(*) AS Id FROM TblAccSubHead WHERE (AccHeadID =" + cboHead.SelectedValue + ")";
                System.Data.SqlClient.SqlDataAdapter MyDataAdapter = new System.Data.SqlClient.SqlDataAdapter(MySQLStr,(string)global::AccountSystem.Properties.Settings.Default.DBConnectionString);
                MyDataAdapter.Fill(MyDataSet);
                int hcode = (Int32)(MyDataSet.Tables[0].Rows[0][0]) + 1;
                accSubCodeTextBox.Text = Convert.ToString(hcode);
                MyDataSet.Dispose();
                if (string.IsNullOrEmpty(createdTextBox.Text))
                {
                    createdTextBox.Text = MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo;
                }

                modifiedTextBox.Text = MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo;
                repliCheckBox.Checked = false;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidateControls()
        {
            //bool functionReturnValue = false;
            bool validate = true;

            if (string.IsNullOrEmpty(cboHead.Text))
            {
                MessageBox.Show("Please select a Account Head . . . ", "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return validate == false;
                //return functionReturnValue;
            }
            else if (string.IsNullOrEmpty(accSubNameTextBox.Text))
            {
                MessageBox.Show("Please Enter SubAccount Name for " + cboHead.Text, "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return validate == false;
            }

            return (validate);
            //return functionReturnValue;
        }

        private void tblAccHeadDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            accSubNameTextBox.Text = tblAccHeadDataGridView.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            accSubCodeTextBox.Text = tblAccHeadDataGridView.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
        }
    }
}