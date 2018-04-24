using Essensoft.AspNetCore.Payment.LianLianPay.Response;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.LianLianPay.Request
{
    public class LianLianPayPaymentRequest : ILianLianPayRequest<LianLianPayPaymentResponse>
    {
        /// <summary>
        /// 平台来源
        /// </summary>
        public string Platform { get; set; }

        /// <summary>
        /// 商户付款流水号
        /// </summary>
        public string NoOrder { get; set; }

        /// <summary>
        /// 商户付款时间
        /// </summary>
        public string DtOrder { get; set; }

        /// <summary>
        /// 付款金额
        /// </summary>
        public string MoneyOrder { get; set; }

        /// <summary>
        /// 收款银行账号
        /// </summary>
        public string CardNo { get; set; }

        /// <summary>
        /// 收款人姓名
        /// </summary>
        public string AcctName { get; set; }

        /// <summary>
        /// 收款银行名称
        /// </summary>
        public string BankName { get; set; }

        /// <summary>
        /// 订单描述
        /// </summary>
        public string InfoOrder { get; set; }

        /// <summary>
        /// 对公对私标志
        /// </summary>
        public string FlagCard { get; set; }

        /// <summary>
        /// 服务器异步通知地址
        /// </summary>
        public string NotifyUrl { get; set; }

        /// <summary>
        /// 收款备注
        /// </summary>
        public string Memo { get; set; }

        /// <summary>
        /// 大额行号
        /// </summary>
        public string Prcptcd { get; set; }

        /// <summary>
        /// 银行编码
        /// </summary>
        public string BankCode { get; set; }

        /// <summary>
        /// 开户行所在市编码
        /// </summary>
        public string CityCode { get; set; }

        /// <summary>
        /// 开户支行名称
        /// </summary>
        public string BrabankName { get; set; }

        #region ILianLianPayRequest
        private string ApiVersion = "1.0";

        public string GetRequestUrl()
        {
            return "https://instantpay.lianlianpay.com/paymentapi/payment.htm";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new LianLianPayDictionary
            {
                { "platform", Platform },
                { "no_order", NoOrder },
                { "dt_order", DtOrder },
                { "money_order", MoneyOrder },
                { "card_no", CardNo },
                { "acct_name", AcctName },
                { "bank_name", BankName },
                { "info_order", InfoOrder },
                { "flag_card", FlagCard },
                { "notify_url", NotifyUrl },
                { "memo", Memo },
                { "prcptcd", Prcptcd },
                { "bank_code", BankCode },
                { "city_code", CityCode },
                { "brabank_name", BrabankName },
                { "api_version", ApiVersion },
            };
            return parameters;
        }

        public string GetApiVersion()
        {
            return ApiVersion;
        }

        public void SetApiVersion(string apiVersion)
        {
            ApiVersion = apiVersion;
        }
        #endregion
    }
}
