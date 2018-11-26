using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayTrustUserReportGetResponse.
    /// </summary>
    public class AlipayTrustUserReportGetResponse : AlipayResponse
    {
        /// <summary>
        /// 报告内容，格式详见示例代码
        /// </summary>
        [JsonProperty("report")]
        [XmlElement("report")]
        public string Report { get; set; }
    }
}
