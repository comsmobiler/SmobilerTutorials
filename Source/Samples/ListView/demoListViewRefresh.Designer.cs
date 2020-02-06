using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Samples
{
    partial class demoListViewRefresh : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public demoListViewRefresh()
            : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call
        }

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
            this.listView1 = new Smobiler.Core.Controls.ListView();
            this.title1 = new Smobiler.Core.Controls.Title();
            // 
            // listView1
            // 
            this.listView1.Flex = 1;
            this.listView1.Name = "listView1";
            this.listView1.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.listView1.PageSizeTextSize = 11F;
            this.listView1.RaiseRefresh = true;
            this.listView1.ShowSplitLine = true;
            this.listView1.Size = new System.Drawing.Size(0, 300);
            this.listView1.Refresh += new System.EventHandler(this.listView1_Refresh);
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "arrow-left";
            this.title1.Size = new System.Drawing.Size(0, 30);
            this.title1.Text = "demoListViewRefresh";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // demoListViewRefresh
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.listView1});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Load += new System.EventHandler(this.demoListViewRefresh_Load);
            this.Name = "demoListViewRefresh";

        }
        #endregion

        private Smobiler.Core.Controls.ListView listView1;
        private Smobiler.Core.Controls.Title title1;
    }
}