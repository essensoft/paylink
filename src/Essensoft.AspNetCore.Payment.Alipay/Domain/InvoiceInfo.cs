using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InvoiceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceInfo : AlipayObject
    {
        /// <summary>
        /// 开票内容  注：json数组格式
        /// </summary>
        [JsonProperty("details")]
        [XmlElement("details")]
        public string Details { get; set; }

        /// <summary>
        /// 开票关键信息
        /// </summary>
        [JsonProperty("key_info")]
        [XmlElement("key_info")]
        public InvoiceKeyInfo KeyInfo { get; set; }
    }
}
