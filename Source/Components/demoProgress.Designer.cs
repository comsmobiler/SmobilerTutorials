using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Components
{
    partial class demoProgress : Smobiler.Core.Controls.MobileForm
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
            this.progress1 = new Smobiler.Core.Controls.Progress();
            this.progress2 = new Smobiler.Core.Controls.Progress();
            this.progress3 = new Smobiler.Core.Controls.Progress();
            this.progress4 = new Smobiler.Core.Controls.Progress();
            this.timer1 = new Smobiler.Core.Controls.Timer();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "Progress";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // panel10
            // 
            this.panel10.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
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
            this.progress1,
            this.progress2,
            this.progress3,
            this.progress4});
            this.panel1.Location = new System.Drawing.Point(5, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 205);
            // 
            // labContent
            // 
            this.labContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labContent.Location = new System.Drawing.Point(0, 26);
            this.labContent.Name = "labContent";
            this.labContent.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labContent.Size = new System.Drawing.Size(290, 54);
            this.labContent.Text = "进度条控件，基础控件，Value、TrackColor、ValueColor属性设置不同样式的进度条控件\r\n";
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
            this.labTitle.Text = "不同样式的进度条控件";
            // 
            // progress1
            // 
            this.progress1.Location = new System.Drawing.Point(3, 91);
            this.progress1.Name = "progress1";
            this.progress1.Size = new System.Drawing.Size(280, 15);
            // 
            // progress2
            // 
            this.progress2.Location = new System.Drawing.Point(3, 121);
            this.progress2.Name = "progress2";
            this.progress2.Size = new System.Drawing.Size(280, 15);
            this.progress2.Value = 0.3F;
            this.progress2.ValueColor = System.Drawing.Color.Red;
            // 
            // progress3
            // 
            this.progress3.Location = new System.Drawing.Point(3, 149);
            this.progress3.Name = "progress3";
            this.progress3.Size = new System.Drawing.Size(280, 15);
            this.progress3.TrackColor = System.Drawing.Color.White;
            this.progress3.Value = 0.7F;
            this.progress3.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            // 
            // progress4
            // 
            this.progress4.Location = new System.Drawing.Point(3, 179);
            this.progress4.Name = "progress4";
            this.progress4.Size = new System.Drawing.Size(280, 15);
            // 
            // timer1
            // 
            this.timer1.Name = "timer1";
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // demoProgress
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.timer1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel10});
            this.Size = new System.Drawing.Size(300, 1000);
            this.Load += new System.EventHandler(this.demoProgress_Load);
            this.Name = "demoProgress";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Panel panel10;
        private Core.Controls.Panel panel1;
        private Core.Controls.Label labContent;
        private Core.Controls.Label labTitle;
        private Core.Controls.Progress progress1;
        private Core.Controls.Progress progress2;
        private Core.Controls.Progress progress3;
        private Core.Controls.Progress progress4;
        private Core.Controls.Timer timer1;
    }
}