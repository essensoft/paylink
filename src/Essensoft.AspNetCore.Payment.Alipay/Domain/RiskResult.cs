using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RiskResult Data Structure.
    /// </summary>
    public class RiskResult : AlipayObject
    {
        /// <summary>
        /// 风险类型，比如0表示广告
        /// </summary>
        [JsonPropertyName("risk_type")]
        public string RiskType { get; set; }

        /// <summary>
        /// 风险识别分数，0-100，分值越大风险越高
        /// </summary>
        [JsonPropertyName("score")]
        public string Score { get; set; }
    }
}
