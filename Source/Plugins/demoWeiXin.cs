using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web.Script.Serialization;
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

        private string appid = ""; //微信开放平台审核通过的应用APPID（请登录open.weixin.qq.com查看，注意与公众号的APPID不同）
        private string secret = ""; //微信开放平台审核通过后的应用密钥AppSecret
        private string universalLink = ""; //由于苹果iOS 13系统版本安全升级,ios需要配置,具体可以查看https://developers.weixin.qq.com/doc/oplatform/Mobile_App/Access_Guide/iOS.html
        private const string accessTokenUrl = "https://api.weixin.qq.com/sns/oauth2/access_token"; //登陆获取access token
        private const string userinfoUrl = "https://api.weixin.qq.com/sns/userinfo"; //根据openid获取用户信息


        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void demoWeiXin_Load(object sender, EventArgs e)
        {
            ListMenuViewGroup g1 = new ListMenuViewGroup();
            g1.AddItem("logon", "注册", "Reg", "");
            g1.AddItem("logon", "登录", "Login", "");
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

            g1.AddItem("logon", "isWXAppInstalled", "isWXAppInstalled", "");
            g1.AddItem("logon", "isWXAppSupportApi", "isWXAppSupportApi", "");
            g1.AddItem("logon", "getWXAppInstallUrl", "getWXAppInstallUrl", "");
            g1.AddItem("logon", "getApiVersion", "getApiVersion", "");
            g1.AddItem("logon", "openWXApp", "openWXApp", "");
            listMenuView1.Groups.Add(g1);
        }

        private void listMenuView1_ItemPress(object sender, ListMenuViewItemPressEventArgs e)
        {
            WeiXinShareEntity entity;
            switch (e.Item.SubContent)
            {
                case "Reg":
                    this.weiXin1.registerApp(appid,(obj, args) => { }, universalLink);//每个设备只需注册一次,方法参数中的appid为微信平台注册应用的appid
                    break;
                case "Login":
                    WeiXinLogin();
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

                case "isWXAppInstalled":
                    this.weiXin1.isWXAppInstalled(HandleWeiXinRPCResult);
                    break;
                case "isWXAppSupportApi":
                    this.weiXin1.isWXAppSupportApi(HandleWeiXinRPCResult);
                    break;
                case "getWXAppInstallUrl":
                    this.weiXin1.getWXAppInstallUrl((s, ss) => { RedirectUrl(ss.args.ToString()); });
                    break;
                case "getApiVersion":
                    this.weiXin1.getApiVersion(HandleWeiXinRPCResult);
                    break;
                case "openWXApp":
                    this.weiXin1.openWXApp(HandleWeiXinRPCResult);
                    break;
            }
        }
        private void HandleWeiXinRPCResult(object sender, Smobiler.Core.Controls.ComponentResultArgs e)
        {
            this.Toast(string.Format("isError{0},error{1},errorCode{2}", e.isError, e.error, e.errorCode));
        }

        private void WeiXinLogin()
        {
            //参考 https://open.weixin.qq.com/cgi-bin/showdocument?action=dir_list&t=resource/res_list&verify=1&id=open1419317851&token=&lang=zh_CN
            //第一个参数为scope，获取用户个人信息则填写snsapi_userinfo
            //第二个参数为state，设置为一个随机数或应用信息即可，用于执行检验
            this.weiXin1.loginWithWeixin("snsapi_userinfo", "demo_smowx_login", (obj, args) =>
            {
                //这里需要判断是否返回正确，错误信息会保存在error及errorCode中
                if (args.isError == false)
                {
                    //如果没有错误，会返回一个code，code在args参数中
                    string code = args.args.ToString();
                    //根据code去获取access_token
                   WeXinAccessTokenResponseEntity accessTokenEntity = GetAccessTokenByCode(code);
                    if (accessTokenEntity.errcode == 0)
                    {
                        //根据获取到的access token获取用户信息
                        var userEntity = GetUserInfoByOpenid(accessTokenEntity.access_token, accessTokenEntity.openid);
                        //这里要判断一下结果是否有错误
                        if (userEntity.errcode == 0)
                        {
                            Toast(string.Format("用户信息获取成功:{0}/{1}", userEntity.openid, userEntity.nickname));
                        }
                        else
                        {
                            Toast(string.Format("get userinfo error: {0}/{1}", userEntity.errcode, userEntity.errmsg));
                        }
                    }
                    else
                    {
                        Toast(string.Format("get access token error: {0}/{1}", accessTokenEntity.errcode, accessTokenEntity.errmsg));
                    }

                }
                else
                {
                    Toast(string.Format("login error: {0}/{1}", args.errorCode, args.error));
                }
            });
        }

        private WeXinAccessTokenResponseEntity GetAccessTokenByCode(string code)
        {
            //获取的格式为https://api.weixin.qq.com/sns/oauth2/access_token?appid=APPID&secret=SECRET&code=CODE&grant_type=authorization_code
            //appid为申请的应用号，secret是应用密钥，code是在调用登陆后获取的参数，grant_type固定为authorization_code
            string accessTokenParameterUrl = string.Format("{0}?appid={1}&secret={2}&code={3}&grant_type=authorization_code", accessTokenUrl, appid, secret, code);
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)HttpWebRequest.Create(accessTokenParameterUrl);
            myHttpWebRequest.Method = "GET";
            //获取结果
            HttpWebResponse result = (HttpWebResponse)myHttpWebRequest.GetResponse();
            string resultStr = "";
            if (result.StatusCode == HttpStatusCode.OK)
            {
                using (StreamReader reader = new StreamReader(result.GetResponseStream()))
                {
                    resultStr = reader.ReadToEnd();
                    //返回的是json格式，这里直接做序列化即可
                    JavaScriptSerializer serializer = new JavaScriptSerializer();
                    return serializer.Deserialize<WeXinAccessTokenResponseEntity>(resultStr);
                }
            }
            else
            {
                return new WeXinAccessTokenResponseEntity() { errcode = -1, errmsg = "HTTP错误状态" + result.StatusCode };
            }
        }


        private WeXinUserInfoResponseEntity GetUserInfoByOpenid(string accessToken, string openid)
        {
            //获取的格式为https://api.weixin.qq.com/sns/userinfo?access_token=ACCESS_TOKEN&openid=OPENID
            //access_token是前面获取的调用凭证，openid是用户标识
            string parameterUrl = string.Format("{0}?access_token={1}&openid={2}", userinfoUrl, accessToken, openid);
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)HttpWebRequest.Create(parameterUrl);
            myHttpWebRequest.Method = "GET";
            //获取结果
            HttpWebResponse result = (HttpWebResponse)myHttpWebRequest.GetResponse();
            string resultStr = "";
            if (result.StatusCode == HttpStatusCode.OK)
            {
                using (StreamReader reader = new StreamReader(result.GetResponseStream()))
                {
                    resultStr = reader.ReadToEnd();
                    //返回的是json格式，这里直接做序列化即可
                    JavaScriptSerializer serializer = new JavaScriptSerializer();
                    return serializer.Deserialize<WeXinUserInfoResponseEntity>(resultStr);
                }
            }
            else
            {
                return new WeXinUserInfoResponseEntity() { errcode = -1, errmsg = "HTTP错误状态" + result.StatusCode };
            }
        }
    }

    public abstract class WexinGetResponseEntity
    {
        //如果出现错误，会有错误编号
        public int errcode { get; set; }
        //如果出现错误，错误编号对应的错误信息
        public string errmsg { get; set; }
    }

    //具体参数信息详见 https://open.weixin.qq.com/cgi-bin/showdocument?action=dir_list&t=resource/res_list&verify=1&id=open1419317853&token=&lang=zh_CN
    public class WeXinAccessTokenResponseEntity : WexinGetResponseEntity
    {
        //-------如果没有出现错误返回如下内容-------
        //接口调用凭证
        public string access_token { get; set; }
        //access_token接口调用凭证超时时间，单位（秒）
        public int expires_in { get; set; }
        //用户刷新access_token
        public string refresh_token { get; set; }
        //授权用户唯一标识
        public string openid { get; set; }
        //用户授权的作用域，使用逗号（,）分隔
        public string scope { get; set; }
        //当且仅当该移动应用已获得该用户的userinfo授权时，才会出现该字段
        public string unionid { get; set; }
    }

    public class WeXinUserInfoResponseEntity : WexinGetResponseEntity
    {
        //-------如果没有出现错误返回如下内容-------
        //普通用户的标识，对当前开发者帐号唯一
        public string openid { get; set; }
        //普通用户昵称
        public string nickname { get; set; }
        //普通用户性别，1为男性，2为女性
        public int sex { get; set; }
        //普通用户个人资料填写的省份
        public string province { get; set; }
        //普通用户个人资料填写的城市
        public string city { get; set; }
        //国家，如中国为CN
        public string country { get; set; }
        //用户头像，最后一个数值代表正方形头像大小（有0、46、64、96、132数值可选，0代表640*640正方形头像），用户没有头像时该项为空
        public string headimgurl { get; set; }
        //用户特权信息，json数组，如微信沃卡用户为（chinaunicom）
        public string[] privilege { get; set; }
        //用户统一标识。针对一个微信开放平台帐号下的应用，同一用户的unionid是唯一的。
        //开发者最好保存unionID信息，以便以后在不同应用之间进行用户信息互通。
        public string unionid { get; set; }
    }

}