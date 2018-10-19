using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Devices
{
    partial class demoTC25 : Smobiler.Core.Controls.MobileForm
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
            this.btnsetTriggerType = new Smobiler.Core.Controls.Button();
            this.btnscan = new Smobiler.Core.Controls.Button();
            this.btnstop = new Smobiler.Core.Controls.Button();
            this.btnstatus = new Smobiler.Core.Controls.Button();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.title1 = new Smobiler.Core.Controls.Title();
            this.tC25Scanner1 = new Smobiler.Device.TC25Scanner();
            this.label3 = new Smobiler.Core.Controls.Label();
            // 
            // btnsetTriggerType
            // 
            this.btnsetTriggerType.Location = new System.Drawing.Point(80, 171);
            this.btnsetTriggerType.Name = "btnsetTriggerType";
            this.btnsetTriggerType.Size = new System.Drawing.Size(130, 37);
            this.btnsetTriggerType.Text = "设置扫描方式 0";
            this.btnsetTriggerType.Press += new System.EventHandler(this.btnsetTriggerType_Press);
            // 
            // btnscan
            // 
            this.btnscan.Location = new System.Drawing.Point(80, 221);
            this.btnscan.Name = "btnscan";
            this.btnscan.Size = new System.Drawing.Size(130, 33);
            this.btnscan.Text = "开启扫描";
            this.btnscan.Press += new System.EventHandler(this.btnscan_Press);
            // 
            // btnstop
            // 
            this.btnstop.Location = new System.Drawing.Point(80, 278);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(130, 32);
            this.btnstop.Text = "关闭扫描";
            this.btnstop.Press += new System.EventHandler(this.btnstop_Press);
            // 
            // btnstatus
            // 
            this.btnstatus.Location = new System.Drawing.Point(80, 326);
            this.btnstatus.Name = "btnstatus";
            this.btnstatus.Size = new System.Drawing.Size(130, 30);
            this.btnstatus.Text = "获取当前扫描设备状态";
            this.btnstatus.Press += new System.EventHandler(this.btnstatus_Press);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(23, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 51);
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(45, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 71);
            this.label2.Text = "label2";
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "TC25";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // tC25Scanner1
            // 
            this.tC25Scanner1.Name = "tC25Scanner1";
            this.tC25Scanner1.DataCaptured += new Smobiler.Device.TC25BarcodeScanEventHandler(this.tC25Scanner1_DataCaptured);
            this.tC25Scanner1.OnNotify += new Smobiler.Device.TC25BarcodeOnNotifyEventHandler(this.tC25Scanner1_OnNotify);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 59);
            this.label3.Text = "使用tC25Scanner插件，需要使用TC25硬件\r\n";
            // 
            // demoTC25
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.tC25Scanner1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnsetTriggerType,
            this.btnscan,
            this.btnstop,
            this.btnstatus,
            this.label1,
            this.label2,
            this.title1,
            this.label3});
            this.Name = "demoTC25";

        }
        #endregion

        private Core.Controls.Button btnsetTriggerType;
        private Core.Controls.Button btnscan;
        private Core.Controls.Button btnstop;
        private Core.Controls.Button btnstatus;
        private Core.Controls.Label label1;
        private Core.Controls.Label label2;
        private Core.Controls.Title title1;
        private Device.TC25Scanner tC25Scanner1;
        private Core.Controls.Label label3;
    }
}