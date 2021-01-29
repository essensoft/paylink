using System;
using System.Threading.Tasks;
using Essensoft.AspNetCore.Payment.WeChatPay;
using Essensoft.AspNetCore.Payment.WeChatPay.V3;
using Essensoft.AspNetCore.Payment.WeChatPay.V3.Notify;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace WebApplicationSample.Controllers
{
    [Route("wechatpay/v3/notify")]
    public class WeChatPayV3NotifyController : Controller
    {
        private readonly IWeChatPayNotifyClient _client;
        private readonly IOptions<WeChatPayOptions> _optionsAccessor;

        public WeChatPayV3NotifyController(IWeChatPayNotifyClient client, IOptions<WeChatPayOptions> optionsAccessor)
        {
            _client = client;
            _optionsAccessor = optionsAccessor;
        }

        /// <summary>
        /// 支付结果通知
        /// </summary>
        [Route("transactions")]
        [HttpPost]
        public async Task<IActionResult> Transactions()
        {
            try
            {
                var notify = await _client.ExecuteAsync<WeChatPayTransactionsNotify>(Request, _optionsAccessor.Value);
                if (notify.TradeState == WeChatPayTradeState.Success)
                {
                    Console.WriteLine("OutTradeNo: " + notify.OutTradeNo);
                    return WeChatPayNotifyResult.Success;
                }

                return WeChatPayNotifyResult.Failure;
            }
            catch (WeChatPayException ex)
            {
                Console.WriteLine("出现异常: " + ex.Message);
                return WeChatPayNotifyResult.Failure;
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
                var notify = await _client.ExecuteAsync<WeChatPayRefundDomesticRefundsNotify>(Request, _optionsAccessor.Value);
                if (notify.RefundStatus == WeChatPayRefundStatus.Success)
                {
                    Console.WriteLine("OutTradeNo: " + notify.OutTradeNo);
                    return WeChatPayNotifyResult.Success;
                }

                return WeChatPayNotifyResult.Failure;
            }
            catch (WeChatPayException ex)
            {
                Console.WriteLine("出现异常: " + ex.Message);
                return WeChatPayNotifyResult.Failure;
            }
        }
    }
}
