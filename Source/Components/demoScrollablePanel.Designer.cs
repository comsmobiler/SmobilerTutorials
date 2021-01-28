using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Components
{
    partial class demoScrollablePanel : Smobiler.Core.Controls.MobileForm
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
            this.panel = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.btnScrollToBottom = new Smobiler.Core.Controls.Button();
            this.btnScrollToTop = new Smobiler.Core.Controls.Button();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "ScrollablePanel";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // panel10
            // 
            this.panel10.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1,
            this.panel2});
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 30);
            this.panel10.Name = "panel10";
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
            this.panel});
            this.panel1.Location = new System.Drawing.Point(5, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 321);
            // 
            // labContent
            // 
            this.labContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labContent.FontSize = 14F;
            this.labContent.Location = new System.Drawing.Point(0, 26);
            this.labContent.Name = "labContent";
            this.labContent.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labContent.Size = new System.Drawing.Size(290, 44);
            this.labContent.Text = "Panel控件的Scrollable属性可使panel具有滚动属性,RaiseReachEnd属性可使panel触发ReachEnd事件";
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
            this.labTitle.Text = "可滚动的容器控件(滚动容器嵌套会发生冲突)";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Gainsboro;
            this.panel.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.label2,
            this.label3,
            this.label4});
            this.panel.Location = new System.Drawing.Point(0, 70);
            this.panel.Name = "panel";
            this.panel.RaiseReachEnd = true;
            this.panel.Scrollable = true;
            this.panel.Size = new System.Drawing.Size(290, 250);
            this.panel.ReachEnd += new System.EventHandler(this.panel3_ReachEnd);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 71);
            this.label1.Text = "设置Scrollable为true，并且当panel中的内容超过panel设定的高度时，可以滚动";
            // 
            // label2
            // 
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 35);
            this.label2.Text = "顶部";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 35);
            this.label3.Text = "中部";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 464);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 35);
            this.label4.Text = "底部";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel2.BorderColor = System.Drawing.Color.Silver;
            this.panel2.BorderRadius = 5;
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label5,
            this.label6,
            this.btnScrollToBottom,
            this.btnScrollToTop});
            this.panel2.Location = new System.Drawing.Point(5, 341);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 127);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.FontSize = 15F;
            this.label5.Location = new System.Drawing.Point(0, 26);
            this.label5.Name = "label5";
            this.label5.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label5.Size = new System.Drawing.Size(290, 42);
            this.label5.Text = "ScrollToBottom、ScrollToTop方法可使Panel滚动到底部、顶部\r\n";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label6.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.label6.FontSize = 16F;
            this.label6.Name = "label6";
            this.label6.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label6.Size = new System.Drawing.Size(290, 26);
            this.label6.Text = "Panel滚动方法";
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
            // demoScrollablePanel
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel10});
            this.Size = new System.Drawing.Size(300, 1000);
            this.Name = "demoScrollablePanel";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Panel panel10;
        private Core.Controls.Panel panel1;
        private Core.Controls.Label labContent;
        private Core.Controls.Label labTitle;
        private Core.Controls.Panel panel;
        private Core.Controls.Label label1;
        private Core.Controls.Label label2;
        private Core.Controls.Label label3;
        private Core.Controls.Label label4;
        private Core.Controls.Panel panel2;
        private Core.Controls.Label label5;
        private Core.Controls.Label label6;
        private Core.Controls.Button btnScrollToBottom;
        private Core.Controls.Button btnScrollToTop;
    }
}