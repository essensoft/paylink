using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// EntityPriorRiskVO Data Structure.
    /// </summary>
    public class EntityPriorRiskVO : AlipayObject
    {
        /// <summary>
        /// 风险处置源
        /// </summary>
        [JsonPropertyName("dispose_department")]
        public string DisposeDepartment { get; set; }

        /// <summary>
        /// 风险详情
        /// </summary>
        [JsonPropertyName("risk_detail")]
        public string RiskDetail { get; set; }

        /// <summary>
        /// 风险级别
        /// </summary>
        [JsonPropertyName("risk_level")]
        public string RiskLevel { get; set; }

        /// <summary>
        /// 风险场景
        /// </summary>
        [JsonPropertyName("risk_scene")]
        public string RiskScene { get; set; }

        /// <summary>
        /// 风险类型
        /// </summary>
        [JsonPropertyName("risk_type")]
        public string RiskType { get; set; }
    }
}
