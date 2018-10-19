using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Components
{
    partial class demoImage : Smobiler.Core.Controls.MobileForm
    {
        public demoImage()
            : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void demoImage_Load(object sender, EventArgs e)
        {
 
        }

        private void button1_Press(object sender, EventArgs e)
        {
            //这里动态生成一个图像
            var image = new System.Drawing.Bitmap(300, 300);
            var g = System.Drawing.Graphics.FromImage(image);
            //写上当前时间
            g.DrawString(DateTime.Now.ToString(), new System.Drawing.Font("宋体", 20), new System.Drawing.SolidBrush(System.Drawing.Color.Red), 0, 0);
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                //获取图像资源
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                //设置数据为byte
                this.image5.ResourceMode = ResourceMode.Data;
                this.image5.ResourceData = ms.GetBuffer();
                ms.Close();
            }
        }
    }
}