using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Samples.Transparent
{
    partial class demoTransparent : Smobiler.Core.Controls.MobileForm
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
            this.pageView1 = new Smobiler.Core.Controls.PageView();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.fontIcon2 = new Smobiler.Core.Controls.FontIcon();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.imageButton1 = new Smobiler.Core.Controls.ImageButton();
            // 
            // pageView1
            // 
            this.pageView1.BorderRadius = 20;
            this.pageView1.IsLoop = true;
            this.pageView1.Name = "pageView1";
            this.pageView1.Size = new System.Drawing.Size(300, 80);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.fontIcon2,
            this.label1,
            this.label2,
            this.imageButton1});
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 40);
            // 
            // fontIcon2
            // 
            this.fontIcon2.Location = new System.Drawing.Point(245, 0);
            this.fontIcon2.Name = "fontIcon2";
            this.fontIcon2.Padding = new Smobiler.Core.Controls.Padding(8F);
            this.fontIcon2.ResourceID = "search";
            this.fontIcon2.Size = new System.Drawing.Size(40, 40);
            // 
            // label1
            // 
            this.label1.FontSize = 16F;
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label1.Location = new System.Drawing.Point(94, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.Text = "Timeable";
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label2.Location = new System.Drawing.Point(93, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.Text = "香港";
            // 
            // imageButton1
            // 
            this.imageButton1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.imageButton1.ImgTextRatio = new Smobiler.Core.Controls.Ratio(10, 0);
            this.imageButton1.Location = new System.Drawing.Point(10, 0);
            this.imageButton1.Name = "imageButton1";
            this.imageButton1.ResourceID = "arrow-left";
            this.imageButton1.Size = new System.Drawing.Size(39, 40);
            this.imageButton1.Press += new System.EventHandler(this.imageButton1_Press);
            // 
            // demoTransparent
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.pageView1,
            this.panel1});
            this.Load += new System.EventHandler(this.demoTransparent_Load);
            this.Name = "demoTransparent";

        }
        #endregion

        private Smobiler.Core.Controls.PageView pageView1;
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.FontIcon fontIcon2;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.ImageButton imageButton1;
    }
}