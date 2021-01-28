using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Controls
{
    partial class demoOfflineCameraButton : Smobiler.Core.Controls.MobileForm
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
            this.offlineCameraButton1 = new Smobiler.Core.Controls.OfflineCameraButton();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.button2 = new Smobiler.Core.Controls.Button();
            this.popList1 = new Smobiler.Core.Controls.PopList();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "OfflineCameraButton";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel2});
            this.panel1.Flex = 1;
            this.panel1.Name = "panel1";
            this.panel1.Scrollable = true;
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
            this.offlineCameraButton1,
            this.button1,
            this.button2});
            this.panel2.Location = new System.Drawing.Point(5, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 674);
            // 
            // labContent
            // 
            this.labContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labContent.FontSize = 15F;
            this.labContent.Location = new System.Drawing.Point(0, 26);
            this.labContent.Name = "labContent";
            this.labContent.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labContent.Size = new System.Drawing.Size(290, 106);
            this.labContent.Text = "调用摄像头或相册进行图片获取\r\nImageType设置按钮图像类型\r\nResourceID设置按钮图像资源名称\r\nResourcePath设置按钮图像存储路径\r\n" +
    "OfflineImageCaptured事件在客户端返货离线资源时触发\r\n\r\n";
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
            this.labTitle.Text = "离线拍照组件\r\n";
            this.labTitle.VerticalAlignment = Smobiler.Core.Controls.VerticalAlignment.Top;
            // 
            // offlineCameraButton1
            // 
            this.offlineCameraButton1.Location = new System.Drawing.Point(102, 217);
            this.offlineCameraButton1.Mode = Smobiler.Core.Controls.CameraMode.Camera;
            this.offlineCameraButton1.Name = "offlineCameraButton1";
            this.offlineCameraButton1.ResourceID = "CameraOffline";
            this.offlineCameraButton1.Size = new System.Drawing.Size(81, 67);
            this.offlineCameraButton1.OfflineImageCaptured += new Smobiler.Core.Controls.CameraOfflineCallBackHandler(this.offlineCameraButton1_OfflineImageCaptured);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(78)))));
            this.button1.Location = new System.Drawing.Point(36, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 30);
            this.button1.Text = "控件介绍";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button2.Location = new System.Drawing.Point(36, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 30);
            this.button2.Text = "查看离线资源";
            this.button2.Press += new System.EventHandler(this.button2_Press);
            // 
            // popList1
            // 
            this.popList1.Name = "popList1";
            this.popList1.Selected += new System.EventHandler(this.popList1_Selected);
            // 
            // demoOfflineCameraButton
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.popList1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel1});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Load += new System.EventHandler(this.demoOfflineCameraButton_Load);
            this.Name = "demoOfflineCameraButton";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Panel panel1;
        private Core.Controls.PopList popList1;
        private Core.Controls.Panel panel2;
        private Core.Controls.Label labContent;
        private Core.Controls.Label labTitle;
        private Core.Controls.OfflineCameraButton offlineCameraButton1;
        private Core.Controls.Button button1;
        private Core.Controls.Button button2;
    }
}