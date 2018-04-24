using Essensoft.AspNetCore.Payment.WeChatPay;
using Essensoft.AspNetCore.Payment.WeChatPay.Request;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NewWebApplicationSample.Models;
using System.Threading.Tasks;

namespace NewWebApplicationSample.Controllers
{
    public class WeChatPayController : Controller
    {
        private readonly WeChatPayClient _client = null;

        public WeChatPayController(WeChatPayClient client)
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
        public async Task<IActionResult> MicroPay(WeChatPayMicroPayViewModel viewModel)
        {
            var request = new WeChatPayMicroPayRequest()
            {
                Body = viewModel.Body,
                OutTradeNo = viewModel.OutTradeNo,
                TotalFee = viewModel.TotalFee,
                SpbillCreateIp = viewModel.SpbillCreateIp,
                AuthCode = viewModel.AuthCode
            };
            var response = await _client.ExecuteAsync(request);
            ViewData["response"] = response.Body;
            return View();
        }

        [HttpGet]
        public IActionResult PubPay()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> PubPay(WeChatPayPubPayViewModel viewModel)
        {
            var request = new WeChatPayUnifiedOrderRequest()
            {
                Body = viewModel.Body,
                OutTradeNo = viewModel.OutTradeNo,
                TotalFee = viewModel.TotalFee,
                SpbillCreateIp = viewModel.SpbillCreateIp,
                NotifyUrl = viewModel.NotifyUrl,
                TradeType = viewModel.TradeType,
                OpenId = viewModel.OpenId
            };
            var response = await _client.ExecuteAsync(request);
            if (response.ReturnCode == "SUCCESS" && response.ResultCode == "SUCCESS")
            {
                var req = new WeChatPayH5CallPaymentRequest()
                {
                    Package = "prepay_id=" + response.PrepayId,
                };
                var parameter = await _client.ExecuteAsync(req);
                // 将参数(parameter)给 公众号前端 让他在微信内H5调起支付(https://pay.weixin.qq.com/wiki/doc/api/jsapi.php?chapter=7_7&index=6)
                ViewData["parameter"] = JsonConvert.SerializeObject(parameter);
                ViewData["response"] = response.Body;
                return View();
            }
            ViewData["response"] = response.Body;
            return View();
        }

        [HttpGet]
        public IActionResult QRPay()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> QRPay(WeChatPayQRPayViewModel viewModel)
        {
            var request = new WeChatPayUnifiedOrderRequest()
            {
                Body = viewModel.Body,
                OutTradeNo = viewModel.OutTradeNo,
                TotalFee = viewModel.TotalFee,
                SpbillCreateIp = viewModel.SpbillCreateIp,
                NotifyUrl = viewModel.NotifyUrl,
                TradeType = viewModel.TradeType,
            };
            var response = await _client.ExecuteAsync(request);
            // response.CodeUrl 给前端生成二维码
            ViewData["qrcode"] = response.CodeUrl;
            ViewData["response"] = response.Body;
            return View();
        }

        [HttpGet]
        public IActionResult AppPay()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AppPay(WeChatPayAppPayViewModel viewModel)
        {
            var request = new WeChatPayUnifiedOrderRequest()
            {
                Body = viewModel.Body,
                OutTradeNo = viewModel.OutTradeNo,
                TotalFee = viewModel.TotalFee,
                SpbillCreateIp = viewModel.SpbillCreateIp,
                NotifyUrl = viewModel.NotifyUrl,
                TradeType = viewModel.TradeType,
            };
            var response = await _client.ExecuteAsync(request);

            if (response.ReturnCode == "SUCCESS" && response.ResultCode == "SUCCESS")
            {
                var req = new WeChatPayAppCallPaymentRequest()
                {
                    PrepayId = response.PrepayId,
                };
                var parameter = await _client.ExecuteAsync(req);
                // 将参数(parameter)给 ios/android端 让他调起微信APP(https://pay.weixin.qq.com/wiki/doc/api/app/app.php?chapter=8_5)
                ViewData["parameter"] = JsonConvert.SerializeObject(parameter);
                ViewData["response"] = response.Body;
                return View();
            }
            ViewData["response"] = response.Body;
            return View();
        }

        [HttpGet]
        public IActionResult H5Pay()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> H5Pay(WeChatPayH5PayViewModel viewModel)
        {
            var request = new WeChatPayUnifiedOrderRequest()
            {
                Body = viewModel.Body,
                OutTradeNo = viewModel.OutTradeNo,
                TotalFee = viewModel.TotalFee,
                SpbillCreateIp = viewModel.SpbillCreateIp,
                NotifyUrl = viewModel.NotifyUrl,
                TradeType = viewModel.TradeType,
            };
            var response = await _client.ExecuteAsync(request);
            ViewData["response"] = response.Body;
            return View();
        }

