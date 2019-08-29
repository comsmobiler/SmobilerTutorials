using Smobiler.Core;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoCN6508 : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm Designer generated code "

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
            this.title = new Smobiler.Core.Controls.Label();
            this.btnGetBarcode = new Smobiler.Core.Controls.Button();
            this.btnSetScanModel = new Smobiler.Core.Controls.Button();
            this.btnSetScanDelaySetting = new Smobiler.Core.Controls.Button();
            this.btnSetScanSound = new Smobiler.Core.Controls.Button();
            this.btnsetScanVibrate = new Smobiler.Core.Controls.Button();
            this.spinner1 = new Smobiler.Core.Controls.Spinner();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.spinner2 = new Smobiler.Core.Controls.Spinner();
            this.spinner3 = new Smobiler.Core.Controls.Spinner();
            this.spinner4 = new Smobiler.Core.Controls.Spinner();
            this.btnshow = new Smobiler.Core.Controls.Button();
            this.cN65081 = new Smobiler.Plugins.CN6508();
            this.label2 = new Smobiler.Core.Controls.Label();
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(0, 8);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(300, 35);
            this.title.Text = "扫码功能";
            // 
            // btnGetBarcode
            // 
            this.btnGetBarcode.Location = new System.Drawing.Point(184, 43);
            this.btnGetBarcode.Name = "btnGetBarcode";
            this.btnGetBarcode.Size = new System.Drawing.Size(116, 53);
            this.btnGetBarcode.Text = "扫码";
            this.btnGetBarcode.Press += new System.EventHandler(this.btnGetBarcode_Press);
            // 
            // btnSetScanModel
            // 
            this.btnSetScanModel.Location = new System.Drawing.Point(182, 150);
            this.btnSetScanModel.Name = "btnSetScanModel";
            this.btnSetScanModel.Size = new System.Drawing.Size(100, 30);
            this.btnSetScanModel.Text = "设置扫描模式";
            this.btnSetScanModel.Press += new System.EventHandler(this.btnSetScanModel_Press);
            // 
            // btnSetScanDelaySetting
            // 
            this.btnSetScanDelaySetting.Location = new System.Drawing.Point(182, 200);
            this.btnSetScanDelaySetting.Name = "btnSetScanDelaySetting";
            this.btnSetScanDelaySetting.Size = new System.Drawing.Size(100, 30);
            this.btnSetScanDelaySetting.Text = "设置连扫间隔";
            this.btnSetScanDelaySetting.Press += new System.EventHandler(this.btnSetScanDelaySetting_Press);
            // 
            // btnSetScanSound
            // 
            this.btnSetScanSound.Location = new System.Drawing.Point(182, 254);
            this.btnSetScanSound.Name = "btnSetScanSound";
            this.btnSetScanSound.Size = new System.Drawing.Size(100, 30);
            this.btnSetScanSound.Text = "设置扫描声音";
            this.btnSetScanSound.Press += new System.EventHandler(this.btnSetScanSound_Press);
            // 
            // btnsetScanVibrate
            // 
            this.btnsetScanVibrate.Location = new System.Drawing.Point(182, 310);
            this.btnsetScanVibrate.Name = "btnsetScanVibrate";
            this.btnsetScanVibrate.Size = new System.Drawing.Size(100, 30);
            this.btnsetScanVibrate.Text = "设置扫描震动";
            this.btnsetScanVibrate.Press += new System.EventHandler(this.btnsetScanVibrate_Press);
            // 
            // spinner1
            // 
            this.spinner1.Items = new string[] {
        "Ordinary:普通",
        "AutoContinuous:连续扫描(自动)",
        "ManualContinuous:连续扫描(手动:按下不松开连续扫描，松开停止)"};
            this.spinner1.Location = new System.Drawing.Point(14, 150);
            this.spinner1.Name = "spinner1";
            this.spinner1.Size = new System.Drawing.Size(136, 30);
            this.spinner1.Text = "选择扫描模式";
            this.spinner1.ItemSelected += new System.EventHandler<Smobiler.Core.Controls.SpinnerItemSelectedEventArgs>(this.spinner1_ItemSelected);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 63);
            this.label1.Text = "点击按钮开启扫描，亦可使用设备两侧按钮开启扫描";
            // 
            // spinner2
            // 
            this.spinner2.Items = new string[] {
        "Time_0:间隔0",
        "Time_500:间隔500ms",
        "Time_1000:间隔1000ms"};
            this.spinner2.Location = new System.Drawing.Point(14, 200);
            this.spinner2.Name = "spinner2";
            this.spinner2.Size = new System.Drawing.Size(136, 30);
            this.spinner2.Text = "选择连扫间隔";
            this.spinner2.ItemSelected += new System.EventHandler<Smobiler.Core.Controls.SpinnerItemSelectedEventArgs>(this.spinner2_ItemSelected);
            // 
            // spinner3
            // 
            this.spinner3.Items = new string[] {
        "true",
        "false"};
            this.spinner3.Location = new System.Drawing.Point(14, 254);
            this.spinner3.Name = "spinner3";
            this.spinner3.Size = new System.Drawing.Size(136, 30);
            this.spinner3.Text = "是否开启声音";
            this.spinner3.ItemSelected += new System.EventHandler<Smobiler.Core.Controls.SpinnerItemSelectedEventArgs>(this.spinner3_ItemSelected);
            // 
            // spinner4
            // 
            this.spinner4.Items = new string[] {
        "true",
        "false"};
            this.spinner4.Location = new System.Drawing.Point(14, 310);
            this.spinner4.Name = "spinner4";
            this.spinner4.Size = new System.Drawing.Size(136, 30);
            this.spinner4.Text = "是否开启震动";
            this.spinner4.ItemSelected += new System.EventHandler<Smobiler.Core.Controls.SpinnerItemSelectedEventArgs>(this.spinner4_ItemSelected);
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(52, 420);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(196, 30);
            this.btnshow.Text = "跳转打印";
            this.btnshow.Press += new System.EventHandler(this.btnshow_Press);
            // 
            // cN65081
            // 
            this.cN65081.Name = "cN65081";
            this.cN65081.BarcodeDataCaptured += new Smobiler.Plugins.CN6508BarcodeScanEventHandler(this.cN65081_BarcodeDataCaptured);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(52, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 35);
            this.label2.Text = "“设置扫描模式”仅对侧边按钮生效";
            // 
            // demoCN6508
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.cN65081});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title,
            this.btnGetBarcode,
            this.btnSetScanModel,
            this.btnSetScanDelaySetting,
            this.btnSetScanSound,
            this.btnsetScanVibrate,
            this.spinner1,
            this.label1,
            this.spinner2,
            this.spinner3,
            this.spinner4,
            this.btnshow,
            this.label2});
            this.Name = "demoCN6508";

        }
        #endregion

        private Smobiler.Core.Controls.Label title;
        private Smobiler.Core.Controls.Button btnGetBarcode;
        private Smobiler.Core.Controls.Button btnSetScanModel;
        private Smobiler.Core.Controls.Button btnSetScanDelaySetting;
        private Smobiler.Core.Controls.Button btnSetScanSound;
        private Smobiler.Core.Controls.Button btnsetScanVibrate;
        private Smobiler.Core.Controls.Spinner spinner1;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Spinner spinner2;
        private Smobiler.Core.Controls.Spinner spinner3;
        private Smobiler.Core.Controls.Spinner spinner4;
        private Smobiler.Core.Controls.Button btnshow;
        private Smobiler.Plugins.CN6508 cN65081;
        private Smobiler.Core.Controls.Label label2;
    }
}