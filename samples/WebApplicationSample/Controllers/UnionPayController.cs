using Essensoft.AspNetCore.UnionPay;
using Essensoft.AspNetCore.UnionPay.Notify;
using Essensoft.AspNetCore.UnionPay.Request;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebApplicationSample.Controllers
{
    public class UnionPayController : Controller
    {
        public readonly UnionPayClient _client = null;
        public readonly UnionPayNotifyClient _notifyClient = null;

        public UnionPayController(UnionPayClient client, UnionPayNotifyClient notifyClient)
        {
            _client = client;
            _notifyClient = notifyClient;
        }

        [HttpPost]
        public async Task<IActionResult> AppConsume(string orderId, string qrNo, string txnTime, string txnAmt, string currencyCode, string backUrl)
        {
            var request = new UnionPayForm05_6_2_AppConsumeRequest()
            {
                OrderId = orderId,
                QrNo = qrNo,
                TxnTime = txnTime,
                TxnAmt = txnAmt,
                BackUrl = backUrl,
                CurrencyCode = currencyCode
            };
            var response = await _client.ExecuteAsync(request);
            return Ok(response.Body);
        }

        [HttpPost]
        public async Task<IActionResult> ApplyQrCode(string orderId, string txnTime, string txnAmt, string currencyCode, string backUrl)
        {
            var request = new UnionPayForm05_6_1_ApplyQrCodeRequest()
            {
                OrderId = orderId,
                TxnTime = txnTime,
                TxnAmt = txnAmt,
                BackUrl = backUrl,
                CurrencyCode = currencyCode
            };
            var response = await _client.ExecuteAsync(request);
            return Ok(response.Body);
        }

        [HttpPost]
        public async Task<IActionResult> PurchaseUndo(string orderId, string txnTime, string txnAmt, string origQryId, string origOrderId, string origTxnTime, string backUrl)
        {
            var request = new UnionPayPurchaseUndoRequest()
            {
                OrderId = orderId,
                TxnTime = txnTime,
                TxnAmt = txnAmt,
                OrigQryId = origQryId,
                OrigOrderId = origOrderId,
                OrigTxnTime = origTxnTime,
                BackUrl = backUrl,
            };
            var response = await _client.ExecuteAsync(request);
            return Ok(response.Body);
        }

        [HttpPost]
        public async Task<IActionResult> Refund(string orderId, string txnTime, string txnAmt, string origQryId, string origOrderId, string origTxnTime, string backUrl)
        {
            var request = new UnionPayRefundRequest()
            {
                OrderId = orderId,
                TxnTime = txnTime,
                TxnAmt = txnAmt,
                OrigQryId = origQryId,
                OrigOrderId = origOrderId,
                OrigTxnTime = origTxnTime,
                BackUrl = backUrl,
            };
            var response = await _client.ExecuteAsync(request);
            return Ok(response.Body);
        }

        [HttpPost]
        public async Task<IActionResult> Query563(string orderId, string txnTime)
        {
            var request = new UnionPayForm05_6_3_QueryRequest()
            {
                OrderId = orderId,
                TxnTime = txnTime,
            };
            var response = await _client.ExecuteAsync(request);
            return Ok(response.Body);
        }

        [HttpPost]
        public async Task<IActionResult> FileTransfer057(string fileType, string txnTime, string settleDate)
        {
            var request = new UnionPayForm05_7_FileTransferRequest()
            {
                FileType = fileType,
                TxnTime = txnTime,
                SettleDate = settleDate,
            };
            var response = await _client.ExecuteAsync(request);
            return Ok(response.Body);
        }

        [HttpPost]
        public async Task<IActionResult> FrontConsume62(string orderId, string txnTime, string txnAmt, string currencyCode, string payTimeout, string frontUrl, string backUrl)
        {
            var request = new UnionPayForm_6_2_FrontConsumeRequest()
            {
                OrderId = orderId,
                TxnTime = txnTime,
                TxnAmt = txnAmt,
                CurrencyCode = currencyCode,
                PayTimeout = payTimeout,
                FrontUrl = frontUrl,
                BackUrl = backUrl,
            };
            var response = await _client.PageExecuteAsync(request, "POST");
            return Content(response.Body, "text/html");
        }

        [HttpPost]
        public async Task<IActionResult> FrontConsume62Return()
        {
            try
            {
                var notify = await _notifyClient.ExecuteAsync<UnionPayForm_6_2_FrontConsumeReturnResponse>(Request);
                return Content("ok", "text/plain");
            }
            catch
            {
                return Content("error", "text/plain");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Query65(string orderId, string txnTime)
        {
            var request = new UnionPayForm_6_5_QueryRequest()
            {
                OrderId = orderId,
                TxnTime = txnTime,
            };
            var response = await _client.ExecuteAsync(request);
            return Ok(response.Body);
        }

        [HttpPost]
        public async Task<IActionResult> ConsumeUndo63(string orderId, string txnTime, string txnAmt, string origQryId, string backUrl)
        {
            var request = new UnionPayForm_6_3_ConsumeUndoRequest()
            {
                OrderId = orderId,
                TxnTime = txnTime,
                TxnAmt = txnAmt,
                OrigQryId = origQryId,
                BackUrl = backUrl,
            };
            var response = await _client.ExecuteAsync(request);
            return Ok(response.Body);
        }

        [HttpPost]
        public async Task<IActionResult> Refund64(string orderId, string txnTime, string txnAmt, string origQryId, string backUrl)
        {
            var request = new UnionPayForm_6_4_RefundRequest()
            {
                OrderId = orderId,
                TxnTime = txnTime,
                TxnAmt = txnAmt,
                OrigQryId = origQryId,
                BackUrl = backUrl,
            };
            var response = await _client.ExecuteAsync(request);
            return Ok(response.Body);
        }

        [HttpPost]
        public async Task<IActionResult> FileTransfer66(string fileType, string txnTime, string settleDate)
        {
            var request = new UnionPayForm_6_6_FileTransferRequest()
            {
                FileType = fileType,
                TxnTime = txnTime,
                SettleDate = settleDate,
            };
            var response = await _client.ExecuteAsync(request);
            return Ok(response.Body);
        }

        [HttpPost]
        public async Task<IActionResult> AuthDealFront671(string orderId, string txnTime, string txnAmt, string currencyCode, string payTimeout, string frontUrl, string backUrl)
        {
            var request = new UnionPayForm_6_7_1_AuthDeal_FrontRequest()
            {
                OrderId = orderId,
                TxnTime = txnTime,
                TxnAmt = txnAmt,
                CurrencyCode = currencyCode,
                PayTimeout = payTimeout,
                FrontUrl = frontUrl,
                BackUrl = backUrl,
            };
            var response = await _client.PageExecuteAsync(request, "POST");
            return Content(response.Body, "text/html");
        }

        [HttpPost]
        public async Task<IActionResult> AuthDealFront671Return()
        {
            try
            {
                var notify = await _notifyClient.ExecuteAsync<UnionPayForm_6_7_1_AuthDeal_FrontReturnResponse>(Request);
                return Content("ok", "text/plain");
            }
            catch
            {
                return Content("error", "text/plain");
            }
        }

        [HttpPost]
        public async Task<IActionResult> AuthUndo672(string orderId, string txnTime, string txnAmt, string origQryId, string backUrl)
        {
            var request = new UnionPayForm_6_7_2_AuthUndoRequest()
            {
                OrderId = orderId,
                TxnTime = txnTime,
                TxnAmt = txnAmt,
                OrigQryId = origQryId,
                BackUrl = backUrl,
            };
            var response = await _client.ExecuteAsync(request);
            return Ok(response.Body);
        }

        [HttpPost]
        public async Task<IActionResult> AuthFinish673(string orderId, string txnTime, string txnAmt, string origQryId, string backUrl)
        {
            var request = new UnionPayForm_6_7_3_AuthFinishRequest()
            {
                OrderId = orderId,
                TxnTime = txnTime,
                TxnAmt = txnAmt,
                OrigQryId = origQryId,
                BackUrl = backUrl,
            };
            var response = await _client.ExecuteAsync(request);
            return Ok(response.Body);
        }

        [HttpPost]
        public async Task<IActionResult> AuthFinishUndo674(string orderId, string txnTime, string txnAmt, string origQryId, string backUrl)
        {
            var request = new UnionPayForm_6_7_4_AuthFinishUndoRequest()
            {
                OrderId = orderId,
                TxnTime = txnTime,
                TxnAmt = txnAmt,
                OrigQryId = origQryId,
                BackUrl = backUrl,
            };
            var response = await _client.ExecuteAsync(request);
            return Ok(response.Body);
        }
    }
}