using System.Collections.Generic;
using System.Threading.Tasks;
using Essensoft.AspNetCore.Payment.WeChatPay;
using Essensoft.AspNetCore.Payment.WeChatPay.Payscore.Domain;
using Essensoft.AspNetCore.Payment.WeChatPay.Payscore.Request;
using Essensoft.AspNetCore.Payment.WeChatPay.V3;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WebApplicationSample.Models;

namespace WebApplicationSample.Controllers
{
    public class WeChatPayScoreController : Controller
    {
        private readonly IWeChatPayClient _client;
        private readonly IOptions<WeChatPayOptions> _optionsAccessor;

        public WeChatPayScoreController(IWeChatPayClient client, IOptions<WeChatPayOptions> optionsAccessor)
        {
            _client = client;
            _optionsAccessor = optionsAccessor;
        }

        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 创建支付分订单
        /// </summary>
        public IActionResult ServiceOrder()
        {
            return View();
        }

        /// <summary>
        /// 创建支付分订单
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> ServiceOrder(WeChatPayScoreServiceOrderViewModel viewModel)
        {
            var model = new WeChatPayScoreServiceOrderModel
            {
                AppId = _optionsAccessor.Value.AppId,
                ServiceId = _optionsAccessor.Value.PayScoreServiceId,
                OutOrderNo = viewModel.OutOrderNo,
                ServiceIntroduction = viewModel.ServiceIntroduction,
                TimeRange = new TimeRange {
                    StartTime = viewModel.StartTime,
                    EndTime = viewModel.EndTime
                },
                RiskFund = new RiskFund {
                    Name = viewModel.RiskFundName,
                    Amount = viewModel.RiskFundAmount
                },
                NotifyUrl = viewModel.NotifyUrl,
                OpenId = viewModel.OpenId
            };
            var request = new WeChatPayScoreServiceOrderRequest();
            request.SetBodyModel(model);
            var response =await _client.ExecuteAsync(request, _optionsAccessor.Value);
            ViewData["response"] = response.Body;
            return View();
        }

        /// <summary>
        /// 查询支付分订单
        /// </summary>
        public IActionResult ServiceOrderQuery()
        {
            return View();
        }

        /// <summary>
        /// 查询支付分订单
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> ServiceOrderQuery(WeChatPayScoreServiceOrderQueryViewModel viewModel)
        {
            var model = new WeChatPayScoreServiceOrderQueryModel
            {
                AppId = _optionsAccessor.Value.AppId,
                ServiceId = _optionsAccessor.Value.PayScoreServiceId,
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
        /// 取消支付分订单
        /// </summary>
        public IActionResult ServiceOrderCancel()
        {
            return View();
        }

        /// <summary>
        /// 取消支付分订单
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> ServiceOrderCancel(WeChatPayScoreServiceOrderCancelViewModel viewModel)
        {
            var model = new WeChatPayScoreServiceOrderCancelModel
            {
                AppId = _optionsAccessor.Value.AppId,
                ServiceId = _optionsAccessor.Value.PayScoreServiceId,
                Reason = viewModel.Reason
            };
            var request = new WeChatPayScoreServiceOrderCancelRequest();
            request.OutOrderNo = viewModel.OutOrderNo;
            request.SetBodyModel(model);
            var response = await _client.ExecuteAsync(request,_optionsAccessor.Value);
            ViewData["response"] = response.Body;
            return View();
        }

        /// <summary>
        /// 修改支付分订单金额
        /// </summary>
        public IActionResult ServiceOrderModify()
        {
            return View();
        }

        /// <summary>
        /// 修改支付分订单金额
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> ServiceOrderModify(WeChatPayScoreServiceOrderModifyViewModel viewModel)
        {
            var model = new WeChatPayScoreServiceOrderModifyModel
            {
                AppId = _optionsAccessor.Value.AppId,
                ServiceId = _optionsAccessor.Value.PayScoreServiceId,                
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
            var request = new WeChatPayScoreServiceOrderModifyRequest();
            request.OutOrderNo = viewModel.OutOrderNo;
            request.SetBodyModel(model);
            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);
            ViewData["response"] = response.Body;
            return View();
        }

        /// <summary>
        /// 完结支付分订单
        /// </summary>
        public IActionResult ServiceOrderComplete()
        {
            return View();
        }

        /// <summary>
        /// 完结支付分订单
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> ServiceOrderComplete(WeChatPayScoreServiceOrderCompleteViewModel viewModel)
        {
            var model = new WeChatPayScoreServiceOrderCompleteModel
            {
                AppId = _optionsAccessor.Value.AppId,
                ServiceId = _optionsAccessor.Value.PayScoreServiceId,
                PostPayments = new List<PostPayment> {
                   new PostPayment{
                       Name = viewModel.Name,
                       Amount = viewModel.Amount,
                       Count = viewModel.Count
                   }
                },
                TotalAmount = viewModel.TotalAmount
            };
            var request = new WeChatPayScoreServiceOrderCompleteRequest();
            request.OutOrderNo = viewModel.OutOrderNo;
            request.SetBodyModel(model);
            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);
            ViewData["response"] = response.Body;
            return View();
        }

        /// <summary>
        /// 商户发起催收扣款
        /// </summary>
        public IActionResult ServiceOrderPay()
        {
            return View();
        }

        /// <summary>
        /// 商户发起催收扣款
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> ServiceOrderPay(WeChatPayScoreServiceOrderPayViewModel viewModel)
        {
            var model = new WeChatPayScoreServiceOrderPayModel
            {
                AppId = _optionsAccessor.Value.AppId,
                ServiceId = _optionsAccessor.Value.PayScoreServiceId
            };
            var request = new WeChatPayScoreServiceOrderPayRequest();
            request.OutOrderNo = viewModel.OutOrderNo;
            request.SetBodyModel(model);
            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);
            ViewData["response"] = response.Body;
            return View();
        }

