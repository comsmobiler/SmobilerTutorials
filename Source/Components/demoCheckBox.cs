using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Components
{
    partial class demoCheckBox : Smobiler.Core.Controls.MobileForm
    {
        public demoCheckBox()
            : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }



        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            Toast(checkBox9.Checked.ToString());
        }
    }
}