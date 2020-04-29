using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoTTS : Smobiler.Core.Controls.MobileForm
    {
        public demoTTS() : base()
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
            tts1.Speak("播放成功与否,成功回调在播放完成后返回 This call is required by the SmobilerForm.", Smobiler.Plugins.TTS.TTSLanguage.zh, 1.5f, (obj, args) =>
            {
                if (args.isError == true)
                    this.Toast("Error: " + args.error);
                else
                    this.Toast("成功");
            });
        }

        private void button2_Press(object sender, EventArgs e)
        {
            tts1.Stop((obj, args) =>
            {
                if (args.isError == true)
                    this.Toast("Error: " + args.error);
                else
                    this.Toast("成功");
            });
        }

        private void button3_Press(object sender, EventArgs e)
        {
            tts1.Speak("This call is required by the SmobilerForm.", Smobiler.Plugins.TTS.TTSLanguage.en, 1, (obj, args) =>
            {
                if (args.isError == true)
                    this.Toast("Error: " + args.error);
                else
                    this.Toast("成功");
            });
        }
    }
}