using Essensoft.AspNetCore.Payment.WeChatPay;
using Essensoft.AspNetCore.Payment.WeChatPay.Parser;
using Essensoft.AspNetCore.Payment.WeChatPay.Request;
using Essensoft.AspNetCore.Payment.WeChatPay.Response;
using Essensoft.AspNetCore.Payment.WeChatPay.Utility;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace WebApplicationSample.Controllers
{
    public class WeChatPayController : Controller
    {
        private readonly WeChatPayClient _client = null;

        public WeChatPayController(WeChatPayClient client)
        {
            _client = client;
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
        public async Task<IActionResult> AppOrder(string out_trade_no, string body, int total_fee, string spbill_create_ip, string notify_url, string trade_type)
        {
            var request = new WeChatPayUnifiedOrderRequest()
            {
                OutTradeNo = out_trade_no,
                Body = body,
                TotalFee = total_fee,
                SpbillCreateIp = spbill_create_ip,
                NotifyUrl = notify_url,
                TradeType = trade_type,
            };
            var response = await _client.ExecuteAsync(request);

            // 组合"调起支付接口"所需参数 :

            var unixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            var timeStamp = (long)((DateTime.Now - unixEpoch).TotalSeconds);

            var dic = new WeChatPayDictionary
            {
                { "appid", _client.Options.AppId },
                { "partnerid",_client.Options.MchId  },
                { "prepayid", response.PrepayId },
                { "package", "Sign=WXPay" },
                { "noncestr", Guid.NewGuid().ToString("N") },
                { "timestamp", timeStamp }
            };
            // 将这些参数签名
            dic.Add("sign", WeChatPaySignature.SignWithKey(dic, _client.Options.Key));

            // 将签名后的参数(dic)给 ios/android端 由其去调起微信APP(https://pay.weixin.qq.com/wiki/doc/api/app/app.php?chapter=8_5)
            return Ok(dic);
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
            var response = await _client.ExecuteAsync(request);
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
            var response = await _client.ExecuteAsync(request);
            return Ok(response.Body);
        }

        [HttpPost]
        public async Task<IActionResult> GetTransferInfo(string partner_trade_no)
        {
            var request = new WeChatPayGetTransferInfoRequest()
            {
                PartnerTradeNo = partner_trade_no,
            };
            var response = await _client.ExecuteAsync(request);
            return Ok(response.Body);
        }

        [HttpPost]
        public async Task<IActionResult> GetPublicKey()
        {
            var request = new WeChatPayGetPublicKeyRequest();
            var response = await _client.ExecuteAsync(request);
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
            var response = await _client.ExecuteAsync(request);
            return Ok(response.Body);
        }

        [HttpPost]
        public async Task<IActionResult> QueryBank(string partner_trade_no)
        {
            var request = new WeChatPayQueryBankRequest()
            {
                PartnerTradeNo = partner_trade_no,
            };
            var response = await _client.ExecuteAsync(request);
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
            var response = await _client.ExecuteAsync(request);
            return Ok(response.Body);
        }

        [HttpPost]
        public async Task<IActionResult> SendRedPack(string mch_billno, string send_name, string re_openid, int total_amount, string wishing, string client_ip, string act_name, string remark)
        {
            var request = new WeChatPaySendRedPackRequest()
            {
                MchBillNo = mch_billno,
                SendName = send_name,
                ReOpenId = re_openid,
                TotalAmount = total_amount,
                TotalNum = 1,
                Wishing = wishing,
                ClientIp = client_ip,
                ActName = act_name,
                Remark = remark,
            };

            var response = await _client.ExecuteAsync(request);
            return Ok(response.Body);
        }

        [HttpPost]
        public async Task<IActionResult> SendGroupRedPack(string mch_billno, string send_name, string re_openid, int total_amount, string wishing, string act_name, string remark)
        {
            var request = new WeChatPaySendGroupRedPackRequest()
            {
                MchBillNo = mch_billno,
                SendName = send_name,
                ReOpenId = re_openid,
                TotalAmount = total_amount,
                TotalNum = 1,
                AmtType = "ALL_RAND",
                Wishing = wishing,
                ActName = act_name,
                Remark = remark,
            };

            var response = await _client.ExecuteAsync(request);
            return Ok(response.Body);
        }

        [HttpPost]
        public async Task<IActionResult> GetHBInfo(string mch_billno, string bill_type)
        {
            var request = new WeChatPayGetHBInfoRequest()
            {
                MchBillNo = mch_billno,
                BillType = bill_type
            };

            var response = await _client.ExecuteAsync(request);
            return Ok(response.Body);
        }
    }
}
