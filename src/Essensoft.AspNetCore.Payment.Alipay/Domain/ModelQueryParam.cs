using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ModelQueryParam Data Structure.
    /// </summary>
    [Serializable]
    public class ModelQueryParam : AlipayObject
    {
        /// <summary>
        /// 条件查询参数
        /// </summary>
        [JsonProperty("key")]
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 操作计算符，目前仅支持EQ
        /// </summary>
        [JsonProperty("operate")]
        [XmlElement("operate")]
        public string Operate { get; set; }

        /// <summary>
        /// 查询参数值
        /// </summary>
        [JsonProperty("value")]
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
