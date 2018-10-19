using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Components
{
    partial class demoVoiceRecorder : Smobiler.Core.Controls.MobileForm
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
            this.btnGetRecorderAudio = new Smobiler.Core.Controls.Button();
            this.btnGetRecorderAudioOffline = new Smobiler.Core.Controls.Button();
            this.btnGetClientRecorderAudio = new Smobiler.Core.Controls.Button();
            this.panel3 = new Smobiler.Core.Controls.Panel();
            this.label13 = new Smobiler.Core.Controls.Label();
            this.label14 = new Smobiler.Core.Controls.Label();
            this.voiceRecorder1 = new Smobiler.Core.Controls.VoiceRecorder();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "VoiceRecorder";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // panel10
            // 
            this.panel10.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1,
            this.panel3});
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
            this.btnGetRecorderAudio,
            this.btnGetRecorderAudioOffline,
            this.btnGetClientRecorderAudio});
            this.panel1.Location = new System.Drawing.Point(5, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 261);
            // 
            // labContent
            // 
            this.labContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labContent.Location = new System.Drawing.Point(0, 26);
            this.labContent.Name = "labContent";
            this.labContent.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.labContent.Size = new System.Drawing.Size(290, 54);
            this.labContent.Text = "录音组件，基础控件，GetRecorderAudio、GetRecorderAudioOffline、GetClientRecorderAudio方法获取音频";
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
            this.labTitle.Text = "录音组件";
            // 
            // btnGetRecorderAudio
            // 
            this.btnGetRecorderAudio.Location = new System.Drawing.Point(87, 99);
            this.btnGetRecorderAudio.Name = "btnGetRecorderAudio";
            this.btnGetRecorderAudio.Size = new System.Drawing.Size(120, 30);
            this.btnGetRecorderAudio.Text = "获取音频";
            this.btnGetRecorderAudio.Press += new System.EventHandler(this.btnGetRecorderAudio_Press);
            // 
            // btnGetRecorderAudioOffline
            // 
            this.btnGetRecorderAudioOffline.Location = new System.Drawing.Point(87, 151);
            this.btnGetRecorderAudioOffline.Name = "btnGetRecorderAudioOffline";
            this.btnGetRecorderAudioOffline.Size = new System.Drawing.Size(120, 30);
            this.btnGetRecorderAudioOffline.Text = "离线获取音频";
            this.btnGetRecorderAudioOffline.Press += new System.EventHandler(this.btnGetRecorderAudioOffline_Press);
            // 
            // btnGetClientRecorderAudio
            // 
            this.btnGetClientRecorderAudio.Location = new System.Drawing.Point(87, 203);
            this.btnGetClientRecorderAudio.Name = "btnGetClientRecorderAudio";
            this.btnGetClientRecorderAudio.Size = new System.Drawing.Size(120, 30);
            this.btnGetClientRecorderAudio.Text = "获取客户端音频";
            this.btnGetClientRecorderAudio.Press += new System.EventHandler(this.btnGetClientRecorderAudio_Press);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Border = new Smobiler.Core.Controls.Border(1F);
            this.panel3.BorderColor = System.Drawing.Color.Silver;
            this.panel3.BorderRadius = 5;
            this.panel3.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label13,
            this.label14});
            this.panel3.Location = new System.Drawing.Point(5, 283);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(290, 109);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label13.Location = new System.Drawing.Point(0, 26);
            this.label13.Name = "label13";
            this.label13.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label13.Size = new System.Drawing.Size(290, 78);
            this.label13.Text = "RecordedAudio、OfflineRecorderdAudio、ClientRecordedAudio在客户端返回音频数据时发生、在客户端返回离线资源时发" +
    "生、在客户端返回手机资源路径时发生";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label14.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.label14.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.label14.FontSize = 16F;
            this.label14.Name = "label14";
            this.label14.Padding = new Smobiler.Core.Controls.Padding(5F);
            this.label14.Size = new System.Drawing.Size(290, 26);
            this.label14.Text = "录音组件事件";
            // 
            // voiceRecorder1
            // 
            this.voiceRecorder1.Name = "voiceRecorder1";
            this.voiceRecorder1.TimeOut = 0;
            this.voiceRecorder1.ClientRecordedAudio += new Smobiler.Core.Controls.ClientResourceCallBackHandler(this.voiceRecorder1_ClientRecordedAudio);
            this.voiceRecorder1.RecordedAudio += new Smobiler.Core.Controls.AudioRecorderOnlineCallBackHandler(this.voiceRecorder1_RecordedAudio);
            this.voiceRecorder1.OfflineRecorderdAudio += new Smobiler.Core.Controls.AudioRecorderOfflineCallBackHandler(this.voiceRecorder1_OfflineRecorderdAudio);
            // 
            // demoVoiceRecorder
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.voiceRecorder1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel10});
            this.Size = new System.Drawing.Size(300, 1000);
            this.Name = "demoVoiceRecorder";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Panel panel10;
        private Core.Controls.Panel panel1;
        private Core.Controls.Label labContent;
        private Core.Controls.Label labTitle;
        private Core.Controls.Panel panel3;
        private Core.Controls.Label label13;
        private Core.Controls.Label label14;
        private Core.Controls.Button btnGetRecorderAudio;
        private Core.Controls.Button btnGetRecorderAudioOffline;
        private Core.Controls.Button btnGetClientRecorderAudio;
        private Core.Controls.VoiceRecorder voiceRecorder1;
    }
}