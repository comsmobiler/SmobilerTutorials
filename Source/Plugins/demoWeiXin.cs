using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using Smobiler.Plugins;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoWeiXin : Smobiler.Core.Controls.MobileForm
    {
        public demoWeiXin()
            : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void demoWeiXin_Load(object sender, EventArgs e)
        {
            ListMenuViewGroup g1 = new ListMenuViewGroup();
            g1.AddItem("logon", "注册", "Reg", "");
            g1.AddItem("logon", "支付", "Pay", "");
            g1.AddItem("logon", "ShareNews", "ShareNews", "");
            g1.AddItem("logon", "ShareText", "ShareText", "");
            g1.AddItem("logon", "ShareImage", "ShareImage", "");
            g1.AddItem("logon", "ShareVideo", "ShareVideo", "");
            g1.AddItem("logon", "ShareAudio", "ShareAudio", "");
            g1.AddItem("logon", "TimeLineNews", "TimeLineNews", "");
            g1.AddItem("logon", "TimeLineText", "TimeLineText", "");
            g1.AddItem("logon", "TimeLineImage", "TimeLineImage", "");
            g1.AddItem("logon", "TimeLineVideo", "TimeLineVideo", "");
            g1.AddItem("logon", "TimeLineAudio", "TimeLineAudio", "");
            listMenuView1.Groups.Add(g1);
        }

        private void listMenuView1_ItemPress(object sender, ListMenuViewItemPressEventArgs e)
        {
            WeiXinShareEntity entity;
            switch (e.Item.SubContent)
            {
                case "Reg":
                    this.weiXin1.registerApp("");
                    break;
                case "Pay":
                    Show(new demoWeixinPay());
                    break;
                case "ShareNews":
                    entity = new WeiXinShareNewsEntity("百度一下你就知道News", "百度一下你就知道", "https://www.baidu.com/");
                    this.weiXin1.shareToSession(entity, HandleWeiXinRPCResult);
                    break;
                case "ShareText":
                    entity = new WeiXinShareTextEntity("这是一个分享标题Text", "这是一个分享文本", "http://www.smobiler.com/images/index/logo.png");
                    this.weiXin1.shareToSession(entity, HandleWeiXinRPCResult);
                    break;
                case "ShareImage":
                    entity = new WeiXinShareImageEntity("这是一个分享标题Image", "这是一个分享文本", "http://www.smobiler.com/images/index/logo.png");
                    this.weiXin1.shareToSession(entity, HandleWeiXinRPCResult);
                    break;
                case "ShareVideo":
                    entity = new WeiXinShareVideoEntity("这是一个分享标题Video", "这是一个分享文本", "http://www.smobiler.com/images/index/logo.png");
                    this.weiXin1.shareToSession(entity, HandleWeiXinRPCResult);
                    break;
                case "ShareAudio":
                    entity = new WeiXinShareAudioEntity("这是一个分享标题Audio", "这是一个分享文本", "http://www.smobiler.com/images/index/logo.png");
                    this.weiXin1.shareToSession(entity, HandleWeiXinRPCResult);
                    break;
                case "TimeLineNews":
                    entity = new WeiXinShareNewsEntity("百度一下你就知道News", "百度一下你就知道", "https://www.baidu.com/");
                    this.weiXin1.shareToTimeline(entity, HandleWeiXinRPCResult);
                    break;
                case "TimeLineText":
                    entity = new WeiXinShareTextEntity("这是一个分享标题Text", "这是一个分享文本", "http://www.smobiler.com/images/index/logo.png");
                    this.weiXin1.shareToTimeline(entity, HandleWeiXinRPCResult);
                    break;
                case "TimeLineImage":
                    entity = new WeiXinShareImageEntity("这是一个分享标题Image", "这是一个分享文本", "http://www.smobiler.com/images/index/logo.png");
                    this.weiXin1.shareToTimeline(entity, HandleWeiXinRPCResult);
                    break;
                case "TimeLineVideo":
                    entity = new WeiXinShareVideoEntity("这是一个分享标题Video", "这是一个分享文本", "http://www.smobiler.com/images/index/logo.png");
                    this.weiXin1.shareToTimeline(entity, HandleWeiXinRPCResult);
                    break;
                case "TimeLineAudio":
                    entity = new WeiXinShareAudioEntity("这是一个分享标题Audio", "这是一个分享文本", "http://www.smobiler.com/images/index/logo.png");
                    this.weiXin1.shareToTimeline(entity, HandleWeiXinRPCResult);
                    break;
            }
        }
        private void HandleWeiXinRPCResult(object sender, Smobiler.Core.RPC.RPCResultArgs e)
        {
            this.Toast(string.Format("isError{0},error{1},errorCode{2}", e.isError, e.error, e.errorCode));
        }
    }
}