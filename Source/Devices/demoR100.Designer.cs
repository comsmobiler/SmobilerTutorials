using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Devices
{
    partial class demoR100 : Smobiler.Core.Controls.MobileForm
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
            this.btnScan = new Smobiler.Core.Controls.Button();
            this.btnScanInstantly = new Smobiler.Core.Controls.Button();
            this.btnStopScan = new Smobiler.Core.Controls.Button();
            this.btnEnableTrigger = new Smobiler.Core.Controls.Button();
            this.btnDisableTrigger = new Smobiler.Core.Controls.Button();
            this.labData = new Smobiler.Core.Controls.Label();
            this.btnBindKeyDown = new Smobiler.Core.Controls.Button();
            this.btnUnbindKeyDown = new Smobiler.Core.Controls.Button();
            this.r100Scanner1 = new Smobiler.Device.R100Scanner();
            this.title1 = new Smobiler.Core.Controls.Title();
            this.label1 = new Smobiler.Core.Controls.Label();
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(94, 95);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(100, 30);
            this.btnScan.Text = "扫描";
            this.btnScan.Press += new System.EventHandler(this.btnScan_Press);
            // 
            // btnScanInstantly
            // 
            this.btnScanInstantly.Location = new System.Drawing.Point(94, 138);
            this.btnScanInstantly.Name = "btnScanInstantly";
            this.btnScanInstantly.Size = new System.Drawing.Size(100, 30);
            this.btnScanInstantly.Text = "持续扫描";
            this.btnScanInstantly.Press += new System.EventHandler(this.btnScanInstantly_Press);
            // 
            // btnStopScan
            // 
            this.btnStopScan.Location = new System.Drawing.Point(94, 180);
            this.btnStopScan.Name = "btnStopScan";
            this.btnStopScan.Size = new System.Drawing.Size(100, 30);
            this.btnStopScan.Text = "停止扫描";
            this.btnStopScan.Press += new System.EventHandler(this.btnStopScan_Press);
            // 
            // btnEnableTrigger
            // 
            this.btnEnableTrigger.Location = new System.Drawing.Point(94, 224);
            this.btnEnableTrigger.Name = "btnEnableTrigger";
            this.btnEnableTrigger.Size = new System.Drawing.Size(100, 30);
            this.btnEnableTrigger.Text = "注册键盘";
            this.btnEnableTrigger.Press += new System.EventHandler(this.btnEnableTrigger_Press);
            // 
            // btnDisableTrigger
            // 
            this.btnDisableTrigger.Location = new System.Drawing.Point(94, 267);
            this.btnDisableTrigger.Name = "btnDisableTrigger";
            this.btnDisableTrigger.Size = new System.Drawing.Size(100, 30);
            this.btnDisableTrigger.Text = "不注册键盘";
            this.btnDisableTrigger.Press += new System.EventHandler(this.btnDisableTrigger_Press);
            // 
            // labData
            // 
            this.labData.Location = new System.Drawing.Point(0, 400);
            this.labData.Name = "labData";
            this.labData.Size = new System.Drawing.Size(300, 35);
            // 
            // btnBindKeyDown
            // 
            this.btnBindKeyDown.Location = new System.Drawing.Point(94, 316);
            this.btnBindKeyDown.Name = "btnBindKeyDown";
            this.btnBindKeyDown.Size = new System.Drawing.Size(100, 30);
            this.btnBindKeyDown.Text = "扫描键自定义";
            this.btnBindKeyDown.Press += new System.EventHandler(this.btnBindKeyDown_Press);
            // 
            // btnUnbindKeyDown
            // 
            this.btnUnbindKeyDown.Location = new System.Drawing.Point(94, 359);
            this.btnUnbindKeyDown.Name = "btnUnbindKeyDown";
            this.btnUnbindKeyDown.Size = new System.Drawing.Size(100, 30);
            this.btnUnbindKeyDown.Text = "扫描键不自定义";
            this.btnUnbindKeyDown.Press += new System.EventHandler(this.btnUnbindKeyDown_Press);
            // 
            // r100Scanner1
            // 
            this.r100Scanner1.Name = "r100Scanner1";
            this.r100Scanner1.DataCaptured += new Smobiler.Device.R100BarcodeScanEventHandler(this.barcode1_DataCaptured);
            this.r100Scanner1.OnNotify += new Smobiler.Device.R100BarcodeOnNotifyEventHandler(this.barcode1_OnNotify);
            this.r100Scanner1.KeyDown += new Smobiler.Device.R100ButtonEventHandler(this.barcode1_KeyDown);
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "R100";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 59);
            this.label1.Text = "使用R100Scanner插件，需要使用R100硬件\r\n";
            // 
            // demoR100
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.r100Scanner1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnScan,
            this.btnScanInstantly,
            this.btnStopScan,
            this.btnEnableTrigger,
            this.btnDisableTrigger,
            this.labData,
            this.btnBindKeyDown,
            this.btnUnbindKeyDown,
            this.title1,
            this.label1});
            this.Name = "demoR100";

        }
        #endregion

        private Core.Controls.Button btnScan;
        private Core.Controls.Button btnScanInstantly;
        private Core.Controls.Button btnStopScan;
        private Core.Controls.Button btnEnableTrigger;
        private Core.Controls.Button btnDisableTrigger;
        private Core.Controls.Label labData;
        private Core.Controls.Button btnBindKeyDown;
        private Core.Controls.Button btnUnbindKeyDown;
        private Device.R100Scanner r100Scanner1;
        private Core.Controls.Title title1;
        private Core.Controls.Label label1;
    }
}