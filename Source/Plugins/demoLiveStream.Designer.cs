using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Plugins
{
    partial class demoLiveStream : Smobiler.Core.Controls.MobileForm
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
            this.liveStream1 = new Smobiler.Plugins.LiveStream();
            this.btnstartStreaming = new Smobiler.Core.Controls.Button();
            this.btnstopStreaming = new Smobiler.Core.Controls.Button();
            this.btnswapCamera = new Smobiler.Core.Controls.Button();
            this.btnfilter = new Smobiler.Core.Controls.Button();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "LiveStream";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // liveStream1
            // 
            this.liveStream1.Location = new System.Drawing.Point(0, 30);
            this.liveStream1.Name = "liveStream1";
            this.liveStream1.Size = new System.Drawing.Size(300, 339);
            this.liveStream1.Url = "rtmp://192.168.2.230/live/livestream";
            this.liveStream1.OnChanged += new Smobiler.Plugins.LiveStreamOnChangedEventHandler(this.liveStream1_OnChanged);
            // 
            // btnstartStreaming
            // 
            this.btnstartStreaming.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(176)))), ((int)(((byte)(250)))));
            this.btnstartStreaming.FontSize = 15F;
            this.btnstartStreaming.Location = new System.Drawing.Point(0, 438);
            this.btnstartStreaming.Name = "btnstartStreaming";
            this.btnstartStreaming.Size = new System.Drawing.Size(100, 38);
            this.btnstartStreaming.Text = "startStreaming";
            this.btnstartStreaming.Press += new System.EventHandler(this.btnstartStreaming_Press);
            // 
            // btnstopStreaming
            // 
            this.btnstopStreaming.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(80)))));
            this.btnstopStreaming.FontSize = 15F;
            this.btnstopStreaming.Location = new System.Drawing.Point(100, 438);
            this.btnstopStreaming.Name = "btnstopStreaming";
            this.btnstopStreaming.Size = new System.Drawing.Size(100, 38);
            this.btnstopStreaming.Text = "stopStreaming";
            this.btnstopStreaming.Press += new System.EventHandler(this.btnstopStreaming_Press);
            // 
            // btnswapCamera
            // 
            this.btnswapCamera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(229)))), ((int)(((byte)(100)))));
            this.btnswapCamera.FontSize = 15F;
            this.btnswapCamera.Location = new System.Drawing.Point(200, 438);
            this.btnswapCamera.Name = "btnswapCamera";
            this.btnswapCamera.Size = new System.Drawing.Size(100, 38);
            this.btnswapCamera.Text = "swapCamera";
            this.btnswapCamera.Press += new System.EventHandler(this.btnswapCamera_Press);
            // 
            // btnfilter
            // 
            this.btnfilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(67)))), ((int)(((byte)(80)))));
            this.btnfilter.FontSize = 16F;
            this.btnfilter.Location = new System.Drawing.Point(0, 382);
            this.btnfilter.Name = "btnfilter";
            this.btnfilter.Size = new System.Drawing.Size(300, 43);
            this.btnfilter.Text = "filter false";
            this.btnfilter.Press += new System.EventHandler(this.btnfilter_Press);
            // 
            // demoLiveStream
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.liveStream1,
            this.btnstartStreaming,
            this.btnstopStreaming,
            this.btnswapCamera,
            this.btnfilter});
            this.Name = "demoLiveStream";

        }
        #endregion

        private Core.Controls.Title title1;
        private Smobiler.Plugins.LiveStream liveStream1;
        private Core.Controls.Button btnstartStreaming;
        private Core.Controls.Button btnstopStreaming;
        private Core.Controls.Button btnswapCamera;
        private Core.Controls.Button btnfilter;
    }
}