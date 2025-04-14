using Smobiler.Core;
using Smobiler.Core.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Smobiler.Tutorials.Samples.Layout
{
    partial class demoLabel : Smobiler.Core.Controls.MobileForm
    {
        public demoLabel() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label2.Text = textBox1.Text;
        }
    }
}