using Smobiler.Core;
using Smobiler.Core.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Smobiler.Tutorials.Devices
{
    partial class demoRS35 : Smobiler.Core.Controls.MobileForm
    {
        public demoRS35() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Press(object sender, EventArgs e)
        {
            this.rS35Scanner1.BarcodeIsMulti(false);
            this.rS35Scanner1.BarcodeScan();

        }

        private void button2_Press(object sender, EventArgs e)
        {
            this.rS35Scanner1.BarcodeIsMulti(true);
            this.rS35Scanner1.BarcodeScan(50);

        }

        private void button3_Press(object sender, EventArgs e)
        {
            this.rS35Scanner1.BarcodeScanStop();
        }

        private void rS35Scanner1_DataCaptured(object sender, Device.RS35BarcodeScanEventArgs e)
        {
            label2.Text = e.Data + System.Environment.NewLine + label2.Text;
        }

        private void rS35Scanner1_OnNotify(object sender, ComponentResultArgs e)
        {
            Toast(e.error);
        }
    }
}