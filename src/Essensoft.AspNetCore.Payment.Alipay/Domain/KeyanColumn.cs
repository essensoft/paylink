using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KeyanColumn Data Structure.
    /// </summary>
    [Serializable]
    public class KeyanColumn : AlipayObject
    {
        /// <summary>
        /// 密码
        /// </summary>
        [JsonProperty("password")]
        [XmlElement("password")]
        public string Password { get; set; }
    }
}
