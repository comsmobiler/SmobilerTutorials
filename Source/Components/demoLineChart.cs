using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;

namespace Smobiler.Tutorials.Components
{
    partial class demoLineChart : Smobiler.Core.Controls.MobileForm
    {
        public demoLineChart()
            : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        DataTable dt = null;
        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Press(object sender, EventArgs e)
        {
            this.popList1.ShowDialog();
        }

        private void demoLineChart_Load(object sender, EventArgs e)
        {
            PopListGroup g1 = new PopListGroup();
            g1.AddListItem("DataBind");
            g1.AddListItem("XAxis");
            g1.AddListItem("AddSet");
            g1.AddListItem("RemoveSet");
            g1.AddListItem("ClearSet");
            g1.AddListItem("SetData");
            popList1.Groups.Add(g1);
        }

        private void popList1_Selected(object sender, EventArgs e)
        {
            switch (popList1.Selections[0].Text)
            {
                case "DataBind":
                    DataBind();
                    break;
                case "XAxis":
                    this.lineChart1.XAxis.XOffset = 1;
                    this.lineChart1.XAxis.YOffset = 1;
                    this.lineChart1.XAxis.TextSize = 10;
                    this.lineChart1.XAxis.TextColor = System.Drawing.Color.Red;
                    this.lineChart1.XAxis.DrawAxisLine = false;
                    this.lineChart1.XAxis.DrawGridLines = false;
                    this.lineChart1.XAxis.DrawLabels = false;
                    this.lineChart1.XAxis.GridLineWidth = 5;
                    this.lineChart1.XAxis.AxisLineWidth = 5;
                    this.lineChart1.XAxis.GridColor = System.Drawing.Color.Blue;
                    this.lineChart1.XAxis.AxisLineColor = System.Drawing.Color.Gray;
                    this.lineChart1.XAxis.Position = XAxisPosition.TOP;
                    break;
                case "AddSet":
                    this.lineChart1.Data.AddSeries(GetNewSerie(this.lineChart1.Data));
                    break;
                case "RemoveSet":
                    if (this.lineChart1.Data.SeriesCount > 0)
                    {
                        this.lineChart1.Data.RemoveSeries(0);
                    }
                    break;
                case "ClearSet":
                    this.lineChart1.Data.ClearValues();
                    break;
                case "SetData":
                    List<string> xLabels = new List<string>();
                    xLabels.AddRange(new string[] { "2019-09-01", "2019-09-02", "2019-09-03", "2019-09-04", "2019-09-05", "2019-09-06", "2019-09-07", "2019-09-08", "2019-09-09", "2019-09-10", "2019-09-11", "2019-09-12", "2019-09-13", "2019-09-14", "2019-09-15", "2019-09-16", "2019-09-17", "2019-09-18", "2019-09-19", "2019-09-20", "2019-09-21", "2019-09-22", "2019-09-23", "2019-09-24", "2019-09-25", "2019-09-26", "2019-09-27", "2019-09-28", "2019-09-29", "2019-09-30", "2019-09-31"});
                    LineData data = new LineData(xLabels);
                    data.AddSeries(GetNewSerie(data));
                    this.lineChart1.Data = data;
                    break;
            }
        }
        private void DataBind()
        {
            //设置数据
            this.lineChart1.SeriesMember = "S";
            this.lineChart1.XValueMember = "X";
            this.lineChart1.YValueMember = "Y";
            dt = DemoGlobal.GetChartDemoTable();
            this.lineChart1.DataSource = dt;
            this.lineChart1.DataBind();

            //填充随机颜色
            int count = this.lineChart1.Data.SeriesCount;
            for (int i = 0; i < count; i += 1)
            {
                LineSeries series = this.lineChart1.Data.GetSeries(i);
                series.DrawFilled = true;
                series.DrawFilledColor = DemoGlobal.GetRandomColor();
            }
        }

        private LineSeries GetNewSerie(LineData data)
        {
            Random countRandom = new Random();
            ChartYAxisValueCollection<ChartYAxisValue> yVals = new ChartYAxisValueCollection<ChartYAxisValue>();
            int count = data.XAxisCount;
            for (int i = 0; i < count; i++)
            {
                yVals.Add(new ChartYAxisValue(countRandom.Next(0, count)));
            }
            LineSeries set1 = new LineSeries(yVals, "DataSet 1");
            set1.Color = DemoGlobal.GetRandomColor();
            set1.DrawFilled = true;
            set1.DrawCubic = true;
            set1.DrawFilledColor = DemoGlobal.GetRandomColor();
            return set1;
        }

        private void lineChart1_ValueSelected(object sender, LineChartValueSelectedEventArgs e)
        {
            Toast(string.Format("X:{0}/Y:{1}", e.XValue, e.YValue.Val));
        }
    }
}
