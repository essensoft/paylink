using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PreAmountClauseResult Data Structure.
    /// </summary>
    public class PreAmountClauseResult : AlipayObject
    {
        /// <summary>
        /// 具体的金额
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 用于指定金额的描述信息
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }
    }
}
