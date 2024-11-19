using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Value;

namespace AccountSystem
{
    public partial class Sale_Return : Form
    {
        private MyDB fn = new MyDB();
        private DataSet ds1 = new DataSet();

        public Sale_Return()
        {
            InitializeComponent();
            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }

        #region Default Instance

        private static Sale_Return defaultInstance;

        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static Sale_Return Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new Sale_Return();
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

        private void Sale_Return_Load(object sender, EventArgs e)
        {
            //MyDB.ConStr = "Data Source=valuetech;Initial Catalog=ValuePOS;User ID=sa;Password=mzislam";
            fn.fillCombo(cboBillNo, "SELECT Sale_id, Sale_bill_no FROM tbl_Sale");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboBillNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds2 = fn.FillDSet("SELECT    tbl_Account.ContactName,tbl_Product.Prod_name, tbl_Sale.Sale_date, tbl_Sale.Sale_bill_no, AVG(tbl_SaleDetail.Prod_rate) AS Rate, SUM(tbl_SaleDetail.prod_qty) AS Quantity, SUM(tbl_SaleDetail.Prod_rate * tbl_SaleDetail.prod_qty) AS amount, SUM(tbl_Sale_Return_Detail.Prod_qty) AS 'Return Qty' FROM         tbl_Product INNER JOIN tbl_Sale INNER JOIN tbl_Account ON tbl_Sale.Contact_id = tbl_Account.Contact_id INNER JOIN tbl_SaleDetail ON tbl_Sale.Sale_id = tbl_SaleDetail.Sale_id ON tbl_Product.Prod_id = tbl_SaleDetail.prod_id LEFT OUTER JOIN tbl_Sale_Return_Detail INNER JOIN tbl_Sale_return ON tbl_Sale_Return_Detail.Sale_retn_id = tbl_Sale_return.Sale_retn_id ON tbl_Product.Prod_id = tbl_Sale_Return_Detail.Prod_id AND tbl_Sale.Sale_id = tbl_Sale_return.Sale_id WHERE     (tbl_Sale.Sale_id = " + cboBillNo.SelectedValue + ") GROUP BY tbl_Sale.Sale_id, tbl_Sale.Sale_date, tbl_Sale.Sale_bill_no, tbl_Account.ContactName, tbl_Product.Prod_name");
            DataSet ds = fn.FillDSet("SELECT    tbl_Product.Prod_name as 'Product Name',  AVG(tbl_SaleDetail.Prod_rate) AS Rate, SUM(tbl_SaleDetail.prod_qty) AS Quantity, SUM(tbl_SaleDetail.Prod_rate * tbl_SaleDetail.prod_qty) AS amount, SUM(tbl_Sale_Return_Detail.Prod_qty) AS 'Return Qty' FROM         tbl_Product INNER JOIN tbl_Sale INNER JOIN tbl_Account ON tbl_Sale.Contact_id = tbl_Account.Contact_id INNER JOIN tbl_SaleDetail ON tbl_Sale.Sale_id = tbl_SaleDetail.Sale_id ON tbl_Product.Prod_id = tbl_SaleDetail.prod_id LEFT OUTER JOIN tbl_Sale_Return_Detail INNER JOIN tbl_Sale_return ON tbl_Sale_Return_Detail.Sale_retn_id = tbl_Sale_return.Sale_retn_id ON tbl_Product.Prod_id = tbl_Sale_Return_Detail.Prod_id AND tbl_Sale.Sale_id = tbl_Sale_return.Sale_id WHERE     (tbl_Sale.Sale_id = " + cboBillNo.SelectedValue + ") GROUP BY tbl_Sale.Sale_id, tbl_Sale.Sale_date, tbl_Sale.Sale_bill_no, tbl_Account.ContactName, tbl_Product.Prod_name");
            lblSaleDate.Text = ds2.Tables[0].Rows[0][1].ToString();
            lblcustomer.Text = ds2.Tables[0].Rows[0][3].ToString();
            dataGridView1.DataSource = ds.Tables[0];
            fn.fillCombo(comboBox1, "SELECT     tbl_Product.Prod_id, tbl_Product.Prod_name FROM         tbl_Sale INNER JOIN tbl_SaleDetail ON tbl_Sale.Sale_id = tbl_SaleDetail.Sale_id INNER JOIN tbl_Product ON tbl_SaleDetail.prod_id = tbl_Product.Prod_id WHERE     (tbl_Sale.Sale_id =" + cboBillNo.SelectedValue + " ) ");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ds1 = fn.FillDSet("");
        }

