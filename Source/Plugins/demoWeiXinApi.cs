using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
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
        private string appid = ""; //APPID 公众号的唯一标识
        private string appsecret = "";
        private string miniappid = "";//小程序中APPID
        private string miniappsecret = "";
        private string key = ""; //商户平台设置的密钥key
        private string mch_id = ""; //微信支付分配的商户号
        private string out_trade_no = ""; //外部订单号
        private const string unifieOrderUrl = "https://api.mch.weixin.qq.com/pay/unifiedorder"; //微信创建订单地址
        private const string orderqueryUrl = "https://api.mch.weixin.qq.com/pay/orderquery"; //微信支付订单的查询地址
        private string Token = "";
        private string Ticket = "";
        private string mTicket = "";
        private string string1 = "";
        private bool mdebug = false;
        private string mopenid = "";//生成支付预订单时需要的openid
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
            g1.AddItem("logon", "扫一扫scanQRCode", "scanQRCode1", "");
            g1.AddItem("logon", "扫一扫scanQRCode", "scanQRCode2", "");
            g1.AddItem("logon", "扫一扫scanQRCode", "scanQRCode3", "");
            g1.AddItem("logon", "网页授权login", "login", "");
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
                            this.weiXinApi1.config(timestamp, nonceStr, signature, (obj, argss) => { Toast("isError:" + argss.isError + "ERROR:" + argss.error + " ARGS:" + argss.args); }, mdebug);
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
                case "scanQRCode1": 
                    this.weiXinApi1.scanQRCode((obj, args) => { ShowMessage("ERROR:" + args.error + " ARGS:" + args.args); });
                    break;
                case "scanQRCode2": //微信扫一扫   WeixinDecode：由微信处理后返回  NoDocode：直接返回扫描结果
                    this.weiXinApi1.scanQRCode(WeiXinApiScanResultType.NoDocode, (obj, args) => { ShowMessage("ERROR:" + args.error + " ARGS:" + args.args); });
                    break;
                case "scanQRCode3": //微信扫一扫   WeixinDecode：由微信处理后返回  NoDocode：直接返回扫描结果
                                    //WeiXinApiScanCodeType 设置扫描条码类型，ios中有效
                    this.weiXinApi1.scanQRCode(WeiXinApiScanResultType.NoDocode, WeiXinApiScanCodeType.All, (obj, args) => { ShowMessage("ERROR:" + args.error + " ARGS:" + args.args); });
                    break;
                case "login": //网页授权
                    //同样可参考微信文档自行网页授权 https://developers.weixin.qq.com/doc/offiaccount/OA_Web_Apps/Wechat_webpage_authorization.html
                    weiXinApi1.login();
                    break;
                case "pay": //支付
                            //可参考微信文档  https://pay.weixin.qq.com/wiki/doc/api/jsapi.php?chapter=7_1
                    try
                    {
                        Pay(UnifiedOrder());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    break;
            }
        }
        /// <summary>
        /// https://pay.weixin.qq.com/wiki/doc/api/jsapi.php?chapter=9_1
        /// 调起支付时，需要先调用微信接口生成预付单，获取到prepay_id后将参数再次签名传输给APP发起支付
        /// </summary>
        private WeXinApiPayAPIResponseEntity UnifiedOrder()
        {
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)HttpWebRequest.Create(unifieOrderUrl);
            myHttpWebRequest.Method = "POST";
            myHttpWebRequest.ContentType = "application/x-www-form-urlencoded;charset=utf-8";

            SortedDictionary<string, string> payDict = new SortedDictionary<string, string>();
            payDict.Add("appid", appid);//公众账号ID
            payDict.Add("mch_id", mch_id);//商户号
            payDict.Add("device_info", this.Client.DeviceID);//设备号
            payDict.Add("nonce_str", System.Guid.NewGuid().ToString("N"));//随机字符串
            payDict.Add("body", "请支付0.01元");//商品描述
            CreateOutTradeNo();//创建外部订单编号
            payDict.Add("out_trade_no", out_trade_no);//外部订单编号
            payDict.Add("total_fee", "1");//金额，单位是分，100代表为1元
            payDict.Add("spbill_create_ip", this.Client.IPEndPoint.Address.ToString());//终端IP
            payDict.Add("notify_url", "http://www.weixin.qq.com/wxpay/pay.php");//由于notify_url为必须的字段，如果有通知地址就填写一个，如果没有的话，可随意填写一个
            payDict.Add("trade_type", "JSAPI");//交易类型
            payDict.Add("openid", mopenid);
            string payXmlStr = CreateRequestXML(payDict);
            byte[] encodedBytes = Encoding.UTF8.GetBytes(payXmlStr);
            myHttpWebRequest.ContentLength = encodedBytes.Length;
            Stream requestStream = myHttpWebRequest.GetRequestStream();
            requestStream.Write(encodedBytes, 0, encodedBytes.Length);
            requestStream.Close();

            //获取结果
            HttpWebResponse result = (HttpWebResponse)myHttpWebRequest.GetResponse();
            string resultStr = "";
            if (result.StatusCode == HttpStatusCode.OK)
            {
                using (Stream mystream = result.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(mystream))
                    {
                        resultStr = reader.ReadToEnd();
                    }
                }
            }

            return WeXinApiPayAPIResponseEntity.Create(resultStr);
        }
        private void CreateOutTradeNo()
        {
            out_trade_no = "SMOAPP" + DateTime.Now.ToString("yyyyMMddHHmmss");
        }
        //调用支付接口
        private void Pay(WeXinApiPayAPIResponseEntity resultEntity)
        {
            if (resultEntity.return_code == "SUCCESS")
            {
                if (resultEntity.result_code == "SUCCESS")
                {
                    Smobiler.Plugins.WeiXinApiPayEntity PayEntity = new Smobiler.Plugins.WeiXinApiPayEntity()
                    {
                        nonceStr = resultEntity.nonce_str,
                        signType = "MD5",
                        package = "prepay_id=" + resultEntity.prepay_id,
                        timestamp = ((int)((DateTime.Now.ToUniversalTime().Ticks - 621355968000000000) / 10000000)).ToString()
                    };
                    //按签名规范重新生成签名
                    //https://pay.weixin.qq.com/wiki/doc/api/app/app.php?chapter=4_3
                    string signTempStr = string.Format("appId={0}&nonceStr={1}&package={2}&signType={3}&timeStamp={4}&key={5}", resultEntity.appid, PayEntity.nonceStr, PayEntity.package, PayEntity.signType, PayEntity.timestamp, key);
                    var md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
                    PayEntity.paySign = BitConverter.ToString(md5.ComputeHash(System.Text.Encoding.UTF8.GetBytes(signTempStr))).Replace("-", "");

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
                }
                else
                    {
                        throw new Exception("WeXinApiPayAPIResponseError " + resultEntity.err_code + "/" + resultEntity.err_code_des);
                    }
                }
                else
                {
                    throw new Exception("WeXinApiPayAPIResponseError " + resultEntity.return_msg);
                }
            }
        public string CreateRequestXML(SortedDictionary<string, string> requestDict)
        {
            XmlDocument doc = new XmlDocument();
            XmlElement xmlNode = doc.CreateElement("xml");
            var props = this.GetType().GetProperties();
            //signDictList主要用于生成签名，详见 https://pay.weixin.qq.com/wiki/doc/api/app/app.php?chapter=4_3
            var signDictList = new List<string>();
            foreach (var pop in requestDict)
            {
                if (string.IsNullOrEmpty(pop.Value) == false)
                {
                    XmlElement element = doc.CreateElement(pop.Key);
                    element.InnerText = pop.Value;
                    xmlNode.AppendChild(element);
                    signDictList.Add(pop.Key + "=" + element.InnerText);
                }
            }
            //使用MD5生成签字算法
            signDictList.Add("key=" + key);
            string signTempStr = string.Join("&", signDictList);
            var md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            string signStr = BitConverter.ToString(md5.ComputeHash(System.Text.Encoding.UTF8.GetBytes(signTempStr))).Replace("-", "");
            XmlElement sign = doc.CreateElement("sign");
            sign.InnerText = signStr;
            xmlNode.AppendChild(sign);

            doc.AppendChild(xmlNode);
            return doc.OuterXml;
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
        private void weiXinApi1_Afterlogin(object sender, WeiXinApiLoginEventArgs e)
        {
            if (e.MiniLoginInfo != null)
            {
                if (e.MiniLoginInfo.errcode == 0)
                {
                    //可获取用户信息
                    Toast(e.MiniLoginInfo.userInfo.nickName);
                    Toast(e.MiniLoginInfo.GetMiniEncryptUserInfo(miniappid, miniappsecret).openId);
                    this.Form.RedirectUrl(this.Client.HostUrl);//必须跳转起始地址，否则微信功能不能使用
                }
            }
            else
            {
                var userInfo = e.GetUserInfo(appsecret);
                if (userInfo.errcode == 0)
                {
                    //可获取用户信息
                    Toast(userInfo.nickname);
                    Toast(userInfo.openid);
                    mopenid = userInfo.openid;
                    this.Form.RedirectUrl(this.Client.HostUrl);//必须跳转起始地址，否则微信功能不能使用
                }
            }
        }


        //weixinapipay
        /// <summary>
        /// 微信支付实体类
        /// 详见 https://pay.weixin.qq.com/wiki/doc/api/app/app.php?chapter=9_1 请求参数
        /// </summary>

        /// <summary>
        /// 微信支付结果类
        /// 详见 https://pay.weixin.qq.com/wiki/doc/api/app/app.php?chapter=9_1 返回结果
        /// </summary>
        public class WeXinApiPayAPIResponseEntity
        {
            /// <summary>
            /// SUCCESS/FAIL
            /// 此字段是通信标识，非交易标识，交易是否成功需要查看result_code来判断
            /// </summary>
            public string return_code { get; set; }
            /// <summary>
            /// 返回信息，如非空，为错误原因
            /// 签名失败
            /// 参数格式校验错误
            /// </summary>
            public string return_msg { get; set; }

            //--------------以下字段在return_code为SUCCESS的时候有返回
            /// <summary>
            /// 调用接口提交的应用ID
            /// </summary>
            public string appid { get; set; }
            /// <summary>
            /// 调用接口提交的商户号
            /// </summary>
            public string mch_id { get; set; }
            /// <summary>
            /// 调用接口提交的终端设备号
            /// </summary>
            public string device_info { get; set; }
            /// <summary>
            /// 微信返回的随机字符串
            /// </summary>
            public string nonce_str { get; set; }
            /// <summary>
            /// 微信返回的签名
            /// </summary>
            public string sign { get; set; }
            /// <summary>
            /// SUCCESS/FAIL
            /// </summary>
            public string result_code { get; set; }
            /// <summary>
            /// 详细参见第6节错误列表
            /// </summary>
            public string err_code { get; set; }
            /// <summary>
            /// 错误返回的信息描述
            /// </summary>
            public string err_code_des { get; set; }

            //--------------以下字段在return_code 和result_code都为SUCCESS的时候有返回
            /// <summary>
            /// 调用接口提交的交易类型，取值如下：JSAPI，NATIVE，APP，详细说明见参数规定
            /// https://pay.weixin.qq.com/wiki/doc/api/app/app.php?chapter=4_2
            /// </summary>
            public string trade_type { get; set; }
            /// <summary>
            /// 微信生成的预支付回话标识，用于后续接口调用中使用，该值有效期为2小时
            /// </summary>
            public string prepay_id { get; set; }

            /// <summary>
            /// 根据返回的XML创建WeXinPayAPIResponseEntity
            /// </summary>
            /// <param name="orderInfoXmlStr">订单XML</param>
            /// <returns></returns>
            public static WeXinApiPayAPIResponseEntity Create(string orderInfoXmlStr)
            {
                WeXinApiPayAPIResponseEntity entity = null;
                if (string.IsNullOrEmpty(orderInfoXmlStr) == false)
                {
                    //加载返回的XML
                    XmlDocument doc = new XmlDocument();
                    doc.LoadXml(orderInfoXmlStr);
                    XmlElement root = doc.DocumentElement;

                    //获取WeXinPayAPIResponseEntity所有的属性
                    var props = typeof(WeXinApiPayAPIResponseEntity).GetProperties();
                    var propDict = new Dictionary<string, System.Reflection.PropertyInfo>();
                    foreach (var pop in props)
                    {
                        propDict.Add(pop.Name, pop);
                    }

                    entity = new WeXinApiPayAPIResponseEntity();
                    //遍历设置WeXinPayAPIResponseEntity的值
                    foreach (XmlElement cNode in root.ChildNodes)
                    {
                        string nodeName = cNode.Name;
                        if (propDict.ContainsKey(nodeName) == true)
                        {
                            propDict[nodeName].SetValue(entity, cNode.InnerText, null);
                        }
                    }
                }
                return entity;
            }
        }
    }
}