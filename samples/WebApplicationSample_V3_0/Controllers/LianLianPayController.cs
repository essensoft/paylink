using System.Threading.Tasks;
using Essensoft.AspNetCore.Payment.LianLianPay;
using Essensoft.AspNetCore.Payment.LianLianPay.Notify;
using Essensoft.AspNetCore.Payment.LianLianPay.Request;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WebApplicationSample_V3_0.Models;

namespace WebApplicationSample_V3_0.Controllers
{
    public class LianLianPayController : Controller
    {
        private readonly ILianLianPayClient _client;
        private readonly ILianLianPayNotifyClient _notifyClient;
        private readonly IOptions<LianLianPayOptions> _optionsAccessor;

        public LianLianPayController(ILianLianPayClient client, ILianLianPayNotifyClient notifyClient, IOptions<LianLianPayOptions> optionsAccessor)
        {
            _client = client;
            _notifyClient = notifyClient;
            _optionsAccessor = optionsAccessor;
        }

        /// <summary>
        /// 连连支付指引页
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// WEB快捷支付
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult WebQuickPay()
        {
            return View();
        }

        /// <summary>
        /// WEB快捷支付
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> WebQuickPay(LianLianPayWebQuickPayViewModel viewModel)
        {
            var request = new LianLianPayCreateBillRequest
            {
                UserId = viewModel.UserId,
                NoOrder = viewModel.NoOrder,
                DtOrder = viewModel.DtOrder,
                NameGoods = viewModel.NameGoods,
                MoneyOrder = viewModel.MoneyOrder,
                NotifyUrl = viewModel.NotifyUrl,
                UrlReturn = viewModel.UrlReturn,
                RiskItem = viewModel.RiskItem,
                FlagPayProduct = "0",
                FlagChnl = "2"
            };
            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);
            return Redirect(response.GatewayUrl);
        }

        /// <summary>
        /// H5快捷支付
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult H5QuickPay()
        {
            return View();
        }

        /// <summary>
        /// H5快捷支付
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> H5QuickPay(LianLianPayH5QuickPayViewModel viewModel)
        {
            var request = new LianLianPayCreateBillRequest
            {
                UserId = viewModel.UserId,
                NoOrder = viewModel.NoOrder,
                DtOrder = viewModel.DtOrder,
                NameGoods = viewModel.NameGoods,
                MoneyOrder = viewModel.MoneyOrder,
                NotifyUrl = viewModel.NotifyUrl,
                UrlReturn = viewModel.UrlReturn,
                RiskItem = viewModel.RiskItem,
                FlagPayProduct = "0",
                FlagChnl = "3"
            };
            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);
            return Redirect(response.GatewayUrl);
        }

        /// <summary>
        /// 订单查询
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult OrderQuery()
        {
            return View();
        }

        /// <summary>
        /// 订单查询
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> OrderQuery(LianLianPayOrderQueryViewModel viewModel)
        {
            var request = new LianLianPayOrderQueryRequest
            {
                NoOrder = viewModel.NoOrder,
                DtOrder = viewModel.DtOrder,
                OidPayBill = viewModel.OidPayBill
            };
            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);
            ViewData["response"] = response.Body;
            return View();
        }

        /// <summary>
        /// 退款
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Refund()
        {
            return View();
        }

        /// <summary>
        /// 退款
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Refund(LianLianPayRefundViewModel viewModel)
        {
            var request = new LianLianPayRefundRequest
            {
                NoRefund = viewModel.NoRefund,
                DtRefund = viewModel.DtRefund,
                MoneyRefund = viewModel.MoneyRefund,
                NoOrder = viewModel.NoOrder,
                DtOrder = viewModel.DtOrder,
                OidPaybill = viewModel.OidPayBill,
                NotifyUrl = viewModel.NotifyUrl
            };
            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);
            ViewData["response"] = response.Body;
            return View();
        }

        /// <summary>
        /// 退款查询
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult RefundQuery()
        {
            return View();
        }

        /// <summary>
        /// 退款查询
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> RefundQuery(LianLianPayRefundQueryViewModel viewModel)
        {
            var request = new LianLianPayRefundQueryRequest
            {
                NoRefund = viewModel.NoRefund,
                DtRefund = viewModel.DtRefund,
                OidRefundNo = viewModel.OidRefundNo
            };
            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);
            ViewData["response"] = response.Body;
            return View();
        }

        /// <summary>
        /// 快捷支付 - 同步跳转
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> QuickPayReturn()
        {
            try
            {
                var notify = await _notifyClient.ExecuteAsync<LianLianPayReceiveMoneyReturnResponse>(Request, _optionsAccessor.Value);
                ViewData["response"] = "支付成功";
                return View();
            }
            catch
            {
                ViewData["response"] = "出现错误";
                return View();
            }
        }
    }
}
