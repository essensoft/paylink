using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditSupplychainCreditpaySellersignCreateModel Data Structure.
    /// </summary>
    public class MybankCreditSupplychainCreditpaySellersignCreateModel : AlipayObject
    {
        /// <summary>
        /// 平台类型
        /// </summary>
        [JsonPropertyName("channel_tag")]
        public string ChannelTag { get; set; }

        /// <summary>
        /// 请求冥等控制ID
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 卖家信息
        /// </summary>
        [JsonPropertyName("seller")]
        public Member Seller { get; set; }

        /// <summary>
        /// 1688卖家ID
        /// </summary>
        [JsonPropertyName("seller_scene_id")]
        public string SellerSceneId { get; set; }

        /// <summary>
        /// havanaId
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 店铺名称：在需要传店铺名称时
        /// </summary>
        [JsonPropertyName("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// Trace信息
        /// </summary>
        [JsonPropertyName("trace_id")]
        public string TraceId { get; set; }
    }
}
