using Smobiler.Core;
using System;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoScreenShied : Smobiler.Core.Controls.MobileForm
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
            this.screenShield1 = new Smobiler.Plugins.ScreenShield();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.datePicker1 = new Smobiler.Core.Controls.DatePicker();
            this.textBox1 = new Smobiler.Core.Controls.TextBox();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "ScreenShield";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // screenShield1
            // 
            this.screenShield1.BackColor = System.Drawing.Color.White;
            this.screenShield1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.button1,
            this.label1,
            this.datePicker1,
            this.textBox1});
            this.screenShield1.Location = new System.Drawing.Point(27, 75);
            this.screenShield1.Name = "screenShield1";
            this.screenShield1.Size = new System.Drawing.Size(239, 239);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.Text = "button1";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(38, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 35);
            this.label1.Text = "请截图试试(仅支持iOS)";
            // 
            // datePicker1
            // 
            this.datePicker1.Location = new System.Drawing.Point(63, 132);
            this.datePicker1.Name = "datePicker1";
            this.datePicker1.Size = new System.Drawing.Size(100, 30);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 174);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 35);
            this.textBox1.Text = "请输入";
            // 
            // demoScreenShied
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.screenShield1});
            this.Name = "demoScreenShied";

        }
        #endregion

        private Core.Controls.Title title1;
        private Smobiler.Plugins.ScreenShield screenShield1;
        private Core.Controls.Button button1;
        private Core.Controls.Label label1;
        private Core.Controls.DatePicker datePicker1;
        private Core.Controls.TextBox textBox1;
    }
}