using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoDropdownAert : Smobiler.Core.Controls.MobileForm
    {
        public demoDropdownAert() : base()
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
            switch (spinner1.Text)
            {
                case "Title":
                    dropdownAlert1.Title = "标题";
                    labContent.Text = "获取与设置标题行文本内容";
                    break;
                case "TitleNumOfLines":
                    dropdownAlert1.TitleNumOfLines = 0;
                    labContent.Text = "获取与设置标题栏的行数";
                    break;
                case "Message":
                    dropdownAlert1.Message = "Smobiler专注为开发者提供极致体验，是一套能够快速实施移动信息化战略的平台级产品。";
                        labContent.Text = "获取与设置内容行文本内容";
                    break;
                case "MessageNumOfLines":
                    dropdownAlert1.MessageNumOfLines = 0;
                    labContent.Text = "获取与设置内容行的行数";
                    break;
                case "CloseInterval":
                    dropdownAlert1.CloseInterval = 3000;
                    labContent.Text = "获取与设置alert显示时间（毫秒）"; 
                    break;
                case "CustomColor":
                    dropdownAlert1.CustomColor = System.Drawing.Color.MistyRose;
                    labContent.Text = "获取与设置custom模式下背景颜色";
                    break;
                case "CustomImage":
                    dropdownAlert1.CustomImage = "https://www.smobiler.com/images/index/logo.png";
                    labContent.Text = "获取与设置custom模式下的图片"; 
                    break;
                case "ErrorColor":
                    dropdownAlert1.ErrorColor= System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(67)))), ((int)(((byte)(81)))));
                    labContent.Text = "获取与设置error模式下背景颜色";
                    break;
                case "InfoColor":
                    dropdownAlert1.InfoColor= System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(229)))), ((int)(((byte)(99)))));
                    labContent.Text = "获取与设置info模式下背景颜色"; 
                    break;
                case "SuccessColor": 
                    dropdownAlert1.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(176)))), ((int)(((byte)(249)))));
                    labContent.Text = "获取与设置success模式下背景颜色";
                    break;
                case "WarnColor":
                    dropdownAlert1.WarnColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(78)))));
                    labContent.Text = "获取与设置warn模式下背景颜色"; 
                    break;
                case "显示sucess提示框":
                    dropdownAlert1.Type = Smobiler.Plugins.DropdownAlertType.success;
                    dropdownAlert1.Show();
                    labContent.Text = "显示sucess提示框";
                    break;
                case "显示error提示框":
                    dropdownAlert1.Type = Smobiler.Plugins.DropdownAlertType.error;
                    dropdownAlert1.Show();
                    labContent.Text = "显示error提示框";
                    break;
                case "显示info提示框":
                    dropdownAlert1.Type = Smobiler.Plugins.DropdownAlertType.info;
                    dropdownAlert1.Show(); 
                    labContent.Text = "显示error提示框";
                    break;
                case "显示warning提示框":
                    dropdownAlert1.Type = Smobiler.Plugins.DropdownAlertType.warn;
                    dropdownAlert1.Show();
                    labContent.Text = "显示warning提示框";
                    break;
                case "显示Custom提示框":
                    dropdownAlert1.Type = Smobiler.Plugins.DropdownAlertType.custom;
                    dropdownAlert1.Show();
                    labContent.Text = "显示Custom提示框"; 
                    break;
            }
        }
    }
}