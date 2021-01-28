using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Components
{
    partial class demoBarcodeView : Smobiler.Core.Controls.MobileForm
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
            this.barCodeView1 = new Smobiler.Core.Controls.BarCodeView();
            this.barCodeView2 = new Smobiler.Core.Controls.BarCodeView();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.barCodeView3 = new Smobiler.Core.Controls.BarCodeView();
            this.barCodeView4 = new Smobiler.Core.Controls.BarCodeView();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "BarcodeView";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // panel10
            // 
            this.panel10.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
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
            this.barCodeView1,
            this.barCodeView2,
            this.label1,
            this.barCodeView3,
            this.barCodeView4});
            this.panel1.Location = new System.Drawing.Point(5, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 421);
            // 
            // labContent
            // 
            this.labContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labContent.FontSize = 15F;
            this.labContent.Location = new System.Drawing.Point(0, 26);
            this.labContent.Name = "labContent";
            this.labContent.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labContent.Size = new System.Drawing.Size(290, 54);
            this.labContent.Text = "Value设置条码的文本、CodeColor设置条码前景色\r\n";
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
            this.labTitle.Text = "条码控件";
            // 
            // barCodeView1
            // 
            this.barCodeView1.Location = new System.Drawing.Point(23, 80);
            this.barCodeView1.Name = "barCodeView1";
            this.barCodeView1.Size = new System.Drawing.Size(100, 100);
            this.barCodeView1.Value = "123456";
            // 
            // barCodeView2
            // 
            this.barCodeView2.CodeColor = System.Drawing.Color.DarkRed;
            this.barCodeView2.Location = new System.Drawing.Point(161, 80);
            this.barCodeView2.Name = "barCodeView2";
            this.barCodeView2.Size = new System.Drawing.Size(100, 100);
            this.barCodeView2.Value = "smobiler";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.FontSize = 15F;
            this.label1.Location = new System.Drawing.Point(0, 192);
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label1.Size = new System.Drawing.Size(290, 54);
            this.label1.Text = "BarCodeType设置条码类型";
            // 
            // barCodeView3
            // 
            this.barCodeView3.Location = new System.Drawing.Point(23, 267);
            this.barCodeView3.Name = "barCodeView3";
            this.barCodeView3.Size = new System.Drawing.Size(100, 100);
            this.barCodeView3.Value = "smobiler";
            // 
            // barCodeView4
            // 
            this.barCodeView4.BarcodeType = Smobiler.Core.Controls.BarcodeType.Code128;
            this.barCodeView4.Location = new System.Drawing.Point(161, 275);
            this.barCodeView4.Name = "barCodeView4";
            this.barCodeView4.Size = new System.Drawing.Size(129, 100);
            this.barCodeView4.Value = "smobiler";
            // 
            // demoBarcodeView
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel10});
            this.Name = "demoBarcodeView";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Panel panel10;
        private Core.Controls.Panel panel1;
        private Core.Controls.Label labContent;
        private Core.Controls.Label labTitle;
        private Core.Controls.BarCodeView barCodeView1;
        private Core.Controls.BarCodeView barCodeView2;
        private Core.Controls.Label label1;
        private Core.Controls.BarCodeView barCodeView3;
        private Core.Controls.BarCodeView barCodeView4;
    }
}