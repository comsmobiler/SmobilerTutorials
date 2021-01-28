using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Components
{
    partial class demoSwipeView : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm
        //It can be modified using the SmobilerForm.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.title1 = new Smobiler.Core.Controls.Title();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.labContent = new Smobiler.Core.Controls.Label();
            this.labTitle = new Smobiler.Core.Controls.Label();
            this.swipeView1 = new Smobiler.Core.Controls.SwipeView();
            this.swipeView2 = new Smobiler.Core.Controls.SwipeView();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.listView1 = new Smobiler.Core.Controls.ListView();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "SwipeView";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel2});
            this.panel1.Flex = 1;
            this.panel1.Name = "panel1";
            this.panel1.Scrollable = true;
            this.panel1.Size = new System.Drawing.Size(0, 100);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel2.BorderColor = System.Drawing.Color.Silver;
            this.panel2.BorderRadius = 5;
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.labContent,
            this.labTitle,
            this.swipeView1,
            this.swipeView2,
            this.label3,
            this.listView1});
            this.panel2.Location = new System.Drawing.Point(5, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 729);
            // 
            // labContent
            // 
            this.labContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labContent.FontSize = 15F;
            this.labContent.Location = new System.Drawing.Point(0, 26);
            this.labContent.Name = "labContent";
            this.labContent.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labContent.Size = new System.Drawing.Size(290, 54);
            this.labContent.Text = "LeftControlName左侧滑模板名称\r\nRightControlName右侧滑模板名称";
            // 
            // labTitle
            // 
            this.labTitle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labTitle.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.labTitle.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.labTitle.FontSize = 16F;
            this.labTitle.Name = "labTitle";
            this.labTitle.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labTitle.Size = new System.Drawing.Size(290, 26);
            this.labTitle.Text = "侧滑控件";
            // 
            // swipeView1
            // 
            this.swipeView1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1});
            this.swipeView1.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.swipeView1.LeftControlName = "swipeViewTemplate";
            this.swipeView1.Location = new System.Drawing.Point(44, 121);
            this.swipeView1.Name = "swipeView1";
            this.swipeView1.Size = new System.Drawing.Size(200, 40);
            this.swipeView1.ActionNotification += new Smobiler.Core.Controls.SwipeViewActionNotificationEventHandler(this.swipeView1_ActionNotification);
            // 
            // swipeView2
            // 
            this.swipeView2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label2});
            this.swipeView2.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.swipeView2.Location = new System.Drawing.Point(44, 195);
            this.swipeView2.Name = "swipeView2";
            this.swipeView2.RightControlName = "swipeViewTemplate";
            this.swipeView2.Size = new System.Drawing.Size(200, 40);
            this.swipeView2.ActionNotification += new Smobiler.Core.Controls.SwipeViewActionNotificationEventHandler(this.swipeView1_ActionNotification);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 40);
            this.label1.Text = "向右滑动";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.AliceBlue;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 39);
            this.label2.Text = "向左滑动";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.FontSize = 15F;
            this.label3.Location = new System.Drawing.Point(0, 269);
            this.label3.Name = "label3";
            this.label3.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label3.Size = new System.Drawing.Size(290, 35);
            this.label3.Text = "和lisvtew组合使用，实现侧滑删除";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(44, 334);
            this.listView1.Name = "listView1";
            this.listView1.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.listView1.Size = new System.Drawing.Size(200, 269);
            this.listView1.RowBind += new Smobiler.Core.Controls.ListViewTemplateBindEventHandler(this.listView1_RowBind);
            // 
            // demoSwipeView
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel1});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Size = new System.Drawing.Size(300, 1500);
            this.Load += new System.EventHandler(this.demoSwipeView_Load);
            this.Name = "demoSwipeView";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Panel panel1;
        private Core.Controls.Panel panel2;
        private Core.Controls.Label labContent;
        private Core.Controls.Label labTitle;
        private Core.Controls.SwipeView swipeView1;
        private Core.Controls.Label label1;
        private Core.Controls.SwipeView swipeView2;
        private Core.Controls.Label label2;
        private Core.Controls.Label label3;
        private Core.Controls.ListView listView1;
    }
}