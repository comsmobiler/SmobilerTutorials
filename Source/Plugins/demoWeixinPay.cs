using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoWeixinPay : Smobiler.Core.Controls.MobileForm
    {
        private string key = ""; //商户平台设置的密钥key
        private string appid = ""; //微信开放平台审核通过的应用APPID（请登录open.weixin.qq.com查看，注意与公众号的APPID不同）
        private string mch_id = ""; //微信支付分配的商户号
        private string out_trade_no = ""; //外部订单号
        private const string unifieOrderUrl = "https://api.mch.weixin.qq.com/pay/unifiedorder"; //微信创建订单地址
        private const string orderqueryUrl = "https://api.mch.weixin.qq.com/pay/orderquery"; //微信支付订单的查询地址
        public demoWeixinPay() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }
        private void demoWeixinPay_Load(object sender, EventArgs e)
        {
            //注册APPID
            this.weiXin1.registerApp(appid);
            CreateOutTradeNo();
        }

        private void btnWXPay_Press(object sender, EventArgs e)
        {
            try
            {
                Pay(UnifiedOrder());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CreateOutTradeNo()
        {
            out_trade_no = "SMOAPP" + DateTime.Now.ToString("yyyyMMddHHmmss");
            this.labOutOrder.Text = out_trade_no;
        }
        /// <summary>
        /// https://pay.weixin.qq.com/wiki/doc/api/app/app.php?chapter=9_1
        /// 调起支付时，需要先调用微信接口生成预付单，获取到prepay_id后将参数再次签名传输给APP发起支付
        /// </summary>
        private WeXinPayAPIResponseEntity UnifiedOrder()
        {
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)HttpWebRequest.Create(unifieOrderUrl);
            myHttpWebRequest.Method = "POST";
            myHttpWebRequest.ContentType = "application/x-www-form-urlencoded;charset=utf-8";

            SortedDictionary<string, string> payDict = new SortedDictionary<string, string>();
            payDict.Add("appid", appid);//应用ID
            payDict.Add("mch_id", mch_id);//商户号
            payDict.Add("device_info", this.Client.DeviceID);//设备号
            payDict.Add("nonce_str", System.Guid.NewGuid().ToString("N"));//随机字符串
            payDict.Add("body", "请支持0.01元");//商品描述
            payDict.Add("out_trade_no", out_trade_no);//外部订单编号
            payDict.Add("total_fee", "1");//金额，单位是分，100代表为1元
            payDict.Add("spbill_create_ip", this.Client.IPEndPoint.Address.ToString());//获取客户端的IP地址
            payDict.Add("notify_url", "http://www.weixin.qq.com/wxpay/pay.php");//由于notify_url为必须的字段，如果有通知地址就填写一个，如果没有的话，可随意填写一个
            payDict.Add("trade_type", "APP");//这里固定为APP
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

            return WeXinPayAPIResponseEntity.Create(resultStr);
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

        //调用支付接口
        private void Pay(WeXinPayAPIResponseEntity resultEntity)
        {
            if (resultEntity.return_code == "SUCCESS")
            {
                if (resultEntity.result_code == "SUCCESS")
                {
                    //参数说明详见 https://pay.weixin.qq.com/wiki/doc/api/app/app.php?chapter=9_12
                    Smobiler.Plugins.WeiXinPayEntity appPayEntity = new Smobiler.Plugins.WeiXinPayEntity()
                    {
                        nonceStr = resultEntity.nonce_str,
                        package = "Sign=WXPay",
                        partnerId = resultEntity.mch_id,
                        prepayId = resultEntity.prepay_id,
                        timeStamp = ((int)((DateTime.Now.ToUniversalTime().Ticks - 621355968000000000) / 10000000)).ToString()
                    };

                    //按签名规范重新生成签名，注意package的值格式为Sign=WXPay
                    string signTempStr = string.Format("appid={0}&nonceStr={1}&package={2}&partnerId ={3}&prepayId={4}&timeStamp={5}", resultEntity.appid, appPayEntity.nonceStr, appPayEntity.package, appPayEntity.partnerId, appPayEntity.prepayId, appPayEntity.timeStamp);
                    var md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
                    appPayEntity.sign = BitConverter.ToString(md5.ComputeHash(System.Text.Encoding.UTF8.GetBytes(signTempStr))).Replace("-", "");

                    //调用支付功能
                    this.weiXin1.pay(appPayEntity, (obj, args) =>
                    {
                        if (args.isError == true)
                        {
                            MessageBox.Show(string.Format("APP Pay Error: {0}", args.error));
                        }
                        else
                        {
                            //如果没有返回错误，代表支付成功，那么这里直接去查询订单状态
                            //一定要以具体查询的结果为准，不要以APP的返回状态为准
                            //https://pay.weixin.qq.com/wiki/doc/api/app/app.php?chapter=9_2
                            Toast("支付成功!");
                        }
                    });
                }
                else
                {
                    throw new Exception("WeXinPayAPIResponseError " + resultEntity.err_code + "/" + resultEntity.err_code_des);
                }
            }
            else
            {
                throw new Exception("WeXinPayAPIResponseError " + resultEntity.return_msg);
            }
        }

        private void btnWXLogin_Press(object sender, EventArgs e)
        {

        }

        private void btnOutOrder_Press(object sender, EventArgs e)
        {
            CreateOutTradeNo();
        }
    }

    /// <summary>
    /// 微信支付实体类
    /// 详见 https://pay.weixin.qq.com/wiki/doc/api/app/app.php?chapter=9_1 请求参数
    /// </summary>

    /// <summary>
    /// 微信支付结果类
    /// 详见 https://pay.weixin.qq.com/wiki/doc/api/app/app.php?chapter=9_1 返回结果
    /// </summary>
    public class WeXinPayAPIResponseEntity
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
        public static WeXinPayAPIResponseEntity Create(string orderInfoXmlStr)
        {
            WeXinPayAPIResponseEntity entity = null;
            if (string.IsNullOrEmpty(orderInfoXmlStr) == false)
            {
                //加载返回的XML
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(orderInfoXmlStr);
                XmlElement root = doc.DocumentElement;

                //获取WeXinPayAPIResponseEntity所有的属性
                var props = typeof(WeXinPayAPIResponseEntity).GetProperties();
                var propDict = new Dictionary<string, System.Reflection.PropertyInfo>();
                foreach (var pop in props)
                {
                    propDict.Add(pop.Name, pop);
                }

                entity = new WeXinPayAPIResponseEntity();
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