using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Devices
{
    partial class demoV7000 : Smobiler.Core.Controls.MobileForm
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
            this.btnScan = new Smobiler.Core.Controls.Button();
            this.btnencoding = new Smobiler.Core.Controls.Button();
            this.btnisContinue = new Smobiler.Core.Controls.Button();
            this.btnisVoice = new Smobiler.Core.Controls.Button();
            this.btnisVibator = new Smobiler.Core.Controls.Button();
            this.btnregisterKeyDown = new Smobiler.Core.Controls.Button();
            this.btnunRegisterKeyDown = new Smobiler.Core.Controls.Button();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.v7000Scanner1 = new Smobiler.Device.V7000Scanner();
            this.label1 = new Smobiler.Core.Controls.Label();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "v7000";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(0, 153);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(300, 64);
            this.btnScan.Text = "扫描";
            this.btnScan.Press += new System.EventHandler(this.btnScan_Press);
            // 
            // btnencoding
            // 
            this.btnencoding.Location = new System.Drawing.Point(0, 217);
            this.btnencoding.Name = "btnencoding";
            this.btnencoding.Size = new System.Drawing.Size(100, 30);
            this.btnencoding.Text = "encoding";
            this.btnencoding.Press += new System.EventHandler(this.btnencoding_Press);
            // 
            // btnisContinue
            // 
            this.btnisContinue.Location = new System.Drawing.Point(0, 247);
            this.btnisContinue.Name = "btnisContinue";
            this.btnisContinue.Size = new System.Drawing.Size(100, 30);
            this.btnisContinue.Text = "isContinue";
            this.btnisContinue.Press += new System.EventHandler(this.btnisContinue_Press);
            // 
            // btnisVoice
            // 
            this.btnisVoice.Location = new System.Drawing.Point(0, 277);
            this.btnisVoice.Name = "btnisVoice";
            this.btnisVoice.Size = new System.Drawing.Size(100, 30);
            this.btnisVoice.Text = "isVoice";
            this.btnisVoice.Press += new System.EventHandler(this.btnisVoice_Press);
            // 
            // btnisVibator
            // 
            this.btnisVibator.Location = new System.Drawing.Point(0, 307);
            this.btnisVibator.Name = "btnisVibator";
            this.btnisVibator.Size = new System.Drawing.Size(100, 30);
            this.btnisVibator.Text = "isVibator";
            this.btnisVibator.Press += new System.EventHandler(this.btnisVibator_Press);
            // 
            // btnregisterKeyDown
            // 
            this.btnregisterKeyDown.Location = new System.Drawing.Point(0, 337);
            this.btnregisterKeyDown.Name = "btnregisterKeyDown";
            this.btnregisterKeyDown.Size = new System.Drawing.Size(300, 61);
            this.btnregisterKeyDown.Text = "开启扫描键扫描";
            this.btnregisterKeyDown.Press += new System.EventHandler(this.btnregisterKeyDown_Press);
            // 
            // btnunRegisterKeyDown
            // 
            this.btnunRegisterKeyDown.Location = new System.Drawing.Point(0, 398);
            this.btnunRegisterKeyDown.Name = "btnunRegisterKeyDown";
            this.btnunRegisterKeyDown.Size = new System.Drawing.Size(300, 63);
            this.btnunRegisterKeyDown.Text = "关闭扫描键扫描";
            this.btnunRegisterKeyDown.Press += new System.EventHandler(this.btnunRegisterKeyDown_Press);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(100, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 30);
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(100, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 30);
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(100, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 30);
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(100, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 30);
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(300, 55);
            // 
            // v7000Scanner1
            // 
            this.v7000Scanner1.Encoding = Smobiler.Device.V7000Encoding.GBK;
            this.v7000Scanner1.Name = "v7000Scanner1";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 59);
            this.label1.Text = "使用v7000Scanner插件，需要使用v7000硬件\r\n";
            // 
            // demoV7000
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.v7000Scanner1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.btnScan,
            this.btnencoding,
            this.btnisContinue,
            this.btnisVoice,
            this.btnisVibator,
            this.btnregisterKeyDown,
            this.btnunRegisterKeyDown,
            this.label2,
            this.label3,
            this.label4,
            this.label5,
            this.label6,
            this.label1});
            this.Name = "demoV7000";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Button btnScan;
        private Core.Controls.Button btnencoding;
        private Core.Controls.Button btnisContinue;
        private Core.Controls.Button btnisVoice;
        private Core.Controls.Button btnisVibator;
        private Core.Controls.Button btnregisterKeyDown;
        private Core.Controls.Button btnunRegisterKeyDown;
        private Core.Controls.Label label2;
        private Core.Controls.Label label3;
        private Core.Controls.Label label4;
        private Core.Controls.Label label5;
        private Core.Controls.Label label6;
        private Device.V7000Scanner v7000Scanner1;
        private Core.Controls.Label label1;
    }
}