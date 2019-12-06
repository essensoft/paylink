using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataDataserviceChinaremodelQueryModel Data Structure.
    /// </summary>
    public class AlipayDataDataserviceChinaremodelQueryModel : AlipayObject
    {
        /// <summary>
        /// 体检记录id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 规则id
        /// </summary>
        [JsonPropertyName("rule_id")]
        public string RuleId { get; set; }

        /// <summary>
        /// 交易流水记录id
        /// </summary>
        [JsonPropertyName("trans_id")]
        public string TransId { get; set; }
    }
}
