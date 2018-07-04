using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SmartAutomatScene Data Structure.
    /// </summary>
    [Serializable]
    public class SmartAutomatScene : AlipayObject
    {
        /// <summary>
        /// 自助售货机一级场景
        /// </summary>
        [JsonProperty("level_1")]
        [XmlElement("level_1")]
        public string Level1 { get; set; }

        /// <summary>
        /// 自助售货机二级场景
        /// </summary>
        [JsonProperty("level_2")]
        [XmlElement("level_2")]
        public string Level2 { get; set; }
    }
}
