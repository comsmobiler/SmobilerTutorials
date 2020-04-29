using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoAudio : Smobiler.Core.Controls.MobileForm
    {
        public demoAudio() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnstart_Press(object sender, EventArgs e)
        {
            audio1.Start();
        }

        private void btnstop_Press(object sender, EventArgs e)
        {
            audio1.Stop();
        }

        private void btnpause_Press(object sender, EventArgs e)
        {
            audio1.Pause();
        }

        private void btnresume_Press(object sender, EventArgs e)
        {
            audio1.Resume();
        }

        private void audio1_Recorded(object sender, Smobiler.Plugins.AudioRecordedEventArgs e)
        {
            Toast(e.URL);
            Toast(e.Status + e.Duration);
            Toast(e.Data.ToString());

            this.Client.PlayAudio(e.URL);
        }
    }
}