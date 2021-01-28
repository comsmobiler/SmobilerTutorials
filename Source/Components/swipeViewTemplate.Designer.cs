using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Components
{
    partial class swipeViewTemplate : Smobiler.Core.Controls.MobileUserControl
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
            this.button1 = new Smobiler.Core.Controls.Button();
            // 
            // button1
            // 
            this.button1.BorderRadius = 0;
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 40);
            this.button1.Text = "关闭侧滑";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // swipeViewTemplate
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.button1});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Size = new System.Drawing.Size(60, 40);
            this.Name = "swipeViewTemplate";

        }
        #endregion

        private Core.Controls.Button button1;
    }
}