using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Plugins
{
    partial class demoEChart : Smobiler.Core.Controls.MobileForm
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
            this.label1 = new Smobiler.Core.Controls.Label();
            this.eCharts1 = new Smobiler.Plugins.ECharts();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.button2 = new Smobiler.Core.Controls.Button();
            this.button3 = new Smobiler.Core.Controls.Button();
            this.button4 = new Smobiler.Core.Controls.Button();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "ECharts";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.eCharts1,
            this.button1,
            this.button2,
            this.button3,
            this.button4});
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Scrollable = true;
            this.panel1.Size = new System.Drawing.Size(300, 100);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 45);
            this.label1.Text = "ECharts控件，仅在网页中可使用";
            // 
            // eCharts1
            // 
            this.eCharts1.Dock = System.Windows.Forms.DockStyle.Top;
            this.eCharts1.Location = new System.Drawing.Point(0, 47);
            this.eCharts1.Name = "eCharts1";
            this.eCharts1.Size = new System.Drawing.Size(300, 230);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.Text = "折线柱状图";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(181, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 35);
            this.button2.Text = "雷达图";
            this.button2.Press += new System.EventHandler(this.button2_Press);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(17, 331);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 35);
            this.button3.Text = "饼图";
            this.button3.Press += new System.EventHandler(this.button3_Press);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(181, 331);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 35);
            this.button4.Text = "仪表盘";
            this.button4.Press += new System.EventHandler(this.button4_Press);
            // 
            // demoEChart
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel1});
            this.Name = "demoEChart";
            this.Name = "demoEChart";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Panel panel1;
        private Core.Controls.Label label1;
        private Smobiler.Plugins.ECharts eCharts1;
        private Core.Controls.Button button1;
        private Core.Controls.Button button2;
        private Core.Controls.Button button3;
        private Core.Controls.Button button4;
    }
}