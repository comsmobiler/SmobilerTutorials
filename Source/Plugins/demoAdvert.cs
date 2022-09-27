using Smobiler.Core;
using Smobiler.Core.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoAdvert : Smobiler.Core.Controls.MobileForm
    {
        public demoAdvert() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Press(object sender, EventArgs e)
        {
            // 第二个参数为激励广告位id
            advert1.ShowAd(true, "1084610515032654", (obj, args) => {
                if (args.isError)
                    Toast("errorcode: " + args.errorCode.ToString() + " error:" + args.error);
            });
        }

        private void button2_Press(object sender, EventArgs e)
        {
            // 第二个参数为激励广告位id
            advert1.ShowAd(true, "5094019749078563", (obj, args) => {
                if (args.isError)
                    Toast("errorcode: " + args.errorCode.ToString() + " error:" + args.error);
            });
        }
    }
}