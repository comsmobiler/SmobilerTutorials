using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Devices
{
    partial class demoR101 : Smobiler.Core.Controls.MobileForm
    {
        public demoR101() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnScan_Press(object sender, EventArgs e)
        {
            this.r101Scanner1.BarcodeIsMulti(false);
            this.r101Scanner1.BarcodeScan();
        }

        private void btnScanInstantly_Press(object sender, EventArgs e)
        {
            this.r101Scanner1.BarcodeIsMulti(true);
            this.r101Scanner1.BarcodeScan(50);
        }

        private void btnStopScan_Press(object sender, EventArgs e)
        {
            this.r101Scanner1.BarcodeScanStop();
        }

        private void r101Scanner1_DataCaptured(object sender, Smobiler.Device.R101BarcodeScanEventArgs e)
        {
            this.labData.Text = e.Data;

        }

        private void r101Scanner1_OnNotify(object sender, ComponentResultArgs e)
        {
            if (e.isError == true)
            {
                MessageBox.Show(e.error);
            }
        }
    }
}