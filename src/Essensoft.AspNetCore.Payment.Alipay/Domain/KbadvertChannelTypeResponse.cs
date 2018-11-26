using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbadvertChannelTypeResponse Data Structure.
    /// </summary>
    [Serializable]
    public class KbadvertChannelTypeResponse : AlipayObject
    {
        /// <summary>
        /// 渠道描述
        /// </summary>
        [JsonProperty("desc")]
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 排序，暂时无用
        /// </summary>
        [JsonProperty("order")]
        [XmlElement("order")]
        public string Order { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [JsonProperty("type")]
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
