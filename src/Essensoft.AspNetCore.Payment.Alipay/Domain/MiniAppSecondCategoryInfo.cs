using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MiniAppSecondCategoryInfo Data Structure.
    /// </summary>
    public class MiniAppSecondCategoryInfo : AlipayObject
    {
        /// <summary>
        /// 小程序类目Id
        /// </summary>
        [JsonPropertyName("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 度假用别墅服务
        /// </summary>
        [JsonPropertyName("category_name")]
        public string CategoryName { get; set; }
    }
}
