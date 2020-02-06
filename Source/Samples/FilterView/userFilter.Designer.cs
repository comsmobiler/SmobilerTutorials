using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Samples
{
    partial class userFilter : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        public userFilter()
            : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call
        }

        //SmobilerUserControl overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerUserControl
        //It can be modified using the SmobilerUserControl.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.segmentedControl1 = new Smobiler.Core.Controls.SegmentedControl();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.fontIcon1 = new Smobiler.Core.Controls.FontIcon();
            this.panel3 = new Smobiler.Core.Controls.Panel();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.fontIcon2 = new Smobiler.Core.Controls.FontIcon();
            this.panel4 = new Smobiler.Core.Controls.Panel();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.fontIcon3 = new Smobiler.Core.Controls.FontIcon();
            this.userFilterItem1 = new Smobiler.Tutorials.Samples.userFilterItem();
            // 
            // segmentedControl1
            // 
            this.segmentedControl1.Items = new string[] {
        "ÍÆ¼ö",
        "´¨Î¶»ð¹ø",
        "ÀÏ±±¾©»ð¹ø",
        "Óã»ð¹ø"};
            this.segmentedControl1.Name = "segmentedControl1";
            this.segmentedControl1.SegmentedBorderRadius = 0;
            this.segmentedControl1.SelectedBackColor = System.Drawing.Color.WhiteSmoke;
            this.segmentedControl1.SelectedColor = System.Drawing.Color.DeepSkyBlue;
            this.segmentedControl1.Size = new System.Drawing.Size(0, 35);
            this.segmentedControl1.UnSelectedBackColor = System.Drawing.Color.White;
            this.segmentedControl1.UnSelectedColor = System.Drawing.Color.Black;
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel2,
            this.panel3,
            this.panel4});
            this.panel1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.panel1.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 35);
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.fontIcon1});
            this.panel2.Flex = 1;
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(50, 0);
            this.panel2.Touchable = true;
            this.panel2.Press += new System.EventHandler(this.panel2_Press);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 21);
            this.label1.Text = "¸½½ü";
            // 
            // fontIcon1
            // 
            this.fontIcon1.ForeColor = System.Drawing.Color.Blue;
            this.fontIcon1.Location = new System.Drawing.Point(67, 9);
            this.fontIcon1.Name = "fontIcon1";
            this.fontIcon1.ResourceID = "caret-down";
            this.fontIcon1.Size = new System.Drawing.Size(21, 21);
            // 
            // panel3
            // 
            this.panel3.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label2,
            this.fontIcon2});
            this.panel3.Flex = 1;
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(50, 0);
            this.panel3.Touchable = true;
            this.panel3.Press += new System.EventHandler(this.panel3_Press);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 21);
            this.label2.Text = "ÖÇÄÜÅÅÐò";
            // 
            // fontIcon2
            // 
            this.fontIcon2.ForeColor = System.Drawing.Color.Blue;
            this.fontIcon2.Location = new System.Drawing.Point(67, 9);
            this.fontIcon2.Name = "fontIcon2";
            this.fontIcon2.ResourceID = "caret-up";
            this.fontIcon2.Size = new System.Drawing.Size(21, 21);
            // 
            // panel4
            // 
            this.panel4.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label3,
            this.fontIcon3});
            this.panel4.Flex = 1;
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 0);
            this.panel4.Touchable = true;
            this.panel4.Press += new System.EventHandler(this.panel4_Press);
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label3.Location = new System.Drawing.Point(19, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 21);
            this.label3.Text = "É¸Ñ¡";
            // 
            // fontIcon3
            // 
            this.fontIcon3.ForeColor = System.Drawing.Color.Blue;
            this.fontIcon3.Location = new System.Drawing.Point(67, 9);
            this.fontIcon3.Name = "fontIcon3";
            this.fontIcon3.ResourceID = "caret-up";
            this.fontIcon3.Size = new System.Drawing.Size(21, 21);
            // 
            // userFilterItem1
            // 
            this.userFilterItem1.Flex = 1;
            this.userFilterItem1.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.userFilterItem1.Name = "userFilterItem1";
            this.userFilterItem1.Size = new System.Drawing.Size(0, 30);
            // 
            // userFilter
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.segmentedControl1,
            this.panel1,
            this.userFilterItem1});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Load += new System.EventHandler(this.userFilter_Load);
            this.Name = "userFilter";

        }
        #endregion

        private Smobiler.Core.Controls.SegmentedControl segmentedControl1;
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Panel panel2;
        private Smobiler.Core.Controls.Panel panel3;
        private Smobiler.Core.Controls.Panel panel4;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.FontIcon fontIcon1;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.FontIcon fontIcon2;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.FontIcon fontIcon3;
        private userFilterItem userFilterItem1;
    }
}