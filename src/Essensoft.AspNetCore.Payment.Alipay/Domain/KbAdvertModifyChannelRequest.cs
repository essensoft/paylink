using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbAdvertModifyChannelRequest Data Structure.
    /// </summary>
    [Serializable]
    public class KbAdvertModifyChannelRequest : AlipayObject
    {
        /// <summary>
        /// 渠道ID（渠道创建接口中，返回的channelID）
        /// </summary>
        [JsonProperty("channel_id")]
        [XmlElement("channel_id")]
        public string ChannelId { get; set; }

        /// <summary>
        /// 渠道说明
        /// </summary>
        [JsonProperty("memo")]
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 渠道名称
        /// </summary>
        [JsonProperty("name")]
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
