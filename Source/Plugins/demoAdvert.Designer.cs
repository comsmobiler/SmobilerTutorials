using Smobiler.Core;
using System;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoAdvert : Smobiler.Core.Controls.MobileForm
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
            this.label1 = new Smobiler.Core.Controls.Label();
            this.advert1 = new Smobiler.Plugins.Advert();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.button2 = new Smobiler.Core.Controls.Button();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "Advert";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(85, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 35);
            this.label1.Text = "广告插件";
            // 
            // advert1
            // 
            this.advert1.Name = "advert1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.Text = "Android点击";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(85, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 35);
            this.button2.Text = "iOS点击";
            this.button2.Press += new System.EventHandler(this.button2_Press);
            // 
            // demoAdvert
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.advert1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.label1,
            this.button1,
            this.button2});
            this.Name = "demoAdvert";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Label label1;
        private Smobiler.Plugins.Advert advert1;
        private Core.Controls.Button button1;
        private Core.Controls.Button button2;
    }
}