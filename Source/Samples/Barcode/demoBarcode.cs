using Smobiler.Core;
using Smobiler.Core.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;

namespace Smobiler.Tutorials.Samples.Barcode
{
    partial class demoBarcode : Smobiler.Core.Controls.MobileForm
    {
        public demoBarcode() : base()
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
            if (string.IsNullOrEmpty(textBox1.Text) == false)
            {
                GetQrCode();
                string imagename = "smoQrcode.png";
                string filePath = Path.Combine(MobileResourceManager.DefaultUploadPath, imagename);
                FileStream fs = new FileStream(filePath, FileMode.Create);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(image1.ResourceData, 0, image1.ResourceData.Length);
                bw.Close();
                fs.Close();
                this.Client.SaveImageToAlbum(imagename, MobileResourceManager.DefaultUploadPath);
            }


        }

        public void GetQrCode()
        {

            BarcodeWriter barcodeWriter = new BarcodeWriter();
            barcodeWriter.Format = BarcodeFormat.QR_CODE;
            QrCodeEncodingOptions qrCodeEncodingOptions = new QrCodeEncodingOptions();
            qrCodeEncodingOptions.DisableECI = true;//是否禁用ECI，设置true时可以使用UTF-8编码（仅限二维码时生效）
            qrCodeEncodingOptions.CharacterSet = "UTF-8";//设置字符集
            qrCodeEncodingOptions.Width = 100;
            qrCodeEncodingOptions.Height = 100;
            qrCodeEncodingOptions.Margin = 5;
            barcodeWriter.Options = qrCodeEncodingOptions;
            Bitmap bitmap = barcodeWriter.Write(textBox1.Text);
            image1.ResourceData = ToGetBytes(bitmap);
        }
        private byte[] ToGetBytes(Bitmap bitmap)
        {
            MemoryStream ms = new MemoryStream();
            bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            byte[] bytes = ms.GetBuffer();
            ms.Close();
            return bytes;
        }

        private void button2_Press(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == false)
            {
                GetBarcode();
                string imagename = "smoBarcode.png";
                string filePath = Path.Combine(MobileResourceManager.DefaultUploadPath, imagename);
                FileStream fs = new FileStream(filePath, FileMode.Create);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(image2.ResourceData, 0, image2.ResourceData.Length);
                bw.Close();
                fs.Close();
                this.Client.SaveImageToAlbum(imagename, MobileResourceManager.DefaultUploadPath);

            }
        }
       public void GetBarcode()
        {

            BarcodeWriter barcodeWriter = new BarcodeWriter();
            barcodeWriter.Format = BarcodeFormat.CODE_128;//设置编码格式
            EncodingOptions encodingOptions = new EncodingOptions();
            encodingOptions.Width = 180;
            encodingOptions.Height = 45;
            encodingOptions.Margin = 5;
            encodingOptions.PureBarcode = false;//是否不显示文本
            barcodeWriter.Options = encodingOptions;
            Bitmap bitmap = barcodeWriter.Write(textBox2.Text);
            image2.ResourceData = ToGetBytes(bitmap);
        }

        private void demoBarcode_Load(object sender, EventArgs e)
        {
            GetBarcode();
            GetQrCode();
        }
    }
}