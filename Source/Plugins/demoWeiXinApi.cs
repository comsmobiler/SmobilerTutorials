using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using Smobiler.Plugins;
using static Smobiler.Plugins.WeiXinApi;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoWeiXinApi : Smobiler.Core.Controls.MobileForm
    {
        public demoWeiXinApi() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        private string appid = ""; //APPID
        private string appsecret = "";
        private string Token = "";
        private string Ticket = "";
        private string mTicket = "";
        private string string1 = "";
        private bool mdebug = false;
        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void demoWeiXinApi_Load(object sender, EventArgs e)
        {
            ListMenuViewGroup g1 = new ListMenuViewGroup();
            g1.AddItem("logon", "获取Token", "Token", "");
            g1.AddItem("logon", "获取Ticket", "Ticket", "");
            g1.AddItem("logon", "注入权限验证配置config", "config", "");
            g1.AddItem("logon", "是否支持指定JS接口checkJsApi", "checkJsApi", "");
            g1.AddItem("logon", "分享给好友shareToSession", "shareToSession", "");
            g1.AddItem("logon", "分享给朋友圈shareToTimeline", "shareToTimeline", "");
            g1.AddItem("logon", "获取地理位置getLocation", "getLocation", "");
            g1.AddItem("logon", "扫一扫scanQRCode", "scanQRCode", "");
            g1.AddItem("logon", "网页授权login", "login", "");
            g1.AddItem("logon", "获取当前的url getUrl", "getUrl", "");
            g1.AddItem("logon", "支付pay", "pay", "");
            listMenuView1.Groups.Add(g1);
        }



        private void listMenuView1_ItemPress(object sender, ListMenuViewItemPressEventArgs e)
        {
            //参数link（https://XXXX/）  分享链接，该链接域名或路径必须与当前页面对应的公众号JS安全域名一致
            WeiXinApiShareEntity entity = new WeiXinApiShareEntity("百度一下你就知道News", "百度一下你就知道", "https://XXXX/", "http://www.smobiler.com/images/index/logo.png");

            switch (e.Item.SubContent)
            {
                case "Token":
                    if (appid != "")
                    {
                        Token = GetToken(appid, appsecret);
                        Client.Session["Token"] = Token;
                    }
                    break;
                case "Ticket":
                    if (Token != "")
                    {
                        Ticket = GettTicket(Token);
                        Client.Session["Ticket"] = Ticket;
                    }
                    break;
                case "config": //注入权限验证配置
                    if (Client.Session["Ticket"] != null)
                    {
                        mTicket = (string)Client.Session["Ticket"];
                        if (mTicket != "")
                        {
                            string nonceStr = CreatenNonce_str();
                            long timestamp = CreatenTimestamp();
                            string signature = GetSignature(mTicket, nonceStr, timestamp, "http://neil.jx.smobiler.com/", out string1);
                            Toast(string1);
                            this.weiXinApi1.config(appid, timestamp, nonceStr, signature, (obj, argss) => { Toast("isError:" + argss.isError + "ERROR:" + argss.error + " ARGS:" + argss.args); }, mdebug);
                        }
                    }
                    break;
                case "checkJsApi": //是否支持指定JS接口
                    this.weiXinApi1.checkJsApi((obj, args) =>
                    {
                        ShowMessage("ERROR:" + args.error + " shareToSession:" + ((WeXinApiCheckJsApiResponseEntity)args.args).shareToSession + " shareToTimeline:" + ((WeXinApiCheckJsApiResponseEntity)args.args).shareToTimeline + " getLocation:" + ((WeXinApiCheckJsApiResponseEntity)args.args).getLocation + " scanQRCode:" + ((WeXinApiCheckJsApiResponseEntity)args.args).scanQRCode + " pay:" + ((WeXinApiCheckJsApiResponseEntity)args.args).pay);
                    });
                    break;
                case "shareToSession": //分享给好友
                    this.weiXinApi1.shareToSession(entity, HandleWeiXinRPCResult);
                    break;
                case "shareToTimeline": //分享给朋友圈
                    this.weiXinApi1.shareToTimeline(entity, HandleWeiXinRPCResult);
                    break;
                case "getLocation": //获取地理位置
                    this.weiXinApi1.getLocation((obj, args) =>
                    {
                        ShowMessage("ERROR:" + args.error + " latitude:" + ((WeXinApiGetLocationResponseEntity)args.args).latitude + " longitude:" + ((WeXinApiGetLocationResponseEntity)args.args).longitude);
                    });
                    break;
                case "scanQRCode": //微信扫一扫   Type0：由微信处理后返回  Type1：直接返回扫描结果
                    this.weiXinApi1.scanQRCode(ScanResultType.Type1, (obj, args) => { ShowMessage("ERROR:" + args.error + " ARGS:" + args.args); });
                    break;
                case "login": //网页授权
                    //同样可参考微信文档自行网页授权 https://developers.weixin.qq.com/doc/offiaccount/OA_Web_Apps/Wechat_webpage_authorization.html
                    weiXinApi1.login(appid, "http://XXXX");
                    break;
                case "getUrl": // 获取当前的url
                    weiXinApi1.getUrl((obj, args) =>
                    {
                        ShowMessage("ERROR:" + args.error + " ARGS:" + args.args);
                    });
                    break;
                case "pay": //支付
                            //可参考微信文档  https://pay.weixin.qq.com/wiki/doc/api/jsapi.php?chapter=7_1

                    Smobiler.Plugins.WeiXinApiPayEntity PayEntity = new Smobiler.Plugins.WeiXinApiPayEntity()
                    {
                        nonceStr ="",
                        signType = "MD5",
                        package = "prepay_id=" + "",
                        timestamp = ((int)((DateTime.Now.ToUniversalTime().Ticks - 621355968000000000) / 10000000)).ToString()
                    };
                    //调用支付功能
                    this.weiXinApi1.pay(PayEntity, (obj, args) =>
                    {
                        if (args.isError == true)
                        {
                            MessageBox.Show(string.Format("APP Pay Error: {0}", args.error));
                        }
                        else
                        {
                            //如果没有返回错误，代表支付成功，那么这里直接去查询订单状态
                            //商户系统对于支付结果通知的内容一定要做签名验证,并校验返回的订单金额是否与商户侧的订单金额一致，防止数据泄漏导致出现“假通知”，造成资金损失。
                            //https://pay.weixin.qq.com/wiki/doc/api/jsapi.php?chapter=9_7&index=8
                            Toast("支付成功!");
                        }
                    });
                    break;
            }
        }
        /// <summary>
        /// 获取Token
        /// </summary>
        /// access_token是公众号的全局唯一接口调用凭据，公众号调用各接口时都需使用access_token。开发者需要进行妥善保存。access_token的存储至少要保留512个字符空间。access_token的有效期目前为2个小时，需定时刷新，重复获取将导致上次获取的access_token失效。
        ///公众号和小程序均可以使用AppID和AppSecret调用本接口来获取access_token。AppID和AppSecret可在“微信公众平台-开发-基本配置”页中获得（需要已经成为开发者，且帐号没有异常状态）。**调用接口时，请登录“微信公众平台-开发-基本配置”提前将服务器IP地址添加到IP白名单中，点击查看设置方法，否则将无法调用成功。**小程序无需配置IP白名单。
        ///详情可查看https://developers.weixin.qq.com/doc/offiaccount/Basic_Information/Get_access_token.html
        public static string GetToken(string appid, string appsecret)
        {
            string result = "";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("https://api.weixin.qq.com/cgi-bin/token?grant_type=client_credential&appid=" + appid + "&secret=" + appsecret);
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            Stream stream = resp.GetResponseStream();
            try
            {
                //获取内容
                using (StreamReader reader = new StreamReader(stream))
                {
                    result = reader.ReadToEnd();
                }
            }
            finally
            {
                stream.Close();
            }
            return Tools.GetJsonValue(result, "access_token");
        }
        /// <summary>
        /// 获取Ticket
        /// </summary>
        /// 用第一步拿到的access_token 采用http GET方式请求获得jsapi_ticket（有效期7200秒，开发者必须在自己的服务全局缓存jsapi_ticket）：https://api.weixin.qq.com/cgi-bin/ticket/getticket?access_token=ACCESS_TOKEN&type=jsapi
        ///详情可查看https://developers.weixin.qq.com/doc/offiaccount/OA_Web_Apps/JS-SDK.html#62
        public static string GettTicket(string token)
        {
            string result = "";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("https://api.weixin.qq.com/cgi-bin/ticket/getticket?access_token=" + token + "&type=jsapi");
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            Stream stream = resp.GetResponseStream();
            try
            {
                //获取内容
                using (StreamReader reader = new StreamReader(stream))
                {
                    result = reader.ReadToEnd();
                }
            }
            finally
            {
                stream.Close();
            }
            return Tools.GetJsonValue(result, "ticket");
        }
        public class Tools
        {
            /// <summary>
            /// 获取Json字符串某节点的值
            /// </summary>
            public static string GetJsonValue(string jsonStr, string key)
            {
                string result = string.Empty;
                if (!string.IsNullOrEmpty(jsonStr))
                {
                    key = "\"" + key.Trim('"') + "\"";
                    int index = jsonStr.IndexOf(key) + key.Length + 1;
                    if (index > key.Length + 1)
                    {
                        //先截逗号，若是最后一个，截“｝”号，取最小值
                        int end = jsonStr.IndexOf(',', index);
                        if (end == -1)
                        {
                            end = jsonStr.IndexOf('}', index);
                        }

                        result = jsonStr.Substring(index, end - index);
                        result = result.Trim(new char[] { '"', ' ', '\'' }); //过滤引号或空格
                    }
                }
                return result;
            }
        }

        private static string[] strs = new string[]
 {
         "a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z",
         "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"
 };
        /// <summary>
        /// 创建随机字符串
        /// </summary>
        /// <returns></returns>
        public static string CreatenNonce_str()
        {
            Random r = new Random();
            var sb = new StringBuilder();
            var length = strs.Length;
            for (int i = 0; i < 15; i++)
            {
                sb.Append(strs[r.Next(length - 1)]);
            }
            return sb.ToString();
        }
        /// <summary>
        /// 创建时间戳
        /// </summary>
        /// <returns></returns>
        public static long CreatenTimestamp()
        {
            return (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000) / 10000000;
        }
        /// <summary>
        /// 签名算法
        /// </summary>
        /// <param name="jsapi_ticket">jsapi_ticket</param>
        /// <param name="noncestr">随机字符串(必须与wx.config中的nonceStr相同)</param>
        /// <param name="timestamp">时间戳(必须与wx.config中的timestamp相同)</param>
        /// <param name="url">当前网页的URL，不包含#及其后面部分(必须是调用JS接口页面的完整URL)</param>
        /// <returns></returns>
        public static string GetSignature(string jsapi_ticket, string noncestr, long timestamp, string url, out string string1)
        {
            var string1Builder = new StringBuilder();
            string1Builder.Append("jsapi_ticket=").Append(jsapi_ticket).Append("&")
            .Append("noncestr=").Append(noncestr).Append("&")
            .Append("timestamp=").Append(timestamp).Append("&")
            .Append("url=").Append(url.IndexOf("#") >= 0 ? url.Substring(0, url.IndexOf("#")) : url);
            string1 = string1Builder.ToString();
            return Sha1(string1);
        }
        /// <summary>
        /// Sha1
        /// </summary>
        /// <param name="orgStr"></param>
        /// <param name="encode"></param>
        /// <returns></returns>
        public static string Sha1(string orgStr, string encode = "UTF-8")
        {
            var sha1 = new SHA1Managed();
            var sha1bytes = System.Text.Encoding.GetEncoding(encode).GetBytes(orgStr);
            byte[] resultHash = sha1.ComputeHash(sha1bytes);
            string sha1String = BitConverter.ToString(resultHash).ToLower();
            sha1String = sha1String.Replace("-", "");
            return sha1String;
        }
        private void ShowMessage(string data)
        {
            this.Form.MessageBox.Show(data);
        }
        private void HandleWeiXinRPCResult(object sender, ComponentResultArgs e)
        {
            this.ShowMessage(System.String.Format("isError{0},error{1},errorCode{2},args{3}", e.isError, e.error, e.errorCode, e.args));
        }
    }
}