        [HttpGet]
        public IActionResult LiteAppPay()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LiteAppPay(WeChatPayLiteAppPayViewModel viewModel)
        {
            var request = new WeChatPayUnifiedOrderRequest()
            {
                Body = viewModel.Body,
                OutTradeNo = viewModel.OutTradeNo,
                TotalFee = viewModel.TotalFee,
                SpbillCreateIp = viewModel.SpbillCreateIp,
                NotifyUrl = viewModel.NotifyUrl,
                TradeType = viewModel.TradeType,
                OpenId = viewModel.OpenId,
            };
            var response = await _client.ExecuteAsync(request);

            if (response.ReturnCode == "SUCCESS" && response.ResultCode == "SUCCESS")
            {
                var req = new WeChatPayLiteAppCallPaymentRequest()
                {
                    Package = "prepay_id=" + response.PrepayId,
                };
                var parameter = await _client.ExecuteAsync(req);
                // 将参数(parameter)给 小程序前端 让他调起支付API(https://pay.weixin.qq.com/wiki/doc/api/wxa/wxa_api.php?chapter=7_7&index=5)
                ViewData["parameter"] = JsonConvert.SerializeObject(parameter);
                ViewData["response"] = response.Body;
                return View();
            }
            ViewData["response"] = response.Body;
            return View();
        }

        [HttpGet]
        public IActionResult OrderQuery()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> OrderQuery(WeChatPayOrderQueryViewModel viewModel)
        {
            var request = new WeChatPayOrderQueryRequest()
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
        public async Task<IActionResult> Reverse(WeChatPayReverseViewModel viewModel)
        {
            var request = new WeChatPayReverseRequest()
            {
                TransactionId = viewModel.TransactionId,
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
        public async Task<IActionResult> CloseOrder(WeChatPayCloseOrderViewModel viewModel)
        {
            var request = new WeChatPayCloseOrderRequest()
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
        public async Task<IActionResult> Refund(WeChatPayRefundViewModel viewModel)
        {
            var request = new WeChatPayRefundRequest()
            {
                OutRefundNo = viewModel.OutRefundNo,
                TransactionId = viewModel.TransactionId,
                OutTradeNo = viewModel.OutTradeNo,
                TotalFee = viewModel.TotalFee,
                RefundFee = viewModel.RefundFee,
                RefundDesc = viewModel.RefundDesc,
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
        public async Task<IActionResult> RefundQuery(WeChatPayRefundQueryViewModel viewModel)
        {
            var request = new WeChatPayRefundQueryRequest()
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
        public IActionResult DownloadBill()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> DownloadBill(WeChatPayDownloadBillViewModel viewModel)
        {
            var request = new WeChatPayDownloadBillRequest()
            {
                BillDate = viewModel.BillDate,
                BillType = viewModel.BillType,
                TarType = viewModel.TarType,
            };
            var response = await _client.ExecuteAsync(request);
            ViewData["response"] = response.Body;
            return View();
        }

        [HttpGet]
        public IActionResult DownloadFundFlow()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> DownloadFundFlow(WeChatPayDownloadFundFlowViewModel viewModel)
        {
            var request = new WeChatPayDownloadFundFlowRequest()
            {
                BillDate = viewModel.BillDate,
                AccountType = viewModel.AccountType,
                TarType = viewModel.TarType,
            };
            var response = await _client.ExecuteAsync(request);
            ViewData["response"] = response.Body;
            return View();
        }

        [HttpGet]
        public IActionResult Transfers()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Transfers(WeChatPayTransfersViewModel viewModel)
        {
            var request = new WeChatPayTransfersRequest()
            {
                PartnerTradeNo = viewModel.PartnerTradeNo,
                OpenId = viewModel.OpenId,
                CheckName = viewModel.CheckName,
                ReUserName = viewModel.ReUserName,
                Amount = viewModel.Amount,
                Desc = viewModel.Desc,
                SpbillCreateIp = viewModel.SpbillCreateIp
            };
            var response = await _client.ExecuteAsync(request);
            ViewData["response"] = response.Body;
            return View();
        }

        [HttpGet]
        public IActionResult GetTransferInfo()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GetTransferInfo(WeChatPayGetTransferInfoViewModel viewModel)
        {
            var request = new WeChatPayGetTransferInfoRequest()
            {
                PartnerTradeNo = viewModel.PartnerTradeNo,
            };
            var response = await _client.ExecuteAsync(request);
            ViewData["response"] = response.Body;
            return View();
        }

        [HttpGet]
        public IActionResult PayBank()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> PayBank(WeChatPayPayBankViewModel viewModel)
        {
            var request = new WeChatPayPayBankRequest()
            {
                PartnerTradeNo = viewModel.PartnerTradeNo,
                EncBankNo = viewModel.EncBankNo,
                EncTrueName = viewModel.EncTrueName,
                BankCode = viewModel.BankCode,
                Amount = viewModel.Amount,
                Desc = viewModel.Desc,
            };
            var response = await _client.ExecuteAsync(request);
            ViewData["response"] = response.Body;
            return View();
        }

        [HttpGet]
        public IActionResult QueryBank()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> QueryBank(WeChatPayQueryBankViewModel viewModel)
        {
            var request = new WeChatPayQueryBankRequest()
            {
                PartnerTradeNo = viewModel.PartnerTradeNo,
            };
            var response = await _client.ExecuteAsync(request);
            ViewData["response"] = response.Body;
            return View();
        }

        [HttpGet]
        [HttpPost]
        public async Task<IActionResult> GetPublicKey()
        {
            if (Request.Method == "POST")
            {
                var request = new WeChatPayGetPublicKeyRequest();
                var response = await _client.ExecuteAsync(request);
                ViewData["response"] = response.Body;
                return View();
            }
            else
            {
                return View();
            }
        }
    }
}
