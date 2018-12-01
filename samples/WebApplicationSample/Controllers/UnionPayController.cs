using System.Threading.Tasks;
using Essensoft.AspNetCore.Payment.UnionPay;
using Essensoft.AspNetCore.Payment.UnionPay.Notify;
using Essensoft.AspNetCore.Payment.UnionPay.Request;
using Microsoft.AspNetCore.Mvc;
using WebApplicationSample.Models;

namespace WebApplicationSample.Controllers
{
    public class UnionPayController : Controller
    {
        private readonly IUnionPayClient _client;
        private readonly IUnionPayNotifyClient _notifyClient;

        public UnionPayController(IUnionPayClient client, IUnionPayNotifyClient notifyClient)
        {
            _client = client;
            _notifyClient = notifyClient;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GatewayPayFrontConsume()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GatewayPayFrontConsume(GatewayPayFrontConsumeFrontConsumeViewModel viewModel)
        {
            var request = new UnionPayGatewayPayFrontConsumeRequest
            {
                TxnType = "01",
                TxnSubType = "01",
                BizType = "000201",
                ChannelType = "07",
                OrderId = viewModel.OrderId,
                TxnTime = viewModel.TxnTime,
                TxnAmt = viewModel.TxnAmt,
                CurrencyCode = viewModel.CurrencyCode,
                PayTimeOut = viewModel.PayTimeOut,
                FrontUrl = viewModel.FrontUrl,
                BackUrl = viewModel.BackUrl
            };
            var response = await _client.PageExecuteAsync(request);
            return Content(response.Body, "text/html;charset=utf-8");
        }

        [HttpPost]
        public async Task<IActionResult> GatewayPayFrontConsumeReturn()
        {
            try
            {
                var notify = await _notifyClient.ExecuteAsync<UnionPayGatewayPayFrontConsumeReturnResponse>(Request);
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