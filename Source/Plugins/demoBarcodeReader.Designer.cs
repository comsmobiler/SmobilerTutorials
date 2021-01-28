using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Plugins
{
    partial class demoBarcodeReader : Smobiler.Core.Controls.MobileForm
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
            this.btnGetBarcode = new Smobiler.Core.Controls.Button();
            this.btnRelease = new Smobiler.Core.Controls.Button();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.barcodeReader1 = new Smobiler.Plugins.BarcodeReader();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "BarcodeReader";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // btnGetBarcode
            // 
            this.btnGetBarcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(229)))), ((int)(((byte)(100)))));
            this.btnGetBarcode.Location = new System.Drawing.Point(72, 114);
            this.btnGetBarcode.Name = "btnGetBarcode";
            this.btnGetBarcode.Size = new System.Drawing.Size(134, 33);
            this.btnGetBarcode.Text = "GetBarcode";
            this.btnGetBarcode.Press += new System.EventHandler(this.btnGetBarcode_Press);
            // 
            // btnRelease
            // 
            this.btnRelease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(80)))));
            this.btnRelease.Location = new System.Drawing.Point(72, 247);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.Size = new System.Drawing.Size(134, 34);
            this.btnRelease.Text = "Release";
            this.btnRelease.Press += new System.EventHandler(this.btnRelease_Press);
            // 
            // label1
            // 
            this.label1.FontSize = 15F;
            this.label1.Location = new System.Drawing.Point(0, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 35);
            this.label1.Text = "GetBarcode：条码扫描";
            // 
            // label2
            // 
            this.label2.FontSize = 15F;
            this.label2.Location = new System.Drawing.Point(0, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 69);
            this.label2.Text = "Release：释放缓存  可释放条码扫描所占用的缓存";
            // 
            // barcodeReader1
            // 
            this.barcodeReader1.Name = "barcodeReader1";
            this.barcodeReader1.BarcodeRead += new Smobiler.Plugins.BarcodeReaderEventHandler(this.barcodeReader1_BarcodeRead);
            // 
            // demoBarcodeReader
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.barcodeReader1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.btnGetBarcode,
            this.btnRelease,
            this.label1,
            this.label2});
            this.Name = "demoBarcodeReader";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Button btnGetBarcode;
        private Core.Controls.Button btnRelease;
        private Core.Controls.Label label1;
        private Core.Controls.Label label2;
        private Smobiler.Plugins.BarcodeReader barcodeReader1;
    }
}