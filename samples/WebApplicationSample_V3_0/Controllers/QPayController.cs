using System.Threading.Tasks;
using Essensoft.AspNetCore.Payment.QPay;
using Essensoft.AspNetCore.Payment.QPay.Request;
using Essensoft.AspNetCore.Payment.Security;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WebApplicationSample_V3_0.Models;

namespace WebApplicationSample_V3_0.Controllers
{
    public class QPayController : Controller
    {
        private readonly IQPayClient _client;
        private readonly IOptions<QPayOptions> _optionsAccessor;

        public QPayController(IQPayClient client, IOptions<QPayOptions> optionsAccessor)
        {
            _client = client;
            _optionsAccessor = optionsAccessor;
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
                SpBillCreateIp = viewModel.SpBillCreateIp,
                DeviceInfo = viewModel.DeviceInfo,
                AuthCode = viewModel.AuthCode,
                TradeType = viewModel.TradeType,
                NotifyUrl = viewModel.NotifyUrl
            };
            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);
            ViewData["response"] = response.ResponseBody;
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
                SpBillCreateIp = viewModel.SpBillCreateIp,
                TradeType = viewModel.TradeType,
                NotifyUrl = viewModel.NotifyUrl
            };
            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);
            ViewData["qrcode"] = response.CodeUrl;
            ViewData["response"] = response.ResponseBody;
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
                SpBillCreateIp = viewModel.SpBillCreateIp,
                TradeType = viewModel.TradeType,
                NotifyUrl = viewModel.NotifyUrl
            };
            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);
            ViewData["response"] = response.ResponseBody;
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
                SpBillCreateIp = viewModel.SpBillCreateIp,
                TradeType = viewModel.TradeType,
                NotifyUrl = viewModel.NotifyUrl
            };
            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);
            ViewData["response"] = response.ResponseBody;
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
            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);
            ViewData["response"] = response.ResponseBody;
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
            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);
            ViewData["response"] = response.ResponseBody;
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
            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);
            ViewData["response"] = response.ResponseBody;
            return View();
        }

        /// <summary>
        /// 申请退款
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Refund()
        {
            return View();
        }

        /// <summary>
        /// 申请退款
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
                OpUserPasswd = MD5.Compute(viewModel.OpUserPasswd).ToUpper(),
            };
            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);
            ViewData["response"] = response.ResponseBody;
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
            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);
            ViewData["response"] = response.ResponseBody;
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
            var request = new QPaySpDownloadStatementDownRequest
            {
                BillDate = viewModel.BillDate,
                BillType = viewModel.BillType,
                TarType = viewModel.TarType
            };
            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);
            ViewData["response"] = response.ResponseBody;
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
                OpenId = viewModel.OpenId,
                Uin = viewModel.Uin,
                OutTradeNo = viewModel.OutTradeNo,
                TotalFee = viewModel.TotalFee,
                Memo = viewModel.Memo,
                CheckRealName = viewModel.CheckRealName,
                OpUserId = viewModel.OpUserId,
                OpUserPasswd = MD5.Compute(viewModel.OpUserPasswd).ToUpper(),
                SpBillCreateIp = viewModel.SpBillCreateIp,
                NotifyUrl = viewModel.NotifyUrl,
            };
            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);
            ViewData["response"] = response.ResponseBody;
            return View();
        }
    }
}
