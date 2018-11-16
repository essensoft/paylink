using Essensoft.AspNetCore.Payment.LianLianPay;
using Essensoft.AspNetCore.Payment.LianLianPay.Notify;
using Essensoft.AspNetCore.Payment.LianLianPay.Request;
using Microsoft.AspNetCore.Mvc;
using WebApplicationSample.Models;
using System.Threading.Tasks;

namespace WebApplicationSample.Controllers
{
    public class LianLianPayController : Controller
    {
        private readonly LianLianPayClient _client = null;
        private readonly LianLianPayNotifyClient _notifyClient = null;

        public LianLianPayController(LianLianPayClient client, LianLianPayNotifyClient notifyClient)
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
            var request = new LianLianPayWebQuickPayRequest()
            {
                NoOrder = viewModel.NoOrder,
                DtOrder = viewModel.DtOrder,
                MoneyOrder = viewModel.MoneyOrder,
                NameGoods = viewModel.NameGoods,
                UserId = viewModel.UserId,
                NotifyUrl = viewModel.NotifyUrl,
                UrlReturn = viewModel.UrlReturn,
                BankCode = viewModel.BankCode,
                PayType = viewModel.PayType,
                NoAgree = viewModel.NoAgree,
                RiskItem = viewModel.RiskItem,
                IdType = viewModel.IdType,
                IdNo = viewModel.IdNo,
                AcctName = viewModel.AcctName,
                CardNo = viewModel.CardNo,
            };
            var response = await _client.PageExecuteAsync(request);
            return Content(response.Body, "text/html;charset=utf-8");
        }

        [HttpGet]
        public IActionResult WapQuickPay()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> WapQuickPay(LianLianPayWapQuickPayViewModel viewModel)
        {
            var request = new LianLianPayWapQuickPayRequest()
            {
                NoOrder = viewModel.NoOrder,
                DtOrder = viewModel.DtOrder,
                MoneyOrder = viewModel.MoneyOrder,
                NameGoods = viewModel.NameGoods,
                UserId = viewModel.UserId,
                AppRequest = viewModel.AppRequest,
                NotifyUrl = viewModel.NotifyUrl,
                UrlReturn = viewModel.UrlReturn,
                NoAgree = viewModel.NoAgree,
                RiskItem = viewModel.RiskItem,
                IdType = viewModel.IdType,
                IdNo = viewModel.IdNo,
                AcctName = viewModel.AcctName,
                CardNo = viewModel.CardNo,
            };
            var response = await _client.PageReqDataExecuteAsync(request);
            return Content(response.Body, "text/html;charset=utf-8");
        }

        [HttpGet]
        public IActionResult OrderQuery()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> OrderQuery(LianLianPayOrderQueryViewModel viewModel)
        {
            var request = new LianLianPayOrderQueryRequest()
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
            var request = new LianLianPayRefundRequest()
            {
                NoRefund = viewModel.NoRefund,
                DtRefund = viewModel.DtRefund,
                MoneyRefund = viewModel.MoneyRefund,
                NoOrder = viewModel.NoOrder,
                DtOrder = viewModel.DtOrder,
                OidPaybill = viewModel.OidPayBill,
                NotifyUrl = viewModel.NotifyUrl,
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
            var request = new LianLianPayRefundQueryRequest()
            {
                NoRefund = viewModel.NoRefund,
                DtRefund = viewModel.DtRefund,
                OidRefundNo = viewModel.OidRefundNo,
            };
            var response = await _client.ExecuteAsync(request);
            ViewData["response"] = response.Body;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> WebQuickPayReturn()
        {
            try
            {
                var notify = await _notifyClient.ExecuteAsync<LianLianPayWebQuickPayReturnResponse>(Request);
                ViewData["response"] = "支付成功";
                return View();
            }
            catch
            {
                ViewData["response"] = "出现错误";
                return View();
            }
        }

        [HttpPost]
        public async Task<IActionResult> WapQuickPayReturn()
        {
            try
            {
                var notify = await _notifyClient.ExecuteAsync<LianLianPayWapQuickPayReturnResponse>(Request);
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
