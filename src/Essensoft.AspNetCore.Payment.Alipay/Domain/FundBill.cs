using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FundBill Data Structure.
    /// </summary>
    public class FundBill : AlipayObject
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
        /// 交易使用的资金渠道，详见 支付渠道列表https://alipay.open.taobao.com/doc2/detail?treeId=26&articleId=103259&docType=1
        /// </summary>
        [JsonPropertyName("fund_channel")]
        public string FundChannel { get; set; }

        /// <summary>
        /// 渠道实际付款金额
        /// </summary>
        [JsonPropertyName("real_amount")]
        public string RealAmount { get; set; }
    }
}
