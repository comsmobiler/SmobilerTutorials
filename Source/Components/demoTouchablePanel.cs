using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Components
{
    partial class demoTouchablePanel : Smobiler.Core.Controls.MobileForm
    {
        public demoTouchablePanel()
            : base()
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
            Toast("LongPress");
        }

        private void panel3_LongPress(object sender, EventArgs e)
        {
            Toast("LongPress");
        }

        private void panel3_Press(object sender, EventArgs e)
        {
            Toast("Press");
        }
    }
}