using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Controls
{
    partial class demoPopList : Smobiler.Core.Controls.MobileForm
    {
        public demoPopList()
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

        private void demoPopList_Load(object sender, EventArgs e)
        {
            PopListGroup g1 = new PopListGroup();
            g1.AddListItem("Groups");
            g1.AddListItem("Show");
            g1.AddListItem("ShowDialog");
            g1.AddListItem("Multi-Show");
            g1.AddListItem("Multi-ShowDialog");
            g1.AddListItem("SingleSelectMode");
            g1.AddListItem("Selected事件");
            popList1.Groups.Add(g1);
        }

        private void popList1_Selected(object sender, EventArgs e)
        {
            switch (popList1.Selections[0].Text)
            {
                case "Groups":
                    PopListGroup g1 = new PopListGroup();
                    g1.TitleVisible = true;
                    g1.Title = "审批人";
                    for (int i = 1; i < 3; i++)
                    {
                        g1.AddListItem(i.ToString());
                    }
                    PopListGroup g2 = new PopListGroup();
                    g2.Title = "抄送人";
                    g2.TitleVisible = true;
                    for (int i = 1; i < 3; i++)
                    {
                        g2.AddListItem(i.ToString());
                    }

                    PopListItem popItem = new PopListItem();
                    popItem.Value = "USER_ID";
                    popItem.Text = "USER_ID";
                    g2.Items.Add(popItem);

                    this.popList2.Groups.Add(g1);
                    this.popList2.Groups.Add(g2);
                    labContent.Text = "选择组集合数据添加";
                    break;
                case "Show":
                    this.popList2.MultiSelect = false;
                    this.popList2.SingleSelectMode = true;
                    this.popList2.Show();
                    labContent.Text = "显示列表选择界面";
                    break;
                case "ShowDialog":
                    this.popList2.MultiSelect = false;
                    this.popList2.ShowDialog();
                    labContent.Text = "显示对话框列表选择界面";
                    break;
                case "Multi-Show":
                    this.popList2.MultiSelect = true;
                    this.popList2.Show();
                    labContent.Text = "设置多选来显示列表选择界面";
                    break;
                case "Multi-ShowDialog":
                    this.popList2.MultiSelect = true;
                    this.popList2.ShowDialog();
                    labContent.Text = "设置多选来显示对话框列表选择界面";
                    break;
                case "SingleSelectMode":
                    this.popList2.MultiSelect = false;
                    this.popList2.SingleSelectMode = false;
                    this.popList2.Show();
                    labContent.Text = "单选时可设置2种不同的选择模式，true时点击结束选择，false时点击完成按钮确认选择";
                    break;
                case "Selected事件":
                    labContent.Text = "Selected事件在Poplist选择完成时发生。";
                    break;
            }
        }
    }
}