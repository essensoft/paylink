using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// EntityPriorRiskVO Data Structure.
    /// </summary>
    [Serializable]
    public class EntityPriorRiskVO : AlipayObject
    {
        /// <summary>
        /// 风险处置源
        /// </summary>
        [JsonProperty("dispose_department")]
        public string DisposeDepartment { get; set; }

        /// <summary>
        /// 风险详情
        /// </summary>
        [JsonProperty("risk_detail")]
        public string RiskDetail { get; set; }

        /// <summary>
        /// 风险级别
        /// </summary>
        [JsonProperty("risk_level")]
        public string RiskLevel { get; set; }

        /// <summary>
        /// 风险场景
        /// </summary>
        [JsonProperty("risk_scene")]
        public string RiskScene { get; set; }

        /// <summary>
        /// 风险类型
        /// </summary>
        [JsonProperty("risk_type")]
        public string RiskType { get; set; }
    }
}
