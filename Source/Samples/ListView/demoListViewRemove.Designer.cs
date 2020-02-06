using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Samples
{
    partial class demoListViewRemove : Smobiler.Core.Controls.MobileForm
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
            this.listView1 = new Smobiler.Core.Controls.ListView();
            this.title1 = new Smobiler.Core.Controls.Title();
            this.btnRemoveIndex = new Smobiler.Core.Controls.Button();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(0, 30);
            this.listView1.Name = "listView1";
            this.listView1.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.listView1.PageSizeTextSize = 11F;
            this.listView1.Size = new System.Drawing.Size(300, 338);
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "arrow-left";
            this.title1.Size = new System.Drawing.Size(0, 30);
            this.title1.Text = "demoListViewRemove";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // btnRemoveIndex
            // 
            this.btnRemoveIndex.Location = new System.Drawing.Point(100, 401);
            this.btnRemoveIndex.Name = "btnRemoveIndex";
            this.btnRemoveIndex.Size = new System.Drawing.Size(100, 30);
            this.btnRemoveIndex.Text = "删行";
            this.btnRemoveIndex.Press += new System.EventHandler(this.btnRemoveIndex_Press);
            // 
            // demoListViewRemove
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.listView1,
            this.title1,
            this.btnRemoveIndex});
            this.Load += new System.EventHandler(this.demoListViewRemove_Load);
            this.Name = "demoListViewRemove";

        }
        #endregion

        private Core.Controls.ListView listView1;
        private Core.Controls.Title title1;
        private Core.Controls.Button btnRemoveIndex;
    }
}