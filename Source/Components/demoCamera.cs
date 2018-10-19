using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Components
{
    partial class demoCamera : Smobiler.Core.Controls.MobileForm
    {
        public demoCamera()
            : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void spinner1_ItemSelected(object sender, SpinnerItemSelectedEventArgs e)
        {
            switch (e.Item)
            {
                case "Camera:直接打开相机":
                    this.camera1.Mode = CameraMode.Camera;
                    break;
                case "CameraAndAlbum:打开一个选择列表，用于选择相机或相册":
                    this.camera1.Mode = CameraMode.CameraAndAlbum;
                    break;
                case "AlbumSingle:直接打开相册，仅上传一张图片":
                    this.camera1.Mode = CameraMode.AlbumSingle;
                    break;
                case "Album:直接打开相册，并上传多张图片":
                    this.camera1.Mode = CameraMode.Album;
                    break;
                case "CameraContinuous:相机连拍":
                    this.camera1.Mode = CameraMode.CameraContinuous;
                    break;
                case "CameraVideo:相机拍摄视频":
                    this.camera1.Mode = CameraMode.CameraVideo;
                    break;
                case "AlbumVideo:相册上传视频":
                    this.camera1.Mode = CameraMode.AlbumVideo;
                    break;
            }
        }

        private void btnGetPhoto_Press(object sender, EventArgs e)
        {
            this.camera1.GetPhoto();
        }

        private void btnGetPhotoOffline_Press(object sender, EventArgs e)
        {
            this.camera1.GetPhotoOffline();
        }

        private void btnGetClientPhotoPath_Press(object sender, EventArgs e)
        {
            this.camera1.GetClientPhotoPath();
        }

        private void btnAlbumCount3_Press(object sender, EventArgs e)
        {
            camera1.AlbumCount = 3;
            labAlbumCount.Text = "3";
        }

        private void btnAlbumCount9_Press(object sender, EventArgs e)
        {
            camera1.AlbumCount = 9;
            labAlbumCount.Text = "9";
        }

        private void btnAllowEditT_Press(object sender, EventArgs e)
        {
            camera1.AllowEdit = true;
            labAllowEdit.Text = "true";
        }

        private void btnAllowEditF_Press(object sender, EventArgs e)
        {
            camera1.AllowEdit = false;
            labAllowEdit.Text = "false";
        }

        private void btnCompressedQuality1_Press(object sender, EventArgs e)
        {
            camera1.CompressedQuality = 30;
            labCompressedQuality.Text = "30";
        }

        private void btnCompressedQuality2_Press(object sender, EventArgs e)
        {
            camera1.CompressedQuality = 60;
            labCompressedQuality.Text = "60";
        }

        private void btnCompressedResolution1_Press(object sender, EventArgs e)
        {
            camera1.CompressedResolution = 720;
            labCompressedResolution.Text = "720";
        }

        private void btnCompressedResolution2_Press(object sender, EventArgs e)
        {
            camera1.CompressedResolution = 1280;
            labCompressedResolution.Text = "1280";
        }

        private void btnContinuousNumber1_Press(object sender, EventArgs e)
        {
            camera1.ContinuousNumber = 3;
            labContinuousNumber.Text = "3";
        }

        private void btnContinuousNumber2_Press(object sender, EventArgs e)
        {
            camera1.ContinuousNumber = 5;
            labContinuousNumber.Text = "5";
        }

        private void btnQualityMode1_Press(object sender, EventArgs e)
        {
            camera1.QualityMode = ImageQualityMode.Compressed;
            labQualityMode.Text = "压缩";
        }

        private void btnQualityMode2_Press(object sender, EventArgs e)
        {
            camera1.QualityMode = ImageQualityMode.Original;
            labQualityMode.Text = "原图";
        }

        private void btnTimeOut1_Press(object sender, EventArgs e)
        {
            camera1.TimeOut = 30000;
            labTimeOut.Text = "30000";
        }

        private void btnTimeOut2_Press(object sender, EventArgs e)
        {
            camera1.TimeOut = 60000;
            labTimeOut.Text = "60000";
        }

        private void btnVideoCompressedQuality1_Press(object sender, EventArgs e)
        {
            camera1.VideoCompressedQuality = VideoCompressedQuality.Size640_480;
            labVideoCompressedQuality.Text = "640*480";
        }

        private void btnVideoCompressedQuality2_Press(object sender, EventArgs e)
        {
            camera1.VideoCompressedQuality = VideoCompressedQuality.Size1920_1080;
            labVideoCompressedQuality.Text = "1920*1080";
        }

        private void btnVideoDuration1_Press(object sender, EventArgs e)
        {
            camera1.VideoDuration = 8;
            labVideoDuration.Text = "8";
        }

        private void btnVideoDuration2_Press(object sender, EventArgs e)
        {
            camera1.VideoDuration = 15;
            labVideoDuration.Text = "15";
        }

        private void camera1_ImageCaptured(object sender, BinaryResultArgs e)
        {
            if (e.isError == true)
            {
                MessageBox.Show("错误：" + e.error);
            }
            else
            {
                e.SaveFile();
                AddTagPageControl(e.ResourceID, e.Data.Length, false);
            }
        }
        private void AddTagPageControl(string resourceid, int datalength, bool clientpath)
        {
            Panel pal = new Panel();
            pal.Flex = 1;
            pal.Width = 0;
            pal.Height = 0;
            pal.Layout = LayoutPosition.Relative;
            pal.Controls.Add(new Label() { Height = 30, Width = 0, Text = string.Format("资源名：{0}/大小：{1}kb", resourceid, (datalength / 1024).ToString()) });
            if (this.camera1.Mode == CameraMode.AlbumVideo || this.camera1.Mode == CameraMode.CameraVideo)
            {
                pal.Controls.Add(new Smobiler.Plugins.MediaView() { Flex = 1, Width = 0, Height = 0, Url = MobileResourceManager.GetResourceURL(this.Client.SessionID, resourceid, MobileResourceManager.DefaultUploadResourceName) });
            }
            else
            {
                if (clientpath == false)
                {
                    pal.Controls.Add(new Image() { Flex = 1, Width = 0, Height = 0, ResourceID = resourceid, ResourcePath = MobileResourceManager.DefaultUploadResourceName });
                }
                else
                {
                    pal.Controls.Add(new Image() { Flex = 1, Width = 0, Height = 0, ResourceID = resourceid, ResourceMode = ResourceMode.Client });
                }
            }
            this.tabPageView1.Controls.Add(pal);
            this.tabPageView1.PageIndex = this.tabPageView1.Controls.Count - 1;
        }

        private void camera1_ClientImageCaptured(object sender, ClientResourceResultArgs e)
        {
            foreach (KeyValuePair<string, string> clientRes in e.Resources)
            {
                AddTagPageControl(clientRes.Value, 0, true);
            }
        }

        private void camera1_OfflineImageCaptured(object sender, ResourcesResultArgs e)
        {
            //可在关于页手动上传
        }
    }
}