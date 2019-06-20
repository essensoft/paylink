using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RiskRankInfoCode Data Structure.
    /// </summary>
    [Serializable]
    public class RiskRankInfoCode : AlipayObject
    {
        /// <summary>
        /// infocode
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// 此infocode在总的得分中的贡献度
        /// </summary>
        [JsonProperty("contribution_degree")]
        public long ContributionDegree { get; set; }

        /// <summary>
        /// 风险描述
        /// </summary>
        [JsonProperty("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 模型名称
        /// </summary>
        [JsonProperty("model_name")]
        public string ModelName { get; set; }
    }
}
