using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using Smobiler.Device;

namespace Smobiler.Tutorials.Devices
{
    partial class demoP380 : Smobiler.Core.Controls.MobileForm
    {
        public demoP380() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void button1_Press(object sender, EventArgs e)
        {
            string str = "690000001";
            TSCPrinterEntityCollection Commands1 = new TSCPrinterEntityCollection();
            Commands1.Add(new TSCPrinterRawProtocolEntity("SIZE 80 mm,40 mm\r\n" + "REFERENCE 0,0\r\n" + "SPEED 4.0\r\n" + "DENSITY 8\r\n" + "SET PEEL OFF\r\n" + "SET CUTTER OFF\r\n" + "SET TEAR ON\r\n" + "DIRECTION 0\r\n" + "SHIFT 0\r\n" + "OFFSET 0 mm\r\n" + "CLS\r\n" + "BARCODE 20,20,\"128M\",160,1,0,4,12,\"" + str + "\"\r\n" + "TEXT 20,190,\"ARIAL.TTF\",0,15,15,\"" + str + "\"\n" + "PRINT 3,1\r\n"));

            p380Printer1.Print(Commands1, (obj, args) =>
            {
                if (args.isError == true)
                    this.Toast("Error: " + args.error);
                else
                    this.Toast("打印成功");
            });
        }
    }
}