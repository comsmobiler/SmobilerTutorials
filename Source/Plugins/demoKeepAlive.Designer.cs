using Smobiler.Core;
using System;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoKeepAlive : Smobiler.Core.Controls.MobileForm
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
            this.button1 = new Smobiler.Core.Controls.Button();
            this.button2 = new Smobiler.Core.Controls.Button();
            this.button3 = new Smobiler.Core.Controls.Button();
            this.button4 = new Smobiler.Core.Controls.Button();
            this.button5 = new Smobiler.Core.Controls.Button();
            this.button6 = new Smobiler.Core.Controls.Button();
            this.button7 = new Smobiler.Core.Controls.Button();
            this.button8 = new Smobiler.Core.Controls.Button();
            this.button9 = new Smobiler.Core.Controls.Button();
            this.labLocation = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.labLatitude = new Smobiler.Core.Controls.Label();
            this.label = new Smobiler.Core.Controls.Label();
            this.labLongitude = new Smobiler.Core.Controls.Label();
            this.time = new Smobiler.Core.Controls.Label();
            this.labTime = new Smobiler.Core.Controls.Label();
            this.keepAlive1 = new Smobiler.Plugins.KeepAlive.KeepAlive();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "KeepAlive";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 35);
            this.button1.Text = "权限通知是否开启";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(159, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 35);
            this.button2.Text = "跳转开启通知页";
            this.button2.Press += new System.EventHandler(this.button2_Press);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(19, 100);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 35);
            this.button3.Text = "开启状态栏常驻通知";
            this.button3.Press += new System.EventHandler(this.button3_Press);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(159, 100);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 35);
            this.button4.Text = "关闭状态栏常驻通知";
            this.button4.Press += new System.EventHandler(this.button4_Press);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(19, 143);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 35);
            this.button5.Text = "app是否开启后台运行";
            this.button5.Press += new System.EventHandler(this.button5_Press);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(159, 143);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 35);
            this.button6.Text = "开启手机厂商应用管家自启管理";
            this.button6.Press += new System.EventHandler(this.button6_Press);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(19, 194);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(120, 35);
            this.button7.Text = "app申请开启后台运行";
            this.button7.Press += new System.EventHandler(this.button7_Press);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(19, 243);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(120, 35);
            this.button8.Text = "StartLocationUpdate";
            this.button8.Press += new System.EventHandler(this.button8_Press);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(159, 243);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(120, 35);
            this.button9.Text = "StopLocationUpdate   ";
            this.button9.Press += new System.EventHandler(this.button9_Press);
            // 
            // labLocation
            // 
            this.labLocation.Border = new Smobiler.Core.Controls.Border(1F);
            this.labLocation.Location = new System.Drawing.Point(19, 418);
            this.labLocation.Name = "labLocation";
            this.labLocation.Size = new System.Drawing.Size(120, 29);
            // 
            // label2
            // 
            this.label2.Border = new Smobiler.Core.Controls.Border(1F);
            this.label2.Location = new System.Drawing.Point(19, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 29);
            this.label2.Text = "Longitude";
            // 
            // label3
            // 
            this.label3.Border = new Smobiler.Core.Controls.Border(1F);
            this.label3.Location = new System.Drawing.Point(159, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 29);
            this.label3.Text = "Latitude";
            // 
            // labLatitude
            // 
            this.labLatitude.Border = new Smobiler.Core.Controls.Border(1F);
            this.labLatitude.Location = new System.Drawing.Point(159, 333);
            this.labLatitude.Name = "labLatitude";
            this.labLatitude.Size = new System.Drawing.Size(120, 29);
            this.labLatitude.Text = "0";
            // 
            // label
            // 
            this.label.Border = new Smobiler.Core.Controls.Border(1F);
            this.label.Location = new System.Drawing.Point(19, 374);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(120, 29);
            this.label.Text = "Location";
            // 
            // labLongitude
            // 
            this.labLongitude.Border = new Smobiler.Core.Controls.Border(1F);
            this.labLongitude.Location = new System.Drawing.Point(19, 333);
            this.labLongitude.Name = "labLongitude";
            this.labLongitude.Size = new System.Drawing.Size(120, 29);
            this.labLongitude.Text = "0";
            // 
            // time
            // 
            this.time.Border = new Smobiler.Core.Controls.Border(1F);
            this.time.Location = new System.Drawing.Point(159, 374);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(120, 29);
            this.time.Text = "当前时间";
            // 
            // labTime
            // 
            this.labTime.Border = new Smobiler.Core.Controls.Border(1F);
            this.labTime.Location = new System.Drawing.Point(159, 418);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(120, 29);
            this.labTime.Text = "2021/12/28 15:32:54";
            // 
            // keepAlive1
            // 
            this.keepAlive1.Name = "keepAlive1";
            // 
            // demoKeepAlive
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.keepAlive1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.button1,
            this.button2,
            this.button3,
            this.button4,
            this.button5,
            this.button6,
            this.button7,
            this.button8,
            this.button9,
            this.labLocation,
            this.label2,
            this.label3,
            this.labLatitude,
            this.label,
            this.labLongitude,
            this.time,
            this.labTime});
            this.Name = "demoKeepAlive";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Button button1;
        private Core.Controls.Button button2;
        private Core.Controls.Button button3;
        private Core.Controls.Button button4;
        private Core.Controls.Button button5;
        private Core.Controls.Button button6;
        private Core.Controls.Button button7;
        private Core.Controls.Button button8;
        private Core.Controls.Button button9;
        private Core.Controls.Label labLocation;
        private Core.Controls.Label label2;
        private Core.Controls.Label label3;
        private Core.Controls.Label labLatitude;
        private Core.Controls.Label label;
        private Core.Controls.Label labLongitude;
        private Core.Controls.Label time;
        private Core.Controls.Label labTime;
        private Smobiler.Plugins.KeepAlive.KeepAlive keepAlive1;
    }
}