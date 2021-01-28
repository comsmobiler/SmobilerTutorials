using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Controls
{
    partial class demoCameraButton : Smobiler.Core.Controls.MobileForm
    {
        public demoCameraButton() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cameraButton1_ImageCaptured(object sender, BinaryResultArgs e)
        {
            if (e.isError == true)
            {
                MessageBox.Show("错误：" + e.error);
            }
            else
            {
                //e.SaveFile();保存图片
                image1.ResourceData = e.Data;
                image1.Refresh();
            }
        }

        private void spinner1_ItemSelected(object sender, SpinnerItemSelectedEventArgs e)
        {
            switch (e.Item)
            {
                case " Camera：直接打开":
                    cameraButton3.Mode = CameraMode.Camera;
                    break;
                case "CameraAndAlbum：打开一个选择列表，用于选择相机或相册":
                    cameraButton3.Mode = CameraMode.CameraAndAlbum;
                    break;
                case "AlbumSingle：直接打开相册，仅上传一张图片":
                    cameraButton3.Mode = CameraMode.AlbumSingle;
                    break;
                case "Album：直接打开相册，并上传多张图片":
                    cameraButton3.Mode = CameraMode.Album;
                    break;
                case "CameraContinuous：相机连拍":
                    cameraButton3.Mode = CameraMode.CameraContinuous;
                    break;
                case "CameraVideo：相机拍摄视频":
                    cameraButton3.Mode = CameraMode.CameraVideo;
                    break;
                case "AlbumVideo：相册上传视频":
                    cameraButton3.Mode = CameraMode.AlbumVideo;
                    break;
            }
        }

        private void cameraButton3_ImageCaptured(object sender, BinaryResultArgs e)
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
            if (this.cameraButton3.Mode == CameraMode.AlbumVideo || this.cameraButton3.Mode == CameraMode.CameraVideo)
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

    }
}