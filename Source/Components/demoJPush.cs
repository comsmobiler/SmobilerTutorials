using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using Smobiler.Utility.JPush;

namespace Smobiler.Tutorials.Components
{
    partial class demoJPush : Smobiler.Core.Controls.MobileForm
    {
        public demoJPush()
            : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private static string appKey = "";
        private static string appSecret = "";
        PushClient client = new PushClient(appKey, appSecret);
        private void button1_Press(object sender, EventArgs e)
        {
            this.Client.Push.SetAlias(this.textBox1.Text, (obj, args) =>
            {
                if (args.isError == true)
                    this.Toast(args.error);
                else
                    this.Toast("Success");
            });
        }

        private void button2_Press(object sender, EventArgs e)
        {
            client.Push(textBox2.Text, textBox1.Text);
        }

        private void button3_Press(object sender, EventArgs e)
        {
            client.PushAll(textBox2.Text, PushPlatform.android);
        }

        private void button4_Press(object sender, EventArgs e)
        {
            client.PushAlert(textBox2.Text, textBox1.Text, textBox1.Text);
        }

        private void button5_Press(object sender, EventArgs e)
        {
            client.PushAlertAll(textBox2.Text, textBox1.Text, PushPlatform.android);
        }

        private void button6_Press(object sender, EventArgs e)
        {
            client.PushURL(textBox2.Text, "https://www.baidu.com/", textBox1.Text);
        }

        private void button7_Press(object sender, EventArgs e)
        {
            client.PushURLAll(textBox2.Text, "https://www.baidu.com/", PushPlatform.android);
        }

        private void button8_Press(object sender, EventArgs e)
        {
            client.PushClientCallBack(textBox2.Text, textBox2.Text, textBox1.Text);
        }

        private void button9_Press(object sender, EventArgs e)
        {
            client.PushClientCallBackAll(textBox2.Text, textBox2.Text, PushPlatform.android);
        }

        private void button10_Press(object sender, EventArgs e)
        {
            //client.PushBigText(textBox2.Text, textBox2.Text, textBox1.Text, textBox1.Text);
        }

        private void button11_Press(object sender, EventArgs e)
        {
            //client.PushBigTextAll(textBox2.Text, textBox2.Text, textBox1.Text,PushPlatform.all);
        }

    }
}