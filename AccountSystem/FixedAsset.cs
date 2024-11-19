using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AccountSystem
{
    public partial class FixedAsset : Form
    {
        private MyModule fn = new MyModule();

        public FixedAsset()
        {
            InitializeComponent();
            if (defaultInstance == null)
                defaultInstance = this;
        }

        #region Default Instance

        private static FixedAsset defaultInstance;

        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static FixedAsset Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new FixedAsset();
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

        private void FixedAsset_Load(object sender, EventArgs e)
        {
            rbtn_bank.Checked = true;
            pnl_cash.Visible = false;
            fn.fillCombo(cbx_asset_code, "SELECT TblAccEntry.EntryAccCode,RIGHT(REPLICATE('0', 2) + CAST(TblAccHead.AccHeadCode AS varchar(2)), 2) + '-' + RIGHT(REPLICATE('0', 3) + CAST(TblAccSubHead.AccSubCode AS varchar(3)), 3)+'-'+ RIGHT(REPLICATE('0',4) + CAST(TblAccEntry.EntryAccCode AS varchar(4)),4) +'  '+ TblAccEntry.EntryAccName AS 'Account Name' FROM TblAccEntry INNER JOIN TblAccSubHead ON TblAccEntry.AccSubID = TblAccSubHead.AccSubID INNER JOIN TblAccHead ON TblAccSubHead.AccHeadID = TblAccHead.AccHeadID WHERE TblAccHead.AccType = 'Assets'");
            fn.fillCombo(cbx_account_head, "SELECT TblAccSubHead.AccSubID,RIGHT(REPLICATE('0', 2) + CAST(TblAccHead.AccHeadCode AS varchar(2)), 2) + '-' + RIGHT(REPLICATE('0', 3) + CAST(TblAccSubHead.AccSubCode AS varchar(3)), 3)+' '+TblAccSubHead.AccSubName AS 'Account Name' FROM TblAccHead INNER JOIN TblAccSubHead ON TblAccHead.AccHeadID = TblAccSubHead.AccHeadID WHERE (TblAccHead.AccType = 'Assets') ");
            DataSet MyDataSet = new DataSet();
            MyDataSet.Clear();
            string MySQLStr = "SELECT isnull(MAX(TblAccEntry.EntryAccCode),0) AS Expr1 FROM TblAccSubHead INNER JOIN TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID WHERE (TblAccSubHead.AccHeadID = " + cbx_account_head.SelectedValue + ")";
            System.Data.SqlClient.SqlDataAdapter MyDataAdapter = new System.Data.SqlClient.SqlDataAdapter(MySQLStr,(string)global::AccountSystem.Properties.Settings.Default.DBConnectionString);
            MyDataAdapter.Fill(MyDataSet);
            int hcode = (Int32)(MyDataSet.Tables[0].Rows[0][0]) + 1;
            txt_asset_code.Text = Convert.ToString(hcode);
            MyDataSet.Dispose();
            label7.Visible = false;
            txt_asset_value.Visible = false;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbtn_new_asset_CheckedChanged(object sender, EventArgs e)
        {
            pnl_fixed_aset.Visible = true;
            groupBox1.Visible = true;
            panel1.Visible = false;
            label7.Visible = false;
            txt_asset_value.Visible = false;
        }

        private void rbtn_Attached_Asset_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
            groupBox1.Visible = false;
            pnl_fixed_aset.Visible = false;
            label7.Visible = true;
            txt_asset_value.Visible = true;
        }

        private void btn_submit_fixedAsset_Click(object sender, EventArgs e)
        {
            if (validateinput() == true)
            {
                SqlCommand cmd = new SqlCommand();
                if (rbtn_Attached_Asset.Checked == true)
                {
                    cmd.CommandText = ("INSERT INTO tbl_fixedAsset(AssetID, itemName, CostofAsset, ServingDate, AssetLife, Model, Location, SerialNo, Vendor, AssetValue, ServiceInfo, Description, Warranty) VALUES(@AssetCode,@id,@itemName,@CostofAsset,@ServingDate,@AssetLife,@Model,@Location,@SerialNo,@Vendor,@AssetValue,@ServiceInfo,@Description,@Warranty)");
                    cmd.Parameters.AddWithValue("@AssetCode", cbx_asset_code.SelectedValue);
                    cmd.Parameters.AddWithValue("@itemName", txt_item_name.Text);
                    cmd.Parameters.AddWithValue("@CostofAsset", txt_cost_of_asset.Text);
                    cmd.Parameters.AddWithValue("@ServingDate", Convert.ToDateTime(dtp_serving_date.Text));
                    cmd.Parameters.AddWithValue("@Model", txt_model_No.Text);
                    cmd.Parameters.AddWithValue("@Location", txt_location.Text);
                    cmd.Parameters.AddWithValue("@SerialNo", txt_serial_no.Text);
                    cmd.Parameters.AddWithValue("@Vendor", txt_vendor.Text);
                    cmd.Parameters.AddWithValue("@AssetValue", txt_asset_value.Text);
                    cmd.Parameters.AddWithValue("@ServiceInfo", txt_serving_info.Text);
                    cmd.Parameters.AddWithValue("@Description", txt_description.Text);
                    cmd.Parameters.AddWithValue("@Warranty", txt_warranty.Text);
                    cmd.Parameters.AddWithValue("@AssetLife", txt_asset_life.Text + "-" + cbx_asset_life.Text);
                    MessageBox.Show(fn.CmdExe(cmd));
                }
                else
                {
                    Int32 AssetID;
                    AssetID = fn.ExenID("INSERT INTO TblAccEntry( EntryAccName, AccSubID,Created, Modified, Repli, EntryAccCode) VALUES ('" + txt_item_name.Text + "'," + cbx_account_head.SelectedValue + ",'" + global::System.Data.SqlDbType.NVarChar + "','" + global::System.Data.SqlDbType.NVarChar + "',1," + txt_asset_code.Text + ") SELECT @@IDENTITY");

                    cmd.CommandText = ("INSERT INTO tbl_fixedAsset(AssetID, itemName, CostofAsset, ServingDate, AssetLife, Model, Location, SerialNo, Vendor, AssetValue, ServiceInfo, Description, Warranty) VALUES(@AssetCode,@id,@itemName,@CostofAsset,@ServingDate,@AssetLife,@Model,@Location,@SerialNo,@Vendor,@AssetValue,@ServiceInfo,@Description,@Warranty)");
                    cmd.Parameters.AddWithValue("@AssetCode", AssetID);
                    cmd.Parameters.AddWithValue("@itemName", txt_item_name.Text);
                    cmd.Parameters.AddWithValue("@CostofAsset", txt_cost_of_asset.Text);
                    cmd.Parameters.AddWithValue("@ServingDate", Convert.ToDateTime(dtp_serving_date.Text));
                    cmd.Parameters.AddWithValue("@Model", txt_model_No.Text);
                    cmd.Parameters.AddWithValue("@Location", txt_location.Text);
                    cmd.Parameters.AddWithValue("@SerialNo", txt_serial_no.Text);
                    cmd.Parameters.AddWithValue("@Vendor", txt_vendor.Text);

                    cmd.Parameters.AddWithValue("@AssetValue", txt_cost_of_asset.Text);
                    cmd.Parameters.AddWithValue("@ServiceInfo", txt_serving_info.Text);
                    cmd.Parameters.AddWithValue("@Description", txt_description.Text);
                    cmd.Parameters.AddWithValue("@Warranty", txt_warranty.Text);
                    cmd.Parameters.AddWithValue("@AssetLife", txt_asset_life.Text + "-" + cbx_asset_life.Text);
                    fn.CmdExe(cmd);
                    if (rbtn_bank.Checked == true)
                    {
                        Amount();

                        fn.GetNum(txtVoucherNo, "SELECT COUNT(*) AS V FROM TblVoucherHDR WHERE (CONVERT(varchar, MONTH(EntryDate)) + CONVERT(varchar, YEAR(EntryDate)) = '" + MyModule.AMonth + "') AND (VoucherNo LIKE N'BV/%') AND (CompanyID =" + MyModule.CompID + ")");
                        txtVoucherNo.Text = "BV/" + MyModule.AMonth + "-" + txtVoucherNo.Text;
                        txtVid.Text = fn.ExenID("insert into TblVoucherHDR (VoucherNo,EntryDate,CheqNo,Created,Modified,Repli,DrawingDate,CompanyID) values('" + txtVoucherNo.Text + "','" + dtp_serving_date.Text + "','" + txt_cheque.Text + "','" + MyModule.UserName + "@" + DateTime.Now + "','" + MyModule.UserName + "@" + DateTime.Now + "',0,'" + dtp_serving_date.Text + "'," + MyModule.CompID + ") SELECT @@IDENTITY").ToString();
                        fn.Exec("insert into TblVoucherDTL (VoucherID,AccEntryID,Description,AmountDeb,AmountCre,Repli) values('" + txtVid.Text + "','" + cbox_bank.SelectedValue + "','" + txt_description.Text + "'," + bdeb + "," + bcre + ",0)");
                        fn.Exec("insert into TblVoucherDTL (VoucherID,AccEntryID,Description,AmountDeb,AmountCre,Repli) values('" + txtVid.Text + "','" + AssetID + "','" + txt_description.Text + "'," + 0 + "," + txt_cost_of_asset.Text + ",0)");
                    }
                    else
                    {
                        Amount();
                        fn.GetNum(txtVoucherNo, "SELECT COUNT(*) AS V FROM TblVoucherHDR WHERE (CONVERT(varchar, MONTH(EntryDate)) + CONVERT(varchar, YEAR(EntryDate)) = '" + MyModule.AMonth + "') AND (VoucherNo LIKE N'JV/%') AND (CompanyID =" + MyModule.CompID + ")");
                        txtVoucherNo.Text = "GPV/" + MyModule.AMonth + "-" + txtVoucherNo.Text;
                        txtVid.Text = fn.ExenID("insert into TblVoucherHDR (VoucherNo,EntryDate,CheqNo,Created,Modified,Repli,DrawingDate,CompanyID) values('" + txtVoucherNo.Text + "','" + dtp_serving_date.Text + "','','" + MyModule.UserName + "@" + DateTime.Now + "','" + MyModule.UserName + "@" + DateTime.Now + "',0,'" + dtp_serving_date.Text + "'," + MyModule.CompID + ") SELECT @@IDENTITY").ToString();
                        fn.Exec("insert into TblVoucherDTL (VoucherID,AccEntryID,Description,AmountDeb,AmountCre,Repli) values('" + txtVid.Text + "','" + cbox_cash.SelectedValue + "','" + txt_description.Text + "'," + bdeb + "," + bcre + ",0)");
                        fn.Exec("insert into TblVoucherDTL (VoucherID,AccEntryID,Description,AmountDeb,AmountCre,Repli) values('" + txtVid.Text + "','" + AssetID + "','" + txt_description.Text + "'," + 0 + "," + txt_cost_of_asset.Text + ",0)");
                    }
                    this.Close();
                }
            }
        }

        private void cbx_account_head_SelectedIndexChanged(object sender, EventArgs e)
        {
            fn.fillCombo(cbox_bank, "SELECT TblAccEntry.EntryAccID,right(REPLICATE('0',2) + cast(TblAccHead.AccHeadCode as varchar(2)),2)+ '-' + right(REPLICATE('0',3) + cast(TblAccSubHead.AccSubCode as varchar(3)),3)+ '-' + right(REPLICATE('0',4) + cast(TblAccEntry.EntryAccCode as varchar(4)),4)+' '+TblAccEntry.EntryAccName FROM TblAccHead INNER JOIN TblAccSubHead ON TblAccHead.AccHeadID = TblAccSubHead.AccHeadID INNER JOIN TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID WHERE (TblAccHead.CompanyID =" + MyModule.CompID + ") AND (TblAccEntry.EntryAccName LIKE N'%Bank%')");
            fn.fillCombo(cbox_cash, "SELECT TblAccEntry.EntryAccID,right(REPLICATE('0',2) + cast(TblAccHead.AccHeadCode as varchar(2)),2)+ '-' + right(REPLICATE('0',3) + cast(TblAccSubHead.AccSubCode as varchar(3)),3)+ '-' + right(REPLICATE('0',4) + cast(TblAccEntry.EntryAccCode as varchar(4)),4)+' '+TblAccEntry.EntryAccName FROM TblAccHead INNER JOIN TblAccSubHead ON TblAccHead.AccHeadID = TblAccSubHead.AccHeadID INNER JOIN TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID WHERE (TblAccHead.CompanyID =" + MyModule.CompID + ") AND (TblAccEntry.EntryAccName LIKE N'%Cash%')");
            DataSet MyDataSet = new DataSet();
            MyDataSet.Clear();
            string MySQLStr = "SELECT COUNT(*) AS Id FROM TblAccSubHead WHERE (AccHeadID =" + cbx_account_head.SelectedValue + ")";
            System.Data.SqlClient.SqlDataAdapter MyDataAdapter = new System.Data.SqlClient.SqlDataAdapter(MySQLStr,(string)global::AccountSystem.Properties.Settings.Default.DBConnectionString);
            MyDataAdapter.Fill(MyDataSet);
            int hcode = (Int32)(MyDataSet.Tables[0].Rows[0][0]) + 1;
            txt_asset_code.Text = Convert.ToString(hcode);
            MyDataSet.Dispose();
        }

        private Boolean validateinput()
        {
            if (string.IsNullOrEmpty(txt_item_name.Text))
            {
                MessageBox.Show("Please Enter  Name.");
                return false;
            }
            if (string.IsNullOrEmpty(txt_cost_of_asset.Text))
            {
                MessageBox.Show("Please Enter  Cost of Asset");
                return false;
            }
            if (string.IsNullOrEmpty(txt_asset_life.Text))
            {
                MessageBox.Show("Please Enter  Asset Life.");
                return false;
            }

            if (string.IsNullOrEmpty(txt_serial_no.Text))
            {
                MessageBox.Show("Please Enter  Serial No.");
                return false;
            }
            if (string.IsNullOrEmpty(txt_vendor.Text))
            {
                MessageBox.Show("Please Enter  Vendor");
                return false;
            }
            if (string.IsNullOrEmpty(txt_asset_value.Text))
            {
                MessageBox.Show("Please Enter  Asset Value.");
                return false;
            }
            if (string.IsNullOrEmpty(txt_serving_info.Text))
            {
                MessageBox.Show("Please Enter Serving information");
            }
            if (string.IsNullOrEmpty(txt_description.Text))
            {
                MessageBox.Show("Please Enter Description ");
            }
            if (string.IsNullOrEmpty(txt_location.Text))
            {
                MessageBox.Show("Please Enter  Location.");
                return false;
            }
            if (string.IsNullOrEmpty(txt_model_No.Text))
            {
                MessageBox.Show("Please Enter Model No");
            }
            if (string.IsNullOrEmpty(txt_warranty.Text))
            {
                MessageBox.Show("Please Enter Warranty ");
            }

            return true;
        }

        private void txt_cost_of_asset_TextChanged(object sender, EventArgs e)
        {
            Boolean ret = fn.ValidateNum(txt_cost_of_asset);
        }

        private void txt_serial_no_TextChanged(object sender, EventArgs e)
        {
            Boolean ret = fn.ValidateNum(txt_serial_no);
        }

        private void rbtn_cash_Click(object sender, EventArgs e)
        {
        }

        private void rbtn_bank_CheckedChanged(object sender, EventArgs e)
        {
            pnl_bank.Visible = true;
            pnl_cash.Visible = false;

            //fn.fillCombo(cbox_bank, "SELECT TblAccEntry.EntryAccID,right(REPLICATE('0',2) + cast(TblAccHead.AccHeadCode as varchar(2)),2)+ '-' + right(REPLICATE('0',3) + cast(TblAccSubHead.AccSubCode as varchar(3)),3)+ '-' + right(REPLICATE('0',4) + cast(TblAccEntry.EntryAccCode as varchar(4)),4)+' '+TblAccEntry.EntryAccName FROM TblAccHead INNER JOIN TblAccSubHead ON TblAccHead.AccHeadID = TblAccSubHead.AccHeadID INNER JOIN TblAccEntry ON TblAccSubHead.AccSubID = TblAccEntry.AccSubID WHERE (TblAccHead.CompanyID =" + MyModule.CompID + ") AND (TblAccEntry.EntryAccName LIKE N'%Bank%')");
        }

        private void rbtn_cash_CheckedChanged(object sender, EventArgs e)
        {
            pnl_cash.Visible = true;
            pnl_bank.Visible = false;
        }

        //////////////////
        //////////////////
        //////////////////
        //////////////////
        private void txt_cheque_TextChanged(object sender, EventArgs e)
        {
            ValidateNum(txt_cheque);
        }

        private double bdeb;
        private double bcre;

        private void Amount()
        {
            bdeb = Convert.ToDouble(txt_cost_of_asset.Text);
            bcre = 0;
        }

        private void ValidateNum(TextBox txtBox)
        {
            try
            {
                if (txtBox.Text != "")
                {
                    Int32 a;
                    a = Convert.ToInt32(txtBox.Text) / 2;
                }
            }
            catch
            {
                MessageBox.Show("Invalid Input Please Re-Enter");
            }
        }

        private void txtCashAmount_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void txt_asset_life_TextChanged(object sender, EventArgs e)
        {
        }

        private void cbx_asset_life_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        //private bool ValidateControls()
        //{
        //    //bool functionReturnValue = false;

        //    bool validate = true;

        //    if (string.IsNullOrEmpty( cbox_bank.Text))
        //    {
        //        MessageBox.Show("Please select a Bank . . . ", "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        return validate == false;
        //        //return functionReturnValue;
        //    }

        //    else if (string.IsNullOrEmpty(txtBankAmount.Text))
        //    {
        //        MessageBox.Show("Please Enter Amount ", "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        return validate == false;
        //    }

        //    else if (MyModule.AMonth != dtp_serving_date.Value.ToString("Myyyy"))
        //    {
        //        MessageBox.Show("Can not save due to invalid date", "GM Soft", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        return validate == false;
        //    }
        //    return (validate);
        //    //return functionReturnValue;
        //}
    }
}