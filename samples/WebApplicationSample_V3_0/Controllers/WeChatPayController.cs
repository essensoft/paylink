using System.Threading.Tasks;
using Essensoft.AspNetCore.Payment.WeChatPay;
using Essensoft.AspNetCore.Payment.WeChatPay.Request;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using WebApplicationSample_V3_0.Models;

namespace WebApplicationSample_V3_0.Controllers
{
    public class WeChatPayController : Controller
    {
        private readonly IWeChatPayClient _client;
        private readonly IOptions<WeChatPayOptions> _optionsAccessor;

        public WeChatPayController(IWeChatPayClient client, IOptions<WeChatPayOptions> optionsAccessor)
        {
            _client = client;
            _optionsAccessor = optionsAccessor;
        }

        /// <summary>
        /// 微信支付指引页
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 刷卡支付
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult MicroPay()
        {
            return View();
        }

        /// <summary>
        /// 刷卡支付
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> MicroPay(WeChatPayMicroPayViewModel viewModel)
        {
            var request = new WeChatPayMicroPayRequest
            {
                Body = viewModel.Body,
                OutTradeNo = viewModel.OutTradeNo,
                TotalFee = viewModel.TotalFee,
                SpBillCreateIp = viewModel.SpBillCreateIp,
                AuthCode = viewModel.AuthCode
            };
            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);
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
        public async Task<IActionResult> PubPay(WeChatPayPubPayViewModel viewModel)
        {
            var request = new WeChatPayUnifiedOrderRequest
            {
                Body = viewModel.Body,
                OutTradeNo = viewModel.OutTradeNo,
                TotalFee = viewModel.TotalFee,
                SpBillCreateIp = viewModel.SpBillCreateIp,
                NotifyUrl = viewModel.NotifyUrl,
                TradeType = viewModel.TradeType,
                OpenId = viewModel.OpenId
            };
            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);
            if (response.ReturnCode == "SUCCESS" && response.ResultCode == "SUCCESS")
            {
                var req = new WeChatPayJsApiSdkRequest
                {
                    Package = "prepay_id=" + response.PrepayId
                };
                var parameter = await _client.ExecuteAsync(req, _optionsAccessor.Value);
                // 将参数(parameter)给 公众号前端 让他在微信内H5调起支付(https://pay.weixin.qq.com/wiki/doc/api/jsapi.php?chapter=7_7&index=6)
                ViewData["parameter"] = JsonConvert.SerializeObject(parameter);
                ViewData["response"] = response.ResponseBody;
                return View();
            }
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
        public async Task<IActionResult> QrCodePay(WeChatPayQrCodePayViewModel viewModel)
        {
            var request = new WeChatPayUnifiedOrderRequest
            {
                Body = viewModel.Body,
                OutTradeNo = viewModel.OutTradeNo,
                TotalFee = viewModel.TotalFee,
                SpBillCreateIp = viewModel.SpBillCreateIp,
                NotifyUrl = viewModel.NotifyUrl,
                TradeType = viewModel.TradeType
            };
            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);
            // response.CodeUrl 给前端生成二维码
            ViewData["qrcode"] = response.CodeUrl;
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
        public async Task<IActionResult> AppPay(WeChatPayAppPayViewModel viewModel)
        {
            var request = new WeChatPayUnifiedOrderRequest
            {
                Body = viewModel.Body,
                OutTradeNo = viewModel.OutTradeNo,
                TotalFee = viewModel.TotalFee,
                SpBillCreateIp = viewModel.SpBillCreateIp,
                NotifyUrl = viewModel.NotifyUrl,
                TradeType = viewModel.TradeType
            };
            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);

            if (response.ReturnCode == "SUCCESS" && response.ResultCode == "SUCCESS")
            {
                var req = new WeChatPayAppSdkRequest
                {
                    PrepayId = response.PrepayId
                };
                var parameter = await _client.ExecuteAsync(req, _optionsAccessor.Value);
                // 将参数(parameter)给 ios/android端 让他调起微信APP(https://pay.weixin.qq.com/wiki/doc/api/app/app.php?chapter=8_5)
                ViewData["parameter"] = JsonConvert.SerializeObject(parameter);
                ViewData["response"] = response.ResponseBody;
                return View();
            }
            ViewData["response"] = response.ResponseBody;
            return View();
        }

        /// <summary>
        /// H5支付
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult H5Pay()
        {
            return View();
        }

        /// <summary>
        /// H5支付
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> H5Pay(WeChatPayH5PayViewModel viewModel)
        {
            var request = new WeChatPayUnifiedOrderRequest
            {
                Body = viewModel.Body,
                OutTradeNo = viewModel.OutTradeNo,
                TotalFee = viewModel.TotalFee,
                SpBillCreateIp = viewModel.SpBillCreateIp,
                NotifyUrl = viewModel.NotifyUrl,
                TradeType = viewModel.TradeType
            };
            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);

