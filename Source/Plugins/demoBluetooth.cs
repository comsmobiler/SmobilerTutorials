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
            string str = "690000001";
            string print = "SIZE 80 mm,40 mm\r\n" + "REFERENCE 0,0\r\n" + "SPEED 4.0\r\n" + "DENSITY 8\r\n" + "SET PEEL OFF\r\n" + "SET CUTTER OFF\r\n" + "SET TEAR ON\r\n" + "DIRECTION 0\r\n" + "SHIFT 0\r\n" + "OFFSET 0 mm\r\n" + "CLS\r\n" + "BARCODE 20,20,\"128M\",160,1,0,4,12,\"" + str + "\"\r\n" + "TEXT 20,190,\"ARIAL.TTF\",0,15,15,\"" + str + "\"\n" + "PRINT 3,1\r\n";
            bluetooth1.WriteData(System.Text.Encoding.UTF8.GetBytes(print), (abj, args) =>
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
            MessageBox.Show(e.Data.ToString());
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
    }
}