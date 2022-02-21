using DingTalk.Api;
using DingTalk.Api.Request;
using DingTalk.Api.Response;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static DingTalk.Api.Response.OapiV2UserGetResponse;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoDingDingApi : Smobiler.Core.Controls.MobileForm
    {
        public demoDingDingApi() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Form.Close();
        }
        string token = "";
        string sign = "";
        long timestamp;
        private string AppID = "***********";//请替换成钉钉应用ID，也就是AppKey
        private string AppSecret = "*********";//请替换成钉钉APPSercetkey
        private string CorpID = "*********";//请替换钉钉CorpID
        private string AgentID = "***********";// 请替换成钉钉AgentId
        private void demoDingDingApi_Load(object sender, EventArgs e)
        {
            dingDingApi1.AppID = AppID;
            dingDingApi1.AppSecret = AppSecret;
            dingDingApi1.CorpID = CorpID;
            dingDingApi1.AgentID = AgentID;
        }
        /// <summary>
        /// config 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Press(object sender, EventArgs e)
        {
            //生成随机字符
            string nonceStr = dingDingApi1.CreatenNonce_str();
            //生成时间戳
            long timestamp = dingDingApi1.CreatenTimestamp();
            token = GetAccessToken();
            string jsticket = GetJsApiTicket(token);
            sign = dingDingApi1.GetSignature(jsticket, nonceStr, timestamp);
            string[] jsApiList = new string[] { "biz.util.scan", "device.geolocation.get", "biz.contact.externalComplexPicker", "biz.chat.openSingleChat" };
            dingDingApi1.Config(timestamp, nonceStr, sign, jsApiList, (obj, args) =>
            {

                if (args.isError == true)
                {
                    Toast("code; " + args.errorCode + " error： " + args.error);
                }
                else
                    Toast("success");
            });
        }
        /// <summary>
        /// 获取授权access_token
        /// </summary>
        /// <returns></returns>
        private string GetAccessToken()
        {
            IDingTalkClient client = new DefaultDingTalkClient("https://oapi.dingtalk.com/gettoken");
            OapiGettokenRequest req = new OapiGettokenRequest();
            if (string.IsNullOrEmpty(AppID) == true)
                throw new Exception("Missing AppID");
            req.Appkey = AppID;
            req.Appsecret = AppSecret;
            req.SetHttpMethod("GET");
            OapiGettokenResponse response = client.Execute(req);
            return response.AccessToken;
        }
        /// <summary>
        /// 获取jsticket
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public string GetJsApiTicket(string token)
        {
            IDingTalkClient client = new DefaultDingTalkClient("https://oapi.dingtalk.com/get_jsapi_ticket");
            OapiGetJsapiTicketRequest req = new OapiGetJsapiTicketRequest();
            req.SetHttpMethod("GET");
            OapiGetJsapiTicketResponse rsp = client.Execute(req, token);
            return rsp.Ticket;
        }
        /// <summary>
        /// 选择要调用的方法 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Press(object sender, EventArgs e)
        {
            Dictionary<string, object> keyValuePairs = new Dictionary<string, object>() { };
            keyValuePairs.Add("type", "all");
            dingDingApi1.SelectMethod("biz", "util", "scan", keyValuePairs, (obj, args) =>
            {
                if (args.isError == false)
                {
                    if (args.args != null)
                    {
                        string str = "";
                        Dictionary<string, object> datas = args.args as Dictionary<string, object>;
                        if (datas != null)
                            foreach (KeyValuePair<string, object> keyValue in datas)
                            {
                                str += keyValue.Key + " " + keyValue.Value.ToString();
                            }
                        Toast(str);
                    }
                }
            });
        }
        /// <summary>
        /// 扫码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Press(object sender, EventArgs e)
        {
            dingDingApi1.Scan(Smobiler.Plugins.DingTalkScanType.All, (obj, args) =>
            {
                if (args.isError == false)
                {
                    Toast(args.args.ToString());
                }
            });
        }
        /// <summary>
        /// 获取定位
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Press(object sender, EventArgs e)
        {
            dingDingApi1.GetLocation(20, Smobiler.Plugins.DingTalkCoordinate.Amap, true, true, (obj, args) =>
            {
                if (args.isError == false)
                {
                    string str = "";
                    Dictionary<string, object> datas = args.args as Dictionary<string, object>;
                    foreach (KeyValuePair<string, object> keyValue in datas)
                    {
                        str += keyValue.Key + " " + keyValue.Value.ToString();
                    }
                    Toast(str);
                }
                else
                {
                    Toast(args.error);
                }
            });

        }
        /// <summary>
        /// 打开与指定用户的单聊会话
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Press(object sender, EventArgs e)
        {//请将 **** 替换成钉钉用户的userid
            dingDingApi1.OpenSingleChat("****", (obj, args) =>
            {

                if (args.isError == true)
                {
                    Toast("code; " + args.errorCode + " error： " + args.error);
                }
                else
                    Toast("success");
            });

        }

        /// <summary>
        /// 选择外部联系人
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Press(object sender, EventArgs e)
        {
            dingDingApi1.ExternalComplexPicker("titie1", true, "超出了", 10, new string[] { }, new string[] { }, new string[] { }, (obj, args) =>
            {
                if (args.isError == false)
                {
                    string str = "";
                    ArrayList arrayList = (ArrayList)args.args;
                    if (arrayList != null)
                    {
                        foreach (Dictionary<string, object> datas in arrayList)
                        {
                            foreach (KeyValuePair<string, object> keyValue in datas)
                            {
                                str += keyValue.Key + " " + keyValue.Value.ToString();
                            }
                        }
                    }
                    Toast(str);
                }
                else
                    Toast(args.error);

            });

        }

        private void button7_Press(object sender, EventArgs e)
        {
            dingDingApi1.Login();
        }

        /// <summary>
        /// 执行Login后触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dingDingApi1_Afterlogin(object sender, Smobiler.Plugins.DingTalkApiLoginEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(e.Code) == false)
                {
                    string code = e.Code;
                    string state = e.State;
                    if (string.IsNullOrEmpty(timestamp.ToString()) == true)
                        timestamp = dingDingApi1.CreatenTimestamp();
                    if (string.IsNullOrEmpty(token) == true)
                        token = GetAccessToken();
                    // 通过临时授权码获取授权用户的个人信息
                    DefaultDingTalkClient client2 = new DefaultDingTalkClient("https://oapi.dingtalk.com/sns/getuserinfo_bycode");
                    OapiSnsGetuserinfoBycodeRequest reqBycodeRequest = new OapiSnsGetuserinfoBycodeRequest();
                    reqBycodeRequest.TmpAuthCode = code;
                    OapiSnsGetuserinfoBycodeResponse bycodeResponse = client2.Execute(reqBycodeRequest, AppID, AppSecret);
                    if (bycodeResponse.Errcode != 0)
                    {
                        throw new Exception("Code: " + bycodeResponse.Errcode.ToString() + "错误信息： " + bycodeResponse.Errmsg);
                    }
                    // 根据unionid获取userid
                    string unionid = bycodeResponse.UserInfo.Unionid;
                    IDingTalkClient clientDingTalkClient = new DefaultDingTalkClient("https://oapi.dingtalk.com/topapi/user/getbyunionid");
                    OapiUserGetbyunionidRequest reqGetbyunionidRequest = new OapiUserGetbyunionidRequest();
                    reqGetbyunionidRequest.Unionid = unionid;
                    OapiUserGetbyunionidResponse oapiUserGetbyunionidResponse = clientDingTalkClient.Execute(reqGetbyunionidRequest, token);
                    if (oapiUserGetbyunionidResponse.IsError)
                    {
                        throw new Exception("Code: " + oapiUserGetbyunionidResponse.ErrCode.ToString() + "错误信息： " + oapiUserGetbyunionidResponse.ErrMsg);
                    }
                    // 根据userId获取用户信息
                    String userid = oapiUserGetbyunionidResponse.Result.Userid;
                    IDingTalkClient clientDingTalkClient2 = new DefaultDingTalkClient("https://oapi.dingtalk.com/topapi/v2/user/get");
                    OapiV2UserGetRequest reqGetRequest = new OapiV2UserGetRequest();
                    reqGetRequest.Userid = userid;
                    reqGetRequest.Language = "zh_CN";
                    OapiV2UserGetResponse rspGetResponse = clientDingTalkClient2.Execute(reqGetRequest, token);
                    if (rspGetResponse.IsError)
                    {
                        throw new Exception("Code: " + rspGetResponse.ErrCode.ToString() + "错误信息： " + rspGetResponse.ErrMsg);
                    }
                    UserGetResponseDomain userinfo = rspGetResponse.Result;
                    Toast(userinfo.Name);
                }
                else
                {
                    throw new Exception(e.Error);
                }
            }
            catch (Exception ex)
            {
                Toast(ex.Message);

            }

        }
    }
}