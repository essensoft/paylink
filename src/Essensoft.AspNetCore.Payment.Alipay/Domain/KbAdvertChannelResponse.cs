using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbAdvertChannelResponse Data Structure.
    /// </summary>
    public class KbAdvertChannelResponse : AlipayObject
    {
        /// <summary>
        /// 渠道ID
        /// </summary>
        [JsonPropertyName("channel_id")]
        public string ChannelId { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 渠道名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 渠道状态  EFFECTIVE：有效  INVALID：无效
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// OFFLINE：线下推广
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
