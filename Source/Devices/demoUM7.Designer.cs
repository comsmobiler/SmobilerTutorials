using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Devices
{
    partial class demoUM7 : Smobiler.Core.Controls.MobileForm
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
            this.btnEnableTrigger = new Smobiler.Core.Controls.Button();
            this.btnDisableTrigger = new Smobiler.Core.Controls.Button();
            this.btnRFIDscan = new Smobiler.Core.Controls.Button();
            this.btnRFIDscanstop = new Smobiler.Core.Controls.Button();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.btnsetRfidPower = new Smobiler.Core.Controls.Button();
            this.textBox1 = new Smobiler.Core.Controls.TextBox();
            this.btnBindKeyDown = new Smobiler.Core.Controls.Button();
            this.btnUnbindKeyDown = new Smobiler.Core.Controls.Button();
            this.btnRFIDType = new Smobiler.Core.Controls.Button();
            this.btnClearNumRfid = new Smobiler.Core.Controls.Button();
            this.btngetRfidPower = new Smobiler.Core.Controls.Button();
            this.btnrestartRfid = new Smobiler.Core.Controls.Button();
            this.uM7Scanner1 = new Smobiler.Device.UM7Scanner();
            // 
            // btnEnableTrigger
            // 
            this.btnEnableTrigger.Location = new System.Drawing.Point(32, 286);
            this.btnEnableTrigger.Name = "btnEnableTrigger";
            this.btnEnableTrigger.Size = new System.Drawing.Size(100, 30);
            this.btnEnableTrigger.Text = "启用扫描键";
            this.btnEnableTrigger.Press += new System.EventHandler(this.btnEnableTrigger_Press);
            // 
            // btnDisableTrigger
            // 
            this.btnDisableTrigger.Location = new System.Drawing.Point(32, 329);
            this.btnDisableTrigger.Name = "btnDisableTrigger";
            this.btnDisableTrigger.Size = new System.Drawing.Size(100, 30);
            this.btnDisableTrigger.Text = "禁用扫描键";
            this.btnDisableTrigger.Press += new System.EventHandler(this.btnDisableTrigger_Press);
            // 
            // btnRFIDscan
            // 
            this.btnRFIDscan.Location = new System.Drawing.Point(167, 135);
            this.btnRFIDscan.Name = "btnRFIDscan";
            this.btnRFIDscan.Size = new System.Drawing.Size(100, 30);
            this.btnRFIDscan.Text = "RFID扫描";
            this.btnRFIDscan.Press += new System.EventHandler(this.btnRFIDscan_Press);
            // 
            // btnRFIDscanstop
            // 
            this.btnRFIDscanstop.Location = new System.Drawing.Point(167, 186);
            this.btnRFIDscanstop.Name = "btnRFIDscanstop";
            this.btnRFIDscanstop.Size = new System.Drawing.Size(100, 30);
            this.btnRFIDscanstop.Text = "关闭RFID扫描";
            this.btnRFIDscanstop.Press += new System.EventHandler(this.btnRFIDscanstop_Press);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(32, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 35);
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(32, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 35);
            this.label2.Text = "label2";
            // 
            // btnsetRfidPower
            // 
            this.btnsetRfidPower.Location = new System.Drawing.Point(167, 376);
            this.btnsetRfidPower.Name = "btnsetRfidPower";
            this.btnsetRfidPower.Size = new System.Drawing.Size(100, 30);
            this.btnsetRfidPower.Text = "设置读标签功率";
            this.btnsetRfidPower.Press += new System.EventHandler(this.btnsetRfidPower_Press);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 371);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 35);
            this.textBox1.WaterMarkText = "设置标签读写功率";
            // 
            // btnBindKeyDown
            // 
            this.btnBindKeyDown.Location = new System.Drawing.Point(167, 286);
            this.btnBindKeyDown.Name = "btnBindKeyDown";
            this.btnBindKeyDown.Size = new System.Drawing.Size(100, 30);
            this.btnBindKeyDown.Text = "扫描键自定义";
            this.btnBindKeyDown.Press += new System.EventHandler(this.btnBindKeyDown_Press);
            // 
            // btnUnbindKeyDown
            // 
            this.btnUnbindKeyDown.Location = new System.Drawing.Point(167, 329);
            this.btnUnbindKeyDown.Name = "btnUnbindKeyDown";
            this.btnUnbindKeyDown.Size = new System.Drawing.Size(100, 30);
            this.btnUnbindKeyDown.Text = "扫描键不自定义";
            this.btnUnbindKeyDown.Press += new System.EventHandler(this.btnUnbindKeyDown_Press);
            // 
            // btnRFIDType
            // 
            this.btnRFIDType.Location = new System.Drawing.Point(167, 239);
            this.btnRFIDType.Name = "btnRFIDType";
            this.btnRFIDType.Size = new System.Drawing.Size(100, 30);
            this.btnRFIDType.Text = "RFIDType";
            this.btnRFIDType.Press += new System.EventHandler(this.btnRFIDType_Press);
            // 
            // btnClearNumRfid
            // 
            this.btnClearNumRfid.Location = new System.Drawing.Point(32, 422);
            this.btnClearNumRfid.Name = "btnClearNumRfid";
            this.btnClearNumRfid.Size = new System.Drawing.Size(100, 30);
            this.btnClearNumRfid.Text = "ClearNumRfid";
            this.btnClearNumRfid.Press += new System.EventHandler(this.button1_Press);
            // 
            // btngetRfidPower
            // 
            this.btngetRfidPower.Location = new System.Drawing.Point(167, 422);
            this.btngetRfidPower.Name = "btngetRfidPower";
            this.btngetRfidPower.Size = new System.Drawing.Size(100, 30);
            this.btngetRfidPower.Text = "获取功率";
            this.btngetRfidPower.Press += new System.EventHandler(this.btngetRfidPower_Press);
            // 
            // btnrestartRfid
            // 
            this.btnrestartRfid.Location = new System.Drawing.Point(32, 135);
            this.btnrestartRfid.Name = "btnrestartRfid";
            this.btnrestartRfid.Size = new System.Drawing.Size(100, 30);
            this.btnrestartRfid.Text = "restartRfid";
            this.btnrestartRfid.Press += new System.EventHandler(this.btnrestartRfid_Press);
            // 
            // uM7Scanner1
            // 
            this.uM7Scanner1.Name = "uM7Scanner1";
            this.uM7Scanner1.RFIDDataCaptured += new Smobiler.Device.UM7RFIDScanEventHandler(this.uM7Scanner1_RFIDDataCaptured);
            this.uM7Scanner1.OnNotify += new Smobiler.Device.UM7ScannerOnNotifyEventHandler(this.uM7Scanner1_OnNotify);
            this.uM7Scanner1.KeyDown += new Smobiler.Device.UM7ButtonEventHandler(this.uM7Scanner1_KeyDown);
            // 
            // demoUM7
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.uM7Scanner1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnEnableTrigger,
            this.btnDisableTrigger,
            this.btnRFIDscan,
            this.btnRFIDscanstop,
            this.label1,
            this.label2,
            this.btnsetRfidPower,
            this.textBox1,
            this.btnBindKeyDown,
            this.btnUnbindKeyDown,
            this.btnRFIDType,
            this.btnClearNumRfid,
            this.btngetRfidPower,
            this.btnrestartRfid});
            this.Name = "demoUM7";

        }
        #endregion

        private Core.Controls.Button btnEnableTrigger;
        private Core.Controls.Button btnDisableTrigger;
        private Core.Controls.Button btnRFIDscan;
        private Core.Controls.Button btnRFIDscanstop;
        private Core.Controls.Label label1;
        private Core.Controls.Label label2;
        private Core.Controls.Button btnsetRfidPower;
        private Core.Controls.TextBox textBox1;
        private Core.Controls.Button btnBindKeyDown;
        private Core.Controls.Button btnUnbindKeyDown;
        private Core.Controls.Button btnRFIDType;
        private Core.Controls.Button btnClearNumRfid;
        private Core.Controls.Button btngetRfidPower;
        private Core.Controls.Button btnrestartRfid;
        private Device.UM7Scanner uM7Scanner1;
    }
}