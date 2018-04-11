using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingDataCustomreportDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingDataCustomreportDetailQueryModel : AlipayObject
    {
        /// <summary>
        /// 自定义报表的规则KEY
        /// </summary>
        [JsonProperty("condition_key")]
        [XmlElement("condition_key")]
        public string ConditionKey { get; set; }
    }
}
