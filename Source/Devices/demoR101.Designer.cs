using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Devices
{
    partial class demoR101 : Smobiler.Core.Controls.MobileForm
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
            this.label1 = new Smobiler.Core.Controls.Label();
            this.r101Scanner1 = new Smobiler.Device.R101Scanner();
            this.btnScan = new Smobiler.Core.Controls.Button();
            this.btnScanInstantly = new Smobiler.Core.Controls.Button();
            this.btnStopScan = new Smobiler.Core.Controls.Button();
            this.labData = new Smobiler.Core.Controls.Label();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "R101";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 59);
            this.label1.Text = "使用R101Scanner插件，需要使用R101硬件\r\n";
            // 
            // r101Scanner1
            // 
            this.r101Scanner1.Name = "r101Scanner1";
            this.r101Scanner1.DataCaptured += new Smobiler.Device.R101BarcodeScanEventHandler(this.r101Scanner1_DataCaptured);
            this.r101Scanner1.OnNotify += new Smobiler.Device.R101BarcodeOnNotifyEventHandler(this.r101Scanner1_OnNotify);
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(93, 113);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(100, 30);
            this.btnScan.Text = "扫描";
            this.btnScan.Press += new System.EventHandler(this.btnScan_Press);
            // 
            // btnScanInstantly
            // 
            this.btnScanInstantly.Location = new System.Drawing.Point(93, 156);
            this.btnScanInstantly.Name = "btnScanInstantly";
            this.btnScanInstantly.Size = new System.Drawing.Size(100, 30);
            this.btnScanInstantly.Text = "持续扫描";
            this.btnScanInstantly.Press += new System.EventHandler(this.btnScanInstantly_Press);
            // 
            // btnStopScan
            // 
            this.btnStopScan.Location = new System.Drawing.Point(93, 198);
            this.btnStopScan.Name = "btnStopScan";
            this.btnStopScan.Size = new System.Drawing.Size(100, 30);
            this.btnStopScan.Text = "停止扫描";
            this.btnStopScan.Press += new System.EventHandler(this.btnStopScan_Press);
            // 
            // labData
            // 
            this.labData.Location = new System.Drawing.Point(0, 328);
            this.labData.Name = "labData";
            this.labData.Size = new System.Drawing.Size(300, 172);
            // 
            // demoR101
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.r101Scanner1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.label1,
            this.btnScan,
            this.btnScanInstantly,
            this.btnStopScan,
            this.labData});
            this.Name = "demoR101";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Label label1;
        private Device.R101Scanner r101Scanner1;
        private Core.Controls.Button btnScan;
        private Core.Controls.Button btnScanInstantly;
        private Core.Controls.Button btnStopScan;
        private Core.Controls.Label labData;
    }
}