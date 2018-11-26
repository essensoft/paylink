using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// StaffInfo Data Structure.
    /// </summary>
    [Serializable]
    public class StaffInfo : AlipayObject
    {
        /// <summary>
        /// 支付宝登录账号
        /// </summary>
        [JsonProperty("logon_id")]
        [XmlElement("logon_id")]
        public string LogonId { get; set; }

        /// <summary>
        /// 用户uid
        /// </summary>
        [JsonProperty("user_id")]
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
