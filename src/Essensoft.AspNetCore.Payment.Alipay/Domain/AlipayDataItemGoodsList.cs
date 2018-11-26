using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataItemGoodsList Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataItemGoodsList : AlipayObject
    {
        /// <summary>
        /// 单品的描述信息
        /// </summary>
        [JsonProperty("desc")]
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 单品id列表
        /// </summary>
        [JsonProperty("goods_list")]
        [XmlArray("goods_list")]
        [XmlArrayItem("string")]
        public List<string> GoodsList { get; set; }
    }
}
