using System.Text;
using System.Threading.Tasks;
using Essensoft.AspNetCore.Payment.JDPay;
using Essensoft.AspNetCore.Payment.JDPay.Notify;
using Essensoft.AspNetCore.Payment.JDPay.Request;
using Microsoft.AspNetCore.Mvc;
using WebApplicationSample.Models;

namespace WebApplicationSample.Controllers
{
    public class JDPayController : Controller
    {
        private readonly IJDPayClient _client;
        private readonly IJDPayNotifyClient _notifyClient;

        public JDPayController(IJDPayClient client, IJDPayNotifyClient notifyClient)
        {
            _client = client;
            _notifyClient = notifyClient;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SaveOrderPC()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SaveOrderPC(JDPaySaveOrderViewModel viewModel)
        {
            var request = new JDPaySaveOrderPCRequest
            {
                TradeNum = viewModel.TradeNum,
                TradeName = viewModel.TradeName,
                TradeTime = viewModel.TradeTime,
                Amount = viewModel.Amount,
                OrderType = viewModel.OrderType,
                Currency = viewModel.Currency,
                CallbackUrl = viewModel.CallbackUrl,
                NotifyUrl = viewModel.NotifyUrl,
                UserId = viewModel.UserId
            };

            var response = await _client.PageExecuteAsync(request);
            return Content(response.Body, "text/html", Encoding.UTF8);
        }

        [HttpGet]
        public IActionResult SaveOrderH5()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SaveOrderH5(JDPaySaveOrderViewModel viewModel)
        {
            var request = new JDPaySaveOrderH5Request
            {
                TradeNum = viewModel.TradeNum,
                TradeName = viewModel.TradeName,
                TradeTime = viewModel.TradeTime,
                Amount = viewModel.Amount,
                OrderType = viewModel.OrderType,
                Currency = viewModel.Currency,
                CallbackUrl = viewModel.CallbackUrl,
                NotifyUrl = viewModel.NotifyUrl,
                UserId = viewModel.UserId
            };

            var response = await _client.PageExecuteAsync(request);
            return Content(response.Body, "text/html", Encoding.UTF8);
        }

        [HttpGet]
        public IActionResult QRPay()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> QRPay(JDPayUnifiedOrderViewModel viewModel)
        {
            var request = new JDPayUnifiedOrderRequest
            {
                TradeNum = viewModel.TradeNum,
                TradeName = viewModel.TradeName,
                TradeTime = viewModel.TradeTime,
                Amount = viewModel.Amount,
                OrderType = viewModel.OrderType,
                Currency = viewModel.Currency,
                NotifyUrl = viewModel.NotifyUrl,
                TradeType = viewModel.TradeType
            };

            var response = await _client.ExecuteAsync(request);
            ViewData["qrcode"] = response.QrCode;
            ViewData["response"] = response.Body;
            return View();
        }

        [HttpGet]
        public IActionResult Query()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Query(JDPayQueryViewModel viewModel)
        {
            var request = new JDPayQueryRequest
            {
                TradeNum = viewModel.TradeNum,
                OTradeNum = viewModel.OTradeNum,
                TradeType = viewModel.TradeType
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
        public async Task<IActionResult> Refund(JDPayRefundViewModel viewModel)
        {
            var request = new JDPayRefundRequest
            {
                TradeNum = viewModel.TradeNum,
                OTradeNum = viewModel.OTradeNum,
                Amount = viewModel.Amount,
                Currency = viewModel.Currency,
                NotifyUrl = viewModel.NotifyUrl
            };

            var response = await _client.ExecuteAsync(request);
            ViewData["response"] = response.Body;
            return View();
        }

        [HttpGet]
        public IActionResult QueryRefund()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> QueryRefund(JDPayQueryRefundViewModel viewModel)
        {
            var request = new JDPayQueryRefundRequest
            {
                TradeNum = viewModel.TradeNum,
                OTradeNum = viewModel.OTradeNum,
                TradeType = viewModel.TradeType
            };

            var response = await _client.ExecuteAsync(request);
            ViewData["response"] = response.Body;
            return View();
        }

        [HttpGet]
        public IActionResult DefrayPay()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> DefrayPay(JDPayDefrayPayViewModel viewModel)
        {
            var request = new JDPayDefrayPayRequest
            {
                RequestDatetime = viewModel.RequestDatetime,
                OutTradeNo = viewModel.OutTradeNo,
                BizTradeNo = viewModel.BizTradeNo,
                OutTradeDate = viewModel.OutTradeDate,
                TradeAmount = viewModel.TradeAmount,
                TradeCurrency = viewModel.TradeCurrency,
                SellerInfo = viewModel.SellerInfo,
                TradeSubject = viewModel.TradeSubject,
                CategoryCode = viewModel.CategoryCode,
                PayTool = viewModel.PayTool,
                TradeSource = viewModel.TradeSource,
                PayeeBankCode = viewModel.PayeeBankCode,
                PayeeBankAssociatedCode = viewModel.PayeeBankAssociatedCode,
                PayeeBankFullname = viewModel.PayeeBankFullname,
                PayeeBankCountryCode = viewModel.PayeeBankCountryCode,
                PayeeBankProvinceCode = viewModel.PayeeBankProvinceCode,
                PayeeBankCityCode = viewModel.PayeeBankCityCode,
                PayeeCardType = viewModel.PayeeCardType,
                PayeeAccountType = viewModel.PayeeAccountType,
                PayeeAccountNo = viewModel.PayeeAccountNo,
                PayeeAccountName = viewModel.PayeeAccountName,
                PayeeIdType = viewModel.PayeeIdType,
                PayeeIdNo = viewModel.PayeeIdNo,
                PayeeMobile = viewModel.PayeeMobile,
                NotifyUrl = viewModel.NotifyUrl,
                ReturnParams = viewModel.ReturnParams,
                ExtendParams = viewModel.ExtendParams,
                BankCardInfoType = viewModel.BankCardInfoType,
                BankCardId = viewModel.BankCardId
            };

            var response = await _client.ExecuteAsync(request);
            ViewData["response"] = response.Body;
            return View();
        }

        [HttpGet]
        public IActionResult TradeQuery()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> TradeQuery(JDPayTradeQueryViewModel viewModel)
        {
            var request = new JDPayTradeQueryRequest
            {
                RequestDatetime = viewModel.RequestDatetime,
                OutTradeNo = viewModel.OutTradeNo,
                TradeNo = viewModel.TradeNo,
                TradeType = viewModel.TradeType
            };

            var response = await _client.ExecuteAsync(request);
            ViewData["response"] = response.Body;
            return View();
        }

        [HttpGet]  // h5 get
        [HttpPost] // pc post
        public async Task<IActionResult> Return()
        {
            try
            {
                var notify = await _notifyClient.ExecuteAsync<JDPaySyncReturnResponse>(Request);
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
