using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Components
{
    partial class demoPanel : Smobiler.Core.Controls.MobileForm
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
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.labContent = new Smobiler.Core.Controls.Label();
            this.labTitle = new Smobiler.Core.Controls.Label();
            this.panel4 = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.panel3 = new Smobiler.Core.Controls.Panel();
            this.image1 = new Smobiler.Core.Controls.Image();
            this.panel5 = new Smobiler.Core.Controls.Panel();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.panel = new Smobiler.Core.Controls.Panel();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.label7 = new Smobiler.Core.Controls.Label();
            this.panel6 = new Smobiler.Core.Controls.Panel();
            this.label8 = new Smobiler.Core.Controls.Label();
            this.label9 = new Smobiler.Core.Controls.Label();
            this.btnScrollToBottom = new Smobiler.Core.Controls.Button();
            this.btnScrollToTop = new Smobiler.Core.Controls.Button();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "Panel";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel2,
            this.panel5,
            this.panel6});
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
            this.panel4,
            this.panel3});
            this.panel2.Location = new System.Drawing.Point(5, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 221);
            // 
            // labContent
            // 
            this.labContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labContent.FontSize = 15F;
            this.labContent.Location = new System.Drawing.Point(0, 26);
            this.labContent.Name = "labContent";
            this.labContent.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labContent.Size = new System.Drawing.Size(290, 74);
            this.labContent.Text = "Panel控件的Touchable属性可使panel触发点击事件,可点击下方灰色panel，触发点击事件\r\n注意：Touchable和Scrollable不同同时" +
    "设置true\r\n";
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
            this.labTitle.Text = "可点击的Panel";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1});
            this.panel4.Location = new System.Drawing.Point(0, 112);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(124, 94);
            this.panel4.Touchable = true;
            this.panel4.Press += new System.EventHandler(this.panel4_Press);
            this.panel4.LongPress += new System.EventHandler(this.panel4_LongPress);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 35);
            this.label1.Text = "label";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image1});
            this.panel3.Location = new System.Drawing.Point(152, 112);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(124, 94);
            this.panel3.Touchable = true;
            this.panel3.Press += new System.EventHandler(this.panel3_Press);
            this.panel3.LongPress += new System.EventHandler(this.panel3_LongPress);
            // 
            // image1
            // 
            this.image1.Location = new System.Drawing.Point(41, 25);
            this.image1.Name = "image1";
            this.image1.ResourceID = "logon";
            this.image1.Size = new System.Drawing.Size(45, 45);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel5.BorderColor = System.Drawing.Color.Silver;
            this.panel5.BorderRadius = 5;
            this.panel5.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label2,
            this.label3,
            this.panel});
            this.panel5.Location = new System.Drawing.Point(5, 241);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(290, 321);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.FontSize = 14F;
            this.label2.Location = new System.Drawing.Point(0, 26);
            this.label2.Name = "label2";
            this.label2.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label2.Size = new System.Drawing.Size(290, 71);
            this.label2.Text = "Panel控件的Scrollable属性可使panel具有滚动属性,RaiseReachEnd属性可使panel触发ReachEnd事件";
            this.label2.VerticalAlignment = Smobiler.Core.Controls.VerticalAlignment.Top;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label3.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.label3.FontSize = 16F;
            this.label3.Name = "label3";
            this.label3.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label3.Size = new System.Drawing.Size(290, 26);
            this.label3.Text = "可滚动的Panel(滚动容器嵌套会发生冲突)";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Gainsboro;
            this.panel.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label4,
            this.label5,
            this.label6,
            this.label7});
            this.panel.Location = new System.Drawing.Point(0, 97);
            this.panel.Name = "panel";
            this.panel.RaiseReachEnd = true;
            this.panel.Scrollable = true;
            this.panel.Size = new System.Drawing.Size(290, 223);
            this.panel.ReachEnd += new System.EventHandler(this.panel3_ReachEnd);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 71);
            this.label4.Text = "设置Scrollable为true，并且当panel中的内容超过panel设定的高度时，可以滚动";
            // 
            // label5
            // 
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 35);
            this.label5.Text = "顶部";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 35);
            this.label6.Text = "中部";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(0, 464);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(250, 35);
            this.label7.Text = "底部";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel6.BorderColor = System.Drawing.Color.Silver;
            this.panel6.BorderRadius = 5;
            this.panel6.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label8,
            this.label9,
            this.btnScrollToBottom,
            this.btnScrollToTop});
            this.panel6.Location = new System.Drawing.Point(5, 572);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(290, 127);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label8.FontSize = 15F;
            this.label8.Location = new System.Drawing.Point(0, 26);
            this.label8.Name = "label8";
            this.label8.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label8.Size = new System.Drawing.Size(290, 42);
            this.label8.Text = "ScrollToBottom、ScrollToTop方法可使Panel滚动到底部、顶部\r\n";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label9.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.label9.FontSize = 16F;
            this.label9.Name = "label9";
            this.label9.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label9.Size = new System.Drawing.Size(290, 26);
            this.label9.Text = "Panel滚动方法";
            // 
            // btnScrollToBottom
            // 
            this.btnScrollToBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(78)))));
            this.btnScrollToBottom.Location = new System.Drawing.Point(25, 83);
            this.btnScrollToBottom.Name = "btnScrollToBottom";
            this.btnScrollToBottom.Size = new System.Drawing.Size(100, 30);
            this.btnScrollToBottom.Text = "滚动到底部";
            this.btnScrollToBottom.Press += new System.EventHandler(this.btnScrollToBottom_Press);
            // 
            // btnScrollToTop
            // 
            this.btnScrollToTop.Location = new System.Drawing.Point(151, 83);
            this.btnScrollToTop.Name = "btnScrollToTop";
            this.btnScrollToTop.Size = new System.Drawing.Size(100, 30);
            this.btnScrollToTop.Text = "滚动到顶部";
            this.btnScrollToTop.Press += new System.EventHandler(this.btnScrollToTop_Press);
            // 
            // demoPanel
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel1});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Name = "demoPanel";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Panel panel1;
        private Core.Controls.Panel panel2;
        private Core.Controls.Label labContent;
        private Core.Controls.Label labTitle;
        private Core.Controls.Panel panel4;
        private Core.Controls.Label label1;
        private Core.Controls.Panel panel3;
        private Core.Controls.Image image1;
        private Core.Controls.Panel panel5;
        private Core.Controls.Label label2;
        private Core.Controls.Label label3;
        private Core.Controls.Panel panel;
        private Core.Controls.Label label4;
        private Core.Controls.Label label5;
        private Core.Controls.Label label6;
        private Core.Controls.Label label7;
        private Core.Controls.Panel panel6;
        private Core.Controls.Label label8;
        private Core.Controls.Label label9;
        private Core.Controls.Button btnScrollToBottom;
        private Core.Controls.Button btnScrollToTop;
    }
}