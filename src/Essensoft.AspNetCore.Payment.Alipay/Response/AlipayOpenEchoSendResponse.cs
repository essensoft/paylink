using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenEchoSendResponse.
    /// </summary>
    public class AlipayOpenEchoSendResponse : AlipayResponse
    {
        /// <summary>
        /// hello world
        /// </summary>
        [JsonProperty("out_a")]
        [XmlElement("out_a")]
        public string OutA { get; set; }

        /// <summary>
        /// Number
        /// </summary>
        [JsonProperty("out_b")]
        [XmlElement("out_b")]
        public long OutB { get; set; }

        /// <summary>
        /// Price
        /// </summary>
        [JsonProperty("out_c")]
        [XmlElement("out_c")]
        public string OutC { get; set; }

        /// <summary>
        /// hello world
        /// </summary>
        [JsonProperty("word")]
        [XmlElement("word")]
        public string Word { get; set; }
    }
}
