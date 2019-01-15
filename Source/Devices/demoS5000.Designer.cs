using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Devices
{
    partial class demoS5000 : Smobiler.Core.Controls.MobileForm
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
            this.label3 = new Smobiler.Core.Controls.Label();
            this.s5000Scanner1 = new Smobiler.Device.S5000Scanner();
            this.btnopen = new Smobiler.Core.Controls.Button();
            this.btnclose = new Smobiler.Core.Controls.Button();
            this.btnstart = new Smobiler.Core.Controls.Button();
            this.btnstop = new Smobiler.Core.Controls.Button();
            this.btnEnableTrigger = new Smobiler.Core.Controls.Button();
            this.btnDisableTrigger = new Smobiler.Core.Controls.Button();
            this.btnsearchcard = new Smobiler.Core.Controls.Button();
            this.btnreadcarddara = new Smobiler.Core.Controls.Button();
            this.btnwritecarddata = new Smobiler.Core.Controls.Button();
            this.image1 = new Smobiler.Core.Controls.Image();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "S5000";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 59);
            this.label3.Text = "使用S5000Scanner插件，需要使用S5000硬件\r\n";
            // 
            // s5000Scanner1
            // 
            this.s5000Scanner1.Name = "s5000Scanner1";
            this.s5000Scanner1.DataCaptured += new Smobiler.Device.S5000ScannerScanEventHandler(this.s5000Scanner1_DataCaptured);
            this.s5000Scanner1.M1CardDataCaptured += new Smobiler.Device.S5000ScannerM1CardEventHandler(this.s5000Scanner1_M1CardDataCaptured);
            this.s5000Scanner1.OnNotify += new Smobiler.Device.S5000ScannerOnNotifyEventHandler(this.s5000Scanner1_OnNotify);
            this.s5000Scanner1.KeyDown += new Smobiler.Device.S5000ScannerButtonEventHandler(this.s5000Scanner1_KeyDown);
            // 
            // btnopen
            // 
            this.btnopen.Location = new System.Drawing.Point(0, 97);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(142, 30);
            this.btnopen.Text = "open";
            this.btnopen.Press += new System.EventHandler(this.btnopen_Press);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(152, 97);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(142, 30);
            this.btnclose.Text = "close";
            this.btnclose.Press += new System.EventHandler(this.btnclose_Press);
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(0, 143);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(142, 30);
            this.btnstart.Text = "start";
            this.btnstart.Press += new System.EventHandler(this.btnstart_Press);
            // 
            // btnstop
            // 
            this.btnstop.Location = new System.Drawing.Point(152, 149);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(142, 30);
            this.btnstop.Text = "stop";
            this.btnstop.Press += new System.EventHandler(this.btnstop_Press);
            // 
            // btnEnableTrigger
            // 
            this.btnEnableTrigger.Location = new System.Drawing.Point(0, 191);
            this.btnEnableTrigger.Name = "btnEnableTrigger";
            this.btnEnableTrigger.Size = new System.Drawing.Size(142, 28);
            this.btnEnableTrigger.Text = "EnableTrigger";
            this.btnEnableTrigger.Press += new System.EventHandler(this.btnEnableTrigger_Press);
            // 
            // btnDisableTrigger
            // 
            this.btnDisableTrigger.Location = new System.Drawing.Point(152, 189);
            this.btnDisableTrigger.Name = "btnDisableTrigger";
            this.btnDisableTrigger.Size = new System.Drawing.Size(142, 30);
            this.btnDisableTrigger.Text = "DisableTrigger";
            this.btnDisableTrigger.Press += new System.EventHandler(this.btnDisableTrigger_Press);
            // 
            // btnsearchcard
            // 
            this.btnsearchcard.Location = new System.Drawing.Point(0, 231);
            this.btnsearchcard.Name = "btnsearchcard";
            this.btnsearchcard.Size = new System.Drawing.Size(142, 30);
            this.btnsearchcard.Text = "searchcard";
            this.btnsearchcard.Press += new System.EventHandler(this.btnsearchcard_Press);
            // 
            // btnreadcarddara
            // 
            this.btnreadcarddara.Location = new System.Drawing.Point(0, 275);
            this.btnreadcarddara.Name = "btnreadcarddara";
            this.btnreadcarddara.Size = new System.Drawing.Size(142, 30);
            this.btnreadcarddara.Text = "readcarddara";
            this.btnreadcarddara.Press += new System.EventHandler(this.btnreadcarddara_Press);
            // 
            // btnwritecarddata
            // 
            this.btnwritecarddata.Location = new System.Drawing.Point(0, 319);
            this.btnwritecarddata.Name = "btnwritecarddata";
            this.btnwritecarddata.Size = new System.Drawing.Size(142, 30);
            this.btnwritecarddata.Text = "writecarddata";
            this.btnwritecarddata.Press += new System.EventHandler(this.btnwritecarddata_Press);
            // 
            // image1
            // 
            this.image1.Location = new System.Drawing.Point(184, 261);
            this.image1.Name = "image1";
            this.image1.ResourceMode = Smobiler.Core.Controls.ResourceMode.Data;
            this.image1.Size = new System.Drawing.Size(91, 68);
            // 
            // demoS5000
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.s5000Scanner1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.label3,
            this.btnopen,
            this.btnclose,
            this.btnstart,
            this.btnstop,
            this.btnEnableTrigger,
            this.btnDisableTrigger,
            this.btnsearchcard,
            this.btnreadcarddara,
            this.btnwritecarddata,
            this.image1});
            this.Load += new System.EventHandler(this.demoS5000_Load);
            this.Name = "demoS5000";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Label label3;
        private Device.S5000Scanner s5000Scanner1;
        private Core.Controls.Button btnopen;
        private Core.Controls.Button btnclose;
        private Core.Controls.Button btnstart;
        private Core.Controls.Button btnstop;
        private Core.Controls.Button btnEnableTrigger;
        private Core.Controls.Button btnDisableTrigger;
        private Core.Controls.Button btnsearchcard;
        private Core.Controls.Button btnreadcarddara;
        private Core.Controls.Button btnwritecarddata;
        private Core.Controls.Image image1;
    }
}