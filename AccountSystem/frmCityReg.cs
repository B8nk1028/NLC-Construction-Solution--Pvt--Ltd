using System;
using System.Data;
using System.Windows.Forms;
namespace AccountSystem
{
    public partial class frmCityReg
    {
        MyModule Fn = new MyModule();
        public frmCityReg()
        {
            InitializeComponent();
            if (defaultInstance == null)
                defaultInstance = this;
        }
        #region Default Instance
        private static frmCityReg defaultInstance;
        public static frmCityReg Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new frmCityReg();
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
        private void frmVendors_Load(object sender, EventArgs e)
        {
            
            Fn.fillCombo(regionComboBox, "SELECT Region, Region AS reg FROM tblLocations GROUP BY Region");
            Fn.fillCombo(provinceComboBox, "SELECT Province, Province AS prv FROM tblLocations GROUP BY Province");
            this.tblLocationsTableAdapter.Fill(this.dataSet2.tblLocations);
        }
        private void tblLocationsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblLocationsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet2);
        }

        private void regionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}