using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Plugins
{
    partial class demoMapTrimView : Smobiler.Core.Controls.MobileForm
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
            this.title = new Smobiler.Core.Controls.Title();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.labTitle = new Smobiler.Core.Controls.Label();
            this.mapTrimView1 = new Smobiler.Plugins.MapTrimView();
            this.labContent = new Smobiler.Core.Controls.Label();
            this.gps1 = new Smobiler.Core.Controls.GPS();
            this.button1 = new Smobiler.Core.Controls.Button();
            // 
            // title
            // 
            this.title.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title.Name = "title";
            this.title.ResourceID = "angle-left";
            this.title.Size = new System.Drawing.Size(300, 30);
            this.title.Text = "MapTrimView";
            this.title.ImagePress += new System.EventHandler(this.title1_ImagePress);
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
            this.labTitle,
            this.mapTrimView1,
            this.labContent,
            this.button1});
            this.panel2.Location = new System.Drawing.Point(5, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 469);
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
            this.labTitle.Text = "地图微调控件";
            // 
            // mapTrimView1
            // 
            this.mapTrimView1.Location = new System.Drawing.Point(6, 109);
            this.mapTrimView1.Name = "mapTrimView1";
            this.mapTrimView1.Size = new System.Drawing.Size(284, 266);
            this.mapTrimView1.LocationChanged += new Smobiler.Plugins.MapTrimViewLocationChanged(this.mapTrimView1_LocationChanged);
            // 
            // labContent
            // 
            this.labContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labContent.FontSize = 15F;
            this.labContent.Location = new System.Drawing.Point(0, 26);
            this.labContent.Name = "labContent";
            this.labContent.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labContent.Size = new System.Drawing.Size(290, 63);
            this.labContent.Text = "GeoType设置坐标系类型\r\nLocationChanged事件在地图标签移动时触发";
            // 
            // gps1
            // 
            this.gps1.Name = "gps1";
            this.gps1.GotLocation += new Smobiler.Core.Controls.GpsCallBackHandler(this.gps1_GotLocation);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.Text = "定位";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // demoMapTrimView
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.gps1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title,
            this.panel1});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Name = "demoMapTrimView";

        }
        #endregion

        private Core.Controls.Title title;
        private Core.Controls.Panel panel1;
        private Core.Controls.Panel panel2;
        private Core.Controls.Label labTitle;
        private Smobiler.Plugins.MapTrimView mapTrimView1;
        private Core.Controls.Label labContent;
        private Core.Controls.GPS gps1;
        private Core.Controls.Button button1;
    }
}