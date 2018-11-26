using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenAppYufanlingsanyaowuYufalingsanyaowuQueryResponse.
    /// </summary>
    public class AlipayOpenAppYufanlingsanyaowuYufalingsanyaowuQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 10
        /// </summary>
        [JsonProperty("userid")]
        [XmlElement("userid")]
        public string Userid { get; set; }
    }
}
