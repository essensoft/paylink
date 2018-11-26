using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoMycarDataExternalQueryResponse.
    /// </summary>
    public class AlipayEcoMycarDataExternalQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 30
        /// </summary>
        [JsonProperty("external_system_name")]
        [XmlElement("external_system_name")]
        public string ExternalSystemName { get; set; }

        /// <summary>
        /// outter_response
        /// </summary>
        [JsonProperty("query_result")]
        [XmlElement("query_result")]
        public string QueryResult { get; set; }
    }
}
