using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBossBaseProcessInstanceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossBaseProcessInstanceQueryModel : AlipayObject
    {
        /// <summary>
        /// 流程全局唯一ID
        /// </summary>
        [JsonProperty("puid")]
        [XmlElement("puid")]
        public string Puid { get; set; }
    }
}
