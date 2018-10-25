using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Plugins
{
    partial class demoHTMLView : Smobiler.Core.Controls.MobileForm
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
            this.htmlView1 = new Smobiler.Plugins.HTMLView();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "HTMLView";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // htmlView1
            // 
            this.htmlView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlView1.Location = new System.Drawing.Point(86, 146);
            this.htmlView1.Name = "htmlView1";
            this.htmlView1.Size = new System.Drawing.Size(100, 30);
            // 
            // demoHTMLView
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.htmlView1});
            this.Load += new System.EventHandler(this.demoHTMLView_Load);
            this.Name = "demoHTMLView";

        }
        #endregion

        private Core.Controls.Title title1;
        private Smobiler.Plugins.HTMLView htmlView1;
    }
}