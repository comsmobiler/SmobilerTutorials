using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Components
{
    partial class demoPhoneButton : Smobiler.Core.Controls.MobileForm
    {
        public demoPhoneButton() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void phoneButton1_Press(object sender, EventArgs e)
        {
            Toast("Press");
        }
    }
}