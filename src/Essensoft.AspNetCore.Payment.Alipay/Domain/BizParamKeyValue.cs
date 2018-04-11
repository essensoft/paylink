using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BizParamKeyValue Data Structure.
    /// </summary>
    [Serializable]
    public class BizParamKeyValue : AlipayObject
    {
        /// <summary>
        /// 参数名key
        /// </summary>
        [JsonProperty("key")]
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 参数值value
        /// </summary>
        [JsonProperty("value")]
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
