using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;

namespace Smobiler.Tutorials.Components
{
    partial class demoBubbleChart : Smobiler.Core.Controls.MobileForm
    {
        public demoBubbleChart()
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

        private void demoBubbleChart_Load(object sender, EventArgs e)
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
                    this.bubbleChart1.Data.AddSeries(GetNewSerie(this.bubbleChart1.Data));
                    break;
                case "RemoveSet":
                    if (this.bubbleChart1.Data.SeriesCount > 0)
                    {
                        this.bubbleChart1.Data.RemoveSeries(0);
                    }
                    break;
                case "ClearSet":
                    this.bubbleChart1.Data.ClearValues();
                    break;
                case "SetData":
                    List<string> xLabels = new List<string>();
                    xLabels.AddRange(new string[] { "1", "2", "3", "4" });
                    BubbleData data = new BubbleData(xLabels);
                    data.AddSeries(GetNewSerie(data));
                    this.bubbleChart1.Data = data;
                    break;
            }
        }
        private void DataBind()
        {
            //设置数据
            this.bubbleChart1.SeriesMember = "S";
            this.bubbleChart1.XValueMember = "X";
            this.bubbleChart1.YValueMember = "Y";
            this.bubbleChart1.SizeMember = "Z";
            dt = DemoGlobal.GetChartDemoTable();
            this.bubbleChart1.DataSource = dt;
            this.bubbleChart1.DataBind();
        }

        private BubbleSeries GetNewSerie(BubbleData data)
        {
            Random countRandom = new Random();
            ChartYAxisValueCollection<BubbleYAxisValue> yVals = new ChartYAxisValueCollection<BubbleYAxisValue>();
            int count = data.XAxisCount;
            for (int i = 0; i < count; i++)
            {
                yVals.Add(new BubbleYAxisValue(countRandom.Next(0, count), countRandom.Next(0, count)));
            }
            BubbleSeries set1 = new BubbleSeries(yVals, "DataSet 1");
            set1.AddColor(DemoGlobal.GetRandomColor());
            set1.AddColor(DemoGlobal.GetRandomColor());
            set1.AddColor(DemoGlobal.GetRandomColor());

            return set1;
        }

        private void bubbleChart1_ValueSelected(object sender, BubbleChartValueSelectedEventArgs e)
        {
            Toast(string.Format("X:{0}/Y:{1}", e.XValue, e.YValue.Val));
        }
    }
}