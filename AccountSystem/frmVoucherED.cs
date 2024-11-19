using System;
using System.Windows.Forms;
namespace AccountSystem
{
    public partial class frmVoucherED : Form
    {
        private Boolean chkSave = default(Boolean);
        private MyModule Fn = new MyModule();
        private Words Wrd = new Words();
        public frmVoucherED()
        {
            InitializeComponent();
            if (defaultInstance == null)
                defaultInstance = this;
        }
        #region Default Instance
        private static frmVoucherED defaultInstance;
        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static frmVoucherED Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new frmVoucherED();
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
        private void frmVoucher_Load(object sender, EventArgs e)
        {

            
            Fn.fillGrdCombo(grdCboAccHeads, "SELECT EntryAccID, EntryAccName FROM TblAccEntry WHERE (Stat = 1)");
Fn.fillGrdCombo(dataGridViewTextBoxColumn7, "SELECT Expr1 AS Ref, Expr1 + ': Rs.' +CONVERT(varchar, format(SUM(Expr2), '#,#;(#,#)')) AS Amount FROM (SELECT Contact_id, 'P' + Purch_bill_no AS Expr1, SUM((TotalAmount + CarriageFreight - AdditionalDiscount - ItemDiscount - AmountPaid)* -1 ) AS Expr2 FROM tbl_Purchase WHERE (InvoiceType = 1) GROUP BY Contact_id, 'P' + Purch_bill_no UNION SELECT Contact_id, 'P' + Purch_OrderNo AS Expr1, SUM((TotalAmount + CarriageFreight - AdditionalDiscount - ItemDiscount - AmountPaid)) AS Expr2 FROM tbl_Purchase AS tbl_Purchase_1 WHERE (InvoiceType = - 1) GROUP BY Contact_id, 'P' + Purch_OrderNo UNION SELECT AccEntryID, Ref, SUM(AmountDeb- AmountCre ) AS Expr1 FROM TblVoucherDTL WHERE (NOT (Ref LIKE '')) GROUP BY AccEntryID, Ref UNION SELECT Contact_id, 'S' + Sale_bill_no AS Expr1, SUM((TotalAmount + CarriageFreight - AdditionalDiscount - ItemDiscount - AmountPaid)) AS Expr2 FROM tbl_Sale WHERE (InvoiceType = 1) GROUP BY Contact_id, 'S' + Sale_bill_no UNION SELECT Contact_id, 'S' + Sale_OrderNo AS Expr1, SUM((TotalAmount + CarriageFreight - AdditionalDiscount - ItemDiscount - AmountPaid) * -1) AS Expr2 FROM tbl_Sale AS tbl_Sale_1 WHERE (InvoiceType = - 1) GROUP BY Contact_id, 'S' + Sale_OrderNo) AS tb GROUP BY Expr1 HAVING (SUM(Expr2) <> 0) AND (Expr1 <> '0')");
        }
        private void frmVoucher_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
        private void cboVouType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Fn.fillList(listVoucher, "SELECT TblVoucherHDR0.VoucherID, TblVoucherHDR0.VoucherNo FROM TblVoucherHDR0 INNER JOIN TblVoucherDTL0 ON TblVoucherHDR0.VoucherID = TblVoucherDTL0.VoucherID WHERE (TblVoucherHDR0.VoucherNo LIKE N'" + cboVouType.Text.Substring(0, 2) + "%') AND (TblVoucherHDR0.VStatus = 0) AND (TblVoucherHDR0.BranchID = "+ cbLocation.SelectedValue + ") GROUP BY TblVoucherHDR0.VoucherNo, TblVoucherHDR0.VoucherID ");
        }

        private void tblVoucherHDRBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblVoucherHDRBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.voucherEd);

        }

        private void tblVoucherHDRBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tblVoucherHDRBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.voucherEd);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblVoucherHDRTableAdapter.Fill(this.voucherEd.TblVoucherHDR, (Int32)listVoucher.SelectedValue);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}