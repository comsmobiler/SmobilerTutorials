using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using Aop.Api;
using Aop.Api.Request;
using Aop.Api.Domain;
using Aop.Api.Response;

namespace Smobiler.Tutorials.Plugins
{
    partial class demoAliPay : Smobiler.Core.Controls.MobileForm
    {
        public demoAliPay()
            : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            this.Close();
        }
        private string tradeNo;

        //支付宝应用编号，此应用必须签约 APP支付
        private string appid = "";
        //应用的私钥
        private string appPrivateKey = "";
        //应用的支付宝公钥
        private string aliPublicKey = "";
        //阿里支付网关
        private string aliOpenAPI = "https://openapi.alipay.com/gateway.do";

        private void btnOutOrder_Press(object sender, EventArgs e)
        {
            tradeNo = "SMOAPP" + DateTime.Now.ToString("yyyyMMddHHmmss");
            this.labOutOrder.Text = tradeNo;
        }

        private void btnCreateOrder_Press(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tradeNo) == true)
            {
                btnOutOrder_Press(null, null);
            }
            IAopClient client = GetAPOClient();
            //实例化具体API对应的request类,类名称和接口名称对应,当前调用接口名称如：alipay.trade.app.pay
            AlipayTradeAppPayRequest request = new AlipayTradeAppPayRequest();
            //SDK已经封装掉了公共参数，这里只需要传入业务参数。以下方法为sdk的model入参方式(model和biz_content同时存在的情况下取biz_content)。
            AlipayTradeAppPayModel model = new AlipayTradeAppPayModel();
            model.Body = "请支持0.01元"; //支付描述
            model.Subject = "支付"; //支付标题
            model.TotalAmount = "0.01"; //支付金额
            model.ProductCode = "QUICK_MSECURITY_PAY"; //产品码
            model.OutTradeNo = tradeNo; //外部编号，外部编号在支付成功时，只能使用一次
            model.TimeoutExpress = "30m"; //超时时间
            request.SetBizModel(model);
            //有条件可设置回调地址，支付宝在支付完成后会POST此地址。或通过查询的方式。
            //request.SetNotifyUrl("");
            //这里和普通的接口调用不同，使用的是sdkExecute
            AlipayTradeAppPayResponse response = client.SdkExecute(request);
            //页面输出的response.Body就是orderString 可以直接给客户端请求，无需再做处理。
            System.Diagnostics.Debug.WriteLine(response.Body);

            //注意，第一个参数是苹果支付需要的格式为ap应用编号，android可设置为空
            this.aliPay1.AppPay("ap" + appid, response.Body, (obj, args) =>
            {
                if (args.isError == true)
                {
                    MessageBox.Show(args.error);
                }
                else
                {
                    string result = "";
                    //foreach (KeyValuePair<string, object> item in args.result)
                    //{
                    //    result += string.Format("{0}/{1}" + Environment.NewLine, item.Key, item.Value);
                    //}
                    MessageBox.Show(result);
                }
            });
        }

        private void btnOrderStatus_Press(object sender, EventArgs e)
        {
            IAopClient client = GetAPOClient();
            //实例化具体API对应的request类,类名称和接口名称对应,当前调用接口名称如：alipay.trade.app.pay
            AlipayTradeQueryRequest request = new AlipayTradeQueryRequest();
            //SDK已经封装掉了公共参数，这里只需要传入业务参数。以下方法为sdk的model入参方式(model和biz_content同时存在的情况下取biz_content)。
            AlipayTradeQueryModel model = new AlipayTradeQueryModel();
            model.OutTradeNo = tradeNo;
            request.SetBizModel(model);
            //这是普通的接口使用Execute
            AlipayTradeQueryResponse response = client.Execute(request);
            //页面输出的response.Body就是orderString 可以直接给客户端请求，无需再做处理。
            System.Diagnostics.Debug.WriteLine(response.Body);
            MessageBox.Show(response.Body);
        }

        private IAopClient GetAPOClient()
        {
            return new DefaultAopClient(aliOpenAPI, appid, appPrivateKey, "json", "1.0", "RSA2", aliPublicKey, "utf-8", false);
        }
    }
}