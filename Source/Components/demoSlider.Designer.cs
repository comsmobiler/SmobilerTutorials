using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Components
{
    partial class demoSlider : Smobiler.Core.Controls.MobileForm
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
            this.slider1 = new Smobiler.Core.Controls.Slider();
            this.slider2 = new Smobiler.Core.Controls.Slider();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.slider3 = new Smobiler.Core.Controls.Slider();
            this.slider4 = new Smobiler.Core.Controls.Slider();
            this.slider5 = new Smobiler.Core.Controls.Slider();
            this.panel3 = new Smobiler.Core.Controls.Panel();
            this.label13 = new Smobiler.Core.Controls.Label();
            this.label14 = new Smobiler.Core.Controls.Label();
            this.slider6 = new Smobiler.Core.Controls.Slider();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "Slider";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // panel10
            // 
            this.panel10.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1,
            this.panel2,
            this.panel3});
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
            this.slider1,
            this.slider2});
            this.panel1.Location = new System.Drawing.Point(5, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 179);
            // 
            // labContent
            // 
            this.labContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labContent.FontSize = 15F;
            this.labContent.Location = new System.Drawing.Point(0, 26);
            this.labContent.Name = "labContent";
            this.labContent.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labContent.Size = new System.Drawing.Size(290, 54);
            this.labContent.Text = "滚动条控件，基础控件";
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
            this.labTitle.Text = "不同样式的滚动条";
            // 
            // slider1
            // 
            this.slider1.Location = new System.Drawing.Point(9, 101);
            this.slider1.Name = "slider1";
            this.slider1.Size = new System.Drawing.Size(268, 10);
            // 
            // slider2
            // 
            this.slider2.HandleColor = System.Drawing.Color.DimGray;
            this.slider2.Location = new System.Drawing.Point(9, 133);
            this.slider2.Name = "slider2";
            this.slider2.Size = new System.Drawing.Size(268, 28);
            this.slider2.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(78)))));
            this.slider2.ValueColor = System.Drawing.Color.Red;
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
            this.slider3,
            this.slider4,
            this.slider5});
            this.panel2.Location = new System.Drawing.Point(5, 203);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 219);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.FontSize = 15F;
            this.label5.Location = new System.Drawing.Point(0, 26);
            this.label5.Name = "label5";
            this.label5.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label5.Size = new System.Drawing.Size(290, 54);
            this.label5.Text = "Value、MinValue、MaxValue、Step属性设置滚动条滑动时变化";
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
            this.label6.Text = "滚动条特色属性";
            // 
            // slider3
            // 
            this.slider3.Location = new System.Drawing.Point(13, 97);
            this.slider3.MaxValue = 3F;
            this.slider3.Name = "slider3";
            this.slider3.Size = new System.Drawing.Size(256, 20);
            this.slider3.Step = 1F;
            this.slider3.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(67)))), ((int)(((byte)(81)))));
            // 
            // slider4
            // 
            this.slider4.Location = new System.Drawing.Point(13, 145);
            this.slider4.MaxValue = 100F;
            this.slider4.Name = "slider4";
            this.slider4.Size = new System.Drawing.Size(256, 20);
            this.slider4.Step = 10F;
            this.slider4.Value = 30F;
            // 
            // slider5
            // 
            this.slider5.Location = new System.Drawing.Point(13, 189);
            this.slider5.MaxValue = 100F;
            this.slider5.Name = "slider5";
            this.slider5.Size = new System.Drawing.Size(256, 20);
            this.slider5.Step = 1F;
            this.slider5.Value = 70F;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel3.BorderColor = System.Drawing.Color.Silver;
            this.panel3.BorderRadius = 5;
            this.panel3.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label13,
            this.label14,
            this.slider6});
            this.panel3.Location = new System.Drawing.Point(5, 437);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(290, 131);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label13.FontSize = 15F;
            this.label13.Location = new System.Drawing.Point(0, 26);
            this.label13.Name = "label13";
            this.label13.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label13.Size = new System.Drawing.Size(290, 54);
            this.label13.Text = "ValueChanged在滚动条值改变时发生";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label14.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label14.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.label14.FontSize = 16F;
            this.label14.Name = "label14";
            this.label14.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label14.Size = new System.Drawing.Size(290, 26);
            this.label14.Text = "滚动条事件";
            // 
            // slider6
            // 
            this.slider6.Location = new System.Drawing.Point(15, 95);
            this.slider6.MaxValue = 10F;
            this.slider6.Name = "slider6";
            this.slider6.Size = new System.Drawing.Size(252, 20);
            this.slider6.Step = 1F;
            this.slider6.Value = 3F;
            this.slider6.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(176)))), ((int)(((byte)(249)))));
            this.slider6.ValueChanged += new System.EventHandler(this.slider6_ValueChanged);
            // 
            // demoSlider
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel10});
            this.Size = new System.Drawing.Size(300, 1000);
            this.Name = "demoSlider";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Panel panel10;
        private Core.Controls.Panel panel1;
        private Core.Controls.Label labContent;
        private Core.Controls.Label labTitle;
        private Core.Controls.Panel panel2;
        private Core.Controls.Label label5;
        private Core.Controls.Label label6;
        private Core.Controls.Panel panel3;
        private Core.Controls.Label label13;
        private Core.Controls.Label label14;
        private Core.Controls.Slider slider1;
        private Core.Controls.Slider slider2;
        private Core.Controls.Slider slider3;
        private Core.Controls.Slider slider4;
        private Core.Controls.Slider slider5;
        private Core.Controls.Slider slider6;
    }
}