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

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Press(object sender, EventArgs e)
        {

            AndroidCodeProvider provider = new AndroidCodeProvider();
            provider.Imports.Add("android.content.Intent;");
            provider.Imports.Add("android.content.ComponentName;");
            provider.MethodBody = @"    
            Intent intent = new Intent(Intent.ACTION_MAIN);
            ComponentName cmp = new ComponentName(""com.tencent.mm"",""com.tencent.mm.ui.LauncherUI"");
            intent.addCategory(Intent.CATEGORY_LAUNCHER);
            intent.addFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
            intent.setComponent(cmp);
            activity.startActivity(intent); ";
            this.androidCodeCompiler1.Run(provider, (obj, args) =>
            {
                if (args.isError == true)
                    MessageBox.Show(args.error);
                else
                    Toast("success");
            });
        }
    }
}