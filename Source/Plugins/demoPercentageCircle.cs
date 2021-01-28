using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoPercentageCircle : Smobiler.Core.Controls.MobileForm
    {
        public demoPercentageCircle() : base()
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
                case "CircleColor":
                    percentageCircle1.CircleColor= System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(176)))), ((int)(((byte)(249)))));
                    labContent.Text = "CircleColor 设置默认百分比进度条颜色";
                    break;
                case "CircleSize":
                    percentageCircle1.CircleSize = 20;
                    labContent.Text = "CircleSize 设置百分比进度条宽度";
                    break;
                case "InnerColor":
                    percentageCircle1.InnerColor = this.percentageCircle1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(76)))), ((int)(((byte)(176)))), ((int)(((byte)(249)))));
                    labContent.Text = "Inner Color设置百分比进度内部颜色";
                    break;
                case "Value":
                    percentageCircle1.Value = 85;
                    labContent.Text = "Value 设置百分比进度条比值（0-100）";
                    break;
                case "ValueColor":
                    percentageCircle1.ValueColor = System.Drawing.Color.Navy;
                    labContent.Text = "ValueColor 设置默认百分比进度条值颜色";
                    break;

             }
        }
    }
}