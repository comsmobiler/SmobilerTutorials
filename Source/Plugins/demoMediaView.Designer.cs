using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Plugins
{
    partial class demoMediaView : Smobiler.Core.Controls.MobileForm
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
            this.mediaView1 = new Smobiler.Plugins.MediaView();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.button2 = new Smobiler.Core.Controls.Button();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "MediaView";
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
            this.mediaView1,
            this.label1,
            this.button1,
            this.button2});
            this.panel2.Location = new System.Drawing.Point(5, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 570);
            // 
            // labContent
            // 
            this.labContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labContent.FontSize = 15F;
            this.labContent.Location = new System.Drawing.Point(0, 26);
            this.labContent.Name = "labContent";
            this.labContent.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labContent.Size = new System.Drawing.Size(290, 72);
            this.labContent.Text = "AutoPlay设置是否自动播放\r\nRepeat设置是否循环播放\r\nUrl设置媒体源";
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
            this.labTitle.Text = "多媒体播放控件";
            // 
            // mediaView1
            // 
            this.mediaView1.Location = new System.Drawing.Point(0, 126);
            this.mediaView1.Name = "mediaView1";
            this.mediaView1.Size = new System.Drawing.Size(290, 238);
            this.mediaView1.StateChanged += new Smobiler.Plugins.MediaViewStateChangedEventHandler(this.mediaView1_StateChanged);
            // 
            // label1
            // 
            this.label1.FontSize = 15F;
            this.label1.Location = new System.Drawing.Point(0, 381);
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label1.Size = new System.Drawing.Size(290, 40);
            this.label1.Text = "StateChanged事件在视频状态改变后触发\r\n";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 409);
            this.button1.Margin = new Smobiler.Core.Controls.Margin(0F, 30F, 0F, 0F);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.Text = "跳转20s";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 409);
            this.button2.Margin = new Smobiler.Core.Controls.Margin(0F, 80F, 0F, 0F);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 35);
            this.button2.Text = "暂停/播放";
            this.button2.Press += new System.EventHandler(this.button2_Press);
            // 
            // demoMediaView
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel1});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Load += new System.EventHandler(this.demoMediaView_Load);
            this.Name = "demoMediaView";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Panel panel1;
        private Core.Controls.Panel panel2;
        private Core.Controls.Label labContent;
        private Core.Controls.Label labTitle;
        private Smobiler.Plugins.MediaView mediaView1;
        private Core.Controls.Label label1;
        private Core.Controls.Button button1;
        private Core.Controls.Button button2;
    }
}