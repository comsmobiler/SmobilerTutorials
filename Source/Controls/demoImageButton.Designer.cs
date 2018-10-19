using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Controls
{
    partial class demoImageButton : Smobiler.Core.Controls.MobileForm
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
            this.panel10 = new Smobiler.Core.Controls.Panel();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.labContent = new Smobiler.Core.Controls.Label();
            this.labTitle = new Smobiler.Core.Controls.Label();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.panel3 = new Smobiler.Core.Controls.Panel();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.panel4 = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.panel5 = new Smobiler.Core.Controls.Panel();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.imageButton1 = new Smobiler.Core.Controls.ImageButton();
            this.imageButton2 = new Smobiler.Core.Controls.ImageButton();
            this.imageButton3 = new Smobiler.Core.Controls.ImageButton();
            this.imageButton4 = new Smobiler.Core.Controls.ImageButton();
            this.imageButton6 = new Smobiler.Core.Controls.ImageButton();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "ImageButton";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // panel10
            // 
            this.panel10.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1,
            this.panel2,
            this.panel3,
            this.panel4,
            this.panel5});
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 30);
            this.panel10.Name = "panel10";
            this.panel10.Scrollable = true;
            this.panel10.Size = new System.Drawing.Size(300, 970);
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
            this.imageButton1,
            this.imageButton2});
            this.panel1.Location = new System.Drawing.Point(5, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 152);
            // 
            // labContent
            // 
            this.labContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labContent.Location = new System.Drawing.Point(0, 26);
            this.labContent.Name = "labContent";
            this.labContent.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labContent.Size = new System.Drawing.Size(290, 43);
            this.labContent.Text = "图片按钮控件";
            // 
            // labTitle
            // 
            this.labTitle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labTitle.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.labTitle.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.labTitle.FontSize = 16F;
            this.labTitle.Name = "labTitle";
            this.labTitle.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labTitle.Size = new System.Drawing.Size(290, 25);
            this.labTitle.Text = "ImageButton控件";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel2.BorderColor = System.Drawing.Color.Silver;
            this.panel2.BorderRadius = 5;
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label5,
            this.imageButton3});
            this.panel2.Location = new System.Drawing.Point(5, 175);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 114);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Name = "label5";
            this.label5.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label5.Size = new System.Drawing.Size(290, 50);
            this.label5.Text = "FontSize、ForeColor设置文本字体与颜色的不同样式\r\nIconColor、ImageType设置图标颜色、图像类型";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel3.BorderColor = System.Drawing.Color.Silver;
            this.panel3.BorderRadius = 5;
            this.panel3.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label6,
            this.imageButton4});
            this.panel3.Location = new System.Drawing.Point(5, 306);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(290, 119);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Name = "label6";
            this.label6.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label6.Size = new System.Drawing.Size(290, 50);
            this.label6.Text = "ResourceID、ResourcePath属性在ImageType设置为image时可设置本地或网络图片";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel4.BorderColor = System.Drawing.Color.Silver;
            this.panel4.BorderRadius = 5;
            this.panel4.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.imageButton6});
            this.panel4.Location = new System.Drawing.Point(5, 461);
            this.panel4.Name = "panel4";
            this.panel4.Scrollable = true;
            this.panel4.Size = new System.Drawing.Size(290, 119);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label1.Size = new System.Drawing.Size(290, 50);
            this.label1.Text = "ImageDirection、ImgTextRadio设置图片显示位置、图片文字比例\r\n";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel5.BorderColor = System.Drawing.Color.Silver;
            this.panel5.BorderRadius = 5;
            this.panel5.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label2});
            this.panel5.Location = new System.Drawing.Point(5, 587);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(290, 80);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Name = "label2";
            this.label2.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label2.Size = new System.Drawing.Size(290, 74);
            this.label2.Text = "Refresh方法图片刷新（更换图片，但id相同时，需要刷新）\r\nPress、LongPress事件在触摸操作激活时触发";
            // 
            // imageButton1
            // 
            this.imageButton1.Location = new System.Drawing.Point(0, 83);
            this.imageButton1.Name = "imageButton1";
            this.imageButton1.ResourceID = "logon";
            this.imageButton1.Size = new System.Drawing.Size(137, 51);
            this.imageButton1.Text = "图片按钮控件";
            this.imageButton1.Press += new System.EventHandler(this.imageButton1_Press);
            this.imageButton1.LongPress += new System.EventHandler(this.imageButton1_LongPress);
            // 
            // imageButton2
            // 
            this.imageButton2.ImageDirection = Smobiler.Core.Controls.Direction.Left;
            this.imageButton2.ImgTextRatio = new Smobiler.Core.Controls.Ratio(3, 7);
            this.imageButton2.Location = new System.Drawing.Point(149, 83);
            this.imageButton2.Name = "imageButton2";
            this.imageButton2.ResourceID = "logon";
            this.imageButton2.Size = new System.Drawing.Size(141, 51);
            this.imageButton2.Text = "图片按钮控件";
            this.imageButton2.Press += new System.EventHandler(this.imageButton1_Press);
            this.imageButton2.LongPress += new System.EventHandler(this.imageButton1_LongPress);
            // 
            // imageButton3
            // 
            this.imageButton3.FontSize = 11F;
            this.imageButton3.ForeColor = System.Drawing.Color.Maroon;
            this.imageButton3.IconColor = System.Drawing.Color.Maroon;
            this.imageButton3.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.imageButton3.Location = new System.Drawing.Point(76, 58);
            this.imageButton3.Name = "imageButton3";
            this.imageButton3.ResourceID = "plus-circle";
            this.imageButton3.Size = new System.Drawing.Size(137, 51);
            this.imageButton3.Text = "图片按钮控件";
            this.imageButton3.Press += new System.EventHandler(this.imageButton1_Press);
            this.imageButton3.LongPress += new System.EventHandler(this.imageButton1_LongPress);
            // 
            // imageButton4
            // 
            this.imageButton4.Location = new System.Drawing.Point(78, 61);
            this.imageButton4.Name = "imageButton4";
            this.imageButton4.ResourceID = "logon";
            this.imageButton4.Size = new System.Drawing.Size(137, 51);
            this.imageButton4.Text = "图片按钮控件";
            this.imageButton4.Press += new System.EventHandler(this.imageButton1_Press);
            this.imageButton4.LongPress += new System.EventHandler(this.imageButton1_LongPress);
            // 
            // imageButton6
            // 
            this.imageButton6.ImageDirection = Smobiler.Core.Controls.Direction.Right;
            this.imageButton6.ImgTextRatio = new Smobiler.Core.Controls.Ratio(2, 4);
            this.imageButton6.Location = new System.Drawing.Point(78, 58);
            this.imageButton6.Name = "imageButton6";
            this.imageButton6.ResourceID = "logon";
            this.imageButton6.Size = new System.Drawing.Size(141, 51);
            this.imageButton6.Text = "图片按钮控件";
            this.imageButton6.Press += new System.EventHandler(this.imageButton1_Press);
            this.imageButton6.LongPress += new System.EventHandler(this.imageButton1_LongPress);
            // 
            // demoImageButton
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel10});
            this.Size = new System.Drawing.Size(300, 1000);
            this.Name = "demoImageButton";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Panel panel10;
        private Core.Controls.Panel panel1;
        private Core.Controls.Label labContent;
        private Core.Controls.Label labTitle;
        private Core.Controls.Panel panel2;
        private Core.Controls.Label label5;
        private Core.Controls.Panel panel3;
        private Core.Controls.Label label6;
        private Core.Controls.Panel panel4;
        private Core.Controls.Label label1;
        private Core.Controls.Panel panel5;
        private Core.Controls.Label label2;
        private Core.Controls.ImageButton imageButton1;
        private Core.Controls.ImageButton imageButton2;
        private Core.Controls.ImageButton imageButton3;
        private Core.Controls.ImageButton imageButton4;
        private Core.Controls.ImageButton imageButton6;
    }
}