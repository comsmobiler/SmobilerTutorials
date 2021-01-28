using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Components
{
    partial class demoBarCodeScanner : Smobiler.Core.Controls.MobileForm
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
            this.panel10 = new Smobiler.Core.Controls.Panel();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.labContent = new Smobiler.Core.Controls.Label();
            this.labTitle = new Smobiler.Core.Controls.Label();
            this.btnGetBarcode = new Smobiler.Core.Controls.Button();
            this.btnGetBarcodeAsync = new Smobiler.Core.Controls.Button();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.panel3 = new Smobiler.Core.Controls.Panel();
            this.label13 = new Smobiler.Core.Controls.Label();
            this.label14 = new Smobiler.Core.Controls.Label();
            this.barcodeScanner1 = new Smobiler.Core.Controls.BarcodeScanner();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "BarCodeScanner";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // panel10
            // 
            this.panel10.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1,
            this.panel3});
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 30);
            this.panel10.Name = "panel10";
            this.panel10.Scrollable = true;
            this.panel10.Size = new System.Drawing.Size(300, 970);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel1.BorderColor = System.Drawing.Color.Silver;
            this.panel1.BorderRadius = 5;
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.labContent,
            this.labTitle,
            this.btnGetBarcode,
            this.btnGetBarcodeAsync,
            this.label1});
            this.panel1.Location = new System.Drawing.Point(5, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 261);
            // 
            // labContent
            // 
            this.labContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labContent.FontSize = 15F;
            this.labContent.Location = new System.Drawing.Point(0, 26);
            this.labContent.Name = "labContent";
            this.labContent.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labContent.Size = new System.Drawing.Size(290, 54);
            this.labContent.Text = "条码扫描组件，GetBarcode方法获取条码、GetBarcodeAsync方法同步获取条码";
            // 
            // labTitle
            // 
            this.labTitle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labTitle.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.labTitle.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.labTitle.FontSize = 16F;
            this.labTitle.Name = "labTitle";
            this.labTitle.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labTitle.Size = new System.Drawing.Size(290, 26);
            this.labTitle.Text = "条码扫描组件";
            // 
            // btnGetBarcode
            // 
            this.btnGetBarcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(78)))));
            this.btnGetBarcode.BorderStyle = Smobiler.Core.Controls.BorderStyle.Dashed;
            this.btnGetBarcode.Location = new System.Drawing.Point(81, 97);
            this.btnGetBarcode.Name = "btnGetBarcode";
            this.btnGetBarcode.Size = new System.Drawing.Size(132, 30);
            this.btnGetBarcode.Text = "GetBarcode";
            this.btnGetBarcode.Press += new System.EventHandler(this.btnGetBarcode_Press);
            // 
            // btnGetBarcodeAsync
            // 
            this.btnGetBarcodeAsync.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(229)))), ((int)(((byte)(99)))));
            this.btnGetBarcodeAsync.Location = new System.Drawing.Point(81, 211);
            this.btnGetBarcodeAsync.Name = "btnGetBarcodeAsync";
            this.btnGetBarcodeAsync.Size = new System.Drawing.Size(132, 30);
            this.btnGetBarcodeAsync.Text = "GetBarcodeAsync";
            this.btnGetBarcodeAsync.Press += new System.EventHandler(this.btnGetBarcodeAsync_Press);
            // 
            // label1
            // 
            this.label1.FontSize = 15F;
            this.label1.Location = new System.Drawing.Point(0, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 35);
            this.label1.Text = "同步获取条码，界面一直loading";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel3.BorderColor = System.Drawing.Color.Silver;
            this.panel3.BorderRadius = 5;
            this.panel3.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label13,
            this.label14});
            this.panel3.Location = new System.Drawing.Point(5, 283);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(290, 105);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label13.FontSize = 15F;
            this.label13.Location = new System.Drawing.Point(0, 26);
            this.label13.Name = "label13";
            this.label13.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label13.Size = new System.Drawing.Size(290, 78);
            this.label13.Text = "BarcodeScanned在客户端返回条码数据时发生";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label14.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label14.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.label14.FontSize = 16F;
            this.label14.Name = "label14";
            this.label14.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label14.Size = new System.Drawing.Size(290, 26);
            this.label14.Text = "事件";
            // 
            // barcodeScanner1
            // 
            this.barcodeScanner1.Name = "barcodeScanner1";
            this.barcodeScanner1.BarcodeScanned += new Smobiler.Core.Controls.BarcodeScannerCallBackHandler(this.barcodeScanner1_BarcodeScanned);
            // 
            // demoBarCodeScanner
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.barcodeScanner1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel10});
            this.Name = "demoBarCodeScanner";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Panel panel10;
        private Core.Controls.Panel panel1;
        private Core.Controls.Label labContent;
        private Core.Controls.Label labTitle;
        private Core.Controls.Panel panel3;
        private Core.Controls.Label label13;
        private Core.Controls.Label label14;
        private Core.Controls.Button btnGetBarcode;
        private Core.Controls.Button btnGetBarcodeAsync;
        private Core.Controls.BarcodeScanner barcodeScanner1;
        private Core.Controls.Label label1;
    }
}