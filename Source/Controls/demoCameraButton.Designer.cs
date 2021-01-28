using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Controls
{
    partial class demoCameraButton : Smobiler.Core.Controls.MobileForm
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
            this.cameraButton1 = new Smobiler.Core.Controls.CameraButton();
            this.cameraButton2 = new Smobiler.Core.Controls.CameraButton();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.image1 = new Smobiler.Core.Controls.Image();
            this.spinner1 = new Smobiler.Core.Controls.Spinner();
            this.cameraButton3 = new Smobiler.Core.Controls.CameraButton();
            this.tabPageView1 = new Smobiler.Core.Controls.TabPageView();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "CameraButton";
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
            this.cameraButton1,
            this.cameraButton2,
            this.label1,
            this.image1,
            this.spinner1,
            this.cameraButton3,
            this.tabPageView1});
            this.panel2.Location = new System.Drawing.Point(5, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 910);
            // 
            // labContent
            // 
            this.labContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labContent.Location = new System.Drawing.Point(0, 26);
            this.labContent.Name = "labContent";
            this.labContent.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labContent.Size = new System.Drawing.Size(290, 119);
            this.labContent.Text = "Text设置按钮文本\r\nIconColor设置图像资源颜色\r\nImageDirection设置图片显示位置\r\nImageExBorderRadius设置图像资源圆" +
    "角\r\nImageType设置图像类型\r\nResourceID设置图像资源名称\r\nResourcePath设置图像存储路径";
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
            this.labTitle.Text = "不同样式的拍照控件";
            // 
            // cameraButton1
            // 
            this.cameraButton1.Location = new System.Drawing.Point(42, 165);
            this.cameraButton1.Name = "cameraButton1";
            this.cameraButton1.ResourceID = "Camera";
            this.cameraButton1.Size = new System.Drawing.Size(77, 44);
            this.cameraButton1.Text = "拍照";
            this.cameraButton1.ImageCaptured += new Smobiler.Core.Controls.CameraOnlineCallBackHandler(this.cameraButton1_ImageCaptured);
            // 
            // cameraButton2
            // 
            this.cameraButton2.IconColor = System.Drawing.Color.DeepSkyBlue;
            this.cameraButton2.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.cameraButton2.ImgTextRatio = new Smobiler.Core.Controls.Ratio(10, 0);
            this.cameraButton2.Location = new System.Drawing.Point(151, 165);
            this.cameraButton2.Name = "cameraButton2";
            this.cameraButton2.ResourceID = "camera-retro";
            this.cameraButton2.Size = new System.Drawing.Size(77, 44);
            this.cameraButton2.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Stretch;
            this.cameraButton2.ImageCaptured += new Smobiler.Core.Controls.CameraOnlineCallBackHandler(this.cameraButton1_ImageCaptured);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 381);
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label1.Size = new System.Drawing.Size(290, 37);
            this.label1.Text = "Mode属性设置相机图像获取方式\r\n";
            // 
            // image1
            // 
            this.image1.Location = new System.Drawing.Point(0, 250);
            this.image1.Name = "image1";
            this.image1.ResourceMode = Smobiler.Core.Controls.ResourceMode.Data;
            this.image1.Size = new System.Drawing.Size(290, 117);
            // 
            // spinner1
            // 
            this.spinner1.Items = new string[] {
        "Camera：直接打开",
        "CameraAndAlbum：打开一个选择列表，用于选择相机或相册",
        "AlbumSingle：直接打开相册，仅上传一张图片",
        "Album：直接打开相册，并上传多张图片",
        "CameraContinuous：相机连拍",
        "CameraVideo：相机拍摄视频",
        "AlbumVideo：相册上传视频"};
            this.spinner1.Location = new System.Drawing.Point(0, 418);
            this.spinner1.Name = "spinner1";
            this.spinner1.Size = new System.Drawing.Size(290, 30);
            this.spinner1.ItemSelected += new System.EventHandler<Smobiler.Core.Controls.SpinnerItemSelectedEventArgs>(this.spinner1_ItemSelected);
            // 
            // cameraButton3
            // 
            this.cameraButton3.Location = new System.Drawing.Point(94, 466);
            this.cameraButton3.Name = "cameraButton3";
            this.cameraButton3.ResourceID = "Camera";
            this.cameraButton3.Size = new System.Drawing.Size(77, 44);
            this.cameraButton3.Text = "拍照";
            this.cameraButton3.ImageCaptured += new Smobiler.Core.Controls.CameraOnlineCallBackHandler(this.cameraButton3_ImageCaptured);
            // 
            // tabPageView1
            // 
            this.tabPageView1.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.tabPageView1.Location = new System.Drawing.Point(0, 531);
            this.tabPageView1.Name = "tabPageView1";
            this.tabPageView1.Size = new System.Drawing.Size(290, 361);
            // 
            // demoCameraButton
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel1});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Size = new System.Drawing.Size(300, 1000);
            this.Name = "demoCameraButton";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Panel panel1;
        private Core.Controls.Panel panel2;
        private Core.Controls.Label labContent;
        private Core.Controls.Label labTitle;
        private Core.Controls.CameraButton cameraButton1;
        private Core.Controls.CameraButton cameraButton2;
        private Core.Controls.Label label1;
        private Core.Controls.Image image1;
        private Core.Controls.Spinner spinner1;
        private Core.Controls.CameraButton cameraButton3;
        private Core.Controls.TabPageView tabPageView1;
    }
}