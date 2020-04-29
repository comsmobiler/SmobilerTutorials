using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Plugins
{
    partial class demoTTS : Smobiler.Core.Controls.MobileForm
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
            this.tts1 = new Smobiler.Plugins.TTS.TTS();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.button2 = new Smobiler.Core.Controls.Button();
            this.button3 = new Smobiler.Core.Controls.Button();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "TTS";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // tts1
            // 
            this.tts1.Name = "tts1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.Text = "中文 1.5倍";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(85, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.Text = "stop";
            this.button2.Press += new System.EventHandler(this.button2_Press);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(85, 131);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 30);
            this.button3.Text = "英文 正常速";
            this.button3.Press += new System.EventHandler(this.button3_Press);
            // 
            // demoTTS
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.tts1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.button1,
            this.button2,
            this.button3});
            this.Name = "demoTTS";

        }
        #endregion

        private Core.Controls.Title title1;
        private Smobiler.Plugins.TTS.TTS tts1;
        private Core.Controls.Button button1;
        private Core.Controls.Button button2;
        private Core.Controls.Button button3;
    }
}