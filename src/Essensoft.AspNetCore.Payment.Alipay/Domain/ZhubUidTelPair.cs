using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhubUidTelPair Data Structure.
    /// </summary>
    [Serializable]
    public class ZhubUidTelPair : AlipayObject
    {
        /// <summary>
        /// 手机号
        /// </summary>
        [JsonProperty("phone")]
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 支付宝uid
        /// </summary>
        [JsonProperty("user_id")]
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
