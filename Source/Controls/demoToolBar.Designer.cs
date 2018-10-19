using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Controls
{
    partial class demoToolBar : Smobiler.Core.Controls.MobileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(demoToolBar));
            Smobiler.Core.Controls.ToolBarItem toolBarItem1 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem2 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem3 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem4 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem5 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem6 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem7 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem8 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem9 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem10 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem11 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem12 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem13 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem14 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem15 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem16 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem17 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem18 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem19 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem20 = new Smobiler.Core.Controls.ToolBarItem();
            this.title1 = new Smobiler.Core.Controls.Title();
            this.panel10 = new Smobiler.Core.Controls.Panel();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.labContent = new Smobiler.Core.Controls.Label();
            this.labTitle = new Smobiler.Core.Controls.Label();
            this.toolBar1 = new Smobiler.Core.Controls.ToolBar();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.toolBar2 = new Smobiler.Core.Controls.ToolBar();
            this.panel3 = new Smobiler.Core.Controls.Panel();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.toolBar3 = new Smobiler.Core.Controls.ToolBar();
            this.panel4 = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.toolBar4 = new Smobiler.Core.Controls.ToolBar();
            this.panel5 = new Smobiler.Core.Controls.Panel();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.toolBar5 = new Smobiler.Core.Controls.ToolBar();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "ToolBar";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // panel10
            // 
            this.panel10.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1,
            this.panel2,
            this.panel3,
            this.panel4,
            this.panel5});
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 30);
            this.panel10.Name = "panel10";
            this.panel10.Scrollable = true;
            this.panel10.Size = new System.Drawing.Size(300, 970);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel1.BorderColor = System.Drawing.Color.Silver;
            this.panel1.BorderRadius = 5;
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.labContent,
            this.labTitle,
            this.toolBar1});
            this.panel1.Location = new System.Drawing.Point(5, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 224);
            // 
            // labContent
            // 
            this.labContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labContent.Location = new System.Drawing.Point(0, 26);
            this.labContent.Name = "labContent";
            this.labContent.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labContent.Size = new System.Drawing.Size(290, 148);
            this.labContent.Text = resources.GetString("labContent.Text");
            // 
            // labTitle
            // 
            this.labTitle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labTitle.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.labTitle.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.labTitle.FontSize = 16F;
            this.labTitle.Name = "labTitle";
            this.labTitle.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labTitle.Size = new System.Drawing.Size(290, 25);
            this.labTitle.Text = "ToolBar控件";
            // 
            // toolBar1
            // 
            toolBarItem1.IconID = "logon";
            toolBarItem1.SelectIconID = "logon";
            toolBarItem1.Text = "1";
            toolBarItem2.IconID = "logon";
            toolBarItem2.SelectIconID = "logon";
            toolBarItem2.Text = "2";
            toolBarItem3.IconID = "logon";
            toolBarItem3.SelectIconID = "logon";
            toolBarItem3.Text = "3";
            toolBarItem4.IconID = "logon";
            toolBarItem4.SelectIconID = "logon";
            toolBarItem4.Text = "4";
            this.toolBar1.Items.AddRange(new Smobiler.Core.Controls.ToolBarItem[] {
            toolBarItem1,
            toolBarItem2,
            toolBarItem3,
            toolBarItem4});
            this.toolBar1.Location = new System.Drawing.Point(73, 101);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.Size = new System.Drawing.Size(100, 50);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel2.BorderColor = System.Drawing.Color.Silver;
            this.panel2.BorderRadius = 5;
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label5,
            this.toolBar2});
            this.panel2.Location = new System.Drawing.Point(5, 245);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 100);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Name = "label5";
            this.label5.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label5.Size = new System.Drawing.Size(290, 50);
            this.label5.Text = "FontSize、ForeColor、SelectBackColor、SelectForeColor设置工具栏字体与颜色的不同样式";
            // 
            // toolBar2
            // 
            this.toolBar2.FontSize = 16F;
            this.toolBar2.ForeColor = System.Drawing.Color.Silver;
            toolBarItem5.IconID = "logon";
            toolBarItem5.SelectIconID = "logon";
            toolBarItem5.Text = "1";
            toolBarItem6.IconID = "logon";
            toolBarItem6.SelectIconID = "logon";
            toolBarItem6.Text = "2";
            toolBarItem7.IconID = "logon";
            toolBarItem7.SelectIconID = "logon";
            toolBarItem7.Text = "3";
            toolBarItem8.IconID = "logon";
            toolBarItem8.SelectIconID = "logon";
            toolBarItem8.Text = "4";
            this.toolBar2.Items.AddRange(new Smobiler.Core.Controls.ToolBarItem[] {
            toolBarItem5,
            toolBarItem6,
            toolBarItem7,
            toolBarItem8});
            this.toolBar2.Location = new System.Drawing.Point(73, 101);
            this.toolBar2.Name = "toolBar2";
            this.toolBar2.SelectBackColor = System.Drawing.Color.ForestGreen;
            this.toolBar2.SelectForeColor = System.Drawing.Color.DimGray;
            this.toolBar2.Size = new System.Drawing.Size(100, 50);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel3.BorderColor = System.Drawing.Color.Silver;
            this.panel3.BorderRadius = 5;
            this.panel3.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label6,
            this.toolBar3});
            this.panel3.Location = new System.Drawing.Point(5, 357);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(290, 100);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Name = "label6";
            this.label6.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label6.Size = new System.Drawing.Size(290, 50);
            this.label6.Text = "ItemCount、ItemWidth、SelectedIndex设置工具栏的不同样式";
            // 
            // toolBar3
            // 
            this.toolBar3.FontSize = 16F;
            this.toolBar3.ForeColor = System.Drawing.Color.Silver;
            this.toolBar3.ItemCount = 2;
            toolBarItem9.IconID = "logon";
            toolBarItem9.SelectIconID = "logon";
            toolBarItem9.Text = "1";
            toolBarItem10.IconID = "logon";
            toolBarItem10.SelectIconID = "logon";
            toolBarItem10.Text = "2";
            toolBarItem11.IconID = "logon";
            toolBarItem11.SelectIconID = "logon";
            toolBarItem11.Text = "3";
            toolBarItem12.IconID = "logon";
            toolBarItem12.SelectIconID = "logon";
            toolBarItem12.Text = "4";
            this.toolBar3.Items.AddRange(new Smobiler.Core.Controls.ToolBarItem[] {
            toolBarItem9,
            toolBarItem10,
            toolBarItem11,
            toolBarItem12});
            this.toolBar3.ItemWidth = 35;
            this.toolBar3.Location = new System.Drawing.Point(73, 101);
            this.toolBar3.Name = "toolBar3";
            this.toolBar3.SelectBackColor = System.Drawing.Color.ForestGreen;
            this.toolBar3.SelectedIndex = 1;
            this.toolBar3.SelectForeColor = System.Drawing.Color.DimGray;
            this.toolBar3.Size = new System.Drawing.Size(100, 50);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel4.BorderColor = System.Drawing.Color.Silver;
            this.panel4.BorderRadius = 5;
            this.panel4.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.toolBar4});
            this.panel4.Location = new System.Drawing.Point(5, 469);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(290, 100);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label1.Size = new System.Drawing.Size(290, 50);
            this.label1.Text = "MessageBackColor、MessageFontSize、MessageForeColor、MessageWidth设置消息框样式";
            // 
            // toolBar4
            // 
            toolBarItem13.IconID = "logon";
            toolBarItem13.MessageText = "1";
            toolBarItem13.SelectIconID = "logon";
            toolBarItem13.Text = "1";
            toolBarItem14.IconID = "logon";
            toolBarItem14.MessageText = "2";
            toolBarItem14.SelectIconID = "logon";
            toolBarItem14.Text = "2";
            toolBarItem15.IconID = "logon";
            toolBarItem15.MessageText = "3";
            toolBarItem15.SelectIconID = "logon";
            toolBarItem15.Text = "3";
            toolBarItem16.IconID = "logon";
            toolBarItem16.MessageText = "4";
            toolBarItem16.SelectIconID = "logon";
            toolBarItem16.Text = "4";
            this.toolBar4.Items.AddRange(new Smobiler.Core.Controls.ToolBarItem[] {
            toolBarItem13,
            toolBarItem14,
            toolBarItem15,
            toolBarItem16});
            this.toolBar4.Location = new System.Drawing.Point(73, 101);
            this.toolBar4.Name = "toolBar4";
            this.toolBar4.Size = new System.Drawing.Size(100, 50);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel5.BorderColor = System.Drawing.Color.Silver;
            this.panel5.BorderRadius = 5;
            this.panel5.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label2,
            this.toolBar5});
            this.panel5.Location = new System.Drawing.Point(5, 579);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(290, 100);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Name = "label2";
            this.label2.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label2.Size = new System.Drawing.Size(290, 50);
            this.label2.Text = "ToolbarItemClick在工具栏点击时发生";
            // 
            // toolBar5
            // 
            toolBarItem17.IconID = "logon";
            toolBarItem17.MessageText = "1";
            toolBarItem17.Name = "1";
            toolBarItem17.SelectIconID = "logon";
            toolBarItem17.Text = "1";
            toolBarItem18.IconID = "logon";
            toolBarItem18.MessageText = "2";
            toolBarItem18.Name = "2";
            toolBarItem18.SelectIconID = "logon";
            toolBarItem18.Text = "2";
            toolBarItem19.IconID = "logon";
            toolBarItem19.MessageText = "3";
            toolBarItem19.Name = "3";
            toolBarItem19.SelectIconID = "logon";
            toolBarItem19.Text = "3";
            toolBarItem20.IconID = "logon";
            toolBarItem20.MessageText = "4";
            toolBarItem20.Name = "4";
            toolBarItem20.SelectIconID = "logon";
            toolBarItem20.Text = "4";
            this.toolBar5.Items.AddRange(new Smobiler.Core.Controls.ToolBarItem[] {
            toolBarItem17,
            toolBarItem18,
            toolBarItem19,
            toolBarItem20});
            this.toolBar5.Location = new System.Drawing.Point(73, 101);
            this.toolBar5.Name = "toolBar5";
            this.toolBar5.Size = new System.Drawing.Size(100, 50);
            this.toolBar5.ToolbarItemClick += new Smobiler.Core.Controls.ToolbarItemClickEventHandler(this.toolBar5_ToolbarItemClick);
            // 
            // demoToolBar
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel10});
            this.Size = new System.Drawing.Size(300, 1000);
            this.Name = "demoToolBar";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Panel panel10;
        private Core.Controls.Panel panel1;
        private Core.Controls.Label labContent;
        private Core.Controls.Label labTitle;
        private Core.Controls.Panel panel2;
        private Core.Controls.ToolBar toolBar1;
        private Core.Controls.Label label5;
        private Core.Controls.ToolBar toolBar2;
        private Core.Controls.Panel panel3;
        private Core.Controls.Label label6;
        private Core.Controls.ToolBar toolBar3;
        private Core.Controls.Panel panel4;
        private Core.Controls.Label label1;
        private Core.Controls.ToolBar toolBar4;
        private Core.Controls.Panel panel5;
        private Core.Controls.Label label2;
        private Core.Controls.ToolBar toolBar5;
    }
}