        public Boolean ValidateQuantity()
        {
            bool chk = true;
            int prod_qty = 0;
            int qty = 0;
            int retn_qty = 0;
            ds1 = fn.FillDSet("SELECT tbl_Account.ContactName,tbl_Product.Prod_name, tbl_Sale.Sale_date, tbl_Sale.Sale_bill_no, AVG(tbl_SaleDetail.Prod_rate) AS Rate, SUM(tbl_SaleDetail.prod_qty) AS Quantity, SUM(tbl_SaleDetail.Prod_rate * tbl_SaleDetail.prod_qty) AS amount, SUM(tbl_Sale_Return_Detail.Prod_qty) AS 'Return Qty' FROM         tbl_Product INNER JOIN tbl_Sale INNER JOIN tbl_Account ON tbl_Sale.Contact_id = tbl_Account.Contact_id INNER JOIN tbl_SaleDetail ON tbl_Sale.Sale_id = tbl_SaleDetail.Sale_id ON tbl_Product.Prod_id = tbl_SaleDetail.prod_id LEFT OUTER JOIN tbl_Sale_Return_Detail INNER JOIN tbl_Sale_return ON tbl_Sale_Return_Detail.Sale_retn_id = tbl_Sale_return.Sale_retn_id ON tbl_Product.Prod_id = tbl_Sale_Return_Detail.Prod_id AND tbl_Sale.Sale_id = tbl_Sale_return.Sale_id WHERE     (tbl_Sale.Sale_id = " + cboBillNo.SelectedValue + " AND tbl_SaleDetail.Prod_id=" + comboBox1.SelectedValue + " ) GROUP BY tbl_Sale.Sale_id, tbl_Sale.Sale_date, tbl_Sale.Sale_bill_no, tbl_Account.ContactName, tbl_Product.Prod_name");

            if (ds1.Tables[0].Rows[0][5] != null)
                prod_qty = Convert.ToInt32(ds1.Tables[0].Rows[0][5]);

            if (!(System.Convert.IsDBNull(ds1.Tables[0].Rows[0][7])))
                retn_qty = Convert.ToInt32(ds1.Tables[0].Rows[0][7]);
            qty = Convert.ToInt32(textBox1.Text);
            if (qty > prod_qty - retn_qty)
            {
                chk = false;
            }

            return chk;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (ValidateQuantity())
                {
                    lblSaleDate.Tag = fn.ExenID("INSERT INTO tbl_Sale_return (Sale_id, Purch_retn_date,Repli) VALUES     (" + cboBillNo.SelectedValue + ", Convert(Datetime,'" + dtpReturnDate.Value.ToString("yyyy-MM-dd") + "'),0) Select @@Identity").ToString();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = ("INSERT INTO tbl_Sale_Return_Detail (Sale_retn_id, Prod_id, Prod_qty, Repli) VALUES     (@saleretn_id,@prod_id,@prod_qty, 0)");
                    cmd.Parameters.AddWithValue("@saleretn_id", lblSaleDate.Tag.ToString());
                    cmd.Parameters.AddWithValue("@prod_id", comboBox1.SelectedValue);
                    cmd.Parameters.AddWithValue("@prod_qty", textBox1.Text);
                    fn.CmdExe(cmd);
                    DataSet ds = fn.FillDSet("SELECT    tbl_Product.Prod_name as 'Product Name',  AVG(tbl_SaleDetail.Prod_rate) AS Rate, SUM(tbl_SaleDetail.prod_qty) AS Quantity, SUM(tbl_SaleDetail.Prod_rate * tbl_SaleDetail.prod_qty) AS amount, SUM(tbl_Sale_Return_Detail.Prod_qty) AS 'Return Qty' FROM         tbl_Product INNER JOIN tbl_Sale INNER JOIN tbl_Account ON tbl_Sale.Contact_id = tbl_Account.Contact_id INNER JOIN tbl_SaleDetail ON tbl_Sale.Sale_id = tbl_SaleDetail.Sale_id ON tbl_Product.Prod_id = tbl_SaleDetail.prod_id LEFT OUTER JOIN tbl_Sale_Return_Detail INNER JOIN tbl_Sale_return ON tbl_Sale_Return_Detail.Sale_retn_id = tbl_Sale_return.Sale_retn_id ON tbl_Product.Prod_id = tbl_Sale_Return_Detail.Prod_id AND tbl_Sale.Sale_id = tbl_Sale_return.Sale_id WHERE     (tbl_Sale.Sale_id = " + cboBillNo.SelectedValue + ") GROUP BY tbl_Sale.Sale_id, tbl_Sale.Sale_date, tbl_Sale.Sale_bill_no, tbl_Account.ContactName, tbl_Product.Prod_name");
                    lblSaleDate.Text = ds.Tables[0].Rows[0][1].ToString();
                    lblcustomer.Text = ds.Tables[0].Rows[0][3].ToString();
                    dataGridView1.DataSource = ds.Tables[0];
                }
                else
                    MessageBox.Show("Quantity must me less than the remaining products");
            }
            else
                MessageBox.Show("Must Enter the Quantity");
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}