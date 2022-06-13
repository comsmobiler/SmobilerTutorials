using Smobiler.Core;
using Smobiler.Core.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoiOSBluetooth : Smobiler.Core.Controls.MobileForm
    {
        public demoiOSBluetooth() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 扫描并连接指定的蓝牙
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Press(object sender, EventArgs e)
        {
            bluetooth1.iOSScanAndConnectBle("0000fff0-0000-1000-8000-00805f9b34fb", "CC:78:AB:AB:5A:3D", (obj, args) =>
            {
                if (args.isError == false)
                {
                    Toast($"name:{args.Name} message:{args.Message}");
                }
                else
                    Toast(args.error);
            });
        }
        /// <summary>
        /// 连接指定蓝牙
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Press(object sender, EventArgs e)
        {
            //第一个参数为蓝牙uuid
            bluetooth1.iOSConnectBle("0000fff0-0000-1000-8000-00805f9b34fb", (obj, args) =>
            {
                if (args.isError == false)
                {
                    Toast($"name:{args.Name} message:{args.Message}");
                }
                else
                    Toast(args.error);
            });
        }
        /// <summary>
        /// 断开指定蓝牙
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Press(object sender, EventArgs e)
        {
            //第一个参数为蓝牙uuid
            bluetooth1.iOSCloseConnectBle("0000fff0-0000-1000-8000-00805f9b34fb", (obj, args) =>
            {
                if (args.isError == false)
                {
                    Toast($"name:{args.Name} message:{args.Message}");
                }
                else
                    Toast(args.error);

            });
        }
        /// <summary>
        /// 查找低功耗蓝牙
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Press(object sender, EventArgs e)
        {
            bluetooth1.iOSSearchBle((obj, args) =>
            {
                if (args.isError == false)
                {
                    string str = "";
                    foreach (var item in args.Data)
                    {
                        str += "name:" + item.Name + "mac:" + item.Mac + "rssi:" + item.Rssi + "uuid" + item.Uuid;
                    }
                    Toast(str);
                }
                else
                    Toast(args.error);

            });
        }
        /// <summary>
        /// 搜索指定已连接设备的服务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Press(object sender, EventArgs e)
        {
            bluetooth1.iOSDiscoverUuid("0000fff0-0000-1000-8000-00805f9b34fb", (obj, args) =>
            {
                if (args.isError == false)
                {
                    string str = "";
                    if (args.Characteristis.Length > 0)
                    {
                        foreach (string item in args.Characteristis)
                            str += item + " ";
                        Toast($"uuid：{args.ServiceUUID} Characteristis:{str}");
                    }
                }
                else
                    Toast(args.error);
            });
        }
        /// <summary>
        /// 打开蓝牙的订阅
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Press(object sender, EventArgs e)
        {
            bluetooth1.iOSStartNotification("0000fff0-0000-1000-8000-00805f9b34fb", "0000fff0-0000-1000-8000-00805f9b34fb", "0000fff0-0000-1000-8000-00805f9b34fb", (obj, args) =>
            {
                if (args.isError == false)
                {
                    Toast($"state {args.State}");
                }
                else
                    Toast(args.error);

            });
        }
        /// <summary>
        /// 向蓝牙写入数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button9_Press(object sender, EventArgs e)
        {
            string str = "690000001";
            string print1 = "SIZE 50 mm,80 mm\r\n" + "GAP 2 mm,0 mm\r\n" + "TEXT 30,0,\"TST24.BF2  \",0,1,1,\"" + "TDW108.热转印色带" + "\n" + "TEXT 30,60,\"ROMAN.TTF \",0,1,1,\"" + "110mm×300m" + "\r\n" + "TEXT 30,120,\"TST24.BF2  \",0,1,1,\"" + "外碳" + "\r\n" + "TEXT 30,180,\"ROMAN.TTF \",0,1,1,\"" + "0101MFG18110056" + "\r\n" + "TEXT 30,240,\"ROMAN.TTF \",0,1,1,\"" + "110.DBON1.0101.4.Z1.24	" + "\r\n" + "REFERENCE 0,0\r\n" + "SPEED 4.0\r\n" + "DENSITY 8\r\n" +
                "SET PEEL OFF\r\n" + "SET CUTTER OFF\r\n" + "SET TEAR ON\r\n" + "DIRECTION 0\r\n" + "SHIFT 0\r\n" + "OFFSET 0 mm\r\n" + "CLS\r\n" + "QRCODE 350,0,H,4,A,0,M6,S7,\"" + str + "\"\r\n" + "TEXT 350,240,\"TSS24.BF2 \",0,1,1,\"" + "数量:100 卷     R11" + "\n" + "PRINT 1,1\r\n";

            bluetooth1.iOSWriteBleData("0000fff0-0000-1000-8000-00805f9b34fb", "0000fff0-0000-1000-8000-00805f9b34fb", "0000fff0-0000-1000-8000-00805f9b34fb", print1, (obj, args) =>
            {
                if (args.isError == false)
                {
                    Toast("success");
                }
                else
                    Toast(args.error);
            });
        }
        /// <summary>
        /// 关闭蓝牙订阅
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button10_Press(object sender, EventArgs e)
        {
            bluetooth1.iOSStopNotification("0000fff0-0000-1000-8000-00805f9b34fb", "0000fff0-0000-1000-8000-00805f9b34fb", "0000fff0-0000-1000-8000-00805f9b34fb", (obj, args) =>
            {
                if (args.isError == false)
                {
                    Toast($"state {args.State}");
                }
                else
                    Toast(args.error);

            });
        }
        /// <summary>
        /// 读蓝牙设备的数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button11_Press(object sender, EventArgs e)
        {
            bluetooth1.iOSReadBleData("0000fff0-0000-1000-8000-00805f9b34fb", "0000fff0-0000-1000-8000-00805f9b34fb", "0000fff0-0000-1000-8000-00805f9b34fb", (obj, args) =>
            {
                if (args.isError == false)
                { Toast(args.Value); }
                else
                    Toast(args.error);
            });

        }
        /// <summary>
        /// 连接指定经典蓝牙
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Press(object sender, EventArgs e)
        {
            bluetooth1.ConnectWithSearch("00:0D:18:00:19:98", (abj, args) =>
            {
                if (args.isError == true)
                    Toast(args.error);
                else
                    Toast("success");
            });
        }
    }
}