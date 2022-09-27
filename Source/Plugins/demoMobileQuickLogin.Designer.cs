using Smobiler.Core;
using System;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoMobileQuickLogin : Smobiler.Core.Controls.MobileForm
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
            this.mobileQuickLogin1 = new Smobiler.Plugins.MobileQuickLogin();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.textBox1 = new Smobiler.Core.Controls.TextBox();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.button2 = new Smobiler.Core.Controls.Button();
            this.button3 = new Smobiler.Core.Controls.Button();
            this.textBox2 = new Smobiler.Core.Controls.TextBox();
            this.button4 = new Smobiler.Core.Controls.Button();
            this.button5 = new Smobiler.Core.Controls.Button();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "MobilerQuickLogin";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // mobileQuickLogin1
            // 
            this.mobileQuickLogin1.Name = "mobileQuickLogin1";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 52);
            this.label1.Text = "注意：web端一键登录和本机号码验证都需要使用流量，不支持wifi";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 181);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 35);
            this.textBox1.WaterMarkText = "请输入手机号";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 35);
            this.button1.Text = "APP 手机号一键登录";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 35);
            this.button2.Text = "APP 本机号码验证";
            this.button2.Press += new System.EventHandler(this.button2_Press);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(29, 298);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(230, 35);
            this.button3.Text = "Web 手机号一键登录";
            this.button3.Press += new System.EventHandler(this.button3_Press);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(35, 358);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(224, 35);
            this.textBox2.WaterMarkText = "请输入手机号";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(29, 419);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(230, 35);
            this.button4.Text = "Web 本机号码验证";
            this.button4.Press += new System.EventHandler(this.button4_Press);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(29, 477);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(230, 35);
            this.button5.Text = "删除凭证";
            this.button5.Press += new System.EventHandler(this.button5_Press);
            // 
            // demoMobileQuickLogin
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.mobileQuickLogin1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.label1,
            this.textBox1,
            this.button1,
            this.button2,
            this.button3,
            this.textBox2,
            this.button4,
            this.button5});
            this.Load += new System.EventHandler(this.demeMobileQuickLogin_Load);
            this.Name = "demoMobileQuickLogin";

        }
        #endregion

        private Core.Controls.Title title1;
        private Smobiler.Plugins.MobileQuickLogin mobileQuickLogin1;
        private Core.Controls.Label label1;
        private Core.Controls.TextBox textBox1;
        private Core.Controls.Button button1;
        private Core.Controls.Button button2;
        private Core.Controls.Button button3;
        private Core.Controls.TextBox textBox2;
        private Core.Controls.Button button4;
        private Core.Controls.Button button5;
    }
}