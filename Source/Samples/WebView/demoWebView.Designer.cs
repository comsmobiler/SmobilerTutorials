using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Samples
{
    partial class demoWebView : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public demoWebView()
            : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call
        }

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
            this.webView1 = new Smobiler.Core.Controls.WebView();
            this.btnLocalHtml = new Smobiler.Core.Controls.Button();
            this.btnDymaticHtml = new Smobiler.Core.Controls.Button();
            this.btnSmobilerUrl = new Smobiler.Core.Controls.Button();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "arrow-left";
            this.title1.Size = new System.Drawing.Size(0, 30);
            this.title1.Text = "demoWebViewLocal";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // webView1
            // 
            this.webView1.Flex = 1;
            this.webView1.Name = "webView1";
            this.webView1.Size = new System.Drawing.Size(0, 300);
            // 
            // btnLocalHtml
            // 
            this.btnLocalHtml.Name = "btnLocalHtml";
            this.btnLocalHtml.Size = new System.Drawing.Size(0, 30);
            this.btnLocalHtml.Text = "加载本地HTML文件";
            this.btnLocalHtml.Press += new System.EventHandler(this.btnLocalHtml_Press);
            // 
            // btnDymaticHtml
            // 
            this.btnDymaticHtml.Name = "btnDymaticHtml";
            this.btnDymaticHtml.Size = new System.Drawing.Size(0, 30);
            this.btnDymaticHtml.Text = "动态生成HTML内容";
            this.btnDymaticHtml.Press += new System.EventHandler(this.btnDymaticHtml_Press);
            // 
            // btnSmobilerUrl
            // 
            this.btnSmobilerUrl.Name = "btnSmobilerUrl";
            this.btnSmobilerUrl.Size = new System.Drawing.Size(0, 30);
            this.btnSmobilerUrl.Text = "修改为Smobiler官网链接";
            this.btnSmobilerUrl.Press += new System.EventHandler(this.btnSmobilerUrl_Press);
            // 
            // demoWebView
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.webView1,
            this.btnLocalHtml,
            this.btnDymaticHtml,
            this.btnSmobilerUrl});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Load += new System.EventHandler(this.demoListViewRefresh_Load);
            this.Name = "demoWebView";

        }
        #endregion

        private Smobiler.Core.Controls.Title title1;
        private Smobiler.Core.Controls.WebView webView1;
        private Smobiler.Core.Controls.Button btnLocalHtml;
        private Smobiler.Core.Controls.Button btnDymaticHtml;
        private Smobiler.Core.Controls.Button btnSmobilerUrl;
    }
}