using Smobiler.Core;
using Smobiler.Core.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Smobiler.Tutorials.Devices
{
    partial class demoRK25 : Smobiler.Core.Controls.MobileForm
    {
        public demoRK25() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rK25Scanner1_OnNotify(object sender, ComponentResultArgs e)
        {
            Toast(e.error);
        }

        private void rK25Scanner1_DataCaptured(object sender, Device.RK25BarcodeScanEventArgs e)
        {
            label2.Text = e.Data + System.Environment.NewLine + label2.Text;
        }

        private void button3_Press(object sender, EventArgs e)
        {
            this.rK25Scanner1.BarcodeScanStop();
        }

        private void button2_Press(object sender, EventArgs e)
        {
            this.rK25Scanner1.BarcodeIsMulti(true);
            this.rK25Scanner1.BarcodeScan(50);
        }

        private void button1_Press(object sender, EventArgs e)
        {
            this.rK25Scanner1.BarcodeIsMulti(false);
            this.rK25Scanner1.BarcodeScan();
        }
    }
}