using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CardFundInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CardFundInfo : AlipayObject
    {
        /// <summary>
        /// 消费资金账户
        /// </summary>
        [JsonProperty("fundaccount")]
        [XmlElement("fundaccount")]
        public string Fundaccount { get; set; }

        /// <summary>
        /// 消费资金类型
        /// </summary>
        [JsonProperty("fundtype")]
        [XmlElement("fundtype")]
        public string Fundtype { get; set; }
    }
}
