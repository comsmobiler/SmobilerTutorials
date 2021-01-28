using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Plugins
{
    partial class demoProgressView : Smobiler.Core.Controls.MobileForm
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
            this.progressView1 = new Smobiler.Plugins.ProgressView();
            this.progressView2 = new Smobiler.Plugins.ProgressView();
            this.progressView3 = new Smobiler.Plugins.ProgressView();
            this.progressView4 = new Smobiler.Plugins.ProgressView();
            this.progressView5 = new Smobiler.Plugins.ProgressView();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.progressView6 = new Smobiler.Plugins.ProgressView();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.progressView7 = new Smobiler.Plugins.ProgressView();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "ProgressView";
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
            this.progressView1,
            this.progressView2,
            this.progressView3,
            this.progressView4,
            this.progressView5,
            this.label1,
            this.progressView6,
            this.label2,
            this.progressView7});
            this.panel2.Location = new System.Drawing.Point(5, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 674);
            // 
            // labContent
            // 
            this.labContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labContent.FontSize = 15F;
            this.labContent.Location = new System.Drawing.Point(0, 26);
            this.labContent.Name = "labContent";
            this.labContent.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labContent.Size = new System.Drawing.Size(290, 110);
            this.labContent.Text = "Progress属性设置进度值，\r\nType属性获取和设置控件的样式(circle：圆环形；pie：圆饼行；bar：条形；circlesnail：特殊圆环形；ve" +
    "rticalbar：竖向进度条)";
            this.labContent.VerticalAlignment = Smobiler.Core.Controls.VerticalAlignment.Top;
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
            this.labTitle.Text = "不同样式的进度条";
            // 
            // progressView1
            // 
            this.progressView1.Location = new System.Drawing.Point(25, 159);
            this.progressView1.Name = "progressView1";
            this.progressView1.Progress = 0.12F;
            this.progressView1.Size = new System.Drawing.Size(100, 40);
            this.progressView1.SnailColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))))};
            // 
            // progressView2
            // 
            this.progressView2.Location = new System.Drawing.Point(167, 159);
            this.progressView2.Name = "progressView2";
            this.progressView2.Progress = 0.52F;
            this.progressView2.Size = new System.Drawing.Size(100, 40);
            this.progressView2.SnailColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))))};
            this.progressView2.Type = Smobiler.Plugins.ProgressViewType.pie;
            // 
            // progressView3
            // 
            this.progressView3.Location = new System.Drawing.Point(25, 218);
            this.progressView3.Name = "progressView3";
            this.progressView3.Progress = 0.35F;
            this.progressView3.Size = new System.Drawing.Size(100, 40);
            this.progressView3.SnailColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))))};
            this.progressView3.Type = Smobiler.Plugins.ProgressViewType.bar;
            // 
            // progressView4
            // 
            this.progressView4.Location = new System.Drawing.Point(167, 218);
            this.progressView4.Name = "progressView4";
            this.progressView4.Progress = 0.78F;
            this.progressView4.Size = new System.Drawing.Size(100, 40);
            this.progressView4.SnailColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))))};
            this.progressView4.Type = Smobiler.Plugins.ProgressViewType.circlesnail;
            // 
            // progressView5
            // 
            this.progressView5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.progressView5.Location = new System.Drawing.Point(47, 278);
            this.progressView5.Name = "progressView5";
            this.progressView5.Progress = 0.28F;
            this.progressView5.Size = new System.Drawing.Size(50, 108);
            this.progressView5.SnailColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))))};
            this.progressView5.Type = Smobiler.Plugins.ProgressViewType.verticalbar;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.FontSize = 15F;
            this.label1.Location = new System.Drawing.Point(0, 405);
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label1.Size = new System.Drawing.Size(290, 61);
            this.label1.Text = "Color 获取和设置progress选中填充部分颜色\r\nUnfilledColor获取和设置progress剩余未填充部分颜色";
            this.label1.VerticalAlignment = Smobiler.Core.Controls.VerticalAlignment.Top;
            // 
            // progressView6
            // 
            this.progressView6.Color = System.Drawing.Color.Tomato;
            this.progressView6.Location = new System.Drawing.Point(90, 483);
            this.progressView6.Name = "progressView6";
            this.progressView6.Progress = 0.12F;
            this.progressView6.Size = new System.Drawing.Size(100, 40);
            this.progressView6.SnailColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))))};
            this.progressView6.UnfilledColor = System.Drawing.Color.MistyRose;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.FontSize = 15F;
            this.label2.Location = new System.Drawing.Point(0, 536);
            this.label2.Name = "label2";
            this.label2.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label2.Size = new System.Drawing.Size(290, 48);
            this.label2.Text = "ShowText 设置是否显示文字，type = circle,时有效";
            this.label2.VerticalAlignment = Smobiler.Core.Controls.VerticalAlignment.Top;
            // 
            // progressView7
            // 
            this.progressView7.Location = new System.Drawing.Point(90, 612);
            this.progressView7.Name = "progressView7";
            this.progressView7.Progress = 0.12F;
            this.progressView7.ShowsText = true;
            this.progressView7.Size = new System.Drawing.Size(100, 40);
            this.progressView7.SnailColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))))};
            // 
            // demoProgressView
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel1});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Name = "demoProgressView";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Panel panel1;
        private Core.Controls.Panel panel2;
        private Core.Controls.Label labContent;
        private Core.Controls.Label labTitle;
        private Smobiler.Plugins.ProgressView progressView1;
        private Smobiler.Plugins.ProgressView progressView2;
        private Smobiler.Plugins.ProgressView progressView3;
        private Smobiler.Plugins.ProgressView progressView4;
        private Smobiler.Plugins.ProgressView progressView5;
        private Core.Controls.Label label1;
        private Smobiler.Plugins.ProgressView progressView6;
        private Core.Controls.Label label2;
        private Smobiler.Plugins.ProgressView progressView7;
    }
}