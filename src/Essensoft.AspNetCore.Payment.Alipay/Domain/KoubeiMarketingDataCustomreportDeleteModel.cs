using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingDataCustomreportDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingDataCustomreportDeleteModel : AlipayObject
    {
        /// <summary>
        /// 自定义报表规则的KEY
        /// </summary>
        [JsonProperty("condition_key")]
        [XmlElement("condition_key")]
        public string ConditionKey { get; set; }
    }
}
