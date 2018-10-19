using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Controls
{
    partial class demoIconMenuView : Smobiler.Core.Controls.MobileForm
    {
        public demoIconMenuView()
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

        private void demoIconMenuView_Load(object sender, EventArgs e)
        {
            PopListGroup g1 = new PopListGroup();
            g1.AddListItem("Groups");
            g1.AddListItem("ColumnNum");
            g1.AddListItem("ItemWidth");
            g1.AddListItem("MenuGroupHeight");
            g1.AddListItem("MenuItemHeight");
            g1.AddListItem("ShowGroupTitle");
            g1.AddListItem("ImageSizeMode");
            g1.AddListItem("FontSize");
            g1.AddListItem("ForeColor");
            g1.AddListItem("GridLines");
            g1.AddListItem("GridLinesColor");
            g1.AddListItem("GroupBackColor");
            g1.AddListItem("GroupFontSize");
            g1.AddListItem("GroupForeColor");
            g1.AddListItem("MessageWidth");
            g1.AddListItem("MessageBackColor");
            g1.AddListItem("MessageFontSize");
            g1.AddListItem("MessageForeColor");
            g1.AddListItem("ShowDialogMenu");
            g1.AddListItem("ItemPress");
            popList1.Groups.Add(g1);
        }
        Random rd = new Random();
        private void popList1_Selected(object sender, EventArgs e)
        {
            switch (popList1.Selections[0].Text)
            {
                case "Groups":
                    this.iconMenuView1.Groups.Clear();
                    for (int i = 0; i < 5; i++)
                    {
                        AddGroup();
                    }
                    labContent.Text = "设置菜单组集合";
                    break;
                case "ColumnNum":
                    this.iconMenuView1.ColumnNum += 1;
                    labContent.Text = "设置列数";
                    break;
                case "ItemWidth":
                    this.iconMenuView1.ItemWidth += 5;
                    labContent.Text = "设置图像空间大小";
                    break;
                case "MenuGroupHeight":
                    this.iconMenuView1.MenuGroupHeight += 5;
                    labContent.Text = "设置菜单组标题行高度";
                    break;
                case "MenuItemHeight":
                    this.iconMenuView1.MenuItemHeight += 5;
                    labContent.Text = "设置菜单项高度";
                    break;
                case "ShowGroupTitle":
                    this.iconMenuView1.ShowGroupTitle = true;
                    labContent.Text = "是否显示菜单组标题";
                    break;
                case "ImageSizeMode":
                    this.iconMenuView1.ImageSizeMode = ImageSizeMode.Default;
                    labContent.Text = "设置图片显示模式(Zoom->Default)";
                    break;
                case "FontSize":
                    this.iconMenuView1.FontSize += 2;
                    labContent.Text = "设置菜单项字体大小";
                    break;
                case "ForeColor":
                    this.iconMenuView1.ForeColor=System.Drawing.Color.FromArgb(rd.Next(0, 255), rd.Next(0, 255), rd.Next(0, 255), rd.Next(0, 255));
                    labContent.Text = "设置菜单项前景色";
                    break;
                case "GridLines":
                    this.iconMenuView1.GridLines = true;
                    labContent.Text = "是否显示网格线";
                    break;
                case "GridLinesColor":
                    this.iconMenuView1.GridLinesColor = System.Drawing.Color.FromArgb(rd.Next(0, 255), rd.Next(0, 255), rd.Next(0, 255), rd.Next(0, 255));
                    labContent.Text = "网格线颜色";
                    break;
                case "GroupBackColor":
                    this.iconMenuView1.GroupBackColor = System.Drawing.Color.FromArgb(rd.Next(0, 255), rd.Next(0, 255), rd.Next(0, 255), rd.Next(0, 255));
                    labContent.Text = "设置菜单组标题背景色";
                    break;
                case "GroupFontSize":
                    this.iconMenuView1.GroupFontSize += 2;
                    labContent.Text = "设置菜单组标题字体大小";
                    break;
                case "GroupForeColor":
                    this.iconMenuView1.GroupForeColor= System.Drawing.Color.FromArgb(rd.Next(0, 255), rd.Next(0, 255), rd.Next(0, 255), rd.Next(0, 255));
                    labContent.Text = "设置菜单组标题字体颜色";
                    break;
                case "MessageWidth":
                    this.iconMenuView1.MessageWidth += 1;
                    labContent.Text = "设置消息框大小";
                    break;
                case "MessageBackColor":
                    this.iconMenuView1.MessageBackColor= System.Drawing.Color.FromArgb(rd.Next(0, 255), rd.Next(0, 255), rd.Next(0, 255), rd.Next(0, 255));
                    labContent.Text = "设置消息框背景色";
                    break;
                case "MessageFontSize":
                    this.iconMenuView1.MessageFontSize += 2;
                  labContent.Text = "设置消息框中字体大小";
                    break;
                case "MessageForeColor":
                    this.iconMenuView1.MessageForeColor= System.Drawing.Color.FromArgb(rd.Next(0, 255), rd.Next(0, 255), rd.Next(0, 255), rd.Next(0, 255));
                    labContent.Text = "设置消息框中字体颜色";
                    break;
                case "ShowDialogMenu":
                    IconMenuViewGroup mvg = new IconMenuViewGroup(DateTime.Now.ToString());
                    for (int j = 0; j < 10; j++)
                        mvg.Items.Add(new IconMenuViewItem("logon", j.ToString()));
                    this.iconMenuView1.ShowDialogMenu(mvg);
                    labContent.Text = "显示二级菜单";
                    break;
                case "ItemPress":
                    labContent.Text = "在菜单项点击时发生";
                    break;
            }
        }
        private void AddGroup()
        {
            IconMenuViewGroup mvg = new IconMenuViewGroup(this.iconMenuView1.Groups.Count.ToString());
            for (int j = 0; j < 3; j++)
                mvg.Items.Add(new IconMenuViewItem("logon", j.ToString()));
            for (int j = 0; j < 2; j++)
                mvg.Items.Add(new IconMenuViewItem(j.ToString(),"logon", j.ToString(), j.ToString(), j.ToString()));
            this.iconMenuView1.Groups.Add(mvg);
        }

        private void iconMenuView1_ItemPress(object sender, IconMenuViewItemPressEventArgs e)
        {
            MessageBox.Show(e.Item.Text);
        }
    }
}