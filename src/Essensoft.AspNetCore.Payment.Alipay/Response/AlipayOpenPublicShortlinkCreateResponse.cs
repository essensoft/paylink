using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicShortlinkCreateResponse.
    /// </summary>
    public class AlipayOpenPublicShortlinkCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 生成的带参推广短链接
        /// </summary>
        [JsonProperty("shortlink")]
        [XmlElement("shortlink")]
        public string Shortlink { get; set; }
    }
}
