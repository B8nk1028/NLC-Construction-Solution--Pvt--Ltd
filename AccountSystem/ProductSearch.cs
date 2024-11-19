using System;
using System.Windows.Forms;
using Value;

namespace AccountSystem
{
    public partial class frmfind : Form
    {
        private MyDB fn = new MyDB();

        public frmfind()
        {
            InitializeComponent();
            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }

        #region Default Instance

        private static frmfind defaultInstance;

        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static frmfind Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new frmfind();
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

        private void btnclose_Click(object sender, EventArgs e)
        {
            if (grdproductsearch.CurrentRow != null)
            {
                frmProducts.Default.ProductInfo = fn.GetRecords("SELECT Prod_id, Prod_name, Prod_Price, Prod_Catg_id, Unit_id, Brand_id, Barcode,DngrLevel,P_Price FROM tbl_Product WHERE (Prod_id = " + grdproductsearch.CurrentRow.Cells[0].Value + ")");
                frmProducts.Default.FillRecord();
                this.Close();
                frmProducts.Default.MdiParent = FrmMain.Default;
                frmProducts.Default.Show();
                frmProducts.Default.btnsave.Text = "&Update";
            }
            else
            {
                frmProducts.Default.MdiParent = FrmMain.Default;
                frmProducts.Default.Show();
                this.Close();
            }
        }

        private void grdproductsearch_DoubleClick(object sender, EventArgs e)
        {
            frmProducts.Default.ProductInfo = fn.GetRecords("SELECT Prod_id, Prod_name, Prod_Price, Prod_Catg_id, Unit_id, Brand_id, Barcode,DngrLevel,P_Price FROM tbl_Product WHERE (Prod_id = " + grdproductsearch.CurrentRow.Cells[0].Value + ")");
            frmProducts.Default.FillRecord();
            this.Close();
            frmProducts.Default.MdiParent = FrmMain.Default;
            frmProducts.Default.Show();
            frmProducts.Default.btnsave.Text = "&Update";
            frmProducts.Default.btnProductfind.Text = "&Cancel";
        }

        private void txtsearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            fn.fillGrid(grdproductsearch, "SELECT Prod_id,Prod_name as 'Product Name', Prod_Price as 'Product Price' FROM tbl_Product WHERE (Prod_name like '" + txtsearch.Text + "%') and CompID=" + MyModule.CompID + "");
        }

        private void grdproductsearch_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            grdproductsearch.Columns[0].Visible = false;
            grdproductsearch.Columns[1].Width = 260;
            grdproductsearch.Columns[2].Width = 100;
        }

        private void frmfind_Load(object sender, EventArgs e)
        {
        }
    }
}