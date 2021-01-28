using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Controls
{
    partial class demoAlbumView : Smobiler.Core.Controls.MobileForm
    {
        public demoAlbumView()
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

        private void demoAlbumView_Load(object sender, EventArgs e)
        {
            PopListGroup g1 = new PopListGroup();
            g1.AddListItem("Items");
            g1.AddListItem("AlbumItemHight");
            g1.AddListItem("ColumnNum");
            g1.AddListItem("GridLines");
            g1.AddListItem("TitleHeight");
            g1.AddListItem("DeletePress事件");
            popList1.Groups.Add(g1);
        }

        private void popList1_Selected(object sender, EventArgs e)
        {
            switch (popList1.Selections[0].Text)
            {
                case "Items":
                    this.albumView1.Items.Add(new AlbumViewItem("设计师.png"));
                    this.albumView1.Items.Add(new AlbumViewItem("拟定合同.png"));
                    this.albumView1.Items.Add(new AlbumViewItem("搜索.png"));
                    this.albumView1.Items.Add(new AlbumViewItem("咨询.png"));
                    this.albumView1.Items.Add(new AlbumViewItem("方案.png"));
                    labContent.Text = "相册数据添加";
                    break;
                case "AlbumItemHight":
                    albumView1.AlbumItemHight -=10;
                    this.albumView1.Items.Refresh();
                    labContent.Text = "设置相册图片行高度";
                    break;
                case "ColumnNum":
                    albumView1.ColumnNum+= 1;
                    labContent.Text = "设置每行显示相片列数";
                    break;
                case "GridLines":
                    albumView1.GridLines= true;
                    albumView1.GridLinesColor = System.Drawing.Color.Black;
                    this.albumView1.Items.Refresh();
                    labContent.Text = "设置是否显示网格线、网格线颜色";
                    break;
                case "TitleHeight":
                    albumView1.TitleHeight += 5;
                    labContent.Text = "设置浏览相册界面Title高度";
                    break;
                case "DeletePress事件":
                    labContent.Text = "在删除按钮点击时发生";
                    break;
            }
        }

        private void albumView1_DeletePress(object sender, AlbumViewItemDeleteEventArgs e)
        {
            Toast("已删除此图片");
        }
    }
}