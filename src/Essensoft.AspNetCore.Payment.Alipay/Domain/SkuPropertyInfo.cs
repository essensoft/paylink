using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SkuPropertyInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SkuPropertyInfo : AlipayObject
    {
        /// <summary>
        /// sku属性key值,可发邮件到lei.mao@antfin.com,联系支付宝获取已支持的key.支付宝在收到邮件后三个工作日内回复
        /// </summary>
        [JsonProperty("key")]
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 商家sku属性值列表
        /// </summary>
        [JsonProperty("value")]
        [XmlArray("value")]
        [XmlArrayItem("sku_property_value")]
        public List<SkuPropertyValue> Value { get; set; }
    }
}
