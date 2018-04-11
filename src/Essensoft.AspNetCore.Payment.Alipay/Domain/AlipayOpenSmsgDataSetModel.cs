using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenSmsgDataSetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSmsgDataSetModel : AlipayObject
    {
        /// <summary>
        /// 测试
        /// </summary>
        [JsonProperty("paramone")]
        [XmlElement("paramone")]
        public string Paramone { get; set; }

        /// <summary>
        /// 测试参数2
        /// </summary>
        [JsonProperty("paramtwo")]
        [XmlElement("paramtwo")]
        public string Paramtwo { get; set; }
    }
}
