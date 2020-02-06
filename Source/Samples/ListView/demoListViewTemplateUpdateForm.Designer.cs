using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Samples.ListView
{
    partial class demoListViewTemplateUpdateForm : Smobiler.Core.Controls.MobileForm
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
            this.textBox1 = new Smobiler.Core.Controls.TextBox();
            this.textBox2 = new Smobiler.Core.Controls.TextBox();
            this.button1 = new Smobiler.Core.Controls.Button();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "arrow-left";
            this.title1.Size = new System.Drawing.Size(0, 30);
            this.title1.Text = "demoListViewTemplateUpdateForm";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 141);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 35);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(97, 210);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 35);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.Text = "保存";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // demoListViewTemplateUpdateForm
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.textBox1,
            this.textBox2,
            this.button1});
            this.Name = "demoListViewTemplateUpdateForm";

        }
        #endregion

        private Smobiler.Core.Controls.Title title1;
        private Smobiler.Core.Controls.Button button1;
        public Smobiler.Core.Controls.TextBox textBox1;
        public Smobiler.Core.Controls.TextBox textBox2;
    }
}