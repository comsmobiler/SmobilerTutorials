using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Controls
{
    partial class demoToolBar : Smobiler.Core.Controls.MobileForm
    {
        public demoToolBar()
            : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();               
        }

        private void toolBar5_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            Toast(e.Name);
        }
    }
}