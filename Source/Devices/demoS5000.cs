using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Devices
{
    partial class demoS5000 : Smobiler.Core.Controls.MobileForm
    {
        public demoS5000() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnopen_Press(object sender, EventArgs e)
        {
            s5000Scanner1.DeviceOpen();
        }

        private void btnclose_Press(object sender, EventArgs e)
        {
            s5000Scanner1.DeviceClose();
        }

        private void btnstart_Press(object sender, EventArgs e)
        {
            s5000Scanner1.ScanStart();
        }

        private void btnstop_Press(object sender, EventArgs e)
        {
            s5000Scanner1.ScanStop();
        }

        private void btnEnableTrigger_Press(object sender, EventArgs e)
        {
            s5000Scanner1.EnableTrigger();
        }

        private void btnDisableTrigger_Press(object sender, EventArgs e)
        {
            s5000Scanner1.DisableTrigger();
        }

        private void btnsearchcard_Press(object sender, EventArgs e)
        {
            s5000Scanner1.SearchCard();
        }

        private void btnreadcarddara_Press(object sender, EventArgs e)
        {
            // s5000Scanner1.ReadCardData();

            s5000Scanner1.ReadCardData(0, 1, 2, false);
        }

        private void btnwritecarddata_Press(object sender, EventArgs e)
        {
            ///hexString:true并且block:1 按16进制字符长度（32个十六进制字符）*1
           // s5000Scanner1.WriteCardData("00000000000000000000000000000001");

            ///hexString:false并且block:2 按非16进制字符长度（16个字符）*2
            s5000Scanner1.WriteCardData("1234567890ABCDEG1234567890ABCDEG", 0, 1, 2, false);
        }

        private void demoS5000_Load(object sender, EventArgs e)
        {

        }

        private void s5000Scanner1_DataCaptured(object sender, Device.S5000ScannerScanEventArgs e)
        {
            MessageBox.Show(e.Name + " " + e.Sex + " " + e.Nation + " " + e.BirthDay + " " + e.Address + " " + e.IDCard + " " + e.Office + " " + e.Effective + " " + e.Photo + " " + e.Finger1 + " " + e.Finger2);
            image1.ResourceData = e.Photo;
        }

        private void s5000Scanner1_KeyDown(object sender, Device.S5000ScannerButtonEventArgs e)
        {
            if (e.KeyCode == Smobiler.Device.S5000Keys.F1)
                Toast("1");
            if (e.KeyCode == Smobiler.Device.S5000Keys.F2)
                Toast("2");
            if (e.KeyCode == Smobiler.Device.S5000Keys.LeftTrigger)
                Toast("3");
            if (e.KeyCode == Smobiler.Device.S5000Keys.RightTrigger)
                Toast("4");
        }

        private void s5000Scanner1_M1CardDataCaptured(object sender, Device.S5000ScannerM1CardEventArgs e)
        {
            if (e.ReadData != null)
                MessageBox.Show("success:" + e.Success + " error:" + e.Error + " card:" + e.CardID + " readdata：" + e.ReadData);
            else
                MessageBox.Show("success:" + e.Success + " error:" + e.Error + " card:" + e.CardID);
        }

        private void s5000Scanner1_OnNotify(object sender, ComponentResultArgs e)
        {
            if (e.isError == true)
            {
                MessageBox.Show(e.error);
            }
            else
            {
                Toast("success");
            }
        }
    }
}