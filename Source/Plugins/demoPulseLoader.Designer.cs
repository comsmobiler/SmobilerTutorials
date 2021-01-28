using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Plugins
{
    partial class demoPulseLoader : Smobiler.Core.Controls.MobileForm
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
            this.pulseLoader1 = new Smobiler.Plugins.PulseLoader();
            this.panel3 = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.pulseLoader2 = new Smobiler.Plugins.PulseLoader();
            this.pulseLoader3 = new Smobiler.Plugins.PulseLoader();
            this.panel4 = new Smobiler.Core.Controls.Panel();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.pulseLoader4 = new Smobiler.Plugins.PulseLoader();
            this.pulseLoader5 = new Smobiler.Plugins.PulseLoader();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "TextBox";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel2,
            this.panel3,
            this.panel4});
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
            this.pulseLoader1});
            this.panel2.Location = new System.Drawing.Point(5, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 192);
            // 
            // labContent
            // 
            this.labContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labContent.FontSize = 15F;
            this.labContent.Location = new System.Drawing.Point(0, 26);
            this.labContent.Name = "labContent";
            this.labContent.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labContent.Size = new System.Drawing.Size(290, 86);
            this.labContent.Text = "ResourceID，ReSourcePath，ReSourceMode设置图片名称路径，资源模式；\r\n点击控件可以触发OnPress事件\r\n\r\n";
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
            this.labTitle.Text = "动态Loader";
            // 
            // pulseLoader1
            // 
            this.pulseLoader1.CircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(176)))), ((int)(((byte)(249)))));
            this.pulseLoader1.Location = new System.Drawing.Point(110, 126);
            this.pulseLoader1.Name = "pulseLoader1";
            this.pulseLoader1.ResourceID = "Logon";
            this.pulseLoader1.Size = new System.Drawing.Size(70, 46);
            this.pulseLoader1.onPress += new System.EventHandler(this.pulseLoader1_onPress);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel3.BorderColor = System.Drawing.Color.Silver;
            this.panel3.BorderRadius = 5;
            this.panel3.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.pulseLoader2,
            this.pulseLoader3});
            this.panel3.Location = new System.Drawing.Point(5, 210);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(290, 192);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.FontSize = 15F;
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label1.Size = new System.Drawing.Size(290, 55);
            this.label1.Text = "ImageScale 设置图片在 控件所占比例；\r\nInteval设置边缘脉冲产生的间隔（单位毫秒）\r\n";
            // 
            // pulseLoader2
            // 
            this.pulseLoader2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(76)))), ((int)(((byte)(176)))), ((int)(((byte)(249)))));
            this.pulseLoader2.CircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(176)))), ((int)(((byte)(249)))));
            this.pulseLoader2.Location = new System.Drawing.Point(42, 90);
            this.pulseLoader2.Name = "pulseLoader2";
            this.pulseLoader2.ResourceID = "Logon";
            this.pulseLoader2.Size = new System.Drawing.Size(70, 70);
            // 
            // pulseLoader3
            // 
            this.pulseLoader3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(76)))), ((int)(((byte)(176)))), ((int)(((byte)(249)))));
            this.pulseLoader3.CircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(176)))), ((int)(((byte)(249)))));
            this.pulseLoader3.ImageScale = 0.8F;
            this.pulseLoader3.Interval = 4000;
            this.pulseLoader3.Location = new System.Drawing.Point(171, 90);
            this.pulseLoader3.Name = "pulseLoader3";
            this.pulseLoader3.ResourceID = "Logon";
            this.pulseLoader3.Size = new System.Drawing.Size(70, 70);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel4.BorderColor = System.Drawing.Color.Silver;
            this.panel4.BorderRadius = 5;
            this.panel4.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label2,
            this.pulseLoader4,
            this.pulseLoader5});
            this.panel4.Location = new System.Drawing.Point(5, 414);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(290, 192);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.FontSize = 15F;
            this.label2.Name = "label2";
            this.label2.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label2.Size = new System.Drawing.Size(290, 55);
            this.label2.Text = "CallBack 设置按钮点击时是否产生loadding\r\nCircleColor 设置边缘脉冲颜色";
            // 
            // pulseLoader4
            // 
            this.pulseLoader4.CircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pulseLoader4.Location = new System.Drawing.Point(41, 81);
            this.pulseLoader4.Name = "pulseLoader4";
            this.pulseLoader4.ResourceID = "Logon";
            this.pulseLoader4.Size = new System.Drawing.Size(70, 70);
            // 
            // pulseLoader5
            // 
            this.pulseLoader5.CallBack = true;
            this.pulseLoader5.CircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(176)))), ((int)(((byte)(249)))));
            this.pulseLoader5.Interval = 4000;
            this.pulseLoader5.Location = new System.Drawing.Point(176, 81);
            this.pulseLoader5.Name = "pulseLoader5";
            this.pulseLoader5.ResourceID = "Logon";
            this.pulseLoader5.Size = new System.Drawing.Size(70, 70);
            // 
            // demoPulseLoader
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel1});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Name = "demoPulseLoader";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Panel panel1;
        private Core.Controls.Panel panel2;
        private Core.Controls.Label labContent;
        private Core.Controls.Label labTitle;
        private Smobiler.Plugins.PulseLoader pulseLoader1;
        private Core.Controls.Panel panel3;
        private Core.Controls.Label label1;
        private Smobiler.Plugins.PulseLoader pulseLoader2;
        private Smobiler.Plugins.PulseLoader pulseLoader3;
        private Core.Controls.Panel panel4;
        private Core.Controls.Label label2;
        private Smobiler.Plugins.PulseLoader pulseLoader4;
        private Smobiler.Plugins.PulseLoader pulseLoader5;
    }
}