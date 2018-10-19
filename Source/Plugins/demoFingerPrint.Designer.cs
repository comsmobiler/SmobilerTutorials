using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Plugins
{
    partial class demoFingerPrint : Smobiler.Core.Controls.MobileForm
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
            this.fingerPrint1 = new Smobiler.Plugins.FingerPrint();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.listMenuView1 = new Smobiler.Core.Controls.ListMenuView();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "FingerPrint";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // fingerPrint1
            // 
            this.fingerPrint1.Name = "fingerPrint1";
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1});
            this.panel1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 58);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Flex = 1;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 0);
            this.label1.Text = "label1";
            // 
            // listMenuView1
            // 
            this.listMenuView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listMenuView1.Location = new System.Drawing.Point(0, 130);
            this.listMenuView1.Name = "listMenuView1";
            this.listMenuView1.Size = new System.Drawing.Size(300, 300);
            this.listMenuView1.ItemPress += new Smobiler.Core.Controls.ListMenuViewItemPressEventHandler(this.listMenuView1_ItemPress);
            // 
            // demoFingerPrint
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.fingerPrint1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel1,
            this.listMenuView1});
            this.Load += new System.EventHandler(this.demoFingerPrint_Load);
            this.Name = "demoFingerPrint";

        }
        #endregion

        private Core.Controls.Title title1;
        private Smobiler.Plugins.FingerPrint fingerPrint1;
        private Core.Controls.Panel panel1;
        private Core.Controls.Label label1;
        private Core.Controls.ListMenuView listMenuView1;
    }
}