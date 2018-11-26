using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppProdmodeProvcityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppProdmodeProvcityQueryModel : AlipayObject
    {
        /// <summary>
        /// 省市编号
        /// </summary>
        [JsonProperty("adcode")]
        [XmlElement("adcode")]
        public string Adcode { get; set; }

        /// <summary>
        /// 查询类型，queryType=1,查询省下面的市信息
        /// </summary>
        [JsonProperty("query_type")]
        [XmlElement("query_type")]
        public string QueryType { get; set; }
    }
}
