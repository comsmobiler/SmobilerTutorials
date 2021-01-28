using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Plugins
{
    partial class demoMapRoute : Smobiler.Core.Controls.MobileForm
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
            this.button1 = new Smobiler.Core.Controls.Button();
            this.button2 = new Smobiler.Core.Controls.Button();
            this.panel3 = new Smobiler.Core.Controls.Panel();
            this.mapRoute1 = new Smobiler.Plugins.MapRoute();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "MapRoute";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel2});
            this.panel1.Flex = 1;
            this.panel1.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
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
            this.button1,
            this.button2,
            this.panel3});
            this.panel2.Location = new System.Drawing.Point(5, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 329);
            // 
            // labContent
            // 
            this.labContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labContent.FontSize = 15F;
            this.labContent.Location = new System.Drawing.Point(0, 27);
            this.labContent.Name = "labContent";
            this.labContent.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labContent.Size = new System.Drawing.Size(290, 65);
            this.labContent.Text = "ResourceID，ResourcePath设置图片名称路径;\r\nArrowLength设置箭头长度；\r\nEnabl设置是否可滑动控件；\r\n\r\n";
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
            this.labTitle.Text = "路径控件";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.Text = "添加路径";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(149, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.Text = "清除";
            this.button2.Press += new System.EventHandler(this.button2_Press);
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.mapRoute1});
            this.panel3.Location = new System.Drawing.Point(45, 120);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(195, 113);
            // 
            // mapRoute1
            // 
            this.mapRoute1.BackColor = System.Drawing.Color.Transparent;
            this.mapRoute1.Name = "mapRoute1";
            this.mapRoute1.ResourceID = "logon";
            this.mapRoute1.Size = new System.Drawing.Size(195, 113);
            // 
            // demoMapRoute
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel1});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Name = "demoMapRoute";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Panel panel1;
        private Core.Controls.Panel panel2;
        private Core.Controls.Label labContent;
        private Core.Controls.Label labTitle;
        private Core.Controls.Button button1;
        private Core.Controls.Button button2;
        private Core.Controls.Panel panel3;
        private Smobiler.Plugins.MapRoute mapRoute1;
    }
}