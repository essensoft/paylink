using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PayOffOrderVO Data Structure.
    /// </summary>
    public class PayOffOrderVO : AlipayObject
    {
        /// <summary>
        /// 金额，单位元，BigDecimal类型
        /// </summary>
        [JsonPropertyName("balance")]
        public string Balance { get; set; }

        /// <summary>
        /// 币种Code，如USD CNY
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 是否高优先级处理
        /// </summary>
        [JsonPropertyName("high_priority")]
        public bool HighPriority { get; set; }

        /// <summary>
        /// 待解付资金流水号 唯一键
        /// </summary>
        [JsonPropertyName("pay_off_no")]
        public string PayOffNo { get; set; }

        /// <summary>
        /// 待解付登记薄状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
