using System;
using System.Threading.Tasks;
using Essensoft.AspNetCore.Payment.Alipay;
using Essensoft.AspNetCore.Payment.Alipay.Notify;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace WebApplicationSample.Controllers
{
    [Route("alipay/notify")]
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
                    // 小程序审核驳回通知
                    case "alipay.open.mini.version.audit.rejected":
                        {
                            var notify = await _client.CertificateExecuteAsync<AlipayOpenMiniVersionAuditRejectedNotify>(Request, _optionsAccessor.Value);
                            return AlipayNotifyResult.Success;
                        }
                    // 收单退款冲退完成通知
                    case "alipay.trade.refund.depositback.completed":
                        {
                            var notify = await _client.CertificateExecuteAsync<AlipayTradeRefundDepositbackCompletedNotify>(Request, _optionsAccessor.Value);
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
                    // 身份认证记录消息
                    case "alipay.user.certify.open.notify.completed":
                        {
                            var notify = await _client.CertificateExecuteAsync<AlipayUserCertifyOpenNotifyCompletedNotify>(Request, _optionsAccessor.Value);
                            return AlipayNotifyResult.Success;
                        }
                    default:
                        return AlipayNotifyResult.Failure;
                }
            }
            catch
            {
                return AlipayNotifyResult.Failure;
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
                switch (notify.TradeStatus)
                {
                    case AlipayTradeStatus.Wait: // 等待付款
                        return AlipayNotifyResult.Success;
                    case AlipayTradeStatus.Success: // 支付成功
                        Console.WriteLine("OutTradeNo: " + notify.OutTradeNo);
                        return AlipayNotifyResult.Success;
                    default:
                        return AlipayNotifyResult.Failure;
                }
            }
            catch
            {
                return AlipayNotifyResult.Failure;
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

                return AlipayNotifyResult.Failure;
            }
            catch
            {
                return AlipayNotifyResult.Failure;
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

                return AlipayNotifyResult.Failure;
            }
            catch
            {
                return AlipayNotifyResult.Failure;
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

                return AlipayNotifyResult.Failure;
            }
            catch
            {
                return AlipayNotifyResult.Failure;
            }
        }

        /// <summary>
        /// 交易关闭异步通知
        /// </summary>
        [Route("close")]
        [HttpPost]
        public async Task<IActionResult> Close()
        {
            try
            {
                var notify = await _client.CertificateExecuteAsync<AlipayTradeCloseNotify>(Request, _optionsAccessor.Value);
                if (notify.TradeStatus == AlipayTradeStatus.Wait)
                {
                    Console.WriteLine("OutTradeNo: " + notify.OutTradeNo);

                    return AlipayNotifyResult.Success;
                }

                return AlipayNotifyResult.Failure;
            }
            catch
            {
                return AlipayNotifyResult.Failure;
            }
        }
    }
}
