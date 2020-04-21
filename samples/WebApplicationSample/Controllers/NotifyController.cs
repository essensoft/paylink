using System;
using System.Threading.Tasks;
using System.Xml;
using Essensoft.AspNetCore.Payment.Alipay;
using Essensoft.AspNetCore.Payment.Alipay.Notify;
using Essensoft.AspNetCore.Payment.Alipay.Utility;
using Essensoft.AspNetCore.Payment.WeChatPay;
using Essensoft.AspNetCore.Payment.WeChatPay.Notify;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace WebApplicationSample.Controllers
{
    #region 支付宝异步通知

    [Route("notify/alipay")]
    public class AlipayNotifyController : Controller
    {
        private readonly IAlipayNotifyClient _client;
        private readonly IOptions<AlipayOptions> _optionsAccessor;

        public AlipayNotifyController(IAlipayNotifyClient client, IOptions<AlipayOptions> optionsAccessor)
        {
            _client = client;
            _optionsAccessor = optionsAccessor;
        }

        /// <summary>
        /// 应用网关
        /// </summary>
        /// <returns></returns>
        [Route("gateway")]
        [HttpPost]
        public async Task<IActionResult> Gateway()
        {
            try
            {
                var service = Request.Form["service"].ToString();
                switch (service)
                {
                    // 激活开发者模式
                    case "alipay.service.check":
                        {
                            var options = _optionsAccessor.Value;

                            // 获取参数
                            var parameters = _client.GetParameters(Request);
                            var sign = parameters["sign"];
                            parameters.Remove("sign");

                            var signContent = AlipaySignature.GetSignContent(parameters);

                            // 验签
                            var isSuccess = AlipaySignature.RSACheckContent(signContent, sign, options.AlipayPublicKey, "GBK", options.SignType);

                            // 组XML响应内容
                            var response = MakeVerifyGWResponse(isSuccess, options.AlipayPublicKey, options.AppPrivateKey, "GBK", options.SignType);

                            return Content(response, "text/xml");
                        }
                }

                var msg_method = Request.Form["msg_method"].ToString();
                switch (msg_method)
                {
                    // 资金单据状态变更通知
                    case "alipay.fund.trans.order.changed":
                        {
                            var notify = await _client.CertificateExecuteAsync<AlipayFundTransOrderChangedNotify>(Request, _optionsAccessor.Value);
                            return AlipayNotifyResult.Success;
                        }
                    // 第三方应用授权取消消息
                    case "alipay.open.auth.appauth.cancelled":
                        {
                            var notify = await _client.CertificateExecuteAsync<AlipayOpenAuthAppauthCancelledNotify>(Request, _optionsAccessor.Value);
                            return AlipayNotifyResult.Success;
                        }
                    // 用户授权取消消息
                    case "alipay.open.auth.userauth.cancelled":
                        {
                            var notify = await _client.CertificateExecuteAsync<AlipayOpenAuthUserauthCancelledNotify>(Request, _optionsAccessor.Value);
                            return AlipayNotifyResult.Success;
                        }
                    // 小程序审核通过通知
                    case "alipay.open.mini.version.audit.passed":
                        {
                            var notify = await _client.CertificateExecuteAsync<AlipayOpenMiniVersionAuditPassedNotify>(Request, _optionsAccessor.Value);
                            return AlipayNotifyResult.Success;
                        }
                    // 用户授权取消消息
                    case "alipay.open.mini.version.audit.rejected":
                        {
                            var notify = await _client.CertificateExecuteAsync<AlipayOpenMiniVersionAuditRejectedNotify>(Request, _optionsAccessor.Value);
                            return AlipayNotifyResult.Success;
                        }
                    // 收单资金结算到银行账户，结算退票的异步通知
                    case "alipay.trade.settle.dishonoured":
                        {
                            var notify = await _client.CertificateExecuteAsync<AlipayTradeSettleDishonouredNotify>(Request, _optionsAccessor.Value);
                            return AlipayNotifyResult.Success;
                        }
                    // 收单资金结算到银行账户，结算失败的异步通知
                    case "alipay.trade.settle.fail":
                        {
                            var notify = await _client.CertificateExecuteAsync<AlipayTradeSettleFailNotify>(Request, _optionsAccessor.Value);
                            return AlipayNotifyResult.Success;
                        }
                    // 收单资金结算到银行账户，结算成功的异步通知
                    case "alipay.trade.settle.success":
                        {
                            var notify = await _client.CertificateExecuteAsync<AlipayTradeSettleSuccessNotify>(Request, _optionsAccessor.Value);
                            return AlipayNotifyResult.Success;
                        }
                }

                return NoContent();
            }
            catch
            {
                return NoContent();
            }
        }

        /// <summary>
        /// 扫码支付异步通知
        /// </summary>
        [Route("precreate")]
        [HttpPost]
        public async Task<IActionResult> Precreate()
        {
            try
            {
                var notify = await _client.CertificateExecuteAsync<AlipayTradePrecreateNotify>(Request, _optionsAccessor.Value);
                if (notify.TradeStatus == AlipayTradeStatus.Success)
                {
                    Console.WriteLine("OutTradeNo: " + notify.OutTradeNo);

                    return AlipayNotifyResult.Success;
                }
                return NoContent();
            }
            catch
            {
                return NoContent();
            }
        }

        /// <summary>
        /// APP支付异步通知
        /// </summary>
        [Route("apppay")]
        [HttpPost]
        public async Task<IActionResult> AppPay()
        {
            try
            {
                var notify = await _client.CertificateExecuteAsync<AlipayTradeAppPayNotify>(Request, _optionsAccessor.Value);
                if (notify.TradeStatus == AlipayTradeStatus.Success)
                {
                    Console.WriteLine("OutTradeNo: " + notify.OutTradeNo);

                    return AlipayNotifyResult.Success;
                }
                return NoContent();
            }
            catch
            {
                return NoContent();
            }
        }

        /// <summary>
        /// 电脑网站支付异步通知
        /// </summary>
        [Route("pagepay")]
        [HttpPost]
        public async Task<IActionResult> PagePay()
        {
            try
            {
                var notify = await _client.CertificateExecuteAsync<AlipayTradePagePayNotify>(Request, _optionsAccessor.Value);
                if (notify.TradeStatus == AlipayTradeStatus.Success)
                {
                    Console.WriteLine("OutTradeNo: " + notify.OutTradeNo);

                    return AlipayNotifyResult.Success;
                }
                return NoContent();
            }
            catch
            {
                return NoContent();
            }
        }

        /// <summary>
        /// 手机网站支付异步通知
        /// </summary>
        [Route("wappay")]
        [HttpPost]
        public async Task<IActionResult> WapPay()
        {
            try
            {
                var notify = await _client.CertificateExecuteAsync<AlipayTradeWapPayNotify>(Request, _optionsAccessor.Value);
                if (notify.TradeStatus == AlipayTradeStatus.Success)
                {
                    Console.WriteLine("OutTradeNo: " + notify.OutTradeNo);

                    return AlipayNotifyResult.Success;
                }
                return NoContent();
            }
            catch
            {
                return NoContent();
            }
        }

        private string MakeVerifyGWResponse(bool isSuccess, string certPublicKey, string appPrivateKey, string charset, string signType)
        {
            var xmlDoc = new XmlDocument(); //创建实例
            var xmldecl = xmlDoc.CreateXmlDeclaration("1.0", "GBK", null);
            xmlDoc.AppendChild(xmldecl);

            var xmlElem = xmlDoc.CreateElement("alipay"); //新建元素
            xmlDoc.AppendChild(xmlElem); //添加元素

            var alipay = xmlDoc.SelectSingleNode("alipay");

            var response = xmlDoc.CreateElement("response");
            var success = xmlDoc.CreateElement("success");
            if (isSuccess)
            {
                success.InnerText = "true";//设置文本节点 
                response.AppendChild(success);//添加到<Node>节点中 
            }
            else
            {
                success.InnerText = "false";//设置文本节点 
                response.AppendChild(success);//添加到<Node>节点中 
                var err = xmlDoc.CreateElement("error_code");
                err.InnerText = "VERIFY_FAILED";
                response.AppendChild(err);
            }

            var biz_content = xmlDoc.CreateElement("biz_content");
            biz_content.InnerText = certPublicKey;
            response.AppendChild(biz_content);

            alipay.AppendChild(response);

            var sign = xmlDoc.CreateElement("sign");
            sign.InnerText = AlipaySignature.RSASignContent(response.InnerXml, appPrivateKey, charset, signType);
            alipay.AppendChild(sign);

            var sign_type = xmlDoc.CreateElement("sign_type");
            sign_type.InnerText = signType;
            alipay.AppendChild(sign_type);

            return xmlDoc.InnerXml;
        }
    }

    #endregion

    #region 微信支付异步通知

    [Route("notify/wechatpay")]
    public class WeChatPayNotifyController : Controller
    {
        private readonly IWeChatPayNotifyClient _client;
        private readonly IOptions<WeChatPayOptions> _optionsAccessor;

        public WeChatPayNotifyController(IWeChatPayNotifyClient client, IOptions<WeChatPayOptions> optionsAccessor)
        {
            _client = client;
            _optionsAccessor = optionsAccessor;
        }

        /// <summary>
        /// 统一下单支付结果通知
        /// </summary>
        [Route("unifiedorder")]
        [HttpPost]
        public async Task<IActionResult> Unifiedorder()
        {
            try
            {
                var notify = await _client.ExecuteAsync<WeChatPayUnifiedOrderNotify>(Request, _optionsAccessor.Value);
                if (notify.ReturnCode == WeChatPayCode.Success)
                {
                    if (notify.ResultCode == WeChatPayCode.Success)
                    {
                        Console.WriteLine("OutTradeNo: " + notify.OutTradeNo);

                        return WeChatPayNotifyResult.Success;
                    }
                }
                return NoContent();
            }
            catch
            {
                return NoContent();
            }
        }

        /// <summary>
        /// 退款结果通知
        /// </summary>
        [Route("refund")]
        [HttpPost]
        public async Task<IActionResult> Refund()
        {
            try
            {
                var notify = await _client.ExecuteAsync<WeChatPayRefundNotify>(Request, _optionsAccessor.Value);
                if (notify.ReturnCode == WeChatPayCode.Success)
                {
                    if (notify.RefundStatus == WeChatPayCode.Success)
                    {
                        Console.WriteLine("OutTradeNo: " + notify.OutTradeNo);
                        return WeChatPayNotifyResult.Success;
                    }
                }
                return NoContent();
            }
            catch
            {
                return NoContent();
            }
        }
    }

    #endregion
}
