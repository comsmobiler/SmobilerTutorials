using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoLiveStreamPlayer : Smobiler.Core.Controls.MobileForm
    {
        public demoLiveStreamPlayer() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void liveStreamPlayer1_StateChanged(object sender, Smobiler.Plugins.LiveStreamStateChangedEventArgs e)
        {
            Toast(e.State.ToString());
        }
    }
}