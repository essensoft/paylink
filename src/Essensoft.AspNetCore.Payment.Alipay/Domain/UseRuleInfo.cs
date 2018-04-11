using System;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// UseRuleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class UseRuleInfo : AlipayObject
    {
        /// <summary>
        /// 适用门店列表
        /// </summary>
        [JsonProperty("suitable_shops")]
        [XmlArray("suitable_shops")]
        [XmlArrayItem("string")]
        public List<string> SuitableShops { get; set; }

        /// <summary>
        /// 核销方式
        /// </summary>
        [JsonProperty("use_mode")]
        [XmlArray("use_mode")]
        [XmlArrayItem("string")]
        public List<string> UseMode { get; set; }
    }
}
