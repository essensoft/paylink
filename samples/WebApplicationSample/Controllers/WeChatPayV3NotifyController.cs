using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Essensoft.AspNetCore.Payment.WeChatPay;
using Essensoft.AspNetCore.Payment.WeChatPay.Notify;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace WebApplicationSample.Controllers
{
    [Route("wechatpay/v3/notify")]
    public class WeChatPayV3NotifyController : Controller
    {
        private readonly IWeChatPayV3NotifyClient _client;
        private readonly IOptions<List<WeChatPayOptions>> _optionsAccessor;

        public WeChatPayV3NotifyController(IWeChatPayV3NotifyClient client, IOptions<List<WeChatPayOptions>> optionsAccessor)
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
                var notify = await _client.ExecuteAsync<WeChatPayTransactionsNotify>(Request, _optionsAccessor.Value[0]);
                if (notify.TradeState == WeChatPayTradeState.Success)
                {
                    Console.WriteLine("OutTradeNo: " + notify.OutTradeNo);
                    return WeChatPayV3NotifyResult.Success;
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
