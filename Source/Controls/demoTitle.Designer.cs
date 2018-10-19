using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Controls
{
    partial class demoTitle : Smobiler.Core.Controls.MobileForm
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
            this.panel10 = new Smobiler.Core.Controls.Panel();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.labContent = new Smobiler.Core.Controls.Label();
            this.labTitle = new Smobiler.Core.Controls.Label();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.label7 = new Smobiler.Core.Controls.Label();
            this.title1 = new Smobiler.Core.Controls.Title();
            this.title2 = new Smobiler.Core.Controls.Title();
            this.title3 = new Smobiler.Core.Controls.Title();
            this.title4 = new Smobiler.Core.Controls.Title();
            this.title5 = new Smobiler.Core.Controls.Title();
            this.title6 = new Smobiler.Core.Controls.Title();
            this.title7 = new Smobiler.Core.Controls.Title();
            this.title8 = new Smobiler.Core.Controls.Title();
            // 
            // panel10
            // 
            this.panel10.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
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
            this.title2,
            this.title3,
            this.title4,
            this.title5,
            this.label1,
            this.label2,
            this.label3,
            this.label4,
            this.title6,
            this.label5,
            this.title7,
            this.label6,
            this.title8,
            this.label7});
            this.panel1.Location = new System.Drawing.Point(5, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 627);
            // 
            // labContent
            // 
            this.labContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labContent.Location = new System.Drawing.Point(0, 26);
            this.labContent.Name = "labContent";
            this.labContent.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labContent.Size = new System.Drawing.Size(290, 54);
            this.labContent.Text = "标题栏控件,不同样式的标题栏控件";
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
            this.labTitle.Text = "Title控件";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 35);
            this.label1.Text = "Text属性可设置标题栏控件标题";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(5, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 35);
            this.label2.Text = "ResourceID与ImageType属性可设置标题栏控件图标";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(5, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 35);
            this.label3.Text = "ResourceID、ImageType、ResourcePath属性可设置标题栏控件图片与图片路径";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 35);
            this.label4.Text = "FontSize、TextColor、IconColor属性可设置标题栏控件标题文本字体大小、文本与图标颜色";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(290, 35);
            this.label5.Text = "TextAlign属性可设置标题栏控件标题文本对齐方式";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 456);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(290, 35);
            this.label6.Text = "ImageWidth属性可设置图片宽度";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(0, 546);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(290, 35);
            this.label7.Text = "ImagePress在触摸操作激活时触发";
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "Title";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // title2
            // 
            this.title2.Dock = System.Windows.Forms.DockStyle.None;
            this.title2.Location = new System.Drawing.Point(0, 121);
            this.title2.Name = "title2";
            this.title2.Size = new System.Drawing.Size(290, 30);
            this.title2.Text = "可设置标题";
            // 
            // title3
            // 
            this.title3.Dock = System.Windows.Forms.DockStyle.None;
            this.title3.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title3.Location = new System.Drawing.Point(0, 193);
            this.title3.Name = "title3";
            this.title3.ResourceID = "angle-double-left";
            this.title3.Size = new System.Drawing.Size(290, 30);
            this.title3.Text = "可设置图标";
            // 
            // title4
            // 
            this.title4.Dock = System.Windows.Forms.DockStyle.None;
            this.title4.Location = new System.Drawing.Point(0, 267);
            this.title4.Name = "title4";
            this.title4.ResourceID = "logon";
            this.title4.Size = new System.Drawing.Size(290, 30);
            this.title4.Text = "可设置图片";
            // 
            // title5
            // 
            this.title5.Dock = System.Windows.Forms.DockStyle.None;
            this.title5.FontSize = 18F;
            this.title5.IconColor = System.Drawing.Color.Red;
            this.title5.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title5.Location = new System.Drawing.Point(0, 341);
            this.title5.Name = "title5";
            this.title5.ResourceID = "angle-double-left";
            this.title5.Size = new System.Drawing.Size(290, 30);
            this.title5.Text = "可更改字体与图标颜色";
            this.title5.TextColor = System.Drawing.Color.Red;
            // 
            // title6
            // 
            this.title6.Dock = System.Windows.Forms.DockStyle.None;
            this.title6.IconColor = System.Drawing.Color.Red;
            this.title6.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title6.Location = new System.Drawing.Point(0, 415);
            this.title6.Name = "title6";
            this.title6.ResourceID = "angle-double-left";
            this.title6.Size = new System.Drawing.Size(290, 30);
            this.title6.Text = "            可更改文本对齐方式";
            this.title6.TextAlign = Smobiler.Core.Controls.HorizontalAlignment.Left;
            this.title6.TextColor = System.Drawing.Color.Red;
            // 
            // title7
            // 
            this.title7.Dock = System.Windows.Forms.DockStyle.None;
            this.title7.IconColor = System.Drawing.Color.Red;
            this.title7.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title7.ImageWidth = 45;
            this.title7.Location = new System.Drawing.Point(0, 491);
            this.title7.Name = "title7";
            this.title7.ResourceID = "angle-double-left";
            this.title7.Size = new System.Drawing.Size(290, 45);
            this.title7.Text = "可设置图片宽度";
            this.title7.TextColor = System.Drawing.Color.Red;
            this.title7.ImagePress += new System.EventHandler(this.title7_ImagePress);
            // 
            // title8
            // 
            this.title8.Dock = System.Windows.Forms.DockStyle.None;
            this.title8.IconColor = System.Drawing.Color.Red;
            this.title8.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title8.Location = new System.Drawing.Point(0, 581);
            this.title8.Name = "title8";
            this.title8.ResourceID = "angle-double-left";
            this.title8.Size = new System.Drawing.Size(290, 30);
            this.title8.Text = "可自定义点击事件";
            this.title8.TextAlign = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.title8.TextColor = System.Drawing.Color.Red;
            this.title8.ImagePress += new System.EventHandler(this.title7_ImagePress);
            // 
            // demoTitle
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel10});
            this.Size = new System.Drawing.Size(300, 1000);
            this.Name = "demoTitle";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Panel panel10;
        private Core.Controls.Panel panel1;
        private Core.Controls.Label labContent;
        private Core.Controls.Label labTitle;
        private Core.Controls.Title title2;
        private Core.Controls.Title title3;
        private Core.Controls.Title title4;
        private Core.Controls.Title title5;
        private Core.Controls.Label label1;
        private Core.Controls.Label label2;
        private Core.Controls.Label label3;
        private Core.Controls.Label label4;
        private Core.Controls.Title title6;
        private Core.Controls.Label label5;
        private Core.Controls.Title title7;
        private Core.Controls.Label label6;
        private Core.Controls.Title title8;
        private Core.Controls.Label label7;
    }
}