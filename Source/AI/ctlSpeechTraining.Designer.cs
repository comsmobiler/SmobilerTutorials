using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.AI
{
    partial class ctlSpeechTraining : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        //SmobilerUserControl overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        //NOTE: The following procedure is required by the SmobilerUserControl
        //It can be modified using the SmobilerUserControl.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.labNotice = new Smobiler.Core.Controls.Label();
            this.txtSpeechContent = new Smobiler.Core.Controls.TextBox();
            this.btnConfirm = new Smobiler.Core.Controls.Button();
            this.btnCancel = new Smobiler.Core.Controls.Button();
            this.btnPlayVoice = new Smobiler.Core.Controls.Button();
            this.btnVoice = new Smobiler.Core.Controls.Button();
            this.labVoiceInfo = new Smobiler.Core.Controls.Label();
            this.voiceRecorder1 = new Smobiler.Core.Controls.VoiceRecorder();
            this.speech1 = new Smobiler.AI.Speech();
            // 
            // labNotice
            // 
            this.labNotice.Name = "labNotice";
            this.labNotice.Size = new System.Drawing.Size(250, 49);
            this.labNotice.Text = "输入语音样本内容（不要包含标点符号，目前样本为0123456789，只能包含这几个内容），然后录入和样本内容一致的语音";
            // 
            // txtSpeechContent
            // 
            this.txtSpeechContent.Location = new System.Drawing.Point(0, 49);
            this.txtSpeechContent.Name = "txtSpeechContent";
            this.txtSpeechContent.Size = new System.Drawing.Size(250, 92);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(17, 256);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 30);
            this.btnConfirm.Text = "上传样本";
            this.btnConfirm.Press += new System.EventHandler(this.btnConfirm_Press);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(141, 256);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.Text = "取消";
            this.btnCancel.Press += new System.EventHandler(this.btnCancel_Press);
            // 
            // btnPlayVoice
            // 
            this.btnPlayVoice.Location = new System.Drawing.Point(141, 156);
            this.btnPlayVoice.Name = "btnPlayVoice";
            this.btnPlayVoice.Size = new System.Drawing.Size(100, 30);
            this.btnPlayVoice.Text = "试听";
            this.btnPlayVoice.Press += new System.EventHandler(this.btnPlayVoice_Press);
            // 
            // btnVoice
            // 
            this.btnVoice.Location = new System.Drawing.Point(17, 156);
            this.btnVoice.Name = "btnVoice";
            this.btnVoice.Size = new System.Drawing.Size(100, 30);
            this.btnVoice.Text = "录音";
            this.btnVoice.Press += new System.EventHandler(this.btnVoice_Press);
            // 
            // labVoiceInfo
            // 
            this.labVoiceInfo.Location = new System.Drawing.Point(15, 195);
            this.labVoiceInfo.Name = "labVoiceInfo";
            this.labVoiceInfo.Size = new System.Drawing.Size(226, 47);
            this.labVoiceInfo.Text = "label1";
            // 
            // voiceRecorder1
            // 
            this.voiceRecorder1.Name = "voiceRecorder1";
            this.voiceRecorder1.TimeOut = 0;
            // 
            // speech1
            // 
            this.speech1.Name = "speech1";
            this.speech1.TrainingServer = "http://aiapi.smobiler.com/";
            // 
            // ctlSpeechTraining
            // 
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BorderRadius = 20;
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.voiceRecorder1,
            this.speech1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.labNotice,
            this.txtSpeechContent,
            this.btnConfirm,
            this.btnCancel,
            this.btnPlayVoice,
            this.btnVoice,
            this.labVoiceInfo});
            this.Size = new System.Drawing.Size(250, 300);
            this.Load += new System.EventHandler(this.ctlSpeechTraining_Load);
            this.Name = "ctlSpeechTraining";

        }
        #endregion

        private Smobiler.Core.Controls.Label labNotice;
        private Smobiler.Core.Controls.TextBox txtSpeechContent;
        private Smobiler.Core.Controls.Button btnConfirm;
        private Smobiler.Core.Controls.Button btnCancel;
        private Smobiler.Core.Controls.Button btnPlayVoice;
        private Smobiler.Core.Controls.Button btnVoice;
        private Smobiler.Core.Controls.Label labVoiceInfo;
        private Smobiler.Core.Controls.VoiceRecorder voiceRecorder1;
        private Smobiler.AI.Speech speech1;
    }
}