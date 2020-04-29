using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Devices
{
    partial class demoB100 : Smobiler.Core.Controls.MobileForm
    {
        public demoB100() : base()
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
            b100Scanner1.BarcodeScan((a, s) => { Toast(s.error); });
        }

        private void btnstopBarcodeScan_Press(object sender, EventArgs e)
        {
            b100Scanner1.BarcodeScanStop((a, s) => { Toast(s.error); });
        }

        private void btnbarcodeSetting_Press(object sender, EventArgs e)
        {

            b100Scanner1.BarcodeSetting(msound, mvi, mscanmode, (a, s) => { Toast(s.error); });
        }

        private Smobiler.Device.B100Scanmode mscanmode = Smobiler.Device.B100Scanmode.One;
        private bool msound = true;
        private bool mvi = true;
        private void spinner1_ItemSelected(object sender, SpinnerItemSelectedEventArgs e)
        {
            if (e.Item == "One")
                mscanmode = Smobiler.Device.B100Scanmode.One;
            else if (e.Item == "Two")
                mscanmode = Smobiler.Device.B100Scanmode.Two;
            else
                mscanmode = Smobiler.Device.B100Scanmode.Three;

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

        private void b100Scanner1_RFIDTagRead(object sender, Smobiler.Device.B2000RFIDTagReadEventArgs e)
        {
            Toast(e.Message);
        }

        private void b100Scanner1_BarcodeDataCaptured(object sender, Device.B100Scanner.B100BarcodeScanEventArgs e)
        {
            Toast(e.Data);
        }
    }
}