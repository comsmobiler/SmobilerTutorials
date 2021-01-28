using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Plugins
{
    partial class demoCN6508Printer : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm
        //It can be modified using the SmobilerForm.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.title = new Smobiler.Core.Controls.Label();
            this.btndemoprint = new Smobiler.Core.Controls.Button();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.btnFormclose = new Smobiler.Core.Controls.Button();
            this.btnprinteropen = new Smobiler.Core.Controls.Button();
            this.btnprinterclose = new Smobiler.Core.Controls.Button();
            this.btnGoToNextPage = new Smobiler.Core.Controls.Button();
            this.btnPrintLineInit = new Smobiler.Core.Controls.Button();
            this.btnPrintLineString = new Smobiler.Core.Controls.Button();
            this.btnPrintLineStringByType = new Smobiler.Core.Controls.Button();
            this.btnPrintStringEx = new Smobiler.Core.Controls.Button();
            this.btnPrintLineEnd = new Smobiler.Core.Controls.Button();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.cN65081 = new Smobiler.Plugins.CN6508();
            this.btnPrintBitmapAtHorizontalCenter = new Smobiler.Core.Controls.Button();
            this.btnPrintBitmap = new Smobiler.Core.Controls.Button();
            this.btnPrintBitmapAtCenter = new Smobiler.Core.Controls.Button();
            this.btnDoHardwarePrint = new Smobiler.Core.Controls.Button();
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(0, 8);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(300, 35);
            this.title.Text = "打印功能";
            // 
            // btndemoprint
            // 
            this.btndemoprint.Location = new System.Drawing.Point(176, 109);
            this.btndemoprint.Name = "btndemoprint";
            this.btndemoprint.Size = new System.Drawing.Size(116, 37);
            this.btndemoprint.Text = "demo打印";
            this.btndemoprint.Press += new System.EventHandler(this.btndemoprint_Press);
            // 
            // label1
            // 
            this.label1.FontSize = 14F;
            this.label1.Location = new System.Drawing.Point(0, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 39);
            this.label1.Text = "点击按钮开始demo打印";
            // 
            // btnFormclose
            // 
            this.btnFormclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(67)))), ((int)(((byte)(80)))));
            this.btnFormclose.Location = new System.Drawing.Point(52, 463);
            this.btnFormclose.Name = "btnFormclose";
            this.btnFormclose.Size = new System.Drawing.Size(196, 30);
            this.btnFormclose.Text = "返回";
            this.btnFormclose.Press += new System.EventHandler(this.btnclose_Press);
            // 
            // btnprinteropen
            // 
            this.btnprinteropen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(80)))));
            this.btnprinteropen.Location = new System.Drawing.Point(22, 52);
            this.btnprinteropen.Name = "btnprinteropen";
            this.btnprinteropen.Size = new System.Drawing.Size(114, 36);
            this.btnprinteropen.Text = "开启打印服务";
            this.btnprinteropen.Press += new System.EventHandler(this.btnprinteropen_Press);
            // 
            // btnprinterclose
            // 
            this.btnprinterclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(229)))), ((int)(((byte)(100)))));
            this.btnprinterclose.Location = new System.Drawing.Point(174, 52);
            this.btnprinterclose.Name = "btnprinterclose";
            this.btnprinterclose.Size = new System.Drawing.Size(110, 36);
            this.btnprinterclose.Text = "关闭打印服务";
            this.btnprinterclose.Press += new System.EventHandler(this.btnprinterclose_Press);
            // 
            // btnGoToNextPage
            // 
            this.btnGoToNextPage.Location = new System.Drawing.Point(174, 158);
            this.btnGoToNextPage.Name = "btnGoToNextPage";
            this.btnGoToNextPage.Size = new System.Drawing.Size(120, 30);
            this.btnGoToNextPage.Text = "GoToNextPage";
            this.btnGoToNextPage.Press += new System.EventHandler(this.btnGoToNextPage_Press);
            // 
            // btnPrintLineInit
            // 
            this.btnPrintLineInit.Location = new System.Drawing.Point(174, 199);
            this.btnPrintLineInit.Name = "btnPrintLineInit";
            this.btnPrintLineInit.Size = new System.Drawing.Size(120, 30);
            this.btnPrintLineInit.Text = "PrintLineInit";
            this.btnPrintLineInit.Press += new System.EventHandler(this.btnPrintLineInit_Press);
            // 
            // btnPrintLineString
            // 
            this.btnPrintLineString.Location = new System.Drawing.Point(212, 245);
            this.btnPrintLineString.Name = "btnPrintLineString";
            this.btnPrintLineString.Size = new System.Drawing.Size(82, 30);
            this.btnPrintLineString.Text = "PrintLineString";
            this.btnPrintLineString.Press += new System.EventHandler(this.btnPrintLineString_Press);
            // 
            // btnPrintLineStringByType
            // 
            this.btnPrintLineStringByType.Location = new System.Drawing.Point(126, 245);
            this.btnPrintLineStringByType.Name = "btnPrintLineStringByType";
            this.btnPrintLineStringByType.Size = new System.Drawing.Size(84, 30);
            this.btnPrintLineStringByType.Text = "PrintLineStringByType";
            this.btnPrintLineStringByType.Press += new System.EventHandler(this.btnPrintLineStringByType_Press);
            // 
            // btnPrintStringEx
            // 
            this.btnPrintStringEx.Location = new System.Drawing.Point(174, 287);
            this.btnPrintStringEx.Name = "btnPrintStringEx";
            this.btnPrintStringEx.Size = new System.Drawing.Size(120, 30);
            this.btnPrintStringEx.Text = "PrintStringEx";
            this.btnPrintStringEx.Press += new System.EventHandler(this.btnPrintStringEx_Press);
            // 
            // btnPrintLineEnd
            // 
            this.btnPrintLineEnd.Location = new System.Drawing.Point(176, 333);
            this.btnPrintLineEnd.Name = "btnPrintLineEnd";
            this.btnPrintLineEnd.Size = new System.Drawing.Size(120, 30);
            this.btnPrintLineEnd.Text = "PrintLineEnd";
            this.btnPrintLineEnd.Press += new System.EventHandler(this.btnPrintLineEnd_Press);
            // 
            // label2
            // 
            this.label2.FontSize = 14F;
            this.label2.Location = new System.Drawing.Point(0, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 35);
            this.label2.Text = "送纸";
            // 
            // label3
            // 
            this.label3.FontSize = 14F;
            this.label3.Location = new System.Drawing.Point(0, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 32);
            this.label3.Text = "打印单行文本之前调用";
            // 
            // label4
            // 
            this.label4.FontSize = 14F;
            this.label4.Location = new System.Drawing.Point(0, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 35);
            this.label4.Text = "绘制单行文本";
            // 
            // label5
            // 
            this.label5.FontSize = 14F;
            this.label5.Location = new System.Drawing.Point(0, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 35);
            this.label5.Text = "打印长文本，文本较长时，可换行打印。";
            // 
            // label6
            // 
            this.label6.FontSize = 14F;
            this.label6.Location = new System.Drawing.Point(0, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 35);
            this.label6.Text = "打印绘制好的单行文本。";
            // 
            // cN65081
            // 
            this.cN65081.Name = "cN65081";
            // 
            // btnPrintBitmapAtHorizontalCenter
            // 
            this.btnPrintBitmapAtHorizontalCenter.Location = new System.Drawing.Point(0, 378);
            this.btnPrintBitmapAtHorizontalCenter.Name = "btnPrintBitmapAtHorizontalCenter";
            this.btnPrintBitmapAtHorizontalCenter.Size = new System.Drawing.Size(140, 30);
            this.btnPrintBitmapAtHorizontalCenter.Text = "PrintBitmapAtHorizontalCenter";
            this.btnPrintBitmapAtHorizontalCenter.Press += new System.EventHandler(this.btnPrintBitmapAtHorizontalCenter_Press);
            // 
            // btnPrintBitmap
            // 
            this.btnPrintBitmap.Location = new System.Drawing.Point(156, 378);
            this.btnPrintBitmap.Name = "btnPrintBitmap";
            this.btnPrintBitmap.Size = new System.Drawing.Size(140, 30);
            this.btnPrintBitmap.Text = "PrintBitmap";
            this.btnPrintBitmap.Press += new System.EventHandler(this.btnPrintBitmap_Press);
            // 
            // btnPrintBitmapAtCenter
            // 
            this.btnPrintBitmapAtCenter.Location = new System.Drawing.Point(0, 422);
            this.btnPrintBitmapAtCenter.Name = "btnPrintBitmapAtCenter";
            this.btnPrintBitmapAtCenter.Size = new System.Drawing.Size(140, 30);
            this.btnPrintBitmapAtCenter.Text = "PrintBitmapAtCenter";
            this.btnPrintBitmapAtCenter.Press += new System.EventHandler(this.btnPrintBitmapAtCenter_Press);
            // 
            // btnDoHardwarePrint
            // 
            this.btnDoHardwarePrint.Location = new System.Drawing.Point(156, 422);
            this.btnDoHardwarePrint.Name = "btnDoHardwarePrint";
            this.btnDoHardwarePrint.Size = new System.Drawing.Size(140, 30);
            this.btnDoHardwarePrint.Text = "DoHardwarePrint";
            this.btnDoHardwarePrint.Press += new System.EventHandler(this.btnDoHardwarePrint_Press);
            // 
            // demoCN6508Printer
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.cN65081});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title,
            this.btndemoprint,
            this.label1,
            this.btnFormclose,
            this.btnprinteropen,
            this.btnprinterclose,
            this.btnGoToNextPage,
            this.btnPrintLineInit,
            this.btnPrintLineString,
            this.btnPrintLineStringByType,
            this.btnPrintStringEx,
            this.btnPrintLineEnd,
            this.label2,
            this.label3,
            this.label4,
            this.label5,
            this.label6,
            this.btnPrintBitmapAtHorizontalCenter,
            this.btnPrintBitmap,
            this.btnPrintBitmapAtCenter,
            this.btnDoHardwarePrint});
            this.Name = "demoCN6508Printer";

        }
        #endregion

        private Smobiler.Core.Controls.Label title;
        private Smobiler.Core.Controls.Button btndemoprint;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Button btnFormclose;
        private Smobiler.Core.Controls.Button btnprinteropen;
        private Smobiler.Core.Controls.Button btnprinterclose;
        private Smobiler.Core.Controls.Button btnGoToNextPage;
        private Smobiler.Core.Controls.Button btnPrintLineInit;
        private Smobiler.Core.Controls.Button btnPrintLineString;
        private Smobiler.Core.Controls.Button btnPrintLineStringByType;
        private Smobiler.Core.Controls.Button btnPrintStringEx;
        private Smobiler.Core.Controls.Button btnPrintLineEnd;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Label label4;
        private Smobiler.Core.Controls.Label label5;
        private Smobiler.Core.Controls.Label label6;
        private Smobiler.Plugins.CN6508 cN65081;
        private Smobiler.Core.Controls.Button btnPrintBitmapAtHorizontalCenter;
        private Smobiler.Core.Controls.Button btnPrintBitmap;
        private Smobiler.Core.Controls.Button btnPrintBitmapAtCenter;
        private Smobiler.Core.Controls.Button btnDoHardwarePrint;
    }
}