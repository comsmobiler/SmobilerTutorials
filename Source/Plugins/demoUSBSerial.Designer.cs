using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Plugins
{
    partial class demoUSBSerial : Smobiler.Core.Controls.MobileForm
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
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.btnConnect = new Smobiler.Core.Controls.Button();
            this.btnWrite = new Smobiler.Core.Controls.Button();
            this.btnClose = new Smobiler.Core.Controls.Button();
            this.usbSerial1 = new Smobiler.Plugins.USBSerial();
            this.label1 = new Smobiler.Core.Controls.Label();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "USBSerial";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // panel1
            // 
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnConnect,
            this.btnWrite,
            this.btnClose,
            this.label1});
            this.panel1.Flex = 1;
            this.panel1.Name = "panel1";
            this.panel1.Scrollable = true;
            this.panel1.Size = new System.Drawing.Size(0, 100);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(176)))), ((int)(((byte)(249)))));
            this.btnConnect.Location = new System.Drawing.Point(100, 73);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 30);
            this.btnConnect.Text = "Connect";
            this.btnConnect.Press += new System.EventHandler(this.btnConnect_Press);
            // 
            // btnWrite
            // 
            this.btnWrite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(229)))), ((int)(((byte)(99)))));
            this.btnWrite.Location = new System.Drawing.Point(100, 132);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(100, 30);
            this.btnWrite.Text = "Write";
            this.btnWrite.Press += new System.EventHandler(this.btnWrite_Press);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(78)))));
            this.btnClose.Location = new System.Drawing.Point(100, 196);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 30);
            this.btnClose.Text = "Close";
            this.btnClose.Press += new System.EventHandler(this.btnClose_Press);
            // 
            // usbSerial1
            // 
            this.usbSerial1.Name = "usbSerial1";
            this.usbSerial1.DataReceived += new Smobiler.Plugins.USBSerialDataReceivedEventHandler(this.usbSerial1_DataReceived);
            // 
            // label1
            // 
            this.label1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.label1.Location = new System.Drawing.Point(0, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 35);
            this.label1.Text = "DataReceived事件在接收后触发\r\n";
            // 
            // demoUSBSerial
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.usbSerial1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.panel1});
            this.Layout = Smobiler.Core.Controls.LayoutPosition.Relative;
            this.Name = "demoUSBSerial";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Panel panel1;
        private Core.Controls.Button btnConnect;
        private Core.Controls.Button btnWrite;
        private Core.Controls.Button btnClose;
        private Smobiler.Plugins.USBSerial usbSerial1;
        private Core.Controls.Label label1;
    }
}