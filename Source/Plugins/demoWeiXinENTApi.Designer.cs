using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Plugins
{
    partial class demoWeiXinENTApi : Smobiler.Core.Controls.MobileForm
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
            this.label1 = new Smobiler.Core.Controls.Label();
            this.listMenuView1 = new Smobiler.Core.Controls.ListMenuView();
            this.weiXinENTApi1 = new Smobiler.Plugins.WeiXinENTApi();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "WeiXinENTApi";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 45);
            this.label1.Text = "WeiXinENTApi控件，仅在企业微信中可使用";
            // 
            // listMenuView1
            // 
            this.listMenuView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listMenuView1.Location = new System.Drawing.Point(0, 116);
            this.listMenuView1.Name = "listMenuView1";
            this.listMenuView1.Size = new System.Drawing.Size(300, 300);
            this.listMenuView1.ItemPress += new Smobiler.Core.Controls.ListMenuViewItemPressEventHandler(this.listMenuView1_ItemPress);
            // 
            // weiXinENTApi1
            // 
            this.weiXinENTApi1.AppID = null;
            this.weiXinENTApi1.CorpID = null;
            this.weiXinENTApi1.Name = "weiXinENTApi1";
            this.weiXinENTApi1.Afterlogin += new Smobiler.Plugins.WeiXinENTApiLoginEventHandler(this.weiXinENTApi1_Afterlogin);
            // 
            // demoWeiXinENTApi
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.weiXinENTApi1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.label1,
            this.listMenuView1});
            this.Load += new System.EventHandler(this.demoWeiXinENTApi_Load);
            this.Name = "demoWeiXinENTApi";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Label label1;
        private Core.Controls.ListMenuView listMenuView1;
        private Smobiler.Plugins.WeiXinENTApi weiXinENTApi1;
    }
}