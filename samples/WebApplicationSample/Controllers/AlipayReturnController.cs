using System.Threading.Tasks;
using Essensoft.Paylink.Alipay;
using Essensoft.Paylink.Alipay.Notify;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace WebApplicationSample.Controllers
{
    [Route("alipay/return")]
    public class AlipayReturnController : Controller
    {
        private readonly ILogger<AlipayReturnController> _logger;
        private readonly IAlipayNotifyClient _client;
        private readonly IOptions<AlipayOptions> _optionsAccessor;

        public AlipayReturnController(ILogger<AlipayReturnController> logger, IAlipayNotifyClient client, IOptions<AlipayOptions> optionsAccessor)
        {
            _logger = logger;
            _client = client;
            _optionsAccessor = optionsAccessor;
        }

        /// <summary>
        /// 电脑网站支付 - 同步跳转
        /// </summary>
        [Route("pagepay")]
        [HttpGet]
        public async Task<IActionResult> PagePay()
        {
            try
            {
                var notify = await _client.ExecuteAsync<AlipayTradePagePayReturn>(Request, _optionsAccessor.Value);
                ViewData["response"] = "支付成功";
                return View();
            }
            catch (AlipayException ex)
            {
                _logger.LogWarning("出现异常: " + ex.Message);
                ViewData["response"] = "出现错误";
                return View();
            }
        }

        /// <summary>
        /// 手机网站支付 - 同步跳转
        /// </summary>
        [HttpGet]
        [Route("wappay")]
        public async Task<IActionResult> WapPay()
        {
            try
            {
                var notify = await _client.ExecuteAsync<AlipayTradeWapPayReturn>(Request, _optionsAccessor.Value);
                ViewData["response"] = "支付成功";
                return View();
            }
            catch (AlipayException ex)
            {
                _logger.LogWarning("出现异常: " + ex.Message);
                ViewData["response"] = "出现错误";
                return View();
            }
        }
    }
}
