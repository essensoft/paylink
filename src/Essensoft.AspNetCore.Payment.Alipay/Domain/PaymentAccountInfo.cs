using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PaymentAccountInfo Data Structure.
    /// </summary>
    public class PaymentAccountInfo : AlipayObject
    {
        /// <summary>
        /// 账号名称
        /// </summary>
        [JsonPropertyName("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 账号
        /// </summary>
        [JsonPropertyName("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 账号类型：ALIPAY(支付宝)，MYBK(网商银行卡)
        /// </summary>
        [JsonPropertyName("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 金额：单位分
        /// </summary>
        [JsonPropertyName("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 账单备注
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }
    }
}
