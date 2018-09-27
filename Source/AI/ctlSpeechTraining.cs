using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.IO.Compression;

namespace Smobiler.Tutorials.AI
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class ctlSpeechTraining : Smobiler.Core.Controls.MobileUserControl
    {
        private string speechSapmlesPath;

        public ctlSpeechTraining()
            : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }

        private void ctlSpeechTraining_Load(object sender, EventArgs e)
        {
            speechSapmlesPath = System.IO.Path.Combine(MobileResourceManager.ResourceRootPath,"Resources", "Speech");
            if (System.IO.Directory.Exists(speechSapmlesPath) == false) System.IO.Directory.CreateDirectory(speechSapmlesPath);
        }

        private string lastVoiceResourceID;

        private void btnVoice_Press(object sender, EventArgs e)
        {
            string speechContent = this.txtSpeechContent.Text.Trim();
            if (string.IsNullOrEmpty(speechContent) == false)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(speechContent, @"^\d+$") == true)
                {
                    this.voiceRecorder1.GetRecorderAudio((obj, args) =>
                    {
                        if (args.isError == false)
                        {
                            string timestamp = Math.Truncate((double)(DateTime.Now.ToUniversalTime().Ticks - 621355968000000000) / 10000000).ToString();
                            lastVoiceResourceID = System.Web.HttpUtility.HtmlEncode(speechContent) + "_" + timestamp + ".aac";
                            args.SaveFile(lastVoiceResourceID, speechSapmlesPath);
                            this.labVoiceInfo.Text = lastVoiceResourceID;
                        }
                        else
                        {
                            MessageBox.Show(args.error);
                        }
                    });
                }
                else
                {
                    MessageBox.Show("请输入0123456789范围内的内容");
                }
            }
            else
            {
                MessageBox.Show("请先输入训练内容");
            }
        }

        private void btnPlayVoice_Press(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lastVoiceResourceID) == false)
                this.Client.PlayAudio(lastVoiceResourceID, speechSapmlesPath);
            else
                MessageBox.Show("未找到语音资源");
        }

        private void btnConfirm_Press(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lastVoiceResourceID) == true)
            {
                MessageBox.Show("请先录入语音!");
            }else
            {
                this.Form.ShowLoadingScreen("正在上传样本数据，请稍候...", true);
                Smobiler.AI.SpeechTrainingResult result = this.speech1.UploadTrainingSample(this.txtSpeechContent.Text.Trim(), System.IO.Path.Combine(speechSapmlesPath, lastVoiceResourceID));
                if (result.success == true)
                {
                    MessageBox.Show("上传成功!");
                }
                else
                {
                    MessageBox.Show(string.Format("上传失败：{0}", result.message));
                }
                this.Form.CloseLoadingScreen();
            }
        }

        private void btnCancel_Press(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}