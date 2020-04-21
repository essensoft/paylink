using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TradeFundBill Data Structure.
    /// </summary>
    public class TradeFundBill : AlipayObject
    {
        /// <summary>
        /// 该支付工具类型所使用的金额
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 银行卡支付时的银行代码
        /// </summary>
        [JsonPropertyName("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// 交易使用的资金渠道，详见 <a href="https://doc.open.alipay.com/doc2/detail?treeId=26&articleId=103259&docType=1">支付渠道列表</a>
        /// </summary>
        [JsonPropertyName("fund_channel")]
        public string FundChannel { get; set; }

        /// <summary>
        /// 渠道所使用的资金类型,目前只在资金渠道(fund_channel)是银行卡渠道(BANKCARD)的情况下才返回该信息(DEBIT_CARD:借记卡,CREDIT_CARD:信用卡,MIXED_CARD:借贷合一卡)
        /// </summary>
        [JsonPropertyName("fund_type")]
        public string FundType { get; set; }

        /// <summary>
        /// 渠道实际付款金额
        /// </summary>
        [JsonPropertyName("real_amount")]
        public string RealAmount { get; set; }
    }
}
