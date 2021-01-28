using Smobiler.Core;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoAndroidCodeCompiler : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm Designer generated code "

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm Designer
        //It can be modified using the SmobilerForm Designer.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.label1 = new Smobiler.Core.Controls.Label();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.androidCodeCompiler1 = new Smobiler.Plugins.AndroidCodeCompiler();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.title1 = new Smobiler.Core.Controls.Title();
            this.button2 = new Smobiler.Core.Controls.Button();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.btngetOcrRegister = new Smobiler.Core.Controls.Button();
            this.btngetOcrParams = new Smobiler.Core.Controls.Button();
            this.btnIDCardParams = new Smobiler.Core.Controls.Button();
            // 
            // label1
            // 
            this.label1.FontSize = 15F;
            this.label1.Location = new System.Drawing.Point(18, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 203);
            this.label1.Text = "安卓震动功能,可先网上搜索头文件与代码.\r\n添加androidCodeCompiler组件\r\n可使用方法Compile（预编译）\r\nRun（编译并执行）\r\n\r\n";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(67)))), ((int)(((byte)(81)))));
            this.button1.Location = new System.Drawing.Point(18, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.Text = "震动";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // androidCodeCompiler1
            // 
            this.androidCodeCompiler1.Name = "androidCodeCompiler1";
            this.androidCodeCompiler1.AndroidCodeCompilerResult += new Smobiler.Plugins.AndroidCodeCompilerEventHandler(this.androidCodeCompiler1_AndroidCodeCompilerResult);
            // 
            // label2
            // 
            this.label2.FontSize = 15F;
            this.label2.Location = new System.Drawing.Point(18, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 35);
            this.label2.Text = "此插件仅支持android";
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "AndroidCodeCompiler";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(229)))), ((int)(((byte)(100)))));
            this.button2.Location = new System.Drawing.Point(186, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.Text = "打开微信";
            this.button2.Press += new System.EventHandler(this.button2_Press);
            // 
            // label3
            // 
            this.label3.FontSize = 15F;
            this.label3.Location = new System.Drawing.Point(18, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 43);
            this.label3.Text = "百度OCR:需要注册百度OCR https://cloud.baidu.com/";
            // 
            // btngetOcrRegister
            // 
            this.btngetOcrRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(176)))), ((int)(((byte)(250)))));
            this.btngetOcrRegister.Location = new System.Drawing.Point(18, 396);
            this.btngetOcrRegister.Name = "btngetOcrRegister";
            this.btngetOcrRegister.Size = new System.Drawing.Size(100, 30);
            this.btngetOcrRegister.Text = "注册";
            this.btngetOcrRegister.Press += new System.EventHandler(this.btngetOcrRegister_Press);
            // 
            // btngetOcrParams
            // 
            this.btngetOcrParams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(80)))));
            this.btngetOcrParams.Location = new System.Drawing.Point(186, 396);
            this.btngetOcrParams.Name = "btngetOcrParams";
            this.btngetOcrParams.Size = new System.Drawing.Size(100, 30);
            this.btngetOcrParams.Text = "文字识别";
            this.btngetOcrParams.Press += new System.EventHandler(this.btngetOcrParams_Press);
            // 
            // btnIDCardParams
            // 
            this.btnIDCardParams.Location = new System.Drawing.Point(102, 443);
            this.btnIDCardParams.Name = "btnIDCardParams";
            this.btnIDCardParams.Size = new System.Drawing.Size(100, 30);
            this.btnIDCardParams.Text = "身份证识别";
            this.btnIDCardParams.Press += new System.EventHandler(this.btnIDCardParams_Press);
            // 
            // demoAndroidCodeCompiler
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.androidCodeCompiler1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.button1,
            this.label2,
            this.title1,
            this.button2,
            this.label3,
            this.btngetOcrRegister,
            this.btngetOcrParams,
            this.btnIDCardParams});
            this.Name = "demoAndroidCodeCompiler";

        }
        #endregion
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Button button1;
        private Smobiler.Plugins.AndroidCodeCompiler androidCodeCompiler1;
        private Smobiler.Core.Controls.Label label2;
        private Core.Controls.Title title1;
        private Core.Controls.Button button2;
        private Core.Controls.Label label3;
        private Core.Controls.Button btngetOcrRegister;
        private Core.Controls.Button btngetOcrParams;
        private Core.Controls.Button btnIDCardParams;
    }
}