using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.usercontrol
{
    partial class demoTabPageViewTemplate : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

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
            this.button1 = new Smobiler.Core.Controls.Button();
            this.textBox1 = new Smobiler.Core.Controls.TextBox();
            this.label1 = new Smobiler.Core.Controls.Label();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 30);
            this.button1.Text = "按钮";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 126);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 45);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 91);
            this.label1.Text = "TabPageView可在设计器中可视化设计页面，也可设计自定义控件后将其添加到TabPageView\r\n";
            // 
            // demoTabPageViewTemplate
            // 
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.textBox1,
            this.button1});
            this.Size = new System.Drawing.Size(300, 300);
            this.Name = "demoTabPageViewTemplate";

        }
        #endregion

        private Core.Controls.Button button1;
        private Core.Controls.TextBox textBox1;
        private Core.Controls.Label label1;
    }
}