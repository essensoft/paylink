using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// NearbyGoods Data Structure.
    /// </summary>
    public class NearbyGoods : AlipayObject
    {
        /// <summary>
        /// 活动再减描述，前端直接展示即可
        /// </summary>
        [JsonPropertyName("discount_desc")]
        public string DiscountDesc { get; set; }

        /// <summary>
        /// 店铺距离当前用户的距离，单位为米
        /// </summary>
        [JsonPropertyName("distance")]
        public string Distance { get; set; }

        /// <summary>
        /// 商品图片链接，用于前端展示商品图片
        /// </summary>
        [JsonPropertyName("image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 商品图片的id值，可用于拼接图片链接
        /// </summary>
        [JsonPropertyName("item_field_id")]
        public string ItemFieldId { get; set; }

        /// <summary>
        /// 商品id,商品唯一标识符，可用于查询单个商品信息
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品名称，用于表征商品基本特性
        /// </summary>
        [JsonPropertyName("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 商品详情跳转地址
        /// </summary>
        [JsonPropertyName("jump_url")]
        public string JumpUrl { get; set; }

        /// <summary>
        /// 商品原价，直接返回给前端，单位为元
        /// </summary>
        [JsonPropertyName("original_price")]
        public string OriginalPrice { get; set; }

        /// <summary>
        /// 促销标，超值抢购 or 促销，此为图片连接
        /// </summary>
        [JsonPropertyName("sales_icon")]
        public string SalesIcon { get; set; }

        /// <summary>
        /// 商品最终售卖价格，单位为元
        /// </summary>
        [JsonPropertyName("selling_price")]
        public string SellingPrice { get; set; }

        /// <summary>
        /// 店铺图片的id值，可用于拼接图片链接
        /// </summary>
        [JsonPropertyName("shop_field_id")]
        public string ShopFieldId { get; set; }

        /// <summary>
        /// 店铺唯一标识
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 店铺logo
        /// </summary>
        [JsonPropertyName("shop_logo")]
        public string ShopLogo { get; set; }

        /// <summary>
        /// 适用门店主店名
        /// </summary>
        [JsonPropertyName("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 店铺轻店铺id
        /// </summary>
        [JsonPropertyName("tb_mini_shop_id")]
        public string TbMiniShopId { get; set; }
    }
}
