using System.Collections.Generic;
using System.Xml.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppBillSearchResponse.
    /// </summary>
    public class AlipayEbppBillSearchResponse : AlipayResponse
    {
        /// <summary>
        /// 已经缓存的的key
        /// </summary>
        [JsonProperty("cachekey")]
        [XmlElement("cachekey")]
        public string Cachekey { get; set; }

        /// <summary>
        /// 实时查询欠费单返回对象
        /// </summary>
        [JsonProperty("inst_bill_info_list")]
        [XmlArray("inst_bill_info_list")]
        [XmlArrayItem("query_inst_bill_info")]
        public List<QueryInstBillInfo> InstBillInfoList { get; set; }
    }
}
