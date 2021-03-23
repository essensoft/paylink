using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using Essensoft.Paylink.WeChatPay;
using Essensoft.Paylink.WeChatPay.V3;
using Essensoft.Paylink.WeChatPay.V3.Domain;
using Essensoft.Paylink.WeChatPay.V3.Request;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using WebApplicationSample.Models;

namespace WebApplicationSample.Controllers
{
    public class WeChatPayV3Controller : Controller
    {
        private readonly ILogger<WeChatPayV3Controller> _logger;
        private readonly IWeChatPayClient _client;
        private readonly IOptions<WeChatPayOptions> _optionsAccessor;

        public WeChatPayV3Controller(ILogger<WeChatPayV3Controller> logger, IWeChatPayClient client, IOptions<WeChatPayOptions> optionsAccessor)
        {
            _logger = logger;
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
            var model = new WeChatPayTransactionsAppBodyModel
            {
                AppId = _optionsAccessor.Value.AppId,
                MchId = _optionsAccessor.Value.MchId,
                Amount = new Amount { Total = viewModel.Total, Currency = "CNY" },
                Description = viewModel.Description,
                NotifyUrl = viewModel.NotifyUrl,
                OutTradeNo = viewModel.OutTradeNo,
            };

            var request = new WeChatPayTransactionsAppRequest();
            request.SetBodyModel(model);

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
            var model = new WeChatPayTransactionsJsApiBodyModel
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
            request.SetBodyModel(model);

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
            var model = new WeChatPayTransactionsNativeBodyModel
            {
                AppId = _optionsAccessor.Value.AppId,
                MchId = _optionsAccessor.Value.MchId,
                Amount = new Amount { Total = viewModel.Total, Currency = "CNY" },
                Description = viewModel.Description,
                NotifyUrl = viewModel.NotifyUrl,
                OutTradeNo = viewModel.OutTradeNo,
            };

            var request = new WeChatPayTransactionsNativeRequest();
            request.SetBodyModel(model);

            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);
            if (response.StatusCode == 200)
            {
                // response.CodeUrl 给前端生成二维码
                ViewData["qrcode"] = response.CodeUrl;
            }

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
            var model = new WeChatPayTransactionsH5BodyModel
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
            request.SetBodyModel(model);

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
            var model = new WeChatPayTransactionsIdQueryModel
            {
                MchId = _optionsAccessor.Value.MchId,
            };

            var request = new WeChatPayTransactionsIdRequest
            {
                TransactionId = viewModel.TransactionId
            };

            request.SetQueryModel(model);

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
            var model = new WeChatPayTransactionsOutTradeNoQueryModel
            {
                MchId = _optionsAccessor.Value.MchId,
            };

            var request = new WeChatPayTransactionsOutTradeNoRequest
            {
                OutTradeNo = viewModel.OutTradeNo,
            };

            request.SetQueryModel(model);

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
            var model = new WeChatPayTransactionsOutTradeNoCloseBodyModel
            {
                MchId = _optionsAccessor.Value.MchId,
            };

            var request = new WeChatPayTransactionsOutTradeNoCloseRequest
            {
                OutTradeNo = viewModel.OutTradeNo,
            };

            request.SetBodyModel(model);

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
            var model = new WeChatPayBillTradeBillQueryModel
            {
                BillDate = viewModel.BillDate
            };

            var request = new WeChatPayBillTradeBillRequest();

            request.SetQueryModel(model);

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
            var model = new WeChatPayBillFundflowBillQueryModel
            {
                BillDate = viewModel.BillDate
            };

            var request = new WeChatPayBillFundflowBillRequest();
            request.SetQueryModel(model);

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
            var request = new WeChatPayBillDownloadRequest();
            request.SetRequestUrl(viewModel.DownloadUrl);

            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);

