using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Devices
{
    partial class demoB2000 : Smobiler.Core.Controls.MobileForm
    {
        public demoB2000() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnbarcodeScan_Press(object sender, EventArgs e)
        {
            b2000Scanner1.BarcodeScan((a, s) => { Toast(s.error); });
        }

        private void btnstopBarcodeScan_Press(object sender, EventArgs e)
        {
            b2000Scanner1.BarcodeScanStop((a, s) => { Toast(s.error); });
        }

        private void btnbarcodeSetting_Press(object sender, EventArgs e)
        {

            b2000Scanner1.BarcodeSetting(msound, mvi, mscanmode, (a, s) => { Toast(s.error); });
        }

        private void btnrfidScan_Press(object sender, EventArgs e)
        {
            b2000Scanner1.RfidScan((a, s) => { Toast(s.error); });
        }

        private void btnstopRfidScan_Press(object sender, EventArgs e)
        {
            b2000Scanner1.StopRfidScan((a, s) => { Toast(s.error); });
        }

        private void btnsetRfidPower_Press(object sender, EventArgs e)
        {
            b2000Scanner1.SetRfidPower(20, (a, s) => { Toast(s.error); });
        }

        private void btngetRfidPower_Press(object sender, EventArgs e)
        {
            b2000Scanner1.GetRfidPower(B2000Scanner1_GetRFIDPower);
        }

        private void B2000Scanner1_GetRFIDPower(object sender, Smobiler.Device.B2000GetRFIDPowerEventArgs e)
        {
            MessageBox.Show(e.Power.ToString());
        }

        private void btnseleteRfidCard_Press(object sender, EventArgs e)
        {
            b2000Scanner1.SeleteRfidCard(1, "E200001787170119199047B8", true, (a, s) => { Toast(s.error); });
        }

        private void btnreadRfidArea_Press(object sender, EventArgs e)
        {
            b2000Scanner1.ReadRfidArea(3, 0, 1, "00000000", (a, s) => { Toast(s.error); });
        }

        private void btnwriteRfidArea_Press(object sender, EventArgs e)
        {
            b2000Scanner1.WriteRfidArea(3, 0, "00000000", "baba", (a, s) => { Toast(s.error); });
        }

        private void b2000Scanner1_BarcodeDataCaptured(object sender, Smobiler.Device.B2000BarcodeScanEventArgs e)
        {
            Toast(e.Data);
        }
        private int i = 0;
        private void b2000Scanner1_RFIDDataCaptured(object sender, Smobiler.Device.B2000RFIDScanEventArgs e)
        {
            Toast("EPC:" + e.Epc + " RSSI:" + e.Rssi + " TID:" + e.Tid);
            i = i + 1;
            label1.Text = i.ToString();
        }
        private Smobiler.Device.B2000Scanmode mscanmode = Smobiler.Device.B2000Scanmode.One;
        private bool msound = true;
        private bool mvi = true;
        private void spinner1_ItemSelected(object sender, SpinnerItemSelectedEventArgs e)
        {
            if (e.Item == "One")
                mscanmode = Smobiler.Device.B2000Scanmode.One;
            else if (e.Item == "Two")
                mscanmode = Smobiler.Device.B2000Scanmode.Two;
            else
                mscanmode = Smobiler.Device.B2000Scanmode.Three;

        }

        private void spinner3_ItemSelected(object sender, SpinnerItemSelectedEventArgs e)
        {
            if (e.Item == "true")
                msound = true;
            else
                msound = false;
        }

        private void spinner2_ItemSelected(object sender, SpinnerItemSelectedEventArgs e)
        {
            if (e.Item == "true")
                mvi = true;
            else
                mvi = false;
        }

        private void b2000Scanner1_RFIDTagRead(object sender, Smobiler.Device.B2000RFIDTagReadEventArgs e)
        {
            Toast(e.Message);
        }
    }
}