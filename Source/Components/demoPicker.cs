using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Components
{
    partial class demoPicker : Smobiler.Core.Controls.MobileForm
    {
        public demoPicker()
            : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picker3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Toast(picker3.SelectedItem);
        }
    }
}