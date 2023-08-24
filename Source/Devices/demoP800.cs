using Smobiler.Core;
using Smobiler.Core.Controls;
using Smobiler.Device;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Smobiler.Tutorials.Devices
{
    partial class demoP800 : Smobiler.Core.Controls.MobileForm
    {
        public demoP800() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Press(object sender, EventArgs e)
        {
            p800Printer1.CutPaper((obj, args) =>
            {
                if (args.isError == true)
                    this.MessageBox.Show("Error: " + args.error);
                else
                    this.MessageBox.Show("success");
            });
        }

        private void button7_Press(object sender, EventArgs e)
        {
            P800PrintEntityCollection entityCollection = new P800PrintEntityCollection();
            //文本打印
            P800PrintTextEntity text = new P800PrintTextEntity()
            {
                Content = "测试打印文本",
                Offset = P800PrintOffSet.Center,
                IsBold = true,
                IsUnderLine = true,

            };
            //条码打印
            P800PrintBarcodeEntity barcode = new P800PrintBarcodeEntity("1234567")
            {
                Offset = P800PrintOffSet.Center,
                BarcodeHeight = 165,
                BarcodeWidth = 4,
                HriPosition = P800HriPosition.Both
            };
            //二维码打印
            P800PrintQRcodeEntity qrcode = new P800PrintQRcodeEntity() { Content = "Abab123", Offset = P800PrintOffSet.Center, QrcodeSize = 6 };
            entityCollection.Add(text);
            entityCollection.Add(barcode);

            entityCollection.Add(qrcode);
            p800Printer1.Print(entityCollection, false, (obj, args) =>
            {
                if (args.isError == true)
                    this.MessageBox.Show("Error: " + args.error);
                else
                    this.MessageBox.Show("success");

            });

        }
    }
}