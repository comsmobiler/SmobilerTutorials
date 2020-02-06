using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Samples.WebView
{
    partial class demoHtmlInteraction : Smobiler.Core.Controls.MobileForm
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
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.btnSetCookie = new Smobiler.Core.Controls.Button();
            this.btnGetCookie = new Smobiler.Core.Controls.Button();
            this.btnDelCookie = new Smobiler.Core.Controls.Button();
            this.webView1 = new Smobiler.Core.Controls.WebView();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "arrow-left";
            this.title1.Size = new System.Drawing.Size(0, 30);
            this.title1.Text = "demoHtmlInteraction";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnSetCookie,
            this.btnGetCookie,
            this.btnDelCookie});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 60);
            // 
            // btnSetCookie
            // 
            this.btnSetCookie.Name = "btnSetCookie";
            this.btnSetCookie.Size = new System.Drawing.Size(100, 30);
            this.btnSetCookie.Text = "SetCookie";
            this.btnSetCookie.Press += new System.EventHandler(this.btnSetCookie_Press);
            // 
            // btnGetCookie
            // 
            this.btnGetCookie.Location = new System.Drawing.Point(100, 0);
            this.btnGetCookie.Name = "btnGetCookie";
            this.btnGetCookie.Size = new System.Drawing.Size(100, 30);
            this.btnGetCookie.Text = "GetCookie";
            this.btnGetCookie.Press += new System.EventHandler(this.btnGetCookie_Press);
            // 
            // btnDelCookie
            // 
            this.btnDelCookie.Location = new System.Drawing.Point(200, 0);
            this.btnDelCookie.Name = "btnDelCookie";
            this.btnDelCookie.Size = new System.Drawing.Size(100, 30);
            this.btnDelCookie.Text = "DelCookie";
            this.btnDelCookie.Press += new System.EventHandler(this.btnDelCookie_Press);
            // 
            // webView1
            // 
            this.webView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView1.Location = new System.Drawing.Point(0, 100);
            this.webView1.Name = "webView1";
            this.webView1.Size = new System.Drawing.Size(300, 300);
            this.webView1.OnMessage += new Smobiler.Core.Controls.WebViewMessageEventHandler(this.webView1_OnMessage);
            // 
            // demoHtmlInteraction
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel1,
            this.webView1});
            this.Load += new System.EventHandler(this.demoHtmlInteraction_Load);
            this.Name = "demoHtmlInteraction";

        }
        #endregion
        private Smobiler.Core.Controls.Title title1;
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Button btnSetCookie;
        private Smobiler.Core.Controls.Button btnGetCookie;
        private Smobiler.Core.Controls.Button btnDelCookie;
        private Smobiler.Core.Controls.WebView webView1;
    }
}