using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Plugins
{
    partial class demoBluetooth : Smobiler.Core.Controls.MobileForm
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
            this.btnopen = new Smobiler.Core.Controls.Button();
            this.btnClose = new Smobiler.Core.Controls.Button();
            this.btnSearch = new Smobiler.Core.Controls.Button();
            this.btnConnect = new Smobiler.Core.Controls.Button();
            this.btnCloseConnect = new Smobiler.Core.Controls.Button();
            this.btnWriteMessage = new Smobiler.Core.Controls.Button();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.btnGetStatus = new Smobiler.Core.Controls.Button();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.bluetooth1 = new Smobiler.Plugins.Bluetooth();
            this.timer1 = new Smobiler.Core.Controls.Timer();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "Bluetooth";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // btnopen
            // 
            this.btnopen.Location = new System.Drawing.Point(66, 42);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(168, 44);
            this.btnopen.Text = "Open";
            this.btnopen.Press += new System.EventHandler(this.btnopen_Press);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(66, 96);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(168, 44);
            this.btnClose.Text = "Close";
            this.btnClose.Press += new System.EventHandler(this.btnClose_Press);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(66, 160);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(168, 44);
            this.btnSearch.Text = "Search";
            this.btnSearch.Press += new System.EventHandler(this.btnSearch_Press);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(66, 210);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(168, 44);
            this.btnConnect.Text = "Connect";
            this.btnConnect.Press += new System.EventHandler(this.btnConnect_Press);
            // 
            // btnCloseConnect
            // 
            this.btnCloseConnect.Location = new System.Drawing.Point(66, 274);
            this.btnCloseConnect.Name = "btnCloseConnect";
            this.btnCloseConnect.Size = new System.Drawing.Size(168, 44);
            this.btnCloseConnect.Text = "CloseConnect";
            this.btnCloseConnect.Press += new System.EventHandler(this.btnCloseConnect_Press);
            // 
            // btnWriteMessage
            // 
            this.btnWriteMessage.Location = new System.Drawing.Point(66, 326);
            this.btnWriteMessage.Name = "btnWriteMessage";
            this.btnWriteMessage.Size = new System.Drawing.Size(168, 44);
            this.btnWriteMessage.Text = "WriteMessage";
            this.btnWriteMessage.Press += new System.EventHandler(this.btnWriteMessage_Press);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(132, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 35);
            // 
            // btnGetStatus
            // 
            this.btnGetStatus.Location = new System.Drawing.Point(66, 393);
            this.btnGetStatus.Name = "btnGetStatus";
            this.btnGetStatus.Size = new System.Drawing.Size(168, 30);
            this.btnGetStatus.Text = "GetStatus";
            this.btnGetStatus.Press += new System.EventHandler(this.btnGetStatus_Press);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 35);
            this.label2.Text = "连接状态：";
            // 
            // bluetooth1
            // 
            this.bluetooth1.Name = "bluetooth1";
            this.bluetooth1.DataReceived += new Smobiler.Plugins.BluetoothDataReceivedEventHandler(this.bluetooth1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Name = "timer1";
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // demoBluetooth
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.bluetooth1,
            this.timer1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.btnopen,
            this.btnClose,
            this.btnSearch,
            this.btnConnect,
            this.btnCloseConnect,
            this.btnWriteMessage,
            this.label1,
            this.btnGetStatus,
            this.label2});
            this.Load += new System.EventHandler(this.demoBluetooth_Load);
            this.Name = "demoBluetooth";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Button btnopen;
        private Core.Controls.Button btnClose;
        private Core.Controls.Button btnSearch;
        private Core.Controls.Button btnConnect;
        private Core.Controls.Button btnCloseConnect;
        private Core.Controls.Button btnWriteMessage;
        private Core.Controls.Label label1;
        private Core.Controls.Button btnGetStatus;
        private Core.Controls.Label label2;
        private Smobiler.Plugins.Bluetooth bluetooth1;
        private Core.Controls.Timer timer1;
    }
}