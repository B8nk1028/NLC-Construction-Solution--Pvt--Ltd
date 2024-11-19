
using System;
using System.Data;
using System.Windows.Forms;

namespace AccountSystem
{
    public partial class frmUsers
    {
        public frmUsers()
        {
            InitializeComponent();

            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }

        #region Default Instance

        private static frmUsers defaultInstance;

        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static frmUsers Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new frmUsers();
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

        private DataSet MyDataSet = new DataSet();

        public void TblUserBindingNavigatorSaveItem_Click(System.Object sender, System.EventArgs e)
        {
            if (User_NameTextBox.Text == "")
            {
                MessageBox.Show("Please Enter User Name ...");
            }
            else if (PasswordTextBox.Text == "")
            {
                MessageBox.Show("Please enter Password ...");
            }
            else if (PasswordTextBox.Text != TextBox1.Text)
            {
                MessageBox.Show("Please chack Re-enterd password not matched with password");
            }
            else
            {
                this.Validate();
                this.TblUserBindingSource.EndEdit();
                this.TableAdapterManager.UpdateAll(this.UsersDataSet);
                FrmMain.Default.StatusTime.Glyph = global::AccountSystem.Properties.Resources.save_all;
                FrmMain.Default.StatusTime.Caption = " Successfully Saved...";
                Panel1.Visible = false;
            }
        }

        public void frmUsers_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            this.Hide();
            UsersDataSet.Clear();
            MyDataSet.Clear();
            this.MdiParent = null;
            Dispose();
        }

        public void frmUsers_Load(System.Object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'UsersDataSet.TblAccEntry' table. You can move, or remove it, as needed.
            this.tblAccEntryTableAdapter.Fill(this.UsersDataSet.TblAccEntry);
            //TODO: This line of code loads data into the 'UsersDataSet.TblUser' table. You can move, or remove it, as needed.
            this.TblUserTableAdapter.Fill(this.UsersDataSet.TblUser);
            
        }

        public void RadioBAdmin_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            GroupType.Tag = 1;
        }

        public void RadioBComm_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            GroupType.Tag = 2;
        }

        public void RadioBClient_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            GroupType.Tag = 0;
        }

        public void btnAdd_Click(System.Object sender, System.EventArgs e)
        {
            BindingNavigatorAddNewItem.Visible = true;
            BindingNavigatorAddNewItem.PerformClick();
            BindingNavigatorAddNewItem.Visible = false;
            Panel1.Visible = true;
            StatusCheckBox.Checked = false;
            GroupType.Tag = 1;
            RadioBAdmin.Checked = true;
        }

        public void ToolStripButton1_Click(System.Object sender, System.EventArgs e)
        {
            Panel1.Visible = false;
            this.TblUserTableAdapter.Fill(this.UsersDataSet.TblUser);
        }

        public void btnClose_Click(System.Object sender, System.EventArgs e)
        {
            this.Close();
        }

        public void TblUserDataGridView_CellDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            Panel1.Visible = true;
            if (System.Convert.ToInt32(GroupType.Tag) == 1)
            {
                RadioBAdmin.Checked = true;
            }
            else if (System.Convert.ToInt32(GroupType.Tag) == 2)
            {
                RadioBComm.Checked = true;
            }
            else
            {
                RadioBClient.Checked = true;
            }
        }

        public void StatusCheckBox_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (StatusCheckBox.CheckState == CheckState.Checked)
            {
                Panel2.Enabled = false;
            }
            else
            {
                Panel2.Enabled = true;
            }
        }

        private void TblUserDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (TblUserDataGridView.Columns[e.ColumnIndex].Name.Equals("userTypeDataGridViewTextBoxColumn"))
            {
                if (!Convert.IsDBNull(e.Value))
                {
                    if (Convert.ToInt32(e.Value) == 1)
                    {
                        TblUserDataGridView.Rows[e.RowIndex].Cells[0].Value = global::AccountSystem.Properties.Resources.admin2;
                    }
                    else if (Convert.ToInt32(e.Value) == 2)
                    {
                        TblUserDataGridView.Rows[e.RowIndex].Cells[0].Value = global::AccountSystem.Properties.Resources.Extv2;
                    }
                    else
                    {
                        TblUserDataGridView.Rows[e.RowIndex].Cells[0].Value = global::AccountSystem.Properties.Resources.user2;
                    }
                }
            }
        }

        private void checkedListBoxControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
 
        }
    }
}