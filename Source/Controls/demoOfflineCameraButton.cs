using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Controls
{
    partial class demoOfflineCameraButton : Smobiler.Core.Controls.MobileForm
    {
        public demoOfflineCameraButton() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }
        private void demoOfflineCameraButton_Load(object sender, EventArgs e)
        {
            PopListGroup pg1 = new PopListGroup();
            pg1.Title = "Mode模式";
            pg1.TitleVisible = true;
            pg1.AddListItem("Camera");
            pg1.AddListItem("CameraAndAlbum");
            pg1.AddListItem("AlbumSingle");
            pg1.AddListItem("Album");
            pg1.AddListItem("CameraContinuous");
            pg1.AddListItem("CameraVideo");
            pg1.AddListItem("AlbumVideo");
            PopListGroup pg2 = new PopListGroup();
            pg2.TitleVisible = true;
            pg2.Title = "AlbumCount可上传数";
            pg2.AddListItem("3");
            PopListGroup pg3 = new PopListGroup();
            pg3.TitleVisible = true;
            pg3.Title = "AllowEdit";
            pg3.AddListItem("true");
            pg3.AddListItem("false");
            PopListGroup pg4 = new PopListGroup();
            pg4.TitleVisible = true;
            pg4.Title = "CompressedQuality压缩质量";
            pg4.AddListItem("30");
            pg4.AddListItem("60");
            PopListGroup pg5 = new PopListGroup();
            pg5.TitleVisible = true;
            pg5.Title = "CompressedResolution压缩分辨率";
            pg5.AddListItem("720");
            pg5.AddListItem("1280");
            PopListGroup pg6 = new PopListGroup();
            pg6.TitleVisible = true;
            pg6.Title = "QualityMode图像上传质量的模式";
            pg6.AddListItem("Custom：用户自己选择上传方式");
            pg6.AddListItem("Compressed：压缩上传");
            pg6.AddListItem("Original：原图上传");
            popList1.Groups.AddRange(new PopListGroup[] { pg1, pg2, pg3, pg4, pg5, pg6 });
        }
        private void button1_Press(object sender, EventArgs e)
        {
            popList1.ShowDialog();
        }

        private void offlineCameraButton1_OfflineImageCaptured(object sender, ResourcesResultArgs e)
        {
            //可在离线资源页上传图片,this.Form.Client.ShowOfflineResources()跳转离线资源页
            if (e.isError == false)
            {
                for (int i = 0; i < e.ResourceIDs.Length; i++)

                    Toast(e.ResourceIDs[i]);
            }

        }

        private void button2_Press(object sender, EventArgs e)
        {
            //跳转离线资源页
            this.Form.Client.ShowOfflineResources();
        }

        private void popList1_Selected(object sender, EventArgs e)
        {
            switch (popList1.Selection.Text)
            {

                case "Camera":
                    offlineCameraButton1.Mode = CameraMode.Camera;
                    button1.Text = "Mode:Camera";
                    break;
                case "CameraAndAlbum":
                    offlineCameraButton1.Mode = CameraMode.CameraAndAlbum;
                    button1.Text = "Mode:CameraAndAlbum"; break;
                case "AlbumSingle":
                    offlineCameraButton1.Mode = CameraMode.AlbumSingle;
                    button1.Text = "Mode:AlbumSingle"; break;
                case "Album":
                    offlineCameraButton1.Mode = CameraMode.Album;
                    button1.Text = "Mode:Album"; break;
                case "CameraContinuous":
                    offlineCameraButton1.Mode = CameraMode.CameraContinuous;
                    button1.Text = "Mode:CameraContinuous"; break;
                case "CameraVideo":
                    offlineCameraButton1.Mode = CameraMode.CameraVideo;
                    button1.Text = "Mode:CameraVideo"; break;
                case "AlbumVideo":
                    offlineCameraButton1.Mode = CameraMode.AlbumVideo;
                    button1.Text = "Mode:AlbumVideo"; 
                    break;
                    case"3":
                    offlineCameraButton1.AlbumCount = 3;
                    button1.Text = "AlbumCount:3"; 
                    break;
                    case"true":
                    offlineCameraButton1.AllowEdit = true;
                    button1.Text = "AllowEdit:true"; 
                    break;
                    case"false":
                    offlineCameraButton1.AllowEdit = false;
                    button1.Text = "AllowEdit:false"; 
                    break;
                    case"30":
                    offlineCameraButton1.CompressedQuality = 30;
                    button1.Text = "CompressedQuality:30";
                    break;
                    case"60": 
                    offlineCameraButton1.CompressedQuality = 60;
                    button1.Text = "CompressedQuality:60"; 
                    break;
                    case"720":
                    offlineCameraButton1.CompressedResolution = 720;
                    button1.Text = "CompressedResolution:720"; 
                    break;
                    case"1280":
                    offlineCameraButton1.CompressedResolution = 1280;
                    button1.Text = "CompressedResolution:1280"; 
                    break;
                    case"Custom：用户自己选择上传方式":
                    offlineCameraButton1.QualityMode = ImageQualityMode.Custom;
                    button1.Text = "Mode:AlbumVideo"; 
                    break;
                    case"Compressed：压缩上传":
                    offlineCameraButton1.QualityMode = ImageQualityMode.Compressed;
                    button1.Text = "Mode:AlbumVideo"; 
                    break;
                    case"Original：原图上传":
                    offlineCameraButton1.QualityMode = ImageQualityMode.Original;
                    button1.Text = "Mode:AlbumVideo";
                    break;
            }
        }
    }
}