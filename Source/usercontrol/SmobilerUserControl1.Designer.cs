using System;
using Smobiler.Core;
namespace Smobiler.Tutorials
{
    partial class SmobilerUserControl1 : Smobiler.Core.Controls.MobileUserControl
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
            this.label1 = new Smobiler.Core.Controls.Label();
            // 
            // label1
            // 
            this.label1.DataMember = "Label";
            this.label1.DisplayMember = "Label";
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 50);
            this.label1.Text = "label1";
            // 
            // SmobilerUserControl1
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1});
            this.Size = new System.Drawing.Size(0, 50);
            this.Name = "SmobilerUserControl1";

        }
        #endregion

        private Core.Controls.Label label1;
    }
}