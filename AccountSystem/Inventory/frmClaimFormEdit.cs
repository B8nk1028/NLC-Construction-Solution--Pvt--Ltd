using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace AccountSystem.Inventory
{
    public partial class frmClaimFormEdit : Form
    {
        private MyModule Fn = new MyModule();
        public frmClaimFormEdit()
        {
            InitializeComponent();
        }
        private void frmClaimForm_Load(object sender, EventArgs e)
        {
         
            Fn.fillCombo(cbLocation, "sp_OfficeLocations");
            cbLocation.SelectedValue = MyModule.BranchID;
            txtClaimNo.Text = Fn.GetRecords("SELECT COUNT(ClaimID) +1 FROM tblTireClaimsHDR WHERE (BranchID = " + cbLocation.SelectedValue + ")")[0];
            Fn.fillCombo(cboPartner, "SELECT EntryAccID, EntryAccName FROM TblAccEntry WHERE (AccType = 8)  AND (Stat = 1)");
            // TODO: This line of code loads data into the 'dataSet2.tblTireClaimsDTL' table. You can move, or remove it, as needed.
            this.tblTireClaimsDTLTableAdapter.Fill(this.dataSet2.tblTireClaimsDTL);
            // TODO: This line of code loads data into the 'dataSet2.tblTireClaimsHDR' table. You can move, or remove it, as needed.
            this.tblTireClaimsHDRTableAdapter.Fill(this.dataSet2.tblTireClaimsHDR);
            //this.tblTireClaimsHDRBindingNavigator.BindingSource.AddNew();
        }
        private void tblTireClaimsHDRBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (cboPartner.SelectedValue == null)
            {
                MessageBox.Show("Please select local partner name");
                return;
            }
            if (cbLocation.SelectedValue == null)
            {
                MessageBox.Show("Please select branch name");
                return;
            }
            if (dtClaimDT.Tag.ToString() == "")
            {
                MessageBox.Show("Please select date");
                return;
            }
            this.Validate();
            this.tblTireClaimsHDRBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet2);
            grdDetails.Show();
            bindingNavigatorAddNewItem.Enabled = true; toolStripButton2.Enabled = true; label9.Visible = true; label8.Visible = true;
        }
        private void grdDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 12 && grdDetails.ReadOnly == false)
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Are You Want to Delete ?", "Deleting Record", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in grdDetails.SelectedRows)
                    {
                        try
                        {
                            grdDetails.Rows.Remove(row);
                        }
                        catch { }
                    }
                }
            }
        }
        private void cbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtClaimNo.Text = Fn.GetRecords("SELECT COUNT(ClaimID) +1 FROM tblTireClaimsHDR WHERE (BranchID = " + cbLocation.SelectedValue + ")")[0];
        }
        private void grdDetails_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 12)
            {
                if (e.Value.ToString() == "System.Drawing.Bitmap")
                {
                    e.Value = global::AccountSystem.Properties.Resources.close;
                }
            }
        }
        private void cboPartner_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPartnerAddress.Text = Fn.GetRecords("SELECT BAddress+'<br><b>Contact No. '+BContactNo FROM TblAccEntry WHERE (EntryAccID = " + cboPartner.SelectedValue + ")")[0].ToString();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void grdDetails_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 12)
            {
                grdDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            else
            {
                grdDetails.SelectionMode = DataGridViewSelectionMode.CellSelect;
            }
        }
        private void tblTireClaimsHDRBindingNavigator_RefreshItems(object sender, EventArgs e)
        {
        }
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            grdDetails.Hide();
            bindingNavigatorAddNewItem.Enabled = false;
            toolStripButton2.Enabled = false; label9.Visible = false; label8.Visible = false;
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            rptTiresClaim PO = new rptTiresClaim();
            PO.Tag = grdDetails.Rows[0].Cells[13].Value;
            PO.ShowDialog();
        }
        private void dtClaimDT_ValueChanged(object sender, EventArgs e)
        {
            dtClaimDT.Tag = dtClaimDT.Value;
        }

        private void dtClaimDT_Enter(object sender, EventArgs e)
        {
            string[] actDate = Fn.GetRecords("sp_ActiveDates");
            dtClaimDT.MaxDate = Convert.ToDateTime(actDate[1]);
            dtClaimDT.MinDate = Convert.ToDateTime(actDate[0]);
        }
    }
}
