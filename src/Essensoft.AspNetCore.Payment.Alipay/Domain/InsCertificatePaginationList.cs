using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InsCertificatePaginationList Data Structure.
    /// </summary>
    [Serializable]
    public class InsCertificatePaginationList : AlipayObject
    {
        /// <summary>
        /// 当前页数
        /// </summary>
        [JsonProperty("current_page")]
        [XmlElement("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 结果列表
        /// </summary>
        [JsonProperty("list")]
        [XmlArray("list")]
        [XmlArrayItem("ins_certificate_api_d_t_o")]
        public List<InsCertificateApiDTO> List { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [JsonProperty("page_size")]
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [JsonProperty("total_count")]
        [XmlElement("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// 全部页数
        /// </summary>
        [JsonProperty("total_page_num")]
        [XmlElement("total_page_num")]
        public long TotalPageNum { get; set; }
    }
}
