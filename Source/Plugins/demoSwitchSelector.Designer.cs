using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Plugins
{
    partial class demoSwitchSelector : Smobiler.Core.Controls.MobileForm
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
            Smobiler.Plugins.SwitchSelectorItem switchSelectorItem1 = new Smobiler.Plugins.SwitchSelectorItem();
            Smobiler.Plugins.SwitchSelectorItem switchSelectorItem2 = new Smobiler.Plugins.SwitchSelectorItem();
            Smobiler.Plugins.SwitchSelectorItem switchSelectorItem3 = new Smobiler.Plugins.SwitchSelectorItem();
            Smobiler.Plugins.SwitchSelectorItem switchSelectorItem4 = new Smobiler.Plugins.SwitchSelectorItem();
            Smobiler.Plugins.SwitchSelectorItem switchSelectorItem5 = new Smobiler.Plugins.SwitchSelectorItem();
            Smobiler.Plugins.SwitchSelectorItem switchSelectorItem6 = new Smobiler.Plugins.SwitchSelectorItem();
            this.title1 = new Smobiler.Core.Controls.Title();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.labContent = new Smobiler.Core.Controls.Label();
            this.labTitle = new Smobiler.Core.Controls.Label();
            this.switchSelector1 = new Smobiler.Plugins.SwitchSelector();
            this.switchSelector2 = new Smobiler.Plugins.SwitchSelector();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "SwitchSelector";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel2});
            this.panel1.Flex = 1;
            this.panel1.Name = "panel1";
            this.panel1.Scrollable = true;
            this.panel1.Size = new System.Drawing.Size(0, 100);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel2.BorderColor = System.Drawing.Color.Silver;
            this.panel2.BorderRadius = 5;
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.labContent,
            this.labTitle,
            this.switchSelector1,
            this.switchSelector2});
            this.panel2.Location = new System.Drawing.Point(5, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 285);
            // 
            // labContent
            // 
            this.labContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labContent.FontSize = 15F;
            this.labContent.Location = new System.Drawing.Point(0, 26);
            this.labContent.Name = "labContent";
            this.labContent.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labContent.Size = new System.Drawing.Size(290, 113);
            this.labContent.Text = "SelectedItemColor 、SelectedItemText分别设置选中项 背景色和字体颜色；UnSelectedItemColor 设置未选中项颜色；" +
    "Options属性设置Items；点击SwitchSelector选项触发点击事件\r\n\r\n\r\n\r\n";
            this.labContent.VerticalAlignment = Smobiler.Core.Controls.VerticalAlignment.Top;
            // 
            // labTitle
            // 
            this.labTitle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labTitle.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.labTitle.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.labTitle.FontSize = 16F;
            this.labTitle.Name = "labTitle";
            this.labTitle.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labTitle.Size = new System.Drawing.Size(290, 26);
            this.labTitle.Text = "选择器控件";
            // 
            // switchSelector1
            // 
            this.switchSelector1.BorderRadius = 0;
            this.switchSelector1.Location = new System.Drawing.Point(40, 172);
            this.switchSelector1.Name = "switchSelector1";
            switchSelectorItem1.ActiveColor = System.Drawing.Color.Empty;
            switchSelectorItem1.ImageResourceID = "logon";
            switchSelectorItem1.Text = "1";
            switchSelectorItem1.Value = "1";
            switchSelectorItem2.ActiveColor = System.Drawing.Color.Empty;
            switchSelectorItem2.ImageResourceID = "logon";
            switchSelectorItem2.Text = "2";
            switchSelectorItem2.Value = "2";
            switchSelectorItem3.ActiveColor = System.Drawing.Color.Empty;
            switchSelectorItem3.ImageResourceID = "logon";
            switchSelectorItem3.Text = "3";
            switchSelectorItem3.Value = "3";
            this.switchSelector1.Options.AddRange(new Smobiler.Plugins.SwitchSelectorItem[] {
            switchSelectorItem1,
            switchSelectorItem2,
            switchSelectorItem3});
            this.switchSelector1.SelectedItemColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(176)))), ((int)(((byte)(249)))));
            this.switchSelector1.Size = new System.Drawing.Size(211, 30);
            this.switchSelector1.UnSelectedTextColor = System.Drawing.Color.DimGray;
            this.switchSelector1.OnPress += new Smobiler.Plugins.SwitchSelectorOnPressEventHandler(this.switchSelector1_OnPress);
            // 
            // switchSelector2
            // 
            this.switchSelector2.BorderRadius = 0;
            this.switchSelector2.Location = new System.Drawing.Point(40, 220);
            this.switchSelector2.Name = "switchSelector2";
            switchSelectorItem4.ActiveColor = System.Drawing.Color.Empty;
            switchSelectorItem4.ImageResourceID = "设计师.png";
            switchSelectorItem4.Text = "设计师";
            switchSelectorItem4.Value = "1";
            switchSelectorItem5.ActiveColor = System.Drawing.Color.Empty;
            switchSelectorItem5.ImageResourceID = "搜索.png";
            switchSelectorItem5.Text = "搜索";
            switchSelectorItem5.Value = "2";
            switchSelectorItem6.ActiveColor = System.Drawing.Color.Empty;
            switchSelectorItem6.ImageResourceID = "咨询.png";
            switchSelectorItem6.Text = "咨询";
            switchSelectorItem6.Value = "3";
            this.switchSelector2.Options.AddRange(new Smobiler.Plugins.SwitchSelectorItem[] {
            switchSelectorItem4,
            switchSelectorItem5,
            switchSelectorItem6});
            this.switchSelector2.SelectedItemColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.switchSelector2.Size = new System.Drawing.Size(211, 30);
            this.switchSelector2.UnSelectedTextColor = System.Drawing.Color.DimGray;
            this.switchSelector2.OnPress += new Smobiler.Plugins.SwitchSelectorOnPressEventHandler(this.switchSelector1_OnPress);
            // 
            // demoSwitchSelector
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel1});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Name = "demoSwitchSelector";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Panel panel1;
        private Core.Controls.Panel panel2;
        private Core.Controls.Label labContent;
        private Core.Controls.Label labTitle;
        private Smobiler.Plugins.SwitchSelector switchSelector1;
        private Smobiler.Plugins.SwitchSelector switchSelector2;
    }
}