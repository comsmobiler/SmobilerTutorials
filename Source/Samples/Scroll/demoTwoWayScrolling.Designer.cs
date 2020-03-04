using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Samples
{
    partial class demoTwoWayScrolling : Smobiler.Core.Controls.MobileForm
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
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.panel3 = new Smobiler.Core.Controls.Panel();
            this.panel4 = new Smobiler.Core.Controls.Panel();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "chevron-left";
            this.title1.Size = new System.Drawing.Size(0, 30);
            this.title1.Text = "双向滚动";
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel2});
            this.panel1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.panel1.Horizontal = true;
            this.panel1.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel1.Name = "panel1";
            this.panel1.Scrollable = true;
            this.panel1.Size = new System.Drawing.Size(0, 205);
            // 
            // panel2
            // 
            this.panel2.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel2.Name = "panel2";
            this.panel2.Scrollable = true;
            this.panel2.Size = new System.Drawing.Size(600, 0);
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel4});
            this.panel3.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel3.Location = new System.Drawing.Point(0, 10);
            this.panel3.Name = "panel3";
            this.panel3.Scrollable = true;
            this.panel3.Size = new System.Drawing.Size(0, 192);
            // 
            // panel4
            // 
            this.panel4.Horizontal = true;
            this.panel4.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel4.Name = "panel4";
            this.panel4.Scrollable = true;
            this.panel4.Size = new System.Drawing.Size(300, 0);
            // 
            // demoTwoWayScrolling
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel1,
            this.panel3});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Load += new System.EventHandler(this.demoTwoWayScrolling_Load);
            this.Name = "demoTwoWayScrolling";

        }
        #endregion

        private Smobiler.Core.Controls.Title title1;
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Panel panel2;
        private Core.Controls.Panel panel3;
        private Core.Controls.Panel panel4;
    }
}