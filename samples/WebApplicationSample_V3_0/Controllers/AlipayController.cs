using System.Text;
using System.Threading.Tasks;
using Essensoft.AspNetCore.Payment.Alipay;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Essensoft.AspNetCore.Payment.Alipay.Notify;
using Essensoft.AspNetCore.Payment.Alipay.Request;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WebApplicationSample_V3_0.Models;

namespace WebApplicationSample_V3_0.Controllers
{
    public class AlipayController : Controller
    {
        private readonly IAlipayClient _client;
        private readonly IAlipayNotifyClient _notifyClient;
        private readonly IOptions<AlipayOptions> _optionsAccessor;

        public AlipayController(IAlipayClient client, IAlipayNotifyClient notifyClient, IOptions<AlipayOptions> optionsAccessor)
        {
            _client = client;
            _notifyClient = notifyClient;
            _optionsAccessor = optionsAccessor;
        }

        /// <summary>
        /// 支付宝指引页
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 当面付-扫码支付
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult PreCreate()
        {
            return View();
        }

        /// <summary>
        /// 当面付-扫码支付
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> PreCreate(AlipayTradePreCreateViewModel viewModel)
        {
            var model = new AlipayTradePrecreateModel
            {
                OutTradeNo = viewModel.OutTradeNo,
                Subject = viewModel.Subject,
                TotalAmount = viewModel.TotalAmount,
                Body = viewModel.Body
            };
            var req = new AlipayTradePrecreateRequest();
            req.SetBizModel(model);
            req.SetNotifyUrl(viewModel.NotifyUrl);

            var response = await _client.ExecuteAsync(req, _optionsAccessor.Value);
            ViewData["qrcode"] = response.QrCode;
            ViewData["response"] = response.ResponseBody;
            return View();
        }

        /// <summary>
        /// 当面付-二维码/条码/声波支付
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Pay()
        {
            return View();
        }

