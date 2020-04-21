using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicGroupCreateModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicGroupCreateModel : AlipayObject
    {
        /// <summary>
        /// 标签规则，满足该规则的粉丝将被圈定，标签id不能重复
        /// </summary>
        [JsonPropertyName("label_rule")]
        public List<ComplexLabelRule> LabelRule { get; set; }

        /// <summary>
        /// 分组名称，仅支持中文、字母、数字、下划线的组合。
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
