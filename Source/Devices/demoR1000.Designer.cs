using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Devices
{
    partial class demoR1000 : Smobiler.Core.Controls.MobileForm
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
            this.btnBarcodescan = new Smobiler.Core.Controls.Button();
            this.btnBarcodescanstop = new Smobiler.Core.Controls.Button();
            this.btnBarcodeTimerScan = new Smobiler.Core.Controls.Button();
            this.btnEnableTrigger = new Smobiler.Core.Controls.Button();
            this.btnDisableTrigger = new Smobiler.Core.Controls.Button();
            this.btnRFIDscan = new Smobiler.Core.Controls.Button();
            this.btnRFIDscanstop = new Smobiler.Core.Controls.Button();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.btnsetRfidPower = new Smobiler.Core.Controls.Button();
            this.textBox1 = new Smobiler.Core.Controls.TextBox();
            this.btnBindKeyDown = new Smobiler.Core.Controls.Button();
            this.btnUnbindKeyDown = new Smobiler.Core.Controls.Button();
            this.btnRFIDType = new Smobiler.Core.Controls.Button();
            this.btnClearNumRfid = new Smobiler.Core.Controls.Button();
            this.title1 = new Smobiler.Core.Controls.Title();
            this.r1000Scanner1 = new Smobiler.Device.R1000Scanner();
            this.label3 = new Smobiler.Core.Controls.Label();
            // 
            // btnBarcodescan
            // 
            this.btnBarcodescan.Location = new System.Drawing.Point(32, 177);
            this.btnBarcodescan.Name = "btnBarcodescan";
            this.btnBarcodescan.Size = new System.Drawing.Size(100, 30);
            this.btnBarcodescan.Text = "Barcode扫描";
            this.btnBarcodescan.Press += new System.EventHandler(this.btnBarcodescan_Press);
            // 
            // btnBarcodescanstop
            // 
            this.btnBarcodescanstop.Location = new System.Drawing.Point(32, 267);
            this.btnBarcodescanstop.Name = "btnBarcodescanstop";
            this.btnBarcodescanstop.Size = new System.Drawing.Size(100, 30);
            this.btnBarcodescanstop.Text = "关闭Barcode连续扫描";
            this.btnBarcodescanstop.Press += new System.EventHandler(this.btnBarcodescanstop_Press);
            // 
            // btnBarcodeTimerScan
            // 
            this.btnBarcodeTimerScan.Location = new System.Drawing.Point(32, 222);
            this.btnBarcodeTimerScan.Name = "btnBarcodeTimerScan";
            this.btnBarcodeTimerScan.Size = new System.Drawing.Size(100, 30);
            this.btnBarcodeTimerScan.Text = "Barcode连续扫描";
            this.btnBarcodeTimerScan.Press += new System.EventHandler(this.btnBarcodeTimerScan_Press);
            // 
            // btnEnableTrigger
            // 
            this.btnEnableTrigger.Location = new System.Drawing.Point(32, 314);
            this.btnEnableTrigger.Name = "btnEnableTrigger";
            this.btnEnableTrigger.Size = new System.Drawing.Size(100, 30);
            this.btnEnableTrigger.Text = "启用扫描键";
            this.btnEnableTrigger.Press += new System.EventHandler(this.btnEnableTrigger_Press);
            // 
            // btnDisableTrigger
            // 
            this.btnDisableTrigger.Location = new System.Drawing.Point(32, 357);
            this.btnDisableTrigger.Name = "btnDisableTrigger";
            this.btnDisableTrigger.Size = new System.Drawing.Size(100, 30);
            this.btnDisableTrigger.Text = "禁用扫描键";
            this.btnDisableTrigger.Press += new System.EventHandler(this.btnDisableTrigger_Press);
            // 
            // btnRFIDscan
            // 
            this.btnRFIDscan.Location = new System.Drawing.Point(167, 177);
            this.btnRFIDscan.Name = "btnRFIDscan";
            this.btnRFIDscan.Size = new System.Drawing.Size(100, 30);
            this.btnRFIDscan.Text = "RFID扫描";
            this.btnRFIDscan.Press += new System.EventHandler(this.btnRFIDscan_Press);
            // 
            // btnRFIDscanstop
            // 
            this.btnRFIDscanstop.Location = new System.Drawing.Point(167, 222);
            this.btnRFIDscanstop.Name = "btnRFIDscanstop";
            this.btnRFIDscanstop.Size = new System.Drawing.Size(100, 30);
            this.btnRFIDscanstop.Text = "关闭RFID扫描";
            this.btnRFIDscanstop.Press += new System.EventHandler(this.btnRFIDscanstop_Press);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(32, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 35);
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(32, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 35);
            this.label2.Text = "label2";
            // 
            // btnsetRfidPower
            // 
            this.btnsetRfidPower.Location = new System.Drawing.Point(167, 404);
            this.btnsetRfidPower.Name = "btnsetRfidPower";
            this.btnsetRfidPower.Size = new System.Drawing.Size(100, 30);
            this.btnsetRfidPower.Text = "设置读标签功率";
            this.btnsetRfidPower.Press += new System.EventHandler(this.btnsetRfidPower_Press);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 399);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 35);
            this.textBox1.WaterMarkText = "设置标签读写功率";
            // 
            // btnBindKeyDown
            // 
            this.btnBindKeyDown.Location = new System.Drawing.Point(167, 314);
            this.btnBindKeyDown.Name = "btnBindKeyDown";
            this.btnBindKeyDown.Size = new System.Drawing.Size(100, 30);
            this.btnBindKeyDown.Text = "扫描键自定义";
            this.btnBindKeyDown.Press += new System.EventHandler(this.btnBindKeyDown_Press);
            // 
            // btnUnbindKeyDown
            // 
            this.btnUnbindKeyDown.Location = new System.Drawing.Point(167, 357);
            this.btnUnbindKeyDown.Name = "btnUnbindKeyDown";
            this.btnUnbindKeyDown.Size = new System.Drawing.Size(100, 30);
            this.btnUnbindKeyDown.Text = "扫描键不自定义";
            this.btnUnbindKeyDown.Press += new System.EventHandler(this.btnUnbindKeyDown_Press);
            // 
            // btnRFIDType
            // 
            this.btnRFIDType.Location = new System.Drawing.Point(167, 267);
            this.btnRFIDType.Name = "btnRFIDType";
            this.btnRFIDType.Size = new System.Drawing.Size(100, 30);
            this.btnRFIDType.Text = "RFIDType";
            this.btnRFIDType.Press += new System.EventHandler(this.btnRFIDType_Press);
            // 
            // btnClearNumRfid
            // 
            this.btnClearNumRfid.Location = new System.Drawing.Point(32, 450);
            this.btnClearNumRfid.Name = "btnClearNumRfid";
            this.btnClearNumRfid.Size = new System.Drawing.Size(100, 30);
            this.btnClearNumRfid.Text = "ClearNumRfid";
            this.btnClearNumRfid.Press += new System.EventHandler(this.button1_Press);
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "R1000";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // r1000Scanner1
            // 
            this.r1000Scanner1.Name = "r1000Scanner1";
            this.r1000Scanner1.BarcodeDataCaptured += new Smobiler.Device.R1000BarcodeScanEventHandler(this.r1000Scanner1_BarcodeDataCaptured);
            this.r1000Scanner1.RFIDDataCaptured += new Smobiler.Device.R1000RFIDScanEventHandler(this.r1000Scanner1_RFIDDataCaptured);
            this.r1000Scanner1.OnNotify += new Smobiler.Device.R1000ScannerOnNotifyEventHandler(this.r1000Scanner1_OnNotify);
            this.r1000Scanner1.KeyDown += new Smobiler.Device.R1000ButtonEventHandler(this.r1000Scanner1_KeyDown);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 59);
            this.label3.Text = "使用R1000Scanner插件，需要使用R1000硬件\r\n";
            // 
            // demoR1000
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.r1000Scanner1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnBarcodescan,
            this.btnBarcodescanstop,
            this.btnBarcodeTimerScan,
            this.btnEnableTrigger,
            this.btnDisableTrigger,
            this.btnRFIDscan,
            this.btnRFIDscanstop,
            this.label1,
            this.label2,
            this.btnsetRfidPower,
            this.textBox1,
            this.btnBindKeyDown,
            this.btnUnbindKeyDown,
            this.btnRFIDType,
            this.btnClearNumRfid,
            this.title1,
            this.label3});
            this.Name = "demoR1000";

        }
        #endregion
        private Core.Controls.Button btnBarcodescan;
        private Core.Controls.Button btnBarcodescanstop;
        private Core.Controls.Button btnBarcodeTimerScan;
        private Core.Controls.Button btnEnableTrigger;
        private Core.Controls.Button btnDisableTrigger;
        private Core.Controls.Button btnRFIDscan;
        private Core.Controls.Button btnRFIDscanstop;
        private Core.Controls.Label label1;
        private Core.Controls.Label label2;
        private Core.Controls.Button btnsetRfidPower;
        private Core.Controls.TextBox textBox1;
        private Core.Controls.Button btnBindKeyDown;
        private Core.Controls.Button btnUnbindKeyDown;
        private Core.Controls.Button btnRFIDType;
        private Core.Controls.Button btnClearNumRfid;
        private Core.Controls.Title title1;
        private Device.R1000Scanner r1000Scanner1;
        private Core.Controls.Label label3;
    }
}