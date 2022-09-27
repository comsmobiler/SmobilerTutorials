using Smobiler.Core;
using Smobiler.Core.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoCAPTCHA : Smobiler.Core.Controls.MobileForm
    {
        public demoCAPTCHA() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void demoCAPTCHA_Load(object sender, EventArgs e)
        {
            //获取bin\Resource\Image\1.png的url
            string url = MobileResourceManager.GetResourceURL(this.Client.SessionID, "1.png", MobileResourceManager.DefaultImagePath);
            captcha1.Url = url;

        }

        private void captcha1_OnChange(object sender, Smobiler.Plugins.CAPTCHAResultArgs e)
        {
            Toast("验证结果：" + e.Result.ToString());
        }



        private void captcha1_OnError(object sender, ComponentResultArgs e)
        {
            Toast(e.error);
        }
    }
}