using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Devices
{
    partial class demoR2100 : Smobiler.Core.Controls.MobileForm
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
            this.btnBarcodescan = new Smobiler.Core.Controls.Button();
            this.btnBarcodescanstop = new Smobiler.Core.Controls.Button();
            this.btnBarcodeIsMulti = new Smobiler.Core.Controls.Button();
            this.btnEnableTrigger = new Smobiler.Core.Controls.Button();
            this.btnDisableTrigger = new Smobiler.Core.Controls.Button();
            this.btnRFIDscan = new Smobiler.Core.Controls.Button();
            this.btnRFIDscanstop = new Smobiler.Core.Controls.Button();
            this.btnRFIDIsMulti = new Smobiler.Core.Controls.Button();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.btnsetRfidPower = new Smobiler.Core.Controls.Button();
            this.btngetRfidPower = new Smobiler.Core.Controls.Button();
            this.textBox1 = new Smobiler.Core.Controls.TextBox();
            this.btnBindKeyDown = new Smobiler.Core.Controls.Button();
            this.btnUnBindKeyDown = new Smobiler.Core.Controls.Button();
            this.btnRFIDType = new Smobiler.Core.Controls.Button();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.r2100Scanner1 = new Smobiler.Device.R2100Scanner();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "R2100";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // btnBarcodescan
            // 
            this.btnBarcodescan.Location = new System.Drawing.Point(28, 181);
            this.btnBarcodescan.Name = "btnBarcodescan";
            this.btnBarcodescan.Size = new System.Drawing.Size(100, 30);
            this.btnBarcodescan.Text = "Barcode扫描";
            this.btnBarcodescan.Press += new System.EventHandler(this.btnBarcodescan_Press);
            // 
            // btnBarcodescanstop
            // 
            this.btnBarcodescanstop.Location = new System.Drawing.Point(28, 232);
            this.btnBarcodescanstop.Name = "btnBarcodescanstop";
            this.btnBarcodescanstop.Size = new System.Drawing.Size(100, 30);
            this.btnBarcodescanstop.Text = "关闭Barcode扫描";
            this.btnBarcodescanstop.Press += new System.EventHandler(this.btnBarcodescanstop_Press);
            // 
            // btnBarcodeIsMulti
            // 
            this.btnBarcodeIsMulti.Location = new System.Drawing.Point(28, 281);
            this.btnBarcodeIsMulti.Name = "btnBarcodeIsMulti";
            this.btnBarcodeIsMulti.Size = new System.Drawing.Size(100, 30);
            this.btnBarcodeIsMulti.Text = "是否开启连续扫描";
            this.btnBarcodeIsMulti.Press += new System.EventHandler(this.btnBarcodeIsMulti_Press);
            // 
            // btnEnableTrigger
            // 
            this.btnEnableTrigger.Location = new System.Drawing.Point(28, 330);
            this.btnEnableTrigger.Name = "btnEnableTrigger";
            this.btnEnableTrigger.Size = new System.Drawing.Size(100, 30);
            this.btnEnableTrigger.Text = "启用扫描键";
            this.btnEnableTrigger.Press += new System.EventHandler(this.btnEnableTrigger_Press);
            // 
            // btnDisableTrigger
            // 
            this.btnDisableTrigger.Location = new System.Drawing.Point(28, 375);
            this.btnDisableTrigger.Name = "btnDisableTrigger";
            this.btnDisableTrigger.Size = new System.Drawing.Size(100, 30);
            this.btnDisableTrigger.Text = "禁用扫描键";
            this.btnDisableTrigger.Press += new System.EventHandler(this.btnDisableTrigger_Press);
            // 
            // btnRFIDscan
            // 
            this.btnRFIDscan.Location = new System.Drawing.Point(163, 181);
            this.btnRFIDscan.Name = "btnRFIDscan";
            this.btnRFIDscan.Size = new System.Drawing.Size(100, 30);
            this.btnRFIDscan.Text = "RFID扫描";
            this.btnRFIDscan.Press += new System.EventHandler(this.btnRFIDscan_Press);
            // 
            // btnRFIDscanstop
            // 
            this.btnRFIDscanstop.Location = new System.Drawing.Point(163, 232);
            this.btnRFIDscanstop.Name = "btnRFIDscanstop";
            this.btnRFIDscanstop.Size = new System.Drawing.Size(100, 30);
            this.btnRFIDscanstop.Text = "关闭RFID扫描";
            this.btnRFIDscanstop.Press += new System.EventHandler(this.btnRFIDscanstop_Press);
            // 
            // btnRFIDIsMulti
            // 
            this.btnRFIDIsMulti.Location = new System.Drawing.Point(163, 281);
            this.btnRFIDIsMulti.Name = "btnRFIDIsMulti";
            this.btnRFIDIsMulti.Size = new System.Drawing.Size(100, 30);
            this.btnRFIDIsMulti.Text = "是否开始多标签模式";
            this.btnRFIDIsMulti.Press += new System.EventHandler(this.btnRFIDIsMulti_Press);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(28, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 35);
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(28, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 35);
            this.label2.Text = "label2";
            // 
            // btnsetRfidPower
            // 
            this.btnsetRfidPower.Location = new System.Drawing.Point(28, 448);
            this.btnsetRfidPower.Name = "btnsetRfidPower";
            this.btnsetRfidPower.Size = new System.Drawing.Size(100, 30);
            this.btnsetRfidPower.Text = "设置读写标签功率";
            this.btnsetRfidPower.Press += new System.EventHandler(this.btnsetRfidPower_Press);
            // 
            // btngetRfidPower
            // 
            this.btngetRfidPower.Location = new System.Drawing.Point(163, 448);
            this.btngetRfidPower.Name = "btngetRfidPower";
            this.btngetRfidPower.Size = new System.Drawing.Size(100, 30);
            this.btngetRfidPower.Text = "获取读写标签功率";
            this.btngetRfidPower.Press += new System.EventHandler(this.btngetRfidPower_Press);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 405);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 35);
            this.textBox1.WaterMarkText = "设置标签读写功率";
            // 
            // btnBindKeyDown
            // 
            this.btnBindKeyDown.Location = new System.Drawing.Point(163, 330);
            this.btnBindKeyDown.Name = "btnBindKeyDown";
            this.btnBindKeyDown.Size = new System.Drawing.Size(100, 30);
            this.btnBindKeyDown.Text = "扫描键自定义";
            this.btnBindKeyDown.Press += new System.EventHandler(this.btnBindKeyDown_Press);
            // 
            // btnUnBindKeyDown
            // 
            this.btnUnBindKeyDown.Location = new System.Drawing.Point(163, 375);
            this.btnUnBindKeyDown.Name = "btnUnBindKeyDown";
            this.btnUnBindKeyDown.Size = new System.Drawing.Size(100, 30);
            this.btnUnBindKeyDown.Text = "扫描键不自定义";
            this.btnUnBindKeyDown.Press += new System.EventHandler(this.btnUnBindKeyDown_Press);
            // 
            // btnRFIDType
            // 
            this.btnRFIDType.Location = new System.Drawing.Point(163, 410);
            this.btnRFIDType.Name = "btnRFIDType";
            this.btnRFIDType.Size = new System.Drawing.Size(100, 30);
            this.btnRFIDType.Text = "RFIDType";
            this.btnRFIDType.Press += new System.EventHandler(this.btnRFIDType_Press);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 59);
            this.label3.Text = "使用R2100Scanner插件，需要使用R2100硬件\r\n";
            // 
            // r2100Scanner1
            // 
            this.r2100Scanner1.Name = "r2100Scanner1";
            this.r2100Scanner1.BarcodeDataCaptured += new Smobiler.Device.R2100BarcodeScanEventHandler(this.r2100Scanner1_BarcodeDataCaptured);
            this.r2100Scanner1.RFIDDataCaptured += new Smobiler.Device.R2100RFIDScanEventHandler(this.r2100Scanner1_RFIDDataCaptured);
            this.r2100Scanner1.OnNotify += new Smobiler.Device.R2100ScannerOnNotifyEventHandler(this.r2100Scanner1_OnNotify_1);
            this.r2100Scanner1.KeyDown += new Smobiler.Device.R2100ButtonEventHandler(this.r2100Scanner1_KeyDown);
            // 
            // demoR2100
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.r2100Scanner1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.btnBarcodescan,
            this.btnBarcodescanstop,
            this.btnBarcodeIsMulti,
            this.btnEnableTrigger,
            this.btnDisableTrigger,
            this.btnRFIDscan,
            this.btnRFIDscanstop,
            this.btnRFIDIsMulti,
            this.label1,
            this.label2,
            this.btnsetRfidPower,
            this.btngetRfidPower,
            this.textBox1,
            this.btnBindKeyDown,
            this.btnUnBindKeyDown,
            this.btnRFIDType,
            this.label3});
            this.Name = "demoR2100";

        }
        #endregion
        private Core.Controls.Title title1;
        private Core.Controls.Button btnBarcodescan;
        private Core.Controls.Button btnBarcodescanstop;
        private Core.Controls.Button btnBarcodeIsMulti;
        private Core.Controls.Button btnEnableTrigger;
        private Core.Controls.Button btnDisableTrigger;
        private Core.Controls.Button btnRFIDscan;
        private Core.Controls.Button btnRFIDscanstop;
        private Core.Controls.Button btnRFIDIsMulti;
        private Core.Controls.Label label1;
        private Core.Controls.Label label2;
        private Core.Controls.Button btnsetRfidPower;
        private Core.Controls.Button btngetRfidPower;
        private Core.Controls.TextBox textBox1;
        private Core.Controls.Button btnBindKeyDown;
        private Core.Controls.Button btnUnBindKeyDown;
        private Core.Controls.Button btnRFIDType;
        private Core.Controls.Label label3;
        private Device.R2100Scanner r2100Scanner1;
    }
}