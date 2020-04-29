using Smobiler.Core.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Smobiler.Tutorials.Components
{
    class DemoGlobal
    {
        private static Random rd = new Random();

        internal static DataTable GetChartDemoTable()
        {
            DataTable dt = new DataTable("Table");
            dt.Columns.Add(new DataColumn("S", typeof(string)));
            dt.Columns.Add(new DataColumn("X", typeof(string)));
            dt.Columns.Add(new DataColumn("Y", typeof(float)));
            dt.Columns.Add(new DataColumn("Z", typeof(float)));
            dt.Columns.Add(new DataColumn("VH", typeof(float)));
            dt.Columns.Add(new DataColumn("VL", typeof(float)));
            dt.Columns.Add(new DataColumn("VO", typeof(float)));
            dt.Columns.Add(new DataColumn("VC", typeof(float)));
            dt.Columns.Add(new DataColumn("SP", typeof(int)));
            for (int s = 1; s <= 12; s++)
            {
                for (int i = 1; i <= 1; i++)
                {
                    DataRow row = dt.NewRow();
                    row["S"] = s.ToString();
                    row["X"] = "数值";
                    row["Y"] = i * s;
                    row["Z"] = i * s;
                    row["VH"] = i * s + i;
                    row["VL"] = i * s - i;
                    row["VO"] = i * s - s;
                    row["VC"] = i * s + s;
                    row["SP"] = rd.Next(0, 5);
                    dt.Rows.Add(row);
                }
            }
            return dt;
        }

        public static System.Drawing.Color GetRandomColor()
        {
            return System.Drawing.Color.FromArgb(rd.Next(0, 256), rd.Next(0, 256), rd.Next(0, 256), rd.Next(0, 256));
        }
    }
}
