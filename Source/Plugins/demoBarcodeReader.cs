using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoBarcodeReader : Smobiler.Core.Controls.MobileForm
    {
        public demoBarcodeReader() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGetBarcode_Press(object sender, EventArgs e)
        {
            barcodeReader1.GetBarcode((obj, args) => { Toast("success:" + !args.isError + " Error:" + args.error); Toast(args.Data); });
        }

        private void btnRelease_Press(object sender, EventArgs e)
        {
            barcodeReader1.Release((obj, args) => { Toast("success:" + !args.isError + " Error:" + args.error); });
        }

        private void barcodeReader1_BarcodeRead(object sender, Smobiler.Plugins.BarcodeReaderEventArgs e)
        {
            Toast(e.Data);
        }
    }
}