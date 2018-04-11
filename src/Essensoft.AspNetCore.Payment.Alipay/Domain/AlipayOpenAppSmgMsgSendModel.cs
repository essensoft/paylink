using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppSmgMsgSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppSmgMsgSendModel : AlipayObject
    {
        /// <summary>
        /// 5555
        /// </summary>
        [JsonProperty("numberone")]
        [XmlElement("numberone")]
        public string Numberone { get; set; }

        /// <summary>
        /// 22
        /// </summary>
        [JsonProperty("numbertowe")]
        [XmlElement("numbertowe")]
        public string Numbertowe { get; set; }
    }
}
