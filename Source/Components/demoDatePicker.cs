using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Components
{
    partial class demoDatePicker : Smobiler.Core.Controls.MobileForm
    {
        public demoDatePicker()
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

        }

        private void btnShow_Press(object sender, EventArgs e)
        {
         
        }

        private void datePicker12_ValueChanged(object sender, EventArgs e)
        {
            Toast("触发事件");
        }
    }
}