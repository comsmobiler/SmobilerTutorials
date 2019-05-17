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
            //platform相关功能详见 https://reactnative.cn/docs/vibration/ 里面的 API
            provider.MethodBody = @"
                if(platform.Vibration){
                    platform.Vibration.vibrate(value);
                } else{
                    return ""Vibration null"";
                }";
            //Run方法中provider参数填写代码，value参数对应provider参数中用户自行添加的变量value
            //由于在iOS上无法设置震动的持续时间,下面value参数只做参考
            this.jsCodeCompiler1.Run(provider, 2000, (obj, args) =>
            {
                if (args.isError == true)
                    MessageBox.Show(args.error);
                else
                    Toast("Sucess");
            });
        }
    }
}