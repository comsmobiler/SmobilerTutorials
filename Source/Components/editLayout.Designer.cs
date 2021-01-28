using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Components
{
    partial class editLayout : Smobiler.Core.Controls.MobileUserControl
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
            this.title1 = new Smobiler.Core.Controls.Title();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.image1 = new Smobiler.Core.Controls.Image();
            this.textBox1 = new Smobiler.Core.Controls.TextBox();
            this.textBox2 = new Smobiler.Core.Controls.TextBox();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.button2 = new Smobiler.Core.Controls.Button();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            // 
            // title1
            // 
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(0, 30);
            this.title1.Text = "编辑";
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image1,
            this.textBox1,
            this.textBox2,
            this.button1,
            this.button2,
            this.label1,
            this.label2});
            this.panel1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.panel1.Flex = 1;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 100);
            this.panel1.Touchable = true;
            // 
            // image1
            // 
            this.image1.Location = new System.Drawing.Point(27, 55);
            this.image1.Name = "image1";
            this.image1.Size = new System.Drawing.Size(81, 79);
            // 
            // textBox1
            // 
            this.textBox1.Border = new Smobiler.Core.Controls.Border(1F);
            this.textBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(176)))), ((int)(((byte)(249)))));
            this.textBox1.Location = new System.Drawing.Point(142, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 35);
            // 
            // textBox2
            // 
            this.textBox2.Border = new Smobiler.Core.Controls.Border(1F);
            this.textBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(176)))), ((int)(((byte)(249)))));
            this.textBox2.Location = new System.Drawing.Point(142, 134);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 35);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(67)))), ((int)(((byte)(81)))));
            this.button1.Location = new System.Drawing.Point(27, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.Text = "取消";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(176)))), ((int)(((byte)(249)))));
            this.button2.Location = new System.Drawing.Point(174, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.Text = "保存";
            this.button2.Press += new System.EventHandler(this.button2_Press);
            // 
            // label1
            // 
            this.label1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label1.Location = new System.Drawing.Point(142, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 35);
            this.label1.Text = "id：";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(190, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 35);
            this.label2.Text = "label2";
            // 
            // editLayout
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel1});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Size = new System.Drawing.Size(0, 300);
            this.Name = "editLayout";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Panel panel1;
        private Core.Controls.Image image1;
        private Core.Controls.TextBox textBox1;
        private Core.Controls.TextBox textBox2;
        private Core.Controls.Button button1;
        private Core.Controls.Button button2;
        private Core.Controls.Label label1;
        private Core.Controls.Label label2;
    }
}