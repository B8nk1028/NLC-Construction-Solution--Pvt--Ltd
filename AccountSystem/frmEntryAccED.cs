using System;
using System.Data;
using System.Windows.Forms;

namespace AccountSystem
{
    public partial class frmEntryAccED : Form
    {
        private MyModule fn = new MyModule();

        public frmEntryAccED()
        {
            InitializeComponent();
            defaultInstance = this;
        }

        #region Default Instance

        private static frmEntryAccED defaultInstance;

        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static frmEntryAccED Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new frmEntryAccED();
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tblAccSubHeadBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (ValidateControls())
            {
                //CountCode();
                this.Validate();
                fn.Exec("UPDATE TblAccEntry SET EntryAccName ='" + accSubNameTextBox.Text + "', Modified ='" + MyModule.UserName + "@" + DateTime.Now + "', Repli =0 WHERE (EntryAccID = " + accSubCodeTextBox.Text + ")");
                //this.tblAccEntryBindingSource.EndEdit();
                //this.tblAccEntryTableAdapter.Update(this.accEntrDS);
                //bindingNavigatorAddNewItem.Visible = true;
                ////bindingNavigatorAddNewItem.PerformClick();
                //bindingNavigatorAddNewItem.Visible = false;
            }
        }

        private void cboHead_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cboHead.Text))
            {
                FilterSubCode();
            }
        }

        private void FilterCode()
        {
            try
            {
                if (!string.IsNullOrEmpty(cboSubH.Text))
                {
                    DataSet MyDataSet = new DataSet();
                    MyDataSet.Clear();
                    string MySQLStr = "Select right(REPLICATE('0',2) + cast(TblAccHead.AccHeadCode as varchar(2)),2)+ '-' + right(REPLICATE('0',3) + cast(TblAccSubHead.AccSubCode as varchar(3)),3)+ '-' + right(REPLICATE('0',4) + cast(TblAccEntry.EntryAccCode as varchar(4)),4) AS Code, TblAccEntry.EntryAccName AS 'Entry Account Name', TblAccEntry.EntryAccID FROM TblAccHead INNER JOIN TblAccSubHead ON TblAccHead.AccHeadID = TblAccSubHead.AccHeadID INNER JOIN TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID WHERE (TblAccSubHead.AccSubID =" + cboSubH.SelectedValue + ")";
                    System.Data.SqlClient.SqlDataAdapter MyDataAdapter = new System.Data.SqlClient.SqlDataAdapter(MySQLStr,(string)global::AccountSystem.Properties.Settings.Default.DBConnectionString);
                    MyDataAdapter.Fill(MyDataSet);

                    tblAccHeadDataGridView.DataSource = MyDataSet.Tables[0];
                    tblAccHeadDataGridView.Columns[0].Width = 120;
                    tblAccHeadDataGridView.Columns[1].Width = 300;
                    tblAccHeadDataGridView.Columns[2].Width = 0;
                    tblAccHeadDataGridView.Columns[2].Visible = false;
                    MyDataSet.Dispose();
                }
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

        private void CountCode()
        {
            try
            {
                DataSet MyDataSet = new DataSet();
                MyDataSet.Clear();

                string MySQLStr = "SELECT COUNT(*) AS Id FROM TblAccEntry WHERE (AccSubID=" + cboSubH.SelectedValue + ")";
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
            else if (string.IsNullOrEmpty(cboSubH.Text))
            {
                MessageBox.Show("Please select a Sub Account Head . . . ", "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return validate == false;
                //return functionReturnValue;
            }
            else if (string.IsNullOrEmpty(accSubNameTextBox.Text))
            {
                MessageBox.Show("Please Enter Entry Account Name for " + cboHead.Text, "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return validate == false;
            }

            return (validate);
            //return functionReturnValue;
        }

        private void FilterSubCode()
        {
            try
            {
                DataSet MyDataSet = new DataSet();
                MyDataSet.Clear();
                string MySQLStr = "SELECT TblAccSubHead.AccSubID, TblAccSubHead.AccSubName FROM TblAccHead INNER JOIN TblAccSubHead ON TblAccHead.AccHeadID = TblAccSubHead.AccHeadID WHERE (TblAccHead.AccHeadID =" + cboHead.SelectedValue + ")";
                System.Data.SqlClient.SqlDataAdapter MyDataAdapter = new System.Data.SqlClient.SqlDataAdapter(MySQLStr,(string)global::AccountSystem.Properties.Settings.Default.DBConnectionString);
                MyDataAdapter.Fill(MyDataSet);
                cboSubH.DisplayMember = "AccSubName";
                cboSubH.ValueMember = "AccSubID";
                cboSubH.DataSource = MyDataSet.Tables[0];

                MyDataSet.Dispose();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void cboSubH_SelectedIndexChanged(object sender, EventArgs e)
        {
            accSubNameTextBox.Text = "";
            accSubCodeTextBox.Text = "";
            FilterCode();
        }

        private void frmEntryAcc_Load_1(object sender, EventArgs e)
        {
            DataSet MyDataSet = new DataSet();
            MyDataSet.Clear();
            string MySQLStr = "SELECT AccHeadID, AccHeadName FROM TblAccHead WHERE (CompanyID =" + MyModule.CompID + ")";
            System.Data.SqlClient.SqlDataAdapter MyDataAdapter = new System.Data.SqlClient.SqlDataAdapter(MySQLStr,(string)global::AccountSystem.Properties.Settings.Default.DBConnectionString);
            MyDataAdapter.Fill(MyDataSet);
            cboHead.DisplayMember = "AccHeadName";
            cboHead.ValueMember = "AccHeadID";
            cboHead.DataSource = MyDataSet.Tables[0];
            MyDataSet.Dispose();
            FilterSubCode();
            try
            {
                bindingNavigatorAddNewItem.PerformClick();
                bindingNavigatorAddNewItem.Visible = false;
                //this.tblAccEntryTableAdapter.Fill(this.accEntrDS.TblAccEntry);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void tblAccHeadDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            accSubNameTextBox.Text = tblAccHeadDataGridView.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            accSubCodeTextBox.Text = tblAccHeadDataGridView.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
        }
    }
}