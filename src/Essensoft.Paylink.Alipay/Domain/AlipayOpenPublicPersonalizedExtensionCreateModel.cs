using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicPersonalizedExtensionCreateModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicPersonalizedExtensionCreateModel : AlipayObject
    {
        /// <summary>
        /// 扩展区列表，最大条数为3
        /// </summary>
        [JsonPropertyName("areas")]
        public List<ExtensionArea> Areas { get; set; }

        /// <summary>
        /// 标签规则，目前限定只能传入1条，在扩展区上线后，满足该标签规则的用户进入生活号首页，将看到该套扩展区。生成标签及打标详情参见<a href="https://opendocs.alipay.com/fw/api/106877">标签管理</a>。
        /// </summary>
        [JsonPropertyName("label_rule")]
        public List<LabelRule> LabelRule { get; set; }
    }
}
