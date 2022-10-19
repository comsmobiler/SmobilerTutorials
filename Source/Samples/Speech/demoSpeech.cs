using Smobiler.Core;
using Smobiler.Core.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Smobiler.Tutorials.Samples.Speech
{
    partial class demoSpeech : Smobiler.Core.Controls.MobileForm
    {
        public demoSpeech() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Press(object sender, EventArgs e)
        {
            /// 百度短语音识别文档  https://ai.baidu.com/ai-doc/SPEECH/sk4o0bnzp
            /// 项目中需要引用Baidu.AI
            // 设置APPID/AK/SK  ,在百度AI服务控制台中查看
            var APP_ID = "*******";
            var API_KEY = "************";
            var SECRET_KEY = "***********";
            var client = new Baidu.Aip.Speech.Asr(APP_ID, API_KEY, SECRET_KEY);
            var data = File.ReadAllBytes(Path.Combine(MobileResourceManager.DefaultMediaPath, "16k-48000.m4a"));
            // 可选参数
            var options = new Dictionary<string, object>
            {
                {"dev_pid", 1537}
            };
            client.Timeout = 120000; // 若语音较长，建议设置更大的超时时间. ms
            var result = client.Recognize(data, "m4a", 16000, options);
            Toast(result.ToString());

            ///讯飞语音听写 参考 https://www.xfyun.cn/doc/asr/voicedictation/API.html
        }
    }
}