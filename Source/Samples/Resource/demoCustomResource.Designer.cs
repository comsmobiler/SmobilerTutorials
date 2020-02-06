using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Samples
{
    partial class demoCustomResource : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public demoCustomResource()
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
            this.title1 = new Smobiler.Core.Controls.Title();
            this.image1 = new Smobiler.Core.Controls.Image();
            this.btnUpdateImage = new Smobiler.Core.Controls.Button();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "chevron-left";
            this.title1.Size = new System.Drawing.Size(0, 30);
            this.title1.Text = "demoCustomResource";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // image1
            // 
            this.image1.Name = "image1";
            this.image1.Size = new System.Drawing.Size(0, 256);
            // 
            // btnUpdateImage
            // 
            this.btnUpdateImage.Name = "btnUpdateImage";
            this.btnUpdateImage.Size = new System.Drawing.Size(0, 30);
            this.btnUpdateImage.Text = "¸üÐÂÍ¼Ïñ";
            this.btnUpdateImage.Press += new System.EventHandler(this.btnUpdateImage_Press);
            // 
            // demoCustomResource
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.image1,
            this.btnUpdateImage});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Load += new System.EventHandler(this.demoCustomResource_Load);
            this.Name = "demoCustomResource";

        }
        #endregion

        private Smobiler.Core.Controls.Title title1;
        private Smobiler.Core.Controls.Image image1;
        private Smobiler.Core.Controls.Button btnUpdateImage;
    }
}