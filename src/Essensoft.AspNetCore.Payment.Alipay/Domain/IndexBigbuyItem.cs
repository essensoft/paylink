using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// IndexBigbuyItem Data Structure.
    /// </summary>
    public class IndexBigbuyItem : AlipayObject
    {
        /// <summary>
        /// 距离
        /// </summary>
        [JsonPropertyName("distance")]
        public long Distance { get; set; }

        /// <summary>
        /// 图片地址，用于展示商品图片
        /// </summary>
        [JsonPropertyName("image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 商品详情页跳转链接
        /// </summary>
        [JsonPropertyName("item_detail_url")]
        public string ItemDetailUrl { get; set; }

        /// <summary>
        /// 商品图片的id值，可用于拼接图片链接
        /// </summary>
        [JsonPropertyName("item_field_id")]
        public string ItemFieldId { get; set; }

        /// <summary>
        /// 商品id，唯一标识
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonPropertyName("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 必抢标文案
        /// </summary>
        [JsonPropertyName("item_tag")]
        public string ItemTag { get; set; }

        /// <summary>
        /// 一般为店名，但当商品为银行卡类型时为商品名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 原价
        /// </summary>
        [JsonPropertyName("original_price")]
        public string OriginalPrice { get; set; }

        /// <summary>
        /// 价格单位
        /// </summary>
        [JsonPropertyName("price_unit")]
        public string PriceUnit { get; set; }

        /// <summary>
        /// 售卖价格
        /// </summary>
        [JsonPropertyName("selling_price")]
        public string SellingPrice { get; set; }

        /// <summary>
        /// 店铺图片的id值，可用于拼接店铺图片链接
        /// </summary>
        [JsonPropertyName("shop_field_id")]
        public string ShopFieldId { get; set; }

        /// <summary>
        /// 店铺id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 店铺logo
        /// </summary>
        [JsonPropertyName("shop_logo")]
        public string ShopLogo { get; set; }

        /// <summary>
        /// 淘宝轻店铺id
        /// </summary>
        [JsonPropertyName("tb_mini_shop_id")]
        public string TbMiniShopId { get; set; }
    }
}
