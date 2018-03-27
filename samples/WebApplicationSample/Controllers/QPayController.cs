using Essensoft.AspNetCore.Payment.QPay;
using Essensoft.AspNetCore.Payment.QPay.Request;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebApplicationSample.Controllers
{
    public class QPayController : Controller
    {
        private readonly QPayClient _client = null;
        private readonly QPayCertificateClient _certClient = null;
        public QPayController(QPayClient client, QPayCertificateClient certClient)
        {
            _client = client;
            _certClient = certClient;
        }

        [HttpPost]
        public async Task<IActionResult> UnifiedOrder(string out_trade_no, string body, int total_fee, string spbill_create_ip, string notify_url, string trade_type)
        {
            var request = new QPayUnifiedOrderRequest()
            {
                OutTradeNo = out_trade_no,
                Body = body,
                TotalFee = total_fee,
                SpbillCreateIp = spbill_create_ip,
                NotifyUrl = notify_url,
                TradeType = trade_type,
            };
            var response = await _client.ExecuteAsync(request);
            return Ok(response.Body);
        }

        [HttpPost]
        public async Task<IActionResult> OrderQuery(string transaction_id, string out_trade_no)
        {
            var request = new QPayOrderQueryRequest()
            {
                TransactionId = transaction_id,
                OutTradeNo = out_trade_no,
            };
            var response = await _client.ExecuteAsync(request);
            return Ok(response.Body);
        }

        [HttpPost]
        public async Task<IActionResult> CloseOrder(string out_trade_no)
        {
            var request = new QPayCloseOrderRequest()
            {
                OutTradeNo = out_trade_no,
            };
            var response = await _client.ExecuteAsync(request);
            return Ok(response.Body);
        }

        [HttpPost]
        public async Task<IActionResult> Refund(string out_refund_no, string transaction_id, string out_trade_no, int refund_fee, string op_user_id, string op_user_passwd)
        {
            var request = new QPayRefundRequest()
            {
                OutRefundNo = out_refund_no,
                TransactionId = transaction_id,
                OutTradeNo = out_trade_no,
                RefundFee = refund_fee,
                OpUserId = op_user_id,
                OpUserPasswd = op_user_passwd,
            };
            var response = await _certClient.ExecuteAsync(request);
            return Ok(response.Body);
        }

        [HttpPost]
        public async Task<IActionResult> RefundQuery(string refund_id, string out_refund_no, string transaction_id, string out_trade_no)
        {
            var request = new QPayRefundQueryRequest()
            {
                RefundId = refund_id,
                OutRefundNo = out_refund_no,
                TransactionId = transaction_id,
                OutTradeNo = out_trade_no,
            };
            var response = await _client.ExecuteAsync(request);
            return Ok(response.Body);
        }
    }
}