        /// <summary>
        /// 同步服务订单信息
        /// </summary>
        public IActionResult ServiceOrderSync()
        {
            return View();
        }

        /// <summary>
        /// 同步服务订单信息
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> ServiceOrderSync(WeChatPayScoreServiceOrderSyncViewModel viewModel)
        {
            var model = new WeChatPayScoreServiceOrderSyncModel
            {
                AppId = _optionsAccessor.Value.AppId,
                ServiceId = _optionsAccessor.Value.PayScoreServiceId,
                Type = viewModel.Type,
                Detail = new SyncDetail {
                    PaidTime = viewModel.PaidTime
                }
            };
            var request = new WeChatPayScoreServiceOrderSyncRequest();
            request.OutOrderNo = viewModel.OutOrderNo;
            request.SetBodyModel(model);
            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);
            ViewData["response"] = response.Body;
            return View();
        }

        /// <summary>
        /// 创单结单合并
        /// </summary>
        public IActionResult ServiceOrderDirectComplete()
        {
            return View();
        }

        /// <summary>
        /// 创单结单合并
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> ServiceOrderDirectComplete(WeChatPayScoreServiceOrderDirectCompleteViewModel viewModel)
        {
            var model = new WeChatPayScoreServiceOrderDirectCompleteModel
            {
                AppId = _optionsAccessor.Value.AppId,
                ServiceId = _optionsAccessor.Value.PayScoreServiceId,
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
        /// 商户预授权
        /// </summary>
        public IActionResult Permissions()
        {
            return View();
        }

        /// <summary>
        /// 商户预授权
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> Permissions(PermissionsViewModel viewModel)
        {
            var model = new WeChatPayScorePermissionsModel
            {
                AppId = _optionsAccessor.Value.AppId,
                ServiceId = _optionsAccessor.Value.PayScoreServiceId,
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
            var model = new WeChatPayScorePermissionsQueryForAuthCodeModel
            {
                ServiceId = _optionsAccessor.Value.PayScoreServiceId
            };
            
            var request = new WeChatPayScorePermissionsQueryForAuthCodeRequest();
            request.AuthorizationCode = viewModel.AuthorizationCode;
            request.SetQueryModel(model);
            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);
            ViewData["response"] = response.Body;
            return View();
        }

        /// <summary>
        /// 解除用户授权关系（授权协议号）
        /// </summary>
        public IActionResult PermissionsTerminateForAuthCode()
        {
            return View();
        }

        /// <summary>
        /// 解除用户授权关系（授权协议号）
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> PermissionsTerminateForAuthCode(PermissionsTerminateForAuthCodeViewModel viewModel)
        {
            var model = new WeChatPayScorePermissionsTerminateForAuthCodeModel
            {                
                ServiceId = _optionsAccessor.Value.PayScoreServiceId,
                Reason  = viewModel.Reason
            };
            var request = new WeChatPayScorePermissionsTerminateForAuthCodeRequest();
            request.AuthorizationCode = viewModel.AuthorizationCode;
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
            var model = new WeChatPayScorePermissionsQueryForOpenIdModel
            {
                AppId = _optionsAccessor.Value.AppId,
                ServiceId = _optionsAccessor.Value.PayScoreServiceId
            };
            var request = new WeChatPayScorePermissionsQueryForOpenIdRequest();
            request.OpenId = viewModel.OpenId;
            request.SetQueryModel(model);
            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);
            ViewData["response"] = response.Body;
            return View();
        }

        /// <summary>
        /// 解除用户授权关系（OpenId）
        /// </summary>
        public IActionResult PermissionsTerminateForOpenId()
        {
            return View();
        }

        /// <summary>
        /// 解除用户授权关系（OpenId）
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> PermissionsTerminateForOpenId(PermissionsTerminateForOpenIdViewModel viewModel)
        {
            var model = new WeChatPayScorePermissionsTerminateForOpenIdModel
            {
                AppId = _optionsAccessor.Value.AppId,
                ServiceId = _optionsAccessor.Value.PayScoreServiceId,
                Reason = viewModel.Reason
            };
            var request = new WeChatPayScorePermissionsTerminateForOpenIdRequest();
            request.OpenId = viewModel.OpenID;
            request.SetBodyModel(model);
            var response = await _client.ExecuteAsync(request, _optionsAccessor.Value);
            ViewData["response"] = response.Body;
            return View();
        }
    }
}
