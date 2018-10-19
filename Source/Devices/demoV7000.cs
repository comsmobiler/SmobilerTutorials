using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Devices
{
    partial class demoV7000 : Smobiler.Core.Controls.MobileForm
    {
        public demoV7000()
            : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SmobilerForm_Load(object sender, EventArgs e)
        {
            label2.Text = v7000Scanner1.Encoding.ToString();
            label3.Text = v7000Scanner1.IsContinue.ToString();
            label4.Text = v7000Scanner1.IsVoice.ToString();
            label5.Text = v7000Scanner1.IsVibator.ToString();
        }


        private void btnencoding_Press(object sender, EventArgs e)
        {
            if (v7000Scanner1.Encoding == Device.V7000Encoding.GBK)
                v7000Scanner1.Encoding = Device.V7000Encoding.UTF8;
            else
                v7000Scanner1.Encoding = Device.V7000Encoding.GBK;
            label2.Text = v7000Scanner1.Encoding.ToString();
        }

        private void btnisContinue_Press(object sender, EventArgs e)
        {
            v7000Scanner1.IsContinue = !v7000Scanner1.IsContinue;
            label3.Text = v7000Scanner1.IsContinue.ToString();
        }

        private void btnisVoice_Press(object sender, EventArgs e)
        {
            v7000Scanner1.IsVoice = !v7000Scanner1.IsVoice;
            label4.Text = v7000Scanner1.IsVoice.ToString();
        }

        private void btnisVibator_Press(object sender, EventArgs e)
        {
            v7000Scanner1.IsVibator = !v7000Scanner1.IsVibator;
            label5.Text = v7000Scanner1.IsVibator.ToString();
        }

        private void btnregisterKeyDown_Press(object sender, EventArgs e)
        {
            v7000Scanner1.EnableTrigger();
        }

        private void btnunRegisterKeyDown_Press(object sender, EventArgs e)
        {
            v7000Scanner1.DisableTrigger();
        }

        private void v7000Scan1_DataCaptured(object sender, Device.V7000ScanEventArgs e)
        {
            label6.Text = e.Data;
        }

        private void v7000Scan1_OnNotify(object sender, ComponentResultArgs e)
        {
            if (e.isError == true)
            {
                MessageBox.Show(e.error);
            }
        }

        private void btnScan_Press(object sender, EventArgs e)
        {
            v7000Scanner1.Scan();
        }
    }
}