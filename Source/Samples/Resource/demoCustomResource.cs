using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Samples
{
    partial class demoCustomResource : Smobiler.Core.Controls.MobileForm
    {
 
        static demoCustomResource()
        {
            MobileServer.RegisterExtendHandler(Smobiler.Core.Web.ExtendHandlerType.ResourceGet, typeof(HttpCustomResourceHandler));
        }

        private void demoCustomResource_Load(object sender, EventArgs e)
        {
            //这里必须设置为Customize
            this.image1.ResourceMode = ResourceMode.Customize;
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdateImage_Press(object sender, EventArgs e)
        {
            //刷新图像
            this.image1.ResourceID = "test";
            this.image1.Refresh();
        }
    }


    class HttpCustomResourceHandler : Smobiler.Core.Web.IExtendHandler
    {
        public Smobiler.Core.Web.ExtendHandlerStatusArgs Excute(Smobiler.Core.Web.ExtendHandlerArgs e)
        {
            Smobiler.Core.Web.ExtendHandlerResourceGetArgs args = e as Smobiler.Core.Web.ExtendHandlerResourceGetArgs;
            var id = args.ResourceID;

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
                //设置返回数据为byte
                args.Data = new BinaryResultArgs(imageData, args.ResourceID);
                ms.Close();
                return args;
            }
        }
    }
}