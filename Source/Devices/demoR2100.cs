using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using Smobiler.Device;

namespace Smobiler.Tutorials.Devices
{
    partial class demoR2100 : Smobiler.Core.Controls.MobileForm
    {
        public demoR2100()
            : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void btnBarcodescan_Press(object sender, EventArgs e)
        {
            r2100Scanner1.BarcodeScan();
        }

        private void btnBarcodescanstop_Press(object sender, EventArgs e)
        {
            r2100Scanner1.BarcodeScanStop();
        }
        private bool mbMulti = false;
        private void btnBarcodeIsMulti_Press(object sender, EventArgs e)
        {
            mbMulti = !mbMulti;
            r2100Scanner1.BarcodeIsMulti(mbMulti);
        }

        private void btnRFIDscan_Press(object sender, EventArgs e)
        {
            r2100Scanner1.RFIDScan();
        }

        private void btnRFIDscanstop_Press(object sender, EventArgs e)
        {
            r2100Scanner1.RFIDScanStop();
        }
        private bool mrMulti = false;
        private void btnRFIDIsMulti_Press(object sender, EventArgs e)
        {
            mrMulti = !mrMulti;
            r2100Scanner1.RFIDIsMulti(mrMulti);
        }

        private void btnEnableTrigger_Press(object sender, EventArgs e)
        {
            r2100Scanner1.EnableTrigger();
        }

        private void btnDisableTrigger_Press(object sender, EventArgs e)
        {
            r2100Scanner1.DisableTrigger();
        }




        private void btnsetRfidPower_Press(object sender, EventArgs e)
        {
            try
            {

                r2100Scanner1.SetRFIDPower(int.Parse(textBox1.Text), int.Parse(textBox1.Text));
            }
            catch
            {
                Toast("设置正确的功率（5-30）");
            }
        }

        private void btngetRfidPower_Press(object sender, EventArgs e)
        {
            //r2100Scanner1.getRfidPower((obj, args) => { Toast(args.ReadPower.ToString()); });
            r2100Scanner1.GetRFIDPower(r2100Scanner1_GetRFIDPower);
        }

        private void r2100Scanner1_GetRFIDPower(object sender, Smobiler.Device.R2100GetRFIDPowerEventArgs e)
        {
            MessageBox.Show(e.ReadPower + "  " + e.WritePower);
        }

        private void btnBindKeyDown_Press(object sender, EventArgs e)
        {
            r2100Scanner1.BindKeyDown();
        }

        private void btnUnBindKeyDown_Press(object sender, EventArgs e)
        {
            r2100Scanner1.UnbindKeyDown();
        }

      
        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }
        int num = 0;
        private void btnRFIDType_Press(object sender, EventArgs e)
        {
            if (num % 3 == 0)
            {
                r2100Scanner1.RFIDType(RFIDType.Singlescan);
                Toast("Singlescan");
                num++;
            }
            else if (num % 3 == 1)
            {
                r2100Scanner1.RFIDType(RFIDType.Filterscan);
                Toast("Filterscan");
                num++;
            }
            else
            {
                r2100Scanner1.RFIDType(RFIDType.Fullscan);
                Toast("Fullscan");
                num++;
            }
        }

        private void r2100Scanner1_BarcodeDataCaptured(object sender, R2100BarcodeScanEventArgs e)
        {
            this.label1.Text = e.Data;
        }

        private void r2100Scanner1_KeyDown(object sender, R2100ButtonEventArgs e)
        {
            if (e.KeyCode == R2100Keys.LeftTrigger)
                Toast("133");
            if (e.KeyCode == R2100Keys.DownTrigger)
                Toast("134");
            if (e.KeyCode == R2100Keys.RightTrigger)
                Toast("135");
        }

        private void r2100Scanner1_OnNotify_1(object sender, ComponentResultArgs e)
        {
            if (e.isError == true)
            {
                MessageBox.Show(e.error);
            }
        }

        private void r2100Scanner1_RFIDDataCaptured(object sender, R2100RFIDScanEventArgs e)
        {
            this.label1.Text = e.Epc;
            this.label2.Text = e.Rssi;
        }

    }
}