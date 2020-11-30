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

namespace Smobiler.Tutorials.Plugins
{
    partial class demoWeiXinENTApi : Smobiler.Core.Controls.MobileForm
    {
        public demoWeiXinENTApi() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        string corpid = "";  //企业ID
        string corpsecret = ""; //应用的凭证密钥
        string agentid = "";//商户号
        string ENTTicket = "";
        string AgentTicket = "";
        string string1 = "";

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();

        }
        private void demoWeiXinENTApi_Load(object sender, EventArgs e)
        {
            ListMenuViewGroup g1 = new ListMenuViewGroup();
            g1.AddItem("logon", "登陆", "login", "");
            g1.AddItem("logon", "获取ENTTicket", "ENTTicket", "");
            g1.AddItem("logon", "获取AgentTicket", "AgentTicket", "");
            g1.AddItem("logon", "注入权限验证配置config", "config", ""); 
                g1.AddItem("logon", "注入应用的权限agentConfig", "agentConfig", ""); 
            g1.AddItem("logon", "是否支持指定JS接口checkJsApi", "checkJsApi", ""); 
            g1.AddItem("logon", "使用invoke：扫一扫scanQRCode", "scanQRCode", "");
            listMenuView1.Groups.Add(g1);
        }

        private void listMenuView1_ItemPress(object sender, ListMenuViewItemPressEventArgs e)
        {
           
            switch (e.Item.SubContent)
            {
                case "login"://登陆
                    weiXinENTApi1.login("12");
                    break;
                case "ENTTicket":
                    if (corpid != "")
                    {
                        ENTTicket = GetENTTicket(GetAccessToken(corpid, corpsecret));
                        Client.Session["ENTTicket"] = ENTTicket;                       
                    }
                    break;
                case "Ticket":
                    if (corpid != "")
                    {
                        AgentTicket = GetAgentTicket(GetAccessToken(corpid, corpsecret));
                        Client.Session["AgentTicket"] = AgentTicket;
                    }
                    break;
                case "config": //注入权限验证配置
                    if (Client.Session["ENTTicket"] != null)
                    {
                        string nonceStr = CreatenNonce_str();
                        long timestamp = CreatenTimestamp();
                        string url = Client.WebUrl;
                        string signature = GetSignature(ENTTicket, nonceStr, timestamp, url, out string1);
                        string[] jsApiList = { "chooseImage", "onMenuShareAppMessage", "playVoice", "stopWifi", "openUserProfile", "openBluetoothAdapter", "closeBluetoothAdapter", "setClipboardData", "scanQRCode" };
                        this.weiXinENTApi1.config(timestamp, nonceStr, signature, jsApiList, (obj, argss) =>
                        {
                            Toast("isError:" + argss.isError + "ERROR:" + argss.error + " ARGS:" + argss.args);
                        }, true);
                    }
                    break;
                case "agentConfig": //注入应用权限
                    if (Client.Session["AgentTicket"] != null)
                    {
                        string nonceStr = CreatenNonce_str();
                        long timestamp = CreatenTimestamp();
                        string url = Client.WebUrl;
                        string signature = GetSignature(AgentTicket, nonceStr, timestamp, url, out string1);
                        this.weiXinENTApi1.agentConfig(agentid, timestamp, nonceStr, signature, (obj, argss) =>
                        {
                            Toast("isError:" + argss.isError + "ERROR:" + argss.error + " ARGS:" + argss.args);
                        }, true);

                    }
                    break;
                case "checkJsApi": //是否支持指定JS接口
                    string[] checkJsApiList = { "chooseImage", "playVoice", "stopWifi", "setClipboardData", "scanQRCode" };

                    weiXinENTApi1.checkJsApi(checkJsApiList, (obj, args) =>
                    {
                        Toast("ERROR:" + args.error);
                    });
                    break;
                case "scanQRCode": //使用invoke方法调用 微信扫一扫  
                                   //参考 https://work.weixin.qq.com/api/doc/90000/90136/90492
                    string[] mscanType = new string[2];
                    mscanType[0] = "qrCode";
                    mscanType[1] = "barCode";
                    Dictionary<string, object> dict = new Dictionary<string, object>();
                    dict.Add("desc", "'scanQRCode desc'");
                    dict.Add("needResult", 1);
                    dict.Add("scanType", mscanType);

                    weiXinENTApi1.invoke("scanQRCode", dict, (obj, args) =>
                    {
                        Dictionary<string, object> paramsDict = args.args as Dictionary<string, object>;
                        Toast("ERROR:" + args.error + " " + (string)paramsDict["resultStr"]);
                    });
                    break;
            }
        }
        private string GetAccessToken(string corpid, string corpsecret)
        {
            if (string.IsNullOrEmpty(corpsecret) == true)
                throw new Exception("Missing appSecret");

            string result = "";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(string.Format("https://qyapi.weixin.qq.com/cgi-bin/gettoken?corpid={0}&corpsecret={1}", corpid, corpsecret));
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

            WeiXinENTApiAccessToken token = Smobiler.Core.MobileUtility.GetJsonInstance<WeiXinENTApiAccessToken>(result);
            return token.access_token;
        }
        /// <summary>
        /// 获取企业的jsapi_ticket
        /// </summary>
        /// <param name="access_token"></param>
        /// <returns></returns>
        private string GetENTTicket(string access_token)
        {
            string result = "";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("https://qyapi.weixin.qq.com/cgi-bin/get_jsapi_ticket?access_token=" + access_token);
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
            return GetJsonValue(result, "ticket");
        }
        /// <summary>
        ///获取应用的jsapi_ticket
        /// </summary>
        /// <param name="access_token"></param>
        /// <returns></returns>
        private string GetAgentTicket(string access_token)
        {
            string result = "";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(string.Format("https://qyapi.weixin.qq.com/cgi-bin/ticket/get?access_token={0}&type=agent_config", access_token));
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
            return GetJsonValue(result, "ticket");
        }
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

        private void weiXinENTApi1_Afterlogin(object sender, WeiXinENTApiLoginEventArgs e)
        {
            Toast("触发事件");
            var userInfo = e.GetUserInfo(corpsecret);
            if (userInfo.errcode == 0)
            {
                Toast("UserId;" + userInfo.UserId + " OpenId:" + userInfo.OpenId + " DeviceId:" + userInfo.DeviceId);
            }
        }
    }
}