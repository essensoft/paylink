using Essensoft.AspNetCore.Payment.UnionPay;
using Essensoft.AspNetCore.Payment.UnionPay.Notify;
using Essensoft.AspNetCore.Payment.UnionPay.Request;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebApplicationSample.Controllers
{
    public class UnionPayController : Controller
    {
        private readonly UnionPayClient _client = null;
        private readonly UnionPayNotifyClient _notifyClient = null;

        public UnionPayController(UnionPayClient client, UnionPayNotifyClient notifyClient)
        {
            _client = client;
            _notifyClient = notifyClient;
        }

        #region 二维码支付

        [HttpPost]
        public async Task<IActionResult> PurchaseUndo(string orderId, string txnTime, string txnAmt, string origQryId, string origOrderId, string origTxnTime, string backUrl)
        {
            var request = new UnionPayUpacpPurchaseUndoRequest()
            {
                TxnType = "31",
                TxnSubType = "00",
                BizType = "000000",
                ChannelType = "08",
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
            var request = new UnionPayUpacpRefundRequest()
            {
                TxnType = "04",
                TxnSubType = "00",
                BizType = "000000",
                ChannelType = "08",
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
        public async Task<IActionResult> ApplyQrCode(string orderId, string txnTime, string txnAmt, string currencyCode, string backUrl)
        {
            var request = new UnionPayForm05_6_1_ApplyQrCodeRequest()
            {
                TxnType = "01",
                TxnSubType = "07",
                BizType = "000000",
                ChannelType = "08",
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
        public async Task<IActionResult> AppConsume(string orderId, string qrNo, string txnTime, string txnAmt, string currencyCode, string backUrl)
        {
            var request = new UnionPayForm05_6_2_AppConsumeRequest()
            {
                TxnType = "01",
                TxnSubType = "06",
                BizType = "000000",
                ChannelType = "08",
                OrderId = orderId,
                TxnTime = txnTime,
                TxnAmt = txnAmt,
                CurrencyCode = currencyCode,
                QrNo = qrNo,
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
                TxnType = "00",
                TxnSubType = "00",
                BizType = "000201",
                OrderId = orderId,
                TxnTime = txnTime,
            };
            var response = await _client.ExecuteAsync(request);
            return Ok(response.Body);
        }

        [HttpPost]
        public async Task<IActionResult> Reversal0565(string orderId, string txnTime)
        {
            var request = new UnionPayForm05_6_5_ReversalRequest()
            {
                TxnType = "99",
                TxnSubType = "01",
                BizType = "000000",
                ChannelType = "08",
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
                TxnType = "76",
                TxnSubType = "01",
                BizType = "000000",
                FileType = fileType,
                TxnTime = txnTime,
                SettleDate = settleDate,
            };
            var response = await _client.ExecuteAsync(request);
            return Ok(response.Body);
        }

        #endregion

        #region 网关支付

        [HttpPost]
        public async Task<IActionResult> FrontConsume62(string orderId, string txnTime, string txnAmt, string currencyCode, string payTimeout, string frontUrl, string backUrl)
        {
            var request = new UnionPayForm_6_2_FrontConsumeRequest()
            {
                TxnType = "01",
                TxnSubType = "01",
                BizType = "000201",
                ChannelType = "07",
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
        public async Task<IActionResult> ConsumeUndo63(string orderId, string txnTime, string txnAmt, string origQryId, string backUrl)
        {
            var request = new UnionPayForm_6_3_ConsumeUndoRequest()
            {
                TxnType = "31",
                TxnSubType = "00",
                BizType = "000201",
                ChannelType = "07",
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
                TxnType = "04",
                TxnSubType = "00",
                BizType = "000301",
                ChannelType = "07",
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
        public async Task<IActionResult> Query65(string orderId, string txnTime)
        {
            var request = new UnionPayForm_6_5_QueryRequest()
            {
                TxnType = "00",
                TxnSubType = "00",
                BizType = "000201",
                OrderId = orderId,
                TxnTime = txnTime,
            };
            var response = await _client.ExecuteAsync(request);
            return Ok(response.Body);
        }

        [HttpPost]
        public async Task<IActionResult> AuthDealFront671(string orderId, string txnTime, string txnAmt, string currencyCode, string payTimeout, string frontUrl, string backUrl)
        {
            var request = new UnionPayForm_6_7_1_AuthDeal_FrontRequest()
            {
                TxnType = "02",
                TxnSubType = "01",
                BizType = "000201",
                ChannelType = "07",
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
                TxnType = "32",
                TxnSubType = "00",
                BizType = "000201",
                ChannelType = "07",
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
                TxnType = "03",
                TxnSubType = "00",
                BizType = "000201",
                ChannelType = "07",
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
                TxnType = "03",
                TxnSubType = "00",
                BizType = "000201",
                ChannelType = "07",
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
                TxnType = "76",
                TxnSubType = "01",
                BizType = "000000",
                FileType = fileType,
                TxnTime = txnTime,
                SettleDate = settleDate,
            };
            var response = await _client.ExecuteAsync(request);
            return Ok(response.Body);
        }
        #endregion
    }
}