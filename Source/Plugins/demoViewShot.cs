using Smobiler.Core;
using Smobiler.Core.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoViewShot : Smobiler.Core.Controls.MobileForm
    {
        public demoViewShot() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRectangle_Press(object sender, EventArgs e)
        {
            viewShot1.Save();
        }

        private void viewShot1_OnViewShotImageSave(object sender, BinaryResultArgs e)
        {
            e.SaveFile("shot.png");
            image1.ResourceID = "shot.png";
            image1.Refresh(); 
        }
    }
}