using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbAdvertAdvChannelResponse Data Structure.
    /// </summary>
    [Serializable]
    public class KbAdvertAdvChannelResponse : AlipayObject
    {
        /// <summary>
        /// 广告内容模型
        /// </summary>
        [JsonProperty("adv_content_list")]
        [XmlArray("adv_content_list")]
        [XmlArrayItem("kb_advert_adv_content_response")]
        public List<KbAdvertAdvContentResponse> AdvContentList { get; set; }

        /// <summary>
        /// 广告id
        /// </summary>
        [JsonProperty("adv_id")]
        [XmlElement("adv_id")]
        public string AdvId { get; set; }

        /// <summary>
        /// 渠道ID
        /// </summary>
        [JsonProperty("channel_id")]
        [XmlElement("channel_id")]
        public string ChannelId { get; set; }

        /// <summary>
        /// 渠道名称
        /// </summary>
        [JsonProperty("channel_name")]
        [XmlElement("channel_name")]
        public string ChannelName { get; set; }

        /// <summary>
        /// 渠道类型
        /// </summary>
        [JsonProperty("channel_type")]
        [XmlElement("channel_type")]
        public string ChannelType { get; set; }
    }
}
