using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Components
{
    partial class demoCamera : Smobiler.Core.Controls.MobileForm
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
            this.label1 = new Smobiler.Core.Controls.Label();
            this.btnAlbumCount3 = new Smobiler.Core.Controls.Button();
            this.btnAlbumCount9 = new Smobiler.Core.Controls.Button();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.labAlbumCount = new Smobiler.Core.Controls.Label();
            this.btnAllowEditT = new Smobiler.Core.Controls.Button();
            this.btnAllowEditF = new Smobiler.Core.Controls.Button();
            this.labAllowEdit = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.btnCompressedQuality1 = new Smobiler.Core.Controls.Button();
            this.btnCompressedQuality2 = new Smobiler.Core.Controls.Button();
            this.labCompressedQuality = new Smobiler.Core.Controls.Label();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.btnCompressedResolution1 = new Smobiler.Core.Controls.Button();
            this.btnCompressedResolution2 = new Smobiler.Core.Controls.Button();
            this.labCompressedResolution = new Smobiler.Core.Controls.Label();
            this.label7 = new Smobiler.Core.Controls.Label();
            this.btnContinuousNumber1 = new Smobiler.Core.Controls.Button();
            this.btnContinuousNumber2 = new Smobiler.Core.Controls.Button();
            this.labContinuousNumber = new Smobiler.Core.Controls.Label();
            this.label8 = new Smobiler.Core.Controls.Label();
            this.btnQualityMode1 = new Smobiler.Core.Controls.Button();
            this.btnQualityMode2 = new Smobiler.Core.Controls.Button();
            this.labQualityMode = new Smobiler.Core.Controls.Label();
            this.label9 = new Smobiler.Core.Controls.Label();
            this.btnTimeOut1 = new Smobiler.Core.Controls.Button();
            this.btnTimeOut2 = new Smobiler.Core.Controls.Button();
            this.labTimeOut = new Smobiler.Core.Controls.Label();
            this.label10 = new Smobiler.Core.Controls.Label();
            this.btnVideoCompressedQuality1 = new Smobiler.Core.Controls.Button();
            this.btnVideoCompressedQuality2 = new Smobiler.Core.Controls.Button();
            this.labVideoCompressedQuality = new Smobiler.Core.Controls.Label();
            this.label11 = new Smobiler.Core.Controls.Label();
            this.btnVideoDuration1 = new Smobiler.Core.Controls.Button();
            this.btnVideoDuration2 = new Smobiler.Core.Controls.Button();
            this.labVideoDuration = new Smobiler.Core.Controls.Label();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.btnGetPhoto = new Smobiler.Core.Controls.Button();
            this.spinner1 = new Smobiler.Core.Controls.Spinner();
            this.btnGetPhotoOffline = new Smobiler.Core.Controls.Button();
            this.btnGetClientPhotoPath = new Smobiler.Core.Controls.Button();
            this.panel3 = new Smobiler.Core.Controls.Panel();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.label12 = new Smobiler.Core.Controls.Label();
            this.tabPageView1 = new Smobiler.Core.Controls.TabPageView();
            this.camera1 = new Smobiler.Core.Controls.Camera();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "Camera";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // panel10
            // 
            this.panel10.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1,
            this.panel2,
            this.panel3,
            this.tabPageView1});
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
            this.label1,
            this.btnAlbumCount3,
            this.btnAlbumCount9,
            this.label2,
            this.labAlbumCount,
            this.btnAllowEditT,
            this.btnAllowEditF,
            this.labAllowEdit,
            this.label3,
            this.btnCompressedQuality1,
            this.btnCompressedQuality2,
            this.labCompressedQuality,
            this.label4,
            this.btnCompressedResolution1,
            this.btnCompressedResolution2,
            this.labCompressedResolution,
            this.label7,
            this.btnContinuousNumber1,
            this.btnContinuousNumber2,
            this.labContinuousNumber,
            this.label8,
            this.btnQualityMode1,
            this.btnQualityMode2,
            this.labQualityMode,
            this.label9,
            this.btnTimeOut1,
            this.btnTimeOut2,
            this.labTimeOut,
            this.label10,
            this.btnVideoCompressedQuality1,
            this.btnVideoCompressedQuality2,
            this.labVideoCompressedQuality,
            this.label11,
            this.btnVideoDuration1,
            this.btnVideoDuration2,
            this.labVideoDuration});
            this.panel1.Location = new System.Drawing.Point(5, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 727);
            // 
            // labContent
            // 
            this.labContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labContent.Location = new System.Drawing.Point(0, 26);
            this.labContent.Name = "labContent";
            this.labContent.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labContent.Size = new System.Drawing.Size(290, 40);
            this.labContent.Text = "相机组件";
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
            this.labTitle.Text = "Camera组件";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 35);
            this.label1.Text = "AlbumCount:获取和设置在CameraMode为Alubum时，上传的数量";
            // 
            // btnAlbumCount3
            // 
            this.btnAlbumCount3.Location = new System.Drawing.Point(90, 114);
            this.btnAlbumCount3.Name = "btnAlbumCount3";
            this.btnAlbumCount3.Size = new System.Drawing.Size(100, 30);
            this.btnAlbumCount3.Text = "3";
            this.btnAlbumCount3.Press += new System.EventHandler(this.btnAlbumCount3_Press);
            // 
            // btnAlbumCount9
            // 
            this.btnAlbumCount9.Location = new System.Drawing.Point(190, 114);
            this.btnAlbumCount9.Name = "btnAlbumCount9";
            this.btnAlbumCount9.Size = new System.Drawing.Size(100, 30);
            this.btnAlbumCount9.Text = "9";
            this.btnAlbumCount9.Press += new System.EventHandler(this.btnAlbumCount9_Press);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 35);
            this.label2.Text = "AllowEdit:获取和设置一个值，该值指示是否允许编辑图片";
            // 
            // labAlbumCount
            // 
            this.labAlbumCount.Location = new System.Drawing.Point(0, 114);
            this.labAlbumCount.Name = "labAlbumCount";
            this.labAlbumCount.Size = new System.Drawing.Size(90, 30);
            this.labAlbumCount.Text = "9";
            // 
            // btnAllowEditT
            // 
            this.btnAllowEditT.Location = new System.Drawing.Point(90, 184);
            this.btnAllowEditT.Name = "btnAllowEditT";
            this.btnAllowEditT.Size = new System.Drawing.Size(100, 30);
            this.btnAllowEditT.Text = "true";
            this.btnAllowEditT.Press += new System.EventHandler(this.btnAllowEditT_Press);
            // 
            // btnAllowEditF
            // 
            this.btnAllowEditF.Location = new System.Drawing.Point(190, 184);
            this.btnAllowEditF.Name = "btnAllowEditF";
            this.btnAllowEditF.Size = new System.Drawing.Size(100, 30);
            this.btnAllowEditF.Text = "false";
            this.btnAllowEditF.Press += new System.EventHandler(this.btnAllowEditF_Press);
            // 
            // labAllowEdit
            // 
            this.labAllowEdit.Location = new System.Drawing.Point(0, 184);
            this.labAllowEdit.Name = "labAllowEdit";
            this.labAllowEdit.Size = new System.Drawing.Size(90, 30);
            this.labAllowEdit.Text = "false";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 35);
            this.label3.Text = "CompressedQuality:获取和设置压缩质量";
            // 
            // btnCompressedQuality1
            // 
            this.btnCompressedQuality1.Location = new System.Drawing.Point(90, 256);
            this.btnCompressedQuality1.Name = "btnCompressedQuality1";
            this.btnCompressedQuality1.Size = new System.Drawing.Size(100, 30);
            this.btnCompressedQuality1.Text = "30";
            this.btnCompressedQuality1.Press += new System.EventHandler(this.btnCompressedQuality1_Press);
            // 
            // btnCompressedQuality2
            // 
            this.btnCompressedQuality2.Location = new System.Drawing.Point(190, 256);
            this.btnCompressedQuality2.Name = "btnCompressedQuality2";
            this.btnCompressedQuality2.Size = new System.Drawing.Size(100, 30);
            this.btnCompressedQuality2.Text = "60";
            this.btnCompressedQuality2.Press += new System.EventHandler(this.btnCompressedQuality2_Press);
            // 
            // labCompressedQuality
            // 
            this.labCompressedQuality.Location = new System.Drawing.Point(0, 256);
            this.labCompressedQuality.Name = "labCompressedQuality";
            this.labCompressedQuality.Size = new System.Drawing.Size(90, 30);
            this.labCompressedQuality.Text = "60";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 35);
            this.label4.Text = "CompressedResolution:获取和设置压缩分辨率";
            // 
            // btnCompressedResolution1
            // 
            this.btnCompressedResolution1.Location = new System.Drawing.Point(90, 328);
            this.btnCompressedResolution1.Name = "btnCompressedResolution1";
            this.btnCompressedResolution1.Size = new System.Drawing.Size(100, 30);
            this.btnCompressedResolution1.Text = "720";
            this.btnCompressedResolution1.Press += new System.EventHandler(this.btnCompressedResolution1_Press);
            // 
            // btnCompressedResolution2
            // 
            this.btnCompressedResolution2.Location = new System.Drawing.Point(190, 328);
            this.btnCompressedResolution2.Name = "btnCompressedResolution2";
            this.btnCompressedResolution2.Size = new System.Drawing.Size(100, 30);
            this.btnCompressedResolution2.Text = "1280";
            this.btnCompressedResolution2.Press += new System.EventHandler(this.btnCompressedResolution2_Press);
            // 
            // labCompressedResolution
            // 
            this.labCompressedResolution.Location = new System.Drawing.Point(0, 328);
            this.labCompressedResolution.Name = "labCompressedResolution";
            this.labCompressedResolution.Size = new System.Drawing.Size(90, 30);
            this.labCompressedResolution.Text = "1280";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(0, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(290, 35);
            this.label7.Text = "ContinuousNumber:获取和设置连续拍照的最大张数";
            // 
            // btnContinuousNumber1
            // 
            this.btnContinuousNumber1.Location = new System.Drawing.Point(90, 399);
            this.btnContinuousNumber1.Name = "btnContinuousNumber1";
            this.btnContinuousNumber1.Size = new System.Drawing.Size(100, 30);
            this.btnContinuousNumber1.Text = "3";
            this.btnContinuousNumber1.Press += new System.EventHandler(this.btnContinuousNumber1_Press);
            // 
            // btnContinuousNumber2
            // 
            this.btnContinuousNumber2.Location = new System.Drawing.Point(190, 399);
            this.btnContinuousNumber2.Name = "btnContinuousNumber2";
            this.btnContinuousNumber2.Size = new System.Drawing.Size(100, 30);
            this.btnContinuousNumber2.Text = "5";
            this.btnContinuousNumber2.Press += new System.EventHandler(this.btnContinuousNumber2_Press);
            // 
            // labContinuousNumber
            // 
            this.labContinuousNumber.Location = new System.Drawing.Point(0, 399);
            this.labContinuousNumber.Name = "labContinuousNumber";
            this.labContinuousNumber.Size = new System.Drawing.Size(90, 30);
            this.labContinuousNumber.Text = "3";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(0, 436);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(290, 35);
            this.label8.Text = "QualityMode:获取或设置相机组件图像质量";
            // 
            // btnQualityMode1
            // 
            this.btnQualityMode1.Location = new System.Drawing.Point(90, 471);
            this.btnQualityMode1.Name = "btnQualityMode1";
            this.btnQualityMode1.Size = new System.Drawing.Size(100, 30);
            this.btnQualityMode1.Text = "压缩";
            this.btnQualityMode1.Press += new System.EventHandler(this.btnQualityMode1_Press);
            // 
            // btnQualityMode2
            // 
            this.btnQualityMode2.Location = new System.Drawing.Point(190, 471);
            this.btnQualityMode2.Name = "btnQualityMode2";
            this.btnQualityMode2.Size = new System.Drawing.Size(100, 30);
            this.btnQualityMode2.Text = "原图";
            this.btnQualityMode2.Press += new System.EventHandler(this.btnQualityMode2_Press);
            // 
            // labQualityMode
            // 
            this.labQualityMode.Location = new System.Drawing.Point(0, 471);
            this.labQualityMode.Name = "labQualityMode";
            this.labQualityMode.Size = new System.Drawing.Size(90, 30);
            this.labQualityMode.Text = "压缩";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(0, 507);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(290, 35);
            this.label9.Text = "TimeOut:获取或设置客户端获取图像的超时时间[毫秒]";
            // 
            // btnTimeOut1
            // 
            this.btnTimeOut1.Location = new System.Drawing.Point(90, 542);
            this.btnTimeOut1.Name = "btnTimeOut1";
            this.btnTimeOut1.Size = new System.Drawing.Size(100, 30);
            this.btnTimeOut1.Text = "30000";
            this.btnTimeOut1.Press += new System.EventHandler(this.btnTimeOut1_Press);
            // 
            // btnTimeOut2
            // 
            this.btnTimeOut2.Location = new System.Drawing.Point(190, 542);
            this.btnTimeOut2.Name = "btnTimeOut2";
            this.btnTimeOut2.Size = new System.Drawing.Size(100, 30);
            this.btnTimeOut2.Text = "60000";
            this.btnTimeOut2.Press += new System.EventHandler(this.btnTimeOut2_Press);
            // 
            // labTimeOut
            // 
            this.labTimeOut.Location = new System.Drawing.Point(0, 542);
            this.labTimeOut.Name = "labTimeOut";
            this.labTimeOut.Size = new System.Drawing.Size(90, 30);
            this.labTimeOut.Text = "60000";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(0, 579);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(290, 35);
            this.label10.Text = "VideoCompressedQuality:获取或设置相机组件视频质量";
            // 
            // btnVideoCompressedQuality1
            // 
            this.btnVideoCompressedQuality1.Location = new System.Drawing.Point(90, 614);
            this.btnVideoCompressedQuality1.Name = "btnVideoCompressedQuality1";
            this.btnVideoCompressedQuality1.Size = new System.Drawing.Size(100, 30);
            this.btnVideoCompressedQuality1.Text = "640*480";
            this.btnVideoCompressedQuality1.Press += new System.EventHandler(this.btnVideoCompressedQuality1_Press);
            // 
            // btnVideoCompressedQuality2
            // 
            this.btnVideoCompressedQuality2.Location = new System.Drawing.Point(190, 614);
            this.btnVideoCompressedQuality2.Name = "btnVideoCompressedQuality2";
            this.btnVideoCompressedQuality2.Size = new System.Drawing.Size(100, 30);
            this.btnVideoCompressedQuality2.Text = "1920*1080";
            this.btnVideoCompressedQuality2.Press += new System.EventHandler(this.btnVideoCompressedQuality2_Press);
            // 
            // labVideoCompressedQuality
            // 
            this.labVideoCompressedQuality.Location = new System.Drawing.Point(0, 614);
            this.labVideoCompressedQuality.Name = "labVideoCompressedQuality";
            this.labVideoCompressedQuality.Size = new System.Drawing.Size(90, 30);
            this.labVideoCompressedQuality.Text = "中质量";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(5, 650);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(290, 35);
            this.label11.Text = "VideoDuration:获取和设置视频拍摄时长（秒）";
            // 
            // btnVideoDuration1
            // 
            this.btnVideoDuration1.Location = new System.Drawing.Point(95, 685);
            this.btnVideoDuration1.Name = "btnVideoDuration1";
            this.btnVideoDuration1.Size = new System.Drawing.Size(100, 30);
            this.btnVideoDuration1.Text = "8";
            this.btnVideoDuration1.Press += new System.EventHandler(this.btnVideoDuration1_Press);
            // 
            // btnVideoDuration2
            // 
            this.btnVideoDuration2.Location = new System.Drawing.Point(195, 685);
            this.btnVideoDuration2.Name = "btnVideoDuration2";
            this.btnVideoDuration2.Size = new System.Drawing.Size(100, 30);
            this.btnVideoDuration2.Text = "15";
            this.btnVideoDuration2.Press += new System.EventHandler(this.btnVideoDuration2_Press);
            // 
            // labVideoDuration
            // 
            this.labVideoDuration.Location = new System.Drawing.Point(5, 685);
            this.labVideoDuration.Name = "labVideoDuration";
            this.labVideoDuration.Size = new System.Drawing.Size(90, 30);
            this.labVideoDuration.Text = "15";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel2.BorderColor = System.Drawing.Color.Silver;
            this.panel2.BorderRadius = 5;
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label6,
            this.btnGetPhoto,
            this.spinner1,
            this.btnGetPhotoOffline,
            this.btnGetClientPhotoPath});
            this.panel2.Location = new System.Drawing.Point(5, 747);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 111);
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
            this.label6.Text = "获取或设置相机组件获取图像的模式";
            // 
            // btnGetPhoto
            // 
            this.btnGetPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnGetPhoto.Location = new System.Drawing.Point(0, 77);
            this.btnGetPhoto.Name = "btnGetPhoto";
            this.btnGetPhoto.Size = new System.Drawing.Size(86, 30);
            this.btnGetPhoto.Text = "在线上传";
            this.btnGetPhoto.Press += new System.EventHandler(this.btnGetPhoto_Press);
            // 
            // spinner1
            // 
            this.spinner1.Items = new string[] {
        "Camera:直接打开相机",
        "CameraAndAlbum:打开一个选择列表，用于选择相机或相册",
        "AlbumSingle:直接打开相册，仅上传一张图片",
        "Album:直接打开相册，并上传多张图片",
        "CameraContinuous:相机连拍",
        "CameraVideo:相机拍摄视频",
        "AlbumVideo:相册上传视频"};
            this.spinner1.Location = new System.Drawing.Point(7, 41);
            this.spinner1.Name = "spinner1";
            this.spinner1.Size = new System.Drawing.Size(274, 30);
            this.spinner1.Text = "Mode";
            this.spinner1.ItemSelected += new System.EventHandler<Smobiler.Core.Controls.SpinnerItemSelectedEventArgs>(this.spinner1_ItemSelected);
            // 
            // btnGetPhotoOffline
            // 
            this.btnGetPhotoOffline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnGetPhotoOffline.Location = new System.Drawing.Point(100, 77);
            this.btnGetPhotoOffline.Name = "btnGetPhotoOffline";
            this.btnGetPhotoOffline.Size = new System.Drawing.Size(86, 30);
            this.btnGetPhotoOffline.Text = "离线上传";
            this.btnGetPhotoOffline.Press += new System.EventHandler(this.btnGetPhotoOffline_Press);
            // 
            // btnGetClientPhotoPath
            // 
            this.btnGetClientPhotoPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnGetClientPhotoPath.Location = new System.Drawing.Point(204, 77);
            this.btnGetClientPhotoPath.Name = "btnGetClientPhotoPath";
            this.btnGetClientPhotoPath.Size = new System.Drawing.Size(86, 30);
            this.btnGetClientPhotoPath.Text = "获取图像地址";
            this.btnGetClientPhotoPath.Press += new System.EventHandler(this.btnGetClientPhotoPath_Press);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel3.BorderColor = System.Drawing.Color.Silver;
            this.panel3.BorderRadius = 5;
            this.panel3.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label5,
            this.label12});
            this.panel3.Location = new System.Drawing.Point(5, 865);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(290, 105);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label5.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.label5.FontSize = 16F;
            this.label5.Name = "label5";
            this.label5.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label5.Size = new System.Drawing.Size(290, 26);
            this.label5.Text = "相机事件";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Location = new System.Drawing.Point(0, 26);
            this.label12.Name = "label12";
            this.label12.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label12.Size = new System.Drawing.Size(290, 79);
            this.label12.Text = "ClientImageCaptured:在客户端返回手机资源路径时发生。\r\nImageCaptured:在客户端返回相机数据时发生。\r\nOfflineImageC" +
    "aptured:在客户端返回离线资源时发生。";
            // 
            // tabPageView1
            // 
            this.tabPageView1.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.tabPageView1.Location = new System.Drawing.Point(0, 970);
            this.tabPageView1.Name = "tabPageView1";
            this.tabPageView1.Size = new System.Drawing.Size(300, 300);
            // 
            // camera1
            // 
            this.camera1.Name = "camera1";
            this.camera1.ClientImageCaptured += new Smobiler.Core.Controls.ClientResourceCallBackHandler(this.camera1_ClientImageCaptured);
            this.camera1.ImageCaptured += new Smobiler.Core.Controls.CameraOnlineCallBackHandler(this.camera1_ImageCaptured);
            this.camera1.OfflineImageCaptured += new Smobiler.Core.Controls.CameraOfflineCallBackHandler(this.camera1_OfflineImageCaptured);
            // 
            // demoCamera
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.camera1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel10});
            this.Size = new System.Drawing.Size(300, 1300);
            this.Name = "demoCamera";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Panel panel10;
        private Core.Controls.Panel panel1;
        private Core.Controls.Label labContent;
        private Core.Controls.Label labTitle;
        private Core.Controls.Panel panel2;
        private Core.Controls.Label label6;
        private Core.Controls.Camera camera1;
        private Core.Controls.Label label1;
        private Core.Controls.Button btnAlbumCount3;
        private Core.Controls.Button btnAlbumCount9;
        private Core.Controls.Label label2;
        private Core.Controls.Label labAlbumCount;
        private Core.Controls.Button btnAllowEditT;
        private Core.Controls.Button btnAllowEditF;
        private Core.Controls.Label labAllowEdit;
        private Core.Controls.Label label3;
        private Core.Controls.Button btnCompressedQuality1;
        private Core.Controls.Button btnCompressedQuality2;
        private Core.Controls.Label labCompressedQuality;
        private Core.Controls.Label label4;
        private Core.Controls.Button btnCompressedResolution1;
        private Core.Controls.Button btnCompressedResolution2;
        private Core.Controls.Label labCompressedResolution;
        private Core.Controls.Label label7;
        private Core.Controls.Button btnContinuousNumber1;
        private Core.Controls.Button btnContinuousNumber2;
        private Core.Controls.Label labContinuousNumber;
        private Core.Controls.Label label8;
        private Core.Controls.Button btnQualityMode1;
        private Core.Controls.Button btnQualityMode2;
        private Core.Controls.Label labQualityMode;
        private Core.Controls.Label label9;
        private Core.Controls.Button btnTimeOut1;
        private Core.Controls.Button btnTimeOut2;
        private Core.Controls.Label labTimeOut;
        private Core.Controls.Label label10;
        private Core.Controls.Button btnVideoCompressedQuality1;
        private Core.Controls.Button btnVideoCompressedQuality2;
        private Core.Controls.Label labVideoCompressedQuality;
        private Core.Controls.Label label11;
        private Core.Controls.Button btnVideoDuration1;
        private Core.Controls.Button btnVideoDuration2;
        private Core.Controls.Label labVideoDuration;
        private Core.Controls.Button btnGetPhoto;
        private Core.Controls.Spinner spinner1;
        private Core.Controls.Button btnGetPhotoOffline;
        private Core.Controls.Button btnGetClientPhotoPath;
        private Core.Controls.Panel panel3;
        private Core.Controls.Label label5;
        private Core.Controls.Label label12;
        private Core.Controls.TabPageView tabPageView1;
    }
}