using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using Smobiler.Core.Web;

namespace Smobiler.Tutorials.Samples
{
    partial class demoHttpResource : Smobiler.Core.Controls.MobileForm
    {

        static demoHttpResource()
        {
            MobileServer.RegisterHttpHandler("demohttpresource", new DemoHttpResourceHandler());
        }

        private void demoHttpResource_Load(object sender, EventArgs e)
        {
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdateImage_Press(object sender, EventArgs e)
        {
            //刷新图像，地址设置为当前请求的Url地址
            //这里添加timespan只是为了刷新资源，如果资源不变的话，不需要添加timespan
            this.image1.ResourceID = string.Format("http://{0}:{1}/demohttpresource?timespan={2}", this.Client.HostAddress, this.Client.HostHttpPort, DateTime.Now.Millisecond);
        }
    }


    class DemoHttpResourceHandler : IHttpHandler
    {
        void IHttpHandler.ProcessRequest(IHttpContext context, HttpHandlerData handlerdata)
        {
            //这里可以通过context.Request获取http请求的数据
            
            //这里动态生成一个图像
            var image = new System.Drawing.Bitmap(300, 300);
            var g = System.Drawing.Graphics.FromImage(image);
            //写上当前时间
            g.DrawString(DateTime.Now.ToString(), new System.Drawing.Font("宋体", 20), new System.Drawing.SolidBrush(System.Drawing.Color.Red), 0, 0);
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                //获取图像资源
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                var imageData = ms.GetBuffer();
                //发送图片，使用标准的Response
                context.Response.ContentLength64 = imageData.Length;
                context.Response.ContentType = "image/png";
                context.Response.OutputStream.Write(imageData, 0, imageData.Length);
                context.Response.OutputStream.Flush();
                context.Response.OutputStream.Close();
            }
        }
    }
}