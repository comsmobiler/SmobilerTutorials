using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoSwitchSelector : Smobiler.Core.Controls.MobileForm
    {
        public demoSwitchSelector() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void switchSelector1_OnPress(object sender, Smobiler.Plugins.SwitchSelectorOnPressEventArgs e)
        {
            Toast("当前点击项为"+e.Option.Text);
        }
    }
}