            // mweb_url为拉起微信支付收银台的中间页面，可通过访问该url来拉起微信客户端，完成支付,mweb_url的有效期为5分钟。
            return Redirect(response.MwebUrl);
        }

        /// <summary>
        /// 小程序支付
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult LiteAppPay()
        {
            return View();
        }

        /// <summary>
        /// 小程序支付
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> LiteAppPay(WeChatPayLiteAppPayViewModel viewModel)
        {
            var request = new WeChatPayUnifiedOrderRequest
            {
                Body = viewModel.Body,
                OutTradeNo = viewModel.OutTradeNo,
                TotalFee = viewModel.TotalFee,
                SpBillCreateIp = viewModel.SpBillCreateIp,
                NotifyUrl = viewModel.NotifyUrl,
                TradeType = viewModel.TradeType,
                OpenId = viewModel.OpenId
            };
            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);

            if (response.ReturnCode == "SUCCESS" && response.ResultCode == "SUCCESS")
            {
                var req = new WeChatPayLiteAppSdkRequest
                {
                    Package = "prepay_id=" + response.PrepayId
                };
                var parameter = await _client.ExecuteAsync(req, _optionsAccessor.Value);
                // 将参数(parameter)给 小程序前端 让他调起支付API(https://pay.weixin.qq.com/wiki/doc/api/wxa/wxa_api.php?chapter=7_7&index=5)
                ViewData["parameter"] = JsonConvert.SerializeObject(parameter);
                ViewData["response"] = response.ResponseBody;
                return View();
            }
            ViewData["response"] = response.ResponseBody;
            return View();
        }

        /// <summary>
        /// 查询订单
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult OrderQuery()
        {
            return View();
        }

        /// <summary>
        /// 查询订单
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> OrderQuery(WeChatPayOrderQueryViewModel viewModel)
        {
            var request = new WeChatPayOrderQueryRequest
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
        public async Task<IActionResult> Reverse(WeChatPayReverseViewModel viewModel)
        {
            var request = new WeChatPayReverseRequest
            {
                TransactionId = viewModel.TransactionId,
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
        public async Task<IActionResult> CloseOrder(WeChatPayCloseOrderViewModel viewModel)
        {
            var request = new WeChatPayCloseOrderRequest
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
        public async Task<IActionResult> Refund(WeChatPayRefundViewModel viewModel)
        {
            var request = new WeChatPayRefundRequest
            {
                OutRefundNo = viewModel.OutRefundNo,
                TransactionId = viewModel.TransactionId,
                OutTradeNo = viewModel.OutTradeNo,
                TotalFee = viewModel.TotalFee,
                RefundFee = viewModel.RefundFee,
                RefundDesc = viewModel.RefundDesc,
                NotifyUrl = viewModel.NotifyUrl
            };
            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);
            ViewData["response"] = response.ResponseBody;
            return View();
        }

        /// <summary>
        /// 查询退款
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult RefundQuery()
        {
            return View();
        }

        /// <summary>
        /// 查询退款
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> RefundQuery(WeChatPayRefundQueryViewModel viewModel)
        {
            var request = new WeChatPayRefundQueryRequest
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
        /// 下载对账单
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult DownloadBill()
        {
            return View();
        }

        /// <summary>
        /// 下载对账单
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> DownloadBill(WeChatPayDownloadBillViewModel viewModel)
        {
            var request = new WeChatPayDownloadBillRequest
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
        /// 下载资金账单
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult DownloadFundFlow()
        {
            return View();
        }

        /// <summary>
        /// 下载资金账单
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> DownloadFundFlow(WeChatPayDownloadFundFlowViewModel viewModel)
        {
            var request = new WeChatPayDownloadFundFlowRequest
            {
                BillDate = viewModel.BillDate,
                AccountType = viewModel.AccountType,
                TarType = viewModel.TarType
            };
            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);
            ViewData["response"] = response.ResponseBody;
            return View();
        }

        /// <summary>
        /// 企业付款到零钱
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Transfers()
        {
            return View();
        }

        /// <summary>
        /// 企业付款到零钱
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Transfers(WeChatPayTransfersViewModel viewModel)
        {
            var request = new WeChatPayPromotionTransfersRequest
            {
                PartnerTradeNo = viewModel.PartnerTradeNo,
                OpenId = viewModel.OpenId,
                CheckName = viewModel.CheckName,
                ReUserName = viewModel.ReUserName,
                Amount = viewModel.Amount,
                Desc = viewModel.Desc,
                SpBillCreateIp = viewModel.SpBillCreateIp
            };
            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);
            ViewData["response"] = response.ResponseBody;
            return View();
        }

        /// <summary>
        /// 查询企业付款
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetTransferInfo()
        {
            return View();
        }

        /// <summary>
        /// 查询企业付款
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> GetTransferInfo(WeChatPayGetTransferInfoViewModel viewModel)
        {
            var request = new WeChatPayGetTransferInfoRequest
            {
                PartnerTradeNo = viewModel.PartnerTradeNo
            };
            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);
            ViewData["response"] = response.ResponseBody;
            return View();
        }

        /// <summary>
        /// 企业付款到银行卡
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult PayBank()
        {
            return View();
        }

        /// <summary>
        /// 企业付款到银行卡
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> PayBank(WeChatPayPayBankViewModel viewModel)
        {
            var request = new WeChatPayPayBankRequest
            {
                PartnerTradeNo = viewModel.PartnerTradeNo,
                EncBankNo = viewModel.EncBankNo,
                EncTrueName = viewModel.EncTrueName,
                BankCode = viewModel.BankCode,
                Amount = viewModel.Amount,
                Desc = viewModel.Desc
            };
            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);
            ViewData["response"] = response.ResponseBody;
            return View();
        }

        /// <summary>
        /// 查询企业付款银行卡
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult QueryBank()
        {
            return View();
        }

        /// <summary>
        /// 查询企业付款银行卡
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> QueryBank(WeChatPayQueryBankViewModel viewModel)
        {
            var request = new WeChatPayQueryBankRequest
            {
                PartnerTradeNo = viewModel.PartnerTradeNo
            };
            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);
            ViewData["response"] = response.ResponseBody;
            return View();
        }

        /// <summary>
        /// 获取RSA加密公钥
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [HttpPost]
        public async Task<IActionResult> GetPublicKey()
        {
            if (Request.Method == "POST")
            {
                var request = new WeChatPayRiskGetPublicKeyRequest();
                var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);
                ViewData["response"] = response.ResponseBody;
                return View();
            }

            return View();
        }
    }
}
