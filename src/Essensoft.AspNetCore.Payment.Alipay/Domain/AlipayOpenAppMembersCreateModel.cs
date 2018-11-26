using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppMembersCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppMembersCreateModel : AlipayObject
    {
        /// <summary>
        /// 支付宝登录账号ID
        /// </summary>
        [JsonProperty("logon_id")]
        [XmlElement("logon_id")]
        public string LogonId { get; set; }

        /// <summary>
        /// 成员的角色类型，DEVELOPER-开发者，EXPERIENCER-体验者
        /// </summary>
        [JsonProperty("role")]
        [XmlElement("role")]
        public string Role { get; set; }
    }
}
