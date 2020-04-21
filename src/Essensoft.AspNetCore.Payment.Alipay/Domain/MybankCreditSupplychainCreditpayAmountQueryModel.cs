using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditSupplychainCreditpayAmountQueryModel Data Structure.
    /// </summary>
    public class MybankCreditSupplychainCreditpayAmountQueryModel : AlipayObject
    {
        /// <summary>
        /// 买方信息，这里是ISV的信息
        /// </summary>
        [JsonPropertyName("buyer")]
        public Member Buyer { get; set; }

        /// <summary>
        /// 平台类型
        /// </summary>
        [JsonPropertyName("channel_tag")]
        public string ChannelTag { get; set; }

        /// <summary>
        /// Trace信息
        /// </summary>
        [JsonPropertyName("trace_id")]
        public string TraceId { get; set; }
    }
}
