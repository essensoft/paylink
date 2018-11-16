using Essensoft.AspNetCore.Payment.QPay;
using Essensoft.AspNetCore.Payment.QPay.Request;
using Microsoft.AspNetCore.Mvc;
using WebApplicationSample.Models;
using System.Threading.Tasks;

namespace WebApplicationSample.Controllers
{
    public class QPayController : Controller
    {
        private readonly QPayClient _client = null;
        public QPayController(QPayClient client)
        {
            _client = client;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MicroPay()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> MicroPay(QPayMicroPayViewModel viewModel)
        {
            var request = new QPayMicroPayRequest()
            {
                OutTradeNo = viewModel.OutTradeNo,
                Body = viewModel.Body,
                FeeType = viewModel.FeeType,
                TotalFee = viewModel.TotalFee,
                SpbillCreateIp = viewModel.SpbillCreateIp,
                DeviceInfo = viewModel.DeviceInfo,
                AuthCode = viewModel.AuthCode,
                TradeType = viewModel.TradeType,
                NotifyUrl = viewModel.NotifyUrl,
            };
            var response = await _client.ExecuteAsync(request);
            ViewData["response"] = response.Body;
            return View();
        }

        [HttpGet]
        public IActionResult QRPay()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> QRPay(QPayUnifiedOrderViewModel viewModel)
        {
            var request = new QPayUnifiedOrderRequest()
            {
                OutTradeNo = viewModel.OutTradeNo,
                Body = viewModel.Body,
                FeeType = viewModel.FeeType,
                TotalFee = viewModel.TotalFee,
                SpbillCreateIp = viewModel.SpbillCreateIp,
                TradeType = viewModel.TradeType,
                NotifyUrl = viewModel.NotifyUrl,
            };
            var response = await _client.ExecuteAsync(request);
            ViewData["qrcode"] = response.CodeUrl;
            ViewData["response"] = response.Body;
            return View();
        }

        [HttpGet]
        public IActionResult PubPay()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> PubPay(QPayUnifiedOrderViewModel viewModel)
        {
            var request = new QPayUnifiedOrderRequest()
            {
                OutTradeNo = viewModel.OutTradeNo,
                Body = viewModel.Body,
                FeeType = viewModel.FeeType,
                TotalFee = viewModel.TotalFee,
                SpbillCreateIp = viewModel.SpbillCreateIp,
                TradeType = viewModel.TradeType,
                NotifyUrl = viewModel.NotifyUrl,
            };
            var response = await _client.ExecuteAsync(request);
            ViewData["response"] = response.Body;
            return View();
        }

        [HttpGet]
        public IActionResult AppPay()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AppPay(QPayUnifiedOrderViewModel viewModel)
        {
            var request = new QPayUnifiedOrderRequest()
            {
                OutTradeNo = viewModel.OutTradeNo,
                Body = viewModel.Body,
                FeeType = viewModel.FeeType,
                TotalFee = viewModel.TotalFee,
                SpbillCreateIp = viewModel.SpbillCreateIp,
                TradeType = viewModel.TradeType,
                NotifyUrl = viewModel.NotifyUrl,
            };
            var response = await _client.ExecuteAsync(request);
            ViewData["response"] = response.Body;
            return View();
        }

        [HttpGet]
        public IActionResult OrderQuery()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> OrderQuery(QPayOrderQueryViewModel viewModel)
        {
            var request = new QPayOrderQueryRequest()
            {
                TransactionId = viewModel.TransactionId,
                OutTradeNo = viewModel.OutTradeNo,
            };
            var response = await _client.ExecuteAsync(request);
            ViewData["response"] = response.Body;
            return View();
        }

        [HttpGet]
        public IActionResult Reverse()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Reverse(QPayReverseViewModel viewModel)
        {
            var request = new QPayReverseRequest()
            {
                OutTradeNo = viewModel.OutTradeNo,
            };
            var response = await _client.ExecuteAsync(request);
            ViewData["response"] = response.Body;
            return View();
        }


        [HttpGet]
        public IActionResult CloseOrder()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CloseOrder(QPayCloseOrderViewModel viewModel)
        {
            var request = new QPayCloseOrderRequest()
            {
                OutTradeNo = viewModel.OutTradeNo,
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
        public async Task<IActionResult> Refund(QPayRefundViewModel viewModel)
        {
            var request = new QPayRefundRequest()
            {
                OutRefundNo = viewModel.OutRefundNo,
                TransactionId = viewModel.TransactionId,
                OutTradeNo = viewModel.OutTradeNo,
                RefundFee = viewModel.RefundFee,
                OpUserId = viewModel.OpUserId,
                OpUserPasswd = viewModel.OpUserPasswd,
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
        public async Task<IActionResult> RefundQuery(QPayRefundQueryViewModel viewModel)
        {
            var request = new QPayRefundQueryRequest()
            {
                RefundId = viewModel.RefundId,
                OutRefundNo = viewModel.OutRefundNo,
                TransactionId = viewModel.TransactionId,
                OutTradeNo = viewModel.OutTradeNo,
            };
            var response = await _client.ExecuteAsync(request);
            ViewData["response"] = response.Body;
            return View();
        }

        [HttpGet]
        public IActionResult StatementDown()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> StatementDown(QPayStatementDownViewModel viewModel)
        {
            var request = new QPayStatementDownRequest()
            {
                BillDate = viewModel.BillDate,
                BillType = viewModel.BillType,
                TarType = viewModel.TarType,
            };
            var response = await _client.ExecuteAsync(request);
            ViewData["response"] = response.Body;
            return View();
        }
    }
}
