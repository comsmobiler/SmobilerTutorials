using Smobiler.Core;
using System;

namespace Smobiler.Tutorials.Samples.Layout
{
    partial class demoLabel : Smobiler.Core.Controls.MobileForm
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
            this.panel5 = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.textBox1 = new Smobiler.Core.Controls.TextBox();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.label4 = new Smobiler.Core.Controls.Label();
            // 
            // title1
            // 
            this.title1.Location = new System.Drawing.Point(53, 81);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(100, 30);
            this.title1.Text = "label自适应高度";
            // 
            // panel5
            // 
            this.panel5.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.textBox1,
            this.panel1,
            this.label3,
            this.label4});
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 30);
            this.panel5.Name = "panel5";
            this.panel5.Scrollable = true;
            this.panel5.Size = new System.Drawing.Size(300, 970);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 72);
            this.label1.Text = "在相对布局的容器中放size(0,0)的label， 就能根据内容自动撑大label。比如在相对布局的panel中放置label\r\n";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 141);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 35);
            this.textBox1.Text = "请输入文字，显示到下方label";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label2});
            this.panel1.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel1.Location = new System.Drawing.Point(0, 247);
            this.panel1.Name = "panel1";
            this.panel1.Scrollable = true;
            this.panel1.Size = new System.Drawing.Size(300, 100);
            // 
            // label2
            // 
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 0);
            this.label2.Text = "请输入文字，显示到下方label";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 35);
            this.label3.Text = "textbox输入";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 35);
            this.label4.Text = "label 显示";
            // 
            // demoLabel
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel5});
            this.Name = "demoLabel";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Panel panel5;
        private Core.Controls.Label label1;
        private Core.Controls.TextBox textBox1;
        private Core.Controls.Panel panel1;
        private Core.Controls.Label label2;
        private Core.Controls.Label label3;
        private Core.Controls.Label label4;
    }
}