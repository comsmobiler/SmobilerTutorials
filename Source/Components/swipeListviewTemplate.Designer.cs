using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Components
{
    partial class swipeListviewTemplate : Smobiler.Core.Controls.MobileUserControl
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
            this.swipeView1 = new Smobiler.Core.Controls.SwipeView();
            this.label1 = new Smobiler.Core.Controls.Label();
            // 
            // swipeView1
            // 
            this.swipeView1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1});
            this.swipeView1.Name = "swipeView1";
            this.swipeView1.RightControlName = "deleteTemplate";
            this.swipeView1.Size = new System.Drawing.Size(0, 40);
            // 
            // label1
            // 
            this.label1.DisplayMember = "lab";
            this.label1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 40);
            this.label1.Text = "label1";
            // 
            // swipeListviewTemplate
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.swipeView1});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Size = new System.Drawing.Size(200, 40);
            this.Name = "swipeListviewTemplate";

        }
        #endregion

        private Core.Controls.SwipeView swipeView1;
        private Core.Controls.Label label1;
    }
}