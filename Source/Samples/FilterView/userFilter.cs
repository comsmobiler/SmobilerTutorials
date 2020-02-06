using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;

namespace Smobiler.Tutorials.Samples
{
    //[System.ComponentModel.ToolboxItem(true)]
    partial class userFilter : Smobiler.Core.Controls.MobileUserControl
    {

        private void userFilter_Load(object sender, EventArgs e)
        {
            Demo(new string[] { "附近", "和平区", "沈河区", "铁西区", "大东区", "皇姑区", "浑南区", "于洪区", "苏家屯区", "沈北新区", "近郊" }, new string[] { "附近", "1km", "3km", "5km", "10km", "全城" });
        }

        private void panel2_Press(object sender, EventArgs e)
        {

            //这个用于在点击时，修改选择的FontIcon的图标
            fontIcon1.ResourceID = "caret-down";
            fontIcon2.ResourceID = "caret-up";
            fontIcon3.ResourceID = "caret-up";

            Demo(new string[] { "附近", "和平区", "沈河区", "铁西区", "大东区", "皇姑区", "浑南区", "于洪区", "苏家屯区", "沈北新区", "近郊" }, new string[] { "附近", "1km", "3km", "5km", "10km", "全城" });
        }

        /// <summary>
        /// 对ListView进行数据绑定
        /// </summary>
        /// <param name="dt1Data"></param>
        /// <param name="dt2Data"></param>
        private void Demo(string[] dt1Data, string[] dt2Data)
        {
            DataTable dt1 = new DataTable();
            dt1.Columns.Add("LABEL", typeof(string));
            dt1Data.ToList<String>().ForEach((item) => { dt1.Rows.Add(item); });

            DataTable dt2 = new DataTable();
            dt2.Columns.Add("LABEL", typeof(string));
            dt2Data.ToList<String>().ForEach((item) => { dt2.Rows.Add(item); });

            this.userFilterItem1.DataBind(dt1, dt2);
        }

        private void panel3_Press(object sender, EventArgs e)
        {
            fontIcon1.ResourceID = "caret-up";
            fontIcon2.ResourceID = "caret-down";
            fontIcon3.ResourceID = "caret-up";

            Demo(new string[] { "附近", "和平区", "沈河区" }, new string[] { "附近", "1km" });
        }

        private void panel4_Press(object sender, EventArgs e)
        {
            fontIcon1.ResourceID = "caret-up";
            fontIcon2.ResourceID = "caret-up";
            fontIcon3.ResourceID = "caret-down";

            Demo(new string[] { "附近", "和平区", "沈河区", "铁西区" }, new string[] { "附近", "全城" });
        }

    }
}