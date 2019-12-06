using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicGroupCrowdQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicGroupCrowdQueryModel : AlipayObject
    {
        /// <summary>
        /// 用户分组的规则项列表，规则项之间元素是与的逻辑，每个规则项内部用多个值表示或的逻辑
        /// </summary>
        [JsonPropertyName("label_rule")]
        public List<ComplexLabelRule> LabelRule { get; set; }
    }
}
