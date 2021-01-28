using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoUSBSerial : Smobiler.Core.Controls.MobileForm
    {
        public demoUSBSerial() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConnect_Press(object sender, EventArgs e)
        {
            usbSerial1.Connect();
        }

        private void btnWrite_Press(object sender, EventArgs e)
        {
            string str = "690000001";
            string print1 = "SIZE 50 mm,80 mm\r\n" + "GAP 2 mm,0 mm\r\n" + "TEXT 30,0,\"TST24.BF2  \",0,1,1,\"" + "TDW108.热转印色带" + "\n" + "TEXT 30,60,\"ROMAN.TTF \",0,1,1,\"" + "110mm×300m" + "\r\n" + "TEXT 30,120,\"TST24.BF2  \",0,1,1,\"" + "外碳" + "\r\n" + "TEXT 30,180,\"ROMAN.TTF \",0,1,1,\"" + "0101MFG18110056" + "\r\n" + "TEXT 30,240,\"ROMAN.TTF \",0,1,1,\"" + "110.DBON1.0101.4.Z1.24" + "\r\n" + "REFERENCE 0,0\r\n" + "SPEED 4.0\r\n" + "DENSITY 8\r\n" +
             "SET PEEL OFF\r\n" + "SET CUTTER OFF\r\n" + "SET TEAR ON\r\n" + "DIRECTION 0\r\n" + "SHIFT 0\r\n" + "OFFSET 0 mm\r\n" + "CLS\r\n" + "QRCODE 350,0,H,4,A,0,M6,S7,\"" + str + "\"\r\n" + "TEXT 350,240,\"TSS24.BF2 \",0,1,1,\"" + "数量:100 卷     R11" + "\n" + "PRINT 1,1\r\n";
            //写入信息
            usbSerial1.Write(System.Text.Encoding.GetEncoding("gbk").GetBytes(print1), (abj, args) =>
            {
                if (args.isError == true)
                    Toast(args.error);
                else
                    Toast("success");
            });

        }

        private void btnClose_Press(object sender, EventArgs e)
        {
            usbSerial1.Close();

        }

        private void usbSerial1_DataReceived(object sender, Smobiler.Plugins.USBSerialDataReceivedEventArgs e)
        {
           //e.Data 接收到的数据
         }
    }
}