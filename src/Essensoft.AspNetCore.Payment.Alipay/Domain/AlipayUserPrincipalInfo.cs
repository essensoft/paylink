using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserPrincipalInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserPrincipalInfo : AlipayObject
    {
        /// <summary>
        /// 用户电子邮箱
        /// </summary>
        [JsonProperty("email")]
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 用户的手机号
        /// </summary>
        [JsonProperty("mobile")]
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 支付宝userId
        /// </summary>
        [JsonProperty("user_id")]
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
