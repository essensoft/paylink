using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Option Data Structure.
    /// </summary>
    [Serializable]
    public class Option : AlipayObject
    {
        /// <summary>
        /// 文本，通常用于理解对应的取值
        /// </summary>
        [JsonProperty("text")]
        [XmlElement("text")]
        public string Text { get; set; }

        /// <summary>
        /// 取值，通常使用简单的数字或字符串
        /// </summary>
        [JsonProperty("value")]
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
