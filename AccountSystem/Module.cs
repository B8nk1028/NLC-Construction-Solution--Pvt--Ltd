using Microsoft.Reporting.WinForms;
using SergeUtils;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace AccountSystem
{
    public class MyModule
    {
        public SqlConnection CN = new SqlConnection();
        public static SByte UserType;
        public static string UserName;
        public static int CompID;
        public static int BranchID;
        public static string CompName;
        public static string ActiveYear;
        public static string AMonth;
        public static string ParmA;
        public static string ParmB;
        public static string ParmD;
        public static Int32 ParmC;
        public static string Parm1;
        public static string Parm2;
        public static string Parm3;
public static string TermsCond;
        public static Microsoft.Reporting.WinForms.ReportViewer rpt;
        public static string PCInfo;
        private string str;
        public void CnStr()
        {
            if (CN.State == ConnectionState.Open)
                CN.Close();
            CN.ConnectionString = global::AccountSystem.Properties.Settings.Default.DBConnectionString;
        }
        public string Exec(string str)
        {
            string Out;
            using (SqlConnection conn = new SqlConnection(global::AccountSystem.Properties.Settings.Default.DBConnectionString))
            {
                conn.Open();
                using (SqlCommand comm = new SqlCommand(str, conn))
                {
                    try
                    {
                        Out = comm.ExecuteNonQuery().ToString();
                    }
                    catch (System.Exception ex)
                    {
                        Out = ex.Message;
                    }
                }
                conn.Dispose();
                conn.Close();
                SqlConnection.ClearPool(conn);
            }
            return Out;
        }
        public  bool Between(string num, string lower, string upper, bool inclusive = false)
        {

            if (Convert.ToInt32(lower) <= Convert.ToInt32(num) && Convert.ToInt32(num) <= Convert.ToInt32(upper))
            {
                inclusive = true;

            }
            return inclusive;
                //? Convert.ToInt32(lower) <= Convert.ToInt32(num) && Convert.ToInt32(num) <= Convert.ToInt32(upper)
                //: Convert.ToInt32(lower) < Convert.ToInt32(num) && Convert.ToInt32(num) < Convert.ToInt32(upper);
        }
        //public void Exec(string str)
        //{
        //    try
        //    {
        //        CnStr();
        //        CN.Open();
        //        SqlCommand cmd = new SqlCommand(str, CN);
        //        cmd.ExecuteNonQuery();
        //        CN.Close();
        //    }
        //    catch (System.Exception ex)
        //    {
        //        //MsgBox(ex.Message)
        //        //' Finally
        //        //'CN.Close()
        //    }
        //}
        public string ValidateNumber(TextBox txtBox)
        {
            string txt = "0";
            try
            {
                if (txtBox.Text != "")
                {
                    Double a;
                    a = Convert.ToDouble(txtBox.Text) / 2;
                    txt = txtBox.Text;
                }
            }
            catch
            {
                txtBox.Focus();
                txtBox.Undo();
                txtBox.ClearUndo();
                return txt;
            }
            return txt;
        }
        public Int32 ExenID(string str)
        {
            Int32 ID;
            CnStr();
            CN.Open();
            SqlCommand cmd = new SqlCommand(str, CN);
            ID = Convert.ToInt32(cmd.ExecuteScalar());
            CN.Close();
            return ID;
        }
        public void fillCombo(ComboBox cmbName, string cmd)
        {
            try
            {
                DataSet MyDataSet = new DataSet();
                MyDataSet.Clear();
                System.Data.SqlClient.SqlDataAdapter MyDataAdapter = new System.Data.SqlClient.SqlDataAdapter(cmd, (string)global::AccountSystem.Properties.Settings.Default.DBConnectionString);
                MyDataAdapter.Fill(MyDataSet);
                cmbName.DisplayMember = MyDataSet.Tables[0].Columns[1].ColumnName;
                cmbName.ValueMember = MyDataSet.Tables[0].Columns[0].ColumnName;

                cmbName.DataSource = MyDataSet.Tables[0];
                MyDataSet.Dispose();
            }
            catch (System.Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        public void fillGrdCombo(DataGridViewComboBoxColumn cmbName, string cmd)
        {
            try
            {
                DataSet dataSet = new DataSet();
                dataSet.Clear();
                (new SqlDataAdapter(cmd, (string)global::AccountSystem.Properties.Settings.Default.DBConnectionString)).Fill(dataSet);
                cmbName.DisplayMember = dataSet.Tables[0].Columns[1].ColumnName;
                cmbName.ValueMember = dataSet.Tables[0].Columns[0].ColumnName;
                cmbName.DataSource = dataSet.Tables[0];
                dataSet.Dispose();
            }
            catch
            {
            }
        }
        public void fillGrdComb(EasyCompletionComboBox cmbName, string cmd)
        {
            try
            {
                DataSet dataSet = new DataSet();
                dataSet.Clear();
                (new SqlDataAdapter(cmd, (string)global::AccountSystem.Properties.Settings.Default.DBConnectionString)).Fill(dataSet);
                cmbName.DisplayMember = dataSet.Tables[0].Columns[1].ColumnName;
                cmbName.ValueMember = dataSet.Tables[0].Columns[0].ColumnName;
                cmbName.DataSource = dataSet.Tables[0];
                dataSet.Dispose();
            }
            catch
            {
            }
        }
        public void fillList(ListBox listName, string cmd)
        {
            try
            {
                DataSet MyDataSet = new DataSet();
                MyDataSet.Clear();
                System.Data.SqlClient.SqlDataAdapter MyDataAdapter = new System.Data.SqlClient.SqlDataAdapter(cmd, (string)global::AccountSystem.Properties.Settings.Default.DBConnectionString);
                MyDataAdapter.Fill(MyDataSet);
                listName.ValueMember = MyDataSet.Tables[0].Columns[0].ColumnName;
                listName.DisplayMember = MyDataSet.Tables[0].Columns[1].ColumnName;
                listName.DataSource = MyDataSet.Tables[0];
                MyDataSet.Dispose();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        public void GetNum(TextBox NumBox, string cmd)
        {
            try
            {
                DataSet MyDataSet = new DataSet();
                MyDataSet.Clear();
                System.Data.SqlClient.SqlDataAdapter MyDataAdapter = new System.Data.SqlClient.SqlDataAdapter(cmd, (string)global::AccountSystem.Properties.Settings.Default.DBConnectionString);
                MyDataAdapter.Fill(MyDataSet);
                if (MyDataSet.Tables[0].Rows[0][0].GetType().Name == "String")
                {
                    String hcode = (String)(MyDataSet.Tables[0].Rows[0][0]);
                    NumBox.Text = Convert.ToString(hcode);
                    NumBox.Tag = (String)(MyDataSet.Tables[0].Rows[0][1]);
                    MyDataSet.Dispose();
                }
                else
                {
                    Int32 hcode = (Int32)(MyDataSet.Tables[0].Rows[0][0]) + 1;
                    NumBox.Text = Convert.ToString(hcode);
                    MyDataSet.Dispose();
                }
            }
            catch (System.Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        public void fillGridCbo(DataGridViewComboBoxColumn cmbName, string cmd)
        {
            try
            {
                DataSet MyDataSet = new DataSet();
                MyDataSet.Clear();
                System.Data.SqlClient.SqlDataAdapter MyDataAdapter = new System.Data.SqlClient.SqlDataAdapter(cmd, (string)global::AccountSystem.Properties.Settings.Default.DBConnectionString);
                MyDataAdapter.Fill(MyDataSet);
                cmbName.ValueMember = MyDataSet.Tables[0].Columns[0].ColumnName;
                cmbName.DisplayMember = MyDataSet.Tables[0].Columns[1].ColumnName;
                cmbName.DataSource = MyDataSet.Tables[0];
                MyDataSet.Dispose();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        public string CmdExe(SqlCommand Cmd)
        {
            string msg = "OK";
            try
            {
                CnStr();
                CN.Open();
                Cmd.Connection = CN;
                Cmd.CommandType = CommandType.Text;
                Cmd.ExecuteNonQuery();
                CN.Close();
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                CN.Close();
            }
            return msg;
        }
        public bool RecordChk(string cmd)
        {
            bool chk = true;
            try
            {
                DataSet MyDataSet = new DataSet();
                MyDataSet.Clear();
                System.Data.SqlClient.SqlDataAdapter MyDataAdapter = new System.Data.SqlClient.SqlDataAdapter(cmd, (string)global::AccountSystem.Properties.Settings.Default.DBConnectionString);
                MyDataAdapter.Fill(MyDataSet);
                if (MyDataSet.Tables[0].Rows.Count >= 1)
                {
                    chk = false;
                }
                MyDataSet.Dispose();
            }
            catch (System.Exception ex)
            {
                chk = false;
            }
            return chk;
        }
        public string[] GetRecords(string cmd)
        {
            string[] R_Data = { "a", "b", "c", "d", "e", "f", "g", "h" };
            try
            {
                DataSet MyDataSet = new DataSet();
                MyDataSet.Clear();
                System.Data.SqlClient.SqlDataAdapter MyDataAdapter = new System.Data.SqlClient.SqlDataAdapter(cmd, (string)global::AccountSystem.Properties.Settings.Default.DBConnectionString);
                MyDataAdapter.Fill(MyDataSet);
                int i = MyDataSet.Tables[0].Rows.Count - 1;
                int j = MyDataSet.Tables[0].Columns.Count - 1;
                int ss = 0;
                for (i = 0; i <= i; i++)
                {
                    for (j = 0; j <= j; j++)
                    {
                        ss = ss + 1;
                        R_Data[ss - 1] = MyDataSet.Tables[0].Rows[i][j].ToString();
                    }
                }
            }
            catch (System.Exception ex)
            {
            }
            return R_Data;
        }
        public void ClearGroup(GroupBox TabCrt)
        {
            foreach (Control ctrl in TabCrt.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
                else if (ctrl is ComboBox)
                {
                    ctrl.Text = null;
                }
            }
        }
        public DateTime FirstDayOfMonthFromDateTime(DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, 1);
        }
        public DateTime LastDayOfMonthFromDateTime(DateTime dateTime)
        {
            DateTime firstDayOfTheMonth = new DateTime(dateTime.Year, dateTime.Month, 1);
            return firstDayOfTheMonth.AddMonths(1).AddDays(-1);
        }
        public void CenterScreen(Form Pnl)
        {
            //' Get the Width and Height of the form
            int frm_width = Pnl.Width;
            int frm_height = Pnl.Height;
            //'Get the Width and Height (resolution) of the screen
            System.Windows.Forms.Screen src = System.Windows.Forms.Screen.PrimaryScreen;
            int src_height = src.Bounds.Height;
            int src_width = src.Bounds.Width;
            //'Set the left and top property to move the form to center of the screen
            Pnl.Left = (src_width - frm_width) / 2;
            //Pnl.Top = (src_height - frm_height) / 2;
            Pnl.Top = 7;
        }
        public Boolean ValidateNum(TextBox txtBox)
        {
            try
            {
                if (txtBox.Text != "")
                {
                    Double a;
                    a = Convert.ToDouble(txtBox.Text) / 2;
                }
            }
            catch
            {
                MessageBox.Show("Invalid Input Please Re-Enter");
                return false;
            }
            return true;
        }
        public Int32 Info_U(string str)
        {
            Int32 ID = 0;
            try
            {
                SqlConnection Con = new SqlConnection();
                Con.ConnectionString = "Data Source=thepeace.edu.pk;Initial Catalog=Home_Exp;User ID=sql2008;Password=mzislam@123";
                Con.Open();
                SqlCommand cmd = new SqlCommand(str, Con);
                ID = Convert.ToInt32(cmd.ExecuteNonQuery());
                Con.Close();
            }
            catch
            {
            }
            return ID;
        }
        public string[] RPage(string cmd)
        {
            string[] R_Data = { "0", "0", "c", "d", "e", "f", "g", "h" };
            try
            {
                DataSet MyDataSet = new DataSet();
                MyDataSet.Clear();
                System.Data.SqlClient.SqlDataAdapter MyDataAdapter = new System.Data.SqlClient.SqlDataAdapter(cmd, "Data Source=204.93.178.45;Initial Catalog=gmsoftpk_Home_Exp;User ID=gmsoftpk_Zia;Password=mzislam123");
                MyDataAdapter.Fill(MyDataSet);
                int i = MyDataSet.Tables[0].Rows.Count - 1;
                int j = MyDataSet.Tables[0].Columns.Count - 1;
                int ss = 0;
                for (i = 0; i <= i; i++)
                {
                    for (j = 0; j <= j; j++)
                    {
                        ss = ss + 1;
                        R_Data[ss - 1] = MyDataSet.Tables[0].Rows[i][j].ToString();
                    }
                }
            }
            catch
            {
            }
            return R_Data;
        }
        public string[] GetRecord2(string cmd)
        {
            string[] R_Data = { "?", "?", "c", "d", "e", "f", "g", "h" };
            try
            {
                DataSet MyDataSet = new DataSet();
                MyDataSet.Clear();
                System.Data.SqlClient.SqlDataAdapter MyDataAdapter = new System.Data.SqlClient.SqlDataAdapter(cmd, "Data Source=thepeace.edu.pk;Initial Catalog=Home_Exp;User ID=sql2008;Password=mzislam@123");
                MyDataAdapter.Fill(MyDataSet);
                int i = MyDataSet.Tables[0].Rows.Count - 1;
                int j = MyDataSet.Tables[0].Columns.Count - 1;
                int ss = 0;
                for (i = 0; i <= i; i++)
                {
                    for (j = 0; j <= j; j++)
                    {
                        ss = ss + 1;
                        R_Data[ss - 1] = MyDataSet.Tables[0].Rows[i][j].ToString();
                    }
                }
            }
            catch
            {
            }
            return R_Data;
        }
        public DataSet FillDSet(string cmd)
        {
            DataSet MyDataSet = new DataSet();
            try
            {
                System.Data.SqlClient.SqlDataAdapter MyDataAdapter = new System.Data.SqlClient.SqlDataAdapter(cmd, global::AccountSystem.Properties.Settings.Default.DBConnectionString);
                MyDataAdapter.Fill(MyDataSet);
            }
            catch
            {
            }
            return MyDataSet;
        }
        public byte[] RunReport(string[] DSet, string[] SQL, string RptName, string ExportType, bool bDownloadAttachment = false)
        {
            LocalReport viewer = new LocalReport();
            viewer.ReportEmbeddedResource = RptName;
            //string ext = "xlsx";
            //EXCELOPENXML
            //if (ExportType == "pdf") { ext = "pdf"; } else if(ExportType == "WORDOPENXML") { ext = "docx"; }
            for (int i = 0; i < DSet.Length; i++)
            {
                ReportDataSource datasource = new ReportDataSource(DSet[i], FillDSet(SQL[i]).Tables[0]);
                viewer.DataSources.Add(datasource);
            }
            viewer.Refresh();
            AutoPrintCls autoprintme = new AutoPrintCls(viewer);
            autoprintme.Print();
            //byte[] Contents = viewer.Render(ExportType);
            return null;
            //oContext.Response.Clear();
            //oContext.Response.ContentType = "application/" + ExportType;
            //if (bDownloadAttachment == true)
            //{
            //    oContext.Response.AddHeader("Content-disposition", "attachment; filename=Report." + ext);
            //}
            //oContext.Response.BinaryWrite(pdfContent);
            //oContext.Response.End();
        }
        public void DecimalValue(object sender, KeyPressEventArgs e,string txt)
        {
            const int BACKSPACE = 8;
            const int DECIMAL_POINT = 46;
            const int ZERO = 48;
            const int NINE = 57;
            const int NOT_FOUND = -1;

            int keyvalue = (int)e.KeyChar; // not really necessary to cast to int

            if ((keyvalue == BACKSPACE) ||
            ((keyvalue >= ZERO) && (keyvalue <= NINE))) return;
            // Allow the first (but only the first) decimal point
            if ((keyvalue == DECIMAL_POINT) &&
            (txt.IndexOf(".") == NOT_FOUND)) return;
            // Allow nothing else
            e.Handled = true;
        }
    }
}