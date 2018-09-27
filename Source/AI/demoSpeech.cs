using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System.Collections;

namespace Smobiler.Tutorials.AI
{
    partial class demoSpeech : Smobiler.Core.Controls.MobileForm
    {

        private void btnStart_Press(object sender, EventArgs e)
        {
            this.label1.Text = "Start" + Environment.NewLine;
            this.speech1.IsRealTime = false;
            this.speech1.RecognizeStart();
        }

        private void btnStartContinuously_Press(object sender, EventArgs e)
        {
            this.label1.Text = "Start RealTime" + Environment.NewLine;
            this.speech1.IsRealTime = true;
            this.speech1.RecognizeStart();
        }

        private void btnPause_Press(object sender, EventArgs e)
        {
            this.speech1.RecognizePause((obj, args) => {
                if (args.isError==true)
                {
                    MessageBox.Show(args.error);
                }else
                {
                    Toast("Pause Done");
                }
            });
        }

        private void btnStop_Press(object sender, EventArgs e)
        {
            this.speech1.RecognizeStop((obj, args) =>
            {
                if (args.isError == true)
                {
                    MessageBox.Show(args.error);
                }
                else
                {
                    Toast("Stop Done");
                }
            });
        }

        private void speech1_Recognized(object sender, Smobiler.AI.SpeechRecognizedEventArgs e)
        {
            if (e.isError == true)
            {
                MessageBox.Show("RecognizedError" + e.error);
            }
            else
            {
                this.label1.Text += string.Format("Text:{0}/Confidence:{1} {2}", e.Text, e.Confidence, Environment.NewLine);

                this.label1.Text += "---------Details---------" + Environment.NewLine;

                if (e.Items != null)
                {
                    foreach (var item in e.Items)
                    {
                        this.label1.Text += string.Format("{0}| {1} {2}", item.Text.PadRight(5, ' '), item.Confidence, Environment.NewLine);
                    }
                }

                if (this.speech1.IsRealTime == true && e.IsEnd == true)
                {
                    this.label1.Text += "Finish!" + Environment.NewLine;
                }
            }
        }

        private void btnInit_Press(object sender, EventArgs e)
        {
            this.speech1.Init((obj, args) =>
            {
                if (args.isError == true)
                {
                    MessageBox.Show(args.error);
                }
                else
                {
                    Toast("Init Done");
                }
            });
        }

        private ctlSpeechTraining dialogTraining;
        private DialogOptions dialogTrainingOptions;

        private void btnUploadVoice_Press(object sender, EventArgs e)
        {
            if (dialogTraining == null)
            {
                dialogTrainingOptions = new DialogOptions(LayoutJustifyAlign.Center);
                dialogTrainingOptions.TouchClosed = false;
                dialogTraining = new ctlSpeechTraining();
            }
            this.ShowDialog(dialogTraining, dialogTrainingOptions);
        }


        private void btnDownloadSpeechConfig_Press(object sender, EventArgs e)
        {
            this.ShowLoadingScreen("配置文件下载中...");
            this.speech1.DownloadTrainingParams((obj, args) => {
                this.CloseLoadingScreen();
                if (args.isError==true)
                {
                    MessageBox.Show(args.error);
                }else
                {
                    MessageBox.Show("下载成功");
                }
            });
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}