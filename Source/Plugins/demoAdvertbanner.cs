using Smobiler.Core;
using Smobiler.Core.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoAdvertbanner : Smobiler.Core.Controls.MobileForm
    {
        public demoAdvertbanner() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

    

        private void demoAdvertbanner_Load(object sender, EventArgs e)
        {

        }

        private void advertBanner1_OnChange(object sender, ComponentResultArgs e)
        {
            if (e.isError == true)
                Toast(e.error);
            else
                Toast("success");
        }
    }
}