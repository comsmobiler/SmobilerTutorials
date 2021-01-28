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
            this.label2 = new Smobiler.Core.Controls.Label();
            this.btnAllowEditT = new Smobiler.Core.Controls.Button();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.btnCompressedQuality1 = new Smobiler.Core.Controls.Button();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.btnCompressedResolution1 = new Smobiler.Core.Controls.Button();
            this.label7 = new Smobiler.Core.Controls.Label();
            this.btnContinuousNumber1 = new Smobiler.Core.Controls.Button();
            this.label8 = new Smobiler.Core.Controls.Label();
            this.btnQualityMode1 = new Smobiler.Core.Controls.Button();
            this.label9 = new Smobiler.Core.Controls.Label();
            this.btnTimeOut1 = new Smobiler.Core.Controls.Button();
            this.label10 = new Smobiler.Core.Controls.Label();
            this.btnVideoCompressedQuality1 = new Smobiler.Core.Controls.Button();
            this.label11 = new Smobiler.Core.Controls.Label();
            this.btnVideoDuration1 = new Smobiler.Core.Controls.Button();
            this.spAlbumCount = new Smobiler.Core.Controls.Spinner();
            this.spAllowEdit = new Smobiler.Core.Controls.Spinner();
            this.spCompressedQuality = new Smobiler.Core.Controls.Spinner();
            this.spCompressedResolution = new Smobiler.Core.Controls.Spinner();
            this.spContinuousNumber = new Smobiler.Core.Controls.Spinner();
            this.spQualityMode = new Smobiler.Core.Controls.Spinner();
            this.spVideoCompressedQuality = new Smobiler.Core.Controls.Spinner();
            this.spTimeOut = new Smobiler.Core.Controls.Spinner();
            this.spVideoDuration = new Smobiler.Core.Controls.Spinner();
            this.spinner1 = new Smobiler.Core.Controls.Spinner();
            this.btnGetPhotoOffline = new Smobiler.Core.Controls.Button();
            this.btnGetPhoto = new Smobiler.Core.Controls.Button();
            this.label6 = new Smobiler.Core.Controls.Label();
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
            this.label2,
            this.btnAllowEditT,
            this.label3,
            this.btnCompressedQuality1,
            this.label4,
            this.btnCompressedResolution1,
            this.label7,
            this.btnContinuousNumber1,
            this.label8,
            this.btnQualityMode1,
            this.label9,
            this.btnTimeOut1,
            this.label10,
            this.btnVideoCompressedQuality1,
            this.label11,
            this.btnVideoDuration1,
            this.spAlbumCount,
            this.spAllowEdit,
            this.spCompressedQuality,
            this.spCompressedResolution,
            this.spContinuousNumber,
            this.spQualityMode,
            this.spVideoCompressedQuality,
            this.spTimeOut,
            this.spVideoDuration,
            this.spinner1,
            this.btnGetPhotoOffline,
            this.btnGetPhoto,
            this.label6,
            this.btnGetClientPhotoPath});
            this.panel1.Location = new System.Drawing.Point(5, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 910);
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
            this.label1.FontSize = 14F;
            this.label1.Location = new System.Drawing.Point(0, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 35);
            this.label1.Text = "AlbumCount:获取和设置在CameraMode为Alubum时，上传的数量";
            // 
            // btnAlbumCount3
            // 
            this.btnAlbumCount3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(176)))), ((int)(((byte)(249)))));
            this.btnAlbumCount3.Location = new System.Drawing.Point(168, 248);
            this.btnAlbumCount3.Name = "btnAlbumCount3";
            this.btnAlbumCount3.Size = new System.Drawing.Size(100, 30);
            this.btnAlbumCount3.Text = "拍照";
            this.btnAlbumCount3.Press += new System.EventHandler(this.btnAllowEditT_Press);
            // 
            // label2
            // 
            this.label2.FontSize = 14F;
            this.label2.Location = new System.Drawing.Point(0, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 35);
            this.label2.Text = "AllowEdit:获取和设置一个值，该值指示是否允许编辑图片";
            // 
            // btnAllowEditT
            // 
            this.btnAllowEditT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(176)))), ((int)(((byte)(249)))));
            this.btnAllowEditT.Location = new System.Drawing.Point(168, 318);
            this.btnAllowEditT.Name = "btnAllowEditT";
            this.btnAllowEditT.Size = new System.Drawing.Size(100, 30);
            this.btnAllowEditT.Text = "拍照";
            this.btnAllowEditT.Press += new System.EventHandler(this.btnAllowEditT_Press);
            // 
            // label3
            // 
            this.label3.FontSize = 15F;
            this.label3.Location = new System.Drawing.Point(0, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 35);
            this.label3.Text = "CompressedQuality:获取和设置压缩质量";
            // 
            // btnCompressedQuality1
            // 
            this.btnCompressedQuality1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(176)))), ((int)(((byte)(249)))));
            this.btnCompressedQuality1.Location = new System.Drawing.Point(168, 390);
            this.btnCompressedQuality1.Name = "btnCompressedQuality1";
            this.btnCompressedQuality1.Size = new System.Drawing.Size(100, 30);
            this.btnCompressedQuality1.Text = "拍照";
            this.btnCompressedQuality1.Press += new System.EventHandler(this.btnAllowEditT_Press);
            // 
            // label4
            // 
            this.label4.FontSize = 15F;
            this.label4.Location = new System.Drawing.Point(0, 427);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 35);
            this.label4.Text = "CompressedResolution:获取和设置压缩分辨率";
            // 
            // btnCompressedResolution1
            // 
            this.btnCompressedResolution1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(176)))), ((int)(((byte)(249)))));
            this.btnCompressedResolution1.Location = new System.Drawing.Point(168, 462);
            this.btnCompressedResolution1.Name = "btnCompressedResolution1";
            this.btnCompressedResolution1.Size = new System.Drawing.Size(100, 30);
            this.btnCompressedResolution1.Text = "拍照";
            this.btnCompressedResolution1.Press += new System.EventHandler(this.btnAllowEditT_Press);
            // 
            // label7
            // 
            this.label7.FontSize = 14F;
            this.label7.Location = new System.Drawing.Point(0, 498);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(290, 35);
            this.label7.Text = "ContinuousNumber:获取和设置连续拍照的最大张数";
            // 
            // btnContinuousNumber1
            // 
            this.btnContinuousNumber1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(176)))), ((int)(((byte)(249)))));
            this.btnContinuousNumber1.Location = new System.Drawing.Point(168, 533);
            this.btnContinuousNumber1.Name = "btnContinuousNumber1";
            this.btnContinuousNumber1.Size = new System.Drawing.Size(100, 30);
            this.btnContinuousNumber1.Text = "拍照";
            this.btnContinuousNumber1.Press += new System.EventHandler(this.btnAllowEditT_Press);
            // 
            // label8
            // 
            this.label8.FontSize = 15F;
            this.label8.Location = new System.Drawing.Point(0, 570);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(290, 35);
            this.label8.Text = "QualityMode:获取或设置相机组件图像质量";
            // 
            // btnQualityMode1
            // 
            this.btnQualityMode1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(176)))), ((int)(((byte)(249)))));
            this.btnQualityMode1.Location = new System.Drawing.Point(168, 605);
            this.btnQualityMode1.Name = "btnQualityMode1";
            this.btnQualityMode1.Size = new System.Drawing.Size(100, 30);
            this.btnQualityMode1.Text = "拍照";
            this.btnQualityMode1.Press += new System.EventHandler(this.btnAllowEditT_Press);
            // 
            // label9
            // 
            this.label9.FontSize = 14F;
            this.label9.Location = new System.Drawing.Point(0, 641);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(290, 35);
            this.label9.Text = "TimeOut:获取或设置客户端获取图像的超时时间[毫秒]";
            // 
            // btnTimeOut1
            // 
            this.btnTimeOut1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(176)))), ((int)(((byte)(249)))));
            this.btnTimeOut1.Location = new System.Drawing.Point(168, 676);
            this.btnTimeOut1.Name = "btnTimeOut1";
            this.btnTimeOut1.Size = new System.Drawing.Size(100, 30);
            this.btnTimeOut1.Text = "拍照";
            this.btnTimeOut1.Press += new System.EventHandler(this.btnAllowEditT_Press);
            // 
            // label10
            // 
            this.label10.FontSize = 14F;
            this.label10.Location = new System.Drawing.Point(0, 713);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(290, 35);
            this.label10.Text = "VideoCompressedQuality:获取或设置相机组件视频质量";
            // 
            // btnVideoCompressedQuality1
            // 
            this.btnVideoCompressedQuality1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(176)))), ((int)(((byte)(249)))));
            this.btnVideoCompressedQuality1.Location = new System.Drawing.Point(168, 748);
            this.btnVideoCompressedQuality1.Name = "btnVideoCompressedQuality1";
            this.btnVideoCompressedQuality1.Size = new System.Drawing.Size(100, 30);
            this.btnVideoCompressedQuality1.Text = "拍照";
            this.btnVideoCompressedQuality1.Press += new System.EventHandler(this.btnAllowEditT_Press);
            // 
            // label11
            // 
            this.label11.FontSize = 15F;
            this.label11.Location = new System.Drawing.Point(0, 784);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(290, 35);
            this.label11.Text = "VideoDuration:获取和设置视频拍摄时长（秒）";
            // 
            // btnVideoDuration1
            // 
            this.btnVideoDuration1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(176)))), ((int)(((byte)(249)))));
            this.btnVideoDuration1.Location = new System.Drawing.Point(168, 819);
            this.btnVideoDuration1.Name = "btnVideoDuration1";
            this.btnVideoDuration1.Size = new System.Drawing.Size(100, 30);
            this.btnVideoDuration1.Text = "拍照";
            this.btnVideoDuration1.Press += new System.EventHandler(this.btnAllowEditT_Press);
            // 
            // spAlbumCount
            // 
            this.spAlbumCount.Items = new string[] {
        "3",
        "5"};
            this.spAlbumCount.Location = new System.Drawing.Point(0, 248);
            this.spAlbumCount.Name = "spAlbumCount";
            this.spAlbumCount.Size = new System.Drawing.Size(151, 35);
            this.spAlbumCount.Text = "3";
            this.spAlbumCount.ItemSelected += new System.EventHandler<Smobiler.Core.Controls.SpinnerItemSelectedEventArgs>(this.spAlbumCount_ItemSelected);
            // 
            // spAllowEdit
            // 
            this.spAllowEdit.Items = new string[] {
        "true",
        "false"};
            this.spAllowEdit.Location = new System.Drawing.Point(0, 318);
            this.spAllowEdit.Name = "spAllowEdit";
            this.spAllowEdit.Size = new System.Drawing.Size(151, 37);
            this.spAllowEdit.Text = "false";
            this.spAllowEdit.ItemSelected += new System.EventHandler<Smobiler.Core.Controls.SpinnerItemSelectedEventArgs>(this.spAllowEdit_ItemSelected);
            // 
            // spCompressedQuality
            // 
            this.spCompressedQuality.Items = new string[] {
        "30",
        "60"};
            this.spCompressedQuality.Location = new System.Drawing.Point(0, 390);
            this.spCompressedQuality.Name = "spCompressedQuality";
            this.spCompressedQuality.Size = new System.Drawing.Size(151, 37);
            this.spCompressedQuality.Text = "30";
            this.spCompressedQuality.ItemSelected += new System.EventHandler<Smobiler.Core.Controls.SpinnerItemSelectedEventArgs>(this.spCompressedQuality_ItemSelected);
            // 
            // spCompressedResolution
            // 
            this.spCompressedResolution.Items = new string[] {
        "720",
        "1280"};
            this.spCompressedResolution.Location = new System.Drawing.Point(0, 462);
            this.spCompressedResolution.Name = "spCompressedResolution";
            this.spCompressedResolution.Size = new System.Drawing.Size(151, 35);
            this.spCompressedResolution.Text = "720";
            this.spCompressedResolution.ItemSelected += new System.EventHandler<Smobiler.Core.Controls.SpinnerItemSelectedEventArgs>(this.spCompressedResolution_ItemSelected);
            // 
            // spContinuousNumber
            // 
            this.spContinuousNumber.Items = new string[] {
        "3",
        "5"};
            this.spContinuousNumber.Location = new System.Drawing.Point(0, 533);
            this.spContinuousNumber.Name = "spContinuousNumber";
            this.spContinuousNumber.Size = new System.Drawing.Size(151, 37);
            this.spContinuousNumber.Text = "3";
            this.spContinuousNumber.ItemSelected += new System.EventHandler<Smobiler.Core.Controls.SpinnerItemSelectedEventArgs>(this.spContinuousNumber_ItemSelected);
            // 
            // spQualityMode
            // 
            this.spQualityMode.Items = new string[] {
        "Custom：用户自己选择上传方式",
        "Compressed：压缩上传",
        "Original：原图上传"};
            this.spQualityMode.Location = new System.Drawing.Point(0, 605);
            this.spQualityMode.Name = "spQualityMode";
            this.spQualityMode.Size = new System.Drawing.Size(151, 35);
            this.spQualityMode.Text = "Original：原图上传";
            this.spQualityMode.ItemSelected += new System.EventHandler<Smobiler.Core.Controls.SpinnerItemSelectedEventArgs>(this.spQualityMode_ItemSelected);
            // 
            // spVideoCompressedQuality
            // 
            this.spVideoCompressedQuality.Items = new string[] {
        "640*480",
        "1920*1080"};
            this.spVideoCompressedQuality.Location = new System.Drawing.Point(0, 748);
            this.spVideoCompressedQuality.Name = "spVideoCompressedQuality";
            this.spVideoCompressedQuality.Size = new System.Drawing.Size(151, 35);
            this.spVideoCompressedQuality.Text = "1920*1080";
            this.spVideoCompressedQuality.ItemSelected += new System.EventHandler<Smobiler.Core.Controls.SpinnerItemSelectedEventArgs>(this.spVideoCompressedQuality_ItemSelected);
            // 
            // spTimeOut
            // 
            this.spTimeOut.Items = new string[] {
        "30000",
        "60000"};
            this.spTimeOut.Location = new System.Drawing.Point(0, 676);
            this.spTimeOut.Name = "spTimeOut";
            this.spTimeOut.Size = new System.Drawing.Size(151, 37);
            this.spTimeOut.Text = "30000";
            // 
            // spVideoDuration
            // 
            this.spVideoDuration.Items = new string[] {
        "8",
        "15"};
            this.spVideoDuration.Location = new System.Drawing.Point(0, 819);
            this.spVideoDuration.Name = "spVideoDuration";
            this.spVideoDuration.Size = new System.Drawing.Size(151, 35);
            this.spVideoDuration.Text = "8";
            this.spVideoDuration.ItemSelected += new System.EventHandler<Smobiler.Core.Controls.SpinnerItemSelectedEventArgs>(this.spVideoDuration_ItemSelected);
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
            this.spinner1.Location = new System.Drawing.Point(6, 113);
            this.spinner1.Name = "spinner1";
            this.spinner1.Size = new System.Drawing.Size(274, 30);
            this.spinner1.Text = "Mode";
            this.spinner1.ItemSelected += new System.EventHandler<Smobiler.Core.Controls.SpinnerItemSelectedEventArgs>(this.spinner1_ItemSelected);
            // 
            // btnGetPhotoOffline
            // 
            this.btnGetPhotoOffline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnGetPhotoOffline.ForeColor = System.Drawing.Color.Gray;
            this.btnGetPhotoOffline.Location = new System.Drawing.Point(100, 172);
            this.btnGetPhotoOffline.Name = "btnGetPhotoOffline";
            this.btnGetPhotoOffline.Size = new System.Drawing.Size(86, 30);
            this.btnGetPhotoOffline.Text = "离线上传";
            this.btnGetPhotoOffline.Press += new System.EventHandler(this.btnGetPhotoOffline_Press);
            // 
            // btnGetPhoto
            // 
            this.btnGetPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(229)))), ((int)(((byte)(99)))));
            this.btnGetPhoto.Location = new System.Drawing.Point(6, 172);
            this.btnGetPhoto.Name = "btnGetPhoto";
            this.btnGetPhoto.Size = new System.Drawing.Size(86, 31);
            this.btnGetPhoto.Text = "在线上传";
            this.btnGetPhoto.Press += new System.EventHandler(this.btnGetPhoto_Press);
            // 
            // label6
            // 
            this.label6.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.label6.FontSize = 16F;
            this.label6.Location = new System.Drawing.Point(0, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(290, 26);
            this.label6.Text = "获取或设置相机组件获取图像的模式";
            // 
            // btnGetClientPhotoPath
            // 
            this.btnGetClientPhotoPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(67)))), ((int)(((byte)(81)))));
            this.btnGetClientPhotoPath.Location = new System.Drawing.Point(194, 172);
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
            this.panel3.Location = new System.Drawing.Point(5, 930);
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
            this.label12.FontSize = 14F;
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
            this.tabPageView1.Location = new System.Drawing.Point(0, 1035);
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
            this.Size = new System.Drawing.Size(300, 1400);
            this.Load += new System.EventHandler(this.demoCamera_Load);
            this.Name = "demoCamera";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Panel panel10;
        private Core.Controls.Panel panel1;
        private Core.Controls.Label labContent;
        private Core.Controls.Label labTitle;
        private Core.Controls.Camera camera1;
        private Core.Controls.Label label1;
        private Core.Controls.Button btnAlbumCount3;
        private Core.Controls.Label label2;
        private Core.Controls.Button btnAllowEditT;
        private Core.Controls.Label label3;
        private Core.Controls.Button btnCompressedQuality1;
        private Core.Controls.Label label4;
        private Core.Controls.Button btnCompressedResolution1;
        private Core.Controls.Label label7;
        private Core.Controls.Button btnContinuousNumber1;
        private Core.Controls.Label label8;
        private Core.Controls.Button btnQualityMode1;
        private Core.Controls.Label label9;
        private Core.Controls.Button btnTimeOut1;
        private Core.Controls.Label label10;
        private Core.Controls.Button btnVideoCompressedQuality1;
        private Core.Controls.Label label11;
        private Core.Controls.Button btnVideoDuration1;
        private Core.Controls.Panel panel3;
        private Core.Controls.Label label5;
        private Core.Controls.Label label12;
        private Core.Controls.TabPageView tabPageView1;
        private Core.Controls.Spinner spAlbumCount;
        private Core.Controls.Spinner spAllowEdit;
        private Core.Controls.Spinner spCompressedQuality;
        private Core.Controls.Spinner spCompressedResolution;
        private Core.Controls.Spinner spContinuousNumber;
        private Core.Controls.Spinner spQualityMode;
        private Core.Controls.Spinner spVideoCompressedQuality;
        private Core.Controls.Spinner spTimeOut;
        private Core.Controls.Spinner spVideoDuration;
        private Core.Controls.Spinner spinner1;
        private Core.Controls.Button btnGetPhotoOffline;
        private Core.Controls.Button btnGetPhoto;
        private Core.Controls.Label label6;
        private Core.Controls.Button btnGetClientPhotoPath;
    }
}