            ViewData["response"] = response.Body;
            return View();
        }

        /// <summary>
        /// 退款申请
        /// </summary>
        [HttpGet]
        public IActionResult Refund()
        {
            return View();
        }

        /// <summary>
        /// 退款申请
        /// </summary>
        /// <param name="viewModel"></param>
        [HttpPost]
        public async Task<IActionResult> Refund(WeChatPayV3RefundViewModel viewModel)
        {
            var model = new WeChatPayRefundDomesticRefundsBodyModel()
            {
                TransactionId = viewModel.TransactionId,
                OutTradeNo = viewModel.OutTradeNo,
                OutRefundNo = viewModel.OutRefundNo,
                NotifyUrl = viewModel.NotifyUrl,
                Amount = new RefundAmount { Refund = viewModel.RefundAmount, Total = viewModel.TotalAmount, Currency = viewModel.Currency }
            };

            var request = new WeChatPayRefundDomesticRefundsRequest();
            request.SetBodyModel(model);

            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);

            ViewData["response"] = response.Body;
            return View();
        }

        /// <summary>
        /// 查询单笔退款
        /// </summary>
        [HttpGet]
        public IActionResult RefundQuery()
        {
            return View();
        }

        /// <summary>
        /// 查询单笔退款
        /// </summary>
        /// <param name="viewModel"></param>
        [HttpPost]
        public async Task<IActionResult> RefundQuery(WeChatPayV3RefundQueryViewModel viewModel)
        {
            var request = new WeChatPayRefundDomesticRefundsOutRefundNoRequest
            {
                OutRefundNo = viewModel.OutRefundNo
            };

            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);

            ViewData["response"] = response.Body;
            return View();
        }

        #region 微信支付分

        /// <summary>
        /// 支付分-创建支付分订单
        /// </summary>
        public IActionResult ServiceOrder()
        {
            return View();
        }

        /// <summary>
        /// 支付分-创建支付分订单
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> ServiceOrder(WeChatPayScoreServiceOrderViewModel viewModel)
        {
            var model = new WeChatPayScoreServiceOrderBodyModel
            {
                AppId = _optionsAccessor.Value.AppId,
                ServiceId = viewModel.ServiceId,
                OutOrderNo = viewModel.OutOrderNo,
                ServiceIntroduction = viewModel.ServiceIntroduction,
                TimeRange = new TimeRange
                {
                    StartTime = viewModel.StartTime,
                    EndTime = viewModel.EndTime
                },
                RiskFund = new RiskFund
                {
                    Name = viewModel.RiskFundName,
                    Amount = viewModel.RiskFundAmount
                },
                NotifyUrl = viewModel.NotifyUrl,
                OpenId = viewModel.OpenId
            };

            var request = new WeChatPayScoreServiceOrderRequest();
            request.SetBodyModel(model);

            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);
            ViewData["response"] = response.Body;
            return View();
        }

        /// <summary>
        /// 支付分-查询支付分订单
        /// </summary>
        public IActionResult ServiceOrderQuery()
        {
            return View();
        }

        /// <summary>
        /// 支付分-查询支付分订单
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> ServiceOrderQuery(WeChatPayScoreServiceOrderQueryViewModel viewModel)
        {
            var model = new WeChatPayScoreServiceOrderQueryModel
            {
                AppId = _optionsAccessor.Value.AppId,
                ServiceId = viewModel.ServiceId,
                OutOrderNo = viewModel.OutOrderNo,
                QueryId = viewModel.QueryId
            };

            var request = new WeChatPayScoreServiceOrderQueryRequest();
            request.SetQueryModel(model);

            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);
            ViewData["response"] = response.Body;
            return View();
        }

        /// <summary>
        /// 支付分-取消支付分订单
        /// </summary>
        public IActionResult ServiceOrderCancel()
        {
            return View();
        }

        /// <summary>
        /// 支付分-取消支付分订单
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> ServiceOrderCancel(WeChatPayScoreServiceOrderCancelViewModel viewModel)
        {
            var model = new WeChatPayScoreServiceOrderOutOrderNoCancelBodyModel
            {
                AppId = _optionsAccessor.Value.AppId,
                ServiceId = viewModel.ServiceId,
                Reason = viewModel.Reason
            };

            var request = new WeChatPayScoreServiceOrderOutOrderNoCancelRequest
            {
                OutOrderNo = viewModel.OutOrderNo
            };
            request.SetBodyModel(model);

            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);
            ViewData["response"] = response.Body;
            return View();
        }

        /// <summary>
        /// 支付分-修改支付分订单金额
        /// </summary>
        public IActionResult ServiceOrderModify()
        {
            return View();
        }

        /// <summary>
        /// 支付分-修改支付分订单金额
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> ServiceOrderModify(WeChatPayScoreServiceOrderModifyViewModel viewModel)
        {
            var model = new WeChatPayScoreServiceOrderOutOrderNoModifyBodyModel
            {
                AppId = _optionsAccessor.Value.AppId,
                ServiceId = viewModel.ServiceId,
                PostPayments = new List<PostPayment> {
                   new PostPayment{
                       Name = viewModel.Name,
                       Amount = viewModel.Amount,
                       Count = viewModel.Count
                   }
                },
                TotalAmount = viewModel.TotalAmount,
                Reason = viewModel.Reason
            };

            var request = new WeChatPayScoreServiceOrderOutOrderNoModifyRequest
            {
                OutOrderNo = viewModel.OutOrderNo
            };
            request.SetBodyModel(model);

            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);
            ViewData["response"] = response.Body;
            return View();
        }

        /// <summary>
        /// 支付分-完结支付分订单
        /// </summary>
        public IActionResult ServiceOrderComplete()
        {
            return View();
        }

        /// <summary>
        /// 支付分-完结支付分订单
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> ServiceOrderComplete(WeChatPayScoreServiceOrderCompleteViewModel viewModel)
        {
            var model = new WeChatPayScoreServiceOrderOutOrderNoCompleteBodyModel
            {
                AppId = _optionsAccessor.Value.AppId,
                ServiceId = viewModel.ServiceId,
                PostPayments = new List<PostPayment>
                {
                   new PostPayment
                   {
                       Name = viewModel.Name,
                       Amount = viewModel.Amount,
                       Count = viewModel.Count
                   }
                },
                TotalAmount = viewModel.TotalAmount
            };

            var request = new WeChatPayScoreServiceOrderOutOrderNoCompleteRequest
            {
                OutOrderNo = viewModel.OutOrderNo
            };
            request.SetBodyModel(model);

            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);
            ViewData["response"] = response.Body;
            return View();
        }

        /// <summary>
        /// 支付分-商户发起催收扣款
        /// </summary>
        public IActionResult ServiceOrderPay()
        {
            return View();
        }

        /// <summary>
        /// 支付分-商户发起催收扣款
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> ServiceOrderPay(WeChatPayScoreServiceOrderPayViewModel viewModel)
        {
            var model = new WeChatPayScoreServiceOrderPayBodyModel
            {
                AppId = _optionsAccessor.Value.AppId,
                ServiceId = viewModel.ServiceId,
            };

            var request = new WeChatPayScoreServiceOrderPayRequest
            {
                OutOrderNo = viewModel.OutOrderNo
            };
            request.SetBodyModel(model);

            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);
            ViewData["response"] = response.Body;
            return View();
        }

        /// <summary>
        /// 支付分-同步服务订单信息
        /// </summary>
        public IActionResult ServiceOrderSync()
        {
            return View();
        }

        /// <summary>
        /// 支付分-同步服务订单信息
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> ServiceOrderSync(WeChatPayScoreServiceOrderSyncViewModel viewModel)
        {
            var model = new WeChatPayScoreServiceOrderSyncBodyModel
            {
                AppId = _optionsAccessor.Value.AppId,
                ServiceId = viewModel.ServiceId,
                Type = viewModel.Type,
                Detail = new SyncDetail
                {
                    PaidTime = viewModel.PaidTime
                }
            };

            var request = new WeChatPayScoreServiceOrderSyncRequest
            {
                OutOrderNo = viewModel.OutOrderNo
            };
            request.SetBodyModel(model);

            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);
            ViewData["response"] = response.Body;
            return View();
        }

        /// <summary>
        /// 支付分-创单结单合并
        /// </summary>
        public IActionResult ServiceOrderDirectComplete()
        {
            return View();
        }

        /// <summary>
        /// 支付分-创单结单合并
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> ServiceOrderDirectComplete(WeChatPayScoreServiceOrderDirectCompleteViewModel viewModel)
        {
            var model = new WeChatPayScoreServiceOrderDirectCompleteBodyModel
            {
                AppId = _optionsAccessor.Value.AppId,
                ServiceId = viewModel.ServiceId,
                OutOrderNo = viewModel.OutOrderNo,
                ServiceIntroduction = viewModel.ServiceIntroduction,
                PostPayments = new List<PostPayment> {
                   new PostPayment{
                       Name = viewModel.PostPaymentName,
                       Amount = viewModel.PostPaymentAmount,
                       Description = viewModel.PostPaymentDescription,
                       Count = viewModel.PostPaymentCount
                   }
                },
                TimeRange = new TimeRange
                {
                    StartTime = viewModel.StartTime,
                    EndTime = viewModel.EndTime
                },
                TotalAmount = viewModel.TotalAmount,
                NotifyUrl = viewModel.NotifyUrl,
                OpenId = viewModel.OpenId
            };

            var request = new WeChatPayScoreServiceOrderDirectCompleteRequest();
            request.SetBodyModel(model);

            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);
            ViewData["response"] = response.Body;
            return View();
        }

        /// <summary>
        /// 支付分-商户预授权
        /// </summary>
        public IActionResult Permissions()
        {
            return View();
        }

        /// <summary>
        /// 支付分-商户预授权
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> Permissions(PermissionsViewModel viewModel)
        {
            var model = new WeChatPayScorePermissionsBodyModel
            {
                AppId = _optionsAccessor.Value.AppId,
                ServiceId = viewModel.ServiceId,
                AuthorizationCode = viewModel.AuthorizationCode,
                NotifyUrl = viewModel.NotifyUrl
            };

            var request = new WeChatPayScorePermissionsRequest();
            request.SetBodyModel(model);

            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);
            ViewData["response"] = response.Body;
            return View();
        }

        /// <summary>
        /// 支付分-查询用户授权记录（授权协议号）
        /// </summary>
        public IActionResult PermissionsQueryForAuthCode()
        {
            return View();
        }

        /// <summary>
        /// 支付分-查询用户授权记录（授权协议号）
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> PermissionsQueryForAuthCode(PermissionsQueryForAuthCodeViewModel viewModel)
        {
            var model = new WeChatPayScorePermissionsQueryForAuthCodeQueryModel
            {
                ServiceId = viewModel.ServiceId,
            };

            var request = new WeChatPayScorePermissionsQueryForAuthCodeRequest
            {
                AuthorizationCode = viewModel.AuthorizationCode
            };
            request.SetQueryModel(model);

            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);
            ViewData["response"] = response.Body;
            return View();
        }

        /// <summary>
        /// 支付分-解除用户授权关系（授权协议号）
        /// </summary>
        public IActionResult PermissionsTerminateForAuthCode()
        {
            return View();
        }

        /// <summary>
        /// 支付分-解除用户授权关系（授权协议号）
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> PermissionsTerminateForAuthCode(PermissionsTerminateForAuthCodeViewModel viewModel)
        {
            var model = new WeChatPayScorePermissionsTerminateForAuthCodeBodyModel
            {
                ServiceId = viewModel.ServiceId,
                Reason = viewModel.Reason
            };

            var request = new WeChatPayScorePermissionsTerminateForAuthCodeRequest
            {
                AuthorizationCode = viewModel.AuthorizationCode
            };
            request.SetBodyModel(model);

            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);
            ViewData["response"] = response.Body;
            return View();
        }

        /// <summary>
        /// 支付分-查询用户授权记录（openid）
        /// </summary>
        public IActionResult PermissionsQueryForOpenId()
        {
            return View();
        }

        /// <summary>
        /// 支付分-查询用户授权记录（openid）
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> PermissionsQueryForOpenId(PermissionsQueryForOpenIdViewModel viewModel)
        {
            var model = new WeChatPayScorePermissionsQueryForOpenIdQueryModel
            {
                AppId = _optionsAccessor.Value.AppId,
                ServiceId = viewModel.ServiceId,
            };

            var request = new WeChatPayScorePermissionsQueryForOpenIdRequest
            {
                OpenId = viewModel.OpenId
            };
            request.SetQueryModel(model);

            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);
            ViewData["response"] = response.Body;
            return View();
        }

        /// <summary>
        /// 支付分-解除用户授权关系（OpenId）
        /// </summary>
        public IActionResult PermissionsTerminateForOpenId()
        {
            return View();
        }

        /// <summary>
        /// 支付分-解除用户授权关系（OpenId）
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> PermissionsTerminateForOpenId(PermissionsTerminateForOpenIdViewModel viewModel)
        {
            var model = new WeChatPayScorePermissionsTerminateForOpenIdBodyModel
            {
                AppId = _optionsAccessor.Value.AppId,
                ServiceId = viewModel.ServiceId,
                Reason = viewModel.Reason
            };

            var request = new WeChatPayScorePermissionsTerminateForOpenIdRequest
            {
                OpenId = viewModel.OpenId
            };
            request.SetBodyModel(model);

            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);
            ViewData["response"] = response.Body;
            return View();
        }

        #endregion
    }
}
