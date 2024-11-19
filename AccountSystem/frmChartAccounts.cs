using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AccountSystem
{
    public partial class frmChartAccounts : Form
    {
        MyModule Fn = new MyModule();
        string SelNode;
        public frmChartAccounts()
        {
            InitializeComponent();
            if (defaultInstance == null)
                defaultInstance = this;
        }
        #region Default Instance

        private static frmChartAccounts defaultInstance;

        public static frmChartAccounts Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new frmChartAccounts();
                    defaultInstance.FormClosed += new FormClosedEventHandler(defaultInstance_FormClosed);
                }

                return defaultInstance;
            }
        }

        static void defaultInstance_FormClosed(object sender, FormClosedEventArgs e)
        {
            defaultInstance = null;
        }

        #endregion
        private void Refrsh()
        {
            // TODO: This line of code loads data into the 'accountHeads.TblAccEntry' table. You can move, or remove it, as needed.
            this.tblAccEntryTableAdapter.Fill(this.accountHeads.TblAccEntry,MyModule.CompID);
            // TODO: This line of code loads data into the 'accountHeads.TblAccSubHead' table. You can move, or remove it, as needed.
            this.tblAccSubHeadTableAdapter.Fill(this.accountHeads.TblAccSubHead, MyModule.CompID);
            // TODO: This line of code loads data into the 'accountHeads.TblAccHead' table. You can move, or remove it, as needed.
            this.tblAccHeadTableAdapter.Fill(this.accountHeads.TblAccHead, MyModule.CompID);
            treeView1.Nodes.Clear();
            foreach (DataRow dr in accountHeads.Tables["TblAccHead"].Rows)
            {

                TreeNode tn = new TreeNode(dr["HeadAccount"].ToString());
                tn.Tag = dr["AccHeadID"].ToString();
                tn.ToolTipText = "Top Level";
                tn.ImageIndex = 1;
                foreach (DataRow drChild in dr.GetChildRows("TblAccHead_TblAccSubHead"))
                {

                    TreeNode tnn = new TreeNode(drChild["SubAccount"].ToString());
                    tnn.Tag = drChild["AccSubID"].ToString();
                    tnn.ToolTipText = "2nd Level";
                    tnn.ImageIndex = 2;
                    tn.Nodes.Add(tnn);

                    foreach (DataRow drGchild in drChild.GetChildRows("TblAccSubHead_TblAccEntry"))
                    {

                        TreeNode tnnn = new TreeNode(drGchild["EntryAccount"].ToString());
                        tnnn.Tag = drGchild["EntryAccID"].ToString();
                        tnnn.ToolTipText = "3rd Level";
                        tnnn.ImageIndex = 3;
                        tnn.Nodes.Add(tnnn);

                    }

                }                treeView1.Nodes.Add(tn);
            }
            //treeView1.ExpandAll();
            if (Fn.GetRecords("SELECT COUNT(AccHeadID) AS Expr1 FROM TblAccHead WHERE (CompanyID = "+MyModule.CompID+")")[0] == "0")
            {
                grpNewCOH.Visible = true;
            }
            else
            {
                grpNewCOH.Visible = false;
            }
        }
        private void frmChartAccounts_Load(object sender, EventArgs e)
        {
            Refrsh();
            Fn.fillCombo(cboHead, "SELECT AccHeadID, AccHeadName FROM TblAccHead WHERE (CompanyID = " + MyModule.CompID + ")");
            Fn.fillCombo(cboSubH, "SELECT TblAccSubHead.AccSubID, RIGHT(REPLICATE('0', 2) + CAST(TblAccHead.AccHeadCode AS varchar(2)), 2) + '-' + RIGHT(REPLICATE('0', 3) + CAST(TblAccSubHead.AccSubCode AS varchar(3)), 3) + ' ' + TblAccSubHead.AccSubName AS SubHeads FROM TblAccSubHead INNER JOIN TblAccHead ON TblAccSubHead.AccHeadID = TblAccHead.AccHeadID WHERE (TblAccHead.CompanyID = " + MyModule.CompID + ") GROUP BY TblAccSubHead.AccSubID, RIGHT(REPLICATE('0', 2) + CAST(TblAccHead.AccHeadCode AS varchar(2)), 2) + '-' + RIGHT(REPLICATE('0', 3) + CAST(TblAccSubHead.AccSubCode AS varchar(3)), 3) + ' ' + TblAccSubHead.AccSubName");
            Fn.fillCombo(ddCompany, "SELECT CompanyID, CompanyName FROM TblCompany WHERE (CompanyID <> "+MyModule.CompID+")");
            Fn.fillCombo(cbStat, "SELECT 1 as vl,'Active' as txt UNION SELECT 0 as vl,'Inactive' as txt");
            Fn.fillCombo(ddType, "SELECT 1 as vl,'General' as txt UNION SELECT 2 as vl,'Cash' as txt UNION SELECT 3 as vl,'Bank' as txt");

        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.ToolTipText == "Top Level")
            {
                Fn.fillCombo(cboHead, "SELECT AccHeadID, AccHeadName FROM TblAccHead WHERE (CompanyID = " + MyModule.CompID + ")");
                SelNode =e.Node.Tag.ToString();
                GrpHeads.Visible = true;
                GrpSubHeads.Visible = false;
                GrpEntryHeads.Visible = false;
                string[] Rerd = Fn.GetRecords("SELECT AccHeadCode, AccHeadName,AccType, Created, Modified FROM TblAccHead WHERE (AccHeadID =" + e.Node.Tag + ")");
                accHeadCodeTextBox.Text = Rerd[0];
                accHeadCodeTextBox.Tag = e.Node.Tag;
                accHeadNameTextBox.Text = Rerd[1];
                accTypeComboBox.Text = Rerd[2];
                lblHCreated.Text ="Created: "+ Rerd[3];
                lblHModify.Text = "Modified: " + Rerd[4];
                simpleButton1.Text = "&Add New";
                SimpleButton8.Text = "&Update";
                SimpleButton8.Image = global::AccountSystem.Properties.Resources.save_all;
            }
            else if (e.Node.ToolTipText == "2nd Level")
            {
                SelNode =e.Node.Tag.ToString();
                GrpHeads.Visible = false;
                GrpSubHeads.Visible = true;
                GrpEntryHeads.Visible = false;
                string[] Rerd = Fn.GetRecords("SELECT AccSubCode,AccSubName,AccHeadID, Created, Modified  FROM TblAccSubHead WHERE (AccSubID =" + e.Node.Tag + ")");
                textBox2.Text = Rerd[0];
                textBox2.Tag = e.Node.Tag;
                accSubNameTextBox.Text = Rerd[1];
                Fn.fillCombo(cboHead, "SELECT AccHeadID, AccHeadName FROM TblAccHead WHERE (CompanyID = "+MyModule.CompID+")");
                cboHead.SelectedValue = Rerd[2];
                lblSCreated.Text = "Created: " + Rerd[3];
                lblSModify.Text = "Modified: " + Rerd[4];
                simpleButton3.Text = "&Add New";
                simpleButton2.Text = "&Update";
                simpleButton2.Image = global::AccountSystem.Properties.Resources.save_all;
            }
            else if (e.Node.ToolTipText == "3rd Level")
            {
                GrpHeads.Visible = false;
                GrpSubHeads.Visible = false;
                GrpEntryHeads.Visible = true;
                string[] Rerd = Fn.GetRecords("SELECT EntryAccCode, EntryAccName, AccSubID, Created, Modified,Stat,AccType FROM TblAccEntry WHERE (EntryAccID =" + e.Node.Tag + ")");
                textBox3.Text = Rerd[0];
                textBox3.Tag = e.Node.Tag;
                textBox1.Text = Rerd[1];
                Fn.fillCombo(cboSubH, "SELECT TblAccSubHead.AccSubID, RIGHT(REPLICATE('0', 2) + CAST(TblAccHead.AccHeadCode AS varchar(2)), 2) + '-' + RIGHT(REPLICATE('0', 3) + CAST(TblAccSubHead.AccSubCode AS varchar(3)), 3) + ' ' + TblAccSubHead.AccSubName AS SubHeads FROM TblAccSubHead INNER JOIN TblAccHead ON TblAccSubHead.AccHeadID = TblAccHead.AccHeadID WHERE (TblAccHead.CompanyID = "+MyModule.CompID+") GROUP BY TblAccSubHead.AccSubID, RIGHT(REPLICATE('0', 2) + CAST(TblAccHead.AccHeadCode AS varchar(2)), 2) + '-' + RIGHT(REPLICATE('0', 3) + CAST(TblAccSubHead.AccSubCode AS varchar(3)), 3) + ' ' + TblAccSubHead.AccSubName");
                cboSubH.SelectedValue = Rerd[2];
                
                cbStat.SelectedValue = Rerd[5];
                ddType.SelectedValue=Rerd[6];
                lblECreated.Text = "Created: " + Rerd[3];
                lblEModify.Text = "Modified: " + Rerd[4];
                simpleButton5.Text = "&Add New";
                simpleButton4.Text = "&Update";
                simpleButton4.Image = global::AccountSystem.Properties.Resources.save_all;
            }
            //MessageBox.Show("1="+e.Node.Text + "2="+e.Node.Name + "3="+e.Node.ToolTipText+"4="+e.Node.Tag);
        }
        private void SimpleButton8_Click(object sender, EventArgs e)
        {
            if (SimpleButton8.Text == "&Cancel")
            {
                GrpHeads.Visible = false;
            }
            else
            {
                if (!string.IsNullOrEmpty(accHeadCodeTextBox.Text) & !string.IsNullOrEmpty(accHeadNameTextBox.Text))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "UPDATE TblAccHead SET AccHeadName = @AccHeadName, AccHeadCode = @AccHeadCode, AccType = @AccType, Repli = 0,Modified = N'" + MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo + "' WHERE (AccHeadID = " + accHeadCodeTextBox.Tag + ")";
                    cmd.Parameters.AddWithValue("@AccHeadName", accHeadNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@AccHeadCode", accHeadCodeTextBox.Text);
                    cmd.Parameters.AddWithValue("@AccType", accTypeComboBox.Text);
                    
                    Fn.CmdExe(cmd);
                    Refrsh();
                    MessageBox.Show("Record Updated", "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please Enter Account Head Code & Name", "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (simpleButton2.Text == "&Cancel")
            {
                GrpSubHeads.Visible = false;
            }
            else
            {
                if (!string.IsNullOrEmpty(accSubNameTextBox.Text) & !string.IsNullOrEmpty(textBox2.Text))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "UPDATE  TblAccSubHead SET AccSubName = @AccSubName, AccSubCode = @AccSubCode, AccHeadID = " + cboHead.SelectedValue + ", Modified = N'" + MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo + "', Repli = 0 WHERE (AccSubID = " + textBox2.Tag + ")";
                    cmd.Parameters.AddWithValue("@AccSubName", accSubNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@AccSubCode", textBox2.Text);
                    Fn.CmdExe(cmd);
                    treeView1.SelectedNode.Text = accSubNameTextBox.Text;
                    //Refrsh();
                    MessageBox.Show("Record Updated", "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please Enter Sub Account Code & Name", "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (simpleButton4.Text == "&Cancel")
            {
                GrpEntryHeads.Visible = false;
            }
            else
            {
                if (!string.IsNullOrEmpty(textBox1.Text) & !string.IsNullOrEmpty(textBox3.Text))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "UPDATE TblAccEntry SET EntryAccName = @EntryAccName, EntryAccCode = @EntryAccCode, Modified = N'" + MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo + "', Repli = 0, AccSubID = " + cboSubH.SelectedValue + ",Stat=@Stat,AccType=@AccType WHERE (EntryAccID = " + textBox3.Tag + ")";
                    cmd.Parameters.AddWithValue("@EntryAccName", textBox1.Text);
                    cmd.Parameters.AddWithValue("@EntryAccCode", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Stat", cbStat.SelectedValue);
                    cmd.Parameters.AddWithValue("@AccType", ddType.SelectedValue);
                    Fn.CmdExe(cmd);
                    treeView1.SelectedNode.Text = textBox1.Text;
                    //Refrsh();
                    MessageBox.Show("Record Updated", "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please Enter Entery Account Code & Name", "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (simpleButton1.Text == "&Add New")
            {
                Fn.ClearGroup(GrpHeads);
                simpleButton1.Text = "&Save Data";
                SimpleButton8.Text = "&Cancel";
                SimpleButton8.Image = global::AccountSystem.Properties.Resources.exit;
            }
            else
            {
                if (!string.IsNullOrEmpty(accHeadCodeTextBox.Text) & !string.IsNullOrEmpty(accHeadNameTextBox.Text) & !string.IsNullOrEmpty(accTypeComboBox.Text))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "INSERT INTO TblAccHead(AccHeadName, CompanyID, Created, Modified, Repli, AccHeadCode, AccType) VALUES (@AccHeadName, " + MyModule.CompID + ", N'" + MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo + "', N'" + MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo + "', 0,@AccHeadCode,@AccType)";
                    cmd.Parameters.AddWithValue("@AccHeadName", accHeadNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@AccHeadCode", accHeadCodeTextBox.Text);
                    cmd.Parameters.AddWithValue("@AccType", accTypeComboBox.Text);
                    Fn.CmdExe(cmd);
                    Refrsh();
                    MessageBox.Show("Record Updated", "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GrpHeads.Visible = false;
                }
                else
                {
                    MessageBox.Show("Please Enter necessary information (Account Head Code, Name and type)", "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (simpleButton3.Text == "&Add New")
                {
                    Fn.ClearGroup(GrpSubHeads);
                    simpleButton3.Text = "&Save Data";
                    simpleButton2.Text = "&Cancel";
                    simpleButton2.Image = global::AccountSystem.Properties.Resources.exit;
                    cboHead.SelectedValue = SelNode;
                    Fn.GetNum(textBox2, "SELECT isnull(MAX(AccSubCode),0) AS Expr1 FROM TblAccSubHead WHERE (AccHeadID =" + cboHead.SelectedValue + ")");
                }
                else
                {
                    if (!string.IsNullOrEmpty(accSubNameTextBox.Text) & !string.IsNullOrEmpty(textBox2.Text) & !string.IsNullOrEmpty(cboHead.Text))
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = "INSERT INTO TblAccSubHead(AccSubName, AccHeadID, Created, Modified, Repli, AccSubCode) VALUES (@AccSubName, " + cboHead.SelectedValue + ", N'" + MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo + "', N'" + MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo + "', 0,@AccSubCode)";
                        cmd.Parameters.AddWithValue("@AccSubName", accSubNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@AccSubCode", textBox2.Text);
                        Fn.CmdExe(cmd);
                        Refrsh();
                        MessageBox.Show("Record Updated", "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GrpSubHeads.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Please Enter necessary information (Account Head Code, Name and type)", "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch { }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            if (simpleButton5.Text == "&Add New")
            {
                Fn.ClearGroup(GrpEntryHeads);
                simpleButton5.Text = "&Save Data";
                simpleButton4.Text = "&Cancel";
                simpleButton4.Image = global::AccountSystem.Properties.Resources.exit;
                cboSubH.SelectedValue = SelNode;
                Fn.GetNum(textBox3, "SELECT isnull(MAX(EntryAccCode),0) AS Expr1 FROM TblAccEntry WHERE (AccSubID =" + cboSubH.SelectedValue + ")");
            }
            else
            {
                if (!string.IsNullOrEmpty(textBox1.Text) & !string.IsNullOrEmpty(textBox3.Text) & !string.IsNullOrEmpty(cboSubH.Text))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "INSERT INTO TblAccEntry(EntryAccName, AccSubID, Created, Modified, Repli, EntryAccCode,Stat,AccType) VALUES (@EntryAccName, " + cboSubH.SelectedValue + ", N'" + MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo + "', N'" + MyModule.UserName + "|" + DateTime.Now + "|" + MyModule.PCInfo + "', 0,@EntryAccCode,@Stat,@AccType)";
                    cmd.Parameters.AddWithValue("@EntryAccName", textBox1.Text);
                    cmd.Parameters.AddWithValue("@EntryAccCode", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Stat", cbStat.SelectedValue);
                    cmd.Parameters.AddWithValue("@AccType", ddType.SelectedValue);
                    Fn.CmdExe(cmd);
                    Refrsh();
                    MessageBox.Show("Record Updated", "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GrpEntryHeads.Visible = false;
                }
                else
                {
                    MessageBox.Show("Please Enter necessary information (Account Head Code, Name and type)", "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnEntryAcc_Click(object sender, EventArgs e)
        {
            try
            {
                GrpHeads.Visible = false;
                GrpSubHeads.Visible = false;
                GrpEntryHeads.Visible = true;
                Fn.fillCombo(cboSubH, "SELECT TblAccSubHead.AccSubID, RIGHT(REPLICATE('0', 2) + CAST(TblAccHead.AccHeadCode AS varchar(2)), 2) + '-' + RIGHT(REPLICATE('0', 3) + CAST(TblAccSubHead.AccSubCode AS varchar(3)), 3) + ' ' + TblAccSubHead.AccSubName AS SubHeads FROM TblAccSubHead INNER JOIN TblAccHead ON TblAccSubHead.AccHeadID = TblAccHead.AccHeadID WHERE (TblAccHead.CompanyID = " + MyModule.CompID + ") GROUP BY TblAccSubHead.AccSubID, RIGHT(REPLICATE('0', 2) + CAST(TblAccHead.AccHeadCode AS varchar(2)), 2) + '-' + RIGHT(REPLICATE('0', 3) + CAST(TblAccSubHead.AccSubCode AS varchar(3)), 3) + ' ' + TblAccSubHead.AccSubName");

                Fn.ClearGroup(GrpEntryHeads);
                cboSubH.SelectedValue = SelNode;
                Fn.GetNum(textBox3, "SELECT isnull(MAX(EntryAccCode),0) AS Expr1 FROM TblAccEntry WHERE (AccSubID =" + cboSubH.SelectedValue + ")");
                simpleButton5.Text = "&Save Data";
                simpleButton4.Text = "&Cancel";
                simpleButton4.Image = global::AccountSystem.Properties.Resources.exit;
            }
            catch { }
        }

        private void btnSubAcc_Click(object sender, EventArgs e)
        {
            try
            {
                GrpHeads.Visible = false;
                GrpSubHeads.Visible = true;
                GrpEntryHeads.Visible = false;

                Fn.ClearGroup(GrpSubHeads);
                cboHead.SelectedValue = SelNode;
                Fn.GetNum(textBox2, "SELECT isnull(MAX(AccSubCode),0) AS Expr1 FROM TblAccSubHead WHERE (AccHeadID =" + cboHead.SelectedValue + ")");
                simpleButton3.Text = "&Save Data";
                simpleButton2.Text = "&Cancel";
                simpleButton2.Image = global::AccountSystem.Properties.Resources.exit;
            }
            catch { }
        }

        private void btnHeads_Click(object sender, EventArgs e)
        {
            GrpHeads.Visible = true;
            GrpSubHeads.Visible = false;
            GrpEntryHeads.Visible = false;
            Fn.ClearGroup(GrpHeads);
            simpleButton1.Text = "&Save Data";
            SimpleButton8.Text = "&Cancel";
            Fn.GetNum(accHeadCodeTextBox, "SELECT isnull(MAX(AccHeadCode),0) AS Expr1 FROM TblAccHead WHERE (CompanyID =" + MyModule.CompID + ")");
            SimpleButton8.Image = global::AccountSystem.Properties.Resources.exit;
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
    AccountChart.Default.MdiParent = FrmMain.Default;
    AccountChart.Default.Show();
        }

        private void cboHead_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (simpleButton3.Text == "&Save Data")
            {
                Fn.GetNum(textBox2, "SELECT isnull(MAX(AccSubCode),0) AS Expr1 FROM TblAccSubHead WHERE (AccHeadID =" + cboHead.SelectedValue + ")");

            }
        }

        private void cboSubH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (simpleButton5.Text == "&Save Data")
            {
                Fn.GetNum(textBox3, "SELECT isnull(MAX(EntryAccCode),0) AS Expr1 FROM TblAccEntry WHERE (AccSubID =" + cboSubH.SelectedValue + ")");
            }
        }

        private void mDelete_Click(object sender, EventArgs e)
        {
            if (Fn.GetRecords("SELECT COUNT(TblAccSubHead.AccSubID) AS Expr1 FROM TblAccHead INNER JOIN TblAccSubHead ON TblAccHead.AccHeadID = TblAccSubHead.AccHeadID WHERE (TblAccHead.AccHeadID = " + accHeadCodeTextBox.Tag + ")")[0] == "0")
            {
                Fn.Exec("DELETE FROM TblAccHead WHERE (AccHeadID = " + accHeadCodeTextBox.Tag + ")");
                treeView1.SelectedNode.Remove();
                GrpHeads.Visible = false;
                treeView1.SelectedNode = null;
                //Refrsh();
            }
            else
            {
                MessageBox.Show("Please delete sub-account first ...", "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void SDelte_Click(object sender, EventArgs e)
        {
            if (Fn.GetRecords("SELECT COUNT(TblAccEntry.EntryAccID) AS Expr1 FROM TblAccSubHead INNER JOIN TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID WHERE (TblAccSubHead.AccSubID = " + textBox2.Tag + ")")[0] == "0")
            {
                Fn.Exec("DELETE FROM TblAccSubHead WHERE (AccSubID = " + textBox2.Tag + ")");
                treeView1.SelectedNode.Remove();
                GrpSubHeads.Visible = false;
                treeView1.SelectedNode = null;
                //Refrsh();
            }
            else
            {
                MessageBox.Show("Please delete entry-account first ...", "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void EDelte_Click(object sender, EventArgs e)
        {
            if (Fn.GetRecords("SELECT COUNT(VW_VoucherDTL.AccEntryID) AS Expr1 FROM TblAccEntry INNER JOIN VW_VoucherDTL ON TblAccEntry.EntryAccID = VW_VoucherDTL.AccEntryID WHERE (TblAccEntry.EntryAccID = " + textBox3.Tag + ")")[0] == "0")
            {
                Fn.Exec("DELETE FROM TblAccEntry WHERE (EntryAccID = " + textBox3.Tag + ")");
                treeView1.SelectedNode.Remove();
                GrpEntryHeads.Visible = false;
                treeView1.SelectedNode = null;
                //Refrsh();
            }
            else
            {
                MessageBox.Show("Unable to delete account ...", "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnCopyCOH_Click(object sender, EventArgs e)
        {
            Fn.Exec("Copy_COA " + ddCompany.SelectedValue + "," + MyModule.CompID);
            Refrsh();
        }
    }
}
