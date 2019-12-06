using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OuterTargetingItem Data Structure.
    /// </summary>
    public class OuterTargetingItem : AlipayObject
    {
        /// <summary>
        /// 定向类型：  REGION_LIST: 实时地址  AD_POS_LIST: 广告位定向  OUTER_KOUBEI_INTEREST_TAG_LIST: 口碑偏好  OUTER_KOUBEI_CROWD_TAG_LIST：口碑人群
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// 定向值
        /// </summary>
        [JsonPropertyName("value_list")]
        public List<string> ValueList { get; set; }
    }
}
