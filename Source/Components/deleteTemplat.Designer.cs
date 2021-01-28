using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Components
{
    partial class deleteTemplate : Smobiler.Core.Controls.MobileUserControl
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
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.BorderRadius = 0;
            this.button1.Flex = 1;
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 30);
            this.button1.Text = "删除";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // deleteTemplate
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.button1});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Name = "deleteTemplate";
            this.Size = new System.Drawing.Size(40, 40);
            this.Name = "deleteTemplate";

        }
        #endregion

        private Core.Controls.Button button1;
    }
}