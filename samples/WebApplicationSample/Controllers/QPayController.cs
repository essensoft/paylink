using System.Security.Cryptography;
using System.Threading.Tasks;
using Essensoft.AspNetCore.Payment.QPay;
using Essensoft.AspNetCore.Payment.QPay.Request;
using Microsoft.AspNetCore.Mvc;
using WebApplicationSample.Models;

namespace WebApplicationSample.Controllers
{
    public class QPayController : Controller
    {
        private readonly IQPayClient _client;

        public QPayController(IQPayClient client)
        {
            _client = client;
        }

        /// <summary>
        /// QQ钱包指引页
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 付款码支付
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult MicroPay()
        {
            return View();
        }

        /// <summary>
        /// 付款码支付
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> MicroPay(QPayMicroPayViewModel viewModel)
        {
            var request = new QPayMicroPayRequest
            {
                OutTradeNo = viewModel.OutTradeNo,
                Body = viewModel.Body,
                FeeType = viewModel.FeeType,
                TotalFee = viewModel.TotalFee,
                SpbillCreateIp = viewModel.SpbillCreateIp,
                DeviceInfo = viewModel.DeviceInfo,
                AuthCode = viewModel.AuthCode,
                TradeType = viewModel.TradeType,
                NotifyUrl = viewModel.NotifyUrl
            };
            var response = await _client.ExecuteAsync(request);
            ViewData["response"] = response.Body;
            return View();
        }

        /// <summary>
        /// 扫码支付
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult QrCodePay()
        {
            return View();
        }

        /// <summary>
        /// 扫码支付
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> QrCodePay(QPayUnifiedOrderViewModel viewModel)
        {
            var request = new QPayUnifiedOrderRequest
            {
                OutTradeNo = viewModel.OutTradeNo,
                Body = viewModel.Body,
                FeeType = viewModel.FeeType,
                TotalFee = viewModel.TotalFee,
                SpbillCreateIp = viewModel.SpbillCreateIp,
                TradeType = viewModel.TradeType,
                NotifyUrl = viewModel.NotifyUrl
            };
            var response = await _client.ExecuteAsync(request);
            ViewData["qrcode"] = response.CodeUrl;
            ViewData["response"] = response.Body;
            return View();
        }

        /// <summary>
        /// 公众号支付
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult PubPay()
        {
            return View();
        }

        /// <summary>
        /// 公众号支付
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> PubPay(QPayUnifiedOrderViewModel viewModel)
        {
            var request = new QPayUnifiedOrderRequest
            {
                OutTradeNo = viewModel.OutTradeNo,
                Body = viewModel.Body,
                FeeType = viewModel.FeeType,
                TotalFee = viewModel.TotalFee,
                SpbillCreateIp = viewModel.SpbillCreateIp,
                TradeType = viewModel.TradeType,
                NotifyUrl = viewModel.NotifyUrl
            };
            var response = await _client.ExecuteAsync(request);
            ViewData["response"] = response.Body;
            return View();
        }

        /// <summary>
        /// APP支付
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult AppPay()
        {
            return View();
        }

        /// <summary>
        /// APP支付
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> AppPay(QPayUnifiedOrderViewModel viewModel)
        {
            var request = new QPayUnifiedOrderRequest
            {
                OutTradeNo = viewModel.OutTradeNo,
                Body = viewModel.Body,
                FeeType = viewModel.FeeType,
                TotalFee = viewModel.TotalFee,
                SpbillCreateIp = viewModel.SpbillCreateIp,
                TradeType = viewModel.TradeType,
                NotifyUrl = viewModel.NotifyUrl
            };
            var response = await _client.ExecuteAsync(request);
            ViewData["response"] = response.Body;
            return View();
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
        public async Task<IActionResult> OrderQuery(QPayOrderQueryViewModel viewModel)
        {
            var request = new QPayOrderQueryRequest
            {
                TransactionId = viewModel.TransactionId,
                OutTradeNo = viewModel.OutTradeNo
            };
            var response = await _client.ExecuteAsync(request);
            ViewData["response"] = response.Body;
            return View();
        }

        /// <summary>
        /// 撤销订单
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Reverse()
        {
            return View();
        }

        /// <summary>
        /// 撤销订单
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Reverse(QPayReverseViewModel viewModel)
        {
            var request = new QPayReverseRequest
            {
                OutTradeNo = viewModel.OutTradeNo
            };
            var response = await _client.ExecuteAsync(request, "qpayCertificateName");
            ViewData["response"] = response.Body;
            return View();
        }

        /// <summary>
        /// 关闭订单
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult CloseOrder()
        {
            return View();
        }

        /// <summary>
        /// 关闭订单
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CloseOrder(QPayCloseOrderViewModel viewModel)
        {
            var request = new QPayCloseOrderRequest
            {
                OutTradeNo = viewModel.OutTradeNo
            };
            var response = await _client.ExecuteAsync(request);
            ViewData["response"] = response.Body;
            return View();
        }

        /// <summary>
        /// 关闭订单
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Refund()
        {
            return View();
        }

        /// <summary>
        /// 关闭订单
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Refund(QPayRefundViewModel viewModel)
        {
            var request = new QPayRefundRequest
            {
                OutRefundNo = viewModel.OutRefundNo,
                TransactionId = viewModel.TransactionId,
                OutTradeNo = viewModel.OutTradeNo,
                RefundFee = viewModel.RefundFee,
                OpUserId = viewModel.OpUserId,
                OpUserPasswd = viewModel.OpUserPasswd
            };
            var response = await _client.ExecuteAsync(request, "qpayCertificateName");
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
        public async Task<IActionResult> RefundQuery(QPayRefundQueryViewModel viewModel)
        {
            var request = new QPayRefundQueryRequest
            {
                RefundId = viewModel.RefundId,
                OutRefundNo = viewModel.OutRefundNo,
                TransactionId = viewModel.TransactionId,
                OutTradeNo = viewModel.OutTradeNo
            };
            var response = await _client.ExecuteAsync(request);
            ViewData["response"] = response.Body;
            return View();
        }

        /// <summary>
        /// 对账单下载
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult StatementDown()
        {
            return View();
        }

        /// <summary>
        /// 对账单下载
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> StatementDown(QPayStatementDownViewModel viewModel)
        {
            var request = new QPayStatementDownRequest
            {
                BillDate = viewModel.BillDate,
                BillType = viewModel.BillType,
                TarType = viewModel.TarType
            };
            var response = await _client.ExecuteAsync(request);
            ViewData["response"] = response.Body;
            return View();
        }
        /// <summary>
        /// 企业付款
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult B2CPay()
        {
            return View();
        }
        /// <summary>
        /// 企业付款
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> B2CPay(QPayB2CPayViewModel viewModel)
        {
            var request = new QPayEPayB2CRequest
            {
                OutTradeNo = viewModel.OutTradeNo,
                TotalFee = viewModel.TotalFee,
                SpbillCreateIp = viewModel.SpbillCreateIp,
                NotifyUrl = viewModel.NotifyUrl,
                AppId = viewModel.AppId,
                Memo = viewModel.Memo,
                OpenId = viewModel.OpenId,
                OpUserId = viewModel.OpUserId,
                OpUserPasswd= Essensoft.AspNetCore.Payment.Security.MD5.Compute(viewModel.OpUserPasswd),
                CheckRealName="1",
                Uin= viewModel.Uin
            };
            var response = await _client.ExecuteAsync(request,"test");
            ViewData["response"] = response.Body;
            return View();
        }
    }
}
