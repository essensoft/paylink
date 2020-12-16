using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MiniEntityBindVO Data Structure.
    /// </summary>
    public class MiniEntityBindVO : AlipayObject
    {
        /// <summary>
        /// 实体id，具体场景见产品文档
        /// </summary>
        [JsonPropertyName("entity_id")]
        public string EntityId { get; set; }

        /// <summary>
        /// 主体id，具体场景含义见产品文档
        /// </summary>
        [JsonPropertyName("principal_id")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// 属性列表，具体属性见产品文档
        /// </summary>
        [JsonPropertyName("property_list")]
        public List<MiniContentProperty> PropertyList { get; set; }
    }
}
