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
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(18, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 203);
            this.label1.Text = "安卓震动功能,可先网上搜索头文件与代码.\r\n添加androidCodeCompiler组件\r\n可使用方法Compile（预编译）\r\nRun（编译并执行）\r\n\r\n";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.Text = "震动";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // androidCodeCompiler1
            // 
            this.androidCodeCompiler1.Name = "androidCodeCompiler1";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(18, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 35);
            this.label2.Text = "此插件仅支持android";
            // 
            // demoAndroidCodeCompiler
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.androidCodeCompiler1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.button1,
            this.label2});
            this.Name = "demoAndroidCodeCompiler";

        }
        #endregion
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Button button1;
        private Smobiler.Plugins.AndroidCodeCompiler androidCodeCompiler1;
        private Smobiler.Core.Controls.Label label2;
    }
}