using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingToolFengdieActivityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingToolFengdieActivityQueryModel : AlipayObject
    {
        /// <summary>
        /// H5应用的唯一id，调用alipay.marketing.tool.fengdie.activity.create获得
        /// </summary>
        [JsonProperty("activity_id")]
        [XmlElement("activity_id")]
        public long ActivityId { get; set; }
    }
}
