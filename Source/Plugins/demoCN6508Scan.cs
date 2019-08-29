using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoCN6508 : Smobiler.Core.Controls.MobileForm
    {
        public demoCN6508() : base()
        {
            InitializeComponent();
        }
        Smobiler.Plugins.CN6508ScanMode scanmode = Smobiler.Plugins.CN6508ScanMode.Ordinary;
        Smobiler.Plugins.CN6508ScanTime scantime = Smobiler.Plugins.CN6508ScanTime.Time_0;
        bool scansound=false;
        bool scanvibrate = false;
        private void btnSetScanModel_Press(object sender, EventArgs e)
        {
            cN65081.SetScanModel(scanmode, (obj, args) =>
            {
                if (args.isError == true)
                    this.Toast("Error: " + args.error);
                else
                    this.Toast("success");
            });
        }

        private void btnSetScanDelaySetting_Press(object sender, EventArgs e)
        {
            cN65081.SetScanDelaySetting(scantime, (obj, args) =>
            {
                if (args.isError == true)
                    this.Toast("Error: " + args.error);
                else
                    this.Toast("success");
            });
        }

        private void btnSetScanSound_Press(object sender, EventArgs e)
        {
            cN65081.SetScanSound(scansound, (obj, args) =>
            {
                if (args.isError == true)
                    this.Toast("Error: " + args.error);
                else
                    this.Toast("success");
            });
        }

        private void btnsetScanVibrate_Press(object sender, EventArgs e)
        {
            cN65081.setScanVibrate(scanvibrate, (obj, args) =>
            {
                if (args.isError == true)
                    this.Toast("Error: " + args.error);
                else
                    this.Toast("success");
            });
        }

        private void btnshow_Press(object sender, EventArgs e)
        {
            this.Show(new demoCN6508Printer());
        }

        private void btnGetBarcode_Press(object sender, EventArgs e)
        {
            cN65081.GetBarcode((obj, args) =>
            {
                if (args.isError == true)
                    this.Toast("Error: " + args.error);
                else
                    this.Toast("success");
            });
        }

        private void spinner1_ItemSelected(object sender, SpinnerItemSelectedEventArgs e)
        {
            if (e.Item == "Ordinary:普通")
                scanmode = Smobiler.Plugins.CN6508ScanMode.Ordinary;
            else if (e.Item == "AutoContinuous:连续扫描(自动)")
                scanmode = Smobiler.Plugins.CN6508ScanMode.AutoContinuous;
            else
                scanmode = Smobiler.Plugins.CN6508ScanMode.ManualContinuous;
        }

        private void spinner2_ItemSelected(object sender, SpinnerItemSelectedEventArgs e)
        {
            if (e.Item == "Time_0:间隔0")
                scantime = Smobiler.Plugins.CN6508ScanTime.Time_0;
            else if (e.Item == "Time_500:间隔500ms")
                scantime = Smobiler.Plugins.CN6508ScanTime.Time_500;
            else
                scantime = Smobiler.Plugins.CN6508ScanTime.Time_1000;
        }

        private void spinner3_ItemSelected(object sender, SpinnerItemSelectedEventArgs e)
        {
            if (e.Item == "true")
                scansound = true;
            else
                scansound = false;
        }

        private void spinner4_ItemSelected(object sender, SpinnerItemSelectedEventArgs e)
        {
            if (e.Item == "true")
                scanvibrate = true;
            else
                scanvibrate = false;
        }

        private void cN65081_BarcodeDataCaptured(object sender, Smobiler.Plugins.CN6508BarcodeScanEventArgs e)
        {
            Toast(e.Data);
        }
    }
}