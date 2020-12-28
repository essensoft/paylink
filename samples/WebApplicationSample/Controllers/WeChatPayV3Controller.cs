using System.Text.Json;
using System.Threading.Tasks;
using Essensoft.AspNetCore.Payment.WeChatPay;
using Essensoft.AspNetCore.Payment.WeChatPay.V3;
using Essensoft.AspNetCore.Payment.WeChatPay.V3.Domain;
using Essensoft.AspNetCore.Payment.WeChatPay.V3.Request;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WebApplicationSample.Models;

namespace WebApplicationSample.Controllers
{
    public class WeChatPayV3Controller : Controller
    {
        private readonly IWeChatPayClient _client;
        private readonly IOptions<WeChatPayOptions> _optionsAccessor;

        public WeChatPayV3Controller(IWeChatPayClient client, IOptions<WeChatPayOptions> optionsAccessor)
        {
            _client = client;
            _optionsAccessor = optionsAccessor;
        }

        /// <summary>
        /// 微信支付指引页
        /// </summary>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 获取平台证书列表
        /// </summary>
        [HttpGet]
        [HttpPost]
        public async Task<IActionResult> GetCertificates()
        {
            if (Request.Method == "POST")
            {
                var request = new WeChatPayCertificatesRequest();
                var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);
                ViewData["response"] = response.Body;
                return View();
            }

            return View();
        }

        /// <summary>
        /// APP支付-App下单API
        /// </summary>
        [HttpGet]
        public IActionResult AppPay()
        {
            return View();
        }

        /// <summary>
        /// APP支付-App下单API
        /// </summary>
        /// <param name="viewModel"></param>
        [HttpPost]
        public async Task<IActionResult> AppPay(WeChatPayAppPayV3ViewModel viewModel)
        {
            var model = new WeChatPayTransactionsAppModel
            {
                AppId = _optionsAccessor.Value.AppId,
                MchId = _optionsAccessor.Value.MchId,
                Amount = new Amount { Total = viewModel.Total, Currency = "CNY" },
                Description = viewModel.Description,
                NotifyUrl = viewModel.NotifyUrl,
                OutTradeNo = viewModel.OutTradeNo,
            };

            var request = new WeChatPayTransactionsAppRequest();
            request.SetQueryModel(model);

            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);

            if (response.StatusCode == 200)
            {
                var req = new WeChatPayAppSdkRequest
                {
                    PrepayId = response.PrepayId
                };

                var parameter = await _client.ExecuteAsync(req, _optionsAccessor.Value);

                // 将参数(parameter)给 ios/android端 
                // https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_2_4.shtml
                ViewData["parameter"] = JsonSerializer.Serialize(parameter);
                ViewData["response"] = response.Body;
                return View();
            }

