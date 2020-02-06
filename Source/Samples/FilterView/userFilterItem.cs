using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;

namespace Smobiler.Tutorials.Samples
{
    [System.ComponentModel.ToolboxItem(true)]
    partial class userFilterItem : Smobiler.Core.Controls.MobileUserControl
    {
        private void userFilterItem_Load(object sender, EventArgs e)
        {
            this.listView1.TemplateControl = new userFilterItemTemplate();
            this.listView2.TemplateControl = new userFilterItemTemplate();            
        }

        public void DataBind(DataTable dt1,DataTable dt2)
        {
            lv1SelectedRow = null;
            lv2SelectedRow = null;

            this.listView1.DataSource = dt1;
            this.listView1.DataBind();
            this.listView2.DataSource = dt2;
            this.listView2.DataBind();
        }

        private ListViewRow lv1SelectedRow;
        private ListViewRow lv2SelectedRow;

        /// <summary>
        /// 用于在ListView中选择时，设置当前选择的值。
        /// </summary>
        /// <param name="row"></param>
        public void SetSelected(ListViewRow row)
        {
            if (listView1.Rows.Contains(row) == true)
            {
                if (lv1SelectedRow != null) ((userFilterItemTemplate)lv1SelectedRow.Control).setUnSelected();
                lv1SelectedRow = row;
            }
            else if (listView2.Rows.Contains(row) == true)
            {
                if (lv2SelectedRow != null) ((userFilterItemTemplate)lv2SelectedRow.Control).setUnSelected();
                lv2SelectedRow = row;
            }
        }
    }
}