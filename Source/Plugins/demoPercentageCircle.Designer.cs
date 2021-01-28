using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Plugins
{
    partial class demoPercentageCircle : Smobiler.Core.Controls.MobileForm
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
            this.spinner1 = new Smobiler.Core.Controls.Spinner();
            this.percentageCircle1 = new Smobiler.Plugins.PercentageCircle();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "PercentageCircle";
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
            this.spinner1,
            this.percentageCircle1});
            this.panel2.Location = new System.Drawing.Point(5, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 278);
            // 
            // labContent
            // 
            this.labContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labContent.FontSize = 15F;
            this.labContent.Location = new System.Drawing.Point(0, 96);
            this.labContent.Name = "labContent";
            this.labContent.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labContent.Size = new System.Drawing.Size(290, 59);
            this.labContent.Text = "CircleColor设置默认百分比进度颜色";
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
            this.labTitle.Text = "百分比圆形插件";
            // 
            // spinner1
            // 
            this.spinner1.Items = new string[] {
        "CircleColor",
        "CircleSize",
        "InnerColor",
        "Value",
        "ValueColor"};
            this.spinner1.Location = new System.Drawing.Point(25, 52);
            this.spinner1.Name = "spinner1";
            this.spinner1.Size = new System.Drawing.Size(243, 30);
            this.spinner1.Text = "CircleColor";
            this.spinner1.ItemSelected += new System.EventHandler<Smobiler.Core.Controls.SpinnerItemSelectedEventArgs>(this.spinner1_ItemSelected);
            // 
            // percentageCircle1
            // 
            this.percentageCircle1.ItemAlign = Smobiler.Core.Controls.LayoutItemAlign.Center;
            this.percentageCircle1.JustifyAlign = Smobiler.Core.Controls.LayoutJustifyAlign.Center;
            this.percentageCircle1.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.percentageCircle1.Location = new System.Drawing.Point(0, 170);
            this.percentageCircle1.Name = "percentageCircle1";
            this.percentageCircle1.Size = new System.Drawing.Size(300, 100);
            this.percentageCircle1.Value = 10;
            this.percentageCircle1.ValueColor = System.Drawing.Color.LightBlue;
            // 
            // demoPercentageCircle
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel1});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Name = "demoPercentageCircle";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Panel panel1;
        private Core.Controls.Panel panel2;
        private Core.Controls.Label labContent;
        private Core.Controls.Label labTitle;
        private Core.Controls.Spinner spinner1;
        private Smobiler.Plugins.PercentageCircle percentageCircle1;
    }
}