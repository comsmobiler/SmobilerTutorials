using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Devices
{
    partial class demoP380 : Smobiler.Core.Controls.MobileForm
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
            this.p380Printer1 = new Smobiler.Device.P380Printer();
            this.button1 = new Smobiler.Core.Controls.Button();
            // 
            // p380Printer1
            // 
            this.p380Printer1.Name = "p380Printer1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 30);
            this.button1.Text = "组协议打印";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // demoP380
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.p380Printer1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.button1});
            this.Name = "demoP380";

        }
        #endregion

        private Device.P380Printer p380Printer1;
        private Core.Controls.Button button1;
    }
}