using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TransactionAmountModifierDTO Data Structure.
    /// </summary>
    public class TransactionAmountModifierDTO : AlipayObject
    {
        /// <summary>
        /// 金额
        /// </summary>
        [JsonPropertyName("amount")]
        public TransactionAmountDTO Amount { get; set; }

        /// <summary>
        /// 金额类型说明
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 金额类型
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
