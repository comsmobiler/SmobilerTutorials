using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Components
{
    partial class demoPanel : Smobiler.Core.Controls.MobileForm
    {
        public demoPanel() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel4_Press(object sender, EventArgs e)
        {
            Toast("Press");
        }

        private void panel4_LongPress(object sender, EventArgs e)
        {
            Toast("Press");
        }

        private void panel3_Press(object sender, EventArgs e)
        {
            Toast("Press Image");
        }

        private void panel3_LongPress(object sender, EventArgs e)
        {
            Toast("Press Image");
        }

        private void panel3_ReachEnd(object sender, EventArgs e)
        {
            Toast("Reach End");
        }

        private void btnScrollToBottom_Press(object sender, EventArgs e)
        {
            panel.ScrollToBottom();
        }

        private void btnScrollToTop_Press(object sender, EventArgs e)
        {
            panel.ScrollToTop();
        }
    }
}