using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppXwbtstabcQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppXwbtstabcQueryModel : AlipayObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("xwbaa")]
        [XmlElement("xwbaa")]
        public string Xwbaa { get; set; }
    }
}
