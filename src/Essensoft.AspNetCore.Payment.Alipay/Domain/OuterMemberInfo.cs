using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OuterMemberInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OuterMemberInfo : AlipayObject
    {
        /// <summary>
        /// 商户记录的用户信息
        /// </summary>
        [JsonProperty("user_info")]
        [XmlElement("user_info")]
        public string UserInfo { get; set; }
    }
}
