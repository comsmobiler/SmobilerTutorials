using Smobiler.Core;
using System;

namespace Smobiler.Tutorials.Samples.AnimationDialog
{
    partial class animationDialog : Smobiler.Core.Controls.MobileUserControl
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
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.textBox1 = new Smobiler.Core.Controls.TextBox();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.button2 = new Smobiler.Core.Controls.Button();
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.panel2.Flex = 1;
            this.panel2.JustifyAlign = Smobiler.Core.Controls.LayoutJustifyAlign.Center;
            this.panel2.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 100);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.textBox1,
            this.button1,
            this.button2});
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 149);
            // 
            // label1
            // 
            this.label1.FontSize = 16F;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 35);
            this.label1.Text = "修改密码前请填写原始密码";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 43);
            this.textBox1.WaterMarkText = "（必输）";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.button1.BorderRadius = 0;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(0, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 35);
            this.button1.Text = "取消";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Border = new Smobiler.Core.Controls.Border(1F, 1F, 0F, 0F);
            this.button2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.button2.BorderRadius = 0;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(150, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 35);
            this.button2.Text = "关闭";
            this.button2.Press += new System.EventHandler(this.button2_Press);
            // 
            // animationDialog
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel2});
            this.Flex = 1;
            this.JustifyAlign = Smobiler.Core.Controls.LayoutJustifyAlign.Center;
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Size = new System.Drawing.Size(300, 0);
            this.Name = "animationDialog";

        }
        #endregion

        private Core.Controls.Panel panel2;
        private Core.Controls.Panel panel1;
        private Core.Controls.Label label1;
        private Core.Controls.TextBox textBox1;
        private Core.Controls.Button button1;
        private Core.Controls.Button button2;
    }
}