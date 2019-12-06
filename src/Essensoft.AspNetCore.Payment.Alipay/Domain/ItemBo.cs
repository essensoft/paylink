using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ItemBo Data Structure.
    /// </summary>
    public class ItemBo : AlipayObject
    {
        /// <summary>
        /// json 字符串表示额外信息
        /// </summary>
        [JsonPropertyName("attribute")]
        public string Attribute { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// logo链接
        /// </summary>
        [JsonPropertyName("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 原价
        /// </summary>
        [JsonPropertyName("origin_price")]
        public long OriginPrice { get; set; }

        /// <summary>
        /// 现价
        /// </summary>
        [JsonPropertyName("price")]
        public long Price { get; set; }
    }
}
