using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Samples.ListView
{
    partial class demoListViewRowBind : Smobiler.Core.Controls.MobileForm
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
            this.listView1 = new Smobiler.Core.Controls.ListView();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "arrow-left";
            this.title1.Size = new System.Drawing.Size(0, 30);
            this.title1.Text = "demoListViewRowBind";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(0, 30);
            this.listView1.Name = "listView1";
            this.listView1.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.listView1.PageSizeTextSize = 11F;
            this.listView1.Size = new System.Drawing.Size(300, 338);
            this.listView1.RowBinding += new Smobiler.Core.Controls.ListViewTemplateBindEventHandler(this.listView1_RowBinding);
            this.listView1.RowBind += new Smobiler.Core.Controls.ListViewTemplateBindEventHandler(this.listView1_RowBind);
            // 
            // demoListViewRowBind
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.listView1});
            this.Load += new System.EventHandler(this.demoListViewRowBind_Load);
            this.Name = "demoListViewRowBind";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.ListView listView1;
    }
}