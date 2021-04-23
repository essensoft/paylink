using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ContentRiskResult Data Structure.
    /// </summary>
    public class ContentRiskResult : AlipayObject
    {
        /// <summary>
        /// 风险详细信息
        /// </summary>
        [JsonPropertyName("content_risk_details")]
        public List<ContentRiskDetail> ContentRiskDetails { get; set; }

        /// <summary>
        /// 审核状态：枚举值，唯一 。 ROBOT_PASS：机审通过  ROBOT_REVIEW_REJECT：机审驳回  ROBOT_FAIL：机审失败
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }

        /// <summary>
        /// 审核规则数
        /// </summary>
        [JsonPropertyName("rl_cnt")]
        public string RlCnt { get; set; }
    }
}
