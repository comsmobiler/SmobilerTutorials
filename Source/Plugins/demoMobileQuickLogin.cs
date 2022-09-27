using Smobiler.Core;
using Smobiler.Core.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web.Security;
using Newtonsoft.Json;
using System.Security.Cryptography;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Crypto.Parameters;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoMobileQuickLogin : Smobiler.Core.Controls.MobileForm
    {
        public demoMobileQuickLogin() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void demeMobileQuickLogin_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// app 一键登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Press(object sender, EventArgs e)
        {
            //从移动平台上获取https://dev.10086.cn/account/login
            string appid = "*************";
            string appkey = "******************";
            string appserect = "*****************";
            mobileQuickLogin1.Login(appid, appkey, (obj, args) =>
            {
                if (args.Success == true)
                {
                    string token = args.Token;
                    Toast(GetTel(appid, appserect, token));
                }
            });
        }
        /// <summary>
        /// app  本机号码验证
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Press(object sender, EventArgs e)
        {
            //从移动平台上获取https://dev.10086.cn/account/login
            string appid = "************";
            string appkey = "*************";
            string appserect = "*********************";
            //平台公钥
            string platkey = "*******************************";
            // 客户RSA私钥
            string clientkey = "***************************************************";
            mobileQuickLogin1.LoginValidate(appid, appkey, (obj, args) =>
            {
                if (string.IsNullOrEmpty(args.Token))
                {
                    Toast("返回码" + args.ResultCode);
                }
                else
                {
                    Toast(TelValidate(appid, appkey, platkey, clientkey, textBox1.Text, args.Token));
                }
            });
        }
       /// <summary>
       /// web 一键登录
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void button3_Press(object sender, EventArgs e)
        {
            //从移动平台上获取https://dev.10086.cn/account/login
            //开发平台appid
            string appid = "**************";
            //移动开发平台appkey
            string appkey = "**********************";
            // 客户RSA私钥
            string clientkey = "*****************************";
            //使用 UUID 标识请求的唯一性,这边使用SessionID代替
            string version = "2.0";
            string msgid = Client.SessionID;
            string traceID = msgid;//业务方生成唯一标识
            int openType = 1;// 取号类型,  0为单独移动, 1为三网循环获取, 默认1
            //时间
            string timestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            //MD5签名 //加密后的签名 sign 生成规则： MD5(appId + businessType + msgId + timestamp + traceId + version+appkey)  注：businessType 为8；msgID 要和 traceID 保持一致，此处 sign 与 token 校验接口 sign 的生成规则不同
            string sign = FormsAuthentication.HashPasswordForStoringInConfigFile(appid + "8" + msgid + timestamp + traceID + version + appkey, "MD5");
            mobileQuickLogin1.WebLogin(appid, appkey, version, sign, traceID, timestamp, openType, "", (obj, args) =>
            {
                if (args.Success == true)
                {
                    string token = args.Token;
                    Toast(WebGetTel(appid, appkey, clientkey, token, args.UserInformation));
                }
            });
        }
        /// <summary>
        /// web 本机校验
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Press(object sender, EventArgs e)
        {
            //从移动平台上获取https://dev.10086.cn/account/login
            string appid = "********************";
            string appkey = "***************";
            // 平台RAS公钥
            string platkey = "********************";
            // 客户RSA私钥
            string clientkey = "************************";
            string version = "1.0";
            //使用 UUID 标识请求的唯一性,这边使用SessionID代替
            string msgid = Client.SessionID;
            string traceID = msgid;//业务方生成唯一标识
            int openType = 1;// 取号类型,  0为单独移动, 1为三网循环获取, 默认1
            string timestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");  //时间
            //MD5签名 加密后的签名 sign 生成规则： MD5(appId + businessType + msgId + timestamp + traceId + version+appkey)  注：businessType 为 1；msgID 要和 traceID 保持一致，此处 sign 与 token 校验接口 sign 的生成规则不同
            string sign = FormsAuthentication.HashPasswordForStoringInConfigFile(appid + "1" + msgid + timestamp + traceID + version + appkey, "MD5").ToUpper();

            mobileQuickLogin1.WebLoginValidate(appid, appkey, version, sign, traceID, timestamp, openType, "", (obj, args) =>
            {
                if (string.IsNullOrEmpty(args.Token))
                {
                    Toast("返回码" + args.ResultCode + "error " + args.error);
                }
                else
                {
                    Toast(WebTelValidate(appid, appkey, platkey, clientkey, textBox2.Text, args.Token, args.UserInformation));
                }
            });
        }
        /// <summary>
        /// 删除凭证
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Press(object sender, EventArgs e)
        {
            mobileQuickLogin1.DelectScrip((obj, args) =>
            {
                if (Convert.ToBoolean(args.args) == true)

                {

                    Toast("删除成功");
                }
                else
                    Toast(args.error);
            });
        }
        /// <summary>
        /// app 根据token 获取手机号
        /// </summary>
        /// <param name="appid"></param>
        /// <param name="appkey"></param>
        /// <param name="appserecct"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        public string GetTel(string appid, string appserecct, string token)
        {
            //通过明码方式获取本机号码，若需要通过加密，请参考移动官网接口文档 https://dev.10086.cn/dev10086/pub/loadAttach?attachId=6EF75FD09D4F40D1973CB7C36C3DB2E2 自行实现
            //随机字符
            string msgid = CreatenNonce_str();
            //时间
            string systemtime = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            //MD5签名
            string sign = FormsAuthentication.HashPasswordForStoringInConfigFile(appid + "2.0" + msgid + systemtime + "0" + token + appserecct, "MD5").ToUpper();
            //转换json格式
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("version", "2.0");
            dict.Add("msgid", msgid);
            dict.Add("systemtime", systemtime);
            dict.Add("strictcheck", "0");
            dict.Add("appid", appid);
            dict.Add("token", token);
            dict.Add("sign", sign);
            dict.Add("encryptionalgorithm", "");
            byte[] buf = System.Text.Encoding.GetEncoding("UTF-8").GetBytes(JsonConvert.SerializeObject(dict));
            //发起请求
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("https://onekey2.cmpassport.com/unisdk/rsapi/loginTokenValidate");
            req.ContentType = "application/json;charset=utf-8";
            req.Method = "POST";
            req.ContentLength = buf.Length;
            Stream stream = req.GetRequestStream();
            stream.Write(buf, 0, buf.Length);
            stream.Close();
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            Stream stream1 = resp.GetResponseStream();
            try
            {
                //获取内容
                using (StreamReader reader = new StreamReader(stream1))
                {
                    string result = reader.ReadToEnd();
                    if (Tools.GetJsonValue(result, "resultCode") == "103000")
                        return "号码" + Tools.GetJsonValue(result, "msisdn") + " 返回码" + Tools.GetJsonValue(result, "resultCode");
                    else
                        return "错误描述 " + Tools.GetJsonValue(result, "desc") + " 返回码" + Tools.GetJsonValue(result, "resultCode");
                }
            }
            finally
            {
                stream1.Close();
            }
        }
        /// <summary>
        /// App版 根据token 验证是否为本机号码
        /// </summary>
        /// <param name="appid"></param>
        /// <param name="appkey"></param>
        /// <param name="phoneNum"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        public string TelValidate(string appid, string appkey, string platkey, string clientkey, string phone, string token)
        {
            ///移动官网接口文档 https://dev.10086.cn/dev10086/pub/loadAttach?attachId=6EF75FD09D4F40D1973CB7C36C3DB2E2
            //使用 UUID 标识请求的唯一性,这边使用SessionID代替
            string msgid = Client.SessionID;
            //时间
            string timestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            //keyType=1 时，使用社区中的客 户公钥所对应的私钥加签，加密算法 是 RSA，参数组装格式为(appId + msgId + phoneNum + timestamp +token + version)。
            string phoneNum = RSAEncrypt(phone + appkey + timestamp, RSAPublicKeyXML(platkey));
            //RSA
            string sign = MD5Sign(appid + msgid + phoneNum + timestamp + token + "1.0", clientkey);
            //转换json格式
            Dictionary<string, object> dict1 = new Dictionary<string, object>();
            dict1.Add("version", "1.0");
            dict1.Add("msgId", msgid);
            dict1.Add("appId", appid);
            dict1.Add("timestamp", timestamp);
            Dictionary<string, object> dict = new Dictionary<string, object>();
            //运营商类型：1：移动;2：联通;3： 电信; 0：未知
            dict.Add("openType", "1");
            dict.Add("requesterType", "0");
            //扩展参数格式：param1 = value1 | param2 = value2 方  式传递，参数以竖线 | 间隔方式传递，此参数需 urlencode 编码。
            // dict.Add("expandParams", "");非必填
            //接入方预留参数，该参数会透传给通知接口，此参数需 urlencode 编码,非必填
            //dict.Add("message", "");
            dict.Add("keyType", 1);//使用RSA加密

            dict.Add("phoneNum", phoneNum);
            dict.Add("token", token);
            dict.Add("sign", sign);
            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("header", dict1);
            param.Add("body", dict);
            byte[] buf = System.Text.Encoding.GetEncoding("UTF-8").GetBytes(JsonConvert.SerializeObject(param));
            //发起请求
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("https://onekey2.cmpassport.com/openapi/rs/tokenValidate");
            req.ContentType = "application/json;charset=utf-8";
            req.Method = "POST";
            req.ContentLength = buf.Length;
            Stream stream = req.GetRequestStream();
            stream.Write(buf, 0, buf.Length);
            stream.Close();
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            Stream stream1 = resp.GetResponseStream();
            try
            {
                //获取内容
                using (StreamReader reader = new StreamReader(stream1))
                {
                    string result = reader.ReadToEnd();
                    return result;
                    // return " 返回码" + Tools.GetJsonValue(result, "resultCode");
                }
            }
            finally
            {
                stream1.Close();
            }

        }
        /// <summary>
        /// web版 一键登录通过token 获取号码
        /// </summary>
        /// <param name="appid"></param>
        /// <param name="appkey"></param>
        /// <param name="clientkey"></param>
        /// <param name="token"></param>
        /// <param name="userinfo"></param>
        /// <returns></returns>
        public string WebGetTel(string appid, string appkey, string clientkey, string token, string userinfo)
        {
            //移动官方文档 http://dev.10086.cn/dev10086/pub/loadAttach?attachId=2B7316314A1C435DB3C531217A3D3AEF
            //随机字符
            string traceId = CreatenNonce_str();
            //时间
            string timestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            //RSA 私钥生签，appId+traceId+timestamp+token+version 注：“+”号为合并意思，不包含在被加密的字符串中，签名需要转成16进制大写
            string sign = SignatureHEX(appid + traceId + timestamp + token + "2.0", RSAPrivateKeyXML(clientkey));
            //转换json格式
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("token", token);
            dict.Add("sign", sign);
            dict.Add("userInformation", userinfo);
            dict.Add("expandParams", "");

            byte[] buf = System.Text.Encoding.GetEncoding("UTF-8").GetBytes(JsonConvert.SerializeObject(dict));
            //发起请求
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("https://www.cmpassport.com/h5/onekeylogin/tokenValidate");
            req.ContentType = "application/json;charset=utf-8";
            req.Method = "POST";
            //请求头
            //接口版本 填写2.0
            req.Headers.Add("interfaceVersion", "2.0");
            req.Headers.Add("appId", appid);
            req.Headers.Add("traceId", traceId);
            req.Headers.Add("timestamp", timestamp);
            //业务类型，填 8
            req.Headers.Add("businessType", "8");
            req.ContentLength = buf.Length;
            Stream stream = req.GetRequestStream();
            stream.Write(buf, 0, buf.Length);
            stream.Close();
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            Stream stream1 = resp.GetResponseStream();
            try
            {
                //获取内容
                using (StreamReader reader = new StreamReader(stream1))
                {
                    string result = reader.ReadToEnd();
                    if (Tools.GetJsonValue(result, "resultCode") == "103000")
                    {
                        return "号码" + AESDecrypt(Tools.GetJsonValue(result, "msisdn"), appkey) + " 返回码" + Tools.GetJsonValue(result, "resultCode");
                    }

                    else
                        return "错误描述 " + Tools.GetJsonValue(result, "desc") + " 返回码" + Tools.GetJsonValue(result, "resultCode");
                }
            }
            finally
            {
                stream1.Close();
            }
        }
        /// <summary>
        /// web 本机号码验证token
        /// </summary>
        /// <param name="appid"></param>
        /// <param name="appkey"></param>
        /// <param name="platkey"></param>
        /// <param name="clientkey"></param>
        /// <param name="phone"></param>
        /// <param name="token"></param>
        /// <param name="userInformation"></param>
        /// <returns></returns>
        public string WebTelValidate(string appid, string appkey, string platkey, string clientkey, string phone, string token, string userInformation)
        {
            ///移动官网接口文档 https://dev.10086.cn/dev10086/pub/loadAttach?attachId=F1D8277FE11F499CADE178A76AB6A879
            //使用 UUID 标识请求的唯一性,这边使用SessionID代替

            string msgid = System.Guid.NewGuid().ToString("N");
            //时间
            string timestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            string phoneNum = RSAEncrypt(phone + appkey + timestamp, RSAPublicKeyXML(platkey));
            //MD5 生签
            string sign = MD5Sign(appid + msgid + phoneNum + timestamp + token + "1.0", clientkey);
            //转换json格式
            ;
            Dictionary<string, object> dict1 = new Dictionary<string, object>();
            dict1.Add("version", "1.0");
            dict1.Add("msgId", msgid);
            dict1.Add("appId", appid);
            dict1.Add("timestamp", timestamp);
            Dictionary<string, object> dict = new Dictionary<string, object>();
            //扩展参数格式：param1 = value1 | param2 = value2 方  式传递，参数以竖线 | 间隔方式传递，此参数需 urlencode 编码。
            dict.Add("expandParams", "");
            dict.Add("phoneNum", phoneNum);
            dict.Add("token", token);
            dict.Add("sign", sign);
            dict.Add("userInformation", userInformation);
            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("header", dict1);
            param.Add("body", dict);
            string uu = JsonConvert.SerializeObject(param);
            byte[] buf = System.Text.Encoding.GetEncoding("UTF-8").GetBytes(JsonConvert.SerializeObject(param));
            //发起请求
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("https://www.cmpassport.com/NumberAbility/h5/verifyVmMobileApi.htm");
            req.ContentType = "application/json;charset=utf-8";
            req.Method = "POST";
            req.ContentLength = buf.Length;
            Stream stream = req.GetRequestStream();
            stream.Write(buf, 0, buf.Length);
            stream.Close();
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            Stream stream1 = resp.GetResponseStream();
            try
            {
                //获取内容
                using (StreamReader reader = new StreamReader(stream1))
                {
                    string result = reader.ReadToEnd();
                    return result;
                    //    return " 返回码" + Tools.GetJsonValue(result, "resultCode");
                }
            }
            finally
            {
                stream1.Close();
            }
        }
        /// <summary>
        /// 创建随机字符串
        /// </summary>
        /// <returns></returns>
        public static string CreatenNonce_str()
        {
            Random r = new Random();
            var sb = new StringBuilder();
            for (int i = 0; i < 15; i++)
            {
                sb.Append(r.Next(10));
            }
            return sb.ToString();
        }
        /// <summary>
        /// RSA加密
        /// </summary>
        /// <param name="publickey">公钥</param>
        /// <param name="content">加密内容</param>
        /// <returns></returns>
        public static string RSAEncrypt(string content, string publickey)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            byte[] cipherbytes;
            rsa.FromXmlString(publickey);
            cipherbytes = rsa.Encrypt(Encoding.UTF8.GetBytes(content), false);
            return Convert.ToBase64String(cipherbytes);
        }
        /// <summary>
        /// RSA生成签名，返回HEX（16进制）
        /// </summary>
        /// <param name="originalText"></param>
        /// <param name="privateKey"></param>
        /// <returns></returns>
        private string SignatureHEX(string originalText, string privateKey)
        {
            byte[] byteData = Encoding.UTF8.GetBytes(originalText);
            RSACryptoServiceProvider provider = new RSACryptoServiceProvider();
            provider.FromXmlString(privateKey);
            byteData = provider.SignData(byteData, new SHA256CryptoServiceProvider());
            //return Convert.ToBase64String(byteData);//Base64格式
            return BitConverter.ToString(byteData, 0).Replace("-", string.Empty).ToUpper();//HEX格式
        }

        /// AES解密(无向量)  
        /// </summary>  
        /// <param name="encryptedBytes">被加密的明文</param>  
        /// <param name="key">密钥</param>  
        /// <returns>明文</returns>  
        private string AESDecrypt(string toDecrypt, string key)
        {
            if (key.Length > 16)
                key = key.Substring(0, 16);
            byte[] keyArray = UTF8Encoding.UTF8.GetBytes(key); ;
            byte[] toEncryptArray = Convert.FromBase64String(toDecrypt);
            RijndaelManaged rDel = new RijndaelManaged();
            rDel.Key = keyArray;
            rDel.Mode = CipherMode.ECB;        //必须设置为ECB
            rDel.Padding = PaddingMode.PKCS7;  //必须设置为PKCS7
            rDel.BlockSize = 128;
            ICryptoTransform cTransform = rDel.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            return UTF8Encoding.UTF8.GetString(resultArray);
        }
        /// <summary>
        /// MD5 通过RSA私钥生签
        /// </summary>
        /// <param name="content">待加密字符串</param>
        /// <param name="privateKey">私钥</param>
        /// <returns>加密后字符串</returns>
        public string MD5Sign(string content, string privateKey)
        {
            byte[] pkcs8EncodedBytes = Convert.FromBase64String(privateKey.Replace("\r", "").Replace("\n", "").Replace(" ", ""));
            AsymmetricKeyParameter priKey = PrivateKeyFactory.CreateKey(pkcs8EncodedBytes);
            ISigner normalSig = SignerUtilities.GetSigner("MD5withRSA");
            normalSig.Init(true, priKey);
            byte[] byteData = Encoding.GetEncoding("UTF-8").GetBytes(content);
            normalSig.BlockUpdate(byteData, 0, byteData.Length);
            byte[] normalResult = normalSig.GenerateSignature();
            return Convert.ToBase64String(normalResult);
        }
        /// <summary>
        /// RSA公钥转xmlstring
        /// </summary>
        /// <param name="publicKey"></param>
        /// <returns></returns>
        public static string RSAPublicKeyXML(string publicKey)
        {
            RsaKeyParameters publicKeyParam = (RsaKeyParameters)PublicKeyFactory.CreateKey(Convert.FromBase64String(publicKey));
            return string.Format("<RSAKeyValue><Modulus>{0}</Modulus><Exponent>{1}</Exponent></RSAKeyValue>",
                    Convert.ToBase64String(publicKeyParam.Modulus.ToByteArrayUnsigned()),
                    Convert.ToBase64String(publicKeyParam.Exponent.ToByteArrayUnsigned()));
        }
        /// <summary>
        /// RSA 私钥转xmlstring
        /// </summary>
        /// <param name="privateJavaKey"></param>
        /// <returns></returns>
        public static string RSAPrivateKeyXML(string privateJavaKey)
        {
            RsaPrivateCrtKeyParameters privateKeyParam = (RsaPrivateCrtKeyParameters)PrivateKeyFactory.CreateKey(Convert.FromBase64String(privateJavaKey));
            return string.Format("<RSAKeyValue><Modulus>{0}</Modulus><Exponent>{1}</Exponent><P>{2}</P><Q>{3}</Q><DP>{4}</DP><DQ>{5}</DQ><InverseQ>{6}</InverseQ><D>{7}</D></RSAKeyValue>",
            Convert.ToBase64String(privateKeyParam.Modulus.ToByteArrayUnsigned()),
            Convert.ToBase64String(privateKeyParam.PublicExponent.ToByteArrayUnsigned()),
            Convert.ToBase64String(privateKeyParam.P.ToByteArrayUnsigned()),
            Convert.ToBase64String(privateKeyParam.Q.ToByteArrayUnsigned()),
            Convert.ToBase64String(privateKeyParam.DP.ToByteArrayUnsigned()),
            Convert.ToBase64String(privateKeyParam.DQ.ToByteArrayUnsigned()),
            Convert.ToBase64String(privateKeyParam.QInv.ToByteArrayUnsigned()),
            Convert.ToBase64String(privateKeyParam.Exponent.ToByteArrayUnsigned()));
        }

      
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
}