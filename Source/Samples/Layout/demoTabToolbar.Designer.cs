using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Samples.Layout
{
    partial class demoTabToolbar : Smobiler.Core.Controls.MobileForm
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
            Smobiler.Core.Controls.ToolBarItem toolBarItem1 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem2 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem3 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem4 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem5 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ActionButtonItem actionButtonItem1 = new Smobiler.Core.Controls.ActionButtonItem();
            this.tabPageView1 = new Smobiler.Core.Controls.TabPageView();
            this.toolBar = new Smobiler.Core.Controls.ToolBar();
            // 
            // tabPageView1
            // 
            this.tabPageView1.BackColor = System.Drawing.Color.White;
            this.tabPageView1.Flex = 1;
            this.tabPageView1.Name = "tabPageView1";
            this.tabPageView1.Size = new System.Drawing.Size(0, 300);
            this.tabPageView1.PageIndexChanged += new System.EventHandler(this.tabPageView1_PageIndexChanged);
            // 
            // toolBar
            // 
            this.toolBar.BackColor = System.Drawing.Color.White;
            this.toolBar.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.toolBar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.toolBar.ItemCount = 5;
            toolBarItem1.IconID = "cangku";
            toolBarItem1.Name = "仓库";
            toolBarItem1.SelectIconColor = System.Drawing.Color.DarkGray;
            toolBarItem1.SelectIconID = "cangku_sel";
            toolBarItem1.Text = "仓库";
            toolBarItem2.IconID = "dingdan";
            toolBarItem2.Name = "订单";
            toolBarItem2.SelectIconID = "dingdan_sel";
            toolBarItem2.Text = "订单";
            toolBarItem3.IconID = "shuju";
            toolBarItem3.Name = "主数据";
            toolBarItem3.SelectIconID = "shuju_sel";
            toolBarItem3.Text = "主数据";
            toolBarItem4.IconID = "tongji";
            toolBarItem4.Name = "统计";
            toolBarItem4.SelectIconID = "tongji_sel";
            toolBarItem4.Text = "统计";
            toolBarItem5.IconID = "shezhi";
            toolBarItem5.Name = "设置";
            toolBarItem5.SelectIconID = "shezhi_sel";
            toolBarItem5.Text = "设置";
            this.toolBar.Items.AddRange(new Smobiler.Core.Controls.ToolBarItem[] {
            toolBarItem1,
            toolBarItem2,
            toolBarItem3,
            toolBarItem4,
            toolBarItem5});
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(0, 50);
            this.toolBar.ToolbarItemClick += new Smobiler.Core.Controls.ToolbarItemClickEventHandler(this.toolBar_ToolbarItemClick);
            // 
            // demoTabToolbar
            // 
            this.ActionButton.Enabled = true;
            actionButtonItem1.ResourceID = "arrow-left";
            actionButtonItem1.Text = "返回";
            this.ActionButton.Items.AddRange(new Smobiler.Core.Controls.ActionButtonItem[] {
            actionButtonItem1});
            this.ActionButton.OffsetY = 62;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.tabPageView1,
            this.toolBar});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.ActionButtonPress += new Smobiler.Core.Controls.ActionButtonPressEventHandler(this.demoTabToolbar_ActionButtonPress);
            this.Load += new System.EventHandler(this.demoTabToolbar_Load);
            this.Name = "demoTabToolbar";

        }
        #endregion

        private Smobiler.Core.Controls.TabPageView tabPageView1;
        private Smobiler.Core.Controls.ToolBar toolBar;
    }
}