using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Plugins
{
    partial class demoVLCPlayer : Smobiler.Core.Controls.MobileForm
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
            this.vlcPlayer1 = new Smobiler.Plugins.VLCPlayer();
            this.label1 = new Smobiler.Core.Controls.Label();
            // 
            // title1
            // 
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "VLCPlayer";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.vlcPlayer1,
            this.label1});
            this.panel1.Flex = 1;
            this.panel1.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel1.Name = "panel1";
            this.panel1.Scrollable = true;
            this.panel1.Size = new System.Drawing.Size(0, 100);
            // 
            // vlcPlayer1
            // 
            this.vlcPlayer1.Flex = 1;
            this.vlcPlayer1.Name = "vlcPlayer1";
            this.vlcPlayer1.Size = new System.Drawing.Size(300, 0);
            this.vlcPlayer1.Url = "rtsp://wowzaec2demo.streamlock.net/vod/mp4:BigBuckBunny_115k.mov";
            // 
            // label1
            // 
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 101);
            this.label1.Text = "VLCPlayer可支持播放rtsp，将rtsp流地址赋值给Url属性即可播放";
            // 
            // demoVLCPlayer
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel1});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Name = "demoVLCPlayer";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Panel panel1;
        private Smobiler.Plugins.VLCPlayer vlcPlayer1;
        private Core.Controls.Label label1;
    }
}