using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AccountSystem
{
    public partial class frmDashB1 : Form
    {
        private MyModule Fn = new MyModule();
        public frmDashB1()
        {
            InitializeComponent();
        }

        private void frmDashB1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'settingDS.MonthlyProduction' table. You can move, or remove it, as needed.
            this.monthlyProductionTableAdapter.Fill(this.settingDS.MonthlyProduction);
            // TODO: This line of code loads data into the 'settingDS.WeeklyProduction' table. You can move, or remove it, as needed.
            this.weeklyProductionTableAdapter.Fill(this.settingDS.WeeklyProduction);
            // TODO: This line of code loads data into the 'settingDS.tblDailyProduction' table. You can move, or remove it, as needed.
            this.tblDailyProductionTableAdapter.Fill(this.settingDS.tblDailyProduction, dateTimePicker1.Text);
            //DataTable dt = Fn.FillDSet("SELECT top(15) SUM(pallets) AS Pallets, pDate Dates FROM tblDailyProduction GROUP BY pDate order by pdate desc").Tables[0];

            //this.chart1.DataSource = dt;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //chart1.DataBindings.Clear();
            //this.tblDailyProductionTableAdapter.Fill(this.settingDS.tblDailyProduction, dateTimePicker1.Text);
            
        }
    }
}
