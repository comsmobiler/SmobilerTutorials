using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoMediaView : Smobiler.Core.Controls.MobileForm
    {
        public demoMediaView() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mediaView1_StateChanged(object sender, Smobiler.Plugins.MediaViewStateChangedEventArgs e)
        {
            Toast("当前状态"+e.State.ToString());
        }

        private void demoMediaView_Load(object sender, EventArgs e)
        {
            mediaView1.Url = "https://www.smobiler.com/video/video/video_001.mp4";
           // string url=MobileResourceManager.GetResourceURL(this.Client.SessionID, "名称.mp4", MobileResourceManager.DefaultUploadResourceName); 将upload下的文件转换为url
        }

        private void button1_Press(object sender, EventArgs e)
        {
            mediaView1.Seek(20);
        }
        private bool flag = false;
        private void button2_Press(object sender, EventArgs e)
        {
            mediaView1.Pause(flag);
            flag = !flag;
        }
    }
}