using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoArcFace : Smobiler.Core.Controls.MobileForm
    {
        public demoArcFace() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        //https://ai.arcsoft.com.cn/
        //需要申请虹软开发者账号，使用云平台打包插件sm_arcface

        private string message;
        private void btnregisterFace_Press(object sender, EventArgs e)
        {
            arcFace1.Register(textBox1.Text, (s, args) =>
            {
                if (args.isError == false)
                    message = "注册人脸成功";
                else
                    message = "";
                label1.Text += message + "Error:" + args.error + "   isError:" + args.isError  + System.Environment.NewLine;
            });
        }
        private void btnrecognitionFace_Press(object sender, EventArgs e)
        {
            arcFace1.Recognize();
        }
        private void btnexistFace_Press(object sender, EventArgs e)
        {
            arcFace1.Exist(textBox1.Text, (s, args) => 
            {
                if (args.Exist == true)
                    message = "检测到有此人脸数据";
                else
                    message = "未检测到有此人脸数据";
                label1.Text += message+"Exist:" + args.Exist + "  Error:" + args.Error   + System.Environment.NewLine;
            });
        }

        private void btndeleteFace_Press(object sender, EventArgs e)
        {
            arcFace1.Delete(textBox1.Text, (s, args) => 
            {
                if (args.isError == false)
                    message = "删除人脸数据成功";
                else
                    message = "";
                label1.Text += message + "Error:" + args.error + "   isError:" + args.isError + System.Environment.NewLine;
            });
        }

        private void arcFace1_FacialRecognized(object sender, Smobiler.Plugins.FacialRecognizedEventArgs e)
        {
            Toast("Name:" + e.Name + "  Score:" + e.Score + "  Error" + e.Error);
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}