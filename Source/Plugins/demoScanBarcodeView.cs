using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoScanBarcodeView : Smobiler.Core.Controls.MobileForm
    {
        public demoScanBarcodeView() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void scanBarcodeView1_BarcodeDataCaptured(object sender, Smobiler.Plugins.ScanBarcodeViewEventArgs e)
        {
            Toast(e.Data);
        }

        private void btnOpenFlashLight_Press(object sender, EventArgs e)
        {
            scanBarcodeView1.FlashLight = true;
        }

        private void btnCloseFlashLight_Press(object sender, EventArgs e)
        {
            scanBarcodeView1.FlashLight = false;
        }

        private void btnScanStart_Press(object sender, EventArgs e)
        {
            scanBarcodeView1.ScanStart();
        }

        private void btnScanStop_Press(object sender, EventArgs e)
        {
            scanBarcodeView1.ScanStop();
        }

        private void btnIntervalTime_Press(object sender, EventArgs e)
        {
            scanBarcodeView1.IntervalTime = int.Parse(textBox1.Text);
        }
    }
}