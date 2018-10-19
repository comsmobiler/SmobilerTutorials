using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Components
{
    partial class demoSpinner : Smobiler.Core.Controls.MobileForm
    {
        public demoSpinner()
            : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }


        private void spinner3_ItemSelected(object sender, SpinnerItemSelectedEventArgs e)
        {
            Toast(e.Item);
        }
    }
}