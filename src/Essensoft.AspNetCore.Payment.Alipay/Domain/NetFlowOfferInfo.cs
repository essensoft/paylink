using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// NetFlowOfferInfo Data Structure.
    /// </summary>
    public class NetFlowOfferInfo : AlipayObject
    {
        /// <summary>
        /// 流量生效时间
        /// </summary>
        [JsonPropertyName("effective_time")]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// 流量过期时间
        /// </summary>
        [JsonPropertyName("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 流量套餐名称
        /// </summary>
        [JsonPropertyName("offer_name")]
        public string OfferName { get; set; }

        /// <summary>
        /// 下单时间
        /// </summary>
        [JsonPropertyName("order_time")]
        public string OrderTime { get; set; }
    }
}
