using Smobiler.Core;
using System;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoViewShot : Smobiler.Core.Controls.MobileForm
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
            this.labContent = new Smobiler.Core.Controls.Label();
            this.labTitle = new Smobiler.Core.Controls.Label();
            this.viewShot1 = new Smobiler.Plugins.ViewShot();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.signatureView1 = new Smobiler.Plugins.SignatureView();
            this.btnRectangle = new Smobiler.Core.Controls.Button();
            this.image1 = new Smobiler.Core.Controls.Image();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "ViewShot";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
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
            this.viewShot1,
            this.btnRectangle,
            this.image1});
            this.panel1.Flex = 1;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Margin = new Smobiler.Core.Controls.Margin(0F, 0F, 0F, 5F);
            this.panel1.Name = "panel1";
            this.panel1.Scrollable = true;
            this.panel1.Size = new System.Drawing.Size(290, 321);
            // 
            // labContent
            // 
            this.labContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labContent.Location = new System.Drawing.Point(0, 39);
            this.labContent.Name = "labContent";
            this.labContent.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labContent.Size = new System.Drawing.Size(290, 61);
            this.labContent.Text = "ViewShot 插件内可以放置其他控件，并截图该插件内的界面\r\n";
            // 
            // labTitle
            // 
            this.labTitle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labTitle.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.labTitle.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.labTitle.FontSize = 16F;
            this.labTitle.Location = new System.Drawing.Point(0, 1);
            this.labTitle.Name = "labTitle";
            this.labTitle.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labTitle.Size = new System.Drawing.Size(290, 36);
            this.labTitle.Text = "图片截取插件";
            // 
            // viewShot1
            // 
            this.viewShot1.BackColor = System.Drawing.Color.Snow;
            this.viewShot1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.button1,
            this.label1,
            this.signatureView1});
            this.viewShot1.Location = new System.Drawing.Point(16, 114);
            this.viewShot1.Name = "viewShot1";
            this.viewShot1.PictureFormat = Smobiler.Plugins.PictureFormat.png;
            this.viewShot1.Size = new System.Drawing.Size(262, 287);
            this.viewShot1.OnViewShotImageSave += new Smobiler.Core.Controls.BinaryResultCallBackHandler(this.viewShot1_OnViewShotImageSave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.Text = "button1";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(49, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 35);
            this.label1.Text = "可在下方的签字版中书写";
            // 
            // signatureView1
            // 
            this.signatureView1.BackColor = System.Drawing.Color.White;
            this.signatureView1.Location = new System.Drawing.Point(18, 107);
            this.signatureView1.Name = "signatureView1";
            this.signatureView1.Size = new System.Drawing.Size(229, 174);
            // 
            // btnRectangle
            // 
            this.btnRectangle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(176)))), ((int)(((byte)(250)))));
            this.btnRectangle.BorderColor = System.Drawing.Color.White;
            this.btnRectangle.BorderRadius = 0;
            this.btnRectangle.BorderStyle = Smobiler.Core.Controls.BorderStyle.Dashed;
            this.btnRectangle.FontSize = 15F;
            this.btnRectangle.Location = new System.Drawing.Point(41, 413);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(224, 30);
            this.btnRectangle.Text = "截图";
            this.btnRectangle.Press += new System.EventHandler(this.btnRectangle_Press);
            // 
            // image1
            // 
            this.image1.Location = new System.Drawing.Point(16, 454);
            this.image1.Name = "image1";
            this.image1.ResourcePath = "upload";
            this.image1.Size = new System.Drawing.Size(262, 287);
            // 
            // demoViewShot
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel1});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Name = "demoViewShot";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Panel panel1;
        private Core.Controls.Label labContent;
        private Core.Controls.Label labTitle;
        private Smobiler.Plugins.ViewShot viewShot1;
        private Core.Controls.Button button1;
        private Core.Controls.Label label1;
        private Smobiler.Plugins.SignatureView signatureView1;
        public Core.Controls.Button btnRectangle;
        private Core.Controls.Image image1;
    }
}