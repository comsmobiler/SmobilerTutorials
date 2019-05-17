using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using Smobiler.Plugins;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoAndroidCodeCompiler : Smobiler.Core.Controls.MobileForm
    {
        public demoAndroidCodeCompiler() : base()
        {
            InitializeComponent();
        }

        private void button1_Press(object sender, EventArgs e)
        {
            //安卓震动功能,可先网上搜索头文件与代码
            AndroidCodeProvider provider = new AndroidCodeProvider();
            provider.Imports.Add("android.os.Vibrator");
            provider.MethodBody = @"
                Vibrator vib = (Vibrator) activity.getSystemService(Service.VIBRATOR_SERVICE);
                vib.vibrate(200);
                resultValue=""success"";";
            //Run方法中provider参数填写代码，value参数对应provider参数中用户自行添加的变量value
            this.androidCodeCompiler1.Run(provider, (obj, args) =>
            {
                if (args.isError == true)
                    MessageBox.Show(args.error);
                else
                    Toast("Sucess");
            });
        }
    }
}