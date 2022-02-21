using Smobiler.Core;
using System;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoDingDingApi : Smobiler.Core.Controls.MobileForm
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
            this.title1 = new Smobiler.Core.Controls.Title();
            this.button5 = new Smobiler.Core.Controls.Button();
            this.button2 = new Smobiler.Core.Controls.Button();
            this.button3 = new Smobiler.Core.Controls.Button();
            this.button4 = new Smobiler.Core.Controls.Button();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.button6 = new Smobiler.Core.Controls.Button();
            this.button7 = new Smobiler.Core.Controls.Button();
            this.dingDingApi1 = new Smobiler.Plugins.DingDingApi();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.labe = new Smobiler.Core.Controls.Label();
            this.label7 = new Smobiler.Core.Controls.Label();
            // 
            // title1
            // 
            this.title1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.title1.Name = "title1";
            this.title1.ResourceID = "angle-left";
            this.title1.Size = new System.Drawing.Size(300, 30);
            this.title1.Text = "DingdingApi";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(146, 115);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(131, 35);
            this.button5.Text = "SelectMethod";
            this.button5.Press += new System.EventHandler(this.button5_Press);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(146, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 35);
            this.button2.Text = "scan";
            this.button2.Press += new System.EventHandler(this.button2_Press);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(146, 270);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 35);
            this.button3.Text = "getLocation ";
            this.button3.Press += new System.EventHandler(this.button3_Press);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(146, 219);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 35);
            this.button4.Text = "openSingleChat ";
            this.button4.Press += new System.EventHandler(this.button4_Press);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 35);
            this.button1.Text = "config";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(144, 320);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(133, 35);
            this.button6.Text = "externalComplexPicker ";
            this.button6.Press += new System.EventHandler(this.button6_Press);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(142, 377);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(135, 35);
            this.button7.Text = "login";
            this.button7.Press += new System.EventHandler(this.button7_Press);
            // 
            // dingDingApi1
            // 
            this.dingDingApi1.AgentID = null;
            this.dingDingApi1.AppID = null;
            this.dingDingApi1.AppSecret = null;
            this.dingDingApi1.CorpID = null;
            this.dingDingApi1.Name = "dingDingApi1";
            this.dingDingApi1.Afterlogin += new Smobiler.Plugins.DingTalkApiLoginEventHandler(this.dingDingApi1_Afterlogin);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(11, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 46);
            this.label1.Text = "JSAPI鉴权， 后续大部分api均需要此配置成功后才能调用";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(11, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 35);
            this.label2.Text = "打开与指定用户的单聊会话";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(11, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 35);
            this.label3.Text = "获取当前地理位置信息（单次定位）";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(11, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 35);
            this.label4.Text = "选择外部联系人";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(11, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 35);
            this.label5.Text = "钉钉免登";
            // 
            // labe
            // 
            this.labe.Location = new System.Drawing.Point(11, 115);
            this.labe.Name = "labe";
            this.labe.Size = new System.Drawing.Size(114, 35);
            this.labe.Text = "选择要调用的方法";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(11, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 35);
            this.label7.Text = "钉钉扫码";
            // 
            // demoDingDingApi
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.dingDingApi1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.button5,
            this.button2,
            this.button3,
            this.button4,
            this.button1,
            this.button6,
            this.button7,
            this.label1,
            this.label2,
            this.label3,
            this.label4,
            this.label5,
            this.labe,
            this.label7});
            this.Load += new System.EventHandler(this.demoDingDingApi_Load);
            this.Name = "demoDingDingApi";

        }
        #endregion

        private Core.Controls.Title title1;
        private Core.Controls.Button button5;
        private Core.Controls.Button button2;
        private Core.Controls.Button button3;
        private Core.Controls.Button button4;
        private Core.Controls.Button button1;
        private Core.Controls.Button button6;
        private Core.Controls.Button button7;
        private Smobiler.Plugins.DingDingApi dingDingApi1;
        private Core.Controls.Label label1;
        private Core.Controls.Label label2;
        private Core.Controls.Label label3;
        private Core.Controls.Label label4;
        private Core.Controls.Label label5;
        private Core.Controls.Label labe;
        private Core.Controls.Label label7;
    }
}