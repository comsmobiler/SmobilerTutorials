using Smobiler.Core;
using System;

namespace Smobiler.Tutorials.Devices
{
    partial class demoRK25 : Smobiler.Core.Controls.MobileForm
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
            this.label1 = new Smobiler.Core.Controls.Label();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.rK25Scanner1 = new Smobiler.Device.RK25Scanner();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "RK25";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.Text = "单次扫描";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(145, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 35);
            this.button2.Text = "连续扫描";
            this.button2.Press += new System.EventHandler(this.button2_Press);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(20, 112);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 35);
            this.button3.Text = "停止扫描";
            this.button3.Press += new System.EventHandler(this.button3_Press);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 35);
            this.label1.Text = "扫描结果";
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label2});
            this.panel1.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel1.Location = new System.Drawing.Point(0, 203);
            this.panel1.Name = "panel1";
            this.panel1.Scrollable = true;
            this.panel1.Size = new System.Drawing.Size(300, 226);
            // 
            // label2
            // 
            this.label2.Flex = 1;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 35);
            // 
            // rK25Scanner1
            // 
            this.rK25Scanner1.Name = "rK25Scanner1";
            this.rK25Scanner1.DataCaptured += new Smobiler.Device.RK25BarcodeScanEventHandler(this.rK25Scanner1_DataCaptured);
            this.rK25Scanner1.OnNotify += new Smobiler.Device.RK25BarcodeOnNotifyEventHandler(this.rK25Scanner1_OnNotify);
            // 
            // demoRK25
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.rK25Scanner1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.button1,
            this.button2,
            this.button3,
            this.label1,
            this.panel1});
            this.Name = "demoRK25";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Button button1;
        private Core.Controls.Button button2;
        private Core.Controls.Button button3;
        private Core.Controls.Label label1;
        private Core.Controls.Panel panel1;
        private Core.Controls.Label label2;
        private Device.RK25Scanner rK25Scanner1;
    }
}