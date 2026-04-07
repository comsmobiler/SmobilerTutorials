using Smobiler.Core;
using System;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoGestureView : Smobiler.Core.Controls.MobileForm
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
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.labContent = new Smobiler.Core.Controls.Label();
            this.labTitle = new Smobiler.Core.Controls.Label();
            this.gestureView1 = new Smobiler.Plugins.GestureView();
            this.gestureView2 = new Smobiler.Plugins.GestureView();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.button2 = new Smobiler.Core.Controls.Button();
            // 
            // title1
            // 
            this.title1.Location = new System.Drawing.Point(140, 35);
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(100, 30);
            this.title1.Text = "demoGesture";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel2.BorderColor = System.Drawing.Color.Silver;
            this.panel2.BorderRadius = 5;
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.labContent,
            this.labTitle});
            this.panel2.Location = new System.Drawing.Point(4, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 65);
            // 
            // labContent
            // 
            this.labContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labContent.FontSize = 15F;
            this.labContent.Location = new System.Drawing.Point(0, 26);
            this.labContent.Name = "labContent";
            this.labContent.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labContent.Size = new System.Drawing.Size(290, 37);
            this.labContent.Text = " 滑动下方容器";
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
            this.labTitle.Text = "带滑动特效的容器";
            // 
            // gestureView1
            // 
            this.gestureView1.BackColor = System.Drawing.Color.White;
            this.gestureView1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.button1});
            this.gestureView1.Location = new System.Drawing.Point(11, 131);
            this.gestureView1.Name = "gestureView1";
            this.gestureView1.Size = new System.Drawing.Size(266, 137);
            this.gestureView1.onChanged += new Smobiler.Plugins.GestureViewChangedEventHandler(this.gestureView1_onChanged);
            // 
            // gestureView2
            // 
            this.gestureView2.BackColor = System.Drawing.Color.White;
            this.gestureView2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.button2});
            this.gestureView2.Location = new System.Drawing.Point(11, 303);
            this.gestureView2.Name = "gestureView2";
            this.gestureView2.Size = new System.Drawing.Size(266, 126);
            this.gestureView2.SlideType = Smobiler.Plugins.SlideType.Vertical;
            this.gestureView2.onChanged += new Smobiler.Plugins.GestureViewChangedEventHandler(this.gestureView1_onChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.Text = "左右滑动";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(88, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 35);
            this.button2.Text = "上下滑动";
            // 
            // demoGestureView
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel2,
            this.gestureView1,
            this.gestureView2});
            this.Name = "demoGestureView";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Panel panel2;
        private Core.Controls.Label labContent;
        private Core.Controls.Label labTitle;
        private Smobiler.Plugins.GestureView gestureView1;
        private Core.Controls.Button button1;
        private Smobiler.Plugins.GestureView gestureView2;
        private Core.Controls.Button button2;
    }
}