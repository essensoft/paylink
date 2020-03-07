using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditSupplychainCreditpaySellerunsignQueryModel Data Structure.
    /// </summary>
    public class MybankCreditSupplychainCreditpaySellerunsignQueryModel : AlipayObject
    {
        /// <summary>
        /// 合约编号
        /// </summary>
        [JsonPropertyName("ar_no")]
        public string ArNo { get; set; }

        /// <summary>
        /// 渠道类型
        /// </summary>
        [JsonPropertyName("channel_tag")]
        public string ChannelTag { get; set; }

        /// <summary>
        /// 请求幂等号
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 卖家信息
        /// </summary>
        [JsonPropertyName("seller")]
        public Member Seller { get; set; }

        /// <summary>
        /// 1688卖家场景ID
        /// </summary>
        [JsonPropertyName("seller_scene_id")]
        public string SellerSceneId { get; set; }

        /// <summary>
        /// havanaId
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 日志id
        /// </summary>
        [JsonPropertyName("trace_id")]
        public string TraceId { get; set; }
    }
}
