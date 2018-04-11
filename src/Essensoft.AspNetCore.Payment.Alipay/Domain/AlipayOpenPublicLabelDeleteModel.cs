using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicLabelDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicLabelDeleteModel : AlipayObject
    {
        /// <summary>
        /// 标签id
        /// </summary>
        [JsonProperty("id")]
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
