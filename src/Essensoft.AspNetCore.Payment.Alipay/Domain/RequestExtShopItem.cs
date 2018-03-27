using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RequestExtShopItem Data Structure.
    /// </summary>
    public class RequestExtShopItem : AlipayObject
    {
        /// <summary>
        /// 店铺商品的品牌名称
        /// </summary>
        [JsonProperty("brand_code")]
        public string BrandCode { get; set; }

        /// <summary>
        /// 店铺商品的商品类别
        /// </summary>
        [JsonProperty("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 商品描述
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// 店铺商品SKU
        /// </summary>
        [JsonProperty("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 口碑门店id
        /// </summary>
        [JsonProperty("kb_shop_id")]
        public string KbShopId { get; set; }

        /// <summary>
        /// 商品参考价格
        /// </summary>
        [JsonProperty("price")]
        public string Price { get; set; }

        /// <summary>
        /// 店铺商品的名称
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
