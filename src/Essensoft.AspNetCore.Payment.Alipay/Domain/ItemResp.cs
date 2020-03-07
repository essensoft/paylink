using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ItemResp Data Structure.
    /// </summary>
    public class ItemResp : AlipayObject
    {
        /// <summary>
        /// 内容分类
        /// </summary>
        [JsonPropertyName("category")]
        public string Category { get; set; }

        /// <summary>
        /// 用户是否已购买或已领取:true-已购买/已领取,false-未购买/未领取
        /// </summary>
        [JsonPropertyName("has_recive")]
        public bool HasRecive { get; set; }

        /// <summary>
        /// 小图标地址
        /// </summary>
        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// 营销图片
        /// </summary>
        [JsonPropertyName("image")]
        public string Image { get; set; }

        /// <summary>
        /// 商品、券ID
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 内容意义
        /// </summary>
        [JsonPropertyName("meaning")]
        public string Meaning { get; set; }

        /// <summary>
        /// 商品原价
        /// </summary>
        [JsonPropertyName("org_price")]
        public string OrgPrice { get; set; }

        /// <summary>
        /// 商品价格或折扣
        /// </summary>
        [JsonPropertyName("price")]
        public string Price { get; set; }

        /// <summary>
        /// 店铺id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 简要描述
        /// </summary>
        [JsonPropertyName("summary")]
        public string Summary { get; set; }

        /// <summary>
        /// 内容标签
        /// </summary>
        [JsonPropertyName("tags")]
        public string Tags { get; set; }

        /// <summary>
        /// 限制及特性描述
        /// </summary>
        [JsonPropertyName("tips")]
        public string Tips { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// 类型:VOUCHER(券)、ITEM(商品)
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// 内容跳转地址
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
