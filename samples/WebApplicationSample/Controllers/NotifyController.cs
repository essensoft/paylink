using Essensoft.AspNetCore.Alipay;
using Essensoft.AspNetCore.Alipay.Notify;
using Essensoft.AspNetCore.JdPay;
using Essensoft.AspNetCore.JdPay.Notify;
using Essensoft.AspNetCore.QPay;
using Essensoft.AspNetCore.QPay.Notify;
using Essensoft.AspNetCore.WeChatPay;
using Essensoft.AspNetCore.WeChatPay.Notify;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace WebApplicationSample.Controllers
{
    [Route("notify/alipay")]
    public class AlipayNotifyController : Controller
    {
        private readonly AlipayNotifyClient _client = null;
        public AlipayNotifyController(AlipayNotifyClient client)
        {
            _client = client;
        }

        /// <summary>
        /// 电脑网站支付异步通知
        /// </summary>
        /// <returns></returns>
        [Route("pagepay")]
        [HttpPost]
        public IActionResult PagePay()
        {
            try
            {
                var notify = _client.Execute<AlipayTradePagePayNotifyResponse>(Request);
                if ("TRADE_SUCCESS" == notify.TradeStatus)
                {
                    Console.WriteLine("OutTradeNo: " + notify.OutTradeNo);

                    return Content("success", "text/plain");
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
        public IActionResult WapPay()
        {
            try
            {
                var notify = _client.Execute<AlipayTradeWapPayNotifyResponse>(Request);
                if ("TRADE_SUCCESS" == notify.TradeStatus)
                {
                    Console.WriteLine("OutTradeNo: " + notify.OutTradeNo);

                    return Content("success", "text/plain");
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
        /// <returns></returns>
        [Route("precreate")]
        [HttpPost]
        public IActionResult Precreate()
        {
            try
            {
                var notify = _client.Execute<AlipayTradePrecreateNotifyResponse>(Request);
                if ("TRADE_SUCCESS" == notify.TradeStatus)
                {
                    Console.WriteLine("OutTradeNo: " + notify.OutTradeNo);

                    return Content("success", "text/plain");
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
        public IActionResult Pay()
        {
            try
            {
                var notify = _client.Execute<AlipayTradePayNotifyResponse>(Request);
                if ("TRADE_SUCCESS" == notify.TradeStatus)
                {
                    Console.WriteLine("OutTradeNo: " + notify.OutTradeNo);

                    return Content("success", "text/plain");
                }
                return NoContent();
            }
            catch
            {
                return NoContent();
            }
        }

    }

    [Route("notify/wechatpay")]
    public class WeChatPayNotifyController : Controller
    {
        private readonly WeChatPayNotifyClient _client = null;
        public WeChatPayNotifyController(WeChatPayNotifyClient client)
        {
            _client = client;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync()
        {
            try
            {
                var notify = await _client.ExecuteAsync<WeChatPayUnifiedOrderNotifyResponse>(Request);
                if (!notify.IsError)
                {
                    if (notify.ResultCode == "SUCCESS")
                    {
                        Console.WriteLine("OutTradeNo: " + notify.OutTradeNo);

                        return Content("<xml><return_code><![CDATA[SUCCESS]]></return_code></xml>", "text/xml");
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

    /// <summary>
    /// 微信支付退款通知 需要在微信支付后台设置通知地址
    /// </summary>
    [Route("notify/wechatpay/refund")]
    public class WeChatPayRefundNotifyController : Controller
    {
        private readonly WeChatPayNotifyClient _client = null;
        public WeChatPayRefundNotifyController(WeChatPayNotifyClient client)
        {
            _client = client;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync()
        {
            try
            {
                var notify = await _client.ExecuteAsync<WeChatPayRefundNotifyResponse>(Request);
                if (!notify.IsError)
                {
                    if (notify.RefundStatus == "SUCCESS")
                    {
                        Console.WriteLine("OutTradeNo: " + notify.OutTradeNo);
                        return Content("<xml><return_code><![CDATA[SUCCESS]]></return_code></xml>", "text/xml");
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

    [Route("notify/qpay")]
    public class QPayNotifyController : Controller
    {
        private readonly QPayNotifyClient _client = null;
        public QPayNotifyController(QPayNotifyClient client)
        {
            _client = client;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync()
        {
            try
            {
                var notify = await _client.ExecuteAsync<QPayUnifiedOrderNotifyResponse>(Request);
                if ("SUCCESS" == notify.TradeState)
                {
                    Console.WriteLine("OutTradeNo: " + notify.OutTradeNo);

                    return Content("<xml><return_code><![CDATA[SUCCESS]]></return_code></xml>", "text/xml");
                }
                return NoContent();
            }
            catch
            {
                return NoContent();
            }
        }
    }

    [Route("notify/jdpay")]
    public class JdPayNotifyController : Controller
    {
        private readonly JdPayNotifyClient _client = null;
        public JdPayNotifyController(JdPayNotifyClient client)
        {
            _client = client;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync()
        {
            try
            {
                var notify = await _client.ExecuteAsync<JdPayAsynNotifyResponse>(Request);
                Console.WriteLine("TradeNum: " + notify.TradeNum + " tradeType :" + notify.TradeType);

                return Content("success", "text/plain");
            }
            catch
            {
                return NoContent();
            }
        }
    }
}
