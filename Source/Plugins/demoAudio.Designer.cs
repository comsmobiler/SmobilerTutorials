using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Plugins
{
    partial class demoAudio : Smobiler.Core.Controls.MobileForm
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
            this.btnstart = new Smobiler.Core.Controls.Button();
            this.btnstop = new Smobiler.Core.Controls.Button();
            this.btnpause = new Smobiler.Core.Controls.Button();
            this.btnresume = new Smobiler.Core.Controls.Button();
            this.audio1 = new Smobiler.Plugins.Audio();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "Audio";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(93, 100);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(100, 30);
            this.btnstart.Text = "开始录音";
            this.btnstart.Press += new System.EventHandler(this.btnstart_Press);
            // 
            // btnstop
            // 
            this.btnstop.Location = new System.Drawing.Point(93, 298);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(100, 30);
            this.btnstop.Text = "停止录音";
            this.btnstop.Press += new System.EventHandler(this.btnstop_Press);
            // 
            // btnpause
            // 
            this.btnpause.Location = new System.Drawing.Point(93, 169);
            this.btnpause.Name = "btnpause";
            this.btnpause.Size = new System.Drawing.Size(100, 30);
            this.btnpause.Text = "暂停";
            this.btnpause.Press += new System.EventHandler(this.btnpause_Press);
            // 
            // btnresume
            // 
            this.btnresume.Location = new System.Drawing.Point(93, 231);
            this.btnresume.Name = "btnresume";
            this.btnresume.Size = new System.Drawing.Size(100, 30);
            this.btnresume.Text = "继续";
            this.btnresume.Press += new System.EventHandler(this.btnresume_Press);
            // 
            // audio1
            // 
            this.audio1.AudioDuration = 0F;
            this.audio1.Channels = 2;
            this.audio1.IncludeByte = false;
            this.audio1.Name = "audio1";
            this.audio1.SampleRate = 44100F;
            this.audio1.Recorded += new Smobiler.Plugins.AudioRecordedEventHandler(this.audio1_Recorded);
            // 
            // demoAudio
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.audio1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.btnstart,
            this.btnstop,
            this.btnpause,
            this.btnresume});
            this.Name = "demoAudio";

        }
        #endregion
        private Core.Controls.Title title1;
        private Smobiler.Plugins.Audio audio1;
        private Core.Controls.Button btnstart;
        private Core.Controls.Button btnstop;
        private Core.Controls.Button btnpause;
        private Core.Controls.Button btnresume;
    }
}