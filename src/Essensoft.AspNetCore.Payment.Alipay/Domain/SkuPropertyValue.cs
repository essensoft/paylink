using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SkuPropertyValue Data Structure.
    /// </summary>
    [Serializable]
    public class SkuPropertyValue : AlipayObject
    {
        /// <summary>
        /// 外部sku属性值ID,由外部商户定义
        /// </summary>
        [JsonProperty("out_pv_id")]
        [XmlElement("out_pv_id")]
        public string OutPvId { get; set; }

        /// <summary>
        /// 外部商户sku属性值
        /// </summary>
        [JsonProperty("value")]
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
