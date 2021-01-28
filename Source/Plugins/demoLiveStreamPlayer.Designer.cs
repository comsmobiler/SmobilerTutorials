using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Plugins
{
    partial class demoLiveStreamPlayer : Smobiler.Core.Controls.MobileForm
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
            this.liveStreamPlayer1 = new Smobiler.Plugins.LiveStreamPlayer();
            this.label1 = new Smobiler.Core.Controls.Label();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "LiveStreamPlayer";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.liveStreamPlayer1,
            this.label1});
            this.panel1.Flex = 1;
            this.panel1.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel1.Name = "panel1";
            this.panel1.Scrollable = true;
            this.panel1.Size = new System.Drawing.Size(0, 100);
            // 
            // liveStreamPlayer1
            // 
            this.liveStreamPlayer1.Flex = 1;
            this.liveStreamPlayer1.Name = "liveStreamPlayer1";
            this.liveStreamPlayer1.Size = new System.Drawing.Size(0, 30);
            this.liveStreamPlayer1.Url = "http://devimages.apple.com.edgekey.net/streaming/examples/bipbop_4x3/gear2/prog_i" +
    "ndex.m3u8";
            this.liveStreamPlayer1.StateChanged += new Smobiler.Plugins.LiveStreamPlayerStateChangedEventHandler(this.liveStreamPlayer1_StateChanged);
            // 
            // label1
            // 
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 65);
            this.label1.Text = "直播流播放器。LiveStreamPlayer可设置Url播放视频流(支持rtmp、http、hls、hks)。\r\nStateChanged事件在播放器状态改变时" +
    "触发";
            // 
            // demoLiveStreamPlayer
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel1});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Name = "demoLiveStreamPlayer";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Panel panel1;
        private Smobiler.Plugins.LiveStreamPlayer liveStreamPlayer1;
        private Core.Controls.Label label1;
    }
}