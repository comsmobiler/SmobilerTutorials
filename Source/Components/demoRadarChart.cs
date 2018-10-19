using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;

namespace Smobiler.Tutorials.Components
{
    partial class demoRadarChart : Smobiler.Core.Controls.MobileForm
    {
        public demoRadarChart()
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

        private void demoRadarChart_Load(object sender, EventArgs e)
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
                    this.radarChart1.Data.AddSeries(GetNewSerie(this.radarChart1.Data));
                    break;
                case "RemoveSet":
                    if (this.radarChart1.Data.SeriesCount > 0)
                    {
                        this.radarChart1.Data.RemoveSeries(0);
                    }
                    break;
                case "ClearSet":
                    this.radarChart1.Data.ClearValues();
                    break;
                case "SetData":
                    List<string> xLabels = new List<string>();
                    xLabels.AddRange(new string[] { "1", "2", "3", "4" });
                    RadarData data = new RadarData(xLabels);
                    data.AddSeries(GetNewSerie(data));
                    this.radarChart1.Data = data;
                    break;
            }
        }
        private void DataBind()
        {
            //设置数据
            this.radarChart1.SeriesMember = "S";
            this.radarChart1.XValueMember = "X";
            this.radarChart1.YValueMember = "Y";
            dt = DemoGlobal.GetChartDemoTable();
            this.radarChart1.DataSource = dt;
            this.radarChart1.DataBind();
        }

        private RadarSeries GetNewSerie(RadarData data)
        {
            Random countRandom = new Random();
            ChartYAxisValueCollection<ChartYAxisValue> yVals = new ChartYAxisValueCollection<ChartYAxisValue>();
            int count = data.XAxisCount;
            for (int i = 0; i < count; i++)
            {
                yVals.Add(new BarYAxisValue(countRandom.Next(0, count)));
            }
            RadarSeries set1 = new RadarSeries(yVals, "DataSet 1");
            set1.AddColor(DemoGlobal.GetRandomColor());
            set1.AddColor(DemoGlobal.GetRandomColor());
            set1.AddColor(DemoGlobal.GetRandomColor());

            return set1;
        }

        private void radarChart1_ValueSelected(object sender, RadarChartValueSelectedEventArgs e)
        {
            Toast(string.Format("X:{0}/Y:{1}", e.XValue, e.YValue.Val));
        }
    }
}