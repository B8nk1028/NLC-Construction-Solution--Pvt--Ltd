using System;
using System.Drawing;
using System.Windows.Forms;

namespace AccountSystem
{
    public partial class frmCompany : Form
    {
        public frmCompany()
        {
            InitializeComponent();
            if (defaultInstance == null)
                defaultInstance = this;
        }

        #region Default Instance

        private static frmCompany defaultInstance;

        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static frmCompany Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new frmCompany();
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

        private void tblCompanyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(createdTextBox.Text))
            {
                createdTextBox.Text = MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo;
            }

            modifiedTextBox.Text = MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo;
            repliCheckBox.Checked = false;
            if (ValidateControls())
            {
                try
                {
                    this.Validate();
                    this.tblCompanyBindingSource.EndEdit();
                    //this.tableAdapterManager.UpdateAll(this.companyDSet);
                    this.tblCompanyTableAdapter.Update(this.companyDSet);
                    this.tblCompanyAccessTableAdapter.Update(this.companyDSet);
                }
                catch
                { }
            }
        }

        private void frmCompany_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userListD.TblUser' table. You can move, or remove it, as needed.
            this.tblUserTableAdapter.Fill(this.userListD.TblUser);
            // TODO: This line of code loads data into the 'companyDSet.TblCompanyAccess' table. You can move, or remove it, as needed.
            this.tblCompanyAccessTableAdapter.Fill(this.companyDSet.TblCompanyAccess);
            // TODO: This line of code loads data into the 'companyDSet.TblCompany' table. You can move, or remove it, as needed.
            this.tblCompanyTableAdapter.Fill(this.companyDSet.TblCompany);
        }

        private void companyNameTextBox_TextChanged(object sender, EventArgs e)
        {
            lblCompany.Text = companyNameTextBox.Text;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tblCompanyAccessDataGridView_Enter(object sender, EventArgs e)
        {
            if (ValidateControls())
            {
                this.Validate();
                this.tblCompanyBindingSource.EndEdit();
                this.tblCompanyTableAdapter.Update(this.companyDSet);
            }
        }

        private void tblCompanyAccessDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty((string)(tblCompanyAccessDataGridView.Rows[e.RowIndex].Cells[1].Value)))
                {
                    tblCompanyAccessDataGridView.Rows[e.RowIndex].Cells[1].Value = MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo;
                }
            }
            catch
            {
                tblCompanyAccessDataGridView.Rows[e.RowIndex].Cells[1].Value = MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo;
            }

            tblCompanyAccessDataGridView.Rows[e.RowIndex].Cells[2].Value = MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo;
            tblCompanyAccessDataGridView.Rows[e.RowIndex].Cells[3].Value = "False";
        }

        private void tblCompanyAccessDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                System.Windows.Forms.SendKeys.Send("DELETE {DELETE}");
            }
        }

        private void tblCompanyAccessDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Do you want to remove the User", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection();
                    con.ConnectionString =(string)global::AccountSystem.Properties.Settings.Default.DBConnectionString;
                    con.Open();
                    string DelQry = "DELETE FROM TblCompanyAccess WHERE (CompanyID=" + companyIDTextBox.Text + ") AND (UserID= " + tblCompanyAccessDataGridView.Rows[tblCompanyAccessDataGridView.CurrentCell.RowIndex].Cells[0].Value + ")";
                    string sql = "INSERT INTO TblDelLog (Sql) VALUES (N'" + DelQry + "')";

                    System.Data.SqlClient.SqlCommand cmd = null;

                    cmd = new System.Data.SqlClient.SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();

                    cmd = new System.Data.SqlClient.SqlCommand(DelQry, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void tblCompanyAccessDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if ((e.Context == DataGridViewDataErrorContexts.Commit))
            {
                MessageBox.Show("User Allready Exist for " + lblCompany.Text, "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool ValidateControls()
        {
            //bool functionReturnValue = false;
            bool validate = true;

            if (string.IsNullOrEmpty(companyNameTextBox.Text))
            {
                MessageBox.Show("Please Enter Company Name . . . " + lblCompany.Text, "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return validate == false;
                //return functionReturnValue;
            }
            return (validate);
            //return functionReturnValue;
        }

        private void SimpleButton8_Click(object sender, EventArgs e)
        {
            opnDialog.Filter = "Jpeg Files(*.Jpeg)|*.jpg;*.png;*.bmp";
            if (opnDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.MemoryStream msPhoto = new System.IO.MemoryStream();
                Bitmap bitmap1 = (Bitmap)System.Drawing.Image.FromFile(opnDialog.FileName);
                bitmap1.Save(msPhoto, System.Drawing.Imaging.ImageFormat.Jpeg);

                logoPictureBox.Image = System.Drawing.Image.FromStream(msPhoto);
            }
        }
    }
}