using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Components
{
    partial class demoFontIcon : Smobiler.Core.Controls.MobileForm
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
            this.fontIcon1 = new Smobiler.Core.Controls.FontIcon();
            this.fontIcon2 = new Smobiler.Core.Controls.FontIcon();
            this.fontIcon3 = new Smobiler.Core.Controls.FontIcon();
            this.fontIcon4 = new Smobiler.Core.Controls.FontIcon();
            this.fontIcon5 = new Smobiler.Core.Controls.FontIcon();
            this.fontIcon6 = new Smobiler.Core.Controls.FontIcon();
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "FontIcon";
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
            this.fontIcon1,
            this.fontIcon2,
            this.fontIcon3,
            this.fontIcon4,
            this.fontIcon5,
            this.fontIcon6});
            this.panel1.Location = new System.Drawing.Point(5, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 213);
            // 
            // labContent
            // 
            this.labContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labContent.Location = new System.Drawing.Point(0, 26);
            this.labContent.Name = "labContent";
            this.labContent.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labContent.Size = new System.Drawing.Size(290, 54);
            this.labContent.Text = "字体图标控件，基础控件";
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
            this.labTitle.Text = "不同样式的字体图标";
            // 
            // fontIcon1
            // 
            this.fontIcon1.Location = new System.Drawing.Point(0, 89);
            this.fontIcon1.Name = "fontIcon1";
            this.fontIcon1.ResourceID = "angle-double-left";
            this.fontIcon1.Size = new System.Drawing.Size(98, 60);
            // 
            // fontIcon2
            // 
            this.fontIcon2.ForeColor = System.Drawing.Color.Blue;
            this.fontIcon2.Location = new System.Drawing.Point(98, 89);
            this.fontIcon2.Name = "fontIcon2";
            this.fontIcon2.ResourceID = "users";
            this.fontIcon2.Size = new System.Drawing.Size(98, 60);
            // 
            // fontIcon3
            // 
            this.fontIcon3.ForeColor = System.Drawing.Color.Red;
            this.fontIcon3.Location = new System.Drawing.Point(197, 89);
            this.fontIcon3.Name = "fontIcon3";
            this.fontIcon3.ResourceID = "times";
            this.fontIcon3.Size = new System.Drawing.Size(98, 60);
            // 
            // fontIcon4
            // 
            this.fontIcon4.Location = new System.Drawing.Point(0, 165);
            this.fontIcon4.Name = "fontIcon4";
            this.fontIcon4.ResourceID = "hand-peace-o";
            this.fontIcon4.Size = new System.Drawing.Size(100, 30);
            // 
            // fontIcon5
            // 
            this.fontIcon5.Location = new System.Drawing.Point(100, 165);
            this.fontIcon5.Name = "fontIcon5";
            this.fontIcon5.ResourceID = "hand-o-up";
            this.fontIcon5.Size = new System.Drawing.Size(100, 30);
            // 
            // fontIcon6
            // 
            this.fontIcon6.Location = new System.Drawing.Point(200, 165);
            this.fontIcon6.Name = "fontIcon6";
            this.fontIcon6.ResourceID = "chevron-circle-left";
            this.fontIcon6.Size = new System.Drawing.Size(100, 30);
            // 
            // demoFontIcon
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel10});
            this.Size = new System.Drawing.Size(300, 1000);
            this.Name = "demoFontIcon";
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Panel panel10;
        private Core.Controls.Panel panel1;
        private Core.Controls.Label labContent;
        private Core.Controls.Label labTitle;
        private Core.Controls.FontIcon fontIcon1;
        private Core.Controls.FontIcon fontIcon2;
        private Core.Controls.FontIcon fontIcon3;
        private Core.Controls.FontIcon fontIcon4;
        private Core.Controls.FontIcon fontIcon5;
        private Core.Controls.FontIcon fontIcon6;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
    }
}