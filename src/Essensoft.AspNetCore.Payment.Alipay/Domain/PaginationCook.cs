using System;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PaginationCook Data Structure.
    /// </summary>
    [Serializable]
    public class PaginationCook : AlipayObject
    {
        /// <summary>
        /// 出参列表
        /// </summary>
        [JsonProperty("list")]
        [XmlArray("list")]
        [XmlArrayItem("kbdish_cook_info")]
        public List<KbdishCookInfo> List { get; set; }

        /// <summary>
        /// 表示当前页数
        /// </summary>
        [JsonProperty("page_no")]
        [XmlElement("page_no")]
        public string PageNo { get; set; }

        /// <summary>
        /// 表示每页条数
        /// </summary>
        [JsonProperty("page_size")]
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [JsonProperty("total_count")]
        [XmlElement("total_count")]
        public string TotalCount { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [JsonProperty("total_page")]
        [XmlElement("total_page")]
        public string TotalPage { get; set; }
    }
}
