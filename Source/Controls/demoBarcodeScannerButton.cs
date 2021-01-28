using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Controls
{
    partial class demoBarcodeScannerButton : Smobiler.Core.Controls.MobileForm
    {
        public demoBarcodeScannerButton() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void barcodeScannerButton1_BarcodeScanned(object sender, BarcodeResultArgs e)
        {
            MessageBox.Show(e.Value);

        }

    }
}