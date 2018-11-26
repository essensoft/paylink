using System.Threading.Tasks;
using Essensoft.AspNetCore.Payment.LianLianPay;
using Essensoft.AspNetCore.Payment.LianLianPay.Notify;
using Essensoft.AspNetCore.Payment.LianLianPay.Request;
using Microsoft.AspNetCore.Mvc;
using WebApplicationSample.Models;

namespace WebApplicationSample.Controllers
{
    public class LianLianPayController : Controller
    {
        private readonly ILianLianPayClient _client;
        private readonly ILianLianPayNotifyClient _notifyClient;

        public LianLianPayController(ILianLianPayClient client, ILianLianPayNotifyClient notifyClient)
        {
            _client = client;
            _notifyClient = notifyClient;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult WebQuickPay()
        {
            return View();
        }

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
            var response = await _client.ExecuteAsync(request);
            return Redirect(response.GatewayUrl);
        }

        [HttpGet]
        public IActionResult H5QuickPay()
        {
            return View();
        }

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
            var response = await _client.ExecuteAsync(request);
            return Redirect(response.GatewayUrl);
        }

        [HttpGet]
        public IActionResult OrderQuery()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> OrderQuery(LianLianPayOrderQueryViewModel viewModel)
        {
            var request = new LianLianPayOrderQueryRequest
            {
                NoOrder = viewModel.NoOrder,
                DtOrder = viewModel.DtOrder,
                OidPayBill = viewModel.OidPayBill
            };
            var response = await _client.ExecuteAsync(request);
            ViewData["response"] = response.Body;
            return View();
        }

        [HttpGet]
        public IActionResult Refund()
        {
            return View();
        }

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
            var response = await _client.ExecuteAsync(request);
            ViewData["response"] = response.Body;
            return View();
        }

        [HttpGet]
        public IActionResult RefundQuery()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RefundQuery(LianLianPayRefundQueryViewModel viewModel)
        {
            var request = new LianLianPayRefundQueryRequest
            {
                NoRefund = viewModel.NoRefund,
                DtRefund = viewModel.DtRefund,
                OidRefundNo = viewModel.OidRefundNo
            };
            var response = await _client.ExecuteAsync(request);
            ViewData["response"] = response.Body;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> QuickPayReturn()
        {
            try
            {
                var notify = await _notifyClient.ExecuteAsync<LianLianPayReceiveMoneyReturnResponse>(Request);
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
