using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Devices
{
    partial class demoHMT1 : Smobiler.Core.Controls.MobileForm
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
            this.hmT11 = new Smobiler.Device.HMT1();
            this.image1 = new Smobiler.Core.Controls.Image();
            this.textBox1 = new Smobiler.Core.Controls.TextBox();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.camera1 = new Smobiler.Core.Controls.Camera();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "HMT1";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // hmT11
            // 
            this.hmT11.Name = "hmT11";
            // 
            // image1
            // 
            this.image1.Location = new System.Drawing.Point(39, 138);
            this.image1.Name = "image1";
            this.image1.Size = new System.Drawing.Size(211, 191);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 35);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 55);
            this.label1.Text = "语音\"文本\"可输入文本，\r\n语音\"拍照\"可调用拍照功能。\r\n";
            // 
            // camera1
            // 
            this.camera1.Name = "camera1";
            this.camera1.ImageCaptured += new Smobiler.Core.Controls.CameraOnlineCallBackHandler(this.camera1_ImageCaptured);
            // 
            // demoHMT1
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.hmT11,
            this.camera1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.image1,
            this.textBox1,
            this.label1});
            this.ForeGround += new System.EventHandler(this.demoHMT1_ForeGround);
            this.Load += new System.EventHandler(this.demoHMT1_Load);
            this.Name = "demoHMT1";

        }
        #endregion
        private Core.Controls.Title title1;
        private Device.HMT1 hmT11;
        private Core.Controls.Image image1;
        private Core.Controls.TextBox textBox1;
        private Core.Controls.Label label1;
        private Core.Controls.Camera camera1;
    }
}