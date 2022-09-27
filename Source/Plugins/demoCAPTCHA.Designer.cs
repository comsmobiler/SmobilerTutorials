using Smobiler.Core;
using System;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoCAPTCHA : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm
        //It can be modified using the SmobilerForm.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.title1 = new Smobiler.Core.Controls.Title();
            this.captcha1 = new Smobiler.Plugins.CAPTCHA();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "CAPTCHA 图形验证";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // captcha1
            // 
            this.captcha1.FragmentSize = 60;
            this.captcha1.Location = new System.Drawing.Point(21, 61);
            this.captcha1.Name = "captcha1";
            this.captcha1.Size = new System.Drawing.Size(250, 200);
            this.captcha1.OnChange += new Smobiler.Plugins.CAPTCHAOnChangedEventHandler(this.captcha1_OnChange);
            this.captcha1.OnError += new Smobiler.Core.Controls.ComponentOnResultHandler(this.captcha1_OnError);
            // 
            // demoCAPTCHA
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.captcha1});
            this.Load += new System.EventHandler(this.demoCAPTCHA_Load);
            this.Name = "demoCAPTCHA";

        }
        #endregion

        private Core.Controls.Title title1;
        private Smobiler.Plugins.CAPTCHA captcha1;
    }
}