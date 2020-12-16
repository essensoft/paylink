using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CircleRecommendItemDTO Data Structure.
    /// </summary>
    public class CircleRecommendItemDTO : AlipayObject
    {
        /// <summary>
        /// 生活圈aoi信息
        /// </summary>
        [JsonPropertyName("aoi_info")]
        public AoiInfoDTO AoiInfo { get; set; }

        /// <summary>
        /// 商品折扣
        /// </summary>
        [JsonPropertyName("discount")]
        public string Discount { get; set; }

        /// <summary>
        /// 商品主图/封面图
        /// </summary>
        [JsonPropertyName("item_cover")]
        public string ItemCover { get; set; }

        /// <summary>
        /// 商品详情链接，根据入参display_channel信息，获取对应端小程序链接，默认支付宝小程序链接
        /// </summary>
        [JsonPropertyName("item_detail_url")]
        public string ItemDetailUrl { get; set; }

        /// <summary>
        /// 商品Id
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品标签（三选一：新品/爆品/超赞）
        /// </summary>
        [JsonPropertyName("item_label")]
        public string ItemLabel { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonPropertyName("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 商品所属门店信息
        /// </summary>
        [JsonPropertyName("item_store")]
        public ItemStoreDTO ItemStore { get; set; }

        /// <summary>
        /// 商品原价
        /// </summary>
        [JsonPropertyName("original_price")]
        public string OriginalPrice { get; set; }

        /// <summary>
        /// 销量 “已售xxx份”，销量大于9999："已售XX万份"
        /// </summary>
        [JsonPropertyName("sales_info")]
        public string SalesInfo { get; set; }

        /// <summary>
        /// 节省X元，originalPrice - salesPrice
        /// </summary>
        [JsonPropertyName("saved_money")]
        public string SavedMoney { get; set; }

        /// <summary>
        /// 描述：节省X元
        /// </summary>
        [JsonPropertyName("saved_money_info")]
        public string SavedMoneyInfo { get; set; }

        /// <summary>
        /// 商品售卖价格
        /// </summary>
        [JsonPropertyName("sell_price")]
        public string SellPrice { get; set; }

        /// <summary>
        /// 商品总销量
        /// </summary>
        [JsonPropertyName("sold_quantity")]
        public string SoldQuantity { get; set; }

        /// <summary>
        /// 商品所属门店ID
        /// </summary>
        [JsonPropertyName("store_id")]
        public string StoreId { get; set; }
    }
}
