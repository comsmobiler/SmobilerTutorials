using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Controls
{
    partial class demoTitle : Smobiler.Core.Controls.MobileForm
    {
        public demoTitle()
            : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void title7_ImagePress(object sender, EventArgs e)
        {
            Toast("触发事件");
        }
    }
}