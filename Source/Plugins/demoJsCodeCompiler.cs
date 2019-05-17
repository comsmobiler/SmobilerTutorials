using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using Smobiler.Plugins;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoJsCodeCompiler : Smobiler.Core.Controls.MobileForm
    {
        public demoJsCodeCompiler() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void button1_Press(object sender, EventArgs e)
        {
            //Js震动功能,可先网上搜索代码
            JsCodeProvider provider = new JsCodeProvider();
            provider.MethodBody = @"
                if(platform.Vibration){platform.Vibration.vibrate(2000);} if(value == 2) return ""执行成功""; else return ""执行失败"";";
            //Run方法中provider参数填写代码，value参数对应provider参数中用户自行添加的变量value
            this.jsCodeCompiler1.Run(provider, 2, (obj, args) =>
            {
                if (args.isError == true)
                    MessageBox.Show(args.error);
                else
                    Toast("Sucess");
            });
        }
    }
}