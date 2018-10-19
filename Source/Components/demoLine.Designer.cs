using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Components
{
    partial class demoLine : Smobiler.Core.Controls.MobileForm
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
            this.line1 = new Smobiler.Core.Controls.Line();
            this.line2 = new Smobiler.Core.Controls.Line();
            this.line3 = new Smobiler.Core.Controls.Line();
            this.line4 = new Smobiler.Core.Controls.Line();
            this.line5 = new Smobiler.Core.Controls.Line();
            this.line6 = new Smobiler.Core.Controls.Line();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "Line";
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
            this.line1,
            this.line2,
            this.line3,
            this.line4,
            this.line5,
            this.line6});
            this.panel1.Location = new System.Drawing.Point(5, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 363);
            // 
            // labContent
            // 
            this.labContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labContent.Location = new System.Drawing.Point(0, 26);
            this.labContent.Name = "labContent";
            this.labContent.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labContent.Size = new System.Drawing.Size(290, 54);
            this.labContent.Text = "线条控件，基础控件，其中Orientation设置线条方向";
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
            this.labTitle.Text = "不同样式的线条";
            // 
            // line1
            // 
            this.line1.Location = new System.Drawing.Point(7, 91);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(80, 8);
            // 
            // line2
            // 
            this.line2.Location = new System.Drawing.Point(7, 115);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(270, 1);
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.Color.Red;
            this.line3.Location = new System.Drawing.Point(7, 135);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(270, 1);
            // 
            // line4
            // 
            this.line4.Location = new System.Drawing.Point(31, 153);
            this.line4.Name = "line4";
            this.line4.Orientation = Smobiler.Core.Controls.OrientationAlignment.Vertical;
            this.line4.Size = new System.Drawing.Size(8, 80);
            // 
            // line5
            // 
            this.line5.Location = new System.Drawing.Point(69, 153);
            this.line5.Name = "line5";
            this.line5.Orientation = Smobiler.Core.Controls.OrientationAlignment.Vertical;
            this.line5.Size = new System.Drawing.Size(1, 182);
            // 
            // line6
            // 
            this.line6.BackColor = System.Drawing.Color.Red;
            this.line6.Location = new System.Drawing.Point(105, 153);
            this.line6.Name = "line6";
            this.line6.Orientation = Smobiler.Core.Controls.OrientationAlignment.Vertical;
            this.line6.Size = new System.Drawing.Size(1, 182);
            // 
            // demoLine
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel10});
            this.Name = "demoLine";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Panel panel10;
        private Core.Controls.Panel panel1;
        private Core.Controls.Label labContent;
        private Core.Controls.Label labTitle;
        private Core.Controls.Line line1;
        private Core.Controls.Line line2;
        private Core.Controls.Line line3;
        private Core.Controls.Line line4;
        private Core.Controls.Line line5;
        private Core.Controls.Line line6;
    }
}