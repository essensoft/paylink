using System;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayItemGoodsList Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayItemGoodsList : AlipayObject
    {
        /// <summary>
        /// 外部单品的描述信息（此字段暂时无用）
        /// </summary>
        [JsonProperty("desc")]
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 外部单品id列表，传入服务商、商户系统中的商品id。
        /// </summary>
        [JsonProperty("goods_list")]
        [XmlArray("goods_list")]
        [XmlArrayItem("string")]
        public List<string> GoodsList { get; set; }
    }
}
