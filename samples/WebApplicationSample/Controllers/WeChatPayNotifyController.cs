using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Essensoft.AspNetCore.Payment.WeChatPay;
using Essensoft.AspNetCore.Payment.WeChatPay.Notify;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace WebApplicationSample.Controllers
{
    [Route("wechatpay/notify")]
    public class WeChatPayNotifyController : Controller
    {
        private readonly IWeChatPayNotifyClient _client;
        private readonly IOptions<List<WeChatPayOptions>> _optionsAccessor;

        public WeChatPayNotifyController(IWeChatPayNotifyClient client, IOptions<List<WeChatPayOptions>> optionsAccessor)
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
                var notify = await _client.ExecuteAsync<WeChatPayUnifiedOrderNotify>(Request, _optionsAccessor.Value[0]);
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
                var notify = await _client.ExecuteAsync<WeChatPayRefundNotify>(Request, _optionsAccessor.Value[0]);
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

}
