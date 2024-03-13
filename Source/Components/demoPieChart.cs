using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;

namespace Smobiler.Tutorials.Components
{
    partial class demoPieChart : Smobiler.Core.Controls.MobileForm
    {
        public demoPieChart()
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

        private void demoPieChart_Load(object sender, EventArgs e)
        {
            PopListGroup g1 = new PopListGroup();
            g1.AddListItem("DataBind");
            g1.AddListItem("Legend");
            g1.AddListItem("LegendSize");
            g1.AddListItem("AddSet");
            g1.AddListItem("RemoveSet");
            g1.AddListItem("ClearSet");
            g1.AddListItem("SetData");
            popList1.Groups.Add(g1);
        }

        private void pieChart1_ValueSelected(object sender, PieChartValueSelectedEventArgs e)
        {
            Toast(string.Format("X:{0}/Y:{1}", e.XValue, e.YValue.Val));
        }
        private void DataBind()
        {
            //设置数据
            this.pieChart1.SeriesMember = "S";
            this.pieChart1.XValueMember = "X";
            this.pieChart1.YValueMember = "Y";
            dt = DemoGlobal.GetChartDemoTable();
            this.pieChart1.DataSource = dt;
            this.pieChart1.DataBind();
        }

        private PieSeries GetNewSerie(PieData data)
        {
            Random countRandom = new Random();
            ChartYAxisValueCollection<ChartYAxisValue> yVals = new ChartYAxisValueCollection<ChartYAxisValue>();
            int count = data.XAxisCount;
            for (int i = 0; i < count; i++)
            {
                yVals.Add(new BarYAxisValue(countRandom.Next(0, count)));
            }
            PieSeries set1 = new PieSeries(yVals, "DataSet 1");
            set1.AddColor(DemoGlobal.GetRandomColor());
            set1.AddColor(DemoGlobal.GetRandomColor());
            set1.AddColor(DemoGlobal.GetRandomColor());

            return set1;
        }

        private void popList1_Selected(object sender, EventArgs e)
        {
            switch (popList1.Selections[0].Text)
            {
                case "DataBind":
                    DataBind();
                    break;
                case "Legend":
                    this.pieChart1.Legend.XEntrySpace = 10;
                    this.pieChart1.Legend.YEntrySpace = 10;
                    this.pieChart1.Legend.Position = LegendPosition.BELOW_CHART_LEFT;
                    this.pieChart1.Legend.XOffset = 1;
                    this.pieChart1.Legend.YOffset = 1;
                    this.pieChart1.Legend.TextSize = 15;
                    this.pieChart1.Legend.TextColor = System.Drawing.Color.Red;
                    break;
                case "LegendSize":
                    if (this.pieChart1.Legend.Size == 0)
                        this.pieChart1.Legend.Size = 10;
                    else
                        this.pieChart1.Legend.Size = 0;
                    break;
                case "AddSet":
                    this.pieChart1.Data.AddSeries(GetNewSerie(this.pieChart1.Data));
                    break;
                case "RemoveSet":
                    if (this.pieChart1.Data.SeriesCount > 0)
                    {
                        this.pieChart1.Data.RemoveSeries(0);
                    }
                    break;
                case "ClearSet":
                    this.pieChart1.Data.ClearValues();
                    break;
                case "SetData":
                    List<string> xLabels = new List<string>();
                    xLabels.AddRange(new string[] { "1", "2", "3", "4" });
                    PieData data = new PieData(xLabels);
                    Random countRandom = new Random();
                    ChartYAxisValueCollection<ChartYAxisValue> yVals = new ChartYAxisValueCollection<ChartYAxisValue>();
                    for (int i = 0; i < xLabels.Count; i++)
                    {
                        yVals.Add(new BarYAxisValue(countRandom.Next(0, xLabels.Count)));
                    }
                    PieSeries set1 = new PieSeries(yVals, "DataSet 1");
                    set1.AddColor(DemoGlobal.GetRandomColor());
                    set1.AddColor(DemoGlobal.GetRandomColor());
                    set1.AddColor(DemoGlobal.GetRandomColor());

                      data.AddSeries(set1);
                      this.pieChart1.Data = data;
           
                    break;
            }
        }
    }
}