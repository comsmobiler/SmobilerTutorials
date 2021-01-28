using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Components
{
    partial class listViewTemplate : Smobiler.Core.Controls.MobileUserControl
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
            this.label2 = new Smobiler.Core.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image1,
            this.label1,
            this.label2});
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 100);
            this.panel1.Touchable = true;
            this.panel1.Press += new System.EventHandler(this.panel1_Press);
            // 
            // image1
            // 
            this.image1.DisplayMember = "img";
            this.image1.Location = new System.Drawing.Point(11, 3);
            this.image1.Name = "image1";
            this.image1.Size = new System.Drawing.Size(29, 30);
            // 
            // label1
            // 
            this.label1.DataMember = "id";
            this.label1.DisplayMember = "name";
            this.label1.Location = new System.Drawing.Point(49, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 35);
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.DisplayMember = "sexual";
            this.label2.Location = new System.Drawing.Point(184, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 35);
            this.label2.Text = "label1";
            // 
            // listViewTemplate
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Size = new System.Drawing.Size(290, 35);
            this.Name = "listViewTemplate";

        }
        #endregion

        private Core.Controls.Panel panel1;
        private Core.Controls.Image image1;
        private Core.Controls.Label label1;
        private Core.Controls.Label label2;
    }
}