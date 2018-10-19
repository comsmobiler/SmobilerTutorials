using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Components
{
    partial class demoSlider : Smobiler.Core.Controls.MobileForm
    {
        public demoSlider()
            : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFocus_Press(object sender, EventArgs e)
        {

        }

        private void btnBlur_Press(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TouchEnter(object sender, EventArgs e)
        {

        }

        private void textBox19_TouchLeave(object sender, EventArgs e)
        {

        }

        private void slider6_ValueChanged(object sender, EventArgs e)
        {
            Toast(slider6.Value.ToString());
        }
    }
}