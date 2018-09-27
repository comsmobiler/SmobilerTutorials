using Smobiler.Core;

namespace Smobiler.Tutorials.AI
{
    partial class demoSpeech : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm Designer generated code "

        public demoSpeech()
            : base()
        {
            //This call is required by the SmobilerForm Designer.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call
        }

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm Designer
        //It can be modified using the SmobilerForm Designer.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.speech1 = new Smobiler.AI.Speech();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.btnInit = new Smobiler.Core.Controls.Button();
            this.btnStart = new Smobiler.Core.Controls.Button();
            this.btnStartContinuously = new Smobiler.Core.Controls.Button();
            this.btnPause = new Smobiler.Core.Controls.Button();
            this.btnStop = new Smobiler.Core.Controls.Button();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.panel2 = new Smobiler.Core.Controls.Panel();
            this.btnUploadVoice = new Smobiler.Core.Controls.Button();
            this.btnDownloadSpeechConfig = new Smobiler.Core.Controls.Button();
            this.title1 = new Smobiler.Core.Controls.Title();
            // 
            // speech1
            // 
            this.speech1.Name = "speech1";
            this.speech1.TrainingServer = "http://aiapi.smobiler.com/";
            this.speech1.Recognized += new Smobiler.AI.SpeechRecognizedEventHandler(this.speech1_Recognized);
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnInit,
            this.btnStart,
            this.btnStartContinuously,
            this.btnPause,
            this.btnStop});
            this.panel1.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.panel1.JustifyAlign = Smobiler.Core.Controls.LayoutJustifyAlign.SpaceAround;
            this.panel1.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel1.Name = "panel1";
            this.panel1.Padding = new Smobiler.Core.Controls.Padding(10F, 2F, 10F, 2F);
            this.panel1.Size = new System.Drawing.Size(0, 50);
            // 
            // btnInit
            // 
            this.btnInit.BorderRadius = 25;
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(50, 0);
            this.btnInit.Text = "初始化";
            this.btnInit.Press += new System.EventHandler(this.btnInit_Press);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.RosyBrown;
            this.btnStart.BorderRadius = 25;
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(50, 0);
            this.btnStart.Text = "开始";
            this.btnStart.Press += new System.EventHandler(this.btnStart_Press);
            // 
            // btnStartContinuously
            // 
            this.btnStartContinuously.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnStartContinuously.BorderRadius = 25;
            this.btnStartContinuously.Name = "btnStartContinuously";
            this.btnStartContinuously.Size = new System.Drawing.Size(50, 0);
            this.btnStartContinuously.Text = "持续";
            this.btnStartContinuously.Visible = false;
            this.btnStartContinuously.Press += new System.EventHandler(this.btnStartContinuously_Press);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnPause.BorderRadius = 25;
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(50, 0);
            this.btnPause.Text = "暂停";
            this.btnPause.Press += new System.EventHandler(this.btnPause_Press);
            // 
            // btnStop
            // 
            this.btnStop.BorderRadius = 25;
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(50, 0);
            this.btnStop.Text = "停止";
            this.btnStop.Press += new System.EventHandler(this.btnStop_Press);
            // 
            // label1
            // 
            this.label1.Flex = 1;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 98);
            this.label1.Text = "目前只能识别0到9的数字，先点击‘初始化’后点击‘开始’识别";
            this.label1.VerticalAlignment = Smobiler.Core.Controls.VerticalAlignment.Top;
            // 
            // panel2
            // 
            this.panel2.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnUploadVoice,
            this.btnDownloadSpeechConfig});
            this.panel2.Direction = Smobiler.Core.Controls.LayoutDirection.Row;
            this.panel2.JustifyAlign = Smobiler.Core.Controls.LayoutJustifyAlign.SpaceAround;
            this.panel2.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.panel2.Name = "panel2";
            this.panel2.Padding = new Smobiler.Core.Controls.Padding(0F, 3F, 0F, 3F);
            this.panel2.Size = new System.Drawing.Size(0, 40);
            // 
            // btnUploadVoice
            // 
            this.btnUploadVoice.Name = "btnUploadVoice";
            this.btnUploadVoice.Size = new System.Drawing.Size(100, 0);
            this.btnUploadVoice.Text = "语音训练";
            this.btnUploadVoice.Press += new System.EventHandler(this.btnUploadVoice_Press);
            // 
            // btnDownloadSpeechConfig
            // 
            this.btnDownloadSpeechConfig.Name = "btnDownloadSpeechConfig";
            this.btnDownloadSpeechConfig.Size = new System.Drawing.Size(100, 0);
            this.btnDownloadSpeechConfig.Text = "下载配置";
            this.btnDownloadSpeechConfig.Press += new System.EventHandler(this.btnDownloadSpeechConfig_Press);
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "Speech";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // demoSpeech
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.speech1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel1,
            this.label1,
            this.panel2});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Name = "demoSpeech";

        }
        #endregion

        private Smobiler.AI.Speech speech1;
        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Button btnStart;
        private Smobiler.Core.Controls.Button btnStartContinuously;
        private Smobiler.Core.Controls.Button btnPause;
        private Smobiler.Core.Controls.Button btnStop;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Button btnInit;
        private Smobiler.Core.Controls.Panel panel2;
        private Smobiler.Core.Controls.Button btnUploadVoice;
        private Smobiler.Core.Controls.Button btnDownloadSpeechConfig;
        private Core.Controls.Title title1;
    }
}