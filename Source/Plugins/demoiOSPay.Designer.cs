using Smobiler.Core;
using System;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoiOSPay : Smobiler.Core.Controls.MobileForm
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
            this.button2 = new Smobiler.Core.Controls.Button();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.textBox1 = new Smobiler.Core.Controls.TextBox();
            this.button3 = new Smobiler.Core.Controls.Button();
            this.iOSPay1 = new Smobiler.Plugins.iOSPay();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "iOSPay";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(76, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 35);
            this.button2.Text = "cancelorder";
            this.button2.Press += new System.EventHandler(this.button2_Press);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(70, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 35);
            this.label1.Text = "请输入商品id";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.Text = "pay";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 35);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(76, 310);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 35);
            this.button3.Text = "confirmOrder";
            this.button3.Press += new System.EventHandler(this.button3_Press);
            // 
            // iOSPay1
            // 
            this.iOSPay1.Name = "iOSPay1";
            // 
            // demoiOSPay
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.iOSPay1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.button2,
            this.label1,
            this.button1,
            this.textBox1,
            this.button3});
            this.Name = "demoiOSPay";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Button button2;
        private Core.Controls.Label label1;
        private Core.Controls.Button button1;
        private Core.Controls.TextBox textBox1;
        private Core.Controls.Button button3;
        private Smobiler.Plugins.iOSPay iOSPay1;
    }
}