using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoCalenderStrip : Smobiler.Core.Controls.MobileForm
    {
        public demoCalenderStrip() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void spinner1_ItemSelected(object sender, SpinnerItemSelectedEventArgs e)
        {
            switch (spinner1.Text)
            {

                case "DateNameColor":
                    calenderStrip1.DateNameColor = System.Drawing.Color.Black;
                     labContent.Text = "获取与设置非周末星期字体的颜色";
                    break;
                case "DateNumberColor":
                    calenderStrip1.DateNumberColor = System.Drawing.Color.Black;
                    labContent.Text = "获取与设置非周末日期字体的颜色";
                    break;
                case "DaySelectionColor":
                    calenderStrip1.DaySelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(176)))), ((int)(((byte)(249)))));
                    labContent.Text = "获取与设置选中日期样式颜色";
                    break;
                case "DaySelectionType":
                    calenderStrip1.DaySelectionType = Smobiler.Plugins.DaySelectionType.Background;
                    labContent.Text = "获取与设置选中日期样式";
                    break;
                case "DisabledDateNameColor":
                    calenderStrip1.DisabledDateNameColor = System.Drawing.Color.WhiteSmoke;
                    labContent.Text = "获取与设置不能选择星期字体的颜色";
                    break;
                case "DisabledDateNumberColor":
                    calenderStrip1.DisabledDateNumberColor = System.Drawing.Color.WhiteSmoke;
                    labContent.Text = "获取与设置不能选择日期字体的颜色";
                    break;
                case "HighlightDateNameColor":
                    calenderStrip1.HighlightDateNameColor = System.Drawing.Color.AliceBlue;
                    labContent.Text = "获取与设置选中星期字体的颜色";
                    break;
                case "HighlightDateNumberColor": 
                    calenderStrip1.HighlightDateNumberColor = System.Drawing.Color.AliceBlue;
                    labContent.Text = "获取与设置选中日期字体的颜色";
                    break;
                case "IconColor":
                    calenderStrip1.IconColor = System.Drawing.Color.SkyBlue;
                    labContent.Text = "获取与设置左右选择按钮的颜色";
                    break;
                case "MaxDate":
                    calenderStrip1.MaxDate = DateTime.Now;
                    labContent.Text = "获取与设置能选择的最大日期";
                    break;
                case "MinDate":
                    calenderStrip1.MinDate = DateTime.Now.AddDays(-7);
                    labContent.Text = "获取与设置能选择的最小日期";
                    break;
                case "ShowDate":
                    calenderStrip1.ShowDate = !calenderStrip1.ShowDate;
                    labContent.Text = "获取与设置是否显示日期和星期";
                    break;
                case "ShowDayName":
                    calenderStrip1.ShowDayName = !calenderStrip1.ShowDayName;
                    labContent.Text = "获取与设置是否显示星期行"; 
                    break;
                case "ShowDayNumber":
                    calenderStrip1.ShowDayNumber = !calenderStrip1.ShowDayNumber;
                    labContent.Text = "获取与设置是否显示日期行";
                    break;
                case "ShowMonth":
                    calenderStrip1.ShowMonth = !calenderStrip1.ShowMonth;
                    labContent.Text = "获取与设置是否显示月份行";
                    break;
            }
        }
    }
}