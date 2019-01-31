using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Plugins
{
    partial class demoMarqueeLabel : Smobiler.Core.Controls.MobileForm
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
            this.marqueeLabel1 = new Smobiler.Plugins.MarqueeLabel();
            this.spinner1 = new Smobiler.Core.Controls.Spinner();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "MarqueeLabel";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel2});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(7, 42);
            this.panel1.Name = "panel1";
            this.panel1.Scrollable = true;
            this.panel1.Size = new System.Drawing.Size(300, 335);
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
            this.marqueeLabel1,
            this.spinner1});
            this.panel2.Location = new System.Drawing.Point(5, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 201);
            // 
            // labContent
            // 
            this.labContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labContent.Location = new System.Drawing.Point(0, 26);
            this.labContent.Name = "labContent";
            this.labContent.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labContent.Size = new System.Drawing.Size(290, 42);
            this.labContent.Text = "跑马灯效果文本，Text设置显示的文本，ScrollDurationt获取与设置文字轮播一页所消耗的时间";
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
            this.labTitle.Text = "MarqueeLabel";
            // 
            // marqueeLabel1
            // 
            this.marqueeLabel1.FontSize = 20F;
            this.marqueeLabel1.ForeColor = System.Drawing.Color.Red;
            this.marqueeLabel1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.marqueeLabel1.Italic = true;
            this.marqueeLabel1.Location = new System.Drawing.Point(2, 68);
            this.marqueeLabel1.Name = "marqueeLabel1";
            this.marqueeLabel1.NumberOfLines = 2;
            this.marqueeLabel1.Selectable = true;
            this.marqueeLabel1.Size = new System.Drawing.Size(288, 39);
            this.marqueeLabel1.Text = "Text获取与设置显示的文字 (若想添加组显示，文字中间添加空格)";
            this.marqueeLabel1.Underline = true;
            // 
            // spinner1
            // 
            this.spinner1.Items = new string[] {
        "FontSize - 13",
        "FontSize - 20",
        "ForeColor - Red",
        "ForeColor - Yellow",
        "HorizontalAlignment - Left",
        "HorizontalAlignment - Center",
        "HorizontalAlignment - Right",
        "NumberOfLines-2",
        "ScrollDurationt-30",
        "Selectable-true",
        "Text - CurrentDate",
        "UnderLine-true"};
            this.spinner1.Location = new System.Drawing.Point(1, 122);
            this.spinner1.Name = "spinner1";
            this.spinner1.Size = new System.Drawing.Size(289, 30);
            this.spinner1.Text = "设置属性";
            this.spinner1.ItemSelected += new System.EventHandler<Smobiler.Core.Controls.SpinnerItemSelectedEventArgs>(this.spinner1_ItemSelected);
            // 
            // demoMarqueeLabel
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel1});
            this.Name = "demoMarqueeLabel";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Panel panel1;
        private Core.Controls.Panel panel2;
        private Core.Controls.Label labContent;
        private Core.Controls.Label labTitle;
        private Smobiler.Plugins.MarqueeLabel marqueeLabel1;
        private Core.Controls.Spinner spinner1;
    }
}