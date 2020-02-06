using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;

namespace Smobiler.Tutorials.Samples
{
    partial class demoListViewRefresh : Smobiler.Core.Controls.MobileForm
    {

        private int dataCounter = 0;

        private void demoListViewRefresh_Load(object sender, EventArgs e)
        {
            this.listView1.TemplateControl = new ListViewTemplateControl();
            this.listView1.FooterControl = new ListViewFooterTemplateControl();
            BindListViewData();
        }

        /// <summary>
        /// 用于下拉刷新时，初始化数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView1_Refresh(object sender, EventArgs e)
        {
            this.listView1.Rows.Clear();
            //在下拉时，初始化起始数据为0
            dataCounter = 0;
            BindListViewData();
        }

        /// <summary>
        /// 用于ListView的 FooterControl 上的Button点击时加载数据
        /// </summary>
        internal void AddListViewData()
        {
            dataCounter += 1;
            BindListViewData();
        }

        /// <summary>
        /// 每一次加载10条数据
        /// </summary>
        private void BindListViewData()
        {
            DataTable dt= new DataTable("listview");
            dt.Columns.Add(new DataColumn("Label", typeof(string)));
            int dataStart = dataCounter * 10 + 1;
            int dataEnd = (dataCounter + 1) * 10;
            for (int i = dataStart; i <= dataEnd; i++)
            {
                dt.Rows.Add(i);
            }
            if (dataCounter == 0)
            {
                this.listView1.DataSource = dt;
                this.listView1.DataBind();
            }
            else
            {
                this.listView1.NewRow(dt, "");
            }
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    /// <summary>
    /// ListView的模板
    /// </summary>
    class ListViewTemplateControl:MobileUserControl
    {
        public ListViewTemplateControl():base()
        {
            this.Layout = LayoutPosition.Relative;
            this.Height = 30;
            this.Controls.Add(new Label() { DisplayMember = "Label", Flex = 1, Width = 0 });
        }
    }

    /// <summary>
    /// ListView下面加载数据的模板
    /// </summary>
    class ListViewFooterTemplateControl : MobileUserControl
    {
        private Button btnLoad;

        public ListViewFooterTemplateControl() : base()
        {
            this.Layout = LayoutPosition.Relative;
            this.Height = 30;
            btnLoad = new Button() { Text = "加载数据", Flex = 1, Width = 0 };
            btnLoad.Press += BtnLoad_Press;
            this.Controls.Add(btnLoad);
        }

        private void BtnLoad_Press(object sender, EventArgs e)
        {
            demoListViewRefresh form = this.Owner.Owner as demoListViewRefresh;
            form.AddListViewData();
        }
    }
}