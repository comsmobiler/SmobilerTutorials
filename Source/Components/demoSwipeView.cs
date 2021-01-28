using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Components
{
    partial class demoSwipeView : Smobiler.Core.Controls.MobileForm
    {
        public demoSwipeView() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void swipeView1_ActionNotification(object sender, SwipeViewActionNotificationEventArgs e)
        {
            Toast("滑动");
        }

        private void demoSwipeView_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("lab");
            for(int i = 0; i < 5; i++)
            {
                dt.Rows.Add("item" + i.ToString());
            }
            listView1.TemplateControl = new swipeListviewTemplate();
            listView1.DataSource = dt;
            listView1.DataBind();
        }

        public void deleteRows(ListViewRow lr)
        {
            listView1.Rows.Remove(lr);
        }
        int flag = 0;
        private void listView1_RowBind(object sender, ListViewTemplateBindEventArgs e)
        {
            if (flag % 2 == 0)
            {
                ((MobileUserControl)e.Row.Control).BackColor = System.Drawing.Color.AliceBlue;
            }
            flag++;
        }
    }
}