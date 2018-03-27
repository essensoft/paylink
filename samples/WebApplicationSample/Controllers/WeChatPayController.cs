using Essensoft.AspNetCore.Payment.WeChatPay;
using Essensoft.AspNetCore.Payment.WeChatPay.Request;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebApplicationSample.Controllers
{
    public class WeChatPayController : Controller
    {
        private readonly WeChatPayClient _client = null;
        private readonly WeChatPayCertificateClient _certClient = null;
        public WeChatPayController(WeChatPayClient client, WeChatPayCertificateClient certClient)
        {
            _client = client;
            _certClient = certClient;
        }

        [HttpPost]
        public async Task<IActionResult> UnifiedOrder(string out_trade_no, string body, int total_fee, string spbill_create_ip, string notify_url, string trade_type, string openid)
        {
            var request = new WeChatPayUnifiedOrderRequest()
            {
                OutTradeNo = out_trade_no,
                Body = body,
                TotalFee = total_fee,
                SpbillCreateIp = spbill_create_ip,
                NotifyUrl = notify_url,
                TradeType = trade_type,
                OpenId = openid,
            };
            var response = await _client.ExecuteAsync(request);
            return Ok(response.Body);
        }

        [HttpPost]
        public async Task<IActionResult> OrderQuery(string transaction_id, string out_trade_no)
        {
            var request = new WeChatPayOrderQueryRequest()
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
            var request = new WeChatPayCloseOrderRequest()
            {
                OutTradeNo = out_trade_no,
            };
            var response = await _client.ExecuteAsync(request);
            return Ok(response.Body);
        }

        [HttpPost]
        public async Task<IActionResult> Refund(string out_refund_no, string transaction_id, string out_trade_no, int total_fee, int refund_fee, string refund_desc, string notify_url)
        {
            var request = new WeChatPayRefundRequest()
            {
                OutRefundNo = out_refund_no,
                TransactionId = transaction_id,
                OutTradeNo = out_trade_no,
                TotalFee = total_fee,
                RefundFee = refund_fee,
                RefundDesc = refund_desc,
                NotifyUrl = notify_url,
            };
            var response = await _certClient.ExecuteAsync(request);
            return Ok(response.Body);
        }

        [HttpPost]
        public async Task<IActionResult> RefundQuery(string refund_id, string out_refund_no, string transaction_id, string out_trade_no)
        {
            var request = new WeChatPayRefundQueryRequest()
            {
                RefundId = refund_id,
                OutRefundNo = out_refund_no,
                TransactionId = transaction_id,
                OutTradeNo = out_trade_no,
            };
            var response = await _client.ExecuteAsync(request);
            return Ok(response.Body);
        }

        [HttpPost]
        public async Task<IActionResult> DownloadBill(string bill_date, string bill_type, string tar_type)
        {
            var request = new WeChatPayDownloadBillRequest()
            {
                BillDate = bill_date,
                BillType = bill_type,
                TarType = tar_type,
            };
            var response = await _client.ExecuteAsync(request);
            return Ok(response.Body);
        }

        [HttpPost]
        public async Task<IActionResult> Transfers(string partner_trade_no, string openid, string check_name, string re_user_name, int amount, string desc, string spbill_create_ip)
        {
            var request = new WeChatPayTransfersRequest()
            {
                PartnerTradeNo = partner_trade_no,
                OpenId = openid,
                CheckName = check_name,
                ReUserName = re_user_name,
                Amount = amount,
                Desc = desc,
                SpbillCreateIp = spbill_create_ip
            };
            var response = await _certClient.ExecuteAsync(request);
            return Ok(response.Body);
        }

        [HttpPost]
        public async Task<IActionResult> GetTransferInfo(string partner_trade_no)
        {
            var request = new WeChatPayGetTransferInfoRequest()
            {
                PartnerTradeNo = partner_trade_no,
            };
            var response = await _certClient.ExecuteAsync(request);
            return Ok(response.Body);
        }

        [HttpPost]
        public async Task<IActionResult> GetPublicKey()
        {
            var request = new WeChatPayGetPublicKeyRequest();
            var response = await _certClient.ExecuteAsync(request);
            return Ok(response.Body);
        }

        [HttpPost]
        public async Task<IActionResult> PayBank(string partner_trade_no, string bank_no, string true_name, string bank_code, int amount, string desc)
        {
            var request = new WeChatPayPayBankRequest()
            {
                PartnerTradeNo = partner_trade_no,
                EncBankNo = bank_no,
                EncTrueName = true_name,
                BankCode = bank_code,
                Amount = amount,
                Desc = desc,
            };
            var response = await _certClient.ExecuteAsync(request);
            return Ok(response.Body);
        }

        [HttpPost]
        public async Task<IActionResult> QueryBank(string partner_trade_no)
        {
            var request = new WeChatPayQueryBankRequest()
            {
                PartnerTradeNo = partner_trade_no,
            };
            var response = await _certClient.ExecuteAsync(request);
            return Ok(response.Body);
        }

        [HttpPost]
        public async Task<IActionResult> DownloadFundFlow(string bill_date, string account_type, string tar_type)
        {
            var request = new WeChatPayDownloadFundFlowRequest()
            {
                BillDate = bill_date,
                AccountType = account_type,
                TarType = tar_type,
            };
            var response = await _certClient.ExecuteAsync(request);
            return Ok(response.Body);
        }
    }
}
