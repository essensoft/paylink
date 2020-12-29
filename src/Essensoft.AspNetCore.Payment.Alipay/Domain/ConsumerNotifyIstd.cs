using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ConsumerNotifyIstd Data Structure.
    /// </summary>
    public class ConsumerNotifyIstd : AlipayObject
    {
        /// <summary>
        /// 商品数量
        /// </summary>
        [JsonPropertyName("goods_count")]
        public long GoodsCount { get; set; }

        /// <summary>
        /// 商品缩略图url，支持格式：bmp、jpg、jpeg、png、gif
        /// </summary>
        [JsonPropertyName("goods_img")]
        public string GoodsImg { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonPropertyName("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商家电话
        /// </summary>
        [JsonPropertyName("merchant_mobile")]
        public string MerchantMobile { get; set; }

        /// <summary>
        /// 商家名称，tiny_app_id和merchant_name不能同时为空
        /// </summary>
        [JsonPropertyName("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 商家小程序appid
        /// </summary>
        [JsonPropertyName("tiny_app_id")]
        public string TinyAppId { get; set; }

        /// <summary>
        /// 商家小程序的路径，建议为订单页面
        /// </summary>
        [JsonPropertyName("tiny_app_url")]
        public string TinyAppUrl { get; set; }
    }
}
