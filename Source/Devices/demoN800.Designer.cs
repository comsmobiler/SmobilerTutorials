using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Devices
{
    partial class demoN800 : Smobiler.Core.Controls.MobileForm
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
            this.btnBarcodeScan = new Smobiler.Core.Controls.Button();
            this.btnBarcodeTimerScan = new Smobiler.Core.Controls.Button();
            this.btnBarcodeScanStop = new Smobiler.Core.Controls.Button();
            this.btnScanTimeout = new Smobiler.Core.Controls.Button();
            this.btnEnableTrigger = new Smobiler.Core.Controls.Button();
            this.btnDisableTrigger = new Smobiler.Core.Controls.Button();
            this.textBox1 = new Smobiler.Core.Controls.TextBox();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.setScanMode = new Smobiler.Core.Controls.Button();
            this.n800Scanner1 = new Smobiler.Device.N800Scanner();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "N800";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // btnBarcodeScan
            // 
            this.btnBarcodeScan.Location = new System.Drawing.Point(70, 68);
            this.btnBarcodeScan.Name = "btnBarcodeScan";
            this.btnBarcodeScan.Size = new System.Drawing.Size(154, 30);
            this.btnBarcodeScan.Text = "BarcodeScan";
            this.btnBarcodeScan.Press += new System.EventHandler(this.btnBarcodeScan_Press);
            // 
            // btnBarcodeTimerScan
            // 
            this.btnBarcodeTimerScan.Location = new System.Drawing.Point(70, 110);
            this.btnBarcodeTimerScan.Name = "btnBarcodeTimerScan";
            this.btnBarcodeTimerScan.Size = new System.Drawing.Size(154, 30);
            this.btnBarcodeTimerScan.Text = "BarcodeTimerScan";
            this.btnBarcodeTimerScan.Press += new System.EventHandler(this.btnBarcodeTimerScan_Press);
            // 
            // btnBarcodeScanStop
            // 
            this.btnBarcodeScanStop.Location = new System.Drawing.Point(70, 152);
            this.btnBarcodeScanStop.Name = "btnBarcodeScanStop";
            this.btnBarcodeScanStop.Size = new System.Drawing.Size(154, 30);
            this.btnBarcodeScanStop.Text = "BarcodeScanStop";
            this.btnBarcodeScanStop.Press += new System.EventHandler(this.btnBarcodeScanStop_Press);
            // 
            // btnScanTimeout
            // 
            this.btnScanTimeout.Location = new System.Drawing.Point(70, 234);
            this.btnScanTimeout.Name = "btnScanTimeout";
            this.btnScanTimeout.Size = new System.Drawing.Size(154, 30);
            this.btnScanTimeout.Text = "ScanTimeout";
            this.btnScanTimeout.Press += new System.EventHandler(this.btnScanTimeout_Press);
            // 
            // btnEnableTrigger
            // 
            this.btnEnableTrigger.Location = new System.Drawing.Point(70, 278);
            this.btnEnableTrigger.Name = "btnEnableTrigger";
            this.btnEnableTrigger.Size = new System.Drawing.Size(154, 30);
            this.btnEnableTrigger.Text = "EnableTrigger";
            this.btnEnableTrigger.Press += new System.EventHandler(this.btnEnableTrigger_Press);
            // 
            // btnDisableTrigger
            // 
            this.btnDisableTrigger.Location = new System.Drawing.Point(70, 320);
            this.btnDisableTrigger.Name = "btnDisableTrigger";
            this.btnDisableTrigger.Size = new System.Drawing.Size(154, 30);
            this.btnDisableTrigger.Text = "DisableTrigger";
            this.btnDisableTrigger.Press += new System.EventHandler(this.btnDisableTrigger_Press);
            // 
            // textBox1
            // 
            this.textBox1.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.textBox1.Location = new System.Drawing.Point(76, 196);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 35);
            this.textBox1.WaterMarkText = "设置扫描超时时间";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 35);
            this.label1.Text = "label1";
            // 
            // setScanMode
            // 
            this.setScanMode.Location = new System.Drawing.Point(70, 370);
            this.setScanMode.Name = "setScanMode";
            this.setScanMode.Size = new System.Drawing.Size(154, 30);
            this.setScanMode.Text = "setScanMode";
            this.setScanMode.Press += new System.EventHandler(this.setScanMode_Press);
            // 
            // n800Scanner1
            // 
            this.n800Scanner1.Name = "n800Scanner1";
            this.n800Scanner1.BarcodeDataCaptured += new Smobiler.Device.N800BarcodeScanEventHandler(this.n800Scanner1_BarcodeDataCaptured);
            this.n800Scanner1.KeyDown += new Smobiler.Device.N800ButtonEventHandler(this.n800Scanner1_KeyDown);
            this.n800Scanner1.OnNotify += new Smobiler.Device.N800ScannerOnNotifyEventHandler(this.n800Scanner1_OnNotify);
            // 
            // demoN800
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.n800Scanner1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.btnBarcodeScan,
            this.btnBarcodeTimerScan,
            this.btnBarcodeScanStop,
            this.btnScanTimeout,
            this.btnEnableTrigger,
            this.btnDisableTrigger,
            this.textBox1,
            this.label1,
            this.setScanMode});
            this.Name = "demoN800";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Button btnBarcodeScan;
        private Core.Controls.Button btnBarcodeTimerScan;
        private Core.Controls.Button btnBarcodeScanStop;
        private Core.Controls.Button btnScanTimeout;
        private Core.Controls.Button btnEnableTrigger;
        private Core.Controls.Button btnDisableTrigger;
        private Core.Controls.TextBox textBox1;
        private Core.Controls.Label label1;
        private Core.Controls.Button setScanMode;
        private Device.N800Scanner n800Scanner1;
    }
}