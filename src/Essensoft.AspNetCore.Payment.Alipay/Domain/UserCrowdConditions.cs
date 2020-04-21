using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// UserCrowdConditions Data Structure.
    /// </summary>
    public class UserCrowdConditions : AlipayObject
    {
        /// <summary>
        /// 最爱这家店的人
        /// </summary>
        [JsonPropertyName("crowd_group_id")]
        public string CrowdGroupId { get; set; }

        /// <summary>
        /// 用户群组描述
        /// </summary>
        [JsonPropertyName("describe")]
        public string Describe { get; set; }

        /// <summary>
        /// 命中用户规则集合
        /// </summary>
        [JsonPropertyName("hit_crowd_conditons")]
        public List<ConditionItemPattern> HitCrowdConditons { get; set; }
    }
}
