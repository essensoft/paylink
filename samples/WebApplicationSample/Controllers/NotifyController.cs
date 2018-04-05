using Essensoft.AspNetCore.Payment.Alipay;
using Essensoft.AspNetCore.Payment.Alipay.Notify;
using Essensoft.AspNetCore.Payment.JdPay;
using Essensoft.AspNetCore.Payment.JdPay.Notify;
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
        public async Task<IActionResult> PagePayAsync()
        {
            try
            {
                var notify = await _client.ExecuteAsync<AlipayTradePagePayNotifyResponse>(Request);
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
        public async Task<IActionResult> WapPayAsync()
        {
            try
            {
                var notify = await _client.ExecuteAsync<AlipayTradeWapPayNotifyResponse>(Request);
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
        public async Task<IActionResult> PrecreateAsync()
        {
            try
            {
                var notify = await _client.ExecuteAsync<AlipayTradePrecreateNotifyResponse>(Request);
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
        public async Task<IActionResult> PayAsync()
        {
            try
            {
                var notify = await _client.ExecuteAsync<AlipayTradePayNotifyResponse>(Request);
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
                if (notify.ReturnCode == "SUCCESS")
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
    /// 微信支付退款通知
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
                if (notify.ReturnCode == "SUCCESS")
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
                    return Content("<xml><return_code>SUCCESS</return_code></xml>", "text/xml");
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
        public async Task<IActionResult> Async()
        {
            try
            {
                var notify = await _client.ExecuteAsync<JdPayAsyncNotifyResponse>(Request);
                Console.WriteLine("TradeNum: " + notify.TradeNum + " tradeType :" + notify.TradeType);

                return Content("success", "text/plain");
            }
            catch
            {
                return NoContent();
            }
        }
    }

    [Route("notify/unionpay")]
    public class UnionPayNotifyController : Controller
    {
        private readonly UnionPayNotifyClient _client = null;
        public UnionPayNotifyController(UnionPayNotifyClient client)
        {
            _client = client;
        }

        /// <summary>
        /// 二维码支付 - 二维码消费（被扫）通知
        /// </summary>
        /// <returns></returns>
        [Route("appconsume")]
        [HttpPost]
        public async Task<IActionResult> AppConsume()
        {
            try
            {
                var notify = await _client.ExecuteAsync<UnionPayForm05_6_2_AppConsumeNotifyResponse>(Request);
                Console.WriteLine("OrderId: " + notify.OrderId + " respCode :" + notify.RespCode);
                return Content("ok", "text/plain");
            }
            catch
            {
                return NoContent();
            }
        }

        /// <summary>
        /// 二维码支付 - 申请二维码（主扫）通知
        /// </summary>
        /// <returns></returns>
        [Route("applyqrcode")]
        [HttpPost]
        public async Task<IActionResult> ApplyQrCode()
        {
            try
            {
                var notify = await _client.ExecuteAsync<UnionPayForm05_6_1_ApplyQrCodeNotifyResponse>(Request);
                Console.WriteLine("OrderId: " + notify.OrderId + " respCode :" + notify.RespCode);
                return Content("ok", "text/plain");
            }
            catch
            {
                return NoContent();
            }
        }

        /// <summary>
        /// 二维码支付 - 消费撤销通知
        /// </summary>
        /// <returns></returns>
        [Route("purchaseundo")]
        [HttpPost]
        public async Task<IActionResult> PurchaseUndo()
        {
            try
            {
                var notify = await _client.ExecuteAsync<UnionPayUpacpPurchaseUndoNotifyResponse>(Request);
                Console.WriteLine("OrderId: " + notify.OrderId + " respCode :" + notify.RespCode);
                return Content("ok", "text/plain");
            }
            catch
            {
                return NoContent();
            }
        }

        /// <summary>
        /// 二维码支付 - 退货通知
        /// </summary>
        /// <returns></returns>
        [Route("refund")]
        [HttpPost]
        public async Task<IActionResult> Refund()
        {
            try
            {
                var notify = await _client.ExecuteAsync<UnionPayUpacpRefundNotifyResponse>(Request);
                Console.WriteLine("OrderId: " + notify.OrderId + " respCode :" + notify.RespCode);
                return Content("ok", "text/plain");
            }
            catch
            {
                return NoContent();
            }
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
                return Content("ok", "text/plain");
            }
            catch
            {
                return NoContent();
            }
        }

        /// <summary>
        /// 网关支付 - 消费撤销通知
        /// </summary>
        /// <returns></returns>
        [Route("consumeundo63")]
        [HttpPost]
        public async Task<IActionResult> ConsumeUndo63()
        {
            try
            {
                var notify = await _client.ExecuteAsync<UnionPayForm_6_3_ConsumeUndoNotifyResponse>(Request);
                Console.WriteLine("OrderId: " + notify.OrderId + " respCode :" + notify.RespCode);
                return Content("ok", "text/plain");
            }
            catch
            {
                return NoContent();
            }
        }

        /// <summary>
        /// 网关支付 - 退货通知
        /// </summary>
        /// <returns></returns>
        [Route("refund64")]
        [HttpPost]
        public async Task<IActionResult> Refund64()
        {
            try
            {
                var notify = await _client.ExecuteAsync<UnionPayForm_6_4_RefundNotifyResponse>(Request);
                Console.WriteLine("OrderId: " + notify.OrderId + " respCode :" + notify.RespCode);
                return Content("ok", "text/plain");
            }
            catch
            {
                return NoContent();
            }
        }

        /// <summary>
        /// 网关支付 - 预授权通知
        /// </summary>
        /// <returns></returns>
        [Route("authdealfront671")]
        [HttpPost]
        public async Task<IActionResult> AuthDealFront671()
        {
            try
            {
                var notify = await _client.ExecuteAsync<UnionPayForm_6_7_1_AuthDeal_FrontNotifyResponse>(Request);
                Console.WriteLine("OrderId: " + notify.OrderId + " respCode :" + notify.RespCode);
                return Content("ok", "text/plain");
            }
            catch
            {
                return NoContent();
            }
        }

        /// <summary>
        /// 网关支付 - 预授权撤销通知
        /// </summary>
        /// <returns></returns>
        [Route("authundo672")]
        [HttpPost]
        public async Task<IActionResult> AuthUndo672()
        {
            try
            {
                var notify = await _client.ExecuteAsync<UnionPayForm_6_7_2_AuthUndoNotifyResponse>(Request);
                Console.WriteLine("OrderId: " + notify.OrderId + " respCode :" + notify.RespCode);
                return Content("ok", "text/plain");
            }
            catch
            {
                return NoContent();
            }
        }

        /// <summary>
        /// 网关支付 - 预授权完成通知
        /// </summary>
        /// <returns></returns>
        [Route("authfinish673")]
        [HttpPost]
        public async Task<IActionResult> AuthFinish673()
        {
            try
            {
                var notify = await _client.ExecuteAsync<UnionPayForm_6_7_3_AuthFinishNotifyResponse>(Request);
                Console.WriteLine("OrderId: " + notify.OrderId + " respCode :" + notify.RespCode);
                return Content("ok", "text/plain");
            }
            catch
            {
                return NoContent();
            }
        }

        /// <summary>
        /// 网关支付 - 预授权完成撤销通知
        /// </summary>
        /// <returns></returns>
        [Route("authfinishundo674")]
        [HttpPost]
        public async Task<IActionResult> AuthFinishUndo674()
        {
            try
            {
                var notify = await _client.ExecuteAsync<UnionPayForm_6_7_4_AuthFinishUndoNotifyResponse>(Request);
                Console.WriteLine("OrderId: " + notify.OrderId + " respCode :" + notify.RespCode);
                return Content("ok", "text/plain");
            }
            catch
            {
                return NoContent();
            }
        }
    }

    [Route("notify/lianlianpay")]
    public class LianLianPayNotifyController : Controller
    {
        private readonly LianLianPayNotifyClient _client = null;
        public LianLianPayNotifyController(LianLianPayNotifyClient client)
        {
            _client = client;
        }

        [Route("quickpay")]
        [HttpPost]
        public async Task<IActionResult> QuickPay()
        {
            try
            {
                var notify = await _client.ExecuteAsync<LianLianPayQuickPayNotifyResponse>(Request);
                Console.WriteLine("NoOrder: " + notify.NoOrder);
                return Content("{\"ret_code\":\"0000\",\"ret_msg\":\"交易成功\"}", "application/json");
            }
            catch
            {
                return NoContent();
            }
        }

        [Route("bankpay")]
        [HttpPost]
        public async Task<IActionResult> BankPay()
        {
            try
            {
                var notify = await _client.ExecuteAsync<LianLianPayBankPayNotifyResponse>(Request);
                Console.WriteLine("NoOrder: " + notify.NoOrder);
                return Content("{\"ret_code\":\"0000\",\"ret_msg\":\"交易成功\"}", "application/json");
            }
            catch
            {
                return NoContent();
            }
        }

        [Route("authpay")]
        [HttpPost]
        public async Task<IActionResult> AuthPay()
        {
            try
            {
                var notify = await _client.ExecuteAsync<LianLianPayAuthPayNotifyResponse>(Request);
                Console.WriteLine("NoOrder: " + notify.NoOrder);
                return Content("{\"ret_code\":\"0000\",\"ret_msg\":\"交易成功\"}", "application/json");
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
                return Content("{\"ret_code\":\"0000\",\"ret_msg\":\"交易成功\"}", "application/json");
            }
            catch
            {
                return NoContent();
            }
        }
    }

}
