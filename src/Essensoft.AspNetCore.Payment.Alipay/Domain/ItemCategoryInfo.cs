using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ItemCategoryInfo Data Structure.
    /// </summary>
    public class ItemCategoryInfo : AlipayObject
    {
        /// <summary>
        /// 类目id
        /// </summary>
        [JsonPropertyName("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 商品类目层级
        /// </summary>
        [JsonPropertyName("category_level")]
        public long CategoryLevel { get; set; }
    }
}
