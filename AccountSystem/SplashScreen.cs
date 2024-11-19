using System;
using System.Windows.Forms;

namespace AccountSystem
{
    public partial class SplashScreen
    {
        public SplashScreen()
        {
            InitializeComponent();

            //Added to support default instance behavour in C#
            if (defaultInstance == null)
                defaultInstance = this;
        }

        #region Default Instance

        private static SplashScreen defaultInstance;

        /// <summary>
        /// Added by the VB.Net to C# Converter to support default instance behavour in C#
        /// </summary>
        public static SplashScreen Default
        {
            get
            {
                if (defaultInstance == null)
                {
                    defaultInstance = new SplashScreen();
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

        public void SplashScreen_Load(System.Object sender, System.EventArgs e)
        {
            //if ((new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.Title != "")
            //{
            //    ApplicationTitle.Text = (new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.Title;
            //}
            //else
            //{
            //    ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension((new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.AssemblyName);
            //}

            //Version.Text = System.String.Format(Version.Text, (new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.Version.Major, (new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.Version.Minor);

            //Copyright.Text = (new Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase()).Info.Copyright;
        }

        private static int LoadTimer_Tick_count;

        public void LoadTimer_Tick(System.Object sender, System.EventArgs e)
        {
            LoadTimer_Tick_count++;
            try
            {
                if (LoadTimer_Tick_count == 1)
                {
                    LoadingLbl.Text = "Checking Classes ...";

                    LoginForm.Default.Visible = false;
                    LoginForm.Default.Activate();
                }
                else if (LoadTimer_Tick_count == 2)
                {
                    LoadingLbl.Text = "Classes Initialized ...";
                    FrmMain.Default.Visible = false;
                    FrmMain.Default.Activate();
                }
                else if (LoadTimer_Tick_count == 3)
                {
                    LoadingLbl.Text = "Applying System Database ...";
                }
                else if (LoadTimer_Tick_count == 4)
                {
                    LoadingLbl.Text = "Loading Database ..";
                }
                else if (LoadTimer_Tick_count == 5)
                {
                    LoadingLbl.Text = "Loading Database ...";
                }
                else if (LoadTimer_Tick_count == 6)
                {
                    LoadingLbl.Text = "Loading .....";
                }
                else if (LoadTimer_Tick_count == 7)
                {
                    LoadingLbl.Text = "Loading ...";
                    FrmMain.Default.Show();
                }
                else if (LoadTimer_Tick_count == 8)
                {
                    LoadTimer.Stop();

                    this.Hide();
                    PictureBox2.Dispose();
                    LoadTimer.Enabled = false;
                    //this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //Exit Sub
            }
        }
    }
}