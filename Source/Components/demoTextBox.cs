using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Components
{
    partial class demoTextBox : Smobiler.Core.Controls.MobileForm
    {
        public demoTextBox()
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
            textBoxFocusOrBlur.Focus();
        }

        private void btnBlur_Press(object sender, EventArgs e)
        {
            textBoxFocusOrBlur.Blur();
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            Toast("TextChanged:"+textBox19.Text);
        }

        private void textBox19_TouchEnter(object sender, EventArgs e)
        {
            Toast("TouchEnter");
        }

        private void textBox19_TouchLeave(object sender, EventArgs e)
        {
            Toast("TouchLeave");
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}