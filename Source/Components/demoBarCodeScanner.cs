using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Components
{
    partial class demoBarCodeScanner : Smobiler.Core.Controls.MobileForm
    {
        public demoBarCodeScanner()
            : base()
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
            barcodeScanner1.GetBarcode();
        }

        private void btnGetBarcodeAsync_Press(object sender, EventArgs e)
        {
            barcodeScanner1.GetBarcodeAsync();
        }

        private void barcodeScanner1_BarcodeScanned(object sender, BarcodeResultArgs e)
        {
            MessageBox.Show(e.Value);
        }
    }
}