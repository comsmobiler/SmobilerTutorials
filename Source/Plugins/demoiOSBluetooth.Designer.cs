using Smobiler.Core;
using System;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoiOSBluetooth : Smobiler.Core.Controls.MobileForm
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
            this.button6 = new Smobiler.Core.Controls.Button();
            this.button4 = new Smobiler.Core.Controls.Button();
            this.button5 = new Smobiler.Core.Controls.Button();
            this.button3 = new Smobiler.Core.Controls.Button();
            this.button7 = new Smobiler.Core.Controls.Button();
            this.button8 = new Smobiler.Core.Controls.Button();
            this.button9 = new Smobiler.Core.Controls.Button();
            this.button10 = new Smobiler.Core.Controls.Button();
            this.button11 = new Smobiler.Core.Controls.Button();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.bluetooth1 = new Smobiler.Plugins.Bluetooth();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "iOSBluetooth";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(150, 133);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 35);
            this.button6.Text = "扫描并连接指定的低功耗蓝牙\n";
            this.button6.Press += new System.EventHandler(this.button6_Press);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(150, 70);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 35);
            this.button4.Text = "连接指定的低功耗蓝牙";
            this.button4.Press += new System.EventHandler(this.button4_Press);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(19, 133);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 35);
            this.button5.Text = "断开指定的低功耗蓝牙\n";
            this.button5.Press += new System.EventHandler(this.button5_Press);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(19, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 35);
            this.button3.Text = "查找低功耗蓝牙\n";
            this.button3.Press += new System.EventHandler(this.button3_Press);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(19, 192);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 35);
            this.button7.Text = "搜索指定已连接设备的服务";
            this.button7.Press += new System.EventHandler(this.button7_Press);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(150, 192);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 35);
            this.button8.Text = "打开蓝牙的订阅";
            this.button8.Press += new System.EventHandler(this.button8_Press);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(150, 250);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 35);
            this.button9.Text = "向蓝牙设备写数据\n";
            this.button9.Press += new System.EventHandler(this.button9_Press);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(19, 250);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(100, 35);
            this.button10.Text = "关闭蓝牙订阅";
            this.button10.Press += new System.EventHandler(this.button10_Press);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(19, 311);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(100, 35);
            this.button11.Text = "读蓝牙设备的数据\n";
            this.button11.Press += new System.EventHandler(this.button11_Press);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 35);
            this.button1.Text = "连接指定经典蓝牙";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // bluetooth1
            // 
            this.bluetooth1.Name = "bluetooth1";
            // 
            // demoiOSBluetooth
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.bluetooth1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.button6,
            this.button4,
            this.button5,
            this.button3,
            this.button7,
            this.button8,
            this.button9,
            this.button10,
            this.button11,
            this.button1});
            this.Name = "demoiOSBluetooth";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Button button6;
        private Core.Controls.Button button4;
        private Core.Controls.Button button5;
        private Core.Controls.Button button3;
        private Core.Controls.Button button7;
        private Core.Controls.Button button8;
        private Core.Controls.Button button9;
        private Core.Controls.Button button10;
        private Core.Controls.Button button11;
        private Core.Controls.Button button1;
        private Smobiler.Plugins.Bluetooth bluetooth1;
    }
}