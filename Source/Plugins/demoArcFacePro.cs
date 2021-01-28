using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using Smobiler.Plugins;
namespace Smobiler.Tutorials.Plugins
{
    partial class demoArcFacePro: Smobiler.Core.Controls.MobileForm
    {
        public demoArcFacePro() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        //http://www.arcsoft.com.cn/ai/user/userlogin?source=/ai/usercenter/index
        //需要申请虹软开发者账号，使用云平台打包插件sm_arcface

        private void btnregisterFace_Press(object sender, EventArgs e)
        {
            arcFace1.Register(textBox1.Text, (s, args) =>
            {
                label1.Text+= "Error:"+args.error+"   isError:"+args.isError + System.Environment.NewLine;
            });
        }

        private void btnrecognitionFace_Press(object sender, EventArgs e)
        {
            arcFace1.Recognize();
        }

        private void btnexistFace_Press(object sender, EventArgs e)
        {
            arcFace1.Exist(textBox1.Text, (s, args) => { label1.Text+= "Exist:"+args.Exist +"  Error:"+args.Error+System.Environment.NewLine; });
        }

        private void btndeleteFace_Press(object sender, EventArgs e)
        {
            arcFace1.Delete(textBox1.Text, (s, args) => { label1.Text +="Error:"+ args.error +"   isError:"+args.isError + System.Environment.NewLine; });
        }

        private void arcFace1_FacialRecognized(object sender, Smobiler.Plugins.FacialRecognizedEventArgs e)
        {
            Toast("Name:"+e.Name+"  Score:"+e.Score+"  Error"+e.Error);
        }


        private void btnliveness_Press(object sender, EventArgs e)
        {
            arcFace1.Recognize(true);
        }

        private void btnactiveonline_Press(object sender, EventArgs e)
        {
            arcFace1.ActiveOnline("填写虹软APP ID ", "填写虹软SDK KEY", "填写虹软设备激活码", (s, args) =>
            {
                label1.Text += "Error:" + args.error + "   isError:" + args.isError + System.Environment.NewLine;
                Toast(args.isError.ToString());
            });
        }
        private string mName = ""; 
        private byte[] mFeature = { };

        private void arcFace1_FacialRegistered(object sender, Smobiler.Plugins.FacialRegisteredEventArgs e)
        {
            Toast("Name:" + e.Name);
            mName = e.Name;
            mFeature = e.Feature;
        }

        private void add_Press(object sender, EventArgs e)
        {
            Add();
        }
        int j = 0;
        public void Add()
        {
            ArcFaceFeatures face1 = new ArcFaceFeatures(mName, mFeature);
            ArcFaceFeatures[] faces = new ArcFaceFeatures[50];
            if (j < 30)
            {
                for (int i = 0; i < 50; i++)
                {
                    faces[i] = face1;
                }
                arcFace1.AddFeatures(faces, (s, args) =>
            {
                label1.Text += "Error:" + args.error + "   isError:" + args.isError + System.Environment.NewLine;
                Add();
                ++j;
            });
            }else
            {
                j = 0;
            }

        }

        private void arcFace1_ImageCaptured(object sender, BinaryResultArgs e)
        {
            e.SaveFile("peter.png");
            image1.ResourceID = "peter.png";
        }

        private void btnClear_Press(object sender, EventArgs e)
        {
            arcFace1.Clear((s, args) =>
            {
                label1.Text += "Error:" + args.error + "   isError:" + args.isError + System.Environment.NewLine;
            });
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}