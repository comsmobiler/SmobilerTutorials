using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Components
{
    partial class demoVoiceRecorder : Smobiler.Core.Controls.MobileForm
    {
        public demoVoiceRecorder()
            : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGetRecorderAudio_Press(object sender, EventArgs e)
        {
            voiceRecorder1.GetRecorderAudio();
        }

        private void btnGetRecorderAudioOffline_Press(object sender, EventArgs e)
        {
            voiceRecorder1.GetRecorderAudioOffline();
        }

        private void btnGetClientRecorderAudio_Press(object sender, EventArgs e)
        {
            voiceRecorder1.GetClientRecorderAudio();
        }

        private void voiceRecorder1_RecordedAudio(object sender, BinaryResultArgs e)
        {
            Toast("触发RecordedAudio事件");
        }

        private void voiceRecorder1_ClientRecordedAudio(object sender, ClientResourceResultArgs e)
        {
            Toast("触发ClientRecordedAudio事件");
        }

        private void voiceRecorder1_OfflineRecorderdAudio(object sender, ResourcesResultArgs e)
        {
            Toast("触发OfflineRecorderdAudio事件");
        }
    }
}