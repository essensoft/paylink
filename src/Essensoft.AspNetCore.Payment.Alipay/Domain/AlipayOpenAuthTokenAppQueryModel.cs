using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAuthTokenAppQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAuthTokenAppQueryModel : AlipayObject
    {
        /// <summary>
        /// 应用授权令牌
        /// </summary>
        [JsonProperty("app_auth_token")]
        [XmlElement("app_auth_token")]
        public string AppAuthToken { get; set; }
    }
}
