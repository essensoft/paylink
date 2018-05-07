using Essensoft.AspNetCore.Payment.LianLianPay;
using Essensoft.AspNetCore.Payment.LianLianPay.Notify;
using Essensoft.AspNetCore.Payment.LianLianPay.Request;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebApplicationSample.Controllers
{
    public class LianLianPayController : Controller
    {
        private readonly LianLianPayClient _client = null;
        private readonly LianLianPayNotifyClient _notifyClient = null;

        public LianLianPayController(LianLianPayClient client, LianLianPayNotifyClient notifyClient)
        {
            _client = client;
            _notifyClient = notifyClient;
        }

        [HttpPost]
        public async Task<IActionResult> QuickPay(string no_order, string dt_order, string money_order, string name_goods,
            string user_id, string notify_url, string url_return, string bank_code, string pay_type, string no_agree, string risk_item,
            string id_type, string id_no, string acct_name, string card_no)
        {
            var request = new LianLianPayWebQuickPayRequest()
            {
                NoOrder = no_order,
                DtOrder = dt_order,
                MoneyOrder = money_order,
                NameGoods = name_goods,
                UserId = user_id,
                NotifyUrl = notify_url,
                UrlReturn = url_return,
                BankCode = bank_code,
                PayType = pay_type,
                NoAgree = no_agree,
                RiskItem = risk_item,
                IdType = id_type,
                IdNo = id_no,
                AcctName = acct_name,
                CardNo = card_no,
            };
            var response = await _client.PageExecuteAsync(request, "GET");
            return Redirect(response.Body);
        }

        [HttpPost]
        public async Task<IActionResult> BankPay(string no_order, string dt_order, string money_order,
            string name_goods, string user_id, string notify_url, string url_return, string risk_item)
        {
            var request = new LianLianPayBankPayRequest()
            {
                NoOrder = no_order,
                DtOrder = dt_order,
                MoneyOrder = money_order,
                NameGoods = name_goods,
                UserId = user_id,
                NotifyUrl = notify_url,
                UrlReturn = url_return,
                RiskItem = risk_item,
            };
            var response = await _client.PageExecuteAsync(request, "GET");
            return Redirect(response.Body);
        }

        [HttpPost]
        public async Task<IActionResult> AuthPay(string no_order, string dt_order, string money_order, string name_goods, string user_id,
            string notify_url, string url_return, string bank_code, string pay_type, string no_agree, string risk_item, string id_type, string id_no,
            string acct_name, string card_no)
        {
            var request = new LianLianPayWebAuthPayRequest()
            {
                NoOrder = no_order,
                DtOrder = dt_order,
                MoneyOrder = money_order,
                NameGoods = name_goods,
                UserId = user_id,
                NotifyUrl = notify_url,
                UrlReturn = url_return,
                BankCode = bank_code,
                PayType = pay_type,
                NoAgree = no_agree,
                RiskItem = risk_item,
                IdType = id_type,
                IdNo = id_no,
                AcctName = acct_name,
                CardNo = card_no,
            };
            var response = await _client.PageExecuteAsync(request, "GET");
            return Redirect(response.Body);
        }

        [HttpPost]
        public async Task<IActionResult> OrderQuery(string no_order, string dt_order, string oid_paybill)
        {
            var request = new LianLianPayOrderQueryRequest()
            {
                NoOrder = no_order,
                DtOrder = dt_order,
                OidPayBill = oid_paybill
            };
            var response = await _client.ExecuteAsync(request);
            return Content(response.Body);
        }

        [HttpPost]
        public async Task<IActionResult> QueryBankCarBin(string card_no)
        {
            var request = new LianLianPayQueryBankCarBinRequest()
            {
                CardNo = card_no,
            };
            var response = await _client.ExecuteAsync(request);
            return Content(response.Body);
        }

        [HttpPost]
        public async Task<IActionResult> QueryBankCarBindList(string user_id, string offset)
        {
            var request = new LianLianPayQueryBankCarBindListRequest()
            {
                UserId = user_id,
                Offset = offset,
            };
            var response = await _client.ExecuteAsync(request);
            return Content(response.Body);
        }

        [HttpPost]
        public async Task<IActionResult> BankCardUnbind(string user_id, string pay_type, string no_agree)
        {
            var request = new LianLianPayBankCardUnbindRequest()
            {
                UserId = user_id,
                PayType = pay_type,
                NoAgree = no_agree,
            };
            var response = await _client.ExecuteAsync(request);
            return Content(response.Body);
        }

        [HttpPost]
        public async Task<IActionResult> ModifyPhone(string user_id, string no_agree, string pay_type, string card_no, string bind_mob)
        {
            var request = new LianLianPayModifyPhoneRequest()
            {
                UserId = user_id,
                NoAgree = no_agree,
                PayType = pay_type,
                CardNo = card_no,
                BindMob = bind_mob
            };
            var response = await _client.ExecuteAsync(request);
            return Content(response.Body);
        }

        [HttpPost]
        public async Task<IActionResult> ModifyPhoneCheck(string user_id, string token, string verify_code)
        {
            var request = new LianLianPayModifyPhoneCheckRequest()
            {
                UserId = user_id,
                Token = token,
                VerifyCode = verify_code,
            };
            var response = await _client.ExecuteAsync(request);
            return Content(response.Body);
        }

        [HttpPost]
        public async Task<IActionResult> SupportBankQuery(string bank_code, string card_type, string product_type, string pay_chnl)
        {
            var request = new LianLianPaySupportBankQueryRequest()
            {
                BankCode = bank_code,
                CardType = card_type,
                ProductType = product_type,
                PayChnl = pay_chnl
            };
            var response = await _client.ExecuteAsync(request);
            return Content(response.Body);
        }

        [HttpPost]
        public async Task<IActionResult> Refund(string no_refund, string dt_refund, string money_refund, string no_order, string dt_order, string oid_paybill, string notify_url)
        {
            var request = new LianLianPayRefundRequest()
            {
                NoRefund = no_refund,
                DtRefund = dt_refund,
                MoneyRefund = money_refund,
                NoOrder = no_order,
                DtOrder = dt_order,
                OidPaybill = oid_paybill,
                NotifyUrl = notify_url,
            };
            var response = await _client.ExecuteAsync(request);
            return Content(response.Body);
        }

        [HttpPost]
        public async Task<IActionResult> RefundQuery(string no_refund, string dt_refund, string oid_refundno)
        {
            var request = new LianLianPayRefundQueryRequest()
            {
                NoRefund = no_refund,
                DtRefund = dt_refund,
                OidRefundNo = oid_refundno,
            };
            var response = await _client.ExecuteAsync(request);
            return Content(response.Body);
        }

        [HttpPost]
        public async Task<IActionResult> BankPayReturn()
        {
            try
            {
                var notify = await _notifyClient.ExecuteAsync<LianLianPayBankPayReturnResponse>(Request);
                return Content("success", "text/plain");
            }
            catch
            {
                return Content("error", "text/plain");
            }
        }

        [HttpPost]
        public async Task<IActionResult> QuickPayReturn()
        {
            try
            {
                var notify = await _notifyClient.ExecuteAsync<LianLianPayWebQuickPayReturnResponse>(Request);
                return Content("success", "text/plain");
            }
            catch
            {
                return Content("error", "text/plain");
            }
        }

        [HttpPost]
        public async Task<IActionResult> AuthPayReturn()
        {
            try
            {
                var notify = await _notifyClient.ExecuteAsync<LianLianPayWebAuthPayReturnResponse>(Request);
                return Content("success", "text/plain");
            }
            catch
            {
                return Content("error", "text/plain");
            }
        }
    }
}
