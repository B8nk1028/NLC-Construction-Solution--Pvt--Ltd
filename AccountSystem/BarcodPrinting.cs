using System;
using System.Windows.Forms;

namespace AccountSystem
{
    public partial class BarcodPrinting : Form
    {
        public BarcodPrinting()
        {
            InitializeComponent();
            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }

        #region Default Instance

        private static BarcodPrinting defaultInstance;

        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static BarcodPrinting Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new BarcodPrinting();
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

        private void BarcodPrinting_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BarcodePrinting.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.BarcodePrinting.DataTable1);

            this.reportViewer1.ShowExportButton = true; this.reportViewer1.RefreshReport();
        }
    }
}