using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Components
{
    partial class gridViewTemplate : Smobiler.Core.Controls.MobileUserControl
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
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.image1 = new Smobiler.Core.Controls.Image();
            this.label1 = new Smobiler.Core.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image1,
            this.label1});
            this.panel1.Flex = 1;
            this.panel1.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 100);
            this.panel1.Touchable = true;
            this.panel1.Press += new System.EventHandler(this.panel1_Press);
            // 
            // image1
            // 
            this.image1.DisplayMember = "img";
            this.image1.Flex = 5;
            this.image1.Margin = new Smobiler.Core.Controls.Margin(10F, 5F, 10F, 5F);
            this.image1.Name = "image1";
            this.image1.Size = new System.Drawing.Size(0, 43);
            // 
            // label1
            // 
            this.label1.DisplayMember = "lab";
            this.label1.Flex = 2;
            this.label1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label1.Margin = new Smobiler.Core.Controls.Margin(0F, 0F, 0F, 5F);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 27);
            this.label1.Text = "label1";
            // 
            // gridViewTemplate
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Size = new System.Drawing.Size(70, 70);
            this.Name = "gridViewTemplate";

        }
        #endregion

        private Core.Controls.Panel panel1;
        private Core.Controls.Image image1;
        private Core.Controls.Label label1;
    }
}