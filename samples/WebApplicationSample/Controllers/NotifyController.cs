using System;
using System.Threading.Tasks;
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
using WebApplicationSample.Helpers;

namespace WebApplicationSample.Controllers
{
    #region 支付宝异步通知

    [Route("notify/alipay")]
    public class AlipayNotifyController : Controller
    {
        private readonly IAlipayNotifyClient _client;

        public AlipayNotifyController(IAlipayNotifyClient client)
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
                var notify = await _client.ExecuteAsync<AlipayTradePrecreateNotify>(Request);
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
                var notify = await _client.ExecuteAsync<AlipayTradeAppPayNotify>(Request);
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
                var notify = await _client.ExecuteAsync<AlipayTradePagePayNotify>(Request);
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
                var notify = await _client.ExecuteAsync<AlipayTradeWapPayNotify>(Request);
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
        private readonly IWeChatPayNotifyClient _client;

        public WeChatPayNotifyController(IWeChatPayNotifyClient client)
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
                var notify = await _client.ExecuteAsync<WeChatPayUnifiedOrderNotify>(Request);
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
                var notify = await _client.ExecuteAsync<WeChatPayRefundNotify>(Request);
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
        private readonly IQPayNotifyClient _client;

        public QPayNotifyController(IQPayNotifyClient client)
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
                var notify = await _client.ExecuteAsync<QPayUnifiedOrderNotify>(Request);
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
                var notify = await _client.ExecuteAsync<QPayMicroPayNotify>(Request);
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
        private readonly IJDPayNotifyClient _client;

        public JDPayNotifyController(IJDPayNotifyClient client)
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

        [Route("defraypay")]
        [HttpPost]
        public async Task<IActionResult> DefrayPay()
        {
            try
            {
                var notify = await _client.ExecuteAsync<JDPayDefrayPayNotifyResponse>(Request);
                Console.WriteLine("trade_no: " + notify.TradeNo + " trade_amount :" + notify.TradeAmount);
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
        private readonly ILianLianPayNotifyClient _client;

        public LianLianPayNotifyController(ILianLianPayNotifyClient client)
        {
            _client = client;
        }

        [Route("receivemoney")]
        [HttpPost]
        public async Task<IActionResult> ReceiveMoney()
        {
            try
            {
                var notify = await _client.ExecuteAsync<LianLianPayReceiveMoneyNotify>(Request);
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
                var notify = await _client.ExecuteAsync<LianLianPayRefundNotify>(Request);
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
        private readonly IUnionPayNotifyClient _client;

        public UnionPayNotifyController(IUnionPayNotifyClient client)
        {
            _client = client;
        }

        /// <summary>
        /// 网关支付 - 跳转网关页面支付通知
        /// </summary>
        /// <returns></returns>
        [Route("gatewaypayfrontconsume")]
        [HttpPost]
        public async Task<IActionResult> GatewayPayFrontConsume()
        {
            try
            {
                var notify = await _client.ExecuteAsync<UnionPayGatewayPayFrontConsumeNotify>(Request);
                Console.WriteLine("OrderId: " + notify.OrderId + " respCode :" + notify.RespCode);
                return UnionPayNotifyResult.Success;
            }
            catch
            {
                return NoContent();
            }
        }
    }

    #endregion
}
