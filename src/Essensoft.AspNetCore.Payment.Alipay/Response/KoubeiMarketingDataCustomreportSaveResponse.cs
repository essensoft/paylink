using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingDataCustomreportSaveResponse.
    /// </summary>
    public class KoubeiMarketingDataCustomreportSaveResponse : AlipayResponse
    {
        /// <summary>
        /// 自定义报表的规则ID
        /// </summary>
        [JsonProperty("condition_key")]
        [XmlElement("condition_key")]
        public string ConditionKey { get; set; }
    }
}
