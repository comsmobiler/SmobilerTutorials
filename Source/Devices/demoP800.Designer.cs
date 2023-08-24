using Smobiler.Core;
using System;

namespace Smobiler.Tutorials.Devices
{
    partial class demoP800 : Smobiler.Core.Controls.MobileForm
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
            this.button7 = new Smobiler.Core.Controls.Button();
            this.p800Printer1 = new Smobiler.Device.P800Printer();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "P800Printer";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 35);
            this.button1.Text = "切纸";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(44, 84);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(202, 35);
            this.button7.Text = "print";
            this.button7.Press += new System.EventHandler(this.button7_Press);
            // 
            // p800Printer1
            // 
            this.p800Printer1.Name = "p800Printer1";
            // 
            // demoP800
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.p800Printer1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.button1,
            this.button7});
            this.Name = "demoP800";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Button button1;
        private Core.Controls.Button button7;
        private Device.P800Printer p800Printer1;
    }
}