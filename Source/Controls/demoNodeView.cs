using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Controls
{
    partial class demoNodeView : Smobiler.Core.Controls.MobileForm
    {
        public demoNodeView() : base()
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
            popList1.ShowDialog();
        }

        private void demoNodeView_Load(object sender, EventArgs e)
        {
            PopListGroup pg1 = new PopListGroup();
            pg1.AddListItem("添加节点");
            pg1.AddListItem("NodeViewItemPress");
            pg1.AddListItem("清除节点");
            popList1.Groups.Add(pg1);

        }

        private void popList1_Selected(object sender, EventArgs e)
        {
            switch (popList1.Selection.Text)
            {
                case "添加节点":
                    addNodes();
                    button1.Text = "添加节点";
                    break;
                case "清除节点":
                    nodeView1.Items.Clear();
                    button1.Text = "清除节点";
                    break;
                case "NodeViewItemPress":
                    button1.Text = "点击节点触发事件";
                    break;
            }
        }
        private void addNodes()
        {
            NodeViewItem nodeViewItem1 = new NodeViewItem() { Text="扫描员已经扫描",SubText=DateTime.Now.ToString(), IconColor = System.Drawing.Color.Gray, TextColor = System.Drawing.Color.DarkGray, SubTextColor = System.Drawing.Color.DarkGray };
            NodeViewItem nodeViewItem2 = new NodeViewItem() { Text = "您的订单已完成挑拣", SubText = DateTime.Now.ToString(), IconColor = System.Drawing.Color.Gray, TextColor = System.Drawing.Color.DarkGray, SubTextColor = System.Drawing.Color.DarkGray };
            NodeViewItem nodeViewItem3 = new NodeViewItem() { Text = "快递员已取货", SubText = DateTime.Now.ToString(), IconColor = System.Drawing.Color.Gray, TextColor = System.Drawing.Color.DarkGray,SubTextColor= System.Drawing.Color.DarkGray };
            NodeViewItem nodeViewItem4 = new NodeViewItem() { Text = "您的订单正在派送中", SubText = DateTime.Now.ToString(),IconColor=System.Drawing.Color.DodgerBlue };
            nodeView1.Items.AddRange(new NodeViewItem[] { nodeViewItem1, nodeViewItem2, nodeViewItem3, nodeViewItem4 });
        }

        private void nodeView1_NodeViewItemPress(object sender, NodeViewClickEventArgs e)
        {
            Toast("当前点击项Text：" + e.Item.Text);
        }
    }
}