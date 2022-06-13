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
            this.btnSearchBle = new Smobiler.Core.Controls.Button();
            this.btnConnectBle = new Smobiler.Core.Controls.Button();
            this.btnCloseConnectBle = new Smobiler.Core.Controls.Button();
            this.btnWriteBleMessage = new Smobiler.Core.Controls.Button();
            this.btnGetBleStatus = new Smobiler.Core.Controls.Button();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.button1 = new Smobiler.Core.Controls.Button();
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
            this.btnopen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(80)))));
            this.btnopen.Location = new System.Drawing.Point(0, 48);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(144, 38);
            this.btnopen.Text = "Open";
            this.btnopen.Press += new System.EventHandler(this.btnopen_Press);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(229)))), ((int)(((byte)(100)))));
            this.btnClose.Location = new System.Drawing.Point(0, 102);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(144, 38);
            this.btnClose.Text = "Close";
            this.btnClose.Press += new System.EventHandler(this.btnClose_Press);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(67)))), ((int)(((byte)(80)))));
            this.btnSearch.Location = new System.Drawing.Point(0, 166);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(144, 38);
            this.btnSearch.Text = "Search";
            this.btnSearch.Press += new System.EventHandler(this.btnSearch_Press);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(67)))), ((int)(((byte)(80)))));
            this.btnConnect.Location = new System.Drawing.Point(0, 216);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(144, 38);
            this.btnConnect.Text = "Connect";
            this.btnConnect.Press += new System.EventHandler(this.btnConnect_Press);
            // 
            // btnCloseConnect
            // 
            this.btnCloseConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(67)))), ((int)(((byte)(80)))));
            this.btnCloseConnect.Location = new System.Drawing.Point(0, 280);
            this.btnCloseConnect.Name = "btnCloseConnect";
            this.btnCloseConnect.Size = new System.Drawing.Size(144, 38);
            this.btnCloseConnect.Text = "CloseConnect";
            this.btnCloseConnect.Press += new System.EventHandler(this.btnCloseConnect_Press);
            // 
            // btnWriteMessage
            // 
            this.btnWriteMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(67)))), ((int)(((byte)(80)))));
            this.btnWriteMessage.Location = new System.Drawing.Point(0, 332);
            this.btnWriteMessage.Name = "btnWriteMessage";
            this.btnWriteMessage.Size = new System.Drawing.Size(144, 38);
            this.btnWriteMessage.Text = "WriteMessage";
            this.btnWriteMessage.Press += new System.EventHandler(this.btnWriteMessage_Press);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(132, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 35);
            // 
            // btnGetStatus
            // 
            this.btnGetStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(67)))), ((int)(((byte)(80)))));
            this.btnGetStatus.Location = new System.Drawing.Point(0, 387);
            this.btnGetStatus.Name = "btnGetStatus";
            this.btnGetStatus.Size = new System.Drawing.Size(144, 36);
            this.btnGetStatus.Text = "GetStatus";
            this.btnGetStatus.Press += new System.EventHandler(this.btnGetStatus_Press);
            // 
            // label2
            // 
            this.label2.FontSize = 14F;
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
            // btnSearchBle
            // 
            this.btnSearchBle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(176)))), ((int)(((byte)(250)))));
            this.btnSearchBle.Location = new System.Drawing.Point(156, 166);
            this.btnSearchBle.Name = "btnSearchBle";
            this.btnSearchBle.Size = new System.Drawing.Size(144, 38);
            this.btnSearchBle.Text = "SearchBle";
            this.btnSearchBle.Press += new System.EventHandler(this.btnSearchBle_Press);
            // 
            // btnConnectBle
            // 
            this.btnConnectBle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(176)))), ((int)(((byte)(250)))));
            this.btnConnectBle.Location = new System.Drawing.Point(156, 216);
            this.btnConnectBle.Name = "btnConnectBle";
            this.btnConnectBle.Size = new System.Drawing.Size(144, 38);
            this.btnConnectBle.Text = "ConnectBle";
            this.btnConnectBle.Press += new System.EventHandler(this.btnConnectBle_Press);
            // 
            // btnCloseConnectBle
            // 
            this.btnCloseConnectBle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(176)))), ((int)(((byte)(250)))));
            this.btnCloseConnectBle.Location = new System.Drawing.Point(156, 280);
            this.btnCloseConnectBle.Name = "btnCloseConnectBle";
            this.btnCloseConnectBle.Size = new System.Drawing.Size(144, 38);
            this.btnCloseConnectBle.Text = "CloseConnectBle";
            this.btnCloseConnectBle.Press += new System.EventHandler(this.btnCloseConnectBle_Press);
            // 
            // btnWriteBleMessage
            // 
            this.btnWriteBleMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(176)))), ((int)(((byte)(250)))));
            this.btnWriteBleMessage.Location = new System.Drawing.Point(156, 332);
            this.btnWriteBleMessage.Name = "btnWriteBleMessage";
            this.btnWriteBleMessage.Size = new System.Drawing.Size(144, 38);
            this.btnWriteBleMessage.Text = "WriteBleMessage";
            this.btnWriteBleMessage.Press += new System.EventHandler(this.btnWriteBleMessage_Press);
            // 
            // btnGetBleStatus
            // 
            this.btnGetBleStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(176)))), ((int)(((byte)(250)))));
            this.btnGetBleStatus.Location = new System.Drawing.Point(156, 387);
            this.btnGetBleStatus.Name = "btnGetBleStatus";
            this.btnGetBleStatus.Size = new System.Drawing.Size(144, 36);
            this.btnGetBleStatus.Text = "GetBleStatus";
            this.btnGetBleStatus.Press += new System.EventHandler(this.btnGetBleStatus_Press);
            // 
            // label3
            // 
            this.label3.FontSize = 14F;
            this.label3.Location = new System.Drawing.Point(164, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 92);
            this.label3.Text = "使用Ble蓝牙通讯需填写相应的uuid\r\n连接返回true不等于连接上,仍需要GetStatus判断连接状态";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 35);
            this.button1.Text = "ConnectWithSearch";
            this.button1.Press += new System.EventHandler(this.button1_Press);
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
            this.label2,
            this.btnSearchBle,
            this.btnConnectBle,
            this.btnCloseConnectBle,
            this.btnWriteBleMessage,
            this.btnGetBleStatus,
            this.label3,
            this.button1});
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
        private Core.Controls.Button btnSearchBle;
        private Core.Controls.Button btnConnectBle;
        private Core.Controls.Button btnCloseConnectBle;
        private Core.Controls.Button btnWriteBleMessage;
        private Core.Controls.Button btnGetBleStatus;
        private Core.Controls.Label label3;
        private Core.Controls.Button button1;
    }
}