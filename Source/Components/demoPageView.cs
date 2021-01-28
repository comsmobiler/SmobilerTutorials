using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;

namespace Smobiler.Tutorials.Components
{
    partial class demoPageView : Smobiler.Core.Controls.MobileForm
    {
        public demoPageView()
            : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Press(object sender, EventArgs e)
        {
            this.popList1.ShowDialog();
        }

        private void popList1_Selected(object sender, EventArgs e)
        {

            switch (popList1.Selections[0].Text)
            {
                case "DataBind":
                    DataBind();
                    labContent.Text = "数据绑定";
                    break;
                case "AutoPlay":
                    pageView1.AutoPlay = false;
                    labContent.Text = "获取和设置一个值，该值指示是否自动轮播页面";
                    break;
                case "Interval":
                    pageView1.Interval = 2;
                    labContent.Text = "获取或设置自动轮播间隔时间（以秒为单位）";
                    break;
                case "IsLoop":
                    pageView1.IsLoop = true;
                    labContent.Text = "获取和设置一个值，该值指示是否循环轮播页面。";
                    break;
                case "Locked":
                    pageView1.Locked = true;
                    labContent.Text = "获取和设置一个值，该值指示是否锁定页面并且切换页面。";
                    break;
                case "ShowIndicator":
                    pageView1.ShowIndicator = false;
                    labContent.Text = "获取和设置一个值，该值指示是否显示界面的圆点。";
                    break;
                case "Vertical":
                    pageView1.Vertical = true;
                    labContent.Text = "获取和设置一个值，该值指示页面是否垂直滚动。";
                    break;
                case "Add":
                    this.pageView1.NewPage();
                    labContent.Text = "添加项";
                    break;
                case "Remove":
                    if (this.pageView1.Pages.Count > 0)
                        this.pageView1.Pages.RemoveAt(0);
                    labContent.Text = "删除项";
                    break;
                case "Clear":
                    this.pageView1.Pages.Clear();
                    labContent.Text = "清空";
                    break;
                case "NewPage":
                    pageTable = new DataTable();
                    pageTable.Columns.Add("image");
                    pageTable.Rows.Add("1");
                    this.pageView1.UpdatePage(this.pageView1.Pages[0], pageTable);
                    labContent.Text = "根据数据源添加";
                    break;
            }
        }

        private void demoPageView_Load(object sender, EventArgs e)
        {
            PopListGroup g1 = new PopListGroup();
            g1.AddListItem("DataBind");
            g1.AddListItem("AutoPlay");
            g1.AddListItem("Interval");
            g1.AddListItem("IsLoop");
            g1.AddListItem("Locked");
            g1.AddListItem("ShowIndicator");
            g1.AddListItem("Vertical");
            g1.AddListItem("Add");
            g1.AddListItem("Remove");
            g1.AddListItem("Clear");
            g1.AddListItem("NewPage");
            popList1.Groups.Add(g1);
        }
        DataTable pageTable;
        private void DataBind()
        {
            pageTable = new DataTable();
            pageTable.Columns.Add("image");
            pageTable.Rows.Add("page1");
            pageTable.Rows.Add("page2");
            pageTable.Rows.Add("page3");
            if (pageTable.Rows.Count > 0)
            {
                pageView1.DataSource = pageTable;
                pageView1.DataBind();
            }
        }

        private void pageView1_PageIndexChanged(object sender, EventArgs e)
        {
            Toast(pageView1.PageIndex.ToString());
        }
    }
}