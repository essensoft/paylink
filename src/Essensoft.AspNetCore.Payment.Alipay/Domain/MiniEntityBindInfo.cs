using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MiniEntityBindInfo Data Structure.
    /// </summary>
    public class MiniEntityBindInfo : AlipayObject
    {
        /// <summary>
        /// 实体id
        /// </summary>
        [JsonPropertyName("entity_id")]
        public string EntityId { get; set; }

        /// <summary>
        /// 属性列表
        /// </summary>
        [JsonPropertyName("property_list")]
        public List<MiniContentPropertyInfo> PropertyList { get; set; }
    }
}
