using Essensoft.AspNetCore.Payment.Alipay;
using Essensoft.AspNetCore.Payment.Alipay.Notify;
using Essensoft.AspNetCore.Payment.JDPay;
using Essensoft.AspNetCore.Payment.JDPay.Notify;
using Essensoft.AspNetCore.Payment.LianLianPay;
using Essensoft.AspNetCore.Payment.LianLianPay.Notify;
using Essensoft.AspNetCore.Payment.QPay;
using Essensoft.AspNetCore.Payment.QPay.Notify;
using Essensoft.AspNetCore.Payment.UnionPay;
using Essensoft.AspNetCore.Payment.UnionPay.Notify;
using Essensoft.AspNetCore.Payment.WeChatPay;
using Essensoft.AspNetCore.Payment.WeChatPay.Notify;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace NewWebApplicationSample.Controllers
{
    #region 支付宝异步通知

    [Route("notify/alipay")]
    public class AlipayNotifyController : Controller
    {
        private readonly AlipayNotifyClient _client = null;
        public AlipayNotifyController(AlipayNotifyClient client)
        {
            _client = client;
        }

        /// <summary>
        /// 扫码支付异步通知
        /// </summary>
        /// <returns></returns>
        [Route("precreate")]
        [HttpPost]
        public async Task<IActionResult> Precreate()
        {
            try
            {
                var notify = await _client.ExecuteAsync<AlipayTradePrecreateNotifyResponse>(Request);
                if ("TRADE_SUCCESS" == notify.TradeStatus)
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
        /// 条码支付异步通知
        /// </summary>
        /// <returns></returns>
        [Route("pay")]
        [HttpPost]
        public async Task<IActionResult> Pay()
        {
            try
            {
                var notify = await _client.ExecuteAsync<AlipayTradePayNotifyResponse>(Request);
                if ("TRADE_SUCCESS" == notify.TradeStatus)
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
        /// <returns></returns>
        [Route("apppay")]
        [HttpPost]
        public async Task<IActionResult> AppPay()
        {
            try
            {
                var notify = await _client.ExecuteAsync<AlipayTradeAppPayNotifyResponse>(Request);
                if ("TRADE_SUCCESS" == notify.TradeStatus)
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
        /// <returns></returns>
        [Route("pagepay")]
        [HttpPost]
        public async Task<IActionResult> PagePay()
        {
            try
            {
                var notify = await _client.ExecuteAsync<AlipayTradePagePayNotifyResponse>(Request);
                if ("TRADE_SUCCESS" == notify.TradeStatus)
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
        /// <returns></returns>
        [Route("wappay")]
        [HttpPost]
        public async Task<IActionResult> WapPay()
        {
            try
            {
                var notify = await _client.ExecuteAsync<AlipayTradeWapPayNotifyResponse>(Request);
                if ("TRADE_SUCCESS" == notify.TradeStatus)
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
    }

    #endregion

    #region 微信支付异步通知

    [Route("notify/wechatpay")]
    public class WeChatPayNotifyController : Controller
    {
        private readonly WeChatPayNotifyClient _client = null;
        public WeChatPayNotifyController(WeChatPayNotifyClient client)
        {
            _client = client;
        }

        /// <summary>
        /// 统一下单支付结果通知
        /// </summary>
        /// <returns></returns>
        [Route("unifiedorder")]
        [HttpPost]
        public async Task<IActionResult> Unifiedorder()
        {
            try
            {
                var notify = await _client.ExecuteAsync<WeChatPayUnifiedOrderNotifyResponse>(Request);
                if (notify.ReturnCode == "SUCCESS")
                {
                    if (notify.ResultCode == "SUCCESS")
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
        /// <returns></returns>
        [Route("refund")]
        [HttpPost]
        public async Task<IActionResult> Refund()
        {
            try
            {
                var notify = await _client.ExecuteAsync<WeChatPayRefundNotifyResponse>(Request);
                if (notify.ReturnCode == "SUCCESS")
                {
                    if (notify.RefundStatus == "SUCCESS")
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

    #region QQ钱包异步通知

    [Route("notify/qpay")]
    public class QPayNotifyController : Controller
    {
        private readonly QPayNotifyClient _client = null;
        public QPayNotifyController(QPayNotifyClient client)
        {
            _client = client;
        }

        /// <summary>
        /// 统一下单支付结果通知
        /// </summary>
        /// <returns></returns>
        [Route("unifiedorder")]
        [HttpPost]
        public async Task<IActionResult> Unifiedorder()
        {
            try
            {
                var notify = await _client.ExecuteAsync<QPayUnifiedOrderNotifyResponse>(Request);
                if ("SUCCESS" == notify.TradeState)
                {
                    Console.WriteLine("OutTradeNo: " + notify.OutTradeNo);
                    return QPayNotifyResult.Success;
                }
                return NoContent();
            }
            catch
            {
                return NoContent();
            }
        }

        /// <summary>
        /// 付款码支付结果通知
        /// </summary>
        /// <returns></returns>
        [Route("micropay")]
        [HttpPost]
        public async Task<IActionResult> MicroPay()
        {
            try
            {
                var notify = await _client.ExecuteAsync<QPayMicroPayNotifyResponse>(Request);
                if ("SUCCESS" == notify.TradeState)
                {
                    Console.WriteLine("OutTradeNo: " + notify.OutTradeNo);
                    return QPayNotifyResult.Success;
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

    #region 京东支付异步通知

    [Route("notify/jdpay")]
    public class JDPayNotifyController : Controller
    {
        private readonly JDPayNotifyClient _client = null;
        public JDPayNotifyController(JDPayNotifyClient client)
        {
            _client = client;
        }

        [Route("async")]
        [HttpPost]
        public async Task<IActionResult> Async()
        {
            try
            {
                var notify = await _client.ExecuteAsync<JDPayAsyncNotifyResponse>(Request);
                Console.WriteLine("TradeNum: " + notify.TradeNum + " tradeType :" + notify.TradeType);// notify.TradeType 0-消费 1-退款
                return JDPayNotifyResult.Success;
            }
            catch
            {
                return NoContent();
            }
        }
    }

    #endregion

    #region 连连支付异步通知

    [Route("notify/lianlianpay")]
    public class LianLianPayNotifyController : Controller
    {
        private readonly LianLianPayNotifyClient _client = null;
        public LianLianPayNotifyController(LianLianPayNotifyClient client)
        {
            _client = client;
        }

        [Route("webquickpay")]
        [HttpPost]
        public async Task<IActionResult> WebQuickPay()
        {
            try
            {
                var notify = await _client.ExecuteAsync<LianLianPayWebQuickPayNotifyResponse>(Request);
                Console.WriteLine("NoOrder: " + notify.NoOrder);
                return LianLianPayNotifyResult.Success;
            }
            catch
            {
                return NoContent();
            }
        }

        [Route("wapquickpay")]
        [HttpPost]
        public async Task<IActionResult> WapQuickPay()
        {
            try
            {
                var notify = await _client.ExecuteAsync<LianLianPayWapQuickPayNotifyResponse>(Request);
                Console.WriteLine("NoOrder: " + notify.NoOrder);
                return LianLianPayNotifyResult.Success;
            }
            catch
            {
                return NoContent();
            }
        }

        [Route("refund")]
        [HttpPost]
        public async Task<IActionResult> Refund()
        {
            try
            {
                var notify = await _client.ExecuteAsync<LianLianPayRefundNotifyResponse>(Request);
                Console.WriteLine("NoRefund: " + notify.NoRefund);
                return LianLianPayNotifyResult.Success;
            }
            catch
            {
                return NoContent();
            }
        }
    }

    #endregion

    #region 银联支付异步通知

    [Route("notify/unionpay")]
    public class UnionPayNotifyController : Controller
    {
        private readonly UnionPayNotifyClient _client = null;
        public UnionPayNotifyController(UnionPayNotifyClient client)
        {
            _client = client;
        }

        /// <summary>
        /// 网关支付 - 跳转网关页面支付通知
        /// </summary>
        /// <returns></returns>
        [Route("frontconsume62")]
        [HttpPost]
        public async Task<IActionResult> FrontConsume62()
        {
            try
            {
                var notify = await _client.ExecuteAsync<UnionPayForm_6_2_FrontConsumeNotifyResponse>(Request);
                Console.WriteLine("OrderId: " + notify.OrderId + " respCode :" + notify.RespCode);
                return UnionPayNotifyResult.Ok;
            }
            catch
            {
                return NoContent();
            }
        }
    }

    #endregion
}
