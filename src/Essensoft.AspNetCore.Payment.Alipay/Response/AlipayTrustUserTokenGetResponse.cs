using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayTrustUserTokenGetResponse.
    /// </summary>
    public class AlipayTrustUserTokenGetResponse : AlipayResponse
    {
        /// <summary>
        /// 访问令牌
        /// </summary>
        [JsonProperty("access_token")]
        [XmlElement("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// 本字段已废弃
        /// </summary>
        [JsonProperty("refresh_token")]
        [XmlElement("refresh_token")]
        public string RefreshToken { get; set; }
    }
}
