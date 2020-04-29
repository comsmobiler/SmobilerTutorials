using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using Smobiler.Device;

namespace Smobiler.Tutorials.Devices
{
    partial class demoUM7 : Smobiler.Core.Controls.MobileForm
    {
        public demoUM7() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }


        private void btnEnableTrigger_Press(object sender, EventArgs e)
        {
            uM7Scanner1.EnableTrigger();
        }

        private void btnDisableTrigger_Press(object sender, EventArgs e)
        {
            uM7Scanner1.DisableTrigger();
        }

        private void btnRFIDscan_Press(object sender, EventArgs e)
        {
            uM7Scanner1.RFIDScan();
        }

        private void btnRFIDscanstop_Press(object sender, EventArgs e)
        {
            uM7Scanner1.RFIDScanStop();
        }

        private void btnsetRfidPower_Press(object sender, EventArgs e)
        {
            Int32 num = 0;
            if (Int32.TryParse(textBox1.Text, out num))
            {
                uM7Scanner1.SetRFIDPower(num);
            }
            else
            {
                Toast("需要设置整数5-30范围");
            }
        }

        private void uM7Scanner1_BarcodeDataCaptured(object sender, Smobiler.Device.R1000BarcodeScanEventArgs e)
        {
            this.label1.Text = e.Data;
        }

        private void uM7Scanner1_OnNotify(object sender, ComponentResultArgs e)
        {
            if (e.isError == true)
            {
                MessageBox.Show(e.error);
            }
        }
        int numRfid = 0;
        private void uM7Scanner1_RFIDDataCaptured(object sender, Smobiler.Device.UM7RFIDScanEventArgs e)
        {
            this.label1.Text = e.Epc;
            this.label2.Text = e.Rssi;
            numRfid += 1;
            Toast(numRfid.ToString());
        }

        private void uM7Scanner1_KeyDown(object sender, Smobiler.Device.UM7ButtonEventArgs e)
        {
            if (e.KeyCode == UM7Keys.F1)
                Toast("1");
            if (e.KeyCode == UM7Keys.F2)
                Toast("2");
            if (e.KeyCode == UM7Keys.F8)
                Toast("8");

        }

        private void btnBindKeyDown_Press(object sender, EventArgs e)
        {
            uM7Scanner1.BindKeyDown();
        }

        private void btnUnbindKeyDown_Press(object sender, EventArgs e)
        {
            uM7Scanner1.UnbindKeyDown();
        }
        int num = 0;
        private void btnRFIDType_Press(object sender, EventArgs e)
        {
            if (num % 3 == 0)
            {
                uM7Scanner1.RFIDType(RFIDType.Singlescan);
                Toast("Singlescan");
                num++;
            }
            else if (num % 3 == 1)
            {
                uM7Scanner1.RFIDType(RFIDType.Filterscan);
                Toast("Filterscan");
                num++;
            }
            else
            {
                uM7Scanner1.RFIDType(RFIDType.Fullscan);
                Toast("Fullscan");
                num++;
            }
        }

        private void button1_Press(object sender, EventArgs e)
        {
            numRfid = 0;
        }

        private void uM7Scanner1_RFIDTagRead(object sender, UM7RFIDTagReadEventArgs e)
        {
            Toast("success:" + e.Success + "Message:" + e.Message);
            label1.Text = e.Message;
        }

        private void uM7Scanner1_RFIDTagWrite(object sender, UM7RFIDTagWriteEventArgs e)
        {
            Toast("success:" + e.Success);
        }

        private void btngetRfidPower_Press(object sender, EventArgs e)
        {
            uM7Scanner1.GetRFIDPower((s, a) => { Toast(a.Power.ToString()); });
        }

        private void btnrestartRfid_Press(object sender, EventArgs e)
        {
            uM7Scanner1.RestartRfid((s, a) => { Toast(a.isError.ToString()); });
        }
    }
}