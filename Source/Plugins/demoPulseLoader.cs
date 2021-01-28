using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoPulseLoader : Smobiler.Core.Controls.MobileForm
    {
        public demoPulseLoader() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pulseLoader1_onPress(object sender, EventArgs e)
        {
            Toast("press");
        }
    }
}