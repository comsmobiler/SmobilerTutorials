using System;
using Smobiler.Core;
namespace Smobiler.Tutorials
{
    partial class demoControls : Smobiler.Core.Controls.MobileForm
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
            this.iconMenuView1 = new Smobiler.Core.Controls.IconMenuView();
            // 
            // iconMenuView1
            // 
            this.iconMenuView1.BackColor = System.Drawing.Color.AliceBlue;
            this.iconMenuView1.Flex = 1;
            this.iconMenuView1.FontSize = 11F;
            this.iconMenuView1.GroupBackColor = System.Drawing.Color.DarkGray;
            this.iconMenuView1.GroupForeColor = System.Drawing.Color.White;
            this.iconMenuView1.ItemWidth = 65;
            this.iconMenuView1.MenuItemHeight = 65;
            this.iconMenuView1.Name = "iconMenuView1";
            this.iconMenuView1.ShowGroupTitle = true;
            this.iconMenuView1.Size = new System.Drawing.Size(0, 0);
            this.iconMenuView1.ItemPress += new Smobiler.Core.Controls.IconMenuViewItemPressClickHandler(this.iconMenuView1_ItemPress);
            // 
            // demoControls
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.iconMenuView1});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Load += new System.EventHandler(this.demoControls_Load);
            this.Name = "demoControls";

        }
        #endregion
        private Core.Controls.IconMenuView iconMenuView1;
    }
}