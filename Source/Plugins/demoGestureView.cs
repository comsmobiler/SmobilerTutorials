using Smobiler.Core;
using Smobiler.Core.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoGestureView : Smobiler.Core.Controls.MobileForm
    {
        public demoGestureView() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void button1_Press(object sender, EventArgs e)
        {

        }

        private void button2_Press(object sender, EventArgs e)
        {

        }

        private void gestureView1_onChanged(object sender, Smobiler.Plugins.GestureViewChangeEventArgs e)
        {
            Toast(e.Action.ToString());
        }
    }
}