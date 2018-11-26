using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingExtData Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingExtData : AlipayObject
    {
        /// <summary>
        /// 复杂模型
        /// </summary>
        [JsonProperty("lbs_info")]
        [XmlElement("lbs_info")]
        public AlipayMarketingIbsInfo LbsInfo { get; set; }

        /// <summary>
        /// 外部uid
        /// </summary>
        [JsonProperty("out_user_id")]
        [XmlElement("out_user_id")]
        public string OutUserId { get; set; }
    }
}
