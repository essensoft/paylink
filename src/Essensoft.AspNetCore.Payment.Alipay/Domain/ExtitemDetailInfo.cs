using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ExtitemDetailInfo Data Structure.
    /// </summary>
    public class ExtitemDetailInfo : AlipayObject
    {
        /// <summary>
        /// 标品id
        /// </summary>
        [JsonPropertyName("extitem_id")]
        public string ExtitemId { get; set; }

        /// <summary>
        /// 标品名称
        /// </summary>
        [JsonPropertyName("extitem_name")]
        public string ExtitemName { get; set; }

        /// <summary>
        /// 标品的货品组成
        /// </summary>
        [JsonPropertyName("goods_component_list")]
        public List<GoodsComponent> GoodsComponentList { get; set; }
    }
}
