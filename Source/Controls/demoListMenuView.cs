using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Controls
{
    partial class demoListMenuView : Smobiler.Core.Controls.MobileForm
    {
        public demoListMenuView()
            : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void button1_Press(object sender, EventArgs e)
        {
            this.popList1.ShowDialog();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void demoListMenuView_Load(object sender, EventArgs e)
        {
            PopListGroup g1 = new PopListGroup();
            g1.AddListItem("Groups");
            g1.AddListItem("MenuGroupHeight");
            g1.AddListItem("MenuItemHeight");
            g1.AddListItem("ShowGroupTitle");
            g1.AddListItem("TextForeColor");
            g1.AddListItem("SubTextForeColor");
            g1.AddListItem("GridLines");
            g1.AddListItem("GridLinesColor");
            g1.AddListItem("GroupBackColor");
            g1.AddListItem("GroupFontSize");
            g1.AddListItem("GroupForeColor");
            g1.AddListItem("ItemActionPress");
            g1.AddListItem("ItemPress");
            popList1.Groups.Add(g1);
        }
        Random rd = new Random();
        private void popList1_Selected(object sender, EventArgs e)
        {
            switch (popList1.Selections[0].Text)
            {
                case "Groups":
                    this.listMenuView1.Groups.Clear();
                    for (int i = 0; i < 5; i++)
                    {
                        AddGroup();
                    }
                    labContent.Text = "设置菜单组集合";
                    break;
                case "MenuGroupHeight":
                    this.listMenuView1.MenuGroupHeight += 5;
                    labContent.Text = "设置菜单组高度";
                    break;
                case "MenuItemHeight":
                    this.listMenuView1.MenuItemHeight += 5;
                    labContent.Text = "设置菜单行项高度";
                    break;
                case "ShowGroupTitle":
                    this.listMenuView1.ShowGroupTitle = true;
                    labContent.Text = "是否显示菜单组";
                    break;
                case "TextForeColor":
                    this.listMenuView1.TextForeColor = System.Drawing.Color.FromArgb(rd.Next(0, 255), rd.Next(0, 255), rd.Next(0, 255), rd.Next(0, 255));
                    labContent.Text = "设置菜单项文本颜色";
                    break;
                case "SubTextForeColor":
                    this.listMenuView1.SubTextForeColor = System.Drawing.Color.FromArgb(rd.Next(0, 255), rd.Next(0, 255), rd.Next(0, 255), rd.Next(0, 255));
                    labContent.Text = "设置菜单项的子文本颜色";
                    break;
                case "GridLines":
                    this.listMenuView1.GridLines = true;
                  labContent.Text = "是否显示网格线";
                    break;
                case "GridLinesColor":
                    this.listMenuView1.GridLinesColor = System.Drawing.Color.FromArgb(rd.Next(0, 255), rd.Next(0, 255), rd.Next(0, 255), rd.Next(0, 255));
                    labContent.Text = "网格线颜色";
                    break;
                case "GroupBackColor":
                    this.listMenuView1.GroupBackColor = System.Drawing.Color.FromArgb(rd.Next(0, 255), rd.Next(0, 255), rd.Next(0, 255), rd.Next(0, 255));
                    labContent.Text = "设置菜单组标题背景色";
                    break;
                case "GroupFontSize":
                    this.listMenuView1.GroupFontSize += 2;
                  labContent.Text = "设置菜单组标题字体大小";
                    break;
                case "GroupForeColor":
                    this.listMenuView1.GroupForeColor = System.Drawing.Color.FromArgb(rd.Next(0, 255), rd.Next(0, 255), rd.Next(0, 255), rd.Next(0, 255));
                    labContent.Text = "设置菜单组标题字体颜色";
                    break;
                case "ItemActionPress":
                    labContent.Text = "在菜单项按钮点击时发生";
                    break;
                case "ItemPress":
                    labContent.Text = "在菜单项点击时发生";
                    break;
            }
        }
        private void AddGroup()
        {
            ListMenuViewGroup mvg = new ListMenuViewGroup();
            mvg.Title = DateTime.Now.ToString();
            for (int j = 0; j < 5; j++)
                mvg.Items.Add(new ListMenuViewItem("logon", DateTime.Now.ToString(), j.ToString(), "+"));
            this.listMenuView1.Groups.Add(mvg);
        }

        private void listMenuView1_ItemActionPress(object sender, ListMenuViewItemPressEventArgs e)
        {
            MessageBox.Show("ItemActionPress " + e.Item.Content);
        }

        private void listMenuView1_ItemPress(object sender, ListMenuViewItemPressEventArgs e)
        {
            MessageBox.Show("ItemPress " + e.Item.Content);
        }
    }
    
}