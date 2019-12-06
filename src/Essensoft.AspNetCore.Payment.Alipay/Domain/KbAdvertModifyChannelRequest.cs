using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbAdvertModifyChannelRequest Data Structure.
    /// </summary>
    public class KbAdvertModifyChannelRequest : AlipayObject
    {
        /// <summary>
        /// 渠道ID（渠道创建接口中，返回的channelID）
        /// </summary>
        [JsonPropertyName("channel_id")]
        public string ChannelId { get; set; }

        /// <summary>
        /// 渠道说明
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 渠道名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
