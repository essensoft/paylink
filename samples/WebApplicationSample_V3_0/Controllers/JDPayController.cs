using System.Text;
using System.Threading.Tasks;
using Essensoft.AspNetCore.Payment.JDPay;
using Essensoft.AspNetCore.Payment.JDPay.Notify;
using Essensoft.AspNetCore.Payment.JDPay.Request;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WebApplicationSample_V3_0.Models;

namespace WebApplicationSample_V3_0.Controllers
{
    public class JDPayController : Controller
    {
        private readonly IJDPayClient _client;
        private readonly IJDPayNotifyClient _notifyClient;
        private readonly IOptions<JDPayOptions> _optionsAccessor;

        public JDPayController(IJDPayClient client, IJDPayNotifyClient notifyClient, IOptions<JDPayOptions> optionsAccessor)
        {
            _client = client;
            _notifyClient = notifyClient;
            _optionsAccessor = optionsAccessor;
        }

        /// <summary>
        /// 京东支付指引页
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// PC在线支付
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult SaveOrderPC()
        {
            return View();
        }

        /// <summary>
        /// PC在线支付
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
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

            var response = await _client.PageExecuteAsync(request, _optionsAccessor.Value);
            return Content(response.Body, "text/html", Encoding.UTF8);
        }

        /// <summary>
        /// H5在线支付
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult SaveOrderH5()
        {
            return View();
        }

        /// <summary>
        /// H5在线支付
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
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

            var response = await _client.PageExecuteAsync(request, _optionsAccessor.Value);
            return Content(response.Body, "text/html", Encoding.UTF8);
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
        public async Task<IActionResult> QrCodePay(JDPayUnifiedOrderViewModel viewModel)
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

            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);
            ViewData["qrcode"] = response.QrCode;
            ViewData["response"] = response.Body;
            return View();
        }

        /// <summary>
        /// 交易查询接口
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Query()
        {
            return View();
        }

        /// <summary>
        /// 交易查询接口
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Query(JDPayQueryViewModel viewModel)
        {
            var request = new JDPayQueryRequest
            {
                TradeNum = viewModel.TradeNum,
                OTradeNum = viewModel.OTradeNum,
                TradeType = viewModel.TradeType
            };

            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);
            ViewData["response"] = response.Body;
            return View();
        }

        /// <summary>
        /// 退款申请接口
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Refund()
        {
            return View();
        }

        /// <summary>
        /// 退款申请接口
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
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

            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);
            ViewData["response"] = response.Body;
            return View();
        }

        /// <summary>
        /// 退款查询接口
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult QueryRefund()
        {
            return View();
        }

        /// <summary>
        /// 退款查询接口
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> QueryRefund(JDPayQueryRefundViewModel viewModel)
        {
            var request = new JDPayQueryRefundRequest
            {
                TradeNum = viewModel.TradeNum,
                OTradeNum = viewModel.OTradeNum,
                TradeType = viewModel.TradeType
            };

            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);
            ViewData["response"] = response.Body;
            return View();
        }

        /// <summary>
        /// 代付交易请求
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult DefrayPay()
        {
            return View();
        }

        /// <summary>
        /// 代付交易请求
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
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

            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);
            ViewData["response"] = response.Body;
            return View();
        }

        /// <summary>
        /// 代付交易查询
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult TradeQuery()
        {
            return View();
        }

        /// <summary>
        /// 代付交易查询
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
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

            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);
            ViewData["response"] = response.Body;
            return View();
        }

        /// <summary>
        /// PC在线支付 / H5在线支付
        /// pc post / h5 get
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [HttpPost]
        public async Task<IActionResult> Return()
        {
            try
            {
                var notify = await _notifyClient.ExecuteAsync<JDPaySyncReturn>(Request, _optionsAccessor.Value);
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
