using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Plugins
{
    partial class demoPDFView : Smobiler.Core.Controls.MobileForm
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
            this.pdfView1 = new Smobiler.Plugins.PDFView();
            this.label1 = new Smobiler.Core.Controls.Label();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "PDFView";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.pdfView1,
            this.label1});
            this.panel1.Flex = 1;
            this.panel1.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel1.Name = "panel1";
            this.panel1.Scrollable = true;
            this.panel1.Size = new System.Drawing.Size(0, 100);
            // 
            // pdfView1
            // 
            this.pdfView1.Flex = 1;
            this.pdfView1.Name = "pdfView1";
            this.pdfView1.ResourceID = "smobiler.pdf";
            this.pdfView1.Size = new System.Drawing.Size(0, 300);
            // 
            // label1
            // 
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 83);
            this.label1.Text = "ReSourceID设置文件名称，ResourcePath设置文件路径（ResourcePath设置Document表示读取项目路径下\\Debug\\Resourc" +
    "es\\Document下文件 ）";
            // 
            // demoPDFView
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel1});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Name = "demoPDFView";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Panel panel1;
        private Smobiler.Plugins.PDFView pdfView1;
        private Core.Controls.Label label1;
    }
}