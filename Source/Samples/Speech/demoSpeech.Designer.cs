using Smobiler.Core;
using System;

namespace Smobiler.Tutorials.Samples.Speech
{
    partial class demoSpeech : Smobiler.Core.Controls.MobileForm
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
            this.label1 = new Smobiler.Core.Controls.Label();
            this.button1 = new Smobiler.Core.Controls.Button();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Location = new System.Drawing.Point(56, 65);
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(100, 30);
            this.title1.Text = "语音转文字";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(37, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 53);
            this.label1.Text = "语音转文字可在服务端使用百度AI或者讯飞实现。";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.Text = "百度短语音识别";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // demoSpeech
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.label1,
            this.button1});
            this.Name = "demoSpeech";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Label label1;
        private Core.Controls.Button button1;
    }
}