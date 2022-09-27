using Smobiler.Core;
using Smobiler.Core.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoMobileClient : Smobiler.Core.Controls.MobileForm
    {
        public demoMobileClient() : base()
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
            mobileClient1.SetAlarm(5, 25, "xxxxx", true, (obj, args) => {

                if (args.isError == false)
                    Toast("success");
                else
                    Toast(args.error);

            });
        }

        private void button2_Press(object sender, EventArgs e)
        {
            mobileClient1.SetAlarm(8, 25, "xxxxx", "key", true, (obj, args) => {

                if (args.isError == false)
                    Toast("success");
                else
                    Toast(args.error);

            });
        }

        private void button3_Press(object sender, EventArgs e)
        {
            mobileClient1.SetCalendars(DateTime.Now, DateTime.Now.AddDays(7), "titiles1", "呀呀呀", (obj, args) =>
            {
                if (args.isError == false)
                    Toast("success");
                else
                    Toast(args.error);

            });
        }
        private bool flag = false;
        private void button4_Press(object sender, EventArgs e)
        {
            mobileClient1.SetIdleTimerDisabled(flag, (obj, args) => {

                if (args.isError == false)
                    Toast("success");
                else
                    Toast(args.error);
                flag = !flag;
            });
        }

        private void button5_Press(object sender, EventArgs e)
        {
            mobileClient1.SetScreenShot(false, (obj, args) => {

                if (args.isError == false)
                    Toast("success");
                else
                    Toast(args.error);
            });
        }
    }
}