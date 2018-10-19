using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;

namespace Smobiler.Tutorials.Components
{
    partial class demoCandleStickChart : Smobiler.Core.Controls.MobileForm
    {
        public demoCandleStickChart()
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


        private void demoCandleStickChart_Load(object sender, EventArgs e)
        {
            PopListGroup g1 = new PopListGroup();
            g1.AddListItem("DataBind");
            g1.AddListItem("AddSet");
            g1.AddListItem("RemoveSet");
            g1.AddListItem("ClearSet");
            g1.AddListItem("SetData");
            popList1.Groups.Add(g1);
        }

        private void DataBind()
        {
            //设置数据
            this.candleStickChart1.SeriesMember = "S";
            this.candleStickChart1.XValueMember = "X";
            this.candleStickChart1.YValueMember = "Y";
            this.candleStickChart1.ValueHighMember = "VH";
            this.candleStickChart1.ValueLowMember = "VL";
            this.candleStickChart1.ValueOpenMember = "VO";
            this.candleStickChart1.ValueCloseMember = "VC";
            this.candleStickChart1.XAxis.AxisLineColor = DemoGlobal.GetRandomColor();
            this.candleStickChart1.XAxis.GridColor = DemoGlobal.GetRandomColor();
            dt = DemoGlobal.GetChartDemoTable();
            this.candleStickChart1.DataSource = dt;
            this.candleStickChart1.DataBind();
        }

        private CandleStickSeries GetNewSerie(CandleStickData data)
        {
            Random countRandom = new Random();
            ChartYAxisValueCollection<CandleStickYAxisValue> yVals = new ChartYAxisValueCollection<CandleStickYAxisValue>();
            int count = data.XAxisCount;
            for (int i = 0; i < count; i++)
            {
                yVals.Add(new CandleStickYAxisValue(countRandom.Next(0, count), countRandom.Next(0, count), countRandom.Next(0, count), countRandom.Next(0, count)));
            }
            CandleStickSeries set1 = new CandleStickSeries(yVals, "DataSet 1");
            set1.AddColor(DemoGlobal.GetRandomColor());
            set1.AddColor(DemoGlobal.GetRandomColor());
            set1.AddColor(DemoGlobal.GetRandomColor());

            return set1;
        }

        private void candleStickChart1_ValueSelected(object sender, CandleStickChartValueSelectedEventArgs e)
        {
            Toast(string.Format("X:{0}/Y:{1}", e.XValue, e.YValue.Val));
        }

        private void popList1_Selected(object sender, EventArgs e)
        {
            switch (popList1.Selections[0].Text)
            {
                case "DataBind":
                    DataBind();
                    break;
                case "AddSet":
                    this.candleStickChart1.Data.AddSeries(GetNewSerie(this.candleStickChart1.Data));
                    break;
                case "RemoveSet":
                    if (this.candleStickChart1.Data.SeriesCount > 0)
                    {
                        this.candleStickChart1.Data.RemoveSeries(0);
                    }
                    break;
                case "ClearSet":
                    this.candleStickChart1.Data.ClearValues();
                    break;
                case "SetData":
                    List<string> xLabels = new List<string>();
                    xLabels.AddRange(new string[] { "1", "2", "3", "4" });
                    CandleStickData data = new CandleStickData(xLabels);
                    data.AddSeries(GetNewSerie(data));
                    this.candleStickChart1.Data = data;
                    break;
            }
        }
    }
}