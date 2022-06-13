using Smobiler.Core;
using System;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoMobileClient : Smobiler.Core.Controls.MobileForm
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
            this.button1 = new Smobiler.Core.Controls.Button();
            this.button2 = new Smobiler.Core.Controls.Button();
            this.button3 = new Smobiler.Core.Controls.Button();
            this.button4 = new Smobiler.Core.Controls.Button();
            this.mobileClient1 = new Smobiler.Plugins.MobileClient();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "MobileClient";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.Text = "android  闹钟";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(84, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 35);
            this.button2.Text = "ios  闹钟";
            this.button2.Press += new System.EventHandler(this.button2_Press);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(84, 229);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 35);
            this.button3.Text = "日历";
            this.button3.Press += new System.EventHandler(this.button3_Press);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(84, 287);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 35);
            this.button4.Text = "息屏";
            this.button4.Press += new System.EventHandler(this.button4_Press);
            // 
            // mobileClient1
            // 
            this.mobileClient1.Name = "mobileClient1";
            // 
            // demoMobileClient
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.mobileClient1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.button1,
            this.button2,
            this.button3,
            this.button4});
            this.Name = "demoMobileClient";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Button button1;
        private Core.Controls.Button button2;
        private Core.Controls.Button button3;
        private Core.Controls.Button button4;
        private Smobiler.Plugins.MobileClient mobileClient1;
    }
}