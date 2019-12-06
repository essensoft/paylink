using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringCrowdgroupConditionSetResponse.
    /// </summary>
    public class KoubeiCateringCrowdgroupConditionSetResponse : AlipayResponse
    {
        /// <summary>
        /// 创建成功返回isv创建的分组规则列表
        /// </summary>
        [JsonPropertyName("condition_model_list")]
        public List<ConditionItemPattern> ConditionModelList { get; set; }

        /// <summary>
        /// isv创建的用户分组id
        /// </summary>
        [JsonPropertyName("crowd_group_id")]
        public string CrowdGroupId { get; set; }

        /// <summary>
        /// 创建状态: success fail
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
