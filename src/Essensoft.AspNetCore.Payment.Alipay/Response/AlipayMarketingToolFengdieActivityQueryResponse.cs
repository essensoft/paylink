using System.Xml.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingToolFengdieActivityQueryResponse.
    /// </summary>
    public class AlipayMarketingToolFengdieActivityQueryResponse : AlipayResponse
    {
        /// <summary>
        /// H5应用详情
        /// </summary>
        [JsonProperty("activity")]
        [XmlElement("activity")]
        public FengdieActivity Activity { get; set; }
    }
}
