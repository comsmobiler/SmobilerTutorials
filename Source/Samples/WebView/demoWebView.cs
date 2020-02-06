using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Data;
using System.IO;

namespace Smobiler.Tutorials.Samples
{
    partial class demoWebView : Smobiler.Core.Controls.MobileForm
    {

        private void demoListViewRefresh_Load(object sender, EventArgs e)
        {
            //配合LocalHtml使用，生成文件
            var localHtmlPath = Path.Combine(MobileResourceManager.DefaultWebPath, "demo.html");
            if (File.Exists(localHtmlPath)==false)
            {
              using( FileStream stream=  File.Create(localHtmlPath))
              {
                  string demoHtml="<Html><Head></Head><Body>Hello LocalHtml</Body></Html>";
                  byte[] demoData=System.Text.Encoding.UTF8.GetBytes(demoHtml);
                  stream.Write(demoData,0,demoData.Length);
                  stream.Close();
              }
            }

            //配合Dynamic使用
            if (MobileServer.IsRegisterHttpHandler("dynamic")==false)
            {
                MobileServer.RegisterHttpHandler("dynamic", new DynamicHttpContentHandler());
            }
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLocalHtml_Press(object sender, EventArgs e)
        {
            this.webView1.Url = MobileResourceManager.GetResourceURL(this.Client.SessionID, "web/demo.html");
        }

        private void btnDymaticHtml_Press(object sender, EventArgs e)
        {
            this.webView1.Url = MobileResourceManager.GetResourceURL(this.Client.SessionID, "dynamic");
        }

        private void btnSmobilerUrl_Press(object sender, EventArgs e)
        {
            this.webView1.Url = "www.smobiler.com";
        }
    }

    class DynamicHttpContentHandler:Smobiler.Core.Web.IHttpHandler
    {

        public void ProcessRequest(System.Net.HttpListenerContext context, Smobiler.Core.Web.HttpHandlerData handlerdata)
        {
            string rawResponse=string.Format("<Html><Head></Head><Body>Hello Dynamic Time {0}</Body></Html>",DateTime.Now.ToString());
            byte[] dataResponse= System.Text.Encoding.UTF8 .GetBytes(rawResponse);
            context.Response.ContentLength64 = dataResponse.Length;
            context.Response.StatusCode = 200;
            context.Response.OutputStream.Write(dataResponse, 0, dataResponse.Length);
            context.Response.OutputStream.Close();
        }
    }
}