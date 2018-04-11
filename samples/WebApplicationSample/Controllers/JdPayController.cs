using Essensoft.AspNetCore.Payment.JDPay;
using Essensoft.AspNetCore.Payment.JDPay.Notify;
using Essensoft.AspNetCore.Payment.JDPay.Request;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebApplicationSample.Controllers
{
    public class JDPayController : Controller
    {
        private readonly JDPayClient _client = null;
        private readonly JDPayNotifyClient _notifyClient = null;

        public JDPayController(JDPayClient client, JDPayNotifyClient notifyClient)
        {
            _client = client;
            _notifyClient = notifyClient;
        }

        [HttpPost]
        public async Task<IActionResult> SaveOrderPC(string tradeNum, string tradeName, string tradeDesc, string tradeTime, string amount, string orderType, string currency, string note, string callbackUrl, string notifyUrl, string tradeType)
        {
            var request = new JDPaySaveOrderPCRequest()
            {
                TradeNum = tradeNum,
                TradeName = tradeName,
                TradeDesc = tradeDesc,
                TradeTime = tradeTime,
                Amount = amount,
                OrderType = orderType,
                Currency = currency,
                Note = note,
                CallbackUrl = callbackUrl,
                NotifyUrl = notifyUrl,
            };

            var response = await _client.PageExecuteAsync(request, "POST");
            return Content(response.Body, "text/html");
        }

        [HttpPost]
        public async Task<IActionResult> SaveOrderH5(string tradeNum, string tradeName, string tradeDesc, string tradeTime, string amount, string orderType, string currency, string note, string callbackUrl, string notifyUrl, string tradeType)
        {
            var request = new JDPaySaveOrderH5Request()
            {
                TradeNum = tradeNum,
                TradeName = tradeName,
                TradeDesc = tradeDesc,
                TradeTime = tradeTime,
                Amount = amount,
                OrderType = orderType,
                Currency = currency,
                Note = note,
                CallbackUrl = callbackUrl,
                NotifyUrl = notifyUrl,
            };

            var response = await _client.PageExecuteAsync(request, "POST");
            return Content(response.Body, "text/html");
        }

        [HttpPost]
        public async Task<IActionResult> Uniorder(string tradeNum, string tradeName, string tradeDesc, string tradeTime, string amount,
            string orderType, string currency, string note, string notifyUrl, string tradeType)
        {
            var request = new JDPayUnifiedOrderRequest()
            {
                TradeNum = tradeNum,
                TradeName = tradeName,
                TradeDesc = tradeDesc,
                TradeTime = tradeTime,
                Amount = amount,
                OrderType = orderType,
                Currency = currency,
                Note = note,
                NotifyUrl = notifyUrl,
                TradeType = tradeType
            };

            var response = await _client.ExecuteAsync(request);
            return Content(response.Body);
        }

        [HttpPost]
        public async Task<IActionResult> OrderQuery(string tradeNum, string oTradeNum)
        {
            var request = new JDPayOrderQueryRequest()
            {
                TradeNum = tradeNum,
                OTradeNum = oTradeNum
            };

            var response = await _client.ExecuteAsync(request);
            return Content(response.Body);
        }

        [HttpPost]
        public async Task<IActionResult> Refund(string tradeNum, string oTradeNum, long amount, string currency, string notifyUrl)
        {
            var request = new JDPayRefundRequest()
            {
                TradeNum = tradeNum,
                OTradeNum = oTradeNum,
                Amount = amount,
                Currency = currency,
                NotifyUrl = notifyUrl
            };

            var response = await _client.ExecuteAsync(request);
            return Content(response.Body);
        }

        [HttpPost]
        public async Task<IActionResult> RefundQuery(string tradeNum, string oTradeNum)
        {
            var request = new JDPayQueryRefundRequest()
            {
                TradeNum = tradeNum,
                OTradeNum = oTradeNum
            };

            var response = await _client.ExecuteAsync(request);
            return Content(response.Body);
        }

        [HttpGet]  // h5 get
        [HttpPost] // pc post
        public async Task<IActionResult> Return()
        {
            try
            {
                var notify = await _notifyClient.ExecuteAsync<JDPaySyncReturnResponse>(Request);
                return Content("success", "text/plain");
            }
            catch
            {
                return Content("error", "text/plain");
            }
        }
    }
}
