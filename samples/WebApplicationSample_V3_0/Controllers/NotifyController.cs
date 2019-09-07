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
using Microsoft.Extensions.Options;

namespace WebApplicationSample_V3_0.Controllers
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
        /// 扫码支付异步通知
        /// </summary>
        /// <returns></returns>
        [Route("precreate")]
        [HttpPost]
        public async Task<IActionResult> Precreate()
        {
            try
            {
                var notify = await _client.ExecuteAsync<AlipayTradePrecreateNotify>(Request, _optionsAccessor.Value);
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
                var notify = await _client.ExecuteAsync<AlipayTradeAppPayNotify>(Request, _optionsAccessor.Value);
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
                var notify = await _client.ExecuteAsync<AlipayTradePagePayNotify>(Request, _optionsAccessor.Value);
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
                var notify = await _client.ExecuteAsync<AlipayTradeWapPayNotify>(Request, _optionsAccessor.Value);
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
        private readonly IOptions<WeChatPayOptions> _optionsAccessor;

        public WeChatPayNotifyController(IWeChatPayNotifyClient client, IOptions<WeChatPayOptions> optionsAccessor)
        {
            _client = client;
            _optionsAccessor = optionsAccessor;
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
                var notify = await _client.ExecuteAsync<WeChatPayUnifiedOrderNotify>(Request, _optionsAccessor.Value);
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
                var notify = await _client.ExecuteAsync<WeChatPayRefundNotify>(Request, _optionsAccessor.Value);
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
        private readonly IOptions<QPayOptions> _optionsAccessor;

        public QPayNotifyController(IQPayNotifyClient client, IOptions<QPayOptions> optionsAccessor)
        {
            _client = client;
            _optionsAccessor = optionsAccessor;
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
                var notify = await _client.ExecuteAsync<QPayUnifiedOrderNotify>(Request, _optionsAccessor.Value);
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
                var notify = await _client.ExecuteAsync<QPayMicroPayNotify>(Request, _optionsAccessor.Value);
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
        /// 企业付款 - 用户到账通知
        /// </summary>
        /// <returns></returns>
        [Route("b2cpay")]
        [HttpPost]
        public async Task<IActionResult> B2CPay()
        {
            try
            {
                var notify = await _client.ExecuteAsync<QPayEPayB2CNotify>(Request, _optionsAccessor.Value);
                Console.WriteLine("OutTradeNo: " + notify.OutTradeNo);
                return QPayNotifyResult.Success;
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
        private readonly IOptions<JDPayOptions> _optionsAccessor;

        public JDPayNotifyController(IJDPayNotifyClient client, IOptions<JDPayOptions> optionsAccessor)
        {
            _client = client;
            _optionsAccessor = optionsAccessor;
        }

        [Route("async")]
        [HttpPost]
        public async Task<IActionResult> Async()
        {
            try
            {
                var notify = await _client.ExecuteAsync<JDPayAsyncNotify>(Request, _optionsAccessor.Value);
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
                var notify = await _client.ExecuteAsync<JDPayDefrayPayNotify>(Request, _optionsAccessor.Value);
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
        private readonly IOptions<LianLianPayOptions> _optionsAccessor;

        public LianLianPayNotifyController(ILianLianPayNotifyClient client, IOptions<LianLianPayOptions> optionsAccessor)
        {
            _client = client;
            _optionsAccessor = optionsAccessor;
        }

        [Route("receivemoney")]
        [HttpPost]
        public async Task<IActionResult> ReceiveMoney()
        {
            try
            {
                var notify = await _client.ExecuteAsync<LianLianPayReceiveMoneyNotify>(Request, _optionsAccessor.Value);
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
                var notify = await _client.ExecuteAsync<LianLianPayRefundNotify>(Request, _optionsAccessor.Value);
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
        private readonly IOptions<UnionPayOptions> _optionsAccessor;

        public UnionPayNotifyController(IUnionPayNotifyClient client, IOptions<UnionPayOptions> optionsAccessor)
        {
            _client = client;
            _optionsAccessor = optionsAccessor;
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
                var notify = await _client.ExecuteAsync<UnionPayGatewayPayFrontConsumeNotify>(Request, _optionsAccessor.Value);
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
