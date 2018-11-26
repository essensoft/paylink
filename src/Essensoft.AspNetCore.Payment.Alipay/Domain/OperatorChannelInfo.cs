using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OperatorChannelInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OperatorChannelInfo : AlipayObject
    {
        /// <summary>
        /// 渠道编码
        /// </summary>
        [JsonProperty("item_code")]
        [XmlElement("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 渠道描述
        /// </summary>
        [JsonProperty("item_desc")]
        [XmlElement("item_desc")]
        public string ItemDesc { get; set; }

        /// <summary>
        /// 渠道名称
        /// </summary>
        [JsonProperty("item_name")]
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 渠道是否可用
        /// </summary>
        [JsonProperty("item_status")]
        [XmlElement("item_status")]
        public string ItemStatus { get; set; }
    }
}
