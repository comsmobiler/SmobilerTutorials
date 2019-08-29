using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoCN6508Printer : Smobiler.Core.Controls.MobileForm
    {
        public demoCN6508Printer() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        private int mKeyTextSize = 24;
        private int mValueTextSize = 20;
        private int mValue2TextSize = 22;
        private int mLineTextSize = 18;
        private int mTitleTextSize = 40;
        private bool titleBold = true;
        private int mOffsetX = 210;
        private Smobiler.Plugins.CN6508PrintType mTitleType = Smobiler.Plugins.CN6508PrintType.Centering;
        private void btnclose_Press(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGoToNextPage_Press(object sender, EventArgs e)
        {
            cN65081.GoToNextPage((obj, args) =>
            {
                if (args.isError == true)
                    this.Toast("Error: " + args.error);
                else
                    this.Toast("success");
            });
        }

        private void btnPrintLineInit_Press(object sender, EventArgs e)
        {
            cN65081.PrintLineInit(18, (obj, args) =>
            {
                if (args.isError == true)
                    this.Toast("Error: " + args.error);
                else
                    this.Toast("success");
            });
        }

        private void btnPrintLineString_Press(object sender, EventArgs e)
        {
            cN65081.PrintLineString("111", 18, 0, true, (obj, args) =>
            {
                if (args.isError == true)
                    this.Toast("Error: " + args.error);
                else
                    this.Toast("success");
            });
        }

        private void btnPrintLineStringByType_Press(object sender, EventArgs e)
        {
            cN65081.PrintLineStringByType("1111", 18, Smobiler.Plugins.CN6508PrintType.Right, true, (obj, args) =>
            {
                if (args.isError == true)
                    this.Toast("Error: " + args.error);
                else
                    this.Toast("success");
            });
        }

        private void btnPrintStringEx_Press(object sender, EventArgs e)
        {
            cN65081.PrintStringEx("1111111111111111111111111111111111111111111111111111111111111", 18, true, true, Smobiler.Plugins.CN6508PrintType.Left, (obj, args) =>
            {
                if (args.isError == true)
                    this.Toast("Error: " + args.error);
                else
                    this.Toast("success");
            });
        }

        private void btnPrintLineEnd_Press(object sender, EventArgs e)
        {
            cN65081.PrintLineEnd((obj, args) =>
            {
                if (args.isError == true)
                    this.Toast("Error: " + args.error);
                else
                    this.Toast("success");
            });
        }

        private void btnprinteropen_Press(object sender, EventArgs e)
        {
            cN65081.Open((obj, args) =>
            {
                if (args.isError == true)
                    this.Toast("Error: " + args.error);
                else
                    this.Toast("success");
            });
        }

        private void btnprinterclose_Press(object sender, EventArgs e)
        {
            cN65081.Close((obj, args) =>
            {
                if (args.isError == true)
                    this.Toast("Error: " + args.error);
                else
                    this.Toast("success");
            });
        }

        private void btndemoprint_Press(object sender, EventArgs e)
        {
            cN65081.PrintStringEx("Printer test", mTitleTextSize, false, titleBold, mTitleType);
            String str = "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~";
            cN65081.PrintLineInit(mLineTextSize);
            cN65081.PrintLineStringByType(str, mLineTextSize, Smobiler.Plugins.CN6508PrintType.Centering, false);
            cN65081.PrintLineEnd();
            cN65081.PrintLineInit(mKeyTextSize);
            cN65081.PrintLineStringByType("Type", mKeyTextSize, Smobiler.Plugins.CN6508PrintType.Left, true);
            cN65081.PrintLineString("Industrial Android ", mValueTextSize, mOffsetX, false);//160
            cN65081.PrintLineEnd();
            cN65081.PrintLineInit(mKeyTextSize);
            cN65081.PrintLineString("Intelligent Terminal", mValueTextSize, mOffsetX, false);//160
            cN65081.PrintLineEnd();
            cN65081.PrintLineInit(mKeyTextSize);
            cN65081.PrintLineStringByType("Time to market", mKeyTextSize, Smobiler.Plugins.CN6508PrintType.Left, true);
            cN65081.PrintLineString("Year 2015", mValue2TextSize, mOffsetX, false);//160
            cN65081.PrintLineEnd();
            cN65081.PrintLineInit(mKeyTextSize);
            cN65081.PrintLineStringByType("Dimension", mKeyTextSize, Smobiler.Plugins.CN6508PrintType.Left, true);
            cN65081.PrintLineString("205.5*87*39mm", mValue2TextSize, mOffsetX, false);//160
            cN65081.PrintLineEnd();
            cN65081.PrintLineInit(mKeyTextSize);
            cN65081.PrintLineStringByType("CPU", mKeyTextSize, Smobiler.Plugins.CN6508PrintType.Left, true);
            cN65081.PrintLineString("Quad-core", mValue2TextSize, mOffsetX, false);//160
            cN65081.PrintLineEnd();
            cN65081.PrintLineInit(mKeyTextSize);
            cN65081.PrintLineStringByType("Operation System", mKeyTextSize, Smobiler.Plugins.CN6508PrintType.Left, true);
            cN65081.PrintLineString("Android 5.1.1", mValue2TextSize, mOffsetX, false);//160
            cN65081.PrintLineEnd();
            cN65081.PrintLineInit(mKeyTextSize);
            cN65081.PrintLineStringByType("Thermal printer", mKeyTextSize, Smobiler.Plugins.CN6508PrintType.Left, true);
            cN65081.PrintLineString(" 2'' 384dots ", mValue2TextSize, mOffsetX, false);//160
            cN65081.PrintLineEnd();
            cN65081.PrintLineInit(mKeyTextSize);
            //cN65081.PrintLineString("Thermal printer", mKeyTextSize, PrintType.Left, true);
            cN65081.PrintLineString("thermal printer ", mValue2TextSize, mOffsetX, false);//160
            cN65081.PrintLineEnd();
            cN65081.PrintLineInit(mKeyTextSize);

            cN65081.PrintLineInit(mKeyTextSize);
            cN65081.PrintLineStringByType("Standby time", mKeyTextSize, Smobiler.Plugins.CN6508PrintType.Left, true);
            cN65081.PrintLineString("72hours", mValue2TextSize, mOffsetX, false);//160
            cN65081.PrintLineEnd();
            cN65081.PrintLineInit(mLineTextSize);
            //        cN65081.PrintLineString(str, mLineTextSize, PrintType.Centering, true);
            //        cN65081.PrintLineEnd();
            cN65081.PrintLineInit(mKeyTextSize);
            cN65081.PrintLineStringByType("Working temperature", mKeyTextSize, Smobiler.Plugins.CN6508PrintType.Left, true);
            cN65081.PrintLineStringByType("-25~65℃", mKeyTextSize, Smobiler.Plugins.CN6508PrintType.Right, false);//160
            cN65081.PrintLineEnd();
            cN65081.PrintLineInit(mKeyTextSize);
            cN65081.PrintLineStringByType("Storage temperature", mKeyTextSize, Smobiler.Plugins.CN6508PrintType.Left, true);
            cN65081.PrintLineStringByType("-30~70 ℃", mKeyTextSize, Smobiler.Plugins.CN6508PrintType.Right, false);//160
            cN65081.PrintLineEnd();
            cN65081.PrintLineInit(mKeyTextSize);
            cN65081.PrintLineStringByType("Humidity", mKeyTextSize, Smobiler.Plugins.CN6508PrintType.Left, true);
            cN65081.PrintLineStringByType("0~95%", mKeyTextSize, Smobiler.Plugins.CN6508PrintType.Right, false);//160
            cN65081.PrintLineEnd();
            cN65081.PrintLineInit(mLineTextSize);
            cN65081.PrintLineStringByType(str, mLineTextSize, Smobiler.Plugins.CN6508PrintType.Centering, false);
            cN65081.PrintLineEnd();
        }

        private void btnPrintBitmapAtHorizontalCenter_Press(object sender, EventArgs e)
        {
            //图片转为byte[]
            byte[] bytes = { };
            //在一个水平方向居中打印图片
            cN65081.PrintBitmapAtHorizontalCenter(bytes);
        }

        private void btnPrintBitmap_Press(object sender, EventArgs e)
        {
            //图片转为byte[]
            byte[] bytes = { };
            //x\y轴
            int x = 0;
            int y = 0;
            //设置x、y轴打印图片
            cN65081.PrintBitmap(bytes,x,y);
        }

        private void btnPrintBitmapAtCenter_Press(object sender, EventArgs e)
        {
            //图片转为byte[]
            byte[] bytes = { };
            //可供打印的区域高度
            int labelHeight = 100;
            int labelWidth = 100;
            //在水平和垂直方向居中打印图片
            cN65081.PrintBitmapAtCenter(bytes, labelHeight, labelWidth);
        }

        private void btnDoHardwarePrint_Press(object sender, EventArgs e)
        {
            //图片转为byte[]
            byte[] bytes = { };
            //直接打印一个图片
            cN65081.DoHardwarePrint(bytes);
        }
    }
}