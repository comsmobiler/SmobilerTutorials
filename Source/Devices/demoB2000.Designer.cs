using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Devices
{
    partial class demoB2000 : Smobiler.Core.Controls.MobileForm
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
            this.btnrfidScan = new Smobiler.Core.Controls.Button();
            this.btnstopRfidScan = new Smobiler.Core.Controls.Button();
            this.btnsetRfidPower = new Smobiler.Core.Controls.Button();
            this.btngetRfidPower = new Smobiler.Core.Controls.Button();
            this.btnseleteRfidCard = new Smobiler.Core.Controls.Button();
            this.btnreadRfidArea = new Smobiler.Core.Controls.Button();
            this.btnwriteRfidArea = new Smobiler.Core.Controls.Button();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.b2000Scanner1 = new Smobiler.Device.B2000Scanner();
            this.btnbarcodeScan = new Smobiler.Core.Controls.Button();
            this.btnstopBarcodeScan = new Smobiler.Core.Controls.Button();
            this.btnbarcodeSetting = new Smobiler.Core.Controls.Button();
            this.spinner1 = new Smobiler.Core.Controls.Spinner();
            this.spinner2 = new Smobiler.Core.Controls.Spinner();
            this.spinner3 = new Smobiler.Core.Controls.Spinner();
            this.label2 = new Smobiler.Core.Controls.Label();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "B2000";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // btnrfidScan
            // 
            this.btnrfidScan.Location = new System.Drawing.Point(36, 248);
            this.btnrfidScan.Name = "btnrfidScan";
            this.btnrfidScan.Size = new System.Drawing.Size(100, 30);
            this.btnrfidScan.Text = "rfidScan";
            this.btnrfidScan.Press += new System.EventHandler(this.btnrfidScan_Press);
            // 
            // btnstopRfidScan
            // 
            this.btnstopRfidScan.Location = new System.Drawing.Point(36, 300);
            this.btnstopRfidScan.Name = "btnstopRfidScan";
            this.btnstopRfidScan.Size = new System.Drawing.Size(100, 30);
            this.btnstopRfidScan.Text = "stopRfidScan";
            this.btnstopRfidScan.Press += new System.EventHandler(this.btnstopRfidScan_Press);
            // 
            // btnsetRfidPower
            // 
            this.btnsetRfidPower.Location = new System.Drawing.Point(36, 348);
            this.btnsetRfidPower.Name = "btnsetRfidPower";
            this.btnsetRfidPower.Size = new System.Drawing.Size(100, 30);
            this.btnsetRfidPower.Text = "setRfidPower";
            this.btnsetRfidPower.Press += new System.EventHandler(this.btnsetRfidPower_Press);
            // 
            // btngetRfidPower
            // 
            this.btngetRfidPower.Location = new System.Drawing.Point(36, 402);
            this.btngetRfidPower.Name = "btngetRfidPower";
            this.btngetRfidPower.Size = new System.Drawing.Size(100, 30);
            this.btngetRfidPower.Text = "getRfidPower";
            this.btngetRfidPower.Press += new System.EventHandler(this.btngetRfidPower_Press);
            // 
            // btnseleteRfidCard
            // 
            this.btnseleteRfidCard.Location = new System.Drawing.Point(166, 300);
            this.btnseleteRfidCard.Name = "btnseleteRfidCard";
            this.btnseleteRfidCard.Size = new System.Drawing.Size(100, 30);
            this.btnseleteRfidCard.Text = "seleteRfidCard";
            this.btnseleteRfidCard.Press += new System.EventHandler(this.btnseleteRfidCard_Press);
            // 
            // btnreadRfidArea
            // 
            this.btnreadRfidArea.Location = new System.Drawing.Point(166, 348);
            this.btnreadRfidArea.Name = "btnreadRfidArea";
            this.btnreadRfidArea.Size = new System.Drawing.Size(100, 30);
            this.btnreadRfidArea.Text = "readRfidArea";
            this.btnreadRfidArea.Press += new System.EventHandler(this.btnreadRfidArea_Press);
            // 
            // btnwriteRfidArea
            // 
            this.btnwriteRfidArea.Location = new System.Drawing.Point(166, 402);
            this.btnwriteRfidArea.Name = "btnwriteRfidArea";
            this.btnwriteRfidArea.Size = new System.Drawing.Size(100, 30);
            this.btnwriteRfidArea.Text = "writeRfidArea";
            this.btnwriteRfidArea.Press += new System.EventHandler(this.btnwriteRfidArea_Press);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(36, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 35);
            this.label1.Text = "label1";
            // 
            // b2000Scanner1
            // 
            this.b2000Scanner1.Name = "b2000Scanner1";
            // 
            // btnbarcodeScan
            // 
            this.btnbarcodeScan.Location = new System.Drawing.Point(28, 40);
            this.btnbarcodeScan.Name = "btnbarcodeScan";
            this.btnbarcodeScan.Size = new System.Drawing.Size(100, 30);
            this.btnbarcodeScan.Text = "barcodeScan";
            this.btnbarcodeScan.Press += new System.EventHandler(this.btnbarcodeScan_Press);
            // 
            // btnstopBarcodeScan
            // 
            this.btnstopBarcodeScan.Location = new System.Drawing.Point(164, 40);
            this.btnstopBarcodeScan.Name = "btnstopBarcodeScan";
            this.btnstopBarcodeScan.Size = new System.Drawing.Size(100, 30);
            this.btnstopBarcodeScan.Text = "stopBarcodeScan";
            this.btnstopBarcodeScan.Press += new System.EventHandler(this.btnstopBarcodeScan_Press);
            // 
            // btnbarcodeSetting
            // 
            this.btnbarcodeSetting.Location = new System.Drawing.Point(88, 206);
            this.btnbarcodeSetting.Name = "btnbarcodeSetting";
            this.btnbarcodeSetting.Size = new System.Drawing.Size(100, 30);
            this.btnbarcodeSetting.Text = "barcodeSetting";
            this.btnbarcodeSetting.Press += new System.EventHandler(this.btnbarcodeSetting_Press);
            // 
            // spinner1
            // 
            this.spinner1.Items = new string[] {
        "One",
        "Two",
        "Three"};
            this.spinner1.Location = new System.Drawing.Point(200, 164);
            this.spinner1.Name = "spinner1";
            this.spinner1.Size = new System.Drawing.Size(100, 30);
            this.spinner1.Text = "扫描模式";
            this.spinner1.ItemSelected += new System.EventHandler<Smobiler.Core.Controls.SpinnerItemSelectedEventArgs>(this.spinner1_ItemSelected);
            // 
            // spinner2
            // 
            this.spinner2.Items = new string[] {
        "true",
        "false"};
            this.spinner2.Location = new System.Drawing.Point(100, 164);
            this.spinner2.Name = "spinner2";
            this.spinner2.Size = new System.Drawing.Size(100, 30);
            this.spinner2.Text = "震动";
            this.spinner2.ItemSelected += new System.EventHandler<Smobiler.Core.Controls.SpinnerItemSelectedEventArgs>(this.spinner2_ItemSelected);
            // 
            // spinner3
            // 
            this.spinner3.Items = new string[] {
        "true",
        "false"};
            this.spinner3.Location = new System.Drawing.Point(0, 164);
            this.spinner3.Name = "spinner3";
            this.spinner3.Size = new System.Drawing.Size(100, 30);
            this.spinner3.Text = "声音";
            this.spinner3.ItemSelected += new System.EventHandler<Smobiler.Core.Controls.SpinnerItemSelectedEventArgs>(this.spinner3_ItemSelected);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 63);
            this.label2.Text = "下一行可分别选择设备：1.是否有提示音 2.是否震动 3.扫描模式(默认:one one:长按连扫,two:单次扫描,three:单次连扫)\r\n";
            // 
            // demoB2000
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.b2000Scanner1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.btnrfidScan,
            this.btnstopRfidScan,
            this.btnsetRfidPower,
            this.btngetRfidPower,
            this.btnseleteRfidCard,
            this.btnreadRfidArea,
            this.btnwriteRfidArea,
            this.label1,
            this.btnbarcodeScan,
            this.btnstopBarcodeScan,
            this.btnbarcodeSetting,
            this.spinner1,
            this.spinner2,
            this.spinner3,
            this.label2});
            this.Name = "demoB2000";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Button btnrfidScan;
        private Core.Controls.Button btnstopRfidScan;
        private Core.Controls.Button btnsetRfidPower;
        private Core.Controls.Button btngetRfidPower;
        private Core.Controls.Button btnseleteRfidCard;
        private Core.Controls.Button btnreadRfidArea;
        private Core.Controls.Button btnwriteRfidArea;
        private Core.Controls.Label label1;
        private Device.B2000Scanner b2000Scanner1;
        private Core.Controls.Button btnbarcodeScan;
        private Core.Controls.Button btnstopBarcodeScan;
        private Core.Controls.Button btnbarcodeSetting;
        private Core.Controls.Spinner spinner1;
        private Core.Controls.Spinner spinner2;
        private Core.Controls.Spinner spinner3;
        private Core.Controls.Label label2;
    }
}