using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Devices
{
    partial class demoN800 : Smobiler.Core.Controls.MobileForm
    {
        public demoN800() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBarcodeScan_Press(object sender, EventArgs e)
        {
            /// 单次扫描条码
            n800Scanner1.BarcodeScan();
        }

        private void btnBarcodeTimerScan_Press(object sender, EventArgs e)
        {
            /// 连续扫描条码
            n800Scanner1.BarcodeTimerScan();
        }

        private void btnBarcodeScanStop_Press(object sender, EventArgs e)
        {
            /// 停止条码扫描
            n800Scanner1.BarcodeScanStop();
        }

        private void btnScanTimeout_Press(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("输入为空");
            else
                /// 设置单次扫描超时时间
                n800Scanner1.ScanTimeout(int.Parse(textBox1.Text));
        }

        private void btnEnableTrigger_Press(object sender, EventArgs e)
        {
            /// 启用扫描键,默认开启(键盘扫描只支持单扫)
            n800Scanner1.EnableTrigger();
        }

        private void btnDisableTrigger_Press(object sender, EventArgs e)
        {
            /// 禁用扫描键
            n800Scanner1.DisableTrigger();
        }

        private void n800Scanner1_BarcodeDataCaptured(object sender, Smobiler.Device.N800BarcodeScanEventArgs e)
        {
            label1.Text = e.Data;
        }

        private void n800Scanner1_OnNotify(object sender, ComponentResultArgs e)
        {
            if (e.isError == true)
            {
                MessageBox.Show(e.error);
            }
        }
        private int i = 0;
        private void setScanMode_Press(object sender, EventArgs e)
        {
            /// 设置扫描回调的方式
            if (i == 0)
            { /// 发送给服务端
                n800Scanner1.SetScanMode(Smobiler.Device.N800ScanMode.Mode1);
                i++;
            }
            else
            {/// 扫到内容添加到选中的输入框
                n800Scanner1.SetScanMode(Smobiler.Device.N800ScanMode.Mode2);
                i = 0;
            }
        }

        private void n800Scanner1_KeyDown(object sender, Smobiler.Device.N800ButtonEventArgs e)
        {
            /// F1按键
            if (e.KeyCode == Smobiler.Device.N800Keys.F1)
                Toast("1");
            /// F2按键
            if (e.KeyCode == Smobiler.Device.N800Keys.F2)
                Toast("2");
            /// F3按键
            if (e.KeyCode == Smobiler.Device.N800Keys.F3)
                Toast("3");
        }
    }
}