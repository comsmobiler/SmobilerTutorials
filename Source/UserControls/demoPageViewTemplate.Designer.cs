using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.usercontrol
{
    partial class demoPageViewTemplate : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        //SmobilerUserControl overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        //NOTE: The following procedure is required by the SmobilerUserControl
        //It can be modified using the SmobilerUserControl.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.image1 = new Smobiler.Core.Controls.Image();
            // 
            // image1
            // 
            this.image1.DataMember = "image";
            this.image1.DisplayMember = "image";
            this.image1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.image1.Name = "image1";
            this.image1.Size = new System.Drawing.Size(45, 45);
            // 
            // demoPageViewTemplate
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image1});
            this.Size = new System.Drawing.Size(300, 200);
            this.Name = "demoPageViewTemplate";

        }
        #endregion

        private Core.Controls.Image image1;
    }
}