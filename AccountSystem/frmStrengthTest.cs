using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace AccountSystem
{

    public partial class frmStrengthTest : XtraForm
    {
        MyModule Fn = new MyModule(); string[] cData;
        public frmStrengthTest()
        {
            InitializeComponent();
            if (defaultInstance == null)
                defaultInstance = this;
        }

        #region Default Instance

        private static frmStrengthTest defaultInstance;

        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static frmStrengthTest Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new frmStrengthTest();
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

        public void About_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            this.Hide();
            this.MdiParent = null;
            Dispose();
        }


        private void About_Load(object sender, EventArgs e)
        {

            Fn.fillCombo(cboVendor, "sp_VendorsList");
            Fn.fillCombo(cboProducts, "SELECT tbl_Product.Prod_id, tbl_Product.Prod_name FROM tbl_Product WHERE (tbl_Product.Brand_id IN (1,2,18,19,2018)) order by Prod_name"); 
            // TODO: This line of code loads data into the 'voucherEd.tblStrengthTest' table. You can move, or remove it, as needed.
            this.tblStrengthTestTableAdapter.Fill(this.voucherEd.tblStrengthTest);

        }

        private void cboVendor_SelectedIndexChanged(object sender, EventArgs e)
        {
            cData = Fn.GetRecords("SELECT TblAccEntry.BAddress + '<br><b>Contact No. ' + TblAccEntry.BContactNo AS Addressline, TblAccEntry.BTransport, TblAccEntry.CrLimit, (SELECT ISNULL(SUM(AmountDeb-AmountCre), 0) AS Expr1 FROM VW_VoucherDTL WHERE (AccEntryID = " + cboVendor.SelectedValue + ")) AS Balance, tblLocations.CityNmae + ', ' + 'Region, ' + tblLocations.Province AS Loc, TblAccEntry.PaymentTermsID FROM TblAccEntry INNER JOIN tblLocations ON TblAccEntry.BCity = tblLocations.CityID WHERE (TblAccEntry.EntryAccID = " + cboVendor.SelectedValue + ") ");
            txtAddress.Text = cData[0];
        }

        private void txtT1_ValueChanged(object sender, EventArgs e)
        {
            
            txtS1.Text = ((Convert.ToDecimal(txtT1.Text == "" ? "0" : txtT1.Text) / Convert.ToDecimal(txtArea.Text == "" ? "0" : txtArea.Text))).ToString("#,#.00");
            txtS2.Text = ((Convert.ToDecimal(txtT2.Text == "" ? "0" : txtT2.Text) / Convert.ToDecimal(txtArea.Text == "" ? "0" : txtArea.Text))).ToString("#,#.00");
            txtS3.Text = ((Convert.ToDecimal(txtT3.Text == "" ? "0" : txtT3.Text) / Convert.ToDecimal(txtArea.Text == "" ? "0" : txtArea.Text))).ToString("#,#.00");
            txtavg.Text = ((Convert.ToDecimal(txtS1.Text == "" ? "0" : txtS1.Text) + Convert.ToDecimal(txtS2.Text == "" ? "0" : txtS2.Text) + Convert.ToDecimal(txtS3.Text == "" ? "0" : txtS3.Text)) / 3).ToString("#,#.00");

        }

        private void tblStrengthTestBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblStrengthTestBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.voucherEd);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            //DialogResult result = new DialogResult();
            //result = MessageBox.Show("Are you sure to delete this test?", "Delete Test", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            //if (result == DialogResult.No)
            //{
            //    return;
            //}
        }
    }
}