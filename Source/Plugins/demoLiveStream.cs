using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoLiveStream : Smobiler.Core.Controls.MobileForm
    {
        public demoLiveStream() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnfilter_Press(object sender, EventArgs e)
        {
            liveStream1.Filter = !liveStream1.Filter;
            btnfilter.Text = "filter" + " " + liveStream1.Filter.ToString();
        }

        private void btnstartStreaming_Press(object sender, EventArgs e)
        {
            liveStream1.Play = false;
            liveStream1.Play = true;
        }

        private void btnstopStreaming_Press(object sender, EventArgs e)
        {
            liveStream1.Play = false;
        }

        private void btnswapCamera_Press(object sender, EventArgs e)
        {
            liveStream1.SwapCamera = !liveStream1.SwapCamera;
        }

        private void liveStream1_OnChanged(object sender, Smobiler.Plugins.LiveStreamOnChangedEventArgs e)
        {
            Toast(e.State.ToString());
        }
    }
}