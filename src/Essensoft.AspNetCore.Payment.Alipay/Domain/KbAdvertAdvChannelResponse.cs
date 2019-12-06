using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbAdvertAdvChannelResponse Data Structure.
    /// </summary>
    public class KbAdvertAdvChannelResponse : AlipayObject
    {
        /// <summary>
        /// 广告内容模型
        /// </summary>
        [JsonPropertyName("adv_content_list")]
        public List<KbAdvertAdvContentResponse> AdvContentList { get; set; }

        /// <summary>
        /// 广告id
        /// </summary>
        [JsonPropertyName("adv_id")]
        public string AdvId { get; set; }

        /// <summary>
        /// 渠道ID
        /// </summary>
        [JsonPropertyName("channel_id")]
        public string ChannelId { get; set; }

        /// <summary>
        /// 渠道名称
        /// </summary>
        [JsonPropertyName("channel_name")]
        public string ChannelName { get; set; }

        /// <summary>
        /// 渠道类型
        /// </summary>
        [JsonPropertyName("channel_type")]
        public string ChannelType { get; set; }
    }
}
