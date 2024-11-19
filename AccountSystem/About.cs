using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace AccountSystem
{

    public partial class About : XtraForm
    {
        MyModule Fn = new MyModule();
        public About()
        {
            InitializeComponent();
            if (defaultInstance == null)
                defaultInstance = this;
        }

        #region Default Instance

        private static About defaultInstance;

        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static About Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new About();
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

        private void SimpleButton8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void About_Load(object sender, EventArgs e)
        {


        }


    }
}