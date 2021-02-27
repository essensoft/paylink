using System;
using System.Threading.Tasks;
using Essensoft.AspNetCore.Payment.WeChatPay;
using Essensoft.AspNetCore.Payment.WeChatPay.Payscore;
using Essensoft.AspNetCore.Payment.WeChatPay.Payscore.Notify;
using Essensoft.AspNetCore.Payment.WeChatPay.V3;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace WebApplicationSample.Controllers
{
    [Route("wechatpay/score/notify")]
    public class WeChatPayScoreNotifyController : Controller
    {
        private readonly IWeChatPayNotifyClient _client;
        private readonly IOptions<WeChatPayOptions> _optionsAccessor;

        public WeChatPayScoreNotifyController(IWeChatPayNotifyClient client, IOptions<WeChatPayOptions> optionsAccessor)
        {
            _client = client;
            _optionsAccessor = optionsAccessor;
        }

        /// <summary>
        /// 开启/解除授权服务回调通知
        /// </summary>
        [Route("Permissions")]
        [HttpPost]
        public async Task<IActionResult> Permissions()
        {
            try
            {
                var notify = await _client.ExecuteAsync<WeChatPayScorePermissionsOpenOrCancelNotify>(Request, _optionsAccessor.Value);
                if (notify.UserServiceStatus == WeChatPayScoreUserServiceStatus.Opened ||
                    notify.UserServiceStatus == WeChatPayScoreUserServiceStatus.Closed)
                {
                    Console.WriteLine("Permissions body: " + notify.Body);
                    return WeChatPayNotifyResult.Success;
                }

                return WeChatPayNotifyResult.Failure;
            }
            catch (WeChatPayException ex)
            {
                Console.WriteLine("出现异常: " + ex.Message);
                return WeChatPayNotifyResult.Failure;
            }
        }

        /// <summary>
        /// 确认订单回调通知
        /// </summary>
        [Route("orderconfirm")]
        [HttpPost]
        public async Task<IActionResult> ServiceOrderConfirm()
        {
            try
            {
                var notify = await _client.ExecuteAsync<WeChatPayScoreServiceOrderConfirmNotify>(Request, _optionsAccessor.Value);
                if (notify.State == ServiceOrderState.Doing)
                {
                    Console.WriteLine("ServiceOrderConfirm body: " + notify.Body);
                    return WeChatPayNotifyResult.Success;
                }

                return WeChatPayNotifyResult.Failure;
            }
            catch (WeChatPayException ex)
            {
                Console.WriteLine("出现异常: " + ex.Message);
                return WeChatPayNotifyResult.Failure;
            }
        }

        /// <summary>
        /// 订单支付成功回调通知
        /// </summary>
        [Route("orderpaid")]
        [HttpPost]
        public async Task<IActionResult> ServiceOrderPaid()
        {
            try
            {
                var notify = await _client.ExecuteAsync<WeChatPayScoreServiceOrderPaidNotify>(Request, _optionsAccessor.Value);
                if (notify.State == ServiceOrderState.Done)
                {
                    Console.WriteLine("ServiceOrderPaid body: " + notify.Body);
                    return WeChatPayNotifyResult.Success;
                }

                return WeChatPayNotifyResult.Failure;
            }
            catch (WeChatPayException ex)
            {
                Console.WriteLine("出现异常: " + ex.Message);
                return WeChatPayNotifyResult.Failure;
            }
        }

        /// <summary>
        /// 订单 确认 或 支付成功 回调通知
        /// </summary>
        [Route("confirmorpaid")]
        [HttpPost]
        public async Task<IActionResult> ServiceOrderConfirmOrPaid()
        {
            try
            {
                var notify = await _client.ExecuteAsync<WeChatPayScoreServiceOrderPaidNotify>(Request, _optionsAccessor.Value);
                if (notify.State == ServiceOrderState.Doing || notify.State == ServiceOrderState.Done)
                {
                    Console.WriteLine("ServiceOrderConfirmOrPaid body: " + notify.Body);
                    return WeChatPayNotifyResult.Success;
                }

                return WeChatPayNotifyResult.Failure;
            }
            catch (WeChatPayException ex)
            {
                Console.WriteLine("出现异常: " + ex.Message);
                return WeChatPayNotifyResult.Failure;
            }
        }
    }
}
