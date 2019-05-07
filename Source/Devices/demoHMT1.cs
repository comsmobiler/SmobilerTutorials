using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Devices
{
    partial class demoHMT1 : Smobiler.Core.Controls.MobileForm
    {
        public demoHMT1() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void btnSynthesis_Press(object sender, EventArgs e)
        {
            //播放文字内容
            hmT11.Synthesis("Hello,欢迎使用Smobiler");
        }

        private void btnSetCommands_Press(object sender, EventArgs e)
        {

            //注册语音识别词
            string[] Commands = { "文本", "拍照" };
            hmT11.SetCommands(Commands);
        }

        private void btnRestoreCommands_Press(object sender, EventArgs e)
        {
            //清空语音识别词
            hmT11.RestoreCommands();
        }
        private void hmT11_Recognized(object sender, Smobiler.Device.HMT1EventArgs e)
        {
            Toast("Type:" + e.Type + " Message:" + e.Message);
            if (e.Message == "拍照")
            {
                camera1.GetPhoto();
            }
            else if (e.Message == "文本")
            {
                textBox1.Blur();
                textBox1.Focus();
            }
        }

        private void hmT11_OnNotify(object sender, ComponentResultArgs e)
        {
            if (e.isError == true)
            {
                MessageBox.Show(e.error);
            }
        }
        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void demoHMT1_Load(object sender, EventArgs e)
        {
            btnSetCommands_Press(null, null);
        }

        private void camera1_ImageCaptured(object sender, BinaryResultArgs e)
        {
            if (!e.isError)
            {
                e.SaveFile(e.ResourceID, "./Resources/Image");
                image1.ResourceID = e.ResourceID;
            }
        }

        private void demoHMT1_ForeGround(object sender, EventArgs e)
        {
            btnSetCommands_Press(null, null);
        }
    }
}