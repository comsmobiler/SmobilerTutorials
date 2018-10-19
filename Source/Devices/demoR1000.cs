using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using Smobiler.Device;

namespace Smobiler.Tutorials.Devices
{
    partial class demoR1000 : Smobiler.Core.Controls.MobileForm
    {
        public demoR1000()
            : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void btnBarcodescan_Press(object sender, EventArgs e)
        {
            r1000Scanner1.BarcodeIsMulti(false);
            r1000Scanner1.BarcodeScan(10);
        }

        private void btnBarcodescanstop_Press(object sender, EventArgs e)
        {
            r1000Scanner1.BarcodeScanStop();
        }

        private void btnEnableTrigger_Press(object sender, EventArgs e)
        {
            r1000Scanner1.EnableTrigger();
        }

        private void btnDisableTrigger_Press(object sender, EventArgs e)
        {
            r1000Scanner1.DisableTrigger();
        }

        private void btnRFIDscan_Press(object sender, EventArgs e)
        {
            r1000Scanner1.RFIDScan();
        }

        private void btnRFIDscanstop_Press(object sender, EventArgs e)
        {
            r1000Scanner1.RFIDScanStop();
        }

        private void btnBarcodeTimerScan_Press(object sender, EventArgs e)
        {
            r1000Scanner1.BarcodeIsMulti(true);
            r1000Scanner1.BarcodeScan();
        }

        private void btnsetRfidPower_Press(object sender, EventArgs e)
        {
            r1000Scanner1.SetRFIDPower(int.Parse(textBox1.Text));
        }

        private void r1000Scanner1_BarcodeDataCaptured(object sender, Smobiler.Device.R1000BarcodeScanEventArgs e)
        {
            this.label1.Text = e.Data;
        }

        private void r1000Scanner1_OnNotify(object sender, ComponentResultArgs e)
        {
            if (e.isError == true)
            {
                MessageBox.Show(e.error);
            }
        }
        int numRfid = 0;
        private void r1000Scanner1_RFIDDataCaptured(object sender, Smobiler.Device.R1000RFIDScanEventArgs e)
        {
            this.label1.Text = e.Epc;
            this.label2.Text = e.Rssi;
            numRfid += 1;
            Toast(numRfid.ToString());
        }

        private void r1000Scanner1_KeyDown(object sender, Smobiler.Device.R1000ButtonEventArgs e)
        {
            if (e.KeyCode == R1000Keys.F1)
                Toast("1");
            if (e.KeyCode == R1000Keys.F2)
                Toast("2");
            if (e.KeyCode == R1000Keys.F3)
                Toast("3");
            if (e.KeyCode == R1000Keys.F4)
                Toast("4");
            if (e.KeyCode == R1000Keys.F5_SCAN)
                Toast("5");
            if (e.KeyCode == R1000Keys.LeftTrigger)
                Toast("6");
            if (e.KeyCode == R1000Keys.RightTrigger)
                Toast("7");
        }

        private void btnBindKeyDown_Press(object sender, EventArgs e)
        {
            r1000Scanner1.BindKeyDown();
        }

        private void btnUnbindKeyDown_Press(object sender, EventArgs e)
        {
            r1000Scanner1.UnbindKeyDown();
        }
        int num = 0;
        private void btnRFIDType_Press(object sender, EventArgs e)
        {
            if (num % 3 == 0)
            {
                r1000Scanner1.RFIDType(RFIDType.Singlescan);
                Toast("Singlescan");
                num++;
            }
            else if (num % 3 == 1)
            {
                r1000Scanner1.RFIDType(RFIDType.Filterscan);
                Toast("Filterscan");
                num++;
            }
            else
            {
                r1000Scanner1.RFIDType(RFIDType.Fullscan);
                Toast("Fullscan");
                num++;
            }
        }

        private void button1_Press(object sender, EventArgs e)
        {
            numRfid = 0;
        }
        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}