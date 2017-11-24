using Microsoft.AspNetCore.Mvc;
using Essensoft.AspNetCore.JdPay.Request;
using Essensoft.AspNetCore.JdPay;
using System.Threading.Tasks;

namespace WebApplicationSample.Controllers
{
    public class JdPayController : Controller
    {
        public readonly JdPayClient _client = null;

        public JdPayController(JdPayClient client)
        {
            _client = client;
        }

        [HttpPost]
        public async Task<IActionResult> Uniorder(string tradeNum, string tradeName, string tradeDesc, string tradeTime, string amount,
            string orderType, string currency, string note, string notifyUrl, string tradeType)
        {
            var request = new JdPayUnifiedOrderRequest()
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
            var request = new JdPayOrderQueryRequest()
            {
                TradeNum = tradeNum,
                OTradeNum = oTradeNum
            };

            var response = await _client.ExecuteAsync(request);
            return Content(response.Body);
        }

        [HttpPost]
        public async Task<IActionResult> Refund(string tradeNum, string oTradeNum, long amount, string currency)
        {
            var request = new JdPayRefundRequest()
            {
                TradeNum = tradeNum,
                OTradeNum = oTradeNum,
                Amount = amount,
                Currency = currency,
            };

            var response = await _client.ExecuteAsync(request);
            return Content(response.Body);
        }

        [HttpPost]
        public async Task<IActionResult> RefundQuery(string tradeNum, string oTradeNum)
        {
            var request = new JdPayRefundQueryRequest()
            {
                TradeNum = tradeNum,
                OTradeNum = oTradeNum
            };

            var response = await _client.ExecuteAsync(request);
            return Content(response.Body);
        }
    }
}
