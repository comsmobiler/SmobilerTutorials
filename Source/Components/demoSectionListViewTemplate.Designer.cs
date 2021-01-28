using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Components
{
    partial class demoSectionListViewTemplate : Smobiler.Core.Controls.MobileUserControl
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
            this.label1 = new Smobiler.Core.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1});
            this.panel1.Flex = 1;
            this.panel1.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 30);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Bold = true;
            this.label1.DisplayMember = "Section";
            this.label1.Flex = 1;
            this.label1.FontSize = 15F;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Margin = new Smobiler.Core.Controls.Margin(10F, 0F, 0F, 0F);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 30);
            this.label1.Text = "label1";
            // 
            // demoSectionListViewTemplate
            // 
            this.BackColor = System.Drawing.Color.Silver;
            this.BorderColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Size = new System.Drawing.Size(0, 25);
            this.Name = "demoSectionListViewTemplate";

        }
        #endregion

        private Core.Controls.Panel panel1;
        private Core.Controls.Label label1;
    }
}