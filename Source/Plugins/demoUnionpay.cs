using com.unionpay.acp.sdk;
using Smobiler.Core;
using Smobiler.Core.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoUnionpay : Smobiler.Core.Controls.MobileForm
    {
        public demoUnionpay() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        // log4net.config 用于配置调用银联支付生成的日志，日志生成位置查看config
        //在appconfig 中需要配置相应项以及银联证书存放文件夹地址
        string tradeNo = "";
        string merID = "***********";//商户id，从银联平台获取
        string ordertime = "";
        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Press(object sender, EventArgs e)
        {
            tradeNo = "SMOAPP" + DateTime.Now.ToString("yyyyMMddHHmmss");
            this.labOutOrder.Text = tradeNo;
        }
        /// <summary>
        /// 订单查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Press(object sender, EventArgs e)
        {
            /**
      * 重要：联调测试时请仔细阅读注释！
      * 
      * 产品：跳转网关支付产品<br>
      * 交易：交易状态查询交易：只有同步应答 
      * 日期： 2015-09<br>
       
      * 版权： 中国银联<br>
      * 说明：以下代码只是为了方便商户测试而提供的样例代码，商户可以根据自己需要，按照技术文档编写。该代码仅供参考，不提供编码性能及规范性等方面的保障<br>
      * 该接口参考文档位置：open.unionpay.com帮助中心 下载  产品接口规范  《网关支付产品接口规范》，<br>
      *              《平台接入接口规范-第5部分-附录》（内包含应答码接口规范，全渠道平台银行名称-简码对照表）<br>
      * 测试过程中的如果遇到疑问或问题您可以：1）优先在open平台中查找答案：
      * 							        调试过程中的问题或其他问题请在 https://open.unionpay.com/ajweb/help/faq/list 帮助中心 FAQ 搜索解决方案
      *                             测试过程中产生的7位应答码问题疑问请在https://open.unionpay.com/ajweb/help/respCode/respCodeList 输入应答码搜索解决方案
      *                           2） 咨询在线人工支持： open.unionpay.com注册一个用户并登陆在右上角点击“在线客服”，咨询人工QQ测试支持。
      * 交易说明： 1）对前台交易发起交易状态查询：前台类交易建议间隔（5分、10分、30分、60分、120分）发起交易查询，如果查询到结果成功，则不用再查询。（失败，处理中，查询不到订单均可能为中间状态）。也可以建议商户使用payTimeout（支付超时时间），过了这个时间点查询，得到的结果为最终结果。
      *        2）对后台交易发起交易状态查询：后台类资金类交易同步返回00，成功银联有后台通知，商户也可以发起 查询交易，可查询N次（不超过6次），每次时间间隔2N秒发起,即间隔1，2，4，8，16，32S查询（查询到03，04，05继续查询，否则终止查询）。
      *        					         后台类资金类同步返03 04 05响应码及未得到银联响应（读超时）需发起查询交易，可查询N次（不超过6次），每次时间间隔2N秒发起,即间隔1，2，4，8，16，32S查询（查询到03，04，05继续查询，否则终止查询）。
      */

            Dictionary<string, string> param = new Dictionary<string, string>();

            //以下信息非特殊情况不需要改动
            param["version"] = SDKConfig.Version;//版本号
            param["encoding"] = "UTF-8";//编码方式
            param["certId"] = CertUtil.GetSignCertId();//证书ID
            param["signMethod"] = SDKConfig.SignMethod;//签名方法
            param["txnType"] = "00";//交易类型
            param["txnSubType"] = "00";//交易子类
            param["bizType"] = "000000";//业务类型
            param["accessType"] = "0";//接入类型
            param["channelType"] = "07";//渠道类型

            //TODO 以下信息需要填写
            param["orderId"] = tradeNo;	//请修改被查询的交易的订单号，8-32位数字字母，不能含“-”或“_”，此处默认取demo演示页面传递的参数
            param["merId"] = merID;//商户代码，请改成自己的测试商户号，此处默认取demo演示页面传递的参数
            param["txnTime"] = ordertime;//请修改被查询的交易的订单发送时间，格式为YYYYMMDDhhmmss，此处默认取demo演示页面传递的参数


            AcpService.Sign(param, System.Text.Encoding.UTF8);  // 签名
            string url = SDKConfig.SingleQueryUrl;

            Dictionary<string, string> rspData = AcpService.Post(param, url, System.Text.Encoding.UTF8);


            if (rspData.Count != 0)
            {

                if (AcpService.Validate(rspData, System.Text.Encoding.UTF8))
                {
                    string respcode = rspData["respCode"]; //其他应答参数也可用此方法获取
                    if ("00" == respcode)
                    {
                        string origRespCode = rspData["origRespCode"]; //其他应答参数也可用此方法获取
                        //处理被查询交易的应答码逻辑
                        if ("00" == origRespCode)
                        {
                            //交易成功，更新商户订单状态
                            //TODO
                            Toast("交易成功。");
                        }
                        else if ("03" == origRespCode ||
                            "04" == origRespCode ||
                            "05" == origRespCode)
                        {
                            //需再次发起交易状态查询交易
                            //TODO
                            Toast("稍后查询。");
                        }
                        else
                        {
                            //其他应答码做以失败处理
                            //TODO
                            Toast("交易失败：" + rspData["origRespMsg"]);
                        }
                    }
                    else if ("03" == respcode ||
                            "04" == respcode ||
                            "05" == respcode)
                    {
                        //不明原因超时，后续继续发起交易查询。
                        //TODO
                        Toast("处理超时，请稍后查询。");
                    }
                    else
                    {
                        //其他应答码做以失败处理
                        //TODO
                        Toast("查询操作失败：" + rspData["respMsg"]);
                    }
                }
            }
            else
            {
                Toast("请求失败");
            }
        }
        /// <summary>
        /// 支付
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Press(object sender, EventArgs e)
        {
            /**
            * 重要：联调测试时请仔细阅读注释！
            * 
            * 产品：跳转网关支付产品<br>
            * 交易：消费：前台跳转，有前台通知应答和后台通知应答
            * 日期： 2015-09<br>
            
            * 版权： 中国银联<br>
            * 说明：以下代码只是为了方便商户测试而提供的样例代码，商户可以根据自己需要，按照技术文档编写。该代码仅供参考，不提供编码性能规范性等方面的保障
            * 提示：该接口参考文档位置：open.unionpay.com帮助中心 下载  产品接口规范  《网关支付产品接口规范》
            *              《平台接入接口规范-第5部分-附录》（内包含应答码接口规范，全渠道平台银行名称-简码对照表)
            *              《全渠道平台接入接口规范 第3部分 文件接口》（对账文件格式说明）
            * 测试过程中的如果遇到疑问或问题您可以：1）优先在open平台中查找答案：
            * 							        调试过程中的问题或其他问题请在 https://open.unionpay.com/ajweb/help/faq/list 帮助中心 FAQ 搜索解决方案
            *                             测试过程中产生的7位应答码问题疑问请在https://open.unionpay.com/ajweb/help/respCode/respCodeList 输入应答码搜索解决方案
            *                          2） 咨询在线人工支持： open.unionpay.com注册一个用户并登陆在右上角点击“在线客服”，咨询人工QQ测试支持。
            * 交易说明:1）以后台通知或交易状态查询交易确定交易成功,前台通知不能作为判断成功的标准.
            *       2）交易状态查询交易（Form_6_5_Query）建议调用机制：前台类交易建议间隔（5分、10分、30分、60分、120分）发起交易查询，如果查询到结果成功，则不用再查询。（失败，处理中，查询不到订单均可能为中间状态）。也可以建议商户使用payTimeout（支付超时时间），过了这个时间点查询，得到的结果为最终结果。
            */

            Dictionary<string, string> param = new Dictionary<string, string>();

            //以下信息非特殊情况不需要改动
            param["version"] = SDKConfig.Version;//版本号
            param["encoding"] = "UTF-8";//编码方式
            param["txnType"] = "01";//交易类型
            param["txnSubType"] = "01";//交易子类
            param["bizType"] = "000201";//业务类型
            param["signMethod"] = SDKConfig.SignMethod;//签名方法
            param["channelType"] = "08";//渠道类型
            param["accessType"] = "0";//接入类型
            param["backUrl"] = SDKConfig.BackUrl;  //后台通知地址
            param["currencyCode"] = "156";//交易币种

            //TODO 以下信息需要填写
            param["merId"] = merID;//商户号，请改自己的测试商户号，此处默认取demo演示页面传递的参数
            param["orderId"] = tradeNo;//商户订单号，8-32位数字字母，不能含“-”或“_”，此处默认取demo演示页面传递的参数，可以自行定制规则
            param["txnTime"] = ordertime = DateTime.Now.ToString("yyyyMMddHHmmss");//订单发送时间，格式为YYYYMMDDhhmmss，取北京时间，此处默认取demo演示页面传递的参数，参考取法： DateTime.Now.ToString("yyyyMMddHHmmss")
            param["txnAmt"] = "5000";//交易金额，单位分，此处默认取demo演示页面传递的参数

            // 请求方保留域，
            // 透传字段，查询、通知、对账文件中均会原样出现，如有需要请启用并修改自己希望透传的数据。
            // 出现部分特殊字符时可能影响解析，请按下面建议的方式填写：
            // 1. 如果能确定内容不会出现&={}[]"'等符号时，可以直接填写数据，建议的方法如下。
            //param["reqReserved"] = "透传信息1|透传信息2|透传信息3";
            // 2. 内容可能出现&={}[]"'符号时：
            // 1) 如果需要对账文件里能显示，可将字符替换成全角＆＝｛｝【】“‘字符（自己写代码，此处不演示）；
            // 2) 如果对账文件没有显示要求，可做一下base64（如下）。
            //    注意控制数据长度，实际传输的数据长度不能超过1024位。
            //    查询、通知等接口解析时使用System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(reqReserved))解base64后再对数据做后续解析。
            //param["reqReserved"] = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes("任意格式的信息都可以"));

            //TODO 其他特殊用法请查看 pages/api_05_app/special_use_purchase.htm

            AcpService.Sign(param, System.Text.Encoding.UTF8);  // 签名
            string url = SDKConfig.AppRequestUrl;

            Dictionary<String, String> rspData = AcpService.Post(param, url, System.Text.Encoding.UTF8);

            if (rspData.Count != 0)
            {
                if (AcpService.Validate(rspData, System.Text.Encoding.UTF8))
                {
                    Toast("商户端验证返回报文签名成功。");
                    string respcode = rspData["respCode"]; //其他应答参数也可用此方法获取
                    if ("00" == respcode)
                    {
                        //成功
                        //TODO
                        Toast("成功接收tn：" + rspData["tn"]);
                        unionPay1.Pay("01", rspData["tn"].ToString(), (obj, args) =>
                        {
                            if (args.isError == false)
                                Toast("succcess");
                            else { Toast(args.error); }
                        });
                        //后续请将此tn传给手机开发，由他们用此tn调起控件后完成支付。
                        //手机端demo默认从仿真获取tn，仿真只返回一个tn，如不想修改手机和后台间的通讯方式，
                    }
                    else
                    {
                        //其他应答码做以失败处理
                        //TODO
                        Toast("失败：" + rspData["respMsg"]);
                    }
                }
                else
                {
                    Toast("商户端验证返回报文签名失败。");
                }
            }
            else
            {
                Toast("请求失败");
            }
        }

        /// <summary>
        /// ios 支付，比安卓支付多了一个参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Press(object sender, EventArgs e)
        {

            /**
        * 重要：联调测试时请仔细阅读注释！
        * 
        * 产品：跳转网关支付产品<br>
        * 交易：消费：前台跳转，有前台通知应答和后台通知应答<br>
        * 日期： 2015-09<br>
        
        * 版权： 中国银联<br>
        * 说明：以下代码只是为了方便商户测试而提供的样例代码，商户可以根据自己需要，按照技术文档编写。该代码仅供参考，不提供编码性能规范性等方面的保障
        * 提示：该接口参考文档位置：open.unionpay.com帮助中心 下载  产品接口规范  《网关支付产品接口规范》，
        *              《平台接入接口规范-第5部分-附录》（内包含应答码接口规范，全渠道平台银行名称-简码对照表)
        *              《全渠道平台接入接口规范 第3部分 文件接口》（对账文件格式说明）
        * 测试过程中的如果遇到疑问或问题您可以：1）优先在open平台中查找答案：
        * 							        调试过程中的问题或其他问题请在 https://open.unionpay.com/ajweb/help/faq/list 帮助中心 FAQ 搜索解决方案
        *                             测试过程中产生的7位应答码问题疑问请在https://open.unionpay.com/ajweb/help/respCode/respCodeList 输入应答码搜索解决方案
        *                          2） 咨询在线人工支持： open.unionpay.com注册一个用户并登陆在右上角点击“在线客服”，咨询人工QQ测试支持。
        * 交易说明:1）以后台通知或交易状态查询交易确定交易成功,前台通知不能作为判断成功的标准.
        *       2）交易状态查询交易（Form_6_5_Query）建议调用机制：前台类交易建议间隔（5分、10分、30分、60分、120分）发起交易查询，如果查询到结果成功，则不用再查询。（失败，处理中，查询不到订单均可能为中间状态）。也可以建议商户使用payTimeout（支付超时时间），过了这个时间点查询，得到的结果为最终结果。
        */

            Dictionary<string, string> param = new Dictionary<string, string>();

            //以下信息非特殊情况不需要改动
            param["version"] = SDKConfig.Version;//版本号
            param["encoding"] = "UTF-8";//编码方式
            param["txnType"] = "01";//交易类型
            param["txnSubType"] = "01";//交易子类
            param["bizType"] = "000201";//业务类型
            param["signMethod"] = SDKConfig.SignMethod;//签名方法
            param["channelType"] = "08";//渠道类型
            param["accessType"] = "0";//接入类型    
            param["backUrl"] = SDKConfig.BackUrl;  //后台通知地址
            param["currencyCode"] = "156";//交易币种

            //TODO 以下信息需要填写
            param["merId"] = merID;//商户号，请改自己的测试商户号，此处默认取demo演示页面传递的参数
            param["orderId"] = tradeNo;//商户订单号，8-32位数字字母，不能含“-”或“_”，此处默认取demo演示页面传递的参数，可以自行定制规则
            param["txnTime"] = ordertime = DateTime.Now.ToString("yyyyMMddHHmmss");//订单发送时间，格式为YYYYMMDDhhmmss，取北京时间，此处默认取demo演示页面传递的参数，参考取法： DateTime.Now.ToString("yyyyMMddHHmmss")
            param["txnAmt"] = "5000";//交易金额，单位分，此处默认取demo演示页面传递的参数

            // 请求方保留域，
            // 透传字段，查询、通知、对账文件中均会原样出现，如有需要请启用并修改自己希望透传的数据。
            // 出现部分特殊字符时可能影响解析，请按下面建议的方式填写：
            // 1. 如果能确定内容不会出现&={}[]"'等符号时，可以直接填写数据，建议的方法如下。
            //param["reqReserved"] = "透传信息1|透传信息2|透传信息3";
            // 2. 内容可能出现&={}[]"'符号时：
            // 1) 如果需要对账文件里能显示，可将字符替换成全角＆＝｛｝【】“‘字符（自己写代码，此处不演示）；
            // 2) 如果对账文件没有显示要求，可做一下base64（如下）。
            //    注意控制数据长度，实际传输的数据长度不能超过1024位。
            //    查询、通知等接口解析时使用System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(reqReserved))解base64后再对数据做后续解析。
            //param["reqReserved"] = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes("任意格式的信息都可以"));

            //TODO 其他特殊用法请查看 pages/api_05_app/special_use_purchase.htm

            AcpService.Sign(param, System.Text.Encoding.UTF8);  // 签名
            string url = SDKConfig.AppRequestUrl;

            Dictionary<String, String> rspData = AcpService.Post(param, url, System.Text.Encoding.UTF8);

            if (rspData.Count != 0)
            {
                if (AcpService.Validate(rspData, System.Text.Encoding.UTF8))
                {
                    Toast("商户端验证返回报文签名成功。");
                    string respcode = rspData["respCode"]; //其他应答参数也可用此方法获取
                    if ("00" == respcode)
                    {
                        //成功
                        //TODO
                        Toast("成功接收tn：" + rspData["tn"]);
                        unionPay1.Pay("01", rspData["tn"].ToString(), "payDemo", (obj, args) =>
                        {
                            if (args.isError == false)
                                Toast("succcess");
                            else { Toast(args.error); }
                        });
                        //后续请将此tn传给手机开发，由他们用此tn调起控件后完成支付。
                        //手机端demo默认从仿真获取tn，仿真只返回一个tn
                    }
                    else
                    {
                        //其他应答码做以失败处理
                        //TODO
                        Toast("失败：" + rspData["respMsg"]);
                    }
                }
                else
                {
                    Toast("商户端验证返回报文签名失败。");
                }
            }
            else
            {
                Toast("请求失败");
            }
        }
    }
}