using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Components
{
    partial class demoGPS : Smobiler.Core.Controls.MobileForm
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
            this.panel5 = new Smobiler.Core.Controls.Panel();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.labContent = new Smobiler.Core.Controls.Label();
            this.labTitle = new Smobiler.Core.Controls.Label();
            this.btnGetGps = new Smobiler.Core.Controls.Button();
            this.btnGetGpsAsyn = new Smobiler.Core.Controls.Button();
            this.lb_Longitude = new Smobiler.Core.Controls.Label();
            this.lb_Latitude = new Smobiler.Core.Controls.Label();
            this.lb_Location = new Smobiler.Core.Controls.Label();
            this.GCJ02_Longitude = new Smobiler.Core.Controls.Label();
            this.GCJ02_Latitude = new Smobiler.Core.Controls.Label();
            this.BD09_Longitude = new Smobiler.Core.Controls.Label();
            this.BD09_Latitude = new Smobiler.Core.Controls.Label();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.gps1 = new Smobiler.Core.Controls.GPS();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "GPS";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // panel5
            // 
            this.panel5.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1,
            this.panel2});
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 30);
            this.panel5.Name = "panel5";
            this.panel5.Scrollable = true;
            this.panel5.Size = new System.Drawing.Size(300, 970);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel1.BorderColor = System.Drawing.Color.Silver;
            this.panel1.BorderRadius = 5;
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.labContent,
            this.labTitle,
            this.btnGetGps,
            this.btnGetGpsAsyn,
            this.lb_Longitude,
            this.lb_Latitude,
            this.lb_Location,
            this.GCJ02_Longitude,
            this.GCJ02_Latitude,
            this.BD09_Longitude,
            this.BD09_Latitude});
            this.panel1.Location = new System.Drawing.Point(5, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 361);
            // 
            // labContent
            // 
            this.labContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labContent.FontSize = 14F;
            this.labContent.Location = new System.Drawing.Point(0, 26);
            this.labContent.Name = "labContent";
            this.labContent.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labContent.Size = new System.Drawing.Size(290, 54);
            this.labContent.Text = "GPS组件，可获取地址坐标，AmapKey设置高德开放平台Key(web服务)，RequestLocation该值指示是否请求地理位置信息。";
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
            this.labTitle.Text = "GPS组件";
            // 
            // btnGetGps
            // 
            this.btnGetGps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(229)))), ((int)(((byte)(99)))));
            this.btnGetGps.Location = new System.Drawing.Point(23, 99);
            this.btnGetGps.Name = "btnGetGps";
            this.btnGetGps.Size = new System.Drawing.Size(100, 30);
            this.btnGetGps.Text = "获取GPS位置";
            this.btnGetGps.Press += new System.EventHandler(this.btnGetGps_Press);
            // 
            // btnGetGpsAsyn
            // 
            this.btnGetGpsAsyn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(78)))));
            this.btnGetGpsAsyn.Location = new System.Drawing.Point(165, 99);
            this.btnGetGpsAsyn.Name = "btnGetGpsAsyn";
            this.btnGetGpsAsyn.Size = new System.Drawing.Size(100, 30);
            this.btnGetGpsAsyn.Text = "同步获取GPS位置";
            this.btnGetGpsAsyn.Press += new System.EventHandler(this.btnGetGpsAsyn_Press);
            // 
            // lb_Longitude
            // 
            this.lb_Longitude.Location = new System.Drawing.Point(23, 151);
            this.lb_Longitude.Name = "lb_Longitude";
            this.lb_Longitude.Size = new System.Drawing.Size(100, 35);
            this.lb_Longitude.Text = "Longitude";
            // 
            // lb_Latitude
            // 
            this.lb_Latitude.Location = new System.Drawing.Point(165, 151);
            this.lb_Latitude.Name = "lb_Latitude";
            this.lb_Latitude.Size = new System.Drawing.Size(100, 35);
            this.lb_Latitude.Text = "Latitude";
            // 
            // lb_Location
            // 
            this.lb_Location.Location = new System.Drawing.Point(23, 303);
            this.lb_Location.Name = "lb_Location";
            this.lb_Location.Size = new System.Drawing.Size(242, 35);
            this.lb_Location.Text = "Location";
            // 
            // GCJ02_Longitude
            // 
            this.GCJ02_Longitude.Location = new System.Drawing.Point(23, 251);
            this.GCJ02_Longitude.Name = "GCJ02_Longitude";
            this.GCJ02_Longitude.Size = new System.Drawing.Size(100, 35);
            this.GCJ02_Longitude.Text = "GCJ02_Longitude";
            // 
            // GCJ02_Latitude
            // 
            this.GCJ02_Latitude.Location = new System.Drawing.Point(165, 251);
            this.GCJ02_Latitude.Name = "GCJ02_Latitude";
            this.GCJ02_Latitude.Size = new System.Drawing.Size(100, 35);
            this.GCJ02_Latitude.Text = "GCJ02_Latitude";
            // 
            // BD09_Longitude
            // 
            this.BD09_Longitude.Location = new System.Drawing.Point(23, 201);
            this.BD09_Longitude.Name = "BD09_Longitude";
            this.BD09_Longitude.Size = new System.Drawing.Size(100, 35);
            this.BD09_Longitude.Text = "BD09_Longitude";
            // 
            // BD09_Latitude
            // 
            this.BD09_Latitude.Location = new System.Drawing.Point(165, 201);
            this.BD09_Latitude.Name = "BD09_Latitude";
            this.BD09_Latitude.Size = new System.Drawing.Size(100, 35);
            this.BD09_Latitude.Text = "BD09_Latitude";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel2.BorderColor = System.Drawing.Color.Silver;
            this.panel2.BorderRadius = 5;
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label5,
            this.label6});
            this.panel2.Location = new System.Drawing.Point(5, 383);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 85);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.FontSize = 15F;
            this.label5.Location = new System.Drawing.Point(0, 26);
            this.label5.Name = "label5";
            this.label5.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label5.Size = new System.Drawing.Size(290, 54);
            this.label5.Text = "PlaceSearch方法可地点搜索";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label6.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.label6.FontSize = 16F;
            this.label6.Name = "label6";
            this.label6.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label6.Size = new System.Drawing.Size(290, 26);
            this.label6.Text = "GPS地点搜索";
            // 
            // gps1
            // 
            this.gps1.Name = "gps1";
            this.gps1.GotLocation += new Smobiler.Core.Controls.GpsCallBackHandler(this.gps1_GotLocation);
            // 
            // demoGPS
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.gps1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel5});
            this.Size = new System.Drawing.Size(300, 1000);
            this.Name = "demoGPS";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Panel panel5;
        private Core.Controls.Panel panel1;
        private Core.Controls.Label labContent;
        private Core.Controls.Label labTitle;
        private Core.Controls.GPS gps1;
        private Core.Controls.Button btnGetGps;
        private Core.Controls.Button btnGetGpsAsyn;
        private Core.Controls.Label lb_Longitude;
        private Core.Controls.Label lb_Latitude;
        private Core.Controls.Label lb_Location;
        private Core.Controls.Panel panel2;
        private Core.Controls.Label label5;
        private Core.Controls.Label label6;
        private Core.Controls.Label GCJ02_Longitude;
        private Core.Controls.Label GCJ02_Latitude;
        private Core.Controls.Label BD09_Longitude;
        private Core.Controls.Label BD09_Latitude;
    }
}