using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Plugins
{
    partial class demoJsCodeCompiler : Smobiler.Core.Controls.MobileForm
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
            this.button1 = new Smobiler.Core.Controls.Button();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.jsCodeCompiler1 = new Smobiler.Plugins.JsCodeCompiler();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.title1 = new Smobiler.Core.Controls.Title();
            this.button2 = new Smobiler.Core.Controls.Button();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.Text = "震动";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(18, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 265);
            this.label1.Text = "Js震动功能,可先网上搜索代码\r\nplatform相关功能详见 https://reactnative.cn/docs/vibration/ 里面的 API\r\n添" +
    "加JsCodeCompiler组件\r\n可使用方法Run（编译并执行）";
            // 
            // jsCodeCompiler1
            // 
            this.jsCodeCompiler1.Name = "jsCodeCompiler1";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(18, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 35);
            this.label2.Text = "此插件仅支持ios";
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "JsCodeCompiler";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(96, 443);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.Text = "打开微信";
            this.button2.Press += new System.EventHandler(this.button2_Press);
            // 
            // demoJsCodeCompiler
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.jsCodeCompiler1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.button1,
            this.label1,
            this.label2,
            this.title1,
            this.button2});
            this.Name = "demoJsCodeCompiler";

        }
        #endregion

        private Smobiler.Core.Controls.Button button1;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Plugins.JsCodeCompiler jsCodeCompiler1;
        private Smobiler.Core.Controls.Label label2;
        private Core.Controls.Title title1;
        private Core.Controls.Button button2;
    }
}