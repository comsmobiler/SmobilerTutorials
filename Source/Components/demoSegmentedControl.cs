using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Components
{
    partial class demoSegmentedControl : Smobiler.Core.Controls.MobileForm
    {
        public demoSegmentedControl()
            : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void segmentedControl7_SelectedIndexChanged(object sender, EventArgs e)
        {
            Toast(segmentedControl7.SelectedItem);
        }
    }
}