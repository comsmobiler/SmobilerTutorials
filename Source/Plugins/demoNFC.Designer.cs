using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Plugins
{
    partial class demoNFC : Smobiler.Core.Controls.MobileForm
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
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.btnstart = new Smobiler.Core.Controls.Button();
            this.btnissupported = new Smobiler.Core.Controls.Button();
            this.btnregisterTagEvent = new Smobiler.Core.Controls.Button();
            this.btnunregisterTagEvent = new Smobiler.Core.Controls.Button();
            this.btngoToNfcSetting = new Smobiler.Core.Controls.Button();
            this.btngetLaunchTagEvent = new Smobiler.Core.Controls.Button();
            this.btnIsEnabled = new Smobiler.Core.Controls.Button();
            this.btnmifareUltralightReadPages = new Smobiler.Core.Controls.Button();
            this.btnrequestTechnology = new Smobiler.Core.Controls.Button();
            this.btncancelTechnologyRequest = new Smobiler.Core.Controls.Button();
            this.btncloseTechnology = new Smobiler.Core.Controls.Button();
            this.btngetTag = new Smobiler.Core.Controls.Button();
            this.btngetCachedNdefMessage = new Smobiler.Core.Controls.Button();
            this.btngetNdefMessage = new Smobiler.Core.Controls.Button();
            this.btnwriteNdefMessage = new Smobiler.Core.Controls.Button();
            this.btnMifareClassicReadBlock = new Smobiler.Core.Controls.Button();
            this.btnMifareClassicReadSector = new Smobiler.Core.Controls.Button();
            this.textBox1 = new Smobiler.Core.Controls.TextBox();
            this.textBox2 = new Smobiler.Core.Controls.TextBox();
            this.btnMifareClassicWriteBlock = new Smobiler.Core.Controls.Button();
            this.btnmifareClassicGetSectorCount = new Smobiler.Core.Controls.Button();
            this.nfc1 = new Smobiler.Plugins.NFC();
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnstart,
            this.btnissupported,
            this.btnregisterTagEvent,
            this.btnunregisterTagEvent,
            this.btngoToNfcSetting,
            this.btngetLaunchTagEvent,
            this.btnIsEnabled,
            this.btnmifareUltralightReadPages,
            this.btnrequestTechnology,
            this.btncancelTechnologyRequest,
            this.btncloseTechnology,
            this.btngetTag,
            this.btngetCachedNdefMessage,
            this.btngetNdefMessage,
            this.btnwriteNdefMessage,
            this.btnMifareClassicReadBlock,
            this.btnMifareClassicReadSector,
            this.textBox1,
            this.textBox2,
            this.btnMifareClassicWriteBlock,
            this.btnmifareClassicGetSectorCount});
            this.panel1.Flex = 1;
            this.panel1.Name = "panel1";
            this.panel1.Scrollable = true;
            this.panel1.Size = new System.Drawing.Size(300, 500);
            // 
            // btnstart
            // 
            this.btnstart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(80)))));
            this.btnstart.Location = new System.Drawing.Point(19, 8);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(100, 30);
            this.btnstart.Text = "start";
            this.btnstart.Press += new System.EventHandler(this.btnstart_Press);
            // 
            // btnissupported
            // 
            this.btnissupported.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(67)))), ((int)(((byte)(80)))));
            this.btnissupported.Location = new System.Drawing.Point(19, 62);
            this.btnissupported.Name = "btnissupported";
            this.btnissupported.Size = new System.Drawing.Size(100, 30);
            this.btnissupported.Text = "isSupported";
            this.btnissupported.Press += new System.EventHandler(this.btnissupported_Press);
            // 
            // btnregisterTagEvent
            // 
            this.btnregisterTagEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(229)))), ((int)(((byte)(100)))));
            this.btnregisterTagEvent.Location = new System.Drawing.Point(19, 121);
            this.btnregisterTagEvent.Name = "btnregisterTagEvent";
            this.btnregisterTagEvent.Size = new System.Drawing.Size(100, 30);
            this.btnregisterTagEvent.Text = "registerTagEvent";
            this.btnregisterTagEvent.Press += new System.EventHandler(this.btnregisterTagEvent_Press);
            // 
            // btnunregisterTagEvent
            // 
            this.btnunregisterTagEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(229)))), ((int)(((byte)(100)))));
            this.btnunregisterTagEvent.Location = new System.Drawing.Point(19, 174);
            this.btnunregisterTagEvent.Name = "btnunregisterTagEvent";
            this.btnunregisterTagEvent.Size = new System.Drawing.Size(107, 30);
            this.btnunregisterTagEvent.Text = "unregisterTagEvent";
            this.btnunregisterTagEvent.Press += new System.EventHandler(this.btnunregisterTagEvent_Press);
            // 
            // btngoToNfcSetting
            // 
            this.btngoToNfcSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(80)))));
            this.btngoToNfcSetting.Location = new System.Drawing.Point(19, 224);
            this.btngoToNfcSetting.Name = "btngoToNfcSetting";
            this.btngoToNfcSetting.Size = new System.Drawing.Size(100, 30);
            this.btngoToNfcSetting.Text = "goToNfcSetting";
            this.btngoToNfcSetting.Press += new System.EventHandler(this.btngoToNfcSetting_Press);
            // 
            // btngetLaunchTagEvent
            // 
            this.btngetLaunchTagEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(176)))), ((int)(((byte)(250)))));
            this.btngetLaunchTagEvent.Location = new System.Drawing.Point(19, 274);
            this.btngetLaunchTagEvent.Name = "btngetLaunchTagEvent";
            this.btngetLaunchTagEvent.Size = new System.Drawing.Size(100, 30);
            this.btngetLaunchTagEvent.Text = "getLaunchTagEvent";
            this.btngetLaunchTagEvent.Press += new System.EventHandler(this.btngetLaunchTagEvent_Press);
            // 
            // btnIsEnabled
            // 
            this.btnIsEnabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(67)))), ((int)(((byte)(80)))));
            this.btnIsEnabled.Location = new System.Drawing.Point(19, 320);
            this.btnIsEnabled.Name = "btnIsEnabled";
            this.btnIsEnabled.Size = new System.Drawing.Size(100, 30);
            this.btnIsEnabled.Text = "IsEnabled";
            this.btnIsEnabled.Press += new System.EventHandler(this.btnIsEnabled_Press);
            // 
            // btnmifareUltralightReadPages
            // 
            this.btnmifareUltralightReadPages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(176)))), ((int)(((byte)(250)))));
            this.btnmifareUltralightReadPages.Location = new System.Drawing.Point(137, 8);
            this.btnmifareUltralightReadPages.Name = "btnmifareUltralightReadPages";
            this.btnmifareUltralightReadPages.Size = new System.Drawing.Size(152, 30);
            this.btnmifareUltralightReadPages.Text = "mifareUltralightReadPages";
            this.btnmifareUltralightReadPages.Press += new System.EventHandler(this.btnmifareUltralightReadPages_Press);
            // 
            // btnrequestTechnology
            // 
            this.btnrequestTechnology.Location = new System.Drawing.Point(137, 62);
            this.btnrequestTechnology.Name = "btnrequestTechnology";
            this.btnrequestTechnology.Size = new System.Drawing.Size(152, 30);
            this.btnrequestTechnology.Text = "requestTechnology";
            this.btnrequestTechnology.Press += new System.EventHandler(this.btnrequestTechnology_Press);
            // 
            // btncancelTechnologyRequest
            // 
            this.btncancelTechnologyRequest.Location = new System.Drawing.Point(137, 121);
            this.btncancelTechnologyRequest.Name = "btncancelTechnologyRequest";
            this.btncancelTechnologyRequest.Size = new System.Drawing.Size(152, 30);
            this.btncancelTechnologyRequest.Text = "cancelTechnologyRequest";
            this.btncancelTechnologyRequest.Press += new System.EventHandler(this.btncancelTechnologyRequest_Press);
            // 
            // btncloseTechnology
            // 
            this.btncloseTechnology.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(67)))), ((int)(((byte)(80)))));
            this.btncloseTechnology.Location = new System.Drawing.Point(137, 174);
            this.btncloseTechnology.Name = "btncloseTechnology";
            this.btncloseTechnology.Size = new System.Drawing.Size(152, 30);
            this.btncloseTechnology.Text = "closeTechnology";
            this.btncloseTechnology.Press += new System.EventHandler(this.btncloseTechnology_Press);
            // 
            // btngetTag
            // 
            this.btngetTag.Location = new System.Drawing.Point(137, 224);
            this.btngetTag.Name = "btngetTag";
            this.btngetTag.Size = new System.Drawing.Size(152, 30);
            this.btngetTag.Text = "getTag";
            this.btngetTag.Press += new System.EventHandler(this.btngetTag_Press);
            // 
            // btngetCachedNdefMessage
            // 
            this.btngetCachedNdefMessage.Location = new System.Drawing.Point(137, 274);
            this.btngetCachedNdefMessage.Name = "btngetCachedNdefMessage";
            this.btngetCachedNdefMessage.Size = new System.Drawing.Size(152, 30);
            this.btngetCachedNdefMessage.Text = "getCachedNdefMessage";
            this.btngetCachedNdefMessage.Press += new System.EventHandler(this.btngetCachedNdefMessage_Press);
            // 
            // btngetNdefMessage
            // 
            this.btngetNdefMessage.Location = new System.Drawing.Point(137, 320);
            this.btngetNdefMessage.Name = "btngetNdefMessage";
            this.btngetNdefMessage.Size = new System.Drawing.Size(152, 30);
            this.btngetNdefMessage.Text = "getNdefMessage";
            this.btngetNdefMessage.Press += new System.EventHandler(this.btngetNdefMessage_Press);
            // 
            // btnwriteNdefMessage
            // 
            this.btnwriteNdefMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(80)))));
            this.btnwriteNdefMessage.Location = new System.Drawing.Point(137, 365);
            this.btnwriteNdefMessage.Name = "btnwriteNdefMessage";
            this.btnwriteNdefMessage.Size = new System.Drawing.Size(152, 30);
            this.btnwriteNdefMessage.Text = "writeNdefMessage";
            this.btnwriteNdefMessage.Press += new System.EventHandler(this.btnwriteNdefMessage_Press);
            // 
            // btnMifareClassicReadBlock
            // 
            this.btnMifareClassicReadBlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(229)))), ((int)(((byte)(100)))));
            this.btnMifareClassicReadBlock.Location = new System.Drawing.Point(19, 402);
            this.btnMifareClassicReadBlock.Name = "btnMifareClassicReadBlock";
            this.btnMifareClassicReadBlock.Size = new System.Drawing.Size(137, 30);
            this.btnMifareClassicReadBlock.Text = "MifareClassicReadBlock";
            this.btnMifareClassicReadBlock.Press += new System.EventHandler(this.btnMifareClassicReadBlock_Press);
            // 
            // btnMifareClassicReadSector
            // 
            this.btnMifareClassicReadSector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(80)))));
            this.btnMifareClassicReadSector.Location = new System.Drawing.Point(19, 486);
            this.btnMifareClassicReadSector.Name = "btnMifareClassicReadSector";
            this.btnMifareClassicReadSector.Size = new System.Drawing.Size(143, 30);
            this.btnMifareClassicReadSector.Text = "MifareClassicReadSector";
            this.btnMifareClassicReadSector.Press += new System.EventHandler(this.btnMifareClassicReadSector_Press);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 440);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 35);
            this.textBox1.Text = "1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(19, 360);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 35);
            this.textBox2.Text = "1";
            // 
            // btnMifareClassicWriteBlock
            // 
            this.btnMifareClassicWriteBlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(80)))));
            this.btnMifareClassicWriteBlock.Location = new System.Drawing.Point(19, 540);
            this.btnMifareClassicWriteBlock.Name = "btnMifareClassicWriteBlock";
            this.btnMifareClassicWriteBlock.Size = new System.Drawing.Size(150, 30);
            this.btnMifareClassicWriteBlock.Text = "MifareClassicWriteBlock";
            this.btnMifareClassicWriteBlock.Press += new System.EventHandler(this.btnMifareClassicWriteBlock_Press);
            // 
            // btnmifareClassicGetSectorCount
            // 
            this.btnmifareClassicGetSectorCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(229)))), ((int)(((byte)(100)))));
            this.btnmifareClassicGetSectorCount.Location = new System.Drawing.Point(126, 440);
            this.btnmifareClassicGetSectorCount.Name = "btnmifareClassicGetSectorCount";
            this.btnmifareClassicGetSectorCount.Size = new System.Drawing.Size(163, 30);
            this.btnmifareClassicGetSectorCount.Text = "mifareClassicGetSectorCount";
            this.btnmifareClassicGetSectorCount.Press += new System.EventHandler(this.btnmifareClassicGetSectorCount_Press);
            // 
            // nfc1
            // 
            this.nfc1.Name = "nfc1";
            this.nfc1.NFCTag += new Smobiler.Plugins.NFCTagEventHandler(this.nfc1_NFCTag);
            this.nfc1.NdefWrite += new Smobiler.Plugins.NdefWriteEventHandler(this.nfc1_NdefWrite);
            this.nfc1.RequestTech += new Smobiler.Plugins.RequestTechEventHandler(this.nfc1_RequestTech);
            this.nfc1.NFCState += new Smobiler.Plugins.NFCStateEventHandler(this.nfc1_NFCState);
            // 
            // demoNFC
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.nfc1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.ShowResult = Smobiler.Core.Controls.ShowResult.Cancel;
            this.Name = "demoNFC";

        }
        #endregion

        private Core.Controls.Panel panel1;
        private Core.Controls.Button btnstart;
        private Core.Controls.Button btnissupported;
        private Core.Controls.Button btnregisterTagEvent;
        private Core.Controls.Button btnunregisterTagEvent;
        private Core.Controls.Button btngoToNfcSetting;
        private Core.Controls.Button btngetLaunchTagEvent;
        private Core.Controls.Button btnIsEnabled;
        private Core.Controls.Button btnmifareUltralightReadPages;
        private Core.Controls.Button btnrequestTechnology;
        private Core.Controls.Button btncancelTechnologyRequest;
        private Core.Controls.Button btncloseTechnology;
        private Core.Controls.Button btngetTag;
        private Core.Controls.Button btngetCachedNdefMessage;
        private Core.Controls.Button btngetNdefMessage;
        private Core.Controls.Button btnwriteNdefMessage;
        private Core.Controls.Button btnMifareClassicReadBlock;
        private Core.Controls.Button btnMifareClassicReadSector;
        private Core.Controls.TextBox textBox1;
        private Core.Controls.TextBox textBox2;
        private Core.Controls.Button btnMifareClassicWriteBlock;
        private Core.Controls.Button btnmifareClassicGetSectorCount;
        private Smobiler.Plugins.NFC nfc1;
    }
}