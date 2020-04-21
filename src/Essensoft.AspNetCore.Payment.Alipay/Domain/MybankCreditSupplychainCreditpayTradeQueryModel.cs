using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditSupplychainCreditpayTradeQueryModel Data Structure.
    /// </summary>
    public class MybankCreditSupplychainCreditpayTradeQueryModel : AlipayObject
    {
        /// <summary>
        /// 买方信息
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

        /// <summary>
        /// 网商交易号
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }
    }
}
