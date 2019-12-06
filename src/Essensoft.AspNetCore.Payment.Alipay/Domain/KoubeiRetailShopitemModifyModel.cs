using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiRetailShopitemModifyModel Data Structure.
    /// </summary>
    public class KoubeiRetailShopitemModifyModel : AlipayObject
    {
        /// <summary>
        /// 店铺商品的品牌名称
        /// </summary>
        [JsonPropertyName("brand_code")]
        public string BrandCode { get; set; }

        /// <summary>
        /// 店铺商品的商品类别
        /// </summary>
        [JsonPropertyName("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 商品描述
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 店铺商品SKU
        /// </summary>
        [JsonPropertyName("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 口碑门店id
        /// </summary>
        [JsonPropertyName("kb_shop_id")]
        public string KbShopId { get; set; }

        /// <summary>
        /// 参考价格
        /// </summary>
        [JsonPropertyName("price")]
        public string Price { get; set; }

        /// <summary>
        /// 店铺商品的名称
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
