using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using Smobiler.Device;

namespace Smobiler.Tutorials.Devices
{
    partial class demoR200 : Smobiler.Core.Controls.MobileForm
    {
        public demoR200() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void btnScan_Press(object sender, EventArgs e)
        {
            this.r200Scanner1.BarcodeIsMulti(false);
            this.r200Scanner1.BarcodeScan();
        }

        private void btnScanInstantly_Press(object sender, EventArgs e)
        {
            this.r200Scanner1.BarcodeIsMulti(true);
            this.r200Scanner1.BarcodeScan();
        }

        private void btnStopScan_Press(object sender, EventArgs e)
        {
            this.r200Scanner1.BarcodeScanStop();
        }

        private void btnEnableTrigger_Press(object sender, EventArgs e)
        {
            this.r200Scanner1.EnableTrigger();
        }

        private void btnDisableTrigger_Press(object sender, EventArgs e)
        {
            this.r200Scanner1.DisableTrigger();
        }

        private void r200Scanner1_DataCaptured(object sender, Smobiler.Device.R200BarcodeScanEventArgs e)
        {
            this.labData.Text = e.Data;
        }

        private void r200Scanner1_OnNotify(object sender, Smobiler.Core.Controls.ComponentResultArgs e)
        {
            if (e.isError == true)
            {
                MessageBox.Show(e.error);
            }
        }

        private void r200Scanner1_KeyDown(object sender, Smobiler.Device.R200ButtonEventArgs e)
        {
            if (e.KeyCode == R200Keys.F1)
            {
                Toast("1");
            }
            if (e.KeyCode == R200Keys.SCAN_F2)
            {
                Toast("2");
            }
            if (e.KeyCode == R200Keys.SCAN)
                Toast("3");
            if (e.KeyCode == R200Keys.LeftTrigger)
                Toast("4");
            if (e.KeyCode == R200Keys.RightTrigger)
                Toast("5");
        }

        private void btnBindKeyDown_Press(object sender, EventArgs e)
        {
            r200Scanner1.BindKeyDown();
        }

        private void btnUnbindKeyDown_Press(object sender, EventArgs e)
        {
            r200Scanner1.UnbindKeyDown();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}