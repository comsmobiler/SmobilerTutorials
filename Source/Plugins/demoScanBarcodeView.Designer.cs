using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Plugins
{
    partial class demoScanBarcodeView : Smobiler.Core.Controls.MobileForm
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
            this.scanBarcodeView1 = new Smobiler.Plugins.ScanBarcodeView();
            this.btnOpenFlashLight = new Smobiler.Core.Controls.Button();
            this.btnCloseFlashLight = new Smobiler.Core.Controls.Button();
            this.textBox1 = new Smobiler.Core.Controls.TextBox();
            this.btnScanStart = new Smobiler.Core.Controls.Button();
            this.btnScanStop = new Smobiler.Core.Controls.Button();
            this.btnIntervalTime = new Smobiler.Core.Controls.Button();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "ScanBarcodeView";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // scanBarcodeView1
            // 
            this.scanBarcodeView1.Location = new System.Drawing.Point(16, 48);
            this.scanBarcodeView1.Name = "scanBarcodeView1";
            this.scanBarcodeView1.Size = new System.Drawing.Size(262, 110);
            this.scanBarcodeView1.BarcodeDataCaptured += new Smobiler.Plugins.ScanBarcodeViewEventHandler(this.scanBarcodeView1_BarcodeDataCaptured);
            // 
            // btnOpenFlashLight
            // 
            this.btnOpenFlashLight.Location = new System.Drawing.Point(16, 188);
            this.btnOpenFlashLight.Name = "btnOpenFlashLight";
            this.btnOpenFlashLight.Size = new System.Drawing.Size(100, 30);
            this.btnOpenFlashLight.Text = "开闪光";
            this.btnOpenFlashLight.Press += new System.EventHandler(this.btnOpenFlashLight_Press);
            // 
            // btnCloseFlashLight
            // 
            this.btnCloseFlashLight.Location = new System.Drawing.Point(178, 188);
            this.btnCloseFlashLight.Name = "btnCloseFlashLight";
            this.btnCloseFlashLight.Size = new System.Drawing.Size(100, 30);
            this.btnCloseFlashLight.Text = "关闪光";
            this.btnCloseFlashLight.Press += new System.EventHandler(this.btnCloseFlashLight_Press);
            // 
            // textBox1
            // 
            this.textBox1.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.textBox1.Location = new System.Drawing.Point(16, 283);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 35);
            this.textBox1.WaterMarkText = "1000(默认)";
            // 
            // btnScanStart
            // 
            this.btnScanStart.Location = new System.Drawing.Point(16, 236);
            this.btnScanStart.Name = "btnScanStart";
            this.btnScanStart.Size = new System.Drawing.Size(100, 30);
            this.btnScanStart.Text = "开扫描";
            this.btnScanStart.Press += new System.EventHandler(this.btnScanStart_Press);
            // 
            // btnScanStop
            // 
            this.btnScanStop.Location = new System.Drawing.Point(178, 236);
            this.btnScanStop.Name = "btnScanStop";
            this.btnScanStop.Size = new System.Drawing.Size(100, 30);
            this.btnScanStop.Text = "关扫描";
            this.btnScanStop.Press += new System.EventHandler(this.btnScanStop_Press);
            // 
            // btnIntervalTime
            // 
            this.btnIntervalTime.Location = new System.Drawing.Point(178, 283);
            this.btnIntervalTime.Name = "btnIntervalTime";
            this.btnIntervalTime.Size = new System.Drawing.Size(100, 30);
            this.btnIntervalTime.Text = "扫描间隔（ms）";
            this.btnIntervalTime.Press += new System.EventHandler(this.btnIntervalTime_Press);
            // 
            // demoScanBarcodeView
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.scanBarcodeView1,
            this.btnOpenFlashLight,
            this.btnCloseFlashLight,
            this.textBox1,
            this.btnScanStart,
            this.btnScanStop,
            this.btnIntervalTime});
            this.Name = "demoScanBarcodeView";

        }
        #endregion

        private Core.Controls.Title title1;
        private Smobiler.Plugins.ScanBarcodeView scanBarcodeView1;
        private Core.Controls.Button btnOpenFlashLight;
        private Core.Controls.Button btnCloseFlashLight;
        private Core.Controls.TextBox textBox1;
        private Core.Controls.Button btnScanStart;
        private Core.Controls.Button btnScanStop;
        private Core.Controls.Button btnIntervalTime;
    }
}