using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ItemStoreDTO Data Structure.
    /// </summary>
    public class ItemStoreDTO : AlipayObject
    {
        /// <summary>
        /// 门店品牌名称
        /// </summary>
        [JsonPropertyName("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 门店类目信息 英文分隔符,隔开 ； 示例：美食,火锅,川菜/重庆火锅
        /// </summary>
        [JsonPropertyName("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 门店地址
        /// </summary>
        [JsonPropertyName("store_address")]
        public string StoreAddress { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [JsonPropertyName("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 门店LOGO
        /// </summary>
        [JsonPropertyName("store_logo")]
        public string StoreLogo { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [JsonPropertyName("store_name")]
        public string StoreName { get; set; }
    }
}
