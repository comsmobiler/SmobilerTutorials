using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Components
{
    partial class demoTabPageView : Smobiler.Core.Controls.MobileForm
    {
        public demoTabPageView()
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

        private void demoTabPageView_Load(object sender, EventArgs e)
        {
            PopListGroup g1 = new PopListGroup();
            g1.AddListItem("Initial");
            g1.AddListItem("ScrollEnabled");
            g1.AddListItem("PageIndex");
            g1.AddListItem("PageIndicator:Dot");
            g1.AddListItem("PageIndicator: Title");
            g1.AddListItem("TitleStyle");
            g1.AddListItem("Titles");
            g1.AddListItem("PageIndicator:None");
            g1.AddListItem("Add");
            g1.AddListItem("Remove");
            g1.AddListItem("Clear");
            popList1.Groups.Add(g1);
        }

        private void popList1_Selected(object sender, EventArgs e)
        {
            switch (popList1.Selections[0].Text)
            {
                case "Initial":
                    for (int i = 0; i < 2; i++)
                    {
                        this.tabPageView1.Controls.Add(new Smobiler.Tutorials.usercontrol.demoTabPageViewTemplate());
                    }
                    labContent.Text = "初始";
                    break;
                case "ScrollEnabled":
                    this.tabPageView1.ScrollEnabled=false;
                    labContent.Text = "设置不允许滚动";
                    break;
                case "PageIndex":
                    this.tabPageView1.PageIndex = 1;
                    labContent.Text = "切换Page页";
                    InitialTitle();
                    break;
                case "PageIndicator:Dot":
                    this.tabPageView1.PageIndicator = TabPageIndicator.Dot;
                    labContent.Text = "设置点状显示标识";
                    break;
                case "PageIndicator: Title":
                    this.tabPageView1.PageIndicator = TabPageIndicator.Title;
                    labContent.Text = "设置标题显示标识";
                    InitialTitle();
                    break;
                case "TitleStyle":
                    this.tabPageView1.TitleStyle= new TabPageViewTitleStyle(System.Drawing.Color.AliceBlue, System.Drawing.Color.Red, System.Drawing.Color.Black, 20, System.Drawing.Color.Tomato, 5);
                    labContent.Text = "设置Title的样式";
                    break;
                case "Titles":
                    this.tabPageView1.Titles = new string[] { "第一页","第二页"};
                    labContent.Text = "设置Title内容";
                    break;
                case "PageIndicator:None":
                    this.tabPageView1.PageIndicator = TabPageIndicator.None;
                    labContent.Text = "设置无显示标识";
                    break;
                case "Clear":
                    this.tabPageView1.Controls.Clear();
                    labContent.Text = "清空";
                    InitialTitle();
                    break;
                case "Add":
                    this.tabPageView1.Controls.Add(new Smobiler.Tutorials.usercontrol.demoTabPageViewTemplate());
                    labContent.Text = "添加";
                    InitialTitle();
                    break;
                case "Remove":
                    if (this.tabPageView1.Controls.Count > 0)
                    {
                        this.tabPageView1.Controls.RemoveAt(0);
                        InitialTitle();
                    }
                    labContent.Text = "删除";
                    break;   
            }
        }
             private void InitialTitle()
        {
            List<string> titleList = new List<string>();
            for (int i = 0; i < this.tabPageView1.Controls.Count; i++)
            {
                titleList.Add(i.ToString());
            }
            this.tabPageView1.Titles = titleList.ToArray();
        }
    
    }
}