using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RiskRankInfoCode Data Structure.
    /// </summary>
    public class RiskRankInfoCode : AlipayObject
    {
        /// <summary>
        /// infocode
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// 此infocode在总的得分中的贡献度
        /// </summary>
        [JsonPropertyName("contribution_degree")]
        public long ContributionDegree { get; set; }

        /// <summary>
        /// 风险描述
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 模型名称
        /// </summary>
        [JsonPropertyName("model_name")]
        public string ModelName { get; set; }
    }
}
