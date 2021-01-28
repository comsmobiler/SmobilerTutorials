using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Controls
{
    partial class demoBarcodeScannerButton : Smobiler.Core.Controls.MobileForm
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
            this.label1 = new Smobiler.Core.Controls.Label();
            this.barcodeScannerButton1 = new Smobiler.Core.Controls.BarcodeScannerButton();
            this.barcodeScanner1 = new Smobiler.Core.Controls.BarcodeScanner();
            this.barcodeScannerButton2 = new Smobiler.Core.Controls.BarcodeScannerButton();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "BarCodeScannerButton";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // panel10
            // 
            this.panel10.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.panel10.Flex = 1;
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
            this.label1,
            this.barcodeScannerButton1,
            this.barcodeScannerButton2});
            this.panel1.Location = new System.Drawing.Point(5, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 300);
            // 
            // labContent
            // 
            this.labContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labContent.FontSize = 15F;
            this.labContent.Location = new System.Drawing.Point(0, 26);
            this.labContent.Name = "labContent";
            this.labContent.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labContent.Size = new System.Drawing.Size(290, 113);
            this.labContent.Text = "IconColor设置图像资源颜色\r\nImageDirection设置图片显示位置\r\nImageExBorderRadius设置图像资源圆角\r\nImageType" +
    "设置图像类型\r\nResourceID设置图像资源名称\r\nResourcePath设置图像存储路径";
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
            this.labTitle.Text = "不同样式条码扫描控件";
            // 
            // label1
            // 
            this.label1.FontSize = 15F;
            this.label1.Location = new System.Drawing.Point(0, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 35);
            this.label1.Text = "BarcodeScanned在客户端返回条码数据时发生";
            // 
            // barcodeScannerButton1
            // 
            this.barcodeScannerButton1.Location = new System.Drawing.Point(58, 161);
            this.barcodeScannerButton1.Name = "barcodeScannerButton1";
            this.barcodeScannerButton1.ResourceID = "BarcodeScanner";
            this.barcodeScannerButton1.Size = new System.Drawing.Size(54, 40);
            this.barcodeScannerButton1.Text = "扫描";
            this.barcodeScannerButton1.BarcodeScanned += new Smobiler.Core.Controls.BarcodeScannerCallBackHandler(this.barcodeScannerButton1_BarcodeScanned);
            // 
            // barcodeScanner1
            // 
            this.barcodeScanner1.Name = "barcodeScanner1";
            // 
            // barcodeScannerButton2
            // 
            this.barcodeScannerButton2.IconColor = System.Drawing.Color.LightSkyBlue;
            this.barcodeScannerButton2.ImageDirection = Smobiler.Core.Controls.Direction.Bottom;
            this.barcodeScannerButton2.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.barcodeScannerButton2.Location = new System.Drawing.Point(165, 161);
            this.barcodeScannerButton2.Name = "barcodeScannerButton2";
            this.barcodeScannerButton2.ResourceID = "barcode";
            this.barcodeScannerButton2.Size = new System.Drawing.Size(54, 40);
            this.barcodeScannerButton2.Text = "扫描";
            this.barcodeScannerButton2.BarcodeScanned += new Smobiler.Core.Controls.BarcodeScannerCallBackHandler(this.barcodeScannerButton1_BarcodeScanned);
            // 
            // demoBarcodeScannerButton
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.barcodeScanner1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel10});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Name = "demoBarcodeScannerButton";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Panel panel10;
        private Core.Controls.Panel panel1;
        private Core.Controls.Label labContent;
        private Core.Controls.Label labTitle;
        private Core.Controls.Label label1;
        private Core.Controls.BarcodeScannerButton barcodeScannerButton1;
        private Core.Controls.BarcodeScanner barcodeScanner1;
        private Core.Controls.BarcodeScannerButton barcodeScannerButton2;
    }
}