using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoBluetooth : Smobiler.Core.Controls.MobileForm
    {
        public demoBluetooth() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnopen_Press(object sender, EventArgs e)
        {
            bluetooth1.Open((abj, args) =>
            {
                if (args.isError == true)
                    Toast(args.error);
                else
                    Toast("success");
            });
        }

        private void btnClose_Press(object sender, EventArgs e)
        {
            bluetooth1.Close((abj, args) =>
            {
                if (args.isError == true)
                    Toast(args.error);
                else
                    Toast("success");
            });
        }

        private void btnSearch_Press(object sender, EventArgs e)
        {
            bluetooth1.Search((abj, args) =>
            {
                if (args.isError == true)
                    Toast(args.error);
                else
                {
                    Toast("success" + args.Name + "  " + args.MacAddress);
                    MessageBox.Show(args.Name + "  " + args.MacAddress);
                }
            });
        }

        private void btnConnect_Press(object sender, EventArgs e)
        {
            bluetooth1.Connect("00:0D:18:00:19:98", (abj, args) =>
            {
                if (args.isError == true)
                    Toast(args.error);
                else
                    Toast("success");
            });
        }

        private void btnCloseConnect_Press(object sender, EventArgs e)
        {
            bluetooth1.CloseConnect((abj, args) =>
            {
                if (args.isError == true)
                    Toast(args.error);
                else
                    Toast("success");
            });
        }

        private void btnWriteMessage_Press(object sender, EventArgs e)
        {
            //发送的TSPL指令
            string str = "690000001";
            string print = "SIZE 80 mm,40 mm\r\n" + "REFERENCE 0,0\r\n" + "SPEED 4.0\r\n" + "DENSITY 8\r\n" + "SET PEEL OFF\r\n" + "SET CUTTER OFF\r\n" + "SET TEAR ON\r\n" + "DIRECTION 0\r\n" + "SHIFT 0\r\n" + "OFFSET 0 mm\r\n" + "CLS\r\n" + "BARCODE 20,20,\"128M\",160,1,0,4,12,\"" + str + "\"\r\n" + "TEXT 20,190,\"ARIAL.TTF\",0,15,15,\"" + str + "\"\n" + "PRINT 3,1\r\n";

            string print1 = "SIZE 50 mm,80 mm\r\n" + "GAP 2 mm,0 mm\r\n" + "TEXT 30,0,\"TST24.BF2  \",0,1,1,\"" + "Smobiler" + "\n" + "TEXT 30,60,\"ROMAN.TTF \",0,1,1,\"" + "110mm×300m" + "\r\n" + "TEXT 30,120,\"TST24.BF2  \",0,1,1,\"" + "石磨" + "\r\n" + "TEXT 30,180,\"ROMAN.TTF \",0,1,1,\"" + "上海石磨信息科技有限公司" + "\r\n" + "TEXT 30,240,\"ROMAN.TTF \",0,1,1,\"" + "Smobiler" + "\r\n" + "REFERENCE 0,0\r\n" + "SPEED 4.0\r\n" + "DENSITY 8\r\n" +
             "SET PEEL OFF\r\n" + "SET CUTTER OFF\r\n" + "SET TEAR ON\r\n" + "DIRECTION 0\r\n" + "SHIFT 0\r\n" + "OFFSET 0 mm\r\n" + "CLS\r\n" + "QRCODE 350,0,H,4,A,0,M6,S7,\"" + str + "\"\r\n" + "TEXT 350,240,\"TSS24.BF2 \",0,1,1,\"" + "页数 1" + "\n" + "PRINT 1,1\r\n";
            bluetooth1.WriteData(System.Text.Encoding.GetEncoding("gbk").GetBytes(print1), (abj, args) =>
            {
                if (args.isError == true)
                    Toast(args.error);
                else
                    Toast("success");
            });

        }

        private void bluetooth1_DataReceived(object sender, Smobiler.Plugins.BluetoothDataReceivedEventArgs e)
        {
            Toast(e.Data.ToString());
            MessageBox.Show(System.Text.Encoding.GetEncoding("gbk").GetString(e.Data));
        }

        private void demoBluetooth_Load(object sender, EventArgs e)
        {
            timer1.Start();
            btnGetStatus_Press(null, null);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = bluetooth1.BluetoothStatus.ToString();
        }

        private void btnGetStatus_Press(object sender, EventArgs e)
        {
            bluetooth1.GetStatus((abj, args) =>
            {
                if (args.isError == true)
                    Toast(args.error);
                else
                {
                    Toast(args.Status + "  " + args.Name + "  " + args.MacAddress);
                    MessageBox.Show(args.Status + "  " + args.Name + "  " + args.MacAddress);
                }
            });
        }

        private void btnSearchBle_Press(object sender, EventArgs e)
        {
            //参数uuidService:连接时的service uuid,需要蓝牙供应商提供
            //参数uuidTransmitCharUuid:连接时发送内容的uuid,需要蓝牙供应商提供
            //参数uuidReceiveCharUuid:连接时接收内容的uuid,如果与发送id相同,请填写相同id.需要蓝牙供应商提供
            bluetooth1.SearchBle("", "", "", (abj, args) =>
            {
                if (args.isError == true)
                    Toast(args.error);
                else
                {
                    Toast("success" + args.Name + "  " + args.MacAddress);
                    MessageBox.Show(args.Name + "  " + args.MacAddress);
                }
            });
        }

        private void btnConnectBle_Press(object sender, EventArgs e)
        {
            //macAddress:连接蓝牙的mac地址,如"00:0D:18:00:19:98"
            //uuidService:连接时的service uuid,需要蓝牙供应商提供
            //uuidTransmitCharUuid:连接时发送内容的uuid,需要蓝牙供应商提供
            //uuidReceiveCharUuid:连接时接收内容的uuid,如果与发送id相同,请填写相同id.需要蓝牙供应商提供
            bluetooth1.ConnectBle("", "", "", "", (abj, args) =>
            {
                if (args.isError == true)
                    Toast(args.error);
                else
                    Toast("success");
            });
        }

        private void btnCloseConnectBle_Press(object sender, EventArgs e)
        {
            bluetooth1.CloseConnectBle((abj, args) =>
            {
                if (args.isError == true)
                    Toast(args.error);
                else
                    Toast("success");
            });
        }

        private void btnWriteBleMessage_Press(object sender, EventArgs e)
        {
            //发送的TSPL指令
            string str = "690000001";
            string print = "SIZE 80 mm,40 mm\r\n" + "REFERENCE 0,0\r\n" + "SPEED 4.0\r\n" + "DENSITY 8\r\n" + "SET PEEL OFF\r\n" + "SET CUTTER OFF\r\n" + "SET TEAR ON\r\n" + "DIRECTION 0\r\n" + "SHIFT 0\r\n" + "OFFSET 0 mm\r\n" + "CLS\r\n" + "BARCODE 20,20,\"128M\",160,1,0,4,12,\"" + str + "\"\r\n" + "TEXT 20,190,\"ARIAL.TTF\",0,15,15,\"" + str + "\"\n" + "PRINT 3,1\r\n";

            string print1 = "SIZE 50 mm,80 mm\r\n" + "GAP 2 mm,0 mm\r\n" + "TEXT 30,0,\"TST24.BF2  \",0,1,1,\"" + "Smobiler" + "\n" + "TEXT 30,60,\"ROMAN.TTF \",0,1,1,\"" + "110mm×300m" + "\r\n" + "TEXT 30,120,\"TST24.BF2  \",0,1,1,\"" + "石磨" + "\r\n" + "TEXT 30,180,\"ROMAN.TTF \",0,1,1,\"" + "上海石磨信息科技有限公司" + "\r\n" + "TEXT 30,240,\"ROMAN.TTF \",0,1,1,\"" + "Smobiler" + "\r\n" + "REFERENCE 0,0\r\n" + "SPEED 4.0\r\n" + "DENSITY 8\r\n" +
             "SET PEEL OFF\r\n" + "SET CUTTER OFF\r\n" + "SET TEAR ON\r\n" + "DIRECTION 0\r\n" + "SHIFT 0\r\n" + "OFFSET 0 mm\r\n" + "CLS\r\n" + "QRCODE 350,0,H,4,A,0,M6,S7,\"" + str + "\"\r\n" + "TEXT 350,240,\"TSS24.BF2 \",0,1,1,\"" + "页数 1" + "\n" + "PRINT 1,1\r\n";
            //BluetoothBleResponse.WRITE_TYPE_DEFAULT  表示不需要外网设备的回应
            bluetooth1.WriteBleData(System.Text.Encoding.GetEncoding("gbk").GetBytes(print1), Smobiler.Plugins.BluetoothBleResponse.WRITE_TYPE_DEFAULT, (abj, args) =>
            {
                if (args.isError == true)
                    Toast(args.error);
                else
                    Toast("success");
            });
        }

        private void btnGetBleStatus_Press(object sender, EventArgs e)
        {
            bluetooth1.GetBleStatus((abj, args) =>
            {
                if (args.isError == true)
                    Toast(args.error);
                else
                {
                    Toast(args.Status + "  " + args.Name + "  " + args.MacAddress);
                    MessageBox.Show(args.Status + "  " + args.Name + "  " + args.MacAddress);
                }
            });
        }

        private void button1_Press(object sender, EventArgs e)
        {
            bluetooth1.ConnectWithSearch("00:0D:18:00:19:9C", (obj, args) => {
                if (args.isError)
                    Toast(args.error);
                else
                {
                    Toast(args.args.ToString());
                }
            });

        }
    }
}