using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Devices
{
    partial class demoB100 : Smobiler.Core.Controls.MobileForm
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
            this.btnbarcodeScan = new Smobiler.Core.Controls.Button();
            this.btnstopBarcodeScan = new Smobiler.Core.Controls.Button();
            this.btnbarcodeSetting = new Smobiler.Core.Controls.Button();
            this.spinner1 = new Smobiler.Core.Controls.Spinner();
            this.spinner2 = new Smobiler.Core.Controls.Spinner();
            this.spinner3 = new Smobiler.Core.Controls.Spinner();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.b100Scanner1 = new Smobiler.Device.B100Scanner();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "B100";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // btnbarcodeScan
            // 
            this.btnbarcodeScan.Location = new System.Drawing.Point(34, 58);
            this.btnbarcodeScan.Name = "btnbarcodeScan";
            this.btnbarcodeScan.Size = new System.Drawing.Size(100, 30);
            this.btnbarcodeScan.Text = "barcodeScan";
            this.btnbarcodeScan.Press += new System.EventHandler(this.btnbarcodeScan_Press);
            // 
            // btnstopBarcodeScan
            // 
            this.btnstopBarcodeScan.Location = new System.Drawing.Point(170, 58);
            this.btnstopBarcodeScan.Name = "btnstopBarcodeScan";
            this.btnstopBarcodeScan.Size = new System.Drawing.Size(100, 30);
            this.btnstopBarcodeScan.Text = "stopBarcodeScan";
            this.btnstopBarcodeScan.Press += new System.EventHandler(this.btnstopBarcodeScan_Press);
            // 
            // btnbarcodeSetting
            // 
            this.btnbarcodeSetting.Location = new System.Drawing.Point(80, 264);
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
            this.spinner1.Location = new System.Drawing.Point(200, 210);
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
            this.spinner2.Location = new System.Drawing.Point(100, 210);
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
            this.spinner3.Location = new System.Drawing.Point(0, 210);
            this.spinner3.Name = "spinner3";
            this.spinner3.Size = new System.Drawing.Size(100, 30);
            this.spinner3.Text = "声音";
            this.spinner3.ItemSelected += new System.EventHandler<Smobiler.Core.Controls.SpinnerItemSelectedEventArgs>(this.spinner3_ItemSelected);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 100);
            this.label1.Text = "下一行可分别选择设备：1.是否有提示音 2.是否震动 3.扫描模式(默认:one one:长按连扫,two:单次扫描,three:单次连扫)";
            // 
            // b100Scanner1
            // 
            this.b100Scanner1.Name = "b100Scanner1";
            this.b100Scanner1.BarcodeDataCaptured += new Smobiler.Device.B100Scanner.B100BarcodeScannEventHandler(this.b100Scanner1_BarcodeDataCaptured);
            // 
            // demoB100
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.b100Scanner1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.btnbarcodeScan,
            this.btnstopBarcodeScan,
            this.btnbarcodeSetting,
            this.spinner1,
            this.spinner2,
            this.spinner3,
            this.label1});
            this.Name = "demoB100";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Button btnbarcodeScan;
        private Core.Controls.Button btnstopBarcodeScan;
        private Core.Controls.Button btnbarcodeSetting;
        private Core.Controls.Spinner spinner1;
        private Core.Controls.Spinner spinner2;
        private Core.Controls.Spinner spinner3;
        private Core.Controls.Label label1;
        private Device.B100Scanner b100Scanner1;
    }
}