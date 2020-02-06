using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Samples.Layout.UserControl
{
    partial class frmMenu : Smobiler.Core.Controls.MobileUserControl
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
            Smobiler.Core.Controls.IconMenuViewGroup iconMenuViewGroup1 = new Smobiler.Core.Controls.IconMenuViewGroup();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem1 = new Smobiler.Core.Controls.IconMenuViewItem();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem2 = new Smobiler.Core.Controls.IconMenuViewItem();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem3 = new Smobiler.Core.Controls.IconMenuViewItem();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem4 = new Smobiler.Core.Controls.IconMenuViewItem();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem5 = new Smobiler.Core.Controls.IconMenuViewItem();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem6 = new Smobiler.Core.Controls.IconMenuViewItem();
            Smobiler.Core.Controls.IconMenuViewGroup iconMenuViewGroup2 = new Smobiler.Core.Controls.IconMenuViewGroup();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem7 = new Smobiler.Core.Controls.IconMenuViewItem();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem8 = new Smobiler.Core.Controls.IconMenuViewItem();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem9 = new Smobiler.Core.Controls.IconMenuViewItem();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem10 = new Smobiler.Core.Controls.IconMenuViewItem();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem11 = new Smobiler.Core.Controls.IconMenuViewItem();
            this.title1 = new Smobiler.Core.Controls.Title();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.plWareHouse = new Smobiler.Core.Controls.Panel();
            this.btnWareHouse = new Smobiler.Core.Controls.Button();
            this.iconMenu = new Smobiler.Core.Controls.IconMenuView();
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "仓库";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plWareHouse,
            this.iconMenu});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            // 
            // plWareHouse
            // 
            this.plWareHouse.BackColor = System.Drawing.Color.White;
            this.plWareHouse.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnWareHouse});
            this.plWareHouse.Name = "plWareHouse";
            this.plWareHouse.Size = new System.Drawing.Size(0, 35);
            // 
            // btnWareHouse
            // 
            this.btnWareHouse.BackColor = System.Drawing.Color.White;
            this.btnWareHouse.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnWareHouse.BorderRadius = 0;
            this.btnWareHouse.ForeColor = System.Drawing.Color.Black;
            this.btnWareHouse.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnWareHouse.Location = new System.Drawing.Point(200, 0);
            this.btnWareHouse.Name = "btnWareHouse";
            this.btnWareHouse.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.btnWareHouse.Size = new System.Drawing.Size(100, 35);
            this.btnWareHouse.Text = "全部仓库   > ";
            this.btnWareHouse.Press += new System.EventHandler(this.btnWareHouse_Press);
            // 
            // iconMenu
            // 
            this.iconMenu.GridLines = true;
            iconMenuViewGroup1.FontSize = 0F;
            iconMenuViewGroup1.IconBorderRadius = 0;
            iconMenuViewGroup1.ItemHeight = 0;
            iconMenuViewItem1.Icon = "zichan";
            iconMenuViewItem1.ID = "0";
            iconMenuViewItem1.Text = "资产管理";
            iconMenuViewItem1.Value = "Assets";
            iconMenuViewItem2.Icon = "muban";
            iconMenuViewItem2.ID = "1";
            iconMenuViewItem2.Text = "资产模板";
            iconMenuViewItem2.Value = "AssTemplate";
            iconMenuViewItem3.Icon = "ruku";
            iconMenuViewItem3.ID = "2";
            iconMenuViewItem3.Text = "入库";
            iconMenuViewItem3.Value = "AssIn";
            iconMenuViewItem4.Icon = "chuku";
            iconMenuViewItem4.ID = "3";
            iconMenuViewItem4.Text = "出库";
            iconMenuViewItem4.Value = "AssOut";
            iconMenuViewItem5.Icon = "diaobo";
            iconMenuViewItem5.ID = "5";
            iconMenuViewItem5.Text = "调拨";
            iconMenuViewItem5.Value = "AssTransfer";
            iconMenuViewItem6.Icon = "pandian";
            iconMenuViewItem6.ID = "4";
            iconMenuViewItem6.Text = "盘点";
            iconMenuViewItem6.Value = "AssInventory";
            iconMenuViewGroup1.Items.AddRange(new Smobiler.Core.Controls.IconMenuViewItem[] {
            iconMenuViewItem1,
            iconMenuViewItem2,
            iconMenuViewItem3,
            iconMenuViewItem4,
            iconMenuViewItem5,
            iconMenuViewItem6});
            iconMenuViewGroup1.ShowTitle = true;
            iconMenuViewGroup1.Text = "资产";
            iconMenuViewGroup2.FontSize = 0F;
            iconMenuViewGroup2.IconBorderRadius = 0;
            iconMenuViewGroup2.ItemHeight = 0;
            iconMenuViewItem7.Icon = "haocai";
            iconMenuViewItem7.ID = "0";
            iconMenuViewItem7.Text = "耗材管理";
            iconMenuViewItem7.Value = "ConManage";
            iconMenuViewItem8.Icon = "ruku";
            iconMenuViewItem8.ID = "1";
            iconMenuViewItem8.Text = "入库";
            iconMenuViewItem8.Value = "ConIn";
            iconMenuViewItem9.Icon = "chuku";
            iconMenuViewItem9.ID = "2";
            iconMenuViewItem9.Text = "出库";
            iconMenuViewItem9.Value = "ConOut";
            iconMenuViewItem10.Icon = "diaobo";
            iconMenuViewItem10.ID = "2";
            iconMenuViewItem10.Text = "调拨";
            iconMenuViewItem10.Value = "ConTransfer";
            iconMenuViewItem11.Icon = "pandian";
            iconMenuViewItem11.ID = "3";
            iconMenuViewItem11.Text = "盘点";
            iconMenuViewItem11.Value = "ConInventory";
            iconMenuViewGroup2.Items.AddRange(new Smobiler.Core.Controls.IconMenuViewItem[] {
            iconMenuViewItem7,
            iconMenuViewItem8,
            iconMenuViewItem9,
            iconMenuViewItem10,
            iconMenuViewItem11});
            iconMenuViewGroup2.ShowTitle = true;
            iconMenuViewGroup2.Text = "耗材";
            this.iconMenu.Groups.AddRange(new Smobiler.Core.Controls.IconMenuViewGroup[] {
            iconMenuViewGroup1,
            iconMenuViewGroup2});
            this.iconMenu.Margin = new Smobiler.Core.Controls.Margin(0F, 10F, 0F, 0F);
            this.iconMenu.Name = "iconMenu";
            this.iconMenu.Size = new System.Drawing.Size(300, 425);
            this.iconMenu.ItemPress += new Smobiler.Core.Controls.IconMenuViewItemPressClickHandler(this.iconMenu_ItemPress);
            // 
            // frmMenu
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel1});
            this.Size = new System.Drawing.Size(300, 500);
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.Name = "frmMenu";

        }
        #endregion

        private Smobiler.Core.Controls.Title title1;
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Panel plWareHouse;
        internal Smobiler.Core.Controls.Button btnWareHouse;
        private Smobiler.Core.Controls.IconMenuView iconMenu;
    }
}