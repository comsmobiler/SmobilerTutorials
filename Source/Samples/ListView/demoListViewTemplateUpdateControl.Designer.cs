using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Samples.ListView
{
    partial class demoListViewTemplateUpdateControl : Smobiler.Core.Controls.MobileUserControl
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
            this.label2 = new Smobiler.Core.Controls.Label();
            this.button1 = new Smobiler.Core.Controls.Button();
            // 
            // label1
            // 
            this.label1.DisplayMember = "label1";
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 35);
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.DisplayMember = "label2";
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 0);
            this.label2.Text = "label2";
            // 
            // button1
            // 
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 0);
            this.button1.Text = "编辑";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // demoListViewTemplateUpdateControl
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.label2,
            this.button1});
            this.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Size = new System.Drawing.Size(0, 30);
            this.Name = "demoListViewTemplateUpdateControl";

        }
        #endregion

        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Button button1;
    }
}