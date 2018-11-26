using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CardCreditInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CardCreditInfo : AlipayObject
    {
        /// <summary>
        /// 是否允许超扣
        /// </summary>
        [JsonProperty("allowoverpay")]
        [XmlElement("allowoverpay")]
        public string Allowoverpay { get; set; }

        /// <summary>
        /// 超扣额度
        /// </summary>
        [JsonProperty("creditquota")]
        [XmlElement("creditquota")]
        public string Creditquota { get; set; }
    }
}
