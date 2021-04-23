using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicGroupModifyModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicGroupModifyModel : AlipayObject
    {
        /// <summary>
        /// 分组ID，通过<a href="https://opendocs.alipay.com/apis/api_6/alipay.open.public.group.create">alipay.open.public.group.create</a>（用户分组创建接口) 创建用户分组获取。
        /// </summary>
        [JsonPropertyName("group_id")]
        public string GroupId { get; set; }

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
