using System;
using System.Windows.Forms;

namespace AccountSystem
{
    public partial class ProductSheetList : Form
    {
        private MyModule Fn = new MyModule();

        public ProductSheetList()
        {
            InitializeComponent();
            if (defaultInstance == null)
                defaultInstance = this;
        }

        #region Default Instance

        private static ProductSheetList defaultInstance;

        public static ProductSheetList Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new ProductSheetList();
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

        private void AccountChart_Load(object sender, EventArgs e)
        {
            Fn.fillGridCbo(dataGridViewTextBoxColumn5, "SELECT Unit_id, Unit_title FROM tbl_Unit");
            Fn.fillGridCbo(dataGridViewTextBoxColumn4, "SELECT Prod_ctg_id, Prod_ctg_name FROM tbl_Prod_category");
            Fn.fillGridCbo(dataGridViewTextBoxColumn6, "SELECT Brand_id, Brand_name FROM tbl_Brand");
            // TODO: This line of code loads data into the 'productSheet.tbl_Product' table. You can move, or remove it, as needed.
            this.tbl_ProductTableAdapter.Fill(this.productSheet.tbl_Product,"%");
        }

        private void tbl_ProductBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_ProductBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.productSheet);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtSearch.Text.Length >= 3)
            {
                this.tbl_ProductTableAdapter.Fill(this.productSheet.tbl_Product, "%" + txtSearch.Text + "%");
            }
        }

        private void btnPrintList_Click(object sender, EventArgs e)
        {
            frmPrintProductList frm = new frmPrintProductList();
            frm.Show();
        }
    }
}