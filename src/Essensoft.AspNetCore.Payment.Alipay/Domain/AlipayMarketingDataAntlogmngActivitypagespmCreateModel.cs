using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingDataAntlogmngActivitypagespmCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingDataAntlogmngActivitypagespmCreateModel : AlipayObject
    {
        /// <summary>
        /// 活动Id
        /// </summary>
        [JsonProperty("activity_id")]
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 负责人的工号
        /// </summary>
        [JsonProperty("owner")]
        [XmlElement("owner")]
        public string Owner { get; set; }

        /// <summary>
        /// spma位
        /// </summary>
        [JsonProperty("spma")]
        [XmlElement("spma")]
        public string Spma { get; set; }

        /// <summary>
        /// 页面的spmb值code
        /// </summary>
        [JsonProperty("spmb")]
        [XmlElement("spmb")]
        public string Spmb { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("title")]
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 凤蝶页面的url
        /// </summary>
        [JsonProperty("url")]
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
