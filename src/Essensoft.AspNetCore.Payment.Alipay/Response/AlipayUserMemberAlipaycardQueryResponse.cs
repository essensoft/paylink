using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserMemberAlipaycardQueryResponse.
    /// </summary>
    public class AlipayUserMemberAlipaycardQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝卡片展现信息（缓存）
        /// </summary>
        [JsonPropertyName("alipay_card_cache_data")]
        public AlipayMiniCardData AlipayCardCacheData { get; set; }

        /// <summary>
        /// 支付宝卡片展现信息（实时），展现层数据信息，结构详见具体复杂类型，返回给用户的卡片展现信息包括实时类和缓存类两部分，缓存类是对实时性要求不高的透出内容。实时类是精确信息，直接用于前端展现，缓存类用于存在缓存中，在调用接口超时或者降级时取用。
        /// </summary>
        [JsonPropertyName("alipay_card_real_time_data")]
        public AlipayMiniCardData AlipayCardRealTimeData { get; set; }
    }
}
