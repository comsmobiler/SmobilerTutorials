using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Controls
{
    partial class demoImageButton : Smobiler.Core.Controls.MobileForm
    {
        public demoImageButton()
            : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void imageButton1_Press(object sender, EventArgs e)
        {
            MessageBox.Show("Press");
        }

        private void imageButton1_LongPress(object sender, EventArgs e)
        {
            MessageBox.Show("LongPress");
        }
    }
}