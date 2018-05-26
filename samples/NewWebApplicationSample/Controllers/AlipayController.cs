using Essensoft.AspNetCore.Payment.Alipay;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Essensoft.AspNetCore.Payment.Alipay.Notify;
using Essensoft.AspNetCore.Payment.Alipay.Request;
using Microsoft.AspNetCore.Mvc;
using NewWebApplicationSample.Models;
using System.Threading.Tasks;

namespace NewWebApplicationSample.Controllers
{
    public class AlipayController : Controller
    {
        private readonly AlipayClient _client = null;
        private readonly AlipayNotifyClient _notifyClient = null;

        public AlipayController(AlipayClient client, AlipayNotifyClient notifyClient)
        {
            _client = client;
            _notifyClient = notifyClient;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult PreCreate()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> PreCreate(AlipayTradePreCreateViewModel viewModel)
        {
            var model = new AlipayTradePrecreateModel()
            {
                OutTradeNo = viewModel.OutTradeNo,
                Subject = viewModel.Subject,
                TotalAmount = viewModel.TotalAmount,
                Body = viewModel.Body,
            };
            var req = new AlipayTradePrecreateRequest();
            req.SetBizModel(model);
            req.SetNotifyUrl(viewModel.NotifyUrl);

            var response = await _client.ExecuteAsync(req);
            ViewData["qrcode"] = response.QrCode;
            ViewData["response"] = response.Body;
            return View();
        }

        [HttpGet]
        public IActionResult Pay()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Pay(AlipayTradePayViewModel viewModel)
        {
            var model = new AlipayTradePayModel()
            {
                OutTradeNo = viewModel.OutTradeNo,
                Subject = viewModel.Subject,
                Scene = viewModel.Scene,
                AuthCode = viewModel.AuthCode,
                TotalAmount = viewModel.TotalAmount,
                Body = viewModel.Body,
            };
            var req = new AlipayTradePayRequest();
            req.SetBizModel(model);
            req.SetNotifyUrl(viewModel.NotifyUrl);

            var response = await _client.ExecuteAsync(req);
            ViewData["response"] = response.Body;
            return View();
        }

        [HttpGet]
        public IActionResult AppPay()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AppPay(AlipayTradeAppPayViewModel viewModel)
        {
            var model = new AlipayTradeAppPayModel()
            {
                OutTradeNo = viewModel.OutTradeNo,
                Subject = viewModel.Subject,
                ProductCode = viewModel.ProductCode,
                TotalAmount = viewModel.TotalAmount,
                Body = viewModel.Body,
            };
            var req = new AlipayTradeAppPayRequest();
            req.SetBizModel(model);
            req.SetNotifyUrl(viewModel.NotifyUrl);

            var response = await _client.SdkExecuteAsync(req);
            //将response.Body给 ios/android端 由其去调起支付宝APP(https://docs.open.alipay.com/204/105296/ https://docs.open.alipay.com/204/105295/)
            ViewData["response"] = response.Body;
            return View();
        }

        [HttpGet]
        public IActionResult PagePay()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> PagePay(AlipayTradePagePayViewModel viewModel)
        {
            var model = new AlipayTradePagePayModel()
            {
                Body = viewModel.Body,
                Subject = viewModel.Subject,
                TotalAmount = viewModel.TotalAmount,
                OutTradeNo = viewModel.OutTradeNo,
                ProductCode = viewModel.ProductCode,
            };
            var req = new AlipayTradePagePayRequest();
            req.SetBizModel(model);
            req.SetNotifyUrl(viewModel.NotifyUrl);
            req.SetReturnUrl(viewModel.ReturnUrl);

            var response = await _client.PageExecuteAsync(req);
            return Content(response.Body, "text/html");
        }

        [HttpGet]
        public IActionResult WapPay()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> WapPay(AlipayTradeWapPayViewModel viewMode)
        {
            var model = new AlipayTradeWapPayModel()
            {
                Body = viewMode.Body,
                Subject = viewMode.Subject,
                TotalAmount = viewMode.TotalAmount,
                OutTradeNo = viewMode.OutTradeNo,
                ProductCode = viewMode.ProductCode,
            };
            var req = new AlipayTradeWapPayRequest();
            req.SetBizModel(model);
            req.SetNotifyUrl(viewMode.NotifyUrl);
            req.SetReturnUrl(viewMode.ReturnUrl);

            var response = await _client.PageExecuteAsync(req);
            return Content(response.Body, "text/html");
        }

        [HttpGet]
        public IActionResult Query()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Query(AlipayTradeQueryViewModel viewMode)
        {
            var model = new AlipayTradeQueryModel()
            {
                OutTradeNo = viewMode.OutTradeNo,
                TradeNo = viewMode.TradeNo
            };

            var req = new AlipayTradeQueryRequest();
            req.SetBizModel(model);

            var response = await _client.ExecuteAsync(req);
            ViewData["response"] = response.Body;
            return View();
        }

        [HttpGet]
        public IActionResult Refund()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Refund(AlipayTradeRefundViewModel viewMode)
        {
            var model = new AlipayTradeRefundModel()
            {
                OutTradeNo = viewMode.OutTradeNo,
                TradeNo = viewMode.TradeNo,
                RefundAmount = viewMode.RefundAmount,
                OutRequestNo = viewMode.OutRequestNo,
                RefundReason = viewMode.RefundReason
            };

            var req = new AlipayTradeRefundRequest();
            req.SetBizModel(model);

            var response = await _client.ExecuteAsync(req);
            ViewData["response"] = response.Body;
            return View();
        }

        [HttpGet]
        public IActionResult RefundQuery()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RefundQuery(AlipayTradeRefundQueryViewModel viewMode)
        {
            var model = new AlipayTradeFastpayRefundQueryModel()
            {
                OutTradeNo = viewMode.OutTradeNo,
                TradeNo = viewMode.TradeNo,
                OutRequestNo = viewMode.OutRequestNo
            };

            var req = new AlipayTradeFastpayRefundQueryRequest();
            req.SetBizModel(model);

            var response = await _client.ExecuteAsync(req);
            ViewData["response"] = response.Body;
            return View();
        }

        [HttpGet]
        public IActionResult Transfer()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Transfer(AlipayTransferViewModel viewMode)
        {
            var model = new AlipayFundTransToaccountTransferModel()
            {
                OutBizNo = viewMode.OutBizNo,
                PayeeType = viewMode.PayeeType,
                PayeeAccount = viewMode.PayeeAccount,
                Amount = viewMode.Amount,
                Remark = viewMode.Remark
            };
            var req = new AlipayFundTransToaccountTransferRequest();
            req.SetBizModel(model);
            var response = await _client.ExecuteAsync(req);
            ViewData["response"] = response.Body;
            return View();
        }

        [HttpGet]
        public IActionResult TransQuery()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> TransQuery(AlipayTransQueryViewModel viewMode)
        {
            var model = new AlipayFundTransOrderQueryModel()
            {
                OutBizNo = viewMode.OutBizNo,
                OrderId = viewMode.OrderId,
            };

            var req = new AlipayFundTransOrderQueryRequest();
            req.SetBizModel(model);
            var response = await _client.ExecuteAsync(req);
            ViewData["response"] = response.Body;
            return View();
        }

        [HttpGet]
        public IActionResult BillDownloadurlQuery()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> BillDownloadurlQuery(AlipayBillDownloadurlQueryViewModel viewModel)
        {
            var model = new AlipayDataDataserviceBillDownloadurlQueryModel()
            {
                BillDate = viewModel.BillDate,
                BillType = viewModel.BillType
            };

            var req = new AlipayDataDataserviceBillDownloadurlQueryRequest();
            req.SetBizModel(model);
            var response = await _client.ExecuteAsync(req);
            ViewData["response"] = response.Body;
            return View();
        }

        /// <summary>
        /// 电脑网站支付-同步跳转
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> PagePayReturn()
        {
            try
            {
                var notify = await _notifyClient.ExecuteAsync<AlipayTradePagePayReturnResponse>(Request);
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
        /// 手机网站支付-同步跳转
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> WapPayReturn()
        {
            try
            {
                var notify = await _notifyClient.ExecuteAsync<AlipayTradeWapPayReturnResponse>(Request);
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
