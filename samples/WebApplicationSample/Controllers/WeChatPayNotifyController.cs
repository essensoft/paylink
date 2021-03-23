using System.Threading.Tasks;
using Essensoft.Paylink.WeChatPay;
using Essensoft.Paylink.WeChatPay.V2;
using Essensoft.Paylink.WeChatPay.V2.Notify;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace WebApplicationSample.Controllers
{
    [Route("wechatpay/notify")]
    public class WeChatPayNotifyController : Controller
    {
        private readonly ILogger<WeChatPayNotifyController> _logger;
        private readonly IWeChatPayNotifyClient _client;
        private readonly IOptions<WeChatPayOptions> _optionsAccessor;

        public WeChatPayNotifyController(ILogger<WeChatPayNotifyController> logger, IWeChatPayNotifyClient client, IOptions<WeChatPayOptions> optionsAccessor)
        {
            _logger = logger;
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
                        _logger.LogInformation("统一下单支付结果通知 => OutTradeNo: " + notify.OutTradeNo);
                        return WeChatPayNotifyResult.Success;
                    }
                }

                return WeChatPayNotifyResult.Failure;
            }
            catch (WeChatPayException ex)
            {
                _logger.LogWarning("出现异常: " + ex.Message);
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
                var notify = await _client.ExecuteAsync<WeChatPayRefundNotify>(Request, _optionsAccessor.Value);
                if (notify.ReturnCode == WeChatPayCode.Success)
                {
                    if (notify.RefundStatus == WeChatPayRefundStatus.Success)
                    {
                        _logger.LogInformation("退款结果通知 => OutTradeNo: " + notify.OutTradeNo);
                        return WeChatPayNotifyResult.Success;
                    }
                }

                return WeChatPayNotifyResult.Failure;
            }
            catch (WeChatPayException ex)
            {
                _logger.LogWarning("出现异常: " + ex.Message);
                return WeChatPayNotifyResult.Failure;
            }
        }
    }

}
