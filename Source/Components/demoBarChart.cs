using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;

namespace Smobiler.Tutorials.Components
{
    partial class demoBarChart : Smobiler.Core.Controls.MobileForm
    {
        public demoBarChart()
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

        private void demoBarChart_Load(object sender, EventArgs e)
        {
            PopListGroup g1 = new PopListGroup();
            g1.AddListItem("DataBind");
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
                case "AddSet":
                    this.barChart1.Data.AddSeries(GetNewSerie(this.barChart1.Data));
                    break;
                case "RemoveSet":
                    if (this.barChart1.Data.SeriesCount > 0)
                    {
                        this.barChart1.Data.RemoveSeries(0);
                    }
                    break;
                case "ClearSet":
                    this.barChart1.Data.ClearValues();
                    break;
                case "SetData":
                    List<string> xLabels = new List<string>();
                    xLabels.AddRange(new string[] { "1", "2", "3", "4" });
                    BarData data = new BarData(xLabels);
                    data.AddSeries(GetNewSerie(data));
                    this.barChart1.Data = data;
                    break;
            }
        }
        private void DataBind()
        {
            //设置数据
            this.barChart1.SeriesMember = "S";
            this.barChart1.XValueMember = "X";
            this.barChart1.YValueMember = "Y";
            this.barChart1.XAxis.AxisLineColor = DemoGlobal.GetRandomColor();
            this.barChart1.XAxis.GridColor = DemoGlobal.GetRandomColor();
            dt = DemoGlobal.GetChartDemoTable();
            this.barChart1.DataSource = dt;
            this.barChart1.DataBind();
        }
        private BarSeries GetNewSerie(BarData data)
        {
            Random countRandom = new Random();
            ChartYAxisValueCollection<BarYAxisValue> yVals = new ChartYAxisValueCollection<BarYAxisValue>();
            int count = data.XAxisCount;
            for (int i = 0; i < count; i++)
            {
                yVals.Add(new BarYAxisValue(countRandom.Next(0, count)));
            }
            BarSeries set1 = new BarSeries(yVals, "DataSet 1");
            set1.AddColor(DemoGlobal.GetRandomColor());
            set1.AddColor(DemoGlobal.GetRandomColor());
            set1.AddColor(DemoGlobal.GetRandomColor());

            return set1;
        }
        private void barChart1_ValueSelected(object sender, BarChartValueSelectedEventArgs e)
        {
            Toast(string.Format("X:{0}/Y:{1}", e.XValue, e.YValue.Val));
        }
    }
}