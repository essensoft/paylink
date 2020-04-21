using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ShopCategoryInfo Data Structure.
    /// </summary>
    public class ShopCategoryInfo : AlipayObject
    {
        /// <summary>
        /// 类目编号
        /// </summary>
        [JsonPropertyName("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 类目层级,目前最多支持1、2、3三级
        /// </summary>
        [JsonPropertyName("category_level")]
        public string CategoryLevel { get; set; }

        /// <summary>
        /// 类目名称
        /// </summary>
        [JsonPropertyName("category_name")]
        public string CategoryName { get; set; }
    }
}
