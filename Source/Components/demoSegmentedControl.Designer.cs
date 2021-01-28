using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Components
{
    partial class demoSegmentedControl : Smobiler.Core.Controls.MobileForm
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
            this.panel10 = new Smobiler.Core.Controls.Panel();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.labContent = new Smobiler.Core.Controls.Label();
            this.labTitle = new Smobiler.Core.Controls.Label();
            this.segmentedControl1 = new Smobiler.Core.Controls.SegmentedControl();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.segmentedControl2 = new Smobiler.Core.Controls.SegmentedControl();
            this.segmentedControl3 = new Smobiler.Core.Controls.SegmentedControl();
            this.segmentedControl4 = new Smobiler.Core.Controls.SegmentedControl();
            this.panel3 = new Smobiler.Core.Controls.Panel();
            this.label13 = new Smobiler.Core.Controls.Label();
            this.segmentedControl5 = new Smobiler.Core.Controls.SegmentedControl();
            this.panel4 = new Smobiler.Core.Controls.Panel();
            this.label16 = new Smobiler.Core.Controls.Label();
            this.segmentedControl6 = new Smobiler.Core.Controls.SegmentedControl();
            this.panel5 = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.segmentedControl7 = new Smobiler.Core.Controls.SegmentedControl();
            this.weiXinApi1 = new Smobiler.Plugins.WeiXinApi();
            this.weiXinApi2 = new Smobiler.Plugins.WeiXinApi();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "SegmentedControl";
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
            this.segmentedControl1});
            this.panel1.Location = new System.Drawing.Point(5, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 137);
            // 
            // labContent
            // 
            this.labContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labContent.FontSize = 15F;
            this.labContent.Location = new System.Drawing.Point(0, 26);
            this.labContent.Name = "labContent";
            this.labContent.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labContent.Size = new System.Drawing.Size(290, 42);
            this.labContent.Text = "Items属性设置单元格集合\r\n";
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
            this.labTitle.Text = "多按钮选择控件";
            // 
            // segmentedControl1
            // 
            this.segmentedControl1.Items = new string[] {
        "报销",
        "请假",
        "考勤"};
            this.segmentedControl1.Location = new System.Drawing.Point(43, 83);
            this.segmentedControl1.Name = "segmentedControl1";
            this.segmentedControl1.SelectedBackColor = System.Drawing.Color.LightCoral;
            this.segmentedControl1.Size = new System.Drawing.Size(200, 35);
            this.segmentedControl1.UnSelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(78)))));
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel2.BorderColor = System.Drawing.Color.Silver;
            this.panel2.BorderRadius = 5;
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label5,
            this.segmentedControl2,
            this.segmentedControl3,
            this.segmentedControl4});
            this.panel2.Location = new System.Drawing.Point(5, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 219);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.FontSize = 14F;
            this.label5.Location = new System.Drawing.Point(0, 2);
            this.label5.Name = "label5";
            this.label5.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label5.Size = new System.Drawing.Size(290, 85);
            this.label5.Text = "SelectedBorderRadius，SelectedBackColor、SelectedColor、SelectedFontSize、UnSelectedB" +
    "ackColor、UnSelectedColor、UnSelectedFontSize设置控件的不同样式";
            // 
            // segmentedControl2
            // 
            this.segmentedControl2.Items = new string[] {
        "报销",
        "请假",
        "考勤"};
            this.segmentedControl2.Location = new System.Drawing.Point(47, 94);
            this.segmentedControl2.Name = "segmentedControl2";
            this.segmentedControl2.SegmentedBorderRadius = 0;
            this.segmentedControl2.SelectedBackColor = System.Drawing.Color.Sienna;
            this.segmentedControl2.Size = new System.Drawing.Size(200, 35);
            // 
            // segmentedControl3
            // 
            this.segmentedControl3.Items = new string[] {
        "报销",
        "请假",
        "考勤"};
            this.segmentedControl3.Location = new System.Drawing.Point(47, 136);
            this.segmentedControl3.Name = "segmentedControl3";
            this.segmentedControl3.SelectedBackColor = System.Drawing.Color.Silver;
            this.segmentedControl3.SelectedColor = System.Drawing.Color.Black;
            this.segmentedControl3.SelectedFontSize = 15F;
            this.segmentedControl3.Size = new System.Drawing.Size(200, 35);
            this.segmentedControl3.UnSelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(176)))), ((int)(((byte)(249)))));
            this.segmentedControl3.UnSelectedColor = System.Drawing.Color.Gray;
            this.segmentedControl3.UnSelectedFontSize = 15F;
            // 
            // segmentedControl4
            // 
            this.segmentedControl4.Items = new string[] {
        "报销",
        "请假",
        "考勤"};
            this.segmentedControl4.Location = new System.Drawing.Point(47, 178);
            this.segmentedControl4.Name = "segmentedControl4";
            this.segmentedControl4.SegmentedBorderRadius = 18;
            this.segmentedControl4.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.segmentedControl4.SelectedColor = System.Drawing.Color.Red;
            this.segmentedControl4.SelectedFontSize = 11F;
            this.segmentedControl4.Size = new System.Drawing.Size(200, 35);
            this.segmentedControl4.UnSelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(229)))), ((int)(((byte)(99)))));
            this.segmentedControl4.UnSelectedColor = System.Drawing.Color.Black;
            this.segmentedControl4.UnSelectedFontSize = 11F;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel3.BorderColor = System.Drawing.Color.Silver;
            this.panel3.BorderRadius = 5;
            this.panel3.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label13,
            this.segmentedControl5});
            this.panel3.Location = new System.Drawing.Point(5, 389);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(290, 131);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label13.FontSize = 15F;
            this.label13.Name = "label13";
            this.label13.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label13.Size = new System.Drawing.Size(290, 54);
            this.label13.Text = "SelectedIndex设置选择单元索引\r\n\r\n";
            // 
            // segmentedControl5
            // 
            this.segmentedControl5.Items = new string[] {
        "报销",
        "请假",
        "考勤"};
            this.segmentedControl5.Location = new System.Drawing.Point(45, 73);
            this.segmentedControl5.Name = "segmentedControl5";
            this.segmentedControl5.SelectedIndex = 1;
            this.segmentedControl5.Size = new System.Drawing.Size(200, 35);
            this.segmentedControl5.UnSelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(176)))), ((int)(((byte)(249)))));
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel4.BorderColor = System.Drawing.Color.Silver;
            this.panel4.BorderRadius = 5;
            this.panel4.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label16,
            this.segmentedControl6});
            this.panel4.Location = new System.Drawing.Point(5, 531);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(290, 131);
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label16.FontSize = 15F;
            this.label16.Name = "label16";
            this.label16.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label16.Size = new System.Drawing.Size(290, 54);
            this.label16.Text = "Enabled属性设置是否启用该控件\r\n";
            // 
            // segmentedControl6
            // 
            this.segmentedControl6.Enabled = false;
            this.segmentedControl6.Items = new string[] {
        "报销",
        "请假",
        "考勤"};
            this.segmentedControl6.Location = new System.Drawing.Point(45, 73);
            this.segmentedControl6.Name = "segmentedControl6";
            this.segmentedControl6.SelectedIndex = 2;
            this.segmentedControl6.Size = new System.Drawing.Size(200, 35);
            this.segmentedControl6.UnSelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(67)))), ((int)(((byte)(81)))));
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel5.BorderColor = System.Drawing.Color.Silver;
            this.panel5.BorderRadius = 5;
            this.panel5.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.segmentedControl7});
            this.panel5.Location = new System.Drawing.Point(5, 675);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(290, 131);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.FontSize = 15F;
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label1.Size = new System.Drawing.Size(290, 54);
            this.label1.Text = "SelectedIndexChanged事件在单元选择改变时触发。\r\nSelectedItem获取选择单元";
            // 
            // segmentedControl7
            // 
            this.segmentedControl7.Items = new string[] {
        "报销",
        "请假",
        "考勤"};
            this.segmentedControl7.Location = new System.Drawing.Point(45, 73);
            this.segmentedControl7.Name = "segmentedControl7";
            this.segmentedControl7.SelectedIndex = 1;
            this.segmentedControl7.Size = new System.Drawing.Size(200, 35);
            this.segmentedControl7.SelectedIndexChanged += new System.EventHandler(this.segmentedControl7_SelectedIndexChanged);
            // 
            // weiXinApi1
            // 
            this.weiXinApi1.AppID = null;
            this.weiXinApi1.Name = "weiXinApi1";
            // 
            // weiXinApi2
            // 
            this.weiXinApi2.AppID = null;
            this.weiXinApi2.Name = "weiXinApi2";
            // 
            // demoSegmentedControl
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.weiXinApi1,
            this.weiXinApi2});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel10});
            this.Size = new System.Drawing.Size(300, 1000);
            this.Name = "demoSegmentedControl";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Panel panel10;
        private Core.Controls.Panel panel1;
        private Core.Controls.Label labContent;
        private Core.Controls.Label labTitle;
        private Core.Controls.Panel panel2;
        private Core.Controls.Label label5;
        private Core.Controls.Panel panel3;
        private Core.Controls.Label label13;
        private Core.Controls.Panel panel4;
        private Core.Controls.Label label16;
        private Core.Controls.Panel panel5;
        private Core.Controls.Label label1;
        private Core.Controls.SegmentedControl segmentedControl1;
        private Core.Controls.SegmentedControl segmentedControl2;
        private Core.Controls.SegmentedControl segmentedControl3;
        private Core.Controls.SegmentedControl segmentedControl4;
        private Core.Controls.SegmentedControl segmentedControl5;
        private Core.Controls.SegmentedControl segmentedControl6;
        private Core.Controls.SegmentedControl segmentedControl7;
        private Smobiler.Plugins.WeiXinApi weiXinApi1;
        private Smobiler.Plugins.WeiXinApi weiXinApi2;
    }
}