            ViewData["response"] = response.Body;
            return View();
        }

        /// <summary>
        /// 公众号支付-JSAPI下单
        /// </summary>
        [HttpGet]
        public IActionResult PubPay()
        {
            return View();
        }

        /// <summary>
        /// 公众号支付-JSAPI下单
        /// </summary>
        /// <param name="viewModel"></param>
        [HttpPost]
        public async Task<IActionResult> PubPay(WeChatPayPubPayV3ViewModel viewModel)
        {
            var model = new WeChatPayTransactionsJsApiModel
            {
                AppId = _optionsAccessor.Value.AppId,
                MchId = _optionsAccessor.Value.MchId,
                Amount = new Amount { Total = viewModel.Total, Currency = "CNY" },
                Description = viewModel.Description,
                NotifyUrl = viewModel.NotifyUrl,
                OutTradeNo = viewModel.OutTradeNo,
                Payer = new PayerInfo { OpenId = viewModel.OpenId }
            };

            var request = new WeChatPayTransactionsJsApiRequest();
            request.SetQueryModel(model);

            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);

            if (response.StatusCode == 200)
            {
                var req = new WeChatPayJsApiSdkRequest
                {
                    Package = "prepay_id=" + response.PrepayId
                };

                var parameter = await _client.ExecuteAsync(req, _optionsAccessor.Value);

                // 将参数(parameter)给 公众号前端
                // https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_1_4.shtml
                ViewData["parameter"] = JsonSerializer.Serialize(parameter);
                ViewData["response"] = response.Body;
                return View();
            }

            ViewData["response"] = response.Body;
            return View();
        }

        /// <summary>
        /// 扫码支付-Native下单API
        /// </summary>
        [HttpGet]
        public IActionResult QrCodePay()
        {
            return View();
        }

        /// <summary>
        /// 扫码支付-Native下单API
        /// </summary>
        /// <param name="viewModel"></param>
        [HttpPost]
        public async Task<IActionResult> QrCodePay(WeChatPayQrCodePayV3ViewModel viewModel)
        {
            var model = new WeChatPayTransactionsNativeModel
            {
                AppId = _optionsAccessor.Value.AppId,
                MchId = _optionsAccessor.Value.MchId,
                Amount = new Amount { Total = viewModel.Total, Currency = "CNY" },
                Description = viewModel.Description,
                NotifyUrl = viewModel.NotifyUrl,
                OutTradeNo = viewModel.OutTradeNo,
            };

            var request = new WeChatPayTransactionsNativeRequest();
            request.SetQueryModel(model);

            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);

            // response.CodeUrl 给前端生成二维码
            ViewData["qrcode"] = response.CodeUrl;
            ViewData["response"] = response.Body;
            return View();
        }

        /// <summary>
        /// H5支付-H5下单API
        /// </summary>
        [HttpGet]
        public IActionResult H5Pay()
        {
            return View();
        }

        /// <summary>
        /// H5支付-H5下单API
        /// </summary>
        /// <param name="viewModel"></param>
        [HttpPost]
        public async Task<IActionResult> H5Pay(WeChatPayH5PayV3ViewModel viewModel)
        {
            var model = new WeChatPayTransactionsH5Model
            {
                AppId = _optionsAccessor.Value.AppId,
                MchId = _optionsAccessor.Value.MchId,
                Amount = new Amount { Total = viewModel.Total, Currency = "CNY" },
                Description = viewModel.Description,
                NotifyUrl = viewModel.NotifyUrl,
                OutTradeNo = viewModel.OutTradeNo,
                SceneInfo = new SceneInfo { PayerClientIp = "127.0.0.1" }
            };

            var request = new WeChatPayTransactionsH5Request();
            request.SetQueryModel(model);

            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);

            // h5_url为拉起微信支付收银台的中间页面，可通过访问该url来拉起微信客户端，完成支付,h5_url的有效期为5分钟。
            // https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_3_4.shtml
            ViewData["response"] = response.Body;
            return View();
        }

        /// <summary>
        /// 微信支付订单号查询
        /// </summary>
        [HttpGet]
        public IActionResult QueryByTransactionId()
        {
            return View();
        }

        /// <summary>
        /// 微信支付订单号查询
        /// </summary>
        /// <param name="viewModel"></param>
        [HttpPost]
        public async Task<IActionResult> QueryByTransactionId(WeChatPayQueryByTransactionIdViewModel viewModel)
        {
            var request = new WeChatPayTransactionsIdRequest
            {
                TransactionId = viewModel.TransactionId,
                MchId = _optionsAccessor.Value.MchId,
            };

            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);

            ViewData["response"] = response.Body;
            return View();
        }

        /// <summary>
        /// 商户订单号查询
        /// </summary>
        [HttpGet]
        public IActionResult QueryByOutTradeNo()
        {
            return View();
        }

        /// <summary>
        /// 商户订单号查询
        /// </summary>
        /// <param name="viewModel"></param>
        [HttpPost]
        public async Task<IActionResult> QueryByOutTradeNo(WeChatPayQueryByOutTradeNoViewModel viewModel)
        {
            var request = new WeChatPayTransactionsOutTradeNoRequest
            {
                OutTradeNo = viewModel.OutTradeNo,
                MchId = _optionsAccessor.Value.MchId,
            };

            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);

            ViewData["response"] = response.Body;
            return View();
        }

        /// <summary>
        /// 关闭订单
        /// </summary>
        [HttpGet]
        public IActionResult OutTradeNoClose()
        {
            return View();
        }

        /// <summary>
        /// 关闭订单
        /// </summary>
        /// <param name="viewModel"></param>
        [HttpPost]
        public async Task<IActionResult> OutTradeNoClose(WeChatPayOutTradeNoCloseViewModel viewModel)
        {
            var model = new WeChatPayTransactionsOutTradeNoCloseModel
            {
                MchId = _optionsAccessor.Value.MchId,
            };

            var request = new WeChatPayTransactionsOutTradeNoCloseRequest
            {
                OutTradeNo = viewModel.OutTradeNo,
            };

            request.SetQueryModel(model);

            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);

            ViewData["response"] = response.Body;
            return View();
        }

        /// <summary>
        /// 申请交易账单
        /// </summary>
        [HttpGet]
        public IActionResult TradeBill()
        {
            return View();
        }

        /// <summary>
        /// 申请交易账单
        /// </summary>
        /// <param name="viewModel"></param>
        [HttpPost]
        public async Task<IActionResult> TradeBill(WeChatPayTradeBillViewModel viewModel)
        {
            var request = new WeChatPayBillTradeBillRequest
            {
                BillDate = viewModel.BillDate
            };

            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);

            ViewData["response"] = response.Body;
            return View();
        }

        /// <summary>
        /// 申请资金账单
        /// </summary>
        [HttpGet]
        public IActionResult FundflowBill()
        {
            return View();
        }

        /// <summary>
        /// 申请资金账单
        /// </summary>
        /// <param name="viewModel"></param>
        [HttpPost]
        public async Task<IActionResult> FundflowBill(WeChatPayFundflowBillViewModel viewModel)
        {
            var request = new WeChatPayBillFundflowBillRequest
            {
                BillDate = viewModel.BillDate
            };

            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);

            ViewData["response"] = response.Body;
            return View();
        }

        /// <summary>
        /// 下载账单
        /// </summary>
        [HttpGet]
        public IActionResult BillDownload()
        {
            return View();
        }

        /// <summary>
        /// 下载账单
        /// </summary>
        /// <param name="viewModel"></param>
        [HttpPost]
        public async Task<IActionResult> BillDownload(WeChatPayBillDownloadViewModel viewModel)
        {
            var request = new WeChatPayBillDownloadRequest
            {
                DownloadUrl = viewModel.DownloadUrl
            };

            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);

            ViewData["response"] = response.Body;
            return View();
        }
    }
}
