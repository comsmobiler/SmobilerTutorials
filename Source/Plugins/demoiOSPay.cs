using Smobiler.Core;
using Smobiler.Core.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoiOSPay : Smobiler.Core.Controls.MobileForm
    {
        public demoiOSPay() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Press(object sender, EventArgs e)
        {
            iOSPay1.CancelOrder((obj, args) => {
                if (args.isError)
                    Toast(args.error);
                else
                    Toast("success");
            });
        }

        private void button1_Press(object sender, EventArgs e)
        {
            iOSPay1.Pay(textBox1.Text.Trim(), (obj, args) =>
            {
                if (args.isError)
                    Toast(args.error);
                else
                    Toast(args.Purchase);
            });
        }

        private void button3_Press(object sender, EventArgs e)
        {
            iOSPay1.ConfirmOrder((obj, args) =>
            {
                if (args.isError)
                    Toast(args.error);
                else
                {
                    if (args.IapUnverifyOrdersArray.Count > 0)
                    {
                        string str = "";
                        int i = 0;
                        foreach (var item in args.IapUnverifyOrdersArray)
                        {
                            var serializer = new JavaScriptSerializer();
                            var json = serializer.Serialize(item);
                            str = "item " + i.ToString() + "       " + json.ToString();
                            i++;
                        }
                        Toast(str);
                    }
                }
            });
        }
    }
}