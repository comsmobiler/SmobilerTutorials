using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Components
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
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.labContent = new Smobiler.Core.Controls.Label();
            this.labTitle = new Smobiler.Core.Controls.Label();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.label7 = new Smobiler.Core.Controls.Label();
            this.label8 = new Smobiler.Core.Controls.Label();
            this.label9 = new Smobiler.Core.Controls.Label();
            this.label10 = new Smobiler.Core.Controls.Label();
            this.label11 = new Smobiler.Core.Controls.Label();
            this.label12 = new Smobiler.Core.Controls.Label();
            this.panel3 = new Smobiler.Core.Controls.Panel();
            this.label13 = new Smobiler.Core.Controls.Label();
            this.label14 = new Smobiler.Core.Controls.Label();
            this.label15 = new Smobiler.Core.Controls.Label();
            this.panel4 = new Smobiler.Core.Controls.Panel();
            this.label16 = new Smobiler.Core.Controls.Label();
            this.label17 = new Smobiler.Core.Controls.Label();
            this.label18 = new Smobiler.Core.Controls.Label();
            this.label20 = new Smobiler.Core.Controls.Label();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "Label";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // panel5
            // 
            this.panel5.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1,
            this.panel2,
            this.panel3,
            this.panel4});
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 30);
            this.panel5.Name = "panel5";
            this.panel5.Scrollable = true;
            this.panel5.Size = new System.Drawing.Size(300, 970);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel1.BorderColor = System.Drawing.Color.Silver;
            this.panel1.BorderRadius = 5;
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.labContent,
            this.labTitle,
            this.label1,
            this.label2,
            this.label3,
            this.label4});
            this.panel1.Location = new System.Drawing.Point(5, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 179);
            // 
            // labContent
            // 
            this.labContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labContent.FontSize = 14F;
            this.labContent.Location = new System.Drawing.Point(0, 26);
            this.labContent.Name = "labContent";
            this.labContent.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labContent.Size = new System.Drawing.Size(290, 54);
            this.labContent.Text = "文本标签控件，最常用的控件，用于显示文本标签内容，可以显示如下不同的样式。可以调整字体，颜色等属性";
            // 
            // labTitle
            // 
            this.labTitle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labTitle.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.labTitle.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.labTitle.FontSize = 16F;
            this.labTitle.Name = "labTitle";
            this.labTitle.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labTitle.Size = new System.Drawing.Size(290, 26);
            this.labTitle.Text = "不同样式的文本标签";
            // 
            // label1
            // 
            this.label1.FontSize = 16F;
            this.label1.Location = new System.Drawing.Point(15, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 35);
            this.label1.Text = "字体大小";
            // 
            // label2
            // 
            this.label2.Bold = true;
            this.label2.Italic = true;
            this.label2.Location = new System.Drawing.Point(15, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 35);
            this.label2.Text = "粗体斜体";
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(133, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 35);
            this.label3.Text = "字体颜色";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(133, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 35);
            this.label4.Text = "文本下划线";
            this.label4.Underline = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel2.BorderColor = System.Drawing.Color.Silver;
            this.panel2.BorderRadius = 5;
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label5,
            this.label6,
            this.label7,
            this.label8,
            this.label9,
            this.label10,
            this.label11,
            this.label12});
            this.panel2.Location = new System.Drawing.Point(5, 203);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 219);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.FontSize = 15F;
            this.label5.Location = new System.Drawing.Point(0, 26);
            this.label5.Name = "label5";
            this.label5.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label5.Size = new System.Drawing.Size(290, 54);
            this.label5.Text = "HorizontalAlignment、VerticalAlignment属性设置文字水平、垂直显示位置";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label6.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.label6.FontSize = 16F;
            this.label6.Name = "label6";
            this.label6.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label6.Size = new System.Drawing.Size(290, 26);
            this.label6.Text = "文本标签水平垂直位置";
            // 
            // label7
            // 
            this.label7.Border = new Smobiler.Core.Controls.Border(1F);
            this.label7.BorderColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(15, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 35);
            this.label7.Text = "水平居左";
            // 
            // label8
            // 
            this.label8.Border = new Smobiler.Core.Controls.Border(1F);
            this.label8.BorderColor = System.Drawing.Color.Gainsboro;
            this.label8.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label8.Location = new System.Drawing.Point(17, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 35);
            this.label8.Text = "水平居中";
            // 
            // label9
            // 
            this.label9.Border = new Smobiler.Core.Controls.Border(1F);
            this.label9.BorderColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(145, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 35);
            this.label9.Text = "垂直居上";
            this.label9.VerticalAlignment = Smobiler.Core.Controls.VerticalAlignment.Top;
            // 
            // label10
            // 
            this.label10.Border = new Smobiler.Core.Controls.Border(1F);
            this.label10.BorderColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(145, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 35);
            this.label10.Text = "垂直居中";
            // 
            // label11
            // 
            this.label11.Border = new Smobiler.Core.Controls.Border(1F);
            this.label11.BorderColor = System.Drawing.Color.Gainsboro;
            this.label11.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.label11.Location = new System.Drawing.Point(17, 181);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 35);
            this.label11.Text = "水平居右";
            // 
            // label12
            // 
            this.label12.Border = new Smobiler.Core.Controls.Border(1F);
            this.label12.BorderColor = System.Drawing.Color.Gainsboro;
            this.label12.Location = new System.Drawing.Point(145, 181);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 35);
            this.label12.Text = "垂直居下";
            this.label12.VerticalAlignment = Smobiler.Core.Controls.VerticalAlignment.Bottom;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel3.BorderColor = System.Drawing.Color.Silver;
            this.panel3.BorderRadius = 5;
            this.panel3.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label13,
            this.label14,
            this.label15});
            this.panel3.Location = new System.Drawing.Point(5, 437);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(290, 139);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label13.FontSize = 15F;
            this.label13.Location = new System.Drawing.Point(0, 26);
            this.label13.Name = "label13";
            this.label13.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label13.Size = new System.Drawing.Size(290, 54);
            this.label13.Text = "Selectable属性设置是否长按选择文本\r\n";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label14.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label14.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.label14.FontSize = 16F;
            this.label14.Name = "label14";
            this.label14.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label14.Size = new System.Drawing.Size(290, 26);
            this.label14.Text = "长按选择文本";
            // 
            // label15
            // 
            this.label15.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label15.Location = new System.Drawing.Point(15, 89);
            this.label15.Name = "label15";
            this.label15.Selectable = true;
            this.label15.Size = new System.Drawing.Size(258, 35);
            this.label15.Text = "可长按选择";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel4.BorderColor = System.Drawing.Color.Silver;
            this.panel4.BorderRadius = 5;
            this.panel4.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label16,
            this.label17,
            this.label18,
            this.label20});
            this.panel4.Location = new System.Drawing.Point(5, 591);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(290, 219);
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label16.FontSize = 15F;
            this.label16.Location = new System.Drawing.Point(0, 26);
            this.label16.Name = "label16";
            this.label16.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label16.Size = new System.Drawing.Size(290, 54);
            this.label16.Text = "NumberOfLines属性可设置显示行数";
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label17.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label17.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.label17.FontSize = 16F;
            this.label17.Name = "label17";
            this.label17.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label17.Size = new System.Drawing.Size(290, 26);
            this.label17.Text = "文本标签显示行数";
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(15, 89);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(108, 123);
            this.label18.Text = "设置为0，可显示多行；或可设置具体行数";
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(145, 89);
            this.label20.Name = "label20";
            this.label20.NumberOfLines = 1;
            this.label20.Size = new System.Drawing.Size(124, 123);
            this.label20.Text = "设置为1，只显示为一行，多余字省略";
            // 
            // demoLabel
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel5});
            this.Size = new System.Drawing.Size(300, 1000);
            this.Name = "demoLabel";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Panel panel5;
        private Core.Controls.Panel panel1;
        private Core.Controls.Label labContent;
        private Core.Controls.Label labTitle;
        private Core.Controls.Label label1;
        private Core.Controls.Label label2;
        private Core.Controls.Label label3;
        private Core.Controls.Label label4;
        private Core.Controls.Panel panel2;
        private Core.Controls.Label label5;
        private Core.Controls.Label label6;
        private Core.Controls.Label label7;
        private Core.Controls.Label label8;
        private Core.Controls.Label label9;
        private Core.Controls.Label label10;
        private Core.Controls.Label label11;
        private Core.Controls.Label label12;
        private Core.Controls.Panel panel3;
        private Core.Controls.Label label13;
        private Core.Controls.Label label14;
        private Core.Controls.Label label15;
        private Core.Controls.Panel panel4;
        private Core.Controls.Label label16;
        private Core.Controls.Label label17;
        private Core.Controls.Label label18;
        private Core.Controls.Label label20;
    }
}