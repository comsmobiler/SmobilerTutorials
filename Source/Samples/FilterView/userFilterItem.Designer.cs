using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Samples
{
    partial class userFilterItem : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        public userFilterItem()
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
            this.listView1 = new Smobiler.Core.Controls.ListView();
            this.listView2 = new Smobiler.Core.Controls.ListView();
            // 
            // segmentedControl1
            // 
            this.segmentedControl1.Items = new string[] {
        "…Ã»¶",
        "µÿÃ˙"};
            this.segmentedControl1.Name = "segmentedControl1";
            this.segmentedControl1.SegmentedBorderRadius = 0;
            this.segmentedControl1.SelectedBackColor = System.Drawing.Color.WhiteSmoke;
            this.segmentedControl1.SelectedColor = System.Drawing.Color.DeepSkyBlue;
            this.segmentedControl1.Size = new System.Drawing.Size(142, 35);
            this.segmentedControl1.UnSelectedBackColor = System.Drawing.Color.White;
            this.segmentedControl1.UnSelectedColor = System.Drawing.Color.Black;
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.listView1,
            this.listView2});
            this.panel1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.panel1.Flex = 1;
            this.panel1.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 100);
            // 
            // listView1
            // 
            this.listView1.Flex = 1;
            this.listView1.Name = "listView1";
            this.listView1.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.listView1.PageSizeTextSize = 11F;
            this.listView1.Size = new System.Drawing.Size(300, 0);
            // 
            // listView2
            // 
            this.listView2.Flex = 2;
            this.listView2.Name = "listView2";
            this.listView2.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.listView2.PageSizeTextSize = 11F;
            this.listView2.Size = new System.Drawing.Size(300, 0);
            // 
            // userFilterItem
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.segmentedControl1,
            this.panel1});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Load += new System.EventHandler(this.userFilterItem_Load);
            this.Name = "userFilterItem";

        }
        #endregion

        private Smobiler.Core.Controls.SegmentedControl segmentedControl1;
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.ListView listView1;
        private Smobiler.Core.Controls.ListView listView2;
    }
}