using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditSupplychainCreditpayBuyersignCreateModel Data Structure.
    /// </summary>
    public class MybankCreditSupplychainCreditpayBuyersignCreateModel : AlipayObject
    {
        /// <summary>
        /// 买家信息
        /// </summary>
        [JsonPropertyName("buyer")]
        public Member Buyer { get; set; }

        /// <summary>
        /// 1688买家ID
        /// </summary>
        [JsonPropertyName("buyer_scene_id")]
        public string BuyerSceneId { get; set; }

        /// <summary>
        /// 平台类型
        /// </summary>
        [JsonPropertyName("channel_tag")]
        public string ChannelTag { get; set; }

        /// <summary>
        /// 请求幂等控制ID
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 网商日志跟踪ID
        /// </summary>
        [JsonPropertyName("trace_id")]
        public string TraceId { get; set; }
    }
}
