using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using Smobiler.Device;

namespace Smobiler.Tutorials.Devices
{
    partial class demoTC25 : Smobiler.Core.Controls.MobileForm
    {
        public demoTC25()
            : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        int i = 0;
        private void btnsetTriggerType_Press(object sender, EventArgs e)
        {
            if (i == 0)
            { this.tC25Scanner1.SetTriggerType(Smobiler.Device.TriggerType.Software); btnsetTriggerType.Text = "设置扫描方式 1"; i++; }
            else
            { this.tC25Scanner1.SetTriggerType(Smobiler.Device.TriggerType.Hardware); btnsetTriggerType.Text = "设置扫描方式 0"; i = 0; }
        }

        private void btnscan_Press(object sender, EventArgs e)
        {
            this.tC25Scanner1.Scan();
        }

        private void btnstop_Press(object sender, EventArgs e)
        {
            this.tC25Scanner1.ScanStop();
        }

        private void btnstatus_Press(object sender, EventArgs e)
        {
            this.tC25Scanner1.Status();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tC25Scanner1_DataCaptured(object sender, TC25BarcodeScanEventArgs e)
        {
            this.label1.Text = e.Data;
        }

        private void tC25Scanner1_OnNotify(object sender, ComponentResultArgs e)
        {
            if (e.isError == true)
            {
                MessageBox.Show(e.error);
            }
        }

        private void tC25Scanner1_OnStatus(object sender, TC25BarcodeStatusEventArgs e)
        {
            this.label2.Text = e.Status;
        }
    }
}