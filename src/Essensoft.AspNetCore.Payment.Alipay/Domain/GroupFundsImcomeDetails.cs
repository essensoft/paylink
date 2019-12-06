using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// GroupFundsImcomeDetails Data Structure.
    /// </summary>
    public class GroupFundsImcomeDetails : AlipayObject
    {
        /// <summary>
        /// 待付款金额,只支持两位小数点的正数,单位元
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 资金分配明细，Map类型，key为收款对象支付宝账户ID，value为分配的金额，两位小数点的正数,单位元
        /// </summary>
        [JsonPropertyName("fund_distributions")]
        public string FundDistributions { get; set; }

        /// <summary>
        /// 付款方支付宝账户ID
        /// </summary>
        [JsonPropertyName("payer_id")]
        public string PayerId { get; set; }
    }
}
