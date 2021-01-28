using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Components
{
    partial class demoPhoneButton : Smobiler.Core.Controls.MobileForm
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
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.labContent = new Smobiler.Core.Controls.Label();
            this.labTitle = new Smobiler.Core.Controls.Label();
            this.phoneButton1 = new Smobiler.Core.Controls.PhoneButton();
            this.phoneButton2 = new Smobiler.Core.Controls.PhoneButton();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "PhoneButton";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel2});
            this.panel1.Flex = 1;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 100);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel2.BorderColor = System.Drawing.Color.Silver;
            this.panel2.BorderRadius = 5;
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.labContent,
            this.labTitle,
            this.phoneButton1,
            this.phoneButton2});
            this.panel2.Location = new System.Drawing.Point(5, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 231);
            // 
            // labContent
            // 
            this.labContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labContent.FontSize = 15F;
            this.labContent.Location = new System.Drawing.Point(0, 26);
            this.labContent.Name = "labContent";
            this.labContent.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labContent.Size = new System.Drawing.Size(290, 123);
            this.labContent.Text = "可以打电话和进行相关操作\r\nImageType图像类型\r\nResourceID图像资源名称\r\nResourcePath图像存储路径\r\nImageDirection" +
    "图片显示位置\r\nText设置文本\r\nPress事件点击控件时触发";
            this.labContent.VerticalAlignment = Smobiler.Core.Controls.VerticalAlignment.Top;
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
            this.labTitle.Text = "不同样式的PhoneButton";
            // 
            // phoneButton1
            // 
            this.phoneButton1.Location = new System.Drawing.Point(46, 159);
            this.phoneButton1.Name = "phoneButton1";
            this.phoneButton1.ResourceID = "Phone";
            this.phoneButton1.Size = new System.Drawing.Size(70, 55);
            this.phoneButton1.TextMember = "400-0588560";
            this.phoneButton1.Press += new System.EventHandler(this.phoneButton1_Press);
            // 
            // phoneButton2
            // 
            this.phoneButton2.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.phoneButton2.Location = new System.Drawing.Point(158, 159);
            this.phoneButton2.Name = "phoneButton2";
            this.phoneButton2.ResourceID = "phone-square";
            this.phoneButton2.Size = new System.Drawing.Size(70, 55);
            this.phoneButton2.Text = "电话";
            this.phoneButton2.TextMember = "400-0588560";
            this.phoneButton2.Press += new System.EventHandler(this.phoneButton1_Press);
            // 
            // demoPhoneButton
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel1});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Name = "demoPhoneButton";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Panel panel1;
        private Core.Controls.Panel panel2;
        private Core.Controls.Label labContent;
        private Core.Controls.Label labTitle;
        private Core.Controls.PhoneButton phoneButton1;
        private Core.Controls.PhoneButton phoneButton2;
    }
}