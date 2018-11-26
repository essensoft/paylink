using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbadvertSmartPromoRequest Data Structure.
    /// </summary>
    [Serializable]
    public class KbadvertSmartPromoRequest : AlipayObject
    {
        /// <summary>
        /// 智能营销分组ID
        /// </summary>
        [JsonProperty("group_id")]
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 智能营销方案ID
        /// </summary>
        [JsonProperty("plan_id")]
        [XmlElement("plan_id")]
        public string PlanId { get; set; }
    }
}
