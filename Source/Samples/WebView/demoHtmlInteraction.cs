using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Samples.WebView
{
    partial class demoHtmlInteraction : Smobiler.Core.Controls.MobileForm
    {
        public demoHtmlInteraction() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        private void btnSetCookie_Press(object sender, EventArgs e)
        {
            //PostMessage用于向网页发送消息，类型为字符串，具体处理详见jsCookie.html中的说明。
            //这里使用json格式，为了便于示例，使用字符串拼接，实际中建议使用Json序列化方式操作。
            this.webView1.PostMessage("{\"action\":\"setCookie\",\"data\":{\"name\":\"smo\",\"value\":\"smopwd\"}}");

        }

        private void btnGetCookie_Press(object sender, EventArgs e)
        {
            //PostMessage用于向网页发送消息，类型为字符串，具体处理详见jsCookie.html中的说明。
            //这里使用json格式，为了便于示例，使用字符串拼接，实际中建议使用Json序列化方式操作。
            this.webView1.PostMessage("{\"action\":\"getCookie\",\"data\":{\"name\":\"smo\"}}");
        }

        private void btnDelCookie_Press(object sender, EventArgs e)
        {
            //PostMessage用于向网页发送消息，类型为字符串，具体处理详见jsCookie.html中的说明。
            //这里使用json格式，为了便于示例，使用字符串拼接，实际中建议使用Json序列化方式操作。
            this.webView1.PostMessage("{\"action\":\"delCookie\",\"data\":{\"name\":\"smo\"}}");
        }

        //此方法用于处理OnMessage事件，此事件会在从网页上向控件发送消息时触发，详见jsCookie.html中的说明。
        private void webView1_OnMessage(object sender, WebViewMessageEventArgs e)
        {
            //这里直接弹出消息框显示接收到的数据
            MessageBox.Show("OnMessage: " + e.Message);
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void demoHtmlInteraction_Load(object sender, EventArgs e)
        {
            //在项目中的Resources/Web文件夹下，有jsCookie.html，里面有对JS的说明。
            this.webView1.Url = MobileResourceManager.GetResourceURL(this.Client.SessionID, "jsCookie.html", MobileResourceManager.DefaultWebResourceName);
        }
    }
}