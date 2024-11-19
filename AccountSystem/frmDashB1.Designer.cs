namespace AccountSystem
{
    partial class frmDashB1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tblDailyProductionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.settingDS = new AccountSystem.SettingDS();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.weeklyProductionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.monthlyProductionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblDailyProductionTableAdapter = new AccountSystem.SettingDSTableAdapters.tblDailyProductionTableAdapter();
            this.weeklyProductionTableAdapter = new AccountSystem.SettingDSTableAdapters.WeeklyProductionTableAdapter();
            this.monthlyProductionTableAdapter = new AccountSystem.SettingDSTableAdapters.MonthlyProductionTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDailyProductionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weeklyProductionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyProductionBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.Control;
            this.chart1.BorderlineColor = System.Drawing.SystemColors.Control;
            this.chart1.BorderSkin.BackColor = System.Drawing.Color.Black;
            this.chart1.BorderSkin.PageColor = System.Drawing.SystemColors.Control;
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.LabelStyle.Format = "dd MMM";
            chartArea1.AxisX.LabelStyle.Interval = 1D;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.MinorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea1.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.BorderColor = System.Drawing.Color.Gainsboro;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.tblDailyProductionBindingSource;
            this.chart1.Dock = System.Windows.Forms.DockStyle.Top;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend1.Name = "Legend1";
            legend1.Position.Auto = false;
            legend1.Position.Height = 10.48035F;
            legend1.Position.Width = 26F;
            legend1.Position.X = 66.15198F;
            legend1.Position.Y = 3F;
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 40);
            this.chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.Silver;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.CustomProperties = "EmptyPointValue=Zero";
            series1.EmptyPointStyle.AxisLabel = "0";
            series1.IsValueShownAsLabel = true;
            series1.Label = "#VAL{N0}";
            series1.Legend = "Legend1";
            series1.MarkerSize = 8;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Star5;
            series1.Name = "Production (Pallets)";
            series1.XValueMember = "Dates";
            series1.YValueMembers = "Pallets";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Purple;
            series2.Legend = "Legend1";
            series2.Name = "AVGs";
            series2.XValueMember = "Dates";
            series2.YValueMembers = "AVGs";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.Red;
            series3.Legend = "Legend1";
            series3.Name = "Targets";
            series3.XValueMember = "Dates";
            series3.YValueMembers = "Targets";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(1199, 230);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tblDailyProductionBindingSource
            // 
            this.tblDailyProductionBindingSource.DataMember = "tblDailyProduction";
            this.tblDailyProductionBindingSource.DataSource = this.settingDS;
            // 
            // settingDS
            // 
            this.settingDS.DataSetName = "SettingDS";
            this.settingDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = " \r\nDaily Production Line";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Weekly Production";
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.SystemColors.Control;
            this.chart2.BorderlineColor = System.Drawing.SystemColors.Control;
            this.chart2.BorderSkin.BackColor = System.Drawing.Color.Black;
            this.chart2.BorderSkin.PageColor = System.Drawing.SystemColors.Control;
            chartArea2.AxisX.Interval = 1D;
            chartArea2.AxisX.LabelStyle.Interval = 1D;
            chartArea2.AxisX.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisY.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisY.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisY.MinorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea2.BackColor = System.Drawing.SystemColors.Control;
            chartArea2.BorderColor = System.Drawing.Color.Gainsboro;
            chartArea2.Name = "ChartArea1";
            chartArea2.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.DataSource = this.weeklyProductionBindingSource;
            this.chart2.Dock = System.Windows.Forms.DockStyle.Left;
            this.chart2.Location = new System.Drawing.Point(0, 300);
            this.chart2.Name = "chart2";
            series4.BorderColor = System.Drawing.Color.Silver;
            series4.ChartArea = "ChartArea1";
            series4.CustomProperties = "EmptyPointValue=Zero";
            series4.EmptyPointStyle.AxisLabel = "0";
            series4.IsValueShownAsLabel = true;
            series4.Label = "#VAL{N0}";
            series4.MarkerSize = 8;
            series4.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Star5;
            series4.Name = "Series1";
            series4.XValueMember = "Weeks";
            series4.YValueMembers = "Pallets";
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Color = System.Drawing.Color.Red;
            series5.Name = "Series2";
            series5.XValueMember = "Weeks";
            series5.YValueMembers = "Targets";
            this.chart2.Series.Add(series4);
            this.chart2.Series.Add(series5);
            this.chart2.Size = new System.Drawing.Size(718, 218);
            this.chart2.TabIndex = 2;
            this.chart2.Text = "chart2";
            // 
            // weeklyProductionBindingSource
            // 
            this.weeklyProductionBindingSource.DataMember = "WeeklyProduction";
            this.weeklyProductionBindingSource.DataSource = this.settingDS;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(788, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Monthly Production";
            // 
            // chart3
            // 
            this.chart3.BackColor = System.Drawing.SystemColors.Control;
            this.chart3.BorderlineColor = System.Drawing.SystemColors.Control;
            this.chart3.BorderSkin.BackColor = System.Drawing.Color.Black;
            this.chart3.BorderSkin.PageColor = System.Drawing.SystemColors.Control;
            chartArea3.AxisX.Interval = 1D;
            chartArea3.AxisX.LabelStyle.Format = "dd MMM";
            chartArea3.AxisX.LabelStyle.Interval = 1D;
            chartArea3.AxisX.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisX.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisY.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisY.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisY.MinorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea3.BackColor = System.Drawing.SystemColors.Control;
            chartArea3.BorderColor = System.Drawing.Color.Gainsboro;
            chartArea3.Name = "ChartArea1";
            chartArea3.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.chart3.ChartAreas.Add(chartArea3);
            this.chart3.DataSource = this.monthlyProductionBindingSource;
            this.chart3.Dock = System.Windows.Forms.DockStyle.Right;
            this.chart3.Location = new System.Drawing.Point(723, 300);
            this.chart3.Name = "chart3";
            this.chart3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series6.BorderColor = System.Drawing.Color.Silver;
            series6.ChartArea = "ChartArea1";
            series6.CustomProperties = "EmptyPointValue=Zero";
            series6.EmptyPointStyle.AxisLabel = "0";
            series6.IsValueShownAsLabel = true;
            series6.Label = "#VAL{N0}";
            series6.MarkerSize = 8;
            series6.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Star5;
            series6.Name = "Series1";
            series6.XValueMember = "Months";
            series6.YValueMembers = "Pallets";
            series7.BorderWidth = 3;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Color = System.Drawing.Color.Red;
            series7.Name = "Series2";
            series7.XValueMember = "Months";
            series7.YValueMembers = "Targets";
            this.chart3.Series.Add(series6);
            this.chart3.Series.Add(series7);
            this.chart3.Size = new System.Drawing.Size(476, 218);
            this.chart3.TabIndex = 4;
            this.chart3.Text = "chart3";
            // 
            // monthlyProductionBindingSource
            // 
            this.monthlyProductionBindingSource.DataMember = "MonthlyProduction";
            this.monthlyProductionBindingSource.DataSource = this.settingDS;
            // 
            // tblDailyProductionTableAdapter
            // 
            this.tblDailyProductionTableAdapter.ClearBeforeFill = true;
            // 
            // weeklyProductionTableAdapter
            // 
            this.weeklyProductionTableAdapter.ClearBeforeFill = true;
            // 
            // monthlyProductionTableAdapter
            // 
            this.monthlyProductionTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MMMM yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(1106, 116);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(10, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 270);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1199, 30);
            this.panel1.TabIndex = 7;
            // 
            // frmDashB1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 518);
            this.ControlBox = false;
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashB1";
            this.Load += new System.EventHandler(this.frmDashB1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDailyProductionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weeklyProductionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyProductionBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private SettingDS settingDS;
        private System.Windows.Forms.BindingSource tblDailyProductionBindingSource;
        private SettingDSTableAdapters.tblDailyProductionTableAdapter tblDailyProductionTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.BindingSource weeklyProductionBindingSource;
        private SettingDSTableAdapters.WeeklyProductionTableAdapter weeklyProductionTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.BindingSource monthlyProductionBindingSource;
        private SettingDSTableAdapters.MonthlyProductionTableAdapter monthlyProductionTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
    }
}