        /// <summary>
        /// 当面付-二维码/条码/声波支付
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Pay(AlipayTradePayViewModel viewModel)
        {
            var model = new AlipayTradePayModel
            {
                OutTradeNo = viewModel.OutTradeNo,
                Subject = viewModel.Subject,
                Scene = viewModel.Scene,
                AuthCode = viewModel.AuthCode,
                TotalAmount = viewModel.TotalAmount,
                Body = viewModel.Body
            };
            var req = new AlipayTradePayRequest();
            req.SetBizModel(model);

            var response = await _client.ExecuteAsync(req, _optionsAccessor.Value);
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
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> AppPay(AlipayTradeAppPayViewModel viewModel)
        {
            var model = new AlipayTradeAppPayModel
            {
                OutTradeNo = viewModel.OutTradeNo,
                Subject = viewModel.Subject,
                ProductCode = viewModel.ProductCode,
                TotalAmount = viewModel.TotalAmount,
                Body = viewModel.Body
            };
            var req = new AlipayTradeAppPayRequest();
            req.SetBizModel(model);
            req.SetNotifyUrl(viewModel.NotifyUrl);

            var response = await _client.SdkExecuteAsync(req, _optionsAccessor.Value);
            //将response.Body给 ios/android端 由其去调起支付宝APP(https://docs.open.alipay.com/204/105296/ https://docs.open.alipay.com/204/105295/)
            ViewData["response"] = response.ResponseBody;
            return View();
        }

        /// <summary>
        /// 电脑网站支付
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult PagePay()
        {
            return View();
        }

        /// <summary>
        /// 电脑网站支付
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> PagePay(AlipayTradePagePayViewModel viewModel)
        {
            var model = new AlipayTradePagePayModel
            {
                Body = viewModel.Body,
                Subject = viewModel.Subject,
                TotalAmount = viewModel.TotalAmount,
                OutTradeNo = viewModel.OutTradeNo,
                ProductCode = viewModel.ProductCode
            };
            var req = new AlipayTradePagePayRequest();
            req.SetBizModel(model);
            req.SetNotifyUrl(viewModel.NotifyUrl);
            req.SetReturnUrl(viewModel.ReturnUrl);

            var response = await _client.PageExecuteAsync(req, _optionsAccessor.Value);
            return Content(response.ResponseBody, "text/html", Encoding.UTF8);
        }

        /// <summary>
        /// 手机网站支付
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult WapPay()
        {
            return View();
        }

        /// <summary>
        /// 手机网站支付
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> WapPay(AlipayTradeWapPayViewModel viewMode)
        {
            var model = new AlipayTradeWapPayModel
            {
                Body = viewMode.Body,
                Subject = viewMode.Subject,
                TotalAmount = viewMode.TotalAmount,
                OutTradeNo = viewMode.OutTradeNo,
                ProductCode = viewMode.ProductCode
            };
            var req = new AlipayTradeWapPayRequest();
            req.SetBizModel(model);
            req.SetNotifyUrl(viewMode.NotifyUrl);
            req.SetReturnUrl(viewMode.ReturnUrl);

            var response = await _client.PageExecuteAsync(req, _optionsAccessor.Value);
            return Content(response.ResponseBody, "text/html", Encoding.UTF8);
        }

        /// <summary>
        /// 交易查询
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Query()
        {
            return View();
        }

        /// <summary>
        /// 交易查询
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Query(AlipayTradeQueryViewModel viewMode)
        {
            var model = new AlipayTradeQueryModel
            {
                OutTradeNo = viewMode.OutTradeNo,
                TradeNo = viewMode.TradeNo
            };

            var req = new AlipayTradeQueryRequest();
            req.SetBizModel(model);

            var response = await _client.ExecuteAsync(req, _optionsAccessor.Value);
            ViewData["response"] = response.ResponseBody;
            return View();
        }

        /// <summary>
        /// 交易退款
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Refund()
        {
            return View();
        }

        /// <summary>
        /// 交易退款
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Refund(AlipayTradeRefundViewModel viewMode)
        {
            var model = new AlipayTradeRefundModel
            {
                OutTradeNo = viewMode.OutTradeNo,
                TradeNo = viewMode.TradeNo,
                RefundAmount = viewMode.RefundAmount,
                OutRequestNo = viewMode.OutRequestNo,
                RefundReason = viewMode.RefundReason
            };

            var req = new AlipayTradeRefundRequest();
            req.SetBizModel(model);

            var response = await _client.ExecuteAsync(req, _optionsAccessor.Value);
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
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> RefundQuery(AlipayTradeRefundQueryViewModel viewMode)
        {
            var model = new AlipayTradeFastpayRefundQueryModel
            {
                OutTradeNo = viewMode.OutTradeNo,
                TradeNo = viewMode.TradeNo,
                OutRequestNo = viewMode.OutRequestNo
            };

            var req = new AlipayTradeFastpayRefundQueryRequest();
            req.SetBizModel(model);

            var response = await _client.ExecuteAsync(req, _optionsAccessor.Value);
            ViewData["response"] = response.ResponseBody;
            return View();
        }

        /// <summary>
        /// 单笔转账到支付宝账户
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Transfer()
        {
            return View();
        }

        /// <summary>
        /// 单笔转账到支付宝账户
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Transfer(AlipayTransferViewModel viewMode)
        {
            var model = new AlipayFundTransToaccountTransferModel
            {
                OutBizNo = viewMode.OutBizNo,
                PayeeType = viewMode.PayeeType,
                PayeeAccount = viewMode.PayeeAccount,
                Amount = viewMode.Amount,
                Remark = viewMode.Remark
            };
            var req = new AlipayFundTransToaccountTransferRequest();
            req.SetBizModel(model);
            var response = await _client.ExecuteAsync(req, _optionsAccessor.Value);
            ViewData["response"] = response.ResponseBody;
            return View();
        }

        /// <summary>
        /// 查询转账订单
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult TransQuery()
        {
            return View();
        }

        /// <summary>
        /// 查询转账订单
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> TransQuery(AlipayTransQueryViewModel viewMode)
        {
            var model = new AlipayFundTransOrderQueryModel
            {
                OutBizNo = viewMode.OutBizNo,
                OrderId = viewMode.OrderId
            };

            var req = new AlipayFundTransOrderQueryRequest();
            req.SetBizModel(model);
            var response = await _client.ExecuteAsync(req, _optionsAccessor.Value);
            ViewData["response"] = response.ResponseBody;
            return View();
        }

        /// <summary>
        /// 查询对账单下载地址
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult BillDownloadurlQuery()
        {
            return View();
        }

        /// <summary>
        /// 查询对账单下载地址
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> BillDownloadurlQuery(AlipayBillDownloadurlQueryViewModel viewModel)
        {
            var model = new AlipayDataDataserviceBillDownloadurlQueryModel
            {
                BillDate = viewModel.BillDate,
                BillType = viewModel.BillType
            };

            var req = new AlipayDataDataserviceBillDownloadurlQueryRequest();
            req.SetBizModel(model);
            var response = await _client.ExecuteAsync(req, _optionsAccessor.Value);
            ViewData["response"] = response.ResponseBody;
            return View();
        }

        /// <summary>
        /// 电脑网站支付 - 同步跳转
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> PagePayReturn()
        {
            try
            {
                var notify = await _notifyClient.ExecuteAsync<AlipayTradePagePayReturn>(Request, _optionsAccessor.Value);
                ViewData["response"] = "支付成功";
                return View();
            }
            catch
            {
                ViewData["response"] = "出现错误";
                return View();
            }
        }

        /// <summary>
        /// 手机网站支付 - 同步跳转
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> WapPayReturn()
        {
            try
            {
                var notify = await _notifyClient.ExecuteAsync<AlipayTradeWapPayReturn>(Request, _optionsAccessor.Value);
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
