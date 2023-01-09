using Smobiler.Core;
using System;

namespace Smobiler.Tutorials.Samples.Barcode
{
    partial class demoBarcode : Smobiler.Core.Controls.MobileForm
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
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.image2 = new Smobiler.Core.Controls.Image();
            this.image1 = new Smobiler.Core.Controls.Image();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.textBox1 = new Smobiler.Core.Controls.TextBox();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.textBox2 = new Smobiler.Core.Controls.TextBox();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.button2 = new Smobiler.Core.Controls.Button();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(0, 30);
            this.title1.Text = "服务端生成条码";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image2,
            this.image1,
            this.button1,
            this.textBox1,
            this.label2,
            this.label1,
            this.textBox2,
            this.label3,
            this.button2});
            this.panel1.Flex = 1;
            this.panel1.Name = "panel1";
            this.panel1.Scrollable = true;
            this.panel1.Size = new System.Drawing.Size(0, 100);
            // 
            // image2
            // 
            this.image2.Location = new System.Drawing.Point(40, 326);
            this.image2.Name = "image2";
            this.image2.ResourceMode = Smobiler.Core.Controls.ResourceMode.Data;
            this.image2.Size = new System.Drawing.Size(223, 111);
            // 
            // image1
            // 
            this.image1.Location = new System.Drawing.Point(40, 144);
            this.image1.Name = "image1";
            this.image1.ResourceMode = Smobiler.Core.Controls.ResourceMode.Data;
            this.image1.Size = new System.Drawing.Size(111, 111);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 35);
            this.button1.Text = "生成二维码并下载到手机";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 188);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 35);
            this.textBox1.Text = "123456";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(163, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.Text = "内容：";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(48, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 96);
            this.label1.Text = "通过xing实现服务端生成一维码和二维码并生成图片下载到手机中";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(51, 475);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(191, 35);
            this.textBox2.Text = "123456";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(51, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 18);
            this.label3.Text = "内容：";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(51, 520);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 35);
            this.button2.Text = "生成一维码并下载到手机";
            this.button2.Press += new System.EventHandler(this.button2_Press);
            // 
            // demoBarcode
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel1});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Load += new System.EventHandler(this.demoBarcode_Load);
            this.Name = "demoBarcode";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Panel panel1;
        private Core.Controls.Image image2;
        private Core.Controls.Image image1;
        private Core.Controls.Button button1;
        private Core.Controls.TextBox textBox1;
        private Core.Controls.Label label2;
        private Core.Controls.Label label1;
        private Core.Controls.TextBox textBox2;
        private Core.Controls.Label label3;
        private Core.Controls.Button button2;
    }
}