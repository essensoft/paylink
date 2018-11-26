using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OpusInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OpusInfo : AlipayObject
    {
        /// <summary>
        /// 展示权重；必须大于等于0；排序规则：权重倒叙;默认值为0
        /// </summary>
        [JsonProperty("display_weight")]
        [XmlElement("display_weight")]
        public string DisplayWeight { get; set; }

        /// <summary>
        /// 外部作品id
        /// </summary>
        [JsonProperty("external_opus_id")]
        [XmlElement("external_opus_id")]
        public string ExternalOpusId { get; set; }

        /// <summary>
        /// 素材id
        /// </summary>
        [JsonProperty("media_id")]
        [XmlElement("media_id")]
        public string MediaId { get; set; }

        /// <summary>
        /// 头图素材type；  枚举类型：PICTURE/VIDEO
        /// </summary>
        [JsonProperty("media_type")]
        [XmlElement("media_type")]
        public string MediaType { get; set; }

        /// <summary>
        /// 素材url
        /// </summary>
        [JsonProperty("media_url")]
        [XmlElement("media_url")]
        public string MediaUrl { get; set; }

        /// <summary>
        /// 作品id
        /// </summary>
        [JsonProperty("opus_id")]
        [XmlElement("opus_id")]
        public string OpusId { get; set; }

        /// <summary>
        /// 素材标题
        /// </summary>
        [JsonProperty("title")]
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
